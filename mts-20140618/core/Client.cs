// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Mts20140618.Models;

namespace AlibabaCloud.SDK.Mts20140618
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-2-pop", "mts.ap-northeast-1.aliyuncs.com"},
                {"ap-southeast-2", "mts.ap-northeast-1.aliyuncs.com"},
                {"ap-southeast-3", "mts.ap-northeast-1.aliyuncs.com"},
                {"cn-beijing-finance-1", "mts.aliyuncs.com"},
                {"cn-beijing-finance-pop", "mts.aliyuncs.com"},
                {"cn-beijing-gov-1", "mts.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "mts.aliyuncs.com"},
                {"cn-chengdu", "mts.aliyuncs.com"},
                {"cn-edge-1", "mts.aliyuncs.com"},
                {"cn-fujian", "mts.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "mts.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "mts.aliyuncs.com"},
                {"cn-hangzhou-finance", "mts.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "mts.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "mts.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "mts.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "mts.aliyuncs.com"},
                {"cn-hangzhou-test-306", "mts.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "mts.aliyuncs.com"},
                {"cn-north-2-gov-1", "mts.aliyuncs.com"},
                {"cn-qingdao", "mts.aliyuncs.com"},
                {"cn-qingdao-nebula", "mts.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "mts.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "mts.aliyuncs.com"},
                {"cn-shanghai-finance-1", "mts.aliyuncs.com"},
                {"cn-shanghai-inner", "mts.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "mts.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "mts.aliyuncs.com"},
                {"cn-shenzhen-inner", "mts.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "mts.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "mts.aliyuncs.com"},
                {"cn-wuhan", "mts.aliyuncs.com"},
                {"cn-yushanfang", "mts.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "mts.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "mts.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "mts.aliyuncs.com"},
                {"eu-west-1-oxs", "mts.ap-northeast-1.aliyuncs.com"},
                {"me-east-1", "mts.ap-northeast-1.aliyuncs.com"},
                {"rus-west-1-pop", "mts.ap-northeast-1.aliyuncs.com"},
                {"us-east-1", "mts.ap-northeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("mts", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ActivateMediaWorkflowResponse ActivateMediaWorkflowWithOptions(ActivateMediaWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActivateMediaWorkflowResponse>(DoRPCRequest("ActivateMediaWorkflow", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ActivateMediaWorkflowResponse> ActivateMediaWorkflowWithOptionsAsync(ActivateMediaWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActivateMediaWorkflowResponse>(await DoRPCRequestAsync("ActivateMediaWorkflow", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ActivateMediaWorkflowResponse ActivateMediaWorkflow(ActivateMediaWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActivateMediaWorkflowWithOptions(request, runtime);
        }

        public async Task<ActivateMediaWorkflowResponse> ActivateMediaWorkflowAsync(ActivateMediaWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActivateMediaWorkflowWithOptionsAsync(request, runtime);
        }

        public AddAsrPipelineResponse AddAsrPipelineWithOptions(AddAsrPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddAsrPipelineResponse>(DoRPCRequest("AddAsrPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddAsrPipelineResponse> AddAsrPipelineWithOptionsAsync(AddAsrPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddAsrPipelineResponse>(await DoRPCRequestAsync("AddAsrPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddAsrPipelineResponse AddAsrPipeline(AddAsrPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAsrPipelineWithOptions(request, runtime);
        }

        public async Task<AddAsrPipelineResponse> AddAsrPipelineAsync(AddAsrPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAsrPipelineWithOptionsAsync(request, runtime);
        }

        public AddCategoryResponse AddCategoryWithOptions(AddCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCategoryResponse>(DoRPCRequest("AddCategory", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddCategoryResponse> AddCategoryWithOptionsAsync(AddCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCategoryResponse>(await DoRPCRequestAsync("AddCategory", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddCategoryResponse AddCategory(AddCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCategoryWithOptions(request, runtime);
        }

        public async Task<AddCategoryResponse> AddCategoryAsync(AddCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCategoryWithOptionsAsync(request, runtime);
        }

        public AddCensorPipelineResponse AddCensorPipelineWithOptions(AddCensorPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCensorPipelineResponse>(DoRPCRequest("AddCensorPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddCensorPipelineResponse> AddCensorPipelineWithOptionsAsync(AddCensorPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCensorPipelineResponse>(await DoRPCRequestAsync("AddCensorPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddCensorPipelineResponse AddCensorPipeline(AddCensorPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCensorPipelineWithOptions(request, runtime);
        }

        public async Task<AddCensorPipelineResponse> AddCensorPipelineAsync(AddCensorPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCensorPipelineWithOptionsAsync(request, runtime);
        }

        public AddCoverPipelineResponse AddCoverPipelineWithOptions(AddCoverPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCoverPipelineResponse>(DoRPCRequest("AddCoverPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddCoverPipelineResponse> AddCoverPipelineWithOptionsAsync(AddCoverPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCoverPipelineResponse>(await DoRPCRequestAsync("AddCoverPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddCoverPipelineResponse AddCoverPipeline(AddCoverPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCoverPipelineWithOptions(request, runtime);
        }

        public async Task<AddCoverPipelineResponse> AddCoverPipelineAsync(AddCoverPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCoverPipelineWithOptionsAsync(request, runtime);
        }

        public AddMCTemplateResponse AddMCTemplateWithOptions(AddMCTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddMCTemplateResponse>(DoRPCRequest("AddMCTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddMCTemplateResponse> AddMCTemplateWithOptionsAsync(AddMCTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddMCTemplateResponse>(await DoRPCRequestAsync("AddMCTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddMCTemplateResponse AddMCTemplate(AddMCTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddMCTemplateWithOptions(request, runtime);
        }

        public async Task<AddMCTemplateResponse> AddMCTemplateAsync(AddMCTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddMCTemplateWithOptionsAsync(request, runtime);
        }

        public AddMediaResponse AddMediaWithOptions(AddMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddMediaResponse>(DoRPCRequest("AddMedia", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddMediaResponse> AddMediaWithOptionsAsync(AddMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddMediaResponse>(await DoRPCRequestAsync("AddMedia", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddMediaResponse AddMedia(AddMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddMediaWithOptions(request, runtime);
        }

        public async Task<AddMediaResponse> AddMediaAsync(AddMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddMediaWithOptionsAsync(request, runtime);
        }

        public AddMediaTagResponse AddMediaTagWithOptions(AddMediaTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddMediaTagResponse>(DoRPCRequest("AddMediaTag", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddMediaTagResponse> AddMediaTagWithOptionsAsync(AddMediaTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddMediaTagResponse>(await DoRPCRequestAsync("AddMediaTag", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddMediaTagResponse AddMediaTag(AddMediaTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddMediaTagWithOptions(request, runtime);
        }

        public async Task<AddMediaTagResponse> AddMediaTagAsync(AddMediaTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddMediaTagWithOptionsAsync(request, runtime);
        }

        public AddMediaWorkflowResponse AddMediaWorkflowWithOptions(AddMediaWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddMediaWorkflowResponse>(DoRPCRequest("AddMediaWorkflow", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddMediaWorkflowResponse> AddMediaWorkflowWithOptionsAsync(AddMediaWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddMediaWorkflowResponse>(await DoRPCRequestAsync("AddMediaWorkflow", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddMediaWorkflowResponse AddMediaWorkflow(AddMediaWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddMediaWorkflowWithOptions(request, runtime);
        }

        public async Task<AddMediaWorkflowResponse> AddMediaWorkflowAsync(AddMediaWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddMediaWorkflowWithOptionsAsync(request, runtime);
        }

        public AddPipelineResponse AddPipelineWithOptions(AddPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddPipelineResponse>(DoRPCRequest("AddPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddPipelineResponse> AddPipelineWithOptionsAsync(AddPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddPipelineResponse>(await DoRPCRequestAsync("AddPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddPipelineResponse AddPipeline(AddPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddPipelineWithOptions(request, runtime);
        }

        public async Task<AddPipelineResponse> AddPipelineAsync(AddPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddPipelineWithOptionsAsync(request, runtime);
        }

        public AddPornPipelineResponse AddPornPipelineWithOptions(AddPornPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddPornPipelineResponse>(DoRPCRequest("AddPornPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddPornPipelineResponse> AddPornPipelineWithOptionsAsync(AddPornPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddPornPipelineResponse>(await DoRPCRequestAsync("AddPornPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddPornPipelineResponse AddPornPipeline(AddPornPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddPornPipelineWithOptions(request, runtime);
        }

        public async Task<AddPornPipelineResponse> AddPornPipelineAsync(AddPornPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddPornPipelineWithOptionsAsync(request, runtime);
        }

        public AddSmarttagTemplateResponse AddSmarttagTemplateWithOptions(AddSmarttagTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSmarttagTemplateResponse>(DoRPCRequest("AddSmarttagTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddSmarttagTemplateResponse> AddSmarttagTemplateWithOptionsAsync(AddSmarttagTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSmarttagTemplateResponse>(await DoRPCRequestAsync("AddSmarttagTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddSmarttagTemplateResponse AddSmarttagTemplate(AddSmarttagTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSmarttagTemplateWithOptions(request, runtime);
        }

        public async Task<AddSmarttagTemplateResponse> AddSmarttagTemplateAsync(AddSmarttagTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSmarttagTemplateWithOptionsAsync(request, runtime);
        }

        public AddTemplateResponse AddTemplateWithOptions(AddTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddTemplateResponse>(DoRPCRequest("AddTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddTemplateResponse> AddTemplateWithOptionsAsync(AddTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddTemplateResponse>(await DoRPCRequestAsync("AddTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddTemplateResponse AddTemplate(AddTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTemplateWithOptions(request, runtime);
        }

        public async Task<AddTemplateResponse> AddTemplateAsync(AddTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTemplateWithOptionsAsync(request, runtime);
        }

        public AddTerrorismPipelineResponse AddTerrorismPipelineWithOptions(AddTerrorismPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddTerrorismPipelineResponse>(DoRPCRequest("AddTerrorismPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddTerrorismPipelineResponse> AddTerrorismPipelineWithOptionsAsync(AddTerrorismPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddTerrorismPipelineResponse>(await DoRPCRequestAsync("AddTerrorismPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddTerrorismPipelineResponse AddTerrorismPipeline(AddTerrorismPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTerrorismPipelineWithOptions(request, runtime);
        }

        public async Task<AddTerrorismPipelineResponse> AddTerrorismPipelineAsync(AddTerrorismPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTerrorismPipelineWithOptionsAsync(request, runtime);
        }

        public AddWaterMarkTemplateResponse AddWaterMarkTemplateWithOptions(AddWaterMarkTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddWaterMarkTemplateResponse>(DoRPCRequest("AddWaterMarkTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddWaterMarkTemplateResponse> AddWaterMarkTemplateWithOptionsAsync(AddWaterMarkTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddWaterMarkTemplateResponse>(await DoRPCRequestAsync("AddWaterMarkTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddWaterMarkTemplateResponse AddWaterMarkTemplate(AddWaterMarkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddWaterMarkTemplateWithOptions(request, runtime);
        }

        public async Task<AddWaterMarkTemplateResponse> AddWaterMarkTemplateAsync(AddWaterMarkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddWaterMarkTemplateWithOptionsAsync(request, runtime);
        }

        public BindInputBucketResponse BindInputBucketWithOptions(BindInputBucketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindInputBucketResponse>(DoRPCRequest("BindInputBucket", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindInputBucketResponse> BindInputBucketWithOptionsAsync(BindInputBucketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindInputBucketResponse>(await DoRPCRequestAsync("BindInputBucket", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindInputBucketResponse BindInputBucket(BindInputBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindInputBucketWithOptions(request, runtime);
        }

        public async Task<BindInputBucketResponse> BindInputBucketAsync(BindInputBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindInputBucketWithOptionsAsync(request, runtime);
        }

        public BindOutputBucketResponse BindOutputBucketWithOptions(BindOutputBucketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindOutputBucketResponse>(DoRPCRequest("BindOutputBucket", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindOutputBucketResponse> BindOutputBucketWithOptionsAsync(BindOutputBucketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindOutputBucketResponse>(await DoRPCRequestAsync("BindOutputBucket", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindOutputBucketResponse BindOutputBucket(BindOutputBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindOutputBucketWithOptions(request, runtime);
        }

        public async Task<BindOutputBucketResponse> BindOutputBucketAsync(BindOutputBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindOutputBucketWithOptionsAsync(request, runtime);
        }

        public CancelJobResponse CancelJobWithOptions(CancelJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelJobResponse>(DoRPCRequest("CancelJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelJobResponse> CancelJobWithOptionsAsync(CancelJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelJobResponse>(await DoRPCRequestAsync("CancelJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelJobResponse CancelJob(CancelJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelJobWithOptions(request, runtime);
        }

        public async Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelJobWithOptionsAsync(request, runtime);
        }

        public CategoryTreeResponse CategoryTreeWithOptions(CategoryTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CategoryTreeResponse>(DoRPCRequest("CategoryTree", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CategoryTreeResponse> CategoryTreeWithOptionsAsync(CategoryTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CategoryTreeResponse>(await DoRPCRequestAsync("CategoryTree", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CategoryTreeResponse CategoryTree(CategoryTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CategoryTreeWithOptions(request, runtime);
        }

        public async Task<CategoryTreeResponse> CategoryTreeAsync(CategoryTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CategoryTreeWithOptionsAsync(request, runtime);
        }

        public CheckResourceResponse CheckResourceWithOptions(CheckResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckResourceResponse>(DoRPCRequest("CheckResource", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckResourceResponse> CheckResourceWithOptionsAsync(CheckResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckResourceResponse>(await DoRPCRequestAsync("CheckResource", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckResourceResponse CheckResource(CheckResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckResourceWithOptions(request, runtime);
        }

        public async Task<CheckResourceResponse> CheckResourceAsync(CheckResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckResourceWithOptionsAsync(request, runtime);
        }

        public CreateFpShotDBResponse CreateFpShotDBWithOptions(CreateFpShotDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFpShotDBResponse>(DoRPCRequest("CreateFpShotDB", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFpShotDBResponse> CreateFpShotDBWithOptionsAsync(CreateFpShotDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFpShotDBResponse>(await DoRPCRequestAsync("CreateFpShotDB", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFpShotDBResponse CreateFpShotDB(CreateFpShotDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFpShotDBWithOptions(request, runtime);
        }

        public async Task<CreateFpShotDBResponse> CreateFpShotDBAsync(CreateFpShotDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFpShotDBWithOptionsAsync(request, runtime);
        }

        public CreateMcuTemplateResponse CreateMcuTemplateWithOptions(CreateMcuTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMcuTemplateResponse>(DoRPCRequest("CreateMcuTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMcuTemplateResponse> CreateMcuTemplateWithOptionsAsync(CreateMcuTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMcuTemplateResponse>(await DoRPCRequestAsync("CreateMcuTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMcuTemplateResponse CreateMcuTemplate(CreateMcuTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcuTemplateWithOptions(request, runtime);
        }

        public async Task<CreateMcuTemplateResponse> CreateMcuTemplateAsync(CreateMcuTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcuTemplateWithOptionsAsync(request, runtime);
        }

        public CreateSessionResponse CreateSessionWithOptions(CreateSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSessionResponse>(DoRPCRequest("CreateSession", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSessionResponse> CreateSessionWithOptionsAsync(CreateSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSessionResponse>(await DoRPCRequestAsync("CreateSession", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSessionResponse CreateSession(CreateSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSessionWithOptions(request, runtime);
        }

        public async Task<CreateSessionResponse> CreateSessionAsync(CreateSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSessionWithOptionsAsync(request, runtime);
        }

        public DeactivateMediaWorkflowResponse DeactivateMediaWorkflowWithOptions(DeactivateMediaWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeactivateMediaWorkflowResponse>(DoRPCRequest("DeactivateMediaWorkflow", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeactivateMediaWorkflowResponse> DeactivateMediaWorkflowWithOptionsAsync(DeactivateMediaWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeactivateMediaWorkflowResponse>(await DoRPCRequestAsync("DeactivateMediaWorkflow", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeactivateMediaWorkflowResponse DeactivateMediaWorkflow(DeactivateMediaWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeactivateMediaWorkflowWithOptions(request, runtime);
        }

        public async Task<DeactivateMediaWorkflowResponse> DeactivateMediaWorkflowAsync(DeactivateMediaWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeactivateMediaWorkflowWithOptionsAsync(request, runtime);
        }

        public DecryptKeyResponse DecryptKeyWithOptions(DecryptKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DecryptKeyResponse>(DoRPCRequest("DecryptKey", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DecryptKeyResponse> DecryptKeyWithOptionsAsync(DecryptKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DecryptKeyResponse>(await DoRPCRequestAsync("DecryptKey", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DecryptKeyResponse DecryptKey(DecryptKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DecryptKeyWithOptions(request, runtime);
        }

        public async Task<DecryptKeyResponse> DecryptKeyAsync(DecryptKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DecryptKeyWithOptionsAsync(request, runtime);
        }

        public DeleteCategoryResponse DeleteCategoryWithOptions(DeleteCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCategoryResponse>(DoRPCRequest("DeleteCategory", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCategoryResponse> DeleteCategoryWithOptionsAsync(DeleteCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCategoryResponse>(await DoRPCRequestAsync("DeleteCategory", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCategoryResponse DeleteCategory(DeleteCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCategoryWithOptions(request, runtime);
        }

        public async Task<DeleteCategoryResponse> DeleteCategoryAsync(DeleteCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCategoryWithOptionsAsync(request, runtime);
        }

        public DeleteMCTemplateResponse DeleteMCTemplateWithOptions(DeleteMCTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMCTemplateResponse>(DoRPCRequest("DeleteMCTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMCTemplateResponse> DeleteMCTemplateWithOptionsAsync(DeleteMCTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMCTemplateResponse>(await DoRPCRequestAsync("DeleteMCTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMCTemplateResponse DeleteMCTemplate(DeleteMCTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMCTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteMCTemplateResponse> DeleteMCTemplateAsync(DeleteMCTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMCTemplateWithOptionsAsync(request, runtime);
        }

        public DeleteMcuJobResponse DeleteMcuJobWithOptions(DeleteMcuJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMcuJobResponse>(DoRPCRequest("DeleteMcuJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMcuJobResponse> DeleteMcuJobWithOptionsAsync(DeleteMcuJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMcuJobResponse>(await DoRPCRequestAsync("DeleteMcuJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMcuJobResponse DeleteMcuJob(DeleteMcuJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMcuJobWithOptions(request, runtime);
        }

        public async Task<DeleteMcuJobResponse> DeleteMcuJobAsync(DeleteMcuJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMcuJobWithOptionsAsync(request, runtime);
        }

        public DeleteMcuTemplateResponse DeleteMcuTemplateWithOptions(DeleteMcuTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMcuTemplateResponse>(DoRPCRequest("DeleteMcuTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMcuTemplateResponse> DeleteMcuTemplateWithOptionsAsync(DeleteMcuTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMcuTemplateResponse>(await DoRPCRequestAsync("DeleteMcuTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMcuTemplateResponse DeleteMcuTemplate(DeleteMcuTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMcuTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteMcuTemplateResponse> DeleteMcuTemplateAsync(DeleteMcuTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMcuTemplateWithOptionsAsync(request, runtime);
        }

        public DeleteMediaResponse DeleteMediaWithOptions(DeleteMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMediaResponse>(DoRPCRequest("DeleteMedia", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMediaResponse> DeleteMediaWithOptionsAsync(DeleteMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMediaResponse>(await DoRPCRequestAsync("DeleteMedia", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMediaResponse DeleteMedia(DeleteMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMediaWithOptions(request, runtime);
        }

        public async Task<DeleteMediaResponse> DeleteMediaAsync(DeleteMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMediaWithOptionsAsync(request, runtime);
        }

        public DeleteMediaTagResponse DeleteMediaTagWithOptions(DeleteMediaTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMediaTagResponse>(DoRPCRequest("DeleteMediaTag", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMediaTagResponse> DeleteMediaTagWithOptionsAsync(DeleteMediaTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMediaTagResponse>(await DoRPCRequestAsync("DeleteMediaTag", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMediaTagResponse DeleteMediaTag(DeleteMediaTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMediaTagWithOptions(request, runtime);
        }

        public async Task<DeleteMediaTagResponse> DeleteMediaTagAsync(DeleteMediaTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMediaTagWithOptionsAsync(request, runtime);
        }

        public DeleteMediaWorkflowResponse DeleteMediaWorkflowWithOptions(DeleteMediaWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMediaWorkflowResponse>(DoRPCRequest("DeleteMediaWorkflow", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMediaWorkflowResponse> DeleteMediaWorkflowWithOptionsAsync(DeleteMediaWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMediaWorkflowResponse>(await DoRPCRequestAsync("DeleteMediaWorkflow", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMediaWorkflowResponse DeleteMediaWorkflow(DeleteMediaWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMediaWorkflowWithOptions(request, runtime);
        }

        public async Task<DeleteMediaWorkflowResponse> DeleteMediaWorkflowAsync(DeleteMediaWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMediaWorkflowWithOptionsAsync(request, runtime);
        }

        public DeletePipelineResponse DeletePipelineWithOptions(DeletePipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePipelineResponse>(DoRPCRequest("DeletePipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeletePipelineResponse> DeletePipelineWithOptionsAsync(DeletePipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePipelineResponse>(await DoRPCRequestAsync("DeletePipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeletePipelineResponse DeletePipeline(DeletePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePipelineWithOptions(request, runtime);
        }

        public async Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePipelineWithOptionsAsync(request, runtime);
        }

        public DeleteSmarttagTemplateResponse DeleteSmarttagTemplateWithOptions(DeleteSmarttagTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSmarttagTemplateResponse>(DoRPCRequest("DeleteSmarttagTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSmarttagTemplateResponse> DeleteSmarttagTemplateWithOptionsAsync(DeleteSmarttagTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSmarttagTemplateResponse>(await DoRPCRequestAsync("DeleteSmarttagTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSmarttagTemplateResponse DeleteSmarttagTemplate(DeleteSmarttagTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSmarttagTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteSmarttagTemplateResponse> DeleteSmarttagTemplateAsync(DeleteSmarttagTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSmarttagTemplateWithOptionsAsync(request, runtime);
        }

        public DeleteTemplateResponse DeleteTemplateWithOptions(DeleteTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(DoRPCRequest("DeleteTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteTemplateResponse> DeleteTemplateWithOptionsAsync(DeleteTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(await DoRPCRequestAsync("DeleteTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTemplateWithOptionsAsync(request, runtime);
        }

        public DeleteWaterMarkTemplateResponse DeleteWaterMarkTemplateWithOptions(DeleteWaterMarkTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteWaterMarkTemplateResponse>(DoRPCRequest("DeleteWaterMarkTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteWaterMarkTemplateResponse> DeleteWaterMarkTemplateWithOptionsAsync(DeleteWaterMarkTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteWaterMarkTemplateResponse>(await DoRPCRequestAsync("DeleteWaterMarkTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteWaterMarkTemplateResponse DeleteWaterMarkTemplate(DeleteWaterMarkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWaterMarkTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteWaterMarkTemplateResponse> DeleteWaterMarkTemplateAsync(DeleteWaterMarkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWaterMarkTemplateWithOptionsAsync(request, runtime);
        }

        public DescribeMtsUserResourcePackageResponse DescribeMtsUserResourcePackageWithOptions(DescribeMtsUserResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMtsUserResourcePackageResponse>(DoRPCRequest("DescribeMtsUserResourcePackage", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMtsUserResourcePackageResponse> DescribeMtsUserResourcePackageWithOptionsAsync(DescribeMtsUserResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMtsUserResourcePackageResponse>(await DoRPCRequestAsync("DescribeMtsUserResourcePackage", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMtsUserResourcePackageResponse DescribeMtsUserResourcePackage(DescribeMtsUserResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMtsUserResourcePackageWithOptions(request, runtime);
        }

        public async Task<DescribeMtsUserResourcePackageResponse> DescribeMtsUserResourcePackageAsync(DescribeMtsUserResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMtsUserResourcePackageWithOptionsAsync(request, runtime);
        }

        public GetLicenseResponse GetLicenseWithOptions(GetLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLicenseResponse>(DoRPCRequest("GetLicense", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetLicenseResponse> GetLicenseWithOptionsAsync(GetLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLicenseResponse>(await DoRPCRequestAsync("GetLicense", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetLicenseResponse GetLicense(GetLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLicenseWithOptions(request, runtime);
        }

        public async Task<GetLicenseResponse> GetLicenseAsync(GetLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLicenseWithOptionsAsync(request, runtime);
        }

        public GetPackageResponse GetPackageWithOptions(GetPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPackageResponse>(DoRPCRequest("GetPackage", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPackageResponse> GetPackageWithOptionsAsync(GetPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPackageResponse>(await DoRPCRequestAsync("GetPackage", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPackageResponse GetPackage(GetPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPackageWithOptions(request, runtime);
        }

        public async Task<GetPackageResponse> GetPackageAsync(GetPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPackageWithOptionsAsync(request, runtime);
        }

        public ListAllCategoryResponse ListAllCategoryWithOptions(ListAllCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAllCategoryResponse>(DoRPCRequest("ListAllCategory", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAllCategoryResponse> ListAllCategoryWithOptionsAsync(ListAllCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAllCategoryResponse>(await DoRPCRequestAsync("ListAllCategory", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAllCategoryResponse ListAllCategory(ListAllCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAllCategoryWithOptions(request, runtime);
        }

        public async Task<ListAllCategoryResponse> ListAllCategoryAsync(ListAllCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAllCategoryWithOptionsAsync(request, runtime);
        }

        public ListAllMediaBucketResponse ListAllMediaBucketWithOptions(ListAllMediaBucketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAllMediaBucketResponse>(DoRPCRequest("ListAllMediaBucket", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAllMediaBucketResponse> ListAllMediaBucketWithOptionsAsync(ListAllMediaBucketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAllMediaBucketResponse>(await DoRPCRequestAsync("ListAllMediaBucket", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAllMediaBucketResponse ListAllMediaBucket(ListAllMediaBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAllMediaBucketWithOptions(request, runtime);
        }

        public async Task<ListAllMediaBucketResponse> ListAllMediaBucketAsync(ListAllMediaBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAllMediaBucketWithOptionsAsync(request, runtime);
        }

        public ListAsrPipelineResponse ListAsrPipelineWithOptions(ListAsrPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAsrPipelineResponse>(DoRPCRequest("ListAsrPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAsrPipelineResponse> ListAsrPipelineWithOptionsAsync(ListAsrPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAsrPipelineResponse>(await DoRPCRequestAsync("ListAsrPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAsrPipelineResponse ListAsrPipeline(ListAsrPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAsrPipelineWithOptions(request, runtime);
        }

        public async Task<ListAsrPipelineResponse> ListAsrPipelineAsync(ListAsrPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAsrPipelineWithOptionsAsync(request, runtime);
        }

        public ListCensorPipelineResponse ListCensorPipelineWithOptions(ListCensorPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCensorPipelineResponse>(DoRPCRequest("ListCensorPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCensorPipelineResponse> ListCensorPipelineWithOptionsAsync(ListCensorPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCensorPipelineResponse>(await DoRPCRequestAsync("ListCensorPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListCensorPipelineResponse ListCensorPipeline(ListCensorPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCensorPipelineWithOptions(request, runtime);
        }

        public async Task<ListCensorPipelineResponse> ListCensorPipelineAsync(ListCensorPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCensorPipelineWithOptionsAsync(request, runtime);
        }

        public ListCoverPipelineResponse ListCoverPipelineWithOptions(ListCoverPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCoverPipelineResponse>(DoRPCRequest("ListCoverPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCoverPipelineResponse> ListCoverPipelineWithOptionsAsync(ListCoverPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCoverPipelineResponse>(await DoRPCRequestAsync("ListCoverPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListCoverPipelineResponse ListCoverPipeline(ListCoverPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCoverPipelineWithOptions(request, runtime);
        }

        public async Task<ListCoverPipelineResponse> ListCoverPipelineAsync(ListCoverPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCoverPipelineWithOptionsAsync(request, runtime);
        }

        public ListCustomPersonsResponse ListCustomPersonsWithOptions(ListCustomPersonsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCustomPersonsResponse>(DoRPCRequest("ListCustomPersons", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCustomPersonsResponse> ListCustomPersonsWithOptionsAsync(ListCustomPersonsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCustomPersonsResponse>(await DoRPCRequestAsync("ListCustomPersons", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListCustomPersonsResponse ListCustomPersons(ListCustomPersonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCustomPersonsWithOptions(request, runtime);
        }

        public async Task<ListCustomPersonsResponse> ListCustomPersonsAsync(ListCustomPersonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCustomPersonsWithOptionsAsync(request, runtime);
        }

        public ListFpShotDBResponse ListFpShotDBWithOptions(ListFpShotDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFpShotDBResponse>(DoRPCRequest("ListFpShotDB", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFpShotDBResponse> ListFpShotDBWithOptionsAsync(ListFpShotDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFpShotDBResponse>(await DoRPCRequestAsync("ListFpShotDB", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFpShotDBResponse ListFpShotDB(ListFpShotDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFpShotDBWithOptions(request, runtime);
        }

        public async Task<ListFpShotDBResponse> ListFpShotDBAsync(ListFpShotDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFpShotDBWithOptionsAsync(request, runtime);
        }

        public ListFpShotFilesResponse ListFpShotFilesWithOptions(ListFpShotFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFpShotFilesResponse>(DoRPCRequest("ListFpShotFiles", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFpShotFilesResponse> ListFpShotFilesWithOptionsAsync(ListFpShotFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFpShotFilesResponse>(await DoRPCRequestAsync("ListFpShotFiles", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFpShotFilesResponse ListFpShotFiles(ListFpShotFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFpShotFilesWithOptions(request, runtime);
        }

        public async Task<ListFpShotFilesResponse> ListFpShotFilesAsync(ListFpShotFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFpShotFilesWithOptionsAsync(request, runtime);
        }

        public ListFpShotNotaryResponse ListFpShotNotaryWithOptions(ListFpShotNotaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFpShotNotaryResponse>(DoRPCRequest("ListFpShotNotary", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFpShotNotaryResponse> ListFpShotNotaryWithOptionsAsync(ListFpShotNotaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFpShotNotaryResponse>(await DoRPCRequestAsync("ListFpShotNotary", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFpShotNotaryResponse ListFpShotNotary(ListFpShotNotaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFpShotNotaryWithOptions(request, runtime);
        }

        public async Task<ListFpShotNotaryResponse> ListFpShotNotaryAsync(ListFpShotNotaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFpShotNotaryWithOptionsAsync(request, runtime);
        }

        public ListJobResponse ListJobWithOptions(ListJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListJobResponse>(DoRPCRequest("ListJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListJobResponse> ListJobWithOptionsAsync(ListJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListJobResponse>(await DoRPCRequestAsync("ListJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListJobResponse ListJob(ListJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJobWithOptions(request, runtime);
        }

        public async Task<ListJobResponse> ListJobAsync(ListJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJobWithOptionsAsync(request, runtime);
        }

        public ListMediaResponse ListMediaWithOptions(ListMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMediaResponse>(DoRPCRequest("ListMedia", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListMediaResponse> ListMediaWithOptionsAsync(ListMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMediaResponse>(await DoRPCRequestAsync("ListMedia", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListMediaResponse ListMedia(ListMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMediaWithOptions(request, runtime);
        }

        public async Task<ListMediaResponse> ListMediaAsync(ListMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMediaWithOptionsAsync(request, runtime);
        }

        public ListMediaWorkflowExecutionsResponse ListMediaWorkflowExecutionsWithOptions(ListMediaWorkflowExecutionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMediaWorkflowExecutionsResponse>(DoRPCRequest("ListMediaWorkflowExecutions", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListMediaWorkflowExecutionsResponse> ListMediaWorkflowExecutionsWithOptionsAsync(ListMediaWorkflowExecutionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMediaWorkflowExecutionsResponse>(await DoRPCRequestAsync("ListMediaWorkflowExecutions", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListMediaWorkflowExecutionsResponse ListMediaWorkflowExecutions(ListMediaWorkflowExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMediaWorkflowExecutionsWithOptions(request, runtime);
        }

        public async Task<ListMediaWorkflowExecutionsResponse> ListMediaWorkflowExecutionsAsync(ListMediaWorkflowExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMediaWorkflowExecutionsWithOptionsAsync(request, runtime);
        }

        public ListPornPipelineResponse ListPornPipelineWithOptions(ListPornPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPornPipelineResponse>(DoRPCRequest("ListPornPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPornPipelineResponse> ListPornPipelineWithOptionsAsync(ListPornPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPornPipelineResponse>(await DoRPCRequestAsync("ListPornPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPornPipelineResponse ListPornPipeline(ListPornPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPornPipelineWithOptions(request, runtime);
        }

        public async Task<ListPornPipelineResponse> ListPornPipelineAsync(ListPornPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPornPipelineWithOptionsAsync(request, runtime);
        }

        public ListTerrorismPipelineResponse ListTerrorismPipelineWithOptions(ListTerrorismPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTerrorismPipelineResponse>(DoRPCRequest("ListTerrorismPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTerrorismPipelineResponse> ListTerrorismPipelineWithOptionsAsync(ListTerrorismPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTerrorismPipelineResponse>(await DoRPCRequestAsync("ListTerrorismPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTerrorismPipelineResponse ListTerrorismPipeline(ListTerrorismPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTerrorismPipelineWithOptions(request, runtime);
        }

        public async Task<ListTerrorismPipelineResponse> ListTerrorismPipelineAsync(ListTerrorismPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTerrorismPipelineWithOptionsAsync(request, runtime);
        }

        public LogicalDeleteResourceResponse LogicalDeleteResourceWithOptions(LogicalDeleteResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LogicalDeleteResourceResponse>(DoRPCRequest("LogicalDeleteResource", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<LogicalDeleteResourceResponse> LogicalDeleteResourceWithOptionsAsync(LogicalDeleteResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LogicalDeleteResourceResponse>(await DoRPCRequestAsync("LogicalDeleteResource", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public LogicalDeleteResourceResponse LogicalDeleteResource(LogicalDeleteResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LogicalDeleteResourceWithOptions(request, runtime);
        }

        public async Task<LogicalDeleteResourceResponse> LogicalDeleteResourceAsync(LogicalDeleteResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LogicalDeleteResourceWithOptionsAsync(request, runtime);
        }

        public PhysicalDeleteResourceResponse PhysicalDeleteResourceWithOptions(PhysicalDeleteResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PhysicalDeleteResourceResponse>(DoRPCRequest("PhysicalDeleteResource", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PhysicalDeleteResourceResponse> PhysicalDeleteResourceWithOptionsAsync(PhysicalDeleteResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PhysicalDeleteResourceResponse>(await DoRPCRequestAsync("PhysicalDeleteResource", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PhysicalDeleteResourceResponse PhysicalDeleteResource(PhysicalDeleteResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PhysicalDeleteResourceWithOptions(request, runtime);
        }

        public async Task<PhysicalDeleteResourceResponse> PhysicalDeleteResourceAsync(PhysicalDeleteResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PhysicalDeleteResourceWithOptionsAsync(request, runtime);
        }

        public PlayerAuthResponse PlayerAuthWithOptions(PlayerAuthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PlayerAuthResponse>(DoRPCRequest("PlayerAuth", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PlayerAuthResponse> PlayerAuthWithOptionsAsync(PlayerAuthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PlayerAuthResponse>(await DoRPCRequestAsync("PlayerAuth", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PlayerAuthResponse PlayerAuth(PlayerAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PlayerAuthWithOptions(request, runtime);
        }

        public async Task<PlayerAuthResponse> PlayerAuthAsync(PlayerAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PlayerAuthWithOptionsAsync(request, runtime);
        }

        public PlayInfoResponse PlayInfoWithOptions(PlayInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PlayInfoResponse>(DoRPCRequest("PlayInfo", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PlayInfoResponse> PlayInfoWithOptionsAsync(PlayInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PlayInfoResponse>(await DoRPCRequestAsync("PlayInfo", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PlayInfoResponse PlayInfo(PlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PlayInfoWithOptions(request, runtime);
        }

        public async Task<PlayInfoResponse> PlayInfoAsync(PlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PlayInfoWithOptionsAsync(request, runtime);
        }

        public QueryAnalysisJobListResponse QueryAnalysisJobListWithOptions(QueryAnalysisJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAnalysisJobListResponse>(DoRPCRequest("QueryAnalysisJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAnalysisJobListResponse> QueryAnalysisJobListWithOptionsAsync(QueryAnalysisJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAnalysisJobListResponse>(await DoRPCRequestAsync("QueryAnalysisJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAnalysisJobListResponse QueryAnalysisJobList(QueryAnalysisJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAnalysisJobListWithOptions(request, runtime);
        }

        public async Task<QueryAnalysisJobListResponse> QueryAnalysisJobListAsync(QueryAnalysisJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAnalysisJobListWithOptionsAsync(request, runtime);
        }

        public QueryAnnotationJobListResponse QueryAnnotationJobListWithOptions(QueryAnnotationJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAnnotationJobListResponse>(DoRPCRequest("QueryAnnotationJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAnnotationJobListResponse> QueryAnnotationJobListWithOptionsAsync(QueryAnnotationJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAnnotationJobListResponse>(await DoRPCRequestAsync("QueryAnnotationJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAnnotationJobListResponse QueryAnnotationJobList(QueryAnnotationJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAnnotationJobListWithOptions(request, runtime);
        }

        public async Task<QueryAnnotationJobListResponse> QueryAnnotationJobListAsync(QueryAnnotationJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAnnotationJobListWithOptionsAsync(request, runtime);
        }

        public QueryAsrJobListResponse QueryAsrJobListWithOptions(QueryAsrJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAsrJobListResponse>(DoRPCRequest("QueryAsrJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAsrJobListResponse> QueryAsrJobListWithOptionsAsync(QueryAsrJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAsrJobListResponse>(await DoRPCRequestAsync("QueryAsrJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAsrJobListResponse QueryAsrJobList(QueryAsrJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAsrJobListWithOptions(request, runtime);
        }

        public async Task<QueryAsrJobListResponse> QueryAsrJobListAsync(QueryAsrJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAsrJobListWithOptionsAsync(request, runtime);
        }

        public QueryAsrPipelineListResponse QueryAsrPipelineListWithOptions(QueryAsrPipelineListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAsrPipelineListResponse>(DoRPCRequest("QueryAsrPipelineList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAsrPipelineListResponse> QueryAsrPipelineListWithOptionsAsync(QueryAsrPipelineListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAsrPipelineListResponse>(await DoRPCRequestAsync("QueryAsrPipelineList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAsrPipelineListResponse QueryAsrPipelineList(QueryAsrPipelineListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAsrPipelineListWithOptions(request, runtime);
        }

        public async Task<QueryAsrPipelineListResponse> QueryAsrPipelineListAsync(QueryAsrPipelineListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAsrPipelineListWithOptionsAsync(request, runtime);
        }

        public QueryAuthConfigResponse QueryAuthConfigWithOptions(QueryAuthConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAuthConfigResponse>(DoRPCRequest("QueryAuthConfig", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAuthConfigResponse> QueryAuthConfigWithOptionsAsync(QueryAuthConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAuthConfigResponse>(await DoRPCRequestAsync("QueryAuthConfig", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAuthConfigResponse QueryAuthConfig(QueryAuthConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAuthConfigWithOptions(request, runtime);
        }

        public async Task<QueryAuthConfigResponse> QueryAuthConfigAsync(QueryAuthConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAuthConfigWithOptionsAsync(request, runtime);
        }

        public QueryCensorJobListResponse QueryCensorJobListWithOptions(QueryCensorJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCensorJobListResponse>(DoRPCRequest("QueryCensorJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryCensorJobListResponse> QueryCensorJobListWithOptionsAsync(QueryCensorJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCensorJobListResponse>(await DoRPCRequestAsync("QueryCensorJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryCensorJobListResponse QueryCensorJobList(QueryCensorJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCensorJobListWithOptions(request, runtime);
        }

        public async Task<QueryCensorJobListResponse> QueryCensorJobListAsync(QueryCensorJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCensorJobListWithOptionsAsync(request, runtime);
        }

        public QueryCensorPipelineListResponse QueryCensorPipelineListWithOptions(QueryCensorPipelineListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCensorPipelineListResponse>(DoRPCRequest("QueryCensorPipelineList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryCensorPipelineListResponse> QueryCensorPipelineListWithOptionsAsync(QueryCensorPipelineListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCensorPipelineListResponse>(await DoRPCRequestAsync("QueryCensorPipelineList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryCensorPipelineListResponse QueryCensorPipelineList(QueryCensorPipelineListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCensorPipelineListWithOptions(request, runtime);
        }

        public async Task<QueryCensorPipelineListResponse> QueryCensorPipelineListAsync(QueryCensorPipelineListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCensorPipelineListWithOptionsAsync(request, runtime);
        }

        public QueryComplexJobListResponse QueryComplexJobListWithOptions(QueryComplexJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryComplexJobListResponse>(DoRPCRequest("QueryComplexJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryComplexJobListResponse> QueryComplexJobListWithOptionsAsync(QueryComplexJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryComplexJobListResponse>(await DoRPCRequestAsync("QueryComplexJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryComplexJobListResponse QueryComplexJobList(QueryComplexJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryComplexJobListWithOptions(request, runtime);
        }

        public async Task<QueryComplexJobListResponse> QueryComplexJobListAsync(QueryComplexJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryComplexJobListWithOptionsAsync(request, runtime);
        }

        public QueryCoverJobListResponse QueryCoverJobListWithOptions(QueryCoverJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCoverJobListResponse>(DoRPCRequest("QueryCoverJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryCoverJobListResponse> QueryCoverJobListWithOptionsAsync(QueryCoverJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCoverJobListResponse>(await DoRPCRequestAsync("QueryCoverJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryCoverJobListResponse QueryCoverJobList(QueryCoverJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCoverJobListWithOptions(request, runtime);
        }

        public async Task<QueryCoverJobListResponse> QueryCoverJobListAsync(QueryCoverJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCoverJobListWithOptionsAsync(request, runtime);
        }

        public QueryCoverPipelineListResponse QueryCoverPipelineListWithOptions(QueryCoverPipelineListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCoverPipelineListResponse>(DoRPCRequest("QueryCoverPipelineList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryCoverPipelineListResponse> QueryCoverPipelineListWithOptionsAsync(QueryCoverPipelineListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCoverPipelineListResponse>(await DoRPCRequestAsync("QueryCoverPipelineList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryCoverPipelineListResponse QueryCoverPipelineList(QueryCoverPipelineListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCoverPipelineListWithOptions(request, runtime);
        }

        public async Task<QueryCoverPipelineListResponse> QueryCoverPipelineListAsync(QueryCoverPipelineListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCoverPipelineListWithOptionsAsync(request, runtime);
        }

        public QueryEditingJobListResponse QueryEditingJobListWithOptions(QueryEditingJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryEditingJobListResponse>(DoRPCRequest("QueryEditingJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryEditingJobListResponse> QueryEditingJobListWithOptionsAsync(QueryEditingJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryEditingJobListResponse>(await DoRPCRequestAsync("QueryEditingJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryEditingJobListResponse QueryEditingJobList(QueryEditingJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEditingJobListWithOptions(request, runtime);
        }

        public async Task<QueryEditingJobListResponse> QueryEditingJobListAsync(QueryEditingJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEditingJobListWithOptionsAsync(request, runtime);
        }

        public QueryFacerecogJobListResponse QueryFacerecogJobListWithOptions(QueryFacerecogJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFacerecogJobListResponse>(DoRPCRequest("QueryFacerecogJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryFacerecogJobListResponse> QueryFacerecogJobListWithOptionsAsync(QueryFacerecogJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFacerecogJobListResponse>(await DoRPCRequestAsync("QueryFacerecogJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryFacerecogJobListResponse QueryFacerecogJobList(QueryFacerecogJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFacerecogJobListWithOptions(request, runtime);
        }

        public async Task<QueryFacerecogJobListResponse> QueryFacerecogJobListAsync(QueryFacerecogJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFacerecogJobListWithOptionsAsync(request, runtime);
        }

        public QueryFpCompareJobListResponse QueryFpCompareJobListWithOptions(QueryFpCompareJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFpCompareJobListResponse>(DoRPCRequest("QueryFpCompareJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryFpCompareJobListResponse> QueryFpCompareJobListWithOptionsAsync(QueryFpCompareJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFpCompareJobListResponse>(await DoRPCRequestAsync("QueryFpCompareJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryFpCompareJobListResponse QueryFpCompareJobList(QueryFpCompareJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFpCompareJobListWithOptions(request, runtime);
        }

        public async Task<QueryFpCompareJobListResponse> QueryFpCompareJobListAsync(QueryFpCompareJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFpCompareJobListWithOptionsAsync(request, runtime);
        }

        public QueryFpDBDeleteJobListResponse QueryFpDBDeleteJobListWithOptions(QueryFpDBDeleteJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFpDBDeleteJobListResponse>(DoRPCRequest("QueryFpDBDeleteJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryFpDBDeleteJobListResponse> QueryFpDBDeleteJobListWithOptionsAsync(QueryFpDBDeleteJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFpDBDeleteJobListResponse>(await DoRPCRequestAsync("QueryFpDBDeleteJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryFpDBDeleteJobListResponse QueryFpDBDeleteJobList(QueryFpDBDeleteJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFpDBDeleteJobListWithOptions(request, runtime);
        }

        public async Task<QueryFpDBDeleteJobListResponse> QueryFpDBDeleteJobListAsync(QueryFpDBDeleteJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFpDBDeleteJobListWithOptionsAsync(request, runtime);
        }

        public QueryFpFileDeleteJobListResponse QueryFpFileDeleteJobListWithOptions(QueryFpFileDeleteJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFpFileDeleteJobListResponse>(DoRPCRequest("QueryFpFileDeleteJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryFpFileDeleteJobListResponse> QueryFpFileDeleteJobListWithOptionsAsync(QueryFpFileDeleteJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFpFileDeleteJobListResponse>(await DoRPCRequestAsync("QueryFpFileDeleteJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryFpFileDeleteJobListResponse QueryFpFileDeleteJobList(QueryFpFileDeleteJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFpFileDeleteJobListWithOptions(request, runtime);
        }

        public async Task<QueryFpFileDeleteJobListResponse> QueryFpFileDeleteJobListAsync(QueryFpFileDeleteJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFpFileDeleteJobListWithOptionsAsync(request, runtime);
        }

        public QueryFpImportResultResponse QueryFpImportResultWithOptions(QueryFpImportResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFpImportResultResponse>(DoRPCRequest("QueryFpImportResult", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryFpImportResultResponse> QueryFpImportResultWithOptionsAsync(QueryFpImportResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFpImportResultResponse>(await DoRPCRequestAsync("QueryFpImportResult", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryFpImportResultResponse QueryFpImportResult(QueryFpImportResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFpImportResultWithOptions(request, runtime);
        }

        public async Task<QueryFpImportResultResponse> QueryFpImportResultAsync(QueryFpImportResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFpImportResultWithOptionsAsync(request, runtime);
        }

        public QueryFpShotJobListResponse QueryFpShotJobListWithOptions(QueryFpShotJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFpShotJobListResponse>(DoRPCRequest("QueryFpShotJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryFpShotJobListResponse> QueryFpShotJobListWithOptionsAsync(QueryFpShotJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFpShotJobListResponse>(await DoRPCRequestAsync("QueryFpShotJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryFpShotJobListResponse QueryFpShotJobList(QueryFpShotJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFpShotJobListWithOptions(request, runtime);
        }

        public async Task<QueryFpShotJobListResponse> QueryFpShotJobListAsync(QueryFpShotJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFpShotJobListWithOptionsAsync(request, runtime);
        }

        public QueryImageSearchJobListResponse QueryImageSearchJobListWithOptions(QueryImageSearchJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryImageSearchJobListResponse>(DoRPCRequest("QueryImageSearchJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryImageSearchJobListResponse> QueryImageSearchJobListWithOptionsAsync(QueryImageSearchJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryImageSearchJobListResponse>(await DoRPCRequestAsync("QueryImageSearchJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryImageSearchJobListResponse QueryImageSearchJobList(QueryImageSearchJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryImageSearchJobListWithOptions(request, runtime);
        }

        public async Task<QueryImageSearchJobListResponse> QueryImageSearchJobListAsync(QueryImageSearchJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryImageSearchJobListWithOptionsAsync(request, runtime);
        }

        public QueryInnerJobResponse QueryInnerJobWithOptions(QueryInnerJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryInnerJobResponse>(DoRPCRequest("QueryInnerJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryInnerJobResponse> QueryInnerJobWithOptionsAsync(QueryInnerJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryInnerJobResponse>(await DoRPCRequestAsync("QueryInnerJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryInnerJobResponse QueryInnerJob(QueryInnerJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInnerJobWithOptions(request, runtime);
        }

        public async Task<QueryInnerJobResponse> QueryInnerJobAsync(QueryInnerJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInnerJobWithOptionsAsync(request, runtime);
        }

        public QueryIProductionJobResponse QueryIProductionJobWithOptions(QueryIProductionJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryIProductionJobResponse>(DoRPCRequest("QueryIProductionJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryIProductionJobResponse> QueryIProductionJobWithOptionsAsync(QueryIProductionJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryIProductionJobResponse>(await DoRPCRequestAsync("QueryIProductionJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryIProductionJobResponse QueryIProductionJob(QueryIProductionJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryIProductionJobWithOptions(request, runtime);
        }

        public async Task<QueryIProductionJobResponse> QueryIProductionJobAsync(QueryIProductionJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryIProductionJobWithOptionsAsync(request, runtime);
        }

        public QueryIProductionJobListResponse QueryIProductionJobListWithOptions(QueryIProductionJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryIProductionJobListResponse>(DoRPCRequest("QueryIProductionJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryIProductionJobListResponse> QueryIProductionJobListWithOptionsAsync(QueryIProductionJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryIProductionJobListResponse>(await DoRPCRequestAsync("QueryIProductionJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryIProductionJobListResponse QueryIProductionJobList(QueryIProductionJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryIProductionJobListWithOptions(request, runtime);
        }

        public async Task<QueryIProductionJobListResponse> QueryIProductionJobListAsync(QueryIProductionJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryIProductionJobListWithOptionsAsync(request, runtime);
        }

        public QueryJobListResponse QueryJobListWithOptions(QueryJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryJobListResponse>(DoRPCRequest("QueryJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryJobListResponse> QueryJobListWithOptionsAsync(QueryJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryJobListResponse>(await DoRPCRequestAsync("QueryJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryJobListResponse QueryJobList(QueryJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryJobListWithOptions(request, runtime);
        }

        public async Task<QueryJobListResponse> QueryJobListAsync(QueryJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryJobListWithOptionsAsync(request, runtime);
        }

        public QueryMCJobListResponse QueryMCJobListWithOptions(QueryMCJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMCJobListResponse>(DoRPCRequest("QueryMCJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMCJobListResponse> QueryMCJobListWithOptionsAsync(QueryMCJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMCJobListResponse>(await DoRPCRequestAsync("QueryMCJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryMCJobListResponse QueryMCJobList(QueryMCJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMCJobListWithOptions(request, runtime);
        }

        public async Task<QueryMCJobListResponse> QueryMCJobListAsync(QueryMCJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMCJobListWithOptionsAsync(request, runtime);
        }

        public QueryMCTemplateListResponse QueryMCTemplateListWithOptions(QueryMCTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMCTemplateListResponse>(DoRPCRequest("QueryMCTemplateList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMCTemplateListResponse> QueryMCTemplateListWithOptionsAsync(QueryMCTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMCTemplateListResponse>(await DoRPCRequestAsync("QueryMCTemplateList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryMCTemplateListResponse QueryMCTemplateList(QueryMCTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMCTemplateListWithOptions(request, runtime);
        }

        public async Task<QueryMCTemplateListResponse> QueryMCTemplateListAsync(QueryMCTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMCTemplateListWithOptionsAsync(request, runtime);
        }

        public QueryMcuJobResponse QueryMcuJobWithOptions(QueryMcuJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMcuJobResponse>(DoRPCRequest("QueryMcuJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMcuJobResponse> QueryMcuJobWithOptionsAsync(QueryMcuJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMcuJobResponse>(await DoRPCRequestAsync("QueryMcuJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryMcuJobResponse QueryMcuJob(QueryMcuJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMcuJobWithOptions(request, runtime);
        }

        public async Task<QueryMcuJobResponse> QueryMcuJobAsync(QueryMcuJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMcuJobWithOptionsAsync(request, runtime);
        }

        public QueryMcuTemplateResponse QueryMcuTemplateWithOptions(QueryMcuTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMcuTemplateResponse>(DoRPCRequest("QueryMcuTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMcuTemplateResponse> QueryMcuTemplateWithOptionsAsync(QueryMcuTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMcuTemplateResponse>(await DoRPCRequestAsync("QueryMcuTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryMcuTemplateResponse QueryMcuTemplate(QueryMcuTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMcuTemplateWithOptions(request, runtime);
        }

        public async Task<QueryMcuTemplateResponse> QueryMcuTemplateAsync(QueryMcuTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMcuTemplateWithOptionsAsync(request, runtime);
        }

        public QueryMediaCensorJobDetailResponse QueryMediaCensorJobDetailWithOptions(QueryMediaCensorJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMediaCensorJobDetailResponse>(DoRPCRequest("QueryMediaCensorJobDetail", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMediaCensorJobDetailResponse> QueryMediaCensorJobDetailWithOptionsAsync(QueryMediaCensorJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMediaCensorJobDetailResponse>(await DoRPCRequestAsync("QueryMediaCensorJobDetail", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryMediaCensorJobDetailResponse QueryMediaCensorJobDetail(QueryMediaCensorJobDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMediaCensorJobDetailWithOptions(request, runtime);
        }

        public async Task<QueryMediaCensorJobDetailResponse> QueryMediaCensorJobDetailAsync(QueryMediaCensorJobDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMediaCensorJobDetailWithOptionsAsync(request, runtime);
        }

        public QueryMediaCensorJobListResponse QueryMediaCensorJobListWithOptions(QueryMediaCensorJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMediaCensorJobListResponse>(DoRPCRequest("QueryMediaCensorJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMediaCensorJobListResponse> QueryMediaCensorJobListWithOptionsAsync(QueryMediaCensorJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMediaCensorJobListResponse>(await DoRPCRequestAsync("QueryMediaCensorJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryMediaCensorJobListResponse QueryMediaCensorJobList(QueryMediaCensorJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMediaCensorJobListWithOptions(request, runtime);
        }

        public async Task<QueryMediaCensorJobListResponse> QueryMediaCensorJobListAsync(QueryMediaCensorJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMediaCensorJobListWithOptionsAsync(request, runtime);
        }

        public QueryMediaDetailJobListResponse QueryMediaDetailJobListWithOptions(QueryMediaDetailJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMediaDetailJobListResponse>(DoRPCRequest("QueryMediaDetailJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMediaDetailJobListResponse> QueryMediaDetailJobListWithOptionsAsync(QueryMediaDetailJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMediaDetailJobListResponse>(await DoRPCRequestAsync("QueryMediaDetailJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryMediaDetailJobListResponse QueryMediaDetailJobList(QueryMediaDetailJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMediaDetailJobListWithOptions(request, runtime);
        }

        public async Task<QueryMediaDetailJobListResponse> QueryMediaDetailJobListAsync(QueryMediaDetailJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMediaDetailJobListWithOptionsAsync(request, runtime);
        }

        public QueryMediaFpDeleteJobListResponse QueryMediaFpDeleteJobListWithOptions(QueryMediaFpDeleteJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMediaFpDeleteJobListResponse>(DoRPCRequest("QueryMediaFpDeleteJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMediaFpDeleteJobListResponse> QueryMediaFpDeleteJobListWithOptionsAsync(QueryMediaFpDeleteJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMediaFpDeleteJobListResponse>(await DoRPCRequestAsync("QueryMediaFpDeleteJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryMediaFpDeleteJobListResponse QueryMediaFpDeleteJobList(QueryMediaFpDeleteJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMediaFpDeleteJobListWithOptions(request, runtime);
        }

        public async Task<QueryMediaFpDeleteJobListResponse> QueryMediaFpDeleteJobListAsync(QueryMediaFpDeleteJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMediaFpDeleteJobListWithOptionsAsync(request, runtime);
        }

        public QueryMediaInfoJobListResponse QueryMediaInfoJobListWithOptions(QueryMediaInfoJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMediaInfoJobListResponse>(DoRPCRequest("QueryMediaInfoJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMediaInfoJobListResponse> QueryMediaInfoJobListWithOptionsAsync(QueryMediaInfoJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMediaInfoJobListResponse>(await DoRPCRequestAsync("QueryMediaInfoJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryMediaInfoJobListResponse QueryMediaInfoJobList(QueryMediaInfoJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMediaInfoJobListWithOptions(request, runtime);
        }

        public async Task<QueryMediaInfoJobListResponse> QueryMediaInfoJobListAsync(QueryMediaInfoJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMediaInfoJobListWithOptionsAsync(request, runtime);
        }

        public QueryMediaListResponse QueryMediaListWithOptions(QueryMediaListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMediaListResponse>(DoRPCRequest("QueryMediaList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMediaListResponse> QueryMediaListWithOptionsAsync(QueryMediaListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMediaListResponse>(await DoRPCRequestAsync("QueryMediaList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryMediaListResponse QueryMediaList(QueryMediaListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMediaListWithOptions(request, runtime);
        }

        public async Task<QueryMediaListResponse> QueryMediaListAsync(QueryMediaListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMediaListWithOptionsAsync(request, runtime);
        }

        public QueryMediaListByURLResponse QueryMediaListByURLWithOptions(QueryMediaListByURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMediaListByURLResponse>(DoRPCRequest("QueryMediaListByURL", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMediaListByURLResponse> QueryMediaListByURLWithOptionsAsync(QueryMediaListByURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMediaListByURLResponse>(await DoRPCRequestAsync("QueryMediaListByURL", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryMediaListByURLResponse QueryMediaListByURL(QueryMediaListByURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMediaListByURLWithOptions(request, runtime);
        }

        public async Task<QueryMediaListByURLResponse> QueryMediaListByURLAsync(QueryMediaListByURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMediaListByURLWithOptionsAsync(request, runtime);
        }

        public QueryMediaWorkflowExecutionListResponse QueryMediaWorkflowExecutionListWithOptions(QueryMediaWorkflowExecutionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMediaWorkflowExecutionListResponse>(DoRPCRequest("QueryMediaWorkflowExecutionList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMediaWorkflowExecutionListResponse> QueryMediaWorkflowExecutionListWithOptionsAsync(QueryMediaWorkflowExecutionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMediaWorkflowExecutionListResponse>(await DoRPCRequestAsync("QueryMediaWorkflowExecutionList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryMediaWorkflowExecutionListResponse QueryMediaWorkflowExecutionList(QueryMediaWorkflowExecutionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMediaWorkflowExecutionListWithOptions(request, runtime);
        }

        public async Task<QueryMediaWorkflowExecutionListResponse> QueryMediaWorkflowExecutionListAsync(QueryMediaWorkflowExecutionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMediaWorkflowExecutionListWithOptionsAsync(request, runtime);
        }

        public QueryMediaWorkflowListResponse QueryMediaWorkflowListWithOptions(QueryMediaWorkflowListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMediaWorkflowListResponse>(DoRPCRequest("QueryMediaWorkflowList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMediaWorkflowListResponse> QueryMediaWorkflowListWithOptionsAsync(QueryMediaWorkflowListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMediaWorkflowListResponse>(await DoRPCRequestAsync("QueryMediaWorkflowList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryMediaWorkflowListResponse QueryMediaWorkflowList(QueryMediaWorkflowListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMediaWorkflowListWithOptions(request, runtime);
        }

        public async Task<QueryMediaWorkflowListResponse> QueryMediaWorkflowListAsync(QueryMediaWorkflowListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMediaWorkflowListWithOptionsAsync(request, runtime);
        }

        public QueryPipelineListResponse QueryPipelineListWithOptions(QueryPipelineListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPipelineListResponse>(DoRPCRequest("QueryPipelineList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryPipelineListResponse> QueryPipelineListWithOptionsAsync(QueryPipelineListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPipelineListResponse>(await DoRPCRequestAsync("QueryPipelineList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryPipelineListResponse QueryPipelineList(QueryPipelineListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPipelineListWithOptions(request, runtime);
        }

        public async Task<QueryPipelineListResponse> QueryPipelineListAsync(QueryPipelineListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPipelineListWithOptionsAsync(request, runtime);
        }

        public QueryPornJobListResponse QueryPornJobListWithOptions(QueryPornJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPornJobListResponse>(DoRPCRequest("QueryPornJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryPornJobListResponse> QueryPornJobListWithOptionsAsync(QueryPornJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPornJobListResponse>(await DoRPCRequestAsync("QueryPornJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryPornJobListResponse QueryPornJobList(QueryPornJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPornJobListWithOptions(request, runtime);
        }

        public async Task<QueryPornJobListResponse> QueryPornJobListAsync(QueryPornJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPornJobListWithOptionsAsync(request, runtime);
        }

        public QueryPornPipelineListResponse QueryPornPipelineListWithOptions(QueryPornPipelineListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPornPipelineListResponse>(DoRPCRequest("QueryPornPipelineList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryPornPipelineListResponse> QueryPornPipelineListWithOptionsAsync(QueryPornPipelineListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPornPipelineListResponse>(await DoRPCRequestAsync("QueryPornPipelineList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryPornPipelineListResponse QueryPornPipelineList(QueryPornPipelineListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPornPipelineListWithOptions(request, runtime);
        }

        public async Task<QueryPornPipelineListResponse> QueryPornPipelineListAsync(QueryPornPipelineListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPornPipelineListWithOptionsAsync(request, runtime);
        }

        public QuerySmarttagJobResponse QuerySmarttagJobWithOptions(QuerySmarttagJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySmarttagJobResponse>(DoRPCRequest("QuerySmarttagJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QuerySmarttagJobResponse> QuerySmarttagJobWithOptionsAsync(QuerySmarttagJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySmarttagJobResponse>(await DoRPCRequestAsync("QuerySmarttagJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QuerySmarttagJobResponse QuerySmarttagJob(QuerySmarttagJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySmarttagJobWithOptions(request, runtime);
        }

        public async Task<QuerySmarttagJobResponse> QuerySmarttagJobAsync(QuerySmarttagJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySmarttagJobWithOptionsAsync(request, runtime);
        }

        public QuerySmarttagTemplateListResponse QuerySmarttagTemplateListWithOptions(QuerySmarttagTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySmarttagTemplateListResponse>(DoRPCRequest("QuerySmarttagTemplateList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QuerySmarttagTemplateListResponse> QuerySmarttagTemplateListWithOptionsAsync(QuerySmarttagTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySmarttagTemplateListResponse>(await DoRPCRequestAsync("QuerySmarttagTemplateList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QuerySmarttagTemplateListResponse QuerySmarttagTemplateList(QuerySmarttagTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySmarttagTemplateListWithOptions(request, runtime);
        }

        public async Task<QuerySmarttagTemplateListResponse> QuerySmarttagTemplateListAsync(QuerySmarttagTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySmarttagTemplateListWithOptionsAsync(request, runtime);
        }

        public QuerySnapshotJobListResponse QuerySnapshotJobListWithOptions(QuerySnapshotJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySnapshotJobListResponse>(DoRPCRequest("QuerySnapshotJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QuerySnapshotJobListResponse> QuerySnapshotJobListWithOptionsAsync(QuerySnapshotJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySnapshotJobListResponse>(await DoRPCRequestAsync("QuerySnapshotJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QuerySnapshotJobListResponse QuerySnapshotJobList(QuerySnapshotJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySnapshotJobListWithOptions(request, runtime);
        }

        public async Task<QuerySnapshotJobListResponse> QuerySnapshotJobListAsync(QuerySnapshotJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySnapshotJobListWithOptionsAsync(request, runtime);
        }

        public QuerySubtitleJobListResponse QuerySubtitleJobListWithOptions(QuerySubtitleJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySubtitleJobListResponse>(DoRPCRequest("QuerySubtitleJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QuerySubtitleJobListResponse> QuerySubtitleJobListWithOptionsAsync(QuerySubtitleJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySubtitleJobListResponse>(await DoRPCRequestAsync("QuerySubtitleJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QuerySubtitleJobListResponse QuerySubtitleJobList(QuerySubtitleJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySubtitleJobListWithOptions(request, runtime);
        }

        public async Task<QuerySubtitleJobListResponse> QuerySubtitleJobListAsync(QuerySubtitleJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySubtitleJobListWithOptionsAsync(request, runtime);
        }

        public QueryTagJobListResponse QueryTagJobListWithOptions(QueryTagJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTagJobListResponse>(DoRPCRequest("QueryTagJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTagJobListResponse> QueryTagJobListWithOptionsAsync(QueryTagJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTagJobListResponse>(await DoRPCRequestAsync("QueryTagJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryTagJobListResponse QueryTagJobList(QueryTagJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTagJobListWithOptions(request, runtime);
        }

        public async Task<QueryTagJobListResponse> QueryTagJobListAsync(QueryTagJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTagJobListWithOptionsAsync(request, runtime);
        }

        public QueryTemplateListResponse QueryTemplateListWithOptions(QueryTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTemplateListResponse>(DoRPCRequest("QueryTemplateList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTemplateListResponse> QueryTemplateListWithOptionsAsync(QueryTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTemplateListResponse>(await DoRPCRequestAsync("QueryTemplateList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryTemplateListResponse QueryTemplateList(QueryTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTemplateListWithOptions(request, runtime);
        }

        public async Task<QueryTemplateListResponse> QueryTemplateListAsync(QueryTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTemplateListWithOptionsAsync(request, runtime);
        }

        public QueryTerrorismJobListResponse QueryTerrorismJobListWithOptions(QueryTerrorismJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTerrorismJobListResponse>(DoRPCRequest("QueryTerrorismJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTerrorismJobListResponse> QueryTerrorismJobListWithOptionsAsync(QueryTerrorismJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTerrorismJobListResponse>(await DoRPCRequestAsync("QueryTerrorismJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryTerrorismJobListResponse QueryTerrorismJobList(QueryTerrorismJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTerrorismJobListWithOptions(request, runtime);
        }

        public async Task<QueryTerrorismJobListResponse> QueryTerrorismJobListAsync(QueryTerrorismJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTerrorismJobListWithOptionsAsync(request, runtime);
        }

        public QueryTerrorismPipelineListResponse QueryTerrorismPipelineListWithOptions(QueryTerrorismPipelineListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTerrorismPipelineListResponse>(DoRPCRequest("QueryTerrorismPipelineList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTerrorismPipelineListResponse> QueryTerrorismPipelineListWithOptionsAsync(QueryTerrorismPipelineListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTerrorismPipelineListResponse>(await DoRPCRequestAsync("QueryTerrorismPipelineList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryTerrorismPipelineListResponse QueryTerrorismPipelineList(QueryTerrorismPipelineListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTerrorismPipelineListWithOptions(request, runtime);
        }

        public async Task<QueryTerrorismPipelineListResponse> QueryTerrorismPipelineListAsync(QueryTerrorismPipelineListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTerrorismPipelineListWithOptionsAsync(request, runtime);
        }

        public QueryVideoGifJobListResponse QueryVideoGifJobListWithOptions(QueryVideoGifJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryVideoGifJobListResponse>(DoRPCRequest("QueryVideoGifJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryVideoGifJobListResponse> QueryVideoGifJobListWithOptionsAsync(QueryVideoGifJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryVideoGifJobListResponse>(await DoRPCRequestAsync("QueryVideoGifJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryVideoGifJobListResponse QueryVideoGifJobList(QueryVideoGifJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryVideoGifJobListWithOptions(request, runtime);
        }

        public async Task<QueryVideoGifJobListResponse> QueryVideoGifJobListAsync(QueryVideoGifJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryVideoGifJobListWithOptionsAsync(request, runtime);
        }

        public QueryVideoPoseJobListResponse QueryVideoPoseJobListWithOptions(QueryVideoPoseJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryVideoPoseJobListResponse>(DoRPCRequest("QueryVideoPoseJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryVideoPoseJobListResponse> QueryVideoPoseJobListWithOptionsAsync(QueryVideoPoseJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryVideoPoseJobListResponse>(await DoRPCRequestAsync("QueryVideoPoseJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryVideoPoseJobListResponse QueryVideoPoseJobList(QueryVideoPoseJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryVideoPoseJobListWithOptions(request, runtime);
        }

        public async Task<QueryVideoPoseJobListResponse> QueryVideoPoseJobListAsync(QueryVideoPoseJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryVideoPoseJobListWithOptionsAsync(request, runtime);
        }

        public QueryVideoQualityJobResponse QueryVideoQualityJobWithOptions(QueryVideoQualityJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryVideoQualityJobResponse>(DoRPCRequest("QueryVideoQualityJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryVideoQualityJobResponse> QueryVideoQualityJobWithOptionsAsync(QueryVideoQualityJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryVideoQualityJobResponse>(await DoRPCRequestAsync("QueryVideoQualityJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryVideoQualityJobResponse QueryVideoQualityJob(QueryVideoQualityJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryVideoQualityJobWithOptions(request, runtime);
        }

        public async Task<QueryVideoQualityJobResponse> QueryVideoQualityJobAsync(QueryVideoQualityJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryVideoQualityJobWithOptionsAsync(request, runtime);
        }

        public QueryVideoSplitJobListResponse QueryVideoSplitJobListWithOptions(QueryVideoSplitJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryVideoSplitJobListResponse>(DoRPCRequest("QueryVideoSplitJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryVideoSplitJobListResponse> QueryVideoSplitJobListWithOptionsAsync(QueryVideoSplitJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryVideoSplitJobListResponse>(await DoRPCRequestAsync("QueryVideoSplitJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryVideoSplitJobListResponse QueryVideoSplitJobList(QueryVideoSplitJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryVideoSplitJobListWithOptions(request, runtime);
        }

        public async Task<QueryVideoSplitJobListResponse> QueryVideoSplitJobListAsync(QueryVideoSplitJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryVideoSplitJobListWithOptionsAsync(request, runtime);
        }

        public QueryVideoSummaryJobListResponse QueryVideoSummaryJobListWithOptions(QueryVideoSummaryJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryVideoSummaryJobListResponse>(DoRPCRequest("QueryVideoSummaryJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryVideoSummaryJobListResponse> QueryVideoSummaryJobListWithOptionsAsync(QueryVideoSummaryJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryVideoSummaryJobListResponse>(await DoRPCRequestAsync("QueryVideoSummaryJobList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryVideoSummaryJobListResponse QueryVideoSummaryJobList(QueryVideoSummaryJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryVideoSummaryJobListWithOptions(request, runtime);
        }

        public async Task<QueryVideoSummaryJobListResponse> QueryVideoSummaryJobListAsync(QueryVideoSummaryJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryVideoSummaryJobListWithOptionsAsync(request, runtime);
        }

        public QueryWaterMarkTemplateListResponse QueryWaterMarkTemplateListWithOptions(QueryWaterMarkTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryWaterMarkTemplateListResponse>(DoRPCRequest("QueryWaterMarkTemplateList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryWaterMarkTemplateListResponse> QueryWaterMarkTemplateListWithOptionsAsync(QueryWaterMarkTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryWaterMarkTemplateListResponse>(await DoRPCRequestAsync("QueryWaterMarkTemplateList", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryWaterMarkTemplateListResponse QueryWaterMarkTemplateList(QueryWaterMarkTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryWaterMarkTemplateListWithOptions(request, runtime);
        }

        public async Task<QueryWaterMarkTemplateListResponse> QueryWaterMarkTemplateListAsync(QueryWaterMarkTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryWaterMarkTemplateListWithOptionsAsync(request, runtime);
        }

        public RefreshCdnDomainConfigsCacheResponse RefreshCdnDomainConfigsCacheWithOptions(RefreshCdnDomainConfigsCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshCdnDomainConfigsCacheResponse>(DoRPCRequest("RefreshCdnDomainConfigsCache", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RefreshCdnDomainConfigsCacheResponse> RefreshCdnDomainConfigsCacheWithOptionsAsync(RefreshCdnDomainConfigsCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshCdnDomainConfigsCacheResponse>(await DoRPCRequestAsync("RefreshCdnDomainConfigsCache", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RefreshCdnDomainConfigsCacheResponse RefreshCdnDomainConfigsCache(RefreshCdnDomainConfigsCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshCdnDomainConfigsCacheWithOptions(request, runtime);
        }

        public async Task<RefreshCdnDomainConfigsCacheResponse> RefreshCdnDomainConfigsCacheAsync(RefreshCdnDomainConfigsCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshCdnDomainConfigsCacheWithOptionsAsync(request, runtime);
        }

        public RegisterCustomFaceResponse RegisterCustomFaceWithOptions(RegisterCustomFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterCustomFaceResponse>(DoRPCRequest("RegisterCustomFace", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RegisterCustomFaceResponse> RegisterCustomFaceWithOptionsAsync(RegisterCustomFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterCustomFaceResponse>(await DoRPCRequestAsync("RegisterCustomFace", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RegisterCustomFaceResponse RegisterCustomFace(RegisterCustomFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterCustomFaceWithOptions(request, runtime);
        }

        public async Task<RegisterCustomFaceResponse> RegisterCustomFaceAsync(RegisterCustomFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterCustomFaceWithOptionsAsync(request, runtime);
        }

        public RegisterMediaDetailPersonResponse RegisterMediaDetailPersonWithOptions(RegisterMediaDetailPersonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterMediaDetailPersonResponse>(DoRPCRequest("RegisterMediaDetailPerson", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RegisterMediaDetailPersonResponse> RegisterMediaDetailPersonWithOptionsAsync(RegisterMediaDetailPersonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterMediaDetailPersonResponse>(await DoRPCRequestAsync("RegisterMediaDetailPerson", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RegisterMediaDetailPersonResponse RegisterMediaDetailPerson(RegisterMediaDetailPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterMediaDetailPersonWithOptions(request, runtime);
        }

        public async Task<RegisterMediaDetailPersonResponse> RegisterMediaDetailPersonAsync(RegisterMediaDetailPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterMediaDetailPersonWithOptionsAsync(request, runtime);
        }

        public RegisterMediaDetailScenarioResponse RegisterMediaDetailScenarioWithOptions(RegisterMediaDetailScenarioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterMediaDetailScenarioResponse>(DoRPCRequest("RegisterMediaDetailScenario", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RegisterMediaDetailScenarioResponse> RegisterMediaDetailScenarioWithOptionsAsync(RegisterMediaDetailScenarioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterMediaDetailScenarioResponse>(await DoRPCRequestAsync("RegisterMediaDetailScenario", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RegisterMediaDetailScenarioResponse RegisterMediaDetailScenario(RegisterMediaDetailScenarioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterMediaDetailScenarioWithOptions(request, runtime);
        }

        public async Task<RegisterMediaDetailScenarioResponse> RegisterMediaDetailScenarioAsync(RegisterMediaDetailScenarioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterMediaDetailScenarioWithOptionsAsync(request, runtime);
        }

        public ReportAnnotationJobResultResponse ReportAnnotationJobResultWithOptions(ReportAnnotationJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportAnnotationJobResultResponse>(DoRPCRequest("ReportAnnotationJobResult", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReportAnnotationJobResultResponse> ReportAnnotationJobResultWithOptionsAsync(ReportAnnotationJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportAnnotationJobResultResponse>(await DoRPCRequestAsync("ReportAnnotationJobResult", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReportAnnotationJobResultResponse ReportAnnotationJobResult(ReportAnnotationJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportAnnotationJobResultWithOptions(request, runtime);
        }

        public async Task<ReportAnnotationJobResultResponse> ReportAnnotationJobResultAsync(ReportAnnotationJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportAnnotationJobResultWithOptionsAsync(request, runtime);
        }

        public ReportCensorJobResultResponse ReportCensorJobResultWithOptions(ReportCensorJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportCensorJobResultResponse>(DoRPCRequest("ReportCensorJobResult", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReportCensorJobResultResponse> ReportCensorJobResultWithOptionsAsync(ReportCensorJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportCensorJobResultResponse>(await DoRPCRequestAsync("ReportCensorJobResult", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReportCensorJobResultResponse ReportCensorJobResult(ReportCensorJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportCensorJobResultWithOptions(request, runtime);
        }

        public async Task<ReportCensorJobResultResponse> ReportCensorJobResultAsync(ReportCensorJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportCensorJobResultWithOptionsAsync(request, runtime);
        }

        public ReportCoverJobResultResponse ReportCoverJobResultWithOptions(ReportCoverJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportCoverJobResultResponse>(DoRPCRequest("ReportCoverJobResult", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReportCoverJobResultResponse> ReportCoverJobResultWithOptionsAsync(ReportCoverJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportCoverJobResultResponse>(await DoRPCRequestAsync("ReportCoverJobResult", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReportCoverJobResultResponse ReportCoverJobResult(ReportCoverJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportCoverJobResultWithOptions(request, runtime);
        }

        public async Task<ReportCoverJobResultResponse> ReportCoverJobResultAsync(ReportCoverJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportCoverJobResultWithOptionsAsync(request, runtime);
        }

        public ReportFacerecogJobResultResponse ReportFacerecogJobResultWithOptions(ReportFacerecogJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportFacerecogJobResultResponse>(DoRPCRequest("ReportFacerecogJobResult", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReportFacerecogJobResultResponse> ReportFacerecogJobResultWithOptionsAsync(ReportFacerecogJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportFacerecogJobResultResponse>(await DoRPCRequestAsync("ReportFacerecogJobResult", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReportFacerecogJobResultResponse ReportFacerecogJobResult(ReportFacerecogJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportFacerecogJobResultWithOptions(request, runtime);
        }

        public async Task<ReportFacerecogJobResultResponse> ReportFacerecogJobResultAsync(ReportFacerecogJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportFacerecogJobResultWithOptionsAsync(request, runtime);
        }

        public ReportFpShotJobResultResponse ReportFpShotJobResultWithOptions(ReportFpShotJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportFpShotJobResultResponse>(DoRPCRequest("ReportFpShotJobResult", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReportFpShotJobResultResponse> ReportFpShotJobResultWithOptionsAsync(ReportFpShotJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportFpShotJobResultResponse>(await DoRPCRequestAsync("ReportFpShotJobResult", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReportFpShotJobResultResponse ReportFpShotJobResult(ReportFpShotJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportFpShotJobResultWithOptions(request, runtime);
        }

        public async Task<ReportFpShotJobResultResponse> ReportFpShotJobResultAsync(ReportFpShotJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportFpShotJobResultWithOptionsAsync(request, runtime);
        }

        public ReportMediaDetailJobResultResponse ReportMediaDetailJobResultWithOptions(ReportMediaDetailJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportMediaDetailJobResultResponse>(DoRPCRequest("ReportMediaDetailJobResult", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReportMediaDetailJobResultResponse> ReportMediaDetailJobResultWithOptionsAsync(ReportMediaDetailJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportMediaDetailJobResultResponse>(await DoRPCRequestAsync("ReportMediaDetailJobResult", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReportMediaDetailJobResultResponse ReportMediaDetailJobResult(ReportMediaDetailJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportMediaDetailJobResultWithOptions(request, runtime);
        }

        public async Task<ReportMediaDetailJobResultResponse> ReportMediaDetailJobResultAsync(ReportMediaDetailJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportMediaDetailJobResultWithOptionsAsync(request, runtime);
        }

        public ReportPornJobResultResponse ReportPornJobResultWithOptions(ReportPornJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportPornJobResultResponse>(DoRPCRequest("ReportPornJobResult", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReportPornJobResultResponse> ReportPornJobResultWithOptionsAsync(ReportPornJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportPornJobResultResponse>(await DoRPCRequestAsync("ReportPornJobResult", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReportPornJobResultResponse ReportPornJobResult(ReportPornJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportPornJobResultWithOptions(request, runtime);
        }

        public async Task<ReportPornJobResultResponse> ReportPornJobResultAsync(ReportPornJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportPornJobResultWithOptionsAsync(request, runtime);
        }

        public ReportTagJobResultResponse ReportTagJobResultWithOptions(ReportTagJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportTagJobResultResponse>(DoRPCRequest("ReportTagJobResult", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReportTagJobResultResponse> ReportTagJobResultWithOptionsAsync(ReportTagJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportTagJobResultResponse>(await DoRPCRequestAsync("ReportTagJobResult", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReportTagJobResultResponse ReportTagJobResult(ReportTagJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportTagJobResultWithOptions(request, runtime);
        }

        public async Task<ReportTagJobResultResponse> ReportTagJobResultAsync(ReportTagJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportTagJobResultWithOptionsAsync(request, runtime);
        }

        public ReportTerrorismJobResultResponse ReportTerrorismJobResultWithOptions(ReportTerrorismJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportTerrorismJobResultResponse>(DoRPCRequest("ReportTerrorismJobResult", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReportTerrorismJobResultResponse> ReportTerrorismJobResultWithOptionsAsync(ReportTerrorismJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportTerrorismJobResultResponse>(await DoRPCRequestAsync("ReportTerrorismJobResult", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReportTerrorismJobResultResponse ReportTerrorismJobResult(ReportTerrorismJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportTerrorismJobResultWithOptions(request, runtime);
        }

        public async Task<ReportTerrorismJobResultResponse> ReportTerrorismJobResultAsync(ReportTerrorismJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportTerrorismJobResultWithOptionsAsync(request, runtime);
        }

        public ReportVideoSplitJobResultResponse ReportVideoSplitJobResultWithOptions(ReportVideoSplitJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportVideoSplitJobResultResponse>(DoRPCRequest("ReportVideoSplitJobResult", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReportVideoSplitJobResultResponse> ReportVideoSplitJobResultWithOptionsAsync(ReportVideoSplitJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportVideoSplitJobResultResponse>(await DoRPCRequestAsync("ReportVideoSplitJobResult", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReportVideoSplitJobResultResponse ReportVideoSplitJobResult(ReportVideoSplitJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportVideoSplitJobResultWithOptions(request, runtime);
        }

        public async Task<ReportVideoSplitJobResultResponse> ReportVideoSplitJobResultAsync(ReportVideoSplitJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportVideoSplitJobResultWithOptionsAsync(request, runtime);
        }

        public SearchMediaResponse SearchMediaWithOptions(SearchMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchMediaResponse>(DoRPCRequest("SearchMedia", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchMediaResponse> SearchMediaWithOptionsAsync(SearchMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchMediaResponse>(await DoRPCRequestAsync("SearchMedia", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchMediaResponse SearchMedia(SearchMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchMediaWithOptions(request, runtime);
        }

        public async Task<SearchMediaResponse> SearchMediaAsync(SearchMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchMediaWithOptionsAsync(request, runtime);
        }

        public SearchMediaWorkflowResponse SearchMediaWorkflowWithOptions(SearchMediaWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchMediaWorkflowResponse>(DoRPCRequest("SearchMediaWorkflow", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchMediaWorkflowResponse> SearchMediaWorkflowWithOptionsAsync(SearchMediaWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchMediaWorkflowResponse>(await DoRPCRequestAsync("SearchMediaWorkflow", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchMediaWorkflowResponse SearchMediaWorkflow(SearchMediaWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchMediaWorkflowWithOptions(request, runtime);
        }

        public async Task<SearchMediaWorkflowResponse> SearchMediaWorkflowAsync(SearchMediaWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchMediaWorkflowWithOptionsAsync(request, runtime);
        }

        public SearchPipelineResponse SearchPipelineWithOptions(SearchPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchPipelineResponse>(DoRPCRequest("SearchPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchPipelineResponse> SearchPipelineWithOptionsAsync(SearchPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchPipelineResponse>(await DoRPCRequestAsync("SearchPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchPipelineResponse SearchPipeline(SearchPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchPipelineWithOptions(request, runtime);
        }

        public async Task<SearchPipelineResponse> SearchPipelineAsync(SearchPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchPipelineWithOptionsAsync(request, runtime);
        }

        public SearchTemplateResponse SearchTemplateWithOptions(SearchTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchTemplateResponse>(DoRPCRequest("SearchTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchTemplateResponse> SearchTemplateWithOptionsAsync(SearchTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchTemplateResponse>(await DoRPCRequestAsync("SearchTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchTemplateResponse SearchTemplate(SearchTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchTemplateWithOptions(request, runtime);
        }

        public async Task<SearchTemplateResponse> SearchTemplateAsync(SearchTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchTemplateWithOptionsAsync(request, runtime);
        }

        public SearchWaterMarkTemplateResponse SearchWaterMarkTemplateWithOptions(SearchWaterMarkTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchWaterMarkTemplateResponse>(DoRPCRequest("SearchWaterMarkTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchWaterMarkTemplateResponse> SearchWaterMarkTemplateWithOptionsAsync(SearchWaterMarkTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchWaterMarkTemplateResponse>(await DoRPCRequestAsync("SearchWaterMarkTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchWaterMarkTemplateResponse SearchWaterMarkTemplate(SearchWaterMarkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchWaterMarkTemplateWithOptions(request, runtime);
        }

        public async Task<SearchWaterMarkTemplateResponse> SearchWaterMarkTemplateAsync(SearchWaterMarkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchWaterMarkTemplateWithOptionsAsync(request, runtime);
        }

        public SetAuthConfigResponse SetAuthConfigWithOptions(SetAuthConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetAuthConfigResponse>(DoRPCRequest("SetAuthConfig", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetAuthConfigResponse> SetAuthConfigWithOptionsAsync(SetAuthConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetAuthConfigResponse>(await DoRPCRequestAsync("SetAuthConfig", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetAuthConfigResponse SetAuthConfig(SetAuthConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAuthConfigWithOptions(request, runtime);
        }

        public async Task<SetAuthConfigResponse> SetAuthConfigAsync(SetAuthConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAuthConfigWithOptionsAsync(request, runtime);
        }

        public StopIProductionJobResponse StopIProductionJobWithOptions(StopIProductionJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopIProductionJobResponse>(DoRPCRequest("StopIProductionJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopIProductionJobResponse> StopIProductionJobWithOptionsAsync(StopIProductionJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopIProductionJobResponse>(await DoRPCRequestAsync("StopIProductionJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopIProductionJobResponse StopIProductionJob(StopIProductionJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopIProductionJobWithOptions(request, runtime);
        }

        public async Task<StopIProductionJobResponse> StopIProductionJobAsync(StopIProductionJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopIProductionJobWithOptionsAsync(request, runtime);
        }

        public SubmitAnalysisJobResponse SubmitAnalysisJobWithOptions(SubmitAnalysisJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitAnalysisJobResponse>(DoRPCRequest("SubmitAnalysisJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitAnalysisJobResponse> SubmitAnalysisJobWithOptionsAsync(SubmitAnalysisJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitAnalysisJobResponse>(await DoRPCRequestAsync("SubmitAnalysisJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitAnalysisJobResponse SubmitAnalysisJob(SubmitAnalysisJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitAnalysisJobWithOptions(request, runtime);
        }

        public async Task<SubmitAnalysisJobResponse> SubmitAnalysisJobAsync(SubmitAnalysisJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitAnalysisJobWithOptionsAsync(request, runtime);
        }

        public SubmitAnnotationJobResponse SubmitAnnotationJobWithOptions(SubmitAnnotationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitAnnotationJobResponse>(DoRPCRequest("SubmitAnnotationJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitAnnotationJobResponse> SubmitAnnotationJobWithOptionsAsync(SubmitAnnotationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitAnnotationJobResponse>(await DoRPCRequestAsync("SubmitAnnotationJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitAnnotationJobResponse SubmitAnnotationJob(SubmitAnnotationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitAnnotationJobWithOptions(request, runtime);
        }

        public async Task<SubmitAnnotationJobResponse> SubmitAnnotationJobAsync(SubmitAnnotationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitAnnotationJobWithOptionsAsync(request, runtime);
        }

        public SubmitAsrJobResponse SubmitAsrJobWithOptions(SubmitAsrJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitAsrJobResponse>(DoRPCRequest("SubmitAsrJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitAsrJobResponse> SubmitAsrJobWithOptionsAsync(SubmitAsrJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitAsrJobResponse>(await DoRPCRequestAsync("SubmitAsrJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitAsrJobResponse SubmitAsrJob(SubmitAsrJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitAsrJobWithOptions(request, runtime);
        }

        public async Task<SubmitAsrJobResponse> SubmitAsrJobAsync(SubmitAsrJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitAsrJobWithOptionsAsync(request, runtime);
        }

        public SubmitBeautifyJobsResponse SubmitBeautifyJobsWithOptions(SubmitBeautifyJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitBeautifyJobsResponse>(DoRPCRequest("SubmitBeautifyJobs", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitBeautifyJobsResponse> SubmitBeautifyJobsWithOptionsAsync(SubmitBeautifyJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitBeautifyJobsResponse>(await DoRPCRequestAsync("SubmitBeautifyJobs", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitBeautifyJobsResponse SubmitBeautifyJobs(SubmitBeautifyJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitBeautifyJobsWithOptions(request, runtime);
        }

        public async Task<SubmitBeautifyJobsResponse> SubmitBeautifyJobsAsync(SubmitBeautifyJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitBeautifyJobsWithOptionsAsync(request, runtime);
        }

        public SubmitComplexJobResponse SubmitComplexJobWithOptions(SubmitComplexJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitComplexJobResponse>(DoRPCRequest("SubmitComplexJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitComplexJobResponse> SubmitComplexJobWithOptionsAsync(SubmitComplexJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitComplexJobResponse>(await DoRPCRequestAsync("SubmitComplexJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitComplexJobResponse SubmitComplexJob(SubmitComplexJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitComplexJobWithOptions(request, runtime);
        }

        public async Task<SubmitComplexJobResponse> SubmitComplexJobAsync(SubmitComplexJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitComplexJobWithOptionsAsync(request, runtime);
        }

        public SubmitCoverJobResponse SubmitCoverJobWithOptions(SubmitCoverJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitCoverJobResponse>(DoRPCRequest("SubmitCoverJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitCoverJobResponse> SubmitCoverJobWithOptionsAsync(SubmitCoverJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitCoverJobResponse>(await DoRPCRequestAsync("SubmitCoverJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitCoverJobResponse SubmitCoverJob(SubmitCoverJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitCoverJobWithOptions(request, runtime);
        }

        public async Task<SubmitCoverJobResponse> SubmitCoverJobAsync(SubmitCoverJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitCoverJobWithOptionsAsync(request, runtime);
        }

        public SubmitEditingJobsResponse SubmitEditingJobsWithOptions(SubmitEditingJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitEditingJobsResponse>(DoRPCRequest("SubmitEditingJobs", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitEditingJobsResponse> SubmitEditingJobsWithOptionsAsync(SubmitEditingJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitEditingJobsResponse>(await DoRPCRequestAsync("SubmitEditingJobs", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitEditingJobsResponse SubmitEditingJobs(SubmitEditingJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitEditingJobsWithOptions(request, runtime);
        }

        public async Task<SubmitEditingJobsResponse> SubmitEditingJobsAsync(SubmitEditingJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitEditingJobsWithOptionsAsync(request, runtime);
        }

        public SubmitFacerecogJobResponse SubmitFacerecogJobWithOptions(SubmitFacerecogJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitFacerecogJobResponse>(DoRPCRequest("SubmitFacerecogJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitFacerecogJobResponse> SubmitFacerecogJobWithOptionsAsync(SubmitFacerecogJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitFacerecogJobResponse>(await DoRPCRequestAsync("SubmitFacerecogJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitFacerecogJobResponse SubmitFacerecogJob(SubmitFacerecogJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitFacerecogJobWithOptions(request, runtime);
        }

        public async Task<SubmitFacerecogJobResponse> SubmitFacerecogJobAsync(SubmitFacerecogJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitFacerecogJobWithOptionsAsync(request, runtime);
        }

        public SubmitFpCompareJobResponse SubmitFpCompareJobWithOptions(SubmitFpCompareJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitFpCompareJobResponse>(DoRPCRequest("SubmitFpCompareJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitFpCompareJobResponse> SubmitFpCompareJobWithOptionsAsync(SubmitFpCompareJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitFpCompareJobResponse>(await DoRPCRequestAsync("SubmitFpCompareJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitFpCompareJobResponse SubmitFpCompareJob(SubmitFpCompareJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitFpCompareJobWithOptions(request, runtime);
        }

        public async Task<SubmitFpCompareJobResponse> SubmitFpCompareJobAsync(SubmitFpCompareJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitFpCompareJobWithOptionsAsync(request, runtime);
        }

        public SubmitFpDBDeleteJobResponse SubmitFpDBDeleteJobWithOptions(SubmitFpDBDeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitFpDBDeleteJobResponse>(DoRPCRequest("SubmitFpDBDeleteJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitFpDBDeleteJobResponse> SubmitFpDBDeleteJobWithOptionsAsync(SubmitFpDBDeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitFpDBDeleteJobResponse>(await DoRPCRequestAsync("SubmitFpDBDeleteJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitFpDBDeleteJobResponse SubmitFpDBDeleteJob(SubmitFpDBDeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitFpDBDeleteJobWithOptions(request, runtime);
        }

        public async Task<SubmitFpDBDeleteJobResponse> SubmitFpDBDeleteJobAsync(SubmitFpDBDeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitFpDBDeleteJobWithOptionsAsync(request, runtime);
        }

        public SubmitFpFileDeleteJobResponse SubmitFpFileDeleteJobWithOptions(SubmitFpFileDeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitFpFileDeleteJobResponse>(DoRPCRequest("SubmitFpFileDeleteJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitFpFileDeleteJobResponse> SubmitFpFileDeleteJobWithOptionsAsync(SubmitFpFileDeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitFpFileDeleteJobResponse>(await DoRPCRequestAsync("SubmitFpFileDeleteJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitFpFileDeleteJobResponse SubmitFpFileDeleteJob(SubmitFpFileDeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitFpFileDeleteJobWithOptions(request, runtime);
        }

        public async Task<SubmitFpFileDeleteJobResponse> SubmitFpFileDeleteJobAsync(SubmitFpFileDeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitFpFileDeleteJobWithOptionsAsync(request, runtime);
        }

        public SubmitFpShotJobResponse SubmitFpShotJobWithOptions(SubmitFpShotJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitFpShotJobResponse>(DoRPCRequest("SubmitFpShotJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitFpShotJobResponse> SubmitFpShotJobWithOptionsAsync(SubmitFpShotJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitFpShotJobResponse>(await DoRPCRequestAsync("SubmitFpShotJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitFpShotJobResponse SubmitFpShotJob(SubmitFpShotJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitFpShotJobWithOptions(request, runtime);
        }

        public async Task<SubmitFpShotJobResponse> SubmitFpShotJobAsync(SubmitFpShotJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitFpShotJobWithOptionsAsync(request, runtime);
        }

        public SubmitImageQualityJobResponse SubmitImageQualityJobWithOptions(SubmitImageQualityJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitImageQualityJobResponse>(DoRPCRequest("SubmitImageQualityJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitImageQualityJobResponse> SubmitImageQualityJobWithOptionsAsync(SubmitImageQualityJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitImageQualityJobResponse>(await DoRPCRequestAsync("SubmitImageQualityJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitImageQualityJobResponse SubmitImageQualityJob(SubmitImageQualityJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitImageQualityJobWithOptions(request, runtime);
        }

        public async Task<SubmitImageQualityJobResponse> SubmitImageQualityJobAsync(SubmitImageQualityJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitImageQualityJobWithOptionsAsync(request, runtime);
        }

        public SubmitImageSearchJobResponse SubmitImageSearchJobWithOptions(SubmitImageSearchJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitImageSearchJobResponse>(DoRPCRequest("SubmitImageSearchJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitImageSearchJobResponse> SubmitImageSearchJobWithOptionsAsync(SubmitImageSearchJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitImageSearchJobResponse>(await DoRPCRequestAsync("SubmitImageSearchJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitImageSearchJobResponse SubmitImageSearchJob(SubmitImageSearchJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitImageSearchJobWithOptions(request, runtime);
        }

        public async Task<SubmitImageSearchJobResponse> SubmitImageSearchJobAsync(SubmitImageSearchJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitImageSearchJobWithOptionsAsync(request, runtime);
        }

        public SubmitInnerJobResponse SubmitInnerJobWithOptions(SubmitInnerJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitInnerJobResponse>(DoRPCRequest("SubmitInnerJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitInnerJobResponse> SubmitInnerJobWithOptionsAsync(SubmitInnerJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitInnerJobResponse>(await DoRPCRequestAsync("SubmitInnerJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitInnerJobResponse SubmitInnerJob(SubmitInnerJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitInnerJobWithOptions(request, runtime);
        }

        public async Task<SubmitInnerJobResponse> SubmitInnerJobAsync(SubmitInnerJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitInnerJobWithOptionsAsync(request, runtime);
        }

        public SubmitIProductionJobResponse SubmitIProductionJobWithOptions(SubmitIProductionJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitIProductionJobResponse>(DoRPCRequest("SubmitIProductionJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitIProductionJobResponse> SubmitIProductionJobWithOptionsAsync(SubmitIProductionJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitIProductionJobResponse>(await DoRPCRequestAsync("SubmitIProductionJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitIProductionJobResponse SubmitIProductionJob(SubmitIProductionJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitIProductionJobWithOptions(request, runtime);
        }

        public async Task<SubmitIProductionJobResponse> SubmitIProductionJobAsync(SubmitIProductionJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitIProductionJobWithOptionsAsync(request, runtime);
        }

        public SubmitJobsResponse SubmitJobsWithOptions(SubmitJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitJobsResponse>(DoRPCRequest("SubmitJobs", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitJobsResponse> SubmitJobsWithOptionsAsync(SubmitJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitJobsResponse>(await DoRPCRequestAsync("SubmitJobs", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitJobsResponse SubmitJobs(SubmitJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitJobsWithOptions(request, runtime);
        }

        public async Task<SubmitJobsResponse> SubmitJobsAsync(SubmitJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitJobsWithOptionsAsync(request, runtime);
        }

        public SubmitMCJobResponse SubmitMCJobWithOptions(SubmitMCJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitMCJobResponse>(DoRPCRequest("SubmitMCJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitMCJobResponse> SubmitMCJobWithOptionsAsync(SubmitMCJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitMCJobResponse>(await DoRPCRequestAsync("SubmitMCJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitMCJobResponse SubmitMCJob(SubmitMCJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitMCJobWithOptions(request, runtime);
        }

        public async Task<SubmitMCJobResponse> SubmitMCJobAsync(SubmitMCJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitMCJobWithOptionsAsync(request, runtime);
        }

        public SubmitMcuJobResponse SubmitMcuJobWithOptions(SubmitMcuJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitMcuJobResponse>(DoRPCRequest("SubmitMcuJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitMcuJobResponse> SubmitMcuJobWithOptionsAsync(SubmitMcuJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitMcuJobResponse>(await DoRPCRequestAsync("SubmitMcuJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitMcuJobResponse SubmitMcuJob(SubmitMcuJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitMcuJobWithOptions(request, runtime);
        }

        public async Task<SubmitMcuJobResponse> SubmitMcuJobAsync(SubmitMcuJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitMcuJobWithOptionsAsync(request, runtime);
        }

        public SubmitMediaCensorJobResponse SubmitMediaCensorJobWithOptions(SubmitMediaCensorJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitMediaCensorJobResponse>(DoRPCRequest("SubmitMediaCensorJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitMediaCensorJobResponse> SubmitMediaCensorJobWithOptionsAsync(SubmitMediaCensorJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitMediaCensorJobResponse>(await DoRPCRequestAsync("SubmitMediaCensorJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitMediaCensorJobResponse SubmitMediaCensorJob(SubmitMediaCensorJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitMediaCensorJobWithOptions(request, runtime);
        }

        public async Task<SubmitMediaCensorJobResponse> SubmitMediaCensorJobAsync(SubmitMediaCensorJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitMediaCensorJobWithOptionsAsync(request, runtime);
        }

        public SubmitMediaDetailJobResponse SubmitMediaDetailJobWithOptions(SubmitMediaDetailJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitMediaDetailJobResponse>(DoRPCRequest("SubmitMediaDetailJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitMediaDetailJobResponse> SubmitMediaDetailJobWithOptionsAsync(SubmitMediaDetailJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitMediaDetailJobResponse>(await DoRPCRequestAsync("SubmitMediaDetailJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitMediaDetailJobResponse SubmitMediaDetailJob(SubmitMediaDetailJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitMediaDetailJobWithOptions(request, runtime);
        }

        public async Task<SubmitMediaDetailJobResponse> SubmitMediaDetailJobAsync(SubmitMediaDetailJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitMediaDetailJobWithOptionsAsync(request, runtime);
        }

        public SubmitMediaFpDeleteJobResponse SubmitMediaFpDeleteJobWithOptions(SubmitMediaFpDeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitMediaFpDeleteJobResponse>(DoRPCRequest("SubmitMediaFpDeleteJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitMediaFpDeleteJobResponse> SubmitMediaFpDeleteJobWithOptionsAsync(SubmitMediaFpDeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitMediaFpDeleteJobResponse>(await DoRPCRequestAsync("SubmitMediaFpDeleteJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitMediaFpDeleteJobResponse SubmitMediaFpDeleteJob(SubmitMediaFpDeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitMediaFpDeleteJobWithOptions(request, runtime);
        }

        public async Task<SubmitMediaFpDeleteJobResponse> SubmitMediaFpDeleteJobAsync(SubmitMediaFpDeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitMediaFpDeleteJobWithOptionsAsync(request, runtime);
        }

        public SubmitMediaInfoJobResponse SubmitMediaInfoJobWithOptions(SubmitMediaInfoJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitMediaInfoJobResponse>(DoRPCRequest("SubmitMediaInfoJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitMediaInfoJobResponse> SubmitMediaInfoJobWithOptionsAsync(SubmitMediaInfoJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitMediaInfoJobResponse>(await DoRPCRequestAsync("SubmitMediaInfoJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitMediaInfoJobResponse SubmitMediaInfoJob(SubmitMediaInfoJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitMediaInfoJobWithOptions(request, runtime);
        }

        public async Task<SubmitMediaInfoJobResponse> SubmitMediaInfoJobAsync(SubmitMediaInfoJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitMediaInfoJobWithOptionsAsync(request, runtime);
        }

        public SubmitPornJobResponse SubmitPornJobWithOptions(SubmitPornJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitPornJobResponse>(DoRPCRequest("SubmitPornJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitPornJobResponse> SubmitPornJobWithOptionsAsync(SubmitPornJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitPornJobResponse>(await DoRPCRequestAsync("SubmitPornJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitPornJobResponse SubmitPornJob(SubmitPornJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitPornJobWithOptions(request, runtime);
        }

        public async Task<SubmitPornJobResponse> SubmitPornJobAsync(SubmitPornJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitPornJobWithOptionsAsync(request, runtime);
        }

        public SubmitSmarttagJobResponse SubmitSmarttagJobWithOptions(SubmitSmarttagJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitSmarttagJobResponse>(DoRPCRequest("SubmitSmarttagJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitSmarttagJobResponse> SubmitSmarttagJobWithOptionsAsync(SubmitSmarttagJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitSmarttagJobResponse>(await DoRPCRequestAsync("SubmitSmarttagJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitSmarttagJobResponse SubmitSmarttagJob(SubmitSmarttagJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSmarttagJobWithOptions(request, runtime);
        }

        public async Task<SubmitSmarttagJobResponse> SubmitSmarttagJobAsync(SubmitSmarttagJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSmarttagJobWithOptionsAsync(request, runtime);
        }

        public SubmitSnapshotJobResponse SubmitSnapshotJobWithOptions(SubmitSnapshotJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitSnapshotJobResponse>(DoRPCRequest("SubmitSnapshotJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitSnapshotJobResponse> SubmitSnapshotJobWithOptionsAsync(SubmitSnapshotJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitSnapshotJobResponse>(await DoRPCRequestAsync("SubmitSnapshotJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitSnapshotJobResponse SubmitSnapshotJob(SubmitSnapshotJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSnapshotJobWithOptions(request, runtime);
        }

        public async Task<SubmitSnapshotJobResponse> SubmitSnapshotJobAsync(SubmitSnapshotJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSnapshotJobWithOptionsAsync(request, runtime);
        }

        public SubmitSubtitleJobResponse SubmitSubtitleJobWithOptions(SubmitSubtitleJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitSubtitleJobResponse>(DoRPCRequest("SubmitSubtitleJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitSubtitleJobResponse> SubmitSubtitleJobWithOptionsAsync(SubmitSubtitleJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitSubtitleJobResponse>(await DoRPCRequestAsync("SubmitSubtitleJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitSubtitleJobResponse SubmitSubtitleJob(SubmitSubtitleJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSubtitleJobWithOptions(request, runtime);
        }

        public async Task<SubmitSubtitleJobResponse> SubmitSubtitleJobAsync(SubmitSubtitleJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSubtitleJobWithOptionsAsync(request, runtime);
        }

        public SubmitTagJobResponse SubmitTagJobWithOptions(SubmitTagJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitTagJobResponse>(DoRPCRequest("SubmitTagJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitTagJobResponse> SubmitTagJobWithOptionsAsync(SubmitTagJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitTagJobResponse>(await DoRPCRequestAsync("SubmitTagJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitTagJobResponse SubmitTagJob(SubmitTagJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitTagJobWithOptions(request, runtime);
        }

        public async Task<SubmitTagJobResponse> SubmitTagJobAsync(SubmitTagJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitTagJobWithOptionsAsync(request, runtime);
        }

        public SubmitTerrorismJobResponse SubmitTerrorismJobWithOptions(SubmitTerrorismJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitTerrorismJobResponse>(DoRPCRequest("SubmitTerrorismJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitTerrorismJobResponse> SubmitTerrorismJobWithOptionsAsync(SubmitTerrorismJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitTerrorismJobResponse>(await DoRPCRequestAsync("SubmitTerrorismJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitTerrorismJobResponse SubmitTerrorismJob(SubmitTerrorismJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitTerrorismJobWithOptions(request, runtime);
        }

        public async Task<SubmitTerrorismJobResponse> SubmitTerrorismJobAsync(SubmitTerrorismJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitTerrorismJobWithOptionsAsync(request, runtime);
        }

        public SubmitVideoGifJobResponse SubmitVideoGifJobWithOptions(SubmitVideoGifJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitVideoGifJobResponse>(DoRPCRequest("SubmitVideoGifJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitVideoGifJobResponse> SubmitVideoGifJobWithOptionsAsync(SubmitVideoGifJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitVideoGifJobResponse>(await DoRPCRequestAsync("SubmitVideoGifJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitVideoGifJobResponse SubmitVideoGifJob(SubmitVideoGifJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitVideoGifJobWithOptions(request, runtime);
        }

        public async Task<SubmitVideoGifJobResponse> SubmitVideoGifJobAsync(SubmitVideoGifJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitVideoGifJobWithOptionsAsync(request, runtime);
        }

        public SubmitVideoPoseJobResponse SubmitVideoPoseJobWithOptions(SubmitVideoPoseJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitVideoPoseJobResponse>(DoRPCRequest("SubmitVideoPoseJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitVideoPoseJobResponse> SubmitVideoPoseJobWithOptionsAsync(SubmitVideoPoseJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitVideoPoseJobResponse>(await DoRPCRequestAsync("SubmitVideoPoseJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitVideoPoseJobResponse SubmitVideoPoseJob(SubmitVideoPoseJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitVideoPoseJobWithOptions(request, runtime);
        }

        public async Task<SubmitVideoPoseJobResponse> SubmitVideoPoseJobAsync(SubmitVideoPoseJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitVideoPoseJobWithOptionsAsync(request, runtime);
        }

        public SubmitVideoQualityJobResponse SubmitVideoQualityJobWithOptions(SubmitVideoQualityJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitVideoQualityJobResponse>(DoRPCRequest("SubmitVideoQualityJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitVideoQualityJobResponse> SubmitVideoQualityJobWithOptionsAsync(SubmitVideoQualityJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitVideoQualityJobResponse>(await DoRPCRequestAsync("SubmitVideoQualityJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitVideoQualityJobResponse SubmitVideoQualityJob(SubmitVideoQualityJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitVideoQualityJobWithOptions(request, runtime);
        }

        public async Task<SubmitVideoQualityJobResponse> SubmitVideoQualityJobAsync(SubmitVideoQualityJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitVideoQualityJobWithOptionsAsync(request, runtime);
        }

        public SubmitVideoSplitJobResponse SubmitVideoSplitJobWithOptions(SubmitVideoSplitJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitVideoSplitJobResponse>(DoRPCRequest("SubmitVideoSplitJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitVideoSplitJobResponse> SubmitVideoSplitJobWithOptionsAsync(SubmitVideoSplitJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitVideoSplitJobResponse>(await DoRPCRequestAsync("SubmitVideoSplitJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitVideoSplitJobResponse SubmitVideoSplitJob(SubmitVideoSplitJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitVideoSplitJobWithOptions(request, runtime);
        }

        public async Task<SubmitVideoSplitJobResponse> SubmitVideoSplitJobAsync(SubmitVideoSplitJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitVideoSplitJobWithOptionsAsync(request, runtime);
        }

        public SubmitVideoSummaryJobResponse SubmitVideoSummaryJobWithOptions(SubmitVideoSummaryJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitVideoSummaryJobResponse>(DoRPCRequest("SubmitVideoSummaryJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitVideoSummaryJobResponse> SubmitVideoSummaryJobWithOptionsAsync(SubmitVideoSummaryJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitVideoSummaryJobResponse>(await DoRPCRequestAsync("SubmitVideoSummaryJob", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitVideoSummaryJobResponse SubmitVideoSummaryJob(SubmitVideoSummaryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitVideoSummaryJobWithOptions(request, runtime);
        }

        public async Task<SubmitVideoSummaryJobResponse> SubmitVideoSummaryJobAsync(SubmitVideoSummaryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitVideoSummaryJobWithOptionsAsync(request, runtime);
        }

        public TagCustomPersonResponse TagCustomPersonWithOptions(TagCustomPersonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagCustomPersonResponse>(DoRPCRequest("TagCustomPerson", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagCustomPersonResponse> TagCustomPersonWithOptionsAsync(TagCustomPersonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagCustomPersonResponse>(await DoRPCRequestAsync("TagCustomPerson", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TagCustomPersonResponse TagCustomPerson(TagCustomPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagCustomPersonWithOptions(request, runtime);
        }

        public async Task<TagCustomPersonResponse> TagCustomPersonAsync(TagCustomPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagCustomPersonWithOptionsAsync(request, runtime);
        }

        public UnbindInputBucketResponse UnbindInputBucketWithOptions(UnbindInputBucketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindInputBucketResponse>(DoRPCRequest("UnbindInputBucket", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindInputBucketResponse> UnbindInputBucketWithOptionsAsync(UnbindInputBucketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindInputBucketResponse>(await DoRPCRequestAsync("UnbindInputBucket", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnbindInputBucketResponse UnbindInputBucket(UnbindInputBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindInputBucketWithOptions(request, runtime);
        }

        public async Task<UnbindInputBucketResponse> UnbindInputBucketAsync(UnbindInputBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindInputBucketWithOptionsAsync(request, runtime);
        }

        public UnbindOutputBucketResponse UnbindOutputBucketWithOptions(UnbindOutputBucketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindOutputBucketResponse>(DoRPCRequest("UnbindOutputBucket", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindOutputBucketResponse> UnbindOutputBucketWithOptionsAsync(UnbindOutputBucketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindOutputBucketResponse>(await DoRPCRequestAsync("UnbindOutputBucket", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnbindOutputBucketResponse UnbindOutputBucket(UnbindOutputBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindOutputBucketWithOptions(request, runtime);
        }

        public async Task<UnbindOutputBucketResponse> UnbindOutputBucketAsync(UnbindOutputBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindOutputBucketWithOptionsAsync(request, runtime);
        }

        public UnregisterCustomFaceResponse UnregisterCustomFaceWithOptions(UnregisterCustomFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnregisterCustomFaceResponse>(DoRPCRequest("UnregisterCustomFace", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnregisterCustomFaceResponse> UnregisterCustomFaceWithOptionsAsync(UnregisterCustomFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnregisterCustomFaceResponse>(await DoRPCRequestAsync("UnregisterCustomFace", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnregisterCustomFaceResponse UnregisterCustomFace(UnregisterCustomFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnregisterCustomFaceWithOptions(request, runtime);
        }

        public async Task<UnregisterCustomFaceResponse> UnregisterCustomFaceAsync(UnregisterCustomFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnregisterCustomFaceWithOptionsAsync(request, runtime);
        }

        public UpdateAsrPipelineResponse UpdateAsrPipelineWithOptions(UpdateAsrPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAsrPipelineResponse>(DoRPCRequest("UpdateAsrPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAsrPipelineResponse> UpdateAsrPipelineWithOptionsAsync(UpdateAsrPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAsrPipelineResponse>(await DoRPCRequestAsync("UpdateAsrPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAsrPipelineResponse UpdateAsrPipeline(UpdateAsrPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAsrPipelineWithOptions(request, runtime);
        }

        public async Task<UpdateAsrPipelineResponse> UpdateAsrPipelineAsync(UpdateAsrPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAsrPipelineWithOptionsAsync(request, runtime);
        }

        public UpdateCategoryNameResponse UpdateCategoryNameWithOptions(UpdateCategoryNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCategoryNameResponse>(DoRPCRequest("UpdateCategoryName", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCategoryNameResponse> UpdateCategoryNameWithOptionsAsync(UpdateCategoryNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCategoryNameResponse>(await DoRPCRequestAsync("UpdateCategoryName", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCategoryNameResponse UpdateCategoryName(UpdateCategoryNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCategoryNameWithOptions(request, runtime);
        }

        public async Task<UpdateCategoryNameResponse> UpdateCategoryNameAsync(UpdateCategoryNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCategoryNameWithOptionsAsync(request, runtime);
        }

        public UpdateCensorPipelineResponse UpdateCensorPipelineWithOptions(UpdateCensorPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCensorPipelineResponse>(DoRPCRequest("UpdateCensorPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCensorPipelineResponse> UpdateCensorPipelineWithOptionsAsync(UpdateCensorPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCensorPipelineResponse>(await DoRPCRequestAsync("UpdateCensorPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCensorPipelineResponse UpdateCensorPipeline(UpdateCensorPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCensorPipelineWithOptions(request, runtime);
        }

        public async Task<UpdateCensorPipelineResponse> UpdateCensorPipelineAsync(UpdateCensorPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCensorPipelineWithOptionsAsync(request, runtime);
        }

        public UpdateCoverPipelineResponse UpdateCoverPipelineWithOptions(UpdateCoverPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCoverPipelineResponse>(DoRPCRequest("UpdateCoverPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCoverPipelineResponse> UpdateCoverPipelineWithOptionsAsync(UpdateCoverPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCoverPipelineResponse>(await DoRPCRequestAsync("UpdateCoverPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCoverPipelineResponse UpdateCoverPipeline(UpdateCoverPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCoverPipelineWithOptions(request, runtime);
        }

        public async Task<UpdateCoverPipelineResponse> UpdateCoverPipelineAsync(UpdateCoverPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCoverPipelineWithOptionsAsync(request, runtime);
        }

        public UpdateMCTemplateResponse UpdateMCTemplateWithOptions(UpdateMCTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMCTemplateResponse>(DoRPCRequest("UpdateMCTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateMCTemplateResponse> UpdateMCTemplateWithOptionsAsync(UpdateMCTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMCTemplateResponse>(await DoRPCRequestAsync("UpdateMCTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateMCTemplateResponse UpdateMCTemplate(UpdateMCTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMCTemplateWithOptions(request, runtime);
        }

        public async Task<UpdateMCTemplateResponse> UpdateMCTemplateAsync(UpdateMCTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMCTemplateWithOptionsAsync(request, runtime);
        }

        public UpdateMcuTemplateResponse UpdateMcuTemplateWithOptions(UpdateMcuTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMcuTemplateResponse>(DoRPCRequest("UpdateMcuTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateMcuTemplateResponse> UpdateMcuTemplateWithOptionsAsync(UpdateMcuTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMcuTemplateResponse>(await DoRPCRequestAsync("UpdateMcuTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateMcuTemplateResponse UpdateMcuTemplate(UpdateMcuTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMcuTemplateWithOptions(request, runtime);
        }

        public async Task<UpdateMcuTemplateResponse> UpdateMcuTemplateAsync(UpdateMcuTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMcuTemplateWithOptionsAsync(request, runtime);
        }

        public UpdateMediaResponse UpdateMediaWithOptions(UpdateMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMediaResponse>(DoRPCRequest("UpdateMedia", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateMediaResponse> UpdateMediaWithOptionsAsync(UpdateMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMediaResponse>(await DoRPCRequestAsync("UpdateMedia", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateMediaResponse UpdateMedia(UpdateMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMediaWithOptions(request, runtime);
        }

        public async Task<UpdateMediaResponse> UpdateMediaAsync(UpdateMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMediaWithOptionsAsync(request, runtime);
        }

        public UpdateMediaCategoryResponse UpdateMediaCategoryWithOptions(UpdateMediaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMediaCategoryResponse>(DoRPCRequest("UpdateMediaCategory", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateMediaCategoryResponse> UpdateMediaCategoryWithOptionsAsync(UpdateMediaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMediaCategoryResponse>(await DoRPCRequestAsync("UpdateMediaCategory", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateMediaCategoryResponse UpdateMediaCategory(UpdateMediaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMediaCategoryWithOptions(request, runtime);
        }

        public async Task<UpdateMediaCategoryResponse> UpdateMediaCategoryAsync(UpdateMediaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMediaCategoryWithOptionsAsync(request, runtime);
        }

        public UpdateMediaCoverResponse UpdateMediaCoverWithOptions(UpdateMediaCoverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMediaCoverResponse>(DoRPCRequest("UpdateMediaCover", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateMediaCoverResponse> UpdateMediaCoverWithOptionsAsync(UpdateMediaCoverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMediaCoverResponse>(await DoRPCRequestAsync("UpdateMediaCover", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateMediaCoverResponse UpdateMediaCover(UpdateMediaCoverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMediaCoverWithOptions(request, runtime);
        }

        public async Task<UpdateMediaCoverResponse> UpdateMediaCoverAsync(UpdateMediaCoverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMediaCoverWithOptionsAsync(request, runtime);
        }

        public UpdateMediaPublishStateResponse UpdateMediaPublishStateWithOptions(UpdateMediaPublishStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMediaPublishStateResponse>(DoRPCRequest("UpdateMediaPublishState", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateMediaPublishStateResponse> UpdateMediaPublishStateWithOptionsAsync(UpdateMediaPublishStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMediaPublishStateResponse>(await DoRPCRequestAsync("UpdateMediaPublishState", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateMediaPublishStateResponse UpdateMediaPublishState(UpdateMediaPublishStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMediaPublishStateWithOptions(request, runtime);
        }

        public async Task<UpdateMediaPublishStateResponse> UpdateMediaPublishStateAsync(UpdateMediaPublishStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMediaPublishStateWithOptionsAsync(request, runtime);
        }

        public UpdateMediaWorkflowResponse UpdateMediaWorkflowWithOptions(UpdateMediaWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMediaWorkflowResponse>(DoRPCRequest("UpdateMediaWorkflow", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateMediaWorkflowResponse> UpdateMediaWorkflowWithOptionsAsync(UpdateMediaWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMediaWorkflowResponse>(await DoRPCRequestAsync("UpdateMediaWorkflow", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateMediaWorkflowResponse UpdateMediaWorkflow(UpdateMediaWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMediaWorkflowWithOptions(request, runtime);
        }

        public async Task<UpdateMediaWorkflowResponse> UpdateMediaWorkflowAsync(UpdateMediaWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMediaWorkflowWithOptionsAsync(request, runtime);
        }

        public UpdateMediaWorkflowTriggerModeResponse UpdateMediaWorkflowTriggerModeWithOptions(UpdateMediaWorkflowTriggerModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMediaWorkflowTriggerModeResponse>(DoRPCRequest("UpdateMediaWorkflowTriggerMode", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateMediaWorkflowTriggerModeResponse> UpdateMediaWorkflowTriggerModeWithOptionsAsync(UpdateMediaWorkflowTriggerModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMediaWorkflowTriggerModeResponse>(await DoRPCRequestAsync("UpdateMediaWorkflowTriggerMode", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateMediaWorkflowTriggerModeResponse UpdateMediaWorkflowTriggerMode(UpdateMediaWorkflowTriggerModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMediaWorkflowTriggerModeWithOptions(request, runtime);
        }

        public async Task<UpdateMediaWorkflowTriggerModeResponse> UpdateMediaWorkflowTriggerModeAsync(UpdateMediaWorkflowTriggerModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMediaWorkflowTriggerModeWithOptionsAsync(request, runtime);
        }

        public UpdatePipelineResponse UpdatePipelineWithOptions(UpdatePipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePipelineResponse>(DoRPCRequest("UpdatePipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdatePipelineResponse> UpdatePipelineWithOptionsAsync(UpdatePipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePipelineResponse>(await DoRPCRequestAsync("UpdatePipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePipelineWithOptions(request, runtime);
        }

        public async Task<UpdatePipelineResponse> UpdatePipelineAsync(UpdatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePipelineWithOptionsAsync(request, runtime);
        }

        public UpdatePornPipelineResponse UpdatePornPipelineWithOptions(UpdatePornPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePornPipelineResponse>(DoRPCRequest("UpdatePornPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdatePornPipelineResponse> UpdatePornPipelineWithOptionsAsync(UpdatePornPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePornPipelineResponse>(await DoRPCRequestAsync("UpdatePornPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdatePornPipelineResponse UpdatePornPipeline(UpdatePornPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePornPipelineWithOptions(request, runtime);
        }

        public async Task<UpdatePornPipelineResponse> UpdatePornPipelineAsync(UpdatePornPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePornPipelineWithOptionsAsync(request, runtime);
        }

        public UpdateSmarttagTemplateResponse UpdateSmarttagTemplateWithOptions(UpdateSmarttagTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSmarttagTemplateResponse>(DoRPCRequest("UpdateSmarttagTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateSmarttagTemplateResponse> UpdateSmarttagTemplateWithOptionsAsync(UpdateSmarttagTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSmarttagTemplateResponse>(await DoRPCRequestAsync("UpdateSmarttagTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateSmarttagTemplateResponse UpdateSmarttagTemplate(UpdateSmarttagTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSmarttagTemplateWithOptions(request, runtime);
        }

        public async Task<UpdateSmarttagTemplateResponse> UpdateSmarttagTemplateAsync(UpdateSmarttagTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSmarttagTemplateWithOptionsAsync(request, runtime);
        }

        public UpdateTemplateResponse UpdateTemplateWithOptions(UpdateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(DoRPCRequest("UpdateTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateTemplateResponse> UpdateTemplateWithOptionsAsync(UpdateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(await DoRPCRequestAsync("UpdateTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTemplateWithOptions(request, runtime);
        }

        public async Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTemplateWithOptionsAsync(request, runtime);
        }

        public UpdateTerrorismPipelineResponse UpdateTerrorismPipelineWithOptions(UpdateTerrorismPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTerrorismPipelineResponse>(DoRPCRequest("UpdateTerrorismPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateTerrorismPipelineResponse> UpdateTerrorismPipelineWithOptionsAsync(UpdateTerrorismPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTerrorismPipelineResponse>(await DoRPCRequestAsync("UpdateTerrorismPipeline", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateTerrorismPipelineResponse UpdateTerrorismPipeline(UpdateTerrorismPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTerrorismPipelineWithOptions(request, runtime);
        }

        public async Task<UpdateTerrorismPipelineResponse> UpdateTerrorismPipelineAsync(UpdateTerrorismPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTerrorismPipelineWithOptionsAsync(request, runtime);
        }

        public UpdateWaterMarkTemplateResponse UpdateWaterMarkTemplateWithOptions(UpdateWaterMarkTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateWaterMarkTemplateResponse>(DoRPCRequest("UpdateWaterMarkTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateWaterMarkTemplateResponse> UpdateWaterMarkTemplateWithOptionsAsync(UpdateWaterMarkTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateWaterMarkTemplateResponse>(await DoRPCRequestAsync("UpdateWaterMarkTemplate", "2014-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateWaterMarkTemplateResponse UpdateWaterMarkTemplate(UpdateWaterMarkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWaterMarkTemplateWithOptions(request, runtime);
        }

        public async Task<UpdateWaterMarkTemplateResponse> UpdateWaterMarkTemplateAsync(UpdateWaterMarkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWaterMarkTemplateWithOptionsAsync(request, runtime);
        }

    }
}
