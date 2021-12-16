// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.CCC20200701.Models;

namespace AlibabaCloud.SDK.CCC20200701
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

        public AbortCampaignResponse AbortCampaignWithOptions(AbortCampaignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CampaignId"] = request.CampaignId;
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortCampaignResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AbortCampaignResponse> AbortCampaignWithOptionsAsync(AbortCampaignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CampaignId"] = request.CampaignId;
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortCampaignResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AbortCampaignResponse AbortCampaign(AbortCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AbortCampaignWithOptions(request, runtime);
        }

        public async Task<AbortCampaignResponse> AbortCampaignAsync(AbortCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AbortCampaignWithOptionsAsync(request, runtime);
        }

        public AddNumbersToSkillGroupResponse AddNumbersToSkillGroupWithOptions(AddNumbersToSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["NumberList"] = request.NumberList;
            query["SkillGroupId"] = request.SkillGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddNumbersToSkillGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddNumbersToSkillGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddNumbersToSkillGroupResponse> AddNumbersToSkillGroupWithOptionsAsync(AddNumbersToSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["NumberList"] = request.NumberList;
            query["SkillGroupId"] = request.SkillGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddNumbersToSkillGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddNumbersToSkillGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddNumbersToSkillGroupResponse AddNumbersToSkillGroup(AddNumbersToSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddNumbersToSkillGroupWithOptions(request, runtime);
        }

        public async Task<AddNumbersToSkillGroupResponse> AddNumbersToSkillGroupAsync(AddNumbersToSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddNumbersToSkillGroupWithOptionsAsync(request, runtime);
        }

        public AddPersonalNumbersToUserResponse AddPersonalNumbersToUserWithOptions(AddPersonalNumbersToUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["NumberList"] = request.NumberList;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddPersonalNumbersToUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddPersonalNumbersToUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddPersonalNumbersToUserResponse> AddPersonalNumbersToUserWithOptionsAsync(AddPersonalNumbersToUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["NumberList"] = request.NumberList;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddPersonalNumbersToUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddPersonalNumbersToUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddPersonalNumbersToUserResponse AddPersonalNumbersToUser(AddPersonalNumbersToUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddPersonalNumbersToUserWithOptions(request, runtime);
        }

        public async Task<AddPersonalNumbersToUserResponse> AddPersonalNumbersToUserAsync(AddPersonalNumbersToUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddPersonalNumbersToUserWithOptionsAsync(request, runtime);
        }

        public AddPhoneNumberToSkillGroupsResponse AddPhoneNumberToSkillGroupsWithOptions(AddPhoneNumberToSkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["Number"] = request.Number;
            query["SkillGroupIdList"] = request.SkillGroupIdList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddPhoneNumberToSkillGroups",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddPhoneNumberToSkillGroupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddPhoneNumberToSkillGroupsResponse> AddPhoneNumberToSkillGroupsWithOptionsAsync(AddPhoneNumberToSkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["Number"] = request.Number;
            query["SkillGroupIdList"] = request.SkillGroupIdList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddPhoneNumberToSkillGroups",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddPhoneNumberToSkillGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddPhoneNumberToSkillGroupsResponse AddPhoneNumberToSkillGroups(AddPhoneNumberToSkillGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddPhoneNumberToSkillGroupsWithOptions(request, runtime);
        }

        public async Task<AddPhoneNumberToSkillGroupsResponse> AddPhoneNumberToSkillGroupsAsync(AddPhoneNumberToSkillGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddPhoneNumberToSkillGroupsWithOptionsAsync(request, runtime);
        }

        public AddPhoneNumbersResponse AddPhoneNumbersWithOptions(AddPhoneNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ContactFlowId"] = request.ContactFlowId;
            query["InstanceId"] = request.InstanceId;
            query["NumberGroupId"] = request.NumberGroupId;
            query["NumberList"] = request.NumberList;
            query["Usage"] = request.Usage;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddPhoneNumbers",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddPhoneNumbersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddPhoneNumbersResponse> AddPhoneNumbersWithOptionsAsync(AddPhoneNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ContactFlowId"] = request.ContactFlowId;
            query["InstanceId"] = request.InstanceId;
            query["NumberGroupId"] = request.NumberGroupId;
            query["NumberList"] = request.NumberList;
            query["Usage"] = request.Usage;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddPhoneNumbers",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddPhoneNumbersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddPhoneNumbersResponse AddPhoneNumbers(AddPhoneNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddPhoneNumbersWithOptions(request, runtime);
        }

        public async Task<AddPhoneNumbersResponse> AddPhoneNumbersAsync(AddPhoneNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddPhoneNumbersWithOptionsAsync(request, runtime);
        }

        public AddSkillGroupsToUserResponse AddSkillGroupsToUserWithOptions(AddSkillGroupsToUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["SkillLevelList"] = request.SkillLevelList;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSkillGroupsToUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSkillGroupsToUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddSkillGroupsToUserResponse> AddSkillGroupsToUserWithOptionsAsync(AddSkillGroupsToUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["SkillLevelList"] = request.SkillLevelList;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSkillGroupsToUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSkillGroupsToUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddSkillGroupsToUserResponse AddSkillGroupsToUser(AddSkillGroupsToUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSkillGroupsToUserWithOptions(request, runtime);
        }

        public async Task<AddSkillGroupsToUserResponse> AddSkillGroupsToUserAsync(AddSkillGroupsToUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSkillGroupsToUserWithOptionsAsync(request, runtime);
        }

        public AddUsersToSkillGroupResponse AddUsersToSkillGroupWithOptions(AddUsersToSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["SkillGroupId"] = request.SkillGroupId;
            query["UserSkillLevelList"] = request.UserSkillLevelList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUsersToSkillGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUsersToSkillGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddUsersToSkillGroupResponse> AddUsersToSkillGroupWithOptionsAsync(AddUsersToSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["SkillGroupId"] = request.SkillGroupId;
            query["UserSkillLevelList"] = request.UserSkillLevelList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUsersToSkillGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUsersToSkillGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddUsersToSkillGroupResponse AddUsersToSkillGroup(AddUsersToSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUsersToSkillGroupWithOptions(request, runtime);
        }

        public async Task<AddUsersToSkillGroupResponse> AddUsersToSkillGroupAsync(AddUsersToSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUsersToSkillGroupWithOptionsAsync(request, runtime);
        }

        public AnswerCallResponse AnswerCallWithOptions(AnswerCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AnswerCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnswerCallResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AnswerCallResponse> AnswerCallWithOptionsAsync(AnswerCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AnswerCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnswerCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AnswerCallResponse AnswerCall(AnswerCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AnswerCallWithOptions(request, runtime);
        }

        public async Task<AnswerCallResponse> AnswerCallAsync(AnswerCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AnswerCallWithOptionsAsync(request, runtime);
        }

        public AssignUsersResponse AssignUsersWithOptions(AssignUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["RamIdList"] = request.RamIdList;
            query["RoleId"] = request.RoleId;
            query["SkillLevelList"] = request.SkillLevelList;
            query["WorkMode"] = request.WorkMode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignUsers",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignUsersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AssignUsersResponse> AssignUsersWithOptionsAsync(AssignUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["RamIdList"] = request.RamIdList;
            query["RoleId"] = request.RoleId;
            query["SkillLevelList"] = request.SkillLevelList;
            query["WorkMode"] = request.WorkMode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignUsers",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignUsersResponse>(await CallApiAsync(params_, req, runtime));
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

        public BargeInCallResponse BargeInCallWithOptions(BargeInCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BargedUserId"] = request.BargedUserId;
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["TimeoutSeconds"] = request.TimeoutSeconds;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BargeInCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BargeInCallResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BargeInCallResponse> BargeInCallWithOptionsAsync(BargeInCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BargedUserId"] = request.BargedUserId;
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["TimeoutSeconds"] = request.TimeoutSeconds;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BargeInCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BargeInCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BargeInCallResponse BargeInCall(BargeInCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BargeInCallWithOptions(request, runtime);
        }

        public async Task<BargeInCallResponse> BargeInCallAsync(BargeInCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BargeInCallWithOptionsAsync(request, runtime);
        }

        public BlindTransferResponse BlindTransferWithOptions(BlindTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["TimeoutSeconds"] = request.TimeoutSeconds;
            query["Transferee"] = request.Transferee;
            query["Transferor"] = request.Transferor;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BlindTransfer",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BlindTransferResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BlindTransferResponse> BlindTransferWithOptionsAsync(BlindTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["TimeoutSeconds"] = request.TimeoutSeconds;
            query["Transferee"] = request.Transferee;
            query["Transferor"] = request.Transferor;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BlindTransfer",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BlindTransferResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BlindTransferResponse BlindTransfer(BlindTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BlindTransferWithOptions(request, runtime);
        }

        public async Task<BlindTransferResponse> BlindTransferAsync(BlindTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BlindTransferWithOptionsAsync(request, runtime);
        }

        public CancelAttendedTransferResponse CancelAttendedTransferWithOptions(CancelAttendedTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelAttendedTransfer",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelAttendedTransferResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelAttendedTransferResponse> CancelAttendedTransferWithOptionsAsync(CancelAttendedTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelAttendedTransfer",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelAttendedTransferResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelAttendedTransferResponse CancelAttendedTransfer(CancelAttendedTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelAttendedTransferWithOptions(request, runtime);
        }

        public async Task<CancelAttendedTransferResponse> CancelAttendedTransferAsync(CancelAttendedTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelAttendedTransferWithOptionsAsync(request, runtime);
        }

        public ChangeWorkModeResponse ChangeWorkModeWithOptions(ChangeWorkModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["UserId"] = request.UserId;
            query["WorkMode"] = request.WorkMode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeWorkMode",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeWorkModeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ChangeWorkModeResponse> ChangeWorkModeWithOptionsAsync(ChangeWorkModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["UserId"] = request.UserId;
            query["WorkMode"] = request.WorkMode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeWorkMode",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeWorkModeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ChangeWorkModeResponse ChangeWorkMode(ChangeWorkModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeWorkModeWithOptions(request, runtime);
        }

        public async Task<ChangeWorkModeResponse> ChangeWorkModeAsync(ChangeWorkModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeWorkModeWithOptionsAsync(request, runtime);
        }

        public CoachCallResponse CoachCallWithOptions(CoachCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CoachedUserId"] = request.CoachedUserId;
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["TimeoutSeconds"] = request.TimeoutSeconds;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CoachCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CoachCallResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CoachCallResponse> CoachCallWithOptionsAsync(CoachCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CoachedUserId"] = request.CoachedUserId;
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["TimeoutSeconds"] = request.TimeoutSeconds;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CoachCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CoachCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CoachCallResponse CoachCall(CoachCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CoachCallWithOptions(request, runtime);
        }

        public async Task<CoachCallResponse> CoachCallAsync(CoachCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CoachCallWithOptionsAsync(request, runtime);
        }

        public CompleteAttendedTransferResponse CompleteAttendedTransferWithOptions(CompleteAttendedTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompleteAttendedTransfer",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompleteAttendedTransferResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CompleteAttendedTransferResponse> CompleteAttendedTransferWithOptionsAsync(CompleteAttendedTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompleteAttendedTransfer",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompleteAttendedTransferResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CompleteAttendedTransferResponse CompleteAttendedTransfer(CompleteAttendedTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompleteAttendedTransferWithOptions(request, runtime);
        }

        public async Task<CompleteAttendedTransferResponse> CompleteAttendedTransferAsync(CompleteAttendedTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompleteAttendedTransferWithOptionsAsync(request, runtime);
        }

        public CreateCampaignResponse CreateCampaignWithOptions(CreateCampaignRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCampaignShrinkRequest request = new CreateCampaignShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CaseList))
            {
                request.CaseListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CaseList, "CaseList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallableTime"] = request.CallableTime;
            query["CaseFileKey"] = request.CaseFileKey;
            query["CaseList"] = request.CaseListShrink;
            query["ContactFlowId"] = request.ContactFlowId;
            query["EndTime"] = request.EndTime;
            query["InstanceId"] = request.InstanceId;
            query["MaxAttemptCount"] = request.MaxAttemptCount;
            query["MinAttemptInterval"] = request.MinAttemptInterval;
            query["Name"] = request.Name;
            query["QueueId"] = request.QueueId;
            query["Simulation"] = request.Simulation;
            query["SimulationParameters"] = request.SimulationParameters;
            query["StartTime"] = request.StartTime;
            query["StrategyParameters"] = request.StrategyParameters;
            query["StrategyType"] = request.StrategyType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCampaignResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateCampaignResponse> CreateCampaignWithOptionsAsync(CreateCampaignRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCampaignShrinkRequest request = new CreateCampaignShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CaseList))
            {
                request.CaseListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CaseList, "CaseList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallableTime"] = request.CallableTime;
            query["CaseFileKey"] = request.CaseFileKey;
            query["CaseList"] = request.CaseListShrink;
            query["ContactFlowId"] = request.ContactFlowId;
            query["EndTime"] = request.EndTime;
            query["InstanceId"] = request.InstanceId;
            query["MaxAttemptCount"] = request.MaxAttemptCount;
            query["MinAttemptInterval"] = request.MinAttemptInterval;
            query["Name"] = request.Name;
            query["QueueId"] = request.QueueId;
            query["Simulation"] = request.Simulation;
            query["SimulationParameters"] = request.SimulationParameters;
            query["StartTime"] = request.StartTime;
            query["StrategyParameters"] = request.StrategyParameters;
            query["StrategyType"] = request.StrategyType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCampaignResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateCampaignResponse CreateCampaign(CreateCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCampaignWithOptions(request, runtime);
        }

        public async Task<CreateCampaignResponse> CreateCampaignAsync(CreateCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCampaignWithOptionsAsync(request, runtime);
        }

        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AdminRamIdList"] = request.AdminRamIdList;
            query["Description"] = request.Description;
            query["DomainName"] = request.DomainName;
            query["Name"] = request.Name;
            query["NumberList"] = request.NumberList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AdminRamIdList"] = request.AdminRamIdList;
            query["Description"] = request.Description;
            query["DomainName"] = request.DomainName;
            query["Name"] = request.Name;
            query["NumberList"] = request.NumberList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await CallApiAsync(params_, req, runtime));
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

        public CreateSkillGroupResponse CreateSkillGroupWithOptions(CreateSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["DisplayName"] = request.DisplayName;
            query["InstanceId"] = request.InstanceId;
            query["Name"] = request.Name;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSkillGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSkillGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSkillGroupResponse> CreateSkillGroupWithOptionsAsync(CreateSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["DisplayName"] = request.DisplayName;
            query["InstanceId"] = request.InstanceId;
            query["Name"] = request.Name;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSkillGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSkillGroupResponse>(await CallApiAsync(params_, req, runtime));
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

        public CreateUserResponse CreateUserWithOptions(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DisplayName"] = request.DisplayName;
            query["Email"] = request.Email;
            query["InstanceId"] = request.InstanceId;
            query["LoginName"] = request.LoginName;
            query["Mobile"] = request.Mobile;
            query["ResetPassword"] = request.ResetPassword;
            query["RoleId"] = request.RoleId;
            query["SkillLevelList"] = request.SkillLevelList;
            query["WorkMode"] = request.WorkMode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateUserResponse> CreateUserWithOptionsAsync(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DisplayName"] = request.DisplayName;
            query["Email"] = request.Email;
            query["InstanceId"] = request.InstanceId;
            query["LoginName"] = request.LoginName;
            query["Mobile"] = request.Mobile;
            query["ResetPassword"] = request.ResetPassword;
            query["RoleId"] = request.RoleId;
            query["SkillLevelList"] = request.SkillLevelList;
            query["WorkMode"] = request.WorkMode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(await CallApiAsync(params_, req, runtime));
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

        public DeleteSkillGroupResponse DeleteSkillGroupWithOptions(DeleteSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Force"] = request.Force;
            query["InstanceId"] = request.InstanceId;
            query["SkillGroupId"] = request.SkillGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSkillGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSkillGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteSkillGroupResponse> DeleteSkillGroupWithOptionsAsync(DeleteSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Force"] = request.Force;
            query["InstanceId"] = request.InstanceId;
            query["SkillGroupId"] = request.SkillGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSkillGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSkillGroupResponse>(await CallApiAsync(params_, req, runtime));
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

        public GetCallDetailRecordResponse GetCallDetailRecordWithOptions(GetCallDetailRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ContactId"] = request.ContactId;
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCallDetailRecord",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCallDetailRecordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCallDetailRecordResponse> GetCallDetailRecordWithOptionsAsync(GetCallDetailRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ContactId"] = request.ContactId;
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCallDetailRecord",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCallDetailRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetCallDetailRecordResponse GetCallDetailRecord(GetCallDetailRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCallDetailRecordWithOptions(request, runtime);
        }

        public async Task<GetCallDetailRecordResponse> GetCallDetailRecordAsync(GetCallDetailRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCallDetailRecordWithOptionsAsync(request, runtime);
        }

        public GetCampaignResponse GetCampaignWithOptions(GetCampaignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CampaignId"] = request.CampaignId;
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCampaignResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCampaignResponse> GetCampaignWithOptionsAsync(GetCampaignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CampaignId"] = request.CampaignId;
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCampaignResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetCampaignResponse GetCampaign(GetCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCampaignWithOptions(request, runtime);
        }

        public async Task<GetCampaignResponse> GetCampaignAsync(GetCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCampaignWithOptionsAsync(request, runtime);
        }

        public GetHistoricalCallerReportResponse GetHistoricalCallerReportWithOptions(GetHistoricalCallerReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallingNumber"] = request.CallingNumber;
            query["InstanceId"] = request.InstanceId;
            query["StartTime"] = request.StartTime;
            query["StopTime"] = request.StopTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHistoricalCallerReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHistoricalCallerReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetHistoricalCallerReportResponse> GetHistoricalCallerReportWithOptionsAsync(GetHistoricalCallerReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallingNumber"] = request.CallingNumber;
            query["InstanceId"] = request.InstanceId;
            query["StartTime"] = request.StartTime;
            query["StopTime"] = request.StopTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHistoricalCallerReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHistoricalCallerReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetHistoricalCallerReportResponse GetHistoricalCallerReport(GetHistoricalCallerReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHistoricalCallerReportWithOptions(request, runtime);
        }

        public async Task<GetHistoricalCallerReportResponse> GetHistoricalCallerReportAsync(GetHistoricalCallerReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHistoricalCallerReportWithOptionsAsync(request, runtime);
        }

        public GetHistoricalInstanceReportResponse GetHistoricalInstanceReportWithOptions(GetHistoricalInstanceReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["InstanceId"] = request.InstanceId;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHistoricalInstanceReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHistoricalInstanceReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetHistoricalInstanceReportResponse> GetHistoricalInstanceReportWithOptionsAsync(GetHistoricalInstanceReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["InstanceId"] = request.InstanceId;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHistoricalInstanceReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHistoricalInstanceReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetHistoricalInstanceReportResponse GetHistoricalInstanceReport(GetHistoricalInstanceReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHistoricalInstanceReportWithOptions(request, runtime);
        }

        public async Task<GetHistoricalInstanceReportResponse> GetHistoricalInstanceReportAsync(GetHistoricalInstanceReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHistoricalInstanceReportWithOptionsAsync(request, runtime);
        }

        public GetInstanceResponse GetInstanceWithOptions(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetInstanceResponse> GetInstanceWithOptionsAsync(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(await CallApiAsync(params_, req, runtime));
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

        public GetInstanceTrendingReportResponse GetInstanceTrendingReportWithOptions(GetInstanceTrendingReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["InstanceId"] = request.InstanceId;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceTrendingReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceTrendingReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetInstanceTrendingReportResponse> GetInstanceTrendingReportWithOptionsAsync(GetInstanceTrendingReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["InstanceId"] = request.InstanceId;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceTrendingReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceTrendingReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetInstanceTrendingReportResponse GetInstanceTrendingReport(GetInstanceTrendingReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceTrendingReportWithOptions(request, runtime);
        }

        public async Task<GetInstanceTrendingReportResponse> GetInstanceTrendingReportAsync(GetInstanceTrendingReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceTrendingReportWithOptionsAsync(request, runtime);
        }

        public GetLoginDetailsResponse GetLoginDetailsWithOptions(GetLoginDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLoginDetails",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLoginDetailsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetLoginDetailsResponse> GetLoginDetailsWithOptionsAsync(GetLoginDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLoginDetails",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLoginDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetLoginDetailsResponse GetLoginDetails(GetLoginDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLoginDetailsWithOptions(request, runtime);
        }

        public async Task<GetLoginDetailsResponse> GetLoginDetailsAsync(GetLoginDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLoginDetailsWithOptionsAsync(request, runtime);
        }

        public GetMonoRecordingResponse GetMonoRecordingWithOptions(GetMonoRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ContactId"] = request.ContactId;
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMonoRecording",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMonoRecordingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetMonoRecordingResponse> GetMonoRecordingWithOptionsAsync(GetMonoRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ContactId"] = request.ContactId;
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMonoRecording",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMonoRecordingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetMonoRecordingResponse GetMonoRecording(GetMonoRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMonoRecordingWithOptions(request, runtime);
        }

        public async Task<GetMonoRecordingResponse> GetMonoRecordingAsync(GetMonoRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMonoRecordingWithOptionsAsync(request, runtime);
        }

        public GetMultiChannelRecordingResponse GetMultiChannelRecordingWithOptions(GetMultiChannelRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ContactId"] = request.ContactId;
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMultiChannelRecording",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMultiChannelRecordingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetMultiChannelRecordingResponse> GetMultiChannelRecordingWithOptionsAsync(GetMultiChannelRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ContactId"] = request.ContactId;
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMultiChannelRecording",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMultiChannelRecordingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetMultiChannelRecordingResponse GetMultiChannelRecording(GetMultiChannelRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMultiChannelRecordingWithOptions(request, runtime);
        }

        public async Task<GetMultiChannelRecordingResponse> GetMultiChannelRecordingAsync(GetMultiChannelRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMultiChannelRecordingWithOptionsAsync(request, runtime);
        }

        public GetNumberLocationResponse GetNumberLocationWithOptions(GetNumberLocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["Number"] = request.Number;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNumberLocation",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNumberLocationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetNumberLocationResponse> GetNumberLocationWithOptionsAsync(GetNumberLocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["Number"] = request.Number;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNumberLocation",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNumberLocationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetNumberLocationResponse GetNumberLocation(GetNumberLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNumberLocationWithOptions(request, runtime);
        }

        public async Task<GetNumberLocationResponse> GetNumberLocationAsync(GetNumberLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNumberLocationWithOptionsAsync(request, runtime);
        }

        public GetRealtimeInstanceStatesResponse GetRealtimeInstanceStatesWithOptions(GetRealtimeInstanceStatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRealtimeInstanceStates",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRealtimeInstanceStatesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRealtimeInstanceStatesResponse> GetRealtimeInstanceStatesWithOptionsAsync(GetRealtimeInstanceStatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRealtimeInstanceStates",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRealtimeInstanceStatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRealtimeInstanceStatesResponse GetRealtimeInstanceStates(GetRealtimeInstanceStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRealtimeInstanceStatesWithOptions(request, runtime);
        }

        public async Task<GetRealtimeInstanceStatesResponse> GetRealtimeInstanceStatesAsync(GetRealtimeInstanceStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRealtimeInstanceStatesWithOptionsAsync(request, runtime);
        }

        public GetTurnCredentialsResponse GetTurnCredentialsWithOptions(GetTurnCredentialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTurnCredentials",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTurnCredentialsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetTurnCredentialsResponse> GetTurnCredentialsWithOptionsAsync(GetTurnCredentialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTurnCredentials",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTurnCredentialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetTurnCredentialsResponse GetTurnCredentials(GetTurnCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTurnCredentialsWithOptions(request, runtime);
        }

        public async Task<GetTurnCredentialsResponse> GetTurnCredentialsAsync(GetTurnCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTurnCredentialsWithOptionsAsync(request, runtime);
        }

        public GetTurnServerListResponse GetTurnServerListWithOptions(GetTurnServerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTurnServerList",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTurnServerListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetTurnServerListResponse> GetTurnServerListWithOptionsAsync(GetTurnServerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTurnServerList",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTurnServerListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetTurnServerListResponse GetTurnServerList(GetTurnServerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTurnServerListWithOptions(request, runtime);
        }

        public async Task<GetTurnServerListResponse> GetTurnServerListAsync(GetTurnServerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTurnServerListWithOptionsAsync(request, runtime);
        }

        public GetUserResponse GetUserWithOptions(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Extension"] = request.Extension;
            query["InstanceId"] = request.InstanceId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUserResponse> GetUserWithOptionsAsync(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Extension"] = request.Extension;
            query["InstanceId"] = request.InstanceId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(await CallApiAsync(params_, req, runtime));
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

        public HoldCallResponse HoldCallWithOptions(HoldCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ChannelId"] = request.ChannelId;
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["Music"] = request.Music;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HoldCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HoldCallResponse>(CallApi(params_, req, runtime));
        }

        public async Task<HoldCallResponse> HoldCallWithOptionsAsync(HoldCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ChannelId"] = request.ChannelId;
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["Music"] = request.Music;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HoldCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HoldCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        public HoldCallResponse HoldCall(HoldCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HoldCallWithOptions(request, runtime);
        }

        public async Task<HoldCallResponse> HoldCallAsync(HoldCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HoldCallWithOptionsAsync(request, runtime);
        }

        public InitiateAttendedTransferResponse InitiateAttendedTransferWithOptions(InitiateAttendedTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["TimeoutSeconds"] = request.TimeoutSeconds;
            query["Transferee"] = request.Transferee;
            query["Transferor"] = request.Transferor;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitiateAttendedTransfer",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitiateAttendedTransferResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InitiateAttendedTransferResponse> InitiateAttendedTransferWithOptionsAsync(InitiateAttendedTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["TimeoutSeconds"] = request.TimeoutSeconds;
            query["Transferee"] = request.Transferee;
            query["Transferor"] = request.Transferor;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitiateAttendedTransfer",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitiateAttendedTransferResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InitiateAttendedTransferResponse InitiateAttendedTransfer(InitiateAttendedTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitiateAttendedTransferWithOptions(request, runtime);
        }

        public async Task<InitiateAttendedTransferResponse> InitiateAttendedTransferAsync(InitiateAttendedTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitiateAttendedTransferWithOptionsAsync(request, runtime);
        }

        public InterceptCallResponse InterceptCallWithOptions(InterceptCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["InterceptedUserId"] = request.InterceptedUserId;
            query["JobId"] = request.JobId;
            query["TimeoutSeconds"] = request.TimeoutSeconds;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InterceptCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InterceptCallResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InterceptCallResponse> InterceptCallWithOptionsAsync(InterceptCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["InterceptedUserId"] = request.InterceptedUserId;
            query["JobId"] = request.JobId;
            query["TimeoutSeconds"] = request.TimeoutSeconds;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InterceptCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InterceptCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InterceptCallResponse InterceptCall(InterceptCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InterceptCallWithOptions(request, runtime);
        }

        public async Task<InterceptCallResponse> InterceptCallAsync(InterceptCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InterceptCallWithOptionsAsync(request, runtime);
        }

        public LaunchAuthenticationResponse LaunchAuthenticationWithOptions(LaunchAuthenticationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ContactFlowId"] = request.ContactFlowId;
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LaunchAuthentication",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LaunchAuthenticationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<LaunchAuthenticationResponse> LaunchAuthenticationWithOptionsAsync(LaunchAuthenticationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ContactFlowId"] = request.ContactFlowId;
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LaunchAuthentication",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LaunchAuthenticationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public LaunchAuthenticationResponse LaunchAuthentication(LaunchAuthenticationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LaunchAuthenticationWithOptions(request, runtime);
        }

        public async Task<LaunchAuthenticationResponse> LaunchAuthenticationAsync(LaunchAuthenticationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LaunchAuthenticationWithOptionsAsync(request, runtime);
        }

        public LaunchSurveyResponse LaunchSurveyWithOptions(LaunchSurveyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ContactFlowId"] = request.ContactFlowId;
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LaunchSurvey",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LaunchSurveyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<LaunchSurveyResponse> LaunchSurveyWithOptionsAsync(LaunchSurveyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ContactFlowId"] = request.ContactFlowId;
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LaunchSurvey",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LaunchSurveyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public LaunchSurveyResponse LaunchSurvey(LaunchSurveyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LaunchSurveyWithOptions(request, runtime);
        }

        public async Task<LaunchSurveyResponse> LaunchSurveyAsync(LaunchSurveyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LaunchSurveyWithOptionsAsync(request, runtime);
        }

        public ListAgentStateLogsResponse ListAgentStateLogsWithOptions(ListAgentStateLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AgentId"] = request.AgentId;
            query["EndTime"] = request.EndTime;
            query["InstanceId"] = request.InstanceId;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgentStateLogs",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentStateLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAgentStateLogsResponse> ListAgentStateLogsWithOptionsAsync(ListAgentStateLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AgentId"] = request.AgentId;
            query["EndTime"] = request.EndTime;
            query["InstanceId"] = request.InstanceId;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgentStateLogs",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentStateLogsResponse>(await CallApiAsync(params_, req, runtime));
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

        public ListAttemptsResponse ListAttemptsWithOptions(ListAttemptsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAttempts",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAttemptsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAttemptsResponse> ListAttemptsWithOptionsAsync(ListAttemptsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAttempts",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAttemptsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAttemptsResponse ListAttempts(ListAttemptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAttemptsWithOptions(request, runtime);
        }

        public async Task<ListAttemptsResponse> ListAttemptsAsync(ListAttemptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAttemptsWithOptionsAsync(request, runtime);
        }

        public ListBriefSkillGroupsResponse ListBriefSkillGroupsWithOptions(ListBriefSkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SearchPattern"] = request.SearchPattern;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBriefSkillGroups",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBriefSkillGroupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListBriefSkillGroupsResponse> ListBriefSkillGroupsWithOptionsAsync(ListBriefSkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SearchPattern"] = request.SearchPattern;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBriefSkillGroups",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBriefSkillGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListBriefSkillGroupsResponse ListBriefSkillGroups(ListBriefSkillGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBriefSkillGroupsWithOptions(request, runtime);
        }

        public async Task<ListBriefSkillGroupsResponse> ListBriefSkillGroupsAsync(ListBriefSkillGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBriefSkillGroupsWithOptionsAsync(request, runtime);
        }

        public ListCallDetailRecordsResponse ListCallDetailRecordsWithOptions(ListCallDetailRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AgentId"] = request.AgentId;
            query["CalledNumber"] = request.CalledNumber;
            query["CallingNumber"] = request.CallingNumber;
            query["ContactDisposition"] = request.ContactDisposition;
            query["ContactId"] = request.ContactId;
            query["ContactType"] = request.ContactType;
            query["Criteria"] = request.Criteria;
            query["EarlyMediaStateList"] = request.EarlyMediaStateList;
            query["EndTime"] = request.EndTime;
            query["InstanceId"] = request.InstanceId;
            query["OrderByField"] = request.OrderByField;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SatisfactionDescriptionList"] = request.SatisfactionDescriptionList;
            query["SatisfactionList"] = request.SatisfactionList;
            query["SatisfactionSurveyChannel"] = request.SatisfactionSurveyChannel;
            query["SkillGroupId"] = request.SkillGroupId;
            query["SortOrder"] = request.SortOrder;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCallDetailRecords",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCallDetailRecordsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListCallDetailRecordsResponse> ListCallDetailRecordsWithOptionsAsync(ListCallDetailRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AgentId"] = request.AgentId;
            query["CalledNumber"] = request.CalledNumber;
            query["CallingNumber"] = request.CallingNumber;
            query["ContactDisposition"] = request.ContactDisposition;
            query["ContactId"] = request.ContactId;
            query["ContactType"] = request.ContactType;
            query["Criteria"] = request.Criteria;
            query["EarlyMediaStateList"] = request.EarlyMediaStateList;
            query["EndTime"] = request.EndTime;
            query["InstanceId"] = request.InstanceId;
            query["OrderByField"] = request.OrderByField;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SatisfactionDescriptionList"] = request.SatisfactionDescriptionList;
            query["SatisfactionList"] = request.SatisfactionList;
            query["SatisfactionSurveyChannel"] = request.SatisfactionSurveyChannel;
            query["SkillGroupId"] = request.SkillGroupId;
            query["SortOrder"] = request.SortOrder;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCallDetailRecords",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCallDetailRecordsResponse>(await CallApiAsync(params_, req, runtime));
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

        public ListCampaignTrendingReportResponse ListCampaignTrendingReportWithOptions(ListCampaignTrendingReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCampaignTrendingReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCampaignTrendingReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListCampaignTrendingReportResponse> ListCampaignTrendingReportWithOptionsAsync(ListCampaignTrendingReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCampaignTrendingReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCampaignTrendingReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListCampaignTrendingReportResponse ListCampaignTrendingReport(ListCampaignTrendingReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCampaignTrendingReportWithOptions(request, runtime);
        }

        public async Task<ListCampaignTrendingReportResponse> ListCampaignTrendingReportAsync(ListCampaignTrendingReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCampaignTrendingReportWithOptionsAsync(request, runtime);
        }

        public ListCampaignsResponse ListCampaignsWithOptions(ListCampaignsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ActualStartTimeFrom"] = request.ActualStartTimeFrom;
            query["ActualStartTimeTo"] = request.ActualStartTimeTo;
            query["InstanceId"] = request.InstanceId;
            query["Name"] = request.Name;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["PlanedStartTimeFrom"] = request.PlanedStartTimeFrom;
            query["PlanedStartTimeTo"] = request.PlanedStartTimeTo;
            query["QueueId"] = request.QueueId;
            query["State"] = request.State;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCampaigns",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCampaignsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListCampaignsResponse> ListCampaignsWithOptionsAsync(ListCampaignsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ActualStartTimeFrom"] = request.ActualStartTimeFrom;
            query["ActualStartTimeTo"] = request.ActualStartTimeTo;
            query["InstanceId"] = request.InstanceId;
            query["Name"] = request.Name;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["PlanedStartTimeFrom"] = request.PlanedStartTimeFrom;
            query["PlanedStartTimeTo"] = request.PlanedStartTimeTo;
            query["QueueId"] = request.QueueId;
            query["State"] = request.State;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCampaigns",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCampaignsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListCampaignsResponse ListCampaigns(ListCampaignsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCampaignsWithOptions(request, runtime);
        }

        public async Task<ListCampaignsResponse> ListCampaignsAsync(ListCampaignsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCampaignsWithOptionsAsync(request, runtime);
        }

        public ListCasesResponse ListCasesWithOptions(ListCasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CampaignId"] = request.CampaignId;
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["PhoneNumber"] = request.PhoneNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCases",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCasesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListCasesResponse> ListCasesWithOptionsAsync(ListCasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CampaignId"] = request.CampaignId;
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["PhoneNumber"] = request.PhoneNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCases",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListCasesResponse ListCases(ListCasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCasesWithOptions(request, runtime);
        }

        public async Task<ListCasesResponse> ListCasesAsync(ListCasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCasesWithOptionsAsync(request, runtime);
        }

        public ListConfigItemsResponse ListConfigItemsWithOptions(ListConfigItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["ObjectId"] = request.ObjectId;
            query["ObjectType"] = request.ObjectType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConfigItems",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConfigItemsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListConfigItemsResponse> ListConfigItemsWithOptionsAsync(ListConfigItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["ObjectId"] = request.ObjectId;
            query["ObjectType"] = request.ObjectType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConfigItems",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConfigItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListConfigItemsResponse ListConfigItems(ListConfigItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConfigItemsWithOptions(request, runtime);
        }

        public async Task<ListConfigItemsResponse> ListConfigItemsAsync(ListConfigItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConfigItemsWithOptionsAsync(request, runtime);
        }

        public ListContactFlowsResponse ListContactFlowsWithOptions(ListContactFlowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContactFlows",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContactFlowsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListContactFlowsResponse> ListContactFlowsWithOptionsAsync(ListContactFlowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContactFlows",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContactFlowsResponse>(await CallApiAsync(params_, req, runtime));
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

        public ListDevicesResponse ListDevicesWithOptions(ListDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDevices",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDevicesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDevicesResponse> ListDevicesWithOptionsAsync(ListDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDevices",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDevicesResponse ListDevices(ListDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDevicesWithOptions(request, runtime);
        }

        public async Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDevicesWithOptionsAsync(request, runtime);
        }

        public ListHistoricalAgentReportResponse ListHistoricalAgentReportWithOptions(ListHistoricalAgentReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["StartTime"] = request.StartTime;
            query["StopTime"] = request.StopTime;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentIdList))
            {
                body["AgentIdList"] = request.AgentIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHistoricalAgentReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHistoricalAgentReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListHistoricalAgentReportResponse> ListHistoricalAgentReportWithOptionsAsync(ListHistoricalAgentReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["StartTime"] = request.StartTime;
            query["StopTime"] = request.StopTime;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentIdList))
            {
                body["AgentIdList"] = request.AgentIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHistoricalAgentReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHistoricalAgentReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListHistoricalAgentReportResponse ListHistoricalAgentReport(ListHistoricalAgentReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHistoricalAgentReportWithOptions(request, runtime);
        }

        public async Task<ListHistoricalAgentReportResponse> ListHistoricalAgentReportAsync(ListHistoricalAgentReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHistoricalAgentReportWithOptionsAsync(request, runtime);
        }

        public ListHistoricalSkillGroupReportResponse ListHistoricalSkillGroupReportWithOptions(ListHistoricalSkillGroupReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["StartTime"] = request.StartTime;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupIdList))
            {
                body["SkillGroupIdList"] = request.SkillGroupIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHistoricalSkillGroupReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHistoricalSkillGroupReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListHistoricalSkillGroupReportResponse> ListHistoricalSkillGroupReportWithOptionsAsync(ListHistoricalSkillGroupReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["StartTime"] = request.StartTime;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupIdList))
            {
                body["SkillGroupIdList"] = request.SkillGroupIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHistoricalSkillGroupReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHistoricalSkillGroupReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListHistoricalSkillGroupReportResponse ListHistoricalSkillGroupReport(ListHistoricalSkillGroupReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHistoricalSkillGroupReportWithOptions(request, runtime);
        }

        public async Task<ListHistoricalSkillGroupReportResponse> ListHistoricalSkillGroupReportAsync(ListHistoricalSkillGroupReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHistoricalSkillGroupReportWithOptionsAsync(request, runtime);
        }

        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancesWithOptions(request, runtime);
        }

        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancesWithOptionsAsync(request, runtime);
        }

        public ListInstancesOfUserResponse ListInstancesOfUserWithOptions(ListInstancesOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstancesOfUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesOfUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListInstancesOfUserResponse> ListInstancesOfUserWithOptionsAsync(ListInstancesOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstancesOfUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesOfUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListInstancesOfUserResponse ListInstancesOfUser(ListInstancesOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancesOfUserWithOptions(request, runtime);
        }

        public async Task<ListInstancesOfUserResponse> ListInstancesOfUserAsync(ListInstancesOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancesOfUserWithOptionsAsync(request, runtime);
        }

        public ListIntervalAgentReportResponse ListIntervalAgentReportWithOptions(ListIntervalAgentReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AgentId"] = request.AgentId;
            query["EndTime"] = request.EndTime;
            query["InstanceId"] = request.InstanceId;
            query["Interval"] = request.Interval;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntervalAgentReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntervalAgentReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListIntervalAgentReportResponse> ListIntervalAgentReportWithOptionsAsync(ListIntervalAgentReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AgentId"] = request.AgentId;
            query["EndTime"] = request.EndTime;
            query["InstanceId"] = request.InstanceId;
            query["Interval"] = request.Interval;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntervalAgentReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntervalAgentReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListIntervalAgentReportResponse ListIntervalAgentReport(ListIntervalAgentReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIntervalAgentReportWithOptions(request, runtime);
        }

        public async Task<ListIntervalAgentReportResponse> ListIntervalAgentReportAsync(ListIntervalAgentReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIntervalAgentReportWithOptionsAsync(request, runtime);
        }

        public ListIntervalInstanceReportResponse ListIntervalInstanceReportWithOptions(ListIntervalInstanceReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["InstanceId"] = request.InstanceId;
            query["Interval"] = request.Interval;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntervalInstanceReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntervalInstanceReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListIntervalInstanceReportResponse> ListIntervalInstanceReportWithOptionsAsync(ListIntervalInstanceReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["InstanceId"] = request.InstanceId;
            query["Interval"] = request.Interval;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntervalInstanceReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntervalInstanceReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListIntervalInstanceReportResponse ListIntervalInstanceReport(ListIntervalInstanceReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIntervalInstanceReportWithOptions(request, runtime);
        }

        public async Task<ListIntervalInstanceReportResponse> ListIntervalInstanceReportAsync(ListIntervalInstanceReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIntervalInstanceReportWithOptionsAsync(request, runtime);
        }

        public ListIntervalSkillGroupReportResponse ListIntervalSkillGroupReportWithOptions(ListIntervalSkillGroupReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["InstanceId"] = request.InstanceId;
            query["Interval"] = request.Interval;
            query["SkillGroupId"] = request.SkillGroupId;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntervalSkillGroupReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntervalSkillGroupReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListIntervalSkillGroupReportResponse> ListIntervalSkillGroupReportWithOptionsAsync(ListIntervalSkillGroupReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["InstanceId"] = request.InstanceId;
            query["Interval"] = request.Interval;
            query["SkillGroupId"] = request.SkillGroupId;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntervalSkillGroupReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntervalSkillGroupReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListIntervalSkillGroupReportResponse ListIntervalSkillGroupReport(ListIntervalSkillGroupReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIntervalSkillGroupReportWithOptions(request, runtime);
        }

        public async Task<ListIntervalSkillGroupReportResponse> ListIntervalSkillGroupReportAsync(ListIntervalSkillGroupReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIntervalSkillGroupReportWithOptionsAsync(request, runtime);
        }

        public ListIvrTrackingDetailsResponse ListIvrTrackingDetailsWithOptions(ListIvrTrackingDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ContactId"] = request.ContactId;
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIvrTrackingDetails",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIvrTrackingDetailsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListIvrTrackingDetailsResponse> ListIvrTrackingDetailsWithOptionsAsync(ListIvrTrackingDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ContactId"] = request.ContactId;
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIvrTrackingDetails",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIvrTrackingDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListIvrTrackingDetailsResponse ListIvrTrackingDetails(ListIvrTrackingDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIvrTrackingDetailsWithOptions(request, runtime);
        }

        public async Task<ListIvrTrackingDetailsResponse> ListIvrTrackingDetailsAsync(ListIvrTrackingDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIvrTrackingDetailsWithOptionsAsync(request, runtime);
        }

        public ListOutboundNumbersOfUserResponse ListOutboundNumbersOfUserWithOptions(ListOutboundNumbersOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SkillGroupIdList"] = request.SkillGroupIdList;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOutboundNumbersOfUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOutboundNumbersOfUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListOutboundNumbersOfUserResponse> ListOutboundNumbersOfUserWithOptionsAsync(ListOutboundNumbersOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SkillGroupIdList"] = request.SkillGroupIdList;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOutboundNumbersOfUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOutboundNumbersOfUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListOutboundNumbersOfUserResponse ListOutboundNumbersOfUser(ListOutboundNumbersOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOutboundNumbersOfUserWithOptions(request, runtime);
        }

        public async Task<ListOutboundNumbersOfUserResponse> ListOutboundNumbersOfUserAsync(ListOutboundNumbersOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOutboundNumbersOfUserWithOptionsAsync(request, runtime);
        }

        public ListPersonalNumbersOfUserResponse ListPersonalNumbersOfUserWithOptions(ListPersonalNumbersOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["IsMember"] = request.IsMember;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SearchPattern"] = request.SearchPattern;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPersonalNumbersOfUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPersonalNumbersOfUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPersonalNumbersOfUserResponse> ListPersonalNumbersOfUserWithOptionsAsync(ListPersonalNumbersOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["IsMember"] = request.IsMember;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SearchPattern"] = request.SearchPattern;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPersonalNumbersOfUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPersonalNumbersOfUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListPersonalNumbersOfUserResponse ListPersonalNumbersOfUser(ListPersonalNumbersOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPersonalNumbersOfUserWithOptions(request, runtime);
        }

        public async Task<ListPersonalNumbersOfUserResponse> ListPersonalNumbersOfUserAsync(ListPersonalNumbersOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPersonalNumbersOfUserWithOptionsAsync(request, runtime);
        }

        public ListPhoneNumbersResponse ListPhoneNumbersWithOptions(ListPhoneNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Active"] = request.Active;
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SearchPattern"] = request.SearchPattern;
            query["Usage"] = request.Usage;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPhoneNumbers",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPhoneNumbersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPhoneNumbersResponse> ListPhoneNumbersWithOptionsAsync(ListPhoneNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Active"] = request.Active;
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SearchPattern"] = request.SearchPattern;
            query["Usage"] = request.Usage;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPhoneNumbers",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPhoneNumbersResponse>(await CallApiAsync(params_, req, runtime));
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

        public ListPhoneNumbersOfSkillGroupResponse ListPhoneNumbersOfSkillGroupWithOptions(ListPhoneNumbersOfSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Active"] = request.Active;
            query["InstanceId"] = request.InstanceId;
            query["IsMember"] = request.IsMember;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SearchPattern"] = request.SearchPattern;
            query["SkillGroupId"] = request.SkillGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPhoneNumbersOfSkillGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPhoneNumbersOfSkillGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPhoneNumbersOfSkillGroupResponse> ListPhoneNumbersOfSkillGroupWithOptionsAsync(ListPhoneNumbersOfSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Active"] = request.Active;
            query["InstanceId"] = request.InstanceId;
            query["IsMember"] = request.IsMember;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SearchPattern"] = request.SearchPattern;
            query["SkillGroupId"] = request.SkillGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPhoneNumbersOfSkillGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPhoneNumbersOfSkillGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListPhoneNumbersOfSkillGroupResponse ListPhoneNumbersOfSkillGroup(ListPhoneNumbersOfSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPhoneNumbersOfSkillGroupWithOptions(request, runtime);
        }

        public async Task<ListPhoneNumbersOfSkillGroupResponse> ListPhoneNumbersOfSkillGroupAsync(ListPhoneNumbersOfSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPhoneNumbersOfSkillGroupWithOptionsAsync(request, runtime);
        }

        public ListPrivilegesOfUserResponse ListPrivilegesOfUserWithOptions(ListPrivilegesOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrivilegesOfUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrivilegesOfUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPrivilegesOfUserResponse> ListPrivilegesOfUserWithOptionsAsync(ListPrivilegesOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrivilegesOfUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrivilegesOfUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListPrivilegesOfUserResponse ListPrivilegesOfUser(ListPrivilegesOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPrivilegesOfUserWithOptions(request, runtime);
        }

        public async Task<ListPrivilegesOfUserResponse> ListPrivilegesOfUserAsync(ListPrivilegesOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPrivilegesOfUserWithOptionsAsync(request, runtime);
        }

        public ListRamUsersResponse ListRamUsersWithOptions(ListRamUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SearchPattern"] = request.SearchPattern;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRamUsers",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRamUsersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRamUsersResponse> ListRamUsersWithOptionsAsync(ListRamUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SearchPattern"] = request.SearchPattern;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRamUsers",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRamUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRamUsersResponse ListRamUsers(ListRamUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRamUsersWithOptions(request, runtime);
        }

        public async Task<ListRamUsersResponse> ListRamUsersAsync(ListRamUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRamUsersWithOptionsAsync(request, runtime);
        }

        public ListRealtimeAgentStatesResponse ListRealtimeAgentStatesWithOptions(ListRealtimeAgentStatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AgentName"] = request.AgentName;
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SkillGroupId"] = request.SkillGroupId;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentIdList))
            {
                body["AgentIdList"] = request.AgentIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StateList))
            {
                body["StateList"] = request.StateList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRealtimeAgentStates",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRealtimeAgentStatesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRealtimeAgentStatesResponse> ListRealtimeAgentStatesWithOptionsAsync(ListRealtimeAgentStatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AgentName"] = request.AgentName;
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SkillGroupId"] = request.SkillGroupId;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentIdList))
            {
                body["AgentIdList"] = request.AgentIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StateList))
            {
                body["StateList"] = request.StateList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRealtimeAgentStates",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRealtimeAgentStatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRealtimeAgentStatesResponse ListRealtimeAgentStates(ListRealtimeAgentStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRealtimeAgentStatesWithOptions(request, runtime);
        }

        public async Task<ListRealtimeAgentStatesResponse> ListRealtimeAgentStatesAsync(ListRealtimeAgentStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRealtimeAgentStatesWithOptionsAsync(request, runtime);
        }

        public ListRealtimeSkillGroupStatesResponse ListRealtimeSkillGroupStatesWithOptions(ListRealtimeSkillGroupStatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupIdList))
            {
                body["SkillGroupIdList"] = request.SkillGroupIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRealtimeSkillGroupStates",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRealtimeSkillGroupStatesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRealtimeSkillGroupStatesResponse> ListRealtimeSkillGroupStatesWithOptionsAsync(ListRealtimeSkillGroupStatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupIdList))
            {
                body["SkillGroupIdList"] = request.SkillGroupIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRealtimeSkillGroupStates",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRealtimeSkillGroupStatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRealtimeSkillGroupStatesResponse ListRealtimeSkillGroupStates(ListRealtimeSkillGroupStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRealtimeSkillGroupStatesWithOptions(request, runtime);
        }

        public async Task<ListRealtimeSkillGroupStatesResponse> ListRealtimeSkillGroupStatesAsync(ListRealtimeSkillGroupStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRealtimeSkillGroupStatesWithOptionsAsync(request, runtime);
        }

        public ListRecentCallDetailRecordsResponse ListRecentCallDetailRecordsWithOptions(ListRecentCallDetailRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Criteria"] = request.Criteria;
            query["EndTime"] = request.EndTime;
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRecentCallDetailRecords",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecentCallDetailRecordsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRecentCallDetailRecordsResponse> ListRecentCallDetailRecordsWithOptionsAsync(ListRecentCallDetailRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Criteria"] = request.Criteria;
            query["EndTime"] = request.EndTime;
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRecentCallDetailRecords",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecentCallDetailRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRecentCallDetailRecordsResponse ListRecentCallDetailRecords(ListRecentCallDetailRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRecentCallDetailRecordsWithOptions(request, runtime);
        }

        public async Task<ListRecentCallDetailRecordsResponse> ListRecentCallDetailRecordsAsync(ListRecentCallDetailRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRecentCallDetailRecordsWithOptionsAsync(request, runtime);
        }

        public ListRolesResponse ListRolesWithOptions(ListRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoles",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRolesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRolesResponse> ListRolesWithOptionsAsync(ListRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoles",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRolesResponse>(await CallApiAsync(params_, req, runtime));
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

        public ListSipCallRecordsResponse ListSipCallRecordsWithOptions(ListSipCallRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ContactIdList"] = request.ContactIdList;
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSipCallRecords",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSipCallRecordsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSipCallRecordsResponse> ListSipCallRecordsWithOptionsAsync(ListSipCallRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ContactIdList"] = request.ContactIdList;
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSipCallRecords",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSipCallRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSipCallRecordsResponse ListSipCallRecords(ListSipCallRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSipCallRecordsWithOptions(request, runtime);
        }

        public async Task<ListSipCallRecordsResponse> ListSipCallRecordsAsync(ListSipCallRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSipCallRecordsWithOptionsAsync(request, runtime);
        }

        public ListSipTracesResponse ListSipTracesWithOptions(ListSipTracesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallId"] = request.CallId;
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSipTraces",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSipTracesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSipTracesResponse> ListSipTracesWithOptionsAsync(ListSipTracesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallId"] = request.CallId;
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSipTraces",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSipTracesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSipTracesResponse ListSipTraces(ListSipTracesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSipTracesWithOptions(request, runtime);
        }

        public async Task<ListSipTracesResponse> ListSipTracesAsync(ListSipTracesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSipTracesWithOptionsAsync(request, runtime);
        }

        public ListSkillGroupsResponse ListSkillGroupsWithOptions(ListSkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SearchPattern"] = request.SearchPattern;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSkillGroups",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSkillGroupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSkillGroupsResponse> ListSkillGroupsWithOptionsAsync(ListSkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SearchPattern"] = request.SearchPattern;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSkillGroups",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSkillGroupsResponse>(await CallApiAsync(params_, req, runtime));
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

        public ListSkillLevelsOfUserResponse ListSkillLevelsOfUserWithOptions(ListSkillLevelsOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["IsMember"] = request.IsMember;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SearchPattern"] = request.SearchPattern;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSkillLevelsOfUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSkillLevelsOfUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSkillLevelsOfUserResponse> ListSkillLevelsOfUserWithOptionsAsync(ListSkillLevelsOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["IsMember"] = request.IsMember;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SearchPattern"] = request.SearchPattern;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSkillLevelsOfUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSkillLevelsOfUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSkillLevelsOfUserResponse ListSkillLevelsOfUser(ListSkillLevelsOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSkillLevelsOfUserWithOptions(request, runtime);
        }

        public async Task<ListSkillLevelsOfUserResponse> ListSkillLevelsOfUserAsync(ListSkillLevelsOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSkillLevelsOfUserWithOptionsAsync(request, runtime);
        }

        public ListUnassignedNumbersResponse ListUnassignedNumbersWithOptions(ListUnassignedNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SearchPattern"] = request.SearchPattern;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUnassignedNumbers",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUnassignedNumbersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListUnassignedNumbersResponse> ListUnassignedNumbersWithOptionsAsync(ListUnassignedNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SearchPattern"] = request.SearchPattern;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUnassignedNumbers",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUnassignedNumbersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListUnassignedNumbersResponse ListUnassignedNumbers(ListUnassignedNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUnassignedNumbersWithOptions(request, runtime);
        }

        public async Task<ListUnassignedNumbersResponse> ListUnassignedNumbersAsync(ListUnassignedNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUnassignedNumbersWithOptionsAsync(request, runtime);
        }

        public ListUserLevelsOfSkillGroupResponse ListUserLevelsOfSkillGroupWithOptions(ListUserLevelsOfSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["IsMember"] = request.IsMember;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SearchPattern"] = request.SearchPattern;
            query["SkillGroupId"] = request.SkillGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserLevelsOfSkillGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserLevelsOfSkillGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListUserLevelsOfSkillGroupResponse> ListUserLevelsOfSkillGroupWithOptionsAsync(ListUserLevelsOfSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["IsMember"] = request.IsMember;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SearchPattern"] = request.SearchPattern;
            query["SkillGroupId"] = request.SkillGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserLevelsOfSkillGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserLevelsOfSkillGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListUserLevelsOfSkillGroupResponse ListUserLevelsOfSkillGroup(ListUserLevelsOfSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserLevelsOfSkillGroupWithOptions(request, runtime);
        }

        public async Task<ListUserLevelsOfSkillGroupResponse> ListUserLevelsOfSkillGroupAsync(ListUserLevelsOfSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserLevelsOfSkillGroupWithOptionsAsync(request, runtime);
        }

        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SearchPattern"] = request.SearchPattern;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SearchPattern"] = request.SearchPattern;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(await CallApiAsync(params_, req, runtime));
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

        public MakeCallResponse MakeCallWithOptions(MakeCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Callee"] = request.Callee;
            query["Caller"] = request.Caller;
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["MaskedCallee"] = request.MaskedCallee;
            query["Tags"] = request.Tags;
            query["TimeoutSeconds"] = request.TimeoutSeconds;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MakeCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MakeCallResponse>(CallApi(params_, req, runtime));
        }

        public async Task<MakeCallResponse> MakeCallWithOptionsAsync(MakeCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Callee"] = request.Callee;
            query["Caller"] = request.Caller;
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["MaskedCallee"] = request.MaskedCallee;
            query["Tags"] = request.Tags;
            query["TimeoutSeconds"] = request.TimeoutSeconds;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MakeCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MakeCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        public MakeCallResponse MakeCall(MakeCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MakeCallWithOptions(request, runtime);
        }

        public async Task<MakeCallResponse> MakeCallAsync(MakeCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MakeCallWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceResponse ModifyInstanceWithOptions(ModifyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstance",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyInstanceResponse> ModifyInstanceWithOptionsAsync(ModifyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstance",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyInstanceResponse ModifyInstance(ModifyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceResponse> ModifyInstanceAsync(ModifyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceWithOptionsAsync(request, runtime);
        }

        public ModifyPhoneNumberResponse ModifyPhoneNumberWithOptions(ModifyPhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ContactFlowId"] = request.ContactFlowId;
            query["InstanceId"] = request.InstanceId;
            query["Number"] = request.Number;
            query["Usage"] = request.Usage;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPhoneNumber",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPhoneNumberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyPhoneNumberResponse> ModifyPhoneNumberWithOptionsAsync(ModifyPhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ContactFlowId"] = request.ContactFlowId;
            query["InstanceId"] = request.InstanceId;
            query["Number"] = request.Number;
            query["Usage"] = request.Usage;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPhoneNumber",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPhoneNumberResponse>(await CallApiAsync(params_, req, runtime));
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

        public ModifySkillGroupResponse ModifySkillGroupWithOptions(ModifySkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["DisplayName"] = request.DisplayName;
            query["InstanceId"] = request.InstanceId;
            query["SkillGroupId"] = request.SkillGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySkillGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySkillGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifySkillGroupResponse> ModifySkillGroupWithOptionsAsync(ModifySkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["DisplayName"] = request.DisplayName;
            query["InstanceId"] = request.InstanceId;
            query["SkillGroupId"] = request.SkillGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySkillGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySkillGroupResponse>(await CallApiAsync(params_, req, runtime));
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

        public ModifySkillLevelsOfUserResponse ModifySkillLevelsOfUserWithOptions(ModifySkillLevelsOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["SkillLevelList"] = request.SkillLevelList;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySkillLevelsOfUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySkillLevelsOfUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifySkillLevelsOfUserResponse> ModifySkillLevelsOfUserWithOptionsAsync(ModifySkillLevelsOfUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["SkillLevelList"] = request.SkillLevelList;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySkillLevelsOfUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySkillLevelsOfUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifySkillLevelsOfUserResponse ModifySkillLevelsOfUser(ModifySkillLevelsOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySkillLevelsOfUserWithOptions(request, runtime);
        }

        public async Task<ModifySkillLevelsOfUserResponse> ModifySkillLevelsOfUserAsync(ModifySkillLevelsOfUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySkillLevelsOfUserWithOptionsAsync(request, runtime);
        }

        public ModifyUserResponse ModifyUserWithOptions(ModifyUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["Mobile"] = request.Mobile;
            query["RoleId"] = request.RoleId;
            query["UserId"] = request.UserId;
            query["WorkMode"] = request.WorkMode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyUserResponse> ModifyUserWithOptionsAsync(ModifyUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["Mobile"] = request.Mobile;
            query["RoleId"] = request.RoleId;
            query["UserId"] = request.UserId;
            query["WorkMode"] = request.WorkMode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyUserResponse>(await CallApiAsync(params_, req, runtime));
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

        public ModifyUserLevelsOfSkillGroupResponse ModifyUserLevelsOfSkillGroupWithOptions(ModifyUserLevelsOfSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["SkillGroupId"] = request.SkillGroupId;
            query["UserLevelList"] = request.UserLevelList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyUserLevelsOfSkillGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyUserLevelsOfSkillGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyUserLevelsOfSkillGroupResponse> ModifyUserLevelsOfSkillGroupWithOptionsAsync(ModifyUserLevelsOfSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["SkillGroupId"] = request.SkillGroupId;
            query["UserLevelList"] = request.UserLevelList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyUserLevelsOfSkillGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyUserLevelsOfSkillGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyUserLevelsOfSkillGroupResponse ModifyUserLevelsOfSkillGroup(ModifyUserLevelsOfSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyUserLevelsOfSkillGroupWithOptions(request, runtime);
        }

        public async Task<ModifyUserLevelsOfSkillGroupResponse> ModifyUserLevelsOfSkillGroupAsync(ModifyUserLevelsOfSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyUserLevelsOfSkillGroupWithOptionsAsync(request, runtime);
        }

        public MonitorCallResponse MonitorCallWithOptions(MonitorCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["MonitoredUserId"] = request.MonitoredUserId;
            query["TimeoutSeconds"] = request.TimeoutSeconds;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MonitorCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MonitorCallResponse>(CallApi(params_, req, runtime));
        }

        public async Task<MonitorCallResponse> MonitorCallWithOptionsAsync(MonitorCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["MonitoredUserId"] = request.MonitoredUserId;
            query["TimeoutSeconds"] = request.TimeoutSeconds;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MonitorCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MonitorCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        public MonitorCallResponse MonitorCall(MonitorCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MonitorCallWithOptions(request, runtime);
        }

        public async Task<MonitorCallResponse> MonitorCallAsync(MonitorCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MonitorCallWithOptionsAsync(request, runtime);
        }

        public MuteCallResponse MuteCallWithOptions(MuteCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ChannelId"] = request.ChannelId;
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MuteCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MuteCallResponse>(CallApi(params_, req, runtime));
        }

        public async Task<MuteCallResponse> MuteCallWithOptionsAsync(MuteCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ChannelId"] = request.ChannelId;
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MuteCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MuteCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        public MuteCallResponse MuteCall(MuteCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MuteCallWithOptions(request, runtime);
        }

        public async Task<MuteCallResponse> MuteCallAsync(MuteCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MuteCallWithOptionsAsync(request, runtime);
        }

        public PauseCampaignResponse PauseCampaignWithOptions(PauseCampaignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CampaignId"] = request.CampaignId;
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PauseCampaignResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PauseCampaignResponse> PauseCampaignWithOptionsAsync(PauseCampaignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CampaignId"] = request.CampaignId;
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PauseCampaignResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PauseCampaignResponse PauseCampaign(PauseCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PauseCampaignWithOptions(request, runtime);
        }

        public async Task<PauseCampaignResponse> PauseCampaignAsync(PauseCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PauseCampaignWithOptionsAsync(request, runtime);
        }

        public PickOutboundNumbersResponse PickOutboundNumbersWithOptions(PickOutboundNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CalledNumber"] = request.CalledNumber;
            query["Count"] = request.Count;
            query["InstanceId"] = request.InstanceId;
            query["SkillGroupIdList"] = request.SkillGroupIdList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PickOutboundNumbers",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PickOutboundNumbersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PickOutboundNumbersResponse> PickOutboundNumbersWithOptionsAsync(PickOutboundNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CalledNumber"] = request.CalledNumber;
            query["Count"] = request.Count;
            query["InstanceId"] = request.InstanceId;
            query["SkillGroupIdList"] = request.SkillGroupIdList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PickOutboundNumbers",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PickOutboundNumbersResponse>(await CallApiAsync(params_, req, runtime));
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

        public PollUserStatusResponse PollUserStatusWithOptions(PollUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PollUserStatus",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PollUserStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PollUserStatusResponse> PollUserStatusWithOptionsAsync(PollUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PollUserStatus",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PollUserStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PollUserStatusResponse PollUserStatus(PollUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PollUserStatusWithOptions(request, runtime);
        }

        public async Task<PollUserStatusResponse> PollUserStatusAsync(PollUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PollUserStatusWithOptionsAsync(request, runtime);
        }

        public ReadyForServiceResponse ReadyForServiceWithOptions(ReadyForServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["OutboundScenario"] = request.OutboundScenario;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadyForService",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadyForServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReadyForServiceResponse> ReadyForServiceWithOptionsAsync(ReadyForServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["OutboundScenario"] = request.OutboundScenario;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadyForService",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadyForServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReadyForServiceResponse ReadyForService(ReadyForServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReadyForServiceWithOptions(request, runtime);
        }

        public async Task<ReadyForServiceResponse> ReadyForServiceAsync(ReadyForServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReadyForServiceWithOptionsAsync(request, runtime);
        }

        public RegisterDeviceResponse RegisterDeviceWithOptions(RegisterDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["Password"] = request.Password;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterDevice",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RegisterDeviceResponse> RegisterDeviceWithOptionsAsync(RegisterDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["Password"] = request.Password;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterDevice",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RegisterDeviceResponse RegisterDevice(RegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterDeviceWithOptions(request, runtime);
        }

        public async Task<RegisterDeviceResponse> RegisterDeviceAsync(RegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterDeviceWithOptionsAsync(request, runtime);
        }

        public ReleaseCallResponse ReleaseCallWithOptions(ReleaseCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ChannelId"] = request.ChannelId;
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseCallResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReleaseCallResponse> ReleaseCallWithOptionsAsync(ReleaseCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ChannelId"] = request.ChannelId;
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReleaseCallResponse ReleaseCall(ReleaseCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseCallWithOptions(request, runtime);
        }

        public async Task<ReleaseCallResponse> ReleaseCallAsync(ReleaseCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseCallWithOptionsAsync(request, runtime);
        }

        public RemovePersonalNumbersFromUserResponse RemovePersonalNumbersFromUserWithOptions(RemovePersonalNumbersFromUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["NumberList"] = request.NumberList;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemovePersonalNumbersFromUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemovePersonalNumbersFromUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemovePersonalNumbersFromUserResponse> RemovePersonalNumbersFromUserWithOptionsAsync(RemovePersonalNumbersFromUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["NumberList"] = request.NumberList;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemovePersonalNumbersFromUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemovePersonalNumbersFromUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemovePersonalNumbersFromUserResponse RemovePersonalNumbersFromUser(RemovePersonalNumbersFromUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemovePersonalNumbersFromUserWithOptions(request, runtime);
        }

        public async Task<RemovePersonalNumbersFromUserResponse> RemovePersonalNumbersFromUserAsync(RemovePersonalNumbersFromUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemovePersonalNumbersFromUserWithOptionsAsync(request, runtime);
        }

        public RemovePhoneNumberFromSkillGroupsResponse RemovePhoneNumberFromSkillGroupsWithOptions(RemovePhoneNumberFromSkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["Number"] = request.Number;
            query["SkillGroupIdList"] = request.SkillGroupIdList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemovePhoneNumberFromSkillGroups",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemovePhoneNumberFromSkillGroupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemovePhoneNumberFromSkillGroupsResponse> RemovePhoneNumberFromSkillGroupsWithOptionsAsync(RemovePhoneNumberFromSkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["Number"] = request.Number;
            query["SkillGroupIdList"] = request.SkillGroupIdList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemovePhoneNumberFromSkillGroups",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemovePhoneNumberFromSkillGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemovePhoneNumberFromSkillGroupsResponse RemovePhoneNumberFromSkillGroups(RemovePhoneNumberFromSkillGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemovePhoneNumberFromSkillGroupsWithOptions(request, runtime);
        }

        public async Task<RemovePhoneNumberFromSkillGroupsResponse> RemovePhoneNumberFromSkillGroupsAsync(RemovePhoneNumberFromSkillGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemovePhoneNumberFromSkillGroupsWithOptionsAsync(request, runtime);
        }

        public RemovePhoneNumbersResponse RemovePhoneNumbersWithOptions(RemovePhoneNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["NumberList"] = request.NumberList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemovePhoneNumbers",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemovePhoneNumbersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemovePhoneNumbersResponse> RemovePhoneNumbersWithOptionsAsync(RemovePhoneNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["NumberList"] = request.NumberList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemovePhoneNumbers",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemovePhoneNumbersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemovePhoneNumbersResponse RemovePhoneNumbers(RemovePhoneNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemovePhoneNumbersWithOptions(request, runtime);
        }

        public async Task<RemovePhoneNumbersResponse> RemovePhoneNumbersAsync(RemovePhoneNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemovePhoneNumbersWithOptionsAsync(request, runtime);
        }

        public RemovePhoneNumbersFromSkillGroupResponse RemovePhoneNumbersFromSkillGroupWithOptions(RemovePhoneNumbersFromSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["NumberList"] = request.NumberList;
            query["SkillGroupId"] = request.SkillGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemovePhoneNumbersFromSkillGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemovePhoneNumbersFromSkillGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemovePhoneNumbersFromSkillGroupResponse> RemovePhoneNumbersFromSkillGroupWithOptionsAsync(RemovePhoneNumbersFromSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["NumberList"] = request.NumberList;
            query["SkillGroupId"] = request.SkillGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemovePhoneNumbersFromSkillGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemovePhoneNumbersFromSkillGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemovePhoneNumbersFromSkillGroupResponse RemovePhoneNumbersFromSkillGroup(RemovePhoneNumbersFromSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemovePhoneNumbersFromSkillGroupWithOptions(request, runtime);
        }

        public async Task<RemovePhoneNumbersFromSkillGroupResponse> RemovePhoneNumbersFromSkillGroupAsync(RemovePhoneNumbersFromSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemovePhoneNumbersFromSkillGroupWithOptionsAsync(request, runtime);
        }

        public RemoveSkillGroupsFromUserResponse RemoveSkillGroupsFromUserWithOptions(RemoveSkillGroupsFromUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["SkillGroupIdList"] = request.SkillGroupIdList;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveSkillGroupsFromUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveSkillGroupsFromUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveSkillGroupsFromUserResponse> RemoveSkillGroupsFromUserWithOptionsAsync(RemoveSkillGroupsFromUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["SkillGroupIdList"] = request.SkillGroupIdList;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveSkillGroupsFromUser",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveSkillGroupsFromUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveSkillGroupsFromUserResponse RemoveSkillGroupsFromUser(RemoveSkillGroupsFromUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveSkillGroupsFromUserWithOptions(request, runtime);
        }

        public async Task<RemoveSkillGroupsFromUserResponse> RemoveSkillGroupsFromUserAsync(RemoveSkillGroupsFromUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveSkillGroupsFromUserWithOptionsAsync(request, runtime);
        }

        public RemoveUsersResponse RemoveUsersWithOptions(RemoveUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["UserIdList"] = request.UserIdList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveUsers",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUsersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveUsersResponse> RemoveUsersWithOptionsAsync(RemoveUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["UserIdList"] = request.UserIdList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveUsers",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUsersResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["SkillGroupId"] = request.SkillGroupId;
            query["UserIdList"] = request.UserIdList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveUsersFromSkillGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUsersFromSkillGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveUsersFromSkillGroupResponse> RemoveUsersFromSkillGroupWithOptionsAsync(RemoveUsersFromSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["SkillGroupId"] = request.SkillGroupId;
            query["UserIdList"] = request.UserIdList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveUsersFromSkillGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUsersFromSkillGroupResponse>(await CallApiAsync(params_, req, runtime));
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

        public ResetAgentStateResponse ResetAgentStateWithOptions(ResetAgentStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetAgentState",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetAgentStateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ResetAgentStateResponse> ResetAgentStateWithOptionsAsync(ResetAgentStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetAgentState",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetAgentStateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ResetAgentStateResponse ResetAgentState(ResetAgentStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetAgentStateWithOptions(request, runtime);
        }

        public async Task<ResetAgentStateResponse> ResetAgentStateAsync(ResetAgentStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetAgentStateWithOptionsAsync(request, runtime);
        }

        public ResetUserPasswordResponse ResetUserPasswordWithOptions(ResetUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["Password"] = request.Password;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetUserPassword",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetUserPasswordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ResetUserPasswordResponse> ResetUserPasswordWithOptionsAsync(ResetUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["Password"] = request.Password;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetUserPassword",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetUserPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ResetUserPasswordResponse ResetUserPassword(ResetUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetUserPasswordWithOptions(request, runtime);
        }

        public async Task<ResetUserPasswordResponse> ResetUserPasswordAsync(ResetUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetUserPasswordWithOptionsAsync(request, runtime);
        }

        public ResumeCampaignResponse ResumeCampaignWithOptions(ResumeCampaignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CampaignId"] = request.CampaignId;
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeCampaignResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ResumeCampaignResponse> ResumeCampaignWithOptionsAsync(ResumeCampaignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CampaignId"] = request.CampaignId;
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeCampaignResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ResumeCampaignResponse ResumeCampaign(ResumeCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeCampaignWithOptions(request, runtime);
        }

        public async Task<ResumeCampaignResponse> ResumeCampaignAsync(ResumeCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeCampaignWithOptionsAsync(request, runtime);
        }

        public RetrieveCallResponse RetrieveCallWithOptions(RetrieveCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ChannelId"] = request.ChannelId;
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetrieveCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveCallResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RetrieveCallResponse> RetrieveCallWithOptionsAsync(RetrieveCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ChannelId"] = request.ChannelId;
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetrieveCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RetrieveCallResponse RetrieveCall(RetrieveCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RetrieveCallWithOptions(request, runtime);
        }

        public async Task<RetrieveCallResponse> RetrieveCallAsync(RetrieveCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RetrieveCallWithOptionsAsync(request, runtime);
        }

        public SaveRTCStatsV2Response SaveRTCStatsV2WithOptions(SaveRTCStatsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallId"] = request.CallId;
            query["GeneralInfo"] = request.GeneralInfo;
            query["GoogAddress"] = request.GoogAddress;
            query["InstanceId"] = request.InstanceId;
            query["ReceiverReport"] = request.ReceiverReport;
            query["SenderReport"] = request.SenderReport;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveRTCStatsV2",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveRTCStatsV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<SaveRTCStatsV2Response> SaveRTCStatsV2WithOptionsAsync(SaveRTCStatsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallId"] = request.CallId;
            query["GeneralInfo"] = request.GeneralInfo;
            query["GoogAddress"] = request.GoogAddress;
            query["InstanceId"] = request.InstanceId;
            query["ReceiverReport"] = request.ReceiverReport;
            query["SenderReport"] = request.SenderReport;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveRTCStatsV2",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveRTCStatsV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public SaveRTCStatsV2Response SaveRTCStatsV2(SaveRTCStatsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveRTCStatsV2WithOptions(request, runtime);
        }

        public async Task<SaveRTCStatsV2Response> SaveRTCStatsV2Async(SaveRTCStatsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveRTCStatsV2WithOptionsAsync(request, runtime);
        }

        public SaveTerminalLogResponse SaveTerminalLogWithOptions(SaveTerminalLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppName"] = request.AppName;
            query["CallId"] = request.CallId;
            query["Content"] = request.Content;
            query["DataType"] = request.DataType;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["MethodName"] = request.MethodName;
            query["Status"] = request.Status;
            query["UniqueRequestId"] = request.UniqueRequestId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTerminalLog",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTerminalLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveTerminalLogResponse> SaveTerminalLogWithOptionsAsync(SaveTerminalLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppName"] = request.AppName;
            query["CallId"] = request.CallId;
            query["Content"] = request.Content;
            query["DataType"] = request.DataType;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["MethodName"] = request.MethodName;
            query["Status"] = request.Status;
            query["UniqueRequestId"] = request.UniqueRequestId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTerminalLog",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTerminalLogResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallId"] = request.CallId;
            query["GeneralInfo"] = request.GeneralInfo;
            query["GoogAddress"] = request.GoogAddress;
            query["InstanceId"] = request.InstanceId;
            query["ReceiverReport"] = request.ReceiverReport;
            query["SenderReport"] = request.SenderReport;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveWebRTCStats",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveWebRTCStatsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveWebRTCStatsResponse> SaveWebRTCStatsWithOptionsAsync(SaveWebRTCStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallId"] = request.CallId;
            query["GeneralInfo"] = request.GeneralInfo;
            query["GoogAddress"] = request.GoogAddress;
            query["InstanceId"] = request.InstanceId;
            query["ReceiverReport"] = request.ReceiverReport;
            query["SenderReport"] = request.SenderReport;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveWebRTCStats",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveWebRTCStatsResponse>(await CallApiAsync(params_, req, runtime));
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

        public SaveWebRtcInfoResponse SaveWebRtcInfoWithOptions(SaveWebRtcInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallId"] = request.CallId;
            query["Content"] = request.Content;
            query["ContentType"] = request.ContentType;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveWebRtcInfo",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveWebRtcInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveWebRtcInfoResponse> SaveWebRtcInfoWithOptionsAsync(SaveWebRtcInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallId"] = request.CallId;
            query["Content"] = request.Content;
            query["ContentType"] = request.ContentType;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveWebRtcInfo",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveWebRtcInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveWebRtcInfoResponse SaveWebRtcInfo(SaveWebRtcInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveWebRtcInfoWithOptions(request, runtime);
        }

        public async Task<SaveWebRtcInfoResponse> SaveWebRtcInfoAsync(SaveWebRtcInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveWebRtcInfoWithOptionsAsync(request, runtime);
        }

        public SendDtmfSignalingResponse SendDtmfSignalingWithOptions(SendDtmfSignalingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ChannelId"] = request.ChannelId;
            query["DeviceId"] = request.DeviceId;
            query["Dtmf"] = request.Dtmf;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendDtmfSignaling",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendDtmfSignalingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SendDtmfSignalingResponse> SendDtmfSignalingWithOptionsAsync(SendDtmfSignalingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ChannelId"] = request.ChannelId;
            query["DeviceId"] = request.DeviceId;
            query["Dtmf"] = request.Dtmf;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendDtmfSignaling",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendDtmfSignalingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SendDtmfSignalingResponse SendDtmfSignaling(SendDtmfSignalingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendDtmfSignalingWithOptions(request, runtime);
        }

        public async Task<SendDtmfSignalingResponse> SendDtmfSignalingAsync(SendDtmfSignalingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendDtmfSignalingWithOptionsAsync(request, runtime);
        }

        public SignInGroupResponse SignInGroupWithOptions(SignInGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["SignedSkillGroupIdList"] = request.SignedSkillGroupIdList;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SignInGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SignInGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SignInGroupResponse> SignInGroupWithOptionsAsync(SignInGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["SignedSkillGroupIdList"] = request.SignedSkillGroupIdList;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SignInGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SignInGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SignInGroupResponse SignInGroup(SignInGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SignInGroupWithOptions(request, runtime);
        }

        public async Task<SignInGroupResponse> SignInGroupAsync(SignInGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SignInGroupWithOptionsAsync(request, runtime);
        }

        public SignOutGroupResponse SignOutGroupWithOptions(SignOutGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SignOutGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SignOutGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SignOutGroupResponse> SignOutGroupWithOptionsAsync(SignOutGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SignOutGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SignOutGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SignOutGroupResponse SignOutGroup(SignOutGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SignOutGroupWithOptions(request, runtime);
        }

        public async Task<SignOutGroupResponse> SignOutGroupAsync(SignOutGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SignOutGroupWithOptionsAsync(request, runtime);
        }

        public StartBack2BackCallResponse StartBack2BackCallWithOptions(StartBack2BackCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AdditionalBroker"] = request.AdditionalBroker;
            query["Broker"] = request.Broker;
            query["Callee"] = request.Callee;
            query["Caller"] = request.Caller;
            query["InstanceId"] = request.InstanceId;
            query["Tags"] = request.Tags;
            query["TimeoutSeconds"] = request.TimeoutSeconds;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartBack2BackCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartBack2BackCallResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartBack2BackCallResponse> StartBack2BackCallWithOptionsAsync(StartBack2BackCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AdditionalBroker"] = request.AdditionalBroker;
            query["Broker"] = request.Broker;
            query["Callee"] = request.Callee;
            query["Caller"] = request.Caller;
            query["InstanceId"] = request.InstanceId;
            query["Tags"] = request.Tags;
            query["TimeoutSeconds"] = request.TimeoutSeconds;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartBack2BackCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartBack2BackCallResponse>(await CallApiAsync(params_, req, runtime));
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

        public StartPredictiveCallResponse StartPredictiveCallWithOptions(StartPredictiveCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Callee"] = request.Callee;
            query["Caller"] = request.Caller;
            query["ContactFlowId"] = request.ContactFlowId;
            query["ContactFlowVariables"] = request.ContactFlowVariables;
            query["InstanceId"] = request.InstanceId;
            query["MaskedCallee"] = request.MaskedCallee;
            query["SkillGroupId"] = request.SkillGroupId;
            query["Tags"] = request.Tags;
            query["TimeoutSeconds"] = request.TimeoutSeconds;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartPredictiveCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartPredictiveCallResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartPredictiveCallResponse> StartPredictiveCallWithOptionsAsync(StartPredictiveCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Callee"] = request.Callee;
            query["Caller"] = request.Caller;
            query["ContactFlowId"] = request.ContactFlowId;
            query["ContactFlowVariables"] = request.ContactFlowVariables;
            query["InstanceId"] = request.InstanceId;
            query["MaskedCallee"] = request.MaskedCallee;
            query["SkillGroupId"] = request.SkillGroupId;
            query["Tags"] = request.Tags;
            query["TimeoutSeconds"] = request.TimeoutSeconds;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartPredictiveCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartPredictiveCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartPredictiveCallResponse StartPredictiveCall(StartPredictiveCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartPredictiveCallWithOptions(request, runtime);
        }

        public async Task<StartPredictiveCallResponse> StartPredictiveCallAsync(StartPredictiveCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartPredictiveCallWithOptionsAsync(request, runtime);
        }

        public SubmitCampaignResponse SubmitCampaignWithOptions(SubmitCampaignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CampaignId"] = request.CampaignId;
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitCampaignResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitCampaignResponse> SubmitCampaignWithOptionsAsync(SubmitCampaignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CampaignId"] = request.CampaignId;
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitCampaignResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitCampaignResponse SubmitCampaign(SubmitCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitCampaignWithOptions(request, runtime);
        }

        public async Task<SubmitCampaignResponse> SubmitCampaignAsync(SubmitCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitCampaignWithOptionsAsync(request, runtime);
        }

        public TakeBreakResponse TakeBreakWithOptions(TakeBreakRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Code"] = request.Code;
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TakeBreak",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TakeBreakResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TakeBreakResponse> TakeBreakWithOptionsAsync(TakeBreakRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Code"] = request.Code;
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TakeBreak",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TakeBreakResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TakeBreakResponse TakeBreak(TakeBreakRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TakeBreakWithOptions(request, runtime);
        }

        public async Task<TakeBreakResponse> TakeBreakAsync(TakeBreakRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TakeBreakWithOptionsAsync(request, runtime);
        }

        public UnmuteCallResponse UnmuteCallWithOptions(UnmuteCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ChannelId"] = request.ChannelId;
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnmuteCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnmuteCallResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnmuteCallResponse> UnmuteCallWithOptionsAsync(UnmuteCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ChannelId"] = request.ChannelId;
            query["DeviceId"] = request.DeviceId;
            query["InstanceId"] = request.InstanceId;
            query["JobId"] = request.JobId;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnmuteCall",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnmuteCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnmuteCallResponse UnmuteCall(UnmuteCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnmuteCallWithOptions(request, runtime);
        }

        public async Task<UnmuteCallResponse> UnmuteCallAsync(UnmuteCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnmuteCallWithOptionsAsync(request, runtime);
        }

        public UpdateConfigItemsResponse UpdateConfigItemsWithOptions(UpdateConfigItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ConfigItems"] = request.ConfigItems;
            query["InstanceId"] = request.InstanceId;
            query["ObjectId"] = request.ObjectId;
            query["ObjectType"] = request.ObjectType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConfigItems",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConfigItemsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateConfigItemsResponse> UpdateConfigItemsWithOptionsAsync(UpdateConfigItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ConfigItems"] = request.ConfigItems;
            query["InstanceId"] = request.InstanceId;
            query["ObjectId"] = request.ObjectId;
            query["ObjectType"] = request.ObjectType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConfigItems",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConfigItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateConfigItemsResponse UpdateConfigItems(UpdateConfigItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateConfigItemsWithOptions(request, runtime);
        }

        public async Task<UpdateConfigItemsResponse> UpdateConfigItemsAsync(UpdateConfigItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateConfigItemsWithOptionsAsync(request, runtime);
        }

    }
}
