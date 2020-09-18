// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Composer20181212.Models;

namespace AlibabaCloud.SDK.Composer20181212
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("composer", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public ListTemplatesResponse ListTemplatesWithOptions(ListTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTemplatesResponse>(DoRequest("ListTemplates", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListTemplatesResponse> ListTemplatesWithOptionsAsync(ListTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTemplatesResponse>(await DoRequestAsync("ListTemplates", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTemplatesWithOptions(request, runtime);
        }

        public async Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTemplatesWithOptionsAsync(request, runtime);
        }

        public GetTemplateResponse GetTemplateWithOptions(GetTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetTemplateResponse>(DoRequest("GetTemplate", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetTemplateResponse> GetTemplateWithOptionsAsync(GetTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetTemplateResponse>(await DoRequestAsync("GetTemplate", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateWithOptions(request, runtime);
        }

        public async Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateWithOptionsAsync(request, runtime);
        }

        public GroupInvokeFlowResponse GroupInvokeFlowWithOptions(GroupInvokeFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GroupInvokeFlowResponse>(DoRequest("GroupInvokeFlow", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GroupInvokeFlowResponse> GroupInvokeFlowWithOptionsAsync(GroupInvokeFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GroupInvokeFlowResponse>(await DoRequestAsync("GroupInvokeFlow", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public GroupInvokeFlowResponse GroupInvokeFlow(GroupInvokeFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GroupInvokeFlowWithOptions(request, runtime);
        }

        public async Task<GroupInvokeFlowResponse> GroupInvokeFlowAsync(GroupInvokeFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GroupInvokeFlowWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRequest("ListTagResources", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRequestAsync("ListTagResources", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
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

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TagResourcesResponse>(DoRequest("TagResources", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TagResourcesResponse>(await DoRequestAsync("TagResources", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
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
            return TeaModel.ToObject<UntagResourcesResponse>(DoRequest("UntagResources", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRequestAsync("UntagResources", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
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

        public GetVersionResponse GetVersionWithOptions(GetVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetVersionResponse>(DoRequest("GetVersion", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetVersionResponse> GetVersionWithOptionsAsync(GetVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetVersionResponse>(await DoRequestAsync("GetVersion", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public GetVersionResponse GetVersion(GetVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVersionWithOptions(request, runtime);
        }

        public async Task<GetVersionResponse> GetVersionAsync(GetVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVersionWithOptionsAsync(request, runtime);
        }

        public ListVersionsResponse ListVersionsWithOptions(ListVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListVersionsResponse>(DoRequest("ListVersions", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListVersionsResponse> ListVersionsWithOptionsAsync(ListVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListVersionsResponse>(await DoRequestAsync("ListVersions", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public ListVersionsResponse ListVersions(ListVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVersionsWithOptions(request, runtime);
        }

        public async Task<ListVersionsResponse> ListVersionsAsync(ListVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVersionsWithOptionsAsync(request, runtime);
        }

        public UpdateFlowResponse UpdateFlowWithOptions(UpdateFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateFlowResponse>(DoRequest("UpdateFlow", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateFlowResponse> UpdateFlowWithOptionsAsync(UpdateFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateFlowResponse>(await DoRequestAsync("UpdateFlow", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public UpdateFlowResponse UpdateFlow(UpdateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFlowWithOptions(request, runtime);
        }

        public async Task<UpdateFlowResponse> UpdateFlowAsync(UpdateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFlowWithOptionsAsync(request, runtime);
        }

        public CloneFlowResponse CloneFlowWithOptions(CloneFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CloneFlowResponse>(DoRequest("CloneFlow", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CloneFlowResponse> CloneFlowWithOptionsAsync(CloneFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CloneFlowResponse>(await DoRequestAsync("CloneFlow", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
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

        public GetFlowResponse GetFlowWithOptions(GetFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetFlowResponse>(DoRequest("GetFlow", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetFlowResponse> GetFlowWithOptionsAsync(GetFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetFlowResponse>(await DoRequestAsync("GetFlow", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public GetFlowResponse GetFlow(GetFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFlowWithOptions(request, runtime);
        }

        public async Task<GetFlowResponse> GetFlowAsync(GetFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFlowWithOptionsAsync(request, runtime);
        }

        public ListFlowsResponse ListFlowsWithOptions(ListFlowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListFlowsResponse>(DoRequest("ListFlows", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListFlowsResponse> ListFlowsWithOptionsAsync(ListFlowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListFlowsResponse>(await DoRequestAsync("ListFlows", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public ListFlowsResponse ListFlows(ListFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowsWithOptions(request, runtime);
        }

        public async Task<ListFlowsResponse> ListFlowsAsync(ListFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowsWithOptionsAsync(request, runtime);
        }

        public DeleteFlowResponse DeleteFlowWithOptions(DeleteFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteFlowResponse>(DoRequest("DeleteFlow", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteFlowResponse> DeleteFlowWithOptionsAsync(DeleteFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteFlowResponse>(await DoRequestAsync("DeleteFlow", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
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

        public DisableFlowResponse DisableFlowWithOptions(DisableFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DisableFlowResponse>(DoRequest("DisableFlow", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DisableFlowResponse> DisableFlowWithOptionsAsync(DisableFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DisableFlowResponse>(await DoRequestAsync("DisableFlow", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
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
            return TeaModel.ToObject<EnableFlowResponse>(DoRequest("EnableFlow", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<EnableFlowResponse> EnableFlowWithOptionsAsync(EnableFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EnableFlowResponse>(await DoRequestAsync("EnableFlow", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
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

        public CreateFlowResponse CreateFlowWithOptions(CreateFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateFlowResponse>(DoRequest("CreateFlow", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateFlowResponse> CreateFlowWithOptionsAsync(CreateFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateFlowResponse>(await DoRequestAsync("CreateFlow", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
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

        public InvokeFlowResponse InvokeFlowWithOptions(InvokeFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InvokeFlowResponse>(DoRequest("InvokeFlow", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<InvokeFlowResponse> InvokeFlowWithOptionsAsync(InvokeFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InvokeFlowResponse>(await DoRequestAsync("InvokeFlow", "HTTPS", "POST", "2018-12-12", "AK", null, request.ToMap(), runtime));
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

    }
}
