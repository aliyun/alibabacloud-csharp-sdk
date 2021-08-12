// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ess20140828.Models;

namespace AlibabaCloud.SDK.Ess20140828
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "ess.aliyuncs.com"},
                {"cn-beijing", "ess.aliyuncs.com"},
                {"cn-hangzhou", "ess.aliyuncs.com"},
                {"cn-shanghai", "ess.aliyuncs.com"},
                {"cn-shenzhen", "ess.aliyuncs.com"},
                {"cn-hongkong", "ess.aliyuncs.com"},
                {"ap-southeast-1", "ess.aliyuncs.com"},
                {"us-west-1", "ess.aliyuncs.com"},
                {"us-east-1", "ess.aliyuncs.com"},
                {"cn-shanghai-finance-1", "ess.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "ess.aliyuncs.com"},
                {"cn-north-2-gov-1", "ess.aliyuncs.com"},
                {"ap-northeast-2-pop", "ess.ap-northeast-1.aliyuncs.com"},
                {"cn-beijing-finance-1", "ess.aliyuncs.com"},
                {"cn-beijing-finance-pop", "ess.aliyuncs.com"},
                {"cn-beijing-gov-1", "ess.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "ess.aliyuncs.com"},
                {"cn-edge-1", "ess.aliyuncs.com"},
                {"cn-fujian", "ess.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "ess.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "ess.aliyuncs.com"},
                {"cn-hangzhou-finance", "ess.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "ess.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "ess.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "ess.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "ess.aliyuncs.com"},
                {"cn-hangzhou-test-306", "ess.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "ess.aliyuncs.com"},
                {"cn-qingdao-nebula", "ess.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "ess.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "ess.aliyuncs.com"},
                {"cn-shanghai-inner", "ess.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "ess.aliyuncs.com"},
                {"cn-shenzhen-inner", "ess.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "ess.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "ess.aliyuncs.com"},
                {"cn-wuhan", "ess.aliyuncs.com"},
                {"cn-yushanfang", "ess.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "ess.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "ess.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "ess.aliyuncs.com"},
                {"eu-west-1-oxs", "ess.ap-northeast-1.aliyuncs.com"},
                {"rus-west-1-pop", "ess.ap-northeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("ess", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AttachAlbServerGroupsResponse AttachAlbServerGroupsWithOptions(AttachAlbServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachAlbServerGroupsResponse>(DoRPCRequest("AttachAlbServerGroups", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachAlbServerGroupsResponse> AttachAlbServerGroupsWithOptionsAsync(AttachAlbServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachAlbServerGroupsResponse>(await DoRPCRequestAsync("AttachAlbServerGroups", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachAlbServerGroupsResponse AttachAlbServerGroups(AttachAlbServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachAlbServerGroupsWithOptions(request, runtime);
        }

        public async Task<AttachAlbServerGroupsResponse> AttachAlbServerGroupsAsync(AttachAlbServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachAlbServerGroupsWithOptionsAsync(request, runtime);
        }

        public AttachDBInstancesResponse AttachDBInstancesWithOptions(AttachDBInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachDBInstancesResponse>(DoRPCRequest("AttachDBInstances", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachDBInstancesResponse> AttachDBInstancesWithOptionsAsync(AttachDBInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachDBInstancesResponse>(await DoRPCRequestAsync("AttachDBInstances", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachDBInstancesResponse AttachDBInstances(AttachDBInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachDBInstancesWithOptions(request, runtime);
        }

        public async Task<AttachDBInstancesResponse> AttachDBInstancesAsync(AttachDBInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachDBInstancesWithOptionsAsync(request, runtime);
        }

        public AttachInstancesResponse AttachInstancesWithOptions(AttachInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachInstancesResponse>(DoRPCRequest("AttachInstances", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachInstancesResponse> AttachInstancesWithOptionsAsync(AttachInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachInstancesResponse>(await DoRPCRequestAsync("AttachInstances", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachInstancesResponse AttachInstances(AttachInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachInstancesWithOptions(request, runtime);
        }

        public async Task<AttachInstancesResponse> AttachInstancesAsync(AttachInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachInstancesWithOptionsAsync(request, runtime);
        }

        public AttachLoadBalancersResponse AttachLoadBalancersWithOptions(AttachLoadBalancersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachLoadBalancersResponse>(DoRPCRequest("AttachLoadBalancers", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachLoadBalancersResponse> AttachLoadBalancersWithOptionsAsync(AttachLoadBalancersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachLoadBalancersResponse>(await DoRPCRequestAsync("AttachLoadBalancers", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachLoadBalancersResponse AttachLoadBalancers(AttachLoadBalancersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachLoadBalancersWithOptions(request, runtime);
        }

        public async Task<AttachLoadBalancersResponse> AttachLoadBalancersAsync(AttachLoadBalancersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachLoadBalancersWithOptionsAsync(request, runtime);
        }

        public AttachVServerGroupsResponse AttachVServerGroupsWithOptions(AttachVServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachVServerGroupsResponse>(DoRPCRequest("AttachVServerGroups", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachVServerGroupsResponse> AttachVServerGroupsWithOptionsAsync(AttachVServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachVServerGroupsResponse>(await DoRPCRequestAsync("AttachVServerGroups", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachVServerGroupsResponse AttachVServerGroups(AttachVServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachVServerGroupsWithOptions(request, runtime);
        }

        public async Task<AttachVServerGroupsResponse> AttachVServerGroupsAsync(AttachVServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachVServerGroupsWithOptionsAsync(request, runtime);
        }

        public CompleteLifecycleActionResponse CompleteLifecycleActionWithOptions(CompleteLifecycleActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CompleteLifecycleActionResponse>(DoRPCRequest("CompleteLifecycleAction", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CompleteLifecycleActionResponse> CompleteLifecycleActionWithOptionsAsync(CompleteLifecycleActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CompleteLifecycleActionResponse>(await DoRPCRequestAsync("CompleteLifecycleAction", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CompleteLifecycleActionResponse CompleteLifecycleAction(CompleteLifecycleActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompleteLifecycleActionWithOptions(request, runtime);
        }

        public async Task<CompleteLifecycleActionResponse> CompleteLifecycleActionAsync(CompleteLifecycleActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompleteLifecycleActionWithOptionsAsync(request, runtime);
        }

        public CreateAlarmResponse CreateAlarmWithOptions(CreateAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAlarmResponse>(DoRPCRequest("CreateAlarm", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAlarmResponse> CreateAlarmWithOptionsAsync(CreateAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAlarmResponse>(await DoRPCRequestAsync("CreateAlarm", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAlarmResponse CreateAlarm(CreateAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAlarmWithOptions(request, runtime);
        }

        public async Task<CreateAlarmResponse> CreateAlarmAsync(CreateAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAlarmWithOptionsAsync(request, runtime);
        }

        public CreateLifecycleHookResponse CreateLifecycleHookWithOptions(CreateLifecycleHookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLifecycleHookResponse>(DoRPCRequest("CreateLifecycleHook", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateLifecycleHookResponse> CreateLifecycleHookWithOptionsAsync(CreateLifecycleHookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLifecycleHookResponse>(await DoRPCRequestAsync("CreateLifecycleHook", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateLifecycleHookResponse CreateLifecycleHook(CreateLifecycleHookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLifecycleHookWithOptions(request, runtime);
        }

        public async Task<CreateLifecycleHookResponse> CreateLifecycleHookAsync(CreateLifecycleHookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLifecycleHookWithOptionsAsync(request, runtime);
        }

        public CreateNotificationConfigurationResponse CreateNotificationConfigurationWithOptions(CreateNotificationConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNotificationConfigurationResponse>(DoRPCRequest("CreateNotificationConfiguration", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateNotificationConfigurationResponse> CreateNotificationConfigurationWithOptionsAsync(CreateNotificationConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNotificationConfigurationResponse>(await DoRPCRequestAsync("CreateNotificationConfiguration", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateNotificationConfigurationResponse CreateNotificationConfiguration(CreateNotificationConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNotificationConfigurationWithOptions(request, runtime);
        }

        public async Task<CreateNotificationConfigurationResponse> CreateNotificationConfigurationAsync(CreateNotificationConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNotificationConfigurationWithOptionsAsync(request, runtime);
        }

        public CreateScalingConfigurationResponse CreateScalingConfigurationWithOptions(CreateScalingConfigurationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateScalingConfigurationShrinkRequest request = new CreateScalingConfigurationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SchedulerOptions))
            {
                request.SchedulerOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SchedulerOptions, "SchedulerOptions", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateScalingConfigurationResponse>(DoRPCRequest("CreateScalingConfiguration", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateScalingConfigurationResponse> CreateScalingConfigurationWithOptionsAsync(CreateScalingConfigurationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateScalingConfigurationShrinkRequest request = new CreateScalingConfigurationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SchedulerOptions))
            {
                request.SchedulerOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SchedulerOptions, "SchedulerOptions", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateScalingConfigurationResponse>(await DoRPCRequestAsync("CreateScalingConfiguration", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateScalingConfigurationResponse CreateScalingConfiguration(CreateScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScalingConfigurationWithOptions(request, runtime);
        }

        public async Task<CreateScalingConfigurationResponse> CreateScalingConfigurationAsync(CreateScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScalingConfigurationWithOptionsAsync(request, runtime);
        }

        public CreateScalingGroupResponse CreateScalingGroupWithOptions(CreateScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateScalingGroupResponse>(DoRPCRequest("CreateScalingGroup", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateScalingGroupResponse> CreateScalingGroupWithOptionsAsync(CreateScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateScalingGroupResponse>(await DoRPCRequestAsync("CreateScalingGroup", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateScalingGroupResponse CreateScalingGroup(CreateScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScalingGroupWithOptions(request, runtime);
        }

        public async Task<CreateScalingGroupResponse> CreateScalingGroupAsync(CreateScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScalingGroupWithOptionsAsync(request, runtime);
        }

        public CreateScalingRuleResponse CreateScalingRuleWithOptions(CreateScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateScalingRuleResponse>(DoRPCRequest("CreateScalingRule", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateScalingRuleResponse> CreateScalingRuleWithOptionsAsync(CreateScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateScalingRuleResponse>(await DoRPCRequestAsync("CreateScalingRule", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateScalingRuleResponse CreateScalingRule(CreateScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScalingRuleWithOptions(request, runtime);
        }

        public async Task<CreateScalingRuleResponse> CreateScalingRuleAsync(CreateScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScalingRuleWithOptionsAsync(request, runtime);
        }

        public CreateScheduledTaskResponse CreateScheduledTaskWithOptions(CreateScheduledTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateScheduledTaskResponse>(DoRPCRequest("CreateScheduledTask", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateScheduledTaskResponse> CreateScheduledTaskWithOptionsAsync(CreateScheduledTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateScheduledTaskResponse>(await DoRPCRequestAsync("CreateScheduledTask", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateScheduledTaskResponse CreateScheduledTask(CreateScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScheduledTaskWithOptions(request, runtime);
        }

        public async Task<CreateScheduledTaskResponse> CreateScheduledTaskAsync(CreateScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScheduledTaskWithOptionsAsync(request, runtime);
        }

        public DeactivateScalingConfigurationResponse DeactivateScalingConfigurationWithOptions(DeactivateScalingConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeactivateScalingConfigurationResponse>(DoRPCRequest("DeactivateScalingConfiguration", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeactivateScalingConfigurationResponse> DeactivateScalingConfigurationWithOptionsAsync(DeactivateScalingConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeactivateScalingConfigurationResponse>(await DoRPCRequestAsync("DeactivateScalingConfiguration", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeactivateScalingConfigurationResponse DeactivateScalingConfiguration(DeactivateScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeactivateScalingConfigurationWithOptions(request, runtime);
        }

        public async Task<DeactivateScalingConfigurationResponse> DeactivateScalingConfigurationAsync(DeactivateScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeactivateScalingConfigurationWithOptionsAsync(request, runtime);
        }

        public DeleteAlarmResponse DeleteAlarmWithOptions(DeleteAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAlarmResponse>(DoRPCRequest("DeleteAlarm", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAlarmResponse> DeleteAlarmWithOptionsAsync(DeleteAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAlarmResponse>(await DoRPCRequestAsync("DeleteAlarm", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAlarmResponse DeleteAlarm(DeleteAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAlarmWithOptions(request, runtime);
        }

        public async Task<DeleteAlarmResponse> DeleteAlarmAsync(DeleteAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAlarmWithOptionsAsync(request, runtime);
        }

        public DeleteLifecycleHookResponse DeleteLifecycleHookWithOptions(DeleteLifecycleHookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLifecycleHookResponse>(DoRPCRequest("DeleteLifecycleHook", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLifecycleHookResponse> DeleteLifecycleHookWithOptionsAsync(DeleteLifecycleHookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLifecycleHookResponse>(await DoRPCRequestAsync("DeleteLifecycleHook", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLifecycleHookResponse DeleteLifecycleHook(DeleteLifecycleHookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLifecycleHookWithOptions(request, runtime);
        }

        public async Task<DeleteLifecycleHookResponse> DeleteLifecycleHookAsync(DeleteLifecycleHookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLifecycleHookWithOptionsAsync(request, runtime);
        }

        public DeleteNotificationConfigurationResponse DeleteNotificationConfigurationWithOptions(DeleteNotificationConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNotificationConfigurationResponse>(DoRPCRequest("DeleteNotificationConfiguration", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteNotificationConfigurationResponse> DeleteNotificationConfigurationWithOptionsAsync(DeleteNotificationConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNotificationConfigurationResponse>(await DoRPCRequestAsync("DeleteNotificationConfiguration", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteNotificationConfigurationResponse DeleteNotificationConfiguration(DeleteNotificationConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNotificationConfigurationWithOptions(request, runtime);
        }

        public async Task<DeleteNotificationConfigurationResponse> DeleteNotificationConfigurationAsync(DeleteNotificationConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNotificationConfigurationWithOptionsAsync(request, runtime);
        }

        public DeleteScalingConfigurationResponse DeleteScalingConfigurationWithOptions(DeleteScalingConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteScalingConfigurationResponse>(DoRPCRequest("DeleteScalingConfiguration", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteScalingConfigurationResponse> DeleteScalingConfigurationWithOptionsAsync(DeleteScalingConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteScalingConfigurationResponse>(await DoRPCRequestAsync("DeleteScalingConfiguration", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteScalingConfigurationResponse DeleteScalingConfiguration(DeleteScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScalingConfigurationWithOptions(request, runtime);
        }

        public async Task<DeleteScalingConfigurationResponse> DeleteScalingConfigurationAsync(DeleteScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScalingConfigurationWithOptionsAsync(request, runtime);
        }

        public DeleteScalingGroupResponse DeleteScalingGroupWithOptions(DeleteScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteScalingGroupResponse>(DoRPCRequest("DeleteScalingGroup", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteScalingGroupResponse> DeleteScalingGroupWithOptionsAsync(DeleteScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteScalingGroupResponse>(await DoRPCRequestAsync("DeleteScalingGroup", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteScalingGroupResponse DeleteScalingGroup(DeleteScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScalingGroupWithOptions(request, runtime);
        }

        public async Task<DeleteScalingGroupResponse> DeleteScalingGroupAsync(DeleteScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScalingGroupWithOptionsAsync(request, runtime);
        }

        public DeleteScalingRuleResponse DeleteScalingRuleWithOptions(DeleteScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteScalingRuleResponse>(DoRPCRequest("DeleteScalingRule", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteScalingRuleResponse> DeleteScalingRuleWithOptionsAsync(DeleteScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteScalingRuleResponse>(await DoRPCRequestAsync("DeleteScalingRule", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteScalingRuleResponse DeleteScalingRule(DeleteScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScalingRuleWithOptions(request, runtime);
        }

        public async Task<DeleteScalingRuleResponse> DeleteScalingRuleAsync(DeleteScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScalingRuleWithOptionsAsync(request, runtime);
        }

        public DeleteScheduledTaskResponse DeleteScheduledTaskWithOptions(DeleteScheduledTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteScheduledTaskResponse>(DoRPCRequest("DeleteScheduledTask", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteScheduledTaskResponse> DeleteScheduledTaskWithOptionsAsync(DeleteScheduledTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteScheduledTaskResponse>(await DoRPCRequestAsync("DeleteScheduledTask", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteScheduledTaskResponse DeleteScheduledTask(DeleteScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScheduledTaskWithOptions(request, runtime);
        }

        public async Task<DeleteScheduledTaskResponse> DeleteScheduledTaskAsync(DeleteScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScheduledTaskWithOptionsAsync(request, runtime);
        }

        public DescribeAlarmsResponse DescribeAlarmsWithOptions(DescribeAlarmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAlarmsResponse>(DoRPCRequest("DescribeAlarms", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAlarmsResponse> DescribeAlarmsWithOptionsAsync(DescribeAlarmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAlarmsResponse>(await DoRPCRequestAsync("DescribeAlarms", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAlarmsResponse DescribeAlarms(DescribeAlarmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlarmsWithOptions(request, runtime);
        }

        public async Task<DescribeAlarmsResponse> DescribeAlarmsAsync(DescribeAlarmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlarmsWithOptionsAsync(request, runtime);
        }

        public DescribeLifecycleActionsResponse DescribeLifecycleActionsWithOptions(DescribeLifecycleActionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLifecycleActionsResponse>(DoRPCRequest("DescribeLifecycleActions", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLifecycleActionsResponse> DescribeLifecycleActionsWithOptionsAsync(DescribeLifecycleActionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLifecycleActionsResponse>(await DoRPCRequestAsync("DescribeLifecycleActions", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLifecycleActionsResponse DescribeLifecycleActions(DescribeLifecycleActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLifecycleActionsWithOptions(request, runtime);
        }

        public async Task<DescribeLifecycleActionsResponse> DescribeLifecycleActionsAsync(DescribeLifecycleActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLifecycleActionsWithOptionsAsync(request, runtime);
        }

        public DescribeLifecycleHooksResponse DescribeLifecycleHooksWithOptions(DescribeLifecycleHooksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLifecycleHooksResponse>(DoRPCRequest("DescribeLifecycleHooks", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLifecycleHooksResponse> DescribeLifecycleHooksWithOptionsAsync(DescribeLifecycleHooksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLifecycleHooksResponse>(await DoRPCRequestAsync("DescribeLifecycleHooks", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLifecycleHooksResponse DescribeLifecycleHooks(DescribeLifecycleHooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLifecycleHooksWithOptions(request, runtime);
        }

        public async Task<DescribeLifecycleHooksResponse> DescribeLifecycleHooksAsync(DescribeLifecycleHooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLifecycleHooksWithOptionsAsync(request, runtime);
        }

        public DescribeLimitationResponse DescribeLimitationWithOptions(DescribeLimitationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLimitationResponse>(DoRPCRequest("DescribeLimitation", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLimitationResponse> DescribeLimitationWithOptionsAsync(DescribeLimitationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLimitationResponse>(await DoRPCRequestAsync("DescribeLimitation", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLimitationResponse DescribeLimitation(DescribeLimitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLimitationWithOptions(request, runtime);
        }

        public async Task<DescribeLimitationResponse> DescribeLimitationAsync(DescribeLimitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLimitationWithOptionsAsync(request, runtime);
        }

        public DescribeNotificationConfigurationsResponse DescribeNotificationConfigurationsWithOptions(DescribeNotificationConfigurationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNotificationConfigurationsResponse>(DoRPCRequest("DescribeNotificationConfigurations", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeNotificationConfigurationsResponse> DescribeNotificationConfigurationsWithOptionsAsync(DescribeNotificationConfigurationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNotificationConfigurationsResponse>(await DoRPCRequestAsync("DescribeNotificationConfigurations", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNotificationConfigurationsWithOptions(request, runtime);
        }

        public async Task<DescribeNotificationConfigurationsResponse> DescribeNotificationConfigurationsAsync(DescribeNotificationConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNotificationConfigurationsWithOptionsAsync(request, runtime);
        }

        public DescribeNotificationTypesResponse DescribeNotificationTypesWithOptions(DescribeNotificationTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNotificationTypesResponse>(DoRPCRequest("DescribeNotificationTypes", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeNotificationTypesResponse> DescribeNotificationTypesWithOptionsAsync(DescribeNotificationTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNotificationTypesResponse>(await DoRPCRequestAsync("DescribeNotificationTypes", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeNotificationTypesResponse DescribeNotificationTypes(DescribeNotificationTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNotificationTypesWithOptions(request, runtime);
        }

        public async Task<DescribeNotificationTypesResponse> DescribeNotificationTypesAsync(DescribeNotificationTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNotificationTypesWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeScalingActivitiesResponse DescribeScalingActivitiesWithOptions(DescribeScalingActivitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingActivitiesResponse>(DoRPCRequest("DescribeScalingActivities", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesWithOptionsAsync(DescribeScalingActivitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingActivitiesResponse>(await DoRPCRequestAsync("DescribeScalingActivities", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScalingActivitiesResponse DescribeScalingActivities(DescribeScalingActivitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingActivitiesWithOptions(request, runtime);
        }

        public async Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesAsync(DescribeScalingActivitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingActivitiesWithOptionsAsync(request, runtime);
        }

        public DescribeScalingActivityDetailResponse DescribeScalingActivityDetailWithOptions(DescribeScalingActivityDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingActivityDetailResponse>(DoRPCRequest("DescribeScalingActivityDetail", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScalingActivityDetailResponse> DescribeScalingActivityDetailWithOptionsAsync(DescribeScalingActivityDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingActivityDetailResponse>(await DoRPCRequestAsync("DescribeScalingActivityDetail", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScalingActivityDetailResponse DescribeScalingActivityDetail(DescribeScalingActivityDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingActivityDetailWithOptions(request, runtime);
        }

        public async Task<DescribeScalingActivityDetailResponse> DescribeScalingActivityDetailAsync(DescribeScalingActivityDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingActivityDetailWithOptionsAsync(request, runtime);
        }

        public DescribeScalingConfigurationsResponse DescribeScalingConfigurationsWithOptions(DescribeScalingConfigurationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingConfigurationsResponse>(DoRPCRequest("DescribeScalingConfigurations", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScalingConfigurationsResponse> DescribeScalingConfigurationsWithOptionsAsync(DescribeScalingConfigurationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingConfigurationsResponse>(await DoRPCRequestAsync("DescribeScalingConfigurations", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScalingConfigurationsResponse DescribeScalingConfigurations(DescribeScalingConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingConfigurationsWithOptions(request, runtime);
        }

        public async Task<DescribeScalingConfigurationsResponse> DescribeScalingConfigurationsAsync(DescribeScalingConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingConfigurationsWithOptionsAsync(request, runtime);
        }

        public DescribeScalingInstancesResponse DescribeScalingInstancesWithOptions(DescribeScalingInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingInstancesResponse>(DoRPCRequest("DescribeScalingInstances", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScalingInstancesResponse> DescribeScalingInstancesWithOptionsAsync(DescribeScalingInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingInstancesResponse>(await DoRPCRequestAsync("DescribeScalingInstances", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScalingInstancesResponse DescribeScalingInstances(DescribeScalingInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeScalingInstancesResponse> DescribeScalingInstancesAsync(DescribeScalingInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeScalingRulesResponse DescribeScalingRulesWithOptions(DescribeScalingRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingRulesResponse>(DoRPCRequest("DescribeScalingRules", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScalingRulesResponse> DescribeScalingRulesWithOptionsAsync(DescribeScalingRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingRulesResponse>(await DoRPCRequestAsync("DescribeScalingRules", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScalingRulesResponse DescribeScalingRules(DescribeScalingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingRulesWithOptions(request, runtime);
        }

        public async Task<DescribeScalingRulesResponse> DescribeScalingRulesAsync(DescribeScalingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingRulesWithOptionsAsync(request, runtime);
        }

        public DescribeScheduledTasksResponse DescribeScheduledTasksWithOptions(DescribeScheduledTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScheduledTasksResponse>(DoRPCRequest("DescribeScheduledTasks", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScheduledTasksResponse> DescribeScheduledTasksWithOptionsAsync(DescribeScheduledTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScheduledTasksResponse>(await DoRPCRequestAsync("DescribeScheduledTasks", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScheduledTasksResponse DescribeScheduledTasks(DescribeScheduledTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScheduledTasksWithOptions(request, runtime);
        }

        public async Task<DescribeScheduledTasksResponse> DescribeScheduledTasksAsync(DescribeScheduledTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScheduledTasksWithOptionsAsync(request, runtime);
        }

        public DetachAlbServerGroupsResponse DetachAlbServerGroupsWithOptions(DetachAlbServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachAlbServerGroupsResponse>(DoRPCRequest("DetachAlbServerGroups", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachAlbServerGroupsResponse> DetachAlbServerGroupsWithOptionsAsync(DetachAlbServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachAlbServerGroupsResponse>(await DoRPCRequestAsync("DetachAlbServerGroups", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachAlbServerGroupsResponse DetachAlbServerGroups(DetachAlbServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachAlbServerGroupsWithOptions(request, runtime);
        }

        public async Task<DetachAlbServerGroupsResponse> DetachAlbServerGroupsAsync(DetachAlbServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachAlbServerGroupsWithOptionsAsync(request, runtime);
        }

        public DetachDBInstancesResponse DetachDBInstancesWithOptions(DetachDBInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachDBInstancesResponse>(DoRPCRequest("DetachDBInstances", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachDBInstancesResponse> DetachDBInstancesWithOptionsAsync(DetachDBInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachDBInstancesResponse>(await DoRPCRequestAsync("DetachDBInstances", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachDBInstancesResponse DetachDBInstances(DetachDBInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachDBInstancesWithOptions(request, runtime);
        }

        public async Task<DetachDBInstancesResponse> DetachDBInstancesAsync(DetachDBInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachDBInstancesWithOptionsAsync(request, runtime);
        }

        public DetachInstancesResponse DetachInstancesWithOptions(DetachInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachInstancesResponse>(DoRPCRequest("DetachInstances", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachInstancesResponse> DetachInstancesWithOptionsAsync(DetachInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachInstancesResponse>(await DoRPCRequestAsync("DetachInstances", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachInstancesResponse DetachInstances(DetachInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachInstancesWithOptions(request, runtime);
        }

        public async Task<DetachInstancesResponse> DetachInstancesAsync(DetachInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachInstancesWithOptionsAsync(request, runtime);
        }

        public DetachLoadBalancersResponse DetachLoadBalancersWithOptions(DetachLoadBalancersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachLoadBalancersResponse>(DoRPCRequest("DetachLoadBalancers", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachLoadBalancersResponse> DetachLoadBalancersWithOptionsAsync(DetachLoadBalancersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachLoadBalancersResponse>(await DoRPCRequestAsync("DetachLoadBalancers", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachLoadBalancersResponse DetachLoadBalancers(DetachLoadBalancersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachLoadBalancersWithOptions(request, runtime);
        }

        public async Task<DetachLoadBalancersResponse> DetachLoadBalancersAsync(DetachLoadBalancersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachLoadBalancersWithOptionsAsync(request, runtime);
        }

        public DetachVServerGroupsResponse DetachVServerGroupsWithOptions(DetachVServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachVServerGroupsResponse>(DoRPCRequest("DetachVServerGroups", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachVServerGroupsResponse> DetachVServerGroupsWithOptionsAsync(DetachVServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachVServerGroupsResponse>(await DoRPCRequestAsync("DetachVServerGroups", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachVServerGroupsResponse DetachVServerGroups(DetachVServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachVServerGroupsWithOptions(request, runtime);
        }

        public async Task<DetachVServerGroupsResponse> DetachVServerGroupsAsync(DetachVServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachVServerGroupsWithOptionsAsync(request, runtime);
        }

        public DisableAlarmResponse DisableAlarmWithOptions(DisableAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableAlarmResponse>(DoRPCRequest("DisableAlarm", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableAlarmResponse> DisableAlarmWithOptionsAsync(DisableAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableAlarmResponse>(await DoRPCRequestAsync("DisableAlarm", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableAlarmResponse DisableAlarm(DisableAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableAlarmWithOptions(request, runtime);
        }

        public async Task<DisableAlarmResponse> DisableAlarmAsync(DisableAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableAlarmWithOptionsAsync(request, runtime);
        }

        public DisableScalingGroupResponse DisableScalingGroupWithOptions(DisableScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableScalingGroupResponse>(DoRPCRequest("DisableScalingGroup", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableScalingGroupResponse> DisableScalingGroupWithOptionsAsync(DisableScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableScalingGroupResponse>(await DoRPCRequestAsync("DisableScalingGroup", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableScalingGroupResponse DisableScalingGroup(DisableScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableScalingGroupWithOptions(request, runtime);
        }

        public async Task<DisableScalingGroupResponse> DisableScalingGroupAsync(DisableScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableScalingGroupWithOptionsAsync(request, runtime);
        }

        public EnableAlarmResponse EnableAlarmWithOptions(EnableAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableAlarmResponse>(DoRPCRequest("EnableAlarm", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableAlarmResponse> EnableAlarmWithOptionsAsync(EnableAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableAlarmResponse>(await DoRPCRequestAsync("EnableAlarm", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableAlarmResponse EnableAlarm(EnableAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableAlarmWithOptions(request, runtime);
        }

        public async Task<EnableAlarmResponse> EnableAlarmAsync(EnableAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableAlarmWithOptionsAsync(request, runtime);
        }

        public EnableScalingGroupResponse EnableScalingGroupWithOptions(EnableScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableScalingGroupResponse>(DoRPCRequest("EnableScalingGroup", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableScalingGroupResponse> EnableScalingGroupWithOptionsAsync(EnableScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableScalingGroupResponse>(await DoRPCRequestAsync("EnableScalingGroup", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableScalingGroupResponse EnableScalingGroup(EnableScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableScalingGroupWithOptions(request, runtime);
        }

        public async Task<EnableScalingGroupResponse> EnableScalingGroupAsync(EnableScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableScalingGroupWithOptionsAsync(request, runtime);
        }

        public EnterStandbyResponse EnterStandbyWithOptions(EnterStandbyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnterStandbyResponse>(DoRPCRequest("EnterStandby", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnterStandbyResponse> EnterStandbyWithOptionsAsync(EnterStandbyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnterStandbyResponse>(await DoRPCRequestAsync("EnterStandby", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnterStandbyResponse EnterStandby(EnterStandbyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterStandbyWithOptions(request, runtime);
        }

        public async Task<EnterStandbyResponse> EnterStandbyAsync(EnterStandbyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterStandbyWithOptionsAsync(request, runtime);
        }

        public ExecuteScalingRuleResponse ExecuteScalingRuleWithOptions(ExecuteScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecuteScalingRuleResponse>(DoRPCRequest("ExecuteScalingRule", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExecuteScalingRuleResponse> ExecuteScalingRuleWithOptionsAsync(ExecuteScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecuteScalingRuleResponse>(await DoRPCRequestAsync("ExecuteScalingRule", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExecuteScalingRuleResponse ExecuteScalingRule(ExecuteScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteScalingRuleWithOptions(request, runtime);
        }

        public async Task<ExecuteScalingRuleResponse> ExecuteScalingRuleAsync(ExecuteScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteScalingRuleWithOptionsAsync(request, runtime);
        }

        public ExitStandbyResponse ExitStandbyWithOptions(ExitStandbyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExitStandbyResponse>(DoRPCRequest("ExitStandby", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExitStandbyResponse> ExitStandbyWithOptionsAsync(ExitStandbyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExitStandbyResponse>(await DoRPCRequestAsync("ExitStandby", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExitStandbyResponse ExitStandby(ExitStandbyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExitStandbyWithOptions(request, runtime);
        }

        public async Task<ExitStandbyResponse> ExitStandbyAsync(ExitStandbyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExitStandbyWithOptionsAsync(request, runtime);
        }

        public ListTagKeysResponse ListTagKeysWithOptions(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagKeysResponse>(DoRPCRequest("ListTagKeys", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagKeysResponse> ListTagKeysWithOptionsAsync(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagKeysResponse>(await DoRPCRequestAsync("ListTagKeys", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTagKeysResponse ListTagKeys(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagKeysWithOptions(request, runtime);
        }

        public async Task<ListTagKeysResponse> ListTagKeysAsync(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagKeysWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRPCRequest("ListTagResources", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRPCRequestAsync("ListTagResources", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListTagValuesResponse ListTagValuesWithOptions(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagValuesResponse>(DoRPCRequest("ListTagValues", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagValuesResponse> ListTagValuesWithOptionsAsync(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagValuesResponse>(await DoRPCRequestAsync("ListTagValues", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTagValuesResponse ListTagValues(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagValuesWithOptions(request, runtime);
        }

        public async Task<ListTagValuesResponse> ListTagValuesAsync(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagValuesWithOptionsAsync(request, runtime);
        }

        public ModifyAlarmResponse ModifyAlarmWithOptions(ModifyAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAlarmResponse>(DoRPCRequest("ModifyAlarm", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAlarmResponse> ModifyAlarmWithOptionsAsync(ModifyAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAlarmResponse>(await DoRPCRequestAsync("ModifyAlarm", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyAlarmResponse ModifyAlarm(ModifyAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAlarmWithOptions(request, runtime);
        }

        public async Task<ModifyAlarmResponse> ModifyAlarmAsync(ModifyAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAlarmWithOptionsAsync(request, runtime);
        }

        public ModifyLifecycleHookResponse ModifyLifecycleHookWithOptions(ModifyLifecycleHookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLifecycleHookResponse>(DoRPCRequest("ModifyLifecycleHook", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyLifecycleHookResponse> ModifyLifecycleHookWithOptionsAsync(ModifyLifecycleHookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLifecycleHookResponse>(await DoRPCRequestAsync("ModifyLifecycleHook", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyLifecycleHookResponse ModifyLifecycleHook(ModifyLifecycleHookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLifecycleHookWithOptions(request, runtime);
        }

        public async Task<ModifyLifecycleHookResponse> ModifyLifecycleHookAsync(ModifyLifecycleHookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLifecycleHookWithOptionsAsync(request, runtime);
        }

        public ModifyNotificationConfigurationResponse ModifyNotificationConfigurationWithOptions(ModifyNotificationConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyNotificationConfigurationResponse>(DoRPCRequest("ModifyNotificationConfiguration", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyNotificationConfigurationResponse> ModifyNotificationConfigurationWithOptionsAsync(ModifyNotificationConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyNotificationConfigurationResponse>(await DoRPCRequestAsync("ModifyNotificationConfiguration", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyNotificationConfigurationResponse ModifyNotificationConfiguration(ModifyNotificationConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNotificationConfigurationWithOptions(request, runtime);
        }

        public async Task<ModifyNotificationConfigurationResponse> ModifyNotificationConfigurationAsync(ModifyNotificationConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNotificationConfigurationWithOptionsAsync(request, runtime);
        }

        public ModifyScalingConfigurationResponse ModifyScalingConfigurationWithOptions(ModifyScalingConfigurationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyScalingConfigurationShrinkRequest request = new ModifyScalingConfigurationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SchedulerOptions))
            {
                request.SchedulerOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SchedulerOptions, "SchedulerOptions", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScalingConfigurationResponse>(DoRPCRequest("ModifyScalingConfiguration", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyScalingConfigurationResponse> ModifyScalingConfigurationWithOptionsAsync(ModifyScalingConfigurationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyScalingConfigurationShrinkRequest request = new ModifyScalingConfigurationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SchedulerOptions))
            {
                request.SchedulerOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SchedulerOptions, "SchedulerOptions", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScalingConfigurationResponse>(await DoRPCRequestAsync("ModifyScalingConfiguration", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyScalingConfigurationResponse ModifyScalingConfiguration(ModifyScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScalingConfigurationWithOptions(request, runtime);
        }

        public async Task<ModifyScalingConfigurationResponse> ModifyScalingConfigurationAsync(ModifyScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScalingConfigurationWithOptionsAsync(request, runtime);
        }

        public ModifyScalingGroupResponse ModifyScalingGroupWithOptions(ModifyScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScalingGroupResponse>(DoRPCRequest("ModifyScalingGroup", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyScalingGroupResponse> ModifyScalingGroupWithOptionsAsync(ModifyScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScalingGroupResponse>(await DoRPCRequestAsync("ModifyScalingGroup", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyScalingGroupResponse ModifyScalingGroup(ModifyScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScalingGroupWithOptions(request, runtime);
        }

        public async Task<ModifyScalingGroupResponse> ModifyScalingGroupAsync(ModifyScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScalingGroupWithOptionsAsync(request, runtime);
        }

        public ModifyScalingRuleResponse ModifyScalingRuleWithOptions(ModifyScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScalingRuleResponse>(DoRPCRequest("ModifyScalingRule", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyScalingRuleResponse> ModifyScalingRuleWithOptionsAsync(ModifyScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScalingRuleResponse>(await DoRPCRequestAsync("ModifyScalingRule", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyScalingRuleResponse ModifyScalingRule(ModifyScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScalingRuleWithOptions(request, runtime);
        }

        public async Task<ModifyScalingRuleResponse> ModifyScalingRuleAsync(ModifyScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScalingRuleWithOptionsAsync(request, runtime);
        }

        public ModifyScheduledTaskResponse ModifyScheduledTaskWithOptions(ModifyScheduledTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScheduledTaskResponse>(DoRPCRequest("ModifyScheduledTask", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyScheduledTaskResponse> ModifyScheduledTaskWithOptionsAsync(ModifyScheduledTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScheduledTaskResponse>(await DoRPCRequestAsync("ModifyScheduledTask", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyScheduledTaskResponse ModifyScheduledTask(ModifyScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScheduledTaskWithOptions(request, runtime);
        }

        public async Task<ModifyScheduledTaskResponse> ModifyScheduledTaskAsync(ModifyScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScheduledTaskWithOptionsAsync(request, runtime);
        }

        public RebalanceInstancesResponse RebalanceInstancesWithOptions(RebalanceInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RebalanceInstancesResponse>(DoRPCRequest("RebalanceInstances", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RebalanceInstancesResponse> RebalanceInstancesWithOptionsAsync(RebalanceInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RebalanceInstancesResponse>(await DoRPCRequestAsync("RebalanceInstances", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RebalanceInstancesResponse RebalanceInstances(RebalanceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RebalanceInstancesWithOptions(request, runtime);
        }

        public async Task<RebalanceInstancesResponse> RebalanceInstancesAsync(RebalanceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RebalanceInstancesWithOptionsAsync(request, runtime);
        }

        public RecordLifecycleActionHeartbeatResponse RecordLifecycleActionHeartbeatWithOptions(RecordLifecycleActionHeartbeatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecordLifecycleActionHeartbeatResponse>(DoRPCRequest("RecordLifecycleActionHeartbeat", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RecordLifecycleActionHeartbeatResponse> RecordLifecycleActionHeartbeatWithOptionsAsync(RecordLifecycleActionHeartbeatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecordLifecycleActionHeartbeatResponse>(await DoRPCRequestAsync("RecordLifecycleActionHeartbeat", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RecordLifecycleActionHeartbeatResponse RecordLifecycleActionHeartbeat(RecordLifecycleActionHeartbeatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecordLifecycleActionHeartbeatWithOptions(request, runtime);
        }

        public async Task<RecordLifecycleActionHeartbeatResponse> RecordLifecycleActionHeartbeatAsync(RecordLifecycleActionHeartbeatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecordLifecycleActionHeartbeatWithOptionsAsync(request, runtime);
        }

        public RemoveInstancesResponse RemoveInstancesWithOptions(RemoveInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveInstancesResponse>(DoRPCRequest("RemoveInstances", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveInstancesResponse> RemoveInstancesWithOptionsAsync(RemoveInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveInstancesResponse>(await DoRPCRequestAsync("RemoveInstances", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveInstancesResponse RemoveInstances(RemoveInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveInstancesWithOptions(request, runtime);
        }

        public async Task<RemoveInstancesResponse> RemoveInstancesAsync(RemoveInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveInstancesWithOptionsAsync(request, runtime);
        }

        public ResumeProcessesResponse ResumeProcessesWithOptions(ResumeProcessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResumeProcessesResponse>(DoRPCRequest("ResumeProcesses", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResumeProcessesResponse> ResumeProcessesWithOptionsAsync(ResumeProcessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResumeProcessesResponse>(await DoRPCRequestAsync("ResumeProcesses", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResumeProcessesResponse ResumeProcesses(ResumeProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeProcessesWithOptions(request, runtime);
        }

        public async Task<ResumeProcessesResponse> ResumeProcessesAsync(ResumeProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeProcessesWithOptionsAsync(request, runtime);
        }

        public ScaleWithAdjustmentResponse ScaleWithAdjustmentWithOptions(ScaleWithAdjustmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ScaleWithAdjustmentResponse>(DoRPCRequest("ScaleWithAdjustment", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ScaleWithAdjustmentResponse> ScaleWithAdjustmentWithOptionsAsync(ScaleWithAdjustmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ScaleWithAdjustmentResponse>(await DoRPCRequestAsync("ScaleWithAdjustment", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ScaleWithAdjustmentResponse ScaleWithAdjustment(ScaleWithAdjustmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ScaleWithAdjustmentWithOptions(request, runtime);
        }

        public async Task<ScaleWithAdjustmentResponse> ScaleWithAdjustmentAsync(ScaleWithAdjustmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ScaleWithAdjustmentWithOptionsAsync(request, runtime);
        }

        public SetGroupDeletionProtectionResponse SetGroupDeletionProtectionWithOptions(SetGroupDeletionProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetGroupDeletionProtectionResponse>(DoRPCRequest("SetGroupDeletionProtection", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetGroupDeletionProtectionResponse> SetGroupDeletionProtectionWithOptionsAsync(SetGroupDeletionProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetGroupDeletionProtectionResponse>(await DoRPCRequestAsync("SetGroupDeletionProtection", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetGroupDeletionProtectionResponse SetGroupDeletionProtection(SetGroupDeletionProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetGroupDeletionProtectionWithOptions(request, runtime);
        }

        public async Task<SetGroupDeletionProtectionResponse> SetGroupDeletionProtectionAsync(SetGroupDeletionProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetGroupDeletionProtectionWithOptionsAsync(request, runtime);
        }

        public SetInstanceHealthResponse SetInstanceHealthWithOptions(SetInstanceHealthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetInstanceHealthResponse>(DoRPCRequest("SetInstanceHealth", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetInstanceHealthResponse> SetInstanceHealthWithOptionsAsync(SetInstanceHealthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetInstanceHealthResponse>(await DoRPCRequestAsync("SetInstanceHealth", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetInstanceHealthResponse SetInstanceHealth(SetInstanceHealthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetInstanceHealthWithOptions(request, runtime);
        }

        public async Task<SetInstanceHealthResponse> SetInstanceHealthAsync(SetInstanceHealthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetInstanceHealthWithOptionsAsync(request, runtime);
        }

        public SetInstancesProtectionResponse SetInstancesProtectionWithOptions(SetInstancesProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetInstancesProtectionResponse>(DoRPCRequest("SetInstancesProtection", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetInstancesProtectionResponse> SetInstancesProtectionWithOptionsAsync(SetInstancesProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetInstancesProtectionResponse>(await DoRPCRequestAsync("SetInstancesProtection", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetInstancesProtectionResponse SetInstancesProtection(SetInstancesProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetInstancesProtectionWithOptions(request, runtime);
        }

        public async Task<SetInstancesProtectionResponse> SetInstancesProtectionAsync(SetInstancesProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetInstancesProtectionWithOptionsAsync(request, runtime);
        }

        public SuspendProcessesResponse SuspendProcessesWithOptions(SuspendProcessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendProcessesResponse>(DoRPCRequest("SuspendProcesses", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SuspendProcessesResponse> SuspendProcessesWithOptionsAsync(SuspendProcessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendProcessesResponse>(await DoRPCRequestAsync("SuspendProcesses", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SuspendProcessesResponse SuspendProcesses(SuspendProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendProcessesWithOptions(request, runtime);
        }

        public async Task<SuspendProcessesResponse> SuspendProcessesAsync(SuspendProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendProcessesWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(DoRPCRequest("UntagResources", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRPCRequestAsync("UntagResources", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public VerifyAuthenticationResponse VerifyAuthenticationWithOptions(VerifyAuthenticationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyAuthenticationResponse>(DoRPCRequest("VerifyAuthentication", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<VerifyAuthenticationResponse> VerifyAuthenticationWithOptionsAsync(VerifyAuthenticationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyAuthenticationResponse>(await DoRPCRequestAsync("VerifyAuthentication", "2014-08-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public VerifyAuthenticationResponse VerifyAuthentication(VerifyAuthenticationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyAuthenticationWithOptions(request, runtime);
        }

        public async Task<VerifyAuthenticationResponse> VerifyAuthenticationAsync(VerifyAuthenticationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyAuthenticationWithOptionsAsync(request, runtime);
        }

        public VerifyUserResponse VerifyUserWithOptions(VerifyUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyUserResponse>(DoRPCRequest("VerifyUser", "2014-08-28", "HTTPS", "POST", "AK", "none", req, runtime));
        }

        public async Task<VerifyUserResponse> VerifyUserWithOptionsAsync(VerifyUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyUserResponse>(await DoRPCRequestAsync("VerifyUser", "2014-08-28", "HTTPS", "POST", "AK", "none", req, runtime));
        }

        public VerifyUserResponse VerifyUser(VerifyUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyUserWithOptions(request, runtime);
        }

        public async Task<VerifyUserResponse> VerifyUserAsync(VerifyUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyUserWithOptionsAsync(request, runtime);
        }

    }
}
