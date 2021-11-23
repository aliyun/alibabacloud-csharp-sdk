// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Rtc20180111.Models;

namespace AlibabaCloud.SDK.Rtc20180111
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("rtc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddRecordTemplateResponse AddRecordTemplateWithOptions(AddRecordTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddRecordTemplateResponse>(DoRPCRequest("AddRecordTemplate", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddRecordTemplateResponse> AddRecordTemplateWithOptionsAsync(AddRecordTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddRecordTemplateResponse>(await DoRPCRequestAsync("AddRecordTemplate", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddRecordTemplateResponse AddRecordTemplate(AddRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddRecordTemplateWithOptions(request, runtime);
        }

        public async Task<AddRecordTemplateResponse> AddRecordTemplateAsync(AddRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddRecordTemplateWithOptionsAsync(request, runtime);
        }

        public CreateAutoLiveStreamRuleResponse CreateAutoLiveStreamRuleWithOptions(CreateAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAutoLiveStreamRuleResponse>(DoRPCRequest("CreateAutoLiveStreamRule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAutoLiveStreamRuleResponse> CreateAutoLiveStreamRuleWithOptionsAsync(CreateAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAutoLiveStreamRuleResponse>(await DoRPCRequestAsync("CreateAutoLiveStreamRule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAutoLiveStreamRuleResponse CreateAutoLiveStreamRule(CreateAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAutoLiveStreamRuleWithOptions(request, runtime);
        }

        public async Task<CreateAutoLiveStreamRuleResponse> CreateAutoLiveStreamRuleAsync(CreateAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

        public CreateEventSubscribeResponse CreateEventSubscribeWithOptions(CreateEventSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEventSubscribeResponse>(DoRPCRequest("CreateEventSubscribe", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateEventSubscribeResponse> CreateEventSubscribeWithOptionsAsync(CreateEventSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEventSubscribeResponse>(await DoRPCRequestAsync("CreateEventSubscribe", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateEventSubscribeResponse CreateEventSubscribe(CreateEventSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEventSubscribeWithOptions(request, runtime);
        }

        public async Task<CreateEventSubscribeResponse> CreateEventSubscribeAsync(CreateEventSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEventSubscribeWithOptionsAsync(request, runtime);
        }

        public CreateMPULayoutResponse CreateMPULayoutWithOptions(CreateMPULayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMPULayoutResponse>(DoRPCRequest("CreateMPULayout", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMPULayoutResponse> CreateMPULayoutWithOptionsAsync(CreateMPULayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMPULayoutResponse>(await DoRPCRequestAsync("CreateMPULayout", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMPULayoutResponse CreateMPULayout(CreateMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMPULayoutWithOptions(request, runtime);
        }

        public async Task<CreateMPULayoutResponse> CreateMPULayoutAsync(CreateMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMPULayoutWithOptionsAsync(request, runtime);
        }

        public CreateRecordIndexFileResponse CreateRecordIndexFileWithOptions(CreateRecordIndexFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRecordIndexFileResponse>(DoRPCRequest("CreateRecordIndexFile", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRecordIndexFileResponse> CreateRecordIndexFileWithOptionsAsync(CreateRecordIndexFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRecordIndexFileResponse>(await DoRPCRequestAsync("CreateRecordIndexFile", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRecordIndexFileResponse CreateRecordIndexFile(CreateRecordIndexFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRecordIndexFileWithOptions(request, runtime);
        }

        public async Task<CreateRecordIndexFileResponse> CreateRecordIndexFileAsync(CreateRecordIndexFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRecordIndexFileWithOptionsAsync(request, runtime);
        }

        public DeleteAutoLiveStreamRuleResponse DeleteAutoLiveStreamRuleWithOptions(DeleteAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAutoLiveStreamRuleResponse>(DoRPCRequest("DeleteAutoLiveStreamRule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAutoLiveStreamRuleResponse> DeleteAutoLiveStreamRuleWithOptionsAsync(DeleteAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAutoLiveStreamRuleResponse>(await DoRPCRequestAsync("DeleteAutoLiveStreamRule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAutoLiveStreamRuleResponse DeleteAutoLiveStreamRule(DeleteAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAutoLiveStreamRuleWithOptions(request, runtime);
        }

        public async Task<DeleteAutoLiveStreamRuleResponse> DeleteAutoLiveStreamRuleAsync(DeleteAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

        public DeleteEventSubscribeResponse DeleteEventSubscribeWithOptions(DeleteEventSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEventSubscribeResponse>(DoRPCRequest("DeleteEventSubscribe", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteEventSubscribeResponse> DeleteEventSubscribeWithOptionsAsync(DeleteEventSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEventSubscribeResponse>(await DoRPCRequestAsync("DeleteEventSubscribe", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteEventSubscribeResponse DeleteEventSubscribe(DeleteEventSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEventSubscribeWithOptions(request, runtime);
        }

        public async Task<DeleteEventSubscribeResponse> DeleteEventSubscribeAsync(DeleteEventSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEventSubscribeWithOptionsAsync(request, runtime);
        }

        public DeleteMPULayoutResponse DeleteMPULayoutWithOptions(DeleteMPULayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMPULayoutResponse>(DoRPCRequest("DeleteMPULayout", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMPULayoutResponse> DeleteMPULayoutWithOptionsAsync(DeleteMPULayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMPULayoutResponse>(await DoRPCRequestAsync("DeleteMPULayout", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMPULayoutResponse DeleteMPULayout(DeleteMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMPULayoutWithOptions(request, runtime);
        }

        public async Task<DeleteMPULayoutResponse> DeleteMPULayoutAsync(DeleteMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMPULayoutWithOptionsAsync(request, runtime);
        }

        public DeleteRecordTemplateResponse DeleteRecordTemplateWithOptions(DeleteRecordTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRecordTemplateResponse>(DoRPCRequest("DeleteRecordTemplate", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRecordTemplateResponse> DeleteRecordTemplateWithOptionsAsync(DeleteRecordTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRecordTemplateResponse>(await DoRPCRequestAsync("DeleteRecordTemplate", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRecordTemplateResponse DeleteRecordTemplate(DeleteRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRecordTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteRecordTemplateResponse> DeleteRecordTemplateAsync(DeleteRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRecordTemplateWithOptionsAsync(request, runtime);
        }

        public DescribeAutoLiveStreamRuleResponse DescribeAutoLiveStreamRuleWithOptions(DescribeAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutoLiveStreamRuleResponse>(DoRPCRequest("DescribeAutoLiveStreamRule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAutoLiveStreamRuleResponse> DescribeAutoLiveStreamRuleWithOptionsAsync(DescribeAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutoLiveStreamRuleResponse>(await DoRPCRequestAsync("DescribeAutoLiveStreamRule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAutoLiveStreamRuleResponse DescribeAutoLiveStreamRule(DescribeAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutoLiveStreamRuleWithOptions(request, runtime);
        }

        public async Task<DescribeAutoLiveStreamRuleResponse> DescribeAutoLiveStreamRuleAsync(DescribeAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

        public DescribeChannelParticipantsResponse DescribeChannelParticipantsWithOptions(DescribeChannelParticipantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeChannelParticipantsResponse>(DoRPCRequest("DescribeChannelParticipants", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeChannelParticipantsResponse> DescribeChannelParticipantsWithOptionsAsync(DescribeChannelParticipantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeChannelParticipantsResponse>(await DoRPCRequestAsync("DescribeChannelParticipants", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeChannelParticipantsResponse DescribeChannelParticipants(DescribeChannelParticipantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelParticipantsWithOptions(request, runtime);
        }

        public async Task<DescribeChannelParticipantsResponse> DescribeChannelParticipantsAsync(DescribeChannelParticipantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelParticipantsWithOptionsAsync(request, runtime);
        }

        public DescribeChannelUsersResponse DescribeChannelUsersWithOptions(DescribeChannelUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeChannelUsersResponse>(DoRPCRequest("DescribeChannelUsers", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeChannelUsersResponse> DescribeChannelUsersWithOptionsAsync(DescribeChannelUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeChannelUsersResponse>(await DoRPCRequestAsync("DescribeChannelUsers", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeChannelUsersResponse DescribeChannelUsers(DescribeChannelUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelUsersWithOptions(request, runtime);
        }

        public async Task<DescribeChannelUsersResponse> DescribeChannelUsersAsync(DescribeChannelUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelUsersWithOptionsAsync(request, runtime);
        }

        public DescribeMPULayoutInfoListResponse DescribeMPULayoutInfoListWithOptions(DescribeMPULayoutInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMPULayoutInfoListResponse>(DoRPCRequest("DescribeMPULayoutInfoList", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMPULayoutInfoListResponse> DescribeMPULayoutInfoListWithOptionsAsync(DescribeMPULayoutInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMPULayoutInfoListResponse>(await DoRPCRequestAsync("DescribeMPULayoutInfoList", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMPULayoutInfoListResponse DescribeMPULayoutInfoList(DescribeMPULayoutInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMPULayoutInfoListWithOptions(request, runtime);
        }

        public async Task<DescribeMPULayoutInfoListResponse> DescribeMPULayoutInfoListAsync(DescribeMPULayoutInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMPULayoutInfoListWithOptionsAsync(request, runtime);
        }

        public DescribeRecordFilesResponse DescribeRecordFilesWithOptions(DescribeRecordFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordFilesResponse>(DoRPCRequest("DescribeRecordFiles", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRecordFilesResponse> DescribeRecordFilesWithOptionsAsync(DescribeRecordFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordFilesResponse>(await DoRPCRequestAsync("DescribeRecordFiles", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRecordFilesResponse DescribeRecordFiles(DescribeRecordFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordFilesWithOptions(request, runtime);
        }

        public async Task<DescribeRecordFilesResponse> DescribeRecordFilesAsync(DescribeRecordFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordFilesWithOptionsAsync(request, runtime);
        }

        public DescribeRecordTasksResponse DescribeRecordTasksWithOptions(DescribeRecordTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordTasksResponse>(DoRPCRequest("DescribeRecordTasks", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRecordTasksResponse> DescribeRecordTasksWithOptionsAsync(DescribeRecordTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordTasksResponse>(await DoRPCRequestAsync("DescribeRecordTasks", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRecordTasksResponse DescribeRecordTasks(DescribeRecordTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordTasksWithOptions(request, runtime);
        }

        public async Task<DescribeRecordTasksResponse> DescribeRecordTasksAsync(DescribeRecordTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordTasksWithOptionsAsync(request, runtime);
        }

        public DescribeRecordTemplatesResponse DescribeRecordTemplatesWithOptions(DescribeRecordTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordTemplatesResponse>(DoRPCRequest("DescribeRecordTemplates", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRecordTemplatesResponse> DescribeRecordTemplatesWithOptionsAsync(DescribeRecordTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordTemplatesResponse>(await DoRPCRequestAsync("DescribeRecordTemplates", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRecordTemplatesResponse DescribeRecordTemplates(DescribeRecordTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordTemplatesWithOptions(request, runtime);
        }

        public async Task<DescribeRecordTemplatesResponse> DescribeRecordTemplatesAsync(DescribeRecordTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordTemplatesWithOptionsAsync(request, runtime);
        }

        public DescribeUserInfoInChannelResponse DescribeUserInfoInChannelWithOptions(DescribeUserInfoInChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserInfoInChannelResponse>(DoRPCRequest("DescribeUserInfoInChannel", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserInfoInChannelResponse> DescribeUserInfoInChannelWithOptionsAsync(DescribeUserInfoInChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserInfoInChannelResponse>(await DoRPCRequestAsync("DescribeUserInfoInChannel", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserInfoInChannelResponse DescribeUserInfoInChannel(DescribeUserInfoInChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserInfoInChannelWithOptions(request, runtime);
        }

        public async Task<DescribeUserInfoInChannelResponse> DescribeUserInfoInChannelAsync(DescribeUserInfoInChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserInfoInChannelWithOptionsAsync(request, runtime);
        }

        public DisableAutoLiveStreamRuleResponse DisableAutoLiveStreamRuleWithOptions(DisableAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableAutoLiveStreamRuleResponse>(DoRPCRequest("DisableAutoLiveStreamRule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableAutoLiveStreamRuleResponse> DisableAutoLiveStreamRuleWithOptionsAsync(DisableAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableAutoLiveStreamRuleResponse>(await DoRPCRequestAsync("DisableAutoLiveStreamRule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableAutoLiveStreamRuleResponse DisableAutoLiveStreamRule(DisableAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableAutoLiveStreamRuleWithOptions(request, runtime);
        }

        public async Task<DisableAutoLiveStreamRuleResponse> DisableAutoLiveStreamRuleAsync(DisableAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

        public EnableAutoLiveStreamRuleResponse EnableAutoLiveStreamRuleWithOptions(EnableAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableAutoLiveStreamRuleResponse>(DoRPCRequest("EnableAutoLiveStreamRule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableAutoLiveStreamRuleResponse> EnableAutoLiveStreamRuleWithOptionsAsync(EnableAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableAutoLiveStreamRuleResponse>(await DoRPCRequestAsync("EnableAutoLiveStreamRule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableAutoLiveStreamRuleResponse EnableAutoLiveStreamRule(EnableAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableAutoLiveStreamRuleWithOptions(request, runtime);
        }

        public async Task<EnableAutoLiveStreamRuleResponse> EnableAutoLiveStreamRuleAsync(EnableAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

        public GetMPUTaskStatusResponse GetMPUTaskStatusWithOptions(GetMPUTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMPUTaskStatusResponse>(DoRPCRequest("GetMPUTaskStatus", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMPUTaskStatusResponse> GetMPUTaskStatusWithOptionsAsync(GetMPUTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMPUTaskStatusResponse>(await DoRPCRequestAsync("GetMPUTaskStatus", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMPUTaskStatusResponse GetMPUTaskStatus(GetMPUTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMPUTaskStatusWithOptions(request, runtime);
        }

        public async Task<GetMPUTaskStatusResponse> GetMPUTaskStatusAsync(GetMPUTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMPUTaskStatusWithOptionsAsync(request, runtime);
        }

        public ModifyMPULayoutResponse ModifyMPULayoutWithOptions(ModifyMPULayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyMPULayoutResponse>(DoRPCRequest("ModifyMPULayout", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyMPULayoutResponse> ModifyMPULayoutWithOptionsAsync(ModifyMPULayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyMPULayoutResponse>(await DoRPCRequestAsync("ModifyMPULayout", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyMPULayoutResponse ModifyMPULayout(ModifyMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMPULayoutWithOptions(request, runtime);
        }

        public async Task<ModifyMPULayoutResponse> ModifyMPULayoutAsync(ModifyMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMPULayoutWithOptionsAsync(request, runtime);
        }

        public RemoveTerminalsResponse RemoveTerminalsWithOptions(RemoveTerminalsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveTerminalsResponse>(DoRPCRequest("RemoveTerminals", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveTerminalsResponse> RemoveTerminalsWithOptionsAsync(RemoveTerminalsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveTerminalsResponse>(await DoRPCRequestAsync("RemoveTerminals", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveTerminalsResponse RemoveTerminals(RemoveTerminalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveTerminalsWithOptions(request, runtime);
        }

        public async Task<RemoveTerminalsResponse> RemoveTerminalsAsync(RemoveTerminalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveTerminalsWithOptionsAsync(request, runtime);
        }

        public StartMPUTaskResponse StartMPUTaskWithOptions(StartMPUTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartMPUTaskResponse>(DoRPCRequest("StartMPUTask", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartMPUTaskResponse> StartMPUTaskWithOptionsAsync(StartMPUTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartMPUTaskResponse>(await DoRPCRequestAsync("StartMPUTask", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartMPUTaskResponse StartMPUTask(StartMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartMPUTaskWithOptions(request, runtime);
        }

        public async Task<StartMPUTaskResponse> StartMPUTaskAsync(StartMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartMPUTaskWithOptionsAsync(request, runtime);
        }

        public StartRecordTaskResponse StartRecordTaskWithOptions(StartRecordTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartRecordTaskResponse>(DoRPCRequest("StartRecordTask", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartRecordTaskResponse> StartRecordTaskWithOptionsAsync(StartRecordTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartRecordTaskResponse>(await DoRPCRequestAsync("StartRecordTask", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartRecordTaskResponse StartRecordTask(StartRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartRecordTaskWithOptions(request, runtime);
        }

        public async Task<StartRecordTaskResponse> StartRecordTaskAsync(StartRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartRecordTaskWithOptionsAsync(request, runtime);
        }

        public StopChannelUserPublishResponse StopChannelUserPublishWithOptions(StopChannelUserPublishRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopChannelUserPublishResponse>(DoRPCRequest("StopChannelUserPublish", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopChannelUserPublishResponse> StopChannelUserPublishWithOptionsAsync(StopChannelUserPublishRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopChannelUserPublishResponse>(await DoRPCRequestAsync("StopChannelUserPublish", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopChannelUserPublishResponse StopChannelUserPublish(StopChannelUserPublishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopChannelUserPublishWithOptions(request, runtime);
        }

        public async Task<StopChannelUserPublishResponse> StopChannelUserPublishAsync(StopChannelUserPublishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopChannelUserPublishWithOptionsAsync(request, runtime);
        }

        public StopMPUTaskResponse StopMPUTaskWithOptions(StopMPUTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopMPUTaskResponse>(DoRPCRequest("StopMPUTask", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopMPUTaskResponse> StopMPUTaskWithOptionsAsync(StopMPUTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopMPUTaskResponse>(await DoRPCRequestAsync("StopMPUTask", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopMPUTaskResponse StopMPUTask(StopMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopMPUTaskWithOptions(request, runtime);
        }

        public async Task<StopMPUTaskResponse> StopMPUTaskAsync(StopMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopMPUTaskWithOptionsAsync(request, runtime);
        }

        public StopRecordTaskResponse StopRecordTaskWithOptions(StopRecordTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopRecordTaskResponse>(DoRPCRequest("StopRecordTask", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopRecordTaskResponse> StopRecordTaskWithOptionsAsync(StopRecordTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopRecordTaskResponse>(await DoRPCRequestAsync("StopRecordTask", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopRecordTaskResponse StopRecordTask(StopRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopRecordTaskWithOptions(request, runtime);
        }

        public async Task<StopRecordTaskResponse> StopRecordTaskAsync(StopRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopRecordTaskWithOptionsAsync(request, runtime);
        }

        public UpdateAutoLiveStreamRuleResponse UpdateAutoLiveStreamRuleWithOptions(UpdateAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAutoLiveStreamRuleResponse>(DoRPCRequest("UpdateAutoLiveStreamRule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAutoLiveStreamRuleResponse> UpdateAutoLiveStreamRuleWithOptionsAsync(UpdateAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAutoLiveStreamRuleResponse>(await DoRPCRequestAsync("UpdateAutoLiveStreamRule", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAutoLiveStreamRuleResponse UpdateAutoLiveStreamRule(UpdateAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAutoLiveStreamRuleWithOptions(request, runtime);
        }

        public async Task<UpdateAutoLiveStreamRuleResponse> UpdateAutoLiveStreamRuleAsync(UpdateAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

        public UpdateMPUTaskResponse UpdateMPUTaskWithOptions(UpdateMPUTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMPUTaskResponse>(DoRPCRequest("UpdateMPUTask", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateMPUTaskResponse> UpdateMPUTaskWithOptionsAsync(UpdateMPUTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMPUTaskResponse>(await DoRPCRequestAsync("UpdateMPUTask", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateMPUTaskResponse UpdateMPUTask(UpdateMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMPUTaskWithOptions(request, runtime);
        }

        public async Task<UpdateMPUTaskResponse> UpdateMPUTaskAsync(UpdateMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMPUTaskWithOptionsAsync(request, runtime);
        }

        public UpdateRecordTaskResponse UpdateRecordTaskWithOptions(UpdateRecordTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRecordTaskResponse>(DoRPCRequest("UpdateRecordTask", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateRecordTaskResponse> UpdateRecordTaskWithOptionsAsync(UpdateRecordTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRecordTaskResponse>(await DoRPCRequestAsync("UpdateRecordTask", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateRecordTaskResponse UpdateRecordTask(UpdateRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRecordTaskWithOptions(request, runtime);
        }

        public async Task<UpdateRecordTaskResponse> UpdateRecordTaskAsync(UpdateRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRecordTaskWithOptionsAsync(request, runtime);
        }

        public UpdateRecordTemplateResponse UpdateRecordTemplateWithOptions(UpdateRecordTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRecordTemplateResponse>(DoRPCRequest("UpdateRecordTemplate", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateRecordTemplateResponse> UpdateRecordTemplateWithOptionsAsync(UpdateRecordTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRecordTemplateResponse>(await DoRPCRequestAsync("UpdateRecordTemplate", "2018-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateRecordTemplateResponse UpdateRecordTemplate(UpdateRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRecordTemplateWithOptions(request, runtime);
        }

        public async Task<UpdateRecordTemplateResponse> UpdateRecordTemplateAsync(UpdateRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRecordTemplateWithOptionsAsync(request, runtime);
        }

    }
}
