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

        public ConfigureDtsJobResponse ConfigureDtsJobWithOptions(ConfigureDtsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigureDtsJobResponse>(DoRPCRequest("ConfigureDtsJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigureDtsJobResponse> ConfigureDtsJobWithOptionsAsync(ConfigureDtsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigureDtsJobResponse>(await DoRPCRequestAsync("ConfigureDtsJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConfigureDtsJobResponse ConfigureDtsJob(ConfigureDtsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigureDtsJobWithOptions(request, runtime);
        }

        public async Task<ConfigureDtsJobResponse> ConfigureDtsJobAsync(ConfigureDtsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigureDtsJobWithOptionsAsync(request, runtime);
        }

        public ConfigureMigrationJobResponse ConfigureMigrationJobWithOptions(ConfigureMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigureMigrationJobResponse>(DoRPCRequest("ConfigureMigrationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigureMigrationJobResponse> ConfigureMigrationJobWithOptionsAsync(ConfigureMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigureMigrationJobResponse>(await DoRPCRequestAsync("ConfigureMigrationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ConfigureMigrationJobAlertResponse ConfigureMigrationJobAlertWithOptions(ConfigureMigrationJobAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigureMigrationJobAlertResponse>(DoRPCRequest("ConfigureMigrationJobAlert", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigureMigrationJobAlertResponse> ConfigureMigrationJobAlertWithOptionsAsync(ConfigureMigrationJobAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigureMigrationJobAlertResponse>(await DoRPCRequestAsync("ConfigureMigrationJobAlert", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigureSubscriptionResponse>(DoRPCRequest("ConfigureSubscription", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigureSubscriptionResponse> ConfigureSubscriptionWithOptionsAsync(ConfigureSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigureSubscriptionResponse>(await DoRPCRequestAsync("ConfigureSubscription", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ConfigureSubscriptionInstanceResponse ConfigureSubscriptionInstanceWithOptions(ConfigureSubscriptionInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigureSubscriptionInstanceResponse>(DoRPCRequest("ConfigureSubscriptionInstance", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigureSubscriptionInstanceResponse> ConfigureSubscriptionInstanceWithOptionsAsync(ConfigureSubscriptionInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigureSubscriptionInstanceResponse>(await DoRPCRequestAsync("ConfigureSubscriptionInstance", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ConfigureSubscriptionInstanceAlertResponse ConfigureSubscriptionInstanceAlertWithOptions(ConfigureSubscriptionInstanceAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigureSubscriptionInstanceAlertResponse>(DoRPCRequest("ConfigureSubscriptionInstanceAlert", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigureSubscriptionInstanceAlertResponse> ConfigureSubscriptionInstanceAlertWithOptionsAsync(ConfigureSubscriptionInstanceAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigureSubscriptionInstanceAlertResponse>(await DoRPCRequestAsync("ConfigureSubscriptionInstanceAlert", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ConfigureSynchronizationJobResponse ConfigureSynchronizationJobWithOptions(ConfigureSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigureSynchronizationJobResponse>(DoRPCRequest("ConfigureSynchronizationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigureSynchronizationJobResponse> ConfigureSynchronizationJobWithOptionsAsync(ConfigureSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigureSynchronizationJobResponse>(await DoRPCRequestAsync("ConfigureSynchronizationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigureSynchronizationJobAlertResponse>(DoRPCRequest("ConfigureSynchronizationJobAlert", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigureSynchronizationJobAlertResponse> ConfigureSynchronizationJobAlertWithOptionsAsync(ConfigureSynchronizationJobAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigureSynchronizationJobAlertResponse>(await DoRPCRequestAsync("ConfigureSynchronizationJobAlert", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ConfigureSynchronizationJobReplicatorCompareResponse ConfigureSynchronizationJobReplicatorCompareWithOptions(ConfigureSynchronizationJobReplicatorCompareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigureSynchronizationJobReplicatorCompareResponse>(DoRPCRequest("ConfigureSynchronizationJobReplicatorCompare", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigureSynchronizationJobReplicatorCompareResponse> ConfigureSynchronizationJobReplicatorCompareWithOptionsAsync(ConfigureSynchronizationJobReplicatorCompareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigureSynchronizationJobReplicatorCompareResponse>(await DoRPCRequestAsync("ConfigureSynchronizationJobReplicatorCompare", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConfigureSynchronizationJobReplicatorCompareResponse ConfigureSynchronizationJobReplicatorCompare(ConfigureSynchronizationJobReplicatorCompareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigureSynchronizationJobReplicatorCompareWithOptions(request, runtime);
        }

        public async Task<ConfigureSynchronizationJobReplicatorCompareResponse> ConfigureSynchronizationJobReplicatorCompareAsync(ConfigureSynchronizationJobReplicatorCompareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigureSynchronizationJobReplicatorCompareWithOptionsAsync(request, runtime);
        }

        public CreateConsumerChannelResponse CreateConsumerChannelWithOptions(CreateConsumerChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateConsumerChannelResponse>(DoRPCRequest("CreateConsumerChannel", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateConsumerChannelResponse> CreateConsumerChannelWithOptionsAsync(CreateConsumerChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateConsumerChannelResponse>(await DoRPCRequestAsync("CreateConsumerChannel", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateConsumerGroupResponse>(DoRPCRequest("CreateConsumerGroup", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateConsumerGroupResponse> CreateConsumerGroupWithOptionsAsync(CreateConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateConsumerGroupResponse>(await DoRPCRequestAsync("CreateConsumerGroup", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateDtsInstanceResponse CreateDtsInstanceWithOptions(CreateDtsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDtsInstanceResponse>(DoRPCRequest("CreateDtsInstance", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDtsInstanceResponse> CreateDtsInstanceWithOptionsAsync(CreateDtsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDtsInstanceResponse>(await DoRPCRequestAsync("CreateDtsInstance", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDtsInstanceResponse CreateDtsInstance(CreateDtsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDtsInstanceWithOptions(request, runtime);
        }

        public async Task<CreateDtsInstanceResponse> CreateDtsInstanceAsync(CreateDtsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDtsInstanceWithOptionsAsync(request, runtime);
        }

        public CreateJobMonitorRuleResponse CreateJobMonitorRuleWithOptions(CreateJobMonitorRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateJobMonitorRuleResponse>(DoRPCRequest("CreateJobMonitorRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateJobMonitorRuleResponse> CreateJobMonitorRuleWithOptionsAsync(CreateJobMonitorRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateJobMonitorRuleResponse>(await DoRPCRequestAsync("CreateJobMonitorRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateJobMonitorRuleResponse CreateJobMonitorRule(CreateJobMonitorRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateJobMonitorRuleWithOptions(request, runtime);
        }

        public async Task<CreateJobMonitorRuleResponse> CreateJobMonitorRuleAsync(CreateJobMonitorRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateJobMonitorRuleWithOptionsAsync(request, runtime);
        }

        public CreateMigrationJobResponse CreateMigrationJobWithOptions(CreateMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMigrationJobResponse>(DoRPCRequest("CreateMigrationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMigrationJobResponse> CreateMigrationJobWithOptionsAsync(CreateMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMigrationJobResponse>(await DoRPCRequestAsync("CreateMigrationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSubscriptionInstanceResponse>(DoRPCRequest("CreateSubscriptionInstance", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSubscriptionInstanceResponse> CreateSubscriptionInstanceWithOptionsAsync(CreateSubscriptionInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSubscriptionInstanceResponse>(await DoRPCRequestAsync("CreateSubscriptionInstance", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSynchronizationJobResponse>(DoRPCRequest("CreateSynchronizationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSynchronizationJobResponse> CreateSynchronizationJobWithOptionsAsync(CreateSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSynchronizationJobResponse>(await DoRPCRequestAsync("CreateSynchronizationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteConsumerChannelResponse DeleteConsumerChannelWithOptions(DeleteConsumerChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteConsumerChannelResponse>(DoRPCRequest("DeleteConsumerChannel", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteConsumerChannelResponse> DeleteConsumerChannelWithOptionsAsync(DeleteConsumerChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteConsumerChannelResponse>(await DoRPCRequestAsync("DeleteConsumerChannel", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteConsumerGroupResponse>(DoRPCRequest("DeleteConsumerGroup", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteConsumerGroupResponse> DeleteConsumerGroupWithOptionsAsync(DeleteConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteConsumerGroupResponse>(await DoRPCRequestAsync("DeleteConsumerGroup", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDtsJobResponse>(DoRPCRequest("DeleteDtsJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDtsJobResponse> DeleteDtsJobWithOptionsAsync(DeleteDtsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDtsJobResponse>(await DoRPCRequestAsync("DeleteDtsJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteMigrationJobResponse DeleteMigrationJobWithOptions(DeleteMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMigrationJobResponse>(DoRPCRequest("DeleteMigrationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMigrationJobResponse> DeleteMigrationJobWithOptionsAsync(DeleteMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMigrationJobResponse>(await DoRPCRequestAsync("DeleteMigrationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSubscriptionInstanceResponse>(DoRPCRequest("DeleteSubscriptionInstance", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSubscriptionInstanceResponse> DeleteSubscriptionInstanceWithOptionsAsync(DeleteSubscriptionInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSubscriptionInstanceResponse>(await DoRPCRequestAsync("DeleteSubscriptionInstance", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSynchronizationJobResponse>(DoRPCRequest("DeleteSynchronizationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSynchronizationJobResponse> DeleteSynchronizationJobWithOptionsAsync(DeleteSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSynchronizationJobResponse>(await DoRPCRequestAsync("DeleteSynchronizationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeConnectionStatusResponse DescribeConnectionStatusWithOptions(DescribeConnectionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeConnectionStatusResponse>(DoRPCRequest("DescribeConnectionStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeConnectionStatusResponse> DescribeConnectionStatusWithOptionsAsync(DescribeConnectionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeConnectionStatusResponse>(await DoRPCRequestAsync("DescribeConnectionStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeConsumerChannelResponse>(DoRPCRequest("DescribeConsumerChannel", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeConsumerChannelResponse> DescribeConsumerChannelWithOptionsAsync(DescribeConsumerChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeConsumerChannelResponse>(await DoRPCRequestAsync("DescribeConsumerChannel", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeConsumerGroupResponse>(DoRPCRequest("DescribeConsumerGroup", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeConsumerGroupResponse> DescribeConsumerGroupWithOptionsAsync(DescribeConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeConsumerGroupResponse>(await DoRPCRequestAsync("DescribeConsumerGroup", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDTSIPResponse DescribeDTSIPWithOptions(DescribeDTSIPRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDTSIPResponse>(DoRPCRequest("DescribeDTSIP", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDTSIPResponse> DescribeDTSIPWithOptionsAsync(DescribeDTSIPRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDTSIPResponse>(await DoRPCRequestAsync("DescribeDTSIP", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDTSIPResponse DescribeDTSIP(DescribeDTSIPRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDTSIPWithOptions(request, runtime);
        }

        public async Task<DescribeDTSIPResponse> DescribeDTSIPAsync(DescribeDTSIPRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDTSIPWithOptionsAsync(request, runtime);
        }

        public DescribeDtsJobDetailResponse DescribeDtsJobDetailWithOptions(DescribeDtsJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDtsJobDetailResponse>(DoRPCRequest("DescribeDtsJobDetail", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDtsJobDetailResponse> DescribeDtsJobDetailWithOptionsAsync(DescribeDtsJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDtsJobDetailResponse>(await DoRPCRequestAsync("DescribeDtsJobDetail", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDtsJobsResponse DescribeDtsJobsWithOptions(DescribeDtsJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDtsJobsResponse>(DoRPCRequest("DescribeDtsJobs", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDtsJobsResponse> DescribeDtsJobsWithOptionsAsync(DescribeDtsJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDtsJobsResponse>(await DoRPCRequestAsync("DescribeDtsJobs", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDtsJobsResponse DescribeDtsJobs(DescribeDtsJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDtsJobsWithOptions(request, runtime);
        }

        public async Task<DescribeDtsJobsResponse> DescribeDtsJobsAsync(DescribeDtsJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDtsJobsWithOptionsAsync(request, runtime);
        }

        public DescribeEndpointSwitchStatusResponse DescribeEndpointSwitchStatusWithOptions(DescribeEndpointSwitchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEndpointSwitchStatusResponse>(DoRPCRequest("DescribeEndpointSwitchStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEndpointSwitchStatusResponse> DescribeEndpointSwitchStatusWithOptionsAsync(DescribeEndpointSwitchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEndpointSwitchStatusResponse>(await DoRPCRequestAsync("DescribeEndpointSwitchStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeInitializationStatusResponse DescribeInitializationStatusWithOptions(DescribeInitializationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInitializationStatusResponse>(DoRPCRequest("DescribeInitializationStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInitializationStatusResponse> DescribeInitializationStatusWithOptionsAsync(DescribeInitializationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInitializationStatusResponse>(await DoRPCRequestAsync("DescribeInitializationStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeJobMonitorRuleResponse>(DoRPCRequest("DescribeJobMonitorRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeJobMonitorRuleResponse> DescribeJobMonitorRuleWithOptionsAsync(DescribeJobMonitorRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeJobMonitorRuleResponse>(await DoRPCRequestAsync("DescribeJobMonitorRule", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeMigrationJobAlertResponse DescribeMigrationJobAlertWithOptions(DescribeMigrationJobAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMigrationJobAlertResponse>(DoRPCRequest("DescribeMigrationJobAlert", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMigrationJobAlertResponse> DescribeMigrationJobAlertWithOptionsAsync(DescribeMigrationJobAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMigrationJobAlertResponse>(await DoRPCRequestAsync("DescribeMigrationJobAlert", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeMigrationJobDetailResponse DescribeMigrationJobDetailWithOptions(DescribeMigrationJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMigrationJobDetailResponse>(DoRPCRequest("DescribeMigrationJobDetail", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMigrationJobDetailResponse> DescribeMigrationJobDetailWithOptionsAsync(DescribeMigrationJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMigrationJobDetailResponse>(await DoRPCRequestAsync("DescribeMigrationJobDetail", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeMigrationJobsResponse DescribeMigrationJobsWithOptions(DescribeMigrationJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMigrationJobsResponse>(DoRPCRequest("DescribeMigrationJobs", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMigrationJobsResponse> DescribeMigrationJobsWithOptionsAsync(DescribeMigrationJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMigrationJobsResponse>(await DoRPCRequestAsync("DescribeMigrationJobs", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeMigrationJobStatusResponse DescribeMigrationJobStatusWithOptions(DescribeMigrationJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMigrationJobStatusResponse>(DoRPCRequest("DescribeMigrationJobStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMigrationJobStatusResponse> DescribeMigrationJobStatusWithOptionsAsync(DescribeMigrationJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMigrationJobStatusResponse>(await DoRPCRequestAsync("DescribeMigrationJobStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribePreCheckStatusResponse DescribePreCheckStatusWithOptions(DescribePreCheckStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePreCheckStatusResponse>(DoRPCRequest("DescribePreCheckStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePreCheckStatusResponse> DescribePreCheckStatusWithOptionsAsync(DescribePreCheckStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePreCheckStatusResponse>(await DoRPCRequestAsync("DescribePreCheckStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSubscriptionInstanceAlertResponse>(DoRPCRequest("DescribeSubscriptionInstanceAlert", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSubscriptionInstanceAlertResponse> DescribeSubscriptionInstanceAlertWithOptionsAsync(DescribeSubscriptionInstanceAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSubscriptionInstanceAlertResponse>(await DoRPCRequestAsync("DescribeSubscriptionInstanceAlert", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeSubscriptionInstancesResponse DescribeSubscriptionInstancesWithOptions(DescribeSubscriptionInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSubscriptionInstancesResponse>(DoRPCRequest("DescribeSubscriptionInstances", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSubscriptionInstancesResponse> DescribeSubscriptionInstancesWithOptionsAsync(DescribeSubscriptionInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSubscriptionInstancesResponse>(await DoRPCRequestAsync("DescribeSubscriptionInstances", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeSubscriptionInstanceStatusResponse DescribeSubscriptionInstanceStatusWithOptions(DescribeSubscriptionInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSubscriptionInstanceStatusResponse>(DoRPCRequest("DescribeSubscriptionInstanceStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSubscriptionInstanceStatusResponse> DescribeSubscriptionInstanceStatusWithOptionsAsync(DescribeSubscriptionInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSubscriptionInstanceStatusResponse>(await DoRPCRequestAsync("DescribeSubscriptionInstanceStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSubscriptionMetaResponse>(DoRPCRequest("DescribeSubscriptionMeta", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSubscriptionMetaResponse>(await DoRPCRequestAsync("DescribeSubscriptionMeta", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSubscriptionMetaResponse DescribeSubscriptionMeta(DescribeSubscriptionMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSubscriptionMetaWithOptions(request, runtime);
        }

        public async Task<DescribeSubscriptionMetaResponse> DescribeSubscriptionMetaAsync(DescribeSubscriptionMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSubscriptionMetaWithOptionsAsync(request, runtime);
        }

        public DescribeSynchronizationJobAlertResponse DescribeSynchronizationJobAlertWithOptions(DescribeSynchronizationJobAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSynchronizationJobAlertResponse>(DoRPCRequest("DescribeSynchronizationJobAlert", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSynchronizationJobAlertResponse> DescribeSynchronizationJobAlertWithOptionsAsync(DescribeSynchronizationJobAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSynchronizationJobAlertResponse>(await DoRPCRequestAsync("DescribeSynchronizationJobAlert", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSynchronizationJobReplicatorCompareResponse>(DoRPCRequest("DescribeSynchronizationJobReplicatorCompare", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSynchronizationJobReplicatorCompareResponse> DescribeSynchronizationJobReplicatorCompareWithOptionsAsync(DescribeSynchronizationJobReplicatorCompareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSynchronizationJobReplicatorCompareResponse>(await DoRPCRequestAsync("DescribeSynchronizationJobReplicatorCompare", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeSynchronizationJobsResponse DescribeSynchronizationJobsWithOptions(DescribeSynchronizationJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSynchronizationJobsResponse>(DoRPCRequest("DescribeSynchronizationJobs", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSynchronizationJobsResponse> DescribeSynchronizationJobsWithOptionsAsync(DescribeSynchronizationJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSynchronizationJobsResponse>(await DoRPCRequestAsync("DescribeSynchronizationJobs", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeSynchronizationJobStatusResponse DescribeSynchronizationJobStatusWithOptions(DescribeSynchronizationJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSynchronizationJobStatusResponse>(DoRPCRequest("DescribeSynchronizationJobStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSynchronizationJobStatusResponse> DescribeSynchronizationJobStatusWithOptionsAsync(DescribeSynchronizationJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSynchronizationJobStatusResponse>(await DoRPCRequestAsync("DescribeSynchronizationJobStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSynchronizationJobStatusListResponse>(DoRPCRequest("DescribeSynchronizationJobStatusList", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSynchronizationJobStatusListResponse> DescribeSynchronizationJobStatusListWithOptionsAsync(DescribeSynchronizationJobStatusListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSynchronizationJobStatusListResponse>(await DoRPCRequestAsync("DescribeSynchronizationJobStatusList", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeSynchronizationObjectModifyStatusResponse DescribeSynchronizationObjectModifyStatusWithOptions(DescribeSynchronizationObjectModifyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSynchronizationObjectModifyStatusResponse>(DoRPCRequest("DescribeSynchronizationObjectModifyStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSynchronizationObjectModifyStatusResponse> DescribeSynchronizationObjectModifyStatusWithOptionsAsync(DescribeSynchronizationObjectModifyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSynchronizationObjectModifyStatusResponse>(await DoRPCRequestAsync("DescribeSynchronizationObjectModifyStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public IgnoreJobDetailResponse IgnoreJobDetailWithOptions(IgnoreJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<IgnoreJobDetailResponse>(DoRPCRequest("IgnoreJobDetail", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<IgnoreJobDetailResponse> IgnoreJobDetailWithOptionsAsync(IgnoreJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<IgnoreJobDetailResponse>(await DoRPCRequestAsync("IgnoreJobDetail", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public IgnoreJobDetailResponse IgnoreJobDetail(IgnoreJobDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IgnoreJobDetailWithOptions(request, runtime);
        }

        public async Task<IgnoreJobDetailResponse> IgnoreJobDetailAsync(IgnoreJobDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IgnoreJobDetailWithOptionsAsync(request, runtime);
        }

        public InitDtsRdsInstanceResponse InitDtsRdsInstanceWithOptions(InitDtsRdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InitDtsRdsInstanceResponse>(DoRPCRequest("InitDtsRdsInstance", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InitDtsRdsInstanceResponse> InitDtsRdsInstanceWithOptionsAsync(InitDtsRdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InitDtsRdsInstanceResponse>(await DoRPCRequestAsync("InitDtsRdsInstance", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InitDtsRdsInstanceResponse InitDtsRdsInstance(InitDtsRdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitDtsRdsInstanceWithOptions(request, runtime);
        }

        public async Task<InitDtsRdsInstanceResponse> InitDtsRdsInstanceAsync(InitDtsRdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitDtsRdsInstanceWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRPCRequest("ListTagResources", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRPCRequestAsync("ListTagResources", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        public ModifyConsumerChannelResponse ModifyConsumerChannelWithOptions(ModifyConsumerChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyConsumerChannelResponse>(DoRPCRequest("ModifyConsumerChannel", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyConsumerChannelResponse> ModifyConsumerChannelWithOptionsAsync(ModifyConsumerChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyConsumerChannelResponse>(await DoRPCRequestAsync("ModifyConsumerChannel", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyConsumerGroupPasswordResponse ModifyConsumerGroupPasswordWithOptions(ModifyConsumerGroupPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyConsumerGroupPasswordResponse>(DoRPCRequest("ModifyConsumerGroupPassword", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyConsumerGroupPasswordResponse> ModifyConsumerGroupPasswordWithOptionsAsync(ModifyConsumerGroupPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyConsumerGroupPasswordResponse>(await DoRPCRequestAsync("ModifyConsumerGroupPassword", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyConsumerGroupPasswordResponse ModifyConsumerGroupPassword(ModifyConsumerGroupPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyConsumerGroupPasswordWithOptions(request, runtime);
        }

        public async Task<ModifyConsumerGroupPasswordResponse> ModifyConsumerGroupPasswordAsync(ModifyConsumerGroupPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyConsumerGroupPasswordWithOptionsAsync(request, runtime);
        }

        public ModifyConsumptionTimestampResponse ModifyConsumptionTimestampWithOptions(ModifyConsumptionTimestampRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyConsumptionTimestampResponse>(DoRPCRequest("ModifyConsumptionTimestamp", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyConsumptionTimestampResponse> ModifyConsumptionTimestampWithOptionsAsync(ModifyConsumptionTimestampRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyConsumptionTimestampResponse>(await DoRPCRequestAsync("ModifyConsumptionTimestamp", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyDtsJobResponse ModifyDtsJobWithOptions(ModifyDtsJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyDtsJobShrinkRequest request = new ModifyDtsJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DbList))
            {
                request.DbListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DbList, "DbList", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDtsJobResponse>(DoRPCRequest("ModifyDtsJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDtsJobResponse>(await DoRPCRequestAsync("ModifyDtsJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyDtsJobNameResponse ModifyDtsJobNameWithOptions(ModifyDtsJobNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDtsJobNameResponse>(DoRPCRequest("ModifyDtsJobName", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDtsJobNameResponse> ModifyDtsJobNameWithOptionsAsync(ModifyDtsJobNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDtsJobNameResponse>(await DoRPCRequestAsync("ModifyDtsJobName", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDtsJobPasswordResponse>(DoRPCRequest("ModifyDtsJobPassword", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDtsJobPasswordResponse> ModifyDtsJobPasswordWithOptionsAsync(ModifyDtsJobPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDtsJobPasswordResponse>(await DoRPCRequestAsync("ModifyDtsJobPassword", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifySubscriptionResponse ModifySubscriptionWithOptions(ModifySubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySubscriptionResponse>(DoRPCRequest("ModifySubscription", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySubscriptionResponse> ModifySubscriptionWithOptionsAsync(ModifySubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySubscriptionResponse>(await DoRPCRequestAsync("ModifySubscription", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifySubscriptionObjectResponse ModifySubscriptionObjectWithOptions(ModifySubscriptionObjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySubscriptionObjectResponse>(DoRPCRequest("ModifySubscriptionObject", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySubscriptionObjectResponse> ModifySubscriptionObjectWithOptionsAsync(ModifySubscriptionObjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySubscriptionObjectResponse>(await DoRPCRequestAsync("ModifySubscriptionObject", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySynchronizationObjectResponse>(DoRPCRequest("ModifySynchronizationObject", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySynchronizationObjectResponse> ModifySynchronizationObjectWithOptionsAsync(ModifySynchronizationObjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySynchronizationObjectResponse>(await DoRPCRequestAsync("ModifySynchronizationObject", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public RenewInstanceResponse RenewInstanceWithOptions(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewInstanceResponse>(DoRPCRequest("RenewInstance", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RenewInstanceResponse> RenewInstanceWithOptionsAsync(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewInstanceResponse>(await DoRPCRequestAsync("RenewInstance", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ResetDtsJobResponse ResetDtsJobWithOptions(ResetDtsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetDtsJobResponse>(DoRPCRequest("ResetDtsJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetDtsJobResponse> ResetDtsJobWithOptionsAsync(ResetDtsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetDtsJobResponse>(await DoRPCRequestAsync("ResetDtsJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResetDtsJobResponse ResetDtsJob(ResetDtsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetDtsJobWithOptions(request, runtime);
        }

        public async Task<ResetDtsJobResponse> ResetDtsJobAsync(ResetDtsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetDtsJobWithOptionsAsync(request, runtime);
        }

        public ResetSynchronizationJobResponse ResetSynchronizationJobWithOptions(ResetSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetSynchronizationJobResponse>(DoRPCRequest("ResetSynchronizationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetSynchronizationJobResponse> ResetSynchronizationJobWithOptionsAsync(ResetSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetSynchronizationJobResponse>(await DoRPCRequestAsync("ResetSynchronizationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ShieldPrecheckResponse ShieldPrecheckWithOptions(ShieldPrecheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ShieldPrecheckResponse>(DoRPCRequest("ShieldPrecheck", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ShieldPrecheckResponse> ShieldPrecheckWithOptionsAsync(ShieldPrecheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ShieldPrecheckResponse>(await DoRPCRequestAsync("ShieldPrecheck", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ShieldPrecheckResponse ShieldPrecheck(ShieldPrecheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ShieldPrecheckWithOptions(request, runtime);
        }

        public async Task<ShieldPrecheckResponse> ShieldPrecheckAsync(ShieldPrecheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ShieldPrecheckWithOptionsAsync(request, runtime);
        }

        public SkipPreCheckResponse SkipPreCheckWithOptions(SkipPreCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SkipPreCheckResponse>(DoRPCRequest("SkipPreCheck", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SkipPreCheckResponse> SkipPreCheckWithOptionsAsync(SkipPreCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SkipPreCheckResponse>(await DoRPCRequestAsync("SkipPreCheck", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartDtsJobResponse>(DoRPCRequest("StartDtsJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartDtsJobResponse> StartDtsJobWithOptionsAsync(StartDtsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartDtsJobResponse>(await DoRPCRequestAsync("StartDtsJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public StartMigrationJobResponse StartMigrationJobWithOptions(StartMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartMigrationJobResponse>(DoRPCRequest("StartMigrationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartMigrationJobResponse> StartMigrationJobWithOptionsAsync(StartMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartMigrationJobResponse>(await DoRPCRequestAsync("StartMigrationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartSubscriptionInstanceResponse>(DoRPCRequest("StartSubscriptionInstance", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartSubscriptionInstanceResponse> StartSubscriptionInstanceWithOptionsAsync(StartSubscriptionInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartSubscriptionInstanceResponse>(await DoRPCRequestAsync("StartSubscriptionInstance", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartSynchronizationJobResponse>(DoRPCRequest("StartSynchronizationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartSynchronizationJobResponse> StartSynchronizationJobWithOptionsAsync(StartSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartSynchronizationJobResponse>(await DoRPCRequestAsync("StartSynchronizationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public StopDtsJobResponse StopDtsJobWithOptions(StopDtsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDtsJobResponse>(DoRPCRequest("StopDtsJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopDtsJobResponse> StopDtsJobWithOptionsAsync(StopDtsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDtsJobResponse>(await DoRPCRequestAsync("StopDtsJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public StopMigrationJobResponse StopMigrationJobWithOptions(StopMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopMigrationJobResponse>(DoRPCRequest("StopMigrationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopMigrationJobResponse> StopMigrationJobWithOptionsAsync(StopMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopMigrationJobResponse>(await DoRPCRequestAsync("StopMigrationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SummaryJobDetailResponse SummaryJobDetailWithOptions(SummaryJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SummaryJobDetailResponse>(DoRPCRequest("SummaryJobDetail", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SummaryJobDetailResponse> SummaryJobDetailWithOptionsAsync(SummaryJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SummaryJobDetailResponse>(await DoRPCRequestAsync("SummaryJobDetail", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SuspendDtsJobResponse SuspendDtsJobWithOptions(SuspendDtsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendDtsJobResponse>(DoRPCRequest("SuspendDtsJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SuspendDtsJobResponse> SuspendDtsJobWithOptionsAsync(SuspendDtsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendDtsJobResponse>(await DoRPCRequestAsync("SuspendDtsJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SuspendDtsJobResponse SuspendDtsJob(SuspendDtsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendDtsJobWithOptions(request, runtime);
        }

        public async Task<SuspendDtsJobResponse> SuspendDtsJobAsync(SuspendDtsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendDtsJobWithOptionsAsync(request, runtime);
        }

        public SuspendMigrationJobResponse SuspendMigrationJobWithOptions(SuspendMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendMigrationJobResponse>(DoRPCRequest("SuspendMigrationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SuspendMigrationJobResponse> SuspendMigrationJobWithOptionsAsync(SuspendMigrationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendMigrationJobResponse>(await DoRPCRequestAsync("SuspendMigrationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendSynchronizationJobResponse>(DoRPCRequest("SuspendSynchronizationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SuspendSynchronizationJobResponse> SuspendSynchronizationJobWithOptionsAsync(SuspendSynchronizationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendSynchronizationJobResponse>(await DoRPCRequestAsync("SuspendSynchronizationJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchSynchronizationEndpointResponse>(DoRPCRequest("SwitchSynchronizationEndpoint", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SwitchSynchronizationEndpointResponse> SwitchSynchronizationEndpointWithOptionsAsync(SwitchSynchronizationEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchSynchronizationEndpointResponse>(await DoRPCRequestAsync("SwitchSynchronizationEndpoint", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        public TransferInstanceClassResponse TransferInstanceClassWithOptions(TransferInstanceClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransferInstanceClassResponse>(DoRPCRequest("TransferInstanceClass", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TransferInstanceClassResponse> TransferInstanceClassWithOptionsAsync(TransferInstanceClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransferInstanceClassResponse>(await DoRPCRequestAsync("TransferInstanceClass", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public TransferPayTypeResponse TransferPayTypeWithOptions(TransferPayTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransferPayTypeResponse>(DoRPCRequest("TransferPayType", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TransferPayTypeResponse> TransferPayTypeWithOptionsAsync(TransferPayTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransferPayTypeResponse>(await DoRPCRequestAsync("TransferPayType", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TransferPayTypeResponse TransferPayType(TransferPayTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferPayTypeWithOptions(request, runtime);
        }

        public async Task<TransferPayTypeResponse> TransferPayTypeAsync(TransferPayTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferPayTypeWithOptionsAsync(request, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(DoRPCRequest("UntagResources", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRPCRequestAsync("UntagResources", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        public UpgradeTwoWayResponse UpgradeTwoWayWithOptions(UpgradeTwoWayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeTwoWayResponse>(DoRPCRequest("UpgradeTwoWay", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpgradeTwoWayResponse> UpgradeTwoWayWithOptionsAsync(UpgradeTwoWayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeTwoWayResponse>(await DoRPCRequestAsync("UpgradeTwoWay", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpgradeTwoWayResponse UpgradeTwoWay(UpgradeTwoWayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeTwoWayWithOptions(request, runtime);
        }

        public async Task<UpgradeTwoWayResponse> UpgradeTwoWayAsync(UpgradeTwoWayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeTwoWayWithOptionsAsync(request, runtime);
        }

        public WhiteIpListResponse WhiteIpListWithOptions(WhiteIpListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<WhiteIpListResponse>(DoRPCRequest("WhiteIpList", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<WhiteIpListResponse> WhiteIpListWithOptionsAsync(WhiteIpListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<WhiteIpListResponse>(await DoRPCRequestAsync("WhiteIpList", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public WhiteIpListResponse WhiteIpList(WhiteIpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return WhiteIpListWithOptions(request, runtime);
        }

        public async Task<WhiteIpListResponse> WhiteIpListAsync(WhiteIpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await WhiteIpListWithOptionsAsync(request, runtime);
        }

    }
}
