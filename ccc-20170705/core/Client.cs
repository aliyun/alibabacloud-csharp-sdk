// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.CCC20170705.Models;

namespace AlibabaCloud.SDK.CCC20170705
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "ccc.aliyuncs.com"},
                {"ap-south-1", "ccc.aliyuncs.com"},
                {"ap-southeast-1", "ccc.aliyuncs.com"},
                {"ap-southeast-2", "ccc.aliyuncs.com"},
                {"ap-southeast-3", "ccc.aliyuncs.com"},
                {"ap-southeast-5", "ccc.aliyuncs.com"},
                {"cn-beijing", "ccc.aliyuncs.com"},
                {"cn-chengdu", "ccc.aliyuncs.com"},
                {"cn-hongkong", "ccc.aliyuncs.com"},
                {"cn-huhehaote", "ccc.aliyuncs.com"},
                {"cn-qingdao", "ccc.aliyuncs.com"},
                {"cn-shenzhen", "ccc.aliyuncs.com"},
                {"cn-zhangjiakou", "ccc.aliyuncs.com"},
                {"eu-central-1", "ccc.aliyuncs.com"},
                {"eu-west-1", "ccc.aliyuncs.com"},
                {"me-east-1", "ccc.aliyuncs.com"},
                {"us-east-1", "ccc.aliyuncs.com"},
                {"us-west-1", "ccc.aliyuncs.com"},
                {"cn-hangzhou-finance", "ccc.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "ccc.aliyuncs.com"},
                {"cn-shanghai-finance-1", "ccc.aliyuncs.com"},
                {"cn-north-2-gov-1", "ccc.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("ccc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AbortPredictiveJobsResponse AbortPredictiveJobsWithOptions(AbortPredictiveJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AbortPredictiveJobsResponse>(DoRPCRequest("AbortPredictiveJobs", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AbortPredictiveJobsResponse> AbortPredictiveJobsWithOptionsAsync(AbortPredictiveJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AbortPredictiveJobsResponse>(await DoRPCRequestAsync("AbortPredictiveJobs", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AbortPredictiveJobsResponse AbortPredictiveJobs(AbortPredictiveJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AbortPredictiveJobsWithOptions(request, runtime);
        }

        public async Task<AbortPredictiveJobsResponse> AbortPredictiveJobsAsync(AbortPredictiveJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AbortPredictiveJobsWithOptionsAsync(request, runtime);
        }

        public AddAgentDeviceResponse AddAgentDeviceWithOptions(AddAgentDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddAgentDeviceResponse>(DoRPCRequest("AddAgentDevice", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddAgentDeviceResponse> AddAgentDeviceWithOptionsAsync(AddAgentDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddAgentDeviceResponse>(await DoRPCRequestAsync("AddAgentDevice", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddAgentDeviceResponse AddAgentDevice(AddAgentDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAgentDeviceWithOptions(request, runtime);
        }

        public async Task<AddAgentDeviceResponse> AddAgentDeviceAsync(AddAgentDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAgentDeviceWithOptionsAsync(request, runtime);
        }

        public AddBulkPhoneNumbersResponse AddBulkPhoneNumbersWithOptions(AddBulkPhoneNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddBulkPhoneNumbersResponse>(DoRPCRequest("AddBulkPhoneNumbers", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddBulkPhoneNumbersResponse> AddBulkPhoneNumbersWithOptionsAsync(AddBulkPhoneNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddBulkPhoneNumbersResponse>(await DoRPCRequestAsync("AddBulkPhoneNumbers", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddBulkPhoneNumbersResponse AddBulkPhoneNumbers(AddBulkPhoneNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddBulkPhoneNumbersWithOptions(request, runtime);
        }

        public async Task<AddBulkPhoneNumbersResponse> AddBulkPhoneNumbersAsync(AddBulkPhoneNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddBulkPhoneNumbersWithOptionsAsync(request, runtime);
        }

        public AddJobsToPredictiveJobGroupResponse AddJobsToPredictiveJobGroupWithOptions(AddJobsToPredictiveJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddJobsToPredictiveJobGroupResponse>(DoRPCRequest("AddJobsToPredictiveJobGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddJobsToPredictiveJobGroupResponse> AddJobsToPredictiveJobGroupWithOptionsAsync(AddJobsToPredictiveJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddJobsToPredictiveJobGroupResponse>(await DoRPCRequestAsync("AddJobsToPredictiveJobGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddJobsToPredictiveJobGroupResponse AddJobsToPredictiveJobGroup(AddJobsToPredictiveJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddJobsToPredictiveJobGroupWithOptions(request, runtime);
        }

        public async Task<AddJobsToPredictiveJobGroupResponse> AddJobsToPredictiveJobGroupAsync(AddJobsToPredictiveJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddJobsToPredictiveJobGroupWithOptionsAsync(request, runtime);
        }

        public AddPhoneNumberResponse AddPhoneNumberWithOptions(AddPhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddPhoneNumberResponse>(DoRPCRequest("AddPhoneNumber", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddPhoneNumberResponse> AddPhoneNumberWithOptionsAsync(AddPhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddPhoneNumberResponse>(await DoRPCRequestAsync("AddPhoneNumber", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddPhoneNumberResponse AddPhoneNumber(AddPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddPhoneNumberWithOptions(request, runtime);
        }

        public async Task<AddPhoneNumberResponse> AddPhoneNumberAsync(AddPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddPhoneNumberWithOptionsAsync(request, runtime);
        }

        public AddPhoneTagsResponse AddPhoneTagsWithOptions(AddPhoneTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddPhoneTagsResponse>(DoRPCRequest("AddPhoneTags", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddPhoneTagsResponse> AddPhoneTagsWithOptionsAsync(AddPhoneTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddPhoneTagsResponse>(await DoRPCRequestAsync("AddPhoneTags", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddPhoneTagsResponse AddPhoneTags(AddPhoneTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddPhoneTagsWithOptions(request, runtime);
        }

        public async Task<AddPhoneTagsResponse> AddPhoneTagsAsync(AddPhoneTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddPhoneTagsWithOptionsAsync(request, runtime);
        }

        public AssignJobsResponse AssignJobsWithOptions(AssignJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssignJobsResponse>(DoRPCRequest("AssignJobs", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssignJobsResponse> AssignJobsWithOptionsAsync(AssignJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssignJobsResponse>(await DoRPCRequestAsync("AssignJobs", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssignJobsResponse AssignJobs(AssignJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssignJobsWithOptions(request, runtime);
        }

        public async Task<AssignJobsResponse> AssignJobsAsync(AssignJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssignJobsWithOptionsAsync(request, runtime);
        }

        public AssignUsersResponse AssignUsersWithOptions(AssignUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssignUsersResponse>(DoRPCRequest("AssignUsers", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssignUsersResponse> AssignUsersWithOptionsAsync(AssignUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssignUsersResponse>(await DoRPCRequestAsync("AssignUsers", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssignUsersResponse AssignUsers(AssignUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssignUsersWithOptions(request, runtime);
        }

        public async Task<AssignUsersResponse> AssignUsersAsync(AssignUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssignUsersWithOptionsAsync(request, runtime);
        }

        public CallOnlinePrivacyNumberResponse CallOnlinePrivacyNumberWithOptions(CallOnlinePrivacyNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CallOnlinePrivacyNumberResponse>(DoRPCRequest("CallOnlinePrivacyNumber", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CallOnlinePrivacyNumberResponse> CallOnlinePrivacyNumberWithOptionsAsync(CallOnlinePrivacyNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CallOnlinePrivacyNumberResponse>(await DoRPCRequestAsync("CallOnlinePrivacyNumber", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CallOnlinePrivacyNumberResponse CallOnlinePrivacyNumber(CallOnlinePrivacyNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CallOnlinePrivacyNumberWithOptions(request, runtime);
        }

        public async Task<CallOnlinePrivacyNumberResponse> CallOnlinePrivacyNumberAsync(CallOnlinePrivacyNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CallOnlinePrivacyNumberWithOptionsAsync(request, runtime);
        }

        public CancelJobsResponse CancelJobsWithOptions(CancelJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelJobsResponse>(DoRPCRequest("CancelJobs", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelJobsResponse> CancelJobsWithOptionsAsync(CancelJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelJobsResponse>(await DoRPCRequestAsync("CancelJobs", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelJobsResponse CancelJobs(CancelJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelJobsWithOptions(request, runtime);
        }

        public async Task<CancelJobsResponse> CancelJobsAsync(CancelJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelJobsWithOptionsAsync(request, runtime);
        }

        public CheckNumberAvaliableResponse CheckNumberAvaliableWithOptions(CheckNumberAvaliableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckNumberAvaliableResponse>(DoRPCRequest("CheckNumberAvaliable", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckNumberAvaliableResponse> CheckNumberAvaliableWithOptionsAsync(CheckNumberAvaliableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckNumberAvaliableResponse>(await DoRPCRequestAsync("CheckNumberAvaliable", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckNumberAvaliableResponse CheckNumberAvaliable(CheckNumberAvaliableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckNumberAvaliableWithOptions(request, runtime);
        }

        public async Task<CheckNumberAvaliableResponse> CheckNumberAvaliableAsync(CheckNumberAvaliableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckNumberAvaliableWithOptionsAsync(request, runtime);
        }

        public CommitContactFlowVersionModificationResponse CommitContactFlowVersionModificationWithOptions(CommitContactFlowVersionModificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CommitContactFlowVersionModificationResponse>(DoRPCRequest("CommitContactFlowVersionModification", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CommitContactFlowVersionModificationResponse> CommitContactFlowVersionModificationWithOptionsAsync(CommitContactFlowVersionModificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CommitContactFlowVersionModificationResponse>(await DoRPCRequestAsync("CommitContactFlowVersionModification", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CommitContactFlowVersionModificationResponse CommitContactFlowVersionModification(CommitContactFlowVersionModificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CommitContactFlowVersionModificationWithOptions(request, runtime);
        }

        public async Task<CommitContactFlowVersionModificationResponse> CommitContactFlowVersionModificationAsync(CommitContactFlowVersionModificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CommitContactFlowVersionModificationWithOptionsAsync(request, runtime);
        }

        public CreateBatchJobsResponse CreateBatchJobsWithOptions(CreateBatchJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBatchJobsResponse>(DoRPCRequest("CreateBatchJobs", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateBatchJobsResponse> CreateBatchJobsWithOptionsAsync(CreateBatchJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBatchJobsResponse>(await DoRPCRequestAsync("CreateBatchJobs", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateBatchJobsResponse CreateBatchJobs(CreateBatchJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBatchJobsWithOptions(request, runtime);
        }

        public async Task<CreateBatchJobsResponse> CreateBatchJobsAsync(CreateBatchJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBatchJobsWithOptionsAsync(request, runtime);
        }

        public CreateCabInstanceResponse CreateCabInstanceWithOptions(CreateCabInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCabInstanceResponse>(DoRPCRequest("CreateCabInstance", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCabInstanceResponse> CreateCabInstanceWithOptionsAsync(CreateCabInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCabInstanceResponse>(await DoRPCRequestAsync("CreateCabInstance", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCabInstanceResponse CreateCabInstance(CreateCabInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCabInstanceWithOptions(request, runtime);
        }

        public async Task<CreateCabInstanceResponse> CreateCabInstanceAsync(CreateCabInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCabInstanceWithOptionsAsync(request, runtime);
        }

        public CreateContactFlowResponse CreateContactFlowWithOptions(CreateContactFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateContactFlowResponse>(DoRPCRequest("CreateContactFlow", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateContactFlowResponse> CreateContactFlowWithOptionsAsync(CreateContactFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateContactFlowResponse>(await DoRPCRequestAsync("CreateContactFlow", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateContactFlowResponse CreateContactFlow(CreateContactFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateContactFlowWithOptions(request, runtime);
        }

        public async Task<CreateContactFlowResponse> CreateContactFlowAsync(CreateContactFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateContactFlowWithOptionsAsync(request, runtime);
        }

        public CreateFaultResponse CreateFaultWithOptions(CreateFaultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFaultResponse>(DoRPCRequest("CreateFault", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFaultResponse> CreateFaultWithOptionsAsync(CreateFaultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFaultResponse>(await DoRPCRequestAsync("CreateFault", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFaultResponse CreateFault(CreateFaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFaultWithOptions(request, runtime);
        }

        public async Task<CreateFaultResponse> CreateFaultAsync(CreateFaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFaultWithOptionsAsync(request, runtime);
        }

        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceResponse>(DoRPCRequest("CreateInstance", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await DoRPCRequestAsync("CreateInstance", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceWithOptions(request, runtime);
        }

        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        public CreateJobGroupResponse CreateJobGroupWithOptions(CreateJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateJobGroupResponse>(DoRPCRequest("CreateJobGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateJobGroupResponse> CreateJobGroupWithOptionsAsync(CreateJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateJobGroupResponse>(await DoRPCRequestAsync("CreateJobGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateJobGroupResponse CreateJobGroup(CreateJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateJobGroupWithOptions(request, runtime);
        }

        public async Task<CreateJobGroupResponse> CreateJobGroupAsync(CreateJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateJobGroupWithOptionsAsync(request, runtime);
        }

        public CreateMediaResponse CreateMediaWithOptions(CreateMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMediaResponse>(DoRPCRequest("CreateMedia", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMediaResponse> CreateMediaWithOptionsAsync(CreateMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMediaResponse>(await DoRPCRequestAsync("CreateMedia", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMediaResponse CreateMedia(CreateMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMediaWithOptions(request, runtime);
        }

        public async Task<CreateMediaResponse> CreateMediaAsync(CreateMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMediaWithOptionsAsync(request, runtime);
        }

        public CreatePredictiveJobGroupResponse CreatePredictiveJobGroupWithOptions(CreatePredictiveJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePredictiveJobGroupResponse>(DoRPCRequest("CreatePredictiveJobGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreatePredictiveJobGroupResponse> CreatePredictiveJobGroupWithOptionsAsync(CreatePredictiveJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePredictiveJobGroupResponse>(await DoRPCRequestAsync("CreatePredictiveJobGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreatePredictiveJobGroupResponse CreatePredictiveJobGroup(CreatePredictiveJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePredictiveJobGroupWithOptions(request, runtime);
        }

        public async Task<CreatePredictiveJobGroupResponse> CreatePredictiveJobGroupAsync(CreatePredictiveJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePredictiveJobGroupWithOptionsAsync(request, runtime);
        }

        public CreateScenarioResponse CreateScenarioWithOptions(CreateScenarioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateScenarioResponse>(DoRPCRequest("CreateScenario", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateScenarioResponse> CreateScenarioWithOptionsAsync(CreateScenarioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateScenarioResponse>(await DoRPCRequestAsync("CreateScenario", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateScenarioResponse CreateScenario(CreateScenarioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScenarioWithOptions(request, runtime);
        }

        public async Task<CreateScenarioResponse> CreateScenarioAsync(CreateScenarioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScenarioWithOptionsAsync(request, runtime);
        }

        public CreateScenarioFromTemplateResponse CreateScenarioFromTemplateWithOptions(CreateScenarioFromTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateScenarioFromTemplateResponse>(DoRPCRequest("CreateScenarioFromTemplate", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateScenarioFromTemplateResponse> CreateScenarioFromTemplateWithOptionsAsync(CreateScenarioFromTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateScenarioFromTemplateResponse>(await DoRPCRequestAsync("CreateScenarioFromTemplate", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateScenarioFromTemplateResponse CreateScenarioFromTemplate(CreateScenarioFromTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScenarioFromTemplateWithOptions(request, runtime);
        }

        public async Task<CreateScenarioFromTemplateResponse> CreateScenarioFromTemplateAsync(CreateScenarioFromTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScenarioFromTemplateWithOptionsAsync(request, runtime);
        }

        public CreateSkillGroupResponse CreateSkillGroupWithOptions(CreateSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSkillGroupResponse>(DoRPCRequest("CreateSkillGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSkillGroupResponse> CreateSkillGroupWithOptionsAsync(CreateSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSkillGroupResponse>(await DoRPCRequestAsync("CreateSkillGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSkillGroupResponse CreateSkillGroup(CreateSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSkillGroupWithOptions(request, runtime);
        }

        public async Task<CreateSkillGroupResponse> CreateSkillGroupAsync(CreateSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSkillGroupWithOptionsAsync(request, runtime);
        }

        public CreateSurveyResponse CreateSurveyWithOptions(CreateSurveyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSurveyResponse>(DoRPCRequest("CreateSurvey", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSurveyResponse> CreateSurveyWithOptionsAsync(CreateSurveyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSurveyResponse>(await DoRPCRequestAsync("CreateSurvey", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSurveyResponse CreateSurvey(CreateSurveyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSurveyWithOptions(request, runtime);
        }

        public async Task<CreateSurveyResponse> CreateSurveyAsync(CreateSurveyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSurveyWithOptionsAsync(request, runtime);
        }

        public CreateUserResponse CreateUserWithOptions(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserResponse>(DoRPCRequest("CreateUser", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateUserResponse> CreateUserWithOptionsAsync(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserResponse>(await DoRPCRequestAsync("CreateUser", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateUserResponse CreateUser(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserWithOptions(request, runtime);
        }

        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserWithOptionsAsync(request, runtime);
        }

        public CreateVoiceAppraiseResponse CreateVoiceAppraiseWithOptions(CreateVoiceAppraiseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVoiceAppraiseResponse>(DoRPCRequest("CreateVoiceAppraise", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVoiceAppraiseResponse> CreateVoiceAppraiseWithOptionsAsync(CreateVoiceAppraiseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVoiceAppraiseResponse>(await DoRPCRequestAsync("CreateVoiceAppraise", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVoiceAppraiseResponse CreateVoiceAppraise(CreateVoiceAppraiseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVoiceAppraiseWithOptions(request, runtime);
        }

        public async Task<CreateVoiceAppraiseResponse> CreateVoiceAppraiseAsync(CreateVoiceAppraiseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVoiceAppraiseWithOptionsAsync(request, runtime);
        }

        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(DoRPCRequest("DeleteInstance", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await DoRPCRequestAsync("DeleteInstance", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceWithOptions(request, runtime);
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceWithOptionsAsync(request, runtime);
        }

        public DeleteJobGroupResponse DeleteJobGroupWithOptions(DeleteJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteJobGroupResponse>(DoRPCRequest("DeleteJobGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteJobGroupResponse> DeleteJobGroupWithOptionsAsync(DeleteJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteJobGroupResponse>(await DoRPCRequestAsync("DeleteJobGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteJobGroupResponse DeleteJobGroup(DeleteJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteJobGroupWithOptions(request, runtime);
        }

        public async Task<DeleteJobGroupResponse> DeleteJobGroupAsync(DeleteJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteJobGroupWithOptionsAsync(request, runtime);
        }

        public DeleteMediaResponse DeleteMediaWithOptions(DeleteMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMediaResponse>(DoRPCRequest("DeleteMedia", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMediaResponse> DeleteMediaWithOptionsAsync(DeleteMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMediaResponse>(await DoRPCRequestAsync("DeleteMedia", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeletePhoneTagsResponse DeletePhoneTagsWithOptions(DeletePhoneTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePhoneTagsResponse>(DoRPCRequest("DeletePhoneTags", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeletePhoneTagsResponse> DeletePhoneTagsWithOptionsAsync(DeletePhoneTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePhoneTagsResponse>(await DoRPCRequestAsync("DeletePhoneTags", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeletePhoneTagsResponse DeletePhoneTags(DeletePhoneTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePhoneTagsWithOptions(request, runtime);
        }

        public async Task<DeletePhoneTagsResponse> DeletePhoneTagsAsync(DeletePhoneTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePhoneTagsWithOptionsAsync(request, runtime);
        }

        public DeleteSkillGroupResponse DeleteSkillGroupWithOptions(DeleteSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSkillGroupResponse>(DoRPCRequest("DeleteSkillGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSkillGroupResponse> DeleteSkillGroupWithOptionsAsync(DeleteSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSkillGroupResponse>(await DoRPCRequestAsync("DeleteSkillGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSkillGroupResponse DeleteSkillGroup(DeleteSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSkillGroupWithOptions(request, runtime);
        }

        public async Task<DeleteSkillGroupResponse> DeleteSkillGroupAsync(DeleteSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSkillGroupWithOptionsAsync(request, runtime);
        }

        public DeleteSurveyResponse DeleteSurveyWithOptions(DeleteSurveyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSurveyResponse>(DoRPCRequest("DeleteSurvey", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSurveyResponse> DeleteSurveyWithOptionsAsync(DeleteSurveyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSurveyResponse>(await DoRPCRequestAsync("DeleteSurvey", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSurveyResponse DeleteSurvey(DeleteSurveyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSurveyWithOptions(request, runtime);
        }

        public async Task<DeleteSurveyResponse> DeleteSurveyAsync(DeleteSurveyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSurveyWithOptionsAsync(request, runtime);
        }

        public DialExResponse DialExWithOptions(DialExRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DialExResponse>(DoRPCRequest("DialEx", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DialExResponse> DialExWithOptionsAsync(DialExRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DialExResponse>(await DoRPCRequestAsync("DialEx", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DialExResponse DialEx(DialExRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DialExWithOptions(request, runtime);
        }

        public async Task<DialExResponse> DialExAsync(DialExRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DialExWithOptionsAsync(request, runtime);
        }

        public DialogueResponse DialogueWithOptions(DialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DialogueResponse>(DoRPCRequest("Dialogue", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DialogueResponse> DialogueWithOptionsAsync(DialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DialogueResponse>(await DoRPCRequestAsync("Dialogue", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DialogueResponse Dialogue(DialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DialogueWithOptions(request, runtime);
        }

        public async Task<DialogueResponse> DialogueAsync(DialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DialogueWithOptionsAsync(request, runtime);
        }

        public DisableTrunkProvidersResponse DisableTrunkProvidersWithOptions(DisableTrunkProvidersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableTrunkProvidersResponse>(DoRPCRequest("DisableTrunkProviders", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableTrunkProvidersResponse> DisableTrunkProvidersWithOptionsAsync(DisableTrunkProvidersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableTrunkProvidersResponse>(await DoRPCRequestAsync("DisableTrunkProviders", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableTrunkProvidersResponse DisableTrunkProviders(DisableTrunkProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableTrunkProvidersWithOptions(request, runtime);
        }

        public async Task<DisableTrunkProvidersResponse> DisableTrunkProvidersAsync(DisableTrunkProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableTrunkProvidersWithOptionsAsync(request, runtime);
        }

        public DownloadAllTypeRecordingResponse DownloadAllTypeRecordingWithOptions(DownloadAllTypeRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadAllTypeRecordingResponse>(DoRPCRequest("DownloadAllTypeRecording", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DownloadAllTypeRecordingResponse> DownloadAllTypeRecordingWithOptionsAsync(DownloadAllTypeRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadAllTypeRecordingResponse>(await DoRPCRequestAsync("DownloadAllTypeRecording", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DownloadAllTypeRecordingResponse DownloadAllTypeRecording(DownloadAllTypeRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadAllTypeRecordingWithOptions(request, runtime);
        }

        public async Task<DownloadAllTypeRecordingResponse> DownloadAllTypeRecordingAsync(DownloadAllTypeRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadAllTypeRecordingWithOptionsAsync(request, runtime);
        }

        public DownloadCabRecordingResponse DownloadCabRecordingWithOptions(DownloadCabRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadCabRecordingResponse>(DoRPCRequest("DownloadCabRecording", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DownloadCabRecordingResponse> DownloadCabRecordingWithOptionsAsync(DownloadCabRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadCabRecordingResponse>(await DoRPCRequestAsync("DownloadCabRecording", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DownloadCabRecordingResponse DownloadCabRecording(DownloadCabRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadCabRecordingWithOptions(request, runtime);
        }

        public async Task<DownloadCabRecordingResponse> DownloadCabRecordingAsync(DownloadCabRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadCabRecordingWithOptionsAsync(request, runtime);
        }

        public DownloadOriginalStatisticsReportResponse DownloadOriginalStatisticsReportWithOptions(DownloadOriginalStatisticsReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadOriginalStatisticsReportResponse>(DoRPCRequest("DownloadOriginalStatisticsReport", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DownloadOriginalStatisticsReportResponse> DownloadOriginalStatisticsReportWithOptionsAsync(DownloadOriginalStatisticsReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadOriginalStatisticsReportResponse>(await DoRPCRequestAsync("DownloadOriginalStatisticsReport", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DownloadOriginalStatisticsReportResponse DownloadOriginalStatisticsReport(DownloadOriginalStatisticsReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadOriginalStatisticsReportWithOptions(request, runtime);
        }

        public async Task<DownloadOriginalStatisticsReportResponse> DownloadOriginalStatisticsReportAsync(DownloadOriginalStatisticsReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadOriginalStatisticsReportWithOptionsAsync(request, runtime);
        }

        public DownloadRecordingResponse DownloadRecordingWithOptions(DownloadRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadRecordingResponse>(DoRPCRequest("DownloadRecording", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DownloadRecordingResponse> DownloadRecordingWithOptionsAsync(DownloadRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadRecordingResponse>(await DoRPCRequestAsync("DownloadRecording", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DownloadRecordingResponse DownloadRecording(DownloadRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadRecordingWithOptions(request, runtime);
        }

        public async Task<DownloadRecordingResponse> DownloadRecordingAsync(DownloadRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadRecordingWithOptionsAsync(request, runtime);
        }

        public DownloadUnreachableContactsResponse DownloadUnreachableContactsWithOptions(DownloadUnreachableContactsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadUnreachableContactsResponse>(DoRPCRequest("DownloadUnreachableContacts", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DownloadUnreachableContactsResponse> DownloadUnreachableContactsWithOptionsAsync(DownloadUnreachableContactsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadUnreachableContactsResponse>(await DoRPCRequestAsync("DownloadUnreachableContacts", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DownloadUnreachableContactsResponse DownloadUnreachableContacts(DownloadUnreachableContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadUnreachableContactsWithOptions(request, runtime);
        }

        public async Task<DownloadUnreachableContactsResponse> DownloadUnreachableContactsAsync(DownloadUnreachableContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadUnreachableContactsWithOptionsAsync(request, runtime);
        }

        public FindUsersResponse FindUsersWithOptions(FindUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindUsersResponse>(DoRPCRequest("FindUsers", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FindUsersResponse> FindUsersWithOptionsAsync(FindUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindUsersResponse>(await DoRPCRequestAsync("FindUsers", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FindUsersResponse FindUsers(FindUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindUsersWithOptions(request, runtime);
        }

        public async Task<FindUsersResponse> FindUsersAsync(FindUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindUsersWithOptionsAsync(request, runtime);
        }

        public GenerateAgentStatisticReportResponse GenerateAgentStatisticReportWithOptions(GenerateAgentStatisticReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateAgentStatisticReportResponse>(DoRPCRequest("GenerateAgentStatisticReport", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GenerateAgentStatisticReportResponse> GenerateAgentStatisticReportWithOptionsAsync(GenerateAgentStatisticReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateAgentStatisticReportResponse>(await DoRPCRequestAsync("GenerateAgentStatisticReport", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GenerateAgentStatisticReportResponse GenerateAgentStatisticReport(GenerateAgentStatisticReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateAgentStatisticReportWithOptions(request, runtime);
        }

        public async Task<GenerateAgentStatisticReportResponse> GenerateAgentStatisticReportAsync(GenerateAgentStatisticReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateAgentStatisticReportWithOptionsAsync(request, runtime);
        }

        public GetAgentDataResponse GetAgentDataWithOptions(GetAgentDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAgentDataResponse>(DoRPCRequest("GetAgentData", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAgentDataResponse> GetAgentDataWithOptionsAsync(GetAgentDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAgentDataResponse>(await DoRPCRequestAsync("GetAgentData", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAgentDataResponse GetAgentData(GetAgentDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentDataWithOptions(request, runtime);
        }

        public async Task<GetAgentDataResponse> GetAgentDataAsync(GetAgentDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentDataWithOptionsAsync(request, runtime);
        }

        public GetCallMeasureSummaryReportResponse GetCallMeasureSummaryReportWithOptions(GetCallMeasureSummaryReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCallMeasureSummaryReportResponse>(DoRPCRequest("GetCallMeasureSummaryReport", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetCallMeasureSummaryReportResponse> GetCallMeasureSummaryReportWithOptionsAsync(GetCallMeasureSummaryReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCallMeasureSummaryReportResponse>(await DoRPCRequestAsync("GetCallMeasureSummaryReport", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetCallMeasureSummaryReportResponse GetCallMeasureSummaryReport(GetCallMeasureSummaryReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCallMeasureSummaryReportWithOptions(request, runtime);
        }

        public async Task<GetCallMeasureSummaryReportResponse> GetCallMeasureSummaryReportAsync(GetCallMeasureSummaryReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCallMeasureSummaryReportWithOptionsAsync(request, runtime);
        }

        public GetConfigResponse GetConfigWithOptions(GetConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetConfigResponse>(DoRPCRequest("GetConfig", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetConfigResponse> GetConfigWithOptionsAsync(GetConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetConfigResponse>(await DoRPCRequestAsync("GetConfig", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetConfigResponse GetConfig(GetConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConfigWithOptions(request, runtime);
        }

        public async Task<GetConfigResponse> GetConfigAsync(GetConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConfigWithOptionsAsync(request, runtime);
        }

        public GetContactInfoByOutboundTaskIdResponse GetContactInfoByOutboundTaskIdWithOptions(GetContactInfoByOutboundTaskIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetContactInfoByOutboundTaskIdResponse>(DoRPCRequest("GetContactInfoByOutboundTaskId", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetContactInfoByOutboundTaskIdResponse> GetContactInfoByOutboundTaskIdWithOptionsAsync(GetContactInfoByOutboundTaskIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetContactInfoByOutboundTaskIdResponse>(await DoRPCRequestAsync("GetContactInfoByOutboundTaskId", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetContactInfoByOutboundTaskIdResponse GetContactInfoByOutboundTaskId(GetContactInfoByOutboundTaskIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetContactInfoByOutboundTaskIdWithOptions(request, runtime);
        }

        public async Task<GetContactInfoByOutboundTaskIdResponse> GetContactInfoByOutboundTaskIdAsync(GetContactInfoByOutboundTaskIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetContactInfoByOutboundTaskIdWithOptionsAsync(request, runtime);
        }

        public GetConversationDetailByContactIdResponse GetConversationDetailByContactIdWithOptions(GetConversationDetailByContactIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetConversationDetailByContactIdResponse>(DoRPCRequest("GetConversationDetailByContactId", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetConversationDetailByContactIdResponse> GetConversationDetailByContactIdWithOptionsAsync(GetConversationDetailByContactIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetConversationDetailByContactIdResponse>(await DoRPCRequestAsync("GetConversationDetailByContactId", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetConversationDetailByContactIdResponse GetConversationDetailByContactId(GetConversationDetailByContactIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConversationDetailByContactIdWithOptions(request, runtime);
        }

        public async Task<GetConversationDetailByContactIdResponse> GetConversationDetailByContactIdAsync(GetConversationDetailByContactIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConversationDetailByContactIdWithOptionsAsync(request, runtime);
        }

        public GetConversationListResponse GetConversationListWithOptions(GetConversationListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetConversationListResponse>(DoRPCRequest("GetConversationList", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetConversationListResponse> GetConversationListWithOptionsAsync(GetConversationListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetConversationListResponse>(await DoRPCRequestAsync("GetConversationList", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetInstanceResponse GetInstanceWithOptions(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceResponse>(DoRPCRequest("GetInstance", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceResponse> GetInstanceWithOptionsAsync(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceResponse>(await DoRPCRequestAsync("GetInstance", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceResponse GetInstance(GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceWithOptions(request, runtime);
        }

        public async Task<GetInstanceResponse> GetInstanceAsync(GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceWithOptionsAsync(request, runtime);
        }

        public GetInstanceStateResponse GetInstanceStateWithOptions(GetInstanceStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceStateResponse>(DoRPCRequest("GetInstanceState", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceStateResponse> GetInstanceStateWithOptionsAsync(GetInstanceStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceStateResponse>(await DoRPCRequestAsync("GetInstanceState", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceStateResponse GetInstanceState(GetInstanceStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceStateWithOptions(request, runtime);
        }

        public async Task<GetInstanceStateResponse> GetInstanceStateAsync(GetInstanceStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceStateWithOptionsAsync(request, runtime);
        }

        public GetInstanceSummaryReportResponse GetInstanceSummaryReportWithOptions(GetInstanceSummaryReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceSummaryReportResponse>(DoRPCRequest("GetInstanceSummaryReport", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceSummaryReportResponse> GetInstanceSummaryReportWithOptionsAsync(GetInstanceSummaryReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceSummaryReportResponse>(await DoRPCRequestAsync("GetInstanceSummaryReport", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceSummaryReportResponse GetInstanceSummaryReport(GetInstanceSummaryReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceSummaryReportWithOptions(request, runtime);
        }

        public async Task<GetInstanceSummaryReportResponse> GetInstanceSummaryReportAsync(GetInstanceSummaryReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceSummaryReportWithOptionsAsync(request, runtime);
        }

        public GetInstanceSummaryReportByIntervalResponse GetInstanceSummaryReportByIntervalWithOptions(GetInstanceSummaryReportByIntervalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceSummaryReportByIntervalResponse>(DoRPCRequest("GetInstanceSummaryReportByInterval", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceSummaryReportByIntervalResponse> GetInstanceSummaryReportByIntervalWithOptionsAsync(GetInstanceSummaryReportByIntervalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceSummaryReportByIntervalResponse>(await DoRPCRequestAsync("GetInstanceSummaryReportByInterval", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceSummaryReportByIntervalResponse GetInstanceSummaryReportByInterval(GetInstanceSummaryReportByIntervalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceSummaryReportByIntervalWithOptions(request, runtime);
        }

        public async Task<GetInstanceSummaryReportByIntervalResponse> GetInstanceSummaryReportByIntervalAsync(GetInstanceSummaryReportByIntervalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceSummaryReportByIntervalWithOptionsAsync(request, runtime);
        }

        public GetInstanceSummaryReportSinceMidnightResponse GetInstanceSummaryReportSinceMidnightWithOptions(GetInstanceSummaryReportSinceMidnightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceSummaryReportSinceMidnightResponse>(DoRPCRequest("GetInstanceSummaryReportSinceMidnight", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceSummaryReportSinceMidnightResponse> GetInstanceSummaryReportSinceMidnightWithOptionsAsync(GetInstanceSummaryReportSinceMidnightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceSummaryReportSinceMidnightResponse>(await DoRPCRequestAsync("GetInstanceSummaryReportSinceMidnight", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceSummaryReportSinceMidnightResponse GetInstanceSummaryReportSinceMidnight(GetInstanceSummaryReportSinceMidnightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceSummaryReportSinceMidnightWithOptions(request, runtime);
        }

        public async Task<GetInstanceSummaryReportSinceMidnightResponse> GetInstanceSummaryReportSinceMidnightAsync(GetInstanceSummaryReportSinceMidnightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceSummaryReportSinceMidnightWithOptionsAsync(request, runtime);
        }

        public GetJobResponse GetJobWithOptions(GetJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobResponse>(DoRPCRequest("GetJob", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetJobResponse> GetJobWithOptionsAsync(GetJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobResponse>(await DoRPCRequestAsync("GetJob", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetJobResponse GetJob(GetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobWithOptions(request, runtime);
        }

        public async Task<GetJobResponse> GetJobAsync(GetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobWithOptionsAsync(request, runtime);
        }

        public GetJobDataUploadParamsResponse GetJobDataUploadParamsWithOptions(GetJobDataUploadParamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobDataUploadParamsResponse>(DoRPCRequest("GetJobDataUploadParams", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetJobDataUploadParamsResponse> GetJobDataUploadParamsWithOptionsAsync(GetJobDataUploadParamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobDataUploadParamsResponse>(await DoRPCRequestAsync("GetJobDataUploadParams", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetJobDataUploadParamsResponse GetJobDataUploadParams(GetJobDataUploadParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobDataUploadParamsWithOptions(request, runtime);
        }

        public async Task<GetJobDataUploadParamsResponse> GetJobDataUploadParamsAsync(GetJobDataUploadParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobDataUploadParamsWithOptionsAsync(request, runtime);
        }

        public GetJobFileUploadUrlResponse GetJobFileUploadUrlWithOptions(GetJobFileUploadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobFileUploadUrlResponse>(DoRPCRequest("GetJobFileUploadUrl", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetJobFileUploadUrlResponse> GetJobFileUploadUrlWithOptionsAsync(GetJobFileUploadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobFileUploadUrlResponse>(await DoRPCRequestAsync("GetJobFileUploadUrl", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetJobFileUploadUrlResponse GetJobFileUploadUrl(GetJobFileUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobFileUploadUrlWithOptions(request, runtime);
        }

        public async Task<GetJobFileUploadUrlResponse> GetJobFileUploadUrlAsync(GetJobFileUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobFileUploadUrlWithOptionsAsync(request, runtime);
        }

        public GetJobGroupResponse GetJobGroupWithOptions(GetJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobGroupResponse>(DoRPCRequest("GetJobGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetJobGroupResponse> GetJobGroupWithOptionsAsync(GetJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobGroupResponse>(await DoRPCRequestAsync("GetJobGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetJobGroupResponse GetJobGroup(GetJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobGroupWithOptions(request, runtime);
        }

        public async Task<GetJobGroupResponse> GetJobGroupAsync(GetJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobGroupWithOptionsAsync(request, runtime);
        }

        public GetJobListResponse GetJobListWithOptions(GetJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobListResponse>(DoRPCRequest("GetJobList", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetJobListResponse> GetJobListWithOptionsAsync(GetJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobListResponse>(await DoRPCRequestAsync("GetJobList", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetJobListResponse GetJobList(GetJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobListWithOptions(request, runtime);
        }

        public async Task<GetJobListResponse> GetJobListAsync(GetJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobListWithOptionsAsync(request, runtime);
        }

        public GetJobStatusByCallIdResponse GetJobStatusByCallIdWithOptions(GetJobStatusByCallIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobStatusByCallIdResponse>(DoRPCRequest("GetJobStatusByCallId", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetJobStatusByCallIdResponse> GetJobStatusByCallIdWithOptionsAsync(GetJobStatusByCallIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobStatusByCallIdResponse>(await DoRPCRequestAsync("GetJobStatusByCallId", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetJobStatusByCallIdResponse GetJobStatusByCallId(GetJobStatusByCallIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobStatusByCallIdWithOptions(request, runtime);
        }

        public async Task<GetJobStatusByCallIdResponse> GetJobStatusByCallIdAsync(GetJobStatusByCallIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobStatusByCallIdWithOptionsAsync(request, runtime);
        }

        public GetJobTemplateDownloadParamsResponse GetJobTemplateDownloadParamsWithOptions(GetJobTemplateDownloadParamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobTemplateDownloadParamsResponse>(DoRPCRequest("GetJobTemplateDownloadParams", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetJobTemplateDownloadParamsResponse> GetJobTemplateDownloadParamsWithOptionsAsync(GetJobTemplateDownloadParamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobTemplateDownloadParamsResponse>(await DoRPCRequestAsync("GetJobTemplateDownloadParams", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetJobTemplateDownloadParamsResponse GetJobTemplateDownloadParams(GetJobTemplateDownloadParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobTemplateDownloadParamsWithOptions(request, runtime);
        }

        public async Task<GetJobTemplateDownloadParamsResponse> GetJobTemplateDownloadParamsAsync(GetJobTemplateDownloadParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobTemplateDownloadParamsWithOptionsAsync(request, runtime);
        }

        public GetNumberRegionInfoResponse GetNumberRegionInfoWithOptions(GetNumberRegionInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNumberRegionInfoResponse>(DoRPCRequest("GetNumberRegionInfo", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetNumberRegionInfoResponse> GetNumberRegionInfoWithOptionsAsync(GetNumberRegionInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNumberRegionInfoResponse>(await DoRPCRequestAsync("GetNumberRegionInfo", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetNumberRegionInfoResponse GetNumberRegionInfo(GetNumberRegionInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNumberRegionInfoWithOptions(request, runtime);
        }

        public async Task<GetNumberRegionInfoResponse> GetNumberRegionInfoAsync(GetNumberRegionInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNumberRegionInfoWithOptionsAsync(request, runtime);
        }

        public GetPredictiveJobGroupResponse GetPredictiveJobGroupWithOptions(GetPredictiveJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPredictiveJobGroupResponse>(DoRPCRequest("GetPredictiveJobGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPredictiveJobGroupResponse> GetPredictiveJobGroupWithOptionsAsync(GetPredictiveJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPredictiveJobGroupResponse>(await DoRPCRequestAsync("GetPredictiveJobGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPredictiveJobGroupResponse GetPredictiveJobGroup(GetPredictiveJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPredictiveJobGroupWithOptions(request, runtime);
        }

        public async Task<GetPredictiveJobGroupResponse> GetPredictiveJobGroupAsync(GetPredictiveJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPredictiveJobGroupWithOptionsAsync(request, runtime);
        }

        public GetPredictiveTaskDataResponse GetPredictiveTaskDataWithOptions(GetPredictiveTaskDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetPredictiveTaskDataResponse>(DoRPCRequest("GetPredictiveTaskData", "2017-07-05", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetPredictiveTaskDataResponse> GetPredictiveTaskDataWithOptionsAsync(GetPredictiveTaskDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetPredictiveTaskDataResponse>(await DoRPCRequestAsync("GetPredictiveTaskData", "2017-07-05", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetPredictiveTaskDataResponse GetPredictiveTaskData(GetPredictiveTaskDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPredictiveTaskDataWithOptions(request, runtime);
        }

        public async Task<GetPredictiveTaskDataResponse> GetPredictiveTaskDataAsync(GetPredictiveTaskDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPredictiveTaskDataWithOptionsAsync(request, runtime);
        }

        public GetRecordOssUploadParamResponse GetRecordOssUploadParamWithOptions(GetRecordOssUploadParamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRecordOssUploadParamResponse>(DoRPCRequest("GetRecordOssUploadParam", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRecordOssUploadParamResponse> GetRecordOssUploadParamWithOptionsAsync(GetRecordOssUploadParamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRecordOssUploadParamResponse>(await DoRPCRequestAsync("GetRecordOssUploadParam", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRecordOssUploadParamResponse GetRecordOssUploadParam(GetRecordOssUploadParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRecordOssUploadParamWithOptions(request, runtime);
        }

        public async Task<GetRecordOssUploadParamResponse> GetRecordOssUploadParamAsync(GetRecordOssUploadParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRecordOssUploadParamWithOptionsAsync(request, runtime);
        }

        public GetRoutePointResponse GetRoutePointWithOptions(GetRoutePointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRoutePointResponse>(DoRPCRequest("GetRoutePoint", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRoutePointResponse> GetRoutePointWithOptionsAsync(GetRoutePointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRoutePointResponse>(await DoRPCRequestAsync("GetRoutePoint", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRoutePointResponse GetRoutePoint(GetRoutePointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRoutePointWithOptions(request, runtime);
        }

        public async Task<GetRoutePointResponse> GetRoutePointAsync(GetRoutePointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRoutePointWithOptionsAsync(request, runtime);
        }

        public GetScenarioResponse GetScenarioWithOptions(GetScenarioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetScenarioResponse>(DoRPCRequest("GetScenario", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetScenarioResponse> GetScenarioWithOptionsAsync(GetScenarioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetScenarioResponse>(await DoRPCRequestAsync("GetScenario", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetScenarioResponse GetScenario(GetScenarioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetScenarioWithOptions(request, runtime);
        }

        public async Task<GetScenarioResponse> GetScenarioAsync(GetScenarioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetScenarioWithOptionsAsync(request, runtime);
        }

        public GetServiceExtensionsResponse GetServiceExtensionsWithOptions(GetServiceExtensionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetServiceExtensionsResponse>(DoRPCRequest("GetServiceExtensions", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetServiceExtensionsResponse> GetServiceExtensionsWithOptionsAsync(GetServiceExtensionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetServiceExtensionsResponse>(await DoRPCRequestAsync("GetServiceExtensions", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetServiceExtensionsResponse GetServiceExtensions(GetServiceExtensionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceExtensionsWithOptions(request, runtime);
        }

        public async Task<GetServiceExtensionsResponse> GetServiceExtensionsAsync(GetServiceExtensionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceExtensionsWithOptionsAsync(request, runtime);
        }

        public GetSmsConfigResponse GetSmsConfigWithOptions(GetSmsConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSmsConfigResponse>(DoRPCRequest("GetSmsConfig", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSmsConfigResponse> GetSmsConfigWithOptionsAsync(GetSmsConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSmsConfigResponse>(await DoRPCRequestAsync("GetSmsConfig", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSmsConfigResponse GetSmsConfig(GetSmsConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSmsConfigWithOptions(request, runtime);
        }

        public async Task<GetSmsConfigResponse> GetSmsConfigAsync(GetSmsConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSmsConfigWithOptionsAsync(request, runtime);
        }

        public GetSurveyResponse GetSurveyWithOptions(GetSurveyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSurveyResponse>(DoRPCRequest("GetSurvey", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSurveyResponse> GetSurveyWithOptionsAsync(GetSurveyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSurveyResponse>(await DoRPCRequestAsync("GetSurvey", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSurveyResponse GetSurvey(GetSurveyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSurveyWithOptions(request, runtime);
        }

        public async Task<GetSurveyResponse> GetSurveyAsync(GetSurveyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSurveyWithOptionsAsync(request, runtime);
        }

        public GetTURNCredentialsResponse GetTURNCredentialsWithOptions(GetTURNCredentialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTURNCredentialsResponse>(DoRPCRequest("GetTURNCredentials", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTURNCredentialsResponse> GetTURNCredentialsWithOptionsAsync(GetTURNCredentialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTURNCredentialsResponse>(await DoRPCRequestAsync("GetTURNCredentials", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTURNCredentialsResponse GetTURNCredentials(GetTURNCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTURNCredentialsWithOptions(request, runtime);
        }

        public async Task<GetTURNCredentialsResponse> GetTURNCredentialsAsync(GetTURNCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTURNCredentialsWithOptionsAsync(request, runtime);
        }

        public GetTURNServerListResponse GetTURNServerListWithOptions(GetTURNServerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTURNServerListResponse>(DoRPCRequest("GetTURNServerList", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTURNServerListResponse> GetTURNServerListWithOptionsAsync(GetTURNServerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTURNServerListResponse>(await DoRPCRequestAsync("GetTURNServerList", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTURNServerListResponse GetTURNServerList(GetTURNServerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTURNServerListWithOptions(request, runtime);
        }

        public async Task<GetTURNServerListResponse> GetTURNServerListAsync(GetTURNServerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTURNServerListWithOptionsAsync(request, runtime);
        }

        public GetTaskListResponse GetTaskListWithOptions(GetTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTaskListResponse>(DoRPCRequest("GetTaskList", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTaskListResponse> GetTaskListWithOptionsAsync(GetTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTaskListResponse>(await DoRPCRequestAsync("GetTaskList", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTaskListResponse GetTaskList(GetTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTaskListWithOptions(request, runtime);
        }

        public async Task<GetTaskListResponse> GetTaskListAsync(GetTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTaskListWithOptionsAsync(request, runtime);
        }

        public GetUserResponse GetUserWithOptions(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserResponse>(DoRPCRequest("GetUser", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetUserResponse> GetUserWithOptionsAsync(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserResponse>(await DoRPCRequestAsync("GetUser", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetUserResponse GetUser(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserWithOptions(request, runtime);
        }

        public async Task<GetUserResponse> GetUserAsync(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserWithOptionsAsync(request, runtime);
        }

        public GetUserByExtensionResponse GetUserByExtensionWithOptions(GetUserByExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserByExtensionResponse>(DoRPCRequest("GetUserByExtension", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetUserByExtensionResponse> GetUserByExtensionWithOptionsAsync(GetUserByExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserByExtensionResponse>(await DoRPCRequestAsync("GetUserByExtension", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetUserByExtensionResponse GetUserByExtension(GetUserByExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserByExtensionWithOptions(request, runtime);
        }

        public async Task<GetUserByExtensionResponse> GetUserByExtensionAsync(GetUserByExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserByExtensionWithOptionsAsync(request, runtime);
        }

        public InflightTaskTimeoutResponse InflightTaskTimeoutWithOptions(InflightTaskTimeoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InflightTaskTimeoutResponse>(DoRPCRequest("InflightTaskTimeout", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InflightTaskTimeoutResponse> InflightTaskTimeoutWithOptionsAsync(InflightTaskTimeoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InflightTaskTimeoutResponse>(await DoRPCRequestAsync("InflightTaskTimeout", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InflightTaskTimeoutResponse InflightTaskTimeout(InflightTaskTimeoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InflightTaskTimeoutWithOptions(request, runtime);
        }

        public async Task<InflightTaskTimeoutResponse> InflightTaskTimeoutAsync(InflightTaskTimeoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InflightTaskTimeoutWithOptionsAsync(request, runtime);
        }

        public LaunchAppraiseResponse LaunchAppraiseWithOptions(LaunchAppraiseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LaunchAppraiseResponse>(DoRPCRequest("LaunchAppraise", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<LaunchAppraiseResponse> LaunchAppraiseWithOptionsAsync(LaunchAppraiseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LaunchAppraiseResponse>(await DoRPCRequestAsync("LaunchAppraise", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public LaunchAppraiseResponse LaunchAppraise(LaunchAppraiseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LaunchAppraiseWithOptions(request, runtime);
        }

        public async Task<LaunchAppraiseResponse> LaunchAppraiseAsync(LaunchAppraiseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LaunchAppraiseWithOptionsAsync(request, runtime);
        }

        public LaunchShortMessageAppraiseResponse LaunchShortMessageAppraiseWithOptions(LaunchShortMessageAppraiseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LaunchShortMessageAppraiseResponse>(DoRPCRequest("LaunchShortMessageAppraise", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<LaunchShortMessageAppraiseResponse> LaunchShortMessageAppraiseWithOptionsAsync(LaunchShortMessageAppraiseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LaunchShortMessageAppraiseResponse>(await DoRPCRequestAsync("LaunchShortMessageAppraise", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public LaunchShortMessageAppraiseResponse LaunchShortMessageAppraise(LaunchShortMessageAppraiseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LaunchShortMessageAppraiseWithOptions(request, runtime);
        }

        public async Task<LaunchShortMessageAppraiseResponse> LaunchShortMessageAppraiseAsync(LaunchShortMessageAppraiseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LaunchShortMessageAppraiseWithOptionsAsync(request, runtime);
        }

        public ListAgentDevicesResponse ListAgentDevicesWithOptions(ListAgentDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAgentDevicesResponse>(DoRPCRequest("ListAgentDevices", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAgentDevicesResponse> ListAgentDevicesWithOptionsAsync(ListAgentDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAgentDevicesResponse>(await DoRPCRequestAsync("ListAgentDevices", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAgentDevicesResponse ListAgentDevices(ListAgentDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAgentDevicesWithOptions(request, runtime);
        }

        public async Task<ListAgentDevicesResponse> ListAgentDevicesAsync(ListAgentDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAgentDevicesWithOptionsAsync(request, runtime);
        }

        public ListAgentEventsResponse ListAgentEventsWithOptions(ListAgentEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAgentEventsResponse>(DoRPCRequest("ListAgentEvents", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAgentEventsResponse> ListAgentEventsWithOptionsAsync(ListAgentEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAgentEventsResponse>(await DoRPCRequestAsync("ListAgentEvents", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAgentEventsResponse ListAgentEvents(ListAgentEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAgentEventsWithOptions(request, runtime);
        }

        public async Task<ListAgentEventsResponse> ListAgentEventsAsync(ListAgentEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAgentEventsWithOptionsAsync(request, runtime);
        }

        public ListAgentStateLogsResponse ListAgentStateLogsWithOptions(ListAgentStateLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAgentStateLogsResponse>(DoRPCRequest("ListAgentStateLogs", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAgentStateLogsResponse> ListAgentStateLogsWithOptionsAsync(ListAgentStateLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAgentStateLogsResponse>(await DoRPCRequestAsync("ListAgentStateLogs", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAgentStateLogsResponse ListAgentStateLogs(ListAgentStateLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAgentStateLogsWithOptions(request, runtime);
        }

        public async Task<ListAgentStateLogsResponse> ListAgentStateLogsAsync(ListAgentStateLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAgentStateLogsWithOptionsAsync(request, runtime);
        }

        public ListAgentStatesResponse ListAgentStatesWithOptions(ListAgentStatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAgentStatesResponse>(DoRPCRequest("ListAgentStates", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAgentStatesResponse> ListAgentStatesWithOptionsAsync(ListAgentStatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAgentStatesResponse>(await DoRPCRequestAsync("ListAgentStates", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAgentStatesResponse ListAgentStates(ListAgentStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAgentStatesWithOptions(request, runtime);
        }

        public async Task<ListAgentStatesResponse> ListAgentStatesAsync(ListAgentStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAgentStatesWithOptionsAsync(request, runtime);
        }

        public ListAgentSummaryReportsResponse ListAgentSummaryReportsWithOptions(ListAgentSummaryReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAgentSummaryReportsResponse>(DoRPCRequest("ListAgentSummaryReports", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAgentSummaryReportsResponse> ListAgentSummaryReportsWithOptionsAsync(ListAgentSummaryReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAgentSummaryReportsResponse>(await DoRPCRequestAsync("ListAgentSummaryReports", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAgentSummaryReportsResponse ListAgentSummaryReports(ListAgentSummaryReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAgentSummaryReportsWithOptions(request, runtime);
        }

        public async Task<ListAgentSummaryReportsResponse> ListAgentSummaryReportsAsync(ListAgentSummaryReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAgentSummaryReportsWithOptionsAsync(request, runtime);
        }

        public ListAgentSummaryReportsByIntervalResponse ListAgentSummaryReportsByIntervalWithOptions(ListAgentSummaryReportsByIntervalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAgentSummaryReportsByIntervalResponse>(DoRPCRequest("ListAgentSummaryReportsByInterval", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAgentSummaryReportsByIntervalResponse> ListAgentSummaryReportsByIntervalWithOptionsAsync(ListAgentSummaryReportsByIntervalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAgentSummaryReportsByIntervalResponse>(await DoRPCRequestAsync("ListAgentSummaryReportsByInterval", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAgentSummaryReportsByIntervalResponse ListAgentSummaryReportsByInterval(ListAgentSummaryReportsByIntervalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAgentSummaryReportsByIntervalWithOptions(request, runtime);
        }

        public async Task<ListAgentSummaryReportsByIntervalResponse> ListAgentSummaryReportsByIntervalAsync(ListAgentSummaryReportsByIntervalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAgentSummaryReportsByIntervalWithOptionsAsync(request, runtime);
        }

        public ListAgentSummaryReportsSinceMidnightResponse ListAgentSummaryReportsSinceMidnightWithOptions(ListAgentSummaryReportsSinceMidnightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAgentSummaryReportsSinceMidnightResponse>(DoRPCRequest("ListAgentSummaryReportsSinceMidnight", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAgentSummaryReportsSinceMidnightResponse> ListAgentSummaryReportsSinceMidnightWithOptionsAsync(ListAgentSummaryReportsSinceMidnightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAgentSummaryReportsSinceMidnightResponse>(await DoRPCRequestAsync("ListAgentSummaryReportsSinceMidnight", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAgentSummaryReportsSinceMidnightResponse ListAgentSummaryReportsSinceMidnight(ListAgentSummaryReportsSinceMidnightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAgentSummaryReportsSinceMidnightWithOptions(request, runtime);
        }

        public async Task<ListAgentSummaryReportsSinceMidnightResponse> ListAgentSummaryReportsSinceMidnightAsync(ListAgentSummaryReportsSinceMidnightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAgentSummaryReportsSinceMidnightWithOptionsAsync(request, runtime);
        }

        public ListBasicStatisticsReportSubItemsResponse ListBasicStatisticsReportSubItemsWithOptions(ListBasicStatisticsReportSubItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBasicStatisticsReportSubItemsResponse>(DoRPCRequest("ListBasicStatisticsReportSubItems", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListBasicStatisticsReportSubItemsResponse> ListBasicStatisticsReportSubItemsWithOptionsAsync(ListBasicStatisticsReportSubItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBasicStatisticsReportSubItemsResponse>(await DoRPCRequestAsync("ListBasicStatisticsReportSubItems", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListBasicStatisticsReportSubItemsResponse ListBasicStatisticsReportSubItems(ListBasicStatisticsReportSubItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBasicStatisticsReportSubItemsWithOptions(request, runtime);
        }

        public async Task<ListBasicStatisticsReportSubItemsResponse> ListBasicStatisticsReportSubItemsAsync(ListBasicStatisticsReportSubItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBasicStatisticsReportSubItemsWithOptionsAsync(request, runtime);
        }

        public ListCallDetailRecordsResponse ListCallDetailRecordsWithOptions(ListCallDetailRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCallDetailRecordsResponse>(DoRPCRequest("ListCallDetailRecords", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCallDetailRecordsResponse> ListCallDetailRecordsWithOptionsAsync(ListCallDetailRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCallDetailRecordsResponse>(await DoRPCRequestAsync("ListCallDetailRecords", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListCallDetailRecordsResponse ListCallDetailRecords(ListCallDetailRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCallDetailRecordsWithOptions(request, runtime);
        }

        public async Task<ListCallDetailRecordsResponse> ListCallDetailRecordsAsync(ListCallDetailRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCallDetailRecordsWithOptionsAsync(request, runtime);
        }

        public ListCallEventDetailByContactIdResponse ListCallEventDetailByContactIdWithOptions(ListCallEventDetailByContactIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCallEventDetailByContactIdResponse>(DoRPCRequest("ListCallEventDetailByContactId", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCallEventDetailByContactIdResponse> ListCallEventDetailByContactIdWithOptionsAsync(ListCallEventDetailByContactIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCallEventDetailByContactIdResponse>(await DoRPCRequestAsync("ListCallEventDetailByContactId", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListCallEventDetailByContactIdResponse ListCallEventDetailByContactId(ListCallEventDetailByContactIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCallEventDetailByContactIdWithOptions(request, runtime);
        }

        public async Task<ListCallEventDetailByContactIdResponse> ListCallEventDetailByContactIdAsync(ListCallEventDetailByContactIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCallEventDetailByContactIdWithOptionsAsync(request, runtime);
        }

        public ListCallMeasureSummaryReportsResponse ListCallMeasureSummaryReportsWithOptions(ListCallMeasureSummaryReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCallMeasureSummaryReportsResponse>(DoRPCRequest("ListCallMeasureSummaryReports", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCallMeasureSummaryReportsResponse> ListCallMeasureSummaryReportsWithOptionsAsync(ListCallMeasureSummaryReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCallMeasureSummaryReportsResponse>(await DoRPCRequestAsync("ListCallMeasureSummaryReports", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListCallMeasureSummaryReportsResponse ListCallMeasureSummaryReports(ListCallMeasureSummaryReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCallMeasureSummaryReportsWithOptions(request, runtime);
        }

        public async Task<ListCallMeasureSummaryReportsResponse> ListCallMeasureSummaryReportsAsync(ListCallMeasureSummaryReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCallMeasureSummaryReportsWithOptionsAsync(request, runtime);
        }

        public ListConfigResponse ListConfigWithOptions(ListConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListConfigResponse>(DoRPCRequest("ListConfig", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListConfigResponse> ListConfigWithOptionsAsync(ListConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListConfigResponse>(await DoRPCRequestAsync("ListConfig", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListConfigResponse ListConfig(ListConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConfigWithOptions(request, runtime);
        }

        public async Task<ListConfigResponse> ListConfigAsync(ListConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConfigWithOptionsAsync(request, runtime);
        }

        public ListContactFlowsResponse ListContactFlowsWithOptions(ListContactFlowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListContactFlowsResponse>(DoRPCRequest("ListContactFlows", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListContactFlowsResponse> ListContactFlowsWithOptionsAsync(ListContactFlowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListContactFlowsResponse>(await DoRPCRequestAsync("ListContactFlows", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListContactFlowsResponse ListContactFlows(ListContactFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListContactFlowsWithOptions(request, runtime);
        }

        public async Task<ListContactFlowsResponse> ListContactFlowsAsync(ListContactFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListContactFlowsWithOptionsAsync(request, runtime);
        }

        public ListInstancesOfUserResponse ListInstancesOfUserWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListInstancesOfUserResponse>(DoRPCRequest("ListInstancesOfUser", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListInstancesOfUserResponse> ListInstancesOfUserWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListInstancesOfUserResponse>(await DoRPCRequestAsync("ListInstancesOfUser", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListInstancesOfUserResponse ListInstancesOfUser()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancesOfUserWithOptions(runtime);
        }

        public async Task<ListInstancesOfUserResponse> ListInstancesOfUserAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancesOfUserWithOptionsAsync(runtime);
        }

        public ListIvrTrackingDetailResponse ListIvrTrackingDetailWithOptions(ListIvrTrackingDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListIvrTrackingDetailResponse>(DoRPCRequest("ListIvrTrackingDetail", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListIvrTrackingDetailResponse> ListIvrTrackingDetailWithOptionsAsync(ListIvrTrackingDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListIvrTrackingDetailResponse>(await DoRPCRequestAsync("ListIvrTrackingDetail", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListIvrTrackingDetailResponse ListIvrTrackingDetail(ListIvrTrackingDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIvrTrackingDetailWithOptions(request, runtime);
        }

        public async Task<ListIvrTrackingDetailResponse> ListIvrTrackingDetailAsync(ListIvrTrackingDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIvrTrackingDetailWithOptionsAsync(request, runtime);
        }

        public ListJobGroupsResponse ListJobGroupsWithOptions(ListJobGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListJobGroupsResponse>(DoRPCRequest("ListJobGroups", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListJobGroupsResponse> ListJobGroupsWithOptionsAsync(ListJobGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListJobGroupsResponse>(await DoRPCRequestAsync("ListJobGroups", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListJobGroupsResponse ListJobGroups(ListJobGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJobGroupsWithOptions(request, runtime);
        }

        public async Task<ListJobGroupsResponse> ListJobGroupsAsync(ListJobGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJobGroupsWithOptionsAsync(request, runtime);
        }

        public ListJobStatusResponse ListJobStatusWithOptions(ListJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListJobStatusResponse>(DoRPCRequest("ListJobStatus", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListJobStatusResponse> ListJobStatusWithOptionsAsync(ListJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListJobStatusResponse>(await DoRPCRequestAsync("ListJobStatus", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListJobStatusResponse ListJobStatus(ListJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJobStatusWithOptions(request, runtime);
        }

        public async Task<ListJobStatusResponse> ListJobStatusAsync(ListJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJobStatusWithOptionsAsync(request, runtime);
        }

        public ListJobsByGroupResponse ListJobsByGroupWithOptions(ListJobsByGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListJobsByGroupResponse>(DoRPCRequest("ListJobsByGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListJobsByGroupResponse> ListJobsByGroupWithOptionsAsync(ListJobsByGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListJobsByGroupResponse>(await DoRPCRequestAsync("ListJobsByGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListJobsByGroupResponse ListJobsByGroup(ListJobsByGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJobsByGroupWithOptions(request, runtime);
        }

        public async Task<ListJobsByGroupResponse> ListJobsByGroupAsync(ListJobsByGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJobsByGroupWithOptionsAsync(request, runtime);
        }

        public ListMediasResponse ListMediasWithOptions(ListMediasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMediasResponse>(DoRPCRequest("ListMedias", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListMediasResponse> ListMediasWithOptionsAsync(ListMediasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMediasResponse>(await DoRPCRequestAsync("ListMedias", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListMediasResponse ListMedias(ListMediasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMediasWithOptions(request, runtime);
        }

        public async Task<ListMediasResponse> ListMediasAsync(ListMediasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMediasWithOptionsAsync(request, runtime);
        }

        public ListOutboundPhoneNumberOfUserResponse ListOutboundPhoneNumberOfUserWithOptions(ListOutboundPhoneNumberOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOutboundPhoneNumberOfUserResponse>(DoRPCRequest("ListOutboundPhoneNumberOfUser", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListOutboundPhoneNumberOfUserResponse> ListOutboundPhoneNumberOfUserWithOptionsAsync(ListOutboundPhoneNumberOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOutboundPhoneNumberOfUserResponse>(await DoRPCRequestAsync("ListOutboundPhoneNumberOfUser", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListOutboundPhoneNumberOfUserResponse ListOutboundPhoneNumberOfUser(ListOutboundPhoneNumberOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOutboundPhoneNumberOfUserWithOptions(request, runtime);
        }

        public async Task<ListOutboundPhoneNumberOfUserResponse> ListOutboundPhoneNumberOfUserAsync(ListOutboundPhoneNumberOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOutboundPhoneNumberOfUserWithOptionsAsync(request, runtime);
        }

        public ListPhoneNumbersResponse ListPhoneNumbersWithOptions(ListPhoneNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPhoneNumbersResponse>(DoRPCRequest("ListPhoneNumbers", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPhoneNumbersResponse> ListPhoneNumbersWithOptionsAsync(ListPhoneNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPhoneNumbersResponse>(await DoRPCRequestAsync("ListPhoneNumbers", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPhoneNumbersResponse ListPhoneNumbers(ListPhoneNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPhoneNumbersWithOptions(request, runtime);
        }

        public async Task<ListPhoneNumbersResponse> ListPhoneNumbersAsync(ListPhoneNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPhoneNumbersWithOptionsAsync(request, runtime);
        }

        public ListPhoneTagsResponse ListPhoneTagsWithOptions(ListPhoneTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPhoneTagsResponse>(DoRPCRequest("ListPhoneTags", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPhoneTagsResponse> ListPhoneTagsWithOptionsAsync(ListPhoneTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPhoneTagsResponse>(await DoRPCRequestAsync("ListPhoneTags", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPhoneTagsResponse ListPhoneTags(ListPhoneTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPhoneTagsWithOptions(request, runtime);
        }

        public async Task<ListPhoneTagsResponse> ListPhoneTagsAsync(ListPhoneTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPhoneTagsWithOptionsAsync(request, runtime);
        }

        public ListRealTimeAgentResponse ListRealTimeAgentWithOptions(ListRealTimeAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRealTimeAgentResponse>(DoRPCRequest("ListRealTimeAgent", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRealTimeAgentResponse> ListRealTimeAgentWithOptionsAsync(ListRealTimeAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRealTimeAgentResponse>(await DoRPCRequestAsync("ListRealTimeAgent", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRealTimeAgentResponse ListRealTimeAgent(ListRealTimeAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRealTimeAgentWithOptions(request, runtime);
        }

        public async Task<ListRealTimeAgentResponse> ListRealTimeAgentAsync(ListRealTimeAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRealTimeAgentWithOptionsAsync(request, runtime);
        }

        public ListRecentCallRecordsResponse ListRecentCallRecordsWithOptions(ListRecentCallRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRecentCallRecordsResponse>(DoRPCRequest("ListRecentCallRecords", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRecentCallRecordsResponse> ListRecentCallRecordsWithOptionsAsync(ListRecentCallRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRecentCallRecordsResponse>(await DoRPCRequestAsync("ListRecentCallRecords", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRecentCallRecordsResponse ListRecentCallRecords(ListRecentCallRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRecentCallRecordsWithOptions(request, runtime);
        }

        public async Task<ListRecentCallRecordsResponse> ListRecentCallRecordsAsync(ListRecentCallRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRecentCallRecordsWithOptionsAsync(request, runtime);
        }

        public ListRecordingOfDualTrackResponse ListRecordingOfDualTrackWithOptions(ListRecordingOfDualTrackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRecordingOfDualTrackResponse>(DoRPCRequest("ListRecordingOfDualTrack", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRecordingOfDualTrackResponse> ListRecordingOfDualTrackWithOptionsAsync(ListRecordingOfDualTrackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRecordingOfDualTrackResponse>(await DoRPCRequestAsync("ListRecordingOfDualTrack", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRecordingOfDualTrackResponse ListRecordingOfDualTrack(ListRecordingOfDualTrackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRecordingOfDualTrackWithOptions(request, runtime);
        }

        public async Task<ListRecordingOfDualTrackResponse> ListRecordingOfDualTrackAsync(ListRecordingOfDualTrackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRecordingOfDualTrackWithOptionsAsync(request, runtime);
        }

        public ListRecordingsResponse ListRecordingsWithOptions(ListRecordingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRecordingsResponse>(DoRPCRequest("ListRecordings", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRecordingsResponse> ListRecordingsWithOptionsAsync(ListRecordingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRecordingsResponse>(await DoRPCRequestAsync("ListRecordings", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRecordingsResponse ListRecordings(ListRecordingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRecordingsWithOptions(request, runtime);
        }

        public async Task<ListRecordingsResponse> ListRecordingsAsync(ListRecordingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRecordingsWithOptionsAsync(request, runtime);
        }

        public ListRecordingsByContactIdResponse ListRecordingsByContactIdWithOptions(ListRecordingsByContactIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRecordingsByContactIdResponse>(DoRPCRequest("ListRecordingsByContactId", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRecordingsByContactIdResponse> ListRecordingsByContactIdWithOptionsAsync(ListRecordingsByContactIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRecordingsByContactIdResponse>(await DoRPCRequestAsync("ListRecordingsByContactId", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRecordingsByContactIdResponse ListRecordingsByContactId(ListRecordingsByContactIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRecordingsByContactIdWithOptions(request, runtime);
        }

        public async Task<ListRecordingsByContactIdResponse> ListRecordingsByContactIdAsync(ListRecordingsByContactIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRecordingsByContactIdWithOptionsAsync(request, runtime);
        }

        public ListRolesResponse ListRolesWithOptions(ListRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRolesResponse>(DoRPCRequest("ListRoles", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRolesResponse> ListRolesWithOptionsAsync(ListRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRolesResponse>(await DoRPCRequestAsync("ListRoles", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRolesResponse ListRoles(ListRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRolesWithOptions(request, runtime);
        }

        public async Task<ListRolesResponse> ListRolesAsync(ListRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRolesWithOptionsAsync(request, runtime);
        }

        public ListScenarioTemplatesResponse ListScenarioTemplatesWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListScenarioTemplatesResponse>(DoRPCRequest("ListScenarioTemplates", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListScenarioTemplatesResponse> ListScenarioTemplatesWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListScenarioTemplatesResponse>(await DoRPCRequestAsync("ListScenarioTemplates", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListScenarioTemplatesResponse ListScenarioTemplates()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScenarioTemplatesWithOptions(runtime);
        }

        public async Task<ListScenarioTemplatesResponse> ListScenarioTemplatesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScenarioTemplatesWithOptionsAsync(runtime);
        }

        public ListScenariosResponse ListScenariosWithOptions(ListScenariosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListScenariosResponse>(DoRPCRequest("ListScenarios", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListScenariosResponse> ListScenariosWithOptionsAsync(ListScenariosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListScenariosResponse>(await DoRPCRequestAsync("ListScenarios", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListScenariosResponse ListScenarios(ListScenariosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScenariosWithOptions(request, runtime);
        }

        public async Task<ListScenariosResponse> ListScenariosAsync(ListScenariosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScenariosWithOptionsAsync(request, runtime);
        }

        public ListSkillGroupStatesResponse ListSkillGroupStatesWithOptions(ListSkillGroupStatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSkillGroupStatesResponse>(DoRPCRequest("ListSkillGroupStates", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSkillGroupStatesResponse> ListSkillGroupStatesWithOptionsAsync(ListSkillGroupStatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSkillGroupStatesResponse>(await DoRPCRequestAsync("ListSkillGroupStates", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSkillGroupStatesResponse ListSkillGroupStates(ListSkillGroupStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSkillGroupStatesWithOptions(request, runtime);
        }

        public async Task<ListSkillGroupStatesResponse> ListSkillGroupStatesAsync(ListSkillGroupStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSkillGroupStatesWithOptionsAsync(request, runtime);
        }

        public ListSkillGroupSummaryReportsResponse ListSkillGroupSummaryReportsWithOptions(ListSkillGroupSummaryReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSkillGroupSummaryReportsResponse>(DoRPCRequest("ListSkillGroupSummaryReports", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSkillGroupSummaryReportsResponse> ListSkillGroupSummaryReportsWithOptionsAsync(ListSkillGroupSummaryReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSkillGroupSummaryReportsResponse>(await DoRPCRequestAsync("ListSkillGroupSummaryReports", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSkillGroupSummaryReportsResponse ListSkillGroupSummaryReports(ListSkillGroupSummaryReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSkillGroupSummaryReportsWithOptions(request, runtime);
        }

        public async Task<ListSkillGroupSummaryReportsResponse> ListSkillGroupSummaryReportsAsync(ListSkillGroupSummaryReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSkillGroupSummaryReportsWithOptionsAsync(request, runtime);
        }

        public ListSkillGroupSummaryReportsByIntervalResponse ListSkillGroupSummaryReportsByIntervalWithOptions(ListSkillGroupSummaryReportsByIntervalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSkillGroupSummaryReportsByIntervalResponse>(DoRPCRequest("ListSkillGroupSummaryReportsByInterval", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSkillGroupSummaryReportsByIntervalResponse> ListSkillGroupSummaryReportsByIntervalWithOptionsAsync(ListSkillGroupSummaryReportsByIntervalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSkillGroupSummaryReportsByIntervalResponse>(await DoRPCRequestAsync("ListSkillGroupSummaryReportsByInterval", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSkillGroupSummaryReportsByIntervalResponse ListSkillGroupSummaryReportsByInterval(ListSkillGroupSummaryReportsByIntervalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSkillGroupSummaryReportsByIntervalWithOptions(request, runtime);
        }

        public async Task<ListSkillGroupSummaryReportsByIntervalResponse> ListSkillGroupSummaryReportsByIntervalAsync(ListSkillGroupSummaryReportsByIntervalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSkillGroupSummaryReportsByIntervalWithOptionsAsync(request, runtime);
        }

        public ListSkillGroupSummaryReportsSinceMidnightResponse ListSkillGroupSummaryReportsSinceMidnightWithOptions(ListSkillGroupSummaryReportsSinceMidnightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSkillGroupSummaryReportsSinceMidnightResponse>(DoRPCRequest("ListSkillGroupSummaryReportsSinceMidnight", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSkillGroupSummaryReportsSinceMidnightResponse> ListSkillGroupSummaryReportsSinceMidnightWithOptionsAsync(ListSkillGroupSummaryReportsSinceMidnightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSkillGroupSummaryReportsSinceMidnightResponse>(await DoRPCRequestAsync("ListSkillGroupSummaryReportsSinceMidnight", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSkillGroupSummaryReportsSinceMidnightResponse ListSkillGroupSummaryReportsSinceMidnight(ListSkillGroupSummaryReportsSinceMidnightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSkillGroupSummaryReportsSinceMidnightWithOptions(request, runtime);
        }

        public async Task<ListSkillGroupSummaryReportsSinceMidnightResponse> ListSkillGroupSummaryReportsSinceMidnightAsync(ListSkillGroupSummaryReportsSinceMidnightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSkillGroupSummaryReportsSinceMidnightWithOptionsAsync(request, runtime);
        }

        public ListSkillGroupsResponse ListSkillGroupsWithOptions(ListSkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSkillGroupsResponse>(DoRPCRequest("ListSkillGroups", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSkillGroupsResponse> ListSkillGroupsWithOptionsAsync(ListSkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSkillGroupsResponse>(await DoRPCRequestAsync("ListSkillGroups", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSkillGroupsResponse ListSkillGroups(ListSkillGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSkillGroupsWithOptions(request, runtime);
        }

        public async Task<ListSkillGroupsResponse> ListSkillGroupsAsync(ListSkillGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSkillGroupsWithOptionsAsync(request, runtime);
        }

        public ListSkillGroupsOfUserResponse ListSkillGroupsOfUserWithOptions(ListSkillGroupsOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSkillGroupsOfUserResponse>(DoRPCRequest("ListSkillGroupsOfUser", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSkillGroupsOfUserResponse> ListSkillGroupsOfUserWithOptionsAsync(ListSkillGroupsOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSkillGroupsOfUserResponse>(await DoRPCRequestAsync("ListSkillGroupsOfUser", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSkillGroupsOfUserResponse ListSkillGroupsOfUser(ListSkillGroupsOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSkillGroupsOfUserWithOptions(request, runtime);
        }

        public async Task<ListSkillGroupsOfUserResponse> ListSkillGroupsOfUserAsync(ListSkillGroupsOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSkillGroupsOfUserWithOptionsAsync(request, runtime);
        }

        public ListSurveysResponse ListSurveysWithOptions(ListSurveysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSurveysResponse>(DoRPCRequest("ListSurveys", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSurveysResponse> ListSurveysWithOptionsAsync(ListSurveysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSurveysResponse>(await DoRPCRequestAsync("ListSurveys", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSurveysResponse ListSurveys(ListSurveysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSurveysWithOptions(request, runtime);
        }

        public async Task<ListSurveysResponse> ListSurveysAsync(ListSurveysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSurveysWithOptionsAsync(request, runtime);
        }

        public ListTransferableSkillGroupsResponse ListTransferableSkillGroupsWithOptions(ListTransferableSkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTransferableSkillGroupsResponse>(DoRPCRequest("ListTransferableSkillGroups", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTransferableSkillGroupsResponse> ListTransferableSkillGroupsWithOptionsAsync(ListTransferableSkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTransferableSkillGroupsResponse>(await DoRPCRequestAsync("ListTransferableSkillGroups", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTransferableSkillGroupsResponse ListTransferableSkillGroups(ListTransferableSkillGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTransferableSkillGroupsWithOptions(request, runtime);
        }

        public async Task<ListTransferableSkillGroupsResponse> ListTransferableSkillGroupsAsync(ListTransferableSkillGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTransferableSkillGroupsWithOptionsAsync(request, runtime);
        }

        public ListTrunkProvidersResponse ListTrunkProvidersWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListTrunkProvidersResponse>(DoRPCRequest("ListTrunkProviders", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTrunkProvidersResponse> ListTrunkProvidersWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListTrunkProvidersResponse>(await DoRPCRequestAsync("ListTrunkProviders", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTrunkProvidersResponse ListTrunkProviders()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTrunkProvidersWithOptions(runtime);
        }

        public async Task<ListTrunkProvidersResponse> ListTrunkProvidersAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTrunkProvidersWithOptionsAsync(runtime);
        }

        public ListTrunksOfSkillGroupResponse ListTrunksOfSkillGroupWithOptions(ListTrunksOfSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTrunksOfSkillGroupResponse>(DoRPCRequest("ListTrunksOfSkillGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTrunksOfSkillGroupResponse> ListTrunksOfSkillGroupWithOptionsAsync(ListTrunksOfSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTrunksOfSkillGroupResponse>(await DoRPCRequestAsync("ListTrunksOfSkillGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTrunksOfSkillGroupResponse ListTrunksOfSkillGroup(ListTrunksOfSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTrunksOfSkillGroupWithOptions(request, runtime);
        }

        public async Task<ListTrunksOfSkillGroupResponse> ListTrunksOfSkillGroupAsync(ListTrunksOfSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTrunksOfSkillGroupWithOptionsAsync(request, runtime);
        }

        public ListUnreachableContactsResponse ListUnreachableContactsWithOptions(ListUnreachableContactsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUnreachableContactsResponse>(DoRPCRequest("ListUnreachableContacts", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUnreachableContactsResponse> ListUnreachableContactsWithOptionsAsync(ListUnreachableContactsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUnreachableContactsResponse>(await DoRPCRequestAsync("ListUnreachableContacts", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUnreachableContactsResponse ListUnreachableContacts(ListUnreachableContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUnreachableContactsWithOptions(request, runtime);
        }

        public async Task<ListUnreachableContactsResponse> ListUnreachableContactsAsync(ListUnreachableContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUnreachableContactsWithOptionsAsync(request, runtime);
        }

        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsersResponse>(DoRPCRequest("ListUsers", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsersResponse>(await DoRPCRequestAsync("ListUsers", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersWithOptions(request, runtime);
        }

        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersWithOptionsAsync(request, runtime);
        }

        public ListUsersOfSkillGroupResponse ListUsersOfSkillGroupWithOptions(ListUsersOfSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsersOfSkillGroupResponse>(DoRPCRequest("ListUsersOfSkillGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUsersOfSkillGroupResponse> ListUsersOfSkillGroupWithOptionsAsync(ListUsersOfSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsersOfSkillGroupResponse>(await DoRPCRequestAsync("ListUsersOfSkillGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUsersOfSkillGroupResponse ListUsersOfSkillGroup(ListUsersOfSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersOfSkillGroupWithOptions(request, runtime);
        }

        public async Task<ListUsersOfSkillGroupResponse> ListUsersOfSkillGroupAsync(ListUsersOfSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersOfSkillGroupWithOptionsAsync(request, runtime);
        }

        public ListVoiceAppraiseResponse ListVoiceAppraiseWithOptions(ListVoiceAppraiseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVoiceAppraiseResponse>(DoRPCRequest("ListVoiceAppraise", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListVoiceAppraiseResponse> ListVoiceAppraiseWithOptionsAsync(ListVoiceAppraiseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVoiceAppraiseResponse>(await DoRPCRequestAsync("ListVoiceAppraise", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListVoiceAppraiseResponse ListVoiceAppraise(ListVoiceAppraiseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVoiceAppraiseWithOptions(request, runtime);
        }

        public async Task<ListVoiceAppraiseResponse> ListVoiceAppraiseAsync(ListVoiceAppraiseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVoiceAppraiseWithOptionsAsync(request, runtime);
        }

        public ModifyAgentDeviceResponse ModifyAgentDeviceWithOptions(ModifyAgentDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAgentDeviceResponse>(DoRPCRequest("ModifyAgentDevice", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAgentDeviceResponse> ModifyAgentDeviceWithOptionsAsync(ModifyAgentDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAgentDeviceResponse>(await DoRPCRequestAsync("ModifyAgentDevice", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyAgentDeviceResponse ModifyAgentDevice(ModifyAgentDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAgentDeviceWithOptions(request, runtime);
        }

        public async Task<ModifyAgentDeviceResponse> ModifyAgentDeviceAsync(ModifyAgentDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAgentDeviceWithOptionsAsync(request, runtime);
        }

        public ModifyCabInstanceResponse ModifyCabInstanceWithOptions(ModifyCabInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCabInstanceResponse>(DoRPCRequest("ModifyCabInstance", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCabInstanceResponse> ModifyCabInstanceWithOptionsAsync(ModifyCabInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCabInstanceResponse>(await DoRPCRequestAsync("ModifyCabInstance", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCabInstanceResponse ModifyCabInstance(ModifyCabInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCabInstanceWithOptions(request, runtime);
        }

        public async Task<ModifyCabInstanceResponse> ModifyCabInstanceAsync(ModifyCabInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCabInstanceWithOptionsAsync(request, runtime);
        }

        public ModifyCallRatioResponse ModifyCallRatioWithOptions(ModifyCallRatioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCallRatioResponse>(DoRPCRequest("ModifyCallRatio", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCallRatioResponse> ModifyCallRatioWithOptionsAsync(ModifyCallRatioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCallRatioResponse>(await DoRPCRequestAsync("ModifyCallRatio", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCallRatioResponse ModifyCallRatio(ModifyCallRatioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCallRatioWithOptions(request, runtime);
        }

        public async Task<ModifyCallRatioResponse> ModifyCallRatioAsync(ModifyCallRatioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCallRatioWithOptionsAsync(request, runtime);
        }

        public ModifyPhoneNumberResponse ModifyPhoneNumberWithOptions(ModifyPhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPhoneNumberResponse>(DoRPCRequest("ModifyPhoneNumber", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyPhoneNumberResponse> ModifyPhoneNumberWithOptionsAsync(ModifyPhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPhoneNumberResponse>(await DoRPCRequestAsync("ModifyPhoneNumber", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyPhoneNumberResponse ModifyPhoneNumber(ModifyPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPhoneNumberWithOptions(request, runtime);
        }

        public async Task<ModifyPhoneNumberResponse> ModifyPhoneNumberAsync(ModifyPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPhoneNumberWithOptionsAsync(request, runtime);
        }

        public ModifyPhoneTagsResponse ModifyPhoneTagsWithOptions(ModifyPhoneTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPhoneTagsResponse>(DoRPCRequest("ModifyPhoneTags", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyPhoneTagsResponse> ModifyPhoneTagsWithOptionsAsync(ModifyPhoneTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPhoneTagsResponse>(await DoRPCRequestAsync("ModifyPhoneTags", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyPhoneTagsResponse ModifyPhoneTags(ModifyPhoneTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPhoneTagsWithOptions(request, runtime);
        }

        public async Task<ModifyPhoneTagsResponse> ModifyPhoneTagsAsync(ModifyPhoneTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPhoneTagsWithOptionsAsync(request, runtime);
        }

        public ModifyPrimaryTrunksOfSkillGroupResponse ModifyPrimaryTrunksOfSkillGroupWithOptions(ModifyPrimaryTrunksOfSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPrimaryTrunksOfSkillGroupResponse>(DoRPCRequest("ModifyPrimaryTrunksOfSkillGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyPrimaryTrunksOfSkillGroupResponse> ModifyPrimaryTrunksOfSkillGroupWithOptionsAsync(ModifyPrimaryTrunksOfSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPrimaryTrunksOfSkillGroupResponse>(await DoRPCRequestAsync("ModifyPrimaryTrunksOfSkillGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyPrimaryTrunksOfSkillGroupResponse ModifyPrimaryTrunksOfSkillGroup(ModifyPrimaryTrunksOfSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPrimaryTrunksOfSkillGroupWithOptions(request, runtime);
        }

        public async Task<ModifyPrimaryTrunksOfSkillGroupResponse> ModifyPrimaryTrunksOfSkillGroupAsync(ModifyPrimaryTrunksOfSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPrimaryTrunksOfSkillGroupWithOptionsAsync(request, runtime);
        }

        public ModifyPrivacyNumberCallDetailResponse ModifyPrivacyNumberCallDetailWithOptions(ModifyPrivacyNumberCallDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPrivacyNumberCallDetailResponse>(DoRPCRequest("ModifyPrivacyNumberCallDetail", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyPrivacyNumberCallDetailResponse> ModifyPrivacyNumberCallDetailWithOptionsAsync(ModifyPrivacyNumberCallDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPrivacyNumberCallDetailResponse>(await DoRPCRequestAsync("ModifyPrivacyNumberCallDetail", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyPrivacyNumberCallDetailResponse ModifyPrivacyNumberCallDetail(ModifyPrivacyNumberCallDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPrivacyNumberCallDetailWithOptions(request, runtime);
        }

        public async Task<ModifyPrivacyNumberCallDetailResponse> ModifyPrivacyNumberCallDetailAsync(ModifyPrivacyNumberCallDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPrivacyNumberCallDetailWithOptionsAsync(request, runtime);
        }

        public ModifyScenarioResponse ModifyScenarioWithOptions(ModifyScenarioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScenarioResponse>(DoRPCRequest("ModifyScenario", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyScenarioResponse> ModifyScenarioWithOptionsAsync(ModifyScenarioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScenarioResponse>(await DoRPCRequestAsync("ModifyScenario", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyScenarioResponse ModifyScenario(ModifyScenarioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScenarioWithOptions(request, runtime);
        }

        public async Task<ModifyScenarioResponse> ModifyScenarioAsync(ModifyScenarioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScenarioWithOptionsAsync(request, runtime);
        }

        public ModifySkillGroupResponse ModifySkillGroupWithOptions(ModifySkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySkillGroupResponse>(DoRPCRequest("ModifySkillGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySkillGroupResponse> ModifySkillGroupWithOptionsAsync(ModifySkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySkillGroupResponse>(await DoRPCRequestAsync("ModifySkillGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySkillGroupResponse ModifySkillGroup(ModifySkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySkillGroupWithOptions(request, runtime);
        }

        public async Task<ModifySkillGroupResponse> ModifySkillGroupAsync(ModifySkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySkillGroupWithOptionsAsync(request, runtime);
        }

        public ModifySkillGroupOfUserResponse ModifySkillGroupOfUserWithOptions(ModifySkillGroupOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySkillGroupOfUserResponse>(DoRPCRequest("ModifySkillGroupOfUser", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySkillGroupOfUserResponse> ModifySkillGroupOfUserWithOptionsAsync(ModifySkillGroupOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySkillGroupOfUserResponse>(await DoRPCRequestAsync("ModifySkillGroupOfUser", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySkillGroupOfUserResponse ModifySkillGroupOfUser(ModifySkillGroupOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySkillGroupOfUserWithOptions(request, runtime);
        }

        public async Task<ModifySkillGroupOfUserResponse> ModifySkillGroupOfUserAsync(ModifySkillGroupOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySkillGroupOfUserWithOptionsAsync(request, runtime);
        }

        public ModifySkillGroupOutboundNumbersResponse ModifySkillGroupOutboundNumbersWithOptions(ModifySkillGroupOutboundNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySkillGroupOutboundNumbersResponse>(DoRPCRequest("ModifySkillGroupOutboundNumbers", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySkillGroupOutboundNumbersResponse> ModifySkillGroupOutboundNumbersWithOptionsAsync(ModifySkillGroupOutboundNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySkillGroupOutboundNumbersResponse>(await DoRPCRequestAsync("ModifySkillGroupOutboundNumbers", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySkillGroupOutboundNumbersResponse ModifySkillGroupOutboundNumbers(ModifySkillGroupOutboundNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySkillGroupOutboundNumbersWithOptions(request, runtime);
        }

        public async Task<ModifySkillGroupOutboundNumbersResponse> ModifySkillGroupOutboundNumbersAsync(ModifySkillGroupOutboundNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySkillGroupOutboundNumbersWithOptionsAsync(request, runtime);
        }

        public ModifySurveyResponse ModifySurveyWithOptions(ModifySurveyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySurveyResponse>(DoRPCRequest("ModifySurvey", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySurveyResponse> ModifySurveyWithOptionsAsync(ModifySurveyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySurveyResponse>(await DoRPCRequestAsync("ModifySurvey", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySurveyResponse ModifySurvey(ModifySurveyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySurveyWithOptions(request, runtime);
        }

        public async Task<ModifySurveyResponse> ModifySurveyAsync(ModifySurveyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySurveyWithOptionsAsync(request, runtime);
        }

        public ModifyUserResponse ModifyUserWithOptions(ModifyUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUserResponse>(DoRPCRequest("ModifyUser", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyUserResponse> ModifyUserWithOptionsAsync(ModifyUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUserResponse>(await DoRPCRequestAsync("ModifyUser", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyUserResponse ModifyUser(ModifyUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyUserWithOptions(request, runtime);
        }

        public async Task<ModifyUserResponse> ModifyUserAsync(ModifyUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyUserWithOptionsAsync(request, runtime);
        }

        public PickGlobalOutboundNumbersResponse PickGlobalOutboundNumbersWithOptions(PickGlobalOutboundNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PickGlobalOutboundNumbersResponse>(DoRPCRequest("PickGlobalOutboundNumbers", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PickGlobalOutboundNumbersResponse> PickGlobalOutboundNumbersWithOptionsAsync(PickGlobalOutboundNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PickGlobalOutboundNumbersResponse>(await DoRPCRequestAsync("PickGlobalOutboundNumbers", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PickGlobalOutboundNumbersResponse PickGlobalOutboundNumbers(PickGlobalOutboundNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PickGlobalOutboundNumbersWithOptions(request, runtime);
        }

        public async Task<PickGlobalOutboundNumbersResponse> PickGlobalOutboundNumbersAsync(PickGlobalOutboundNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PickGlobalOutboundNumbersWithOptionsAsync(request, runtime);
        }

        public PickLocalNumberResponse PickLocalNumberWithOptions(PickLocalNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PickLocalNumberResponse>(DoRPCRequest("PickLocalNumber", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PickLocalNumberResponse> PickLocalNumberWithOptionsAsync(PickLocalNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PickLocalNumberResponse>(await DoRPCRequestAsync("PickLocalNumber", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PickLocalNumberResponse PickLocalNumber(PickLocalNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PickLocalNumberWithOptions(request, runtime);
        }

        public async Task<PickLocalNumberResponse> PickLocalNumberAsync(PickLocalNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PickLocalNumberWithOptionsAsync(request, runtime);
        }

        public PickOutboundNumbersResponse PickOutboundNumbersWithOptions(PickOutboundNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PickOutboundNumbersResponse>(DoRPCRequest("PickOutboundNumbers", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PickOutboundNumbersResponse> PickOutboundNumbersWithOptionsAsync(PickOutboundNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PickOutboundNumbersResponse>(await DoRPCRequestAsync("PickOutboundNumbers", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PickOutboundNumbersResponse PickOutboundNumbers(PickOutboundNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PickOutboundNumbersWithOptions(request, runtime);
        }

        public async Task<PickOutboundNumbersResponse> PickOutboundNumbersAsync(PickOutboundNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PickOutboundNumbersWithOptionsAsync(request, runtime);
        }

        public PublishContactFlowVersionResponse PublishContactFlowVersionWithOptions(PublishContactFlowVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishContactFlowVersionResponse>(DoRPCRequest("PublishContactFlowVersion", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PublishContactFlowVersionResponse> PublishContactFlowVersionWithOptionsAsync(PublishContactFlowVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishContactFlowVersionResponse>(await DoRPCRequestAsync("PublishContactFlowVersion", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PublishContactFlowVersionResponse PublishContactFlowVersion(PublishContactFlowVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishContactFlowVersionWithOptions(request, runtime);
        }

        public async Task<PublishContactFlowVersionResponse> PublishContactFlowVersionAsync(PublishContactFlowVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishContactFlowVersionWithOptionsAsync(request, runtime);
        }

        public PublishPredictiveJobGroupResponse PublishPredictiveJobGroupWithOptions(PublishPredictiveJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishPredictiveJobGroupResponse>(DoRPCRequest("PublishPredictiveJobGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PublishPredictiveJobGroupResponse> PublishPredictiveJobGroupWithOptionsAsync(PublishPredictiveJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishPredictiveJobGroupResponse>(await DoRPCRequestAsync("PublishPredictiveJobGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PublishPredictiveJobGroupResponse PublishPredictiveJobGroup(PublishPredictiveJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishPredictiveJobGroupWithOptions(request, runtime);
        }

        public async Task<PublishPredictiveJobGroupResponse> PublishPredictiveJobGroupAsync(PublishPredictiveJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishPredictiveJobGroupWithOptionsAsync(request, runtime);
        }

        public PublishSurveyResponse PublishSurveyWithOptions(PublishSurveyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishSurveyResponse>(DoRPCRequest("PublishSurvey", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PublishSurveyResponse> PublishSurveyWithOptionsAsync(PublishSurveyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishSurveyResponse>(await DoRPCRequestAsync("PublishSurvey", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PublishSurveyResponse PublishSurvey(PublishSurveyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishSurveyWithOptions(request, runtime);
        }

        public async Task<PublishSurveyResponse> PublishSurveyAsync(PublishSurveyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishSurveyWithOptionsAsync(request, runtime);
        }

        public RefreshTokenResponse RefreshTokenWithOptions(RefreshTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshTokenResponse>(DoRPCRequest("RefreshToken", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RefreshTokenResponse> RefreshTokenWithOptionsAsync(RefreshTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshTokenResponse>(await DoRPCRequestAsync("RefreshToken", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RefreshTokenResponse RefreshToken(RefreshTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshTokenWithOptions(request, runtime);
        }

        public async Task<RefreshTokenResponse> RefreshTokenAsync(RefreshTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshTokenWithOptionsAsync(request, runtime);
        }

        public RemovePhoneNumberResponse RemovePhoneNumberWithOptions(RemovePhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemovePhoneNumberResponse>(DoRPCRequest("RemovePhoneNumber", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemovePhoneNumberResponse> RemovePhoneNumberWithOptionsAsync(RemovePhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemovePhoneNumberResponse>(await DoRPCRequestAsync("RemovePhoneNumber", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemovePhoneNumberResponse RemovePhoneNumber(RemovePhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemovePhoneNumberWithOptions(request, runtime);
        }

        public async Task<RemovePhoneNumberResponse> RemovePhoneNumberAsync(RemovePhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemovePhoneNumberWithOptionsAsync(request, runtime);
        }

        public RemoveUsersResponse RemoveUsersWithOptions(RemoveUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveUsersResponse>(DoRPCRequest("RemoveUsers", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveUsersResponse> RemoveUsersWithOptionsAsync(RemoveUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveUsersResponse>(await DoRPCRequestAsync("RemoveUsers", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveUsersResponse RemoveUsers(RemoveUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveUsersWithOptions(request, runtime);
        }

        public async Task<RemoveUsersResponse> RemoveUsersAsync(RemoveUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveUsersWithOptionsAsync(request, runtime);
        }

        public RemoveUsersFromSkillGroupResponse RemoveUsersFromSkillGroupWithOptions(RemoveUsersFromSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveUsersFromSkillGroupResponse>(DoRPCRequest("RemoveUsersFromSkillGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveUsersFromSkillGroupResponse> RemoveUsersFromSkillGroupWithOptionsAsync(RemoveUsersFromSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveUsersFromSkillGroupResponse>(await DoRPCRequestAsync("RemoveUsersFromSkillGroup", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveUsersFromSkillGroupResponse RemoveUsersFromSkillGroup(RemoveUsersFromSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveUsersFromSkillGroupWithOptions(request, runtime);
        }

        public async Task<RemoveUsersFromSkillGroupResponse> RemoveUsersFromSkillGroupAsync(RemoveUsersFromSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveUsersFromSkillGroupWithOptionsAsync(request, runtime);
        }

        public RequestLoginInfoResponse RequestLoginInfoWithOptions(RequestLoginInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RequestLoginInfoResponse>(DoRPCRequest("RequestLoginInfo", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RequestLoginInfoResponse> RequestLoginInfoWithOptionsAsync(RequestLoginInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RequestLoginInfoResponse>(await DoRPCRequestAsync("RequestLoginInfo", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RequestLoginInfoResponse RequestLoginInfo(RequestLoginInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RequestLoginInfoWithOptions(request, runtime);
        }

        public async Task<RequestLoginInfoResponse> RequestLoginInfoAsync(RequestLoginInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RequestLoginInfoWithOptionsAsync(request, runtime);
        }

        public ResetUserStatusResponse ResetUserStatusWithOptions(ResetUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetUserStatusResponse>(DoRPCRequest("ResetUserStatus", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetUserStatusResponse> ResetUserStatusWithOptionsAsync(ResetUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetUserStatusResponse>(await DoRPCRequestAsync("ResetUserStatus", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResetUserStatusResponse ResetUserStatus(ResetUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetUserStatusWithOptions(request, runtime);
        }

        public async Task<ResetUserStatusResponse> ResetUserStatusAsync(ResetUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetUserStatusWithOptionsAsync(request, runtime);
        }

        public ResumeJobsResponse ResumeJobsWithOptions(ResumeJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResumeJobsResponse>(DoRPCRequest("ResumeJobs", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResumeJobsResponse> ResumeJobsWithOptionsAsync(ResumeJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResumeJobsResponse>(await DoRPCRequestAsync("ResumeJobs", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResumeJobsResponse ResumeJobs(ResumeJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeJobsWithOptions(request, runtime);
        }

        public async Task<ResumeJobsResponse> ResumeJobsAsync(ResumeJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeJobsWithOptionsAsync(request, runtime);
        }

        public ResumePredictiveJobsResponse ResumePredictiveJobsWithOptions(ResumePredictiveJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResumePredictiveJobsResponse>(DoRPCRequest("ResumePredictiveJobs", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResumePredictiveJobsResponse> ResumePredictiveJobsWithOptionsAsync(ResumePredictiveJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResumePredictiveJobsResponse>(await DoRPCRequestAsync("ResumePredictiveJobs", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResumePredictiveJobsResponse ResumePredictiveJobs(ResumePredictiveJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumePredictiveJobsWithOptions(request, runtime);
        }

        public async Task<ResumePredictiveJobsResponse> ResumePredictiveJobsAsync(ResumePredictiveJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumePredictiveJobsWithOptionsAsync(request, runtime);
        }

        public SaveStatsResponse SaveStatsWithOptions(SaveStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveStatsResponse>(DoRPCRequest("SaveStats", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveStatsResponse> SaveStatsWithOptionsAsync(SaveStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveStatsResponse>(await DoRPCRequestAsync("SaveStats", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveStatsResponse SaveStats(SaveStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveStatsWithOptions(request, runtime);
        }

        public async Task<SaveStatsResponse> SaveStatsAsync(SaveStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveStatsWithOptionsAsync(request, runtime);
        }

        public SaveTerminalLogResponse SaveTerminalLogWithOptions(SaveTerminalLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveTerminalLogResponse>(DoRPCRequest("SaveTerminalLog", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveTerminalLogResponse> SaveTerminalLogWithOptionsAsync(SaveTerminalLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveTerminalLogResponse>(await DoRPCRequestAsync("SaveTerminalLog", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveTerminalLogResponse SaveTerminalLog(SaveTerminalLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTerminalLogWithOptions(request, runtime);
        }

        public async Task<SaveTerminalLogResponse> SaveTerminalLogAsync(SaveTerminalLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTerminalLogWithOptionsAsync(request, runtime);
        }

        public SaveWebRTCStatsResponse SaveWebRTCStatsWithOptions(SaveWebRTCStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveWebRTCStatsResponse>(DoRPCRequest("SaveWebRTCStats", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveWebRTCStatsResponse> SaveWebRTCStatsWithOptionsAsync(SaveWebRTCStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveWebRTCStatsResponse>(await DoRPCRequestAsync("SaveWebRTCStats", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveWebRTCStatsResponse SaveWebRTCStats(SaveWebRTCStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveWebRTCStatsWithOptions(request, runtime);
        }

        public async Task<SaveWebRTCStatsResponse> SaveWebRTCStatsAsync(SaveWebRTCStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveWebRTCStatsWithOptionsAsync(request, runtime);
        }

        public SendPredefinedShortMessageResponse SendPredefinedShortMessageWithOptions(SendPredefinedShortMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendPredefinedShortMessageResponse>(DoRPCRequest("SendPredefinedShortMessage", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendPredefinedShortMessageResponse> SendPredefinedShortMessageWithOptionsAsync(SendPredefinedShortMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendPredefinedShortMessageResponse>(await DoRPCRequestAsync("SendPredefinedShortMessage", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendPredefinedShortMessageResponse SendPredefinedShortMessage(SendPredefinedShortMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendPredefinedShortMessageWithOptions(request, runtime);
        }

        public async Task<SendPredefinedShortMessageResponse> SendPredefinedShortMessageAsync(SendPredefinedShortMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendPredefinedShortMessageWithOptionsAsync(request, runtime);
        }

        public StartBack2BackCallResponse StartBack2BackCallWithOptions(StartBack2BackCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartBack2BackCallResponse>(DoRPCRequest("StartBack2BackCall", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartBack2BackCallResponse> StartBack2BackCallWithOptionsAsync(StartBack2BackCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartBack2BackCallResponse>(await DoRPCRequestAsync("StartBack2BackCall", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartBack2BackCallResponse StartBack2BackCall(StartBack2BackCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartBack2BackCallWithOptions(request, runtime);
        }

        public async Task<StartBack2BackCallResponse> StartBack2BackCallAsync(StartBack2BackCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartBack2BackCallWithOptionsAsync(request, runtime);
        }

        public StartJobResponse StartJobWithOptions(StartJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartJobResponse>(DoRPCRequest("StartJob", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartJobResponse> StartJobWithOptionsAsync(StartJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartJobResponse>(await DoRPCRequestAsync("StartJob", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartJobResponse StartJob(StartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartJobWithOptions(request, runtime);
        }

        public async Task<StartJobResponse> StartJobAsync(StartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartJobWithOptionsAsync(request, runtime);
        }

        public SubmitBatchJobsResponse SubmitBatchJobsWithOptions(SubmitBatchJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitBatchJobsResponse>(DoRPCRequest("SubmitBatchJobs", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitBatchJobsResponse> SubmitBatchJobsWithOptionsAsync(SubmitBatchJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitBatchJobsResponse>(await DoRPCRequestAsync("SubmitBatchJobs", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitBatchJobsResponse SubmitBatchJobs(SubmitBatchJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitBatchJobsWithOptions(request, runtime);
        }

        public async Task<SubmitBatchJobsResponse> SubmitBatchJobsAsync(SubmitBatchJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitBatchJobsWithOptionsAsync(request, runtime);
        }

        public SubmitCabRecordingResponse SubmitCabRecordingWithOptions(SubmitCabRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitCabRecordingResponse>(DoRPCRequest("SubmitCabRecording", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitCabRecordingResponse> SubmitCabRecordingWithOptionsAsync(SubmitCabRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitCabRecordingResponse>(await DoRPCRequestAsync("SubmitCabRecording", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitCabRecordingResponse SubmitCabRecording(SubmitCabRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitCabRecordingWithOptions(request, runtime);
        }

        public async Task<SubmitCabRecordingResponse> SubmitCabRecordingAsync(SubmitCabRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitCabRecordingWithOptionsAsync(request, runtime);
        }

        public SuspendJobsResponse SuspendJobsWithOptions(SuspendJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendJobsResponse>(DoRPCRequest("SuspendJobs", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SuspendJobsResponse> SuspendJobsWithOptionsAsync(SuspendJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendJobsResponse>(await DoRPCRequestAsync("SuspendJobs", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SuspendJobsResponse SuspendJobs(SuspendJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendJobsWithOptions(request, runtime);
        }

        public async Task<SuspendJobsResponse> SuspendJobsAsync(SuspendJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendJobsWithOptionsAsync(request, runtime);
        }

        public SuspendPredictiveJobsResponse SuspendPredictiveJobsWithOptions(SuspendPredictiveJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendPredictiveJobsResponse>(DoRPCRequest("SuspendPredictiveJobs", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SuspendPredictiveJobsResponse> SuspendPredictiveJobsWithOptionsAsync(SuspendPredictiveJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendPredictiveJobsResponse>(await DoRPCRequestAsync("SuspendPredictiveJobs", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SuspendPredictiveJobsResponse SuspendPredictiveJobs(SuspendPredictiveJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendPredictiveJobsWithOptions(request, runtime);
        }

        public async Task<SuspendPredictiveJobsResponse> SuspendPredictiveJobsAsync(SuspendPredictiveJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendPredictiveJobsWithOptionsAsync(request, runtime);
        }

        public TaskPreparingResponse TaskPreparingWithOptions(TaskPreparingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TaskPreparingResponse>(DoRPCRequest("TaskPreparing", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TaskPreparingResponse> TaskPreparingWithOptionsAsync(TaskPreparingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TaskPreparingResponse>(await DoRPCRequestAsync("TaskPreparing", "2017-07-05", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TaskPreparingResponse TaskPreparing(TaskPreparingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TaskPreparingWithOptions(request, runtime);
        }

        public async Task<TaskPreparingResponse> TaskPreparingAsync(TaskPreparingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TaskPreparingWithOptionsAsync(request, runtime);
        }

    }
}
