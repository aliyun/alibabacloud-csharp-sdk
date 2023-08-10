// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dts20200101.Models;

namespace AlibabaCloud.SDK.Dts20200101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "dts.aliyuncs.com"},
                {"cn-beijing", "dts.aliyuncs.com"},
                {"cn-zhangjiakou", "dts.aliyuncs.com"},
                {"cn-huhehaote", "dts.aliyuncs.com"},
                {"cn-hangzhou", "dts.aliyuncs.com"},
                {"cn-shanghai", "dts.aliyuncs.com"},
                {"cn-shenzhen", "dts.aliyuncs.com"},
                {"cn-hongkong", "dts.aliyuncs.com"},
                {"ap-southeast-1", "dts.aliyuncs.com"},
                {"ap-southeast-2", "dts.aliyuncs.com"},
                {"ap-southeast-3", "dts.aliyuncs.com"},
                {"ap-southeast-5", "dts.aliyuncs.com"},
                {"eu-west-1", "dts.aliyuncs.com"},
                {"us-west-1", "dts.aliyuncs.com"},
                {"us-east-1", "dts.aliyuncs.com"},
                {"eu-central-1", "dts.aliyuncs.com"},
                {"me-east-1", "dts.aliyuncs.com"},
                {"ap-south-1", "dts.aliyuncs.com"},
                {"cn-hangzhou-finance", "dts.aliyuncs.com"},
                {"cn-shanghai-finance-1", "dts.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "dts.aliyuncs.com"},
                {"cn-north-2-gov-1", "dts.aliyuncs.com"},
                {"ap-northeast-2-pop", "dts.aliyuncs.com"},
                {"cn-beijing-finance-1", "dts.aliyuncs.com"},
                {"cn-beijing-finance-pop", "dts.aliyuncs.com"},
                {"cn-beijing-gov-1", "dts.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "dts.aliyuncs.com"},
                {"cn-chengdu", "dts.aliyuncs.com"},
                {"cn-edge-1", "dts.aliyuncs.com"},
                {"cn-fujian", "dts.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "dts.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "dts.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "dts.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "dts.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "dts.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "dts.aliyuncs.com"},
                {"cn-hangzhou-test-306", "dts.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "dts.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "dts.aliyuncs.com"},
                {"cn-qingdao-nebula", "dts.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "dts.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "dts.aliyuncs.com"},
                {"cn-shanghai-inner", "dts.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "dts.aliyuncs.com"},
                {"cn-shenzhen-inner", "dts.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "dts.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "dts.aliyuncs.com"},
                {"cn-wuhan", "dts.aliyuncs.com"},
                {"cn-wulanchabu", "dts.aliyuncs.com"},
                {"cn-yushanfang", "dts.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "dts.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "dts.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "dts.aliyuncs.com"},
                {"eu-west-1-oxs", "dts.aliyuncs.com"},
                {"rus-west-1-pop", "dts.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("dts", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
          * The name of the DTS instance.
          *
          * @param request ConfigureDtsJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ConfigureDtsJobResponse
         */
        public ConfigureDtsJobResponse ConfigureDtsJobWithOptions(ConfigureDtsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Checkpoint))
            {
                query["Checkpoint"] = request.Checkpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCheckConfigure))
            {
                query["DataCheckConfigure"] = request.DataCheckConfigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataInitialization))
            {
                query["DataInitialization"] = request.DataInitialization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSynchronization))
            {
                query["DataSynchronization"] = request.DataSynchronization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                query["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayNotice))
            {
                query["DelayNotice"] = request.DelayNotice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayPhone))
            {
                query["DelayPhone"] = request.DelayPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayRuleTime))
            {
                query["DelayRuleTime"] = request.DelayRuleTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointDataBaseName))
            {
                query["DestinationEndpointDataBaseName"] = request.DestinationEndpointDataBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointEngineName))
            {
                query["DestinationEndpointEngineName"] = request.DestinationEndpointEngineName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointOwnerID))
            {
                query["DestinationEndpointOwnerID"] = request.DestinationEndpointOwnerID;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointRole))
            {
                query["DestinationEndpointRole"] = request.DestinationEndpointRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointUserName))
            {
                query["DestinationEndpointUserName"] = request.DestinationEndpointUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisasterRecoveryJob))
            {
                query["DisasterRecoveryJob"] = request.DisasterRecoveryJob;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsBisLabel))
            {
                query["DtsBisLabel"] = request.DtsBisLabel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobName))
            {
                query["DtsJobName"] = request.DtsJobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorNotice))
            {
                query["ErrorNotice"] = request.ErrorNotice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorPhone))
            {
                query["ErrorPhone"] = request.ErrorPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileOssUrl))
            {
                query["FileOssUrl"] = request.FileOssUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointDatabaseName))
            {
                query["SourceEndpointDatabaseName"] = request.SourceEndpointDatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointEngineName))
            {
                query["SourceEndpointEngineName"] = request.SourceEndpointEngineName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointOwnerID))
            {
                query["SourceEndpointOwnerID"] = request.SourceEndpointOwnerID;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointRole))
            {
                query["SourceEndpointRole"] = request.SourceEndpointRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointUserName))
            {
                query["SourceEndpointUserName"] = request.SourceEndpointUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointVSwitchID))
            {
                query["SourceEndpointVSwitchID"] = request.SourceEndpointVSwitchID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructureInitialization))
            {
                query["StructureInitialization"] = request.StructureInitialization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbList))
            {
                body["DbList"] = request.DbList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reserve))
            {
                body["Reserve"] = request.Reserve;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureDtsJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureDtsJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The name of the DTS instance.
          *
          * @param request ConfigureDtsJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ConfigureDtsJobResponse
         */
        public async Task<ConfigureDtsJobResponse> ConfigureDtsJobWithOptionsAsync(ConfigureDtsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Checkpoint))
            {
                query["Checkpoint"] = request.Checkpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCheckConfigure))
            {
                query["DataCheckConfigure"] = request.DataCheckConfigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataInitialization))
            {
                query["DataInitialization"] = request.DataInitialization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSynchronization))
            {
                query["DataSynchronization"] = request.DataSynchronization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                query["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayNotice))
            {
                query["DelayNotice"] = request.DelayNotice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayPhone))
            {
                query["DelayPhone"] = request.DelayPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayRuleTime))
            {
                query["DelayRuleTime"] = request.DelayRuleTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointDataBaseName))
            {
                query["DestinationEndpointDataBaseName"] = request.DestinationEndpointDataBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointEngineName))
            {
                query["DestinationEndpointEngineName"] = request.DestinationEndpointEngineName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointOwnerID))
            {
                query["DestinationEndpointOwnerID"] = request.DestinationEndpointOwnerID;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointRole))
            {
                query["DestinationEndpointRole"] = request.DestinationEndpointRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointUserName))
            {
                query["DestinationEndpointUserName"] = request.DestinationEndpointUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisasterRecoveryJob))
            {
                query["DisasterRecoveryJob"] = request.DisasterRecoveryJob;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsBisLabel))
            {
                query["DtsBisLabel"] = request.DtsBisLabel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobName))
            {
                query["DtsJobName"] = request.DtsJobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorNotice))
            {
                query["ErrorNotice"] = request.ErrorNotice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorPhone))
            {
                query["ErrorPhone"] = request.ErrorPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileOssUrl))
            {
                query["FileOssUrl"] = request.FileOssUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointDatabaseName))
            {
                query["SourceEndpointDatabaseName"] = request.SourceEndpointDatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointEngineName))
            {
                query["SourceEndpointEngineName"] = request.SourceEndpointEngineName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointOwnerID))
            {
                query["SourceEndpointOwnerID"] = request.SourceEndpointOwnerID;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointRole))
            {
                query["SourceEndpointRole"] = request.SourceEndpointRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointUserName))
            {
                query["SourceEndpointUserName"] = request.SourceEndpointUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointVSwitchID))
            {
                query["SourceEndpointVSwitchID"] = request.SourceEndpointVSwitchID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructureInitialization))
            {
                query["StructureInitialization"] = request.StructureInitialization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbList))
            {
                body["DbList"] = request.DbList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reserve))
            {
                body["Reserve"] = request.Reserve;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureDtsJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureDtsJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The name of the DTS instance.
          *
          * @param request ConfigureDtsJobRequest
          * @return ConfigureDtsJobResponse
         */
        public ConfigureDtsJobResponse ConfigureDtsJob(ConfigureDtsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigureDtsJobWithOptions(request, runtime);
        }

        /**
          * The name of the DTS instance.
          *
          * @param request ConfigureDtsJobRequest
          * @return ConfigureDtsJobResponse
         */
        public async Task<ConfigureDtsJobResponse> ConfigureDtsJobAsync(ConfigureDtsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigureDtsJobWithOptionsAsync(request, runtime);
        }

        public ConfigureDtsJobResponse ConfigureDtsJobAdvance(ConfigureDtsJobAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "Dts",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = null;
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            ConfigureDtsJobRequest configureDtsJobReq = new ConfigureDtsJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, configureDtsJobReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileOssUrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileOssUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                configureDtsJobReq.FileOssUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            ConfigureDtsJobResponse configureDtsJobResp = ConfigureDtsJobWithOptions(configureDtsJobReq, runtime);
            return configureDtsJobResp;
        }

        public async Task<ConfigureDtsJobResponse> ConfigureDtsJobAdvanceAsync(ConfigureDtsJobAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "Dts",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = null;
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            ConfigureDtsJobRequest configureDtsJobReq = new ConfigureDtsJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, configureDtsJobReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileOssUrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileOssUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                configureDtsJobReq.FileOssUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            ConfigureDtsJobResponse configureDtsJobResp = await ConfigureDtsJobWithOptionsAsync(configureDtsJobReq, runtime);
            return configureDtsJobResp;
        }

        /**
          * After you call this operation to configure a data migration task, the task will be automatically started. You do not need to call the [StartMigrationJob](~~49429~~) operation to start the task.
          * A data migration task may fail to be started due to precheck failures. You can call the [DescribeMigrationJobStatus](~~49433~~) operation to query the error messages about precheck failures. Then, you can fix the issue based on the error messages. After you fix the issue, you must call the [StartMigrationJob](~~49429~~) operation to restart the data migration task.
          *
          * @param request ConfigureMigrationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ConfigureMigrationJobResponse
         */
        public ConfigureMigrationJobResponse ConfigureMigrationJobWithOptions(ConfigureMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Checkpoint))
            {
                query["Checkpoint"] = request.Checkpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobName))
            {
                query["MigrationJobName"] = request.MigrationJobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationReserved))
            {
                query["MigrationReserved"] = request.MigrationReserved;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpoint))
            {
                query["DestinationEndpoint"] = request.DestinationEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationMode))
            {
                query["MigrationMode"] = request.MigrationMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpoint))
            {
                query["SourceEndpoint"] = request.SourceEndpoint;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationObject))
            {
                body["MigrationObject"] = request.MigrationObject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureMigrationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureMigrationJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * After you call this operation to configure a data migration task, the task will be automatically started. You do not need to call the [StartMigrationJob](~~49429~~) operation to start the task.
          * A data migration task may fail to be started due to precheck failures. You can call the [DescribeMigrationJobStatus](~~49433~~) operation to query the error messages about precheck failures. Then, you can fix the issue based on the error messages. After you fix the issue, you must call the [StartMigrationJob](~~49429~~) operation to restart the data migration task.
          *
          * @param request ConfigureMigrationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ConfigureMigrationJobResponse
         */
        public async Task<ConfigureMigrationJobResponse> ConfigureMigrationJobWithOptionsAsync(ConfigureMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Checkpoint))
            {
                query["Checkpoint"] = request.Checkpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobName))
            {
                query["MigrationJobName"] = request.MigrationJobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationReserved))
            {
                query["MigrationReserved"] = request.MigrationReserved;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpoint))
            {
                query["DestinationEndpoint"] = request.DestinationEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationMode))
            {
                query["MigrationMode"] = request.MigrationMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpoint))
            {
                query["SourceEndpoint"] = request.SourceEndpoint;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationObject))
            {
                body["MigrationObject"] = request.MigrationObject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureMigrationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureMigrationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * After you call this operation to configure a data migration task, the task will be automatically started. You do not need to call the [StartMigrationJob](~~49429~~) operation to start the task.
          * A data migration task may fail to be started due to precheck failures. You can call the [DescribeMigrationJobStatus](~~49433~~) operation to query the error messages about precheck failures. Then, you can fix the issue based on the error messages. After you fix the issue, you must call the [StartMigrationJob](~~49429~~) operation to restart the data migration task.
          *
          * @param request ConfigureMigrationJobRequest
          * @return ConfigureMigrationJobResponse
         */
        public ConfigureMigrationJobResponse ConfigureMigrationJob(ConfigureMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigureMigrationJobWithOptions(request, runtime);
        }

        /**
          * After you call this operation to configure a data migration task, the task will be automatically started. You do not need to call the [StartMigrationJob](~~49429~~) operation to start the task.
          * A data migration task may fail to be started due to precheck failures. You can call the [DescribeMigrationJobStatus](~~49433~~) operation to query the error messages about precheck failures. Then, you can fix the issue based on the error messages. After you fix the issue, you must call the [StartMigrationJob](~~49429~~) operation to restart the data migration task.
          *
          * @param request ConfigureMigrationJobRequest
          * @return ConfigureMigrationJobResponse
         */
        public async Task<ConfigureMigrationJobResponse> ConfigureMigrationJobAsync(ConfigureMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigureMigrationJobWithOptionsAsync(request, runtime);
        }

        public ConfigureMigrationJobAlertResponse ConfigureMigrationJobAlertWithOptions(ConfigureMigrationJobAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayAlertPhone))
            {
                query["DelayAlertPhone"] = request.DelayAlertPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayAlertStatus))
            {
                query["DelayAlertStatus"] = request.DelayAlertStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayOverSeconds))
            {
                query["DelayOverSeconds"] = request.DelayOverSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorAlertPhone))
            {
                query["ErrorAlertPhone"] = request.ErrorAlertPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorAlertStatus))
            {
                query["ErrorAlertStatus"] = request.ErrorAlertStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "ConfigureMigrationJobAlert",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureMigrationJobAlertResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ConfigureMigrationJobAlertResponse> ConfigureMigrationJobAlertWithOptionsAsync(ConfigureMigrationJobAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayAlertPhone))
            {
                query["DelayAlertPhone"] = request.DelayAlertPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayAlertStatus))
            {
                query["DelayAlertStatus"] = request.DelayAlertStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayOverSeconds))
            {
                query["DelayOverSeconds"] = request.DelayOverSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorAlertPhone))
            {
                query["ErrorAlertPhone"] = request.ErrorAlertPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorAlertStatus))
            {
                query["ErrorAlertStatus"] = request.ErrorAlertStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "ConfigureMigrationJobAlert",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureMigrationJobAlertResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ConfigureMigrationJobAlertResponse ConfigureMigrationJobAlert(ConfigureMigrationJobAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigureMigrationJobAlertWithOptions(request, runtime);
        }

        public async Task<ConfigureMigrationJobAlertResponse> ConfigureMigrationJobAlertAsync(ConfigureMigrationJobAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigureMigrationJobAlertWithOptionsAsync(request, runtime);
        }

        public ConfigureSubscriptionResponse ConfigureSubscriptionWithOptions(ConfigureSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Checkpoint))
            {
                query["Checkpoint"] = request.Checkpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbList))
            {
                query["DbList"] = request.DbList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                query["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayNotice))
            {
                query["DelayNotice"] = request.DelayNotice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayPhone))
            {
                query["DelayPhone"] = request.DelayPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayRuleTime))
            {
                query["DelayRuleTime"] = request.DelayRuleTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsBisLabel))
            {
                query["DtsBisLabel"] = request.DtsBisLabel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobName))
            {
                query["DtsJobName"] = request.DtsJobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorNotice))
            {
                query["ErrorNotice"] = request.ErrorNotice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorPhone))
            {
                query["ErrorPhone"] = request.ErrorPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reserve))
            {
                query["Reserve"] = request.Reserve;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointDatabaseName))
            {
                query["SourceEndpointDatabaseName"] = request.SourceEndpointDatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointEngineName))
            {
                query["SourceEndpointEngineName"] = request.SourceEndpointEngineName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointOwnerID))
            {
                query["SourceEndpointOwnerID"] = request.SourceEndpointOwnerID;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointRole))
            {
                query["SourceEndpointRole"] = request.SourceEndpointRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointUserName))
            {
                query["SourceEndpointUserName"] = request.SourceEndpointUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionDataTypeDDL))
            {
                query["SubscriptionDataTypeDDL"] = request.SubscriptionDataTypeDDL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionDataTypeDML))
            {
                query["SubscriptionDataTypeDML"] = request.SubscriptionDataTypeDML;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceNetworkType))
            {
                query["SubscriptionInstanceNetworkType"] = request.SubscriptionInstanceNetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceVPCId))
            {
                query["SubscriptionInstanceVPCId"] = request.SubscriptionInstanceVPCId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceVSwitchId))
            {
                query["SubscriptionInstanceVSwitchId"] = request.SubscriptionInstanceVSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureSubscription",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ConfigureSubscriptionResponse> ConfigureSubscriptionWithOptionsAsync(ConfigureSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Checkpoint))
            {
                query["Checkpoint"] = request.Checkpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbList))
            {
                query["DbList"] = request.DbList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                query["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayNotice))
            {
                query["DelayNotice"] = request.DelayNotice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayPhone))
            {
                query["DelayPhone"] = request.DelayPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayRuleTime))
            {
                query["DelayRuleTime"] = request.DelayRuleTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsBisLabel))
            {
                query["DtsBisLabel"] = request.DtsBisLabel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobName))
            {
                query["DtsJobName"] = request.DtsJobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorNotice))
            {
                query["ErrorNotice"] = request.ErrorNotice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorPhone))
            {
                query["ErrorPhone"] = request.ErrorPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reserve))
            {
                query["Reserve"] = request.Reserve;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointDatabaseName))
            {
                query["SourceEndpointDatabaseName"] = request.SourceEndpointDatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointEngineName))
            {
                query["SourceEndpointEngineName"] = request.SourceEndpointEngineName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointOwnerID))
            {
                query["SourceEndpointOwnerID"] = request.SourceEndpointOwnerID;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointRole))
            {
                query["SourceEndpointRole"] = request.SourceEndpointRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointUserName))
            {
                query["SourceEndpointUserName"] = request.SourceEndpointUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionDataTypeDDL))
            {
                query["SubscriptionDataTypeDDL"] = request.SubscriptionDataTypeDDL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionDataTypeDML))
            {
                query["SubscriptionDataTypeDML"] = request.SubscriptionDataTypeDML;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceNetworkType))
            {
                query["SubscriptionInstanceNetworkType"] = request.SubscriptionInstanceNetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceVPCId))
            {
                query["SubscriptionInstanceVPCId"] = request.SubscriptionInstanceVPCId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceVSwitchId))
            {
                query["SubscriptionInstanceVSwitchId"] = request.SubscriptionInstanceVSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureSubscription",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ConfigureSubscriptionResponse ConfigureSubscription(ConfigureSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigureSubscriptionWithOptions(request, runtime);
        }

        public async Task<ConfigureSubscriptionResponse> ConfigureSubscriptionAsync(ConfigureSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigureSubscriptionWithOptionsAsync(request, runtime);
        }

        /**
          * The operation that you want to perform. Set the value to **ConfigureSubscriptionInstance**.
          *
          * @param request ConfigureSubscriptionInstanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ConfigureSubscriptionInstanceResponse
         */
        public ConfigureSubscriptionInstanceResponse ConfigureSubscriptionInstanceWithOptions(ConfigureSubscriptionInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceName))
            {
                query["SubscriptionInstanceName"] = request.SubscriptionInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceNetworkType))
            {
                query["SubscriptionInstanceNetworkType"] = request.SubscriptionInstanceNetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpoint))
            {
                query["SourceEndpoint"] = request.SourceEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionDataType))
            {
                query["SubscriptionDataType"] = request.SubscriptionDataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstance))
            {
                query["SubscriptionInstance"] = request.SubscriptionInstance;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionObject))
            {
                body["SubscriptionObject"] = request.SubscriptionObject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureSubscriptionInstance",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureSubscriptionInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The operation that you want to perform. Set the value to **ConfigureSubscriptionInstance**.
          *
          * @param request ConfigureSubscriptionInstanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ConfigureSubscriptionInstanceResponse
         */
        public async Task<ConfigureSubscriptionInstanceResponse> ConfigureSubscriptionInstanceWithOptionsAsync(ConfigureSubscriptionInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceName))
            {
                query["SubscriptionInstanceName"] = request.SubscriptionInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceNetworkType))
            {
                query["SubscriptionInstanceNetworkType"] = request.SubscriptionInstanceNetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpoint))
            {
                query["SourceEndpoint"] = request.SourceEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionDataType))
            {
                query["SubscriptionDataType"] = request.SubscriptionDataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstance))
            {
                query["SubscriptionInstance"] = request.SubscriptionInstance;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionObject))
            {
                body["SubscriptionObject"] = request.SubscriptionObject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureSubscriptionInstance",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureSubscriptionInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The operation that you want to perform. Set the value to **ConfigureSubscriptionInstance**.
          *
          * @param request ConfigureSubscriptionInstanceRequest
          * @return ConfigureSubscriptionInstanceResponse
         */
        public ConfigureSubscriptionInstanceResponse ConfigureSubscriptionInstance(ConfigureSubscriptionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigureSubscriptionInstanceWithOptions(request, runtime);
        }

        /**
          * The operation that you want to perform. Set the value to **ConfigureSubscriptionInstance**.
          *
          * @param request ConfigureSubscriptionInstanceRequest
          * @return ConfigureSubscriptionInstanceResponse
         */
        public async Task<ConfigureSubscriptionInstanceResponse> ConfigureSubscriptionInstanceAsync(ConfigureSubscriptionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigureSubscriptionInstanceWithOptionsAsync(request, runtime);
        }

        public ConfigureSubscriptionInstanceAlertResponse ConfigureSubscriptionInstanceAlertWithOptions(ConfigureSubscriptionInstanceAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayAlertPhone))
            {
                query["DelayAlertPhone"] = request.DelayAlertPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayAlertStatus))
            {
                query["DelayAlertStatus"] = request.DelayAlertStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayOverSeconds))
            {
                query["DelayOverSeconds"] = request.DelayOverSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorAlertPhone))
            {
                query["ErrorAlertPhone"] = request.ErrorAlertPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorAlertStatus))
            {
                query["ErrorAlertStatus"] = request.ErrorAlertStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureSubscriptionInstanceAlert",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureSubscriptionInstanceAlertResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ConfigureSubscriptionInstanceAlertResponse> ConfigureSubscriptionInstanceAlertWithOptionsAsync(ConfigureSubscriptionInstanceAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayAlertPhone))
            {
                query["DelayAlertPhone"] = request.DelayAlertPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayAlertStatus))
            {
                query["DelayAlertStatus"] = request.DelayAlertStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayOverSeconds))
            {
                query["DelayOverSeconds"] = request.DelayOverSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorAlertPhone))
            {
                query["ErrorAlertPhone"] = request.ErrorAlertPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorAlertStatus))
            {
                query["ErrorAlertStatus"] = request.ErrorAlertStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureSubscriptionInstanceAlert",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureSubscriptionInstanceAlertResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ConfigureSubscriptionInstanceAlertResponse ConfigureSubscriptionInstanceAlert(ConfigureSubscriptionInstanceAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigureSubscriptionInstanceAlertWithOptions(request, runtime);
        }

        public async Task<ConfigureSubscriptionInstanceAlertResponse> ConfigureSubscriptionInstanceAlertAsync(ConfigureSubscriptionInstanceAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigureSubscriptionInstanceAlertWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, you must call the [CreateSynchronizationJob](~~49446~~) operation to create a data synchronization instance.
          * > 
          * *   After you call this operation to configure a data synchronization task, the task will be automatically started and prechecked. You do not need to call the [StartSynchronizationJob](~~49448~~) operation to start the task.
          * *   A data synchronization task may fail to be started due to precheck failures. You can call the [DescribeSynchronizationJobStatus](~~49453~~) operation to query the status of the task. Then, you can change parameter settings based on the error messages about the precheck failures. After you fix the issue, you must call the [StartSynchronizationJob](~~49448~~) operation to restart the data synchronization task.
          *
          * @param request ConfigureSynchronizationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ConfigureSynchronizationJobResponse
         */
        public ConfigureSynchronizationJobResponse ConfigureSynchronizationJobWithOptions(ConfigureSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Checkpoint))
            {
                query["Checkpoint"] = request.Checkpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataInitialization))
            {
                query["DataInitialization"] = request.DataInitialization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationReserved))
            {
                query["MigrationReserved"] = request.MigrationReserved;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructureInitialization))
            {
                query["StructureInitialization"] = request.StructureInitialization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobName))
            {
                query["SynchronizationJobName"] = request.SynchronizationJobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpoint))
            {
                query["DestinationEndpoint"] = request.DestinationEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionKey))
            {
                query["PartitionKey"] = request.PartitionKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpoint))
            {
                query["SourceEndpoint"] = request.SourceEndpoint;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationObjects))
            {
                body["SynchronizationObjects"] = request.SynchronizationObjects;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureSynchronizationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureSynchronizationJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, you must call the [CreateSynchronizationJob](~~49446~~) operation to create a data synchronization instance.
          * > 
          * *   After you call this operation to configure a data synchronization task, the task will be automatically started and prechecked. You do not need to call the [StartSynchronizationJob](~~49448~~) operation to start the task.
          * *   A data synchronization task may fail to be started due to precheck failures. You can call the [DescribeSynchronizationJobStatus](~~49453~~) operation to query the status of the task. Then, you can change parameter settings based on the error messages about the precheck failures. After you fix the issue, you must call the [StartSynchronizationJob](~~49448~~) operation to restart the data synchronization task.
          *
          * @param request ConfigureSynchronizationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ConfigureSynchronizationJobResponse
         */
        public async Task<ConfigureSynchronizationJobResponse> ConfigureSynchronizationJobWithOptionsAsync(ConfigureSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Checkpoint))
            {
                query["Checkpoint"] = request.Checkpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataInitialization))
            {
                query["DataInitialization"] = request.DataInitialization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationReserved))
            {
                query["MigrationReserved"] = request.MigrationReserved;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructureInitialization))
            {
                query["StructureInitialization"] = request.StructureInitialization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobName))
            {
                query["SynchronizationJobName"] = request.SynchronizationJobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpoint))
            {
                query["DestinationEndpoint"] = request.DestinationEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionKey))
            {
                query["PartitionKey"] = request.PartitionKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpoint))
            {
                query["SourceEndpoint"] = request.SourceEndpoint;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationObjects))
            {
                body["SynchronizationObjects"] = request.SynchronizationObjects;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureSynchronizationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureSynchronizationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, you must call the [CreateSynchronizationJob](~~49446~~) operation to create a data synchronization instance.
          * > 
          * *   After you call this operation to configure a data synchronization task, the task will be automatically started and prechecked. You do not need to call the [StartSynchronizationJob](~~49448~~) operation to start the task.
          * *   A data synchronization task may fail to be started due to precheck failures. You can call the [DescribeSynchronizationJobStatus](~~49453~~) operation to query the status of the task. Then, you can change parameter settings based on the error messages about the precheck failures. After you fix the issue, you must call the [StartSynchronizationJob](~~49448~~) operation to restart the data synchronization task.
          *
          * @param request ConfigureSynchronizationJobRequest
          * @return ConfigureSynchronizationJobResponse
         */
        public ConfigureSynchronizationJobResponse ConfigureSynchronizationJob(ConfigureSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigureSynchronizationJobWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, you must call the [CreateSynchronizationJob](~~49446~~) operation to create a data synchronization instance.
          * > 
          * *   After you call this operation to configure a data synchronization task, the task will be automatically started and prechecked. You do not need to call the [StartSynchronizationJob](~~49448~~) operation to start the task.
          * *   A data synchronization task may fail to be started due to precheck failures. You can call the [DescribeSynchronizationJobStatus](~~49453~~) operation to query the status of the task. Then, you can change parameter settings based on the error messages about the precheck failures. After you fix the issue, you must call the [StartSynchronizationJob](~~49448~~) operation to restart the data synchronization task.
          *
          * @param request ConfigureSynchronizationJobRequest
          * @return ConfigureSynchronizationJobResponse
         */
        public async Task<ConfigureSynchronizationJobResponse> ConfigureSynchronizationJobAsync(ConfigureSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigureSynchronizationJobWithOptionsAsync(request, runtime);
        }

        public ConfigureSynchronizationJobAlertResponse ConfigureSynchronizationJobAlertWithOptions(ConfigureSynchronizationJobAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayAlertPhone))
            {
                query["DelayAlertPhone"] = request.DelayAlertPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayAlertStatus))
            {
                query["DelayAlertStatus"] = request.DelayAlertStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayOverSeconds))
            {
                query["DelayOverSeconds"] = request.DelayOverSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorAlertPhone))
            {
                query["ErrorAlertPhone"] = request.ErrorAlertPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorAlertStatus))
            {
                query["ErrorAlertStatus"] = request.ErrorAlertStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureSynchronizationJobAlert",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureSynchronizationJobAlertResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ConfigureSynchronizationJobAlertResponse> ConfigureSynchronizationJobAlertWithOptionsAsync(ConfigureSynchronizationJobAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayAlertPhone))
            {
                query["DelayAlertPhone"] = request.DelayAlertPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayAlertStatus))
            {
                query["DelayAlertStatus"] = request.DelayAlertStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayOverSeconds))
            {
                query["DelayOverSeconds"] = request.DelayOverSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorAlertPhone))
            {
                query["ErrorAlertPhone"] = request.ErrorAlertPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorAlertStatus))
            {
                query["ErrorAlertStatus"] = request.ErrorAlertStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureSynchronizationJobAlert",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureSynchronizationJobAlertResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ConfigureSynchronizationJobAlertResponse ConfigureSynchronizationJobAlert(ConfigureSynchronizationJobAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigureSynchronizationJobAlertWithOptions(request, runtime);
        }

        public async Task<ConfigureSynchronizationJobAlertResponse> ConfigureSynchronizationJobAlertAsync(ConfigureSynchronizationJobAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigureSynchronizationJobAlertWithOptionsAsync(request, runtime);
        }

        /**
          * When you use Data Transmission Service (DTS) to synchronize data, other data sources may write data to the destination instance. In this case, data may become inconsistent between the source and destination instances. To ensure data consistency, you can enable image matching.
          * After you call this operation, you can call the [DescribeSynchronizationJobReplicatorCompare](~~199183~~) operation to verify whether image matching is enabled for the data synchronization instance.
          *
          * @param request ConfigureSynchronizationJobReplicatorCompareRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ConfigureSynchronizationJobReplicatorCompareResponse
         */
        public ConfigureSynchronizationJobReplicatorCompareResponse ConfigureSynchronizationJobReplicatorCompareWithOptions(ConfigureSynchronizationJobReplicatorCompareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationReplicatorCompareEnable))
            {
                query["SynchronizationReplicatorCompareEnable"] = request.SynchronizationReplicatorCompareEnable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureSynchronizationJobReplicatorCompare",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureSynchronizationJobReplicatorCompareResponse>(CallApi(params_, req, runtime));
        }

        /**
          * When you use Data Transmission Service (DTS) to synchronize data, other data sources may write data to the destination instance. In this case, data may become inconsistent between the source and destination instances. To ensure data consistency, you can enable image matching.
          * After you call this operation, you can call the [DescribeSynchronizationJobReplicatorCompare](~~199183~~) operation to verify whether image matching is enabled for the data synchronization instance.
          *
          * @param request ConfigureSynchronizationJobReplicatorCompareRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ConfigureSynchronizationJobReplicatorCompareResponse
         */
        public async Task<ConfigureSynchronizationJobReplicatorCompareResponse> ConfigureSynchronizationJobReplicatorCompareWithOptionsAsync(ConfigureSynchronizationJobReplicatorCompareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationReplicatorCompareEnable))
            {
                query["SynchronizationReplicatorCompareEnable"] = request.SynchronizationReplicatorCompareEnable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureSynchronizationJobReplicatorCompare",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureSynchronizationJobReplicatorCompareResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * When you use Data Transmission Service (DTS) to synchronize data, other data sources may write data to the destination instance. In this case, data may become inconsistent between the source and destination instances. To ensure data consistency, you can enable image matching.
          * After you call this operation, you can call the [DescribeSynchronizationJobReplicatorCompare](~~199183~~) operation to verify whether image matching is enabled for the data synchronization instance.
          *
          * @param request ConfigureSynchronizationJobReplicatorCompareRequest
          * @return ConfigureSynchronizationJobReplicatorCompareResponse
         */
        public ConfigureSynchronizationJobReplicatorCompareResponse ConfigureSynchronizationJobReplicatorCompare(ConfigureSynchronizationJobReplicatorCompareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigureSynchronizationJobReplicatorCompareWithOptions(request, runtime);
        }

        /**
          * When you use Data Transmission Service (DTS) to synchronize data, other data sources may write data to the destination instance. In this case, data may become inconsistent between the source and destination instances. To ensure data consistency, you can enable image matching.
          * After you call this operation, you can call the [DescribeSynchronizationJobReplicatorCompare](~~199183~~) operation to verify whether image matching is enabled for the data synchronization instance.
          *
          * @param request ConfigureSynchronizationJobReplicatorCompareRequest
          * @return ConfigureSynchronizationJobReplicatorCompareResponse
         */
        public async Task<ConfigureSynchronizationJobReplicatorCompareResponse> ConfigureSynchronizationJobReplicatorCompareAsync(ConfigureSynchronizationJobReplicatorCompareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigureSynchronizationJobReplicatorCompareWithOptionsAsync(request, runtime);
        }

        public CountJobByConditionResponse CountJobByConditionWithOptions(CountJobByConditionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestDbType))
            {
                query["DestDbType"] = request.DestDbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDbType))
            {
                query["SrcDbType"] = request.SrcDbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "CountJobByCondition",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CountJobByConditionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CountJobByConditionResponse> CountJobByConditionWithOptionsAsync(CountJobByConditionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestDbType))
            {
                query["DestDbType"] = request.DestDbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDbType))
            {
                query["SrcDbType"] = request.SrcDbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "CountJobByCondition",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CountJobByConditionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CountJobByConditionResponse CountJobByCondition(CountJobByConditionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CountJobByConditionWithOptions(request, runtime);
        }

        public async Task<CountJobByConditionResponse> CountJobByConditionAsync(CountJobByConditionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CountJobByConditionWithOptionsAsync(request, runtime);
        }

        public CreateConsumerChannelResponse CreateConsumerChannelWithOptions(CreateConsumerChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupName))
            {
                query["ConsumerGroupName"] = request.ConsumerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupPassword))
            {
                query["ConsumerGroupPassword"] = request.ConsumerGroupPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupUserName))
            {
                query["ConsumerGroupUserName"] = request.ConsumerGroupUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
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
                Action = "CreateConsumerChannel",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConsumerChannelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateConsumerChannelResponse> CreateConsumerChannelWithOptionsAsync(CreateConsumerChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupName))
            {
                query["ConsumerGroupName"] = request.ConsumerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupPassword))
            {
                query["ConsumerGroupPassword"] = request.ConsumerGroupPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupUserName))
            {
                query["ConsumerGroupUserName"] = request.ConsumerGroupUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
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
                Action = "CreateConsumerChannel",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConsumerChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateConsumerChannelResponse CreateConsumerChannel(CreateConsumerChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateConsumerChannelWithOptions(request, runtime);
        }

        public async Task<CreateConsumerChannelResponse> CreateConsumerChannelAsync(CreateConsumerChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateConsumerChannelWithOptionsAsync(request, runtime);
        }

        public CreateConsumerGroupResponse CreateConsumerGroupWithOptions(CreateConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupName))
            {
                query["ConsumerGroupName"] = request.ConsumerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupPassword))
            {
                query["ConsumerGroupPassword"] = request.ConsumerGroupPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupUserName))
            {
                query["ConsumerGroupUserName"] = request.ConsumerGroupUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConsumerGroup",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConsumerGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateConsumerGroupResponse> CreateConsumerGroupWithOptionsAsync(CreateConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupName))
            {
                query["ConsumerGroupName"] = request.ConsumerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupPassword))
            {
                query["ConsumerGroupPassword"] = request.ConsumerGroupPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupUserName))
            {
                query["ConsumerGroupUserName"] = request.ConsumerGroupUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConsumerGroup",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConsumerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateConsumerGroupResponse CreateConsumerGroup(CreateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateConsumerGroupWithOptions(request, runtime);
        }

        public async Task<CreateConsumerGroupResponse> CreateConsumerGroupAsync(CreateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateConsumerGroupWithOptionsAsync(request, runtime);
        }

        public CreateDedicatedClusterMonitorRuleResponse CreateDedicatedClusterMonitorRuleWithOptions(CreateDedicatedClusterMonitorRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuAlarmThreshold))
            {
                query["CpuAlarmThreshold"] = request.CpuAlarmThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                query["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskAlarmThreshold))
            {
                query["DiskAlarmThreshold"] = request.DiskAlarmThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuAlarmThreshold))
            {
                query["DuAlarmThreshold"] = request.DuAlarmThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemAlarmThreshold))
            {
                query["MemAlarmThreshold"] = request.MemAlarmThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeSwitch))
            {
                query["NoticeSwitch"] = request.NoticeSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phones))
            {
                query["Phones"] = request.Phones;
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
                Action = "CreateDedicatedClusterMonitorRule",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDedicatedClusterMonitorRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDedicatedClusterMonitorRuleResponse> CreateDedicatedClusterMonitorRuleWithOptionsAsync(CreateDedicatedClusterMonitorRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuAlarmThreshold))
            {
                query["CpuAlarmThreshold"] = request.CpuAlarmThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                query["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskAlarmThreshold))
            {
                query["DiskAlarmThreshold"] = request.DiskAlarmThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuAlarmThreshold))
            {
                query["DuAlarmThreshold"] = request.DuAlarmThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemAlarmThreshold))
            {
                query["MemAlarmThreshold"] = request.MemAlarmThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeSwitch))
            {
                query["NoticeSwitch"] = request.NoticeSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phones))
            {
                query["Phones"] = request.Phones;
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
                Action = "CreateDedicatedClusterMonitorRule",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDedicatedClusterMonitorRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDedicatedClusterMonitorRuleResponse CreateDedicatedClusterMonitorRule(CreateDedicatedClusterMonitorRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDedicatedClusterMonitorRuleWithOptions(request, runtime);
        }

        public async Task<CreateDedicatedClusterMonitorRuleResponse> CreateDedicatedClusterMonitorRuleAsync(CreateDedicatedClusterMonitorRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDedicatedClusterMonitorRuleWithOptionsAsync(request, runtime);
        }

        /**
          * *   Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing) of DTS.
          * *   If you want to run a DTS task on a DTS dedicated cluster, you must configure the task before you purchase a DTS instance. You can call the [ConfigureDtsJob](~~208399~~) operation to configure a DTS task.
          *
          * @param request CreateDtsInstanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateDtsInstanceResponse
         */
        public CreateDtsInstanceResponse CreateDtsInstanceWithOptions(CreateDtsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStart))
            {
                query["AutoStart"] = request.AutoStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputeUnit))
            {
                query["ComputeUnit"] = request.ComputeUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseCount))
            {
                query["DatabaseCount"] = request.DatabaseCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointEngineName))
            {
                query["DestinationEndpointEngineName"] = request.DestinationEndpointEngineName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationRegion))
            {
                query["DestinationRegion"] = request.DestinationRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Du))
            {
                query["Du"] = request.Du;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeeType))
            {
                query["FeeType"] = request.FeeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceClass))
            {
                query["InstanceClass"] = request.InstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                query["Quantity"] = request.Quantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointEngineName))
            {
                query["SourceEndpointEngineName"] = request.SourceEndpointEngineName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRegion))
            {
                query["SourceRegion"] = request.SourceRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncArchitecture))
            {
                query["SyncArchitecture"] = request.SyncArchitecture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
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
                Action = "CreateDtsInstance",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDtsInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing) of DTS.
          * *   If you want to run a DTS task on a DTS dedicated cluster, you must configure the task before you purchase a DTS instance. You can call the [ConfigureDtsJob](~~208399~~) operation to configure a DTS task.
          *
          * @param request CreateDtsInstanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateDtsInstanceResponse
         */
        public async Task<CreateDtsInstanceResponse> CreateDtsInstanceWithOptionsAsync(CreateDtsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStart))
            {
                query["AutoStart"] = request.AutoStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputeUnit))
            {
                query["ComputeUnit"] = request.ComputeUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseCount))
            {
                query["DatabaseCount"] = request.DatabaseCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointEngineName))
            {
                query["DestinationEndpointEngineName"] = request.DestinationEndpointEngineName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationRegion))
            {
                query["DestinationRegion"] = request.DestinationRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Du))
            {
                query["Du"] = request.Du;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeeType))
            {
                query["FeeType"] = request.FeeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceClass))
            {
                query["InstanceClass"] = request.InstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                query["Quantity"] = request.Quantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointEngineName))
            {
                query["SourceEndpointEngineName"] = request.SourceEndpointEngineName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRegion))
            {
                query["SourceRegion"] = request.SourceRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncArchitecture))
            {
                query["SyncArchitecture"] = request.SyncArchitecture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
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
                Action = "CreateDtsInstance",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDtsInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing) of DTS.
          * *   If you want to run a DTS task on a DTS dedicated cluster, you must configure the task before you purchase a DTS instance. You can call the [ConfigureDtsJob](~~208399~~) operation to configure a DTS task.
          *
          * @param request CreateDtsInstanceRequest
          * @return CreateDtsInstanceResponse
         */
        public CreateDtsInstanceResponse CreateDtsInstance(CreateDtsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDtsInstanceWithOptions(request, runtime);
        }

        /**
          * *   Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing) of DTS.
          * *   If you want to run a DTS task on a DTS dedicated cluster, you must configure the task before you purchase a DTS instance. You can call the [ConfigureDtsJob](~~208399~~) operation to configure a DTS task.
          *
          * @param request CreateDtsInstanceRequest
          * @return CreateDtsInstanceResponse
         */
        public async Task<CreateDtsInstanceResponse> CreateDtsInstanceAsync(CreateDtsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDtsInstanceWithOptionsAsync(request, runtime);
        }

        /**
          * DTS provides the following metrics for DTS tasks:************
          * *   **Latency**: DTS monitors the latency of a DTS task. If the latency of the task exceeds the specified threshold, an alert is triggered. Unit: seconds.
          * *   **Status**: DTS monitors the status of a DTS task. If the state of the task changes to **Error** or **Restore**, an alert is triggered.
          * *   **Full Timeout**: DTS monitors the duration of a DTS task. If the duration of the task exceeds the specified threshold, an alert is triggered. Unit: hours.
          *
          * @param request CreateJobMonitorRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateJobMonitorRuleResponse
         */
        public CreateJobMonitorRuleResponse CreateJobMonitorRuleWithOptions(CreateJobMonitorRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayRuleTime))
            {
                query["DelayRuleTime"] = request.DelayRuleTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeValue))
            {
                query["NoticeValue"] = request.NoticeValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Times))
            {
                query["Times"] = request.Times;
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
                Action = "CreateJobMonitorRule",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobMonitorRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
          * DTS provides the following metrics for DTS tasks:************
          * *   **Latency**: DTS monitors the latency of a DTS task. If the latency of the task exceeds the specified threshold, an alert is triggered. Unit: seconds.
          * *   **Status**: DTS monitors the status of a DTS task. If the state of the task changes to **Error** or **Restore**, an alert is triggered.
          * *   **Full Timeout**: DTS monitors the duration of a DTS task. If the duration of the task exceeds the specified threshold, an alert is triggered. Unit: hours.
          *
          * @param request CreateJobMonitorRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateJobMonitorRuleResponse
         */
        public async Task<CreateJobMonitorRuleResponse> CreateJobMonitorRuleWithOptionsAsync(CreateJobMonitorRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayRuleTime))
            {
                query["DelayRuleTime"] = request.DelayRuleTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeValue))
            {
                query["NoticeValue"] = request.NoticeValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Times))
            {
                query["Times"] = request.Times;
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
                Action = "CreateJobMonitorRule",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobMonitorRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * DTS provides the following metrics for DTS tasks:************
          * *   **Latency**: DTS monitors the latency of a DTS task. If the latency of the task exceeds the specified threshold, an alert is triggered. Unit: seconds.
          * *   **Status**: DTS monitors the status of a DTS task. If the state of the task changes to **Error** or **Restore**, an alert is triggered.
          * *   **Full Timeout**: DTS monitors the duration of a DTS task. If the duration of the task exceeds the specified threshold, an alert is triggered. Unit: hours.
          *
          * @param request CreateJobMonitorRuleRequest
          * @return CreateJobMonitorRuleResponse
         */
        public CreateJobMonitorRuleResponse CreateJobMonitorRule(CreateJobMonitorRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateJobMonitorRuleWithOptions(request, runtime);
        }

        /**
          * DTS provides the following metrics for DTS tasks:************
          * *   **Latency**: DTS monitors the latency of a DTS task. If the latency of the task exceeds the specified threshold, an alert is triggered. Unit: seconds.
          * *   **Status**: DTS monitors the status of a DTS task. If the state of the task changes to **Error** or **Restore**, an alert is triggered.
          * *   **Full Timeout**: DTS monitors the duration of a DTS task. If the duration of the task exceeds the specified threshold, an alert is triggered. Unit: hours.
          *
          * @param request CreateJobMonitorRuleRequest
          * @return CreateJobMonitorRuleResponse
         */
        public async Task<CreateJobMonitorRuleResponse> CreateJobMonitorRuleAsync(CreateJobMonitorRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateJobMonitorRuleWithOptionsAsync(request, runtime);
        }

        /**
          * >  This API operation is outdated. We recommend that you use the new version. For more information, see [CreateDtsInstance](~~208270~~).
          * Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service/pricing) of Data Transmission Service (DTS).
          * After you purchase a data migration instance, you must call the [ConfigureMigrationJob](~~324260~~) operation to configure a data migration task.
          *
          * @param request CreateMigrationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateMigrationJobResponse
         */
        public CreateMigrationJobResponse CreateMigrationJobWithOptions(CreateMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobClass))
            {
                query["MigrationJobClass"] = request.MigrationJobClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
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
                Action = "CreateMigrationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMigrationJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  This API operation is outdated. We recommend that you use the new version. For more information, see [CreateDtsInstance](~~208270~~).
          * Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service/pricing) of Data Transmission Service (DTS).
          * After you purchase a data migration instance, you must call the [ConfigureMigrationJob](~~324260~~) operation to configure a data migration task.
          *
          * @param request CreateMigrationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateMigrationJobResponse
         */
        public async Task<CreateMigrationJobResponse> CreateMigrationJobWithOptionsAsync(CreateMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobClass))
            {
                query["MigrationJobClass"] = request.MigrationJobClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
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
                Action = "CreateMigrationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMigrationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  This API operation is outdated. We recommend that you use the new version. For more information, see [CreateDtsInstance](~~208270~~).
          * Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service/pricing) of Data Transmission Service (DTS).
          * After you purchase a data migration instance, you must call the [ConfigureMigrationJob](~~324260~~) operation to configure a data migration task.
          *
          * @param request CreateMigrationJobRequest
          * @return CreateMigrationJobResponse
         */
        public CreateMigrationJobResponse CreateMigrationJob(CreateMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMigrationJobWithOptions(request, runtime);
        }

        /**
          * >  This API operation is outdated. We recommend that you use the new version. For more information, see [CreateDtsInstance](~~208270~~).
          * Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service/pricing) of Data Transmission Service (DTS).
          * After you purchase a data migration instance, you must call the [ConfigureMigrationJob](~~324260~~) operation to configure a data migration task.
          *
          * @param request CreateMigrationJobRequest
          * @return CreateMigrationJobResponse
         */
        public async Task<CreateMigrationJobResponse> CreateMigrationJobAsync(CreateMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMigrationJobWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service/pricing) of Data Transmission Service (DTS).
          *
          * @param request CreateSubscriptionInstanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateSubscriptionInstanceResponse
         */
        public CreateSubscriptionInstanceResponse CreateSubscriptionInstanceWithOptions(CreateSubscriptionInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedTime))
            {
                query["UsedTime"] = request.UsedTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpoint))
            {
                query["SourceEndpoint"] = request.SourceEndpoint;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSubscriptionInstance",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSubscriptionInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service/pricing) of Data Transmission Service (DTS).
          *
          * @param request CreateSubscriptionInstanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateSubscriptionInstanceResponse
         */
        public async Task<CreateSubscriptionInstanceResponse> CreateSubscriptionInstanceWithOptionsAsync(CreateSubscriptionInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedTime))
            {
                query["UsedTime"] = request.UsedTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpoint))
            {
                query["SourceEndpoint"] = request.SourceEndpoint;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSubscriptionInstance",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSubscriptionInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service/pricing) of Data Transmission Service (DTS).
          *
          * @param request CreateSubscriptionInstanceRequest
          * @return CreateSubscriptionInstanceResponse
         */
        public CreateSubscriptionInstanceResponse CreateSubscriptionInstance(CreateSubscriptionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSubscriptionInstanceWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service/pricing) of Data Transmission Service (DTS).
          *
          * @param request CreateSubscriptionInstanceRequest
          * @return CreateSubscriptionInstanceResponse
         */
        public async Task<CreateSubscriptionInstanceResponse> CreateSubscriptionInstanceAsync(CreateSubscriptionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSubscriptionInstanceWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service/pricing) of Data Transmission Service (DTS).
          * After you purchase a data synchronization instance, you must call the [ConfigureSynchronizationJob](~~49447~~) operation to configure a data synchronization task. Then, the task is automatically started.
          *
          * @param request CreateSynchronizationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateSynchronizationJobResponse
         */
        public CreateSynchronizationJobResponse CreateSynchronizationJobWithOptions(CreateSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceCount))
            {
                query["DBInstanceCount"] = request.DBInstanceCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestRegion))
            {
                query["DestRegion"] = request.DestRegion;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRegion))
            {
                query["SourceRegion"] = request.SourceRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobClass))
            {
                query["SynchronizationJobClass"] = request.SynchronizationJobClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topology))
            {
                query["Topology"] = request.Topology;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedTime))
            {
                query["UsedTime"] = request.UsedTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["networkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpoint))
            {
                query["DestinationEndpoint"] = request.DestinationEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpoint))
            {
                query["SourceEndpoint"] = request.SourceEndpoint;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSynchronizationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSynchronizationJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service/pricing) of Data Transmission Service (DTS).
          * After you purchase a data synchronization instance, you must call the [ConfigureSynchronizationJob](~~49447~~) operation to configure a data synchronization task. Then, the task is automatically started.
          *
          * @param request CreateSynchronizationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateSynchronizationJobResponse
         */
        public async Task<CreateSynchronizationJobResponse> CreateSynchronizationJobWithOptionsAsync(CreateSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceCount))
            {
                query["DBInstanceCount"] = request.DBInstanceCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestRegion))
            {
                query["DestRegion"] = request.DestRegion;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRegion))
            {
                query["SourceRegion"] = request.SourceRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobClass))
            {
                query["SynchronizationJobClass"] = request.SynchronizationJobClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topology))
            {
                query["Topology"] = request.Topology;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedTime))
            {
                query["UsedTime"] = request.UsedTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["networkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpoint))
            {
                query["DestinationEndpoint"] = request.DestinationEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpoint))
            {
                query["SourceEndpoint"] = request.SourceEndpoint;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSynchronizationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSynchronizationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service/pricing) of Data Transmission Service (DTS).
          * After you purchase a data synchronization instance, you must call the [ConfigureSynchronizationJob](~~49447~~) operation to configure a data synchronization task. Then, the task is automatically started.
          *
          * @param request CreateSynchronizationJobRequest
          * @return CreateSynchronizationJobResponse
         */
        public CreateSynchronizationJobResponse CreateSynchronizationJob(CreateSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSynchronizationJobWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service/pricing) of Data Transmission Service (DTS).
          * After you purchase a data synchronization instance, you must call the [ConfigureSynchronizationJob](~~49447~~) operation to configure a data synchronization task. Then, the task is automatically started.
          *
          * @param request CreateSynchronizationJobRequest
          * @return CreateSynchronizationJobResponse
         */
        public async Task<CreateSynchronizationJobResponse> CreateSynchronizationJobAsync(CreateSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSynchronizationJobWithOptionsAsync(request, runtime);
        }

        public DeleteConsumerChannelResponse DeleteConsumerChannelWithOptions(DeleteConsumerChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupId))
            {
                query["ConsumerGroupId"] = request.ConsumerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
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
                Action = "DeleteConsumerChannel",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConsumerChannelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteConsumerChannelResponse> DeleteConsumerChannelWithOptionsAsync(DeleteConsumerChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupId))
            {
                query["ConsumerGroupId"] = request.ConsumerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
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
                Action = "DeleteConsumerChannel",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConsumerChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteConsumerChannelResponse DeleteConsumerChannel(DeleteConsumerChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteConsumerChannelWithOptions(request, runtime);
        }

        public async Task<DeleteConsumerChannelResponse> DeleteConsumerChannelAsync(DeleteConsumerChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteConsumerChannelWithOptionsAsync(request, runtime);
        }

        public DeleteConsumerGroupResponse DeleteConsumerGroupWithOptions(DeleteConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupID))
            {
                query["ConsumerGroupID"] = request.ConsumerGroupID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConsumerGroup",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConsumerGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteConsumerGroupResponse> DeleteConsumerGroupWithOptionsAsync(DeleteConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupID))
            {
                query["ConsumerGroupID"] = request.ConsumerGroupID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConsumerGroup",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConsumerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteConsumerGroupResponse DeleteConsumerGroup(DeleteConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteConsumerGroupWithOptions(request, runtime);
        }

        public async Task<DeleteConsumerGroupResponse> DeleteConsumerGroupAsync(DeleteConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteConsumerGroupWithOptionsAsync(request, runtime);
        }

        public DeleteDtsJobResponse DeleteDtsJobWithOptions(DeleteDtsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDtsJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDtsJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDtsJobResponse> DeleteDtsJobWithOptionsAsync(DeleteDtsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDtsJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDtsJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDtsJobResponse DeleteDtsJob(DeleteDtsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDtsJobWithOptions(request, runtime);
        }

        public async Task<DeleteDtsJobResponse> DeleteDtsJobAsync(DeleteDtsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDtsJobWithOptionsAsync(request, runtime);
        }

        public DeleteDtsJobsResponse DeleteDtsJobsWithOptions(DeleteDtsJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobIds))
            {
                query["DtsJobIds"] = request.DtsJobIds;
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
                Action = "DeleteDtsJobs",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDtsJobsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDtsJobsResponse> DeleteDtsJobsWithOptionsAsync(DeleteDtsJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobIds))
            {
                query["DtsJobIds"] = request.DtsJobIds;
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
                Action = "DeleteDtsJobs",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDtsJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDtsJobsResponse DeleteDtsJobs(DeleteDtsJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDtsJobsWithOptions(request, runtime);
        }

        public async Task<DeleteDtsJobsResponse> DeleteDtsJobsAsync(DeleteDtsJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDtsJobsWithOptionsAsync(request, runtime);
        }

        /**
          * >  After a data migration instance is released, it cannot be recovered.
          *
          * @param request DeleteMigrationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteMigrationJobResponse
         */
        public DeleteMigrationJobResponse DeleteMigrationJobWithOptions(DeleteMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "DeleteMigrationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMigrationJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  After a data migration instance is released, it cannot be recovered.
          *
          * @param request DeleteMigrationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteMigrationJobResponse
         */
        public async Task<DeleteMigrationJobResponse> DeleteMigrationJobWithOptionsAsync(DeleteMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "DeleteMigrationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMigrationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  After a data migration instance is released, it cannot be recovered.
          *
          * @param request DeleteMigrationJobRequest
          * @return DeleteMigrationJobResponse
         */
        public DeleteMigrationJobResponse DeleteMigrationJob(DeleteMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMigrationJobWithOptions(request, runtime);
        }

        /**
          * >  After a data migration instance is released, it cannot be recovered.
          *
          * @param request DeleteMigrationJobRequest
          * @return DeleteMigrationJobResponse
         */
        public async Task<DeleteMigrationJobResponse> DeleteMigrationJobAsync(DeleteMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMigrationJobWithOptionsAsync(request, runtime);
        }

        /**
          * >  After a change tracking instance is released, it cannot be recovered.
          *
          * @param request DeleteSubscriptionInstanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteSubscriptionInstanceResponse
         */
        public DeleteSubscriptionInstanceResponse DeleteSubscriptionInstanceWithOptions(DeleteSubscriptionInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSubscriptionInstance",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSubscriptionInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  After a change tracking instance is released, it cannot be recovered.
          *
          * @param request DeleteSubscriptionInstanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteSubscriptionInstanceResponse
         */
        public async Task<DeleteSubscriptionInstanceResponse> DeleteSubscriptionInstanceWithOptionsAsync(DeleteSubscriptionInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSubscriptionInstance",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSubscriptionInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  After a change tracking instance is released, it cannot be recovered.
          *
          * @param request DeleteSubscriptionInstanceRequest
          * @return DeleteSubscriptionInstanceResponse
         */
        public DeleteSubscriptionInstanceResponse DeleteSubscriptionInstance(DeleteSubscriptionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSubscriptionInstanceWithOptions(request, runtime);
        }

        /**
          * >  After a change tracking instance is released, it cannot be recovered.
          *
          * @param request DeleteSubscriptionInstanceRequest
          * @return DeleteSubscriptionInstanceResponse
         */
        public async Task<DeleteSubscriptionInstanceResponse> DeleteSubscriptionInstanceAsync(DeleteSubscriptionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSubscriptionInstanceWithOptionsAsync(request, runtime);
        }

        /**
          * >  After a data synchronization instance is released, it cannot be recovered.
          *
          * @param request DeleteSynchronizationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteSynchronizationJobResponse
         */
        public DeleteSynchronizationJobResponse DeleteSynchronizationJobWithOptions(DeleteSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSynchronizationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSynchronizationJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  After a data synchronization instance is released, it cannot be recovered.
          *
          * @param request DeleteSynchronizationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteSynchronizationJobResponse
         */
        public async Task<DeleteSynchronizationJobResponse> DeleteSynchronizationJobWithOptionsAsync(DeleteSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSynchronizationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSynchronizationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  After a data synchronization instance is released, it cannot be recovered.
          *
          * @param request DeleteSynchronizationJobRequest
          * @return DeleteSynchronizationJobResponse
         */
        public DeleteSynchronizationJobResponse DeleteSynchronizationJob(DeleteSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSynchronizationJobWithOptions(request, runtime);
        }

        /**
          * >  After a data synchronization instance is released, it cannot be recovered.
          *
          * @param request DeleteSynchronizationJobRequest
          * @return DeleteSynchronizationJobResponse
         */
        public async Task<DeleteSynchronizationJobResponse> DeleteSynchronizationJobAsync(DeleteSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSynchronizationJobWithOptionsAsync(request, runtime);
        }

        public DescribeChannelAccountResponse DescribeChannelAccountWithOptions(DescribeChannelAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
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
                Action = "DescribeChannelAccount",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeChannelAccountResponse> DescribeChannelAccountWithOptionsAsync(DescribeChannelAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
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
                Action = "DescribeChannelAccount",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeChannelAccountResponse DescribeChannelAccount(DescribeChannelAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelAccountWithOptions(request, runtime);
        }

        public async Task<DescribeChannelAccountResponse> DescribeChannelAccountAsync(DescribeChannelAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelAccountWithOptionsAsync(request, runtime);
        }

        public DescribeCheckJobsResponse DescribeCheckJobsWithOptions(DescribeCheckJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                query["CheckType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
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
                Action = "DescribeCheckJobs",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCheckJobsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCheckJobsResponse> DescribeCheckJobsWithOptionsAsync(DescribeCheckJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                query["CheckType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
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
                Action = "DescribeCheckJobs",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCheckJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCheckJobsResponse DescribeCheckJobs(DescribeCheckJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCheckJobsWithOptions(request, runtime);
        }

        public async Task<DescribeCheckJobsResponse> DescribeCheckJobsAsync(DescribeCheckJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCheckJobsWithOptionsAsync(request, runtime);
        }

        public DescribeClusterOperateLogsResponse DescribeClusterOperateLogsWithOptions(DescribeClusterOperateLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                body["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                body["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerID))
            {
                body["OwnerID"] = request.OwnerID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
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
                Action = "DescribeClusterOperateLogs",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterOperateLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterOperateLogsResponse> DescribeClusterOperateLogsWithOptionsAsync(DescribeClusterOperateLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                body["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                body["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerID))
            {
                body["OwnerID"] = request.OwnerID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
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
                Action = "DescribeClusterOperateLogs",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterOperateLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterOperateLogsResponse DescribeClusterOperateLogs(DescribeClusterOperateLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterOperateLogsWithOptions(request, runtime);
        }

        public async Task<DescribeClusterOperateLogsResponse> DescribeClusterOperateLogsAsync(DescribeClusterOperateLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterOperateLogsWithOptionsAsync(request, runtime);
        }

        public DescribeClusterUsedUtilizationResponse DescribeClusterUsedUtilizationWithOptions(DescribeClusterUsedUtilizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                body["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                body["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                body["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                body["MetricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerID))
            {
                body["OwnerID"] = request.OwnerID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                body["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterUsedUtilization",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterUsedUtilizationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterUsedUtilizationResponse> DescribeClusterUsedUtilizationWithOptionsAsync(DescribeClusterUsedUtilizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                body["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                body["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                body["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                body["MetricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerID))
            {
                body["OwnerID"] = request.OwnerID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                body["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterUsedUtilization",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterUsedUtilizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterUsedUtilizationResponse DescribeClusterUsedUtilization(DescribeClusterUsedUtilizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterUsedUtilizationWithOptions(request, runtime);
        }

        public async Task<DescribeClusterUsedUtilizationResponse> DescribeClusterUsedUtilizationAsync(DescribeClusterUsedUtilizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterUsedUtilizationWithOptionsAsync(request, runtime);
        }

        public DescribeConnectionStatusResponse DescribeConnectionStatusWithOptions(DescribeConnectionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointArchitecture))
            {
                query["DestinationEndpointArchitecture"] = request.DestinationEndpointArchitecture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointDatabaseName))
            {
                query["DestinationEndpointDatabaseName"] = request.DestinationEndpointDatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointEngineName))
            {
                query["DestinationEndpointEngineName"] = request.DestinationEndpointEngineName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointArchitecture))
            {
                query["SourceEndpointArchitecture"] = request.SourceEndpointArchitecture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointDatabaseName))
            {
                query["SourceEndpointDatabaseName"] = request.SourceEndpointDatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointEngineName))
            {
                query["SourceEndpointEngineName"] = request.SourceEndpointEngineName;
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
                Action = "DescribeConnectionStatus",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConnectionStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeConnectionStatusResponse> DescribeConnectionStatusWithOptionsAsync(DescribeConnectionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointArchitecture))
            {
                query["DestinationEndpointArchitecture"] = request.DestinationEndpointArchitecture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointDatabaseName))
            {
                query["DestinationEndpointDatabaseName"] = request.DestinationEndpointDatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointEngineName))
            {
                query["DestinationEndpointEngineName"] = request.DestinationEndpointEngineName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointArchitecture))
            {
                query["SourceEndpointArchitecture"] = request.SourceEndpointArchitecture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointDatabaseName))
            {
                query["SourceEndpointDatabaseName"] = request.SourceEndpointDatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointEngineName))
            {
                query["SourceEndpointEngineName"] = request.SourceEndpointEngineName;
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
                Action = "DescribeConnectionStatus",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConnectionStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeConnectionStatusResponse DescribeConnectionStatus(DescribeConnectionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeConnectionStatusWithOptions(request, runtime);
        }

        public async Task<DescribeConnectionStatusResponse> DescribeConnectionStatusAsync(DescribeConnectionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeConnectionStatusWithOptionsAsync(request, runtime);
        }

        public DescribeConsumerChannelResponse DescribeConsumerChannelWithOptions(DescribeConsumerChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentChannelId))
            {
                query["ParentChannelId"] = request.ParentChannelId;
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
                Action = "DescribeConsumerChannel",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConsumerChannelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeConsumerChannelResponse> DescribeConsumerChannelWithOptionsAsync(DescribeConsumerChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentChannelId))
            {
                query["ParentChannelId"] = request.ParentChannelId;
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
                Action = "DescribeConsumerChannel",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConsumerChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeConsumerChannelResponse DescribeConsumerChannel(DescribeConsumerChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeConsumerChannelWithOptions(request, runtime);
        }

        public async Task<DescribeConsumerChannelResponse> DescribeConsumerChannelAsync(DescribeConsumerChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeConsumerChannelWithOptionsAsync(request, runtime);
        }

        public DescribeConsumerGroupResponse DescribeConsumerGroupWithOptions(DescribeConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeConsumerGroup",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConsumerGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeConsumerGroupResponse> DescribeConsumerGroupWithOptionsAsync(DescribeConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeConsumerGroup",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConsumerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeConsumerGroupResponse DescribeConsumerGroup(DescribeConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeConsumerGroupWithOptions(request, runtime);
        }

        public async Task<DescribeConsumerGroupResponse> DescribeConsumerGroupAsync(DescribeConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeConsumerGroupWithOptionsAsync(request, runtime);
        }

        /**
          * If the **source or destination instance** is an **on-premises database**, you need to call this operation to query the CIDR blocks of DTS servers. Then, you need to add the CIDR blocks of DTS servers to the security settings of the source or destination instance, for example, the firewall of your database. For more information, see [Add the CIDR blocks of DTS servers to the security settings of on-premises databases](~~176627~~).
          * >  If the **source or destination database** is an **ApsaraDB database instance** (such as RDS instance and ApsaraDB for MongoDB instance) or a **self-managed database hosted on ECS**, you do not need to add the CIDR blocks. When you click **Set Whitelist and Next** in the DTS console, DTS automatically add the CIDR blocks of DTS servers to the security settings of the source or destination instance.
          *
          * @param request DescribeDTSIPRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDTSIPResponse
         */
        public DescribeDTSIPResponse DescribeDTSIPWithOptions(DescribeDTSIPRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointRegion))
            {
                query["DestinationEndpointRegion"] = request.DestinationEndpointRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeDTSIP",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDTSIPResponse>(CallApi(params_, req, runtime));
        }

        /**
          * If the **source or destination instance** is an **on-premises database**, you need to call this operation to query the CIDR blocks of DTS servers. Then, you need to add the CIDR blocks of DTS servers to the security settings of the source or destination instance, for example, the firewall of your database. For more information, see [Add the CIDR blocks of DTS servers to the security settings of on-premises databases](~~176627~~).
          * >  If the **source or destination database** is an **ApsaraDB database instance** (such as RDS instance and ApsaraDB for MongoDB instance) or a **self-managed database hosted on ECS**, you do not need to add the CIDR blocks. When you click **Set Whitelist and Next** in the DTS console, DTS automatically add the CIDR blocks of DTS servers to the security settings of the source or destination instance.
          *
          * @param request DescribeDTSIPRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDTSIPResponse
         */
        public async Task<DescribeDTSIPResponse> DescribeDTSIPWithOptionsAsync(DescribeDTSIPRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointRegion))
            {
                query["DestinationEndpointRegion"] = request.DestinationEndpointRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeDTSIP",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDTSIPResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * If the **source or destination instance** is an **on-premises database**, you need to call this operation to query the CIDR blocks of DTS servers. Then, you need to add the CIDR blocks of DTS servers to the security settings of the source or destination instance, for example, the firewall of your database. For more information, see [Add the CIDR blocks of DTS servers to the security settings of on-premises databases](~~176627~~).
          * >  If the **source or destination database** is an **ApsaraDB database instance** (such as RDS instance and ApsaraDB for MongoDB instance) or a **self-managed database hosted on ECS**, you do not need to add the CIDR blocks. When you click **Set Whitelist and Next** in the DTS console, DTS automatically add the CIDR blocks of DTS servers to the security settings of the source or destination instance.
          *
          * @param request DescribeDTSIPRequest
          * @return DescribeDTSIPResponse
         */
        public DescribeDTSIPResponse DescribeDTSIP(DescribeDTSIPRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDTSIPWithOptions(request, runtime);
        }

        /**
          * If the **source or destination instance** is an **on-premises database**, you need to call this operation to query the CIDR blocks of DTS servers. Then, you need to add the CIDR blocks of DTS servers to the security settings of the source or destination instance, for example, the firewall of your database. For more information, see [Add the CIDR blocks of DTS servers to the security settings of on-premises databases](~~176627~~).
          * >  If the **source or destination database** is an **ApsaraDB database instance** (such as RDS instance and ApsaraDB for MongoDB instance) or a **self-managed database hosted on ECS**, you do not need to add the CIDR blocks. When you click **Set Whitelist and Next** in the DTS console, DTS automatically add the CIDR blocks of DTS servers to the security settings of the source or destination instance.
          *
          * @param request DescribeDTSIPRequest
          * @return DescribeDTSIPResponse
         */
        public async Task<DescribeDTSIPResponse> DescribeDTSIPAsync(DescribeDTSIPRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDTSIPWithOptionsAsync(request, runtime);
        }

        public DescribeDataCheckReportUrlResponse DescribeDataCheckReportUrlWithOptions(DescribeDataCheckReportUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                query["CheckType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbName))
            {
                query["TbName"] = request.TbName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataCheckReportUrl",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataCheckReportUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDataCheckReportUrlResponse> DescribeDataCheckReportUrlWithOptionsAsync(DescribeDataCheckReportUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                query["CheckType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbName))
            {
                query["TbName"] = request.TbName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataCheckReportUrl",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataCheckReportUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDataCheckReportUrlResponse DescribeDataCheckReportUrl(DescribeDataCheckReportUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataCheckReportUrlWithOptions(request, runtime);
        }

        public async Task<DescribeDataCheckReportUrlResponse> DescribeDataCheckReportUrlAsync(DescribeDataCheckReportUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataCheckReportUrlWithOptionsAsync(request, runtime);
        }

        public DescribeDataCheckTableDetailsResponse DescribeDataCheckTableDetailsWithOptions(DescribeDataCheckTableDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                query["CheckType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["SchemaName"] = request.SchemaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "DescribeDataCheckTableDetails",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataCheckTableDetailsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDataCheckTableDetailsResponse> DescribeDataCheckTableDetailsWithOptionsAsync(DescribeDataCheckTableDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                query["CheckType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["SchemaName"] = request.SchemaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "DescribeDataCheckTableDetails",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataCheckTableDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDataCheckTableDetailsResponse DescribeDataCheckTableDetails(DescribeDataCheckTableDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataCheckTableDetailsWithOptions(request, runtime);
        }

        public async Task<DescribeDataCheckTableDetailsResponse> DescribeDataCheckTableDetailsAsync(DescribeDataCheckTableDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataCheckTableDetailsWithOptionsAsync(request, runtime);
        }

        public DescribeDataCheckTableDiffDetailsResponse DescribeDataCheckTableDiffDetailsWithOptions(DescribeDataCheckTableDiffDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                query["CheckType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbName))
            {
                query["TbName"] = request.TbName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataCheckTableDiffDetails",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataCheckTableDiffDetailsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDataCheckTableDiffDetailsResponse> DescribeDataCheckTableDiffDetailsWithOptionsAsync(DescribeDataCheckTableDiffDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                query["CheckType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbName))
            {
                query["TbName"] = request.TbName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataCheckTableDiffDetails",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataCheckTableDiffDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDataCheckTableDiffDetailsResponse DescribeDataCheckTableDiffDetails(DescribeDataCheckTableDiffDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataCheckTableDiffDetailsWithOptions(request, runtime);
        }

        public async Task<DescribeDataCheckTableDiffDetailsResponse> DescribeDataCheckTableDiffDetailsAsync(DescribeDataCheckTableDiffDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataCheckTableDiffDetailsWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedClusterResponse DescribeDedicatedClusterWithOptions(DescribeDedicatedClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                query["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "DescribeDedicatedCluster",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDedicatedClusterResponse> DescribeDedicatedClusterWithOptionsAsync(DescribeDedicatedClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                query["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "DescribeDedicatedCluster",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDedicatedClusterResponse DescribeDedicatedCluster(DescribeDedicatedClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedClusterWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedClusterResponse> DescribeDedicatedClusterAsync(DescribeDedicatedClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedClusterWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedClusterMonitorRuleResponse DescribeDedicatedClusterMonitorRuleWithOptions(DescribeDedicatedClusterMonitorRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                query["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "DescribeDedicatedClusterMonitorRule",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedClusterMonitorRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDedicatedClusterMonitorRuleResponse> DescribeDedicatedClusterMonitorRuleWithOptionsAsync(DescribeDedicatedClusterMonitorRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                query["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "DescribeDedicatedClusterMonitorRule",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedClusterMonitorRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDedicatedClusterMonitorRuleResponse DescribeDedicatedClusterMonitorRule(DescribeDedicatedClusterMonitorRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedClusterMonitorRuleWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedClusterMonitorRuleResponse> DescribeDedicatedClusterMonitorRuleAsync(DescribeDedicatedClusterMonitorRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedClusterMonitorRuleWithOptionsAsync(request, runtime);
        }

        public DescribeDtsEtlJobVersionInfoResponse DescribeDtsEtlJobVersionInfoWithOptions(DescribeDtsEtlJobVersionInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "DescribeDtsEtlJobVersionInfo",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDtsEtlJobVersionInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDtsEtlJobVersionInfoResponse> DescribeDtsEtlJobVersionInfoWithOptionsAsync(DescribeDtsEtlJobVersionInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "DescribeDtsEtlJobVersionInfo",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDtsEtlJobVersionInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDtsEtlJobVersionInfoResponse DescribeDtsEtlJobVersionInfo(DescribeDtsEtlJobVersionInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDtsEtlJobVersionInfoWithOptions(request, runtime);
        }

        public async Task<DescribeDtsEtlJobVersionInfoResponse> DescribeDtsEtlJobVersionInfoAsync(DescribeDtsEtlJobVersionInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDtsEtlJobVersionInfoWithOptionsAsync(request, runtime);
        }

        public DescribeDtsJobDetailResponse DescribeDtsJobDetailWithOptions(DescribeDtsJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceID))
            {
                query["DtsInstanceID"] = request.DtsInstanceID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncSubJobHistory))
            {
                query["SyncSubJobHistory"] = request.SyncSubJobHistory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDtsJobDetail",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDtsJobDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDtsJobDetailResponse> DescribeDtsJobDetailWithOptionsAsync(DescribeDtsJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceID))
            {
                query["DtsInstanceID"] = request.DtsInstanceID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncSubJobHistory))
            {
                query["SyncSubJobHistory"] = request.SyncSubJobHistory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDtsJobDetail",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDtsJobDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDtsJobDetailResponse DescribeDtsJobDetail(DescribeDtsJobDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDtsJobDetailWithOptions(request, runtime);
        }

        public async Task<DescribeDtsJobDetailResponse> DescribeDtsJobDetailAsync(DescribeDtsJobDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDtsJobDetailWithOptionsAsync(request, runtime);
        }

        /**
          * ## Debugging
          * [OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.](https://api.aliyun.com/#product=Dts\\&api=DescribeDtsJobs\\&type=RPC\\&version=2020-01-01)
          *
          * @param request DescribeDtsJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDtsJobsResponse
         */
        public DescribeDtsJobsResponse DescribeDtsJobsWithOptions(DescribeDtsJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                query["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsBisLabel))
            {
                query["DtsBisLabel"] = request.DtsBisLabel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderColumn))
            {
                query["OrderColumn"] = request.OrderColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["OrderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithoutDbList))
            {
                query["WithoutDbList"] = request.WithoutDbList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDtsJobs",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDtsJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Debugging
          * [OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.](https://api.aliyun.com/#product=Dts\\&api=DescribeDtsJobs\\&type=RPC\\&version=2020-01-01)
          *
          * @param request DescribeDtsJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDtsJobsResponse
         */
        public async Task<DescribeDtsJobsResponse> DescribeDtsJobsWithOptionsAsync(DescribeDtsJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                query["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsBisLabel))
            {
                query["DtsBisLabel"] = request.DtsBisLabel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderColumn))
            {
                query["OrderColumn"] = request.OrderColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["OrderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithoutDbList))
            {
                query["WithoutDbList"] = request.WithoutDbList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDtsJobs",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDtsJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Debugging
          * [OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.](https://api.aliyun.com/#product=Dts\\&api=DescribeDtsJobs\\&type=RPC\\&version=2020-01-01)
          *
          * @param request DescribeDtsJobsRequest
          * @return DescribeDtsJobsResponse
         */
        public DescribeDtsJobsResponse DescribeDtsJobs(DescribeDtsJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDtsJobsWithOptions(request, runtime);
        }

        /**
          * ## Debugging
          * [OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.](https://api.aliyun.com/#product=Dts\\&api=DescribeDtsJobs\\&type=RPC\\&version=2020-01-01)
          *
          * @param request DescribeDtsJobsRequest
          * @return DescribeDtsJobsResponse
         */
        public async Task<DescribeDtsJobsResponse> DescribeDtsJobsAsync(DescribeDtsJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDtsJobsWithOptionsAsync(request, runtime);
        }

        public DescribeDtsServiceLogResponse DescribeDtsServiceLogWithOptions(DescribeDtsServiceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubJobType))
            {
                query["SubJobType"] = request.SubJobType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDtsServiceLog",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDtsServiceLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDtsServiceLogResponse> DescribeDtsServiceLogWithOptionsAsync(DescribeDtsServiceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubJobType))
            {
                query["SubJobType"] = request.SubJobType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDtsServiceLog",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDtsServiceLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDtsServiceLogResponse DescribeDtsServiceLog(DescribeDtsServiceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDtsServiceLogWithOptions(request, runtime);
        }

        public async Task<DescribeDtsServiceLogResponse> DescribeDtsServiceLogAsync(DescribeDtsServiceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDtsServiceLogWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, you must call the [SwitchSynchronizationEndpoint](~~201858~~) operation to change the database connection settings.
          *
          * @param request DescribeEndpointSwitchStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeEndpointSwitchStatusResponse
         */
        public DescribeEndpointSwitchStatusResponse DescribeEndpointSwitchStatusWithOptions(DescribeEndpointSwitchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeEndpointSwitchStatus",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEndpointSwitchStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, you must call the [SwitchSynchronizationEndpoint](~~201858~~) operation to change the database connection settings.
          *
          * @param request DescribeEndpointSwitchStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeEndpointSwitchStatusResponse
         */
        public async Task<DescribeEndpointSwitchStatusResponse> DescribeEndpointSwitchStatusWithOptionsAsync(DescribeEndpointSwitchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeEndpointSwitchStatus",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEndpointSwitchStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, you must call the [SwitchSynchronizationEndpoint](~~201858~~) operation to change the database connection settings.
          *
          * @param request DescribeEndpointSwitchStatusRequest
          * @return DescribeEndpointSwitchStatusResponse
         */
        public DescribeEndpointSwitchStatusResponse DescribeEndpointSwitchStatus(DescribeEndpointSwitchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEndpointSwitchStatusWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, you must call the [SwitchSynchronizationEndpoint](~~201858~~) operation to change the database connection settings.
          *
          * @param request DescribeEndpointSwitchStatusRequest
          * @return DescribeEndpointSwitchStatusResponse
         */
        public async Task<DescribeEndpointSwitchStatusResponse> DescribeEndpointSwitchStatusAsync(DescribeEndpointSwitchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEndpointSwitchStatusWithOptionsAsync(request, runtime);
        }

        public DescribeEtlJobLogsResponse DescribeEtlJobLogsWithOptions(DescribeEtlJobLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
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
                Action = "DescribeEtlJobLogs",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEtlJobLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeEtlJobLogsResponse> DescribeEtlJobLogsWithOptionsAsync(DescribeEtlJobLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
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
                Action = "DescribeEtlJobLogs",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEtlJobLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeEtlJobLogsResponse DescribeEtlJobLogs(DescribeEtlJobLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEtlJobLogsWithOptions(request, runtime);
        }

        public async Task<DescribeEtlJobLogsResponse> DescribeEtlJobLogsAsync(DescribeEtlJobLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEtlJobLogsWithOptionsAsync(request, runtime);
        }

        public DescribeInitializationStatusResponse DescribeInitializationStatusWithOptions(DescribeInitializationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInitializationStatus",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInitializationStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeInitializationStatusResponse> DescribeInitializationStatusWithOptionsAsync(DescribeInitializationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInitializationStatus",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInitializationStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeInitializationStatusResponse DescribeInitializationStatus(DescribeInitializationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInitializationStatusWithOptions(request, runtime);
        }

        public async Task<DescribeInitializationStatusResponse> DescribeInitializationStatusAsync(DescribeInitializationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInitializationStatusWithOptionsAsync(request, runtime);
        }

        public DescribeJobMonitorRuleResponse DescribeJobMonitorRuleWithOptions(DescribeJobMonitorRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
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
                Action = "DescribeJobMonitorRule",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobMonitorRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeJobMonitorRuleResponse> DescribeJobMonitorRuleWithOptionsAsync(DescribeJobMonitorRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
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
                Action = "DescribeJobMonitorRule",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobMonitorRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeJobMonitorRuleResponse DescribeJobMonitorRule(DescribeJobMonitorRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeJobMonitorRuleWithOptions(request, runtime);
        }

        public async Task<DescribeJobMonitorRuleResponse> DescribeJobMonitorRuleAsync(DescribeJobMonitorRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeJobMonitorRuleWithOptionsAsync(request, runtime);
        }

        public DescribeMetricListResponse DescribeMetricListWithOptions(DescribeMetricListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                body["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                body["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                body["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                body["MetricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerID))
            {
                body["OwnerID"] = request.OwnerID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["Param"] = request.Param;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
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
                Action = "DescribeMetricList",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMetricListResponse> DescribeMetricListWithOptionsAsync(DescribeMetricListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                body["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                body["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                body["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                body["MetricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerID))
            {
                body["OwnerID"] = request.OwnerID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["Param"] = request.Param;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
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
                Action = "DescribeMetricList",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMetricListResponse DescribeMetricList(DescribeMetricListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricListWithOptions(request, runtime);
        }

        public async Task<DescribeMetricListResponse> DescribeMetricListAsync(DescribeMetricListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricListWithOptionsAsync(request, runtime);
        }

        public DescribeMigrationJobAlertResponse DescribeMigrationJobAlertWithOptions(DescribeMigrationJobAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "DescribeMigrationJobAlert",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMigrationJobAlertResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMigrationJobAlertResponse> DescribeMigrationJobAlertWithOptionsAsync(DescribeMigrationJobAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "DescribeMigrationJobAlert",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMigrationJobAlertResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMigrationJobAlertResponse DescribeMigrationJobAlert(DescribeMigrationJobAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMigrationJobAlertWithOptions(request, runtime);
        }

        public async Task<DescribeMigrationJobAlertResponse> DescribeMigrationJobAlertAsync(DescribeMigrationJobAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMigrationJobAlertWithOptionsAsync(request, runtime);
        }

        /**
          * When you call this operation, the data migration task must be in the Migrating, Failed, Paused, or Finished state.
          *
          * @param request DescribeMigrationJobDetailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMigrationJobDetailResponse
         */
        public DescribeMigrationJobDetailResponse DescribeMigrationJobDetailWithOptions(DescribeMigrationJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationMode))
            {
                query["MigrationMode"] = request.MigrationMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMigrationJobDetail",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMigrationJobDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
          * When you call this operation, the data migration task must be in the Migrating, Failed, Paused, or Finished state.
          *
          * @param request DescribeMigrationJobDetailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMigrationJobDetailResponse
         */
        public async Task<DescribeMigrationJobDetailResponse> DescribeMigrationJobDetailWithOptionsAsync(DescribeMigrationJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationMode))
            {
                query["MigrationMode"] = request.MigrationMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMigrationJobDetail",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMigrationJobDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * When you call this operation, the data migration task must be in the Migrating, Failed, Paused, or Finished state.
          *
          * @param request DescribeMigrationJobDetailRequest
          * @return DescribeMigrationJobDetailResponse
         */
        public DescribeMigrationJobDetailResponse DescribeMigrationJobDetail(DescribeMigrationJobDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMigrationJobDetailWithOptions(request, runtime);
        }

        /**
          * When you call this operation, the data migration task must be in the Migrating, Failed, Paused, or Finished state.
          *
          * @param request DescribeMigrationJobDetailRequest
          * @return DescribeMigrationJobDetailResponse
         */
        public async Task<DescribeMigrationJobDetailResponse> DescribeMigrationJobDetailAsync(DescribeMigrationJobDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMigrationJobDetailWithOptionsAsync(request, runtime);
        }

        public DescribeMigrationJobStatusResponse DescribeMigrationJobStatusWithOptions(DescribeMigrationJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "DescribeMigrationJobStatus",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMigrationJobStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMigrationJobStatusResponse> DescribeMigrationJobStatusWithOptionsAsync(DescribeMigrationJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "DescribeMigrationJobStatus",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMigrationJobStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMigrationJobStatusResponse DescribeMigrationJobStatus(DescribeMigrationJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMigrationJobStatusWithOptions(request, runtime);
        }

        public async Task<DescribeMigrationJobStatusResponse> DescribeMigrationJobStatusAsync(DescribeMigrationJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMigrationJobStatusWithOptionsAsync(request, runtime);
        }

        public DescribeMigrationJobsResponse DescribeMigrationJobsWithOptions(DescribeMigrationJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobName))
            {
                query["MigrationJobName"] = request.MigrationJobName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMigrationJobs",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMigrationJobsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMigrationJobsResponse> DescribeMigrationJobsWithOptionsAsync(DescribeMigrationJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobName))
            {
                query["MigrationJobName"] = request.MigrationJobName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMigrationJobs",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMigrationJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMigrationJobsResponse DescribeMigrationJobs(DescribeMigrationJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMigrationJobsWithOptions(request, runtime);
        }

        public async Task<DescribeMigrationJobsResponse> DescribeMigrationJobsAsync(DescribeMigrationJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMigrationJobsWithOptionsAsync(request, runtime);
        }

        public DescribePreCheckStatusResponse DescribePreCheckStatusWithOptions(DescribePreCheckStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobCode))
            {
                query["JobCode"] = request.JobCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructPhase))
            {
                query["StructPhase"] = request.StructPhase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructType))
            {
                query["StructType"] = request.StructType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePreCheckStatus",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePreCheckStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribePreCheckStatusResponse> DescribePreCheckStatusWithOptionsAsync(DescribePreCheckStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobCode))
            {
                query["JobCode"] = request.JobCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructPhase))
            {
                query["StructPhase"] = request.StructPhase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructType))
            {
                query["StructType"] = request.StructType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePreCheckStatus",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePreCheckStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribePreCheckStatusResponse DescribePreCheckStatus(DescribePreCheckStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePreCheckStatusWithOptions(request, runtime);
        }

        public async Task<DescribePreCheckStatusResponse> DescribePreCheckStatusAsync(DescribePreCheckStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePreCheckStatusWithOptionsAsync(request, runtime);
        }

        public DescribeSubscriptionInstanceAlertResponse DescribeSubscriptionInstanceAlertWithOptions(DescribeSubscriptionInstanceAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSubscriptionInstanceAlert",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSubscriptionInstanceAlertResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSubscriptionInstanceAlertResponse> DescribeSubscriptionInstanceAlertWithOptionsAsync(DescribeSubscriptionInstanceAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSubscriptionInstanceAlert",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSubscriptionInstanceAlertResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSubscriptionInstanceAlertResponse DescribeSubscriptionInstanceAlert(DescribeSubscriptionInstanceAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSubscriptionInstanceAlertWithOptions(request, runtime);
        }

        public async Task<DescribeSubscriptionInstanceAlertResponse> DescribeSubscriptionInstanceAlertAsync(DescribeSubscriptionInstanceAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSubscriptionInstanceAlertWithOptionsAsync(request, runtime);
        }

        public DescribeSubscriptionInstanceStatusResponse DescribeSubscriptionInstanceStatusWithOptions(DescribeSubscriptionInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSubscriptionInstanceStatus",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSubscriptionInstanceStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSubscriptionInstanceStatusResponse> DescribeSubscriptionInstanceStatusWithOptionsAsync(DescribeSubscriptionInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSubscriptionInstanceStatus",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSubscriptionInstanceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSubscriptionInstanceStatusResponse DescribeSubscriptionInstanceStatus(DescribeSubscriptionInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSubscriptionInstanceStatusWithOptions(request, runtime);
        }

        public async Task<DescribeSubscriptionInstanceStatusResponse> DescribeSubscriptionInstanceStatusAsync(DescribeSubscriptionInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSubscriptionInstanceStatusWithOptionsAsync(request, runtime);
        }

        public DescribeSubscriptionInstancesResponse DescribeSubscriptionInstancesWithOptions(DescribeSubscriptionInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceName))
            {
                query["SubscriptionInstanceName"] = request.SubscriptionInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSubscriptionInstances",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSubscriptionInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSubscriptionInstancesResponse> DescribeSubscriptionInstancesWithOptionsAsync(DescribeSubscriptionInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceName))
            {
                query["SubscriptionInstanceName"] = request.SubscriptionInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSubscriptionInstances",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSubscriptionInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSubscriptionInstancesResponse DescribeSubscriptionInstances(DescribeSubscriptionInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSubscriptionInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeSubscriptionInstancesResponse> DescribeSubscriptionInstancesAsync(DescribeSubscriptionInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSubscriptionInstancesWithOptionsAsync(request, runtime);
        }

        /**
          * *   When Data Transmission Service (DTS) tracks data changes from a PolarDB-X 1.0 instance, data is distributed across the attached ApsaraDB RDS for MySQL instances. DTS runs a subtask for each ApsaraDB RDS for MySQL instance. You can call this operation to query the details of the subtasks in a distributed change tracking task.
          * *   You can call the [DescribeDtsJobs](~~209702~~) operation to query the ID of the change tracking instance and the ID of the consumer group.
          *
          * @param tmpReq DescribeSubscriptionMetaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeSubscriptionMetaResponse
         */
        public DescribeSubscriptionMetaResponse DescribeSubscriptionMetaWithOptions(DescribeSubscriptionMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeSubscriptionMetaShrinkRequest request = new DescribeSubscriptionMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubMigrationJobIds))
            {
                request.SubMigrationJobIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubMigrationJobIds, "SubMigrationJobIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Topics))
            {
                request.TopicsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Topics, "Topics", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sid))
            {
                query["Sid"] = request.Sid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubMigrationJobIdsShrink))
            {
                query["SubMigrationJobIds"] = request.SubMigrationJobIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicsShrink))
            {
                query["Topics"] = request.TopicsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSubscriptionMeta",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSubscriptionMetaResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   When Data Transmission Service (DTS) tracks data changes from a PolarDB-X 1.0 instance, data is distributed across the attached ApsaraDB RDS for MySQL instances. DTS runs a subtask for each ApsaraDB RDS for MySQL instance. You can call this operation to query the details of the subtasks in a distributed change tracking task.
          * *   You can call the [DescribeDtsJobs](~~209702~~) operation to query the ID of the change tracking instance and the ID of the consumer group.
          *
          * @param tmpReq DescribeSubscriptionMetaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeSubscriptionMetaResponse
         */
        public async Task<DescribeSubscriptionMetaResponse> DescribeSubscriptionMetaWithOptionsAsync(DescribeSubscriptionMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeSubscriptionMetaShrinkRequest request = new DescribeSubscriptionMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubMigrationJobIds))
            {
                request.SubMigrationJobIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubMigrationJobIds, "SubMigrationJobIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Topics))
            {
                request.TopicsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Topics, "Topics", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sid))
            {
                query["Sid"] = request.Sid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubMigrationJobIdsShrink))
            {
                query["SubMigrationJobIds"] = request.SubMigrationJobIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicsShrink))
            {
                query["Topics"] = request.TopicsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSubscriptionMeta",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSubscriptionMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   When Data Transmission Service (DTS) tracks data changes from a PolarDB-X 1.0 instance, data is distributed across the attached ApsaraDB RDS for MySQL instances. DTS runs a subtask for each ApsaraDB RDS for MySQL instance. You can call this operation to query the details of the subtasks in a distributed change tracking task.
          * *   You can call the [DescribeDtsJobs](~~209702~~) operation to query the ID of the change tracking instance and the ID of the consumer group.
          *
          * @param request DescribeSubscriptionMetaRequest
          * @return DescribeSubscriptionMetaResponse
         */
        public DescribeSubscriptionMetaResponse DescribeSubscriptionMeta(DescribeSubscriptionMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSubscriptionMetaWithOptions(request, runtime);
        }

        /**
          * *   When Data Transmission Service (DTS) tracks data changes from a PolarDB-X 1.0 instance, data is distributed across the attached ApsaraDB RDS for MySQL instances. DTS runs a subtask for each ApsaraDB RDS for MySQL instance. You can call this operation to query the details of the subtasks in a distributed change tracking task.
          * *   You can call the [DescribeDtsJobs](~~209702~~) operation to query the ID of the change tracking instance and the ID of the consumer group.
          *
          * @param request DescribeSubscriptionMetaRequest
          * @return DescribeSubscriptionMetaResponse
         */
        public async Task<DescribeSubscriptionMetaResponse> DescribeSubscriptionMetaAsync(DescribeSubscriptionMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSubscriptionMetaWithOptionsAsync(request, runtime);
        }

        public DescribeSynchronizationJobAlertResponse DescribeSynchronizationJobAlertWithOptions(DescribeSynchronizationJobAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSynchronizationJobAlert",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSynchronizationJobAlertResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSynchronizationJobAlertResponse> DescribeSynchronizationJobAlertWithOptionsAsync(DescribeSynchronizationJobAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSynchronizationJobAlert",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSynchronizationJobAlertResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSynchronizationJobAlertResponse DescribeSynchronizationJobAlert(DescribeSynchronizationJobAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSynchronizationJobAlertWithOptions(request, runtime);
        }

        public async Task<DescribeSynchronizationJobAlertResponse> DescribeSynchronizationJobAlertAsync(DescribeSynchronizationJobAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSynchronizationJobAlertWithOptionsAsync(request, runtime);
        }

        public DescribeSynchronizationJobReplicatorCompareResponse DescribeSynchronizationJobReplicatorCompareWithOptions(DescribeSynchronizationJobReplicatorCompareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSynchronizationJobReplicatorCompare",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSynchronizationJobReplicatorCompareResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSynchronizationJobReplicatorCompareResponse> DescribeSynchronizationJobReplicatorCompareWithOptionsAsync(DescribeSynchronizationJobReplicatorCompareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSynchronizationJobReplicatorCompare",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSynchronizationJobReplicatorCompareResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSynchronizationJobReplicatorCompareResponse DescribeSynchronizationJobReplicatorCompare(DescribeSynchronizationJobReplicatorCompareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSynchronizationJobReplicatorCompareWithOptions(request, runtime);
        }

        public async Task<DescribeSynchronizationJobReplicatorCompareResponse> DescribeSynchronizationJobReplicatorCompareAsync(DescribeSynchronizationJobReplicatorCompareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSynchronizationJobReplicatorCompareWithOptionsAsync(request, runtime);
        }

        public DescribeSynchronizationJobStatusResponse DescribeSynchronizationJobStatusWithOptions(DescribeSynchronizationJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSynchronizationJobStatus",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSynchronizationJobStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSynchronizationJobStatusResponse> DescribeSynchronizationJobStatusWithOptionsAsync(DescribeSynchronizationJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSynchronizationJobStatus",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSynchronizationJobStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSynchronizationJobStatusResponse DescribeSynchronizationJobStatus(DescribeSynchronizationJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSynchronizationJobStatusWithOptions(request, runtime);
        }

        public async Task<DescribeSynchronizationJobStatusResponse> DescribeSynchronizationJobStatusAsync(DescribeSynchronizationJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSynchronizationJobStatusWithOptionsAsync(request, runtime);
        }

        public DescribeSynchronizationJobStatusListResponse DescribeSynchronizationJobStatusListWithOptions(DescribeSynchronizationJobStatusListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobIdListJsonStr))
            {
                query["SynchronizationJobIdListJsonStr"] = request.SynchronizationJobIdListJsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSynchronizationJobStatusList",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSynchronizationJobStatusListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSynchronizationJobStatusListResponse> DescribeSynchronizationJobStatusListWithOptionsAsync(DescribeSynchronizationJobStatusListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobIdListJsonStr))
            {
                query["SynchronizationJobIdListJsonStr"] = request.SynchronizationJobIdListJsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSynchronizationJobStatusList",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSynchronizationJobStatusListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSynchronizationJobStatusListResponse DescribeSynchronizationJobStatusList(DescribeSynchronizationJobStatusListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSynchronizationJobStatusListWithOptions(request, runtime);
        }

        public async Task<DescribeSynchronizationJobStatusListResponse> DescribeSynchronizationJobStatusListAsync(DescribeSynchronizationJobStatusListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSynchronizationJobStatusListWithOptionsAsync(request, runtime);
        }

        public DescribeSynchronizationJobsResponse DescribeSynchronizationJobsWithOptions(DescribeSynchronizationJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobName))
            {
                query["SynchronizationJobName"] = request.SynchronizationJobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSynchronizationJobs",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSynchronizationJobsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSynchronizationJobsResponse> DescribeSynchronizationJobsWithOptionsAsync(DescribeSynchronizationJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobName))
            {
                query["SynchronizationJobName"] = request.SynchronizationJobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSynchronizationJobs",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSynchronizationJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSynchronizationJobsResponse DescribeSynchronizationJobs(DescribeSynchronizationJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSynchronizationJobsWithOptions(request, runtime);
        }

        public async Task<DescribeSynchronizationJobsResponse> DescribeSynchronizationJobsAsync(DescribeSynchronizationJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSynchronizationJobsWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, you must call the [ModifySynchronizationObject](~~49451~~) operation to obtain the task ID.
          *
          * @param request DescribeSynchronizationObjectModifyStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeSynchronizationObjectModifyStatusResponse
         */
        public DescribeSynchronizationObjectModifyStatusResponse DescribeSynchronizationObjectModifyStatusWithOptions(DescribeSynchronizationObjectModifyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeSynchronizationObjectModifyStatus",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSynchronizationObjectModifyStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, you must call the [ModifySynchronizationObject](~~49451~~) operation to obtain the task ID.
          *
          * @param request DescribeSynchronizationObjectModifyStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeSynchronizationObjectModifyStatusResponse
         */
        public async Task<DescribeSynchronizationObjectModifyStatusResponse> DescribeSynchronizationObjectModifyStatusWithOptionsAsync(DescribeSynchronizationObjectModifyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeSynchronizationObjectModifyStatus",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSynchronizationObjectModifyStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, you must call the [ModifySynchronizationObject](~~49451~~) operation to obtain the task ID.
          *
          * @param request DescribeSynchronizationObjectModifyStatusRequest
          * @return DescribeSynchronizationObjectModifyStatusResponse
         */
        public DescribeSynchronizationObjectModifyStatusResponse DescribeSynchronizationObjectModifyStatus(DescribeSynchronizationObjectModifyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSynchronizationObjectModifyStatusWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, you must call the [ModifySynchronizationObject](~~49451~~) operation to obtain the task ID.
          *
          * @param request DescribeSynchronizationObjectModifyStatusRequest
          * @return DescribeSynchronizationObjectModifyStatusResponse
         */
        public async Task<DescribeSynchronizationObjectModifyStatusResponse> DescribeSynchronizationObjectModifyStatusAsync(DescribeSynchronizationObjectModifyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSynchronizationObjectModifyStatusWithOptionsAsync(request, runtime);
        }

        public DescribeTagKeysResponse DescribeTagKeysWithOptions(DescribeTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeTagKeys",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTagKeysResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeTagKeysResponse> DescribeTagKeysWithOptionsAsync(DescribeTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeTagKeys",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTagKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeTagKeysResponse DescribeTagKeys(DescribeTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTagKeysWithOptions(request, runtime);
        }

        public async Task<DescribeTagKeysResponse> DescribeTagKeysAsync(DescribeTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTagKeysWithOptionsAsync(request, runtime);
        }

        public DescribeTagValuesResponse DescribeTagValuesWithOptions(DescribeTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeTagValues",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTagValuesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeTagValuesResponse> DescribeTagValuesWithOptionsAsync(DescribeTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeTagValues",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTagValuesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeTagValuesResponse DescribeTagValues(DescribeTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTagValuesWithOptions(request, runtime);
        }

        public async Task<DescribeTagValuesResponse> DescribeTagValuesAsync(DescribeTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTagValuesWithOptionsAsync(request, runtime);
        }

        /**
          * *   The node must be an ApsaraDB RDS for MySQL instance or a self-managed MySQL database that is connected over Cloud Enterprise Network (CEN).
          * *   This operation is used to initialize the built-in account named rdsdt_dtsacct on a node of an active geo-redundancy database cluster. DTS uses this account to connect to the node and perform data synchronization tasks.
          *
          * @param request InitDtsRdsInstanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return InitDtsRdsInstanceResponse
         */
        public InitDtsRdsInstanceResponse InitDtsRdsInstanceWithOptions(InitDtsRdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointCenId))
            {
                query["EndpointCenId"] = request.EndpointCenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointInstanceId))
            {
                query["EndpointInstanceId"] = request.EndpointInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointInstanceType))
            {
                query["EndpointInstanceType"] = request.EndpointInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointRegion))
            {
                query["EndpointRegion"] = request.EndpointRegion;
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
                Action = "InitDtsRdsInstance",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitDtsRdsInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   The node must be an ApsaraDB RDS for MySQL instance or a self-managed MySQL database that is connected over Cloud Enterprise Network (CEN).
          * *   This operation is used to initialize the built-in account named rdsdt_dtsacct on a node of an active geo-redundancy database cluster. DTS uses this account to connect to the node and perform data synchronization tasks.
          *
          * @param request InitDtsRdsInstanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return InitDtsRdsInstanceResponse
         */
        public async Task<InitDtsRdsInstanceResponse> InitDtsRdsInstanceWithOptionsAsync(InitDtsRdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointCenId))
            {
                query["EndpointCenId"] = request.EndpointCenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointInstanceId))
            {
                query["EndpointInstanceId"] = request.EndpointInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointInstanceType))
            {
                query["EndpointInstanceType"] = request.EndpointInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointRegion))
            {
                query["EndpointRegion"] = request.EndpointRegion;
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
                Action = "InitDtsRdsInstance",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitDtsRdsInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   The node must be an ApsaraDB RDS for MySQL instance or a self-managed MySQL database that is connected over Cloud Enterprise Network (CEN).
          * *   This operation is used to initialize the built-in account named rdsdt_dtsacct on a node of an active geo-redundancy database cluster. DTS uses this account to connect to the node and perform data synchronization tasks.
          *
          * @param request InitDtsRdsInstanceRequest
          * @return InitDtsRdsInstanceResponse
         */
        public InitDtsRdsInstanceResponse InitDtsRdsInstance(InitDtsRdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitDtsRdsInstanceWithOptions(request, runtime);
        }

        /**
          * *   The node must be an ApsaraDB RDS for MySQL instance or a self-managed MySQL database that is connected over Cloud Enterprise Network (CEN).
          * *   This operation is used to initialize the built-in account named rdsdt_dtsacct on a node of an active geo-redundancy database cluster. DTS uses this account to connect to the node and perform data synchronization tasks.
          *
          * @param request InitDtsRdsInstanceRequest
          * @return InitDtsRdsInstanceResponse
         */
        public async Task<InitDtsRdsInstanceResponse> InitDtsRdsInstanceAsync(InitDtsRdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitDtsRdsInstanceWithOptionsAsync(request, runtime);
        }

        public ListDedicatedClusterResponse ListDedicatedClusterWithOptions(ListDedicatedClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderColumn))
            {
                query["OrderColumn"] = request.OrderColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["OrderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
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
                Action = "ListDedicatedCluster",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDedicatedClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDedicatedClusterResponse> ListDedicatedClusterWithOptionsAsync(ListDedicatedClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderColumn))
            {
                query["OrderColumn"] = request.OrderColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["OrderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
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
                Action = "ListDedicatedCluster",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDedicatedClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDedicatedClusterResponse ListDedicatedCluster(ListDedicatedClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDedicatedClusterWithOptions(request, runtime);
        }

        public async Task<ListDedicatedClusterResponse> ListDedicatedClusterAsync(ListDedicatedClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDedicatedClusterWithOptionsAsync(request, runtime);
        }

        /**
          * ****
          *
          * @param request ListTagResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ****
          *
          * @param request ListTagResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ****
          *
          * @param request ListTagResourcesRequest
          * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /**
          * ****
          *
          * @param request ListTagResourcesRequest
          * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        public ModifyConsumerChannelResponse ModifyConsumerChannelWithOptions(ModifyConsumerChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupId))
            {
                query["ConsumerGroupId"] = request.ConsumerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupName))
            {
                query["ConsumerGroupName"] = request.ConsumerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupPassword))
            {
                query["ConsumerGroupPassword"] = request.ConsumerGroupPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupUserName))
            {
                query["ConsumerGroupUserName"] = request.ConsumerGroupUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
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
                Action = "ModifyConsumerChannel",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyConsumerChannelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyConsumerChannelResponse> ModifyConsumerChannelWithOptionsAsync(ModifyConsumerChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupId))
            {
                query["ConsumerGroupId"] = request.ConsumerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupName))
            {
                query["ConsumerGroupName"] = request.ConsumerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupPassword))
            {
                query["ConsumerGroupPassword"] = request.ConsumerGroupPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupUserName))
            {
                query["ConsumerGroupUserName"] = request.ConsumerGroupUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
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
                Action = "ModifyConsumerChannel",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyConsumerChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyConsumerChannelResponse ModifyConsumerChannel(ModifyConsumerChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyConsumerChannelWithOptions(request, runtime);
        }

        public async Task<ModifyConsumerChannelResponse> ModifyConsumerChannelAsync(ModifyConsumerChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyConsumerChannelWithOptionsAsync(request, runtime);
        }

        /**
          * > 
          * *   This operation is applicable to only the new version of the change tracking feature. To use the new version, you must specify the SubscriptionInstanceNetworkType parameter when you call the ConfigureSubscriptionInstance operation. If you use the previous version, you do not need to specify the **SubscriptionInstanceNetworkType** parameter.
          * *   When you call this operation, the change tracking task must be in the NotStarted, Failed, Normal, or Abnormal state.
          *
          * @param request ModifyConsumerGroupPasswordRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyConsumerGroupPasswordResponse
         */
        public ModifyConsumerGroupPasswordResponse ModifyConsumerGroupPasswordWithOptions(ModifyConsumerGroupPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupID))
            {
                query["ConsumerGroupID"] = request.ConsumerGroupID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupName))
            {
                query["ConsumerGroupName"] = request.ConsumerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupPassword))
            {
                query["ConsumerGroupPassword"] = request.ConsumerGroupPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupUserName))
            {
                query["ConsumerGroupUserName"] = request.ConsumerGroupUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupNewPassword))
            {
                query["consumerGroupNewPassword"] = request.ConsumerGroupNewPassword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyConsumerGroupPassword",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyConsumerGroupPasswordResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > 
          * *   This operation is applicable to only the new version of the change tracking feature. To use the new version, you must specify the SubscriptionInstanceNetworkType parameter when you call the ConfigureSubscriptionInstance operation. If you use the previous version, you do not need to specify the **SubscriptionInstanceNetworkType** parameter.
          * *   When you call this operation, the change tracking task must be in the NotStarted, Failed, Normal, or Abnormal state.
          *
          * @param request ModifyConsumerGroupPasswordRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyConsumerGroupPasswordResponse
         */
        public async Task<ModifyConsumerGroupPasswordResponse> ModifyConsumerGroupPasswordWithOptionsAsync(ModifyConsumerGroupPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupID))
            {
                query["ConsumerGroupID"] = request.ConsumerGroupID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupName))
            {
                query["ConsumerGroupName"] = request.ConsumerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupPassword))
            {
                query["ConsumerGroupPassword"] = request.ConsumerGroupPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupUserName))
            {
                query["ConsumerGroupUserName"] = request.ConsumerGroupUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupNewPassword))
            {
                query["consumerGroupNewPassword"] = request.ConsumerGroupNewPassword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyConsumerGroupPassword",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyConsumerGroupPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > 
          * *   This operation is applicable to only the new version of the change tracking feature. To use the new version, you must specify the SubscriptionInstanceNetworkType parameter when you call the ConfigureSubscriptionInstance operation. If you use the previous version, you do not need to specify the **SubscriptionInstanceNetworkType** parameter.
          * *   When you call this operation, the change tracking task must be in the NotStarted, Failed, Normal, or Abnormal state.
          *
          * @param request ModifyConsumerGroupPasswordRequest
          * @return ModifyConsumerGroupPasswordResponse
         */
        public ModifyConsumerGroupPasswordResponse ModifyConsumerGroupPassword(ModifyConsumerGroupPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyConsumerGroupPasswordWithOptions(request, runtime);
        }

        /**
          * > 
          * *   This operation is applicable to only the new version of the change tracking feature. To use the new version, you must specify the SubscriptionInstanceNetworkType parameter when you call the ConfigureSubscriptionInstance operation. If you use the previous version, you do not need to specify the **SubscriptionInstanceNetworkType** parameter.
          * *   When you call this operation, the change tracking task must be in the NotStarted, Failed, Normal, or Abnormal state.
          *
          * @param request ModifyConsumerGroupPasswordRequest
          * @return ModifyConsumerGroupPasswordResponse
         */
        public async Task<ModifyConsumerGroupPasswordResponse> ModifyConsumerGroupPasswordAsync(ModifyConsumerGroupPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyConsumerGroupPasswordWithOptionsAsync(request, runtime);
        }

        /**
          * > 
          * *   This operation is applicable to only the previous version of the change tracking feature. To use the new version, you must specify the SubscriptionInstanceNetworkType parameter when you call the [ConfigureSubscriptionInstance](~~49437~~) operation. If you use the previous version, you do not need to specify the **SubscriptionInstanceNetworkType** parameter.
          * *   If you use the new version, you need to set the consumption checkpoint on the change tracking client.
          * *   When you call this operation, you must stop the change tracking client, and the change tracking task must be in the Normal state.
          *
          * @param request ModifyConsumptionTimestampRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyConsumptionTimestampResponse
         */
        public ModifyConsumptionTimestampResponse ModifyConsumptionTimestampWithOptions(ModifyConsumptionTimestampRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumptionTimestamp))
            {
                query["ConsumptionTimestamp"] = request.ConsumptionTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyConsumptionTimestamp",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyConsumptionTimestampResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > 
          * *   This operation is applicable to only the previous version of the change tracking feature. To use the new version, you must specify the SubscriptionInstanceNetworkType parameter when you call the [ConfigureSubscriptionInstance](~~49437~~) operation. If you use the previous version, you do not need to specify the **SubscriptionInstanceNetworkType** parameter.
          * *   If you use the new version, you need to set the consumption checkpoint on the change tracking client.
          * *   When you call this operation, you must stop the change tracking client, and the change tracking task must be in the Normal state.
          *
          * @param request ModifyConsumptionTimestampRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyConsumptionTimestampResponse
         */
        public async Task<ModifyConsumptionTimestampResponse> ModifyConsumptionTimestampWithOptionsAsync(ModifyConsumptionTimestampRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumptionTimestamp))
            {
                query["ConsumptionTimestamp"] = request.ConsumptionTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyConsumptionTimestamp",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyConsumptionTimestampResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > 
          * *   This operation is applicable to only the previous version of the change tracking feature. To use the new version, you must specify the SubscriptionInstanceNetworkType parameter when you call the [ConfigureSubscriptionInstance](~~49437~~) operation. If you use the previous version, you do not need to specify the **SubscriptionInstanceNetworkType** parameter.
          * *   If you use the new version, you need to set the consumption checkpoint on the change tracking client.
          * *   When you call this operation, you must stop the change tracking client, and the change tracking task must be in the Normal state.
          *
          * @param request ModifyConsumptionTimestampRequest
          * @return ModifyConsumptionTimestampResponse
         */
        public ModifyConsumptionTimestampResponse ModifyConsumptionTimestamp(ModifyConsumptionTimestampRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyConsumptionTimestampWithOptions(request, runtime);
        }

        /**
          * > 
          * *   This operation is applicable to only the previous version of the change tracking feature. To use the new version, you must specify the SubscriptionInstanceNetworkType parameter when you call the [ConfigureSubscriptionInstance](~~49437~~) operation. If you use the previous version, you do not need to specify the **SubscriptionInstanceNetworkType** parameter.
          * *   If you use the new version, you need to set the consumption checkpoint on the change tracking client.
          * *   When you call this operation, you must stop the change tracking client, and the change tracking task must be in the Normal state.
          *
          * @param request ModifyConsumptionTimestampRequest
          * @return ModifyConsumptionTimestampResponse
         */
        public async Task<ModifyConsumptionTimestampResponse> ModifyConsumptionTimestampAsync(ModifyConsumptionTimestampRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyConsumptionTimestampWithOptionsAsync(request, runtime);
        }

        /**
          * You can modify only the overcommit ratio.
          *
          * @param request ModifyDedicatedClusterRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyDedicatedClusterResponse
         */
        public ModifyDedicatedClusterResponse ModifyDedicatedClusterWithOptions(ModifyDedicatedClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                query["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterName))
            {
                query["DedicatedClusterName"] = request.DedicatedClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OversoldRatio))
            {
                query["OversoldRatio"] = request.OversoldRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "ModifyDedicatedCluster",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDedicatedClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can modify only the overcommit ratio.
          *
          * @param request ModifyDedicatedClusterRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyDedicatedClusterResponse
         */
        public async Task<ModifyDedicatedClusterResponse> ModifyDedicatedClusterWithOptionsAsync(ModifyDedicatedClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                query["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterName))
            {
                query["DedicatedClusterName"] = request.DedicatedClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OversoldRatio))
            {
                query["OversoldRatio"] = request.OversoldRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "ModifyDedicatedCluster",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDedicatedClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can modify only the overcommit ratio.
          *
          * @param request ModifyDedicatedClusterRequest
          * @return ModifyDedicatedClusterResponse
         */
        public ModifyDedicatedClusterResponse ModifyDedicatedCluster(ModifyDedicatedClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedClusterWithOptions(request, runtime);
        }

        /**
          * You can modify only the overcommit ratio.
          *
          * @param request ModifyDedicatedClusterRequest
          * @return ModifyDedicatedClusterResponse
         */
        public async Task<ModifyDedicatedClusterResponse> ModifyDedicatedClusterAsync(ModifyDedicatedClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedClusterWithOptionsAsync(request, runtime);
        }

        public ModifyDtsJobResponse ModifyDtsJobWithOptions(ModifyDtsJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyDtsJobShrinkRequest request = new ModifyDtsJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DbList))
            {
                request.DbListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DbList, "DbList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataInitialization))
            {
                query["DataInitialization"] = request.DataInitialization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSynchronization))
            {
                query["DataSynchronization"] = request.DataSynchronization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileOssUrl))
            {
                query["FileOssUrl"] = request.FileOssUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructureInitialization))
            {
                query["StructureInitialization"] = request.StructureInitialization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbListShrink))
            {
                body["DbList"] = request.DbListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EtlOperatorColumnReference))
            {
                body["EtlOperatorColumnReference"] = request.EtlOperatorColumnReference;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterTableName))
            {
                body["FilterTableName"] = request.FilterTableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyTypeEnum))
            {
                body["ModifyTypeEnum"] = request.ModifyTypeEnum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reserved))
            {
                body["Reserved"] = request.Reserved;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDtsJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDtsJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDtsJobResponse> ModifyDtsJobWithOptionsAsync(ModifyDtsJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyDtsJobShrinkRequest request = new ModifyDtsJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DbList))
            {
                request.DbListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DbList, "DbList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataInitialization))
            {
                query["DataInitialization"] = request.DataInitialization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSynchronization))
            {
                query["DataSynchronization"] = request.DataSynchronization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileOssUrl))
            {
                query["FileOssUrl"] = request.FileOssUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructureInitialization))
            {
                query["StructureInitialization"] = request.StructureInitialization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbListShrink))
            {
                body["DbList"] = request.DbListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EtlOperatorColumnReference))
            {
                body["EtlOperatorColumnReference"] = request.EtlOperatorColumnReference;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterTableName))
            {
                body["FilterTableName"] = request.FilterTableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyTypeEnum))
            {
                body["ModifyTypeEnum"] = request.ModifyTypeEnum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reserved))
            {
                body["Reserved"] = request.Reserved;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDtsJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDtsJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDtsJobResponse ModifyDtsJob(ModifyDtsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDtsJobWithOptions(request, runtime);
        }

        public async Task<ModifyDtsJobResponse> ModifyDtsJobAsync(ModifyDtsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDtsJobWithOptionsAsync(request, runtime);
        }

        public ModifyDtsJobResponse ModifyDtsJobAdvance(ModifyDtsJobAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "Dts",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = null;
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            ModifyDtsJobRequest modifyDtsJobReq = new ModifyDtsJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, modifyDtsJobReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileOssUrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileOssUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                modifyDtsJobReq.FileOssUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            ModifyDtsJobResponse modifyDtsJobResp = ModifyDtsJobWithOptions(modifyDtsJobReq, runtime);
            return modifyDtsJobResp;
        }

        public async Task<ModifyDtsJobResponse> ModifyDtsJobAdvanceAsync(ModifyDtsJobAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "Dts",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = null;
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            ModifyDtsJobRequest modifyDtsJobReq = new ModifyDtsJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, modifyDtsJobReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileOssUrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileOssUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                modifyDtsJobReq.FileOssUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            ModifyDtsJobResponse modifyDtsJobResp = await ModifyDtsJobWithOptionsAsync(modifyDtsJobReq, runtime);
            return modifyDtsJobResp;
        }

        public ModifyDtsJobDedicatedClusterResponse ModifyDtsJobDedicatedClusterWithOptions(ModifyDtsJobDedicatedClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                query["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobIds))
            {
                query["DtsJobIds"] = request.DtsJobIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "ModifyDtsJobDedicatedCluster",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDtsJobDedicatedClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDtsJobDedicatedClusterResponse> ModifyDtsJobDedicatedClusterWithOptionsAsync(ModifyDtsJobDedicatedClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                query["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobIds))
            {
                query["DtsJobIds"] = request.DtsJobIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "ModifyDtsJobDedicatedCluster",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDtsJobDedicatedClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDtsJobDedicatedClusterResponse ModifyDtsJobDedicatedCluster(ModifyDtsJobDedicatedClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDtsJobDedicatedClusterWithOptions(request, runtime);
        }

        public async Task<ModifyDtsJobDedicatedClusterResponse> ModifyDtsJobDedicatedClusterAsync(ModifyDtsJobDedicatedClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDtsJobDedicatedClusterWithOptionsAsync(request, runtime);
        }

        /**
          * *   DTS allows you to upgrade or downgrade the configurations of DTS instances in a dedicated cluster. You can adjust the resources that are occupied for task execution to dynamically adjust the number of tasks that can be scheduled in the cluster. This way, you can reduce the total number of DUs required for the cluster or release DUs.
          * *   Before you modify the upper limit of DUs for a DTS task, make sure that sufficient DUs are available.
          *
          * @param request ModifyDtsJobDuLimitRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyDtsJobDuLimitResponse
         */
        public ModifyDtsJobDuLimitResponse ModifyDtsJobDuLimitWithOptions(ModifyDtsJobDuLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuLimit))
            {
                query["DuLimit"] = request.DuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "ModifyDtsJobDuLimit",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDtsJobDuLimitResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   DTS allows you to upgrade or downgrade the configurations of DTS instances in a dedicated cluster. You can adjust the resources that are occupied for task execution to dynamically adjust the number of tasks that can be scheduled in the cluster. This way, you can reduce the total number of DUs required for the cluster or release DUs.
          * *   Before you modify the upper limit of DUs for a DTS task, make sure that sufficient DUs are available.
          *
          * @param request ModifyDtsJobDuLimitRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyDtsJobDuLimitResponse
         */
        public async Task<ModifyDtsJobDuLimitResponse> ModifyDtsJobDuLimitWithOptionsAsync(ModifyDtsJobDuLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuLimit))
            {
                query["DuLimit"] = request.DuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "ModifyDtsJobDuLimit",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDtsJobDuLimitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   DTS allows you to upgrade or downgrade the configurations of DTS instances in a dedicated cluster. You can adjust the resources that are occupied for task execution to dynamically adjust the number of tasks that can be scheduled in the cluster. This way, you can reduce the total number of DUs required for the cluster or release DUs.
          * *   Before you modify the upper limit of DUs for a DTS task, make sure that sufficient DUs are available.
          *
          * @param request ModifyDtsJobDuLimitRequest
          * @return ModifyDtsJobDuLimitResponse
         */
        public ModifyDtsJobDuLimitResponse ModifyDtsJobDuLimit(ModifyDtsJobDuLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDtsJobDuLimitWithOptions(request, runtime);
        }

        /**
          * *   DTS allows you to upgrade or downgrade the configurations of DTS instances in a dedicated cluster. You can adjust the resources that are occupied for task execution to dynamically adjust the number of tasks that can be scheduled in the cluster. This way, you can reduce the total number of DUs required for the cluster or release DUs.
          * *   Before you modify the upper limit of DUs for a DTS task, make sure that sufficient DUs are available.
          *
          * @param request ModifyDtsJobDuLimitRequest
          * @return ModifyDtsJobDuLimitResponse
         */
        public async Task<ModifyDtsJobDuLimitResponse> ModifyDtsJobDuLimitAsync(ModifyDtsJobDuLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDtsJobDuLimitWithOptionsAsync(request, runtime);
        }

        public ModifyDtsJobNameResponse ModifyDtsJobNameWithOptions(ModifyDtsJobNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobName))
            {
                query["DtsJobName"] = request.DtsJobName;
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
                Action = "ModifyDtsJobName",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDtsJobNameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDtsJobNameResponse> ModifyDtsJobNameWithOptionsAsync(ModifyDtsJobNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobName))
            {
                query["DtsJobName"] = request.DtsJobName;
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
                Action = "ModifyDtsJobName",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDtsJobNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDtsJobNameResponse ModifyDtsJobName(ModifyDtsJobNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDtsJobNameWithOptions(request, runtime);
        }

        public async Task<ModifyDtsJobNameResponse> ModifyDtsJobNameAsync(ModifyDtsJobNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDtsJobNameWithOptionsAsync(request, runtime);
        }

        public ModifyDtsJobPasswordResponse ModifyDtsJobPasswordWithOptions(ModifyDtsJobPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endpoint))
            {
                query["Endpoint"] = request.Endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "ModifyDtsJobPassword",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDtsJobPasswordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDtsJobPasswordResponse> ModifyDtsJobPasswordWithOptionsAsync(ModifyDtsJobPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endpoint))
            {
                query["Endpoint"] = request.Endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "ModifyDtsJobPassword",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDtsJobPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDtsJobPasswordResponse ModifyDtsJobPassword(ModifyDtsJobPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDtsJobPasswordWithOptions(request, runtime);
        }

        public async Task<ModifyDtsJobPasswordResponse> ModifyDtsJobPasswordAsync(ModifyDtsJobPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDtsJobPasswordWithOptionsAsync(request, runtime);
        }

        public ModifyDynamicConfigResponse ModifyDynamicConfigWithOptions(ModifyDynamicConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigList))
            {
                query["ConfigList"] = request.ConfigList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableLimit))
            {
                query["EnableLimit"] = request.EnableLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobCode))
            {
                query["JobCode"] = request.JobCode;
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
                Action = "ModifyDynamicConfig",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDynamicConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDynamicConfigResponse> ModifyDynamicConfigWithOptionsAsync(ModifyDynamicConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigList))
            {
                query["ConfigList"] = request.ConfigList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableLimit))
            {
                query["EnableLimit"] = request.EnableLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobCode))
            {
                query["JobCode"] = request.JobCode;
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
                Action = "ModifyDynamicConfig",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDynamicConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDynamicConfigResponse ModifyDynamicConfig(ModifyDynamicConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDynamicConfigWithOptions(request, runtime);
        }

        public async Task<ModifyDynamicConfigResponse> ModifyDynamicConfigAsync(ModifyDynamicConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDynamicConfigWithOptionsAsync(request, runtime);
        }

        public ModifySubscriptionResponse ModifySubscriptionWithOptions(ModifySubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbList))
            {
                query["DbList"] = request.DbList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionDataTypeDDL))
            {
                query["SubscriptionDataTypeDDL"] = request.SubscriptionDataTypeDDL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionDataTypeDML))
            {
                query["SubscriptionDataTypeDML"] = request.SubscriptionDataTypeDML;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySubscription",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySubscriptionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifySubscriptionResponse> ModifySubscriptionWithOptionsAsync(ModifySubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbList))
            {
                query["DbList"] = request.DbList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionDataTypeDDL))
            {
                query["SubscriptionDataTypeDDL"] = request.SubscriptionDataTypeDDL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionDataTypeDML))
            {
                query["SubscriptionDataTypeDML"] = request.SubscriptionDataTypeDML;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySubscription",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifySubscriptionResponse ModifySubscription(ModifySubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySubscriptionWithOptions(request, runtime);
        }

        public async Task<ModifySubscriptionResponse> ModifySubscriptionAsync(ModifySubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySubscriptionWithOptionsAsync(request, runtime);
        }

        /**
          * When you call this operation, the change tracking task must be in the Normal, NotStarted, or Failed state.
          * > 
          * *   If you call this operation to modify the objects of a change tracking task that is in the Normal state, DTS automatically calls the [StartSubscriptionInstance](~~49438~~) to restart the task.
          * *   If you call this operation to modify the objects of a change tracking task that is in the NotStarted or Failed state, DTS does not automatically start the task. You must call the [StartSubscriptionInstance](~~49438~~) to restart the task.
          *
          * @param request ModifySubscriptionObjectRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifySubscriptionObjectResponse
         */
        public ModifySubscriptionObjectResponse ModifySubscriptionObjectWithOptions(ModifySubscriptionObjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionObject))
            {
                query["SubscriptionObject"] = request.SubscriptionObject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySubscriptionObject",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySubscriptionObjectResponse>(CallApi(params_, req, runtime));
        }

        /**
          * When you call this operation, the change tracking task must be in the Normal, NotStarted, or Failed state.
          * > 
          * *   If you call this operation to modify the objects of a change tracking task that is in the Normal state, DTS automatically calls the [StartSubscriptionInstance](~~49438~~) to restart the task.
          * *   If you call this operation to modify the objects of a change tracking task that is in the NotStarted or Failed state, DTS does not automatically start the task. You must call the [StartSubscriptionInstance](~~49438~~) to restart the task.
          *
          * @param request ModifySubscriptionObjectRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifySubscriptionObjectResponse
         */
        public async Task<ModifySubscriptionObjectResponse> ModifySubscriptionObjectWithOptionsAsync(ModifySubscriptionObjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionObject))
            {
                query["SubscriptionObject"] = request.SubscriptionObject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySubscriptionObject",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySubscriptionObjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * When you call this operation, the change tracking task must be in the Normal, NotStarted, or Failed state.
          * > 
          * *   If you call this operation to modify the objects of a change tracking task that is in the Normal state, DTS automatically calls the [StartSubscriptionInstance](~~49438~~) to restart the task.
          * *   If you call this operation to modify the objects of a change tracking task that is in the NotStarted or Failed state, DTS does not automatically start the task. You must call the [StartSubscriptionInstance](~~49438~~) to restart the task.
          *
          * @param request ModifySubscriptionObjectRequest
          * @return ModifySubscriptionObjectResponse
         */
        public ModifySubscriptionObjectResponse ModifySubscriptionObject(ModifySubscriptionObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySubscriptionObjectWithOptions(request, runtime);
        }

        /**
          * When you call this operation, the change tracking task must be in the Normal, NotStarted, or Failed state.
          * > 
          * *   If you call this operation to modify the objects of a change tracking task that is in the Normal state, DTS automatically calls the [StartSubscriptionInstance](~~49438~~) to restart the task.
          * *   If you call this operation to modify the objects of a change tracking task that is in the NotStarted or Failed state, DTS does not automatically start the task. You must call the [StartSubscriptionInstance](~~49438~~) to restart the task.
          *
          * @param request ModifySubscriptionObjectRequest
          * @return ModifySubscriptionObjectResponse
         */
        public async Task<ModifySubscriptionObjectResponse> ModifySubscriptionObjectAsync(ModifySubscriptionObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySubscriptionObjectWithOptionsAsync(request, runtime);
        }

        /**
          * >  When you call this operation, the data synchronization task must be in the Not Started or Synchronizing state.
          *
          * @param request ModifySynchronizationObjectRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifySynchronizationObjectResponse
         */
        public ModifySynchronizationObjectResponse ModifySynchronizationObjectWithOptions(ModifySynchronizationObjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationObjects))
            {
                body["SynchronizationObjects"] = request.SynchronizationObjects;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySynchronizationObject",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySynchronizationObjectResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  When you call this operation, the data synchronization task must be in the Not Started or Synchronizing state.
          *
          * @param request ModifySynchronizationObjectRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifySynchronizationObjectResponse
         */
        public async Task<ModifySynchronizationObjectResponse> ModifySynchronizationObjectWithOptionsAsync(ModifySynchronizationObjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationObjects))
            {
                body["SynchronizationObjects"] = request.SynchronizationObjects;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySynchronizationObject",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySynchronizationObjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  When you call this operation, the data synchronization task must be in the Not Started or Synchronizing state.
          *
          * @param request ModifySynchronizationObjectRequest
          * @return ModifySynchronizationObjectResponse
         */
        public ModifySynchronizationObjectResponse ModifySynchronizationObject(ModifySynchronizationObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySynchronizationObjectWithOptions(request, runtime);
        }

        /**
          * >  When you call this operation, the data synchronization task must be in the Not Started or Synchronizing state.
          *
          * @param request ModifySynchronizationObjectRequest
          * @return ModifySynchronizationObjectResponse
         */
        public async Task<ModifySynchronizationObjectResponse> ModifySynchronizationObjectAsync(ModifySynchronizationObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySynchronizationObjectWithOptionsAsync(request, runtime);
        }

        public RenewInstanceResponse RenewInstanceWithOptions(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyCount))
            {
                query["BuyCount"] = request.BuyCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
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
                Action = "RenewInstance",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RenewInstanceResponse> RenewInstanceWithOptionsAsync(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyCount))
            {
                query["BuyCount"] = request.BuyCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
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
                Action = "RenewInstance",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RenewInstanceResponse RenewInstance(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewInstanceWithOptions(request, runtime);
        }

        public async Task<RenewInstanceResponse> RenewInstanceAsync(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewInstanceWithOptionsAsync(request, runtime);
        }

        /**
          * >  If you clear the configurations of a data synchronization or change tracking task, DTS deletes the task. Then, DTS creates another task. The task is in the Not Configured state. You must call the [ConfigureDtsJob](~~208399~~) operation reconfigure the task.
          *
          * @param request ResetDtsJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ResetDtsJobResponse
         */
        public ResetDtsJobResponse ResetDtsJobWithOptions(ResetDtsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetDtsJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetDtsJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  If you clear the configurations of a data synchronization or change tracking task, DTS deletes the task. Then, DTS creates another task. The task is in the Not Configured state. You must call the [ConfigureDtsJob](~~208399~~) operation reconfigure the task.
          *
          * @param request ResetDtsJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ResetDtsJobResponse
         */
        public async Task<ResetDtsJobResponse> ResetDtsJobWithOptionsAsync(ResetDtsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetDtsJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetDtsJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  If you clear the configurations of a data synchronization or change tracking task, DTS deletes the task. Then, DTS creates another task. The task is in the Not Configured state. You must call the [ConfigureDtsJob](~~208399~~) operation reconfigure the task.
          *
          * @param request ResetDtsJobRequest
          * @return ResetDtsJobResponse
         */
        public ResetDtsJobResponse ResetDtsJob(ResetDtsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetDtsJobWithOptions(request, runtime);
        }

        /**
          * >  If you clear the configurations of a data synchronization or change tracking task, DTS deletes the task. Then, DTS creates another task. The task is in the Not Configured state. You must call the [ConfigureDtsJob](~~208399~~) operation reconfigure the task.
          *
          * @param request ResetDtsJobRequest
          * @return ResetDtsJobResponse
         */
        public async Task<ResetDtsJobResponse> ResetDtsJobAsync(ResetDtsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetDtsJobWithOptionsAsync(request, runtime);
        }

        /**
          * >  If you clear the configurations of a data synchronization task, the task will be released. To start the task again, you must call the **ConfigureSynchronizationJob** operation to reconfigure the task.
          *
          * @param request ResetSynchronizationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ResetSynchronizationJobResponse
         */
        public ResetSynchronizationJobResponse ResetSynchronizationJobWithOptions(ResetSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetSynchronizationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetSynchronizationJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  If you clear the configurations of a data synchronization task, the task will be released. To start the task again, you must call the **ConfigureSynchronizationJob** operation to reconfigure the task.
          *
          * @param request ResetSynchronizationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ResetSynchronizationJobResponse
         */
        public async Task<ResetSynchronizationJobResponse> ResetSynchronizationJobWithOptionsAsync(ResetSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetSynchronizationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetSynchronizationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  If you clear the configurations of a data synchronization task, the task will be released. To start the task again, you must call the **ConfigureSynchronizationJob** operation to reconfigure the task.
          *
          * @param request ResetSynchronizationJobRequest
          * @return ResetSynchronizationJobResponse
         */
        public ResetSynchronizationJobResponse ResetSynchronizationJob(ResetSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetSynchronizationJobWithOptions(request, runtime);
        }

        /**
          * >  If you clear the configurations of a data synchronization task, the task will be released. To start the task again, you must call the **ConfigureSynchronizationJob** operation to reconfigure the task.
          *
          * @param request ResetSynchronizationJobRequest
          * @return ResetSynchronizationJobResponse
         */
        public async Task<ResetSynchronizationJobResponse> ResetSynchronizationJobAsync(ResetSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetSynchronizationJobWithOptionsAsync(request, runtime);
        }

        public ReverseTwoWayDirectionResponse ReverseTwoWayDirectionWithOptions(ReverseTwoWayDirectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreErrorSubJob))
            {
                query["IgnoreErrorSubJob"] = request.IgnoreErrorSubJob;
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
                Action = "ReverseTwoWayDirection",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReverseTwoWayDirectionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReverseTwoWayDirectionResponse> ReverseTwoWayDirectionWithOptionsAsync(ReverseTwoWayDirectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreErrorSubJob))
            {
                query["IgnoreErrorSubJob"] = request.IgnoreErrorSubJob;
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
                Action = "ReverseTwoWayDirection",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReverseTwoWayDirectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReverseTwoWayDirectionResponse ReverseTwoWayDirection(ReverseTwoWayDirectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReverseTwoWayDirectionWithOptions(request, runtime);
        }

        public async Task<ReverseTwoWayDirectionResponse> ReverseTwoWayDirectionAsync(ReverseTwoWayDirectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReverseTwoWayDirectionWithOptionsAsync(request, runtime);
        }

        /**
          * If you call this operation to ignore all precheck items, you must call the [StartMigrationJob](https://www.alibabacloud.com/help/zh/doc-detail/49429.htm) or [StartSynchronizationJob](https://www.alibabacloud.com/help/zh/doc-detail/49448.htm) operation. DTS performs a precheck again. After the data migration or synchronization task passes the precheck, the task will be automatically started.
          *
          * @param request ShieldPrecheckRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ShieldPrecheckResponse
         */
        public ShieldPrecheckResponse ShieldPrecheckWithOptions(ShieldPrecheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrecheckItems))
            {
                query["PrecheckItems"] = request.PrecheckItems;
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
                Action = "ShieldPrecheck",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ShieldPrecheckResponse>(CallApi(params_, req, runtime));
        }

        /**
          * If you call this operation to ignore all precheck items, you must call the [StartMigrationJob](https://www.alibabacloud.com/help/zh/doc-detail/49429.htm) or [StartSynchronizationJob](https://www.alibabacloud.com/help/zh/doc-detail/49448.htm) operation. DTS performs a precheck again. After the data migration or synchronization task passes the precheck, the task will be automatically started.
          *
          * @param request ShieldPrecheckRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ShieldPrecheckResponse
         */
        public async Task<ShieldPrecheckResponse> ShieldPrecheckWithOptionsAsync(ShieldPrecheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrecheckItems))
            {
                query["PrecheckItems"] = request.PrecheckItems;
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
                Action = "ShieldPrecheck",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ShieldPrecheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * If you call this operation to ignore all precheck items, you must call the [StartMigrationJob](https://www.alibabacloud.com/help/zh/doc-detail/49429.htm) or [StartSynchronizationJob](https://www.alibabacloud.com/help/zh/doc-detail/49448.htm) operation. DTS performs a precheck again. After the data migration or synchronization task passes the precheck, the task will be automatically started.
          *
          * @param request ShieldPrecheckRequest
          * @return ShieldPrecheckResponse
         */
        public ShieldPrecheckResponse ShieldPrecheck(ShieldPrecheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ShieldPrecheckWithOptions(request, runtime);
        }

        /**
          * If you call this operation to ignore all precheck items, you must call the [StartMigrationJob](https://www.alibabacloud.com/help/zh/doc-detail/49429.htm) or [StartSynchronizationJob](https://www.alibabacloud.com/help/zh/doc-detail/49448.htm) operation. DTS performs a precheck again. After the data migration or synchronization task passes the precheck, the task will be automatically started.
          *
          * @param request ShieldPrecheckRequest
          * @return ShieldPrecheckResponse
         */
        public async Task<ShieldPrecheckResponse> ShieldPrecheckAsync(ShieldPrecheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ShieldPrecheckWithOptionsAsync(request, runtime);
        }

        public SkipPreCheckResponse SkipPreCheckWithOptions(SkipPreCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                query["Skip"] = request.Skip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipPreCheckItems))
            {
                query["SkipPreCheckItems"] = request.SkipPreCheckItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipPreCheckNames))
            {
                query["SkipPreCheckNames"] = request.SkipPreCheckNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SkipPreCheck",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SkipPreCheckResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SkipPreCheckResponse> SkipPreCheckWithOptionsAsync(SkipPreCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                query["Skip"] = request.Skip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipPreCheckItems))
            {
                query["SkipPreCheckItems"] = request.SkipPreCheckItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipPreCheckNames))
            {
                query["SkipPreCheckNames"] = request.SkipPreCheckNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SkipPreCheck",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SkipPreCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SkipPreCheckResponse SkipPreCheck(SkipPreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SkipPreCheckWithOptions(request, runtime);
        }

        public async Task<SkipPreCheckResponse> SkipPreCheckAsync(SkipPreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SkipPreCheckWithOptionsAsync(request, runtime);
        }

        public StartDtsJobResponse StartDtsJobWithOptions(StartDtsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDtsJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDtsJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartDtsJobResponse> StartDtsJobWithOptionsAsync(StartDtsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDtsJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDtsJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartDtsJobResponse StartDtsJob(StartDtsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDtsJobWithOptions(request, runtime);
        }

        public async Task<StartDtsJobResponse> StartDtsJobAsync(StartDtsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDtsJobWithOptionsAsync(request, runtime);
        }

        public StartDtsJobsResponse StartDtsJobsWithOptions(StartDtsJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobIds))
            {
                query["DtsJobIds"] = request.DtsJobIds;
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
                Action = "StartDtsJobs",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDtsJobsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartDtsJobsResponse> StartDtsJobsWithOptionsAsync(StartDtsJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobIds))
            {
                query["DtsJobIds"] = request.DtsJobIds;
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
                Action = "StartDtsJobs",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDtsJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartDtsJobsResponse StartDtsJobs(StartDtsJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDtsJobsWithOptions(request, runtime);
        }

        public async Task<StartDtsJobsResponse> StartDtsJobsAsync(StartDtsJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDtsJobsWithOptionsAsync(request, runtime);
        }

        /**
          * >  When you call this operation, the data migration task must be in the Not Started, Paused, or Migration Failed state.
          *
          * @param request StartMigrationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartMigrationJobResponse
         */
        public StartMigrationJobResponse StartMigrationJobWithOptions(StartMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "StartMigrationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartMigrationJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  When you call this operation, the data migration task must be in the Not Started, Paused, or Migration Failed state.
          *
          * @param request StartMigrationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartMigrationJobResponse
         */
        public async Task<StartMigrationJobResponse> StartMigrationJobWithOptionsAsync(StartMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "StartMigrationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartMigrationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  When you call this operation, the data migration task must be in the Not Started, Paused, or Migration Failed state.
          *
          * @param request StartMigrationJobRequest
          * @return StartMigrationJobResponse
         */
        public StartMigrationJobResponse StartMigrationJob(StartMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartMigrationJobWithOptions(request, runtime);
        }

        /**
          * >  When you call this operation, the data migration task must be in the Not Started, Paused, or Migration Failed state.
          *
          * @param request StartMigrationJobRequest
          * @return StartMigrationJobResponse
         */
        public async Task<StartMigrationJobResponse> StartMigrationJobAsync(StartMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartMigrationJobWithOptionsAsync(request, runtime);
        }

        /**
          * When you call this operation, the change tracking task must be in the NotStarted or Failed state.
          *
          * @param request StartSubscriptionInstanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartSubscriptionInstanceResponse
         */
        public StartSubscriptionInstanceResponse StartSubscriptionInstanceWithOptions(StartSubscriptionInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartSubscriptionInstance",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartSubscriptionInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * When you call this operation, the change tracking task must be in the NotStarted or Failed state.
          *
          * @param request StartSubscriptionInstanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartSubscriptionInstanceResponse
         */
        public async Task<StartSubscriptionInstanceResponse> StartSubscriptionInstanceWithOptionsAsync(StartSubscriptionInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartSubscriptionInstance",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartSubscriptionInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * When you call this operation, the change tracking task must be in the NotStarted or Failed state.
          *
          * @param request StartSubscriptionInstanceRequest
          * @return StartSubscriptionInstanceResponse
         */
        public StartSubscriptionInstanceResponse StartSubscriptionInstance(StartSubscriptionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartSubscriptionInstanceWithOptions(request, runtime);
        }

        /**
          * When you call this operation, the change tracking task must be in the NotStarted or Failed state.
          *
          * @param request StartSubscriptionInstanceRequest
          * @return StartSubscriptionInstanceResponse
         */
        public async Task<StartSubscriptionInstanceResponse> StartSubscriptionInstanceAsync(StartSubscriptionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartSubscriptionInstanceWithOptionsAsync(request, runtime);
        }

        /**
          * > 
          * *   Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service) of Data Transmission Service (DTS).
          * *   When you call this operation, the data synchronization task must be in the NotStarted, Failed, or Suspending state. If you call this operation to start a task that is in the NotStarted state, the task will be prechecked.
          *
          * @param request StartSynchronizationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartSynchronizationJobResponse
         */
        public StartSynchronizationJobResponse StartSynchronizationJobWithOptions(StartSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartSynchronizationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartSynchronizationJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > 
          * *   Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service) of Data Transmission Service (DTS).
          * *   When you call this operation, the data synchronization task must be in the NotStarted, Failed, or Suspending state. If you call this operation to start a task that is in the NotStarted state, the task will be prechecked.
          *
          * @param request StartSynchronizationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartSynchronizationJobResponse
         */
        public async Task<StartSynchronizationJobResponse> StartSynchronizationJobWithOptionsAsync(StartSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartSynchronizationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartSynchronizationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > 
          * *   Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service) of Data Transmission Service (DTS).
          * *   When you call this operation, the data synchronization task must be in the NotStarted, Failed, or Suspending state. If you call this operation to start a task that is in the NotStarted state, the task will be prechecked.
          *
          * @param request StartSynchronizationJobRequest
          * @return StartSynchronizationJobResponse
         */
        public StartSynchronizationJobResponse StartSynchronizationJob(StartSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartSynchronizationJobWithOptions(request, runtime);
        }

        /**
          * > 
          * *   Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service) of Data Transmission Service (DTS).
          * *   When you call this operation, the data synchronization task must be in the NotStarted, Failed, or Suspending state. If you call this operation to start a task that is in the NotStarted state, the task will be prechecked.
          *
          * @param request StartSynchronizationJobRequest
          * @return StartSynchronizationJobResponse
         */
        public async Task<StartSynchronizationJobResponse> StartSynchronizationJobAsync(StartSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartSynchronizationJobWithOptionsAsync(request, runtime);
        }

        public StopDedicatedClusterResponse StopDedicatedClusterWithOptions(StopDedicatedClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                query["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterName))
            {
                query["DedicatedClusterName"] = request.DedicatedClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "StopDedicatedCluster",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDedicatedClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopDedicatedClusterResponse> StopDedicatedClusterWithOptionsAsync(StopDedicatedClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                query["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterName))
            {
                query["DedicatedClusterName"] = request.DedicatedClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "StopDedicatedCluster",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDedicatedClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopDedicatedClusterResponse StopDedicatedCluster(StopDedicatedClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDedicatedClusterWithOptions(request, runtime);
        }

        public async Task<StopDedicatedClusterResponse> StopDedicatedClusterAsync(StopDedicatedClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDedicatedClusterWithOptionsAsync(request, runtime);
        }

        public StopDtsJobResponse StopDtsJobWithOptions(StopDtsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDtsJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDtsJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopDtsJobResponse> StopDtsJobWithOptionsAsync(StopDtsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDtsJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDtsJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopDtsJobResponse StopDtsJob(StopDtsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDtsJobWithOptions(request, runtime);
        }

        public async Task<StopDtsJobResponse> StopDtsJobAsync(StopDtsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDtsJobWithOptionsAsync(request, runtime);
        }

        public StopDtsJobsResponse StopDtsJobsWithOptions(StopDtsJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobIds))
            {
                query["DtsJobIds"] = request.DtsJobIds;
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
                Action = "StopDtsJobs",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDtsJobsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopDtsJobsResponse> StopDtsJobsWithOptionsAsync(StopDtsJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobIds))
            {
                query["DtsJobIds"] = request.DtsJobIds;
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
                Action = "StopDtsJobs",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDtsJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopDtsJobsResponse StopDtsJobs(StopDtsJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDtsJobsWithOptions(request, runtime);
        }

        public async Task<StopDtsJobsResponse> StopDtsJobsAsync(StopDtsJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDtsJobsWithOptionsAsync(request, runtime);
        }

        /**
          * >  After you call this operation to stop a data migration task, the status of the task changes to Finished and you cannot restart the task by calling the [StartMigrationJob](~~49429~~) operation.
          *
          * @param request StopMigrationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StopMigrationJobResponse
         */
        public StopMigrationJobResponse StopMigrationJobWithOptions(StopMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "StopMigrationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopMigrationJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  After you call this operation to stop a data migration task, the status of the task changes to Finished and you cannot restart the task by calling the [StartMigrationJob](~~49429~~) operation.
          *
          * @param request StopMigrationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StopMigrationJobResponse
         */
        public async Task<StopMigrationJobResponse> StopMigrationJobWithOptionsAsync(StopMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "StopMigrationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopMigrationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  After you call this operation to stop a data migration task, the status of the task changes to Finished and you cannot restart the task by calling the [StartMigrationJob](~~49429~~) operation.
          *
          * @param request StopMigrationJobRequest
          * @return StopMigrationJobResponse
         */
        public StopMigrationJobResponse StopMigrationJob(StopMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopMigrationJobWithOptions(request, runtime);
        }

        /**
          * >  After you call this operation to stop a data migration task, the status of the task changes to Finished and you cannot restart the task by calling the [StartMigrationJob](~~49429~~) operation.
          *
          * @param request StopMigrationJobRequest
          * @return StopMigrationJobResponse
         */
        public async Task<StopMigrationJobResponse> StopMigrationJobAsync(StopMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopMigrationJobWithOptionsAsync(request, runtime);
        }

        public SummaryJobDetailResponse SummaryJobDetailWithOptions(SummaryJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobCode))
            {
                query["JobCode"] = request.JobCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructType))
            {
                query["StructType"] = request.StructType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SummaryJobDetail",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SummaryJobDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SummaryJobDetailResponse> SummaryJobDetailWithOptionsAsync(SummaryJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobCode))
            {
                query["JobCode"] = request.JobCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructType))
            {
                query["StructType"] = request.StructType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SummaryJobDetail",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SummaryJobDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SummaryJobDetailResponse SummaryJobDetail(SummaryJobDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SummaryJobDetailWithOptions(request, runtime);
        }

        public async Task<SummaryJobDetailResponse> SummaryJobDetailAsync(SummaryJobDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SummaryJobDetailWithOptionsAsync(request, runtime);
        }

        /**
          * ****
          *
          * @param request SuspendDtsJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SuspendDtsJobResponse
         */
        public SuspendDtsJobResponse SuspendDtsJobWithOptions(SuspendDtsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendDtsJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendDtsJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ****
          *
          * @param request SuspendDtsJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SuspendDtsJobResponse
         */
        public async Task<SuspendDtsJobResponse> SuspendDtsJobWithOptionsAsync(SuspendDtsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendDtsJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendDtsJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ****
          *
          * @param request SuspendDtsJobRequest
          * @return SuspendDtsJobResponse
         */
        public SuspendDtsJobResponse SuspendDtsJob(SuspendDtsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendDtsJobWithOptions(request, runtime);
        }

        /**
          * ****
          *
          * @param request SuspendDtsJobRequest
          * @return SuspendDtsJobResponse
         */
        public async Task<SuspendDtsJobResponse> SuspendDtsJobAsync(SuspendDtsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendDtsJobWithOptionsAsync(request, runtime);
        }

        public SuspendDtsJobsResponse SuspendDtsJobsWithOptions(SuspendDtsJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobIds))
            {
                query["DtsJobIds"] = request.DtsJobIds;
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
                Action = "SuspendDtsJobs",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendDtsJobsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SuspendDtsJobsResponse> SuspendDtsJobsWithOptionsAsync(SuspendDtsJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobIds))
            {
                query["DtsJobIds"] = request.DtsJobIds;
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
                Action = "SuspendDtsJobs",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendDtsJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SuspendDtsJobsResponse SuspendDtsJobs(SuspendDtsJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendDtsJobsWithOptions(request, runtime);
        }

        public async Task<SuspendDtsJobsResponse> SuspendDtsJobsAsync(SuspendDtsJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendDtsJobsWithOptionsAsync(request, runtime);
        }

        /**
          * > 
          * *   If a data migration task is performing incremental data migration, we recommend that you do not pause the task for more than 6 hours. Otherwise, you will not be able to call the [StartMigrationJob](~~49429~~) operation to restart the task.
          * *   If you select incremental data migration as the migration type for a pay-as-you-go instance, DTS charges a fee even when the task is paused. This is because DTS only stops writing data to the destination database. DTS continues to pull the logs of the source database so that the task can resume quickly after it is restarted. Therefore, incremental data migration consumes resources such as the bandwidth of the source database.
          *
          * @param request SuspendMigrationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SuspendMigrationJobResponse
         */
        public SuspendMigrationJobResponse SuspendMigrationJobWithOptions(SuspendMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "SuspendMigrationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendMigrationJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > 
          * *   If a data migration task is performing incremental data migration, we recommend that you do not pause the task for more than 6 hours. Otherwise, you will not be able to call the [StartMigrationJob](~~49429~~) operation to restart the task.
          * *   If you select incremental data migration as the migration type for a pay-as-you-go instance, DTS charges a fee even when the task is paused. This is because DTS only stops writing data to the destination database. DTS continues to pull the logs of the source database so that the task can resume quickly after it is restarted. Therefore, incremental data migration consumes resources such as the bandwidth of the source database.
          *
          * @param request SuspendMigrationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SuspendMigrationJobResponse
         */
        public async Task<SuspendMigrationJobResponse> SuspendMigrationJobWithOptionsAsync(SuspendMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "SuspendMigrationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendMigrationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > 
          * *   If a data migration task is performing incremental data migration, we recommend that you do not pause the task for more than 6 hours. Otherwise, you will not be able to call the [StartMigrationJob](~~49429~~) operation to restart the task.
          * *   If you select incremental data migration as the migration type for a pay-as-you-go instance, DTS charges a fee even when the task is paused. This is because DTS only stops writing data to the destination database. DTS continues to pull the logs of the source database so that the task can resume quickly after it is restarted. Therefore, incremental data migration consumes resources such as the bandwidth of the source database.
          *
          * @param request SuspendMigrationJobRequest
          * @return SuspendMigrationJobResponse
         */
        public SuspendMigrationJobResponse SuspendMigrationJob(SuspendMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendMigrationJobWithOptions(request, runtime);
        }

        /**
          * > 
          * *   If a data migration task is performing incremental data migration, we recommend that you do not pause the task for more than 6 hours. Otherwise, you will not be able to call the [StartMigrationJob](~~49429~~) operation to restart the task.
          * *   If you select incremental data migration as the migration type for a pay-as-you-go instance, DTS charges a fee even when the task is paused. This is because DTS only stops writing data to the destination database. DTS continues to pull the logs of the source database so that the task can resume quickly after it is restarted. Therefore, incremental data migration consumes resources such as the bandwidth of the source database.
          *
          * @param request SuspendMigrationJobRequest
          * @return SuspendMigrationJobResponse
         */
        public async Task<SuspendMigrationJobResponse> SuspendMigrationJobAsync(SuspendMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendMigrationJobWithOptionsAsync(request, runtime);
        }

        /**
          * > 
          * *   When you call this operation, the data synchronization task must be in the Synchronizing state.
          * *   We recommend that you do not pause a data synchronization task for more than 6 hours. Otherwise, the task cannot be started again.
          * *   If the billing method is pay-as-you-go, DTS charges a fee even when the task is paused. This is because DTS only stops writing data to the destination database. DTS continues to pull the logs of the source database so that the task can resume quickly after it is restarted. Therefore, data synchronization consumes resources such as the bandwidth of the source database.
          *
          * @param request SuspendSynchronizationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SuspendSynchronizationJobResponse
         */
        public SuspendSynchronizationJobResponse SuspendSynchronizationJobWithOptions(SuspendSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendSynchronizationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendSynchronizationJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > 
          * *   When you call this operation, the data synchronization task must be in the Synchronizing state.
          * *   We recommend that you do not pause a data synchronization task for more than 6 hours. Otherwise, the task cannot be started again.
          * *   If the billing method is pay-as-you-go, DTS charges a fee even when the task is paused. This is because DTS only stops writing data to the destination database. DTS continues to pull the logs of the source database so that the task can resume quickly after it is restarted. Therefore, data synchronization consumes resources such as the bandwidth of the source database.
          *
          * @param request SuspendSynchronizationJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SuspendSynchronizationJobResponse
         */
        public async Task<SuspendSynchronizationJobResponse> SuspendSynchronizationJobWithOptionsAsync(SuspendSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendSynchronizationJob",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendSynchronizationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > 
          * *   When you call this operation, the data synchronization task must be in the Synchronizing state.
          * *   We recommend that you do not pause a data synchronization task for more than 6 hours. Otherwise, the task cannot be started again.
          * *   If the billing method is pay-as-you-go, DTS charges a fee even when the task is paused. This is because DTS only stops writing data to the destination database. DTS continues to pull the logs of the source database so that the task can resume quickly after it is restarted. Therefore, data synchronization consumes resources such as the bandwidth of the source database.
          *
          * @param request SuspendSynchronizationJobRequest
          * @return SuspendSynchronizationJobResponse
         */
        public SuspendSynchronizationJobResponse SuspendSynchronizationJob(SuspendSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendSynchronizationJobWithOptions(request, runtime);
        }

        /**
          * > 
          * *   When you call this operation, the data synchronization task must be in the Synchronizing state.
          * *   We recommend that you do not pause a data synchronization task for more than 6 hours. Otherwise, the task cannot be started again.
          * *   If the billing method is pay-as-you-go, DTS charges a fee even when the task is paused. This is because DTS only stops writing data to the destination database. DTS continues to pull the logs of the source database so that the task can resume quickly after it is restarted. Therefore, data synchronization consumes resources such as the bandwidth of the source database.
          *
          * @param request SuspendSynchronizationJobRequest
          * @return SuspendSynchronizationJobResponse
         */
        public async Task<SuspendSynchronizationJobResponse> SuspendSynchronizationJobAsync(SuspendSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendSynchronizationJobWithOptionsAsync(request, runtime);
        }

        public SwitchPhysicalDtsJobToCloudResponse SwitchPhysicalDtsJobToCloudWithOptions(SwitchPhysicalDtsJobToCloudRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchPhysicalDtsJobToCloud",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchPhysicalDtsJobToCloudResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SwitchPhysicalDtsJobToCloudResponse> SwitchPhysicalDtsJobToCloudWithOptionsAsync(SwitchPhysicalDtsJobToCloudRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsInstanceId))
            {
                query["DtsInstanceId"] = request.DtsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchPhysicalDtsJobToCloud",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchPhysicalDtsJobToCloudResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SwitchPhysicalDtsJobToCloudResponse SwitchPhysicalDtsJobToCloud(SwitchPhysicalDtsJobToCloudRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchPhysicalDtsJobToCloudWithOptions(request, runtime);
        }

        public async Task<SwitchPhysicalDtsJobToCloudResponse> SwitchPhysicalDtsJobToCloudAsync(SwitchPhysicalDtsJobToCloudRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchPhysicalDtsJobToCloudWithOptionsAsync(request, runtime);
        }

        /**
          * *   If the source or destination database is a self-managed MySQL database connected over the Internet, Elastic Compute Service (ECS) or Express Connect, you must call this operation to update the connection settings.
          * *   If the source or destination database is hosted on an ApsaraDB instance (such as ApsaraDB RDS instance and ApsaraDB for MongoDB instance), DTS automatically updates the connection settings. You do not need to call this operation.
          * > *   For two-way synchronization tasks, if you perform a primary/secondary switchover on the source or destination database, you must call this operation twice to update the connection settings.
          *         For example, if you perform a primary/secondary switchover on the destination database of the forward direction, you must call this operation twice. In the first call, set the **SynchronizationDirection** parameter to **Forward**, set the **Endpoint.Type **parameter to **Destination**, and configure the connection settings. In the second call, set the **SynchronizationDirection** parameter to **Reverse**, set the **Endpoint.Type **parameter to **Source**, and configure the connection settings.
          *
          * @param request SwitchSynchronizationEndpointRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SwitchSynchronizationEndpointResponse
         */
        public SwitchSynchronizationEndpointResponse SwitchSynchronizationEndpointWithOptions(SwitchSynchronizationEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endpoint))
            {
                query["Endpoint"] = request.Endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpoint))
            {
                query["SourceEndpoint"] = request.SourceEndpoint;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchSynchronizationEndpoint",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchSynchronizationEndpointResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   If the source or destination database is a self-managed MySQL database connected over the Internet, Elastic Compute Service (ECS) or Express Connect, you must call this operation to update the connection settings.
          * *   If the source or destination database is hosted on an ApsaraDB instance (such as ApsaraDB RDS instance and ApsaraDB for MongoDB instance), DTS automatically updates the connection settings. You do not need to call this operation.
          * > *   For two-way synchronization tasks, if you perform a primary/secondary switchover on the source or destination database, you must call this operation twice to update the connection settings.
          *         For example, if you perform a primary/secondary switchover on the destination database of the forward direction, you must call this operation twice. In the first call, set the **SynchronizationDirection** parameter to **Forward**, set the **Endpoint.Type **parameter to **Destination**, and configure the connection settings. In the second call, set the **SynchronizationDirection** parameter to **Reverse**, set the **Endpoint.Type **parameter to **Source**, and configure the connection settings.
          *
          * @param request SwitchSynchronizationEndpointRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SwitchSynchronizationEndpointResponse
         */
        public async Task<SwitchSynchronizationEndpointResponse> SwitchSynchronizationEndpointWithOptionsAsync(SwitchSynchronizationEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endpoint))
            {
                query["Endpoint"] = request.Endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpoint))
            {
                query["SourceEndpoint"] = request.SourceEndpoint;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchSynchronizationEndpoint",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchSynchronizationEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   If the source or destination database is a self-managed MySQL database connected over the Internet, Elastic Compute Service (ECS) or Express Connect, you must call this operation to update the connection settings.
          * *   If the source or destination database is hosted on an ApsaraDB instance (such as ApsaraDB RDS instance and ApsaraDB for MongoDB instance), DTS automatically updates the connection settings. You do not need to call this operation.
          * > *   For two-way synchronization tasks, if you perform a primary/secondary switchover on the source or destination database, you must call this operation twice to update the connection settings.
          *         For example, if you perform a primary/secondary switchover on the destination database of the forward direction, you must call this operation twice. In the first call, set the **SynchronizationDirection** parameter to **Forward**, set the **Endpoint.Type **parameter to **Destination**, and configure the connection settings. In the second call, set the **SynchronizationDirection** parameter to **Reverse**, set the **Endpoint.Type **parameter to **Source**, and configure the connection settings.
          *
          * @param request SwitchSynchronizationEndpointRequest
          * @return SwitchSynchronizationEndpointResponse
         */
        public SwitchSynchronizationEndpointResponse SwitchSynchronizationEndpoint(SwitchSynchronizationEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchSynchronizationEndpointWithOptions(request, runtime);
        }

        /**
          * *   If the source or destination database is a self-managed MySQL database connected over the Internet, Elastic Compute Service (ECS) or Express Connect, you must call this operation to update the connection settings.
          * *   If the source or destination database is hosted on an ApsaraDB instance (such as ApsaraDB RDS instance and ApsaraDB for MongoDB instance), DTS automatically updates the connection settings. You do not need to call this operation.
          * > *   For two-way synchronization tasks, if you perform a primary/secondary switchover on the source or destination database, you must call this operation twice to update the connection settings.
          *         For example, if you perform a primary/secondary switchover on the destination database of the forward direction, you must call this operation twice. In the first call, set the **SynchronizationDirection** parameter to **Forward**, set the **Endpoint.Type **parameter to **Destination**, and configure the connection settings. In the second call, set the **SynchronizationDirection** parameter to **Reverse**, set the **Endpoint.Type **parameter to **Source**, and configure the connection settings.
          *
          * @param request SwitchSynchronizationEndpointRequest
          * @return SwitchSynchronizationEndpointResponse
         */
        public async Task<SwitchSynchronizationEndpointResponse> SwitchSynchronizationEndpointAsync(SwitchSynchronizationEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchSynchronizationEndpointWithOptionsAsync(request, runtime);
        }

        /**
          * If you have a large number of instances, you can create multiple tags and bind these tags to the instances. Then, you can filter the instances by tag.
          * *   A tag consists of a key and a value. Each key must be unique in a region for an Alibaba Cloud account. Different keys can be mapped to the same value.
          * *   If the tag that you specify does not exist, this tag is automatically created and bound to the specified instance.
          * *   If the key of the specified tag is the same as that of an existing tag, the specified tag overwrites the existing tag.
          * *   You can bind up to 20 tags to each instance.
          * *   You can bind tags to up to 50 instances in each call.
          *
          * @param request TagResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * If you have a large number of instances, you can create multiple tags and bind these tags to the instances. Then, you can filter the instances by tag.
          * *   A tag consists of a key and a value. Each key must be unique in a region for an Alibaba Cloud account. Different keys can be mapped to the same value.
          * *   If the tag that you specify does not exist, this tag is automatically created and bound to the specified instance.
          * *   If the key of the specified tag is the same as that of an existing tag, the specified tag overwrites the existing tag.
          * *   You can bind up to 20 tags to each instance.
          * *   You can bind tags to up to 50 instances in each call.
          *
          * @param request TagResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * If you have a large number of instances, you can create multiple tags and bind these tags to the instances. Then, you can filter the instances by tag.
          * *   A tag consists of a key and a value. Each key must be unique in a region for an Alibaba Cloud account. Different keys can be mapped to the same value.
          * *   If the tag that you specify does not exist, this tag is automatically created and bound to the specified instance.
          * *   If the key of the specified tag is the same as that of an existing tag, the specified tag overwrites the existing tag.
          * *   You can bind up to 20 tags to each instance.
          * *   You can bind tags to up to 50 instances in each call.
          *
          * @param request TagResourcesRequest
          * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /**
          * If you have a large number of instances, you can create multiple tags and bind these tags to the instances. Then, you can filter the instances by tag.
          * *   A tag consists of a key and a value. Each key must be unique in a region for an Alibaba Cloud account. Different keys can be mapped to the same value.
          * *   If the tag that you specify does not exist, this tag is automatically created and bound to the specified instance.
          * *   If the key of the specified tag is the same as that of an existing tag, the specified tag overwrites the existing tag.
          * *   You can bind up to 20 tags to each instance.
          * *   You can bind tags to up to 50 instances in each call.
          *
          * @param request TagResourcesRequest
          * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        public TransferInstanceClassResponse TransferInstanceClassWithOptions(TransferInstanceClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceClass))
            {
                query["InstanceClass"] = request.InstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
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
                Action = "TransferInstanceClass",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferInstanceClassResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TransferInstanceClassResponse> TransferInstanceClassWithOptionsAsync(TransferInstanceClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceClass))
            {
                query["InstanceClass"] = request.InstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
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
                Action = "TransferInstanceClass",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferInstanceClassResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TransferInstanceClassResponse TransferInstanceClass(TransferInstanceClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferInstanceClassWithOptions(request, runtime);
        }

        public async Task<TransferInstanceClassResponse> TransferInstanceClassAsync(TransferInstanceClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferInstanceClassWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service/pricing) of DTS.
          * *   The billing method of subscription instances cannot be changed to pay-as-you-go. To prevent resource waste, determine whether you need to change the billing method of your resources.
          * *   Data migration instances are all pay-as-you-go instances. You do not need to change the billing method of data migration instances.
          * *   After you change the billing method from pay-as-you-go to subscription, the DTS instance is not affected.
          *
          * @param request TransferPayTypeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return TransferPayTypeResponse
         */
        public TransferPayTypeResponse TransferPayTypeWithOptions(TransferPayTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyCount))
            {
                query["BuyCount"] = request.BuyCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
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
                Action = "TransferPayType",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferPayTypeResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service/pricing) of DTS.
          * *   The billing method of subscription instances cannot be changed to pay-as-you-go. To prevent resource waste, determine whether you need to change the billing method of your resources.
          * *   Data migration instances are all pay-as-you-go instances. You do not need to change the billing method of data migration instances.
          * *   After you change the billing method from pay-as-you-go to subscription, the DTS instance is not affected.
          *
          * @param request TransferPayTypeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return TransferPayTypeResponse
         */
        public async Task<TransferPayTypeResponse> TransferPayTypeWithOptionsAsync(TransferPayTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyCount))
            {
                query["BuyCount"] = request.BuyCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
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
                Action = "TransferPayType",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferPayTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service/pricing) of DTS.
          * *   The billing method of subscription instances cannot be changed to pay-as-you-go. To prevent resource waste, determine whether you need to change the billing method of your resources.
          * *   Data migration instances are all pay-as-you-go instances. You do not need to change the billing method of data migration instances.
          * *   After you change the billing method from pay-as-you-go to subscription, the DTS instance is not affected.
          *
          * @param request TransferPayTypeRequest
          * @return TransferPayTypeResponse
         */
        public TransferPayTypeResponse TransferPayType(TransferPayTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferPayTypeWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service/pricing) of DTS.
          * *   The billing method of subscription instances cannot be changed to pay-as-you-go. To prevent resource waste, determine whether you need to change the billing method of your resources.
          * *   Data migration instances are all pay-as-you-go instances. You do not need to change the billing method of data migration instances.
          * *   After you change the billing method from pay-as-you-go to subscription, the DTS instance is not affected.
          *
          * @param request TransferPayTypeRequest
          * @return TransferPayTypeResponse
         */
        public async Task<TransferPayTypeResponse> TransferPayTypeAsync(TransferPayTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferPayTypeWithOptionsAsync(request, runtime);
        }

        /**
          * >  If a tag is unbound from an instance and is not bound to other instances, the tag is deleted.
          *
          * @param request UntagResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  If a tag is unbound from an instance and is not bound to other instances, the tag is deleted.
          *
          * @param request UntagResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  If a tag is unbound from an instance and is not bound to other instances, the tag is deleted.
          *
          * @param request UntagResourcesRequest
          * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /**
          * >  If a tag is unbound from an instance and is not bound to other instances, the tag is deleted.
          *
          * @param request UntagResourcesRequest
          * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service/pricing) of Data Transmission Service (DTS)
          * When you call this operation, take note of the following information:
          * *   The source and destination databases of the data synchronization task are both **MySQL** databases.
          * *   The synchronization topology of the data synchronization task is **one-way synchronization**.
          * *   The data synchronization task is in the **Synchronizing** state.
          * *   The upgrade operation causes data synchronization latency of about 5 seconds. We recommend that you perform this operation during off-peak hours.
          *
          * @param request UpgradeTwoWayRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpgradeTwoWayResponse
         */
        public UpgradeTwoWayResponse UpgradeTwoWayWithOptions(UpgradeTwoWayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceClass))
            {
                query["InstanceClass"] = request.InstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "UpgradeTwoWay",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeTwoWayResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service/pricing) of Data Transmission Service (DTS)
          * When you call this operation, take note of the following information:
          * *   The source and destination databases of the data synchronization task are both **MySQL** databases.
          * *   The synchronization topology of the data synchronization task is **one-way synchronization**.
          * *   The data synchronization task is in the **Synchronizing** state.
          * *   The upgrade operation causes data synchronization latency of about 5 seconds. We recommend that you perform this operation during off-peak hours.
          *
          * @param request UpgradeTwoWayRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpgradeTwoWayResponse
         */
        public async Task<UpgradeTwoWayResponse> UpgradeTwoWayWithOptionsAsync(UpgradeTwoWayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceClass))
            {
                query["InstanceClass"] = request.InstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "UpgradeTwoWay",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeTwoWayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service/pricing) of Data Transmission Service (DTS)
          * When you call this operation, take note of the following information:
          * *   The source and destination databases of the data synchronization task are both **MySQL** databases.
          * *   The synchronization topology of the data synchronization task is **one-way synchronization**.
          * *   The data synchronization task is in the **Synchronizing** state.
          * *   The upgrade operation causes data synchronization latency of about 5 seconds. We recommend that you perform this operation during off-peak hours.
          *
          * @param request UpgradeTwoWayRequest
          * @return UpgradeTwoWayResponse
         */
        public UpgradeTwoWayResponse UpgradeTwoWay(UpgradeTwoWayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeTwoWayWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/data-transmission-service/pricing) of Data Transmission Service (DTS)
          * When you call this operation, take note of the following information:
          * *   The source and destination databases of the data synchronization task are both **MySQL** databases.
          * *   The synchronization topology of the data synchronization task is **one-way synchronization**.
          * *   The data synchronization task is in the **Synchronizing** state.
          * *   The upgrade operation causes data synchronization latency of about 5 seconds. We recommend that you perform this operation during off-peak hours.
          *
          * @param request UpgradeTwoWayRequest
          * @return UpgradeTwoWayResponse
         */
        public async Task<UpgradeTwoWayResponse> UpgradeTwoWayAsync(UpgradeTwoWayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeTwoWayWithOptionsAsync(request, runtime);
        }

        /**
          * The operation that you want to perform. Set the value to **WhiteIpList**.
          *
          * @param request WhiteIpListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return WhiteIpListResponse
         */
        public WhiteIpListResponse WhiteIpListWithOptions(WhiteIpListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationRegion))
            {
                query["DestinationRegion"] = request.DestinationRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "WhiteIpList",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WhiteIpListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The operation that you want to perform. Set the value to **WhiteIpList**.
          *
          * @param request WhiteIpListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return WhiteIpListResponse
         */
        public async Task<WhiteIpListResponse> WhiteIpListWithOptionsAsync(WhiteIpListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationRegion))
            {
                query["DestinationRegion"] = request.DestinationRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "WhiteIpList",
                Version = "2020-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WhiteIpListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The operation that you want to perform. Set the value to **WhiteIpList**.
          *
          * @param request WhiteIpListRequest
          * @return WhiteIpListResponse
         */
        public WhiteIpListResponse WhiteIpList(WhiteIpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return WhiteIpListWithOptions(request, runtime);
        }

        /**
          * The operation that you want to perform. Set the value to **WhiteIpList**.
          *
          * @param request WhiteIpListRequest
          * @return WhiteIpListResponse
         */
        public async Task<WhiteIpListResponse> WhiteIpListAsync(WhiteIpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await WhiteIpListWithOptionsAsync(request, runtime);
        }

    }
}
