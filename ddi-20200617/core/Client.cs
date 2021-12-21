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

    }
}
