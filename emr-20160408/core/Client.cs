// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Emr20160408.Models;

namespace AlibabaCloud.SDK.Emr20160408
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing", "emr.aliyuncs.com"},
                {"cn-hangzhou", "emr.aliyuncs.com"},
                {"cn-shanghai", "emr.aliyuncs.com"},
                {"cn-shenzhen", "emr.aliyuncs.com"},
                {"ap-southeast-1", "emr.aliyuncs.com"},
                {"us-west-1", "emr.aliyuncs.com"},
                {"cn-hangzhou-finance", "emr.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "emr.aliyuncs.com"},
                {"cn-shanghai-finance-1", "emr.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("emr", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddClusterServiceResponse AddClusterServiceWithOptions(AddClusterServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Comment"] = request.Comment;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Service"] = request.Service;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddClusterService",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddClusterServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddClusterServiceResponse> AddClusterServiceWithOptionsAsync(AddClusterServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Comment"] = request.Comment;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Service"] = request.Service;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddClusterService",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddClusterServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddClusterServiceResponse AddClusterService(AddClusterServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddClusterServiceWithOptions(request, runtime);
        }

        public async Task<AddClusterServiceResponse> AddClusterServiceAsync(AddClusterServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddClusterServiceWithOptionsAsync(request, runtime);
        }

        public AddScalingConfigItemV2Response AddScalingConfigItemV2WithOptions(AddScalingConfigItemV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ConfigItemInformation"] = request.ConfigItemInformation;
            query["ConfigItemType"] = request.ConfigItemType;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingGroupBizId"] = request.ScalingGroupBizId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddScalingConfigItemV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddScalingConfigItemV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<AddScalingConfigItemV2Response> AddScalingConfigItemV2WithOptionsAsync(AddScalingConfigItemV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ConfigItemInformation"] = request.ConfigItemInformation;
            query["ConfigItemType"] = request.ConfigItemType;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingGroupBizId"] = request.ScalingGroupBizId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddScalingConfigItemV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddScalingConfigItemV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public AddScalingConfigItemV2Response AddScalingConfigItemV2(AddScalingConfigItemV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddScalingConfigItemV2WithOptions(request, runtime);
        }

        public async Task<AddScalingConfigItemV2Response> AddScalingConfigItemV2Async(AddScalingConfigItemV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddScalingConfigItemV2WithOptionsAsync(request, runtime);
        }

        public AuthorizeSecurityGroupResponse AuthorizeSecurityGroupWithOptions(AuthorizeSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BizContent"] = request.BizContent;
            query["BizType"] = request.BizType;
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeSecurityGroup",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeSecurityGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AuthorizeSecurityGroupResponse> AuthorizeSecurityGroupWithOptionsAsync(AuthorizeSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BizContent"] = request.BizContent;
            query["BizType"] = request.BizType;
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeSecurityGroup",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeSecurityGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AuthorizeSecurityGroupResponse AuthorizeSecurityGroup(AuthorizeSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthorizeSecurityGroupWithOptions(request, runtime);
        }

        public async Task<AuthorizeSecurityGroupResponse> AuthorizeSecurityGroupAsync(AuthorizeSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthorizeSecurityGroupWithOptionsAsync(request, runtime);
        }

        public CancelOrderResponse CancelOrderWithOptions(CancelOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelOrder",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelOrderResponse> CancelOrderWithOptionsAsync(CancelOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelOrder",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelOrderResponse CancelOrder(CancelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelOrderWithOptions(request, runtime);
        }

        public async Task<CancelOrderResponse> CancelOrderAsync(CancelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelOrderWithOptionsAsync(request, runtime);
        }

        public CloneFlowResponse CloneFlowWithOptions(CloneFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneFlow",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneFlowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CloneFlowResponse> CloneFlowWithOptionsAsync(CloneFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneFlow",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneFlowResponse>(await CallApiAsync(params_, req, runtime));
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

        public CloneFlowJobResponse CloneFlowJobWithOptions(CloneFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["Name"] = request.Name;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneFlowJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneFlowJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CloneFlowJobResponse> CloneFlowJobWithOptionsAsync(CloneFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["Name"] = request.Name;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneFlowJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneFlowJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CloneFlowJobResponse CloneFlowJob(CloneFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloneFlowJobWithOptions(request, runtime);
        }

        public async Task<CloneFlowJobResponse> CloneFlowJobAsync(CloneFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloneFlowJobWithOptionsAsync(request, runtime);
        }

        public CreateBackupResponse CreateBackupWithOptions(CreateBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackupPlanId"] = request.BackupPlanId;
            query["MetadataType"] = request.MetadataType;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBackup",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBackupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateBackupResponse> CreateBackupWithOptionsAsync(CreateBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackupPlanId"] = request.BackupPlanId;
            query["MetadataType"] = request.MetadataType;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBackup",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBackupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateBackupResponse CreateBackup(CreateBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBackupWithOptions(request, runtime);
        }

        public async Task<CreateBackupResponse> CreateBackupAsync(CreateBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBackupWithOptionsAsync(request, runtime);
        }

        public CreateBackupPlanResponse CreateBackupPlanWithOptions(CreateBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RootPath"] = request.RootPath;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBackupPlan",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBackupPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateBackupPlanResponse> CreateBackupPlanWithOptionsAsync(CreateBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RootPath"] = request.RootPath;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBackupPlan",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBackupPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateBackupPlanResponse CreateBackupPlan(CreateBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBackupPlanWithOptions(request, runtime);
        }

        public async Task<CreateBackupPlanResponse> CreateBackupPlanAsync(CreateBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBackupPlanWithOptionsAsync(request, runtime);
        }

        public CreateClusterBootstrapActionResponse CreateClusterBootstrapActionWithOptions(CreateClusterBootstrapActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BootstrapAction"] = request.BootstrapAction;
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClusterBootstrapAction",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterBootstrapActionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateClusterBootstrapActionResponse> CreateClusterBootstrapActionWithOptionsAsync(CreateClusterBootstrapActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BootstrapAction"] = request.BootstrapAction;
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClusterBootstrapAction",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterBootstrapActionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateClusterBootstrapActionResponse CreateClusterBootstrapAction(CreateClusterBootstrapActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClusterBootstrapActionWithOptions(request, runtime);
        }

        public async Task<CreateClusterBootstrapActionResponse> CreateClusterBootstrapActionAsync(CreateClusterBootstrapActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClusterBootstrapActionWithOptionsAsync(request, runtime);
        }

        public CreateClusterHostGroupResponse CreateClusterHostGroupWithOptions(CreateClusterHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Comment"] = request.Comment;
            query["HostGroupName"] = request.HostGroupName;
            query["HostGroupParams"] = request.HostGroupParams;
            query["HostGroupType"] = request.HostGroupType;
            query["PayType"] = request.PayType;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityGroupId"] = request.SecurityGroupId;
            query["VswitchId"] = request.VswitchId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClusterHostGroup",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterHostGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateClusterHostGroupResponse> CreateClusterHostGroupWithOptionsAsync(CreateClusterHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Comment"] = request.Comment;
            query["HostGroupName"] = request.HostGroupName;
            query["HostGroupParams"] = request.HostGroupParams;
            query["HostGroupType"] = request.HostGroupType;
            query["PayType"] = request.PayType;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityGroupId"] = request.SecurityGroupId;
            query["VswitchId"] = request.VswitchId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClusterHostGroup",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterHostGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateClusterHostGroupResponse CreateClusterHostGroup(CreateClusterHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClusterHostGroupWithOptions(request, runtime);
        }

        public async Task<CreateClusterHostGroupResponse> CreateClusterHostGroupAsync(CreateClusterHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClusterHostGroupWithOptionsAsync(request, runtime);
        }

        public CreateClusterTemplateResponse CreateClusterTemplateWithOptions(CreateClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoRenew"] = request.AutoRenew;
            query["BootstrapAction"] = request.BootstrapAction;
            query["ClientToken"] = request.ClientToken;
            query["ClusterType"] = request.ClusterType;
            query["Config"] = request.Config;
            query["Configurations"] = request.Configurations;
            query["DepositType"] = request.DepositType;
            query["EasEnable"] = request.EasEnable;
            query["EmrVer"] = request.EmrVer;
            query["HighAvailabilityEnable"] = request.HighAvailabilityEnable;
            query["HostGroup"] = request.HostGroup;
            query["InitCustomHiveMetaDb"] = request.InitCustomHiveMetaDb;
            query["InstanceGeneration"] = request.InstanceGeneration;
            query["IoOptimized"] = request.IoOptimized;
            query["IsOpenPublicIp"] = request.IsOpenPublicIp;
            query["KeyPairName"] = request.KeyPairName;
            query["LogPath"] = request.LogPath;
            query["MachineType"] = request.MachineType;
            query["MasterPwd"] = request.MasterPwd;
            query["MetaStoreConf"] = request.MetaStoreConf;
            query["MetaStoreType"] = request.MetaStoreType;
            query["NetType"] = request.NetType;
            query["OptionSoftWareList"] = request.OptionSoftWareList;
            query["Period"] = request.Period;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityGroupId"] = request.SecurityGroupId;
            query["SecurityGroupName"] = request.SecurityGroupName;
            query["SshEnable"] = request.SshEnable;
            query["Tag"] = request.Tag;
            query["TemplateName"] = request.TemplateName;
            query["UseCustomHiveMetaDb"] = request.UseCustomHiveMetaDb;
            query["UseLocalMetaDb"] = request.UseLocalMetaDb;
            query["UserDefinedEmrEcsRole"] = request.UserDefinedEmrEcsRole;
            query["VSwitchId"] = request.VSwitchId;
            query["VpcId"] = request.VpcId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClusterTemplate",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateClusterTemplateResponse> CreateClusterTemplateWithOptionsAsync(CreateClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoRenew"] = request.AutoRenew;
            query["BootstrapAction"] = request.BootstrapAction;
            query["ClientToken"] = request.ClientToken;
            query["ClusterType"] = request.ClusterType;
            query["Config"] = request.Config;
            query["Configurations"] = request.Configurations;
            query["DepositType"] = request.DepositType;
            query["EasEnable"] = request.EasEnable;
            query["EmrVer"] = request.EmrVer;
            query["HighAvailabilityEnable"] = request.HighAvailabilityEnable;
            query["HostGroup"] = request.HostGroup;
            query["InitCustomHiveMetaDb"] = request.InitCustomHiveMetaDb;
            query["InstanceGeneration"] = request.InstanceGeneration;
            query["IoOptimized"] = request.IoOptimized;
            query["IsOpenPublicIp"] = request.IsOpenPublicIp;
            query["KeyPairName"] = request.KeyPairName;
            query["LogPath"] = request.LogPath;
            query["MachineType"] = request.MachineType;
            query["MasterPwd"] = request.MasterPwd;
            query["MetaStoreConf"] = request.MetaStoreConf;
            query["MetaStoreType"] = request.MetaStoreType;
            query["NetType"] = request.NetType;
            query["OptionSoftWareList"] = request.OptionSoftWareList;
            query["Period"] = request.Period;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityGroupId"] = request.SecurityGroupId;
            query["SecurityGroupName"] = request.SecurityGroupName;
            query["SshEnable"] = request.SshEnable;
            query["Tag"] = request.Tag;
            query["TemplateName"] = request.TemplateName;
            query["UseCustomHiveMetaDb"] = request.UseCustomHiveMetaDb;
            query["UseLocalMetaDb"] = request.UseLocalMetaDb;
            query["UserDefinedEmrEcsRole"] = request.UserDefinedEmrEcsRole;
            query["VSwitchId"] = request.VSwitchId;
            query["VpcId"] = request.VpcId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClusterTemplate",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateClusterTemplateResponse CreateClusterTemplate(CreateClusterTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClusterTemplateWithOptions(request, runtime);
        }

        public async Task<CreateClusterTemplateResponse> CreateClusterTemplateAsync(CreateClusterTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClusterTemplateWithOptionsAsync(request, runtime);
        }

        public CreateClusterV2Response CreateClusterV2WithOptions(CreateClusterV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AuthorizeContent"] = request.AuthorizeContent;
            query["AutoPayOrder"] = request.AutoPayOrder;
            query["AutoRenew"] = request.AutoRenew;
            query["BootstrapAction"] = request.BootstrapAction;
            query["ChargeType"] = request.ChargeType;
            query["ClickHouseConf"] = request.ClickHouseConf;
            query["ClientToken"] = request.ClientToken;
            query["ClusterType"] = request.ClusterType;
            query["Config"] = request.Config;
            query["Configurations"] = request.Configurations;
            query["DepositType"] = request.DepositType;
            query["EasEnable"] = request.EasEnable;
            query["EmrVer"] = request.EmrVer;
            query["ExtraAttributes"] = request.ExtraAttributes;
            query["HighAvailabilityEnable"] = request.HighAvailabilityEnable;
            query["HostComponentInfo"] = request.HostComponentInfo;
            query["HostGroup"] = request.HostGroup;
            query["InitCustomHiveMetaDB"] = request.InitCustomHiveMetaDB;
            query["InstanceGeneration"] = request.InstanceGeneration;
            query["IoOptimized"] = request.IoOptimized;
            query["IsOpenPublicIp"] = request.IsOpenPublicIp;
            query["KeyPairName"] = request.KeyPairName;
            query["LogPath"] = request.LogPath;
            query["MachineType"] = request.MachineType;
            query["MasterPwd"] = request.MasterPwd;
            query["MetaStoreConf"] = request.MetaStoreConf;
            query["MetaStoreType"] = request.MetaStoreType;
            query["Name"] = request.Name;
            query["NetType"] = request.NetType;
            query["OptionSoftWareList"] = request.OptionSoftWareList;
            query["Period"] = request.Period;
            query["PromotionInfo"] = request.PromotionInfo;
            query["RegionId"] = request.RegionId;
            query["RelatedClusterId"] = request.RelatedClusterId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityGroupId"] = request.SecurityGroupId;
            query["SecurityGroupName"] = request.SecurityGroupName;
            query["ServiceInfo"] = request.ServiceInfo;
            query["SshEnable"] = request.SshEnable;
            query["Tag"] = request.Tag;
            query["UseCustomHiveMetaDB"] = request.UseCustomHiveMetaDB;
            query["UseLocalMetaDb"] = request.UseLocalMetaDb;
            query["UserDefinedEmrEcsRole"] = request.UserDefinedEmrEcsRole;
            query["UserInfo"] = request.UserInfo;
            query["VSwitchId"] = request.VSwitchId;
            query["VpcId"] = request.VpcId;
            query["WhiteListType"] = request.WhiteListType;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClusterV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<CreateClusterV2Response> CreateClusterV2WithOptionsAsync(CreateClusterV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AuthorizeContent"] = request.AuthorizeContent;
            query["AutoPayOrder"] = request.AutoPayOrder;
            query["AutoRenew"] = request.AutoRenew;
            query["BootstrapAction"] = request.BootstrapAction;
            query["ChargeType"] = request.ChargeType;
            query["ClickHouseConf"] = request.ClickHouseConf;
            query["ClientToken"] = request.ClientToken;
            query["ClusterType"] = request.ClusterType;
            query["Config"] = request.Config;
            query["Configurations"] = request.Configurations;
            query["DepositType"] = request.DepositType;
            query["EasEnable"] = request.EasEnable;
            query["EmrVer"] = request.EmrVer;
            query["ExtraAttributes"] = request.ExtraAttributes;
            query["HighAvailabilityEnable"] = request.HighAvailabilityEnable;
            query["HostComponentInfo"] = request.HostComponentInfo;
            query["HostGroup"] = request.HostGroup;
            query["InitCustomHiveMetaDB"] = request.InitCustomHiveMetaDB;
            query["InstanceGeneration"] = request.InstanceGeneration;
            query["IoOptimized"] = request.IoOptimized;
            query["IsOpenPublicIp"] = request.IsOpenPublicIp;
            query["KeyPairName"] = request.KeyPairName;
            query["LogPath"] = request.LogPath;
            query["MachineType"] = request.MachineType;
            query["MasterPwd"] = request.MasterPwd;
            query["MetaStoreConf"] = request.MetaStoreConf;
            query["MetaStoreType"] = request.MetaStoreType;
            query["Name"] = request.Name;
            query["NetType"] = request.NetType;
            query["OptionSoftWareList"] = request.OptionSoftWareList;
            query["Period"] = request.Period;
            query["PromotionInfo"] = request.PromotionInfo;
            query["RegionId"] = request.RegionId;
            query["RelatedClusterId"] = request.RelatedClusterId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityGroupId"] = request.SecurityGroupId;
            query["SecurityGroupName"] = request.SecurityGroupName;
            query["ServiceInfo"] = request.ServiceInfo;
            query["SshEnable"] = request.SshEnable;
            query["Tag"] = request.Tag;
            query["UseCustomHiveMetaDB"] = request.UseCustomHiveMetaDB;
            query["UseLocalMetaDb"] = request.UseLocalMetaDb;
            query["UserDefinedEmrEcsRole"] = request.UserDefinedEmrEcsRole;
            query["UserInfo"] = request.UserInfo;
            query["VSwitchId"] = request.VSwitchId;
            query["VpcId"] = request.VpcId;
            query["WhiteListType"] = request.WhiteListType;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClusterV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public CreateClusterV2Response CreateClusterV2(CreateClusterV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClusterV2WithOptions(request, runtime);
        }

        public async Task<CreateClusterV2Response> CreateClusterV2Async(CreateClusterV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClusterV2WithOptionsAsync(request, runtime);
        }

        public CreateClusterWithTemplateResponse CreateClusterWithTemplateWithOptions(CreateClusterWithTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterName"] = request.ClusterName;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TemplateBizId"] = request.TemplateBizId;
            query["UniqueTag"] = request.UniqueTag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClusterWithTemplate",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterWithTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateClusterWithTemplateResponse> CreateClusterWithTemplateWithOptionsAsync(CreateClusterWithTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterName"] = request.ClusterName;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TemplateBizId"] = request.TemplateBizId;
            query["UniqueTag"] = request.UniqueTag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClusterWithTemplate",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterWithTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateClusterWithTemplateResponse CreateClusterWithTemplate(CreateClusterWithTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClusterWithTemplateWithOptions(request, runtime);
        }

        public async Task<CreateClusterWithTemplateResponse> CreateClusterWithTemplateAsync(CreateClusterWithTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClusterWithTemplateWithOptionsAsync(request, runtime);
        }

        public CreateDataSourceResponse CreateDataSourceWithOptions(CreateDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Conf"] = request.Conf;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["NavParentId"] = request.NavParentId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SourceType"] = request.SourceType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataSource",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataSourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDataSourceResponse> CreateDataSourceWithOptionsAsync(CreateDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Conf"] = request.Conf;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["NavParentId"] = request.NavParentId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SourceType"] = request.SourceType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataSource",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataSourceWithOptions(request, runtime);
        }

        public async Task<CreateDataSourceResponse> CreateDataSourceAsync(CreateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataSourceWithOptionsAsync(request, runtime);
        }

        public CreateExecutionPlanResponse CreateExecutionPlanWithOptions(CreateExecutionPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BootstrapAction"] = request.BootstrapAction;
            query["ClusterId"] = request.ClusterId;
            query["ClusterName"] = request.ClusterName;
            query["ClusterType"] = request.ClusterType;
            query["Config"] = request.Config;
            query["Configurations"] = request.Configurations;
            query["CreateClusterOnDemand"] = request.CreateClusterOnDemand;
            query["DayOfMonth"] = request.DayOfMonth;
            query["DayOfWeek"] = request.DayOfWeek;
            query["EasEnable"] = request.EasEnable;
            query["EcsOrder"] = request.EcsOrder;
            query["EmrVer"] = request.EmrVer;
            query["HighAvailabilityEnable"] = request.HighAvailabilityEnable;
            query["InitCustomHiveMetaDB"] = request.InitCustomHiveMetaDB;
            query["InstanceGeneration"] = request.InstanceGeneration;
            query["IoOptimized"] = request.IoOptimized;
            query["IsOpenPublicIp"] = request.IsOpenPublicIp;
            query["JobIdList"] = request.JobIdList;
            query["LogEnable"] = request.LogEnable;
            query["LogPath"] = request.LogPath;
            query["Name"] = request.Name;
            query["NetType"] = request.NetType;
            query["OptionSoftWareList"] = request.OptionSoftWareList;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityGroupId"] = request.SecurityGroupId;
            query["StartTime"] = request.StartTime;
            query["Strategy"] = request.Strategy;
            query["TimeInterval"] = request.TimeInterval;
            query["TimeUnit"] = request.TimeUnit;
            query["UseCustomHiveMetaDB"] = request.UseCustomHiveMetaDB;
            query["UseLocalMetaDb"] = request.UseLocalMetaDb;
            query["UserDefinedEmrEcsRole"] = request.UserDefinedEmrEcsRole;
            query["VSwitchId"] = request.VSwitchId;
            query["VpcId"] = request.VpcId;
            query["WorkflowDefinition"] = request.WorkflowDefinition;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExecutionPlan",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExecutionPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateExecutionPlanResponse> CreateExecutionPlanWithOptionsAsync(CreateExecutionPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BootstrapAction"] = request.BootstrapAction;
            query["ClusterId"] = request.ClusterId;
            query["ClusterName"] = request.ClusterName;
            query["ClusterType"] = request.ClusterType;
            query["Config"] = request.Config;
            query["Configurations"] = request.Configurations;
            query["CreateClusterOnDemand"] = request.CreateClusterOnDemand;
            query["DayOfMonth"] = request.DayOfMonth;
            query["DayOfWeek"] = request.DayOfWeek;
            query["EasEnable"] = request.EasEnable;
            query["EcsOrder"] = request.EcsOrder;
            query["EmrVer"] = request.EmrVer;
            query["HighAvailabilityEnable"] = request.HighAvailabilityEnable;
            query["InitCustomHiveMetaDB"] = request.InitCustomHiveMetaDB;
            query["InstanceGeneration"] = request.InstanceGeneration;
            query["IoOptimized"] = request.IoOptimized;
            query["IsOpenPublicIp"] = request.IsOpenPublicIp;
            query["JobIdList"] = request.JobIdList;
            query["LogEnable"] = request.LogEnable;
            query["LogPath"] = request.LogPath;
            query["Name"] = request.Name;
            query["NetType"] = request.NetType;
            query["OptionSoftWareList"] = request.OptionSoftWareList;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityGroupId"] = request.SecurityGroupId;
            query["StartTime"] = request.StartTime;
            query["Strategy"] = request.Strategy;
            query["TimeInterval"] = request.TimeInterval;
            query["TimeUnit"] = request.TimeUnit;
            query["UseCustomHiveMetaDB"] = request.UseCustomHiveMetaDB;
            query["UseLocalMetaDb"] = request.UseLocalMetaDb;
            query["UserDefinedEmrEcsRole"] = request.UserDefinedEmrEcsRole;
            query["VSwitchId"] = request.VSwitchId;
            query["VpcId"] = request.VpcId;
            query["WorkflowDefinition"] = request.WorkflowDefinition;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExecutionPlan",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExecutionPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateExecutionPlanResponse CreateExecutionPlan(CreateExecutionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateExecutionPlanWithOptions(request, runtime);
        }

        public async Task<CreateExecutionPlanResponse> CreateExecutionPlanAsync(CreateExecutionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateExecutionPlanWithOptionsAsync(request, runtime);
        }

        public CreateFlowResponse CreateFlowWithOptions(CreateFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AlertConf"] = request.AlertConf;
            query["AlertDingDingGroupBizId"] = request.AlertDingDingGroupBizId;
            query["AlertUserGroupBizId"] = request.AlertUserGroupBizId;
            query["Application"] = request.Application;
            query["ClusterId"] = request.ClusterId;
            query["CreateCluster"] = request.CreateCluster;
            query["CronExpr"] = request.CronExpr;
            query["Description"] = request.Description;
            query["EndSchedule"] = request.EndSchedule;
            query["HostName"] = request.HostName;
            query["Lifecycle"] = request.Lifecycle;
            query["LogArchiveLocation"] = request.LogArchiveLocation;
            query["Name"] = request.Name;
            query["Namespace"] = request.Namespace;
            query["ParentCategory"] = request.ParentCategory;
            query["ParentFlowList"] = request.ParentFlowList;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["StartSchedule"] = request.StartSchedule;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlow",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFlowResponse> CreateFlowWithOptionsAsync(CreateFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AlertConf"] = request.AlertConf;
            query["AlertDingDingGroupBizId"] = request.AlertDingDingGroupBizId;
            query["AlertUserGroupBizId"] = request.AlertUserGroupBizId;
            query["Application"] = request.Application;
            query["ClusterId"] = request.ClusterId;
            query["CreateCluster"] = request.CreateCluster;
            query["CronExpr"] = request.CronExpr;
            query["Description"] = request.Description;
            query["EndSchedule"] = request.EndSchedule;
            query["HostName"] = request.HostName;
            query["Lifecycle"] = request.Lifecycle;
            query["LogArchiveLocation"] = request.LogArchiveLocation;
            query["Name"] = request.Name;
            query["Namespace"] = request.Namespace;
            query["ParentCategory"] = request.ParentCategory;
            query["ParentFlowList"] = request.ParentFlowList;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["StartSchedule"] = request.StartSchedule;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlow",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowResponse>(await CallApiAsync(params_, req, runtime));
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

        public CreateFlowCategoryResponse CreateFlowCategoryWithOptions(CreateFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Name"] = request.Name;
            query["ParentId"] = request.ParentId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowCategory",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowCategoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFlowCategoryResponse> CreateFlowCategoryWithOptionsAsync(CreateFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Name"] = request.Name;
            query["ParentId"] = request.ParentId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowCategory",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFlowCategoryResponse CreateFlowCategory(CreateFlowCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowCategoryWithOptions(request, runtime);
        }

        public async Task<CreateFlowCategoryResponse> CreateFlowCategoryAsync(CreateFlowCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowCategoryWithOptionsAsync(request, runtime);
        }

        public CreateFlowForWebResponse CreateFlowForWebWithOptions(CreateFlowForWebRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AlertConf"] = request.AlertConf;
            query["AlertDingDingGroupBizId"] = request.AlertDingDingGroupBizId;
            query["AlertUserGroupBizId"] = request.AlertUserGroupBizId;
            query["ClusterId"] = request.ClusterId;
            query["CreateCluster"] = request.CreateCluster;
            query["CronExpr"] = request.CronExpr;
            query["Description"] = request.Description;
            query["EndSchedule"] = request.EndSchedule;
            query["Graph"] = request.Graph;
            query["HostName"] = request.HostName;
            query["Lifecycle"] = request.Lifecycle;
            query["LogArchiveLocation"] = request.LogArchiveLocation;
            query["Name"] = request.Name;
            query["Namespace"] = request.Namespace;
            query["ParentCategory"] = request.ParentCategory;
            query["ParentFlowList"] = request.ParentFlowList;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["StartSchedule"] = request.StartSchedule;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowForWeb",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowForWebResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFlowForWebResponse> CreateFlowForWebWithOptionsAsync(CreateFlowForWebRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AlertConf"] = request.AlertConf;
            query["AlertDingDingGroupBizId"] = request.AlertDingDingGroupBizId;
            query["AlertUserGroupBizId"] = request.AlertUserGroupBizId;
            query["ClusterId"] = request.ClusterId;
            query["CreateCluster"] = request.CreateCluster;
            query["CronExpr"] = request.CronExpr;
            query["Description"] = request.Description;
            query["EndSchedule"] = request.EndSchedule;
            query["Graph"] = request.Graph;
            query["HostName"] = request.HostName;
            query["Lifecycle"] = request.Lifecycle;
            query["LogArchiveLocation"] = request.LogArchiveLocation;
            query["Name"] = request.Name;
            query["Namespace"] = request.Namespace;
            query["ParentCategory"] = request.ParentCategory;
            query["ParentFlowList"] = request.ParentFlowList;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["StartSchedule"] = request.StartSchedule;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowForWeb",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowForWebResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFlowForWebResponse CreateFlowForWeb(CreateFlowForWebRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowForWebWithOptions(request, runtime);
        }

        public async Task<CreateFlowForWebResponse> CreateFlowForWebAsync(CreateFlowForWebRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowForWebWithOptionsAsync(request, runtime);
        }

        public CreateFlowJobResponse CreateFlowJobWithOptions(CreateFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Adhoc"] = request.Adhoc;
            query["AlertConf"] = request.AlertConf;
            query["ClusterId"] = request.ClusterId;
            query["FailAct"] = request.FailAct;
            query["MaxRetry"] = request.MaxRetry;
            query["MaxRunningTimeSec"] = request.MaxRunningTimeSec;
            query["Mode"] = request.Mode;
            query["Name"] = request.Name;
            query["ParentCategory"] = request.ParentCategory;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["RetryInterval"] = request.RetryInterval;
            query["RetryPolicy"] = request.RetryPolicy;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFlowJobResponse> CreateFlowJobWithOptionsAsync(CreateFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Adhoc"] = request.Adhoc;
            query["AlertConf"] = request.AlertConf;
            query["ClusterId"] = request.ClusterId;
            query["FailAct"] = request.FailAct;
            query["MaxRetry"] = request.MaxRetry;
            query["MaxRunningTimeSec"] = request.MaxRunningTimeSec;
            query["Mode"] = request.Mode;
            query["Name"] = request.Name;
            query["ParentCategory"] = request.ParentCategory;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["RetryInterval"] = request.RetryInterval;
            query["RetryPolicy"] = request.RetryPolicy;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFlowJobResponse CreateFlowJob(CreateFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowJobWithOptions(request, runtime);
        }

        public async Task<CreateFlowJobResponse> CreateFlowJobAsync(CreateFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowJobWithOptionsAsync(request, runtime);
        }

        public CreateFlowProjectResponse CreateFlowProjectWithOptions(CreateFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["ProductType"] = request.ProductType;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowProject",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFlowProjectResponse> CreateFlowProjectWithOptionsAsync(CreateFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["ProductType"] = request.ProductType;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowProject",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFlowProjectResponse CreateFlowProject(CreateFlowProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowProjectWithOptions(request, runtime);
        }

        public async Task<CreateFlowProjectResponse> CreateFlowProjectAsync(CreateFlowProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowProjectWithOptionsAsync(request, runtime);
        }

        public CreateFlowProjectClusterSettingResponse CreateFlowProjectClusterSettingWithOptions(CreateFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["DefaultQueue"] = request.DefaultQueue;
            query["DefaultUser"] = request.DefaultUser;
            query["HostList"] = request.HostList;
            query["ProjectId"] = request.ProjectId;
            query["QueueList"] = request.QueueList;
            query["RegionId"] = request.RegionId;
            query["UserList"] = request.UserList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowProjectClusterSetting",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowProjectClusterSettingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFlowProjectClusterSettingResponse> CreateFlowProjectClusterSettingWithOptionsAsync(CreateFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["DefaultQueue"] = request.DefaultQueue;
            query["DefaultUser"] = request.DefaultUser;
            query["HostList"] = request.HostList;
            query["ProjectId"] = request.ProjectId;
            query["QueueList"] = request.QueueList;
            query["RegionId"] = request.RegionId;
            query["UserList"] = request.UserList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowProjectClusterSetting",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowProjectClusterSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFlowProjectClusterSettingResponse CreateFlowProjectClusterSetting(CreateFlowProjectClusterSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowProjectClusterSettingWithOptions(request, runtime);
        }

        public async Task<CreateFlowProjectClusterSettingResponse> CreateFlowProjectClusterSettingAsync(CreateFlowProjectClusterSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowProjectClusterSettingWithOptionsAsync(request, runtime);
        }

        public CreateFlowProjectUserResponse CreateFlowProjectUserWithOptions(CreateFlowProjectUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["User"] = request.User;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowProjectUser",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowProjectUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFlowProjectUserResponse> CreateFlowProjectUserWithOptionsAsync(CreateFlowProjectUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["User"] = request.User;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowProjectUser",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowProjectUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFlowProjectUserResponse CreateFlowProjectUser(CreateFlowProjectUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowProjectUserWithOptions(request, runtime);
        }

        public async Task<CreateFlowProjectUserResponse> CreateFlowProjectUserAsync(CreateFlowProjectUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowProjectUserWithOptionsAsync(request, runtime);
        }

        public CreateJobResponse CreateJobWithOptions(CreateJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["FailAct"] = request.FailAct;
            query["MaxRetry"] = request.MaxRetry;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RetryInterval"] = request.RetryInterval;
            query["RunParameter"] = request.RunParameter;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateJobResponse> CreateJobWithOptionsAsync(CreateJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["FailAct"] = request.FailAct;
            query["MaxRetry"] = request.MaxRetry;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RetryInterval"] = request.RetryInterval;
            query["RunParameter"] = request.RunParameter;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateJobResponse CreateJob(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateJobWithOptions(request, runtime);
        }

        public async Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateJobWithOptionsAsync(request, runtime);
        }

        public CreateLibraryResponse CreateLibraryWithOptions(CreateLibraryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["LibraryVersion"] = request.LibraryVersion;
            query["Name"] = request.Name;
            query["Properties"] = request.Properties;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Scope"] = request.Scope;
            query["SourceLocation"] = request.SourceLocation;
            query["SourceType"] = request.SourceType;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLibrary",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLibraryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateLibraryResponse> CreateLibraryWithOptionsAsync(CreateLibraryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["LibraryVersion"] = request.LibraryVersion;
            query["Name"] = request.Name;
            query["Properties"] = request.Properties;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Scope"] = request.Scope;
            query["SourceLocation"] = request.SourceLocation;
            query["SourceType"] = request.SourceType;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLibrary",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLibraryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateLibraryResponse CreateLibrary(CreateLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLibraryWithOptions(request, runtime);
        }

        public async Task<CreateLibraryResponse> CreateLibraryAsync(CreateLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLibraryWithOptionsAsync(request, runtime);
        }

        public CreateMetaTablePreviewTaskResponse CreateMetaTablePreviewTaskWithOptions(CreateMetaTablePreviewTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["DatabaseId"] = request.DatabaseId;
            query["Password"] = request.Password;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TableId"] = request.TableId;
            query["User"] = request.User;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMetaTablePreviewTask",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMetaTablePreviewTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateMetaTablePreviewTaskResponse> CreateMetaTablePreviewTaskWithOptionsAsync(CreateMetaTablePreviewTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["DatabaseId"] = request.DatabaseId;
            query["Password"] = request.Password;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TableId"] = request.TableId;
            query["User"] = request.User;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMetaTablePreviewTask",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMetaTablePreviewTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateMetaTablePreviewTaskResponse CreateMetaTablePreviewTask(CreateMetaTablePreviewTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMetaTablePreviewTaskWithOptions(request, runtime);
        }

        public async Task<CreateMetaTablePreviewTaskResponse> CreateMetaTablePreviewTaskAsync(CreateMetaTablePreviewTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMetaTablePreviewTaskWithOptionsAsync(request, runtime);
        }

        public CreateResourcePoolResponse CreateResourcePoolWithOptions(CreateResourcePoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Active"] = request.Active;
            query["ClusterId"] = request.ClusterId;
            query["Config"] = request.Config;
            query["Name"] = request.Name;
            query["Note"] = request.Note;
            query["PoolType"] = request.PoolType;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["YarnSiteConfig"] = request.YarnSiteConfig;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourcePool",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourcePoolResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateResourcePoolResponse> CreateResourcePoolWithOptionsAsync(CreateResourcePoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Active"] = request.Active;
            query["ClusterId"] = request.ClusterId;
            query["Config"] = request.Config;
            query["Name"] = request.Name;
            query["Note"] = request.Note;
            query["PoolType"] = request.PoolType;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["YarnSiteConfig"] = request.YarnSiteConfig;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourcePool",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourcePoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateResourcePoolResponse CreateResourcePool(CreateResourcePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateResourcePoolWithOptions(request, runtime);
        }

        public async Task<CreateResourcePoolResponse> CreateResourcePoolAsync(CreateResourcePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateResourcePoolWithOptionsAsync(request, runtime);
        }

        public CreateResourceQueueResponse CreateResourceQueueWithOptions(CreateResourceQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Config"] = request.Config;
            query["Leaf"] = request.Leaf;
            query["Name"] = request.Name;
            query["ParentQueueId"] = request.ParentQueueId;
            query["QualifiedName"] = request.QualifiedName;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourcePoolId"] = request.ResourcePoolId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceQueue",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceQueueResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateResourceQueueResponse> CreateResourceQueueWithOptionsAsync(CreateResourceQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Config"] = request.Config;
            query["Leaf"] = request.Leaf;
            query["Name"] = request.Name;
            query["ParentQueueId"] = request.ParentQueueId;
            query["QualifiedName"] = request.QualifiedName;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourcePoolId"] = request.ResourcePoolId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceQueue",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceQueueResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateResourceQueueResponse CreateResourceQueue(CreateResourceQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateResourceQueueWithOptions(request, runtime);
        }

        public async Task<CreateResourceQueueResponse> CreateResourceQueueAsync(CreateResourceQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateResourceQueueWithOptionsAsync(request, runtime);
        }

        public CreateScalingGroupV2Response CreateScalingGroupV2WithOptions(CreateScalingGroupV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["HostGroupId"] = request.HostGroupId;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScalingGroupV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScalingGroupV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<CreateScalingGroupV2Response> CreateScalingGroupV2WithOptionsAsync(CreateScalingGroupV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["HostGroupId"] = request.HostGroupId;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScalingGroupV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScalingGroupV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public CreateScalingGroupV2Response CreateScalingGroupV2(CreateScalingGroupV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScalingGroupV2WithOptions(request, runtime);
        }

        public async Task<CreateScalingGroupV2Response> CreateScalingGroupV2Async(CreateScalingGroupV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScalingGroupV2WithOptionsAsync(request, runtime);
        }

        public CreateScalingRuleResponse CreateScalingRuleWithOptions(CreateScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AdjustmentType"] = request.AdjustmentType;
            query["AdjustmentValue"] = request.AdjustmentValue;
            query["CloudWatchTrigger"] = request.CloudWatchTrigger;
            query["ClusterId"] = request.ClusterId;
            query["Cooldown"] = request.Cooldown;
            query["HostGroupId"] = request.HostGroupId;
            query["LaunchExpirationTime"] = request.LaunchExpirationTime;
            query["LaunchTime"] = request.LaunchTime;
            query["RecurrenceEndTime"] = request.RecurrenceEndTime;
            query["RecurrenceType"] = request.RecurrenceType;
            query["RecurrenceValue"] = request.RecurrenceValue;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RuleCategory"] = request.RuleCategory;
            query["RuleName"] = request.RuleName;
            query["SchedulerTrigger"] = request.SchedulerTrigger;
            query["TimeoutWithGrace"] = request.TimeoutWithGrace;
            query["WithGrace"] = request.WithGrace;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScalingRule",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateScalingRuleResponse> CreateScalingRuleWithOptionsAsync(CreateScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AdjustmentType"] = request.AdjustmentType;
            query["AdjustmentValue"] = request.AdjustmentValue;
            query["CloudWatchTrigger"] = request.CloudWatchTrigger;
            query["ClusterId"] = request.ClusterId;
            query["Cooldown"] = request.Cooldown;
            query["HostGroupId"] = request.HostGroupId;
            query["LaunchExpirationTime"] = request.LaunchExpirationTime;
            query["LaunchTime"] = request.LaunchTime;
            query["RecurrenceEndTime"] = request.RecurrenceEndTime;
            query["RecurrenceType"] = request.RecurrenceType;
            query["RecurrenceValue"] = request.RecurrenceValue;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RuleCategory"] = request.RuleCategory;
            query["RuleName"] = request.RuleName;
            query["SchedulerTrigger"] = request.SchedulerTrigger;
            query["TimeoutWithGrace"] = request.TimeoutWithGrace;
            query["WithGrace"] = request.WithGrace;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScalingRule",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
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

        public CreateTagResponse CreateTagWithOptions(CreateTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Category"] = request.Category;
            query["Description"] = request.Description;
            query["Id"] = request.Id;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTag",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTagResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTagResponse> CreateTagWithOptionsAsync(CreateTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Category"] = request.Category;
            query["Description"] = request.Description;
            query["Id"] = request.Id;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTag",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTagResponse CreateTag(CreateTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTagWithOptions(request, runtime);
        }

        public async Task<CreateTagResponse> CreateTagAsync(CreateTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTagWithOptionsAsync(request, runtime);
        }

        public CreateUserResponse CreateUserWithOptions(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AliyunUserId"] = request.AliyunUserId;
            query["Description"] = request.Description;
            query["GroupIdList"] = request.GroupIdList;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RoleIdList"] = request.RoleIdList;
            query["Status"] = request.Status;
            query["UserAccountParamList"] = request.UserAccountParamList;
            query["UserName"] = request.UserName;
            query["UserType"] = request.UserType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateUserResponse> CreateUserWithOptionsAsync(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AliyunUserId"] = request.AliyunUserId;
            query["Description"] = request.Description;
            query["GroupIdList"] = request.GroupIdList;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RoleIdList"] = request.RoleIdList;
            query["Status"] = request.Status;
            query["UserAccountParamList"] = request.UserAccountParamList;
            query["UserName"] = request.UserName;
            query["UserType"] = request.UserType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
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

        public CreateUsersResponse CreateUsersWithOptions(CreateUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["UserInfo"] = request.UserInfo;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUsers",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUsersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateUsersResponse> CreateUsersWithOptionsAsync(CreateUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["UserInfo"] = request.UserInfo;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUsers",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateUsersResponse CreateUsers(CreateUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUsersWithOptions(request, runtime);
        }

        public async Task<CreateUsersResponse> CreateUsersAsync(CreateUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUsersWithOptionsAsync(request, runtime);
        }

        public DecommissionHostComponentResponse DecommissionHostComponentWithOptions(DecommissionHostComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ComponentName"] = request.ComponentName;
            query["HostInstanceId"] = request.HostInstanceId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            query["TimeoutSeconds"] = request.TimeoutSeconds;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DecommissionHostComponent",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DecommissionHostComponentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DecommissionHostComponentResponse> DecommissionHostComponentWithOptionsAsync(DecommissionHostComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ComponentName"] = request.ComponentName;
            query["HostInstanceId"] = request.HostInstanceId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            query["TimeoutSeconds"] = request.TimeoutSeconds;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DecommissionHostComponent",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DecommissionHostComponentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DecommissionHostComponentResponse DecommissionHostComponent(DecommissionHostComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DecommissionHostComponentWithOptions(request, runtime);
        }

        public async Task<DecommissionHostComponentResponse> DecommissionHostComponentAsync(DecommissionHostComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DecommissionHostComponentWithOptionsAsync(request, runtime);
        }

        public DeleteClusterTemplateResponse DeleteClusterTemplateWithOptions(DeleteClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BizId"] = request.BizId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteClusterTemplate",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClusterTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteClusterTemplateResponse> DeleteClusterTemplateWithOptionsAsync(DeleteClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BizId"] = request.BizId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteClusterTemplate",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClusterTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteClusterTemplateResponse DeleteClusterTemplate(DeleteClusterTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClusterTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteClusterTemplateResponse> DeleteClusterTemplateAsync(DeleteClusterTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClusterTemplateWithOptionsAsync(request, runtime);
        }

        public DeleteExecutionPlanResponse DeleteExecutionPlanWithOptions(DeleteExecutionPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExecutionPlan",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExecutionPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteExecutionPlanResponse> DeleteExecutionPlanWithOptionsAsync(DeleteExecutionPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExecutionPlan",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExecutionPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteExecutionPlanResponse DeleteExecutionPlan(DeleteExecutionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteExecutionPlanWithOptions(request, runtime);
        }

        public async Task<DeleteExecutionPlanResponse> DeleteExecutionPlanAsync(DeleteExecutionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteExecutionPlanWithOptionsAsync(request, runtime);
        }

        public DeleteFlowResponse DeleteFlowWithOptions(DeleteFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlow",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFlowResponse> DeleteFlowWithOptionsAsync(DeleteFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlow",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowResponse>(await CallApiAsync(params_, req, runtime));
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

        public DeleteFlowCategoryResponse DeleteFlowCategoryWithOptions(DeleteFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowCategory",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowCategoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFlowCategoryResponse> DeleteFlowCategoryWithOptionsAsync(DeleteFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowCategory",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFlowCategoryResponse DeleteFlowCategory(DeleteFlowCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowCategoryWithOptions(request, runtime);
        }

        public async Task<DeleteFlowCategoryResponse> DeleteFlowCategoryAsync(DeleteFlowCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowCategoryWithOptionsAsync(request, runtime);
        }

        public DeleteFlowJobResponse DeleteFlowJobWithOptions(DeleteFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFlowJobResponse> DeleteFlowJobWithOptionsAsync(DeleteFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFlowJobResponse DeleteFlowJob(DeleteFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowJobWithOptions(request, runtime);
        }

        public async Task<DeleteFlowJobResponse> DeleteFlowJobAsync(DeleteFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowJobWithOptionsAsync(request, runtime);
        }

        public DeleteFlowProjectResponse DeleteFlowProjectWithOptions(DeleteFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowProject",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFlowProjectResponse> DeleteFlowProjectWithOptionsAsync(DeleteFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowProject",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFlowProjectResponse DeleteFlowProject(DeleteFlowProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowProjectWithOptions(request, runtime);
        }

        public async Task<DeleteFlowProjectResponse> DeleteFlowProjectAsync(DeleteFlowProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowProjectWithOptionsAsync(request, runtime);
        }

        public DeleteFlowProjectClusterSettingResponse DeleteFlowProjectClusterSettingWithOptions(DeleteFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowProjectClusterSetting",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowProjectClusterSettingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFlowProjectClusterSettingResponse> DeleteFlowProjectClusterSettingWithOptionsAsync(DeleteFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowProjectClusterSetting",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowProjectClusterSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFlowProjectClusterSettingResponse DeleteFlowProjectClusterSetting(DeleteFlowProjectClusterSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowProjectClusterSettingWithOptions(request, runtime);
        }

        public async Task<DeleteFlowProjectClusterSettingResponse> DeleteFlowProjectClusterSettingAsync(DeleteFlowProjectClusterSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowProjectClusterSettingWithOptionsAsync(request, runtime);
        }

        public DeleteFlowProjectUserResponse DeleteFlowProjectUserWithOptions(DeleteFlowProjectUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["UserName"] = request.UserName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowProjectUser",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowProjectUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFlowProjectUserResponse> DeleteFlowProjectUserWithOptionsAsync(DeleteFlowProjectUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["UserName"] = request.UserName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowProjectUser",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowProjectUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFlowProjectUserResponse DeleteFlowProjectUser(DeleteFlowProjectUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowProjectUserWithOptions(request, runtime);
        }

        public async Task<DeleteFlowProjectUserResponse> DeleteFlowProjectUserAsync(DeleteFlowProjectUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowProjectUserWithOptionsAsync(request, runtime);
        }

        public DeleteJobResponse DeleteJobWithOptions(DeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteJobResponse> DeleteJobWithOptionsAsync(DeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteJobResponse DeleteJob(DeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteJobWithOptions(request, runtime);
        }

        public async Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteJobWithOptionsAsync(request, runtime);
        }

        public DeleteLibrariesResponse DeleteLibrariesWithOptions(DeleteLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["LibraryBizIdList"] = request.LibraryBizIdList;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLibraries",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLibrariesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteLibrariesResponse> DeleteLibrariesWithOptionsAsync(DeleteLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["LibraryBizIdList"] = request.LibraryBizIdList;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLibraries",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLibrariesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteLibrariesResponse DeleteLibraries(DeleteLibrariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLibrariesWithOptions(request, runtime);
        }

        public async Task<DeleteLibrariesResponse> DeleteLibrariesAsync(DeleteLibrariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLibrariesWithOptionsAsync(request, runtime);
        }

        public DeleteResourcePoolResponse DeleteResourcePoolWithOptions(DeleteResourcePoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourcePoolId"] = request.ResourcePoolId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourcePool",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourcePoolResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteResourcePoolResponse> DeleteResourcePoolWithOptionsAsync(DeleteResourcePoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourcePoolId"] = request.ResourcePoolId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourcePool",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourcePoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteResourcePoolResponse DeleteResourcePool(DeleteResourcePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteResourcePoolWithOptions(request, runtime);
        }

        public async Task<DeleteResourcePoolResponse> DeleteResourcePoolAsync(DeleteResourcePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteResourcePoolWithOptionsAsync(request, runtime);
        }

        public DeleteResourceQueueResponse DeleteResourceQueueWithOptions(DeleteResourceQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceQueueId"] = request.ResourceQueueId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceQueue",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceQueueResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteResourceQueueResponse> DeleteResourceQueueWithOptionsAsync(DeleteResourceQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceQueueId"] = request.ResourceQueueId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceQueue",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceQueueResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteResourceQueueResponse DeleteResourceQueue(DeleteResourceQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteResourceQueueWithOptions(request, runtime);
        }

        public async Task<DeleteResourceQueueResponse> DeleteResourceQueueAsync(DeleteResourceQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteResourceQueueWithOptionsAsync(request, runtime);
        }

        public DeleteScalingRuleResponse DeleteScalingRuleWithOptions(DeleteScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["HostGroupId"] = request.HostGroupId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingRuleId"] = request.ScalingRuleId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScalingRule",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteScalingRuleResponse> DeleteScalingRuleWithOptionsAsync(DeleteScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["HostGroupId"] = request.HostGroupId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingRuleId"] = request.ScalingRuleId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScalingRule",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
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

        public DeleteTagResponse DeleteTagWithOptions(DeleteTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Category"] = request.Category;
            query["Description"] = request.Description;
            query["Id"] = request.Id;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTag",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTagResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTagResponse> DeleteTagWithOptionsAsync(DeleteTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Category"] = request.Category;
            query["Description"] = request.Description;
            query["Id"] = request.Id;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTag",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTagResponse DeleteTag(DeleteTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTagWithOptions(request, runtime);
        }

        public async Task<DeleteTagResponse> DeleteTagAsync(DeleteTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTagWithOptionsAsync(request, runtime);
        }

        public DeleteUserResponse DeleteUserWithOptions(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Type"] = request.Type;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteUserResponse> DeleteUserWithOptionsAsync(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Type"] = request.Type;
            query["UserId"] = request.UserId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserWithOptions(request, runtime);
        }

        public async Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserWithOptionsAsync(request, runtime);
        }

        public DescribeClusterBasicInfoResponse DescribeClusterBasicInfoWithOptions(DescribeClusterBasicInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterBasicInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterBasicInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterBasicInfoResponse> DescribeClusterBasicInfoWithOptionsAsync(DescribeClusterBasicInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterBasicInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterBasicInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterBasicInfoResponse DescribeClusterBasicInfo(DescribeClusterBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterBasicInfoWithOptions(request, runtime);
        }

        public async Task<DescribeClusterBasicInfoResponse> DescribeClusterBasicInfoAsync(DescribeClusterBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterBasicInfoWithOptionsAsync(request, runtime);
        }

        public DescribeClusterMetaCollectResponse DescribeClusterMetaCollectWithOptions(DescribeClusterMetaCollectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterMetaCollect",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterMetaCollectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterMetaCollectResponse> DescribeClusterMetaCollectWithOptionsAsync(DescribeClusterMetaCollectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterMetaCollect",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterMetaCollectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterMetaCollectResponse DescribeClusterMetaCollect(DescribeClusterMetaCollectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterMetaCollectWithOptions(request, runtime);
        }

        public async Task<DescribeClusterMetaCollectResponse> DescribeClusterMetaCollectAsync(DescribeClusterMetaCollectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterMetaCollectWithOptionsAsync(request, runtime);
        }

        public DescribeClusterOperationHostTaskLogResponse DescribeClusterOperationHostTaskLogWithOptions(DescribeClusterOperationHostTaskLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["HostId"] = request.HostId;
            query["OperationId"] = request.OperationId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Status"] = request.Status;
            query["TaskId"] = request.TaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterOperationHostTaskLog",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterOperationHostTaskLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterOperationHostTaskLogResponse> DescribeClusterOperationHostTaskLogWithOptionsAsync(DescribeClusterOperationHostTaskLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["HostId"] = request.HostId;
            query["OperationId"] = request.OperationId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Status"] = request.Status;
            query["TaskId"] = request.TaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterOperationHostTaskLog",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterOperationHostTaskLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterOperationHostTaskLogResponse DescribeClusterOperationHostTaskLog(DescribeClusterOperationHostTaskLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterOperationHostTaskLogWithOptions(request, runtime);
        }

        public async Task<DescribeClusterOperationHostTaskLogResponse> DescribeClusterOperationHostTaskLogAsync(DescribeClusterOperationHostTaskLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterOperationHostTaskLogWithOptionsAsync(request, runtime);
        }

        public DescribeClusterResourcePoolSchedulerTypeResponse DescribeClusterResourcePoolSchedulerTypeWithOptions(DescribeClusterResourcePoolSchedulerTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterResourcePoolSchedulerType",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterResourcePoolSchedulerTypeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterResourcePoolSchedulerTypeResponse> DescribeClusterResourcePoolSchedulerTypeWithOptionsAsync(DescribeClusterResourcePoolSchedulerTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterResourcePoolSchedulerType",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterResourcePoolSchedulerTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterResourcePoolSchedulerTypeResponse DescribeClusterResourcePoolSchedulerType(DescribeClusterResourcePoolSchedulerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterResourcePoolSchedulerTypeWithOptions(request, runtime);
        }

        public async Task<DescribeClusterResourcePoolSchedulerTypeResponse> DescribeClusterResourcePoolSchedulerTypeAsync(DescribeClusterResourcePoolSchedulerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterResourcePoolSchedulerTypeWithOptionsAsync(request, runtime);
        }

        public DescribeClusterServiceResponse DescribeClusterServiceWithOptions(DescribeClusterServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterService",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterServiceResponse> DescribeClusterServiceWithOptionsAsync(DescribeClusterServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterService",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterServiceResponse DescribeClusterService(DescribeClusterServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterServiceWithOptions(request, runtime);
        }

        public async Task<DescribeClusterServiceResponse> DescribeClusterServiceAsync(DescribeClusterServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterServiceWithOptionsAsync(request, runtime);
        }

        public DescribeClusterServiceConfigResponse DescribeClusterServiceConfigWithOptions(DescribeClusterServiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ConfigVersion"] = request.ConfigVersion;
            query["GroupId"] = request.GroupId;
            query["HostInstanceId"] = request.HostInstanceId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            query["TagValue"] = request.TagValue;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterServiceConfig",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterServiceConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterServiceConfigResponse> DescribeClusterServiceConfigWithOptionsAsync(DescribeClusterServiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ConfigVersion"] = request.ConfigVersion;
            query["GroupId"] = request.GroupId;
            query["HostInstanceId"] = request.HostInstanceId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            query["TagValue"] = request.TagValue;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterServiceConfig",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterServiceConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterServiceConfigResponse DescribeClusterServiceConfig(DescribeClusterServiceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterServiceConfigWithOptions(request, runtime);
        }

        public async Task<DescribeClusterServiceConfigResponse> DescribeClusterServiceConfigAsync(DescribeClusterServiceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterServiceConfigWithOptionsAsync(request, runtime);
        }

        public DescribeClusterServiceConfigHistoryResponse DescribeClusterServiceConfigHistoryWithOptions(DescribeClusterServiceConfigHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ConfigVersion"] = request.ConfigVersion;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterServiceConfigHistory",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterServiceConfigHistoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterServiceConfigHistoryResponse> DescribeClusterServiceConfigHistoryWithOptionsAsync(DescribeClusterServiceConfigHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ConfigVersion"] = request.ConfigVersion;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterServiceConfigHistory",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterServiceConfigHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterServiceConfigHistoryResponse DescribeClusterServiceConfigHistory(DescribeClusterServiceConfigHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterServiceConfigHistoryWithOptions(request, runtime);
        }

        public async Task<DescribeClusterServiceConfigHistoryResponse> DescribeClusterServiceConfigHistoryAsync(DescribeClusterServiceConfigHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterServiceConfigHistoryWithOptionsAsync(request, runtime);
        }

        public DescribeClusterServiceConfigTagResponse DescribeClusterServiceConfigTagWithOptions(DescribeClusterServiceConfigTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ConfigTag"] = request.ConfigTag;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterServiceConfigTag",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterServiceConfigTagResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterServiceConfigTagResponse> DescribeClusterServiceConfigTagWithOptionsAsync(DescribeClusterServiceConfigTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ConfigTag"] = request.ConfigTag;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterServiceConfigTag",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterServiceConfigTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterServiceConfigTagResponse DescribeClusterServiceConfigTag(DescribeClusterServiceConfigTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterServiceConfigTagWithOptions(request, runtime);
        }

        public async Task<DescribeClusterServiceConfigTagResponse> DescribeClusterServiceConfigTagAsync(DescribeClusterServiceConfigTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterServiceConfigTagWithOptionsAsync(request, runtime);
        }

        public DescribeClusterTemplateResponse DescribeClusterTemplateWithOptions(DescribeClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BizId"] = request.BizId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterTemplate",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterTemplateResponse> DescribeClusterTemplateWithOptionsAsync(DescribeClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BizId"] = request.BizId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterTemplate",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterTemplateResponse DescribeClusterTemplate(DescribeClusterTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterTemplateWithOptions(request, runtime);
        }

        public async Task<DescribeClusterTemplateResponse> DescribeClusterTemplateAsync(DescribeClusterTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterTemplateWithOptionsAsync(request, runtime);
        }

        public DescribeClusterV2Response DescribeClusterV2WithOptions(DescribeClusterV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterV2Response> DescribeClusterV2WithOptionsAsync(DescribeClusterV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterV2Response DescribeClusterV2(DescribeClusterV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterV2WithOptions(request, runtime);
        }

        public async Task<DescribeClusterV2Response> DescribeClusterV2Async(DescribeClusterV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterV2WithOptionsAsync(request, runtime);
        }

        public DescribeDataSourceResponse DescribeDataSourceWithOptions(DescribeDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataSource",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataSourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDataSourceResponse> DescribeDataSourceWithOptionsAsync(DescribeDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataSource",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDataSourceResponse DescribeDataSource(DescribeDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataSourceWithOptions(request, runtime);
        }

        public async Task<DescribeDataSourceResponse> DescribeDataSourceAsync(DescribeDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataSourceWithOptionsAsync(request, runtime);
        }

        public DescribeDiskOpsActivityResponse DescribeDiskOpsActivityWithOptions(DescribeDiskOpsActivityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["CurrentStage"] = request.CurrentStage;
            query["CurrentState"] = request.CurrentState;
            query["DiskId"] = request.DiskId;
            query["EventId"] = request.EventId;
            query["InstanceId"] = request.InstanceId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiskOpsActivity",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiskOpsActivityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDiskOpsActivityResponse> DescribeDiskOpsActivityWithOptionsAsync(DescribeDiskOpsActivityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["CurrentStage"] = request.CurrentStage;
            query["CurrentState"] = request.CurrentState;
            query["DiskId"] = request.DiskId;
            query["EventId"] = request.EventId;
            query["InstanceId"] = request.InstanceId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiskOpsActivity",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiskOpsActivityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDiskOpsActivityResponse DescribeDiskOpsActivity(DescribeDiskOpsActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDiskOpsActivityWithOptions(request, runtime);
        }

        public async Task<DescribeDiskOpsActivityResponse> DescribeDiskOpsActivityAsync(DescribeDiskOpsActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDiskOpsActivityWithOptionsAsync(request, runtime);
        }

        public DescribeEmrMainVersionResponse DescribeEmrMainVersionWithOptions(DescribeEmrMainVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EmrVersion"] = request.EmrVersion;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEmrMainVersion",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEmrMainVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeEmrMainVersionResponse> DescribeEmrMainVersionWithOptionsAsync(DescribeEmrMainVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EmrVersion"] = request.EmrVersion;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEmrMainVersion",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEmrMainVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeEmrMainVersionResponse DescribeEmrMainVersion(DescribeEmrMainVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEmrMainVersionWithOptions(request, runtime);
        }

        public async Task<DescribeEmrMainVersionResponse> DescribeEmrMainVersionAsync(DescribeEmrMainVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEmrMainVersionWithOptionsAsync(request, runtime);
        }

        public DescribeExecutionPlanResponse DescribeExecutionPlanWithOptions(DescribeExecutionPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExecutionPlan",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExecutionPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeExecutionPlanResponse> DescribeExecutionPlanWithOptionsAsync(DescribeExecutionPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExecutionPlan",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExecutionPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeExecutionPlanResponse DescribeExecutionPlan(DescribeExecutionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExecutionPlanWithOptions(request, runtime);
        }

        public async Task<DescribeExecutionPlanResponse> DescribeExecutionPlanAsync(DescribeExecutionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExecutionPlanWithOptionsAsync(request, runtime);
        }

        public DescribeFlowResponse DescribeFlowWithOptions(DescribeFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlow",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeFlowResponse> DescribeFlowWithOptionsAsync(DescribeFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlow",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowResponse>(await CallApiAsync(params_, req, runtime));
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

        public DescribeFlowCategoryResponse DescribeFlowCategoryWithOptions(DescribeFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowCategory",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowCategoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeFlowCategoryResponse> DescribeFlowCategoryWithOptionsAsync(DescribeFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowCategory",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeFlowCategoryResponse DescribeFlowCategory(DescribeFlowCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowCategoryWithOptions(request, runtime);
        }

        public async Task<DescribeFlowCategoryResponse> DescribeFlowCategoryAsync(DescribeFlowCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowCategoryWithOptionsAsync(request, runtime);
        }

        public DescribeFlowCategoryTreeResponse DescribeFlowCategoryTreeWithOptions(DescribeFlowCategoryTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CategoryId"] = request.CategoryId;
            query["Keyword"] = request.Keyword;
            query["Mode"] = request.Mode;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowCategoryTree",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowCategoryTreeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeFlowCategoryTreeResponse> DescribeFlowCategoryTreeWithOptionsAsync(DescribeFlowCategoryTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CategoryId"] = request.CategoryId;
            query["Keyword"] = request.Keyword;
            query["Mode"] = request.Mode;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowCategoryTree",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowCategoryTreeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeFlowCategoryTreeResponse DescribeFlowCategoryTree(DescribeFlowCategoryTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowCategoryTreeWithOptions(request, runtime);
        }

        public async Task<DescribeFlowCategoryTreeResponse> DescribeFlowCategoryTreeAsync(DescribeFlowCategoryTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowCategoryTreeWithOptionsAsync(request, runtime);
        }

        public DescribeFlowInstanceResponse DescribeFlowInstanceWithOptions(DescribeFlowInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowInstance",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeFlowInstanceResponse> DescribeFlowInstanceWithOptionsAsync(DescribeFlowInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowInstance",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeFlowInstanceResponse DescribeFlowInstance(DescribeFlowInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeFlowInstanceResponse> DescribeFlowInstanceAsync(DescribeFlowInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeFlowJobResponse DescribeFlowJobWithOptions(DescribeFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeFlowJobResponse> DescribeFlowJobWithOptionsAsync(DescribeFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeFlowJobResponse DescribeFlowJob(DescribeFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowJobWithOptions(request, runtime);
        }

        public async Task<DescribeFlowJobResponse> DescribeFlowJobAsync(DescribeFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowJobWithOptionsAsync(request, runtime);
        }

        public DescribeFlowNodeInstanceResponse DescribeFlowNodeInstanceWithOptions(DescribeFlowNodeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowNodeInstance",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowNodeInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeFlowNodeInstanceResponse> DescribeFlowNodeInstanceWithOptionsAsync(DescribeFlowNodeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowNodeInstance",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowNodeInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeFlowNodeInstanceResponse DescribeFlowNodeInstance(DescribeFlowNodeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowNodeInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeFlowNodeInstanceResponse> DescribeFlowNodeInstanceAsync(DescribeFlowNodeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowNodeInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeFlowNodeInstanceContainerLogResponse DescribeFlowNodeInstanceContainerLogWithOptions(DescribeFlowNodeInstanceContainerLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["ContainerId"] = request.ContainerId;
            query["Length"] = request.Length;
            query["LogName"] = request.LogName;
            query["NodeInstanceId"] = request.NodeInstanceId;
            query["Offset"] = request.Offset;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowNodeInstanceContainerLog",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowNodeInstanceContainerLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeFlowNodeInstanceContainerLogResponse> DescribeFlowNodeInstanceContainerLogWithOptionsAsync(DescribeFlowNodeInstanceContainerLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["ContainerId"] = request.ContainerId;
            query["Length"] = request.Length;
            query["LogName"] = request.LogName;
            query["NodeInstanceId"] = request.NodeInstanceId;
            query["Offset"] = request.Offset;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowNodeInstanceContainerLog",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowNodeInstanceContainerLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeFlowNodeInstanceContainerLogResponse DescribeFlowNodeInstanceContainerLog(DescribeFlowNodeInstanceContainerLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowNodeInstanceContainerLogWithOptions(request, runtime);
        }

        public async Task<DescribeFlowNodeInstanceContainerLogResponse> DescribeFlowNodeInstanceContainerLogAsync(DescribeFlowNodeInstanceContainerLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowNodeInstanceContainerLogWithOptionsAsync(request, runtime);
        }

        public DescribeFlowNodeInstanceLauncherLogResponse DescribeFlowNodeInstanceLauncherLogWithOptions(DescribeFlowNodeInstanceLauncherLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["Length"] = request.Length;
            query["Lines"] = request.Lines;
            query["NodeInstanceId"] = request.NodeInstanceId;
            query["Offset"] = request.Offset;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["Reverse"] = request.Reverse;
            query["Start"] = request.Start;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowNodeInstanceLauncherLog",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowNodeInstanceLauncherLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeFlowNodeInstanceLauncherLogResponse> DescribeFlowNodeInstanceLauncherLogWithOptionsAsync(DescribeFlowNodeInstanceLauncherLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["Length"] = request.Length;
            query["Lines"] = request.Lines;
            query["NodeInstanceId"] = request.NodeInstanceId;
            query["Offset"] = request.Offset;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["Reverse"] = request.Reverse;
            query["Start"] = request.Start;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowNodeInstanceLauncherLog",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowNodeInstanceLauncherLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeFlowNodeInstanceLauncherLogResponse DescribeFlowNodeInstanceLauncherLog(DescribeFlowNodeInstanceLauncherLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowNodeInstanceLauncherLogWithOptions(request, runtime);
        }

        public async Task<DescribeFlowNodeInstanceLauncherLogResponse> DescribeFlowNodeInstanceLauncherLogAsync(DescribeFlowNodeInstanceLauncherLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowNodeInstanceLauncherLogWithOptionsAsync(request, runtime);
        }

        public DescribeFlowProjectResponse DescribeFlowProjectWithOptions(DescribeFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowProject",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeFlowProjectResponse> DescribeFlowProjectWithOptionsAsync(DescribeFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowProject",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeFlowProjectResponse DescribeFlowProject(DescribeFlowProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowProjectWithOptions(request, runtime);
        }

        public async Task<DescribeFlowProjectResponse> DescribeFlowProjectAsync(DescribeFlowProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowProjectWithOptionsAsync(request, runtime);
        }

        public DescribeFlowProjectClusterSettingResponse DescribeFlowProjectClusterSettingWithOptions(DescribeFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowProjectClusterSetting",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowProjectClusterSettingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeFlowProjectClusterSettingResponse> DescribeFlowProjectClusterSettingWithOptionsAsync(DescribeFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowProjectClusterSetting",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowProjectClusterSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeFlowProjectClusterSettingResponse DescribeFlowProjectClusterSetting(DescribeFlowProjectClusterSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowProjectClusterSettingWithOptions(request, runtime);
        }

        public async Task<DescribeFlowProjectClusterSettingResponse> DescribeFlowProjectClusterSettingAsync(DescribeFlowProjectClusterSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowProjectClusterSettingWithOptionsAsync(request, runtime);
        }

        public DescribeJobResponse DescribeJobWithOptions(DescribeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeJobResponse> DescribeJobWithOptionsAsync(DescribeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeJobResponse DescribeJob(DescribeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeJobWithOptions(request, runtime);
        }

        public async Task<DescribeJobResponse> DescribeJobAsync(DescribeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeJobWithOptionsAsync(request, runtime);
        }

        public DescribeLibraryDetailResponse DescribeLibraryDetailWithOptions(DescribeLibraryDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["LibraryBizId"] = request.LibraryBizId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLibraryDetail",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLibraryDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeLibraryDetailResponse> DescribeLibraryDetailWithOptionsAsync(DescribeLibraryDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["LibraryBizId"] = request.LibraryBizId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLibraryDetail",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLibraryDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeLibraryDetailResponse DescribeLibraryDetail(DescribeLibraryDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLibraryDetailWithOptions(request, runtime);
        }

        public async Task<DescribeLibraryDetailResponse> DescribeLibraryDetailAsync(DescribeLibraryDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLibraryDetailWithOptionsAsync(request, runtime);
        }

        public DescribeLibraryInstallTaskDetailResponse DescribeLibraryInstallTaskDetailWithOptions(DescribeLibraryInstallTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TaskBizId"] = request.TaskBizId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLibraryInstallTaskDetail",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLibraryInstallTaskDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeLibraryInstallTaskDetailResponse> DescribeLibraryInstallTaskDetailWithOptionsAsync(DescribeLibraryInstallTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TaskBizId"] = request.TaskBizId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLibraryInstallTaskDetail",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLibraryInstallTaskDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeLibraryInstallTaskDetailResponse DescribeLibraryInstallTaskDetail(DescribeLibraryInstallTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLibraryInstallTaskDetailWithOptions(request, runtime);
        }

        public async Task<DescribeLibraryInstallTaskDetailResponse> DescribeLibraryInstallTaskDetailAsync(DescribeLibraryInstallTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLibraryInstallTaskDetailWithOptionsAsync(request, runtime);
        }

        public DescribeMetaTablePreviewTaskResponse DescribeMetaTablePreviewTaskWithOptions(DescribeMetaTablePreviewTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TaskId"] = request.TaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMetaTablePreviewTask",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetaTablePreviewTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMetaTablePreviewTaskResponse> DescribeMetaTablePreviewTaskWithOptionsAsync(DescribeMetaTablePreviewTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TaskId"] = request.TaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMetaTablePreviewTask",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetaTablePreviewTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMetaTablePreviewTaskResponse DescribeMetaTablePreviewTask(DescribeMetaTablePreviewTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetaTablePreviewTaskWithOptions(request, runtime);
        }

        public async Task<DescribeMetaTablePreviewTaskResponse> DescribeMetaTablePreviewTaskAsync(DescribeMetaTablePreviewTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetaTablePreviewTaskWithOptionsAsync(request, runtime);
        }

        public DescribeScalingActivityResponse DescribeScalingActivityWithOptions(DescribeScalingActivityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["HostGroupId"] = request.HostGroupId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingActivityId"] = request.ScalingActivityId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingActivity",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingActivityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeScalingActivityResponse> DescribeScalingActivityWithOptionsAsync(DescribeScalingActivityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["HostGroupId"] = request.HostGroupId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingActivityId"] = request.ScalingActivityId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingActivity",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingActivityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeScalingActivityResponse DescribeScalingActivity(DescribeScalingActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingActivityWithOptions(request, runtime);
        }

        public async Task<DescribeScalingActivityResponse> DescribeScalingActivityAsync(DescribeScalingActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingActivityWithOptionsAsync(request, runtime);
        }

        public DescribeScalingCommonConfigResponse DescribeScalingCommonConfigWithOptions(DescribeScalingCommonConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingCommonConfig",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingCommonConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeScalingCommonConfigResponse> DescribeScalingCommonConfigWithOptionsAsync(DescribeScalingCommonConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingCommonConfig",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingCommonConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeScalingCommonConfigResponse DescribeScalingCommonConfig(DescribeScalingCommonConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingCommonConfigWithOptions(request, runtime);
        }

        public async Task<DescribeScalingCommonConfigResponse> DescribeScalingCommonConfigAsync(DescribeScalingCommonConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingCommonConfigWithOptionsAsync(request, runtime);
        }

        public DescribeScalingConfigItemV2Response DescribeScalingConfigItemV2WithOptions(DescribeScalingConfigItemV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ConfigItemType"] = request.ConfigItemType;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingConfigItemId"] = request.ScalingConfigItemId;
            query["ScalingGroupBizId"] = request.ScalingGroupBizId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingConfigItemV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingConfigItemV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeScalingConfigItemV2Response> DescribeScalingConfigItemV2WithOptionsAsync(DescribeScalingConfigItemV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ConfigItemType"] = request.ConfigItemType;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingConfigItemId"] = request.ScalingConfigItemId;
            query["ScalingGroupBizId"] = request.ScalingGroupBizId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingConfigItemV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingConfigItemV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeScalingConfigItemV2Response DescribeScalingConfigItemV2(DescribeScalingConfigItemV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingConfigItemV2WithOptions(request, runtime);
        }

        public async Task<DescribeScalingConfigItemV2Response> DescribeScalingConfigItemV2Async(DescribeScalingConfigItemV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingConfigItemV2WithOptionsAsync(request, runtime);
        }

        public DescribeScalingGroupInstanceV2Response DescribeScalingGroupInstanceV2WithOptions(DescribeScalingGroupInstanceV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["HostGroupBizId"] = request.HostGroupBizId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingGroupBizId"] = request.ScalingGroupBizId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingGroupInstanceV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingGroupInstanceV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeScalingGroupInstanceV2Response> DescribeScalingGroupInstanceV2WithOptionsAsync(DescribeScalingGroupInstanceV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["HostGroupBizId"] = request.HostGroupBizId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingGroupBizId"] = request.ScalingGroupBizId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingGroupInstanceV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingGroupInstanceV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeScalingGroupInstanceV2Response DescribeScalingGroupInstanceV2(DescribeScalingGroupInstanceV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingGroupInstanceV2WithOptions(request, runtime);
        }

        public async Task<DescribeScalingGroupInstanceV2Response> DescribeScalingGroupInstanceV2Async(DescribeScalingGroupInstanceV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingGroupInstanceV2WithOptionsAsync(request, runtime);
        }

        public DescribeScalingGroupV2Response DescribeScalingGroupV2WithOptions(DescribeScalingGroupV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["HostGroupBizId"] = request.HostGroupBizId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingGroupBizId"] = request.ScalingGroupBizId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingGroupV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingGroupV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeScalingGroupV2Response> DescribeScalingGroupV2WithOptionsAsync(DescribeScalingGroupV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["HostGroupBizId"] = request.HostGroupBizId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingGroupBizId"] = request.ScalingGroupBizId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingGroupV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingGroupV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeScalingGroupV2Response DescribeScalingGroupV2(DescribeScalingGroupV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingGroupV2WithOptions(request, runtime);
        }

        public async Task<DescribeScalingGroupV2Response> DescribeScalingGroupV2Async(DescribeScalingGroupV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingGroupV2WithOptionsAsync(request, runtime);
        }

        public DescribeScalingRuleResponse DescribeScalingRuleWithOptions(DescribeScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["HostGroupId"] = request.HostGroupId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingRuleId"] = request.ScalingRuleId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingRule",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeScalingRuleResponse> DescribeScalingRuleWithOptionsAsync(DescribeScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["HostGroupId"] = request.HostGroupId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingRuleId"] = request.ScalingRuleId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingRule",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeScalingRuleResponse DescribeScalingRule(DescribeScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingRuleWithOptions(request, runtime);
        }

        public async Task<DescribeScalingRuleResponse> DescribeScalingRuleAsync(DescribeScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingRuleWithOptionsAsync(request, runtime);
        }

        public DescribeSecurityGroupAttributeResponse DescribeSecurityGroupAttributeWithOptions(DescribeSecurityGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecurityGroupAttribute",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecurityGroupAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSecurityGroupAttributeResponse> DescribeSecurityGroupAttributeWithOptionsAsync(DescribeSecurityGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecurityGroupAttribute",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecurityGroupAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSecurityGroupAttributeResponse DescribeSecurityGroupAttribute(DescribeSecurityGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityGroupAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeSecurityGroupAttributeResponse> DescribeSecurityGroupAttributeAsync(DescribeSecurityGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityGroupAttributeWithOptionsAsync(request, runtime);
        }

        public DetachAndReleaseClusterEniResponse DetachAndReleaseClusterEniWithOptions(DetachAndReleaseClusterEniRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TargetClusterId"] = request.TargetClusterId;
            query["VswitchId"] = request.VswitchId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachAndReleaseClusterEni",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachAndReleaseClusterEniResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetachAndReleaseClusterEniResponse> DetachAndReleaseClusterEniWithOptionsAsync(DetachAndReleaseClusterEniRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TargetClusterId"] = request.TargetClusterId;
            query["VswitchId"] = request.VswitchId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachAndReleaseClusterEni",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachAndReleaseClusterEniResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DetachAndReleaseClusterEniResponse DetachAndReleaseClusterEni(DetachAndReleaseClusterEniRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachAndReleaseClusterEniWithOptions(request, runtime);
        }

        public async Task<DetachAndReleaseClusterEniResponse> DetachAndReleaseClusterEniAsync(DetachAndReleaseClusterEniRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachAndReleaseClusterEniWithOptionsAsync(request, runtime);
        }

        public GetHdfsCapacityStatisticInfoResponse GetHdfsCapacityStatisticInfoWithOptions(GetHdfsCapacityStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["FromDatetime"] = request.FromDatetime;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ToDatetime"] = request.ToDatetime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHdfsCapacityStatisticInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHdfsCapacityStatisticInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetHdfsCapacityStatisticInfoResponse> GetHdfsCapacityStatisticInfoWithOptionsAsync(GetHdfsCapacityStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["FromDatetime"] = request.FromDatetime;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ToDatetime"] = request.ToDatetime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHdfsCapacityStatisticInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHdfsCapacityStatisticInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetHdfsCapacityStatisticInfoResponse GetHdfsCapacityStatisticInfo(GetHdfsCapacityStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHdfsCapacityStatisticInfoWithOptions(request, runtime);
        }

        public async Task<GetHdfsCapacityStatisticInfoResponse> GetHdfsCapacityStatisticInfoAsync(GetHdfsCapacityStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHdfsCapacityStatisticInfoWithOptionsAsync(request, runtime);
        }

        public GetJobInputStatisticInfoResponse GetJobInputStatisticInfoWithOptions(GetJobInputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["FromDatetime"] = request.FromDatetime;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ToDatetime"] = request.ToDatetime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobInputStatisticInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobInputStatisticInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetJobInputStatisticInfoResponse> GetJobInputStatisticInfoWithOptionsAsync(GetJobInputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["FromDatetime"] = request.FromDatetime;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ToDatetime"] = request.ToDatetime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobInputStatisticInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobInputStatisticInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetJobInputStatisticInfoResponse GetJobInputStatisticInfo(GetJobInputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobInputStatisticInfoWithOptions(request, runtime);
        }

        public async Task<GetJobInputStatisticInfoResponse> GetJobInputStatisticInfoAsync(GetJobInputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobInputStatisticInfoWithOptionsAsync(request, runtime);
        }

        public GetJobOutputStatisticInfoResponse GetJobOutputStatisticInfoWithOptions(GetJobOutputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["FromDatetime"] = request.FromDatetime;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ToDatetime"] = request.ToDatetime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobOutputStatisticInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobOutputStatisticInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetJobOutputStatisticInfoResponse> GetJobOutputStatisticInfoWithOptionsAsync(GetJobOutputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["FromDatetime"] = request.FromDatetime;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ToDatetime"] = request.ToDatetime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobOutputStatisticInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobOutputStatisticInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetJobOutputStatisticInfoResponse GetJobOutputStatisticInfo(GetJobOutputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobOutputStatisticInfoWithOptions(request, runtime);
        }

        public async Task<GetJobOutputStatisticInfoResponse> GetJobOutputStatisticInfoAsync(GetJobOutputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobOutputStatisticInfoWithOptionsAsync(request, runtime);
        }

        public GetJobRunningTimeStatisticInfoResponse GetJobRunningTimeStatisticInfoWithOptions(GetJobRunningTimeStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["FromDatetime"] = request.FromDatetime;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ToDatetime"] = request.ToDatetime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobRunningTimeStatisticInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobRunningTimeStatisticInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetJobRunningTimeStatisticInfoResponse> GetJobRunningTimeStatisticInfoWithOptionsAsync(GetJobRunningTimeStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["FromDatetime"] = request.FromDatetime;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ToDatetime"] = request.ToDatetime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobRunningTimeStatisticInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobRunningTimeStatisticInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetJobRunningTimeStatisticInfoResponse GetJobRunningTimeStatisticInfo(GetJobRunningTimeStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobRunningTimeStatisticInfoWithOptions(request, runtime);
        }

        public async Task<GetJobRunningTimeStatisticInfoResponse> GetJobRunningTimeStatisticInfoAsync(GetJobRunningTimeStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobRunningTimeStatisticInfoWithOptionsAsync(request, runtime);
        }

        public GetQueueInputStatisticInfoResponse GetQueueInputStatisticInfoWithOptions(GetQueueInputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["FromDatetime"] = request.FromDatetime;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ToDatetime"] = request.ToDatetime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueueInputStatisticInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueueInputStatisticInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetQueueInputStatisticInfoResponse> GetQueueInputStatisticInfoWithOptionsAsync(GetQueueInputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["FromDatetime"] = request.FromDatetime;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ToDatetime"] = request.ToDatetime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueueInputStatisticInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueueInputStatisticInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetQueueInputStatisticInfoResponse GetQueueInputStatisticInfo(GetQueueInputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueueInputStatisticInfoWithOptions(request, runtime);
        }

        public async Task<GetQueueInputStatisticInfoResponse> GetQueueInputStatisticInfoAsync(GetQueueInputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueueInputStatisticInfoWithOptionsAsync(request, runtime);
        }

        public GetQueueOutputStatisticInfoResponse GetQueueOutputStatisticInfoWithOptions(GetQueueOutputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["FromDatetime"] = request.FromDatetime;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ToDatetime"] = request.ToDatetime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueueOutputStatisticInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueueOutputStatisticInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetQueueOutputStatisticInfoResponse> GetQueueOutputStatisticInfoWithOptionsAsync(GetQueueOutputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["FromDatetime"] = request.FromDatetime;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ToDatetime"] = request.ToDatetime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueueOutputStatisticInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueueOutputStatisticInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetQueueOutputStatisticInfoResponse GetQueueOutputStatisticInfo(GetQueueOutputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueueOutputStatisticInfoWithOptions(request, runtime);
        }

        public async Task<GetQueueOutputStatisticInfoResponse> GetQueueOutputStatisticInfoAsync(GetQueueOutputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueueOutputStatisticInfoWithOptionsAsync(request, runtime);
        }

        public GetQueueSubmissionStatisticInfoResponse GetQueueSubmissionStatisticInfoWithOptions(GetQueueSubmissionStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ApplicationType"] = request.ApplicationType;
            query["ClusterId"] = request.ClusterId;
            query["FinalStatus"] = request.FinalStatus;
            query["FromDatetime"] = request.FromDatetime;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ToDatetime"] = request.ToDatetime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueueSubmissionStatisticInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueueSubmissionStatisticInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetQueueSubmissionStatisticInfoResponse> GetQueueSubmissionStatisticInfoWithOptionsAsync(GetQueueSubmissionStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ApplicationType"] = request.ApplicationType;
            query["ClusterId"] = request.ClusterId;
            query["FinalStatus"] = request.FinalStatus;
            query["FromDatetime"] = request.FromDatetime;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ToDatetime"] = request.ToDatetime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueueSubmissionStatisticInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueueSubmissionStatisticInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetQueueSubmissionStatisticInfoResponse GetQueueSubmissionStatisticInfo(GetQueueSubmissionStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueueSubmissionStatisticInfoWithOptions(request, runtime);
        }

        public async Task<GetQueueSubmissionStatisticInfoResponse> GetQueueSubmissionStatisticInfoAsync(GetQueueSubmissionStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueueSubmissionStatisticInfoWithOptionsAsync(request, runtime);
        }

        public GetUserInputStatisticInfoResponse GetUserInputStatisticInfoWithOptions(GetUserInputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["FromDatetime"] = request.FromDatetime;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ToDatetime"] = request.ToDatetime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserInputStatisticInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserInputStatisticInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUserInputStatisticInfoResponse> GetUserInputStatisticInfoWithOptionsAsync(GetUserInputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["FromDatetime"] = request.FromDatetime;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ToDatetime"] = request.ToDatetime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserInputStatisticInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserInputStatisticInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetUserInputStatisticInfoResponse GetUserInputStatisticInfo(GetUserInputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserInputStatisticInfoWithOptions(request, runtime);
        }

        public async Task<GetUserInputStatisticInfoResponse> GetUserInputStatisticInfoAsync(GetUserInputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserInputStatisticInfoWithOptionsAsync(request, runtime);
        }

        public GetUserOutputStatisticInfoResponse GetUserOutputStatisticInfoWithOptions(GetUserOutputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["FromDatetime"] = request.FromDatetime;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ToDatetime"] = request.ToDatetime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserOutputStatisticInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserOutputStatisticInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUserOutputStatisticInfoResponse> GetUserOutputStatisticInfoWithOptionsAsync(GetUserOutputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["FromDatetime"] = request.FromDatetime;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ToDatetime"] = request.ToDatetime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserOutputStatisticInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserOutputStatisticInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetUserOutputStatisticInfoResponse GetUserOutputStatisticInfo(GetUserOutputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserOutputStatisticInfoWithOptions(request, runtime);
        }

        public async Task<GetUserOutputStatisticInfoResponse> GetUserOutputStatisticInfoAsync(GetUserOutputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserOutputStatisticInfoWithOptionsAsync(request, runtime);
        }

        public GetUserSubmissionStatisticInfoResponse GetUserSubmissionStatisticInfoWithOptions(GetUserSubmissionStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ApplicationType"] = request.ApplicationType;
            query["ClusterId"] = request.ClusterId;
            query["FinalStatus"] = request.FinalStatus;
            query["FromDatetime"] = request.FromDatetime;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ToDatetime"] = request.ToDatetime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserSubmissionStatisticInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserSubmissionStatisticInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUserSubmissionStatisticInfoResponse> GetUserSubmissionStatisticInfoWithOptionsAsync(GetUserSubmissionStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ApplicationType"] = request.ApplicationType;
            query["ClusterId"] = request.ClusterId;
            query["FinalStatus"] = request.FinalStatus;
            query["FromDatetime"] = request.FromDatetime;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ToDatetime"] = request.ToDatetime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserSubmissionStatisticInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserSubmissionStatisticInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetUserSubmissionStatisticInfoResponse GetUserSubmissionStatisticInfo(GetUserSubmissionStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserSubmissionStatisticInfoWithOptions(request, runtime);
        }

        public async Task<GetUserSubmissionStatisticInfoResponse> GetUserSubmissionStatisticInfoAsync(GetUserSubmissionStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserSubmissionStatisticInfoWithOptionsAsync(request, runtime);
        }

        public InstallLibrariesResponse InstallLibrariesWithOptions(InstallLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterBizIdList"] = request.ClusterBizIdList;
            query["LibraryBizId"] = request.LibraryBizId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallLibraries",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallLibrariesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InstallLibrariesResponse> InstallLibrariesWithOptionsAsync(InstallLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterBizIdList"] = request.ClusterBizIdList;
            query["LibraryBizId"] = request.LibraryBizId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallLibraries",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallLibrariesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InstallLibrariesResponse InstallLibraries(InstallLibrariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstallLibrariesWithOptions(request, runtime);
        }

        public async Task<InstallLibrariesResponse> InstallLibrariesAsync(InstallLibrariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstallLibrariesWithOptionsAsync(request, runtime);
        }

        public JoinResourceGroupResponse JoinResourceGroupWithOptions(JoinResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "JoinResourceGroup",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<JoinResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<JoinResourceGroupResponse> JoinResourceGroupWithOptionsAsync(JoinResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "JoinResourceGroup",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<JoinResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public JoinResourceGroupResponse JoinResourceGroup(JoinResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return JoinResourceGroupWithOptions(request, runtime);
        }

        public async Task<JoinResourceGroupResponse> JoinResourceGroupAsync(JoinResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await JoinResourceGroupWithOptionsAsync(request, runtime);
        }

        public KillFlowJobResponse KillFlowJobWithOptions(KillFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["JobInstanceId"] = request.JobInstanceId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillFlowJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<KillFlowJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<KillFlowJobResponse> KillFlowJobWithOptionsAsync(KillFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["JobInstanceId"] = request.JobInstanceId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillFlowJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<KillFlowJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public KillFlowJobResponse KillFlowJob(KillFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return KillFlowJobWithOptions(request, runtime);
        }

        public async Task<KillFlowJobResponse> KillFlowJobAsync(KillFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await KillFlowJobWithOptionsAsync(request, runtime);
        }

        public ListAdviceActionResponse ListAdviceActionWithOptions(ListAdviceActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Component"] = request.Component;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAdviceAction",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAdviceActionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAdviceActionResponse> ListAdviceActionWithOptionsAsync(ListAdviceActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Component"] = request.Component;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAdviceAction",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAdviceActionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAdviceActionResponse ListAdviceAction(ListAdviceActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAdviceActionWithOptions(request, runtime);
        }

        public async Task<ListAdviceActionResponse> ListAdviceActionAsync(ListAdviceActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAdviceActionWithOptionsAsync(request, runtime);
        }

        public ListApmApplicationResponse ListApmApplicationWithOptions(ListApmApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["ClusterId"] = request.ClusterId;
            query["DiagnoseResult"] = request.DiagnoseResult;
            query["EndTimeFrom"] = request.EndTimeFrom;
            query["EndTimeTo"] = request.EndTimeTo;
            query["FinalStatus"] = request.FinalStatus;
            query["JobType"] = request.JobType;
            query["Name"] = request.Name;
            query["OrderBy"] = request.OrderBy;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["Queue"] = request.Queue;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["StartTimeFrom"] = request.StartTimeFrom;
            query["StartTimeTo"] = request.StartTimeTo;
            query["State"] = request.State;
            query["User"] = request.User;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApmApplication",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApmApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListApmApplicationResponse> ListApmApplicationWithOptionsAsync(ListApmApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["ClusterId"] = request.ClusterId;
            query["DiagnoseResult"] = request.DiagnoseResult;
            query["EndTimeFrom"] = request.EndTimeFrom;
            query["EndTimeTo"] = request.EndTimeTo;
            query["FinalStatus"] = request.FinalStatus;
            query["JobType"] = request.JobType;
            query["Name"] = request.Name;
            query["OrderBy"] = request.OrderBy;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["Queue"] = request.Queue;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["StartTimeFrom"] = request.StartTimeFrom;
            query["StartTimeTo"] = request.StartTimeTo;
            query["State"] = request.State;
            query["User"] = request.User;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApmApplication",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApmApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListApmApplicationResponse ListApmApplication(ListApmApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApmApplicationWithOptions(request, runtime);
        }

        public async Task<ListApmApplicationResponse> ListApmApplicationAsync(ListApmApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApmApplicationWithOptionsAsync(request, runtime);
        }

        public ListBackupsResponse ListBackupsWithOptions(ListBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackupId"] = request.BackupId;
            query["BackupPlanId"] = request.BackupPlanId;
            query["BizId"] = request.BizId;
            query["ClusterId"] = request.ClusterId;
            query["CurrentSize"] = request.CurrentSize;
            query["Id"] = request.Id;
            query["Limit"] = request.Limit;
            query["MetadataType"] = request.MetadataType;
            query["OrderMode"] = request.OrderMode;
            query["PageCount"] = request.PageCount;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBackups",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBackupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListBackupsResponse> ListBackupsWithOptionsAsync(ListBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackupId"] = request.BackupId;
            query["BackupPlanId"] = request.BackupPlanId;
            query["BizId"] = request.BizId;
            query["ClusterId"] = request.ClusterId;
            query["CurrentSize"] = request.CurrentSize;
            query["Id"] = request.Id;
            query["Limit"] = request.Limit;
            query["MetadataType"] = request.MetadataType;
            query["OrderMode"] = request.OrderMode;
            query["PageCount"] = request.PageCount;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBackups",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBackupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListBackupsResponse ListBackups(ListBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBackupsWithOptions(request, runtime);
        }

        public async Task<ListBackupsResponse> ListBackupsAsync(ListBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBackupsWithOptionsAsync(request, runtime);
        }

        public ListClusterHostResponse ListClusterHostWithOptions(ListClusterHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ComponentName"] = request.ComponentName;
            query["GroupType"] = request.GroupType;
            query["HostGroupId"] = request.HostGroupId;
            query["HostInstanceId"] = request.HostInstanceId;
            query["HostName"] = request.HostName;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["PrivateIp"] = request.PrivateIp;
            query["PublicIp"] = request.PublicIp;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["StatusList"] = request.StatusList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterHost",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterHostResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListClusterHostResponse> ListClusterHostWithOptionsAsync(ListClusterHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ComponentName"] = request.ComponentName;
            query["GroupType"] = request.GroupType;
            query["HostGroupId"] = request.HostGroupId;
            query["HostInstanceId"] = request.HostInstanceId;
            query["HostName"] = request.HostName;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["PrivateIp"] = request.PrivateIp;
            query["PublicIp"] = request.PublicIp;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["StatusList"] = request.StatusList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterHost",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterHostResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListClusterHostResponse ListClusterHost(ListClusterHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterHostWithOptions(request, runtime);
        }

        public async Task<ListClusterHostResponse> ListClusterHostAsync(ListClusterHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterHostWithOptionsAsync(request, runtime);
        }

        public ListClusterHostComponentResponse ListClusterHostComponentWithOptions(ListClusterHostComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ComponentName"] = request.ComponentName;
            query["ComponentStatus"] = request.ComponentStatus;
            query["HostInstanceId"] = request.HostInstanceId;
            query["HostName"] = request.HostName;
            query["HostRole"] = request.HostRole;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterHostComponent",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterHostComponentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListClusterHostComponentResponse> ListClusterHostComponentWithOptionsAsync(ListClusterHostComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ComponentName"] = request.ComponentName;
            query["ComponentStatus"] = request.ComponentStatus;
            query["HostInstanceId"] = request.HostInstanceId;
            query["HostName"] = request.HostName;
            query["HostRole"] = request.HostRole;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterHostComponent",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterHostComponentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListClusterHostComponentResponse ListClusterHostComponent(ListClusterHostComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterHostComponentWithOptions(request, runtime);
        }

        public async Task<ListClusterHostComponentResponse> ListClusterHostComponentAsync(ListClusterHostComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterHostComponentWithOptionsAsync(request, runtime);
        }

        public ListClusterHostGroupResponse ListClusterHostGroupWithOptions(ListClusterHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["HostGroupId"] = request.HostGroupId;
            query["HostGroupName"] = request.HostGroupName;
            query["HostGroupType"] = request.HostGroupType;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["StatusList"] = request.StatusList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterHostGroup",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterHostGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListClusterHostGroupResponse> ListClusterHostGroupWithOptionsAsync(ListClusterHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["HostGroupId"] = request.HostGroupId;
            query["HostGroupName"] = request.HostGroupName;
            query["HostGroupType"] = request.HostGroupType;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["StatusList"] = request.StatusList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterHostGroup",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterHostGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListClusterHostGroupResponse ListClusterHostGroup(ListClusterHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterHostGroupWithOptions(request, runtime);
        }

        public async Task<ListClusterHostGroupResponse> ListClusterHostGroupAsync(ListClusterHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterHostGroupWithOptionsAsync(request, runtime);
        }

        public ListClusterInstalledServiceResponse ListClusterInstalledServiceWithOptions(ListClusterInstalledServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterInstalledService",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterInstalledServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListClusterInstalledServiceResponse> ListClusterInstalledServiceWithOptionsAsync(ListClusterInstalledServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterInstalledService",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterInstalledServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListClusterInstalledServiceResponse ListClusterInstalledService(ListClusterInstalledServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterInstalledServiceWithOptions(request, runtime);
        }

        public async Task<ListClusterInstalledServiceResponse> ListClusterInstalledServiceAsync(ListClusterInstalledServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterInstalledServiceWithOptionsAsync(request, runtime);
        }

        public ListClusterOperationResponse ListClusterOperationWithOptions(ListClusterOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["OperationId"] = request.OperationId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterOperation",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterOperationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListClusterOperationResponse> ListClusterOperationWithOptionsAsync(ListClusterOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["OperationId"] = request.OperationId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterOperation",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterOperationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListClusterOperationResponse ListClusterOperation(ListClusterOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterOperationWithOptions(request, runtime);
        }

        public async Task<ListClusterOperationResponse> ListClusterOperationAsync(ListClusterOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterOperationWithOptionsAsync(request, runtime);
        }

        public ListClusterOperationHostResponse ListClusterOperationHostWithOptions(ListClusterOperationHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["OperationId"] = request.OperationId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterOperationHost",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterOperationHostResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListClusterOperationHostResponse> ListClusterOperationHostWithOptionsAsync(ListClusterOperationHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["OperationId"] = request.OperationId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterOperationHost",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterOperationHostResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListClusterOperationHostResponse ListClusterOperationHost(ListClusterOperationHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterOperationHostWithOptions(request, runtime);
        }

        public async Task<ListClusterOperationHostResponse> ListClusterOperationHostAsync(ListClusterOperationHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterOperationHostWithOptionsAsync(request, runtime);
        }

        public ListClusterOperationHostTaskResponse ListClusterOperationHostTaskWithOptions(ListClusterOperationHostTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["HostId"] = request.HostId;
            query["OperationId"] = request.OperationId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterOperationHostTask",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterOperationHostTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListClusterOperationHostTaskResponse> ListClusterOperationHostTaskWithOptionsAsync(ListClusterOperationHostTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["HostId"] = request.HostId;
            query["OperationId"] = request.OperationId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterOperationHostTask",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterOperationHostTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListClusterOperationHostTaskResponse ListClusterOperationHostTask(ListClusterOperationHostTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterOperationHostTaskWithOptions(request, runtime);
        }

        public async Task<ListClusterOperationHostTaskResponse> ListClusterOperationHostTaskAsync(ListClusterOperationHostTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterOperationHostTaskWithOptionsAsync(request, runtime);
        }

        public ListClusterOperationTaskResponse ListClusterOperationTaskWithOptions(ListClusterOperationTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["OperationId"] = request.OperationId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterOperationTask",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterOperationTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListClusterOperationTaskResponse> ListClusterOperationTaskWithOptionsAsync(ListClusterOperationTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["OperationId"] = request.OperationId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterOperationTask",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterOperationTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListClusterOperationTaskResponse ListClusterOperationTask(ListClusterOperationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterOperationTaskWithOptions(request, runtime);
        }

        public async Task<ListClusterOperationTaskResponse> ListClusterOperationTaskAsync(ListClusterOperationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterOperationTaskWithOptionsAsync(request, runtime);
        }

        public ListClusterServiceResponse ListClusterServiceWithOptions(ListClusterServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterService",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListClusterServiceResponse> ListClusterServiceWithOptionsAsync(ListClusterServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterService",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListClusterServiceResponse ListClusterService(ListClusterServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterServiceWithOptions(request, runtime);
        }

        public async Task<ListClusterServiceResponse> ListClusterServiceAsync(ListClusterServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterServiceWithOptionsAsync(request, runtime);
        }

        public ListClusterServiceComponentResponse ListClusterServiceComponentWithOptions(ListClusterServiceComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ComponentName"] = request.ComponentName;
            query["ComponentStatus"] = request.ComponentStatus;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["PodName"] = request.PodName;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterServiceComponent",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterServiceComponentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListClusterServiceComponentResponse> ListClusterServiceComponentWithOptionsAsync(ListClusterServiceComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ComponentName"] = request.ComponentName;
            query["ComponentStatus"] = request.ComponentStatus;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["PodName"] = request.PodName;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterServiceComponent",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterServiceComponentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListClusterServiceComponentResponse ListClusterServiceComponent(ListClusterServiceComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterServiceComponentWithOptions(request, runtime);
        }

        public async Task<ListClusterServiceComponentResponse> ListClusterServiceComponentAsync(ListClusterServiceComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterServiceComponentWithOptionsAsync(request, runtime);
        }

        public ListClusterServiceComponentHealthInfoResponse ListClusterServiceComponentHealthInfoWithOptions(ListClusterServiceComponentHealthInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ComponentName"] = request.ComponentName;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterServiceComponentHealthInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterServiceComponentHealthInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListClusterServiceComponentHealthInfoResponse> ListClusterServiceComponentHealthInfoWithOptionsAsync(ListClusterServiceComponentHealthInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ComponentName"] = request.ComponentName;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterServiceComponentHealthInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterServiceComponentHealthInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListClusterServiceComponentHealthInfoResponse ListClusterServiceComponentHealthInfo(ListClusterServiceComponentHealthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterServiceComponentHealthInfoWithOptions(request, runtime);
        }

        public async Task<ListClusterServiceComponentHealthInfoResponse> ListClusterServiceComponentHealthInfoAsync(ListClusterServiceComponentHealthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterServiceComponentHealthInfoWithOptionsAsync(request, runtime);
        }

        public ListClusterServiceConfigHistoryResponse ListClusterServiceConfigHistoryWithOptions(ListClusterServiceConfigHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Author"] = request.Author;
            query["ClusterId"] = request.ClusterId;
            query["Comment"] = request.Comment;
            query["ConfigFileName"] = request.ConfigFileName;
            query["ConfigItemKey"] = request.ConfigItemKey;
            query["ConfigVersion"] = request.ConfigVersion;
            query["HostGroupId"] = request.HostGroupId;
            query["HostInstanceId"] = request.HostInstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterServiceConfigHistory",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterServiceConfigHistoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListClusterServiceConfigHistoryResponse> ListClusterServiceConfigHistoryWithOptionsAsync(ListClusterServiceConfigHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Author"] = request.Author;
            query["ClusterId"] = request.ClusterId;
            query["Comment"] = request.Comment;
            query["ConfigFileName"] = request.ConfigFileName;
            query["ConfigItemKey"] = request.ConfigItemKey;
            query["ConfigVersion"] = request.ConfigVersion;
            query["HostGroupId"] = request.HostGroupId;
            query["HostInstanceId"] = request.HostInstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterServiceConfigHistory",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterServiceConfigHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListClusterServiceConfigHistoryResponse ListClusterServiceConfigHistory(ListClusterServiceConfigHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterServiceConfigHistoryWithOptions(request, runtime);
        }

        public async Task<ListClusterServiceConfigHistoryResponse> ListClusterServiceConfigHistoryAsync(ListClusterServiceConfigHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterServiceConfigHistoryWithOptionsAsync(request, runtime);
        }

        public ListClusterServiceQuickLinkResponse ListClusterServiceQuickLinkWithOptions(ListClusterServiceQuickLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["DirectType"] = request.DirectType;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterServiceQuickLink",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterServiceQuickLinkResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListClusterServiceQuickLinkResponse> ListClusterServiceQuickLinkWithOptionsAsync(ListClusterServiceQuickLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["DirectType"] = request.DirectType;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterServiceQuickLink",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterServiceQuickLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListClusterServiceQuickLinkResponse ListClusterServiceQuickLink(ListClusterServiceQuickLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterServiceQuickLinkWithOptions(request, runtime);
        }

        public async Task<ListClusterServiceQuickLinkResponse> ListClusterServiceQuickLinkAsync(ListClusterServiceQuickLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterServiceQuickLinkWithOptionsAsync(request, runtime);
        }

        public ListClusterTemplatesResponse ListClusterTemplatesWithOptions(ListClusterTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BizId"] = request.BizId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProductType"] = request.ProductType;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterTemplates",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterTemplatesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListClusterTemplatesResponse> ListClusterTemplatesWithOptionsAsync(ListClusterTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BizId"] = request.BizId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProductType"] = request.ProductType;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterTemplates",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListClusterTemplatesResponse ListClusterTemplates(ListClusterTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterTemplatesWithOptions(request, runtime);
        }

        public async Task<ListClusterTemplatesResponse> ListClusterTemplatesAsync(ListClusterTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterTemplatesWithOptionsAsync(request, runtime);
        }

        public ListClustersResponse ListClustersWithOptions(ListClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterTypeList"] = request.ClusterTypeList;
            query["CreateType"] = request.CreateType;
            query["DefaultStatus"] = request.DefaultStatus;
            query["DepositType"] = request.DepositType;
            query["ExpiredTagList"] = request.ExpiredTagList;
            query["IsDesc"] = request.IsDesc;
            query["MachineType"] = request.MachineType;
            query["Name"] = request.Name;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["StatusList"] = request.StatusList;
            query["Tag"] = request.Tag;
            query["VpcId"] = request.VpcId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusters",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClustersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListClustersResponse> ListClustersWithOptionsAsync(ListClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterTypeList"] = request.ClusterTypeList;
            query["CreateType"] = request.CreateType;
            query["DefaultStatus"] = request.DefaultStatus;
            query["DepositType"] = request.DepositType;
            query["ExpiredTagList"] = request.ExpiredTagList;
            query["IsDesc"] = request.IsDesc;
            query["MachineType"] = request.MachineType;
            query["Name"] = request.Name;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["StatusList"] = request.StatusList;
            query["Tag"] = request.Tag;
            query["VpcId"] = request.VpcId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusters",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClustersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListClustersResponse ListClusters(ListClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClustersWithOptions(request, runtime);
        }

        public async Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClustersWithOptionsAsync(request, runtime);
        }

        public ListDataSourceResponse ListDataSourceWithOptions(ListDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CreateFrom"] = request.CreateFrom;
            query["Id"] = request.Id;
            query["Name"] = request.Name;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SourceType"] = request.SourceType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSource",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDataSourceResponse> ListDataSourceWithOptionsAsync(ListDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CreateFrom"] = request.CreateFrom;
            query["Id"] = request.Id;
            query["Name"] = request.Name;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SourceType"] = request.SourceType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSource",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDataSourceResponse ListDataSource(ListDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataSourceWithOptions(request, runtime);
        }

        public async Task<ListDataSourceResponse> ListDataSourceAsync(ListDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataSourceWithOptionsAsync(request, runtime);
        }

        public ListDiskOpsEventsResponse ListDiskOpsEventsWithOptions(ListDiskOpsEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["EndTime"] = request.EndTime;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDiskOpsEvents",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDiskOpsEventsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDiskOpsEventsResponse> ListDiskOpsEventsWithOptionsAsync(ListDiskOpsEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["EndTime"] = request.EndTime;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDiskOpsEvents",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDiskOpsEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDiskOpsEventsResponse ListDiskOpsEvents(ListDiskOpsEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDiskOpsEventsWithOptions(request, runtime);
        }

        public async Task<ListDiskOpsEventsResponse> ListDiskOpsEventsAsync(ListDiskOpsEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDiskOpsEventsWithOptionsAsync(request, runtime);
        }

        public ListEmrAvailableConfigResponse ListEmrAvailableConfigWithOptions(ListEmrAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEmrAvailableConfig",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEmrAvailableConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListEmrAvailableConfigResponse> ListEmrAvailableConfigWithOptionsAsync(ListEmrAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEmrAvailableConfig",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEmrAvailableConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListEmrAvailableConfigResponse ListEmrAvailableConfig(ListEmrAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEmrAvailableConfigWithOptions(request, runtime);
        }

        public async Task<ListEmrAvailableConfigResponse> ListEmrAvailableConfigAsync(ListEmrAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEmrAvailableConfigWithOptionsAsync(request, runtime);
        }

        public ListEmrAvailableResourceResponse ListEmrAvailableResourceWithOptions(ListEmrAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ClusterType"] = request.ClusterType;
            query["DataDiskType"] = request.DataDiskType;
            query["DepositType"] = request.DepositType;
            query["DestinationResource"] = request.DestinationResource;
            query["EmrVersion"] = request.EmrVersion;
            query["InstanceChargeType"] = request.InstanceChargeType;
            query["InstanceType"] = request.InstanceType;
            query["NetType"] = request.NetType;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SpotStrategy"] = request.SpotStrategy;
            query["SystemDiskType"] = request.SystemDiskType;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEmrAvailableResource",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEmrAvailableResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListEmrAvailableResourceResponse> ListEmrAvailableResourceWithOptionsAsync(ListEmrAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ClusterType"] = request.ClusterType;
            query["DataDiskType"] = request.DataDiskType;
            query["DepositType"] = request.DepositType;
            query["DestinationResource"] = request.DestinationResource;
            query["EmrVersion"] = request.EmrVersion;
            query["InstanceChargeType"] = request.InstanceChargeType;
            query["InstanceType"] = request.InstanceType;
            query["NetType"] = request.NetType;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SpotStrategy"] = request.SpotStrategy;
            query["SystemDiskType"] = request.SystemDiskType;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEmrAvailableResource",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEmrAvailableResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListEmrAvailableResourceResponse ListEmrAvailableResource(ListEmrAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEmrAvailableResourceWithOptions(request, runtime);
        }

        public async Task<ListEmrAvailableResourceResponse> ListEmrAvailableResourceAsync(ListEmrAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEmrAvailableResourceWithOptionsAsync(request, runtime);
        }

        public ListEmrMainVersionResponse ListEmrMainVersionWithOptions(ListEmrMainVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EmrVersion"] = request.EmrVersion;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["StackName"] = request.StackName;
            query["StackVersion"] = request.StackVersion;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEmrMainVersion",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEmrMainVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListEmrMainVersionResponse> ListEmrMainVersionWithOptionsAsync(ListEmrMainVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EmrVersion"] = request.EmrVersion;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["StackName"] = request.StackName;
            query["StackVersion"] = request.StackVersion;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEmrMainVersion",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEmrMainVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListEmrMainVersionResponse ListEmrMainVersion(ListEmrMainVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEmrMainVersionWithOptions(request, runtime);
        }

        public async Task<ListEmrMainVersionResponse> ListEmrMainVersionAsync(ListEmrMainVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEmrMainVersionWithOptionsAsync(request, runtime);
        }

        public ListExecutionPlanInstancesResponse ListExecutionPlanInstancesWithOptions(ListExecutionPlanInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ExecutionPlanIdList"] = request.ExecutionPlanIdList;
            query["IsDesc"] = request.IsDesc;
            query["OnlyLastInstance"] = request.OnlyLastInstance;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["StatusList"] = request.StatusList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExecutionPlanInstances",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExecutionPlanInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListExecutionPlanInstancesResponse> ListExecutionPlanInstancesWithOptionsAsync(ListExecutionPlanInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ExecutionPlanIdList"] = request.ExecutionPlanIdList;
            query["IsDesc"] = request.IsDesc;
            query["OnlyLastInstance"] = request.OnlyLastInstance;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["StatusList"] = request.StatusList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExecutionPlanInstances",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExecutionPlanInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListExecutionPlanInstancesResponse ListExecutionPlanInstances(ListExecutionPlanInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExecutionPlanInstancesWithOptions(request, runtime);
        }

        public async Task<ListExecutionPlanInstancesResponse> ListExecutionPlanInstancesAsync(ListExecutionPlanInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExecutionPlanInstancesWithOptionsAsync(request, runtime);
        }

        public ListFlowResponse ListFlowWithOptions(ListFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Id"] = request.Id;
            query["JobId"] = request.JobId;
            query["Name"] = request.Name;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["Periodic"] = request.Periodic;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlow",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFlowResponse> ListFlowWithOptionsAsync(ListFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Id"] = request.Id;
            query["JobId"] = request.JobId;
            query["Name"] = request.Name;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["Periodic"] = request.Periodic;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlow",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowResponse>(await CallApiAsync(params_, req, runtime));
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

        public ListFlowCategoryResponse ListFlowCategoryWithOptions(ListFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ParentId"] = request.ParentId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["Root"] = request.Root;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowCategory",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowCategoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFlowCategoryResponse> ListFlowCategoryWithOptionsAsync(ListFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ParentId"] = request.ParentId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["Root"] = request.Root;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowCategory",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFlowCategoryResponse ListFlowCategory(ListFlowCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowCategoryWithOptions(request, runtime);
        }

        public async Task<ListFlowCategoryResponse> ListFlowCategoryAsync(ListFlowCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowCategoryWithOptionsAsync(request, runtime);
        }

        public ListFlowClusterResponse ListFlowClusterWithOptions(ListFlowClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowCluster",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFlowClusterResponse> ListFlowClusterWithOptionsAsync(ListFlowClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowCluster",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFlowClusterResponse ListFlowCluster(ListFlowClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowClusterWithOptions(request, runtime);
        }

        public async Task<ListFlowClusterResponse> ListFlowClusterAsync(ListFlowClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowClusterWithOptionsAsync(request, runtime);
        }

        public ListFlowClusterAllResponse ListFlowClusterAllWithOptions(ListFlowClusterAllRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProductType"] = request.ProductType;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowClusterAll",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowClusterAllResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFlowClusterAllResponse> ListFlowClusterAllWithOptionsAsync(ListFlowClusterAllRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProductType"] = request.ProductType;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowClusterAll",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowClusterAllResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFlowClusterAllResponse ListFlowClusterAll(ListFlowClusterAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowClusterAllWithOptions(request, runtime);
        }

        public async Task<ListFlowClusterAllResponse> ListFlowClusterAllAsync(ListFlowClusterAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowClusterAllWithOptionsAsync(request, runtime);
        }

        public ListFlowClusterAllHostsResponse ListFlowClusterAllHostsWithOptions(ListFlowClusterAllHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowClusterAllHosts",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowClusterAllHostsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFlowClusterAllHostsResponse> ListFlowClusterAllHostsWithOptionsAsync(ListFlowClusterAllHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowClusterAllHosts",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowClusterAllHostsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFlowClusterAllHostsResponse ListFlowClusterAllHosts(ListFlowClusterAllHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowClusterAllHostsWithOptions(request, runtime);
        }

        public async Task<ListFlowClusterAllHostsResponse> ListFlowClusterAllHostsAsync(ListFlowClusterAllHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowClusterAllHostsWithOptionsAsync(request, runtime);
        }

        public ListFlowClusterHostResponse ListFlowClusterHostWithOptions(ListFlowClusterHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowClusterHost",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowClusterHostResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFlowClusterHostResponse> ListFlowClusterHostWithOptionsAsync(ListFlowClusterHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowClusterHost",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowClusterHostResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFlowClusterHostResponse ListFlowClusterHost(ListFlowClusterHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowClusterHostWithOptions(request, runtime);
        }

        public async Task<ListFlowClusterHostResponse> ListFlowClusterHostAsync(ListFlowClusterHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowClusterHostWithOptionsAsync(request, runtime);
        }

        public ListFlowInstanceResponse ListFlowInstanceWithOptions(ListFlowInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["FlowId"] = request.FlowId;
            query["FlowName"] = request.FlowName;
            query["Id"] = request.Id;
            query["InstanceId"] = request.InstanceId;
            query["NodeInstanceId"] = request.NodeInstanceId;
            query["OrderBy"] = request.OrderBy;
            query["OrderType"] = request.OrderType;
            query["Owner"] = request.Owner;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["StatusList"] = request.StatusList;
            query["TimeRange"] = request.TimeRange;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowInstance",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFlowInstanceResponse> ListFlowInstanceWithOptionsAsync(ListFlowInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["FlowId"] = request.FlowId;
            query["FlowName"] = request.FlowName;
            query["Id"] = request.Id;
            query["InstanceId"] = request.InstanceId;
            query["NodeInstanceId"] = request.NodeInstanceId;
            query["OrderBy"] = request.OrderBy;
            query["OrderType"] = request.OrderType;
            query["Owner"] = request.Owner;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["StatusList"] = request.StatusList;
            query["TimeRange"] = request.TimeRange;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowInstance",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFlowInstanceResponse ListFlowInstance(ListFlowInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowInstanceWithOptions(request, runtime);
        }

        public async Task<ListFlowInstanceResponse> ListFlowInstanceAsync(ListFlowInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowInstanceWithOptionsAsync(request, runtime);
        }

        public ListFlowJobResponse ListFlowJobWithOptions(ListFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Adhoc"] = request.Adhoc;
            query["Id"] = request.Id;
            query["Name"] = request.Name;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFlowJobResponse> ListFlowJobWithOptionsAsync(ListFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Adhoc"] = request.Adhoc;
            query["Id"] = request.Id;
            query["Name"] = request.Name;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFlowJobResponse ListFlowJob(ListFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowJobWithOptions(request, runtime);
        }

        public async Task<ListFlowJobResponse> ListFlowJobAsync(ListFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowJobWithOptionsAsync(request, runtime);
        }

        public ListFlowJobHistoryResponse ListFlowJobHistoryWithOptions(ListFlowJobHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["InstanceId"] = request.InstanceId;
            query["JobType"] = request.JobType;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["StatusList"] = request.StatusList;
            query["TimeRange"] = request.TimeRange;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowJobHistory",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowJobHistoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFlowJobHistoryResponse> ListFlowJobHistoryWithOptionsAsync(ListFlowJobHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["InstanceId"] = request.InstanceId;
            query["JobType"] = request.JobType;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["StatusList"] = request.StatusList;
            query["TimeRange"] = request.TimeRange;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowJobHistory",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowJobHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFlowJobHistoryResponse ListFlowJobHistory(ListFlowJobHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowJobHistoryWithOptions(request, runtime);
        }

        public async Task<ListFlowJobHistoryResponse> ListFlowJobHistoryAsync(ListFlowJobHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowJobHistoryWithOptionsAsync(request, runtime);
        }

        public ListFlowNodeInstanceResponse ListFlowNodeInstanceWithOptions(ListFlowNodeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OrderBy"] = request.OrderBy;
            query["OrderType"] = request.OrderType;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["StartTime"] = request.StartTime;
            query["StatusList"] = request.StatusList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowNodeInstance",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowNodeInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFlowNodeInstanceResponse> ListFlowNodeInstanceWithOptionsAsync(ListFlowNodeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OrderBy"] = request.OrderBy;
            query["OrderType"] = request.OrderType;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["StartTime"] = request.StartTime;
            query["StatusList"] = request.StatusList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowNodeInstance",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowNodeInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFlowNodeInstanceResponse ListFlowNodeInstance(ListFlowNodeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowNodeInstanceWithOptions(request, runtime);
        }

        public async Task<ListFlowNodeInstanceResponse> ListFlowNodeInstanceAsync(ListFlowNodeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowNodeInstanceWithOptionsAsync(request, runtime);
        }

        public ListFlowNodeInstanceContainerStatusResponse ListFlowNodeInstanceContainerStatusWithOptions(ListFlowNodeInstanceContainerStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NodeInstanceId"] = request.NodeInstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowNodeInstanceContainerStatus",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowNodeInstanceContainerStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFlowNodeInstanceContainerStatusResponse> ListFlowNodeInstanceContainerStatusWithOptionsAsync(ListFlowNodeInstanceContainerStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NodeInstanceId"] = request.NodeInstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowNodeInstanceContainerStatus",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowNodeInstanceContainerStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFlowNodeInstanceContainerStatusResponse ListFlowNodeInstanceContainerStatus(ListFlowNodeInstanceContainerStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowNodeInstanceContainerStatusWithOptions(request, runtime);
        }

        public async Task<ListFlowNodeInstanceContainerStatusResponse> ListFlowNodeInstanceContainerStatusAsync(ListFlowNodeInstanceContainerStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowNodeInstanceContainerStatusWithOptionsAsync(request, runtime);
        }

        public ListFlowNodeSqlResultResponse ListFlowNodeSqlResultWithOptions(ListFlowNodeSqlResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Length"] = request.Length;
            query["NodeInstanceId"] = request.NodeInstanceId;
            query["Offset"] = request.Offset;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["SqlIndex"] = request.SqlIndex;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowNodeSqlResult",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowNodeSqlResultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFlowNodeSqlResultResponse> ListFlowNodeSqlResultWithOptionsAsync(ListFlowNodeSqlResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Length"] = request.Length;
            query["NodeInstanceId"] = request.NodeInstanceId;
            query["Offset"] = request.Offset;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["SqlIndex"] = request.SqlIndex;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowNodeSqlResult",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowNodeSqlResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFlowNodeSqlResultResponse ListFlowNodeSqlResult(ListFlowNodeSqlResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowNodeSqlResultWithOptions(request, runtime);
        }

        public async Task<ListFlowNodeSqlResultResponse> ListFlowNodeSqlResultAsync(ListFlowNodeSqlResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowNodeSqlResultWithOptionsAsync(request, runtime);
        }

        public ListFlowProjectResponse ListFlowProjectWithOptions(ListFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Name"] = request.Name;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProductType"] = request.ProductType;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowProject",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFlowProjectResponse> ListFlowProjectWithOptionsAsync(ListFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Name"] = request.Name;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProductType"] = request.ProductType;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowProject",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFlowProjectResponse ListFlowProject(ListFlowProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowProjectWithOptions(request, runtime);
        }

        public async Task<ListFlowProjectResponse> ListFlowProjectAsync(ListFlowProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowProjectWithOptionsAsync(request, runtime);
        }

        public ListFlowProjectClusterSettingResponse ListFlowProjectClusterSettingWithOptions(ListFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowProjectClusterSetting",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowProjectClusterSettingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFlowProjectClusterSettingResponse> ListFlowProjectClusterSettingWithOptionsAsync(ListFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowProjectClusterSetting",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowProjectClusterSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFlowProjectClusterSettingResponse ListFlowProjectClusterSetting(ListFlowProjectClusterSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowProjectClusterSettingWithOptions(request, runtime);
        }

        public async Task<ListFlowProjectClusterSettingResponse> ListFlowProjectClusterSettingAsync(ListFlowProjectClusterSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowProjectClusterSettingWithOptionsAsync(request, runtime);
        }

        public ListFlowProjectUserResponse ListFlowProjectUserWithOptions(ListFlowProjectUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowProjectUser",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowProjectUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFlowProjectUserResponse> ListFlowProjectUserWithOptionsAsync(ListFlowProjectUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowProjectUser",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowProjectUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFlowProjectUserResponse ListFlowProjectUser(ListFlowProjectUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowProjectUserWithOptions(request, runtime);
        }

        public async Task<ListFlowProjectUserResponse> ListFlowProjectUserAsync(ListFlowProjectUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowProjectUserWithOptionsAsync(request, runtime);
        }

        public ListJobExecutionInstancesResponse ListJobExecutionInstancesWithOptions(ListJobExecutionInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ExecutionPlanInstanceId"] = request.ExecutionPlanInstanceId;
            query["IsDesc"] = request.IsDesc;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobExecutionInstances",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobExecutionInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListJobExecutionInstancesResponse> ListJobExecutionInstancesWithOptionsAsync(ListJobExecutionInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ExecutionPlanInstanceId"] = request.ExecutionPlanInstanceId;
            query["IsDesc"] = request.IsDesc;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobExecutionInstances",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobExecutionInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListJobExecutionInstancesResponse ListJobExecutionInstances(ListJobExecutionInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJobExecutionInstancesWithOptions(request, runtime);
        }

        public async Task<ListJobExecutionInstancesResponse> ListJobExecutionInstancesAsync(ListJobExecutionInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJobExecutionInstancesWithOptionsAsync(request, runtime);
        }

        public ListJobsResponse ListJobsWithOptions(ListJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["IsDesc"] = request.IsDesc;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["QueryString"] = request.QueryString;
            query["QueryType"] = request.QueryType;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListJobsResponse> ListJobsWithOptionsAsync(ListJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["IsDesc"] = request.IsDesc;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["QueryString"] = request.QueryString;
            query["QueryType"] = request.QueryType;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListJobsResponse ListJobs(ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJobsWithOptions(request, runtime);
        }

        public async Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJobsWithOptionsAsync(request, runtime);
        }

        public ListLibrariesResponse ListLibrariesWithOptions(ListLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterBizId"] = request.ClusterBizId;
            query["CurrentSize"] = request.CurrentSize;
            query["Limit"] = request.Limit;
            query["OrderField"] = request.OrderField;
            query["OrderMode"] = request.OrderMode;
            query["PageCount"] = request.PageCount;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLibraries",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLibrariesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListLibrariesResponse> ListLibrariesWithOptionsAsync(ListLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterBizId"] = request.ClusterBizId;
            query["CurrentSize"] = request.CurrentSize;
            query["Limit"] = request.Limit;
            query["OrderField"] = request.OrderField;
            query["OrderMode"] = request.OrderMode;
            query["PageCount"] = request.PageCount;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLibraries",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLibrariesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListLibrariesResponse ListLibraries(ListLibrariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLibrariesWithOptions(request, runtime);
        }

        public async Task<ListLibrariesResponse> ListLibrariesAsync(ListLibrariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLibrariesWithOptionsAsync(request, runtime);
        }

        public ListLibraryInstallTasksResponse ListLibraryInstallTasksWithOptions(ListLibraryInstallTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterBizId"] = request.ClusterBizId;
            query["CurrentSize"] = request.CurrentSize;
            query["LibraryBizId"] = request.LibraryBizId;
            query["Limit"] = request.Limit;
            query["OrderField"] = request.OrderField;
            query["OrderMode"] = request.OrderMode;
            query["PageCount"] = request.PageCount;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLibraryInstallTasks",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLibraryInstallTasksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListLibraryInstallTasksResponse> ListLibraryInstallTasksWithOptionsAsync(ListLibraryInstallTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterBizId"] = request.ClusterBizId;
            query["CurrentSize"] = request.CurrentSize;
            query["LibraryBizId"] = request.LibraryBizId;
            query["Limit"] = request.Limit;
            query["OrderField"] = request.OrderField;
            query["OrderMode"] = request.OrderMode;
            query["PageCount"] = request.PageCount;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLibraryInstallTasks",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLibraryInstallTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListLibraryInstallTasksResponse ListLibraryInstallTasks(ListLibraryInstallTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLibraryInstallTasksWithOptions(request, runtime);
        }

        public async Task<ListLibraryInstallTasksResponse> ListLibraryInstallTasksAsync(ListLibraryInstallTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLibraryInstallTasksWithOptionsAsync(request, runtime);
        }

        public ListLibraryStatusResponse ListLibraryStatusWithOptions(ListLibraryStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterBizId"] = request.ClusterBizId;
            query["CurrentSize"] = request.CurrentSize;
            query["LibraryBizId"] = request.LibraryBizId;
            query["Limit"] = request.Limit;
            query["OrderField"] = request.OrderField;
            query["OrderMode"] = request.OrderMode;
            query["PageCount"] = request.PageCount;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLibraryStatus",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLibraryStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListLibraryStatusResponse> ListLibraryStatusWithOptionsAsync(ListLibraryStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterBizId"] = request.ClusterBizId;
            query["CurrentSize"] = request.CurrentSize;
            query["LibraryBizId"] = request.LibraryBizId;
            query["Limit"] = request.Limit;
            query["OrderField"] = request.OrderField;
            query["OrderMode"] = request.OrderMode;
            query["PageCount"] = request.PageCount;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLibraryStatus",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLibraryStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListLibraryStatusResponse ListLibraryStatus(ListLibraryStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLibraryStatusWithOptions(request, runtime);
        }

        public async Task<ListLibraryStatusResponse> ListLibraryStatusAsync(ListLibraryStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLibraryStatusWithOptionsAsync(request, runtime);
        }

        public ListLocalDiskComponentInfoResponse ListLocalDiskComponentInfoWithOptions(ListLocalDiskComponentInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["InstanceId"] = request.InstanceId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLocalDiskComponentInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLocalDiskComponentInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListLocalDiskComponentInfoResponse> ListLocalDiskComponentInfoWithOptionsAsync(ListLocalDiskComponentInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["InstanceId"] = request.InstanceId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLocalDiskComponentInfo",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLocalDiskComponentInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListLocalDiskComponentInfoResponse ListLocalDiskComponentInfo(ListLocalDiskComponentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLocalDiskComponentInfoWithOptions(request, runtime);
        }

        public async Task<ListLocalDiskComponentInfoResponse> ListLocalDiskComponentInfoAsync(ListLocalDiskComponentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLocalDiskComponentInfoWithOptionsAsync(request, runtime);
        }

        public ListResourcePoolResponse ListResourcePoolWithOptions(ListResourcePoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["PoolType"] = request.PoolType;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourcePool",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourcePoolResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListResourcePoolResponse> ListResourcePoolWithOptionsAsync(ListResourcePoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["PoolType"] = request.PoolType;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourcePool",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourcePoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListResourcePoolResponse ListResourcePool(ListResourcePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourcePoolWithOptions(request, runtime);
        }

        public async Task<ListResourcePoolResponse> ListResourcePoolAsync(ListResourcePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourcePoolWithOptionsAsync(request, runtime);
        }

        public ListRolesResponse ListRolesWithOptions(ListRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoles",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRolesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRolesResponse> ListRolesWithOptionsAsync(ListRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoles",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
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

        public ListScalingActivityV2Response ListScalingActivityV2WithOptions(ListScalingActivityV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterBizId"] = request.ClusterBizId;
            query["CurrentSize"] = request.CurrentSize;
            query["HostGroupId"] = request.HostGroupId;
            query["HostGroupName"] = request.HostGroupName;
            query["Limit"] = request.Limit;
            query["OrderField"] = request.OrderField;
            query["OrderMode"] = request.OrderMode;
            query["PageCount"] = request.PageCount;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingGroupBizId"] = request.ScalingGroupBizId;
            query["ScalingRuleName"] = request.ScalingRuleName;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScalingActivityV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScalingActivityV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<ListScalingActivityV2Response> ListScalingActivityV2WithOptionsAsync(ListScalingActivityV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterBizId"] = request.ClusterBizId;
            query["CurrentSize"] = request.CurrentSize;
            query["HostGroupId"] = request.HostGroupId;
            query["HostGroupName"] = request.HostGroupName;
            query["Limit"] = request.Limit;
            query["OrderField"] = request.OrderField;
            query["OrderMode"] = request.OrderMode;
            query["PageCount"] = request.PageCount;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingGroupBizId"] = request.ScalingGroupBizId;
            query["ScalingRuleName"] = request.ScalingRuleName;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScalingActivityV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScalingActivityV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public ListScalingActivityV2Response ListScalingActivityV2(ListScalingActivityV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScalingActivityV2WithOptions(request, runtime);
        }

        public async Task<ListScalingActivityV2Response> ListScalingActivityV2Async(ListScalingActivityV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScalingActivityV2WithOptionsAsync(request, runtime);
        }

        public ListScalingConfigItemV2Response ListScalingConfigItemV2WithOptions(ListScalingConfigItemV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ConfigItemType"] = request.ConfigItemType;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingGroupBizId"] = request.ScalingGroupBizId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScalingConfigItemV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScalingConfigItemV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<ListScalingConfigItemV2Response> ListScalingConfigItemV2WithOptionsAsync(ListScalingConfigItemV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ConfigItemType"] = request.ConfigItemType;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingGroupBizId"] = request.ScalingGroupBizId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScalingConfigItemV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScalingConfigItemV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public ListScalingConfigItemV2Response ListScalingConfigItemV2(ListScalingConfigItemV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScalingConfigItemV2WithOptions(request, runtime);
        }

        public async Task<ListScalingConfigItemV2Response> ListScalingConfigItemV2Async(ListScalingConfigItemV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScalingConfigItemV2WithOptionsAsync(request, runtime);
        }

        public ListScalingGroupV2Response ListScalingGroupV2WithOptions(ListScalingGroupV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterBizId"] = request.ClusterBizId;
            query["CurrentSize"] = request.CurrentSize;
            query["Limit"] = request.Limit;
            query["OrderField"] = request.OrderField;
            query["OrderMode"] = request.OrderMode;
            query["PageCount"] = request.PageCount;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScalingGroupV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScalingGroupV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<ListScalingGroupV2Response> ListScalingGroupV2WithOptionsAsync(ListScalingGroupV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterBizId"] = request.ClusterBizId;
            query["CurrentSize"] = request.CurrentSize;
            query["Limit"] = request.Limit;
            query["OrderField"] = request.OrderField;
            query["OrderMode"] = request.OrderMode;
            query["PageCount"] = request.PageCount;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScalingGroupV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScalingGroupV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public ListScalingGroupV2Response ListScalingGroupV2(ListScalingGroupV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScalingGroupV2WithOptions(request, runtime);
        }

        public async Task<ListScalingGroupV2Response> ListScalingGroupV2Async(ListScalingGroupV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScalingGroupV2WithOptionsAsync(request, runtime);
        }

        public ListSecurityGroupResponse ListSecurityGroupWithOptions(ListSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DepositType"] = request.DepositType;
            query["NetType"] = request.NetType;
            query["ProductType"] = request.ProductType;
            query["RegionId"] = request.RegionId;
            query["VpcId"] = request.VpcId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSecurityGroup",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSecurityGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSecurityGroupResponse> ListSecurityGroupWithOptionsAsync(ListSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DepositType"] = request.DepositType;
            query["NetType"] = request.NetType;
            query["ProductType"] = request.ProductType;
            query["RegionId"] = request.RegionId;
            query["VpcId"] = request.VpcId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSecurityGroup",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSecurityGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSecurityGroupResponse ListSecurityGroup(ListSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSecurityGroupWithOptions(request, runtime);
        }

        public async Task<ListSecurityGroupResponse> ListSecurityGroupAsync(ListSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSecurityGroupWithOptionsAsync(request, runtime);
        }

        public ListStackResponse ListStackWithOptions(ListStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["StackName"] = request.StackName;
            query["StackVersion"] = request.StackVersion;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStack",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStackResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListStackResponse> ListStackWithOptionsAsync(ListStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["StackName"] = request.StackName;
            query["StackVersion"] = request.StackVersion;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStack",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStackResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListStackResponse ListStack(ListStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStackWithOptions(request, runtime);
        }

        public async Task<ListStackResponse> ListStackAsync(ListStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStackWithOptionsAsync(request, runtime);
        }

        public ListTagKeysResponse ListTagKeysWithOptions(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Category"] = request.Category;
            query["NextToken"] = request.NextToken;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            query["Scope"] = request.Scope;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagKeys",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagKeysResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTagKeysResponse> ListTagKeysWithOptionsAsync(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Category"] = request.Category;
            query["NextToken"] = request.NextToken;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            query["Scope"] = request.Scope;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagKeys",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagKeysResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NextToken"] = request.NextToken;
            query["RegionId"] = request.RegionId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NextToken"] = request.NextToken;
            query["RegionId"] = request.RegionId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Key"] = request.Key;
            query["NextToken"] = request.NextToken;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            query["Scope"] = request.Scope;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagValues",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagValuesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTagValuesResponse> ListTagValuesWithOptionsAsync(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Key"] = request.Key;
            query["NextToken"] = request.NextToken;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            query["Scope"] = request.Scope;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagValues",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagValuesResponse>(await CallApiAsync(params_, req, runtime));
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

        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
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

        public ListVswitchResponse ListVswitchWithOptions(ListVswitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DepositType"] = request.DepositType;
            query["ProductType"] = request.ProductType;
            query["RegionId"] = request.RegionId;
            query["VpcId"] = request.VpcId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVswitch",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVswitchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListVswitchResponse> ListVswitchWithOptionsAsync(ListVswitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DepositType"] = request.DepositType;
            query["ProductType"] = request.ProductType;
            query["RegionId"] = request.RegionId;
            query["VpcId"] = request.VpcId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVswitch",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVswitchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListVswitchResponse ListVswitch(ListVswitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVswitchWithOptions(request, runtime);
        }

        public async Task<ListVswitchResponse> ListVswitchAsync(ListVswitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVswitchWithOptionsAsync(request, runtime);
        }

        public ModifyClusterBootstrapActionResponse ModifyClusterBootstrapActionWithOptions(ModifyClusterBootstrapActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BootstrapAction"] = request.BootstrapAction;
            query["ClusterId"] = request.ClusterId;
            query["Id"] = request.Id;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterBootstrapAction",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterBootstrapActionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyClusterBootstrapActionResponse> ModifyClusterBootstrapActionWithOptionsAsync(ModifyClusterBootstrapActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BootstrapAction"] = request.BootstrapAction;
            query["ClusterId"] = request.ClusterId;
            query["Id"] = request.Id;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterBootstrapAction",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterBootstrapActionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyClusterBootstrapActionResponse ModifyClusterBootstrapAction(ModifyClusterBootstrapActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyClusterBootstrapActionWithOptions(request, runtime);
        }

        public async Task<ModifyClusterBootstrapActionResponse> ModifyClusterBootstrapActionAsync(ModifyClusterBootstrapActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyClusterBootstrapActionWithOptionsAsync(request, runtime);
        }

        public ModifyClusterHostGroupResponse ModifyClusterHostGroupWithOptions(ModifyClusterHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Comment"] = request.Comment;
            query["HostGroupId"] = request.HostGroupId;
            query["HostGroupName"] = request.HostGroupName;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityGroupId"] = request.SecurityGroupId;
            query["VswitchId"] = request.VswitchId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterHostGroup",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterHostGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyClusterHostGroupResponse> ModifyClusterHostGroupWithOptionsAsync(ModifyClusterHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Comment"] = request.Comment;
            query["HostGroupId"] = request.HostGroupId;
            query["HostGroupName"] = request.HostGroupName;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityGroupId"] = request.SecurityGroupId;
            query["VswitchId"] = request.VswitchId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterHostGroup",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterHostGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyClusterHostGroupResponse ModifyClusterHostGroup(ModifyClusterHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyClusterHostGroupWithOptions(request, runtime);
        }

        public async Task<ModifyClusterHostGroupResponse> ModifyClusterHostGroupAsync(ModifyClusterHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyClusterHostGroupWithOptionsAsync(request, runtime);
        }

        public ModifyClusterMetaCollectResponse ModifyClusterMetaCollectWithOptions(ModifyClusterMetaCollectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SwitchOn"] = request.SwitchOn;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterMetaCollect",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterMetaCollectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyClusterMetaCollectResponse> ModifyClusterMetaCollectWithOptionsAsync(ModifyClusterMetaCollectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SwitchOn"] = request.SwitchOn;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterMetaCollect",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterMetaCollectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyClusterMetaCollectResponse ModifyClusterMetaCollect(ModifyClusterMetaCollectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyClusterMetaCollectWithOptions(request, runtime);
        }

        public async Task<ModifyClusterMetaCollectResponse> ModifyClusterMetaCollectAsync(ModifyClusterMetaCollectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyClusterMetaCollectWithOptionsAsync(request, runtime);
        }

        public ModifyClusterNameResponse ModifyClusterNameWithOptions(ModifyClusterNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterName",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterNameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyClusterNameResponse> ModifyClusterNameWithOptionsAsync(ModifyClusterNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterName",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyClusterNameResponse ModifyClusterName(ModifyClusterNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyClusterNameWithOptions(request, runtime);
        }

        public async Task<ModifyClusterNameResponse> ModifyClusterNameAsync(ModifyClusterNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyClusterNameWithOptionsAsync(request, runtime);
        }

        public ModifyClusterSecurityGroupRuleResponse ModifyClusterSecurityGroupRuleWithOptions(ModifyClusterSecurityGroupRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["IpProtocol"] = request.IpProtocol;
            query["ModifyType"] = request.ModifyType;
            query["NicType"] = request.NicType;
            query["PortRange"] = request.PortRange;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["WhiteIp"] = request.WhiteIp;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterSecurityGroupRule",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterSecurityGroupRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyClusterSecurityGroupRuleResponse> ModifyClusterSecurityGroupRuleWithOptionsAsync(ModifyClusterSecurityGroupRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["IpProtocol"] = request.IpProtocol;
            query["ModifyType"] = request.ModifyType;
            query["NicType"] = request.NicType;
            query["PortRange"] = request.PortRange;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["WhiteIp"] = request.WhiteIp;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterSecurityGroupRule",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterSecurityGroupRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyClusterSecurityGroupRuleResponse ModifyClusterSecurityGroupRule(ModifyClusterSecurityGroupRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyClusterSecurityGroupRuleWithOptions(request, runtime);
        }

        public async Task<ModifyClusterSecurityGroupRuleResponse> ModifyClusterSecurityGroupRuleAsync(ModifyClusterSecurityGroupRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyClusterSecurityGroupRuleWithOptionsAsync(request, runtime);
        }

        public ModifyClusterServiceConfigResponse ModifyClusterServiceConfigWithOptions(ModifyClusterServiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Comment"] = request.Comment;
            query["ConfigParams"] = request.ConfigParams;
            query["ConfigType"] = request.ConfigType;
            query["CustomConfigParams"] = request.CustomConfigParams;
            query["GatewayClusterIdList"] = request.GatewayClusterIdList;
            query["GroupId"] = request.GroupId;
            query["HostInstanceId"] = request.HostInstanceId;
            query["RefreshHostConfig"] = request.RefreshHostConfig;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterServiceConfig",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterServiceConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyClusterServiceConfigResponse> ModifyClusterServiceConfigWithOptionsAsync(ModifyClusterServiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Comment"] = request.Comment;
            query["ConfigParams"] = request.ConfigParams;
            query["ConfigType"] = request.ConfigType;
            query["CustomConfigParams"] = request.CustomConfigParams;
            query["GatewayClusterIdList"] = request.GatewayClusterIdList;
            query["GroupId"] = request.GroupId;
            query["HostInstanceId"] = request.HostInstanceId;
            query["RefreshHostConfig"] = request.RefreshHostConfig;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceName"] = request.ServiceName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterServiceConfig",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterServiceConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyClusterServiceConfigResponse ModifyClusterServiceConfig(ModifyClusterServiceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyClusterServiceConfigWithOptions(request, runtime);
        }

        public async Task<ModifyClusterServiceConfigResponse> ModifyClusterServiceConfigAsync(ModifyClusterServiceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyClusterServiceConfigWithOptionsAsync(request, runtime);
        }

        public ModifyClusterTemplateResponse ModifyClusterTemplateWithOptions(ModifyClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoRenew"] = request.AutoRenew;
            query["BizId"] = request.BizId;
            query["BootstrapAction"] = request.BootstrapAction;
            query["ChargeType"] = request.ChargeType;
            query["ClusterType"] = request.ClusterType;
            query["Config"] = request.Config;
            query["Configurations"] = request.Configurations;
            query["DepositType"] = request.DepositType;
            query["EasEnable"] = request.EasEnable;
            query["EmrVer"] = request.EmrVer;
            query["HighAvailabilityEnable"] = request.HighAvailabilityEnable;
            query["HostGroup"] = request.HostGroup;
            query["InitCustomHiveMetaDb"] = request.InitCustomHiveMetaDb;
            query["InstanceGeneration"] = request.InstanceGeneration;
            query["IoOptimized"] = request.IoOptimized;
            query["IsOpenPublicIp"] = request.IsOpenPublicIp;
            query["KeyPairName"] = request.KeyPairName;
            query["LogPath"] = request.LogPath;
            query["MachineType"] = request.MachineType;
            query["MasterPwd"] = request.MasterPwd;
            query["MetaStoreConf"] = request.MetaStoreConf;
            query["MetaStoreType"] = request.MetaStoreType;
            query["NetType"] = request.NetType;
            query["OptionSoftWareList"] = request.OptionSoftWareList;
            query["Period"] = request.Period;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityGroupId"] = request.SecurityGroupId;
            query["SecurityGroupName"] = request.SecurityGroupName;
            query["SshEnable"] = request.SshEnable;
            query["Tag"] = request.Tag;
            query["TemplateName"] = request.TemplateName;
            query["UseCustomHiveMetaDb"] = request.UseCustomHiveMetaDb;
            query["UseLocalMetaDb"] = request.UseLocalMetaDb;
            query["UserDefinedEmrEcsRole"] = request.UserDefinedEmrEcsRole;
            query["VSwitchId"] = request.VSwitchId;
            query["VpcId"] = request.VpcId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterTemplate",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyClusterTemplateResponse> ModifyClusterTemplateWithOptionsAsync(ModifyClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoRenew"] = request.AutoRenew;
            query["BizId"] = request.BizId;
            query["BootstrapAction"] = request.BootstrapAction;
            query["ChargeType"] = request.ChargeType;
            query["ClusterType"] = request.ClusterType;
            query["Config"] = request.Config;
            query["Configurations"] = request.Configurations;
            query["DepositType"] = request.DepositType;
            query["EasEnable"] = request.EasEnable;
            query["EmrVer"] = request.EmrVer;
            query["HighAvailabilityEnable"] = request.HighAvailabilityEnable;
            query["HostGroup"] = request.HostGroup;
            query["InitCustomHiveMetaDb"] = request.InitCustomHiveMetaDb;
            query["InstanceGeneration"] = request.InstanceGeneration;
            query["IoOptimized"] = request.IoOptimized;
            query["IsOpenPublicIp"] = request.IsOpenPublicIp;
            query["KeyPairName"] = request.KeyPairName;
            query["LogPath"] = request.LogPath;
            query["MachineType"] = request.MachineType;
            query["MasterPwd"] = request.MasterPwd;
            query["MetaStoreConf"] = request.MetaStoreConf;
            query["MetaStoreType"] = request.MetaStoreType;
            query["NetType"] = request.NetType;
            query["OptionSoftWareList"] = request.OptionSoftWareList;
            query["Period"] = request.Period;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityGroupId"] = request.SecurityGroupId;
            query["SecurityGroupName"] = request.SecurityGroupName;
            query["SshEnable"] = request.SshEnable;
            query["Tag"] = request.Tag;
            query["TemplateName"] = request.TemplateName;
            query["UseCustomHiveMetaDb"] = request.UseCustomHiveMetaDb;
            query["UseLocalMetaDb"] = request.UseLocalMetaDb;
            query["UserDefinedEmrEcsRole"] = request.UserDefinedEmrEcsRole;
            query["VSwitchId"] = request.VSwitchId;
            query["VpcId"] = request.VpcId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterTemplate",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyClusterTemplateResponse ModifyClusterTemplate(ModifyClusterTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyClusterTemplateWithOptions(request, runtime);
        }

        public async Task<ModifyClusterTemplateResponse> ModifyClusterTemplateAsync(ModifyClusterTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyClusterTemplateWithOptionsAsync(request, runtime);
        }

        public ModifyExecutionPlanResponse ModifyExecutionPlanWithOptions(ModifyExecutionPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BootstrapAction"] = request.BootstrapAction;
            query["ClusterId"] = request.ClusterId;
            query["ClusterName"] = request.ClusterName;
            query["ClusterType"] = request.ClusterType;
            query["Config"] = request.Config;
            query["Configurations"] = request.Configurations;
            query["CreateClusterOnDemand"] = request.CreateClusterOnDemand;
            query["DayOfMonth"] = request.DayOfMonth;
            query["DayOfWeek"] = request.DayOfWeek;
            query["EasEnable"] = request.EasEnable;
            query["EcsOrder"] = request.EcsOrder;
            query["EmrVer"] = request.EmrVer;
            query["ExecutionPlanVersion"] = request.ExecutionPlanVersion;
            query["HighAvailabilityEnable"] = request.HighAvailabilityEnable;
            query["Id"] = request.Id;
            query["InitCustomHiveMetaDB"] = request.InitCustomHiveMetaDB;
            query["InstanceGeneration"] = request.InstanceGeneration;
            query["IoOptimized"] = request.IoOptimized;
            query["IsOpenPublicIp"] = request.IsOpenPublicIp;
            query["JobIdList"] = request.JobIdList;
            query["LogEnable"] = request.LogEnable;
            query["LogPath"] = request.LogPath;
            query["Name"] = request.Name;
            query["NetType"] = request.NetType;
            query["OptionSoftWareList"] = request.OptionSoftWareList;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityGroupId"] = request.SecurityGroupId;
            query["StartTime"] = request.StartTime;
            query["Strategy"] = request.Strategy;
            query["TimeInterval"] = request.TimeInterval;
            query["TimeUnit"] = request.TimeUnit;
            query["UseCustomHiveMetaDB"] = request.UseCustomHiveMetaDB;
            query["UseLocalMetaDb"] = request.UseLocalMetaDb;
            query["UserDefinedEmrEcsRole"] = request.UserDefinedEmrEcsRole;
            query["VSwitchId"] = request.VSwitchId;
            query["VpcId"] = request.VpcId;
            query["WorkflowDefinition"] = request.WorkflowDefinition;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyExecutionPlan",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyExecutionPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyExecutionPlanResponse> ModifyExecutionPlanWithOptionsAsync(ModifyExecutionPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BootstrapAction"] = request.BootstrapAction;
            query["ClusterId"] = request.ClusterId;
            query["ClusterName"] = request.ClusterName;
            query["ClusterType"] = request.ClusterType;
            query["Config"] = request.Config;
            query["Configurations"] = request.Configurations;
            query["CreateClusterOnDemand"] = request.CreateClusterOnDemand;
            query["DayOfMonth"] = request.DayOfMonth;
            query["DayOfWeek"] = request.DayOfWeek;
            query["EasEnable"] = request.EasEnable;
            query["EcsOrder"] = request.EcsOrder;
            query["EmrVer"] = request.EmrVer;
            query["ExecutionPlanVersion"] = request.ExecutionPlanVersion;
            query["HighAvailabilityEnable"] = request.HighAvailabilityEnable;
            query["Id"] = request.Id;
            query["InitCustomHiveMetaDB"] = request.InitCustomHiveMetaDB;
            query["InstanceGeneration"] = request.InstanceGeneration;
            query["IoOptimized"] = request.IoOptimized;
            query["IsOpenPublicIp"] = request.IsOpenPublicIp;
            query["JobIdList"] = request.JobIdList;
            query["LogEnable"] = request.LogEnable;
            query["LogPath"] = request.LogPath;
            query["Name"] = request.Name;
            query["NetType"] = request.NetType;
            query["OptionSoftWareList"] = request.OptionSoftWareList;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityGroupId"] = request.SecurityGroupId;
            query["StartTime"] = request.StartTime;
            query["Strategy"] = request.Strategy;
            query["TimeInterval"] = request.TimeInterval;
            query["TimeUnit"] = request.TimeUnit;
            query["UseCustomHiveMetaDB"] = request.UseCustomHiveMetaDB;
            query["UseLocalMetaDb"] = request.UseLocalMetaDb;
            query["UserDefinedEmrEcsRole"] = request.UserDefinedEmrEcsRole;
            query["VSwitchId"] = request.VSwitchId;
            query["VpcId"] = request.VpcId;
            query["WorkflowDefinition"] = request.WorkflowDefinition;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyExecutionPlan",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyExecutionPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyExecutionPlanResponse ModifyExecutionPlan(ModifyExecutionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyExecutionPlanWithOptions(request, runtime);
        }

        public async Task<ModifyExecutionPlanResponse> ModifyExecutionPlanAsync(ModifyExecutionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyExecutionPlanWithOptionsAsync(request, runtime);
        }

        public ModifyFlowResponse ModifyFlowWithOptions(ModifyFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AlertConf"] = request.AlertConf;
            query["AlertDingDingGroupBizId"] = request.AlertDingDingGroupBizId;
            query["AlertUserGroupBizId"] = request.AlertUserGroupBizId;
            query["Application"] = request.Application;
            query["ClusterId"] = request.ClusterId;
            query["CreateCluster"] = request.CreateCluster;
            query["CronExpr"] = request.CronExpr;
            query["Description"] = request.Description;
            query["EndSchedule"] = request.EndSchedule;
            query["HostName"] = request.HostName;
            query["Id"] = request.Id;
            query["Lifecycle"] = request.Lifecycle;
            query["LogArchiveLocation"] = request.LogArchiveLocation;
            query["Name"] = request.Name;
            query["Namespace"] = request.Namespace;
            query["ParentCategory"] = request.ParentCategory;
            query["ParentFlowList"] = request.ParentFlowList;
            query["Periodic"] = request.Periodic;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["StartSchedule"] = request.StartSchedule;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlow",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFlowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyFlowResponse> ModifyFlowWithOptionsAsync(ModifyFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AlertConf"] = request.AlertConf;
            query["AlertDingDingGroupBizId"] = request.AlertDingDingGroupBizId;
            query["AlertUserGroupBizId"] = request.AlertUserGroupBizId;
            query["Application"] = request.Application;
            query["ClusterId"] = request.ClusterId;
            query["CreateCluster"] = request.CreateCluster;
            query["CronExpr"] = request.CronExpr;
            query["Description"] = request.Description;
            query["EndSchedule"] = request.EndSchedule;
            query["HostName"] = request.HostName;
            query["Id"] = request.Id;
            query["Lifecycle"] = request.Lifecycle;
            query["LogArchiveLocation"] = request.LogArchiveLocation;
            query["Name"] = request.Name;
            query["Namespace"] = request.Namespace;
            query["ParentCategory"] = request.ParentCategory;
            query["ParentFlowList"] = request.ParentFlowList;
            query["Periodic"] = request.Periodic;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["StartSchedule"] = request.StartSchedule;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlow",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFlowResponse>(await CallApiAsync(params_, req, runtime));
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

        public ModifyFlowCategoryResponse ModifyFlowCategoryWithOptions(ModifyFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["Name"] = request.Name;
            query["ParentId"] = request.ParentId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowCategory",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFlowCategoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyFlowCategoryResponse> ModifyFlowCategoryWithOptionsAsync(ModifyFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["Name"] = request.Name;
            query["ParentId"] = request.ParentId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowCategory",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFlowCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyFlowCategoryResponse ModifyFlowCategory(ModifyFlowCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFlowCategoryWithOptions(request, runtime);
        }

        public async Task<ModifyFlowCategoryResponse> ModifyFlowCategoryAsync(ModifyFlowCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFlowCategoryWithOptionsAsync(request, runtime);
        }

        public ModifyFlowForWebResponse ModifyFlowForWebWithOptions(ModifyFlowForWebRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AlertConf"] = request.AlertConf;
            query["AlertDingDingGroupBizId"] = request.AlertDingDingGroupBizId;
            query["AlertUserGroupBizId"] = request.AlertUserGroupBizId;
            query["ClusterId"] = request.ClusterId;
            query["CreateCluster"] = request.CreateCluster;
            query["CronExpr"] = request.CronExpr;
            query["Description"] = request.Description;
            query["EndSchedule"] = request.EndSchedule;
            query["Graph"] = request.Graph;
            query["HostName"] = request.HostName;
            query["Id"] = request.Id;
            query["Lifecycle"] = request.Lifecycle;
            query["LogArchiveLocation"] = request.LogArchiveLocation;
            query["Name"] = request.Name;
            query["Namespace"] = request.Namespace;
            query["ParentCategory"] = request.ParentCategory;
            query["ParentFlowList"] = request.ParentFlowList;
            query["Periodic"] = request.Periodic;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["StartSchedule"] = request.StartSchedule;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowForWeb",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFlowForWebResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyFlowForWebResponse> ModifyFlowForWebWithOptionsAsync(ModifyFlowForWebRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AlertConf"] = request.AlertConf;
            query["AlertDingDingGroupBizId"] = request.AlertDingDingGroupBizId;
            query["AlertUserGroupBizId"] = request.AlertUserGroupBizId;
            query["ClusterId"] = request.ClusterId;
            query["CreateCluster"] = request.CreateCluster;
            query["CronExpr"] = request.CronExpr;
            query["Description"] = request.Description;
            query["EndSchedule"] = request.EndSchedule;
            query["Graph"] = request.Graph;
            query["HostName"] = request.HostName;
            query["Id"] = request.Id;
            query["Lifecycle"] = request.Lifecycle;
            query["LogArchiveLocation"] = request.LogArchiveLocation;
            query["Name"] = request.Name;
            query["Namespace"] = request.Namespace;
            query["ParentCategory"] = request.ParentCategory;
            query["ParentFlowList"] = request.ParentFlowList;
            query["Periodic"] = request.Periodic;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["StartSchedule"] = request.StartSchedule;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowForWeb",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFlowForWebResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyFlowForWebResponse ModifyFlowForWeb(ModifyFlowForWebRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFlowForWebWithOptions(request, runtime);
        }

        public async Task<ModifyFlowForWebResponse> ModifyFlowForWebAsync(ModifyFlowForWebRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFlowForWebWithOptionsAsync(request, runtime);
        }

        public ModifyFlowJobResponse ModifyFlowJobWithOptions(ModifyFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AlertConf"] = request.AlertConf;
            query["ClusterId"] = request.ClusterId;
            query["CustomVariables"] = request.CustomVariables;
            query["Description"] = request.Description;
            query["EnvConf"] = request.EnvConf;
            query["FailAct"] = request.FailAct;
            query["Id"] = request.Id;
            query["MaxRetry"] = request.MaxRetry;
            query["MaxRunningTimeSec"] = request.MaxRunningTimeSec;
            query["Mode"] = request.Mode;
            query["MonitorConf"] = request.MonitorConf;
            query["Name"] = request.Name;
            query["ParamConf"] = request.ParamConf;
            query["Params"] = request.Params;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["ResourceList"] = request.ResourceList;
            query["RetryInterval"] = request.RetryInterval;
            query["RetryPolicy"] = request.RetryPolicy;
            query["RunConf"] = request.RunConf;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFlowJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyFlowJobResponse> ModifyFlowJobWithOptionsAsync(ModifyFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AlertConf"] = request.AlertConf;
            query["ClusterId"] = request.ClusterId;
            query["CustomVariables"] = request.CustomVariables;
            query["Description"] = request.Description;
            query["EnvConf"] = request.EnvConf;
            query["FailAct"] = request.FailAct;
            query["Id"] = request.Id;
            query["MaxRetry"] = request.MaxRetry;
            query["MaxRunningTimeSec"] = request.MaxRunningTimeSec;
            query["Mode"] = request.Mode;
            query["MonitorConf"] = request.MonitorConf;
            query["Name"] = request.Name;
            query["ParamConf"] = request.ParamConf;
            query["Params"] = request.Params;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["ResourceList"] = request.ResourceList;
            query["RetryInterval"] = request.RetryInterval;
            query["RetryPolicy"] = request.RetryPolicy;
            query["RunConf"] = request.RunConf;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFlowJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyFlowJobResponse ModifyFlowJob(ModifyFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFlowJobWithOptions(request, runtime);
        }

        public async Task<ModifyFlowJobResponse> ModifyFlowJobAsync(ModifyFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFlowJobWithOptionsAsync(request, runtime);
        }

        public ModifyFlowProjectResponse ModifyFlowProjectWithOptions(ModifyFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowProject",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFlowProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyFlowProjectResponse> ModifyFlowProjectWithOptionsAsync(ModifyFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowProject",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFlowProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyFlowProjectResponse ModifyFlowProject(ModifyFlowProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFlowProjectWithOptions(request, runtime);
        }

        public async Task<ModifyFlowProjectResponse> ModifyFlowProjectAsync(ModifyFlowProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFlowProjectWithOptionsAsync(request, runtime);
        }

        public ModifyFlowProjectClusterSettingResponse ModifyFlowProjectClusterSettingWithOptions(ModifyFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["DefaultQueue"] = request.DefaultQueue;
            query["DefaultUser"] = request.DefaultUser;
            query["HostList"] = request.HostList;
            query["ProjectId"] = request.ProjectId;
            query["QueueList"] = request.QueueList;
            query["RegionId"] = request.RegionId;
            query["UserList"] = request.UserList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowProjectClusterSetting",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFlowProjectClusterSettingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyFlowProjectClusterSettingResponse> ModifyFlowProjectClusterSettingWithOptionsAsync(ModifyFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["DefaultQueue"] = request.DefaultQueue;
            query["DefaultUser"] = request.DefaultUser;
            query["HostList"] = request.HostList;
            query["ProjectId"] = request.ProjectId;
            query["QueueList"] = request.QueueList;
            query["RegionId"] = request.RegionId;
            query["UserList"] = request.UserList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowProjectClusterSetting",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFlowProjectClusterSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyFlowProjectClusterSettingResponse ModifyFlowProjectClusterSetting(ModifyFlowProjectClusterSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFlowProjectClusterSettingWithOptions(request, runtime);
        }

        public async Task<ModifyFlowProjectClusterSettingResponse> ModifyFlowProjectClusterSettingAsync(ModifyFlowProjectClusterSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFlowProjectClusterSettingWithOptionsAsync(request, runtime);
        }

        public ModifyJobResponse ModifyJobWithOptions(ModifyJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["FailAct"] = request.FailAct;
            query["Id"] = request.Id;
            query["MaxRetry"] = request.MaxRetry;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RetryInterval"] = request.RetryInterval;
            query["RunParameter"] = request.RunParameter;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyJobResponse> ModifyJobWithOptionsAsync(ModifyJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["FailAct"] = request.FailAct;
            query["Id"] = request.Id;
            query["MaxRetry"] = request.MaxRetry;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RetryInterval"] = request.RetryInterval;
            query["RunParameter"] = request.RunParameter;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyJobResponse ModifyJob(ModifyJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyJobWithOptions(request, runtime);
        }

        public async Task<ModifyJobResponse> ModifyJobAsync(ModifyJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyJobWithOptionsAsync(request, runtime);
        }

        public ModifyResourcePoolResponse ModifyResourcePoolWithOptions(ModifyResourcePoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Active"] = request.Active;
            query["ClusterId"] = request.ClusterId;
            query["Config"] = request.Config;
            query["Id"] = request.Id;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Yarnsiteconfig"] = request.Yarnsiteconfig;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyResourcePool",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyResourcePoolResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyResourcePoolResponse> ModifyResourcePoolWithOptionsAsync(ModifyResourcePoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Active"] = request.Active;
            query["ClusterId"] = request.ClusterId;
            query["Config"] = request.Config;
            query["Id"] = request.Id;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Yarnsiteconfig"] = request.Yarnsiteconfig;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyResourcePool",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyResourcePoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyResourcePoolResponse ModifyResourcePool(ModifyResourcePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyResourcePoolWithOptions(request, runtime);
        }

        public async Task<ModifyResourcePoolResponse> ModifyResourcePoolAsync(ModifyResourcePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyResourcePoolWithOptionsAsync(request, runtime);
        }

        public ModifyResourcePoolSchedulerTypeResponse ModifyResourcePoolSchedulerTypeWithOptions(ModifyResourcePoolSchedulerTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SchedulerType"] = request.SchedulerType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyResourcePoolSchedulerType",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyResourcePoolSchedulerTypeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyResourcePoolSchedulerTypeResponse> ModifyResourcePoolSchedulerTypeWithOptionsAsync(ModifyResourcePoolSchedulerTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SchedulerType"] = request.SchedulerType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyResourcePoolSchedulerType",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyResourcePoolSchedulerTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyResourcePoolSchedulerTypeResponse ModifyResourcePoolSchedulerType(ModifyResourcePoolSchedulerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyResourcePoolSchedulerTypeWithOptions(request, runtime);
        }

        public async Task<ModifyResourcePoolSchedulerTypeResponse> ModifyResourcePoolSchedulerTypeAsync(ModifyResourcePoolSchedulerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyResourcePoolSchedulerTypeWithOptionsAsync(request, runtime);
        }

        public ModifyResourceQueueResponse ModifyResourceQueueWithOptions(ModifyResourceQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Config"] = request.Config;
            query["Id"] = request.Id;
            query["Leaf"] = request.Leaf;
            query["Name"] = request.Name;
            query["ParentQueueId"] = request.ParentQueueId;
            query["QualifiedName"] = request.QualifiedName;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourcePoolId"] = request.ResourcePoolId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyResourceQueue",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyResourceQueueResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyResourceQueueResponse> ModifyResourceQueueWithOptionsAsync(ModifyResourceQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Config"] = request.Config;
            query["Id"] = request.Id;
            query["Leaf"] = request.Leaf;
            query["Name"] = request.Name;
            query["ParentQueueId"] = request.ParentQueueId;
            query["QualifiedName"] = request.QualifiedName;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourcePoolId"] = request.ResourcePoolId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyResourceQueue",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyResourceQueueResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyResourceQueueResponse ModifyResourceQueue(ModifyResourceQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyResourceQueueWithOptions(request, runtime);
        }

        public async Task<ModifyResourceQueueResponse> ModifyResourceQueueAsync(ModifyResourceQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyResourceQueueWithOptionsAsync(request, runtime);
        }

        public ModifyScalingConfigItemV2Response ModifyScalingConfigItemV2WithOptions(ModifyScalingConfigItemV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ConfigItemBizId"] = request.ConfigItemBizId;
            query["ConfigItemInformation"] = request.ConfigItemInformation;
            query["ConfigItemType"] = request.ConfigItemType;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingGroupBizId"] = request.ScalingGroupBizId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScalingConfigItemV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScalingConfigItemV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyScalingConfigItemV2Response> ModifyScalingConfigItemV2WithOptionsAsync(ModifyScalingConfigItemV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ConfigItemBizId"] = request.ConfigItemBizId;
            query["ConfigItemInformation"] = request.ConfigItemInformation;
            query["ConfigItemType"] = request.ConfigItemType;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingGroupBizId"] = request.ScalingGroupBizId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScalingConfigItemV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScalingConfigItemV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyScalingConfigItemV2Response ModifyScalingConfigItemV2(ModifyScalingConfigItemV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScalingConfigItemV2WithOptions(request, runtime);
        }

        public async Task<ModifyScalingConfigItemV2Response> ModifyScalingConfigItemV2Async(ModifyScalingConfigItemV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScalingConfigItemV2WithOptionsAsync(request, runtime);
        }

        public ModifyScalingGroupV2Response ModifyScalingGroupV2WithOptions(ModifyScalingGroupV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingGroupBizId"] = request.ScalingGroupBizId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScalingGroupV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScalingGroupV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyScalingGroupV2Response> ModifyScalingGroupV2WithOptionsAsync(ModifyScalingGroupV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingGroupBizId"] = request.ScalingGroupBizId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScalingGroupV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScalingGroupV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyScalingGroupV2Response ModifyScalingGroupV2(ModifyScalingGroupV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScalingGroupV2WithOptions(request, runtime);
        }

        public async Task<ModifyScalingGroupV2Response> ModifyScalingGroupV2Async(ModifyScalingGroupV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScalingGroupV2WithOptionsAsync(request, runtime);
        }

        public ModifyScalingRuleResponse ModifyScalingRuleWithOptions(ModifyScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AdjustmentType"] = request.AdjustmentType;
            query["AdjustmentValue"] = request.AdjustmentValue;
            query["CloudWatchTrigger"] = request.CloudWatchTrigger;
            query["ClusterId"] = request.ClusterId;
            query["Cooldown"] = request.Cooldown;
            query["HostGroupId"] = request.HostGroupId;
            query["LaunchExpirationTime"] = request.LaunchExpirationTime;
            query["LaunchTime"] = request.LaunchTime;
            query["RecurrenceEndTime"] = request.RecurrenceEndTime;
            query["RecurrenceType"] = request.RecurrenceType;
            query["RecurrenceValue"] = request.RecurrenceValue;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RuleName"] = request.RuleName;
            query["ScalingRuleId"] = request.ScalingRuleId;
            query["SchedulerTrigger"] = request.SchedulerTrigger;
            query["TimeoutWithGrace"] = request.TimeoutWithGrace;
            query["WithGrace"] = request.WithGrace;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScalingRule",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyScalingRuleResponse> ModifyScalingRuleWithOptionsAsync(ModifyScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AdjustmentType"] = request.AdjustmentType;
            query["AdjustmentValue"] = request.AdjustmentValue;
            query["CloudWatchTrigger"] = request.CloudWatchTrigger;
            query["ClusterId"] = request.ClusterId;
            query["Cooldown"] = request.Cooldown;
            query["HostGroupId"] = request.HostGroupId;
            query["LaunchExpirationTime"] = request.LaunchExpirationTime;
            query["LaunchTime"] = request.LaunchTime;
            query["RecurrenceEndTime"] = request.RecurrenceEndTime;
            query["RecurrenceType"] = request.RecurrenceType;
            query["RecurrenceValue"] = request.RecurrenceValue;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RuleName"] = request.RuleName;
            query["ScalingRuleId"] = request.ScalingRuleId;
            query["SchedulerTrigger"] = request.SchedulerTrigger;
            query["TimeoutWithGrace"] = request.TimeoutWithGrace;
            query["WithGrace"] = request.WithGrace;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScalingRule",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
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

        public ModifyScalingTaskGroupResponse ModifyScalingTaskGroupWithOptions(ModifyScalingTaskGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ActiveRuleCategory"] = request.ActiveRuleCategory;
            query["ClusterId"] = request.ClusterId;
            query["DefaultCooldown"] = request.DefaultCooldown;
            query["HostGroupId"] = request.HostGroupId;
            query["MaxSize"] = request.MaxSize;
            query["MinSize"] = request.MinSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TimeoutWithGrace"] = request.TimeoutWithGrace;
            query["WithGrace"] = request.WithGrace;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScalingTaskGroup",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScalingTaskGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyScalingTaskGroupResponse> ModifyScalingTaskGroupWithOptionsAsync(ModifyScalingTaskGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ActiveRuleCategory"] = request.ActiveRuleCategory;
            query["ClusterId"] = request.ClusterId;
            query["DefaultCooldown"] = request.DefaultCooldown;
            query["HostGroupId"] = request.HostGroupId;
            query["MaxSize"] = request.MaxSize;
            query["MinSize"] = request.MinSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TimeoutWithGrace"] = request.TimeoutWithGrace;
            query["WithGrace"] = request.WithGrace;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScalingTaskGroup",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScalingTaskGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyScalingTaskGroupResponse ModifyScalingTaskGroup(ModifyScalingTaskGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScalingTaskGroupWithOptions(request, runtime);
        }

        public async Task<ModifyScalingTaskGroupResponse> ModifyScalingTaskGroupAsync(ModifyScalingTaskGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScalingTaskGroupWithOptionsAsync(request, runtime);
        }

        public QueryEntityResponse QueryEntityWithOptions(QueryEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Category"] = request.Category;
            query["Description"] = request.Description;
            query["Id"] = request.Id;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEntity",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEntityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryEntityResponse> QueryEntityWithOptionsAsync(QueryEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Category"] = request.Category;
            query["Description"] = request.Description;
            query["Id"] = request.Id;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEntity",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEntityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryEntityResponse QueryEntity(QueryEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEntityWithOptions(request, runtime);
        }

        public async Task<QueryEntityResponse> QueryEntityAsync(QueryEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEntityWithOptionsAsync(request, runtime);
        }

        public QueryTagResponse QueryTagWithOptions(QueryTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EntityId"] = request.EntityId;
            query["EntityType"] = request.EntityType;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TagId"] = request.TagId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTag",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTagResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTagResponse> QueryTagWithOptionsAsync(QueryTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EntityId"] = request.EntityId;
            query["EntityType"] = request.EntityType;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TagId"] = request.TagId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTag",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTagResponse QueryTag(QueryTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTagWithOptions(request, runtime);
        }

        public async Task<QueryTagResponse> QueryTagAsync(QueryTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTagWithOptionsAsync(request, runtime);
        }

        public RefreshClusterResourcePoolResponse RefreshClusterResourcePoolWithOptions(RefreshClusterResourcePoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourcePoolId"] = request.ResourcePoolId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshClusterResourcePool",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshClusterResourcePoolResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RefreshClusterResourcePoolResponse> RefreshClusterResourcePoolWithOptionsAsync(RefreshClusterResourcePoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourcePoolId"] = request.ResourcePoolId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshClusterResourcePool",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshClusterResourcePoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RefreshClusterResourcePoolResponse RefreshClusterResourcePool(RefreshClusterResourcePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshClusterResourcePoolWithOptions(request, runtime);
        }

        public async Task<RefreshClusterResourcePoolResponse> RefreshClusterResourcePoolAsync(RefreshClusterResourcePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshClusterResourcePoolWithOptionsAsync(request, runtime);
        }

        public ReleaseClusterResponse ReleaseClusterWithOptions(ReleaseClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ForceRelease"] = request.ForceRelease;
            query["Id"] = request.Id;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseCluster",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReleaseClusterResponse> ReleaseClusterWithOptionsAsync(ReleaseClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ForceRelease"] = request.ForceRelease;
            query["Id"] = request.Id;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseCluster",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReleaseClusterResponse ReleaseCluster(ReleaseClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseClusterWithOptions(request, runtime);
        }

        public async Task<ReleaseClusterResponse> ReleaseClusterAsync(ReleaseClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseClusterWithOptionsAsync(request, runtime);
        }

        public ReleaseClusterHostGroupResponse ReleaseClusterHostGroupWithOptions(ReleaseClusterHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["HostGroupId"] = request.HostGroupId;
            query["InstanceIdList"] = request.InstanceIdList;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseClusterHostGroup",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseClusterHostGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReleaseClusterHostGroupResponse> ReleaseClusterHostGroupWithOptionsAsync(ReleaseClusterHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["HostGroupId"] = request.HostGroupId;
            query["InstanceIdList"] = request.InstanceIdList;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseClusterHostGroup",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseClusterHostGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReleaseClusterHostGroupResponse ReleaseClusterHostGroup(ReleaseClusterHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseClusterHostGroupWithOptions(request, runtime);
        }

        public async Task<ReleaseClusterHostGroupResponse> ReleaseClusterHostGroupAsync(ReleaseClusterHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseClusterHostGroupWithOptionsAsync(request, runtime);
        }

        public RemoveScalingConfigItemV2Response RemoveScalingConfigItemV2WithOptions(RemoveScalingConfigItemV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ConfigItemBizId"] = request.ConfigItemBizId;
            query["ConfigItemType"] = request.ConfigItemType;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingGroupBizId"] = request.ScalingGroupBizId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveScalingConfigItemV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveScalingConfigItemV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveScalingConfigItemV2Response> RemoveScalingConfigItemV2WithOptionsAsync(RemoveScalingConfigItemV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ConfigItemBizId"] = request.ConfigItemBizId;
            query["ConfigItemType"] = request.ConfigItemType;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingGroupBizId"] = request.ScalingGroupBizId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveScalingConfigItemV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveScalingConfigItemV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveScalingConfigItemV2Response RemoveScalingConfigItemV2(RemoveScalingConfigItemV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveScalingConfigItemV2WithOptions(request, runtime);
        }

        public async Task<RemoveScalingConfigItemV2Response> RemoveScalingConfigItemV2Async(RemoveScalingConfigItemV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveScalingConfigItemV2WithOptionsAsync(request, runtime);
        }

        public RerunFlowResponse RerunFlowWithOptions(RerunFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["FlowInstanceId"] = request.FlowInstanceId;
            query["ProjectId"] = request.ProjectId;
            query["ReRunFail"] = request.ReRunFail;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RerunFlow",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RerunFlowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RerunFlowResponse> RerunFlowWithOptionsAsync(RerunFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["FlowInstanceId"] = request.FlowInstanceId;
            query["ProjectId"] = request.ProjectId;
            query["ReRunFail"] = request.ReRunFail;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RerunFlow",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RerunFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RerunFlowResponse RerunFlow(RerunFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RerunFlowWithOptions(request, runtime);
        }

        public async Task<RerunFlowResponse> RerunFlowAsync(RerunFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RerunFlowWithOptionsAsync(request, runtime);
        }

        public ResizeClusterV2Response ResizeClusterV2WithOptions(ResizeClusterV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoPayOrder"] = request.AutoPayOrder;
            query["ClusterId"] = request.ClusterId;
            query["HostComponentInfo"] = request.HostComponentInfo;
            query["HostGroup"] = request.HostGroup;
            query["IsOpenPublicIp"] = request.IsOpenPublicIp;
            query["PromotionInfo"] = request.PromotionInfo;
            query["RegionId"] = request.RegionId;
            query["VswitchId"] = request.VswitchId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResizeClusterV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResizeClusterV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<ResizeClusterV2Response> ResizeClusterV2WithOptionsAsync(ResizeClusterV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoPayOrder"] = request.AutoPayOrder;
            query["ClusterId"] = request.ClusterId;
            query["HostComponentInfo"] = request.HostComponentInfo;
            query["HostGroup"] = request.HostGroup;
            query["IsOpenPublicIp"] = request.IsOpenPublicIp;
            query["PromotionInfo"] = request.PromotionInfo;
            query["RegionId"] = request.RegionId;
            query["VswitchId"] = request.VswitchId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResizeClusterV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResizeClusterV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public ResizeClusterV2Response ResizeClusterV2(ResizeClusterV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResizeClusterV2WithOptions(request, runtime);
        }

        public async Task<ResizeClusterV2Response> ResizeClusterV2Async(ResizeClusterV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResizeClusterV2WithOptionsAsync(request, runtime);
        }

        public ResumeExecutionPlanSchedulerResponse ResumeExecutionPlanSchedulerWithOptions(ResumeExecutionPlanSchedulerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeExecutionPlanScheduler",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeExecutionPlanSchedulerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ResumeExecutionPlanSchedulerResponse> ResumeExecutionPlanSchedulerWithOptionsAsync(ResumeExecutionPlanSchedulerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeExecutionPlanScheduler",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeExecutionPlanSchedulerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ResumeExecutionPlanSchedulerResponse ResumeExecutionPlanScheduler(ResumeExecutionPlanSchedulerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeExecutionPlanSchedulerWithOptions(request, runtime);
        }

        public async Task<ResumeExecutionPlanSchedulerResponse> ResumeExecutionPlanSchedulerAsync(ResumeExecutionPlanSchedulerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeExecutionPlanSchedulerWithOptionsAsync(request, runtime);
        }

        public ResumeFlowResponse ResumeFlowWithOptions(ResumeFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["FlowInstanceId"] = request.FlowInstanceId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeFlow",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeFlowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ResumeFlowResponse> ResumeFlowWithOptionsAsync(ResumeFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["FlowInstanceId"] = request.FlowInstanceId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeFlow",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ResumeFlowResponse ResumeFlow(ResumeFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeFlowWithOptions(request, runtime);
        }

        public async Task<ResumeFlowResponse> ResumeFlowAsync(ResumeFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeFlowWithOptionsAsync(request, runtime);
        }

        public RetryOperationResponse RetryOperationWithOptions(RetryOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OperationId"] = request.OperationId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryOperation",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryOperationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RetryOperationResponse> RetryOperationWithOptionsAsync(RetryOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OperationId"] = request.OperationId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryOperation",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryOperationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RetryOperationResponse RetryOperation(RetryOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RetryOperationWithOptions(request, runtime);
        }

        public async Task<RetryOperationResponse> RetryOperationAsync(RetryOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RetryOperationWithOptionsAsync(request, runtime);
        }

        public RunClusterServiceActionResponse RunClusterServiceActionWithOptions(RunClusterServiceActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Comment"] = request.Comment;
            query["ComponentNameList"] = request.ComponentNameList;
            query["CustomCommand"] = request.CustomCommand;
            query["CustomParams"] = request.CustomParams;
            query["ExecuteStrategy"] = request.ExecuteStrategy;
            query["HostGroupIdList"] = request.HostGroupIdList;
            query["HostIdList"] = request.HostIdList;
            query["Interval"] = request.Interval;
            query["IsRolling"] = request.IsRolling;
            query["NodeCountPerBatch"] = request.NodeCountPerBatch;
            query["OnlyRestartStaleConfigNodes"] = request.OnlyRestartStaleConfigNodes;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceActionName"] = request.ServiceActionName;
            query["ServiceName"] = request.ServiceName;
            query["TotlerateFailCount"] = request.TotlerateFailCount;
            query["TurnOnMaintenanceMode"] = request.TurnOnMaintenanceMode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunClusterServiceAction",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunClusterServiceActionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RunClusterServiceActionResponse> RunClusterServiceActionWithOptionsAsync(RunClusterServiceActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Comment"] = request.Comment;
            query["ComponentNameList"] = request.ComponentNameList;
            query["CustomCommand"] = request.CustomCommand;
            query["CustomParams"] = request.CustomParams;
            query["ExecuteStrategy"] = request.ExecuteStrategy;
            query["HostGroupIdList"] = request.HostGroupIdList;
            query["HostIdList"] = request.HostIdList;
            query["Interval"] = request.Interval;
            query["IsRolling"] = request.IsRolling;
            query["NodeCountPerBatch"] = request.NodeCountPerBatch;
            query["OnlyRestartStaleConfigNodes"] = request.OnlyRestartStaleConfigNodes;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ServiceActionName"] = request.ServiceActionName;
            query["ServiceName"] = request.ServiceName;
            query["TotlerateFailCount"] = request.TotlerateFailCount;
            query["TurnOnMaintenanceMode"] = request.TurnOnMaintenanceMode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunClusterServiceAction",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunClusterServiceActionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RunClusterServiceActionResponse RunClusterServiceAction(RunClusterServiceActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunClusterServiceActionWithOptions(request, runtime);
        }

        public async Task<RunClusterServiceActionResponse> RunClusterServiceActionAsync(RunClusterServiceActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunClusterServiceActionWithOptionsAsync(request, runtime);
        }

        public RunDiskOpsActivityResponse RunDiskOpsActivityWithOptions(RunDiskOpsActivityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["CurrentStage"] = request.CurrentStage;
            query["CurrentState"] = request.CurrentState;
            query["DiskId"] = request.DiskId;
            query["EventId"] = request.EventId;
            query["InstanceId"] = request.InstanceId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDiskOpsActivity",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDiskOpsActivityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RunDiskOpsActivityResponse> RunDiskOpsActivityWithOptionsAsync(RunDiskOpsActivityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["CurrentStage"] = request.CurrentStage;
            query["CurrentState"] = request.CurrentState;
            query["DiskId"] = request.DiskId;
            query["EventId"] = request.EventId;
            query["InstanceId"] = request.InstanceId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDiskOpsActivity",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDiskOpsActivityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RunDiskOpsActivityResponse RunDiskOpsActivity(RunDiskOpsActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunDiskOpsActivityWithOptions(request, runtime);
        }

        public async Task<RunDiskOpsActivityResponse> RunDiskOpsActivityAsync(RunDiskOpsActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunDiskOpsActivityWithOptionsAsync(request, runtime);
        }

        public RunExecutionPlanResponse RunExecutionPlanWithOptions(RunExecutionPlanRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunExecutionPlanShrinkRequest request = new RunExecutionPlanShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Arguments))
            {
                request.ArgumentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Arguments, "Arguments", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Arguments"] = request.ArgumentsShrink;
            query["Id"] = request.Id;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunExecutionPlan",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunExecutionPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RunExecutionPlanResponse> RunExecutionPlanWithOptionsAsync(RunExecutionPlanRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunExecutionPlanShrinkRequest request = new RunExecutionPlanShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Arguments))
            {
                request.ArgumentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Arguments, "Arguments", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Arguments"] = request.ArgumentsShrink;
            query["Id"] = request.Id;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunExecutionPlan",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunExecutionPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RunExecutionPlanResponse RunExecutionPlan(RunExecutionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunExecutionPlanWithOptions(request, runtime);
        }

        public async Task<RunExecutionPlanResponse> RunExecutionPlanAsync(RunExecutionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunExecutionPlanWithOptionsAsync(request, runtime);
        }

        public RunScalingActionV2Response RunScalingActionV2WithOptions(RunScalingActionV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ActionParam"] = request.ActionParam;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingActionType"] = request.ScalingActionType;
            query["ScalingGroupBizId"] = request.ScalingGroupBizId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunScalingActionV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunScalingActionV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<RunScalingActionV2Response> RunScalingActionV2WithOptionsAsync(RunScalingActionV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ActionParam"] = request.ActionParam;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ScalingActionType"] = request.ScalingActionType;
            query["ScalingGroupBizId"] = request.ScalingGroupBizId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunScalingActionV2",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunScalingActionV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public RunScalingActionV2Response RunScalingActionV2(RunScalingActionV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunScalingActionV2WithOptions(request, runtime);
        }

        public async Task<RunScalingActionV2Response> RunScalingActionV2Async(RunScalingActionV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunScalingActionV2WithOptionsAsync(request, runtime);
        }

        public SearchLogResponse SearchLogWithOptions(SearchLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["FromTimestamp"] = request.FromTimestamp;
            query["HostInnerIp"] = request.HostInnerIp;
            query["HostName"] = request.HostName;
            query["Line"] = request.Line;
            query["LogstoreName"] = request.LogstoreName;
            query["Offset"] = request.Offset;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Reverse"] = request.Reverse;
            query["SlsQueryString"] = request.SlsQueryString;
            query["ToTimestamp"] = request.ToTimestamp;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchLog",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SearchLogResponse> SearchLogWithOptionsAsync(SearchLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["FromTimestamp"] = request.FromTimestamp;
            query["HostInnerIp"] = request.HostInnerIp;
            query["HostName"] = request.HostName;
            query["Line"] = request.Line;
            query["LogstoreName"] = request.LogstoreName;
            query["Offset"] = request.Offset;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Reverse"] = request.Reverse;
            query["SlsQueryString"] = request.SlsQueryString;
            query["ToTimestamp"] = request.ToTimestamp;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchLog",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SearchLogResponse SearchLog(SearchLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchLogWithOptions(request, runtime);
        }

        public async Task<SearchLogResponse> SearchLogAsync(SearchLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchLogWithOptionsAsync(request, runtime);
        }

        public StartFlowResponse StartFlowWithOptions(StartFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["FlowInstanceId"] = request.FlowInstanceId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartFlow",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartFlowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartFlowResponse> StartFlowWithOptionsAsync(StartFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["FlowInstanceId"] = request.FlowInstanceId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartFlow",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartFlowResponse StartFlow(StartFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartFlowWithOptions(request, runtime);
        }

        public async Task<StartFlowResponse> StartFlowAsync(StartFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartFlowWithOptionsAsync(request, runtime);
        }

        public SubmitFlowResponse SubmitFlowWithOptions(SubmitFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Conf"] = request.Conf;
            query["FlowId"] = request.FlowId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitFlow",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitFlowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitFlowResponse> SubmitFlowWithOptionsAsync(SubmitFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Conf"] = request.Conf;
            query["FlowId"] = request.FlowId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitFlow",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitFlowResponse SubmitFlow(SubmitFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitFlowWithOptions(request, runtime);
        }

        public async Task<SubmitFlowResponse> SubmitFlowAsync(SubmitFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitFlowWithOptionsAsync(request, runtime);
        }

        public SubmitFlowJobResponse SubmitFlowJobWithOptions(SubmitFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Conf"] = request.Conf;
            query["HostName"] = request.HostName;
            query["JobId"] = request.JobId;
            query["JobInstanceId"] = request.JobInstanceId;
            query["Namespace"] = request.Namespace;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitFlowJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitFlowJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitFlowJobResponse> SubmitFlowJobWithOptionsAsync(SubmitFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterId"] = request.ClusterId;
            query["Conf"] = request.Conf;
            query["HostName"] = request.HostName;
            query["JobId"] = request.JobId;
            query["JobInstanceId"] = request.JobInstanceId;
            query["Namespace"] = request.Namespace;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitFlowJob",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitFlowJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitFlowJobResponse SubmitFlowJob(SubmitFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitFlowJobWithOptions(request, runtime);
        }

        public async Task<SubmitFlowJobResponse> SubmitFlowJobAsync(SubmitFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitFlowJobWithOptionsAsync(request, runtime);
        }

        public SuspendExecutionPlanSchedulerResponse SuspendExecutionPlanSchedulerWithOptions(SuspendExecutionPlanSchedulerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendExecutionPlanScheduler",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendExecutionPlanSchedulerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SuspendExecutionPlanSchedulerResponse> SuspendExecutionPlanSchedulerWithOptionsAsync(SuspendExecutionPlanSchedulerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Id"] = request.Id;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendExecutionPlanScheduler",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendExecutionPlanSchedulerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SuspendExecutionPlanSchedulerResponse SuspendExecutionPlanScheduler(SuspendExecutionPlanSchedulerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendExecutionPlanSchedulerWithOptions(request, runtime);
        }

        public async Task<SuspendExecutionPlanSchedulerResponse> SuspendExecutionPlanSchedulerAsync(SuspendExecutionPlanSchedulerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendExecutionPlanSchedulerWithOptionsAsync(request, runtime);
        }

        public SuspendFlowResponse SuspendFlowWithOptions(SuspendFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["FlowInstanceId"] = request.FlowInstanceId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendFlow",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendFlowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SuspendFlowResponse> SuspendFlowWithOptionsAsync(SuspendFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["FlowInstanceId"] = request.FlowInstanceId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendFlow",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SuspendFlowResponse SuspendFlow(SuspendFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendFlowWithOptions(request, runtime);
        }

        public async Task<SuspendFlowResponse> SuspendFlowAsync(SuspendFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendFlowWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
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

        public UninstallLibrariesResponse UninstallLibrariesWithOptions(UninstallLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterBizIdList"] = request.ClusterBizIdList;
            query["LibraryBizId"] = request.LibraryBizId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallLibraries",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallLibrariesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UninstallLibrariesResponse> UninstallLibrariesWithOptionsAsync(UninstallLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterBizIdList"] = request.ClusterBizIdList;
            query["LibraryBizId"] = request.LibraryBizId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallLibraries",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallLibrariesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UninstallLibrariesResponse UninstallLibraries(UninstallLibrariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UninstallLibrariesWithOptions(request, runtime);
        }

        public async Task<UninstallLibrariesResponse> UninstallLibrariesAsync(UninstallLibrariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UninstallLibrariesWithOptionsAsync(request, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["All"] = request.All;
            query["RegionId"] = request.RegionId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            query["TagKey"] = request.TagKey;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["All"] = request.All;
            query["RegionId"] = request.RegionId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            query["TagKey"] = request.TagKey;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
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

        public UpdateDataSourceResponse UpdateDataSourceWithOptions(UpdateDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Conf"] = request.Conf;
            query["Description"] = request.Description;
            query["Id"] = request.Id;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataSource",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataSourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateDataSourceResponse> UpdateDataSourceWithOptionsAsync(UpdateDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Conf"] = request.Conf;
            query["Description"] = request.Description;
            query["Id"] = request.Id;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataSource",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataSourceWithOptions(request, runtime);
        }

        public async Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataSourceWithOptionsAsync(request, runtime);
        }

        public UpdateLibraryInstallTaskStatusResponse UpdateLibraryInstallTaskStatusWithOptions(UpdateLibraryInstallTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Status"] = request.Status;
            query["TaskBizId"] = request.TaskBizId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLibraryInstallTaskStatus",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLibraryInstallTaskStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateLibraryInstallTaskStatusResponse> UpdateLibraryInstallTaskStatusWithOptionsAsync(UpdateLibraryInstallTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Status"] = request.Status;
            query["TaskBizId"] = request.TaskBizId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLibraryInstallTaskStatus",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLibraryInstallTaskStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateLibraryInstallTaskStatusResponse UpdateLibraryInstallTaskStatus(UpdateLibraryInstallTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLibraryInstallTaskStatusWithOptions(request, runtime);
        }

        public async Task<UpdateLibraryInstallTaskStatusResponse> UpdateLibraryInstallTaskStatusAsync(UpdateLibraryInstallTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLibraryInstallTaskStatusWithOptionsAsync(request, runtime);
        }

        public UpdateTagResponse UpdateTagWithOptions(UpdateTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Category"] = request.Category;
            query["Description"] = request.Description;
            query["Id"] = request.Id;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTag",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTagResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateTagResponse> UpdateTagWithOptionsAsync(UpdateTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Category"] = request.Category;
            query["Description"] = request.Description;
            query["Id"] = request.Id;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTag",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateTagResponse UpdateTag(UpdateTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTagWithOptions(request, runtime);
        }

        public async Task<UpdateTagResponse> UpdateTagAsync(UpdateTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTagWithOptionsAsync(request, runtime);
        }

        public UpdateUserResponse UpdateUserWithOptions(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AliyunUserId"] = request.AliyunUserId;
            query["Description"] = request.Description;
            query["GroupIdList"] = request.GroupIdList;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RoleIdList"] = request.RoleIdList;
            query["Status"] = request.Status;
            query["UserAccountParamList"] = request.UserAccountParamList;
            query["UserName"] = request.UserName;
            query["UserType"] = request.UserType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateUserResponse> UpdateUserWithOptionsAsync(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AliyunUserId"] = request.AliyunUserId;
            query["Description"] = request.Description;
            query["GroupIdList"] = request.GroupIdList;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RoleIdList"] = request.RoleIdList;
            query["Status"] = request.Status;
            query["UserAccountParamList"] = request.UserAccountParamList;
            query["UserName"] = request.UserName;
            query["UserType"] = request.UserType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2016-04-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserWithOptions(request, runtime);
        }

        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserWithOptionsAsync(request, runtime);
        }

    }
}
