// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Chatbot20171011.Models;

namespace AlibabaCloud.SDK.Chatbot20171011
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("chatbot", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateEntityResponse CreateEntityWithOptions(CreateEntityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEntityShrinkRequest request = new CreateEntityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Members))
            {
                request.MembersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Members, "Members", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEntityResponse>(DoRPCRequest("CreateEntity", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateEntityResponse> CreateEntityWithOptionsAsync(CreateEntityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEntityShrinkRequest request = new CreateEntityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Members))
            {
                request.MembersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Members, "Members", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEntityResponse>(await DoRPCRequestAsync("CreateEntity", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateEntityResponse CreateEntity(CreateEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEntityWithOptions(request, runtime);
        }

        public async Task<CreateEntityResponse> CreateEntityAsync(CreateEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEntityWithOptionsAsync(request, runtime);
        }

        public AddSynonymResponse AddSynonymWithOptions(AddSynonymRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSynonymResponse>(DoRPCRequest("AddSynonym", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddSynonymResponse> AddSynonymWithOptionsAsync(AddSynonymRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSynonymResponse>(await DoRPCRequestAsync("AddSynonym", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddSynonymResponse AddSynonym(AddSynonymRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSynonymWithOptions(request, runtime);
        }

        public async Task<AddSynonymResponse> AddSynonymAsync(AddSynonymRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSynonymWithOptionsAsync(request, runtime);
        }

        public DeleteCategoryResponse DeleteCategoryWithOptions(DeleteCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCategoryResponse>(DoRPCRequest("DeleteCategory", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCategoryResponse> DeleteCategoryWithOptionsAsync(DeleteCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCategoryResponse>(await DoRPCRequestAsync("DeleteCategory", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public PublishKnowledgeResponse PublishKnowledgeWithOptions(PublishKnowledgeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishKnowledgeResponse>(DoRPCRequest("PublishKnowledge", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PublishKnowledgeResponse> PublishKnowledgeWithOptionsAsync(PublishKnowledgeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishKnowledgeResponse>(await DoRPCRequestAsync("PublishKnowledge", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PublishKnowledgeResponse PublishKnowledge(PublishKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishKnowledgeWithOptions(request, runtime);
        }

        public async Task<PublishKnowledgeResponse> PublishKnowledgeAsync(PublishKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishKnowledgeWithOptionsAsync(request, runtime);
        }

        public ListBotKnowledgeDetailsResponse ListBotKnowledgeDetailsWithOptions(ListBotKnowledgeDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBotKnowledgeDetailsResponse>(DoRPCRequest("ListBotKnowledgeDetails", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListBotKnowledgeDetailsResponse> ListBotKnowledgeDetailsWithOptionsAsync(ListBotKnowledgeDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBotKnowledgeDetailsResponse>(await DoRPCRequestAsync("ListBotKnowledgeDetails", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListBotKnowledgeDetailsResponse ListBotKnowledgeDetails(ListBotKnowledgeDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBotKnowledgeDetailsWithOptions(request, runtime);
        }

        public async Task<ListBotKnowledgeDetailsResponse> ListBotKnowledgeDetailsAsync(ListBotKnowledgeDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBotKnowledgeDetailsWithOptionsAsync(request, runtime);
        }

        public QueryIntentsResponse QueryIntentsWithOptions(QueryIntentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryIntentsResponse>(DoRPCRequest("QueryIntents", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryIntentsResponse> QueryIntentsWithOptionsAsync(QueryIntentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryIntentsResponse>(await DoRPCRequestAsync("QueryIntents", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryIntentsResponse QueryIntents(QueryIntentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryIntentsWithOptions(request, runtime);
        }

        public async Task<QueryIntentsResponse> QueryIntentsAsync(QueryIntentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryIntentsWithOptionsAsync(request, runtime);
        }

        public DescribeCategoryResponse DescribeCategoryWithOptions(DescribeCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCategoryResponse>(DoRPCRequest("DescribeCategory", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCategoryResponse> DescribeCategoryWithOptionsAsync(DescribeCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCategoryResponse>(await DoRPCRequestAsync("DescribeCategory", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCategoryResponse DescribeCategory(DescribeCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCategoryWithOptions(request, runtime);
        }

        public async Task<DescribeCategoryResponse> DescribeCategoryAsync(DescribeCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCategoryWithOptionsAsync(request, runtime);
        }

        public ListBotReceptionDetailDatasResponse ListBotReceptionDetailDatasWithOptions(ListBotReceptionDetailDatasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBotReceptionDetailDatasResponse>(DoRPCRequest("ListBotReceptionDetailDatas", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListBotReceptionDetailDatasResponse> ListBotReceptionDetailDatasWithOptionsAsync(ListBotReceptionDetailDatasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBotReceptionDetailDatasResponse>(await DoRPCRequestAsync("ListBotReceptionDetailDatas", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListBotReceptionDetailDatasResponse ListBotReceptionDetailDatas(ListBotReceptionDetailDatasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBotReceptionDetailDatasWithOptions(request, runtime);
        }

        public async Task<ListBotReceptionDetailDatasResponse> ListBotReceptionDetailDatasAsync(ListBotReceptionDetailDatasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBotReceptionDetailDatasWithOptionsAsync(request, runtime);
        }

        public AppendEntityMemberResponse AppendEntityMemberWithOptions(AppendEntityMemberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AppendEntityMemberShrinkRequest request = new AppendEntityMemberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Member.ToMap()))
            {
                request.MemberShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Member.ToMap(), "Member", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AppendEntityMemberResponse>(DoRPCRequest("AppendEntityMember", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AppendEntityMemberResponse> AppendEntityMemberWithOptionsAsync(AppendEntityMemberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AppendEntityMemberShrinkRequest request = new AppendEntityMemberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Member.ToMap()))
            {
                request.MemberShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Member.ToMap(), "Member", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AppendEntityMemberResponse>(await DoRPCRequestAsync("AppendEntityMember", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AppendEntityMemberResponse AppendEntityMember(AppendEntityMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AppendEntityMemberWithOptions(request, runtime);
        }

        public async Task<AppendEntityMemberResponse> AppendEntityMemberAsync(AppendEntityMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AppendEntityMemberWithOptionsAsync(request, runtime);
        }

        public DescribeBotResponse DescribeBotWithOptions(DescribeBotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBotResponse>(DoRPCRequest("DescribeBot", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBotResponse> DescribeBotWithOptionsAsync(DescribeBotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBotResponse>(await DoRPCRequestAsync("DescribeBot", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBotResponse DescribeBot(DescribeBotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBotWithOptions(request, runtime);
        }

        public async Task<DescribeBotResponse> DescribeBotAsync(DescribeBotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBotWithOptionsAsync(request, runtime);
        }

        public ListBotColdDsDatasResponse ListBotColdDsDatasWithOptions(ListBotColdDsDatasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBotColdDsDatasResponse>(DoRPCRequest("ListBotColdDsDatas", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListBotColdDsDatasResponse> ListBotColdDsDatasWithOptionsAsync(ListBotColdDsDatasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBotColdDsDatasResponse>(await DoRPCRequestAsync("ListBotColdDsDatas", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListBotColdDsDatasResponse ListBotColdDsDatas(ListBotColdDsDatasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBotColdDsDatasWithOptions(request, runtime);
        }

        public async Task<ListBotColdDsDatasResponse> ListBotColdDsDatasAsync(ListBotColdDsDatasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBotColdDsDatasWithOptionsAsync(request, runtime);
        }

        public DescribePerspectiveResponse DescribePerspectiveWithOptions(DescribePerspectiveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePerspectiveResponse>(DoRPCRequest("DescribePerspective", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePerspectiveResponse> DescribePerspectiveWithOptionsAsync(DescribePerspectiveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePerspectiveResponse>(await DoRPCRequestAsync("DescribePerspective", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePerspectiveResponse DescribePerspective(DescribePerspectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePerspectiveWithOptions(request, runtime);
        }

        public async Task<DescribePerspectiveResponse> DescribePerspectiveAsync(DescribePerspectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePerspectiveWithOptionsAsync(request, runtime);
        }

        public UpdateDialogResponse UpdateDialogWithOptions(UpdateDialogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDialogResponse>(DoRPCRequest("UpdateDialog", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDialogResponse> UpdateDialogWithOptionsAsync(UpdateDialogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDialogResponse>(await DoRPCRequestAsync("UpdateDialog", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDialogResponse UpdateDialog(UpdateDialogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDialogWithOptions(request, runtime);
        }

        public async Task<UpdateDialogResponse> UpdateDialogAsync(UpdateDialogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDialogWithOptionsAsync(request, runtime);
        }

        public CreateBotResponse CreateBotWithOptions(CreateBotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBotResponse>(DoRPCRequest("CreateBot", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateBotResponse> CreateBotWithOptionsAsync(CreateBotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBotResponse>(await DoRPCRequestAsync("CreateBot", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateBotResponse CreateBot(CreateBotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBotWithOptions(request, runtime);
        }

        public async Task<CreateBotResponse> CreateBotAsync(CreateBotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBotWithOptionsAsync(request, runtime);
        }

        public DescribeIntentResponse DescribeIntentWithOptions(DescribeIntentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIntentResponse>(DoRPCRequest("DescribeIntent", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIntentResponse> DescribeIntentWithOptionsAsync(DescribeIntentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIntentResponse>(await DoRPCRequestAsync("DescribeIntent", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeIntentResponse DescribeIntent(DescribeIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIntentWithOptions(request, runtime);
        }

        public async Task<DescribeIntentResponse> DescribeIntentAsync(DescribeIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIntentWithOptionsAsync(request, runtime);
        }

        public QueryDialogsResponse QueryDialogsWithOptions(QueryDialogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDialogsResponse>(DoRPCRequest("QueryDialogs", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDialogsResponse> QueryDialogsWithOptionsAsync(QueryDialogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDialogsResponse>(await DoRPCRequestAsync("QueryDialogs", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryDialogsResponse QueryDialogs(QueryDialogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDialogsWithOptions(request, runtime);
        }

        public async Task<QueryDialogsResponse> QueryDialogsAsync(QueryDialogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDialogsWithOptionsAsync(request, runtime);
        }

        public CreateDialogResponse CreateDialogWithOptions(CreateDialogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDialogResponse>(DoRPCRequest("CreateDialog", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDialogResponse> CreateDialogWithOptionsAsync(CreateDialogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDialogResponse>(await DoRPCRequestAsync("CreateDialog", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDialogResponse CreateDialog(CreateDialogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDialogWithOptions(request, runtime);
        }

        public async Task<CreateDialogResponse> CreateDialogAsync(CreateDialogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDialogWithOptionsAsync(request, runtime);
        }

        public QueryCoreWordsResponse QueryCoreWordsWithOptions(QueryCoreWordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCoreWordsResponse>(DoRPCRequest("QueryCoreWords", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryCoreWordsResponse> QueryCoreWordsWithOptionsAsync(QueryCoreWordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCoreWordsResponse>(await DoRPCRequestAsync("QueryCoreWords", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryCoreWordsResponse QueryCoreWords(QueryCoreWordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCoreWordsWithOptions(request, runtime);
        }

        public async Task<QueryCoreWordsResponse> QueryCoreWordsAsync(QueryCoreWordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCoreWordsWithOptionsAsync(request, runtime);
        }

        public UpdateCoreWordResponse UpdateCoreWordWithOptions(UpdateCoreWordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCoreWordResponse>(DoRPCRequest("UpdateCoreWord", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCoreWordResponse> UpdateCoreWordWithOptionsAsync(UpdateCoreWordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCoreWordResponse>(await DoRPCRequestAsync("UpdateCoreWord", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCoreWordResponse UpdateCoreWord(UpdateCoreWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCoreWordWithOptions(request, runtime);
        }

        public async Task<UpdateCoreWordResponse> UpdateCoreWordAsync(UpdateCoreWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCoreWordWithOptionsAsync(request, runtime);
        }

        public UpdateCategoryResponse UpdateCategoryWithOptions(UpdateCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCategoryResponse>(DoRPCRequest("UpdateCategory", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCategoryResponse> UpdateCategoryWithOptionsAsync(UpdateCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCategoryResponse>(await DoRPCRequestAsync("UpdateCategory", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCategoryResponse UpdateCategory(UpdateCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCategoryWithOptions(request, runtime);
        }

        public async Task<UpdateCategoryResponse> UpdateCategoryAsync(UpdateCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCategoryWithOptionsAsync(request, runtime);
        }

        public GetConversationListResponse GetConversationListWithOptions(GetConversationListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetConversationListResponse>(DoRPCRequest("GetConversationList", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetConversationListResponse> GetConversationListWithOptionsAsync(GetConversationListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetConversationListResponse>(await DoRPCRequestAsync("GetConversationList", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetConversationListResponse GetConversationList(GetConversationListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConversationListWithOptions(request, runtime);
        }

        public async Task<GetConversationListResponse> GetConversationListAsync(GetConversationListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConversationListWithOptionsAsync(request, runtime);
        }

        public UpdateEntityResponse UpdateEntityWithOptions(UpdateEntityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateEntityShrinkRequest request = new UpdateEntityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Members))
            {
                request.MembersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Members, "Members", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateEntityResponse>(DoRPCRequest("UpdateEntity", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateEntityResponse> UpdateEntityWithOptionsAsync(UpdateEntityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateEntityShrinkRequest request = new UpdateEntityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Members))
            {
                request.MembersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Members, "Members", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateEntityResponse>(await DoRPCRequestAsync("UpdateEntity", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateEntityResponse UpdateEntity(UpdateEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEntityWithOptions(request, runtime);
        }

        public async Task<UpdateEntityResponse> UpdateEntityAsync(UpdateEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEntityWithOptionsAsync(request, runtime);
        }

        public DeleteCoreWordResponse DeleteCoreWordWithOptions(DeleteCoreWordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCoreWordResponse>(DoRPCRequest("DeleteCoreWord", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCoreWordResponse> DeleteCoreWordWithOptionsAsync(DeleteCoreWordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCoreWordResponse>(await DoRPCRequestAsync("DeleteCoreWord", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCoreWordResponse DeleteCoreWord(DeleteCoreWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCoreWordWithOptions(request, runtime);
        }

        public async Task<DeleteCoreWordResponse> DeleteCoreWordAsync(DeleteCoreWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCoreWordWithOptionsAsync(request, runtime);
        }

        public MoveKnowledgeCategoryResponse MoveKnowledgeCategoryWithOptions(MoveKnowledgeCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveKnowledgeCategoryResponse>(DoRPCRequest("MoveKnowledgeCategory", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MoveKnowledgeCategoryResponse> MoveKnowledgeCategoryWithOptionsAsync(MoveKnowledgeCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveKnowledgeCategoryResponse>(await DoRPCRequestAsync("MoveKnowledgeCategory", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MoveKnowledgeCategoryResponse MoveKnowledgeCategory(MoveKnowledgeCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveKnowledgeCategoryWithOptions(request, runtime);
        }

        public async Task<MoveKnowledgeCategoryResponse> MoveKnowledgeCategoryAsync(MoveKnowledgeCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveKnowledgeCategoryWithOptionsAsync(request, runtime);
        }

        public CreateIntentResponse CreateIntentWithOptions(CreateIntentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateIntentShrinkRequest request = new CreateIntentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IntentDefinition.ToMap()))
            {
                request.IntentDefinitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IntentDefinition.ToMap(), "IntentDefinition", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIntentResponse>(DoRPCRequest("CreateIntent", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateIntentResponse> CreateIntentWithOptionsAsync(CreateIntentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateIntentShrinkRequest request = new CreateIntentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IntentDefinition.ToMap()))
            {
                request.IntentDefinitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IntentDefinition.ToMap(), "IntentDefinition", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIntentResponse>(await DoRPCRequestAsync("CreateIntent", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateIntentResponse CreateIntent(CreateIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIntentWithOptions(request, runtime);
        }

        public async Task<CreateIntentResponse> CreateIntentAsync(CreateIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIntentWithOptionsAsync(request, runtime);
        }

        public UpdatePerspectiveResponse UpdatePerspectiveWithOptions(UpdatePerspectiveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePerspectiveResponse>(DoRPCRequest("UpdatePerspective", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdatePerspectiveResponse> UpdatePerspectiveWithOptionsAsync(UpdatePerspectiveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePerspectiveResponse>(await DoRPCRequestAsync("UpdatePerspective", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdatePerspectiveResponse UpdatePerspective(UpdatePerspectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePerspectiveWithOptions(request, runtime);
        }

        public async Task<UpdatePerspectiveResponse> UpdatePerspectiveAsync(UpdatePerspectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePerspectiveWithOptionsAsync(request, runtime);
        }

        public QueryCategoriesResponse QueryCategoriesWithOptions(QueryCategoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCategoriesResponse>(DoRPCRequest("QueryCategories", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryCategoriesResponse> QueryCategoriesWithOptionsAsync(QueryCategoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCategoriesResponse>(await DoRPCRequestAsync("QueryCategories", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryCategoriesResponse QueryCategories(QueryCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCategoriesWithOptions(request, runtime);
        }

        public async Task<QueryCategoriesResponse> QueryCategoriesAsync(QueryCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCategoriesWithOptionsAsync(request, runtime);
        }

        public DeleteDialogResponse DeleteDialogWithOptions(DeleteDialogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDialogResponse>(DoRPCRequest("DeleteDialog", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDialogResponse> DeleteDialogWithOptionsAsync(DeleteDialogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDialogResponse>(await DoRPCRequestAsync("DeleteDialog", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDialogResponse DeleteDialog(DeleteDialogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDialogWithOptions(request, runtime);
        }

        public async Task<DeleteDialogResponse> DeleteDialogAsync(DeleteDialogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDialogWithOptionsAsync(request, runtime);
        }

        public QueryKnowledgesResponse QueryKnowledgesWithOptions(QueryKnowledgesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryKnowledgesResponse>(DoRPCRequest("QueryKnowledges", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryKnowledgesResponse> QueryKnowledgesWithOptionsAsync(QueryKnowledgesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryKnowledgesResponse>(await DoRPCRequestAsync("QueryKnowledges", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryKnowledgesResponse QueryKnowledges(QueryKnowledgesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryKnowledgesWithOptions(request, runtime);
        }

        public async Task<QueryKnowledgesResponse> QueryKnowledgesAsync(QueryKnowledgesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryKnowledgesWithOptionsAsync(request, runtime);
        }

        public GetAsyncResultResponse GetAsyncResultWithOptions(GetAsyncResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAsyncResultResponse>(DoRPCRequest("GetAsyncResult", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAsyncResultResponse> GetAsyncResultWithOptionsAsync(GetAsyncResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAsyncResultResponse>(await DoRPCRequestAsync("GetAsyncResult", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAsyncResultResponse GetAsyncResult(GetAsyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAsyncResultWithOptions(request, runtime);
        }

        public async Task<GetAsyncResultResponse> GetAsyncResultAsync(GetAsyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAsyncResultWithOptionsAsync(request, runtime);
        }

        public DescribeDialogResponse DescribeDialogWithOptions(DescribeDialogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDialogResponse>(DoRPCRequest("DescribeDialog", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDialogResponse> DescribeDialogWithOptionsAsync(DescribeDialogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDialogResponse>(await DoRPCRequestAsync("DescribeDialog", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDialogResponse DescribeDialog(DescribeDialogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDialogWithOptions(request, runtime);
        }

        public async Task<DescribeDialogResponse> DescribeDialogAsync(DescribeDialogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDialogWithOptionsAsync(request, runtime);
        }

        public UpdateIntentResponse UpdateIntentWithOptions(UpdateIntentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateIntentShrinkRequest request = new UpdateIntentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IntentDefinition.ToMap()))
            {
                request.IntentDefinitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IntentDefinition.ToMap(), "IntentDefinition", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateIntentResponse>(DoRPCRequest("UpdateIntent", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateIntentResponse> UpdateIntentWithOptionsAsync(UpdateIntentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateIntentShrinkRequest request = new UpdateIntentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IntentDefinition.ToMap()))
            {
                request.IntentDefinitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IntentDefinition.ToMap(), "IntentDefinition", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateIntentResponse>(await DoRPCRequestAsync("UpdateIntent", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateIntentResponse UpdateIntent(UpdateIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateIntentWithOptions(request, runtime);
        }

        public async Task<UpdateIntentResponse> UpdateIntentAsync(UpdateIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateIntentWithOptionsAsync(request, runtime);
        }

        public RemoveSynonymResponse RemoveSynonymWithOptions(RemoveSynonymRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveSynonymResponse>(DoRPCRequest("RemoveSynonym", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveSynonymResponse> RemoveSynonymWithOptionsAsync(RemoveSynonymRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveSynonymResponse>(await DoRPCRequestAsync("RemoveSynonym", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveSynonymResponse RemoveSynonym(RemoveSynonymRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveSynonymWithOptions(request, runtime);
        }

        public async Task<RemoveSynonymResponse> RemoveSynonymAsync(RemoveSynonymRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveSynonymWithOptionsAsync(request, runtime);
        }

        public DescribeDialogFlowResponse DescribeDialogFlowWithOptions(DescribeDialogFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDialogFlowResponse>(DoRPCRequest("DescribeDialogFlow", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDialogFlowResponse> DescribeDialogFlowWithOptionsAsync(DescribeDialogFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDialogFlowResponse>(await DoRPCRequestAsync("DescribeDialogFlow", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDialogFlowResponse DescribeDialogFlow(DescribeDialogFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDialogFlowWithOptions(request, runtime);
        }

        public async Task<DescribeDialogFlowResponse> DescribeDialogFlowAsync(DescribeDialogFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDialogFlowWithOptionsAsync(request, runtime);
        }

        public ActivatePerspectiveResponse ActivatePerspectiveWithOptions(ActivatePerspectiveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActivatePerspectiveResponse>(DoRPCRequest("ActivatePerspective", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ActivatePerspectiveResponse> ActivatePerspectiveWithOptionsAsync(ActivatePerspectiveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActivatePerspectiveResponse>(await DoRPCRequestAsync("ActivatePerspective", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ActivatePerspectiveResponse ActivatePerspective(ActivatePerspectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActivatePerspectiveWithOptions(request, runtime);
        }

        public async Task<ActivatePerspectiveResponse> ActivatePerspectiveAsync(ActivatePerspectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActivatePerspectiveWithOptionsAsync(request, runtime);
        }

        public DescribeKnowledgeResponse DescribeKnowledgeWithOptions(DescribeKnowledgeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeKnowledgeResponse>(DoRPCRequest("DescribeKnowledge", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeKnowledgeResponse> DescribeKnowledgeWithOptionsAsync(DescribeKnowledgeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeKnowledgeResponse>(await DoRPCRequestAsync("DescribeKnowledge", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeKnowledgeResponse DescribeKnowledge(DescribeKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeKnowledgeWithOptions(request, runtime);
        }

        public async Task<DescribeKnowledgeResponse> DescribeKnowledgeAsync(DescribeKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeKnowledgeWithOptionsAsync(request, runtime);
        }

        public QueryPerspectivesResponse QueryPerspectivesWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<QueryPerspectivesResponse>(DoRPCRequest("QueryPerspectives", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryPerspectivesResponse> QueryPerspectivesWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<QueryPerspectivesResponse>(await DoRPCRequestAsync("QueryPerspectives", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryPerspectivesResponse QueryPerspectives()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPerspectivesWithOptions(runtime);
        }

        public async Task<QueryPerspectivesResponse> QueryPerspectivesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPerspectivesWithOptionsAsync(runtime);
        }

        public CreatePerspectiveResponse CreatePerspectiveWithOptions(CreatePerspectiveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePerspectiveResponse>(DoRPCRequest("CreatePerspective", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreatePerspectiveResponse> CreatePerspectiveWithOptionsAsync(CreatePerspectiveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePerspectiveResponse>(await DoRPCRequestAsync("CreatePerspective", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreatePerspectiveResponse CreatePerspective(CreatePerspectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePerspectiveWithOptions(request, runtime);
        }

        public async Task<CreatePerspectiveResponse> CreatePerspectiveAsync(CreatePerspectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePerspectiveWithOptionsAsync(request, runtime);
        }

        public DeleteEntityResponse DeleteEntityWithOptions(DeleteEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEntityResponse>(DoRPCRequest("DeleteEntity", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteEntityResponse> DeleteEntityWithOptionsAsync(DeleteEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEntityResponse>(await DoRPCRequestAsync("DeleteEntity", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteEntityResponse DeleteEntity(DeleteEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEntityWithOptions(request, runtime);
        }

        public async Task<DeleteEntityResponse> DeleteEntityAsync(DeleteEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEntityWithOptionsAsync(request, runtime);
        }

        public RemoveEntityMemberResponse RemoveEntityMemberWithOptions(RemoveEntityMemberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveEntityMemberShrinkRequest request = new RemoveEntityMemberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Member.ToMap()))
            {
                request.MemberShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Member.ToMap(), "Member", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveEntityMemberResponse>(DoRPCRequest("RemoveEntityMember", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveEntityMemberResponse> RemoveEntityMemberWithOptionsAsync(RemoveEntityMemberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveEntityMemberShrinkRequest request = new RemoveEntityMemberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Member.ToMap()))
            {
                request.MemberShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Member.ToMap(), "Member", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveEntityMemberResponse>(await DoRPCRequestAsync("RemoveEntityMember", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveEntityMemberResponse RemoveEntityMember(RemoveEntityMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveEntityMemberWithOptions(request, runtime);
        }

        public async Task<RemoveEntityMemberResponse> RemoveEntityMemberAsync(RemoveEntityMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveEntityMemberWithOptionsAsync(request, runtime);
        }

        public TestDialogFlowResponse TestDialogFlowWithOptions(TestDialogFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TestDialogFlowResponse>(DoRPCRequest("TestDialogFlow", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TestDialogFlowResponse> TestDialogFlowWithOptionsAsync(TestDialogFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TestDialogFlowResponse>(await DoRPCRequestAsync("TestDialogFlow", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TestDialogFlowResponse TestDialogFlow(TestDialogFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TestDialogFlowWithOptions(request, runtime);
        }

        public async Task<TestDialogFlowResponse> TestDialogFlowAsync(TestDialogFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TestDialogFlowWithOptionsAsync(request, runtime);
        }

        public GetBotDsStatDataResponse GetBotDsStatDataWithOptions(GetBotDsStatDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBotDsStatDataResponse>(DoRPCRequest("GetBotDsStatData", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetBotDsStatDataResponse> GetBotDsStatDataWithOptionsAsync(GetBotDsStatDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBotDsStatDataResponse>(await DoRPCRequestAsync("GetBotDsStatData", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetBotDsStatDataResponse GetBotDsStatData(GetBotDsStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBotDsStatDataWithOptions(request, runtime);
        }

        public async Task<GetBotDsStatDataResponse> GetBotDsStatDataAsync(GetBotDsStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBotDsStatDataWithOptionsAsync(request, runtime);
        }

        public FeedbackResponse FeedbackWithOptions(FeedbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FeedbackResponse>(DoRPCRequest("Feedback", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FeedbackResponse> FeedbackWithOptionsAsync(FeedbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FeedbackResponse>(await DoRPCRequestAsync("Feedback", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FeedbackResponse Feedback(FeedbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FeedbackWithOptions(request, runtime);
        }

        public async Task<FeedbackResponse> FeedbackAsync(FeedbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FeedbackWithOptionsAsync(request, runtime);
        }

        public ChatResponse ChatWithOptions(ChatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChatResponse>(DoRPCRequest("Chat", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ChatResponse> ChatWithOptionsAsync(ChatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChatResponse>(await DoRPCRequestAsync("Chat", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ChatResponse Chat(ChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChatWithOptions(request, runtime);
        }

        public async Task<ChatResponse> ChatAsync(ChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChatWithOptionsAsync(request, runtime);
        }

        public DisableKnowledgeResponse DisableKnowledgeWithOptions(DisableKnowledgeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableKnowledgeResponse>(DoRPCRequest("DisableKnowledge", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableKnowledgeResponse> DisableKnowledgeWithOptionsAsync(DisableKnowledgeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableKnowledgeResponse>(await DoRPCRequestAsync("DisableKnowledge", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableKnowledgeResponse DisableKnowledge(DisableKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableKnowledgeWithOptions(request, runtime);
        }

        public async Task<DisableKnowledgeResponse> DisableKnowledgeAsync(DisableKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableKnowledgeWithOptionsAsync(request, runtime);
        }

        public ListBotHotDsDatasResponse ListBotHotDsDatasWithOptions(ListBotHotDsDatasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBotHotDsDatasResponse>(DoRPCRequest("ListBotHotDsDatas", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListBotHotDsDatasResponse> ListBotHotDsDatasWithOptionsAsync(ListBotHotDsDatasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBotHotDsDatasResponse>(await DoRPCRequestAsync("ListBotHotDsDatas", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListBotHotDsDatasResponse ListBotHotDsDatas(ListBotHotDsDatasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBotHotDsDatasWithOptions(request, runtime);
        }

        public async Task<ListBotHotDsDatasResponse> ListBotHotDsDatasAsync(ListBotHotDsDatasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBotHotDsDatasWithOptionsAsync(request, runtime);
        }

        public GetBotKnowledgeStatDataResponse GetBotKnowledgeStatDataWithOptions(GetBotKnowledgeStatDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBotKnowledgeStatDataResponse>(DoRPCRequest("GetBotKnowledgeStatData", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetBotKnowledgeStatDataResponse> GetBotKnowledgeStatDataWithOptionsAsync(GetBotKnowledgeStatDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBotKnowledgeStatDataResponse>(await DoRPCRequestAsync("GetBotKnowledgeStatData", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetBotKnowledgeStatDataResponse GetBotKnowledgeStatData(GetBotKnowledgeStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBotKnowledgeStatDataWithOptions(request, runtime);
        }

        public async Task<GetBotKnowledgeStatDataResponse> GetBotKnowledgeStatDataAsync(GetBotKnowledgeStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBotKnowledgeStatDataWithOptionsAsync(request, runtime);
        }

        public UpdateKnowledgeResponse UpdateKnowledgeWithOptions(UpdateKnowledgeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateKnowledgeShrinkRequest request = new UpdateKnowledgeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Knowledge.ToMap()))
            {
                request.KnowledgeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Knowledge.ToMap(), "Knowledge", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateKnowledgeResponse>(DoRPCRequest("UpdateKnowledge", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateKnowledgeResponse> UpdateKnowledgeWithOptionsAsync(UpdateKnowledgeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateKnowledgeShrinkRequest request = new UpdateKnowledgeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Knowledge.ToMap()))
            {
                request.KnowledgeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Knowledge.ToMap(), "Knowledge", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateKnowledgeResponse>(await DoRPCRequestAsync("UpdateKnowledge", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateKnowledgeResponse UpdateKnowledge(UpdateKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateKnowledgeWithOptions(request, runtime);
        }

        public async Task<UpdateKnowledgeResponse> UpdateKnowledgeAsync(UpdateKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateKnowledgeWithOptionsAsync(request, runtime);
        }

        public CreateKnowledgeResponse CreateKnowledgeWithOptions(CreateKnowledgeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateKnowledgeShrinkRequest request = new CreateKnowledgeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Knowledge.ToMap()))
            {
                request.KnowledgeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Knowledge.ToMap(), "Knowledge", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateKnowledgeResponse>(DoRPCRequest("CreateKnowledge", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateKnowledgeResponse> CreateKnowledgeWithOptionsAsync(CreateKnowledgeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateKnowledgeShrinkRequest request = new CreateKnowledgeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Knowledge.ToMap()))
            {
                request.KnowledgeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Knowledge.ToMap(), "Knowledge", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateKnowledgeResponse>(await DoRPCRequestAsync("CreateKnowledge", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateKnowledgeResponse CreateKnowledge(CreateKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateKnowledgeWithOptions(request, runtime);
        }

        public async Task<CreateKnowledgeResponse> CreateKnowledgeAsync(CreateKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateKnowledgeWithOptionsAsync(request, runtime);
        }

        public DeleteIntentResponse DeleteIntentWithOptions(DeleteIntentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIntentResponse>(DoRPCRequest("DeleteIntent", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteIntentResponse> DeleteIntentWithOptionsAsync(DeleteIntentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIntentResponse>(await DoRPCRequestAsync("DeleteIntent", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteIntentResponse DeleteIntent(DeleteIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIntentWithOptions(request, runtime);
        }

        public async Task<DeleteIntentResponse> DeleteIntentAsync(DeleteIntentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIntentWithOptionsAsync(request, runtime);
        }

        public DeleteKnowledgeResponse DeleteKnowledgeWithOptions(DeleteKnowledgeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteKnowledgeResponse>(DoRPCRequest("DeleteKnowledge", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteKnowledgeResponse> DeleteKnowledgeWithOptionsAsync(DeleteKnowledgeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteKnowledgeResponse>(await DoRPCRequestAsync("DeleteKnowledge", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteKnowledgeResponse DeleteKnowledge(DeleteKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteKnowledgeWithOptions(request, runtime);
        }

        public async Task<DeleteKnowledgeResponse> DeleteKnowledgeAsync(DeleteKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteKnowledgeWithOptionsAsync(request, runtime);
        }

        public ListBotChatHistorysResponse ListBotChatHistorysWithOptions(ListBotChatHistorysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBotChatHistorysResponse>(DoRPCRequest("ListBotChatHistorys", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListBotChatHistorysResponse> ListBotChatHistorysWithOptionsAsync(ListBotChatHistorysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBotChatHistorysResponse>(await DoRPCRequestAsync("ListBotChatHistorys", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListBotChatHistorysResponse ListBotChatHistorys(ListBotChatHistorysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBotChatHistorysWithOptions(request, runtime);
        }

        public async Task<ListBotChatHistorysResponse> ListBotChatHistorysAsync(ListBotChatHistorysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBotChatHistorysWithOptionsAsync(request, runtime);
        }

        public DisableDialogFlowResponse DisableDialogFlowWithOptions(DisableDialogFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableDialogFlowResponse>(DoRPCRequest("DisableDialogFlow", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableDialogFlowResponse> DisableDialogFlowWithOptionsAsync(DisableDialogFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableDialogFlowResponse>(await DoRPCRequestAsync("DisableDialogFlow", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableDialogFlowResponse DisableDialogFlow(DisableDialogFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableDialogFlowWithOptions(request, runtime);
        }

        public async Task<DisableDialogFlowResponse> DisableDialogFlowAsync(DisableDialogFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableDialogFlowWithOptionsAsync(request, runtime);
        }

        public QueryBotsResponse QueryBotsWithOptions(QueryBotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryBotsResponse>(DoRPCRequest("QueryBots", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryBotsResponse> QueryBotsWithOptionsAsync(QueryBotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryBotsResponse>(await DoRPCRequestAsync("QueryBots", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryBotsResponse QueryBots(QueryBotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBotsWithOptions(request, runtime);
        }

        public async Task<QueryBotsResponse> QueryBotsAsync(QueryBotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBotsWithOptionsAsync(request, runtime);
        }

        public PublishDialogFlowResponse PublishDialogFlowWithOptions(PublishDialogFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishDialogFlowResponse>(DoRPCRequest("PublishDialogFlow", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PublishDialogFlowResponse> PublishDialogFlowWithOptionsAsync(PublishDialogFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishDialogFlowResponse>(await DoRPCRequestAsync("PublishDialogFlow", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PublishDialogFlowResponse PublishDialogFlow(PublishDialogFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishDialogFlowWithOptions(request, runtime);
        }

        public async Task<PublishDialogFlowResponse> PublishDialogFlowAsync(PublishDialogFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishDialogFlowWithOptionsAsync(request, runtime);
        }

        public ListBotColdKnowledgesResponse ListBotColdKnowledgesWithOptions(ListBotColdKnowledgesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBotColdKnowledgesResponse>(DoRPCRequest("ListBotColdKnowledges", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListBotColdKnowledgesResponse> ListBotColdKnowledgesWithOptionsAsync(ListBotColdKnowledgesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBotColdKnowledgesResponse>(await DoRPCRequestAsync("ListBotColdKnowledges", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListBotColdKnowledgesResponse ListBotColdKnowledges(ListBotColdKnowledgesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBotColdKnowledgesWithOptions(request, runtime);
        }

        public async Task<ListBotColdKnowledgesResponse> ListBotColdKnowledgesAsync(ListBotColdKnowledgesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBotColdKnowledgesWithOptionsAsync(request, runtime);
        }

        public CreateCoreWordResponse CreateCoreWordWithOptions(CreateCoreWordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCoreWordResponse>(DoRPCRequest("CreateCoreWord", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCoreWordResponse> CreateCoreWordWithOptionsAsync(CreateCoreWordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCoreWordResponse>(await DoRPCRequestAsync("CreateCoreWord", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCoreWordResponse CreateCoreWord(CreateCoreWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCoreWordWithOptions(request, runtime);
        }

        public async Task<CreateCoreWordResponse> CreateCoreWordAsync(CreateCoreWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCoreWordWithOptionsAsync(request, runtime);
        }

        public DeleteBotResponse DeleteBotWithOptions(DeleteBotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBotResponse>(DoRPCRequest("DeleteBot", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteBotResponse> DeleteBotWithOptionsAsync(DeleteBotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBotResponse>(await DoRPCRequestAsync("DeleteBot", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteBotResponse DeleteBot(DeleteBotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBotWithOptions(request, runtime);
        }

        public async Task<DeleteBotResponse> DeleteBotAsync(DeleteBotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBotWithOptionsAsync(request, runtime);
        }

        public QuerySystemEntitiesResponse QuerySystemEntitiesWithOptions(QuerySystemEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySystemEntitiesResponse>(DoRPCRequest("QuerySystemEntities", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QuerySystemEntitiesResponse> QuerySystemEntitiesWithOptionsAsync(QuerySystemEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySystemEntitiesResponse>(await DoRPCRequestAsync("QuerySystemEntities", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QuerySystemEntitiesResponse QuerySystemEntities(QuerySystemEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySystemEntitiesWithOptions(request, runtime);
        }

        public async Task<QuerySystemEntitiesResponse> QuerySystemEntitiesAsync(QuerySystemEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySystemEntitiesWithOptionsAsync(request, runtime);
        }

        public ListConversationLogsResponse ListConversationLogsWithOptions(ListConversationLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListConversationLogsResponse>(DoRPCRequest("ListConversationLogs", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListConversationLogsResponse> ListConversationLogsWithOptionsAsync(ListConversationLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListConversationLogsResponse>(await DoRPCRequestAsync("ListConversationLogs", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListConversationLogsResponse ListConversationLogs(ListConversationLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConversationLogsWithOptions(request, runtime);
        }

        public async Task<ListConversationLogsResponse> ListConversationLogsAsync(ListConversationLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConversationLogsWithOptionsAsync(request, runtime);
        }

        public GetBotChatDataResponse GetBotChatDataWithOptions(GetBotChatDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBotChatDataResponse>(DoRPCRequest("GetBotChatData", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetBotChatDataResponse> GetBotChatDataWithOptionsAsync(GetBotChatDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBotChatDataResponse>(await DoRPCRequestAsync("GetBotChatData", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetBotChatDataResponse GetBotChatData(GetBotChatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBotChatDataWithOptions(request, runtime);
        }

        public async Task<GetBotChatDataResponse> GetBotChatDataAsync(GetBotChatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBotChatDataWithOptionsAsync(request, runtime);
        }

        public DescribeCoreWordResponse DescribeCoreWordWithOptions(DescribeCoreWordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCoreWordResponse>(DoRPCRequest("DescribeCoreWord", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCoreWordResponse> DescribeCoreWordWithOptionsAsync(DescribeCoreWordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCoreWordResponse>(await DoRPCRequestAsync("DescribeCoreWord", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCoreWordResponse DescribeCoreWord(DescribeCoreWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCoreWordWithOptions(request, runtime);
        }

        public async Task<DescribeCoreWordResponse> DescribeCoreWordAsync(DescribeCoreWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCoreWordWithOptionsAsync(request, runtime);
        }

        public GetBotSessionDataResponse GetBotSessionDataWithOptions(GetBotSessionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBotSessionDataResponse>(DoRPCRequest("GetBotSessionData", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetBotSessionDataResponse> GetBotSessionDataWithOptionsAsync(GetBotSessionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBotSessionDataResponse>(await DoRPCRequestAsync("GetBotSessionData", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetBotSessionDataResponse GetBotSessionData(GetBotSessionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBotSessionDataWithOptions(request, runtime);
        }

        public async Task<GetBotSessionDataResponse> GetBotSessionDataAsync(GetBotSessionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBotSessionDataWithOptionsAsync(request, runtime);
        }

        public ListBotHotKnowledgesResponse ListBotHotKnowledgesWithOptions(ListBotHotKnowledgesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBotHotKnowledgesResponse>(DoRPCRequest("ListBotHotKnowledges", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListBotHotKnowledgesResponse> ListBotHotKnowledgesWithOptionsAsync(ListBotHotKnowledgesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBotHotKnowledgesResponse>(await DoRPCRequestAsync("ListBotHotKnowledges", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListBotHotKnowledgesResponse ListBotHotKnowledges(ListBotHotKnowledgesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBotHotKnowledgesWithOptions(request, runtime);
        }

        public async Task<ListBotHotKnowledgesResponse> ListBotHotKnowledgesAsync(ListBotHotKnowledgesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBotHotKnowledgesWithOptionsAsync(request, runtime);
        }

        public QueryEntitiesResponse QueryEntitiesWithOptions(QueryEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryEntitiesResponse>(DoRPCRequest("QueryEntities", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryEntitiesResponse> QueryEntitiesWithOptionsAsync(QueryEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryEntitiesResponse>(await DoRPCRequestAsync("QueryEntities", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryEntitiesResponse QueryEntities(QueryEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEntitiesWithOptions(request, runtime);
        }

        public async Task<QueryEntitiesResponse> QueryEntitiesAsync(QueryEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEntitiesWithOptionsAsync(request, runtime);
        }

        public UpdateDialogFlowResponse UpdateDialogFlowWithOptions(UpdateDialogFlowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDialogFlowShrinkRequest request = new UpdateDialogFlowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ModuleDefinition.ToMap()))
            {
                request.ModuleDefinitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ModuleDefinition.ToMap(), "ModuleDefinition", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDialogFlowResponse>(DoRPCRequest("UpdateDialogFlow", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDialogFlowResponse> UpdateDialogFlowWithOptionsAsync(UpdateDialogFlowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDialogFlowShrinkRequest request = new UpdateDialogFlowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ModuleDefinition.ToMap()))
            {
                request.ModuleDefinitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ModuleDefinition.ToMap(), "ModuleDefinition", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDialogFlowResponse>(await DoRPCRequestAsync("UpdateDialogFlow", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDialogFlowResponse UpdateDialogFlow(UpdateDialogFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDialogFlowWithOptions(request, runtime);
        }

        public async Task<UpdateDialogFlowResponse> UpdateDialogFlowAsync(UpdateDialogFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDialogFlowWithOptionsAsync(request, runtime);
        }

        public ListBotDsDetailsResponse ListBotDsDetailsWithOptions(ListBotDsDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBotDsDetailsResponse>(DoRPCRequest("ListBotDsDetails", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListBotDsDetailsResponse> ListBotDsDetailsWithOptionsAsync(ListBotDsDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBotDsDetailsResponse>(await DoRPCRequestAsync("ListBotDsDetails", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListBotDsDetailsResponse ListBotDsDetails(ListBotDsDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBotDsDetailsWithOptions(request, runtime);
        }

        public async Task<ListBotDsDetailsResponse> ListBotDsDetailsAsync(ListBotDsDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBotDsDetailsWithOptionsAsync(request, runtime);
        }

        public AssociateResponse AssociateWithOptions(AssociateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateResponse>(DoRPCRequest("Associate", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssociateResponse> AssociateWithOptionsAsync(AssociateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateResponse>(await DoRPCRequestAsync("Associate", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssociateResponse Associate(AssociateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateWithOptions(request, runtime);
        }

        public async Task<AssociateResponse> AssociateAsync(AssociateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateWithOptionsAsync(request, runtime);
        }

        public CreateCategoryResponse CreateCategoryWithOptions(CreateCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCategoryResponse>(DoRPCRequest("CreateCategory", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCategoryResponse> CreateCategoryWithOptionsAsync(CreateCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCategoryResponse>(await DoRPCRequestAsync("CreateCategory", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCategoryResponse CreateCategory(CreateCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCategoryWithOptions(request, runtime);
        }

        public async Task<CreateCategoryResponse> CreateCategoryAsync(CreateCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCategoryWithOptionsAsync(request, runtime);
        }

        public DescribeEntitiesResponse DescribeEntitiesWithOptions(DescribeEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEntitiesResponse>(DoRPCRequest("DescribeEntities", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEntitiesResponse> DescribeEntitiesWithOptionsAsync(DescribeEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEntitiesResponse>(await DoRPCRequestAsync("DescribeEntities", "2017-10-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEntitiesResponse DescribeEntities(DescribeEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEntitiesWithOptions(request, runtime);
        }

        public async Task<DescribeEntitiesResponse> DescribeEntitiesAsync(DescribeEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEntitiesWithOptionsAsync(request, runtime);
        }

    }
}
