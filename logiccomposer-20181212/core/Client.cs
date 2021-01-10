// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Logiccomposer20181212.Models;

namespace AlibabaCloud.SDK.Logiccomposer20181212
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("logiccomposer", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AbolishFlowResponse AbolishFlowWithOptions(AbolishFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AbolishFlowResponse>(DoRPCRequest("AbolishFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AbolishFlowResponse> AbolishFlowWithOptionsAsync(AbolishFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AbolishFlowResponse>(await DoRPCRequestAsync("AbolishFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AbolishFlowResponse AbolishFlow(AbolishFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AbolishFlowWithOptions(request, runtime);
        }

        public async Task<AbolishFlowResponse> AbolishFlowAsync(AbolishFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AbolishFlowWithOptionsAsync(request, runtime);
        }

        public CloneFlowResponse CloneFlowWithOptions(CloneFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloneFlowResponse>(DoRPCRequest("CloneFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CloneFlowResponse> CloneFlowWithOptionsAsync(CloneFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloneFlowResponse>(await DoRPCRequestAsync("CloneFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CloneFlowResponse CloneFlow(CloneFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloneFlowWithOptions(request, runtime);
        }

        public async Task<CloneFlowResponse> CloneFlowAsync(CloneFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloneFlowWithOptionsAsync(request, runtime);
        }

        public CreateFlowResponse CreateFlowWithOptions(CreateFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowResponse>(DoRPCRequest("CreateFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFlowResponse> CreateFlowWithOptionsAsync(CreateFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowResponse>(await DoRPCRequestAsync("CreateFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFlowResponse CreateFlow(CreateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowWithOptions(request, runtime);
        }

        public async Task<CreateFlowResponse> CreateFlowAsync(CreateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowWithOptionsAsync(request, runtime);
        }

        public DeleteFlowResponse DeleteFlowWithOptions(DeleteFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowResponse>(DoRPCRequest("DeleteFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFlowResponse> DeleteFlowWithOptionsAsync(DeleteFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowResponse>(await DoRPCRequestAsync("DeleteFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFlowResponse DeleteFlow(DeleteFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowWithOptions(request, runtime);
        }

        public async Task<DeleteFlowResponse> DeleteFlowAsync(DeleteFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowWithOptionsAsync(request, runtime);
        }

        public DeployFlowResponse DeployFlowWithOptions(DeployFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeployFlowResponse>(DoRPCRequest("DeployFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeployFlowResponse> DeployFlowWithOptionsAsync(DeployFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeployFlowResponse>(await DoRPCRequestAsync("DeployFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeployFlowResponse DeployFlow(DeployFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeployFlowWithOptions(request, runtime);
        }

        public async Task<DeployFlowResponse> DeployFlowAsync(DeployFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeployFlowWithOptionsAsync(request, runtime);
        }

        public DescribeAccountSummaryResponse DescribeAccountSummaryWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeAccountSummaryResponse>(DoRPCRequest("DescribeAccountSummary", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAccountSummaryResponse> DescribeAccountSummaryWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeAccountSummaryResponse>(await DoRPCRequestAsync("DescribeAccountSummary", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAccountSummaryResponse DescribeAccountSummary()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccountSummaryWithOptions(runtime);
        }

        public async Task<DescribeAccountSummaryResponse> DescribeAccountSummaryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccountSummaryWithOptionsAsync(runtime);
        }

        public DescribeConnectorAttributeResponse DescribeConnectorAttributeWithOptions(DescribeConnectorAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeConnectorAttributeResponse>(DoRPCRequest("DescribeConnectorAttribute", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeConnectorAttributeResponse> DescribeConnectorAttributeWithOptionsAsync(DescribeConnectorAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeConnectorAttributeResponse>(await DoRPCRequestAsync("DescribeConnectorAttribute", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeConnectorAttributeResponse DescribeConnectorAttribute(DescribeConnectorAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeConnectorAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeConnectorAttributeResponse> DescribeConnectorAttributeAsync(DescribeConnectorAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeConnectorAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeConnectorCapabilityResponse DescribeConnectorCapabilityWithOptions(DescribeConnectorCapabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeConnectorCapabilityResponse>(DoRPCRequest("DescribeConnectorCapability", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeConnectorCapabilityResponse> DescribeConnectorCapabilityWithOptionsAsync(DescribeConnectorCapabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeConnectorCapabilityResponse>(await DoRPCRequestAsync("DescribeConnectorCapability", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeConnectorCapabilityResponse DescribeConnectorCapability(DescribeConnectorCapabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeConnectorCapabilityWithOptions(request, runtime);
        }

        public async Task<DescribeConnectorCapabilityResponse> DescribeConnectorCapabilityAsync(DescribeConnectorCapabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeConnectorCapabilityWithOptionsAsync(request, runtime);
        }

        public DescribeFlowResponse DescribeFlowWithOptions(DescribeFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowResponse>(DoRPCRequest("DescribeFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowResponse> DescribeFlowWithOptionsAsync(DescribeFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowResponse>(await DoRPCRequestAsync("DescribeFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlowResponse DescribeFlow(DescribeFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowWithOptions(request, runtime);
        }

        public async Task<DescribeFlowResponse> DescribeFlowAsync(DescribeFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowWithOptionsAsync(request, runtime);
        }

        public DescribeFlowMetricResponse DescribeFlowMetricWithOptions(DescribeFlowMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowMetricResponse>(DoRPCRequest("DescribeFlowMetric", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowMetricResponse> DescribeFlowMetricWithOptionsAsync(DescribeFlowMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowMetricResponse>(await DoRPCRequestAsync("DescribeFlowMetric", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlowMetricResponse DescribeFlowMetric(DescribeFlowMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowMetricWithOptions(request, runtime);
        }

        public async Task<DescribeFlowMetricResponse> DescribeFlowMetricAsync(DescribeFlowMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowMetricWithOptionsAsync(request, runtime);
        }

        public DescribeFlowTemplateResponse DescribeFlowTemplateWithOptions(DescribeFlowTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowTemplateResponse>(DoRPCRequest("DescribeFlowTemplate", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowTemplateResponse> DescribeFlowTemplateWithOptionsAsync(DescribeFlowTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowTemplateResponse>(await DoRPCRequestAsync("DescribeFlowTemplate", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlowTemplateResponse DescribeFlowTemplate(DescribeFlowTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowTemplateWithOptions(request, runtime);
        }

        public async Task<DescribeFlowTemplateResponse> DescribeFlowTemplateAsync(DescribeFlowTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowTemplateWithOptionsAsync(request, runtime);
        }

        public DescribeInvocationLogResponse DescribeInvocationLogWithOptions(DescribeInvocationLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInvocationLogResponse>(DoRPCRequest("DescribeInvocationLog", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInvocationLogResponse> DescribeInvocationLogWithOptionsAsync(DescribeInvocationLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInvocationLogResponse>(await DoRPCRequestAsync("DescribeInvocationLog", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInvocationLogResponse DescribeInvocationLog(DescribeInvocationLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInvocationLogWithOptions(request, runtime);
        }

        public async Task<DescribeInvocationLogResponse> DescribeInvocationLogAsync(DescribeInvocationLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInvocationLogWithOptionsAsync(request, runtime);
        }

        public DescribeMetricDetailResponse DescribeMetricDetailWithOptions(DescribeMetricDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetricDetailResponse>(DoRPCRequest("DescribeMetricDetail", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMetricDetailResponse> DescribeMetricDetailWithOptionsAsync(DescribeMetricDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetricDetailResponse>(await DoRPCRequestAsync("DescribeMetricDetail", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMetricDetailResponse DescribeMetricDetail(DescribeMetricDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricDetailWithOptions(request, runtime);
        }

        public async Task<DescribeMetricDetailResponse> DescribeMetricDetailAsync(DescribeMetricDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricDetailWithOptionsAsync(request, runtime);
        }

        public DisableFlowResponse DisableFlowWithOptions(DisableFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableFlowResponse>(DoRPCRequest("DisableFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableFlowResponse> DisableFlowWithOptionsAsync(DisableFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableFlowResponse>(await DoRPCRequestAsync("DisableFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableFlowResponse DisableFlow(DisableFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableFlowWithOptions(request, runtime);
        }

        public async Task<DisableFlowResponse> DisableFlowAsync(DisableFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableFlowWithOptionsAsync(request, runtime);
        }

        public EnableFlowResponse EnableFlowWithOptions(EnableFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableFlowResponse>(DoRPCRequest("EnableFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableFlowResponse> EnableFlowWithOptionsAsync(EnableFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableFlowResponse>(await DoRPCRequestAsync("EnableFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableFlowResponse EnableFlow(EnableFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableFlowWithOptions(request, runtime);
        }

        public async Task<EnableFlowResponse> EnableFlowAsync(EnableFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableFlowWithOptionsAsync(request, runtime);
        }

        public InvokeFlowResponse InvokeFlowWithOptions(InvokeFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InvokeFlowResponse>(DoRPCRequest("InvokeFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InvokeFlowResponse> InvokeFlowWithOptionsAsync(InvokeFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InvokeFlowResponse>(await DoRPCRequestAsync("InvokeFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InvokeFlowResponse InvokeFlow(InvokeFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InvokeFlowWithOptions(request, runtime);
        }

        public async Task<InvokeFlowResponse> InvokeFlowAsync(InvokeFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InvokeFlowWithOptionsAsync(request, runtime);
        }

        public ListConnectorsResponse ListConnectorsWithOptions(ListConnectorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListConnectorsResponse>(DoRPCRequest("ListConnectors", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListConnectorsResponse> ListConnectorsWithOptionsAsync(ListConnectorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListConnectorsResponse>(await DoRPCRequestAsync("ListConnectors", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListConnectorsResponse ListConnectors(ListConnectorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConnectorsWithOptions(request, runtime);
        }

        public async Task<ListConnectorsResponse> ListConnectorsAsync(ListConnectorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConnectorsWithOptionsAsync(request, runtime);
        }

        public ListConnectorTriggersResponse ListConnectorTriggersWithOptions(ListConnectorTriggersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListConnectorTriggersResponse>(DoRPCRequest("ListConnectorTriggers", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListConnectorTriggersResponse> ListConnectorTriggersWithOptionsAsync(ListConnectorTriggersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListConnectorTriggersResponse>(await DoRPCRequestAsync("ListConnectorTriggers", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListConnectorTriggersResponse ListConnectorTriggers(ListConnectorTriggersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConnectorTriggersWithOptions(request, runtime);
        }

        public async Task<ListConnectorTriggersResponse> ListConnectorTriggersAsync(ListConnectorTriggersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConnectorTriggersWithOptionsAsync(request, runtime);
        }

        public ListFlowResponse ListFlowWithOptions(ListFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowResponse>(DoRPCRequest("ListFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowResponse> ListFlowWithOptionsAsync(ListFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowResponse>(await DoRPCRequestAsync("ListFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowResponse ListFlow(ListFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowWithOptions(request, runtime);
        }

        public async Task<ListFlowResponse> ListFlowAsync(ListFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowWithOptionsAsync(request, runtime);
        }

        public ListFlowConnectionsResponse ListFlowConnectionsWithOptions(ListFlowConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowConnectionsResponse>(DoRPCRequest("ListFlowConnections", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowConnectionsResponse> ListFlowConnectionsWithOptionsAsync(ListFlowConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowConnectionsResponse>(await DoRPCRequestAsync("ListFlowConnections", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowConnectionsResponse ListFlowConnections(ListFlowConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowConnectionsWithOptions(request, runtime);
        }

        public async Task<ListFlowConnectionsResponse> ListFlowConnectionsAsync(ListFlowConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowConnectionsWithOptionsAsync(request, runtime);
        }

        public ListFlowTemplateResponse ListFlowTemplateWithOptions(ListFlowTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowTemplateResponse>(DoRPCRequest("ListFlowTemplate", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowTemplateResponse> ListFlowTemplateWithOptionsAsync(ListFlowTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowTemplateResponse>(await DoRPCRequestAsync("ListFlowTemplate", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowTemplateResponse ListFlowTemplate(ListFlowTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowTemplateWithOptions(request, runtime);
        }

        public async Task<ListFlowTemplateResponse> ListFlowTemplateAsync(ListFlowTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowTemplateWithOptionsAsync(request, runtime);
        }

        public ListFlowTriggersResponse ListFlowTriggersWithOptions(ListFlowTriggersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowTriggersResponse>(DoRPCRequest("ListFlowTriggers", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowTriggersResponse> ListFlowTriggersWithOptionsAsync(ListFlowTriggersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowTriggersResponse>(await DoRPCRequestAsync("ListFlowTriggers", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowTriggersResponse ListFlowTriggers(ListFlowTriggersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowTriggersWithOptions(request, runtime);
        }

        public async Task<ListFlowTriggersResponse> ListFlowTriggersAsync(ListFlowTriggersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowTriggersWithOptionsAsync(request, runtime);
        }

        public ListFlowVersionResponse ListFlowVersionWithOptions(ListFlowVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowVersionResponse>(DoRPCRequest("ListFlowVersion", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowVersionResponse> ListFlowVersionWithOptionsAsync(ListFlowVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowVersionResponse>(await DoRPCRequestAsync("ListFlowVersion", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowVersionResponse ListFlowVersion(ListFlowVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowVersionWithOptions(request, runtime);
        }

        public async Task<ListFlowVersionResponse> ListFlowVersionAsync(ListFlowVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowVersionWithOptionsAsync(request, runtime);
        }

        public ListInvocationLogsResponse ListInvocationLogsWithOptions(ListInvocationLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInvocationLogsResponse>(DoRPCRequest("ListInvocationLogs", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListInvocationLogsResponse> ListInvocationLogsWithOptionsAsync(ListInvocationLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInvocationLogsResponse>(await DoRPCRequestAsync("ListInvocationLogs", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListInvocationLogsResponse ListInvocationLogs(ListInvocationLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInvocationLogsWithOptions(request, runtime);
        }

        public async Task<ListInvocationLogsResponse> ListInvocationLogsAsync(ListInvocationLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInvocationLogsWithOptionsAsync(request, runtime);
        }

        public ListTagResponse ListTagWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListTagResponse>(DoRPCRequest("ListTag", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagResponse> ListTagWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListTagResponse>(await DoRPCRequestAsync("ListTag", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTagResponse ListTag()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagWithOptions(runtime);
        }

        public async Task<ListTagResponse> ListTagAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagWithOptionsAsync(runtime);
        }

        public ModifyFlowResponse ModifyFlowWithOptions(ModifyFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowResponse>(DoRPCRequest("ModifyFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyFlowResponse> ModifyFlowWithOptionsAsync(ModifyFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowResponse>(await DoRPCRequestAsync("ModifyFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyFlowResponse ModifyFlow(ModifyFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFlowWithOptions(request, runtime);
        }

        public async Task<ModifyFlowResponse> ModifyFlowAsync(ModifyFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFlowWithOptionsAsync(request, runtime);
        }

        public RollBackFlowResponse RollBackFlowWithOptions(RollBackFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RollBackFlowResponse>(DoRPCRequest("RollBackFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RollBackFlowResponse> RollBackFlowWithOptionsAsync(RollBackFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RollBackFlowResponse>(await DoRPCRequestAsync("RollBackFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RollBackFlowResponse RollBackFlow(RollBackFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RollBackFlowWithOptions(request, runtime);
        }

        public async Task<RollBackFlowResponse> RollBackFlowAsync(RollBackFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RollBackFlowWithOptionsAsync(request, runtime);
        }

        public UpdateConnectionResponse UpdateConnectionWithOptions(UpdateConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateConnectionResponse>(DoRPCRequest("UpdateConnection", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateConnectionResponse> UpdateConnectionWithOptionsAsync(UpdateConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateConnectionResponse>(await DoRPCRequestAsync("UpdateConnection", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateConnectionResponse UpdateConnection(UpdateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateConnectionWithOptions(request, runtime);
        }

        public async Task<UpdateConnectionResponse> UpdateConnectionAsync(UpdateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateConnectionWithOptionsAsync(request, runtime);
        }

    }
}
