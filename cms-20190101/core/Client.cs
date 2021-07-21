// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cms20190101.Models;

namespace AlibabaCloud.SDK.Cms20190101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cms", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddTagsResponse AddTagsWithOptions(AddTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddTagsResponse>(DoRPCRequest("AddTags", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddTagsResponse> AddTagsWithOptionsAsync(AddTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddTagsResponse>(await DoRPCRequestAsync("AddTags", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddTagsResponse AddTags(AddTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTagsWithOptions(request, runtime);
        }

        public async Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTagsWithOptionsAsync(request, runtime);
        }

        public ApplyMetricRuleTemplateResponse ApplyMetricRuleTemplateWithOptions(ApplyMetricRuleTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApplyMetricRuleTemplateResponse>(DoRPCRequest("ApplyMetricRuleTemplate", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ApplyMetricRuleTemplateResponse> ApplyMetricRuleTemplateWithOptionsAsync(ApplyMetricRuleTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApplyMetricRuleTemplateResponse>(await DoRPCRequestAsync("ApplyMetricRuleTemplate", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ApplyMetricRuleTemplateResponse ApplyMetricRuleTemplate(ApplyMetricRuleTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyMetricRuleTemplateWithOptions(request, runtime);
        }

        public async Task<ApplyMetricRuleTemplateResponse> ApplyMetricRuleTemplateAsync(ApplyMetricRuleTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyMetricRuleTemplateWithOptionsAsync(request, runtime);
        }

        public CreateCmsCallNumOrderResponse CreateCmsCallNumOrderWithOptions(CreateCmsCallNumOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCmsCallNumOrderResponse>(DoRPCRequest("CreateCmsCallNumOrder", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCmsCallNumOrderResponse> CreateCmsCallNumOrderWithOptionsAsync(CreateCmsCallNumOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCmsCallNumOrderResponse>(await DoRPCRequestAsync("CreateCmsCallNumOrder", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCmsCallNumOrderResponse CreateCmsCallNumOrder(CreateCmsCallNumOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCmsCallNumOrderWithOptions(request, runtime);
        }

        public async Task<CreateCmsCallNumOrderResponse> CreateCmsCallNumOrderAsync(CreateCmsCallNumOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCmsCallNumOrderWithOptionsAsync(request, runtime);
        }

        public CreateCmsOrderResponse CreateCmsOrderWithOptions(CreateCmsOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCmsOrderResponse>(DoRPCRequest("CreateCmsOrder", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCmsOrderResponse> CreateCmsOrderWithOptionsAsync(CreateCmsOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCmsOrderResponse>(await DoRPCRequestAsync("CreateCmsOrder", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCmsOrderResponse CreateCmsOrder(CreateCmsOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCmsOrderWithOptions(request, runtime);
        }

        public async Task<CreateCmsOrderResponse> CreateCmsOrderAsync(CreateCmsOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCmsOrderWithOptionsAsync(request, runtime);
        }

        public CreateCmsSmspackageOrderResponse CreateCmsSmspackageOrderWithOptions(CreateCmsSmspackageOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCmsSmspackageOrderResponse>(DoRPCRequest("CreateCmsSmspackageOrder", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCmsSmspackageOrderResponse> CreateCmsSmspackageOrderWithOptionsAsync(CreateCmsSmspackageOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCmsSmspackageOrderResponse>(await DoRPCRequestAsync("CreateCmsSmspackageOrder", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCmsSmspackageOrderResponse CreateCmsSmspackageOrder(CreateCmsSmspackageOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCmsSmspackageOrderWithOptions(request, runtime);
        }

        public async Task<CreateCmsSmspackageOrderResponse> CreateCmsSmspackageOrderAsync(CreateCmsSmspackageOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCmsSmspackageOrderWithOptionsAsync(request, runtime);
        }

        public CreateDynamicTagGroupResponse CreateDynamicTagGroupWithOptions(CreateDynamicTagGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDynamicTagGroupResponse>(DoRPCRequest("CreateDynamicTagGroup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDynamicTagGroupResponse> CreateDynamicTagGroupWithOptionsAsync(CreateDynamicTagGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDynamicTagGroupResponse>(await DoRPCRequestAsync("CreateDynamicTagGroup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDynamicTagGroupResponse CreateDynamicTagGroup(CreateDynamicTagGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDynamicTagGroupWithOptions(request, runtime);
        }

        public async Task<CreateDynamicTagGroupResponse> CreateDynamicTagGroupAsync(CreateDynamicTagGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDynamicTagGroupWithOptionsAsync(request, runtime);
        }

        public CreateGroupMetricRulesResponse CreateGroupMetricRulesWithOptions(CreateGroupMetricRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGroupMetricRulesResponse>(DoRPCRequest("CreateGroupMetricRules", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateGroupMetricRulesResponse> CreateGroupMetricRulesWithOptionsAsync(CreateGroupMetricRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGroupMetricRulesResponse>(await DoRPCRequestAsync("CreateGroupMetricRules", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateGroupMetricRulesResponse CreateGroupMetricRules(CreateGroupMetricRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGroupMetricRulesWithOptions(request, runtime);
        }

        public async Task<CreateGroupMetricRulesResponse> CreateGroupMetricRulesAsync(CreateGroupMetricRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGroupMetricRulesWithOptionsAsync(request, runtime);
        }

        public CreateGroupMonitoringAgentProcessResponse CreateGroupMonitoringAgentProcessWithOptions(CreateGroupMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGroupMonitoringAgentProcessResponse>(DoRPCRequest("CreateGroupMonitoringAgentProcess", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateGroupMonitoringAgentProcessResponse> CreateGroupMonitoringAgentProcessWithOptionsAsync(CreateGroupMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGroupMonitoringAgentProcessResponse>(await DoRPCRequestAsync("CreateGroupMonitoringAgentProcess", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateGroupMonitoringAgentProcessResponse CreateGroupMonitoringAgentProcess(CreateGroupMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGroupMonitoringAgentProcessWithOptions(request, runtime);
        }

        public async Task<CreateGroupMonitoringAgentProcessResponse> CreateGroupMonitoringAgentProcessAsync(CreateGroupMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGroupMonitoringAgentProcessWithOptionsAsync(request, runtime);
        }

        public CreateHostAvailabilityResponse CreateHostAvailabilityWithOptions(CreateHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHostAvailabilityResponse>(DoRPCRequest("CreateHostAvailability", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateHostAvailabilityResponse> CreateHostAvailabilityWithOptionsAsync(CreateHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHostAvailabilityResponse>(await DoRPCRequestAsync("CreateHostAvailability", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateHostAvailabilityResponse CreateHostAvailability(CreateHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHostAvailabilityWithOptions(request, runtime);
        }

        public async Task<CreateHostAvailabilityResponse> CreateHostAvailabilityAsync(CreateHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHostAvailabilityWithOptionsAsync(request, runtime);
        }

        public CreateMetricRuleResourcesResponse CreateMetricRuleResourcesWithOptions(CreateMetricRuleResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMetricRuleResourcesResponse>(DoRPCRequest("CreateMetricRuleResources", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMetricRuleResourcesResponse> CreateMetricRuleResourcesWithOptionsAsync(CreateMetricRuleResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMetricRuleResourcesResponse>(await DoRPCRequestAsync("CreateMetricRuleResources", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMetricRuleResourcesResponse CreateMetricRuleResources(CreateMetricRuleResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMetricRuleResourcesWithOptions(request, runtime);
        }

        public async Task<CreateMetricRuleResourcesResponse> CreateMetricRuleResourcesAsync(CreateMetricRuleResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMetricRuleResourcesWithOptionsAsync(request, runtime);
        }

        public CreateMetricRuleTemplateResponse CreateMetricRuleTemplateWithOptions(CreateMetricRuleTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMetricRuleTemplateResponse>(DoRPCRequest("CreateMetricRuleTemplate", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMetricRuleTemplateResponse> CreateMetricRuleTemplateWithOptionsAsync(CreateMetricRuleTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMetricRuleTemplateResponse>(await DoRPCRequestAsync("CreateMetricRuleTemplate", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMetricRuleTemplateResponse CreateMetricRuleTemplate(CreateMetricRuleTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMetricRuleTemplateWithOptions(request, runtime);
        }

        public async Task<CreateMetricRuleTemplateResponse> CreateMetricRuleTemplateAsync(CreateMetricRuleTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMetricRuleTemplateWithOptionsAsync(request, runtime);
        }

        public CreateMonitorAgentProcessResponse CreateMonitorAgentProcessWithOptions(CreateMonitorAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMonitorAgentProcessResponse>(DoRPCRequest("CreateMonitorAgentProcess", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMonitorAgentProcessResponse> CreateMonitorAgentProcessWithOptionsAsync(CreateMonitorAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMonitorAgentProcessResponse>(await DoRPCRequestAsync("CreateMonitorAgentProcess", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMonitorAgentProcessResponse CreateMonitorAgentProcess(CreateMonitorAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMonitorAgentProcessWithOptions(request, runtime);
        }

        public async Task<CreateMonitorAgentProcessResponse> CreateMonitorAgentProcessAsync(CreateMonitorAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMonitorAgentProcessWithOptionsAsync(request, runtime);
        }

        public CreateMonitorGroupResponse CreateMonitorGroupWithOptions(CreateMonitorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMonitorGroupResponse>(DoRPCRequest("CreateMonitorGroup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMonitorGroupResponse> CreateMonitorGroupWithOptionsAsync(CreateMonitorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMonitorGroupResponse>(await DoRPCRequestAsync("CreateMonitorGroup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMonitorGroupResponse CreateMonitorGroup(CreateMonitorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMonitorGroupWithOptions(request, runtime);
        }

        public async Task<CreateMonitorGroupResponse> CreateMonitorGroupAsync(CreateMonitorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMonitorGroupWithOptionsAsync(request, runtime);
        }

        public CreateMonitorGroupByResourceGroupIdResponse CreateMonitorGroupByResourceGroupIdWithOptions(CreateMonitorGroupByResourceGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMonitorGroupByResourceGroupIdResponse>(DoRPCRequest("CreateMonitorGroupByResourceGroupId", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMonitorGroupByResourceGroupIdResponse> CreateMonitorGroupByResourceGroupIdWithOptionsAsync(CreateMonitorGroupByResourceGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMonitorGroupByResourceGroupIdResponse>(await DoRPCRequestAsync("CreateMonitorGroupByResourceGroupId", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMonitorGroupByResourceGroupIdResponse CreateMonitorGroupByResourceGroupId(CreateMonitorGroupByResourceGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMonitorGroupByResourceGroupIdWithOptions(request, runtime);
        }

        public async Task<CreateMonitorGroupByResourceGroupIdResponse> CreateMonitorGroupByResourceGroupIdAsync(CreateMonitorGroupByResourceGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMonitorGroupByResourceGroupIdWithOptionsAsync(request, runtime);
        }

        public CreateMonitorGroupInstancesResponse CreateMonitorGroupInstancesWithOptions(CreateMonitorGroupInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMonitorGroupInstancesResponse>(DoRPCRequest("CreateMonitorGroupInstances", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMonitorGroupInstancesResponse> CreateMonitorGroupInstancesWithOptionsAsync(CreateMonitorGroupInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMonitorGroupInstancesResponse>(await DoRPCRequestAsync("CreateMonitorGroupInstances", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMonitorGroupInstancesResponse CreateMonitorGroupInstances(CreateMonitorGroupInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMonitorGroupInstancesWithOptions(request, runtime);
        }

        public async Task<CreateMonitorGroupInstancesResponse> CreateMonitorGroupInstancesAsync(CreateMonitorGroupInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMonitorGroupInstancesWithOptionsAsync(request, runtime);
        }

        public CreateMonitorGroupNotifyPolicyResponse CreateMonitorGroupNotifyPolicyWithOptions(CreateMonitorGroupNotifyPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMonitorGroupNotifyPolicyResponse>(DoRPCRequest("CreateMonitorGroupNotifyPolicy", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMonitorGroupNotifyPolicyResponse> CreateMonitorGroupNotifyPolicyWithOptionsAsync(CreateMonitorGroupNotifyPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMonitorGroupNotifyPolicyResponse>(await DoRPCRequestAsync("CreateMonitorGroupNotifyPolicy", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMonitorGroupNotifyPolicyResponse CreateMonitorGroupNotifyPolicy(CreateMonitorGroupNotifyPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMonitorGroupNotifyPolicyWithOptions(request, runtime);
        }

        public async Task<CreateMonitorGroupNotifyPolicyResponse> CreateMonitorGroupNotifyPolicyAsync(CreateMonitorGroupNotifyPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMonitorGroupNotifyPolicyWithOptionsAsync(request, runtime);
        }

        public CreateMonitoringAgentProcessResponse CreateMonitoringAgentProcessWithOptions(CreateMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMonitoringAgentProcessResponse>(DoRPCRequest("CreateMonitoringAgentProcess", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMonitoringAgentProcessResponse> CreateMonitoringAgentProcessWithOptionsAsync(CreateMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMonitoringAgentProcessResponse>(await DoRPCRequestAsync("CreateMonitoringAgentProcess", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMonitoringAgentProcessResponse CreateMonitoringAgentProcess(CreateMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMonitoringAgentProcessWithOptions(request, runtime);
        }

        public async Task<CreateMonitoringAgentProcessResponse> CreateMonitoringAgentProcessAsync(CreateMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMonitoringAgentProcessWithOptionsAsync(request, runtime);
        }

        public CreateSiteMonitorResponse CreateSiteMonitorWithOptions(CreateSiteMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSiteMonitorResponse>(DoRPCRequest("CreateSiteMonitor", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSiteMonitorResponse> CreateSiteMonitorWithOptionsAsync(CreateSiteMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSiteMonitorResponse>(await DoRPCRequestAsync("CreateSiteMonitor", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSiteMonitorResponse CreateSiteMonitor(CreateSiteMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSiteMonitorWithOptions(request, runtime);
        }

        public async Task<CreateSiteMonitorResponse> CreateSiteMonitorAsync(CreateSiteMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSiteMonitorWithOptionsAsync(request, runtime);
        }

        public DeleteContactResponse DeleteContactWithOptions(DeleteContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteContactResponse>(DoRPCRequest("DeleteContact", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteContactResponse> DeleteContactWithOptionsAsync(DeleteContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteContactResponse>(await DoRPCRequestAsync("DeleteContact", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteContactResponse DeleteContact(DeleteContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteContactWithOptions(request, runtime);
        }

        public async Task<DeleteContactResponse> DeleteContactAsync(DeleteContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteContactWithOptionsAsync(request, runtime);
        }

        public DeleteContactGroupResponse DeleteContactGroupWithOptions(DeleteContactGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteContactGroupResponse>(DoRPCRequest("DeleteContactGroup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteContactGroupResponse> DeleteContactGroupWithOptionsAsync(DeleteContactGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteContactGroupResponse>(await DoRPCRequestAsync("DeleteContactGroup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteContactGroupResponse DeleteContactGroup(DeleteContactGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteContactGroupWithOptions(request, runtime);
        }

        public async Task<DeleteContactGroupResponse> DeleteContactGroupAsync(DeleteContactGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteContactGroupWithOptionsAsync(request, runtime);
        }

        public DeleteCustomMetricResponse DeleteCustomMetricWithOptions(DeleteCustomMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCustomMetricResponse>(DoRPCRequest("DeleteCustomMetric", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCustomMetricResponse> DeleteCustomMetricWithOptionsAsync(DeleteCustomMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCustomMetricResponse>(await DoRPCRequestAsync("DeleteCustomMetric", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCustomMetricResponse DeleteCustomMetric(DeleteCustomMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomMetricWithOptions(request, runtime);
        }

        public async Task<DeleteCustomMetricResponse> DeleteCustomMetricAsync(DeleteCustomMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomMetricWithOptionsAsync(request, runtime);
        }

        public DeleteDynamicTagGroupResponse DeleteDynamicTagGroupWithOptions(DeleteDynamicTagGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDynamicTagGroupResponse>(DoRPCRequest("DeleteDynamicTagGroup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDynamicTagGroupResponse> DeleteDynamicTagGroupWithOptionsAsync(DeleteDynamicTagGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDynamicTagGroupResponse>(await DoRPCRequestAsync("DeleteDynamicTagGroup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDynamicTagGroupResponse DeleteDynamicTagGroup(DeleteDynamicTagGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDynamicTagGroupWithOptions(request, runtime);
        }

        public async Task<DeleteDynamicTagGroupResponse> DeleteDynamicTagGroupAsync(DeleteDynamicTagGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDynamicTagGroupWithOptionsAsync(request, runtime);
        }

        public DeleteEventRulesResponse DeleteEventRulesWithOptions(DeleteEventRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEventRulesResponse>(DoRPCRequest("DeleteEventRules", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteEventRulesResponse> DeleteEventRulesWithOptionsAsync(DeleteEventRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEventRulesResponse>(await DoRPCRequestAsync("DeleteEventRules", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteEventRulesResponse DeleteEventRules(DeleteEventRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEventRulesWithOptions(request, runtime);
        }

        public async Task<DeleteEventRulesResponse> DeleteEventRulesAsync(DeleteEventRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEventRulesWithOptionsAsync(request, runtime);
        }

        public DeleteEventRuleTargetsResponse DeleteEventRuleTargetsWithOptions(DeleteEventRuleTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEventRuleTargetsResponse>(DoRPCRequest("DeleteEventRuleTargets", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteEventRuleTargetsResponse> DeleteEventRuleTargetsWithOptionsAsync(DeleteEventRuleTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEventRuleTargetsResponse>(await DoRPCRequestAsync("DeleteEventRuleTargets", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteEventRuleTargetsResponse DeleteEventRuleTargets(DeleteEventRuleTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEventRuleTargetsWithOptions(request, runtime);
        }

        public async Task<DeleteEventRuleTargetsResponse> DeleteEventRuleTargetsAsync(DeleteEventRuleTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEventRuleTargetsWithOptionsAsync(request, runtime);
        }

        public DeleteExporterOutputResponse DeleteExporterOutputWithOptions(DeleteExporterOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteExporterOutputResponse>(DoRPCRequest("DeleteExporterOutput", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteExporterOutputResponse> DeleteExporterOutputWithOptionsAsync(DeleteExporterOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteExporterOutputResponse>(await DoRPCRequestAsync("DeleteExporterOutput", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteExporterOutputResponse DeleteExporterOutput(DeleteExporterOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteExporterOutputWithOptions(request, runtime);
        }

        public async Task<DeleteExporterOutputResponse> DeleteExporterOutputAsync(DeleteExporterOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteExporterOutputWithOptionsAsync(request, runtime);
        }

        public DeleteExporterRuleResponse DeleteExporterRuleWithOptions(DeleteExporterRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteExporterRuleResponse>(DoRPCRequest("DeleteExporterRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteExporterRuleResponse> DeleteExporterRuleWithOptionsAsync(DeleteExporterRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteExporterRuleResponse>(await DoRPCRequestAsync("DeleteExporterRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteExporterRuleResponse DeleteExporterRule(DeleteExporterRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteExporterRuleWithOptions(request, runtime);
        }

        public async Task<DeleteExporterRuleResponse> DeleteExporterRuleAsync(DeleteExporterRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteExporterRuleWithOptionsAsync(request, runtime);
        }

        public DeleteGroupMonitoringAgentProcessResponse DeleteGroupMonitoringAgentProcessWithOptions(DeleteGroupMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteGroupMonitoringAgentProcessResponse>(DoRPCRequest("DeleteGroupMonitoringAgentProcess", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteGroupMonitoringAgentProcessResponse> DeleteGroupMonitoringAgentProcessWithOptionsAsync(DeleteGroupMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteGroupMonitoringAgentProcessResponse>(await DoRPCRequestAsync("DeleteGroupMonitoringAgentProcess", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteGroupMonitoringAgentProcessResponse DeleteGroupMonitoringAgentProcess(DeleteGroupMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGroupMonitoringAgentProcessWithOptions(request, runtime);
        }

        public async Task<DeleteGroupMonitoringAgentProcessResponse> DeleteGroupMonitoringAgentProcessAsync(DeleteGroupMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGroupMonitoringAgentProcessWithOptionsAsync(request, runtime);
        }

        public DeleteHostAvailabilityResponse DeleteHostAvailabilityWithOptions(DeleteHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHostAvailabilityResponse>(DoRPCRequest("DeleteHostAvailability", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteHostAvailabilityResponse> DeleteHostAvailabilityWithOptionsAsync(DeleteHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHostAvailabilityResponse>(await DoRPCRequestAsync("DeleteHostAvailability", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteHostAvailabilityResponse DeleteHostAvailability(DeleteHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHostAvailabilityWithOptions(request, runtime);
        }

        public async Task<DeleteHostAvailabilityResponse> DeleteHostAvailabilityAsync(DeleteHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHostAvailabilityWithOptionsAsync(request, runtime);
        }

        public DeleteLogMonitorResponse DeleteLogMonitorWithOptions(DeleteLogMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLogMonitorResponse>(DoRPCRequest("DeleteLogMonitor", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLogMonitorResponse> DeleteLogMonitorWithOptionsAsync(DeleteLogMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLogMonitorResponse>(await DoRPCRequestAsync("DeleteLogMonitor", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLogMonitorResponse DeleteLogMonitor(DeleteLogMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLogMonitorWithOptions(request, runtime);
        }

        public async Task<DeleteLogMonitorResponse> DeleteLogMonitorAsync(DeleteLogMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLogMonitorWithOptionsAsync(request, runtime);
        }

        public DeleteMetricRuleResourcesResponse DeleteMetricRuleResourcesWithOptions(DeleteMetricRuleResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMetricRuleResourcesResponse>(DoRPCRequest("DeleteMetricRuleResources", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMetricRuleResourcesResponse> DeleteMetricRuleResourcesWithOptionsAsync(DeleteMetricRuleResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMetricRuleResourcesResponse>(await DoRPCRequestAsync("DeleteMetricRuleResources", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMetricRuleResourcesResponse DeleteMetricRuleResources(DeleteMetricRuleResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMetricRuleResourcesWithOptions(request, runtime);
        }

        public async Task<DeleteMetricRuleResourcesResponse> DeleteMetricRuleResourcesAsync(DeleteMetricRuleResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMetricRuleResourcesWithOptionsAsync(request, runtime);
        }

        public DeleteMetricRulesResponse DeleteMetricRulesWithOptions(DeleteMetricRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMetricRulesResponse>(DoRPCRequest("DeleteMetricRules", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMetricRulesResponse> DeleteMetricRulesWithOptionsAsync(DeleteMetricRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMetricRulesResponse>(await DoRPCRequestAsync("DeleteMetricRules", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMetricRulesResponse DeleteMetricRules(DeleteMetricRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMetricRulesWithOptions(request, runtime);
        }

        public async Task<DeleteMetricRulesResponse> DeleteMetricRulesAsync(DeleteMetricRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMetricRulesWithOptionsAsync(request, runtime);
        }

        public DeleteMetricRuleTargetsResponse DeleteMetricRuleTargetsWithOptions(DeleteMetricRuleTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMetricRuleTargetsResponse>(DoRPCRequest("DeleteMetricRuleTargets", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMetricRuleTargetsResponse> DeleteMetricRuleTargetsWithOptionsAsync(DeleteMetricRuleTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMetricRuleTargetsResponse>(await DoRPCRequestAsync("DeleteMetricRuleTargets", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMetricRuleTargetsResponse DeleteMetricRuleTargets(DeleteMetricRuleTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMetricRuleTargetsWithOptions(request, runtime);
        }

        public async Task<DeleteMetricRuleTargetsResponse> DeleteMetricRuleTargetsAsync(DeleteMetricRuleTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMetricRuleTargetsWithOptionsAsync(request, runtime);
        }

        public DeleteMetricRuleTemplateResponse DeleteMetricRuleTemplateWithOptions(DeleteMetricRuleTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMetricRuleTemplateResponse>(DoRPCRequest("DeleteMetricRuleTemplate", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMetricRuleTemplateResponse> DeleteMetricRuleTemplateWithOptionsAsync(DeleteMetricRuleTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMetricRuleTemplateResponse>(await DoRPCRequestAsync("DeleteMetricRuleTemplate", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMetricRuleTemplateResponse DeleteMetricRuleTemplate(DeleteMetricRuleTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMetricRuleTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteMetricRuleTemplateResponse> DeleteMetricRuleTemplateAsync(DeleteMetricRuleTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMetricRuleTemplateWithOptionsAsync(request, runtime);
        }

        public DeleteMonitorGroupResponse DeleteMonitorGroupWithOptions(DeleteMonitorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMonitorGroupResponse>(DoRPCRequest("DeleteMonitorGroup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMonitorGroupResponse> DeleteMonitorGroupWithOptionsAsync(DeleteMonitorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMonitorGroupResponse>(await DoRPCRequestAsync("DeleteMonitorGroup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMonitorGroupResponse DeleteMonitorGroup(DeleteMonitorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMonitorGroupWithOptions(request, runtime);
        }

        public async Task<DeleteMonitorGroupResponse> DeleteMonitorGroupAsync(DeleteMonitorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMonitorGroupWithOptionsAsync(request, runtime);
        }

        public DeleteMonitorGroupDynamicRuleResponse DeleteMonitorGroupDynamicRuleWithOptions(DeleteMonitorGroupDynamicRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMonitorGroupDynamicRuleResponse>(DoRPCRequest("DeleteMonitorGroupDynamicRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMonitorGroupDynamicRuleResponse> DeleteMonitorGroupDynamicRuleWithOptionsAsync(DeleteMonitorGroupDynamicRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMonitorGroupDynamicRuleResponse>(await DoRPCRequestAsync("DeleteMonitorGroupDynamicRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMonitorGroupDynamicRuleResponse DeleteMonitorGroupDynamicRule(DeleteMonitorGroupDynamicRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMonitorGroupDynamicRuleWithOptions(request, runtime);
        }

        public async Task<DeleteMonitorGroupDynamicRuleResponse> DeleteMonitorGroupDynamicRuleAsync(DeleteMonitorGroupDynamicRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMonitorGroupDynamicRuleWithOptionsAsync(request, runtime);
        }

        public DeleteMonitorGroupInstancesResponse DeleteMonitorGroupInstancesWithOptions(DeleteMonitorGroupInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMonitorGroupInstancesResponse>(DoRPCRequest("DeleteMonitorGroupInstances", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMonitorGroupInstancesResponse> DeleteMonitorGroupInstancesWithOptionsAsync(DeleteMonitorGroupInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMonitorGroupInstancesResponse>(await DoRPCRequestAsync("DeleteMonitorGroupInstances", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMonitorGroupInstancesResponse DeleteMonitorGroupInstances(DeleteMonitorGroupInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMonitorGroupInstancesWithOptions(request, runtime);
        }

        public async Task<DeleteMonitorGroupInstancesResponse> DeleteMonitorGroupInstancesAsync(DeleteMonitorGroupInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMonitorGroupInstancesWithOptionsAsync(request, runtime);
        }

        public DeleteMonitorGroupNotifyPolicyResponse DeleteMonitorGroupNotifyPolicyWithOptions(DeleteMonitorGroupNotifyPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMonitorGroupNotifyPolicyResponse>(DoRPCRequest("DeleteMonitorGroupNotifyPolicy", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMonitorGroupNotifyPolicyResponse> DeleteMonitorGroupNotifyPolicyWithOptionsAsync(DeleteMonitorGroupNotifyPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMonitorGroupNotifyPolicyResponse>(await DoRPCRequestAsync("DeleteMonitorGroupNotifyPolicy", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMonitorGroupNotifyPolicyResponse DeleteMonitorGroupNotifyPolicy(DeleteMonitorGroupNotifyPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMonitorGroupNotifyPolicyWithOptions(request, runtime);
        }

        public async Task<DeleteMonitorGroupNotifyPolicyResponse> DeleteMonitorGroupNotifyPolicyAsync(DeleteMonitorGroupNotifyPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMonitorGroupNotifyPolicyWithOptionsAsync(request, runtime);
        }

        public DeleteMonitoringAgentProcessResponse DeleteMonitoringAgentProcessWithOptions(DeleteMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMonitoringAgentProcessResponse>(DoRPCRequest("DeleteMonitoringAgentProcess", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMonitoringAgentProcessResponse> DeleteMonitoringAgentProcessWithOptionsAsync(DeleteMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMonitoringAgentProcessResponse>(await DoRPCRequestAsync("DeleteMonitoringAgentProcess", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMonitoringAgentProcessResponse DeleteMonitoringAgentProcess(DeleteMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMonitoringAgentProcessWithOptions(request, runtime);
        }

        public async Task<DeleteMonitoringAgentProcessResponse> DeleteMonitoringAgentProcessAsync(DeleteMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMonitoringAgentProcessWithOptionsAsync(request, runtime);
        }

        public DeleteSiteMonitorsResponse DeleteSiteMonitorsWithOptions(DeleteSiteMonitorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSiteMonitorsResponse>(DoRPCRequest("DeleteSiteMonitors", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSiteMonitorsResponse> DeleteSiteMonitorsWithOptionsAsync(DeleteSiteMonitorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSiteMonitorsResponse>(await DoRPCRequestAsync("DeleteSiteMonitors", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSiteMonitorsResponse DeleteSiteMonitors(DeleteSiteMonitorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSiteMonitorsWithOptions(request, runtime);
        }

        public async Task<DeleteSiteMonitorsResponse> DeleteSiteMonitorsAsync(DeleteSiteMonitorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSiteMonitorsWithOptionsAsync(request, runtime);
        }

        public DescribeActiveMetricRuleListResponse DescribeActiveMetricRuleListWithOptions(DescribeActiveMetricRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeActiveMetricRuleListResponse>(DoRPCRequest("DescribeActiveMetricRuleList", "2019-01-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeActiveMetricRuleListResponse> DescribeActiveMetricRuleListWithOptionsAsync(DescribeActiveMetricRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeActiveMetricRuleListResponse>(await DoRPCRequestAsync("DescribeActiveMetricRuleList", "2019-01-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeActiveMetricRuleListResponse DescribeActiveMetricRuleList(DescribeActiveMetricRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeActiveMetricRuleListWithOptions(request, runtime);
        }

        public async Task<DescribeActiveMetricRuleListResponse> DescribeActiveMetricRuleListAsync(DescribeActiveMetricRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeActiveMetricRuleListWithOptionsAsync(request, runtime);
        }

        public DescribeAlertHistoryListResponse DescribeAlertHistoryListWithOptions(DescribeAlertHistoryListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAlertHistoryListResponse>(DoRPCRequest("DescribeAlertHistoryList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAlertHistoryListResponse> DescribeAlertHistoryListWithOptionsAsync(DescribeAlertHistoryListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAlertHistoryListResponse>(await DoRPCRequestAsync("DescribeAlertHistoryList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAlertHistoryListResponse DescribeAlertHistoryList(DescribeAlertHistoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertHistoryListWithOptions(request, runtime);
        }

        public async Task<DescribeAlertHistoryListResponse> DescribeAlertHistoryListAsync(DescribeAlertHistoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertHistoryListWithOptionsAsync(request, runtime);
        }

        public DescribeAlertingMetricRuleResourcesResponse DescribeAlertingMetricRuleResourcesWithOptions(DescribeAlertingMetricRuleResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeAlertingMetricRuleResourcesResponse>(DoRPCRequest("DescribeAlertingMetricRuleResources", "2019-01-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeAlertingMetricRuleResourcesResponse> DescribeAlertingMetricRuleResourcesWithOptionsAsync(DescribeAlertingMetricRuleResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeAlertingMetricRuleResourcesResponse>(await DoRPCRequestAsync("DescribeAlertingMetricRuleResources", "2019-01-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeAlertingMetricRuleResourcesResponse DescribeAlertingMetricRuleResources(DescribeAlertingMetricRuleResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertingMetricRuleResourcesWithOptions(request, runtime);
        }

        public async Task<DescribeAlertingMetricRuleResourcesResponse> DescribeAlertingMetricRuleResourcesAsync(DescribeAlertingMetricRuleResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertingMetricRuleResourcesWithOptionsAsync(request, runtime);
        }

        public DescribeAlertLogCountResponse DescribeAlertLogCountWithOptions(DescribeAlertLogCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAlertLogCountResponse>(DoRPCRequest("DescribeAlertLogCount", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAlertLogCountResponse> DescribeAlertLogCountWithOptionsAsync(DescribeAlertLogCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAlertLogCountResponse>(await DoRPCRequestAsync("DescribeAlertLogCount", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAlertLogCountResponse DescribeAlertLogCount(DescribeAlertLogCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertLogCountWithOptions(request, runtime);
        }

        public async Task<DescribeAlertLogCountResponse> DescribeAlertLogCountAsync(DescribeAlertLogCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertLogCountWithOptionsAsync(request, runtime);
        }

        public DescribeAlertLogHistogramResponse DescribeAlertLogHistogramWithOptions(DescribeAlertLogHistogramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAlertLogHistogramResponse>(DoRPCRequest("DescribeAlertLogHistogram", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAlertLogHistogramResponse> DescribeAlertLogHistogramWithOptionsAsync(DescribeAlertLogHistogramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAlertLogHistogramResponse>(await DoRPCRequestAsync("DescribeAlertLogHistogram", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAlertLogHistogramResponse DescribeAlertLogHistogram(DescribeAlertLogHistogramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertLogHistogramWithOptions(request, runtime);
        }

        public async Task<DescribeAlertLogHistogramResponse> DescribeAlertLogHistogramAsync(DescribeAlertLogHistogramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertLogHistogramWithOptionsAsync(request, runtime);
        }

        public DescribeAlertLogListResponse DescribeAlertLogListWithOptions(DescribeAlertLogListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAlertLogListResponse>(DoRPCRequest("DescribeAlertLogList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAlertLogListResponse> DescribeAlertLogListWithOptionsAsync(DescribeAlertLogListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAlertLogListResponse>(await DoRPCRequestAsync("DescribeAlertLogList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAlertLogListResponse DescribeAlertLogList(DescribeAlertLogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertLogListWithOptions(request, runtime);
        }

        public async Task<DescribeAlertLogListResponse> DescribeAlertLogListAsync(DescribeAlertLogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertLogListWithOptionsAsync(request, runtime);
        }

        public DescribeContactGroupListResponse DescribeContactGroupListWithOptions(DescribeContactGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeContactGroupListResponse>(DoRPCRequest("DescribeContactGroupList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeContactGroupListResponse> DescribeContactGroupListWithOptionsAsync(DescribeContactGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeContactGroupListResponse>(await DoRPCRequestAsync("DescribeContactGroupList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeContactGroupListResponse DescribeContactGroupList(DescribeContactGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContactGroupListWithOptions(request, runtime);
        }

        public async Task<DescribeContactGroupListResponse> DescribeContactGroupListAsync(DescribeContactGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContactGroupListWithOptionsAsync(request, runtime);
        }

        public DescribeContactListResponse DescribeContactListWithOptions(DescribeContactListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeContactListResponse>(DoRPCRequest("DescribeContactList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeContactListResponse> DescribeContactListWithOptionsAsync(DescribeContactListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeContactListResponse>(await DoRPCRequestAsync("DescribeContactList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeContactListResponse DescribeContactList(DescribeContactListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContactListWithOptions(request, runtime);
        }

        public async Task<DescribeContactListResponse> DescribeContactListAsync(DescribeContactListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContactListWithOptionsAsync(request, runtime);
        }

        public DescribeContactListByContactGroupResponse DescribeContactListByContactGroupWithOptions(DescribeContactListByContactGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeContactListByContactGroupResponse>(DoRPCRequest("DescribeContactListByContactGroup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeContactListByContactGroupResponse> DescribeContactListByContactGroupWithOptionsAsync(DescribeContactListByContactGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeContactListByContactGroupResponse>(await DoRPCRequestAsync("DescribeContactListByContactGroup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeContactListByContactGroupResponse DescribeContactListByContactGroup(DescribeContactListByContactGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContactListByContactGroupWithOptions(request, runtime);
        }

        public async Task<DescribeContactListByContactGroupResponse> DescribeContactListByContactGroupAsync(DescribeContactListByContactGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContactListByContactGroupWithOptionsAsync(request, runtime);
        }

        public DescribeCustomEventAttributeResponse DescribeCustomEventAttributeWithOptions(DescribeCustomEventAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCustomEventAttributeResponse>(DoRPCRequest("DescribeCustomEventAttribute", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCustomEventAttributeResponse> DescribeCustomEventAttributeWithOptionsAsync(DescribeCustomEventAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCustomEventAttributeResponse>(await DoRPCRequestAsync("DescribeCustomEventAttribute", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCustomEventAttributeResponse DescribeCustomEventAttribute(DescribeCustomEventAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomEventAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeCustomEventAttributeResponse> DescribeCustomEventAttributeAsync(DescribeCustomEventAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomEventAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeCustomEventCountResponse DescribeCustomEventCountWithOptions(DescribeCustomEventCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCustomEventCountResponse>(DoRPCRequest("DescribeCustomEventCount", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCustomEventCountResponse> DescribeCustomEventCountWithOptionsAsync(DescribeCustomEventCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCustomEventCountResponse>(await DoRPCRequestAsync("DescribeCustomEventCount", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCustomEventCountResponse DescribeCustomEventCount(DescribeCustomEventCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomEventCountWithOptions(request, runtime);
        }

        public async Task<DescribeCustomEventCountResponse> DescribeCustomEventCountAsync(DescribeCustomEventCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomEventCountWithOptionsAsync(request, runtime);
        }

        public DescribeCustomEventHistogramResponse DescribeCustomEventHistogramWithOptions(DescribeCustomEventHistogramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCustomEventHistogramResponse>(DoRPCRequest("DescribeCustomEventHistogram", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCustomEventHistogramResponse> DescribeCustomEventHistogramWithOptionsAsync(DescribeCustomEventHistogramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCustomEventHistogramResponse>(await DoRPCRequestAsync("DescribeCustomEventHistogram", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCustomEventHistogramResponse DescribeCustomEventHistogram(DescribeCustomEventHistogramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomEventHistogramWithOptions(request, runtime);
        }

        public async Task<DescribeCustomEventHistogramResponse> DescribeCustomEventHistogramAsync(DescribeCustomEventHistogramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomEventHistogramWithOptionsAsync(request, runtime);
        }

        public DescribeCustomMetricListResponse DescribeCustomMetricListWithOptions(DescribeCustomMetricListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCustomMetricListResponse>(DoRPCRequest("DescribeCustomMetricList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCustomMetricListResponse> DescribeCustomMetricListWithOptionsAsync(DescribeCustomMetricListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCustomMetricListResponse>(await DoRPCRequestAsync("DescribeCustomMetricList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCustomMetricListResponse DescribeCustomMetricList(DescribeCustomMetricListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomMetricListWithOptions(request, runtime);
        }

        public async Task<DescribeCustomMetricListResponse> DescribeCustomMetricListAsync(DescribeCustomMetricListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomMetricListWithOptionsAsync(request, runtime);
        }

        public DescribeDynamicTagRuleListResponse DescribeDynamicTagRuleListWithOptions(DescribeDynamicTagRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDynamicTagRuleListResponse>(DoRPCRequest("DescribeDynamicTagRuleList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDynamicTagRuleListResponse> DescribeDynamicTagRuleListWithOptionsAsync(DescribeDynamicTagRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDynamicTagRuleListResponse>(await DoRPCRequestAsync("DescribeDynamicTagRuleList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDynamicTagRuleListResponse DescribeDynamicTagRuleList(DescribeDynamicTagRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDynamicTagRuleListWithOptions(request, runtime);
        }

        public async Task<DescribeDynamicTagRuleListResponse> DescribeDynamicTagRuleListAsync(DescribeDynamicTagRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDynamicTagRuleListWithOptionsAsync(request, runtime);
        }

        public DescribeEventRuleAttributeResponse DescribeEventRuleAttributeWithOptions(DescribeEventRuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEventRuleAttributeResponse>(DoRPCRequest("DescribeEventRuleAttribute", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEventRuleAttributeResponse> DescribeEventRuleAttributeWithOptionsAsync(DescribeEventRuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEventRuleAttributeResponse>(await DoRPCRequestAsync("DescribeEventRuleAttribute", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEventRuleAttributeResponse DescribeEventRuleAttribute(DescribeEventRuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEventRuleAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeEventRuleAttributeResponse> DescribeEventRuleAttributeAsync(DescribeEventRuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEventRuleAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeEventRuleListResponse DescribeEventRuleListWithOptions(DescribeEventRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEventRuleListResponse>(DoRPCRequest("DescribeEventRuleList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEventRuleListResponse> DescribeEventRuleListWithOptionsAsync(DescribeEventRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEventRuleListResponse>(await DoRPCRequestAsync("DescribeEventRuleList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEventRuleListResponse DescribeEventRuleList(DescribeEventRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEventRuleListWithOptions(request, runtime);
        }

        public async Task<DescribeEventRuleListResponse> DescribeEventRuleListAsync(DescribeEventRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEventRuleListWithOptionsAsync(request, runtime);
        }

        public DescribeEventRuleTargetListResponse DescribeEventRuleTargetListWithOptions(DescribeEventRuleTargetListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEventRuleTargetListResponse>(DoRPCRequest("DescribeEventRuleTargetList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEventRuleTargetListResponse> DescribeEventRuleTargetListWithOptionsAsync(DescribeEventRuleTargetListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEventRuleTargetListResponse>(await DoRPCRequestAsync("DescribeEventRuleTargetList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEventRuleTargetListResponse DescribeEventRuleTargetList(DescribeEventRuleTargetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEventRuleTargetListWithOptions(request, runtime);
        }

        public async Task<DescribeEventRuleTargetListResponse> DescribeEventRuleTargetListAsync(DescribeEventRuleTargetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEventRuleTargetListWithOptionsAsync(request, runtime);
        }

        public DescribeExporterOutputListResponse DescribeExporterOutputListWithOptions(DescribeExporterOutputListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExporterOutputListResponse>(DoRPCRequest("DescribeExporterOutputList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeExporterOutputListResponse> DescribeExporterOutputListWithOptionsAsync(DescribeExporterOutputListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExporterOutputListResponse>(await DoRPCRequestAsync("DescribeExporterOutputList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeExporterOutputListResponse DescribeExporterOutputList(DescribeExporterOutputListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExporterOutputListWithOptions(request, runtime);
        }

        public async Task<DescribeExporterOutputListResponse> DescribeExporterOutputListAsync(DescribeExporterOutputListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExporterOutputListWithOptionsAsync(request, runtime);
        }

        public DescribeExporterRuleListResponse DescribeExporterRuleListWithOptions(DescribeExporterRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExporterRuleListResponse>(DoRPCRequest("DescribeExporterRuleList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeExporterRuleListResponse> DescribeExporterRuleListWithOptionsAsync(DescribeExporterRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExporterRuleListResponse>(await DoRPCRequestAsync("DescribeExporterRuleList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeExporterRuleListResponse DescribeExporterRuleList(DescribeExporterRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExporterRuleListWithOptions(request, runtime);
        }

        public async Task<DescribeExporterRuleListResponse> DescribeExporterRuleListAsync(DescribeExporterRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExporterRuleListWithOptionsAsync(request, runtime);
        }

        public DescribeGroupMonitoringAgentProcessResponse DescribeGroupMonitoringAgentProcessWithOptions(DescribeGroupMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupMonitoringAgentProcessResponse>(DoRPCRequest("DescribeGroupMonitoringAgentProcess", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGroupMonitoringAgentProcessResponse> DescribeGroupMonitoringAgentProcessWithOptionsAsync(DescribeGroupMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupMonitoringAgentProcessResponse>(await DoRPCRequestAsync("DescribeGroupMonitoringAgentProcess", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGroupMonitoringAgentProcessResponse DescribeGroupMonitoringAgentProcess(DescribeGroupMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGroupMonitoringAgentProcessWithOptions(request, runtime);
        }

        public async Task<DescribeGroupMonitoringAgentProcessResponse> DescribeGroupMonitoringAgentProcessAsync(DescribeGroupMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGroupMonitoringAgentProcessWithOptionsAsync(request, runtime);
        }

        public DescribeHostAvailabilityListResponse DescribeHostAvailabilityListWithOptions(DescribeHostAvailabilityListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHostAvailabilityListResponse>(DoRPCRequest("DescribeHostAvailabilityList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHostAvailabilityListResponse> DescribeHostAvailabilityListWithOptionsAsync(DescribeHostAvailabilityListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHostAvailabilityListResponse>(await DoRPCRequestAsync("DescribeHostAvailabilityList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHostAvailabilityListResponse DescribeHostAvailabilityList(DescribeHostAvailabilityListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHostAvailabilityListWithOptions(request, runtime);
        }

        public async Task<DescribeHostAvailabilityListResponse> DescribeHostAvailabilityListAsync(DescribeHostAvailabilityListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHostAvailabilityListWithOptionsAsync(request, runtime);
        }

        public DescribeLogMonitorAttributeResponse DescribeLogMonitorAttributeWithOptions(DescribeLogMonitorAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeLogMonitorAttributeResponse>(DoRPCRequest("DescribeLogMonitorAttribute", "2019-01-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeLogMonitorAttributeResponse> DescribeLogMonitorAttributeWithOptionsAsync(DescribeLogMonitorAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeLogMonitorAttributeResponse>(await DoRPCRequestAsync("DescribeLogMonitorAttribute", "2019-01-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeLogMonitorAttributeResponse DescribeLogMonitorAttribute(DescribeLogMonitorAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLogMonitorAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeLogMonitorAttributeResponse> DescribeLogMonitorAttributeAsync(DescribeLogMonitorAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLogMonitorAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeLogMonitorListResponse DescribeLogMonitorListWithOptions(DescribeLogMonitorListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLogMonitorListResponse>(DoRPCRequest("DescribeLogMonitorList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLogMonitorListResponse> DescribeLogMonitorListWithOptionsAsync(DescribeLogMonitorListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLogMonitorListResponse>(await DoRPCRequestAsync("DescribeLogMonitorList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLogMonitorListResponse DescribeLogMonitorList(DescribeLogMonitorListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLogMonitorListWithOptions(request, runtime);
        }

        public async Task<DescribeLogMonitorListResponse> DescribeLogMonitorListAsync(DescribeLogMonitorListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLogMonitorListWithOptionsAsync(request, runtime);
        }

        public DescribeMetricDataResponse DescribeMetricDataWithOptions(DescribeMetricDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetricDataResponse>(DoRPCRequest("DescribeMetricData", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMetricDataResponse> DescribeMetricDataWithOptionsAsync(DescribeMetricDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetricDataResponse>(await DoRPCRequestAsync("DescribeMetricData", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMetricDataResponse DescribeMetricData(DescribeMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricDataWithOptions(request, runtime);
        }

        public async Task<DescribeMetricDataResponse> DescribeMetricDataAsync(DescribeMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricDataWithOptionsAsync(request, runtime);
        }

        public DescribeMetricLastResponse DescribeMetricLastWithOptions(DescribeMetricLastRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetricLastResponse>(DoRPCRequest("DescribeMetricLast", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMetricLastResponse> DescribeMetricLastWithOptionsAsync(DescribeMetricLastRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetricLastResponse>(await DoRPCRequestAsync("DescribeMetricLast", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMetricLastResponse DescribeMetricLast(DescribeMetricLastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricLastWithOptions(request, runtime);
        }

        public async Task<DescribeMetricLastResponse> DescribeMetricLastAsync(DescribeMetricLastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricLastWithOptionsAsync(request, runtime);
        }

        public DescribeMetricListResponse DescribeMetricListWithOptions(DescribeMetricListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetricListResponse>(DoRPCRequest("DescribeMetricList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMetricListResponse> DescribeMetricListWithOptionsAsync(DescribeMetricListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetricListResponse>(await DoRPCRequestAsync("DescribeMetricList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeMetricMetaListResponse DescribeMetricMetaListWithOptions(DescribeMetricMetaListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetricMetaListResponse>(DoRPCRequest("DescribeMetricMetaList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMetricMetaListResponse> DescribeMetricMetaListWithOptionsAsync(DescribeMetricMetaListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetricMetaListResponse>(await DoRPCRequestAsync("DescribeMetricMetaList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMetricMetaListResponse DescribeMetricMetaList(DescribeMetricMetaListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricMetaListWithOptions(request, runtime);
        }

        public async Task<DescribeMetricMetaListResponse> DescribeMetricMetaListAsync(DescribeMetricMetaListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricMetaListWithOptionsAsync(request, runtime);
        }

        public DescribeMetricRuleCountResponse DescribeMetricRuleCountWithOptions(DescribeMetricRuleCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeMetricRuleCountResponse>(DoRPCRequest("DescribeMetricRuleCount", "2019-01-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeMetricRuleCountResponse> DescribeMetricRuleCountWithOptionsAsync(DescribeMetricRuleCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeMetricRuleCountResponse>(await DoRPCRequestAsync("DescribeMetricRuleCount", "2019-01-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeMetricRuleCountResponse DescribeMetricRuleCount(DescribeMetricRuleCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricRuleCountWithOptions(request, runtime);
        }

        public async Task<DescribeMetricRuleCountResponse> DescribeMetricRuleCountAsync(DescribeMetricRuleCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricRuleCountWithOptionsAsync(request, runtime);
        }

        public DescribeMetricRuleListResponse DescribeMetricRuleListWithOptions(DescribeMetricRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetricRuleListResponse>(DoRPCRequest("DescribeMetricRuleList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMetricRuleListResponse> DescribeMetricRuleListWithOptionsAsync(DescribeMetricRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetricRuleListResponse>(await DoRPCRequestAsync("DescribeMetricRuleList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMetricRuleListResponse DescribeMetricRuleList(DescribeMetricRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricRuleListWithOptions(request, runtime);
        }

        public async Task<DescribeMetricRuleListResponse> DescribeMetricRuleListAsync(DescribeMetricRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricRuleListWithOptionsAsync(request, runtime);
        }

        public DescribeMetricRuleTargetsResponse DescribeMetricRuleTargetsWithOptions(DescribeMetricRuleTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetricRuleTargetsResponse>(DoRPCRequest("DescribeMetricRuleTargets", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMetricRuleTargetsResponse> DescribeMetricRuleTargetsWithOptionsAsync(DescribeMetricRuleTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetricRuleTargetsResponse>(await DoRPCRequestAsync("DescribeMetricRuleTargets", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMetricRuleTargetsResponse DescribeMetricRuleTargets(DescribeMetricRuleTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricRuleTargetsWithOptions(request, runtime);
        }

        public async Task<DescribeMetricRuleTargetsResponse> DescribeMetricRuleTargetsAsync(DescribeMetricRuleTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricRuleTargetsWithOptionsAsync(request, runtime);
        }

        public DescribeMetricRuleTemplateAttributeResponse DescribeMetricRuleTemplateAttributeWithOptions(DescribeMetricRuleTemplateAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetricRuleTemplateAttributeResponse>(DoRPCRequest("DescribeMetricRuleTemplateAttribute", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMetricRuleTemplateAttributeResponse> DescribeMetricRuleTemplateAttributeWithOptionsAsync(DescribeMetricRuleTemplateAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetricRuleTemplateAttributeResponse>(await DoRPCRequestAsync("DescribeMetricRuleTemplateAttribute", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMetricRuleTemplateAttributeResponse DescribeMetricRuleTemplateAttribute(DescribeMetricRuleTemplateAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricRuleTemplateAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeMetricRuleTemplateAttributeResponse> DescribeMetricRuleTemplateAttributeAsync(DescribeMetricRuleTemplateAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricRuleTemplateAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeMetricRuleTemplateListResponse DescribeMetricRuleTemplateListWithOptions(DescribeMetricRuleTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetricRuleTemplateListResponse>(DoRPCRequest("DescribeMetricRuleTemplateList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMetricRuleTemplateListResponse> DescribeMetricRuleTemplateListWithOptionsAsync(DescribeMetricRuleTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetricRuleTemplateListResponse>(await DoRPCRequestAsync("DescribeMetricRuleTemplateList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMetricRuleTemplateListResponse DescribeMetricRuleTemplateList(DescribeMetricRuleTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricRuleTemplateListWithOptions(request, runtime);
        }

        public async Task<DescribeMetricRuleTemplateListResponse> DescribeMetricRuleTemplateListAsync(DescribeMetricRuleTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricRuleTemplateListWithOptionsAsync(request, runtime);
        }

        public DescribeMetricTopResponse DescribeMetricTopWithOptions(DescribeMetricTopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetricTopResponse>(DoRPCRequest("DescribeMetricTop", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMetricTopResponse> DescribeMetricTopWithOptionsAsync(DescribeMetricTopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetricTopResponse>(await DoRPCRequestAsync("DescribeMetricTop", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMetricTopResponse DescribeMetricTop(DescribeMetricTopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricTopWithOptions(request, runtime);
        }

        public async Task<DescribeMetricTopResponse> DescribeMetricTopAsync(DescribeMetricTopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricTopWithOptionsAsync(request, runtime);
        }

        public DescribeMonitorGroupCategoriesResponse DescribeMonitorGroupCategoriesWithOptions(DescribeMonitorGroupCategoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitorGroupCategoriesResponse>(DoRPCRequest("DescribeMonitorGroupCategories", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMonitorGroupCategoriesResponse> DescribeMonitorGroupCategoriesWithOptionsAsync(DescribeMonitorGroupCategoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitorGroupCategoriesResponse>(await DoRPCRequestAsync("DescribeMonitorGroupCategories", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMonitorGroupCategoriesResponse DescribeMonitorGroupCategories(DescribeMonitorGroupCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitorGroupCategoriesWithOptions(request, runtime);
        }

        public async Task<DescribeMonitorGroupCategoriesResponse> DescribeMonitorGroupCategoriesAsync(DescribeMonitorGroupCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitorGroupCategoriesWithOptionsAsync(request, runtime);
        }

        public DescribeMonitorGroupDynamicRulesResponse DescribeMonitorGroupDynamicRulesWithOptions(DescribeMonitorGroupDynamicRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitorGroupDynamicRulesResponse>(DoRPCRequest("DescribeMonitorGroupDynamicRules", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMonitorGroupDynamicRulesResponse> DescribeMonitorGroupDynamicRulesWithOptionsAsync(DescribeMonitorGroupDynamicRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitorGroupDynamicRulesResponse>(await DoRPCRequestAsync("DescribeMonitorGroupDynamicRules", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMonitorGroupDynamicRulesResponse DescribeMonitorGroupDynamicRules(DescribeMonitorGroupDynamicRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitorGroupDynamicRulesWithOptions(request, runtime);
        }

        public async Task<DescribeMonitorGroupDynamicRulesResponse> DescribeMonitorGroupDynamicRulesAsync(DescribeMonitorGroupDynamicRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitorGroupDynamicRulesWithOptionsAsync(request, runtime);
        }

        public DescribeMonitorGroupInstanceAttributeResponse DescribeMonitorGroupInstanceAttributeWithOptions(DescribeMonitorGroupInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitorGroupInstanceAttributeResponse>(DoRPCRequest("DescribeMonitorGroupInstanceAttribute", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMonitorGroupInstanceAttributeResponse> DescribeMonitorGroupInstanceAttributeWithOptionsAsync(DescribeMonitorGroupInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitorGroupInstanceAttributeResponse>(await DoRPCRequestAsync("DescribeMonitorGroupInstanceAttribute", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMonitorGroupInstanceAttributeResponse DescribeMonitorGroupInstanceAttribute(DescribeMonitorGroupInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitorGroupInstanceAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeMonitorGroupInstanceAttributeResponse> DescribeMonitorGroupInstanceAttributeAsync(DescribeMonitorGroupInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitorGroupInstanceAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeMonitorGroupInstancesResponse DescribeMonitorGroupInstancesWithOptions(DescribeMonitorGroupInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitorGroupInstancesResponse>(DoRPCRequest("DescribeMonitorGroupInstances", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMonitorGroupInstancesResponse> DescribeMonitorGroupInstancesWithOptionsAsync(DescribeMonitorGroupInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitorGroupInstancesResponse>(await DoRPCRequestAsync("DescribeMonitorGroupInstances", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMonitorGroupInstancesResponse DescribeMonitorGroupInstances(DescribeMonitorGroupInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitorGroupInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeMonitorGroupInstancesResponse> DescribeMonitorGroupInstancesAsync(DescribeMonitorGroupInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitorGroupInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeMonitorGroupNotifyPolicyListResponse DescribeMonitorGroupNotifyPolicyListWithOptions(DescribeMonitorGroupNotifyPolicyListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitorGroupNotifyPolicyListResponse>(DoRPCRequest("DescribeMonitorGroupNotifyPolicyList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMonitorGroupNotifyPolicyListResponse> DescribeMonitorGroupNotifyPolicyListWithOptionsAsync(DescribeMonitorGroupNotifyPolicyListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitorGroupNotifyPolicyListResponse>(await DoRPCRequestAsync("DescribeMonitorGroupNotifyPolicyList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMonitorGroupNotifyPolicyListResponse DescribeMonitorGroupNotifyPolicyList(DescribeMonitorGroupNotifyPolicyListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitorGroupNotifyPolicyListWithOptions(request, runtime);
        }

        public async Task<DescribeMonitorGroupNotifyPolicyListResponse> DescribeMonitorGroupNotifyPolicyListAsync(DescribeMonitorGroupNotifyPolicyListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitorGroupNotifyPolicyListWithOptionsAsync(request, runtime);
        }

        public DescribeMonitorGroupsResponse DescribeMonitorGroupsWithOptions(DescribeMonitorGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitorGroupsResponse>(DoRPCRequest("DescribeMonitorGroups", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMonitorGroupsResponse> DescribeMonitorGroupsWithOptionsAsync(DescribeMonitorGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitorGroupsResponse>(await DoRPCRequestAsync("DescribeMonitorGroups", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMonitorGroupsResponse DescribeMonitorGroups(DescribeMonitorGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitorGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeMonitorGroupsResponse> DescribeMonitorGroupsAsync(DescribeMonitorGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitorGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeMonitoringAgentAccessKeyResponse DescribeMonitoringAgentAccessKeyWithOptions(DescribeMonitoringAgentAccessKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitoringAgentAccessKeyResponse>(DoRPCRequest("DescribeMonitoringAgentAccessKey", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMonitoringAgentAccessKeyResponse> DescribeMonitoringAgentAccessKeyWithOptionsAsync(DescribeMonitoringAgentAccessKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitoringAgentAccessKeyResponse>(await DoRPCRequestAsync("DescribeMonitoringAgentAccessKey", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMonitoringAgentAccessKeyResponse DescribeMonitoringAgentAccessKey(DescribeMonitoringAgentAccessKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitoringAgentAccessKeyWithOptions(request, runtime);
        }

        public async Task<DescribeMonitoringAgentAccessKeyResponse> DescribeMonitoringAgentAccessKeyAsync(DescribeMonitoringAgentAccessKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitoringAgentAccessKeyWithOptionsAsync(request, runtime);
        }

        public DescribeMonitoringAgentConfigResponse DescribeMonitoringAgentConfigWithOptions(DescribeMonitoringAgentConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitoringAgentConfigResponse>(DoRPCRequest("DescribeMonitoringAgentConfig", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMonitoringAgentConfigResponse> DescribeMonitoringAgentConfigWithOptionsAsync(DescribeMonitoringAgentConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitoringAgentConfigResponse>(await DoRPCRequestAsync("DescribeMonitoringAgentConfig", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMonitoringAgentConfigResponse DescribeMonitoringAgentConfig(DescribeMonitoringAgentConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitoringAgentConfigWithOptions(request, runtime);
        }

        public async Task<DescribeMonitoringAgentConfigResponse> DescribeMonitoringAgentConfigAsync(DescribeMonitoringAgentConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitoringAgentConfigWithOptionsAsync(request, runtime);
        }

        public DescribeMonitoringAgentHostsResponse DescribeMonitoringAgentHostsWithOptions(DescribeMonitoringAgentHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitoringAgentHostsResponse>(DoRPCRequest("DescribeMonitoringAgentHosts", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMonitoringAgentHostsResponse> DescribeMonitoringAgentHostsWithOptionsAsync(DescribeMonitoringAgentHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitoringAgentHostsResponse>(await DoRPCRequestAsync("DescribeMonitoringAgentHosts", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMonitoringAgentHostsResponse DescribeMonitoringAgentHosts(DescribeMonitoringAgentHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitoringAgentHostsWithOptions(request, runtime);
        }

        public async Task<DescribeMonitoringAgentHostsResponse> DescribeMonitoringAgentHostsAsync(DescribeMonitoringAgentHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitoringAgentHostsWithOptionsAsync(request, runtime);
        }

        public DescribeMonitoringAgentProcessesResponse DescribeMonitoringAgentProcessesWithOptions(DescribeMonitoringAgentProcessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitoringAgentProcessesResponse>(DoRPCRequest("DescribeMonitoringAgentProcesses", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMonitoringAgentProcessesResponse> DescribeMonitoringAgentProcessesWithOptionsAsync(DescribeMonitoringAgentProcessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitoringAgentProcessesResponse>(await DoRPCRequestAsync("DescribeMonitoringAgentProcesses", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMonitoringAgentProcessesResponse DescribeMonitoringAgentProcesses(DescribeMonitoringAgentProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitoringAgentProcessesWithOptions(request, runtime);
        }

        public async Task<DescribeMonitoringAgentProcessesResponse> DescribeMonitoringAgentProcessesAsync(DescribeMonitoringAgentProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitoringAgentProcessesWithOptionsAsync(request, runtime);
        }

        public DescribeMonitoringAgentStatusesResponse DescribeMonitoringAgentStatusesWithOptions(DescribeMonitoringAgentStatusesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitoringAgentStatusesResponse>(DoRPCRequest("DescribeMonitoringAgentStatuses", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMonitoringAgentStatusesResponse> DescribeMonitoringAgentStatusesWithOptionsAsync(DescribeMonitoringAgentStatusesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitoringAgentStatusesResponse>(await DoRPCRequestAsync("DescribeMonitoringAgentStatuses", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMonitoringAgentStatusesResponse DescribeMonitoringAgentStatuses(DescribeMonitoringAgentStatusesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitoringAgentStatusesWithOptions(request, runtime);
        }

        public async Task<DescribeMonitoringAgentStatusesResponse> DescribeMonitoringAgentStatusesAsync(DescribeMonitoringAgentStatusesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitoringAgentStatusesWithOptionsAsync(request, runtime);
        }

        public DescribeMonitoringConfigResponse DescribeMonitoringConfigWithOptions(DescribeMonitoringConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitoringConfigResponse>(DoRPCRequest("DescribeMonitoringConfig", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMonitoringConfigResponse> DescribeMonitoringConfigWithOptionsAsync(DescribeMonitoringConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitoringConfigResponse>(await DoRPCRequestAsync("DescribeMonitoringConfig", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMonitoringConfigResponse DescribeMonitoringConfig(DescribeMonitoringConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitoringConfigWithOptions(request, runtime);
        }

        public async Task<DescribeMonitoringConfigResponse> DescribeMonitoringConfigAsync(DescribeMonitoringConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitoringConfigWithOptionsAsync(request, runtime);
        }

        public DescribeMonitorResourceQuotaAttributeResponse DescribeMonitorResourceQuotaAttributeWithOptions(DescribeMonitorResourceQuotaAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitorResourceQuotaAttributeResponse>(DoRPCRequest("DescribeMonitorResourceQuotaAttribute", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMonitorResourceQuotaAttributeResponse> DescribeMonitorResourceQuotaAttributeWithOptionsAsync(DescribeMonitorResourceQuotaAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitorResourceQuotaAttributeResponse>(await DoRPCRequestAsync("DescribeMonitorResourceQuotaAttribute", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMonitorResourceQuotaAttributeResponse DescribeMonitorResourceQuotaAttribute(DescribeMonitorResourceQuotaAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitorResourceQuotaAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeMonitorResourceQuotaAttributeResponse> DescribeMonitorResourceQuotaAttributeAsync(DescribeMonitorResourceQuotaAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitorResourceQuotaAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeProductResourceTagKeyListResponse DescribeProductResourceTagKeyListWithOptions(DescribeProductResourceTagKeyListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProductResourceTagKeyListResponse>(DoRPCRequest("DescribeProductResourceTagKeyList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeProductResourceTagKeyListResponse> DescribeProductResourceTagKeyListWithOptionsAsync(DescribeProductResourceTagKeyListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProductResourceTagKeyListResponse>(await DoRPCRequestAsync("DescribeProductResourceTagKeyList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeProductResourceTagKeyListResponse DescribeProductResourceTagKeyList(DescribeProductResourceTagKeyListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProductResourceTagKeyListWithOptions(request, runtime);
        }

        public async Task<DescribeProductResourceTagKeyListResponse> DescribeProductResourceTagKeyListAsync(DescribeProductResourceTagKeyListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProductResourceTagKeyListWithOptionsAsync(request, runtime);
        }

        public DescribeProductsOfActiveMetricRuleResponse DescribeProductsOfActiveMetricRuleWithOptions(DescribeProductsOfActiveMetricRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProductsOfActiveMetricRuleResponse>(DoRPCRequest("DescribeProductsOfActiveMetricRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeProductsOfActiveMetricRuleResponse> DescribeProductsOfActiveMetricRuleWithOptionsAsync(DescribeProductsOfActiveMetricRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProductsOfActiveMetricRuleResponse>(await DoRPCRequestAsync("DescribeProductsOfActiveMetricRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeProductsOfActiveMetricRuleResponse DescribeProductsOfActiveMetricRule(DescribeProductsOfActiveMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProductsOfActiveMetricRuleWithOptions(request, runtime);
        }

        public async Task<DescribeProductsOfActiveMetricRuleResponse> DescribeProductsOfActiveMetricRuleAsync(DescribeProductsOfActiveMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProductsOfActiveMetricRuleWithOptionsAsync(request, runtime);
        }

        public DescribeProjectMetaResponse DescribeProjectMetaWithOptions(DescribeProjectMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProjectMetaResponse>(DoRPCRequest("DescribeProjectMeta", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeProjectMetaResponse> DescribeProjectMetaWithOptionsAsync(DescribeProjectMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProjectMetaResponse>(await DoRPCRequestAsync("DescribeProjectMeta", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeProjectMetaResponse DescribeProjectMeta(DescribeProjectMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProjectMetaWithOptions(request, runtime);
        }

        public async Task<DescribeProjectMetaResponse> DescribeProjectMetaAsync(DescribeProjectMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProjectMetaWithOptionsAsync(request, runtime);
        }

        public DescribeSiteMonitorAttributeResponse DescribeSiteMonitorAttributeWithOptions(DescribeSiteMonitorAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSiteMonitorAttributeResponse>(DoRPCRequest("DescribeSiteMonitorAttribute", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSiteMonitorAttributeResponse> DescribeSiteMonitorAttributeWithOptionsAsync(DescribeSiteMonitorAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSiteMonitorAttributeResponse>(await DoRPCRequestAsync("DescribeSiteMonitorAttribute", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSiteMonitorAttributeResponse DescribeSiteMonitorAttribute(DescribeSiteMonitorAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSiteMonitorAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeSiteMonitorAttributeResponse> DescribeSiteMonitorAttributeAsync(DescribeSiteMonitorAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSiteMonitorAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeSiteMonitorDataResponse DescribeSiteMonitorDataWithOptions(DescribeSiteMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSiteMonitorDataResponse>(DoRPCRequest("DescribeSiteMonitorData", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSiteMonitorDataResponse> DescribeSiteMonitorDataWithOptionsAsync(DescribeSiteMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSiteMonitorDataResponse>(await DoRPCRequestAsync("DescribeSiteMonitorData", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSiteMonitorDataResponse DescribeSiteMonitorData(DescribeSiteMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSiteMonitorDataWithOptions(request, runtime);
        }

        public async Task<DescribeSiteMonitorDataResponse> DescribeSiteMonitorDataAsync(DescribeSiteMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSiteMonitorDataWithOptionsAsync(request, runtime);
        }

        public DescribeSiteMonitorListResponse DescribeSiteMonitorListWithOptions(DescribeSiteMonitorListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSiteMonitorListResponse>(DoRPCRequest("DescribeSiteMonitorList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSiteMonitorListResponse> DescribeSiteMonitorListWithOptionsAsync(DescribeSiteMonitorListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSiteMonitorListResponse>(await DoRPCRequestAsync("DescribeSiteMonitorList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSiteMonitorListResponse DescribeSiteMonitorList(DescribeSiteMonitorListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSiteMonitorListWithOptions(request, runtime);
        }

        public async Task<DescribeSiteMonitorListResponse> DescribeSiteMonitorListAsync(DescribeSiteMonitorListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSiteMonitorListWithOptionsAsync(request, runtime);
        }

        public DescribeSiteMonitorQuotaResponse DescribeSiteMonitorQuotaWithOptions(DescribeSiteMonitorQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSiteMonitorQuotaResponse>(DoRPCRequest("DescribeSiteMonitorQuota", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSiteMonitorQuotaResponse> DescribeSiteMonitorQuotaWithOptionsAsync(DescribeSiteMonitorQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSiteMonitorQuotaResponse>(await DoRPCRequestAsync("DescribeSiteMonitorQuota", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSiteMonitorQuotaResponse DescribeSiteMonitorQuota(DescribeSiteMonitorQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSiteMonitorQuotaWithOptions(request, runtime);
        }

        public async Task<DescribeSiteMonitorQuotaResponse> DescribeSiteMonitorQuotaAsync(DescribeSiteMonitorQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSiteMonitorQuotaWithOptionsAsync(request, runtime);
        }

        public DescribeSiteMonitorStatisticsResponse DescribeSiteMonitorStatisticsWithOptions(DescribeSiteMonitorStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSiteMonitorStatisticsResponse>(DoRPCRequest("DescribeSiteMonitorStatistics", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSiteMonitorStatisticsResponse> DescribeSiteMonitorStatisticsWithOptionsAsync(DescribeSiteMonitorStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSiteMonitorStatisticsResponse>(await DoRPCRequestAsync("DescribeSiteMonitorStatistics", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSiteMonitorStatisticsResponse DescribeSiteMonitorStatistics(DescribeSiteMonitorStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSiteMonitorStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeSiteMonitorStatisticsResponse> DescribeSiteMonitorStatisticsAsync(DescribeSiteMonitorStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSiteMonitorStatisticsWithOptionsAsync(request, runtime);
        }

        public DescribeSystemEventAttributeResponse DescribeSystemEventAttributeWithOptions(DescribeSystemEventAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSystemEventAttributeResponse>(DoRPCRequest("DescribeSystemEventAttribute", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSystemEventAttributeResponse> DescribeSystemEventAttributeWithOptionsAsync(DescribeSystemEventAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSystemEventAttributeResponse>(await DoRPCRequestAsync("DescribeSystemEventAttribute", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSystemEventAttributeResponse DescribeSystemEventAttribute(DescribeSystemEventAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSystemEventAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeSystemEventAttributeResponse> DescribeSystemEventAttributeAsync(DescribeSystemEventAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSystemEventAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeSystemEventCountResponse DescribeSystemEventCountWithOptions(DescribeSystemEventCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSystemEventCountResponse>(DoRPCRequest("DescribeSystemEventCount", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSystemEventCountResponse> DescribeSystemEventCountWithOptionsAsync(DescribeSystemEventCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSystemEventCountResponse>(await DoRPCRequestAsync("DescribeSystemEventCount", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSystemEventCountResponse DescribeSystemEventCount(DescribeSystemEventCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSystemEventCountWithOptions(request, runtime);
        }

        public async Task<DescribeSystemEventCountResponse> DescribeSystemEventCountAsync(DescribeSystemEventCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSystemEventCountWithOptionsAsync(request, runtime);
        }

        public DescribeSystemEventHistogramResponse DescribeSystemEventHistogramWithOptions(DescribeSystemEventHistogramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSystemEventHistogramResponse>(DoRPCRequest("DescribeSystemEventHistogram", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSystemEventHistogramResponse> DescribeSystemEventHistogramWithOptionsAsync(DescribeSystemEventHistogramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSystemEventHistogramResponse>(await DoRPCRequestAsync("DescribeSystemEventHistogram", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSystemEventHistogramResponse DescribeSystemEventHistogram(DescribeSystemEventHistogramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSystemEventHistogramWithOptions(request, runtime);
        }

        public async Task<DescribeSystemEventHistogramResponse> DescribeSystemEventHistogramAsync(DescribeSystemEventHistogramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSystemEventHistogramWithOptionsAsync(request, runtime);
        }

        public DescribeTagKeyListResponse DescribeTagKeyListWithOptions(DescribeTagKeyListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTagKeyListResponse>(DoRPCRequest("DescribeTagKeyList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTagKeyListResponse> DescribeTagKeyListWithOptionsAsync(DescribeTagKeyListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTagKeyListResponse>(await DoRPCRequestAsync("DescribeTagKeyList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTagKeyListResponse DescribeTagKeyList(DescribeTagKeyListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTagKeyListWithOptions(request, runtime);
        }

        public async Task<DescribeTagKeyListResponse> DescribeTagKeyListAsync(DescribeTagKeyListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTagKeyListWithOptionsAsync(request, runtime);
        }

        public DescribeTagValueListResponse DescribeTagValueListWithOptions(DescribeTagValueListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTagValueListResponse>(DoRPCRequest("DescribeTagValueList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTagValueListResponse> DescribeTagValueListWithOptionsAsync(DescribeTagValueListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTagValueListResponse>(await DoRPCRequestAsync("DescribeTagValueList", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTagValueListResponse DescribeTagValueList(DescribeTagValueListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTagValueListWithOptions(request, runtime);
        }

        public async Task<DescribeTagValueListResponse> DescribeTagValueListAsync(DescribeTagValueListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTagValueListWithOptionsAsync(request, runtime);
        }

        public DescribeUnhealthyHostAvailabilityResponse DescribeUnhealthyHostAvailabilityWithOptions(DescribeUnhealthyHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUnhealthyHostAvailabilityResponse>(DoRPCRequest("DescribeUnhealthyHostAvailability", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUnhealthyHostAvailabilityResponse> DescribeUnhealthyHostAvailabilityWithOptionsAsync(DescribeUnhealthyHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUnhealthyHostAvailabilityResponse>(await DoRPCRequestAsync("DescribeUnhealthyHostAvailability", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUnhealthyHostAvailabilityResponse DescribeUnhealthyHostAvailability(DescribeUnhealthyHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUnhealthyHostAvailabilityWithOptions(request, runtime);
        }

        public async Task<DescribeUnhealthyHostAvailabilityResponse> DescribeUnhealthyHostAvailabilityAsync(DescribeUnhealthyHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUnhealthyHostAvailabilityWithOptionsAsync(request, runtime);
        }

        public DisableActiveMetricRuleResponse DisableActiveMetricRuleWithOptions(DisableActiveMetricRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableActiveMetricRuleResponse>(DoRPCRequest("DisableActiveMetricRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableActiveMetricRuleResponse> DisableActiveMetricRuleWithOptionsAsync(DisableActiveMetricRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableActiveMetricRuleResponse>(await DoRPCRequestAsync("DisableActiveMetricRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableActiveMetricRuleResponse DisableActiveMetricRule(DisableActiveMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableActiveMetricRuleWithOptions(request, runtime);
        }

        public async Task<DisableActiveMetricRuleResponse> DisableActiveMetricRuleAsync(DisableActiveMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableActiveMetricRuleWithOptionsAsync(request, runtime);
        }

        public DisableEventRulesResponse DisableEventRulesWithOptions(DisableEventRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableEventRulesResponse>(DoRPCRequest("DisableEventRules", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableEventRulesResponse> DisableEventRulesWithOptionsAsync(DisableEventRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableEventRulesResponse>(await DoRPCRequestAsync("DisableEventRules", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableEventRulesResponse DisableEventRules(DisableEventRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableEventRulesWithOptions(request, runtime);
        }

        public async Task<DisableEventRulesResponse> DisableEventRulesAsync(DisableEventRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableEventRulesWithOptionsAsync(request, runtime);
        }

        public DisableHostAvailabilityResponse DisableHostAvailabilityWithOptions(DisableHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableHostAvailabilityResponse>(DoRPCRequest("DisableHostAvailability", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableHostAvailabilityResponse> DisableHostAvailabilityWithOptionsAsync(DisableHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableHostAvailabilityResponse>(await DoRPCRequestAsync("DisableHostAvailability", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableHostAvailabilityResponse DisableHostAvailability(DisableHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableHostAvailabilityWithOptions(request, runtime);
        }

        public async Task<DisableHostAvailabilityResponse> DisableHostAvailabilityAsync(DisableHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableHostAvailabilityWithOptionsAsync(request, runtime);
        }

        public DisableMetricRulesResponse DisableMetricRulesWithOptions(DisableMetricRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableMetricRulesResponse>(DoRPCRequest("DisableMetricRules", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableMetricRulesResponse> DisableMetricRulesWithOptionsAsync(DisableMetricRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableMetricRulesResponse>(await DoRPCRequestAsync("DisableMetricRules", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableMetricRulesResponse DisableMetricRules(DisableMetricRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableMetricRulesWithOptions(request, runtime);
        }

        public async Task<DisableMetricRulesResponse> DisableMetricRulesAsync(DisableMetricRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableMetricRulesWithOptionsAsync(request, runtime);
        }

        public DisableSiteMonitorsResponse DisableSiteMonitorsWithOptions(DisableSiteMonitorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableSiteMonitorsResponse>(DoRPCRequest("DisableSiteMonitors", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableSiteMonitorsResponse> DisableSiteMonitorsWithOptionsAsync(DisableSiteMonitorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableSiteMonitorsResponse>(await DoRPCRequestAsync("DisableSiteMonitors", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableSiteMonitorsResponse DisableSiteMonitors(DisableSiteMonitorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableSiteMonitorsWithOptions(request, runtime);
        }

        public async Task<DisableSiteMonitorsResponse> DisableSiteMonitorsAsync(DisableSiteMonitorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableSiteMonitorsWithOptionsAsync(request, runtime);
        }

        public EnableActiveMetricRuleResponse EnableActiveMetricRuleWithOptions(EnableActiveMetricRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableActiveMetricRuleResponse>(DoRPCRequest("EnableActiveMetricRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableActiveMetricRuleResponse> EnableActiveMetricRuleWithOptionsAsync(EnableActiveMetricRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableActiveMetricRuleResponse>(await DoRPCRequestAsync("EnableActiveMetricRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableActiveMetricRuleResponse EnableActiveMetricRule(EnableActiveMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableActiveMetricRuleWithOptions(request, runtime);
        }

        public async Task<EnableActiveMetricRuleResponse> EnableActiveMetricRuleAsync(EnableActiveMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableActiveMetricRuleWithOptionsAsync(request, runtime);
        }

        public EnableEventRulesResponse EnableEventRulesWithOptions(EnableEventRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableEventRulesResponse>(DoRPCRequest("EnableEventRules", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableEventRulesResponse> EnableEventRulesWithOptionsAsync(EnableEventRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableEventRulesResponse>(await DoRPCRequestAsync("EnableEventRules", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableEventRulesResponse EnableEventRules(EnableEventRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableEventRulesWithOptions(request, runtime);
        }

        public async Task<EnableEventRulesResponse> EnableEventRulesAsync(EnableEventRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableEventRulesWithOptionsAsync(request, runtime);
        }

        public EnableHostAvailabilityResponse EnableHostAvailabilityWithOptions(EnableHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableHostAvailabilityResponse>(DoRPCRequest("EnableHostAvailability", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableHostAvailabilityResponse> EnableHostAvailabilityWithOptionsAsync(EnableHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableHostAvailabilityResponse>(await DoRPCRequestAsync("EnableHostAvailability", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableHostAvailabilityResponse EnableHostAvailability(EnableHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableHostAvailabilityWithOptions(request, runtime);
        }

        public async Task<EnableHostAvailabilityResponse> EnableHostAvailabilityAsync(EnableHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableHostAvailabilityWithOptionsAsync(request, runtime);
        }

        public EnableMetricRulesResponse EnableMetricRulesWithOptions(EnableMetricRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableMetricRulesResponse>(DoRPCRequest("EnableMetricRules", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableMetricRulesResponse> EnableMetricRulesWithOptionsAsync(EnableMetricRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableMetricRulesResponse>(await DoRPCRequestAsync("EnableMetricRules", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableMetricRulesResponse EnableMetricRules(EnableMetricRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableMetricRulesWithOptions(request, runtime);
        }

        public async Task<EnableMetricRulesResponse> EnableMetricRulesAsync(EnableMetricRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableMetricRulesWithOptionsAsync(request, runtime);
        }

        public EnableSiteMonitorsResponse EnableSiteMonitorsWithOptions(EnableSiteMonitorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableSiteMonitorsResponse>(DoRPCRequest("EnableSiteMonitors", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableSiteMonitorsResponse> EnableSiteMonitorsWithOptionsAsync(EnableSiteMonitorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableSiteMonitorsResponse>(await DoRPCRequestAsync("EnableSiteMonitors", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableSiteMonitorsResponse EnableSiteMonitors(EnableSiteMonitorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableSiteMonitorsWithOptions(request, runtime);
        }

        public async Task<EnableSiteMonitorsResponse> EnableSiteMonitorsAsync(EnableSiteMonitorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableSiteMonitorsWithOptionsAsync(request, runtime);
        }

        public InstallMonitoringAgentResponse InstallMonitoringAgentWithOptions(InstallMonitoringAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InstallMonitoringAgentResponse>(DoRPCRequest("InstallMonitoringAgent", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InstallMonitoringAgentResponse> InstallMonitoringAgentWithOptionsAsync(InstallMonitoringAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InstallMonitoringAgentResponse>(await DoRPCRequestAsync("InstallMonitoringAgent", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InstallMonitoringAgentResponse InstallMonitoringAgent(InstallMonitoringAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstallMonitoringAgentWithOptions(request, runtime);
        }

        public async Task<InstallMonitoringAgentResponse> InstallMonitoringAgentAsync(InstallMonitoringAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstallMonitoringAgentWithOptionsAsync(request, runtime);
        }

        public ModifyGroupMonitoringAgentProcessResponse ModifyGroupMonitoringAgentProcessWithOptions(ModifyGroupMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyGroupMonitoringAgentProcessResponse>(DoRPCRequest("ModifyGroupMonitoringAgentProcess", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyGroupMonitoringAgentProcessResponse> ModifyGroupMonitoringAgentProcessWithOptionsAsync(ModifyGroupMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyGroupMonitoringAgentProcessResponse>(await DoRPCRequestAsync("ModifyGroupMonitoringAgentProcess", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyGroupMonitoringAgentProcessResponse ModifyGroupMonitoringAgentProcess(ModifyGroupMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyGroupMonitoringAgentProcessWithOptions(request, runtime);
        }

        public async Task<ModifyGroupMonitoringAgentProcessResponse> ModifyGroupMonitoringAgentProcessAsync(ModifyGroupMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyGroupMonitoringAgentProcessWithOptionsAsync(request, runtime);
        }

        public ModifyHostAvailabilityResponse ModifyHostAvailabilityWithOptions(ModifyHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHostAvailabilityResponse>(DoRPCRequest("ModifyHostAvailability", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyHostAvailabilityResponse> ModifyHostAvailabilityWithOptionsAsync(ModifyHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHostAvailabilityResponse>(await DoRPCRequestAsync("ModifyHostAvailability", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyHostAvailabilityResponse ModifyHostAvailability(ModifyHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHostAvailabilityWithOptions(request, runtime);
        }

        public async Task<ModifyHostAvailabilityResponse> ModifyHostAvailabilityAsync(ModifyHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHostAvailabilityWithOptionsAsync(request, runtime);
        }

        public ModifyHostInfoResponse ModifyHostInfoWithOptions(ModifyHostInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHostInfoResponse>(DoRPCRequest("ModifyHostInfo", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyHostInfoResponse> ModifyHostInfoWithOptionsAsync(ModifyHostInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHostInfoResponse>(await DoRPCRequestAsync("ModifyHostInfo", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyHostInfoResponse ModifyHostInfo(ModifyHostInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHostInfoWithOptions(request, runtime);
        }

        public async Task<ModifyHostInfoResponse> ModifyHostInfoAsync(ModifyHostInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHostInfoWithOptionsAsync(request, runtime);
        }

        public ModifyMetricRuleTemplateResponse ModifyMetricRuleTemplateWithOptions(ModifyMetricRuleTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyMetricRuleTemplateResponse>(DoRPCRequest("ModifyMetricRuleTemplate", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyMetricRuleTemplateResponse> ModifyMetricRuleTemplateWithOptionsAsync(ModifyMetricRuleTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyMetricRuleTemplateResponse>(await DoRPCRequestAsync("ModifyMetricRuleTemplate", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyMetricRuleTemplateResponse ModifyMetricRuleTemplate(ModifyMetricRuleTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMetricRuleTemplateWithOptions(request, runtime);
        }

        public async Task<ModifyMetricRuleTemplateResponse> ModifyMetricRuleTemplateAsync(ModifyMetricRuleTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMetricRuleTemplateWithOptionsAsync(request, runtime);
        }

        public ModifyMonitorGroupResponse ModifyMonitorGroupWithOptions(ModifyMonitorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyMonitorGroupResponse>(DoRPCRequest("ModifyMonitorGroup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyMonitorGroupResponse> ModifyMonitorGroupWithOptionsAsync(ModifyMonitorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyMonitorGroupResponse>(await DoRPCRequestAsync("ModifyMonitorGroup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyMonitorGroupResponse ModifyMonitorGroup(ModifyMonitorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMonitorGroupWithOptions(request, runtime);
        }

        public async Task<ModifyMonitorGroupResponse> ModifyMonitorGroupAsync(ModifyMonitorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMonitorGroupWithOptionsAsync(request, runtime);
        }

        public ModifyMonitorGroupInstancesResponse ModifyMonitorGroupInstancesWithOptions(ModifyMonitorGroupInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyMonitorGroupInstancesResponse>(DoRPCRequest("ModifyMonitorGroupInstances", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyMonitorGroupInstancesResponse> ModifyMonitorGroupInstancesWithOptionsAsync(ModifyMonitorGroupInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyMonitorGroupInstancesResponse>(await DoRPCRequestAsync("ModifyMonitorGroupInstances", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyMonitorGroupInstancesResponse ModifyMonitorGroupInstances(ModifyMonitorGroupInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMonitorGroupInstancesWithOptions(request, runtime);
        }

        public async Task<ModifyMonitorGroupInstancesResponse> ModifyMonitorGroupInstancesAsync(ModifyMonitorGroupInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMonitorGroupInstancesWithOptionsAsync(request, runtime);
        }

        public ModifySiteMonitorResponse ModifySiteMonitorWithOptions(ModifySiteMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySiteMonitorResponse>(DoRPCRequest("ModifySiteMonitor", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySiteMonitorResponse> ModifySiteMonitorWithOptionsAsync(ModifySiteMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySiteMonitorResponse>(await DoRPCRequestAsync("ModifySiteMonitor", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySiteMonitorResponse ModifySiteMonitor(ModifySiteMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySiteMonitorWithOptions(request, runtime);
        }

        public async Task<ModifySiteMonitorResponse> ModifySiteMonitorAsync(ModifySiteMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySiteMonitorWithOptionsAsync(request, runtime);
        }

        public OpenCmsServiceResponse OpenCmsServiceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<OpenCmsServiceResponse>(DoRPCRequest("OpenCmsService", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OpenCmsServiceResponse> OpenCmsServiceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<OpenCmsServiceResponse>(await DoRPCRequestAsync("OpenCmsService", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OpenCmsServiceResponse OpenCmsService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenCmsServiceWithOptions(runtime);
        }

        public async Task<OpenCmsServiceResponse> OpenCmsServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenCmsServiceWithOptionsAsync(runtime);
        }

        public PutContactResponse PutContactWithOptions(PutContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutContactResponse>(DoRPCRequest("PutContact", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutContactResponse> PutContactWithOptionsAsync(PutContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutContactResponse>(await DoRPCRequestAsync("PutContact", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutContactResponse PutContact(PutContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutContactWithOptions(request, runtime);
        }

        public async Task<PutContactResponse> PutContactAsync(PutContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutContactWithOptionsAsync(request, runtime);
        }

        public PutContactGroupResponse PutContactGroupWithOptions(PutContactGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutContactGroupResponse>(DoRPCRequest("PutContactGroup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutContactGroupResponse> PutContactGroupWithOptionsAsync(PutContactGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutContactGroupResponse>(await DoRPCRequestAsync("PutContactGroup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutContactGroupResponse PutContactGroup(PutContactGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutContactGroupWithOptions(request, runtime);
        }

        public async Task<PutContactGroupResponse> PutContactGroupAsync(PutContactGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutContactGroupWithOptionsAsync(request, runtime);
        }

        public PutCustomEventResponse PutCustomEventWithOptions(PutCustomEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutCustomEventResponse>(DoRPCRequest("PutCustomEvent", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutCustomEventResponse> PutCustomEventWithOptionsAsync(PutCustomEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutCustomEventResponse>(await DoRPCRequestAsync("PutCustomEvent", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutCustomEventResponse PutCustomEvent(PutCustomEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutCustomEventWithOptions(request, runtime);
        }

        public async Task<PutCustomEventResponse> PutCustomEventAsync(PutCustomEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutCustomEventWithOptionsAsync(request, runtime);
        }

        public PutCustomEventRuleResponse PutCustomEventRuleWithOptions(PutCustomEventRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutCustomEventRuleResponse>(DoRPCRequest("PutCustomEventRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutCustomEventRuleResponse> PutCustomEventRuleWithOptionsAsync(PutCustomEventRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutCustomEventRuleResponse>(await DoRPCRequestAsync("PutCustomEventRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutCustomEventRuleResponse PutCustomEventRule(PutCustomEventRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutCustomEventRuleWithOptions(request, runtime);
        }

        public async Task<PutCustomEventRuleResponse> PutCustomEventRuleAsync(PutCustomEventRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutCustomEventRuleWithOptionsAsync(request, runtime);
        }

        public PutCustomMetricResponse PutCustomMetricWithOptions(PutCustomMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutCustomMetricResponse>(DoRPCRequest("PutCustomMetric", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutCustomMetricResponse> PutCustomMetricWithOptionsAsync(PutCustomMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutCustomMetricResponse>(await DoRPCRequestAsync("PutCustomMetric", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutCustomMetricResponse PutCustomMetric(PutCustomMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutCustomMetricWithOptions(request, runtime);
        }

        public async Task<PutCustomMetricResponse> PutCustomMetricAsync(PutCustomMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutCustomMetricWithOptionsAsync(request, runtime);
        }

        public PutCustomMetricRuleResponse PutCustomMetricRuleWithOptions(PutCustomMetricRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutCustomMetricRuleResponse>(DoRPCRequest("PutCustomMetricRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutCustomMetricRuleResponse> PutCustomMetricRuleWithOptionsAsync(PutCustomMetricRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutCustomMetricRuleResponse>(await DoRPCRequestAsync("PutCustomMetricRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutCustomMetricRuleResponse PutCustomMetricRule(PutCustomMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutCustomMetricRuleWithOptions(request, runtime);
        }

        public async Task<PutCustomMetricRuleResponse> PutCustomMetricRuleAsync(PutCustomMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutCustomMetricRuleWithOptionsAsync(request, runtime);
        }

        public PutEventRuleResponse PutEventRuleWithOptions(PutEventRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutEventRuleResponse>(DoRPCRequest("PutEventRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutEventRuleResponse> PutEventRuleWithOptionsAsync(PutEventRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutEventRuleResponse>(await DoRPCRequestAsync("PutEventRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutEventRuleResponse PutEventRule(PutEventRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutEventRuleWithOptions(request, runtime);
        }

        public async Task<PutEventRuleResponse> PutEventRuleAsync(PutEventRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutEventRuleWithOptionsAsync(request, runtime);
        }

        public PutEventRuleTargetsResponse PutEventRuleTargetsWithOptions(PutEventRuleTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutEventRuleTargetsResponse>(DoRPCRequest("PutEventRuleTargets", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutEventRuleTargetsResponse> PutEventRuleTargetsWithOptionsAsync(PutEventRuleTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutEventRuleTargetsResponse>(await DoRPCRequestAsync("PutEventRuleTargets", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutEventRuleTargetsResponse PutEventRuleTargets(PutEventRuleTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutEventRuleTargetsWithOptions(request, runtime);
        }

        public async Task<PutEventRuleTargetsResponse> PutEventRuleTargetsAsync(PutEventRuleTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutEventRuleTargetsWithOptionsAsync(request, runtime);
        }

        public PutExporterOutputResponse PutExporterOutputWithOptions(PutExporterOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutExporterOutputResponse>(DoRPCRequest("PutExporterOutput", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutExporterOutputResponse> PutExporterOutputWithOptionsAsync(PutExporterOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutExporterOutputResponse>(await DoRPCRequestAsync("PutExporterOutput", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutExporterOutputResponse PutExporterOutput(PutExporterOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutExporterOutputWithOptions(request, runtime);
        }

        public async Task<PutExporterOutputResponse> PutExporterOutputAsync(PutExporterOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutExporterOutputWithOptionsAsync(request, runtime);
        }

        public PutExporterRuleResponse PutExporterRuleWithOptions(PutExporterRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutExporterRuleResponse>(DoRPCRequest("PutExporterRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutExporterRuleResponse> PutExporterRuleWithOptionsAsync(PutExporterRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutExporterRuleResponse>(await DoRPCRequestAsync("PutExporterRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutExporterRuleResponse PutExporterRule(PutExporterRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutExporterRuleWithOptions(request, runtime);
        }

        public async Task<PutExporterRuleResponse> PutExporterRuleAsync(PutExporterRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutExporterRuleWithOptionsAsync(request, runtime);
        }

        public PutGroupMetricRuleResponse PutGroupMetricRuleWithOptions(PutGroupMetricRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutGroupMetricRuleResponse>(DoRPCRequest("PutGroupMetricRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutGroupMetricRuleResponse> PutGroupMetricRuleWithOptionsAsync(PutGroupMetricRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutGroupMetricRuleResponse>(await DoRPCRequestAsync("PutGroupMetricRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutGroupMetricRuleResponse PutGroupMetricRule(PutGroupMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutGroupMetricRuleWithOptions(request, runtime);
        }

        public async Task<PutGroupMetricRuleResponse> PutGroupMetricRuleAsync(PutGroupMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutGroupMetricRuleWithOptionsAsync(request, runtime);
        }

        public PutLogMonitorResponse PutLogMonitorWithOptions(PutLogMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutLogMonitorResponse>(DoRPCRequest("PutLogMonitor", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutLogMonitorResponse> PutLogMonitorWithOptionsAsync(PutLogMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutLogMonitorResponse>(await DoRPCRequestAsync("PutLogMonitor", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutLogMonitorResponse PutLogMonitor(PutLogMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutLogMonitorWithOptions(request, runtime);
        }

        public async Task<PutLogMonitorResponse> PutLogMonitorAsync(PutLogMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutLogMonitorWithOptionsAsync(request, runtime);
        }

        public PutMetricRuleTargetsResponse PutMetricRuleTargetsWithOptions(PutMetricRuleTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutMetricRuleTargetsResponse>(DoRPCRequest("PutMetricRuleTargets", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutMetricRuleTargetsResponse> PutMetricRuleTargetsWithOptionsAsync(PutMetricRuleTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutMetricRuleTargetsResponse>(await DoRPCRequestAsync("PutMetricRuleTargets", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutMetricRuleTargetsResponse PutMetricRuleTargets(PutMetricRuleTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutMetricRuleTargetsWithOptions(request, runtime);
        }

        public async Task<PutMetricRuleTargetsResponse> PutMetricRuleTargetsAsync(PutMetricRuleTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutMetricRuleTargetsWithOptionsAsync(request, runtime);
        }

        public PutMonitorGroupDynamicRuleResponse PutMonitorGroupDynamicRuleWithOptions(PutMonitorGroupDynamicRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutMonitorGroupDynamicRuleResponse>(DoRPCRequest("PutMonitorGroupDynamicRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutMonitorGroupDynamicRuleResponse> PutMonitorGroupDynamicRuleWithOptionsAsync(PutMonitorGroupDynamicRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutMonitorGroupDynamicRuleResponse>(await DoRPCRequestAsync("PutMonitorGroupDynamicRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutMonitorGroupDynamicRuleResponse PutMonitorGroupDynamicRule(PutMonitorGroupDynamicRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutMonitorGroupDynamicRuleWithOptions(request, runtime);
        }

        public async Task<PutMonitorGroupDynamicRuleResponse> PutMonitorGroupDynamicRuleAsync(PutMonitorGroupDynamicRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutMonitorGroupDynamicRuleWithOptionsAsync(request, runtime);
        }

        public PutMonitoringConfigResponse PutMonitoringConfigWithOptions(PutMonitoringConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutMonitoringConfigResponse>(DoRPCRequest("PutMonitoringConfig", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutMonitoringConfigResponse> PutMonitoringConfigWithOptionsAsync(PutMonitoringConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutMonitoringConfigResponse>(await DoRPCRequestAsync("PutMonitoringConfig", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutMonitoringConfigResponse PutMonitoringConfig(PutMonitoringConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutMonitoringConfigWithOptions(request, runtime);
        }

        public async Task<PutMonitoringConfigResponse> PutMonitoringConfigAsync(PutMonitoringConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutMonitoringConfigWithOptionsAsync(request, runtime);
        }

        public PutResourceMetricRuleResponse PutResourceMetricRuleWithOptions(PutResourceMetricRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutResourceMetricRuleResponse>(DoRPCRequest("PutResourceMetricRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutResourceMetricRuleResponse> PutResourceMetricRuleWithOptionsAsync(PutResourceMetricRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutResourceMetricRuleResponse>(await DoRPCRequestAsync("PutResourceMetricRule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutResourceMetricRuleResponse PutResourceMetricRule(PutResourceMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutResourceMetricRuleWithOptions(request, runtime);
        }

        public async Task<PutResourceMetricRuleResponse> PutResourceMetricRuleAsync(PutResourceMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutResourceMetricRuleWithOptionsAsync(request, runtime);
        }

        public PutResourceMetricRulesResponse PutResourceMetricRulesWithOptions(PutResourceMetricRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutResourceMetricRulesResponse>(DoRPCRequest("PutResourceMetricRules", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutResourceMetricRulesResponse> PutResourceMetricRulesWithOptionsAsync(PutResourceMetricRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutResourceMetricRulesResponse>(await DoRPCRequestAsync("PutResourceMetricRules", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutResourceMetricRulesResponse PutResourceMetricRules(PutResourceMetricRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutResourceMetricRulesWithOptions(request, runtime);
        }

        public async Task<PutResourceMetricRulesResponse> PutResourceMetricRulesAsync(PutResourceMetricRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutResourceMetricRulesWithOptionsAsync(request, runtime);
        }

        public RemoveTagsResponse RemoveTagsWithOptions(RemoveTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveTagsResponse>(DoRPCRequest("RemoveTags", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveTagsResponse> RemoveTagsWithOptionsAsync(RemoveTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveTagsResponse>(await DoRPCRequestAsync("RemoveTags", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveTagsWithOptions(request, runtime);
        }

        public async Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveTagsWithOptionsAsync(request, runtime);
        }

        public SendDryRunSystemEventResponse SendDryRunSystemEventWithOptions(SendDryRunSystemEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendDryRunSystemEventResponse>(DoRPCRequest("SendDryRunSystemEvent", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendDryRunSystemEventResponse> SendDryRunSystemEventWithOptionsAsync(SendDryRunSystemEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendDryRunSystemEventResponse>(await DoRPCRequestAsync("SendDryRunSystemEvent", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendDryRunSystemEventResponse SendDryRunSystemEvent(SendDryRunSystemEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendDryRunSystemEventWithOptions(request, runtime);
        }

        public async Task<SendDryRunSystemEventResponse> SendDryRunSystemEventAsync(SendDryRunSystemEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendDryRunSystemEventWithOptionsAsync(request, runtime);
        }

        public UninstallMonitoringAgentResponse UninstallMonitoringAgentWithOptions(UninstallMonitoringAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UninstallMonitoringAgentResponse>(DoRPCRequest("UninstallMonitoringAgent", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UninstallMonitoringAgentResponse> UninstallMonitoringAgentWithOptionsAsync(UninstallMonitoringAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UninstallMonitoringAgentResponse>(await DoRPCRequestAsync("UninstallMonitoringAgent", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UninstallMonitoringAgentResponse UninstallMonitoringAgent(UninstallMonitoringAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UninstallMonitoringAgentWithOptions(request, runtime);
        }

        public async Task<UninstallMonitoringAgentResponse> UninstallMonitoringAgentAsync(UninstallMonitoringAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UninstallMonitoringAgentWithOptionsAsync(request, runtime);
        }

    }
}
