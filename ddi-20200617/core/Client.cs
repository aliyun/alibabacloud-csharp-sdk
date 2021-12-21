// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ddi20200617.Models;

namespace AlibabaCloud.SDK.Ddi20200617
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "ddi.cn-qingdao.aliyuncs.com"},
                {"cn-chengdu", "ddi.cn-chengdu.aliyuncs.com"},
                {"cn-zhangjiakou", "ddi.cn-zhangjiakou.aliyuncs.com"},
                {"cn-huhehaote", "ddi.cn-huhehaote.aliyuncs.com"},
                {"cn-hongkong", "ddi.cn-hongkong.aliyuncs.com"},
                {"ap-southeast-2", "ddi.ap-southeast-2.aliyuncs.com"},
                {"ap-southeast-3", "ddi.ap-southeast-3.aliyuncs.com"},
                {"ap-southeast-5", "ddi.ap-southeast-5.aliyuncs.com"},
                {"ap-northeast-1", "ddi.ap-northeast-1.aliyuncs.com"},
                {"eu-west-1", "ddi.eu-west-1.aliyuncs.com"},
                {"us-east-1", "ddi.us-east-1.aliyuncs.com"},
                {"eu-central-1", "ddi.eu-central-1.aliyuncs.com"},
                {"me-east-1", "ddi.me-east-1.aliyuncs.com"},
                {"ap-south-1", "ddi.ap-south-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("ddi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneFlowJob",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneFlowJob",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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

        public CommitFlowEntitySnapshotResponse CommitFlowEntitySnapshotWithOptions(CommitFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EntityId"] = request.EntityId;
            query["EntityType"] = request.EntityType;
            query["Message"] = request.Message;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CommitFlowEntitySnapshot",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommitFlowEntitySnapshotResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CommitFlowEntitySnapshotResponse> CommitFlowEntitySnapshotWithOptionsAsync(CommitFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EntityId"] = request.EntityId;
            query["EntityType"] = request.EntityType;
            query["Message"] = request.Message;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CommitFlowEntitySnapshot",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommitFlowEntitySnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CommitFlowEntitySnapshotResponse CommitFlowEntitySnapshot(CommitFlowEntitySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CommitFlowEntitySnapshotWithOptions(request, runtime);
        }

        public async Task<CommitFlowEntitySnapshotResponse> CommitFlowEntitySnapshotAsync(CommitFlowEntitySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CommitFlowEntitySnapshotWithOptionsAsync(request, runtime);
        }

        public CreateClusterV2Response CreateClusterV2WithOptions(CreateClusterV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AuthorizeContent"] = request.AuthorizeContent;
            query["Auto"] = request.Auto;
            query["AutoPayOrder"] = request.AutoPayOrder;
            query["BootstrapAction"] = request.BootstrapAction;
            query["ChargeType"] = request.ChargeType;
            query["ClickHouseConf"] = request.ClickHouseConf;
            query["ClientToken"] = request.ClientToken;
            query["ClusterType"] = request.ClusterType;
            query["Config"] = request.Config;
            query["Configurations"] = request.Configurations;
            query["DepositType"] = request.DepositType;
            query["EmrVer"] = request.EmrVer;
            query["EnableEas"] = request.EnableEas;
            query["EnableHighAvailability"] = request.EnableHighAvailability;
            query["EnableSsh"] = request.EnableSsh;
            query["ExtraAttributes"] = request.ExtraAttributes;
            query["HostComponentInfo"] = request.HostComponentInfo;
            query["HostGroup"] = request.HostGroup;
            query["InitCustomHiveMetaDB"] = request.InitCustomHiveMetaDB;
            query["InstanceGeneration"] = request.InstanceGeneration;
            query["IsOpenPublicIp"] = request.IsOpenPublicIp;
            query["KeyPairName"] = request.KeyPairName;
            query["LogPath"] = request.LogPath;
            query["MachineType"] = request.MachineType;
            query["MasterPwd"] = request.MasterPwd;
            query["MetaStoreConf"] = request.MetaStoreConf;
            query["MetaStoreType"] = request.MetaStoreType;
            query["Name"] = request.Name;
            query["NetType"] = request.NetType;
            query["Period"] = request.Period;
            query["PromotionInfo"] = request.PromotionInfo;
            query["RegionId"] = request.RegionId;
            query["RelatedClusterId"] = request.RelatedClusterId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityGroupId"] = request.SecurityGroupId;
            query["SecurityGroupName"] = request.SecurityGroupName;
            query["ServiceInfo"] = request.ServiceInfo;
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClusterV2",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<CreateClusterV2Response> CreateClusterV2WithOptionsAsync(CreateClusterV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AuthorizeContent"] = request.AuthorizeContent;
            query["Auto"] = request.Auto;
            query["AutoPayOrder"] = request.AutoPayOrder;
            query["BootstrapAction"] = request.BootstrapAction;
            query["ChargeType"] = request.ChargeType;
            query["ClickHouseConf"] = request.ClickHouseConf;
            query["ClientToken"] = request.ClientToken;
            query["ClusterType"] = request.ClusterType;
            query["Config"] = request.Config;
            query["Configurations"] = request.Configurations;
            query["DepositType"] = request.DepositType;
            query["EmrVer"] = request.EmrVer;
            query["EnableEas"] = request.EnableEas;
            query["EnableHighAvailability"] = request.EnableHighAvailability;
            query["EnableSsh"] = request.EnableSsh;
            query["ExtraAttributes"] = request.ExtraAttributes;
            query["HostComponentInfo"] = request.HostComponentInfo;
            query["HostGroup"] = request.HostGroup;
            query["InitCustomHiveMetaDB"] = request.InitCustomHiveMetaDB;
            query["InstanceGeneration"] = request.InstanceGeneration;
            query["IsOpenPublicIp"] = request.IsOpenPublicIp;
            query["KeyPairName"] = request.KeyPairName;
            query["LogPath"] = request.LogPath;
            query["MachineType"] = request.MachineType;
            query["MasterPwd"] = request.MasterPwd;
            query["MetaStoreConf"] = request.MetaStoreConf;
            query["MetaStoreType"] = request.MetaStoreType;
            query["Name"] = request.Name;
            query["NetType"] = request.NetType;
            query["Period"] = request.Period;
            query["PromotionInfo"] = request.PromotionInfo;
            query["RegionId"] = request.RegionId;
            query["RelatedClusterId"] = request.RelatedClusterId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityGroupId"] = request.SecurityGroupId;
            query["SecurityGroupName"] = request.SecurityGroupName;
            query["ServiceInfo"] = request.ServiceInfo;
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClusterV2",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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

        public CreateFlowResponse CreateFlowWithOptions(CreateFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AlertConf"] = request.AlertConf;
            query["AlertDingDingGroupBizId"] = request.AlertDingDingGroupBizId;
            query["AlertUserGroupBizId"] = request.AlertUserGroupBizId;
            query["Application"] = request.Application;
            query["ClientToken"] = request.ClientToken;
            query["ClusterId"] = request.ClusterId;
            query["CreateCluster"] = request.CreateCluster;
            query["CronExpression"] = request.CronExpression;
            query["Description"] = request.Description;
            query["EndSchedule"] = request.EndSchedule;
            query["HostName"] = request.HostName;
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            query["ClientToken"] = request.ClientToken;
            query["ClusterId"] = request.ClusterId;
            query["CreateCluster"] = request.CreateCluster;
            query["CronExpression"] = request.CronExpression;
            query["Description"] = request.Description;
            query["EndSchedule"] = request.EndSchedule;
            query["HostName"] = request.HostName;
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            query["ClientToken"] = request.ClientToken;
            query["Name"] = request.Name;
            query["ParentId"] = request.ParentId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowCategory",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowCategoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFlowCategoryResponse> CreateFlowCategoryWithOptionsAsync(CreateFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["Name"] = request.Name;
            query["ParentId"] = request.ParentId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowCategory",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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

        public CreateFlowEditLockResponse CreateFlowEditLockWithOptions(CreateFlowEditLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EntityId"] = request.EntityId;
            query["Force"] = request.Force;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowEditLock",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowEditLockResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFlowEditLockResponse> CreateFlowEditLockWithOptionsAsync(CreateFlowEditLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EntityId"] = request.EntityId;
            query["Force"] = request.Force;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowEditLock",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowEditLockResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFlowEditLockResponse CreateFlowEditLock(CreateFlowEditLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowEditLockWithOptions(request, runtime);
        }

        public async Task<CreateFlowEditLockResponse> CreateFlowEditLockAsync(CreateFlowEditLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowEditLockWithOptionsAsync(request, runtime);
        }

        public CreateFlowJobResponse CreateFlowJobWithOptions(CreateFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Adhoc"] = request.Adhoc;
            query["AlertConf"] = request.AlertConf;
            query["ClientToken"] = request.ClientToken;
            query["ClusterId"] = request.ClusterId;
            query["CustomVariables"] = request.CustomVariables;
            query["Description"] = request.Description;
            query["EnvConf"] = request.EnvConf;
            query["FailAct"] = request.FailAct;
            query["Mode"] = request.Mode;
            query["MonitorConf"] = request.MonitorConf;
            query["Name"] = request.Name;
            query["ParamConf"] = request.ParamConf;
            query["Params"] = request.Params;
            query["ParentCategory"] = request.ParentCategory;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["ResourceList"] = request.ResourceList;
            query["RetryPolicy"] = request.RetryPolicy;
            query["RunConf"] = request.RunConf;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowJob",
                Version = "2020-06-17",
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
            query["ClientToken"] = request.ClientToken;
            query["ClusterId"] = request.ClusterId;
            query["CustomVariables"] = request.CustomVariables;
            query["Description"] = request.Description;
            query["EnvConf"] = request.EnvConf;
            query["FailAct"] = request.FailAct;
            query["Mode"] = request.Mode;
            query["MonitorConf"] = request.MonitorConf;
            query["Name"] = request.Name;
            query["ParamConf"] = request.ParamConf;
            query["Params"] = request.Params;
            query["ParentCategory"] = request.ParentCategory;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["ResourceList"] = request.ResourceList;
            query["RetryPolicy"] = request.RetryPolicy;
            query["RunConf"] = request.RunConf;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowJob",
                Version = "2020-06-17",
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
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["ProductType"] = request.ProductType;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowProject",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFlowProjectResponse> CreateFlowProjectWithOptionsAsync(CreateFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["ProductType"] = request.ProductType;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowProject",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            query["ClientToken"] = request.ClientToken;
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowProjectClusterSetting",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowProjectClusterSettingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFlowProjectClusterSettingResponse> CreateFlowProjectClusterSettingWithOptionsAsync(CreateFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowProjectClusterSetting",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            query["ClientToken"] = request.ClientToken;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["User"] = request.User;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowProjectUser",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowProjectUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFlowProjectUserResponse> CreateFlowProjectUserWithOptionsAsync(CreateFlowProjectUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["User"] = request.User;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowProjectUser",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowCategory",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowCategory",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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

        public DeleteFlowEditLockResponse DeleteFlowEditLockWithOptions(DeleteFlowEditLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EntityId"] = request.EntityId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowEditLock",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowEditLockResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFlowEditLockResponse> DeleteFlowEditLockWithOptionsAsync(DeleteFlowEditLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EntityId"] = request.EntityId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowEditLock",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowEditLockResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFlowEditLockResponse DeleteFlowEditLock(DeleteFlowEditLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowEditLockWithOptions(request, runtime);
        }

        public async Task<DeleteFlowEditLockResponse> DeleteFlowEditLockAsync(DeleteFlowEditLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowEditLockWithOptionsAsync(request, runtime);
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowProject",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowProject",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowProjectClusterSetting",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowProjectClusterSetting",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowProjectUser",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowProjectUser",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterV2",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterV2",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowCategoryTree",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowCategoryTree",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowInstance",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowInstance",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowJob",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowJob",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowNodeInstance",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowNodeInstance",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowNodeInstanceContainerLog",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowNodeInstanceContainerLog",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowNodeInstanceLauncherLog",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowNodeInstanceLauncherLog",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowProject",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowProject",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowProjectClusterSetting",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowProjectClusterSetting",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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

        public DescribeFlowSLAResponse DescribeFlowSLAWithOptions(DescribeFlowSLARequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["From"] = request.From;
            query["Metrics"] = request.Metrics;
            query["PeriodType"] = request.PeriodType;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["To"] = request.To;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowSLA",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowSLAResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeFlowSLAResponse> DescribeFlowSLAWithOptionsAsync(DescribeFlowSLARequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["From"] = request.From;
            query["Metrics"] = request.Metrics;
            query["PeriodType"] = request.PeriodType;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["To"] = request.To;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowSLA",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowSLAResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeFlowSLAResponse DescribeFlowSLA(DescribeFlowSLARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowSLAWithOptions(request, runtime);
        }

        public async Task<DescribeFlowSLAResponse> DescribeFlowSLAAsync(DescribeFlowSLARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowSLAWithOptionsAsync(request, runtime);
        }

        public DescribeFlowVariableCollectionResponse DescribeFlowVariableCollectionWithOptions(DescribeFlowVariableCollectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EntityId"] = request.EntityId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowVariableCollection",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowVariableCollectionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeFlowVariableCollectionResponse> DescribeFlowVariableCollectionWithOptionsAsync(DescribeFlowVariableCollectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EntityId"] = request.EntityId;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowVariableCollection",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowVariableCollectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeFlowVariableCollectionResponse DescribeFlowVariableCollection(DescribeFlowVariableCollectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowVariableCollectionWithOptions(request, runtime);
        }

        public async Task<DescribeFlowVariableCollectionResponse> DescribeFlowVariableCollectionAsync(DescribeFlowVariableCollectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowVariableCollectionWithOptionsAsync(request, runtime);
        }

        public GetFlowAuditLogsResponse GetFlowAuditLogsWithOptions(GetFlowAuditLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CurrentSize"] = request.CurrentSize;
            query["EntityGroupId"] = request.EntityGroupId;
            query["EntityId"] = request.EntityId;
            query["EntityType"] = request.EntityType;
            query["Limit"] = request.Limit;
            query["Operation"] = request.Operation;
            query["OperatorId"] = request.OperatorId;
            query["OrderField"] = request.OrderField;
            query["OrderMode"] = request.OrderMode;
            query["PageCount"] = request.PageCount;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowAuditLogs",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowAuditLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFlowAuditLogsResponse> GetFlowAuditLogsWithOptionsAsync(GetFlowAuditLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CurrentSize"] = request.CurrentSize;
            query["EntityGroupId"] = request.EntityGroupId;
            query["EntityId"] = request.EntityId;
            query["EntityType"] = request.EntityType;
            query["Limit"] = request.Limit;
            query["Operation"] = request.Operation;
            query["OperatorId"] = request.OperatorId;
            query["OrderField"] = request.OrderField;
            query["OrderMode"] = request.OrderMode;
            query["PageCount"] = request.PageCount;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowAuditLogs",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowAuditLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetFlowAuditLogsResponse GetFlowAuditLogs(GetFlowAuditLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFlowAuditLogsWithOptions(request, runtime);
        }

        public async Task<GetFlowAuditLogsResponse> GetFlowAuditLogsAsync(GetFlowAuditLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFlowAuditLogsWithOptionsAsync(request, runtime);
        }

        public KillFlowResponse KillFlowWithOptions(KillFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["FlowInstanceId"] = request.FlowInstanceId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KillFlowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<KillFlowResponse> KillFlowWithOptionsAsync(KillFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["FlowInstanceId"] = request.FlowInstanceId;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KillFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public KillFlowResponse KillFlow(KillFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return KillFlowWithOptions(request, runtime);
        }

        public async Task<KillFlowResponse> KillFlowAsync(KillFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await KillFlowWithOptionsAsync(request, runtime);
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillFlowJob",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillFlowJob",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusters",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusters",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowCluster",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowCluster",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowClusterAll",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowClusterAll",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowClusterAllHosts",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowClusterAllHosts",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowClusterHost",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowClusterHost",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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

        public ListFlowEntitySnapshotResponse ListFlowEntitySnapshotWithOptions(ListFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CommitterId"] = request.CommitterId;
            query["CurrentSize"] = request.CurrentSize;
            query["EntityGroupId"] = request.EntityGroupId;
            query["EntityId"] = request.EntityId;
            query["EntityType"] = request.EntityType;
            query["Limit"] = request.Limit;
            query["OrderField"] = request.OrderField;
            query["OrderMode"] = request.OrderMode;
            query["PageCount"] = request.PageCount;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Revision"] = request.Revision;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowEntitySnapshot",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowEntitySnapshotResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFlowEntitySnapshotResponse> ListFlowEntitySnapshotWithOptionsAsync(ListFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CommitterId"] = request.CommitterId;
            query["CurrentSize"] = request.CurrentSize;
            query["EntityGroupId"] = request.EntityGroupId;
            query["EntityId"] = request.EntityId;
            query["EntityType"] = request.EntityType;
            query["Limit"] = request.Limit;
            query["OrderField"] = request.OrderField;
            query["OrderMode"] = request.OrderMode;
            query["PageCount"] = request.PageCount;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Revision"] = request.Revision;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowEntitySnapshot",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowEntitySnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFlowEntitySnapshotResponse ListFlowEntitySnapshot(ListFlowEntitySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowEntitySnapshotWithOptions(request, runtime);
        }

        public async Task<ListFlowEntitySnapshotResponse> ListFlowEntitySnapshotAsync(ListFlowEntitySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowEntitySnapshotWithOptionsAsync(request, runtime);
        }

        public ListFlowInstanceResponse ListFlowInstanceWithOptions(ListFlowInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["FlowId"] = request.FlowId;
            query["FlowName"] = request.FlowName;
            query["Id"] = request.Id;
            query["InstanceId"] = request.InstanceId;
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowInstance",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowInstance",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowJobHistory",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowJobHistory",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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

        public ListFlowJobsResponse ListFlowJobsWithOptions(ListFlowJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowJobs",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowJobsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFlowJobsResponse> ListFlowJobsWithOptionsAsync(ListFlowJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowJobs",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFlowJobsResponse ListFlowJobs(ListFlowJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowJobsWithOptions(request, runtime);
        }

        public async Task<ListFlowJobsResponse> ListFlowJobsAsync(ListFlowJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowJobsWithOptionsAsync(request, runtime);
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowNodeInstanceContainerStatus",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowNodeInstanceContainerStatus",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowNodeSqlResult",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowNodeSqlResult",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowProjectClusterSetting",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowProjectClusterSetting",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowProjectUser",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowProjectUser",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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

        public ListFlowProjectsResponse ListFlowProjectsWithOptions(ListFlowProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowProjects",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowProjectsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFlowProjectsResponse> ListFlowProjectsWithOptionsAsync(ListFlowProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowProjects",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowProjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFlowProjectsResponse ListFlowProjects(ListFlowProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowProjectsWithOptions(request, runtime);
        }

        public async Task<ListFlowProjectsResponse> ListFlowProjectsAsync(ListFlowProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowProjectsWithOptionsAsync(request, runtime);
        }

        public ListFlowsResponse ListFlowsWithOptions(ListFlowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlows",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFlowsResponse> ListFlowsWithOptionsAsync(ListFlowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlows",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowsResponse>(await CallApiAsync(params_, req, runtime));
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

        public ListMainVersionsResponse ListMainVersionsWithOptions(ListMainVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMainVersions",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMainVersionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListMainVersionsResponse> ListMainVersionsWithOptionsAsync(ListMainVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMainVersions",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMainVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListMainVersionsResponse ListMainVersions(ListMainVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMainVersionsWithOptions(request, runtime);
        }

        public async Task<ListMainVersionsResponse> ListMainVersionsAsync(ListMainVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMainVersionsWithOptionsAsync(request, runtime);
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
            query["Name"] = request.Name;
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            query["Name"] = request.Name;
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowCategory",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowCategory",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowForWeb",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowForWeb",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            query["KnoxPassword"] = request.KnoxPassword;
            query["KnoxUser"] = request.KnoxUser;
            query["Mode"] = request.Mode;
            query["MonitorConf"] = request.MonitorConf;
            query["Name"] = request.Name;
            query["ParamConf"] = request.ParamConf;
            query["Params"] = request.Params;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["ResourceList"] = request.ResourceList;
            query["RetryPolicy"] = request.RetryPolicy;
            query["RunConf"] = request.RunConf;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowJob",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            query["KnoxPassword"] = request.KnoxPassword;
            query["KnoxUser"] = request.KnoxUser;
            query["Mode"] = request.Mode;
            query["MonitorConf"] = request.MonitorConf;
            query["Name"] = request.Name;
            query["ParamConf"] = request.ParamConf;
            query["Params"] = request.Params;
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            query["ResourceList"] = request.ResourceList;
            query["RetryPolicy"] = request.RetryPolicy;
            query["RunConf"] = request.RunConf;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowJob",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowProject",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowProject",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowProjectClusterSetting",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowProjectClusterSetting",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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

        public ModifyFlowVariableCollectionResponse ModifyFlowVariableCollectionWithOptions(ModifyFlowVariableCollectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Data"] = request.Data;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowVariableCollection",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFlowVariableCollectionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyFlowVariableCollectionResponse> ModifyFlowVariableCollectionWithOptionsAsync(ModifyFlowVariableCollectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Data"] = request.Data;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowVariableCollection",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFlowVariableCollectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyFlowVariableCollectionResponse ModifyFlowVariableCollection(ModifyFlowVariableCollectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFlowVariableCollectionWithOptions(request, runtime);
        }

        public async Task<ModifyFlowVariableCollectionResponse> ModifyFlowVariableCollectionAsync(ModifyFlowVariableCollectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFlowVariableCollectionWithOptionsAsync(request, runtime);
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseCluster",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseCluster",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RerunFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RerunFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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

        public RestoreFlowEntitySnapshotResponse RestoreFlowEntitySnapshotWithOptions(RestoreFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EntityId"] = request.EntityId;
            query["EntityType"] = request.EntityType;
            query["OperatorId"] = request.OperatorId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Revision"] = request.Revision;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestoreFlowEntitySnapshot",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreFlowEntitySnapshotResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RestoreFlowEntitySnapshotResponse> RestoreFlowEntitySnapshotWithOptionsAsync(RestoreFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EntityId"] = request.EntityId;
            query["EntityType"] = request.EntityType;
            query["OperatorId"] = request.OperatorId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Revision"] = request.Revision;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestoreFlowEntitySnapshot",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreFlowEntitySnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RestoreFlowEntitySnapshotResponse RestoreFlowEntitySnapshot(RestoreFlowEntitySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestoreFlowEntitySnapshotWithOptions(request, runtime);
        }

        public async Task<RestoreFlowEntitySnapshotResponse> RestoreFlowEntitySnapshotAsync(RestoreFlowEntitySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestoreFlowEntitySnapshotWithOptionsAsync(request, runtime);
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitFlowJob",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            query["ProjectId"] = request.ProjectId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitFlowJob",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendFlow",
                Version = "2020-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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

    }
}
