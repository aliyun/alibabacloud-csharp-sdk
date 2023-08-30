// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dts20190901.Models;

namespace AlibabaCloud.SDK.Dts20190901
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
                Version = "2019-09-01",
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
                Version = "2019-09-01",
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

        public ConfigureSynchronizationJobAlertResponse ConfigureSynchronizationJobAlertWithOptions(ConfigureSynchronizationJobAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Version = "2019-09-01",
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
                Version = "2019-09-01",
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
                Version = "2019-09-01",
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
                Version = "2019-09-01",
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
                Version = "2019-09-01",
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
                Version = "2019-09-01",
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

        public DescribeEndpointSwitchStatusResponse DescribeEndpointSwitchStatusWithOptions(DescribeEndpointSwitchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeEndpointSwitchStatus",
                Version = "2019-09-01",
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

        public async Task<DescribeEndpointSwitchStatusResponse> DescribeEndpointSwitchStatusWithOptionsAsync(DescribeEndpointSwitchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeEndpointSwitchStatus",
                Version = "2019-09-01",
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

        public DescribeEndpointSwitchStatusResponse DescribeEndpointSwitchStatus(DescribeEndpointSwitchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEndpointSwitchStatusWithOptions(request, runtime);
        }

        public async Task<DescribeEndpointSwitchStatusResponse> DescribeEndpointSwitchStatusAsync(DescribeEndpointSwitchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEndpointSwitchStatusWithOptionsAsync(request, runtime);
        }

        public DescribeSynchronizationJobAlertResponse DescribeSynchronizationJobAlertWithOptions(DescribeSynchronizationJobAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Version = "2019-09-01",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Version = "2019-09-01",
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
                Version = "2019-09-01",
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
                Version = "2019-09-01",
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
                Version = "2019-09-01",
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
                Version = "2019-09-01",
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
                Version = "2019-09-01",
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
                Version = "2019-09-01",
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

        public ModifySynchronizationObjectResponse ModifySynchronizationObjectWithOptions(ModifySynchronizationObjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
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
                Version = "2019-09-01",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationDirection))
            {
                query["SynchronizationDirection"] = request.SynchronizationDirection;
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
                Version = "2019-09-01",
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

        public ResetSynchronizationJobResponse ResetSynchronizationJobWithOptions(ResetSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Version = "2019-09-01",
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

        public async Task<ResetSynchronizationJobResponse> ResetSynchronizationJobWithOptionsAsync(ResetSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Version = "2019-09-01",
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

        public ResetSynchronizationJobResponse ResetSynchronizationJob(ResetSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetSynchronizationJobWithOptions(request, runtime);
        }

        public async Task<ResetSynchronizationJobResponse> ResetSynchronizationJobAsync(ResetSynchronizationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetSynchronizationJobWithOptionsAsync(request, runtime);
        }

        public StartSynchronizationJobResponse StartSynchronizationJobWithOptions(StartSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Version = "2019-09-01",
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
                Version = "2019-09-01",
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

        public SuspendSynchronizationJobResponse SuspendSynchronizationJobWithOptions(SuspendSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Version = "2019-09-01",
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
                Version = "2019-09-01",
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

        public SwitchSynchronizationEndpointResponse SwitchSynchronizationEndpointWithOptions(SwitchSynchronizationEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchSynchronizationEndpoint",
                Version = "2019-09-01",
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

        public async Task<SwitchSynchronizationEndpointResponse> SwitchSynchronizationEndpointWithOptionsAsync(SwitchSynchronizationEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchSynchronizationEndpoint",
                Version = "2019-09-01",
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

        public SwitchSynchronizationEndpointResponse SwitchSynchronizationEndpoint(SwitchSynchronizationEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchSynchronizationEndpointWithOptions(request, runtime);
        }

        public async Task<SwitchSynchronizationEndpointResponse> SwitchSynchronizationEndpointAsync(SwitchSynchronizationEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchSynchronizationEndpointWithOptionsAsync(request, runtime);
        }

    }
}
