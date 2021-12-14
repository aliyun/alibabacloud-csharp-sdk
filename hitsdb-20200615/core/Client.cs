// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Hitsdb20200615.Models;

namespace AlibabaCloud.SDK.Hitsdb20200615
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "hitsdb.aliyuncs.com"},
                {"cn-beijing", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou", "hitsdb.aliyuncs.com"},
                {"cn-shanghai", "hitsdb.aliyuncs.com"},
                {"cn-shenzhen", "hitsdb.aliyuncs.com"},
                {"cn-hongkong", "hitsdb.aliyuncs.com"},
                {"ap-southeast-1", "hitsdb.aliyuncs.com"},
                {"us-west-1", "hitsdb.aliyuncs.com"},
                {"us-east-1", "hitsdb.aliyuncs.com"},
                {"cn-shanghai-finance-1", "hitsdb.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "hitsdb.aliyuncs.com"},
                {"ap-northeast-2-pop", "hitsdb.aliyuncs.com"},
                {"cn-beijing-finance-1", "hitsdb.aliyuncs.com"},
                {"cn-beijing-finance-pop", "hitsdb.aliyuncs.com"},
                {"cn-beijing-gov-1", "hitsdb.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "hitsdb.aliyuncs.com"},
                {"cn-chengdu", "hitsdb.aliyuncs.com"},
                {"cn-edge-1", "hitsdb.aliyuncs.com"},
                {"cn-fujian", "hitsdb.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou-finance", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou-test-306", "hitsdb.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "hitsdb.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "hitsdb.aliyuncs.com"},
                {"cn-qingdao-nebula", "hitsdb.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "hitsdb.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "hitsdb.aliyuncs.com"},
                {"cn-shanghai-inner", "hitsdb.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "hitsdb.aliyuncs.com"},
                {"cn-shenzhen-inner", "hitsdb.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "hitsdb.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "hitsdb.aliyuncs.com"},
                {"cn-wuhan", "hitsdb.aliyuncs.com"},
                {"cn-wulanchabu", "hitsdb.aliyuncs.com"},
                {"cn-yushanfang", "hitsdb.aliyuncs.com"},
                {"cn-zhangbei", "hitsdb.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "hitsdb.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "hitsdb.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "hitsdb.aliyuncs.com"},
                {"eu-west-1-oxs", "hitsdb.aliyuncs.com"},
                {"me-east-1", "hitsdb.aliyuncs.com"},
                {"rus-west-1-pop", "hitsdb.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("hitsdb", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateLindormInstanceResponse CreateLindormInstanceWithOptions(CreateLindormInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ColdStorage"] = request.ColdStorage;
            query["CoreSpec"] = request.CoreSpec;
            query["DiskCategory"] = request.DiskCategory;
            query["Duration"] = request.Duration;
            query["FilestoreNum"] = request.FilestoreNum;
            query["FilestoreSpec"] = request.FilestoreSpec;
            query["InstanceAlias"] = request.InstanceAlias;
            query["InstanceStorage"] = request.InstanceStorage;
            query["LindormNum"] = request.LindormNum;
            query["LindormSpec"] = request.LindormSpec;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PayType"] = request.PayType;
            query["PricingCycle"] = request.PricingCycle;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityToken"] = request.SecurityToken;
            query["SolrNum"] = request.SolrNum;
            query["SolrSpec"] = request.SolrSpec;
            query["TsdbNum"] = request.TsdbNum;
            query["TsdbSpec"] = request.TsdbSpec;
            query["VPCId"] = request.VPCId;
            query["VSwitchId"] = request.VSwitchId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLindormInstance",
                Version = "2020-06-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLindormInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateLindormInstanceResponse> CreateLindormInstanceWithOptionsAsync(CreateLindormInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ColdStorage"] = request.ColdStorage;
            query["CoreSpec"] = request.CoreSpec;
            query["DiskCategory"] = request.DiskCategory;
            query["Duration"] = request.Duration;
            query["FilestoreNum"] = request.FilestoreNum;
            query["FilestoreSpec"] = request.FilestoreSpec;
            query["InstanceAlias"] = request.InstanceAlias;
            query["InstanceStorage"] = request.InstanceStorage;
            query["LindormNum"] = request.LindormNum;
            query["LindormSpec"] = request.LindormSpec;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PayType"] = request.PayType;
            query["PricingCycle"] = request.PricingCycle;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityToken"] = request.SecurityToken;
            query["SolrNum"] = request.SolrNum;
            query["SolrSpec"] = request.SolrSpec;
            query["TsdbNum"] = request.TsdbNum;
            query["TsdbSpec"] = request.TsdbSpec;
            query["VPCId"] = request.VPCId;
            query["VSwitchId"] = request.VSwitchId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLindormInstance",
                Version = "2020-06-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLindormInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateLindormInstanceResponse CreateLindormInstance(CreateLindormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLindormInstanceWithOptions(request, runtime);
        }

        public async Task<CreateLindormInstanceResponse> CreateLindormInstanceAsync(CreateLindormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLindormInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceptLanguage"] = request.AcceptLanguage;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2020-06-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceptLanguage"] = request.AcceptLanguage;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2020-06-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        public GetInstanceIpWhiteListResponse GetInstanceIpWhiteListWithOptions(GetInstanceIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GroupName"] = request.GroupName;
            query["InstanceId"] = request.InstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceIpWhiteList",
                Version = "2020-06-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceIpWhiteListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetInstanceIpWhiteListResponse> GetInstanceIpWhiteListWithOptionsAsync(GetInstanceIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GroupName"] = request.GroupName;
            query["InstanceId"] = request.InstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceIpWhiteList",
                Version = "2020-06-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceIpWhiteListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetInstanceIpWhiteListResponse GetInstanceIpWhiteList(GetInstanceIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceIpWhiteListWithOptions(request, runtime);
        }

        public async Task<GetInstanceIpWhiteListResponse> GetInstanceIpWhiteListAsync(GetInstanceIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceIpWhiteListWithOptionsAsync(request, runtime);
        }

        public GetLindormInstanceResponse GetLindormInstanceWithOptions(GetLindormInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLindormInstance",
                Version = "2020-06-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLindormInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetLindormInstanceResponse> GetLindormInstanceWithOptionsAsync(GetLindormInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLindormInstance",
                Version = "2020-06-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLindormInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetLindormInstanceResponse GetLindormInstance(GetLindormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLindormInstanceWithOptions(request, runtime);
        }

        public async Task<GetLindormInstanceResponse> GetLindormInstanceAsync(GetLindormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLindormInstanceWithOptionsAsync(request, runtime);
        }

        public GetLindormInstanceEngineListResponse GetLindormInstanceEngineListWithOptions(GetLindormInstanceEngineListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLindormInstanceEngineList",
                Version = "2020-06-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLindormInstanceEngineListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetLindormInstanceEngineListResponse> GetLindormInstanceEngineListWithOptionsAsync(GetLindormInstanceEngineListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLindormInstanceEngineList",
                Version = "2020-06-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLindormInstanceEngineListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetLindormInstanceEngineListResponse GetLindormInstanceEngineList(GetLindormInstanceEngineListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLindormInstanceEngineListWithOptions(request, runtime);
        }

        public async Task<GetLindormInstanceEngineListResponse> GetLindormInstanceEngineListAsync(GetLindormInstanceEngineListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLindormInstanceEngineListWithOptionsAsync(request, runtime);
        }

        public GetLindormInstanceListResponse GetLindormInstanceListWithOptions(GetLindormInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["QueryStr"] = request.QueryStr;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityToken"] = request.SecurityToken;
            query["ServiceType"] = request.ServiceType;
            query["SupportEngine"] = request.SupportEngine;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLindormInstanceList",
                Version = "2020-06-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLindormInstanceListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetLindormInstanceListResponse> GetLindormInstanceListWithOptionsAsync(GetLindormInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["QueryStr"] = request.QueryStr;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityToken"] = request.SecurityToken;
            query["ServiceType"] = request.ServiceType;
            query["SupportEngine"] = request.SupportEngine;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLindormInstanceList",
                Version = "2020-06-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLindormInstanceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetLindormInstanceListResponse GetLindormInstanceList(GetLindormInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLindormInstanceListWithOptions(request, runtime);
        }

        public async Task<GetLindormInstanceListResponse> GetLindormInstanceListAsync(GetLindormInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLindormInstanceListWithOptionsAsync(request, runtime);
        }

        public ReleaseLindormInstanceResponse ReleaseLindormInstanceWithOptions(ReleaseLindormInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseLindormInstance",
                Version = "2020-06-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseLindormInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReleaseLindormInstanceResponse> ReleaseLindormInstanceWithOptionsAsync(ReleaseLindormInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseLindormInstance",
                Version = "2020-06-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseLindormInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReleaseLindormInstanceResponse ReleaseLindormInstance(ReleaseLindormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseLindormInstanceWithOptions(request, runtime);
        }

        public async Task<ReleaseLindormInstanceResponse> ReleaseLindormInstanceAsync(ReleaseLindormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseLindormInstanceWithOptionsAsync(request, runtime);
        }

        public UpdateInstanceIpWhiteListResponse UpdateInstanceIpWhiteListWithOptions(UpdateInstanceIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GroupName"] = request.GroupName;
            query["InstanceId"] = request.InstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityIpList"] = request.SecurityIpList;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceIpWhiteList",
                Version = "2020-06-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceIpWhiteListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateInstanceIpWhiteListResponse> UpdateInstanceIpWhiteListWithOptionsAsync(UpdateInstanceIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GroupName"] = request.GroupName;
            query["InstanceId"] = request.InstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityIpList"] = request.SecurityIpList;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceIpWhiteList",
                Version = "2020-06-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceIpWhiteListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateInstanceIpWhiteListResponse UpdateInstanceIpWhiteList(UpdateInstanceIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceIpWhiteListWithOptions(request, runtime);
        }

        public async Task<UpdateInstanceIpWhiteListResponse> UpdateInstanceIpWhiteListAsync(UpdateInstanceIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceIpWhiteListWithOptionsAsync(request, runtime);
        }

        public UpgradeLindormInstanceResponse UpgradeLindormInstanceWithOptions(UpgradeLindormInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterStorage"] = request.ClusterStorage;
            query["ColdStorage"] = request.ColdStorage;
            query["CoreNum"] = request.CoreNum;
            query["CoreSpec"] = request.CoreSpec;
            query["FilestoreNum"] = request.FilestoreNum;
            query["FilestoreSpec"] = request.FilestoreSpec;
            query["InstanceId"] = request.InstanceId;
            query["LindormNum"] = request.LindormNum;
            query["LindormSpec"] = request.LindormSpec;
            query["LtsCoreNum"] = request.LtsCoreNum;
            query["LtsCoreSpec"] = request.LtsCoreSpec;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PhoenixCoreNum"] = request.PhoenixCoreNum;
            query["PhoenixCoreSpec"] = request.PhoenixCoreSpec;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityToken"] = request.SecurityToken;
            query["SolrNum"] = request.SolrNum;
            query["SolrSpec"] = request.SolrSpec;
            query["TsdbNum"] = request.TsdbNum;
            query["TsdbSpec"] = request.TsdbSpec;
            query["UpgradeType"] = request.UpgradeType;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeLindormInstance",
                Version = "2020-06-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeLindormInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpgradeLindormInstanceResponse> UpgradeLindormInstanceWithOptionsAsync(UpgradeLindormInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClusterStorage"] = request.ClusterStorage;
            query["ColdStorage"] = request.ColdStorage;
            query["CoreNum"] = request.CoreNum;
            query["CoreSpec"] = request.CoreSpec;
            query["FilestoreNum"] = request.FilestoreNum;
            query["FilestoreSpec"] = request.FilestoreSpec;
            query["InstanceId"] = request.InstanceId;
            query["LindormNum"] = request.LindormNum;
            query["LindormSpec"] = request.LindormSpec;
            query["LtsCoreNum"] = request.LtsCoreNum;
            query["LtsCoreSpec"] = request.LtsCoreSpec;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PhoenixCoreNum"] = request.PhoenixCoreNum;
            query["PhoenixCoreSpec"] = request.PhoenixCoreSpec;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecurityToken"] = request.SecurityToken;
            query["SolrNum"] = request.SolrNum;
            query["SolrSpec"] = request.SolrSpec;
            query["TsdbNum"] = request.TsdbNum;
            query["TsdbSpec"] = request.TsdbSpec;
            query["UpgradeType"] = request.UpgradeType;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeLindormInstance",
                Version = "2020-06-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeLindormInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpgradeLindormInstanceResponse UpgradeLindormInstance(UpgradeLindormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeLindormInstanceWithOptions(request, runtime);
        }

        public async Task<UpgradeLindormInstanceResponse> UpgradeLindormInstanceAsync(UpgradeLindormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeLindormInstanceWithOptionsAsync(request, runtime);
        }

    }
}
