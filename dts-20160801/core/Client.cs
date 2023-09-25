// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dts20160801.Models;

namespace AlibabaCloud.SDK.Dts20160801
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

        public ConfigurationSynchronizationJobResponse ConfigurationSynchronizationJobWithOptions(ConfigurationSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobName))
            {
                query["SynchronizationJobName"] = request.SynchronizationJobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationObject))
            {
                query["SynchronizationObject"] = request.SynchronizationObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpoint))
            {
                query["DestinationEndpoint"] = request.DestinationEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Initialization))
            {
                query["Initialization"] = request.Initialization;
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
                Action = "ConfigurationSynchronizationJob",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigurationSynchronizationJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ConfigurationSynchronizationJobResponse> ConfigurationSynchronizationJobWithOptionsAsync(ConfigurationSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobName))
            {
                query["SynchronizationJobName"] = request.SynchronizationJobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationObject))
            {
                query["SynchronizationObject"] = request.SynchronizationObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpoint))
            {
                query["DestinationEndpoint"] = request.DestinationEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Initialization))
            {
                query["Initialization"] = request.Initialization;
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
                Action = "ConfigurationSynchronizationJob",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigurationSynchronizationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ConfigurationSynchronizationJobResponse ConfigurationSynchronizationJob(ConfigurationSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigurationSynchronizationJobWithOptions(request, runtime);
        }

        public async Task<ConfigurationSynchronizationJobResponse> ConfigurationSynchronizationJobAsync(ConfigurationSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigurationSynchronizationJobWithOptionsAsync(request, runtime);
        }

        public ConfigureMigrationJobResponse ConfigureMigrationJobWithOptions(ConfigureMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationObject))
            {
                query["MigrationObject"] = request.MigrationObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationReserved))
            {
                query["MigrationReserved"] = request.MigrationReserved;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureMigrationJob",
                Version = "2016-08-01",
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

        public async Task<ConfigureMigrationJobResponse> ConfigureMigrationJobWithOptionsAsync(ConfigureMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationObject))
            {
                query["MigrationObject"] = request.MigrationObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationReserved))
            {
                query["MigrationReserved"] = request.MigrationReserved;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureMigrationJob",
                Version = "2016-08-01",
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

        public ConfigureMigrationJobResponse ConfigureMigrationJob(ConfigureMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigureMigrationJobWithOptions(request, runtime);
        }

        public async Task<ConfigureMigrationJobResponse> ConfigureMigrationJobAsync(ConfigureMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigureMigrationJobWithOptionsAsync(request, runtime);
        }

        public ConfigureSubscriptionInstanceResponse ConfigureSubscriptionInstanceWithOptions(ConfigureSubscriptionInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceName))
            {
                query["SubscriptionInstanceName"] = request.SubscriptionInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionObject))
            {
                query["SubscriptionObject"] = request.SubscriptionObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpoint))
            {
                query["SourceEndpoint"] = request.SourceEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionDataType))
            {
                query["SubscriptionDataType"] = request.SubscriptionDataType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureSubscriptionInstance",
                Version = "2016-08-01",
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

        public async Task<ConfigureSubscriptionInstanceResponse> ConfigureSubscriptionInstanceWithOptionsAsync(ConfigureSubscriptionInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceId))
            {
                query["SubscriptionInstanceId"] = request.SubscriptionInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceName))
            {
                query["SubscriptionInstanceName"] = request.SubscriptionInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionObject))
            {
                query["SubscriptionObject"] = request.SubscriptionObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpoint))
            {
                query["SourceEndpoint"] = request.SourceEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionDataType))
            {
                query["SubscriptionDataType"] = request.SubscriptionDataType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureSubscriptionInstance",
                Version = "2016-08-01",
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

        public ConfigureSubscriptionInstanceResponse ConfigureSubscriptionInstance(ConfigureSubscriptionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigureSubscriptionInstanceWithOptions(request, runtime);
        }

        public async Task<ConfigureSubscriptionInstanceResponse> ConfigureSubscriptionInstanceAsync(ConfigureSubscriptionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigureSubscriptionInstanceWithOptionsAsync(request, runtime);
        }

        public ConfigureSynchronizationJobResponse ConfigureSynchronizationJobWithOptions(ConfigureSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructureInitialization))
            {
                query["StructureInitialization"] = request.StructureInitialization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobName))
            {
                query["SynchronizationJobName"] = request.SynchronizationJobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationObjects))
            {
                query["SynchronizationObjects"] = request.SynchronizationObjects;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureSynchronizationJob",
                Version = "2016-08-01",
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

        public async Task<ConfigureSynchronizationJobResponse> ConfigureSynchronizationJobWithOptionsAsync(ConfigureSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructureInitialization))
            {
                query["StructureInitialization"] = request.StructureInitialization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobName))
            {
                query["SynchronizationJobName"] = request.SynchronizationJobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationObjects))
            {
                query["SynchronizationObjects"] = request.SynchronizationObjects;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureSynchronizationJob",
                Version = "2016-08-01",
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

        public ConfigureSynchronizationJobResponse ConfigureSynchronizationJob(ConfigureSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigureSynchronizationJobWithOptions(request, runtime);
        }

        public async Task<ConfigureSynchronizationJobResponse> ConfigureSynchronizationJobAsync(ConfigureSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigureSynchronizationJobWithOptionsAsync(request, runtime);
        }

        public CreateMigrationJobResponse CreateMigrationJobWithOptions(CreateMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMigrationJob",
                Version = "2016-08-01",
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

        public async Task<CreateMigrationJobResponse> CreateMigrationJobWithOptionsAsync(CreateMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMigrationJob",
                Version = "2016-08-01",
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

        public CreateMigrationJobResponse CreateMigrationJob(CreateMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMigrationJobWithOptions(request, runtime);
        }

        public async Task<CreateMigrationJobResponse> CreateMigrationJobAsync(CreateMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMigrationJobWithOptionsAsync(request, runtime);
        }

        public CreateSubscriptionInstanceResponse CreateSubscriptionInstanceWithOptions(CreateSubscriptionInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateSubscriptionInstance",
                Version = "2016-08-01",
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

        public async Task<CreateSubscriptionInstanceResponse> CreateSubscriptionInstanceWithOptionsAsync(CreateSubscriptionInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateSubscriptionInstance",
                Version = "2016-08-01",
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

        public CreateSubscriptionInstanceResponse CreateSubscriptionInstance(CreateSubscriptionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSubscriptionInstanceWithOptions(request, runtime);
        }

        public async Task<CreateSubscriptionInstanceResponse> CreateSubscriptionInstanceAsync(CreateSubscriptionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSubscriptionInstanceWithOptionsAsync(request, runtime);
        }

        public CreateSynchronizationJobResponse CreateSynchronizationJobWithOptions(CreateSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRegion))
            {
                query["SourceRegion"] = request.SourceRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobClass))
            {
                query["SynchronizationJobClass"] = request.SynchronizationJobClass;
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
                Version = "2016-08-01",
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

        public async Task<CreateSynchronizationJobResponse> CreateSynchronizationJobWithOptionsAsync(CreateSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRegion))
            {
                query["SourceRegion"] = request.SourceRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobClass))
            {
                query["SynchronizationJobClass"] = request.SynchronizationJobClass;
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
                Version = "2016-08-01",
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

        public CreateSynchronizationJobResponse CreateSynchronizationJob(CreateSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSynchronizationJobWithOptions(request, runtime);
        }

        public async Task<CreateSynchronizationJobResponse> CreateSynchronizationJobAsync(CreateSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSynchronizationJobWithOptionsAsync(request, runtime);
        }

        public DeleteMigrationJobResponse DeleteMigrationJobWithOptions(DeleteMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
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
                Action = "DeleteMigrationJob",
                Version = "2016-08-01",
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

        public async Task<DeleteMigrationJobResponse> DeleteMigrationJobWithOptionsAsync(DeleteMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
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
                Action = "DeleteMigrationJob",
                Version = "2016-08-01",
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

        public DeleteMigrationJobResponse DeleteMigrationJob(DeleteMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMigrationJobWithOptions(request, runtime);
        }

        public async Task<DeleteMigrationJobResponse> DeleteMigrationJobAsync(DeleteMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMigrationJobWithOptionsAsync(request, runtime);
        }

        public DeleteSubscriptionInstanceResponse DeleteSubscriptionInstanceWithOptions(DeleteSubscriptionInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Version = "2016-08-01",
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

        public async Task<DeleteSubscriptionInstanceResponse> DeleteSubscriptionInstanceWithOptionsAsync(DeleteSubscriptionInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Version = "2016-08-01",
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

        public DeleteSubscriptionInstanceResponse DeleteSubscriptionInstance(DeleteSubscriptionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSubscriptionInstanceWithOptions(request, runtime);
        }

        public async Task<DeleteSubscriptionInstanceResponse> DeleteSubscriptionInstanceAsync(DeleteSubscriptionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSubscriptionInstanceWithOptionsAsync(request, runtime);
        }

        public DeleteSynchronizationJobResponse DeleteSynchronizationJobWithOptions(DeleteSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Version = "2016-08-01",
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

        public async Task<DeleteSynchronizationJobResponse> DeleteSynchronizationJobWithOptionsAsync(DeleteSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Version = "2016-08-01",
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

        public DeleteSynchronizationJobResponse DeleteSynchronizationJob(DeleteSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSynchronizationJobWithOptions(request, runtime);
        }

        public async Task<DeleteSynchronizationJobResponse> DeleteSynchronizationJobAsync(DeleteSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSynchronizationJobWithOptionsAsync(request, runtime);
        }

        public DescirbeMigrationJobsResponse DescirbeMigrationJobsWithOptions(DescirbeMigrationJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescirbeMigrationJobs",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescirbeMigrationJobsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescirbeMigrationJobsResponse> DescirbeMigrationJobsWithOptionsAsync(DescirbeMigrationJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescirbeMigrationJobs",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescirbeMigrationJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescirbeMigrationJobsResponse DescirbeMigrationJobs(DescirbeMigrationJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescirbeMigrationJobsWithOptions(request, runtime);
        }

        public async Task<DescirbeMigrationJobsResponse> DescirbeMigrationJobsAsync(DescirbeMigrationJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescirbeMigrationJobsWithOptionsAsync(request, runtime);
        }

        public DescribeInitializationStatusResponse DescribeInitializationStatusWithOptions(DescribeInitializationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Version = "2016-08-01",
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
                Version = "2016-08-01",
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

        public DescribeMigrationJobDetailResponse DescribeMigrationJobDetailWithOptions(DescribeMigrationJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Version = "2016-08-01",
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

        public async Task<DescribeMigrationJobDetailResponse> DescribeMigrationJobDetailWithOptionsAsync(DescribeMigrationJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Version = "2016-08-01",
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

        public DescribeMigrationJobDetailResponse DescribeMigrationJobDetail(DescribeMigrationJobDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMigrationJobDetailWithOptions(request, runtime);
        }

        public async Task<DescribeMigrationJobDetailResponse> DescribeMigrationJobDetailAsync(DescribeMigrationJobDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMigrationJobDetailWithOptionsAsync(request, runtime);
        }

        public DescribeMigrationJobStatusResponse DescribeMigrationJobStatusWithOptions(DescribeMigrationJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMigrationJobStatus",
                Version = "2016-08-01",
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMigrationJobStatus",
                Version = "2016-08-01",
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMigrationJobs",
                Version = "2016-08-01",
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMigrationJobs",
                Version = "2016-08-01",
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

        public DescribeSubscriptionInstanceStatusResponse DescribeSubscriptionInstanceStatusWithOptions(DescribeSubscriptionInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Version = "2016-08-01",
                Protocol = "HTTP",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Version = "2016-08-01",
                Protocol = "HTTP",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceName))
            {
                query["SubscriptionInstanceName"] = request.SubscriptionInstanceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSubscriptionInstances",
                Version = "2016-08-01",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionInstanceName))
            {
                query["SubscriptionInstanceName"] = request.SubscriptionInstanceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSubscriptionInstances",
                Version = "2016-08-01",
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

        public DescribeSubscriptionObjectModifyStatusResponse DescribeSubscriptionObjectModifyStatusWithOptions(DescribeSubscriptionObjectModifyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeSubscriptionObjectModifyStatus",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSubscriptionObjectModifyStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSubscriptionObjectModifyStatusResponse> DescribeSubscriptionObjectModifyStatusWithOptionsAsync(DescribeSubscriptionObjectModifyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeSubscriptionObjectModifyStatus",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSubscriptionObjectModifyStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSubscriptionObjectModifyStatusResponse DescribeSubscriptionObjectModifyStatus(DescribeSubscriptionObjectModifyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSubscriptionObjectModifyStatusWithOptions(request, runtime);
        }

        public async Task<DescribeSubscriptionObjectModifyStatusResponse> DescribeSubscriptionObjectModifyStatusAsync(DescribeSubscriptionObjectModifyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSubscriptionObjectModifyStatusWithOptionsAsync(request, runtime);
        }

        public DescribeSynchronizationJobStatusResponse DescribeSynchronizationJobStatusWithOptions(DescribeSynchronizationJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Version = "2016-08-01",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Version = "2016-08-01",
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

        public DescribeSynchronizationJobsResponse DescribeSynchronizationJobsWithOptions(DescribeSynchronizationJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobName))
            {
                query["SynchronizationJobName"] = request.SynchronizationJobName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSynchronizationJobs",
                Version = "2016-08-01",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobName))
            {
                query["SynchronizationJobName"] = request.SynchronizationJobName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSynchronizationJobs",
                Version = "2016-08-01",
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

        public DescribeSynchronizationObjectModifyStatusResponse DescribeSynchronizationObjectModifyStatusWithOptions(DescribeSynchronizationObjectModifyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Version = "2016-08-01",
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

        public async Task<DescribeSynchronizationObjectModifyStatusResponse> DescribeSynchronizationObjectModifyStatusWithOptionsAsync(DescribeSynchronizationObjectModifyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Version = "2016-08-01",
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

        public DescribeSynchronizationObjectModifyStatusResponse DescribeSynchronizationObjectModifyStatus(DescribeSynchronizationObjectModifyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSynchronizationObjectModifyStatusWithOptions(request, runtime);
        }

        public async Task<DescribeSynchronizationObjectModifyStatusResponse> DescribeSynchronizationObjectModifyStatusAsync(DescribeSynchronizationObjectModifyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSynchronizationObjectModifyStatusWithOptionsAsync(request, runtime);
        }

        public ModifyConsumptionTimestampResponse ModifyConsumptionTimestampWithOptions(ModifyConsumptionTimestampRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumptionTimestamp))
            {
                query["ConsumptionTimestamp"] = request.ConsumptionTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Version = "2016-08-01",
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

        public async Task<ModifyConsumptionTimestampResponse> ModifyConsumptionTimestampWithOptionsAsync(ModifyConsumptionTimestampRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumptionTimestamp))
            {
                query["ConsumptionTimestamp"] = request.ConsumptionTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Version = "2016-08-01",
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

        public ModifyConsumptionTimestampResponse ModifyConsumptionTimestamp(ModifyConsumptionTimestampRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyConsumptionTimestampWithOptions(request, runtime);
        }

        public async Task<ModifyConsumptionTimestampResponse> ModifyConsumptionTimestampAsync(ModifyConsumptionTimestampRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyConsumptionTimestampWithOptionsAsync(request, runtime);
        }

        public ModifyMigrationObjectResponse ModifyMigrationObjectWithOptions(ModifyMigrationObjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationObject))
            {
                query["MigrationObject"] = request.MigrationObject;
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
                Action = "ModifyMigrationObject",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMigrationObjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyMigrationObjectResponse> ModifyMigrationObjectWithOptionsAsync(ModifyMigrationObjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationObject))
            {
                query["MigrationObject"] = request.MigrationObject;
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
                Action = "ModifyMigrationObject",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMigrationObjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyMigrationObjectResponse ModifyMigrationObject(ModifyMigrationObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMigrationObjectWithOptions(request, runtime);
        }

        public async Task<ModifyMigrationObjectResponse> ModifyMigrationObjectAsync(ModifyMigrationObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMigrationObjectWithOptionsAsync(request, runtime);
        }

        public ModifySubscriptionObjectResponse ModifySubscriptionObjectWithOptions(ModifySubscriptionObjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Version = "2016-08-01",
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

        public async Task<ModifySubscriptionObjectResponse> ModifySubscriptionObjectWithOptionsAsync(ModifySubscriptionObjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Version = "2016-08-01",
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

        public ModifySubscriptionObjectResponse ModifySubscriptionObject(ModifySubscriptionObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySubscriptionObjectWithOptions(request, runtime);
        }

        public async Task<ModifySubscriptionObjectResponse> ModifySubscriptionObjectAsync(ModifySubscriptionObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySubscriptionObjectWithOptionsAsync(request, runtime);
        }

        public ModifySynchronizationObjectResponse ModifySynchronizationObjectWithOptions(ModifySynchronizationObjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationObjects))
            {
                query["SynchronizationObjects"] = request.SynchronizationObjects;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySynchronizationObject",
                Version = "2016-08-01",
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

        public async Task<ModifySynchronizationObjectResponse> ModifySynchronizationObjectWithOptionsAsync(ModifySynchronizationObjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                query["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationObjects))
            {
                query["SynchronizationObjects"] = request.SynchronizationObjects;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySynchronizationObject",
                Version = "2016-08-01",
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

        public ModifySynchronizationObjectResponse ModifySynchronizationObject(ModifySynchronizationObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySynchronizationObjectWithOptions(request, runtime);
        }

        public async Task<ModifySynchronizationObjectResponse> ModifySynchronizationObjectAsync(ModifySynchronizationObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySynchronizationObjectWithOptionsAsync(request, runtime);
        }

        public StartMigrationJobResponse StartMigrationJobWithOptions(StartMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
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
                Action = "StartMigrationJob",
                Version = "2016-08-01",
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

        public async Task<StartMigrationJobResponse> StartMigrationJobWithOptionsAsync(StartMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobId))
            {
                query["MigrationJobId"] = request.MigrationJobId;
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
                Action = "StartMigrationJob",
                Version = "2016-08-01",
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

        public StartMigrationJobResponse StartMigrationJob(StartMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartMigrationJobWithOptions(request, runtime);
        }

        public async Task<StartMigrationJobResponse> StartMigrationJobAsync(StartMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartMigrationJobWithOptionsAsync(request, runtime);
        }

        public StartSubscriptionInstanceResponse StartSubscriptionInstanceWithOptions(StartSubscriptionInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Version = "2016-08-01",
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

        public async Task<StartSubscriptionInstanceResponse> StartSubscriptionInstanceWithOptionsAsync(StartSubscriptionInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Version = "2016-08-01",
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

        public StartSubscriptionInstanceResponse StartSubscriptionInstance(StartSubscriptionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartSubscriptionInstanceWithOptions(request, runtime);
        }

        public async Task<StartSubscriptionInstanceResponse> StartSubscriptionInstanceAsync(StartSubscriptionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartSubscriptionInstanceWithOptionsAsync(request, runtime);
        }

        public StartSynchronizationJobResponse StartSynchronizationJobWithOptions(StartSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Version = "2016-08-01",
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

        public async Task<StartSynchronizationJobResponse> StartSynchronizationJobWithOptionsAsync(StartSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Version = "2016-08-01",
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

        public StartSynchronizationJobResponse StartSynchronizationJob(StartSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartSynchronizationJobWithOptions(request, runtime);
        }

        public async Task<StartSynchronizationJobResponse> StartSynchronizationJobAsync(StartSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartSynchronizationJobWithOptionsAsync(request, runtime);
        }

        public StopMigrationJobResponse StopMigrationJobWithOptions(StopMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopMigrationJob",
                Version = "2016-08-01",
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

        public async Task<StopMigrationJobResponse> StopMigrationJobWithOptionsAsync(StopMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopMigrationJob",
                Version = "2016-08-01",
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

        public StopMigrationJobResponse StopMigrationJob(StopMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopMigrationJobWithOptions(request, runtime);
        }

        public async Task<StopMigrationJobResponse> StopMigrationJobAsync(StopMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopMigrationJobWithOptionsAsync(request, runtime);
        }

        public SuspendMigrationJobResponse SuspendMigrationJobWithOptions(SuspendMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendMigrationJob",
                Version = "2016-08-01",
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

        public async Task<SuspendMigrationJobResponse> SuspendMigrationJobWithOptionsAsync(SuspendMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendMigrationJob",
                Version = "2016-08-01",
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

        public SuspendMigrationJobResponse SuspendMigrationJob(SuspendMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendMigrationJobWithOptions(request, runtime);
        }

        public async Task<SuspendMigrationJobResponse> SuspendMigrationJobAsync(SuspendMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendMigrationJobWithOptionsAsync(request, runtime);
        }

        public SuspendSynchronizationJobResponse SuspendSynchronizationJobWithOptions(SuspendSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Version = "2016-08-01",
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

        public async Task<SuspendSynchronizationJobResponse> SuspendSynchronizationJobWithOptionsAsync(SuspendSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Version = "2016-08-01",
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

        public SuspendSynchronizationJobResponse SuspendSynchronizationJob(SuspendSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendSynchronizationJobWithOptions(request, runtime);
        }

        public async Task<SuspendSynchronizationJobResponse> SuspendSynchronizationJobAsync(SuspendSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendSynchronizationJobWithOptionsAsync(request, runtime);
        }

    }
}
