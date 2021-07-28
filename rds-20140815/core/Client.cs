// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Rds20140815.Models;

namespace AlibabaCloud.SDK.Rds20140815
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "rds.aliyuncs.com"},
                {"cn-beijing", "rds.aliyuncs.com"},
                {"cn-hangzhou", "rds.aliyuncs.com"},
                {"cn-shanghai", "rds.aliyuncs.com"},
                {"cn-shenzhen", "rds.aliyuncs.com"},
                {"cn-heyuan", "rds.aliyuncs.com"},
                {"cn-hongkong", "rds.aliyuncs.com"},
                {"ap-southeast-1", "rds.aliyuncs.com"},
                {"us-west-1", "rds.aliyuncs.com"},
                {"us-east-1", "rds.aliyuncs.com"},
                {"cn-shanghai-finance-1", "rds.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "rds.aliyuncs.com"},
                {"cn-north-2-gov-1", "rds.aliyuncs.com"},
                {"ap-northeast-2-pop", "rds.aliyuncs.com"},
                {"cn-beijing-finance-1", "rds.aliyuncs.com"},
                {"cn-beijing-finance-pop", "rds.aliyuncs.com"},
                {"cn-beijing-gov-1", "rds.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "rds.aliyuncs.com"},
                {"cn-edge-1", "rds.aliyuncs.com"},
                {"cn-fujian", "rds.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "rds.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "rds.aliyuncs.com"},
                {"cn-hangzhou-finance", "rds.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "rds.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "rds.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "rds.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "rds.aliyuncs.com"},
                {"cn-hangzhou-test-306", "rds.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "rds.aliyuncs.com"},
                {"cn-qingdao-nebula", "rds.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "rds.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "rds.aliyuncs.com"},
                {"cn-shanghai-inner", "rds.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "rds.aliyuncs.com"},
                {"cn-shenzhen-inner", "rds.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "rds.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "rds.aliyuncs.com"},
                {"cn-wuhan", "rds.aliyuncs.com"},
                {"cn-yushanfang", "rds.aliyuncs.com"},
                {"cn-zhangbei", "rds.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "rds.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "rds.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "rds.aliyuncs.com"},
                {"eu-west-1-oxs", "rds.aliyuncs.com"},
                {"rus-west-1-pop", "rds.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("rds", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddTagsToResourceResponse AddTagsToResourceWithOptions(AddTagsToResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["proxyId"] = request.ProxyId;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Tags"] = request.Tags;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTagsToResource",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTagsToResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddTagsToResourceResponse> AddTagsToResourceWithOptionsAsync(AddTagsToResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["proxyId"] = request.ProxyId;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Tags"] = request.Tags;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTagsToResource",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTagsToResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTagsToResourceWithOptions(request, runtime);
        }

        public async Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTagsToResourceWithOptionsAsync(request, runtime);
        }

        public AllocateInstancePublicConnectionResponse AllocateInstancePublicConnectionWithOptions(AllocateInstancePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ConnectionStringPrefix"] = request.ConnectionStringPrefix;
            query["Port"] = request.Port;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AllocateInstancePublicConnection",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllocateInstancePublicConnectionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AllocateInstancePublicConnectionResponse> AllocateInstancePublicConnectionWithOptionsAsync(AllocateInstancePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ConnectionStringPrefix"] = request.ConnectionStringPrefix;
            query["Port"] = request.Port;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AllocateInstancePublicConnection",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllocateInstancePublicConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AllocateInstancePublicConnectionResponse AllocateInstancePublicConnection(AllocateInstancePublicConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocateInstancePublicConnectionWithOptions(request, runtime);
        }

        public async Task<AllocateInstancePublicConnectionResponse> AllocateInstancePublicConnectionAsync(AllocateInstancePublicConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocateInstancePublicConnectionWithOptionsAsync(request, runtime);
        }

        public AllocateReadWriteSplittingConnectionResponse AllocateReadWriteSplittingConnectionWithOptions(AllocateReadWriteSplittingConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ConnectionStringPrefix"] = request.ConnectionStringPrefix;
            query["Port"] = request.Port;
            query["MaxDelayTime"] = request.MaxDelayTime;
            query["NetType"] = request.NetType;
            query["DistributionType"] = request.DistributionType;
            query["Weight"] = request.Weight;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AllocateReadWriteSplittingConnection",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllocateReadWriteSplittingConnectionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AllocateReadWriteSplittingConnectionResponse> AllocateReadWriteSplittingConnectionWithOptionsAsync(AllocateReadWriteSplittingConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ConnectionStringPrefix"] = request.ConnectionStringPrefix;
            query["Port"] = request.Port;
            query["MaxDelayTime"] = request.MaxDelayTime;
            query["NetType"] = request.NetType;
            query["DistributionType"] = request.DistributionType;
            query["Weight"] = request.Weight;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AllocateReadWriteSplittingConnection",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllocateReadWriteSplittingConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AllocateReadWriteSplittingConnectionResponse AllocateReadWriteSplittingConnection(AllocateReadWriteSplittingConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocateReadWriteSplittingConnectionWithOptions(request, runtime);
        }

        public async Task<AllocateReadWriteSplittingConnectionResponse> AllocateReadWriteSplittingConnectionAsync(AllocateReadWriteSplittingConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocateReadWriteSplittingConnectionWithOptionsAsync(request, runtime);
        }

        public CalculateDBInstanceWeightResponse CalculateDBInstanceWeightWithOptions(CalculateDBInstanceWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CalculateDBInstanceWeight",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CalculateDBInstanceWeightResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CalculateDBInstanceWeightResponse> CalculateDBInstanceWeightWithOptionsAsync(CalculateDBInstanceWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CalculateDBInstanceWeight",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CalculateDBInstanceWeightResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CalculateDBInstanceWeightResponse CalculateDBInstanceWeight(CalculateDBInstanceWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CalculateDBInstanceWeightWithOptions(request, runtime);
        }

        public async Task<CalculateDBInstanceWeightResponse> CalculateDBInstanceWeightAsync(CalculateDBInstanceWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CalculateDBInstanceWeightWithOptionsAsync(request, runtime);
        }

        public CancelImportResponse CancelImportWithOptions(CancelImportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ImportId"] = request.ImportId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelImport",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelImportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelImportResponse> CancelImportWithOptionsAsync(CancelImportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ImportId"] = request.ImportId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelImport",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelImportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelImportResponse CancelImport(CancelImportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelImportWithOptions(request, runtime);
        }

        public async Task<CancelImportResponse> CancelImportAsync(CancelImportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelImportWithOptionsAsync(request, runtime);
        }

        public CheckAccountNameAvailableResponse CheckAccountNameAvailableWithOptions(CheckAccountNameAvailableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AccountName"] = request.AccountName;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckAccountNameAvailable",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckAccountNameAvailableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckAccountNameAvailableResponse> CheckAccountNameAvailableWithOptionsAsync(CheckAccountNameAvailableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AccountName"] = request.AccountName;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckAccountNameAvailable",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckAccountNameAvailableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckAccountNameAvailableResponse CheckAccountNameAvailable(CheckAccountNameAvailableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckAccountNameAvailableWithOptions(request, runtime);
        }

        public async Task<CheckAccountNameAvailableResponse> CheckAccountNameAvailableAsync(CheckAccountNameAvailableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckAccountNameAvailableWithOptionsAsync(request, runtime);
        }

        public CheckCloudResourceAuthorizedResponse CheckCloudResourceAuthorizedWithOptions(CheckCloudResourceAuthorizedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["TargetRegionId"] = request.TargetRegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckCloudResourceAuthorized",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckCloudResourceAuthorizedResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckCloudResourceAuthorizedResponse> CheckCloudResourceAuthorizedWithOptionsAsync(CheckCloudResourceAuthorizedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["TargetRegionId"] = request.TargetRegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckCloudResourceAuthorized",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckCloudResourceAuthorizedResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckCloudResourceAuthorizedResponse CheckCloudResourceAuthorized(CheckCloudResourceAuthorizedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckCloudResourceAuthorizedWithOptions(request, runtime);
        }

        public async Task<CheckCloudResourceAuthorizedResponse> CheckCloudResourceAuthorizedAsync(CheckCloudResourceAuthorizedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckCloudResourceAuthorizedWithOptionsAsync(request, runtime);
        }

        public CheckCreateDdrDBInstanceResponse CheckCreateDdrDBInstanceWithOptions(CheckCreateDdrDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["Engine"] = request.Engine;
            query["EngineVersion"] = request.EngineVersion;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["DBInstanceStorage"] = request.DBInstanceStorage;
            query["RestoreType"] = request.RestoreType;
            query["BackupSetId"] = request.BackupSetId;
            query["RestoreTime"] = request.RestoreTime;
            query["SourceRegion"] = request.SourceRegion;
            query["SourceDBInstanceName"] = request.SourceDBInstanceName;
            query["BinlogName"] = request.BinlogName;
            query["BinlogPosition"] = request.BinlogPosition;
            query["BinlogRole"] = request.BinlogRole;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckCreateDdrDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckCreateDdrDBInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckCreateDdrDBInstanceResponse> CheckCreateDdrDBInstanceWithOptionsAsync(CheckCreateDdrDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["Engine"] = request.Engine;
            query["EngineVersion"] = request.EngineVersion;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["DBInstanceStorage"] = request.DBInstanceStorage;
            query["RestoreType"] = request.RestoreType;
            query["BackupSetId"] = request.BackupSetId;
            query["RestoreTime"] = request.RestoreTime;
            query["SourceRegion"] = request.SourceRegion;
            query["SourceDBInstanceName"] = request.SourceDBInstanceName;
            query["BinlogName"] = request.BinlogName;
            query["BinlogPosition"] = request.BinlogPosition;
            query["BinlogRole"] = request.BinlogRole;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckCreateDdrDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckCreateDdrDBInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckCreateDdrDBInstanceResponse CheckCreateDdrDBInstance(CheckCreateDdrDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckCreateDdrDBInstanceWithOptions(request, runtime);
        }

        public async Task<CheckCreateDdrDBInstanceResponse> CheckCreateDdrDBInstanceAsync(CheckCreateDdrDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckCreateDdrDBInstanceWithOptionsAsync(request, runtime);
        }

        public CheckDBNameAvailableResponse CheckDBNameAvailableWithOptions(CheckDBNameAvailableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBName"] = request.DBName;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDBNameAvailable",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDBNameAvailableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckDBNameAvailableResponse> CheckDBNameAvailableWithOptionsAsync(CheckDBNameAvailableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBName"] = request.DBName;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDBNameAvailable",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDBNameAvailableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckDBNameAvailableResponse CheckDBNameAvailable(CheckDBNameAvailableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDBNameAvailableWithOptions(request, runtime);
        }

        public async Task<CheckDBNameAvailableResponse> CheckDBNameAvailableAsync(CheckDBNameAvailableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDBNameAvailableWithOptionsAsync(request, runtime);
        }

        public CheckInstanceExistResponse CheckInstanceExistWithOptions(CheckInstanceExistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckInstanceExist",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckInstanceExistResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckInstanceExistResponse> CheckInstanceExistWithOptionsAsync(CheckInstanceExistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckInstanceExist",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckInstanceExistResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckInstanceExistResponse CheckInstanceExist(CheckInstanceExistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckInstanceExistWithOptions(request, runtime);
        }

        public async Task<CheckInstanceExistResponse> CheckInstanceExistAsync(CheckInstanceExistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckInstanceExistWithOptionsAsync(request, runtime);
        }

        public ClearDedicatedHostResponse ClearDedicatedHostWithOptions(ClearDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["FailoverMode"] = request.FailoverMode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClearDedicatedHost",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearDedicatedHostResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ClearDedicatedHostResponse> ClearDedicatedHostWithOptionsAsync(ClearDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["FailoverMode"] = request.FailoverMode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClearDedicatedHost",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearDedicatedHostResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ClearDedicatedHostResponse ClearDedicatedHost(ClearDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ClearDedicatedHostWithOptions(request, runtime);
        }

        public async Task<ClearDedicatedHostResponse> ClearDedicatedHostAsync(ClearDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ClearDedicatedHostWithOptionsAsync(request, runtime);
        }

        public CloneDBInstanceResponse CloneDBInstanceWithOptions(CloneDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["ZoneId"] = request.ZoneId;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["DBInstanceStorage"] = request.DBInstanceStorage;
            query["DbNames"] = request.DbNames;
            query["PayType"] = request.PayType;
            query["InstanceNetworkType"] = request.InstanceNetworkType;
            query["DBInstanceId"] = request.DBInstanceId;
            query["BackupId"] = request.BackupId;
            query["RestoreTime"] = request.RestoreTime;
            query["VPCId"] = request.VPCId;
            query["VSwitchId"] = request.VSwitchId;
            query["PrivateIpAddress"] = request.PrivateIpAddress;
            query["UsedTime"] = request.UsedTime;
            query["Period"] = request.Period;
            query["Category"] = request.Category;
            query["DBInstanceStorageType"] = request.DBInstanceStorageType;
            query["RestoreTable"] = request.RestoreTable;
            query["TableMeta"] = request.TableMeta;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["BackupType"] = request.BackupType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneDBInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CloneDBInstanceResponse> CloneDBInstanceWithOptionsAsync(CloneDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["ZoneId"] = request.ZoneId;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["DBInstanceStorage"] = request.DBInstanceStorage;
            query["DbNames"] = request.DbNames;
            query["PayType"] = request.PayType;
            query["InstanceNetworkType"] = request.InstanceNetworkType;
            query["DBInstanceId"] = request.DBInstanceId;
            query["BackupId"] = request.BackupId;
            query["RestoreTime"] = request.RestoreTime;
            query["VPCId"] = request.VPCId;
            query["VSwitchId"] = request.VSwitchId;
            query["PrivateIpAddress"] = request.PrivateIpAddress;
            query["UsedTime"] = request.UsedTime;
            query["Period"] = request.Period;
            query["Category"] = request.Category;
            query["DBInstanceStorageType"] = request.DBInstanceStorageType;
            query["RestoreTable"] = request.RestoreTable;
            query["TableMeta"] = request.TableMeta;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["BackupType"] = request.BackupType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneDBInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CloneDBInstanceResponse CloneDBInstance(CloneDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloneDBInstanceWithOptions(request, runtime);
        }

        public async Task<CloneDBInstanceResponse> CloneDBInstanceAsync(CloneDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloneDBInstanceWithOptionsAsync(request, runtime);
        }

        public CloneParameterGroupResponse CloneParameterGroupWithOptions(CloneParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["TargetRegionId"] = request.TargetRegionId;
            query["ParameterGroupId"] = request.ParameterGroupId;
            query["ParameterGroupName"] = request.ParameterGroupName;
            query["ParameterGroupDesc"] = request.ParameterGroupDesc;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneParameterGroup",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneParameterGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CloneParameterGroupResponse> CloneParameterGroupWithOptionsAsync(CloneParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["TargetRegionId"] = request.TargetRegionId;
            query["ParameterGroupId"] = request.ParameterGroupId;
            query["ParameterGroupName"] = request.ParameterGroupName;
            query["ParameterGroupDesc"] = request.ParameterGroupDesc;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneParameterGroup",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneParameterGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CloneParameterGroupResponse CloneParameterGroup(CloneParameterGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloneParameterGroupWithOptions(request, runtime);
        }

        public async Task<CloneParameterGroupResponse> CloneParameterGroupAsync(CloneParameterGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloneParameterGroupWithOptionsAsync(request, runtime);
        }

        public CopyDatabaseResponse CopyDatabaseWithOptions(CopyDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyDatabase",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyDatabaseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CopyDatabaseResponse> CopyDatabaseWithOptionsAsync(CopyDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyDatabase",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CopyDatabaseResponse CopyDatabase(CopyDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyDatabaseWithOptions(request, runtime);
        }

        public async Task<CopyDatabaseResponse> CopyDatabaseAsync(CopyDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyDatabaseWithOptionsAsync(request, runtime);
        }

        public CopyDatabaseBetweenInstancesResponse CopyDatabaseBetweenInstancesWithOptions(CopyDatabaseBetweenInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["TargetDBInstanceId"] = request.TargetDBInstanceId;
            query["DbNames"] = request.DbNames;
            query["BackupId"] = request.BackupId;
            query["RestoreTime"] = request.RestoreTime;
            query["SyncUserPrivilege"] = request.SyncUserPrivilege;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyDatabaseBetweenInstances",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyDatabaseBetweenInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CopyDatabaseBetweenInstancesResponse> CopyDatabaseBetweenInstancesWithOptionsAsync(CopyDatabaseBetweenInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["TargetDBInstanceId"] = request.TargetDBInstanceId;
            query["DbNames"] = request.DbNames;
            query["BackupId"] = request.BackupId;
            query["RestoreTime"] = request.RestoreTime;
            query["SyncUserPrivilege"] = request.SyncUserPrivilege;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyDatabaseBetweenInstances",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyDatabaseBetweenInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CopyDatabaseBetweenInstancesResponse CopyDatabaseBetweenInstances(CopyDatabaseBetweenInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyDatabaseBetweenInstancesWithOptions(request, runtime);
        }

        public async Task<CopyDatabaseBetweenInstancesResponse> CopyDatabaseBetweenInstancesAsync(CopyDatabaseBetweenInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyDatabaseBetweenInstancesWithOptionsAsync(request, runtime);
        }

        public CreateAccountResponse CreateAccountWithOptions(CreateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AccountName"] = request.AccountName;
            query["AccountPassword"] = request.AccountPassword;
            query["AccountDescription"] = request.AccountDescription;
            query["AccountType"] = request.AccountType;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccount",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateAccountResponse> CreateAccountWithOptionsAsync(CreateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AccountName"] = request.AccountName;
            query["AccountPassword"] = request.AccountPassword;
            query["AccountDescription"] = request.AccountDescription;
            query["AccountType"] = request.AccountType;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccount",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateAccountResponse CreateAccount(CreateAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccountWithOptions(request, runtime);
        }

        public async Task<CreateAccountResponse> CreateAccountAsync(CreateAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccountWithOptionsAsync(request, runtime);
        }

        public CreateBackupResponse CreateBackupWithOptions(CreateBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBName"] = request.DBName;
            query["BackupStrategy"] = request.BackupStrategy;
            query["BackupMethod"] = request.BackupMethod;
            query["BackupType"] = request.BackupType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBackup",
                Version = "2014-08-15",
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
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBName"] = request.DBName;
            query["BackupStrategy"] = request.BackupStrategy;
            query["BackupMethod"] = request.BackupMethod;
            query["BackupType"] = request.BackupType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBackup",
                Version = "2014-08-15",
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

        public CreateDatabaseResponse CreateDatabaseWithOptions(CreateDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBName"] = request.DBName;
            query["CharacterSetName"] = request.CharacterSetName;
            query["DBDescription"] = request.DBDescription;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatabase",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatabaseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDatabaseResponse> CreateDatabaseWithOptionsAsync(CreateDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBName"] = request.DBName;
            query["CharacterSetName"] = request.CharacterSetName;
            query["DBDescription"] = request.DBDescription;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatabase",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDatabaseResponse CreateDatabase(CreateDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDatabaseWithOptions(request, runtime);
        }

        public async Task<CreateDatabaseResponse> CreateDatabaseAsync(CreateDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDatabaseWithOptionsAsync(request, runtime);
        }

        public CreateDBInstanceResponse CreateDBInstanceWithOptions(CreateDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["Engine"] = request.Engine;
            query["EngineVersion"] = request.EngineVersion;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["DBInstanceStorage"] = request.DBInstanceStorage;
            query["SystemDBCharset"] = request.SystemDBCharset;
            query["DBInstanceNetType"] = request.DBInstanceNetType;
            query["DBInstanceDescription"] = request.DBInstanceDescription;
            query["SecurityIPList"] = request.SecurityIPList;
            query["ClientToken"] = request.ClientToken;
            query["PayType"] = request.PayType;
            query["ZoneId"] = request.ZoneId;
            query["ZoneIdSlave1"] = request.ZoneIdSlave1;
            query["ZoneIdSlave2"] = request.ZoneIdSlave2;
            query["InstanceNetworkType"] = request.InstanceNetworkType;
            query["ConnectionMode"] = request.ConnectionMode;
            query["VPCId"] = request.VPCId;
            query["VSwitchId"] = request.VSwitchId;
            query["PrivateIpAddress"] = request.PrivateIpAddress;
            query["UsedTime"] = request.UsedTime;
            query["Period"] = request.Period;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["DBInstanceStorageType"] = request.DBInstanceStorageType;
            query["BusinessInfo"] = request.BusinessInfo;
            query["EncryptionKey"] = request.EncryptionKey;
            query["RoleARN"] = request.RoleARN;
            query["AutoRenew"] = request.AutoRenew;
            query["Category"] = request.Category;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["TargetDedicatedHostIdForMaster"] = request.TargetDedicatedHostIdForMaster;
            query["TargetDedicatedHostIdForSlave"] = request.TargetDedicatedHostIdForSlave;
            query["TargetDedicatedHostIdForLog"] = request.TargetDedicatedHostIdForLog;
            query["DBParamGroupId"] = request.DBParamGroupId;
            query["DBTimeZone"] = request.DBTimeZone;
            query["DBIsIgnoreCase"] = request.DBIsIgnoreCase;
            query["TargetMinorVersion"] = request.TargetMinorVersion;
            query["StorageAutoScale"] = request.StorageAutoScale;
            query["StorageThreshold"] = request.StorageThreshold;
            query["StorageUpperBound"] = request.StorageUpperBound;
            query["DryRun"] = request.DryRun;
            query["UserBackupId"] = request.UserBackupId;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDBInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDBInstanceResponse> CreateDBInstanceWithOptionsAsync(CreateDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["Engine"] = request.Engine;
            query["EngineVersion"] = request.EngineVersion;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["DBInstanceStorage"] = request.DBInstanceStorage;
            query["SystemDBCharset"] = request.SystemDBCharset;
            query["DBInstanceNetType"] = request.DBInstanceNetType;
            query["DBInstanceDescription"] = request.DBInstanceDescription;
            query["SecurityIPList"] = request.SecurityIPList;
            query["ClientToken"] = request.ClientToken;
            query["PayType"] = request.PayType;
            query["ZoneId"] = request.ZoneId;
            query["ZoneIdSlave1"] = request.ZoneIdSlave1;
            query["ZoneIdSlave2"] = request.ZoneIdSlave2;
            query["InstanceNetworkType"] = request.InstanceNetworkType;
            query["ConnectionMode"] = request.ConnectionMode;
            query["VPCId"] = request.VPCId;
            query["VSwitchId"] = request.VSwitchId;
            query["PrivateIpAddress"] = request.PrivateIpAddress;
            query["UsedTime"] = request.UsedTime;
            query["Period"] = request.Period;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["DBInstanceStorageType"] = request.DBInstanceStorageType;
            query["BusinessInfo"] = request.BusinessInfo;
            query["EncryptionKey"] = request.EncryptionKey;
            query["RoleARN"] = request.RoleARN;
            query["AutoRenew"] = request.AutoRenew;
            query["Category"] = request.Category;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["TargetDedicatedHostIdForMaster"] = request.TargetDedicatedHostIdForMaster;
            query["TargetDedicatedHostIdForSlave"] = request.TargetDedicatedHostIdForSlave;
            query["TargetDedicatedHostIdForLog"] = request.TargetDedicatedHostIdForLog;
            query["DBParamGroupId"] = request.DBParamGroupId;
            query["DBTimeZone"] = request.DBTimeZone;
            query["DBIsIgnoreCase"] = request.DBIsIgnoreCase;
            query["TargetMinorVersion"] = request.TargetMinorVersion;
            query["StorageAutoScale"] = request.StorageAutoScale;
            query["StorageThreshold"] = request.StorageThreshold;
            query["StorageUpperBound"] = request.StorageUpperBound;
            query["DryRun"] = request.DryRun;
            query["UserBackupId"] = request.UserBackupId;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDBInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDBInstanceResponse CreateDBInstance(CreateDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDBInstanceWithOptions(request, runtime);
        }

        public async Task<CreateDBInstanceResponse> CreateDBInstanceAsync(CreateDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDBInstanceWithOptionsAsync(request, runtime);
        }

        public CreateDBProxyEndpointAddressResponse CreateDBProxyEndpointAddressWithOptions(CreateDBProxyEndpointAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBProxyEndpointId"] = request.DBProxyEndpointId;
            query["ConnectionStringPrefix"] = request.ConnectionStringPrefix;
            query["DBProxyNewConnectStringPort"] = request.DBProxyNewConnectStringPort;
            query["DBProxyConnectStringNetType"] = request.DBProxyConnectStringNetType;
            query["VPCId"] = request.VPCId;
            query["VSwitchId"] = request.VSwitchId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDBProxyEndpointAddress",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDBProxyEndpointAddressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDBProxyEndpointAddressResponse> CreateDBProxyEndpointAddressWithOptionsAsync(CreateDBProxyEndpointAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBProxyEndpointId"] = request.DBProxyEndpointId;
            query["ConnectionStringPrefix"] = request.ConnectionStringPrefix;
            query["DBProxyNewConnectStringPort"] = request.DBProxyNewConnectStringPort;
            query["DBProxyConnectStringNetType"] = request.DBProxyConnectStringNetType;
            query["VPCId"] = request.VPCId;
            query["VSwitchId"] = request.VSwitchId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDBProxyEndpointAddress",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDBProxyEndpointAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDBProxyEndpointAddressResponse CreateDBProxyEndpointAddress(CreateDBProxyEndpointAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDBProxyEndpointAddressWithOptions(request, runtime);
        }

        public async Task<CreateDBProxyEndpointAddressResponse> CreateDBProxyEndpointAddressAsync(CreateDBProxyEndpointAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDBProxyEndpointAddressWithOptionsAsync(request, runtime);
        }

        public CreateDdrInstanceResponse CreateDdrInstanceWithOptions(CreateDdrInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["Engine"] = request.Engine;
            query["EngineVersion"] = request.EngineVersion;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["DBInstanceStorage"] = request.DBInstanceStorage;
            query["SystemDBCharset"] = request.SystemDBCharset;
            query["DBInstanceNetType"] = request.DBInstanceNetType;
            query["DBInstanceDescription"] = request.DBInstanceDescription;
            query["SecurityIPList"] = request.SecurityIPList;
            query["ClientToken"] = request.ClientToken;
            query["PayType"] = request.PayType;
            query["ZoneId"] = request.ZoneId;
            query["InstanceNetworkType"] = request.InstanceNetworkType;
            query["ConnectionMode"] = request.ConnectionMode;
            query["VPCId"] = request.VPCId;
            query["VSwitchId"] = request.VSwitchId;
            query["PrivateIpAddress"] = request.PrivateIpAddress;
            query["OwnerAccount"] = request.OwnerAccount;
            query["UsedTime"] = request.UsedTime;
            query["Period"] = request.Period;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["RestoreType"] = request.RestoreType;
            query["BackupSetId"] = request.BackupSetId;
            query["RestoreTime"] = request.RestoreTime;
            query["SourceRegion"] = request.SourceRegion;
            query["SourceDBInstanceName"] = request.SourceDBInstanceName;
            query["DBInstanceStorageType"] = request.DBInstanceStorageType;
            query["BinlogName"] = request.BinlogName;
            query["BinlogPosition"] = request.BinlogPosition;
            query["BinlogRole"] = request.BinlogRole;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDdrInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDdrInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDdrInstanceResponse> CreateDdrInstanceWithOptionsAsync(CreateDdrInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["Engine"] = request.Engine;
            query["EngineVersion"] = request.EngineVersion;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["DBInstanceStorage"] = request.DBInstanceStorage;
            query["SystemDBCharset"] = request.SystemDBCharset;
            query["DBInstanceNetType"] = request.DBInstanceNetType;
            query["DBInstanceDescription"] = request.DBInstanceDescription;
            query["SecurityIPList"] = request.SecurityIPList;
            query["ClientToken"] = request.ClientToken;
            query["PayType"] = request.PayType;
            query["ZoneId"] = request.ZoneId;
            query["InstanceNetworkType"] = request.InstanceNetworkType;
            query["ConnectionMode"] = request.ConnectionMode;
            query["VPCId"] = request.VPCId;
            query["VSwitchId"] = request.VSwitchId;
            query["PrivateIpAddress"] = request.PrivateIpAddress;
            query["OwnerAccount"] = request.OwnerAccount;
            query["UsedTime"] = request.UsedTime;
            query["Period"] = request.Period;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["RestoreType"] = request.RestoreType;
            query["BackupSetId"] = request.BackupSetId;
            query["RestoreTime"] = request.RestoreTime;
            query["SourceRegion"] = request.SourceRegion;
            query["SourceDBInstanceName"] = request.SourceDBInstanceName;
            query["DBInstanceStorageType"] = request.DBInstanceStorageType;
            query["BinlogName"] = request.BinlogName;
            query["BinlogPosition"] = request.BinlogPosition;
            query["BinlogRole"] = request.BinlogRole;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDdrInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDdrInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDdrInstanceResponse CreateDdrInstance(CreateDdrInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDdrInstanceWithOptions(request, runtime);
        }

        public async Task<CreateDdrInstanceResponse> CreateDdrInstanceAsync(CreateDdrInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDdrInstanceWithOptionsAsync(request, runtime);
        }

        public CreateDedicatedHostResponse CreateDedicatedHostWithOptions(CreateDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["HostName"] = request.HostName;
            query["ZoneId"] = request.ZoneId;
            query["VSwitchId"] = request.VSwitchId;
            query["HostClass"] = request.HostClass;
            query["PayType"] = request.PayType;
            query["Period"] = request.Period;
            query["UsedTime"] = request.UsedTime;
            query["ClientToken"] = request.ClientToken;
            query["AutoRenew"] = request.AutoRenew;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDedicatedHost",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDedicatedHostResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDedicatedHostResponse> CreateDedicatedHostWithOptionsAsync(CreateDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["HostName"] = request.HostName;
            query["ZoneId"] = request.ZoneId;
            query["VSwitchId"] = request.VSwitchId;
            query["HostClass"] = request.HostClass;
            query["PayType"] = request.PayType;
            query["Period"] = request.Period;
            query["UsedTime"] = request.UsedTime;
            query["ClientToken"] = request.ClientToken;
            query["AutoRenew"] = request.AutoRenew;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDedicatedHost",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDedicatedHostResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDedicatedHostResponse CreateDedicatedHost(CreateDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDedicatedHostWithOptions(request, runtime);
        }

        public async Task<CreateDedicatedHostResponse> CreateDedicatedHostAsync(CreateDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDedicatedHostWithOptionsAsync(request, runtime);
        }

        public CreateDedicatedHostAccountResponse CreateDedicatedHostAccountWithOptions(CreateDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["AccountName"] = request.AccountName;
            query["AccountPassword"] = request.AccountPassword;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDedicatedHostAccount",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDedicatedHostAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDedicatedHostAccountResponse> CreateDedicatedHostAccountWithOptionsAsync(CreateDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["AccountName"] = request.AccountName;
            query["AccountPassword"] = request.AccountPassword;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDedicatedHostAccount",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDedicatedHostAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDedicatedHostAccountResponse CreateDedicatedHostAccount(CreateDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDedicatedHostAccountWithOptions(request, runtime);
        }

        public async Task<CreateDedicatedHostAccountResponse> CreateDedicatedHostAccountAsync(CreateDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDedicatedHostAccountWithOptionsAsync(request, runtime);
        }

        public CreateDedicatedHostGroupResponse CreateDedicatedHostGroupWithOptions(CreateDedicatedHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["Engine"] = request.Engine;
            query["CpuAllocationRatio"] = request.CpuAllocationRatio;
            query["MemAllocationRatio"] = request.MemAllocationRatio;
            query["DiskAllocationRatio"] = request.DiskAllocationRatio;
            query["AllocationPolicy"] = request.AllocationPolicy;
            query["VPCId"] = request.VPCId;
            query["HostReplacePolicy"] = request.HostReplacePolicy;
            query["ClientToken"] = request.ClientToken;
            query["OpenPermission"] = request.OpenPermission;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDedicatedHostGroup",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDedicatedHostGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDedicatedHostGroupResponse> CreateDedicatedHostGroupWithOptionsAsync(CreateDedicatedHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["Engine"] = request.Engine;
            query["CpuAllocationRatio"] = request.CpuAllocationRatio;
            query["MemAllocationRatio"] = request.MemAllocationRatio;
            query["DiskAllocationRatio"] = request.DiskAllocationRatio;
            query["AllocationPolicy"] = request.AllocationPolicy;
            query["VPCId"] = request.VPCId;
            query["HostReplacePolicy"] = request.HostReplacePolicy;
            query["ClientToken"] = request.ClientToken;
            query["OpenPermission"] = request.OpenPermission;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDedicatedHostGroup",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDedicatedHostGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDedicatedHostGroupResponse CreateDedicatedHostGroup(CreateDedicatedHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDedicatedHostGroupWithOptions(request, runtime);
        }

        public async Task<CreateDedicatedHostGroupResponse> CreateDedicatedHostGroupAsync(CreateDedicatedHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDedicatedHostGroupWithOptionsAsync(request, runtime);
        }

        public CreateDedicatedHostUserResponse CreateDedicatedHostUserWithOptions(CreateDedicatedHostUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DedicatedHostName"] = request.DedicatedHostName;
            query["UserName"] = request.UserName;
            query["UserPassword"] = request.UserPassword;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDedicatedHostUser",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDedicatedHostUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDedicatedHostUserResponse> CreateDedicatedHostUserWithOptionsAsync(CreateDedicatedHostUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DedicatedHostName"] = request.DedicatedHostName;
            query["UserName"] = request.UserName;
            query["UserPassword"] = request.UserPassword;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDedicatedHostUser",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDedicatedHostUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDedicatedHostUserResponse CreateDedicatedHostUser(CreateDedicatedHostUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDedicatedHostUserWithOptions(request, runtime);
        }

        public async Task<CreateDedicatedHostUserResponse> CreateDedicatedHostUserAsync(CreateDedicatedHostUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDedicatedHostUserWithOptionsAsync(request, runtime);
        }

        public CreateDiagnosticReportResponse CreateDiagnosticReportWithOptions(CreateDiagnosticReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DBInstanceId"] = request.DBInstanceId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDiagnosticReport",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDiagnosticReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDiagnosticReportResponse> CreateDiagnosticReportWithOptionsAsync(CreateDiagnosticReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DBInstanceId"] = request.DBInstanceId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDiagnosticReport",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDiagnosticReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDiagnosticReportResponse CreateDiagnosticReport(CreateDiagnosticReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDiagnosticReportWithOptions(request, runtime);
        }

        public async Task<CreateDiagnosticReportResponse> CreateDiagnosticReportAsync(CreateDiagnosticReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDiagnosticReportWithOptionsAsync(request, runtime);
        }

        public CreateGdnInstanceResponse CreateGdnInstanceWithOptions(CreateGdnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["PrimaryInstanceName"] = request.PrimaryInstanceName;
            query["PrimaryInstanceRegion"] = request.PrimaryInstanceRegion;
            query["Description"] = request.Description;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGdnInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGdnInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateGdnInstanceResponse> CreateGdnInstanceWithOptionsAsync(CreateGdnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["PrimaryInstanceName"] = request.PrimaryInstanceName;
            query["PrimaryInstanceRegion"] = request.PrimaryInstanceRegion;
            query["Description"] = request.Description;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGdnInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGdnInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateGdnInstanceResponse CreateGdnInstance(CreateGdnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGdnInstanceWithOptions(request, runtime);
        }

        public async Task<CreateGdnInstanceResponse> CreateGdnInstanceAsync(CreateGdnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGdnInstanceWithOptionsAsync(request, runtime);
        }

        public CreateMigrateTaskResponse CreateMigrateTaskWithOptions(CreateMigrateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBName"] = request.DBName;
            query["BackupMode"] = request.BackupMode;
            query["IsOnlineDB"] = request.IsOnlineDB;
            query["CheckDBMode"] = request.CheckDBMode;
            query["OssObjectPositions"] = request.OssObjectPositions;
            query["OSSUrls"] = request.OSSUrls;
            query["MigrateTaskId"] = request.MigrateTaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMigrateTask",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMigrateTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateMigrateTaskResponse> CreateMigrateTaskWithOptionsAsync(CreateMigrateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBName"] = request.DBName;
            query["BackupMode"] = request.BackupMode;
            query["IsOnlineDB"] = request.IsOnlineDB;
            query["CheckDBMode"] = request.CheckDBMode;
            query["OssObjectPositions"] = request.OssObjectPositions;
            query["OSSUrls"] = request.OSSUrls;
            query["MigrateTaskId"] = request.MigrateTaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMigrateTask",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMigrateTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateMigrateTaskResponse CreateMigrateTask(CreateMigrateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMigrateTaskWithOptions(request, runtime);
        }

        public async Task<CreateMigrateTaskResponse> CreateMigrateTaskAsync(CreateMigrateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMigrateTaskWithOptionsAsync(request, runtime);
        }

        public CreateMigrateTaskForSQLServerResponse CreateMigrateTaskForSQLServerWithOptions(CreateMigrateTaskForSQLServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBName"] = request.DBName;
            query["TaskType"] = request.TaskType;
            query["IsOnlineDB"] = request.IsOnlineDB;
            query["OSSUrls"] = request.OSSUrls;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMigrateTaskForSQLServer",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMigrateTaskForSQLServerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateMigrateTaskForSQLServerResponse> CreateMigrateTaskForSQLServerWithOptionsAsync(CreateMigrateTaskForSQLServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBName"] = request.DBName;
            query["TaskType"] = request.TaskType;
            query["IsOnlineDB"] = request.IsOnlineDB;
            query["OSSUrls"] = request.OSSUrls;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMigrateTaskForSQLServer",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMigrateTaskForSQLServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateMigrateTaskForSQLServerResponse CreateMigrateTaskForSQLServer(CreateMigrateTaskForSQLServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMigrateTaskForSQLServerWithOptions(request, runtime);
        }

        public async Task<CreateMigrateTaskForSQLServerResponse> CreateMigrateTaskForSQLServerAsync(CreateMigrateTaskForSQLServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMigrateTaskForSQLServerWithOptionsAsync(request, runtime);
        }

        public CreateOnlineDatabaseTaskResponse CreateOnlineDatabaseTaskWithOptions(CreateOnlineDatabaseTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBName"] = request.DBName;
            query["MigrateTaskId"] = request.MigrateTaskId;
            query["CheckDBMode"] = request.CheckDBMode;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOnlineDatabaseTask",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOnlineDatabaseTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateOnlineDatabaseTaskResponse> CreateOnlineDatabaseTaskWithOptionsAsync(CreateOnlineDatabaseTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBName"] = request.DBName;
            query["MigrateTaskId"] = request.MigrateTaskId;
            query["CheckDBMode"] = request.CheckDBMode;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOnlineDatabaseTask",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOnlineDatabaseTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateOnlineDatabaseTaskResponse CreateOnlineDatabaseTask(CreateOnlineDatabaseTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOnlineDatabaseTaskWithOptions(request, runtime);
        }

        public async Task<CreateOnlineDatabaseTaskResponse> CreateOnlineDatabaseTaskAsync(CreateOnlineDatabaseTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOnlineDatabaseTaskWithOptionsAsync(request, runtime);
        }

        public CreateParameterGroupResponse CreateParameterGroupWithOptions(CreateParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["ParameterGroupName"] = request.ParameterGroupName;
            query["Engine"] = request.Engine;
            query["EngineVersion"] = request.EngineVersion;
            query["Parameters"] = request.Parameters;
            query["ParameterGroupDesc"] = request.ParameterGroupDesc;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateParameterGroup",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateParameterGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateParameterGroupResponse> CreateParameterGroupWithOptionsAsync(CreateParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["ParameterGroupName"] = request.ParameterGroupName;
            query["Engine"] = request.Engine;
            query["EngineVersion"] = request.EngineVersion;
            query["Parameters"] = request.Parameters;
            query["ParameterGroupDesc"] = request.ParameterGroupDesc;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateParameterGroup",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateParameterGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateParameterGroupResponse CreateParameterGroup(CreateParameterGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateParameterGroupWithOptions(request, runtime);
        }

        public async Task<CreateParameterGroupResponse> CreateParameterGroupAsync(CreateParameterGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateParameterGroupWithOptionsAsync(request, runtime);
        }

        public CreateReadOnlyDBInstanceResponse CreateReadOnlyDBInstanceWithOptions(CreateReadOnlyDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["RegionId"] = request.RegionId;
            query["ZoneId"] = request.ZoneId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["DBInstanceStorage"] = request.DBInstanceStorage;
            query["EngineVersion"] = request.EngineVersion;
            query["PayType"] = request.PayType;
            query["DBInstanceDescription"] = request.DBInstanceDescription;
            query["InstanceNetworkType"] = request.InstanceNetworkType;
            query["VPCId"] = request.VPCId;
            query["VSwitchId"] = request.VSwitchId;
            query["PrivateIpAddress"] = request.PrivateIpAddress;
            query["OwnerAccount"] = request.OwnerAccount;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["Category"] = request.Category;
            query["DBInstanceStorageType"] = request.DBInstanceStorageType;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["TargetDedicatedHostIdForMaster"] = request.TargetDedicatedHostIdForMaster;
            query["GdnInstanceName"] = request.GdnInstanceName;
            query["TddlBizType"] = request.TddlBizType;
            query["TddlRegionConfig"] = request.TddlRegionConfig;
            query["InstructionSetArch"] = request.InstructionSetArch;
            query["UsedTime"] = request.UsedTime;
            query["Period"] = request.Period;
            query["AutoRenew"] = request.AutoRenew;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateReadOnlyDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateReadOnlyDBInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateReadOnlyDBInstanceResponse> CreateReadOnlyDBInstanceWithOptionsAsync(CreateReadOnlyDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["RegionId"] = request.RegionId;
            query["ZoneId"] = request.ZoneId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["DBInstanceStorage"] = request.DBInstanceStorage;
            query["EngineVersion"] = request.EngineVersion;
            query["PayType"] = request.PayType;
            query["DBInstanceDescription"] = request.DBInstanceDescription;
            query["InstanceNetworkType"] = request.InstanceNetworkType;
            query["VPCId"] = request.VPCId;
            query["VSwitchId"] = request.VSwitchId;
            query["PrivateIpAddress"] = request.PrivateIpAddress;
            query["OwnerAccount"] = request.OwnerAccount;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["Category"] = request.Category;
            query["DBInstanceStorageType"] = request.DBInstanceStorageType;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["TargetDedicatedHostIdForMaster"] = request.TargetDedicatedHostIdForMaster;
            query["GdnInstanceName"] = request.GdnInstanceName;
            query["TddlBizType"] = request.TddlBizType;
            query["TddlRegionConfig"] = request.TddlRegionConfig;
            query["InstructionSetArch"] = request.InstructionSetArch;
            query["UsedTime"] = request.UsedTime;
            query["Period"] = request.Period;
            query["AutoRenew"] = request.AutoRenew;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateReadOnlyDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateReadOnlyDBInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateReadOnlyDBInstanceResponse CreateReadOnlyDBInstance(CreateReadOnlyDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateReadOnlyDBInstanceWithOptions(request, runtime);
        }

        public async Task<CreateReadOnlyDBInstanceResponse> CreateReadOnlyDBInstanceAsync(CreateReadOnlyDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateReadOnlyDBInstanceWithOptionsAsync(request, runtime);
        }

        public CreateTempDBInstanceResponse CreateTempDBInstanceWithOptions(CreateTempDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["BackupId"] = request.BackupId;
            query["RestoreTime"] = request.RestoreTime;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTempDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTempDBInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTempDBInstanceResponse> CreateTempDBInstanceWithOptionsAsync(CreateTempDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["BackupId"] = request.BackupId;
            query["RestoreTime"] = request.RestoreTime;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTempDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTempDBInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTempDBInstanceResponse CreateTempDBInstance(CreateTempDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTempDBInstanceWithOptions(request, runtime);
        }

        public async Task<CreateTempDBInstanceResponse> CreateTempDBInstanceAsync(CreateTempDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTempDBInstanceWithOptionsAsync(request, runtime);
        }

        public DeleteAccountResponse DeleteAccountWithOptions(DeleteAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AccountName"] = request.AccountName;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccount",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteAccountResponse> DeleteAccountWithOptionsAsync(DeleteAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AccountName"] = request.AccountName;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccount",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteAccountResponse DeleteAccount(DeleteAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccountWithOptions(request, runtime);
        }

        public async Task<DeleteAccountResponse> DeleteAccountAsync(DeleteAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccountWithOptionsAsync(request, runtime);
        }

        public DeleteBackupResponse DeleteBackupWithOptions(DeleteBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["BackupId"] = request.BackupId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBackup",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBackupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteBackupResponse> DeleteBackupWithOptionsAsync(DeleteBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["BackupId"] = request.BackupId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBackup",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBackupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteBackupResponse DeleteBackup(DeleteBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBackupWithOptions(request, runtime);
        }

        public async Task<DeleteBackupResponse> DeleteBackupAsync(DeleteBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBackupWithOptionsAsync(request, runtime);
        }

        public DeleteBackupFileResponse DeleteBackupFileWithOptions(DeleteBackupFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["BackupId"] = request.BackupId;
            query["DBName"] = request.DBName;
            query["BackupTime"] = request.BackupTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBackupFile",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBackupFileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteBackupFileResponse> DeleteBackupFileWithOptionsAsync(DeleteBackupFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["BackupId"] = request.BackupId;
            query["DBName"] = request.DBName;
            query["BackupTime"] = request.BackupTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBackupFile",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBackupFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteBackupFileResponse DeleteBackupFile(DeleteBackupFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBackupFileWithOptions(request, runtime);
        }

        public async Task<DeleteBackupFileResponse> DeleteBackupFileAsync(DeleteBackupFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBackupFileWithOptionsAsync(request, runtime);
        }

        public DeleteDatabaseResponse DeleteDatabaseWithOptions(DeleteDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBName"] = request.DBName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatabase",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatabaseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDatabaseResponse> DeleteDatabaseWithOptionsAsync(DeleteDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBName"] = request.DBName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatabase",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDatabaseResponse DeleteDatabase(DeleteDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDatabaseWithOptions(request, runtime);
        }

        public async Task<DeleteDatabaseResponse> DeleteDatabaseAsync(DeleteDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDatabaseWithOptionsAsync(request, runtime);
        }

        public DeleteDBInstanceResponse DeleteDBInstanceWithOptions(DeleteDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["ReleasedKeepPolicy"] = request.ReleasedKeepPolicy;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDBInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDBInstanceResponse> DeleteDBInstanceWithOptionsAsync(DeleteDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["ReleasedKeepPolicy"] = request.ReleasedKeepPolicy;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDBInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDBInstanceResponse DeleteDBInstance(DeleteDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDBInstanceWithOptions(request, runtime);
        }

        public async Task<DeleteDBInstanceResponse> DeleteDBInstanceAsync(DeleteDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDBInstanceWithOptionsAsync(request, runtime);
        }

        public DeleteDBProxyEndpointAddressResponse DeleteDBProxyEndpointAddressWithOptions(DeleteDBProxyEndpointAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBProxyEndpointId"] = request.DBProxyEndpointId;
            query["DBProxyConnectStringNetType"] = request.DBProxyConnectStringNetType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDBProxyEndpointAddress",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDBProxyEndpointAddressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDBProxyEndpointAddressResponse> DeleteDBProxyEndpointAddressWithOptionsAsync(DeleteDBProxyEndpointAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBProxyEndpointId"] = request.DBProxyEndpointId;
            query["DBProxyConnectStringNetType"] = request.DBProxyConnectStringNetType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDBProxyEndpointAddress",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDBProxyEndpointAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDBProxyEndpointAddressResponse DeleteDBProxyEndpointAddress(DeleteDBProxyEndpointAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDBProxyEndpointAddressWithOptions(request, runtime);
        }

        public async Task<DeleteDBProxyEndpointAddressResponse> DeleteDBProxyEndpointAddressAsync(DeleteDBProxyEndpointAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDBProxyEndpointAddressWithOptionsAsync(request, runtime);
        }

        public DeleteDedicatedHostAccountResponse DeleteDedicatedHostAccountWithOptions(DeleteDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["AccountName"] = request.AccountName;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDedicatedHostAccount",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDedicatedHostAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDedicatedHostAccountResponse> DeleteDedicatedHostAccountWithOptionsAsync(DeleteDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["AccountName"] = request.AccountName;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDedicatedHostAccount",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDedicatedHostAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDedicatedHostAccountResponse DeleteDedicatedHostAccount(DeleteDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDedicatedHostAccountWithOptions(request, runtime);
        }

        public async Task<DeleteDedicatedHostAccountResponse> DeleteDedicatedHostAccountAsync(DeleteDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDedicatedHostAccountWithOptionsAsync(request, runtime);
        }

        public DeleteDedicatedHostGroupResponse DeleteDedicatedHostGroupWithOptions(DeleteDedicatedHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDedicatedHostGroup",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDedicatedHostGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDedicatedHostGroupResponse> DeleteDedicatedHostGroupWithOptionsAsync(DeleteDedicatedHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDedicatedHostGroup",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDedicatedHostGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDedicatedHostGroupResponse DeleteDedicatedHostGroup(DeleteDedicatedHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDedicatedHostGroupWithOptions(request, runtime);
        }

        public async Task<DeleteDedicatedHostGroupResponse> DeleteDedicatedHostGroupAsync(DeleteDedicatedHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDedicatedHostGroupWithOptionsAsync(request, runtime);
        }

        public DeleteParameterGroupResponse DeleteParameterGroupWithOptions(DeleteParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["ParameterGroupId"] = request.ParameterGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteParameterGroup",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteParameterGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteParameterGroupResponse> DeleteParameterGroupWithOptionsAsync(DeleteParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["ParameterGroupId"] = request.ParameterGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteParameterGroup",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteParameterGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteParameterGroupResponse DeleteParameterGroup(DeleteParameterGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteParameterGroupWithOptions(request, runtime);
        }

        public async Task<DeleteParameterGroupResponse> DeleteParameterGroupAsync(DeleteParameterGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteParameterGroupWithOptionsAsync(request, runtime);
        }

        public DeleteUserBackupFileResponse DeleteUserBackupFileWithOptions(DeleteUserBackupFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["BackupId"] = request.BackupId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserBackupFile",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserBackupFileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteUserBackupFileResponse> DeleteUserBackupFileWithOptionsAsync(DeleteUserBackupFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["BackupId"] = request.BackupId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserBackupFile",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserBackupFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteUserBackupFileResponse DeleteUserBackupFile(DeleteUserBackupFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserBackupFileWithOptions(request, runtime);
        }

        public async Task<DeleteUserBackupFileResponse> DeleteUserBackupFileAsync(DeleteUserBackupFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserBackupFileWithOptionsAsync(request, runtime);
        }

        public DescibeImportsFromDatabaseResponse DescibeImportsFromDatabaseWithOptions(DescibeImportsFromDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Engine"] = request.Engine;
            query["ImportId"] = request.ImportId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescibeImportsFromDatabase",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescibeImportsFromDatabaseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescibeImportsFromDatabaseResponse> DescibeImportsFromDatabaseWithOptionsAsync(DescibeImportsFromDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Engine"] = request.Engine;
            query["ImportId"] = request.ImportId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescibeImportsFromDatabase",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescibeImportsFromDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescibeImportsFromDatabaseResponse DescibeImportsFromDatabase(DescibeImportsFromDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescibeImportsFromDatabaseWithOptions(request, runtime);
        }

        public async Task<DescibeImportsFromDatabaseResponse> DescibeImportsFromDatabaseAsync(DescibeImportsFromDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescibeImportsFromDatabaseWithOptionsAsync(request, runtime);
        }

        public DescribeAccountsResponse DescribeAccountsWithOptions(DescribeAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AccountName"] = request.AccountName;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccounts",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccountsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAccountsResponse> DescribeAccountsWithOptionsAsync(DescribeAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AccountName"] = request.AccountName;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccounts",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccountsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAccountsResponse DescribeAccounts(DescribeAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccountsWithOptions(request, runtime);
        }

        public async Task<DescribeAccountsResponse> DescribeAccountsAsync(DescribeAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccountsWithOptionsAsync(request, runtime);
        }

        public DescribeActionEventPolicyResponse DescribeActionEventPolicyWithOptions(DescribeActionEventPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeActionEventPolicy",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeActionEventPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeActionEventPolicyResponse> DescribeActionEventPolicyWithOptionsAsync(DescribeActionEventPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeActionEventPolicy",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeActionEventPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeActionEventPolicyResponse DescribeActionEventPolicy(DescribeActionEventPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeActionEventPolicyWithOptions(request, runtime);
        }

        public async Task<DescribeActionEventPolicyResponse> DescribeActionEventPolicyAsync(DescribeActionEventPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeActionEventPolicyWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableClassesResponse DescribeAvailableClassesWithOptions(DescribeAvailableClassesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["ZoneId"] = request.ZoneId;
            query["InstanceChargeType"] = request.InstanceChargeType;
            query["Engine"] = request.Engine;
            query["EngineVersion"] = request.EngineVersion;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OrderType"] = request.OrderType;
            query["DBInstanceStorageType"] = request.DBInstanceStorageType;
            query["Category"] = request.Category;
            query["CommodityCode"] = request.CommodityCode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableClasses",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableClassesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAvailableClassesResponse> DescribeAvailableClassesWithOptionsAsync(DescribeAvailableClassesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["ZoneId"] = request.ZoneId;
            query["InstanceChargeType"] = request.InstanceChargeType;
            query["Engine"] = request.Engine;
            query["EngineVersion"] = request.EngineVersion;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OrderType"] = request.OrderType;
            query["DBInstanceStorageType"] = request.DBInstanceStorageType;
            query["Category"] = request.Category;
            query["CommodityCode"] = request.CommodityCode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableClasses",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableClassesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAvailableClassesResponse DescribeAvailableClasses(DescribeAvailableClassesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableClassesWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableClassesResponse> DescribeAvailableClassesAsync(DescribeAvailableClassesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableClassesWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableCrossRegionResponse DescribeAvailableCrossRegionWithOptions(DescribeAvailableCrossRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableCrossRegion",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableCrossRegionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAvailableCrossRegionResponse> DescribeAvailableCrossRegionWithOptionsAsync(DescribeAvailableCrossRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableCrossRegion",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableCrossRegionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAvailableCrossRegionResponse DescribeAvailableCrossRegion(DescribeAvailableCrossRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableCrossRegionWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableCrossRegionResponse> DescribeAvailableCrossRegionAsync(DescribeAvailableCrossRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableCrossRegionWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableDedicatedHostClassesResponse DescribeAvailableDedicatedHostClassesWithOptions(DescribeAvailableDedicatedHostClassesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["ZoneId"] = request.ZoneId;
            query["StorageType"] = request.StorageType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableDedicatedHostClasses",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableDedicatedHostClassesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAvailableDedicatedHostClassesResponse> DescribeAvailableDedicatedHostClassesWithOptionsAsync(DescribeAvailableDedicatedHostClassesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["ZoneId"] = request.ZoneId;
            query["StorageType"] = request.StorageType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableDedicatedHostClasses",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableDedicatedHostClassesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAvailableDedicatedHostClassesResponse DescribeAvailableDedicatedHostClasses(DescribeAvailableDedicatedHostClassesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableDedicatedHostClassesWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableDedicatedHostClassesResponse> DescribeAvailableDedicatedHostClassesAsync(DescribeAvailableDedicatedHostClassesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableDedicatedHostClassesWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableDedicatedHostZonesResponse DescribeAvailableDedicatedHostZonesWithOptions(DescribeAvailableDedicatedHostZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableDedicatedHostZones",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableDedicatedHostZonesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAvailableDedicatedHostZonesResponse> DescribeAvailableDedicatedHostZonesWithOptionsAsync(DescribeAvailableDedicatedHostZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableDedicatedHostZones",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableDedicatedHostZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAvailableDedicatedHostZonesResponse DescribeAvailableDedicatedHostZones(DescribeAvailableDedicatedHostZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableDedicatedHostZonesWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableDedicatedHostZonesResponse> DescribeAvailableDedicatedHostZonesAsync(DescribeAvailableDedicatedHostZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableDedicatedHostZonesWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableRecoveryTimeResponse DescribeAvailableRecoveryTimeWithOptions(DescribeAvailableRecoveryTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["CrossBackupId"] = request.CrossBackupId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableRecoveryTime",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableRecoveryTimeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAvailableRecoveryTimeResponse> DescribeAvailableRecoveryTimeWithOptionsAsync(DescribeAvailableRecoveryTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["CrossBackupId"] = request.CrossBackupId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableRecoveryTime",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableRecoveryTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAvailableRecoveryTimeResponse DescribeAvailableRecoveryTime(DescribeAvailableRecoveryTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableRecoveryTimeWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableRecoveryTimeResponse> DescribeAvailableRecoveryTimeAsync(DescribeAvailableRecoveryTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableRecoveryTimeWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableResourceResponse DescribeAvailableResourceWithOptions(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["ZoneId"] = request.ZoneId;
            query["InstanceChargeType"] = request.InstanceChargeType;
            query["Engine"] = request.Engine;
            query["EngineVersion"] = request.EngineVersion;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["OrderType"] = request.OrderType;
            query["DBInstanceStorageType"] = request.DBInstanceStorageType;
            query["Category"] = request.Category;
            query["DispenseMode"] = request.DispenseMode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableResource",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceWithOptionsAsync(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["ZoneId"] = request.ZoneId;
            query["InstanceChargeType"] = request.InstanceChargeType;
            query["Engine"] = request.Engine;
            query["EngineVersion"] = request.EngineVersion;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["OrderType"] = request.OrderType;
            query["DBInstanceStorageType"] = request.DBInstanceStorageType;
            query["Category"] = request.Category;
            query["DispenseMode"] = request.DispenseMode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableResource",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAvailableResourceResponse DescribeAvailableResource(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableResourceWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceAsync(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableResourceWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableZonesResponse DescribeAvailableZonesWithOptions(DescribeAvailableZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["Engine"] = request.Engine;
            query["ZoneId"] = request.ZoneId;
            query["EngineVersion"] = request.EngineVersion;
            query["CommodityCode"] = request.CommodityCode;
            query["DispenseMode"] = request.DispenseMode;
            query["DBInstanceName"] = request.DBInstanceName;
            query["Category"] = request.Category;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableZones",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableZonesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAvailableZonesResponse> DescribeAvailableZonesWithOptionsAsync(DescribeAvailableZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["Engine"] = request.Engine;
            query["ZoneId"] = request.ZoneId;
            query["EngineVersion"] = request.EngineVersion;
            query["CommodityCode"] = request.CommodityCode;
            query["DispenseMode"] = request.DispenseMode;
            query["DBInstanceName"] = request.DBInstanceName;
            query["Category"] = request.Category;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableZones",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAvailableZonesResponse DescribeAvailableZones(DescribeAvailableZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableZonesWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableZonesResponse> DescribeAvailableZonesAsync(DescribeAvailableZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableZonesWithOptionsAsync(request, runtime);
        }

        public DescribeBackupDatabaseResponse DescribeBackupDatabaseWithOptions(DescribeBackupDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["BackupId"] = request.BackupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupDatabase",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupDatabaseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeBackupDatabaseResponse> DescribeBackupDatabaseWithOptionsAsync(DescribeBackupDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["BackupId"] = request.BackupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupDatabase",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeBackupDatabaseResponse DescribeBackupDatabase(DescribeBackupDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupDatabaseWithOptions(request, runtime);
        }

        public async Task<DescribeBackupDatabaseResponse> DescribeBackupDatabaseAsync(DescribeBackupDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupDatabaseWithOptionsAsync(request, runtime);
        }

        public DescribeBackupPolicyResponse DescribeBackupPolicyWithOptions(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["BackupPolicyMode"] = request.BackupPolicyMode;
            query["OwnerAccount"] = request.OwnerAccount;
            query["CompressType"] = request.CompressType;
            query["ReleasedKeepPolicy"] = request.ReleasedKeepPolicy;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupPolicy",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeBackupPolicyResponse> DescribeBackupPolicyWithOptionsAsync(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["BackupPolicyMode"] = request.BackupPolicyMode;
            query["OwnerAccount"] = request.OwnerAccount;
            query["CompressType"] = request.CompressType;
            query["ReleasedKeepPolicy"] = request.ReleasedKeepPolicy;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupPolicy",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeBackupPolicyResponse DescribeBackupPolicy(DescribeBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupPolicyWithOptions(request, runtime);
        }

        public async Task<DescribeBackupPolicyResponse> DescribeBackupPolicyAsync(DescribeBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupPolicyWithOptionsAsync(request, runtime);
        }

        public DescribeBackupsResponse DescribeBackupsWithOptions(DescribeBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["BackupId"] = request.BackupId;
            query["BackupStatus"] = request.BackupStatus;
            query["BackupMode"] = request.BackupMode;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackups",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeBackupsResponse> DescribeBackupsWithOptionsAsync(DescribeBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["BackupId"] = request.BackupId;
            query["BackupStatus"] = request.BackupStatus;
            query["BackupMode"] = request.BackupMode;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackups",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeBackupsResponse DescribeBackups(DescribeBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupsWithOptions(request, runtime);
        }

        public async Task<DescribeBackupsResponse> DescribeBackupsAsync(DescribeBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupsWithOptionsAsync(request, runtime);
        }

        public DescribeBackupTasksResponse DescribeBackupTasksWithOptions(DescribeBackupTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["Flag"] = request.Flag;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["BackupJobId"] = request.BackupJobId;
            query["BackupMode"] = request.BackupMode;
            query["BackupJobStatus"] = request.BackupJobStatus;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupTasks",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupTasksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeBackupTasksResponse> DescribeBackupTasksWithOptionsAsync(DescribeBackupTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["Flag"] = request.Flag;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["BackupJobId"] = request.BackupJobId;
            query["BackupMode"] = request.BackupMode;
            query["BackupJobStatus"] = request.BackupJobStatus;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupTasks",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeBackupTasksResponse DescribeBackupTasks(DescribeBackupTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupTasksWithOptions(request, runtime);
        }

        public async Task<DescribeBackupTasksResponse> DescribeBackupTasksAsync(DescribeBackupTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupTasksWithOptionsAsync(request, runtime);
        }

        public DescribeBinlogFilesResponse DescribeBinlogFilesWithOptions(DescribeBinlogFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBinlogFiles",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBinlogFilesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeBinlogFilesResponse> DescribeBinlogFilesWithOptionsAsync(DescribeBinlogFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBinlogFiles",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBinlogFilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeBinlogFilesResponse DescribeBinlogFiles(DescribeBinlogFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBinlogFilesWithOptions(request, runtime);
        }

        public async Task<DescribeBinlogFilesResponse> DescribeBinlogFilesAsync(DescribeBinlogFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBinlogFilesWithOptionsAsync(request, runtime);
        }

        public DescribeCharacterSetNameResponse DescribeCharacterSetNameWithOptions(DescribeCharacterSetNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Engine"] = request.Engine;
            query["RegionId"] = request.RegionId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCharacterSetName",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCharacterSetNameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCharacterSetNameResponse> DescribeCharacterSetNameWithOptionsAsync(DescribeCharacterSetNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Engine"] = request.Engine;
            query["RegionId"] = request.RegionId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCharacterSetName",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCharacterSetNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCharacterSetNameResponse DescribeCharacterSetName(DescribeCharacterSetNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCharacterSetNameWithOptions(request, runtime);
        }

        public async Task<DescribeCharacterSetNameResponse> DescribeCharacterSetNameAsync(DescribeCharacterSetNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCharacterSetNameWithOptionsAsync(request, runtime);
        }

        public DescribeCollationTimeZonesResponse DescribeCollationTimeZonesWithOptions(DescribeCollationTimeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCollationTimeZones",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCollationTimeZonesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCollationTimeZonesResponse> DescribeCollationTimeZonesWithOptionsAsync(DescribeCollationTimeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCollationTimeZones",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCollationTimeZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCollationTimeZonesResponse DescribeCollationTimeZones(DescribeCollationTimeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCollationTimeZonesWithOptions(request, runtime);
        }

        public async Task<DescribeCollationTimeZonesResponse> DescribeCollationTimeZonesAsync(DescribeCollationTimeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCollationTimeZonesWithOptionsAsync(request, runtime);
        }

        public DescribeCrossBackupMetaListResponse DescribeCrossBackupMetaListWithOptions(DescribeCrossBackupMetaListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["BackupSetId"] = request.BackupSetId;
            query["GetDbName"] = request.GetDbName;
            query["Pattern"] = request.Pattern;
            query["PageSize"] = request.PageSize;
            query["PageIndex"] = request.PageIndex;
            query["Region"] = request.Region;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCrossBackupMetaList",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCrossBackupMetaListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCrossBackupMetaListResponse> DescribeCrossBackupMetaListWithOptionsAsync(DescribeCrossBackupMetaListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["BackupSetId"] = request.BackupSetId;
            query["GetDbName"] = request.GetDbName;
            query["Pattern"] = request.Pattern;
            query["PageSize"] = request.PageSize;
            query["PageIndex"] = request.PageIndex;
            query["Region"] = request.Region;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCrossBackupMetaList",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCrossBackupMetaListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCrossBackupMetaListResponse DescribeCrossBackupMetaList(DescribeCrossBackupMetaListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCrossBackupMetaListWithOptions(request, runtime);
        }

        public async Task<DescribeCrossBackupMetaListResponse> DescribeCrossBackupMetaListAsync(DescribeCrossBackupMetaListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCrossBackupMetaListWithOptionsAsync(request, runtime);
        }

        public DescribeCrossRegionBackupDBInstanceResponse DescribeCrossRegionBackupDBInstanceWithOptions(DescribeCrossRegionBackupDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCrossRegionBackupDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCrossRegionBackupDBInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCrossRegionBackupDBInstanceResponse> DescribeCrossRegionBackupDBInstanceWithOptionsAsync(DescribeCrossRegionBackupDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCrossRegionBackupDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCrossRegionBackupDBInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCrossRegionBackupDBInstanceResponse DescribeCrossRegionBackupDBInstance(DescribeCrossRegionBackupDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCrossRegionBackupDBInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeCrossRegionBackupDBInstanceResponse> DescribeCrossRegionBackupDBInstanceAsync(DescribeCrossRegionBackupDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCrossRegionBackupDBInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeCrossRegionBackupsResponse DescribeCrossRegionBackupsWithOptions(DescribeCrossRegionBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            query["CrossBackupRegion"] = request.CrossBackupRegion;
            query["CrossBackupId"] = request.CrossBackupId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["BackupId"] = request.BackupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCrossRegionBackups",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCrossRegionBackupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCrossRegionBackupsResponse> DescribeCrossRegionBackupsWithOptionsAsync(DescribeCrossRegionBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            query["CrossBackupRegion"] = request.CrossBackupRegion;
            query["CrossBackupId"] = request.CrossBackupId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["BackupId"] = request.BackupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCrossRegionBackups",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCrossRegionBackupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCrossRegionBackupsResponse DescribeCrossRegionBackups(DescribeCrossRegionBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCrossRegionBackupsWithOptions(request, runtime);
        }

        public async Task<DescribeCrossRegionBackupsResponse> DescribeCrossRegionBackupsAsync(DescribeCrossRegionBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCrossRegionBackupsWithOptionsAsync(request, runtime);
        }

        public DescribeCrossRegionLogBackupFilesResponse DescribeCrossRegionLogBackupFilesWithOptions(DescribeCrossRegionLogBackupFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            query["CrossBackupRegion"] = request.CrossBackupRegion;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCrossRegionLogBackupFiles",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCrossRegionLogBackupFilesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCrossRegionLogBackupFilesResponse> DescribeCrossRegionLogBackupFilesWithOptionsAsync(DescribeCrossRegionLogBackupFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            query["CrossBackupRegion"] = request.CrossBackupRegion;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCrossRegionLogBackupFiles",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCrossRegionLogBackupFilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCrossRegionLogBackupFilesResponse DescribeCrossRegionLogBackupFiles(DescribeCrossRegionLogBackupFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCrossRegionLogBackupFilesWithOptions(request, runtime);
        }

        public async Task<DescribeCrossRegionLogBackupFilesResponse> DescribeCrossRegionLogBackupFilesAsync(DescribeCrossRegionLogBackupFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCrossRegionLogBackupFilesWithOptionsAsync(request, runtime);
        }

        public DescribeDatabasesResponse DescribeDatabasesWithOptions(DescribeDatabasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBName"] = request.DBName;
            query["DBStatus"] = request.DBStatus;
            query["OwnerAccount"] = request.OwnerAccount;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDatabases",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDatabasesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDatabasesResponse> DescribeDatabasesWithOptionsAsync(DescribeDatabasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBName"] = request.DBName;
            query["DBStatus"] = request.DBStatus;
            query["OwnerAccount"] = request.OwnerAccount;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDatabases",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDatabasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDatabasesResponse DescribeDatabases(DescribeDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDatabasesWithOptions(request, runtime);
        }

        public async Task<DescribeDatabasesResponse> DescribeDatabasesAsync(DescribeDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDatabasesWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceAttributeResponse DescribeDBInstanceAttributeWithOptions(DescribeDBInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Expired"] = request.Expired;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceAttribute",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDBInstanceAttributeResponse> DescribeDBInstanceAttributeWithOptionsAsync(DescribeDBInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Expired"] = request.Expired;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceAttribute",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDBInstanceAttributeResponse DescribeDBInstanceAttribute(DescribeDBInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceAttributeResponse> DescribeDBInstanceAttributeAsync(DescribeDBInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceDetailResponse DescribeDBInstanceDetailWithOptions(DescribeDBInstanceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceDetail",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDBInstanceDetailResponse> DescribeDBInstanceDetailWithOptionsAsync(DescribeDBInstanceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceDetail",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDBInstanceDetailResponse DescribeDBInstanceDetail(DescribeDBInstanceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceDetailWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceDetailResponse> DescribeDBInstanceDetailAsync(DescribeDBInstanceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceDetailWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceEncryptionKeyResponse DescribeDBInstanceEncryptionKeyWithOptions(DescribeDBInstanceEncryptionKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["EncryptionKey"] = request.EncryptionKey;
            query["TargetRegionId"] = request.TargetRegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceEncryptionKey",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceEncryptionKeyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDBInstanceEncryptionKeyResponse> DescribeDBInstanceEncryptionKeyWithOptionsAsync(DescribeDBInstanceEncryptionKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["EncryptionKey"] = request.EncryptionKey;
            query["TargetRegionId"] = request.TargetRegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceEncryptionKey",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceEncryptionKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDBInstanceEncryptionKeyResponse DescribeDBInstanceEncryptionKey(DescribeDBInstanceEncryptionKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceEncryptionKeyWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceEncryptionKeyResponse> DescribeDBInstanceEncryptionKeyAsync(DescribeDBInstanceEncryptionKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceEncryptionKeyWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceHAConfigResponse DescribeDBInstanceHAConfigWithOptions(DescribeDBInstanceHAConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceHAConfig",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceHAConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDBInstanceHAConfigResponse> DescribeDBInstanceHAConfigWithOptionsAsync(DescribeDBInstanceHAConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceHAConfig",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceHAConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDBInstanceHAConfigResponse DescribeDBInstanceHAConfig(DescribeDBInstanceHAConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceHAConfigWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceHAConfigResponse> DescribeDBInstanceHAConfigAsync(DescribeDBInstanceHAConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceHAConfigWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceIPArrayListResponse DescribeDBInstanceIPArrayListWithOptions(DescribeDBInstanceIPArrayListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["WhitelistNetworkType"] = request.WhitelistNetworkType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceIPArrayList",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceIPArrayListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDBInstanceIPArrayListResponse> DescribeDBInstanceIPArrayListWithOptionsAsync(DescribeDBInstanceIPArrayListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["WhitelistNetworkType"] = request.WhitelistNetworkType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceIPArrayList",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceIPArrayListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDBInstanceIPArrayListResponse DescribeDBInstanceIPArrayList(DescribeDBInstanceIPArrayListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceIPArrayListWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceIPArrayListResponse> DescribeDBInstanceIPArrayListAsync(DescribeDBInstanceIPArrayListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceIPArrayListWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceIpHostnameResponse DescribeDBInstanceIpHostnameWithOptions(DescribeDBInstanceIpHostnameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceIpHostname",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceIpHostnameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDBInstanceIpHostnameResponse> DescribeDBInstanceIpHostnameWithOptionsAsync(DescribeDBInstanceIpHostnameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceIpHostname",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceIpHostnameResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDBInstanceIpHostnameResponse DescribeDBInstanceIpHostname(DescribeDBInstanceIpHostnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceIpHostnameWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceIpHostnameResponse> DescribeDBInstanceIpHostnameAsync(DescribeDBInstanceIpHostnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceIpHostnameWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceMonitorResponse DescribeDBInstanceMonitorWithOptions(DescribeDBInstanceMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceMonitor",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceMonitorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDBInstanceMonitorResponse> DescribeDBInstanceMonitorWithOptionsAsync(DescribeDBInstanceMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceMonitor",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDBInstanceMonitorResponse DescribeDBInstanceMonitor(DescribeDBInstanceMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceMonitorWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceMonitorResponse> DescribeDBInstanceMonitorAsync(DescribeDBInstanceMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceMonitorWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceNetInfoResponse DescribeDBInstanceNetInfoWithOptions(DescribeDBInstanceNetInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Flag"] = request.Flag;
            query["DBInstanceNetRWSplitType"] = request.DBInstanceNetRWSplitType;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceNetInfo",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceNetInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDBInstanceNetInfoResponse> DescribeDBInstanceNetInfoWithOptionsAsync(DescribeDBInstanceNetInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Flag"] = request.Flag;
            query["DBInstanceNetRWSplitType"] = request.DBInstanceNetRWSplitType;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceNetInfo",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceNetInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDBInstanceNetInfoResponse DescribeDBInstanceNetInfo(DescribeDBInstanceNetInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceNetInfoWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceNetInfoResponse> DescribeDBInstanceNetInfoAsync(DescribeDBInstanceNetInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceNetInfoWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstancePerformanceResponse DescribeDBInstancePerformanceWithOptions(DescribeDBInstancePerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Key"] = request.Key;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstancePerformance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstancePerformanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDBInstancePerformanceResponse> DescribeDBInstancePerformanceWithOptionsAsync(DescribeDBInstancePerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Key"] = request.Key;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstancePerformance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstancePerformanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDBInstancePerformanceResponse DescribeDBInstancePerformance(DescribeDBInstancePerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstancePerformanceWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstancePerformanceResponse> DescribeDBInstancePerformanceAsync(DescribeDBInstancePerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstancePerformanceWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceProxyConfigurationResponse DescribeDBInstanceProxyConfigurationWithOptions(DescribeDBInstanceProxyConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceProxyConfiguration",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceProxyConfigurationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDBInstanceProxyConfigurationResponse> DescribeDBInstanceProxyConfigurationWithOptionsAsync(DescribeDBInstanceProxyConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceProxyConfiguration",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceProxyConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDBInstanceProxyConfigurationResponse DescribeDBInstanceProxyConfiguration(DescribeDBInstanceProxyConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceProxyConfigurationWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceProxyConfigurationResponse> DescribeDBInstanceProxyConfigurationAsync(DescribeDBInstanceProxyConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceProxyConfigurationWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstancesResponse DescribeDBInstancesWithOptions(DescribeDBInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["proxyId"] = request.ProxyId;
            query["Engine"] = request.Engine;
            query["ZoneId"] = request.ZoneId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["DBInstanceStatus"] = request.DBInstanceStatus;
            query["Expired"] = request.Expired;
            query["SearchKey"] = request.SearchKey;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBInstanceType"] = request.DBInstanceType;
            query["RegionId"] = request.RegionId;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["InstanceNetworkType"] = request.InstanceNetworkType;
            query["VpcId"] = request.VpcId;
            query["VSwitchId"] = request.VSwitchId;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["EngineVersion"] = request.EngineVersion;
            query["PayType"] = request.PayType;
            query["ConnectionMode"] = request.ConnectionMode;
            query["Tags"] = request.Tags;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["InstanceLevel"] = request.InstanceLevel;
            query["ConnectionString"] = request.ConnectionString;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstances",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDBInstancesResponse> DescribeDBInstancesWithOptionsAsync(DescribeDBInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["proxyId"] = request.ProxyId;
            query["Engine"] = request.Engine;
            query["ZoneId"] = request.ZoneId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["DBInstanceStatus"] = request.DBInstanceStatus;
            query["Expired"] = request.Expired;
            query["SearchKey"] = request.SearchKey;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBInstanceType"] = request.DBInstanceType;
            query["RegionId"] = request.RegionId;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["InstanceNetworkType"] = request.InstanceNetworkType;
            query["VpcId"] = request.VpcId;
            query["VSwitchId"] = request.VSwitchId;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["EngineVersion"] = request.EngineVersion;
            query["PayType"] = request.PayType;
            query["ConnectionMode"] = request.ConnectionMode;
            query["Tags"] = request.Tags;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["InstanceLevel"] = request.InstanceLevel;
            query["ConnectionString"] = request.ConnectionString;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstances",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDBInstancesResponse DescribeDBInstances(DescribeDBInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstancesResponse> DescribeDBInstancesAsync(DescribeDBInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstancesAsCsvResponse DescribeDBInstancesAsCsvWithOptions(DescribeDBInstancesAsCsvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstancesAsCsv",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstancesAsCsvResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDBInstancesAsCsvResponse> DescribeDBInstancesAsCsvWithOptionsAsync(DescribeDBInstancesAsCsvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstancesAsCsv",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstancesAsCsvResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDBInstancesAsCsvResponse DescribeDBInstancesAsCsv(DescribeDBInstancesAsCsvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstancesAsCsvWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstancesAsCsvResponse> DescribeDBInstancesAsCsvAsync(DescribeDBInstancesAsCsvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstancesAsCsvWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstancesByExpireTimeResponse DescribeDBInstancesByExpireTimeWithOptions(DescribeDBInstancesByExpireTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["proxyId"] = request.ProxyId;
            query["ExpirePeriod"] = request.ExpirePeriod;
            query["Expired"] = request.Expired;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["Tags"] = request.Tags;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstancesByExpireTime",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstancesByExpireTimeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDBInstancesByExpireTimeResponse> DescribeDBInstancesByExpireTimeWithOptionsAsync(DescribeDBInstancesByExpireTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["proxyId"] = request.ProxyId;
            query["ExpirePeriod"] = request.ExpirePeriod;
            query["Expired"] = request.Expired;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["Tags"] = request.Tags;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstancesByExpireTime",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstancesByExpireTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDBInstancesByExpireTimeResponse DescribeDBInstancesByExpireTime(DescribeDBInstancesByExpireTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstancesByExpireTimeWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstancesByExpireTimeResponse> DescribeDBInstancesByExpireTimeAsync(DescribeDBInstancesByExpireTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstancesByExpireTimeWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstancesByPerformanceResponse DescribeDBInstancesByPerformanceWithOptions(DescribeDBInstancesByPerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["proxyId"] = request.ProxyId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["SortMethod"] = request.SortMethod;
            query["SortKey"] = request.SortKey;
            query["Tags"] = request.Tags;
            query["OwnerAccount"] = request.OwnerAccount;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstancesByPerformance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstancesByPerformanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDBInstancesByPerformanceResponse> DescribeDBInstancesByPerformanceWithOptionsAsync(DescribeDBInstancesByPerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["proxyId"] = request.ProxyId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["SortMethod"] = request.SortMethod;
            query["SortKey"] = request.SortKey;
            query["Tags"] = request.Tags;
            query["OwnerAccount"] = request.OwnerAccount;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstancesByPerformance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstancesByPerformanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDBInstancesByPerformanceResponse DescribeDBInstancesByPerformance(DescribeDBInstancesByPerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstancesByPerformanceWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstancesByPerformanceResponse> DescribeDBInstancesByPerformanceAsync(DescribeDBInstancesByPerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstancesByPerformanceWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstancesForCloneResponse DescribeDBInstancesForCloneWithOptions(DescribeDBInstancesForCloneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["proxyId"] = request.ProxyId;
            query["Engine"] = request.Engine;
            query["ZoneId"] = request.ZoneId;
            query["DBInstanceStatus"] = request.DBInstanceStatus;
            query["Expired"] = request.Expired;
            query["SearchKey"] = request.SearchKey;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBInstanceType"] = request.DBInstanceType;
            query["RegionId"] = request.RegionId;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["InstanceNetworkType"] = request.InstanceNetworkType;
            query["VpcId"] = request.VpcId;
            query["VSwitchId"] = request.VSwitchId;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["EngineVersion"] = request.EngineVersion;
            query["NodeType"] = request.NodeType;
            query["PayType"] = request.PayType;
            query["ConnectionMode"] = request.ConnectionMode;
            query["OwnerAccount"] = request.OwnerAccount;
            query["CurrentInstanceId"] = request.CurrentInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstancesForClone",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstancesForCloneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDBInstancesForCloneResponse> DescribeDBInstancesForCloneWithOptionsAsync(DescribeDBInstancesForCloneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["proxyId"] = request.ProxyId;
            query["Engine"] = request.Engine;
            query["ZoneId"] = request.ZoneId;
            query["DBInstanceStatus"] = request.DBInstanceStatus;
            query["Expired"] = request.Expired;
            query["SearchKey"] = request.SearchKey;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBInstanceType"] = request.DBInstanceType;
            query["RegionId"] = request.RegionId;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["InstanceNetworkType"] = request.InstanceNetworkType;
            query["VpcId"] = request.VpcId;
            query["VSwitchId"] = request.VSwitchId;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["EngineVersion"] = request.EngineVersion;
            query["NodeType"] = request.NodeType;
            query["PayType"] = request.PayType;
            query["ConnectionMode"] = request.ConnectionMode;
            query["OwnerAccount"] = request.OwnerAccount;
            query["CurrentInstanceId"] = request.CurrentInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstancesForClone",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstancesForCloneResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDBInstancesForCloneResponse DescribeDBInstancesForClone(DescribeDBInstancesForCloneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstancesForCloneWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstancesForCloneResponse> DescribeDBInstancesForCloneAsync(DescribeDBInstancesForCloneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstancesForCloneWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceSSLResponse DescribeDBInstanceSSLWithOptions(DescribeDBInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceSSL",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceSSLResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDBInstanceSSLResponse> DescribeDBInstanceSSLWithOptionsAsync(DescribeDBInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceSSL",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceSSLResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDBInstanceSSLResponse DescribeDBInstanceSSL(DescribeDBInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceSSLWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceSSLResponse> DescribeDBInstanceSSLAsync(DescribeDBInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceSSLWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceStatusResponse DescribeDBInstanceStatusWithOptions(DescribeDBInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceStatus",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDBInstanceStatusResponse> DescribeDBInstanceStatusWithOptionsAsync(DescribeDBInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceStatus",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDBInstanceStatusResponse DescribeDBInstanceStatus(DescribeDBInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceStatusWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceStatusResponse> DescribeDBInstanceStatusAsync(DescribeDBInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceStatusWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceTDEResponse DescribeDBInstanceTDEWithOptions(DescribeDBInstanceTDERequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceTDE",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceTDEResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDBInstanceTDEResponse> DescribeDBInstanceTDEWithOptionsAsync(DescribeDBInstanceTDERequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceTDE",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceTDEResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDBInstanceTDEResponse DescribeDBInstanceTDE(DescribeDBInstanceTDERequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceTDEWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceTDEResponse> DescribeDBInstanceTDEAsync(DescribeDBInstanceTDERequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceTDEWithOptionsAsync(request, runtime);
        }

        public DescribeDBProxyResponse DescribeDBProxyWithOptions(DescribeDBProxyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBProxy",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBProxyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDBProxyResponse> DescribeDBProxyWithOptionsAsync(DescribeDBProxyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBProxy",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBProxyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDBProxyResponse DescribeDBProxy(DescribeDBProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBProxyWithOptions(request, runtime);
        }

        public async Task<DescribeDBProxyResponse> DescribeDBProxyAsync(DescribeDBProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBProxyWithOptionsAsync(request, runtime);
        }

        public DescribeDBProxyEndpointResponse DescribeDBProxyEndpointWithOptions(DescribeDBProxyEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBProxyEndpointId"] = request.DBProxyEndpointId;
            query["DBProxyConnectString"] = request.DBProxyConnectString;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBProxyEndpoint",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBProxyEndpointResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDBProxyEndpointResponse> DescribeDBProxyEndpointWithOptionsAsync(DescribeDBProxyEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBProxyEndpointId"] = request.DBProxyEndpointId;
            query["DBProxyConnectString"] = request.DBProxyConnectString;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBProxyEndpoint",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBProxyEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDBProxyEndpointResponse DescribeDBProxyEndpoint(DescribeDBProxyEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBProxyEndpointWithOptions(request, runtime);
        }

        public async Task<DescribeDBProxyEndpointResponse> DescribeDBProxyEndpointAsync(DescribeDBProxyEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBProxyEndpointWithOptionsAsync(request, runtime);
        }

        public DescribeDBProxyPerformanceResponse DescribeDBProxyPerformanceWithOptions(DescribeDBProxyPerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBProxyInstanceType"] = request.DBProxyInstanceType;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["RegionId"] = request.RegionId;
            query["MetricsName"] = request.MetricsName;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBProxyPerformance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBProxyPerformanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDBProxyPerformanceResponse> DescribeDBProxyPerformanceWithOptionsAsync(DescribeDBProxyPerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBProxyInstanceType"] = request.DBProxyInstanceType;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["RegionId"] = request.RegionId;
            query["MetricsName"] = request.MetricsName;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBProxyPerformance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBProxyPerformanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDBProxyPerformanceResponse DescribeDBProxyPerformance(DescribeDBProxyPerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBProxyPerformanceWithOptions(request, runtime);
        }

        public async Task<DescribeDBProxyPerformanceResponse> DescribeDBProxyPerformanceAsync(DescribeDBProxyPerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBProxyPerformanceWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostAttributeResponse DescribeDedicatedHostAttributeWithOptions(DescribeDedicatedHostAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDedicatedHostAttribute",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedHostAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDedicatedHostAttributeResponse> DescribeDedicatedHostAttributeWithOptionsAsync(DescribeDedicatedHostAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDedicatedHostAttribute",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedHostAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDedicatedHostAttributeResponse DescribeDedicatedHostAttribute(DescribeDedicatedHostAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostAttributeResponse> DescribeDedicatedHostAttributeAsync(DescribeDedicatedHostAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostGroupsResponse DescribeDedicatedHostGroupsWithOptions(DescribeDedicatedHostGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["ImageCategory"] = request.ImageCategory;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDedicatedHostGroups",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedHostGroupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDedicatedHostGroupsResponse> DescribeDedicatedHostGroupsWithOptionsAsync(DescribeDedicatedHostGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["ImageCategory"] = request.ImageCategory;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDedicatedHostGroups",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedHostGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDedicatedHostGroupsResponse DescribeDedicatedHostGroups(DescribeDedicatedHostGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostGroupsResponse> DescribeDedicatedHostGroupsAsync(DescribeDedicatedHostGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostImageCategoriesResponse DescribeDedicatedHostImageCategoriesWithOptions(DescribeDedicatedHostImageCategoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["HostGroup"] = request.HostGroup;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDedicatedHostImageCategories",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedHostImageCategoriesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDedicatedHostImageCategoriesResponse> DescribeDedicatedHostImageCategoriesWithOptionsAsync(DescribeDedicatedHostImageCategoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["HostGroup"] = request.HostGroup;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDedicatedHostImageCategories",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedHostImageCategoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDedicatedHostImageCategoriesResponse DescribeDedicatedHostImageCategories(DescribeDedicatedHostImageCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostImageCategoriesWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostImageCategoriesResponse> DescribeDedicatedHostImageCategoriesAsync(DescribeDedicatedHostImageCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostImageCategoriesWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostsResponse DescribeDedicatedHostsWithOptions(DescribeDedicatedHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["OrderId"] = request.OrderId;
            query["HostType"] = request.HostType;
            query["HostStatus"] = request.HostStatus;
            query["AllocationStatus"] = request.AllocationStatus;
            query["ZoneId"] = request.ZoneId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDedicatedHosts",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedHostsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDedicatedHostsResponse> DescribeDedicatedHostsWithOptionsAsync(DescribeDedicatedHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["OrderId"] = request.OrderId;
            query["HostType"] = request.HostType;
            query["HostStatus"] = request.HostStatus;
            query["AllocationStatus"] = request.AllocationStatus;
            query["ZoneId"] = request.ZoneId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDedicatedHosts",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedHostsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDedicatedHostsResponse DescribeDedicatedHosts(DescribeDedicatedHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostsWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostsResponse> DescribeDedicatedHostsAsync(DescribeDedicatedHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostsWithOptionsAsync(request, runtime);
        }

        public DescribeDetachedBackupsResponse DescribeDetachedBackupsWithOptions(DescribeDetachedBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["BackupId"] = request.BackupId;
            query["BackupStatus"] = request.BackupStatus;
            query["BackupMode"] = request.BackupMode;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["Region"] = request.Region;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDetachedBackups",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDetachedBackupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDetachedBackupsResponse> DescribeDetachedBackupsWithOptionsAsync(DescribeDetachedBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["BackupId"] = request.BackupId;
            query["BackupStatus"] = request.BackupStatus;
            query["BackupMode"] = request.BackupMode;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["Region"] = request.Region;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDetachedBackups",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDetachedBackupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDetachedBackupsResponse DescribeDetachedBackups(DescribeDetachedBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDetachedBackupsWithOptions(request, runtime);
        }

        public async Task<DescribeDetachedBackupsResponse> DescribeDetachedBackupsAsync(DescribeDetachedBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDetachedBackupsWithOptionsAsync(request, runtime);
        }

        public DescribeDiagnosticReportListResponse DescribeDiagnosticReportListWithOptions(DescribeDiagnosticReportListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiagnosticReportList",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiagnosticReportListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDiagnosticReportListResponse> DescribeDiagnosticReportListWithOptionsAsync(DescribeDiagnosticReportListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiagnosticReportList",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiagnosticReportListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDiagnosticReportListResponse DescribeDiagnosticReportList(DescribeDiagnosticReportListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDiagnosticReportListWithOptions(request, runtime);
        }

        public async Task<DescribeDiagnosticReportListResponse> DescribeDiagnosticReportListAsync(DescribeDiagnosticReportListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDiagnosticReportListWithOptionsAsync(request, runtime);
        }

        public DescribeDTCSecurityIpHostsForSQLServerResponse DescribeDTCSecurityIpHostsForSQLServerWithOptions(DescribeDTCSecurityIpHostsForSQLServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDTCSecurityIpHostsForSQLServer",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDTCSecurityIpHostsForSQLServerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDTCSecurityIpHostsForSQLServerResponse> DescribeDTCSecurityIpHostsForSQLServerWithOptionsAsync(DescribeDTCSecurityIpHostsForSQLServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDTCSecurityIpHostsForSQLServer",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDTCSecurityIpHostsForSQLServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDTCSecurityIpHostsForSQLServerResponse DescribeDTCSecurityIpHostsForSQLServer(DescribeDTCSecurityIpHostsForSQLServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDTCSecurityIpHostsForSQLServerWithOptions(request, runtime);
        }

        public async Task<DescribeDTCSecurityIpHostsForSQLServerResponse> DescribeDTCSecurityIpHostsForSQLServerAsync(DescribeDTCSecurityIpHostsForSQLServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDTCSecurityIpHostsForSQLServerWithOptionsAsync(request, runtime);
        }

        public DescribeErrorLogsResponse DescribeErrorLogsWithOptions(DescribeErrorLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeErrorLogs",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeErrorLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeErrorLogsResponse> DescribeErrorLogsWithOptionsAsync(DescribeErrorLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeErrorLogs",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeErrorLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeErrorLogsResponse DescribeErrorLogs(DescribeErrorLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeErrorLogsWithOptions(request, runtime);
        }

        public async Task<DescribeErrorLogsResponse> DescribeErrorLogsAsync(DescribeErrorLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeErrorLogsWithOptionsAsync(request, runtime);
        }

        public DescribeEventsResponse DescribeEventsWithOptions(DescribeEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEvents",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeEventsResponse> DescribeEventsWithOptionsAsync(DescribeEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEvents",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEventsWithOptions(request, runtime);
        }

        public async Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEventsWithOptionsAsync(request, runtime);
        }

        public DescribeHADiagnoseConfigResponse DescribeHADiagnoseConfigWithOptions(DescribeHADiagnoseConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHADiagnoseConfig",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHADiagnoseConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeHADiagnoseConfigResponse> DescribeHADiagnoseConfigWithOptionsAsync(DescribeHADiagnoseConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHADiagnoseConfig",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHADiagnoseConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeHADiagnoseConfigResponse DescribeHADiagnoseConfig(DescribeHADiagnoseConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHADiagnoseConfigWithOptions(request, runtime);
        }

        public async Task<DescribeHADiagnoseConfigResponse> DescribeHADiagnoseConfigAsync(DescribeHADiagnoseConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHADiagnoseConfigWithOptionsAsync(request, runtime);
        }

        public DescribeHASwitchConfigResponse DescribeHASwitchConfigWithOptions(DescribeHASwitchConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHASwitchConfig",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHASwitchConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeHASwitchConfigResponse> DescribeHASwitchConfigWithOptionsAsync(DescribeHASwitchConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHASwitchConfig",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHASwitchConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeHASwitchConfigResponse DescribeHASwitchConfig(DescribeHASwitchConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHASwitchConfigWithOptions(request, runtime);
        }

        public async Task<DescribeHASwitchConfigResponse> DescribeHASwitchConfigAsync(DescribeHASwitchConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHASwitchConfigWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceAutoRenewalAttributeResponse DescribeInstanceAutoRenewalAttributeWithOptions(DescribeInstanceAutoRenewalAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["proxyId"] = request.ProxyId;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceAutoRenewalAttribute",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceAutoRenewalAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeInstanceAutoRenewalAttributeResponse> DescribeInstanceAutoRenewalAttributeWithOptionsAsync(DescribeInstanceAutoRenewalAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["proxyId"] = request.ProxyId;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceAutoRenewalAttribute",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceAutoRenewalAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeInstanceAutoRenewalAttributeResponse DescribeInstanceAutoRenewalAttribute(DescribeInstanceAutoRenewalAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceAutoRenewalAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceAutoRenewalAttributeResponse> DescribeInstanceAutoRenewalAttributeAsync(DescribeInstanceAutoRenewalAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceAutoRenewalAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceCrossBackupPolicyResponse DescribeInstanceCrossBackupPolicyWithOptions(DescribeInstanceCrossBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceCrossBackupPolicy",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceCrossBackupPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeInstanceCrossBackupPolicyResponse> DescribeInstanceCrossBackupPolicyWithOptionsAsync(DescribeInstanceCrossBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceCrossBackupPolicy",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceCrossBackupPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeInstanceCrossBackupPolicyResponse DescribeInstanceCrossBackupPolicy(DescribeInstanceCrossBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceCrossBackupPolicyWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceCrossBackupPolicyResponse> DescribeInstanceCrossBackupPolicyAsync(DescribeInstanceCrossBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceCrossBackupPolicyWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceKeywordsResponse DescribeInstanceKeywordsWithOptions(DescribeInstanceKeywordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Key"] = request.Key;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceKeywords",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceKeywordsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeInstanceKeywordsResponse> DescribeInstanceKeywordsWithOptionsAsync(DescribeInstanceKeywordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Key"] = request.Key;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceKeywords",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceKeywordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeInstanceKeywordsResponse DescribeInstanceKeywords(DescribeInstanceKeywordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceKeywordsWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceKeywordsResponse> DescribeInstanceKeywordsAsync(DescribeInstanceKeywordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceKeywordsWithOptionsAsync(request, runtime);
        }

        public DescribeLocalAvailableRecoveryTimeResponse DescribeLocalAvailableRecoveryTimeWithOptions(DescribeLocalAvailableRecoveryTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Region"] = request.Region;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLocalAvailableRecoveryTime",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLocalAvailableRecoveryTimeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeLocalAvailableRecoveryTimeResponse> DescribeLocalAvailableRecoveryTimeWithOptionsAsync(DescribeLocalAvailableRecoveryTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Region"] = request.Region;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLocalAvailableRecoveryTime",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLocalAvailableRecoveryTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeLocalAvailableRecoveryTimeResponse DescribeLocalAvailableRecoveryTime(DescribeLocalAvailableRecoveryTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLocalAvailableRecoveryTimeWithOptions(request, runtime);
        }

        public async Task<DescribeLocalAvailableRecoveryTimeResponse> DescribeLocalAvailableRecoveryTimeAsync(DescribeLocalAvailableRecoveryTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLocalAvailableRecoveryTimeWithOptionsAsync(request, runtime);
        }

        public DescribeLogBackupFilesResponse DescribeLogBackupFilesWithOptions(DescribeLogBackupFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogBackupFiles",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogBackupFilesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeLogBackupFilesResponse> DescribeLogBackupFilesWithOptionsAsync(DescribeLogBackupFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogBackupFiles",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogBackupFilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeLogBackupFilesResponse DescribeLogBackupFiles(DescribeLogBackupFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLogBackupFilesWithOptions(request, runtime);
        }

        public async Task<DescribeLogBackupFilesResponse> DescribeLogBackupFilesAsync(DescribeLogBackupFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLogBackupFilesWithOptionsAsync(request, runtime);
        }

        public DescribeMetaListResponse DescribeMetaListWithOptions(DescribeMetaListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RestoreType"] = request.RestoreType;
            query["BackupSetID"] = request.BackupSetID;
            query["RestoreTime"] = request.RestoreTime;
            query["GetDbName"] = request.GetDbName;
            query["Pattern"] = request.Pattern;
            query["PageSize"] = request.PageSize;
            query["PageIndex"] = request.PageIndex;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMetaList",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetaListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMetaListResponse> DescribeMetaListWithOptionsAsync(DescribeMetaListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RestoreType"] = request.RestoreType;
            query["BackupSetID"] = request.BackupSetID;
            query["RestoreTime"] = request.RestoreTime;
            query["GetDbName"] = request.GetDbName;
            query["Pattern"] = request.Pattern;
            query["PageSize"] = request.PageSize;
            query["PageIndex"] = request.PageIndex;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMetaList",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetaListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMetaListResponse DescribeMetaList(DescribeMetaListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetaListWithOptions(request, runtime);
        }

        public async Task<DescribeMetaListResponse> DescribeMetaListAsync(DescribeMetaListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetaListWithOptionsAsync(request, runtime);
        }

        public DescribeMigrateTaskByIdResponse DescribeMigrateTaskByIdWithOptions(DescribeMigrateTaskByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["MigrateTaskId"] = request.MigrateTaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMigrateTaskById",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMigrateTaskByIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMigrateTaskByIdResponse> DescribeMigrateTaskByIdWithOptionsAsync(DescribeMigrateTaskByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["MigrateTaskId"] = request.MigrateTaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMigrateTaskById",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMigrateTaskByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMigrateTaskByIdResponse DescribeMigrateTaskById(DescribeMigrateTaskByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMigrateTaskByIdWithOptions(request, runtime);
        }

        public async Task<DescribeMigrateTaskByIdResponse> DescribeMigrateTaskByIdAsync(DescribeMigrateTaskByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMigrateTaskByIdWithOptionsAsync(request, runtime);
        }

        public DescribeMigrateTasksResponse DescribeMigrateTasksWithOptions(DescribeMigrateTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMigrateTasks",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMigrateTasksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMigrateTasksResponse> DescribeMigrateTasksWithOptionsAsync(DescribeMigrateTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMigrateTasks",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMigrateTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMigrateTasksResponse DescribeMigrateTasks(DescribeMigrateTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMigrateTasksWithOptions(request, runtime);
        }

        public async Task<DescribeMigrateTasksResponse> DescribeMigrateTasksAsync(DescribeMigrateTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMigrateTasksWithOptionsAsync(request, runtime);
        }

        public DescribeMigrateTasksForSQLServerResponse DescribeMigrateTasksForSQLServerWithOptions(DescribeMigrateTasksForSQLServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMigrateTasksForSQLServer",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMigrateTasksForSQLServerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMigrateTasksForSQLServerResponse> DescribeMigrateTasksForSQLServerWithOptionsAsync(DescribeMigrateTasksForSQLServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMigrateTasksForSQLServer",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMigrateTasksForSQLServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMigrateTasksForSQLServerResponse DescribeMigrateTasksForSQLServer(DescribeMigrateTasksForSQLServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMigrateTasksForSQLServerWithOptions(request, runtime);
        }

        public async Task<DescribeMigrateTasksForSQLServerResponse> DescribeMigrateTasksForSQLServerAsync(DescribeMigrateTasksForSQLServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMigrateTasksForSQLServerWithOptionsAsync(request, runtime);
        }

        public DescribeModifyParameterLogResponse DescribeModifyParameterLogWithOptions(DescribeModifyParameterLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeModifyParameterLog",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeModifyParameterLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeModifyParameterLogResponse> DescribeModifyParameterLogWithOptionsAsync(DescribeModifyParameterLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeModifyParameterLog",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeModifyParameterLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeModifyParameterLogResponse DescribeModifyParameterLog(DescribeModifyParameterLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeModifyParameterLogWithOptions(request, runtime);
        }

        public async Task<DescribeModifyParameterLogResponse> DescribeModifyParameterLogAsync(DescribeModifyParameterLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeModifyParameterLogWithOptionsAsync(request, runtime);
        }

        public DescribeOssDownloadsResponse DescribeOssDownloadsWithOptions(DescribeOssDownloadsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["MigrateTaskId"] = request.MigrateTaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOssDownloads",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOssDownloadsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeOssDownloadsResponse> DescribeOssDownloadsWithOptionsAsync(DescribeOssDownloadsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["MigrateTaskId"] = request.MigrateTaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOssDownloads",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOssDownloadsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeOssDownloadsResponse DescribeOssDownloads(DescribeOssDownloadsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOssDownloadsWithOptions(request, runtime);
        }

        public async Task<DescribeOssDownloadsResponse> DescribeOssDownloadsAsync(DescribeOssDownloadsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOssDownloadsWithOptionsAsync(request, runtime);
        }

        public DescribeOssDownloadsForSQLServerResponse DescribeOssDownloadsForSQLServerWithOptions(DescribeOssDownloadsForSQLServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["MigrateTaskId"] = request.MigrateTaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOssDownloadsForSQLServer",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOssDownloadsForSQLServerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeOssDownloadsForSQLServerResponse> DescribeOssDownloadsForSQLServerWithOptionsAsync(DescribeOssDownloadsForSQLServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["MigrateTaskId"] = request.MigrateTaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOssDownloadsForSQLServer",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOssDownloadsForSQLServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeOssDownloadsForSQLServerResponse DescribeOssDownloadsForSQLServer(DescribeOssDownloadsForSQLServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOssDownloadsForSQLServerWithOptions(request, runtime);
        }

        public async Task<DescribeOssDownloadsForSQLServerResponse> DescribeOssDownloadsForSQLServerAsync(DescribeOssDownloadsForSQLServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOssDownloadsForSQLServerWithOptionsAsync(request, runtime);
        }

        public DescribeParameterGroupResponse DescribeParameterGroupWithOptions(DescribeParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ParameterGroupId"] = request.ParameterGroupId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeParameterGroup",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeParameterGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeParameterGroupResponse> DescribeParameterGroupWithOptionsAsync(DescribeParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ParameterGroupId"] = request.ParameterGroupId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeParameterGroup",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeParameterGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeParameterGroupResponse DescribeParameterGroup(DescribeParameterGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeParameterGroupWithOptions(request, runtime);
        }

        public async Task<DescribeParameterGroupResponse> DescribeParameterGroupAsync(DescribeParameterGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeParameterGroupWithOptionsAsync(request, runtime);
        }

        public DescribeParameterGroupsResponse DescribeParameterGroupsWithOptions(DescribeParameterGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeParameterGroups",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeParameterGroupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeParameterGroupsResponse> DescribeParameterGroupsWithOptionsAsync(DescribeParameterGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeParameterGroups",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeParameterGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeParameterGroupsResponse DescribeParameterGroups(DescribeParameterGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeParameterGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeParameterGroupsResponse> DescribeParameterGroupsAsync(DescribeParameterGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeParameterGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeParametersResponse DescribeParametersWithOptions(DescribeParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeParameters",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeParametersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeParametersResponse> DescribeParametersWithOptionsAsync(DescribeParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeParameters",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeParametersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeParametersResponse DescribeParameters(DescribeParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeParametersWithOptions(request, runtime);
        }

        public async Task<DescribeParametersResponse> DescribeParametersAsync(DescribeParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeParametersWithOptionsAsync(request, runtime);
        }

        public DescribeParameterTemplatesResponse DescribeParameterTemplatesWithOptions(DescribeParameterTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["Engine"] = request.Engine;
            query["EngineVersion"] = request.EngineVersion;
            query["OwnerAccount"] = request.OwnerAccount;
            query["Category"] = request.Category;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeParameterTemplates",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeParameterTemplatesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeParameterTemplatesResponse> DescribeParameterTemplatesWithOptionsAsync(DescribeParameterTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["Engine"] = request.Engine;
            query["EngineVersion"] = request.EngineVersion;
            query["OwnerAccount"] = request.OwnerAccount;
            query["Category"] = request.Category;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeParameterTemplates",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeParameterTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeParameterTemplatesResponse DescribeParameterTemplates(DescribeParameterTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeParameterTemplatesWithOptions(request, runtime);
        }

        public async Task<DescribeParameterTemplatesResponse> DescribeParameterTemplatesAsync(DescribeParameterTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeParameterTemplatesWithOptionsAsync(request, runtime);
        }

        public DescribePriceResponse DescribePriceWithOptions(DescribePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["CommodityCode"] = request.CommodityCode;
            query["RegionId"] = request.RegionId;
            query["Engine"] = request.Engine;
            query["EngineVersion"] = request.EngineVersion;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["DBInstanceStorage"] = request.DBInstanceStorage;
            query["PayType"] = request.PayType;
            query["ZoneId"] = request.ZoneId;
            query["UsedTime"] = request.UsedTime;
            query["TimeType"] = request.TimeType;
            query["Quantity"] = request.Quantity;
            query["InstanceUsedType"] = request.InstanceUsedType;
            query["OrderType"] = request.OrderType;
            query["DBInstanceStorageType"] = request.DBInstanceStorageType;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePrice",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePriceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribePriceResponse> DescribePriceWithOptionsAsync(DescribePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["CommodityCode"] = request.CommodityCode;
            query["RegionId"] = request.RegionId;
            query["Engine"] = request.Engine;
            query["EngineVersion"] = request.EngineVersion;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["DBInstanceStorage"] = request.DBInstanceStorage;
            query["PayType"] = request.PayType;
            query["ZoneId"] = request.ZoneId;
            query["UsedTime"] = request.UsedTime;
            query["TimeType"] = request.TimeType;
            query["Quantity"] = request.Quantity;
            query["InstanceUsedType"] = request.InstanceUsedType;
            query["OrderType"] = request.OrderType;
            query["DBInstanceStorageType"] = request.DBInstanceStorageType;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePrice",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribePriceResponse DescribePrice(DescribePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePriceWithOptions(request, runtime);
        }

        public async Task<DescribePriceResponse> DescribePriceAsync(DescribePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePriceWithOptionsAsync(request, runtime);
        }

        public DescribeRdsResourceSettingsResponse DescribeRdsResourceSettingsWithOptions(DescribeRdsResourceSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceNiche"] = request.ResourceNiche;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRdsResourceSettings",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRdsResourceSettingsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRdsResourceSettingsResponse> DescribeRdsResourceSettingsWithOptionsAsync(DescribeRdsResourceSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceNiche"] = request.ResourceNiche;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRdsResourceSettings",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRdsResourceSettingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRdsResourceSettingsResponse DescribeRdsResourceSettings(DescribeRdsResourceSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRdsResourceSettingsWithOptions(request, runtime);
        }

        public async Task<DescribeRdsResourceSettingsResponse> DescribeRdsResourceSettingsAsync(DescribeRdsResourceSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRdsResourceSettingsWithOptionsAsync(request, runtime);
        }

        public DescribeReadDBInstanceDelayResponse DescribeReadDBInstanceDelayWithOptions(DescribeReadDBInstanceDelayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ReadInstanceId"] = request.ReadInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeReadDBInstanceDelay",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeReadDBInstanceDelayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeReadDBInstanceDelayResponse> DescribeReadDBInstanceDelayWithOptionsAsync(DescribeReadDBInstanceDelayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ReadInstanceId"] = request.ReadInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeReadDBInstanceDelay",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeReadDBInstanceDelayResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeReadDBInstanceDelayResponse DescribeReadDBInstanceDelay(DescribeReadDBInstanceDelayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeReadDBInstanceDelayWithOptions(request, runtime);
        }

        public async Task<DescribeReadDBInstanceDelayResponse> DescribeReadDBInstanceDelayAsync(DescribeReadDBInstanceDelayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeReadDBInstanceDelayWithOptionsAsync(request, runtime);
        }

        public DescribeRegionInfosResponse DescribeRegionInfosWithOptions(DescribeRegionInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["RegionId"] = request.RegionId;
            query["InstanceUsedType"] = request.InstanceUsedType;
            query["SpecifyCount"] = request.SpecifyCount;
            query["HostType"] = request.HostType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegionInfos",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionInfosResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRegionInfosResponse> DescribeRegionInfosWithOptionsAsync(DescribeRegionInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["RegionId"] = request.RegionId;
            query["InstanceUsedType"] = request.InstanceUsedType;
            query["SpecifyCount"] = request.SpecifyCount;
            query["HostType"] = request.HostType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegionInfos",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRegionInfosResponse DescribeRegionInfos(DescribeRegionInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionInfosWithOptions(request, runtime);
        }

        public async Task<DescribeRegionInfosResponse> DescribeRegionInfosAsync(DescribeRegionInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionInfosWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
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

        public DescribeRenewalPriceResponse DescribeRenewalPriceWithOptions(DescribeRenewalPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            query["PayType"] = request.PayType;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["UsedTime"] = request.UsedTime;
            query["TimeType"] = request.TimeType;
            query["Quantity"] = request.Quantity;
            query["OrderType"] = request.OrderType;
            query["BusinessInfo"] = request.BusinessInfo;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRenewalPrice",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRenewalPriceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRenewalPriceResponse> DescribeRenewalPriceWithOptionsAsync(DescribeRenewalPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            query["PayType"] = request.PayType;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["UsedTime"] = request.UsedTime;
            query["TimeType"] = request.TimeType;
            query["Quantity"] = request.Quantity;
            query["OrderType"] = request.OrderType;
            query["BusinessInfo"] = request.BusinessInfo;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRenewalPrice",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRenewalPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRenewalPriceResponse DescribeRenewalPrice(DescribeRenewalPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRenewalPriceWithOptions(request, runtime);
        }

        public async Task<DescribeRenewalPriceResponse> DescribeRenewalPriceAsync(DescribeRenewalPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRenewalPriceWithOptionsAsync(request, runtime);
        }

        public DescribeResourceUsageResponse DescribeResourceUsageWithOptions(DescribeResourceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceUsage",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceUsageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeResourceUsageResponse> DescribeResourceUsageWithOptionsAsync(DescribeResourceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceUsage",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeResourceUsageResponse DescribeResourceUsage(DescribeResourceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourceUsageWithOptions(request, runtime);
        }

        public async Task<DescribeResourceUsageResponse> DescribeResourceUsageAsync(DescribeResourceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourceUsageWithOptionsAsync(request, runtime);
        }

        public DescribeSecurityGroupConfigurationResponse DescribeSecurityGroupConfigurationWithOptions(DescribeSecurityGroupConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecurityGroupConfiguration",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecurityGroupConfigurationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSecurityGroupConfigurationResponse> DescribeSecurityGroupConfigurationWithOptionsAsync(DescribeSecurityGroupConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecurityGroupConfiguration",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecurityGroupConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSecurityGroupConfigurationResponse DescribeSecurityGroupConfiguration(DescribeSecurityGroupConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityGroupConfigurationWithOptions(request, runtime);
        }

        public async Task<DescribeSecurityGroupConfigurationResponse> DescribeSecurityGroupConfigurationAsync(DescribeSecurityGroupConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityGroupConfigurationWithOptionsAsync(request, runtime);
        }

        public DescribeSlowLogRecordsResponse DescribeSlowLogRecordsWithOptions(DescribeSlowLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["SQLHASH"] = request.SQLHASH;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["DBName"] = request.DBName;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlowLogRecords",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlowLogRecordsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSlowLogRecordsResponse> DescribeSlowLogRecordsWithOptionsAsync(DescribeSlowLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["SQLHASH"] = request.SQLHASH;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["DBName"] = request.DBName;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlowLogRecords",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlowLogRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSlowLogRecordsResponse DescribeSlowLogRecords(DescribeSlowLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSlowLogRecordsWithOptions(request, runtime);
        }

        public async Task<DescribeSlowLogRecordsResponse> DescribeSlowLogRecordsAsync(DescribeSlowLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSlowLogRecordsWithOptionsAsync(request, runtime);
        }

        public DescribeSlowLogsResponse DescribeSlowLogsWithOptions(DescribeSlowLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["DBName"] = request.DBName;
            query["SortKey"] = request.SortKey;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlowLogs",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlowLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSlowLogsResponse> DescribeSlowLogsWithOptionsAsync(DescribeSlowLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["DBName"] = request.DBName;
            query["SortKey"] = request.SortKey;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlowLogs",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlowLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSlowLogsResponse DescribeSlowLogs(DescribeSlowLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSlowLogsWithOptions(request, runtime);
        }

        public async Task<DescribeSlowLogsResponse> DescribeSlowLogsAsync(DescribeSlowLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSlowLogsWithOptionsAsync(request, runtime);
        }

        public DescribeSQLCollectorPolicyResponse DescribeSQLCollectorPolicyWithOptions(DescribeSQLCollectorPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSQLCollectorPolicy",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLCollectorPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSQLCollectorPolicyResponse> DescribeSQLCollectorPolicyWithOptionsAsync(DescribeSQLCollectorPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSQLCollectorPolicy",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLCollectorPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSQLCollectorPolicyResponse DescribeSQLCollectorPolicy(DescribeSQLCollectorPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSQLCollectorPolicyWithOptions(request, runtime);
        }

        public async Task<DescribeSQLCollectorPolicyResponse> DescribeSQLCollectorPolicyAsync(DescribeSQLCollectorPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSQLCollectorPolicyWithOptionsAsync(request, runtime);
        }

        public DescribeSQLCollectorRetentionResponse DescribeSQLCollectorRetentionWithOptions(DescribeSQLCollectorRetentionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSQLCollectorRetention",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLCollectorRetentionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSQLCollectorRetentionResponse> DescribeSQLCollectorRetentionWithOptionsAsync(DescribeSQLCollectorRetentionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSQLCollectorRetention",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLCollectorRetentionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSQLCollectorRetentionResponse DescribeSQLCollectorRetention(DescribeSQLCollectorRetentionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSQLCollectorRetentionWithOptions(request, runtime);
        }

        public async Task<DescribeSQLCollectorRetentionResponse> DescribeSQLCollectorRetentionAsync(DescribeSQLCollectorRetentionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSQLCollectorRetentionWithOptionsAsync(request, runtime);
        }

        public DescribeSQLLogFilesResponse DescribeSQLLogFilesWithOptions(DescribeSQLLogFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["FileName"] = request.FileName;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSQLLogFiles",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLLogFilesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSQLLogFilesResponse> DescribeSQLLogFilesWithOptionsAsync(DescribeSQLLogFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["FileName"] = request.FileName;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSQLLogFiles",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLLogFilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSQLLogFilesResponse DescribeSQLLogFiles(DescribeSQLLogFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSQLLogFilesWithOptions(request, runtime);
        }

        public async Task<DescribeSQLLogFilesResponse> DescribeSQLLogFilesAsync(DescribeSQLLogFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSQLLogFilesWithOptionsAsync(request, runtime);
        }

        public DescribeSQLLogRecordsResponse DescribeSQLLogRecordsWithOptions(DescribeSQLLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["SQLId"] = request.SQLId;
            query["QueryKeywords"] = request.QueryKeywords;
            query["StartTime"] = request.StartTime;
            query["Database"] = request.Database;
            query["User"] = request.User;
            query["Form"] = request.Form;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSQLLogRecords",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLLogRecordsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSQLLogRecordsResponse> DescribeSQLLogRecordsWithOptionsAsync(DescribeSQLLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["SQLId"] = request.SQLId;
            query["QueryKeywords"] = request.QueryKeywords;
            query["StartTime"] = request.StartTime;
            query["Database"] = request.Database;
            query["User"] = request.User;
            query["Form"] = request.Form;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSQLLogRecords",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLLogRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSQLLogRecordsResponse DescribeSQLLogRecords(DescribeSQLLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSQLLogRecordsWithOptions(request, runtime);
        }

        public async Task<DescribeSQLLogRecordsResponse> DescribeSQLLogRecordsAsync(DescribeSQLLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSQLLogRecordsWithOptionsAsync(request, runtime);
        }

        public DescribeSQLLogReportListResponse DescribeSQLLogReportListWithOptions(DescribeSQLLogReportListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSQLLogReportList",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLLogReportListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSQLLogReportListResponse> DescribeSQLLogReportListWithOptionsAsync(DescribeSQLLogReportListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSQLLogReportList",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLLogReportListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSQLLogReportListResponse DescribeSQLLogReportList(DescribeSQLLogReportListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSQLLogReportListWithOptions(request, runtime);
        }

        public async Task<DescribeSQLLogReportListResponse> DescribeSQLLogReportListAsync(DescribeSQLLogReportListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSQLLogReportListWithOptionsAsync(request, runtime);
        }

        public DescribeSQLLogReportsResponse DescribeSQLLogReportsWithOptions(DescribeSQLLogReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSQLLogReports",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLLogReportsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSQLLogReportsResponse> DescribeSQLLogReportsWithOptionsAsync(DescribeSQLLogReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSQLLogReports",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLLogReportsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSQLLogReportsResponse DescribeSQLLogReports(DescribeSQLLogReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSQLLogReportsWithOptions(request, runtime);
        }

        public async Task<DescribeSQLLogReportsResponse> DescribeSQLLogReportsAsync(DescribeSQLLogReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSQLLogReportsWithOptionsAsync(request, runtime);
        }

        public DescribeTagsResponse DescribeTagsWithOptions(DescribeTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["proxyId"] = request.ProxyId;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Tags"] = request.Tags;
            query["OwnerAccount"] = request.OwnerAccount;
            query["ResourceType"] = request.ResourceType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTags",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTagsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeTagsResponse> DescribeTagsWithOptionsAsync(DescribeTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["proxyId"] = request.ProxyId;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Tags"] = request.Tags;
            query["OwnerAccount"] = request.OwnerAccount;
            query["ResourceType"] = request.ResourceType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTags",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTagsWithOptions(request, runtime);
        }

        public async Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTagsWithOptionsAsync(request, runtime);
        }

        public DescribeTasksResponse DescribeTasksWithOptions(DescribeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["Status"] = request.Status;
            query["TaskAction"] = request.TaskAction;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTasks",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTasksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeTasksResponse> DescribeTasksWithOptionsAsync(DescribeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["StartTime"] = request.StartTime;
            query["EndTime"] = request.EndTime;
            query["PageSize"] = request.PageSize;
            query["PageNumber"] = request.PageNumber;
            query["Status"] = request.Status;
            query["TaskAction"] = request.TaskAction;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTasks",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeTasksResponse DescribeTasks(DescribeTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTasksWithOptions(request, runtime);
        }

        public async Task<DescribeTasksResponse> DescribeTasksAsync(DescribeTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTasksWithOptionsAsync(request, runtime);
        }

        public DestroyDBInstanceResponse DestroyDBInstanceWithOptions(DestroyDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DestroyDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DestroyDBInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DestroyDBInstanceResponse> DestroyDBInstanceWithOptionsAsync(DestroyDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DestroyDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DestroyDBInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DestroyDBInstanceResponse DestroyDBInstance(DestroyDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DestroyDBInstanceWithOptions(request, runtime);
        }

        public async Task<DestroyDBInstanceResponse> DestroyDBInstanceAsync(DestroyDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DestroyDBInstanceWithOptionsAsync(request, runtime);
        }

        public DropDedicatedHostUserResponse DropDedicatedHostUserWithOptions(DropDedicatedHostUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DedicatedHostName"] = request.DedicatedHostName;
            query["UserName"] = request.UserName;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DropDedicatedHostUser",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DropDedicatedHostUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DropDedicatedHostUserResponse> DropDedicatedHostUserWithOptionsAsync(DropDedicatedHostUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DedicatedHostName"] = request.DedicatedHostName;
            query["UserName"] = request.UserName;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DropDedicatedHostUser",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DropDedicatedHostUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DropDedicatedHostUserResponse DropDedicatedHostUser(DropDedicatedHostUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DropDedicatedHostUserWithOptions(request, runtime);
        }

        public async Task<DropDedicatedHostUserResponse> DropDedicatedHostUserAsync(DropDedicatedHostUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DropDedicatedHostUserWithOptionsAsync(request, runtime);
        }

        public EvaluateDedicatedHostInstanceResourceResponse EvaluateDedicatedHostInstanceResourceWithOptions(EvaluateDedicatedHostInstanceResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["DiskType"] = request.DiskType;
            query["DiskSize"] = request.DiskSize;
            query["InstanceClassNames"] = request.InstanceClassNames;
            query["Engine"] = request.Engine;
            query["EngineVersion"] = request.EngineVersion;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EvaluateDedicatedHostInstanceResource",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EvaluateDedicatedHostInstanceResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EvaluateDedicatedHostInstanceResourceResponse> EvaluateDedicatedHostInstanceResourceWithOptionsAsync(EvaluateDedicatedHostInstanceResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["DiskType"] = request.DiskType;
            query["DiskSize"] = request.DiskSize;
            query["InstanceClassNames"] = request.InstanceClassNames;
            query["Engine"] = request.Engine;
            query["EngineVersion"] = request.EngineVersion;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EvaluateDedicatedHostInstanceResource",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EvaluateDedicatedHostInstanceResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EvaluateDedicatedHostInstanceResourceResponse EvaluateDedicatedHostInstanceResource(EvaluateDedicatedHostInstanceResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EvaluateDedicatedHostInstanceResourceWithOptions(request, runtime);
        }

        public async Task<EvaluateDedicatedHostInstanceResourceResponse> EvaluateDedicatedHostInstanceResourceAsync(EvaluateDedicatedHostInstanceResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EvaluateDedicatedHostInstanceResourceWithOptionsAsync(request, runtime);
        }

        public GetDbProxyInstanceSslResponse GetDbProxyInstanceSslWithOptions(GetDbProxyInstanceSslRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["DbInstanceId"] = request.DbInstanceId;
            query["DbInstanceId"] = request.DbInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDbProxyInstanceSsl",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDbProxyInstanceSslResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDbProxyInstanceSslResponse> GetDbProxyInstanceSslWithOptionsAsync(GetDbProxyInstanceSslRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["DbInstanceId"] = request.DbInstanceId;
            query["DbInstanceId"] = request.DbInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDbProxyInstanceSsl",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDbProxyInstanceSslResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDbProxyInstanceSslResponse GetDbProxyInstanceSsl(GetDbProxyInstanceSslRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDbProxyInstanceSslWithOptions(request, runtime);
        }

        public async Task<GetDbProxyInstanceSslResponse> GetDbProxyInstanceSslAsync(GetDbProxyInstanceSslRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDbProxyInstanceSslWithOptionsAsync(request, runtime);
        }

        public GrantAccountPrivilegeResponse GrantAccountPrivilegeWithOptions(GrantAccountPrivilegeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AccountName"] = request.AccountName;
            query["DBName"] = request.DBName;
            query["AccountPrivilege"] = request.AccountPrivilege;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantAccountPrivilege",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantAccountPrivilegeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GrantAccountPrivilegeResponse> GrantAccountPrivilegeWithOptionsAsync(GrantAccountPrivilegeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AccountName"] = request.AccountName;
            query["DBName"] = request.DBName;
            query["AccountPrivilege"] = request.AccountPrivilege;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantAccountPrivilege",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantAccountPrivilegeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GrantAccountPrivilegeResponse GrantAccountPrivilege(GrantAccountPrivilegeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantAccountPrivilegeWithOptions(request, runtime);
        }

        public async Task<GrantAccountPrivilegeResponse> GrantAccountPrivilegeAsync(GrantAccountPrivilegeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantAccountPrivilegeWithOptionsAsync(request, runtime);
        }

        public GrantOperatorPermissionResponse GrantOperatorPermissionWithOptions(GrantOperatorPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ExpiredTime"] = request.ExpiredTime;
            query["Privileges"] = request.Privileges;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantOperatorPermission",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantOperatorPermissionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GrantOperatorPermissionResponse> GrantOperatorPermissionWithOptionsAsync(GrantOperatorPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ExpiredTime"] = request.ExpiredTime;
            query["Privileges"] = request.Privileges;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantOperatorPermission",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantOperatorPermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GrantOperatorPermissionResponse GrantOperatorPermission(GrantOperatorPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantOperatorPermissionWithOptions(request, runtime);
        }

        public async Task<GrantOperatorPermissionResponse> GrantOperatorPermissionAsync(GrantOperatorPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantOperatorPermissionWithOptionsAsync(request, runtime);
        }

        public ImportDatabaseBetweenInstancesResponse ImportDatabaseBetweenInstancesWithOptions(ImportDatabaseBetweenInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["SourceDBInstanceId"] = request.SourceDBInstanceId;
            query["DBInfo"] = request.DBInfo;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportDatabaseBetweenInstances",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportDatabaseBetweenInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ImportDatabaseBetweenInstancesResponse> ImportDatabaseBetweenInstancesWithOptionsAsync(ImportDatabaseBetweenInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["SourceDBInstanceId"] = request.SourceDBInstanceId;
            query["DBInfo"] = request.DBInfo;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportDatabaseBetweenInstances",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportDatabaseBetweenInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ImportDatabaseBetweenInstancesResponse ImportDatabaseBetweenInstances(ImportDatabaseBetweenInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportDatabaseBetweenInstancesWithOptions(request, runtime);
        }

        public async Task<ImportDatabaseBetweenInstancesResponse> ImportDatabaseBetweenInstancesAsync(ImportDatabaseBetweenInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportDatabaseBetweenInstancesWithOptionsAsync(request, runtime);
        }

        public ImportUserBackupFileResponse ImportUserBackupFileWithOptions(ImportUserBackupFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["EngineVersion"] = request.EngineVersion;
            query["BucketRegion"] = request.BucketRegion;
            query["BackupFile"] = request.BackupFile;
            query["Comment"] = request.Comment;
            query["RestoreSize"] = request.RestoreSize;
            query["Retention"] = request.Retention;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportUserBackupFile",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportUserBackupFileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ImportUserBackupFileResponse> ImportUserBackupFileWithOptionsAsync(ImportUserBackupFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["EngineVersion"] = request.EngineVersion;
            query["BucketRegion"] = request.BucketRegion;
            query["BackupFile"] = request.BackupFile;
            query["Comment"] = request.Comment;
            query["RestoreSize"] = request.RestoreSize;
            query["Retention"] = request.Retention;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportUserBackupFile",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportUserBackupFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ImportUserBackupFileResponse ImportUserBackupFile(ImportUserBackupFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportUserBackupFileWithOptions(request, runtime);
        }

        public async Task<ImportUserBackupFileResponse> ImportUserBackupFileAsync(ImportUserBackupFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportUserBackupFileWithOptionsAsync(request, runtime);
        }

        public ListClassesResponse ListClassesWithOptions(ListClassesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["CommodityCode"] = request.CommodityCode;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OrderType"] = request.OrderType;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClasses",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClassesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListClassesResponse> ListClassesWithOptionsAsync(ListClassesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["CommodityCode"] = request.CommodityCode;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OrderType"] = request.OrderType;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClasses",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClassesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListClassesResponse ListClasses(ListClassesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClassesWithOptions(request, runtime);
        }

        public async Task<ListClassesResponse> ListClassesAsync(ListClassesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClassesWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceType"] = request.ResourceType;
            query["NextToken"] = request.NextToken;
            query["ResourceId"] = request.ResourceId;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2014-08-15",
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
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceType"] = request.ResourceType;
            query["NextToken"] = request.NextToken;
            query["ResourceId"] = request.ResourceId;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2014-08-15",
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

        public ListUserBackupFilesResponse ListUserBackupFilesWithOptions(ListUserBackupFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Status"] = request.Status;
            query["RegionId"] = request.RegionId;
            query["Comment"] = request.Comment;
            query["BackupId"] = request.BackupId;
            query["OssUrl"] = request.OssUrl;
            query["Tags"] = request.Tags;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserBackupFiles",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserBackupFilesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListUserBackupFilesResponse> ListUserBackupFilesWithOptionsAsync(ListUserBackupFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Status"] = request.Status;
            query["RegionId"] = request.RegionId;
            query["Comment"] = request.Comment;
            query["BackupId"] = request.BackupId;
            query["OssUrl"] = request.OssUrl;
            query["Tags"] = request.Tags;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserBackupFiles",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserBackupFilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListUserBackupFilesResponse ListUserBackupFiles(ListUserBackupFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserBackupFilesWithOptions(request, runtime);
        }

        public async Task<ListUserBackupFilesResponse> ListUserBackupFilesAsync(ListUserBackupFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserBackupFilesWithOptionsAsync(request, runtime);
        }

        public LockAccountResponse LockAccountWithOptions(LockAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AccountName"] = request.AccountName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LockAccount",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<LockAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<LockAccountResponse> LockAccountWithOptionsAsync(LockAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AccountName"] = request.AccountName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LockAccount",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<LockAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public LockAccountResponse LockAccount(LockAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LockAccountWithOptions(request, runtime);
        }

        public async Task<LockAccountResponse> LockAccountAsync(LockAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LockAccountWithOptionsAsync(request, runtime);
        }

        public MigrateDBInstanceResponse MigrateDBInstanceWithOptions(MigrateDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["TargetDedicatedHostIdForMaster"] = request.TargetDedicatedHostIdForMaster;
            query["TargetDedicatedHostIdForSlave"] = request.TargetDedicatedHostIdForSlave;
            query["EffectiveTime"] = request.EffectiveTime;
            query["SpecifiedTime"] = request.SpecifiedTime;
            query["ZoneIdForLog"] = request.ZoneIdForLog;
            query["ZoneIdForFollower"] = request.ZoneIdForFollower;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MigrateDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MigrateDBInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<MigrateDBInstanceResponse> MigrateDBInstanceWithOptionsAsync(MigrateDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["TargetDedicatedHostIdForMaster"] = request.TargetDedicatedHostIdForMaster;
            query["TargetDedicatedHostIdForSlave"] = request.TargetDedicatedHostIdForSlave;
            query["EffectiveTime"] = request.EffectiveTime;
            query["SpecifiedTime"] = request.SpecifiedTime;
            query["ZoneIdForLog"] = request.ZoneIdForLog;
            query["ZoneIdForFollower"] = request.ZoneIdForFollower;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MigrateDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MigrateDBInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public MigrateDBInstanceResponse MigrateDBInstance(MigrateDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MigrateDBInstanceWithOptions(request, runtime);
        }

        public async Task<MigrateDBInstanceResponse> MigrateDBInstanceAsync(MigrateDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MigrateDBInstanceWithOptionsAsync(request, runtime);
        }

        public MigrateSecurityIPModeResponse MigrateSecurityIPModeWithOptions(MigrateSecurityIPModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MigrateSecurityIPMode",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MigrateSecurityIPModeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<MigrateSecurityIPModeResponse> MigrateSecurityIPModeWithOptionsAsync(MigrateSecurityIPModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MigrateSecurityIPMode",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MigrateSecurityIPModeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public MigrateSecurityIPModeResponse MigrateSecurityIPMode(MigrateSecurityIPModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MigrateSecurityIPModeWithOptions(request, runtime);
        }

        public async Task<MigrateSecurityIPModeResponse> MigrateSecurityIPModeAsync(MigrateSecurityIPModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MigrateSecurityIPModeWithOptionsAsync(request, runtime);
        }

        public MigrateToOtherZoneResponse MigrateToOtherZoneWithOptions(MigrateToOtherZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["VPCId"] = request.VPCId;
            query["ZoneId"] = request.ZoneId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["EffectiveTime"] = request.EffectiveTime;
            query["VSwitchId"] = request.VSwitchId;
            query["Category"] = request.Category;
            query["ZoneIdSlave1"] = request.ZoneIdSlave1;
            query["ZoneIdSlave2"] = request.ZoneIdSlave2;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MigrateToOtherZone",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MigrateToOtherZoneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<MigrateToOtherZoneResponse> MigrateToOtherZoneWithOptionsAsync(MigrateToOtherZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["VPCId"] = request.VPCId;
            query["ZoneId"] = request.ZoneId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["EffectiveTime"] = request.EffectiveTime;
            query["VSwitchId"] = request.VSwitchId;
            query["Category"] = request.Category;
            query["ZoneIdSlave1"] = request.ZoneIdSlave1;
            query["ZoneIdSlave2"] = request.ZoneIdSlave2;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MigrateToOtherZone",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MigrateToOtherZoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        public MigrateToOtherZoneResponse MigrateToOtherZone(MigrateToOtherZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MigrateToOtherZoneWithOptions(request, runtime);
        }

        public async Task<MigrateToOtherZoneResponse> MigrateToOtherZoneAsync(MigrateToOtherZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MigrateToOtherZoneWithOptionsAsync(request, runtime);
        }

        public ModifyAccountDescriptionResponse ModifyAccountDescriptionWithOptions(ModifyAccountDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AccountName"] = request.AccountName;
            query["AccountDescription"] = request.AccountDescription;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAccountDescription",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAccountDescriptionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyAccountDescriptionResponse> ModifyAccountDescriptionWithOptionsAsync(ModifyAccountDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AccountName"] = request.AccountName;
            query["AccountDescription"] = request.AccountDescription;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAccountDescription",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAccountDescriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyAccountDescriptionResponse ModifyAccountDescription(ModifyAccountDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAccountDescriptionWithOptions(request, runtime);
        }

        public async Task<ModifyAccountDescriptionResponse> ModifyAccountDescriptionAsync(ModifyAccountDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAccountDescriptionWithOptionsAsync(request, runtime);
        }

        public ModifyActionEventPolicyResponse ModifyActionEventPolicyWithOptions(ModifyActionEventPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["EnableEventLog"] = request.EnableEventLog;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyActionEventPolicy",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyActionEventPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyActionEventPolicyResponse> ModifyActionEventPolicyWithOptionsAsync(ModifyActionEventPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["EnableEventLog"] = request.EnableEventLog;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyActionEventPolicy",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyActionEventPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyActionEventPolicyResponse ModifyActionEventPolicy(ModifyActionEventPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyActionEventPolicyWithOptions(request, runtime);
        }

        public async Task<ModifyActionEventPolicyResponse> ModifyActionEventPolicyAsync(ModifyActionEventPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyActionEventPolicyWithOptionsAsync(request, runtime);
        }

        public ModifyBackupPolicyResponse ModifyBackupPolicyWithOptions(ModifyBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["BackupPolicyMode"] = request.BackupPolicyMode;
            query["PreferredBackupTime"] = request.PreferredBackupTime;
            query["PreferredBackupPeriod"] = request.PreferredBackupPeriod;
            query["BackupRetentionPeriod"] = request.BackupRetentionPeriod;
            query["BackupLog"] = request.BackupLog;
            query["LogBackupRetentionPeriod"] = request.LogBackupRetentionPeriod;
            query["OwnerAccount"] = request.OwnerAccount;
            query["EnableBackupLog"] = request.EnableBackupLog;
            query["LocalLogRetentionHours"] = request.LocalLogRetentionHours;
            query["LocalLogRetentionSpace"] = request.LocalLogRetentionSpace;
            query["HighSpaceUsageProtection"] = request.HighSpaceUsageProtection;
            query["LogBackupFrequency"] = request.LogBackupFrequency;
            query["CompressType"] = request.CompressType;
            query["ArchiveBackupRetentionPeriod"] = request.ArchiveBackupRetentionPeriod;
            query["ArchiveBackupKeepPolicy"] = request.ArchiveBackupKeepPolicy;
            query["ArchiveBackupKeepCount"] = request.ArchiveBackupKeepCount;
            query["ReleasedKeepPolicy"] = request.ReleasedKeepPolicy;
            query["LogBackupLocalRetentionNumber"] = request.LogBackupLocalRetentionNumber;
            query["Category"] = request.Category;
            query["BackupInterval"] = request.BackupInterval;
            query["BackupMethod"] = request.BackupMethod;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBackupPolicy",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBackupPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyBackupPolicyResponse> ModifyBackupPolicyWithOptionsAsync(ModifyBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["BackupPolicyMode"] = request.BackupPolicyMode;
            query["PreferredBackupTime"] = request.PreferredBackupTime;
            query["PreferredBackupPeriod"] = request.PreferredBackupPeriod;
            query["BackupRetentionPeriod"] = request.BackupRetentionPeriod;
            query["BackupLog"] = request.BackupLog;
            query["LogBackupRetentionPeriod"] = request.LogBackupRetentionPeriod;
            query["OwnerAccount"] = request.OwnerAccount;
            query["EnableBackupLog"] = request.EnableBackupLog;
            query["LocalLogRetentionHours"] = request.LocalLogRetentionHours;
            query["LocalLogRetentionSpace"] = request.LocalLogRetentionSpace;
            query["HighSpaceUsageProtection"] = request.HighSpaceUsageProtection;
            query["LogBackupFrequency"] = request.LogBackupFrequency;
            query["CompressType"] = request.CompressType;
            query["ArchiveBackupRetentionPeriod"] = request.ArchiveBackupRetentionPeriod;
            query["ArchiveBackupKeepPolicy"] = request.ArchiveBackupKeepPolicy;
            query["ArchiveBackupKeepCount"] = request.ArchiveBackupKeepCount;
            query["ReleasedKeepPolicy"] = request.ReleasedKeepPolicy;
            query["LogBackupLocalRetentionNumber"] = request.LogBackupLocalRetentionNumber;
            query["Category"] = request.Category;
            query["BackupInterval"] = request.BackupInterval;
            query["BackupMethod"] = request.BackupMethod;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBackupPolicy",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBackupPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyBackupPolicyResponse ModifyBackupPolicy(ModifyBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBackupPolicyWithOptions(request, runtime);
        }

        public async Task<ModifyBackupPolicyResponse> ModifyBackupPolicyAsync(ModifyBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBackupPolicyWithOptionsAsync(request, runtime);
        }

        public ModifyCollationTimeZoneResponse ModifyCollationTimeZoneWithOptions(ModifyCollationTimeZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Collation"] = request.Collation;
            query["Timezone"] = request.Timezone;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCollationTimeZone",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCollationTimeZoneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyCollationTimeZoneResponse> ModifyCollationTimeZoneWithOptionsAsync(ModifyCollationTimeZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Collation"] = request.Collation;
            query["Timezone"] = request.Timezone;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCollationTimeZone",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCollationTimeZoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyCollationTimeZoneResponse ModifyCollationTimeZone(ModifyCollationTimeZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCollationTimeZoneWithOptions(request, runtime);
        }

        public async Task<ModifyCollationTimeZoneResponse> ModifyCollationTimeZoneAsync(ModifyCollationTimeZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCollationTimeZoneWithOptionsAsync(request, runtime);
        }

        public ModifyDasInstanceConfigResponse ModifyDasInstanceConfigWithOptions(ModifyDasInstanceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["StorageAutoScale"] = request.StorageAutoScale;
            query["StorageThreshold"] = request.StorageThreshold;
            query["StorageUpperBound"] = request.StorageUpperBound;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDasInstanceConfig",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDasInstanceConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDasInstanceConfigResponse> ModifyDasInstanceConfigWithOptionsAsync(ModifyDasInstanceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["StorageAutoScale"] = request.StorageAutoScale;
            query["StorageThreshold"] = request.StorageThreshold;
            query["StorageUpperBound"] = request.StorageUpperBound;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDasInstanceConfig",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDasInstanceConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDasInstanceConfigResponse ModifyDasInstanceConfig(ModifyDasInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDasInstanceConfigWithOptions(request, runtime);
        }

        public async Task<ModifyDasInstanceConfigResponse> ModifyDasInstanceConfigAsync(ModifyDasInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDasInstanceConfigWithOptionsAsync(request, runtime);
        }

        public ModifyDBDescriptionResponse ModifyDBDescriptionWithOptions(ModifyDBDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBName"] = request.DBName;
            query["DBDescription"] = request.DBDescription;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBDescription",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBDescriptionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDBDescriptionResponse> ModifyDBDescriptionWithOptionsAsync(ModifyDBDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBName"] = request.DBName;
            query["DBDescription"] = request.DBDescription;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBDescription",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBDescriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDBDescriptionResponse ModifyDBDescription(ModifyDBDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBDescriptionWithOptions(request, runtime);
        }

        public async Task<ModifyDBDescriptionResponse> ModifyDBDescriptionAsync(ModifyDBDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBDescriptionWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceAutoUpgradeMinorVersionResponse ModifyDBInstanceAutoUpgradeMinorVersionWithOptions(ModifyDBInstanceAutoUpgradeMinorVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AutoUpgradeMinorVersion"] = request.AutoUpgradeMinorVersion;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceAutoUpgradeMinorVersion",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceAutoUpgradeMinorVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDBInstanceAutoUpgradeMinorVersionResponse> ModifyDBInstanceAutoUpgradeMinorVersionWithOptionsAsync(ModifyDBInstanceAutoUpgradeMinorVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AutoUpgradeMinorVersion"] = request.AutoUpgradeMinorVersion;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceAutoUpgradeMinorVersion",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceAutoUpgradeMinorVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDBInstanceAutoUpgradeMinorVersionResponse ModifyDBInstanceAutoUpgradeMinorVersion(ModifyDBInstanceAutoUpgradeMinorVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceAutoUpgradeMinorVersionWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceAutoUpgradeMinorVersionResponse> ModifyDBInstanceAutoUpgradeMinorVersionAsync(ModifyDBInstanceAutoUpgradeMinorVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceAutoUpgradeMinorVersionWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceConnectionModeResponse ModifyDBInstanceConnectionModeWithOptions(ModifyDBInstanceConnectionModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ConnectionMode"] = request.ConnectionMode;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceConnectionMode",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceConnectionModeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDBInstanceConnectionModeResponse> ModifyDBInstanceConnectionModeWithOptionsAsync(ModifyDBInstanceConnectionModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ConnectionMode"] = request.ConnectionMode;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceConnectionMode",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceConnectionModeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDBInstanceConnectionModeResponse ModifyDBInstanceConnectionMode(ModifyDBInstanceConnectionModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceConnectionModeWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceConnectionModeResponse> ModifyDBInstanceConnectionModeAsync(ModifyDBInstanceConnectionModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceConnectionModeWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceConnectionStringResponse ModifyDBInstanceConnectionStringWithOptions(ModifyDBInstanceConnectionStringRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["CurrentConnectionString"] = request.CurrentConnectionString;
            query["ConnectionStringPrefix"] = request.ConnectionStringPrefix;
            query["Port"] = request.Port;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceConnectionString",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceConnectionStringResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDBInstanceConnectionStringResponse> ModifyDBInstanceConnectionStringWithOptionsAsync(ModifyDBInstanceConnectionStringRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["CurrentConnectionString"] = request.CurrentConnectionString;
            query["ConnectionStringPrefix"] = request.ConnectionStringPrefix;
            query["Port"] = request.Port;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceConnectionString",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceConnectionStringResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDBInstanceConnectionStringResponse ModifyDBInstanceConnectionString(ModifyDBInstanceConnectionStringRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceConnectionStringWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceConnectionStringResponse> ModifyDBInstanceConnectionStringAsync(ModifyDBInstanceConnectionStringRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceConnectionStringWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceDescriptionResponse ModifyDBInstanceDescriptionWithOptions(ModifyDBInstanceDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBInstanceDescription"] = request.DBInstanceDescription;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceDescription",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceDescriptionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDBInstanceDescriptionResponse> ModifyDBInstanceDescriptionWithOptionsAsync(ModifyDBInstanceDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBInstanceDescription"] = request.DBInstanceDescription;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceDescription",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceDescriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDBInstanceDescriptionResponse ModifyDBInstanceDescription(ModifyDBInstanceDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceDescriptionWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceDescriptionResponse> ModifyDBInstanceDescriptionAsync(ModifyDBInstanceDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceDescriptionWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceHAConfigResponse ModifyDBInstanceHAConfigWithOptions(ModifyDBInstanceHAConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SyncMode"] = request.SyncMode;
            query["HAMode"] = request.HAMode;
            query["DbInstanceId"] = request.DbInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceHAConfig",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceHAConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDBInstanceHAConfigResponse> ModifyDBInstanceHAConfigWithOptionsAsync(ModifyDBInstanceHAConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SyncMode"] = request.SyncMode;
            query["HAMode"] = request.HAMode;
            query["DbInstanceId"] = request.DbInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceHAConfig",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceHAConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDBInstanceHAConfigResponse ModifyDBInstanceHAConfig(ModifyDBInstanceHAConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceHAConfigWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceHAConfigResponse> ModifyDBInstanceHAConfigAsync(ModifyDBInstanceHAConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceHAConfigWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceMaintainTimeResponse ModifyDBInstanceMaintainTimeWithOptions(ModifyDBInstanceMaintainTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["MaintainTime"] = request.MaintainTime;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceMaintainTime",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceMaintainTimeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDBInstanceMaintainTimeResponse> ModifyDBInstanceMaintainTimeWithOptionsAsync(ModifyDBInstanceMaintainTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["MaintainTime"] = request.MaintainTime;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceMaintainTime",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceMaintainTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDBInstanceMaintainTimeResponse ModifyDBInstanceMaintainTime(ModifyDBInstanceMaintainTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceMaintainTimeWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceMaintainTimeResponse> ModifyDBInstanceMaintainTimeAsync(ModifyDBInstanceMaintainTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceMaintainTimeWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceMonitorResponse ModifyDBInstanceMonitorWithOptions(ModifyDBInstanceMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Period"] = request.Period;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceMonitor",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceMonitorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDBInstanceMonitorResponse> ModifyDBInstanceMonitorWithOptionsAsync(ModifyDBInstanceMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Period"] = request.Period;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceMonitor",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDBInstanceMonitorResponse ModifyDBInstanceMonitor(ModifyDBInstanceMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceMonitorWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceMonitorResponse> ModifyDBInstanceMonitorAsync(ModifyDBInstanceMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceMonitorWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceNetworkExpireTimeResponse ModifyDBInstanceNetworkExpireTimeWithOptions(ModifyDBInstanceNetworkExpireTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ConnectionString"] = request.ConnectionString;
            query["ClassicExpiredDays"] = request.ClassicExpiredDays;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceNetworkExpireTime",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceNetworkExpireTimeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDBInstanceNetworkExpireTimeResponse> ModifyDBInstanceNetworkExpireTimeWithOptionsAsync(ModifyDBInstanceNetworkExpireTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ConnectionString"] = request.ConnectionString;
            query["ClassicExpiredDays"] = request.ClassicExpiredDays;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceNetworkExpireTime",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceNetworkExpireTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDBInstanceNetworkExpireTimeResponse ModifyDBInstanceNetworkExpireTime(ModifyDBInstanceNetworkExpireTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceNetworkExpireTimeWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceNetworkExpireTimeResponse> ModifyDBInstanceNetworkExpireTimeAsync(ModifyDBInstanceNetworkExpireTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceNetworkExpireTimeWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceNetworkTypeResponse ModifyDBInstanceNetworkTypeWithOptions(ModifyDBInstanceNetworkTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RetainClassic"] = request.RetainClassic;
            query["ClassicExpiredDays"] = request.ClassicExpiredDays;
            query["InstanceNetworkType"] = request.InstanceNetworkType;
            query["ReadWriteSplittingClassicExpiredDays"] = request.ReadWriteSplittingClassicExpiredDays;
            query["VPCId"] = request.VPCId;
            query["VSwitchId"] = request.VSwitchId;
            query["PrivateIpAddress"] = request.PrivateIpAddress;
            query["ReadWriteSplittingPrivateIpAddress"] = request.ReadWriteSplittingPrivateIpAddress;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceNetworkType",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceNetworkTypeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDBInstanceNetworkTypeResponse> ModifyDBInstanceNetworkTypeWithOptionsAsync(ModifyDBInstanceNetworkTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RetainClassic"] = request.RetainClassic;
            query["ClassicExpiredDays"] = request.ClassicExpiredDays;
            query["InstanceNetworkType"] = request.InstanceNetworkType;
            query["ReadWriteSplittingClassicExpiredDays"] = request.ReadWriteSplittingClassicExpiredDays;
            query["VPCId"] = request.VPCId;
            query["VSwitchId"] = request.VSwitchId;
            query["PrivateIpAddress"] = request.PrivateIpAddress;
            query["ReadWriteSplittingPrivateIpAddress"] = request.ReadWriteSplittingPrivateIpAddress;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceNetworkType",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceNetworkTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDBInstanceNetworkTypeResponse ModifyDBInstanceNetworkType(ModifyDBInstanceNetworkTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceNetworkTypeWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceNetworkTypeResponse> ModifyDBInstanceNetworkTypeAsync(ModifyDBInstanceNetworkTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceNetworkTypeWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstancePayTypeResponse ModifyDBInstancePayTypeWithOptions(ModifyDBInstancePayTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["UsedTime"] = request.UsedTime;
            query["PayType"] = request.PayType;
            query["Period"] = request.Period;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstancePayType",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstancePayTypeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDBInstancePayTypeResponse> ModifyDBInstancePayTypeWithOptionsAsync(ModifyDBInstancePayTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["UsedTime"] = request.UsedTime;
            query["PayType"] = request.PayType;
            query["Period"] = request.Period;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstancePayType",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstancePayTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDBInstancePayTypeResponse ModifyDBInstancePayType(ModifyDBInstancePayTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstancePayTypeWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstancePayTypeResponse> ModifyDBInstancePayTypeAsync(ModifyDBInstancePayTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstancePayTypeWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceProxyConfigurationResponse ModifyDBInstanceProxyConfigurationWithOptions(ModifyDBInstanceProxyConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ProxyConfigurationKey"] = request.ProxyConfigurationKey;
            query["ProxyConfigurationValue"] = request.ProxyConfigurationValue;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceProxyConfiguration",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceProxyConfigurationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDBInstanceProxyConfigurationResponse> ModifyDBInstanceProxyConfigurationWithOptionsAsync(ModifyDBInstanceProxyConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ProxyConfigurationKey"] = request.ProxyConfigurationKey;
            query["ProxyConfigurationValue"] = request.ProxyConfigurationValue;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceProxyConfiguration",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceProxyConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDBInstanceProxyConfigurationResponse ModifyDBInstanceProxyConfiguration(ModifyDBInstanceProxyConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceProxyConfigurationWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceProxyConfigurationResponse> ModifyDBInstanceProxyConfigurationAsync(ModifyDBInstanceProxyConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceProxyConfigurationWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceSpecResponse ModifyDBInstanceSpecWithOptions(ModifyDBInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["DBInstanceStorage"] = request.DBInstanceStorage;
            query["PayType"] = request.PayType;
            query["OwnerAccount"] = request.OwnerAccount;
            query["EffectiveTime"] = request.EffectiveTime;
            query["EngineVersion"] = request.EngineVersion;
            query["DBInstanceStorageType"] = request.DBInstanceStorageType;
            query["Direction"] = request.Direction;
            query["SourceBiz"] = request.SourceBiz;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceSpec",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceSpecResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDBInstanceSpecResponse> ModifyDBInstanceSpecWithOptionsAsync(ModifyDBInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["DBInstanceStorage"] = request.DBInstanceStorage;
            query["PayType"] = request.PayType;
            query["OwnerAccount"] = request.OwnerAccount;
            query["EffectiveTime"] = request.EffectiveTime;
            query["EngineVersion"] = request.EngineVersion;
            query["DBInstanceStorageType"] = request.DBInstanceStorageType;
            query["Direction"] = request.Direction;
            query["SourceBiz"] = request.SourceBiz;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceSpec",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDBInstanceSpecResponse ModifyDBInstanceSpec(ModifyDBInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceSpecWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceSpecResponse> ModifyDBInstanceSpecAsync(ModifyDBInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceSpecWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceSSLResponse ModifyDBInstanceSSLWithOptions(ModifyDBInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ConnectionString"] = request.ConnectionString;
            query["OwnerAccount"] = request.OwnerAccount;
            query["SSLEnabled"] = request.SSLEnabled;
            query["CAType"] = request.CAType;
            query["ServerCert"] = request.ServerCert;
            query["ServerKey"] = request.ServerKey;
            query["ClientCAEnabled"] = request.ClientCAEnabled;
            query["ClientCACert"] = request.ClientCACert;
            query["ClientCrlEnabled"] = request.ClientCrlEnabled;
            query["ClientCertRevocationList"] = request.ClientCertRevocationList;
            query["ACL"] = request.ACL;
            query["ReplicationACL"] = request.ReplicationACL;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceSSL",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceSSLResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDBInstanceSSLResponse> ModifyDBInstanceSSLWithOptionsAsync(ModifyDBInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ConnectionString"] = request.ConnectionString;
            query["OwnerAccount"] = request.OwnerAccount;
            query["SSLEnabled"] = request.SSLEnabled;
            query["CAType"] = request.CAType;
            query["ServerCert"] = request.ServerCert;
            query["ServerKey"] = request.ServerKey;
            query["ClientCAEnabled"] = request.ClientCAEnabled;
            query["ClientCACert"] = request.ClientCACert;
            query["ClientCrlEnabled"] = request.ClientCrlEnabled;
            query["ClientCertRevocationList"] = request.ClientCertRevocationList;
            query["ACL"] = request.ACL;
            query["ReplicationACL"] = request.ReplicationACL;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceSSL",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceSSLResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDBInstanceSSLResponse ModifyDBInstanceSSL(ModifyDBInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceSSLWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceSSLResponse> ModifyDBInstanceSSLAsync(ModifyDBInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceSSLWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceTDEResponse ModifyDBInstanceTDEWithOptions(ModifyDBInstanceTDERequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["TDEStatus"] = request.TDEStatus;
            query["DBName"] = request.DBName;
            query["OwnerAccount"] = request.OwnerAccount;
            query["EncryptionKey"] = request.EncryptionKey;
            query["RoleArn"] = request.RoleArn;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceTDE",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceTDEResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDBInstanceTDEResponse> ModifyDBInstanceTDEWithOptionsAsync(ModifyDBInstanceTDERequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["TDEStatus"] = request.TDEStatus;
            query["DBName"] = request.DBName;
            query["OwnerAccount"] = request.OwnerAccount;
            query["EncryptionKey"] = request.EncryptionKey;
            query["RoleArn"] = request.RoleArn;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceTDE",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceTDEResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDBInstanceTDEResponse ModifyDBInstanceTDE(ModifyDBInstanceTDERequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceTDEWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceTDEResponse> ModifyDBInstanceTDEAsync(ModifyDBInstanceTDERequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceTDEWithOptionsAsync(request, runtime);
        }

        public ModifyDBProxyResponse ModifyDBProxyWithOptions(ModifyDBProxyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ConfigDBProxyService"] = request.ConfigDBProxyService;
            query["DBProxyInstanceNum"] = request.DBProxyInstanceNum;
            query["RegionId"] = request.RegionId;
            query["InstanceNetworkType"] = request.InstanceNetworkType;
            query["VPCId"] = request.VPCId;
            query["VSwitchId"] = request.VSwitchId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBProxy",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBProxyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDBProxyResponse> ModifyDBProxyWithOptionsAsync(ModifyDBProxyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ConfigDBProxyService"] = request.ConfigDBProxyService;
            query["DBProxyInstanceNum"] = request.DBProxyInstanceNum;
            query["RegionId"] = request.RegionId;
            query["InstanceNetworkType"] = request.InstanceNetworkType;
            query["VPCId"] = request.VPCId;
            query["VSwitchId"] = request.VSwitchId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBProxy",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBProxyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDBProxyResponse ModifyDBProxy(ModifyDBProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBProxyWithOptions(request, runtime);
        }

        public async Task<ModifyDBProxyResponse> ModifyDBProxyAsync(ModifyDBProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBProxyWithOptionsAsync(request, runtime);
        }

        public ModifyDBProxyEndpointResponse ModifyDBProxyEndpointWithOptions(ModifyDBProxyEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBProxyEndpointId"] = request.DBProxyEndpointId;
            query["ConfigDBProxyFeatures"] = request.ConfigDBProxyFeatures;
            query["RegionId"] = request.RegionId;
            query["ReadOnlyInstanceMaxDelayTime"] = request.ReadOnlyInstanceMaxDelayTime;
            query["ReadOnlyInstanceDistributionType"] = request.ReadOnlyInstanceDistributionType;
            query["ReadOnlyInstanceWeight"] = request.ReadOnlyInstanceWeight;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DbEndpointOperator"] = request.DbEndpointOperator;
            query["DbEndpointAliases"] = request.DbEndpointAliases;
            query["DbEndpointType"] = request.DbEndpointType;
            query["DbEndpointReadWriteMode"] = request.DbEndpointReadWriteMode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBProxyEndpoint",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBProxyEndpointResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDBProxyEndpointResponse> ModifyDBProxyEndpointWithOptionsAsync(ModifyDBProxyEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBProxyEndpointId"] = request.DBProxyEndpointId;
            query["ConfigDBProxyFeatures"] = request.ConfigDBProxyFeatures;
            query["RegionId"] = request.RegionId;
            query["ReadOnlyInstanceMaxDelayTime"] = request.ReadOnlyInstanceMaxDelayTime;
            query["ReadOnlyInstanceDistributionType"] = request.ReadOnlyInstanceDistributionType;
            query["ReadOnlyInstanceWeight"] = request.ReadOnlyInstanceWeight;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DbEndpointOperator"] = request.DbEndpointOperator;
            query["DbEndpointAliases"] = request.DbEndpointAliases;
            query["DbEndpointType"] = request.DbEndpointType;
            query["DbEndpointReadWriteMode"] = request.DbEndpointReadWriteMode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBProxyEndpoint",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBProxyEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDBProxyEndpointResponse ModifyDBProxyEndpoint(ModifyDBProxyEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBProxyEndpointWithOptions(request, runtime);
        }

        public async Task<ModifyDBProxyEndpointResponse> ModifyDBProxyEndpointAsync(ModifyDBProxyEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBProxyEndpointWithOptionsAsync(request, runtime);
        }

        public ModifyDBProxyEndpointAddressResponse ModifyDBProxyEndpointAddressWithOptions(ModifyDBProxyEndpointAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBProxyEndpointId"] = request.DBProxyEndpointId;
            query["DBProxyNewConnectString"] = request.DBProxyNewConnectString;
            query["DBProxyNewConnectStringPort"] = request.DBProxyNewConnectStringPort;
            query["DBProxyConnectStringNetType"] = request.DBProxyConnectStringNetType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBProxyEndpointAddress",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBProxyEndpointAddressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDBProxyEndpointAddressResponse> ModifyDBProxyEndpointAddressWithOptionsAsync(ModifyDBProxyEndpointAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBProxyEndpointId"] = request.DBProxyEndpointId;
            query["DBProxyNewConnectString"] = request.DBProxyNewConnectString;
            query["DBProxyNewConnectStringPort"] = request.DBProxyNewConnectStringPort;
            query["DBProxyConnectStringNetType"] = request.DBProxyConnectStringNetType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBProxyEndpointAddress",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBProxyEndpointAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDBProxyEndpointAddressResponse ModifyDBProxyEndpointAddress(ModifyDBProxyEndpointAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBProxyEndpointAddressWithOptions(request, runtime);
        }

        public async Task<ModifyDBProxyEndpointAddressResponse> ModifyDBProxyEndpointAddressAsync(ModifyDBProxyEndpointAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBProxyEndpointAddressWithOptionsAsync(request, runtime);
        }

        public ModifyDBProxyInstanceResponse ModifyDBProxyInstanceWithOptions(ModifyDBProxyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBProxyInstanceType"] = request.DBProxyInstanceType;
            query["DBProxyInstanceNum"] = request.DBProxyInstanceNum;
            query["EffectiveTime"] = request.EffectiveTime;
            query["EffectiveSpecificTime"] = request.EffectiveSpecificTime;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBProxyInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBProxyInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDBProxyInstanceResponse> ModifyDBProxyInstanceWithOptionsAsync(ModifyDBProxyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DBProxyInstanceType"] = request.DBProxyInstanceType;
            query["DBProxyInstanceNum"] = request.DBProxyInstanceNum;
            query["EffectiveTime"] = request.EffectiveTime;
            query["EffectiveSpecificTime"] = request.EffectiveSpecificTime;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBProxyInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBProxyInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDBProxyInstanceResponse ModifyDBProxyInstance(ModifyDBProxyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBProxyInstanceWithOptions(request, runtime);
        }

        public async Task<ModifyDBProxyInstanceResponse> ModifyDBProxyInstanceAsync(ModifyDBProxyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBProxyInstanceWithOptionsAsync(request, runtime);
        }

        public ModifyDbProxyInstanceSslResponse ModifyDbProxyInstanceSslWithOptions(ModifyDbProxyInstanceSslRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["DbInstanceId"] = request.DbInstanceId;
            query["DbInstanceId"] = request.DbInstanceId;
            query["DbProxyEndpointId"] = request.DbProxyEndpointId;
            query["DbProxyConnectString"] = request.DbProxyConnectString;
            query["DbProxySslEnabled"] = request.DbProxySslEnabled;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDbProxyInstanceSsl",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDbProxyInstanceSslResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDbProxyInstanceSslResponse> ModifyDbProxyInstanceSslWithOptionsAsync(ModifyDbProxyInstanceSslRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["DbInstanceId"] = request.DbInstanceId;
            query["DbInstanceId"] = request.DbInstanceId;
            query["DbProxyEndpointId"] = request.DbProxyEndpointId;
            query["DbProxyConnectString"] = request.DbProxyConnectString;
            query["DbProxySslEnabled"] = request.DbProxySslEnabled;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDbProxyInstanceSsl",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDbProxyInstanceSslResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDbProxyInstanceSslResponse ModifyDbProxyInstanceSsl(ModifyDbProxyInstanceSslRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDbProxyInstanceSslWithOptions(request, runtime);
        }

        public async Task<ModifyDbProxyInstanceSslResponse> ModifyDbProxyInstanceSslAsync(ModifyDbProxyInstanceSslRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDbProxyInstanceSslWithOptionsAsync(request, runtime);
        }

        public ModifyDedicatedHostAccountResponse ModifyDedicatedHostAccountWithOptions(ModifyDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["AccountName"] = request.AccountName;
            query["AccountPassword"] = request.AccountPassword;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDedicatedHostAccount",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDedicatedHostAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDedicatedHostAccountResponse> ModifyDedicatedHostAccountWithOptionsAsync(ModifyDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["AccountName"] = request.AccountName;
            query["AccountPassword"] = request.AccountPassword;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDedicatedHostAccount",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDedicatedHostAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDedicatedHostAccountResponse ModifyDedicatedHostAccount(ModifyDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedHostAccountWithOptions(request, runtime);
        }

        public async Task<ModifyDedicatedHostAccountResponse> ModifyDedicatedHostAccountAsync(ModifyDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedHostAccountWithOptionsAsync(request, runtime);
        }

        public ModifyDedicatedHostAttributeResponse ModifyDedicatedHostAttributeWithOptions(ModifyDedicatedHostAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["HostName"] = request.HostName;
            query["AllocationStatus"] = request.AllocationStatus;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDedicatedHostAttribute",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDedicatedHostAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDedicatedHostAttributeResponse> ModifyDedicatedHostAttributeWithOptionsAsync(ModifyDedicatedHostAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["HostName"] = request.HostName;
            query["AllocationStatus"] = request.AllocationStatus;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDedicatedHostAttribute",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDedicatedHostAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDedicatedHostAttributeResponse ModifyDedicatedHostAttribute(ModifyDedicatedHostAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedHostAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyDedicatedHostAttributeResponse> ModifyDedicatedHostAttributeAsync(ModifyDedicatedHostAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedHostAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyDedicatedHostGroupAttributeResponse ModifyDedicatedHostGroupAttributeWithOptions(ModifyDedicatedHostGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["DedicatedHostGroupDesc"] = request.DedicatedHostGroupDesc;
            query["CpuAllocationRatio"] = request.CpuAllocationRatio;
            query["MemAllocationRatio"] = request.MemAllocationRatio;
            query["DiskAllocationRatio"] = request.DiskAllocationRatio;
            query["AllocationPolicy"] = request.AllocationPolicy;
            query["HostReplacePolicy"] = request.HostReplacePolicy;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDedicatedHostGroupAttribute",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDedicatedHostGroupAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDedicatedHostGroupAttributeResponse> ModifyDedicatedHostGroupAttributeWithOptionsAsync(ModifyDedicatedHostGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["DedicatedHostGroupDesc"] = request.DedicatedHostGroupDesc;
            query["CpuAllocationRatio"] = request.CpuAllocationRatio;
            query["MemAllocationRatio"] = request.MemAllocationRatio;
            query["DiskAllocationRatio"] = request.DiskAllocationRatio;
            query["AllocationPolicy"] = request.AllocationPolicy;
            query["HostReplacePolicy"] = request.HostReplacePolicy;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDedicatedHostGroupAttribute",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDedicatedHostGroupAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDedicatedHostGroupAttributeResponse ModifyDedicatedHostGroupAttribute(ModifyDedicatedHostGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedHostGroupAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyDedicatedHostGroupAttributeResponse> ModifyDedicatedHostGroupAttributeAsync(ModifyDedicatedHostGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedHostGroupAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyDedicatedHostUserResponse ModifyDedicatedHostUserWithOptions(ModifyDedicatedHostUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DedicatedHostName"] = request.DedicatedHostName;
            query["UserName"] = request.UserName;
            query["OldPassword"] = request.OldPassword;
            query["NewPassword"] = request.NewPassword;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDedicatedHostUser",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDedicatedHostUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDedicatedHostUserResponse> ModifyDedicatedHostUserWithOptionsAsync(ModifyDedicatedHostUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DedicatedHostName"] = request.DedicatedHostName;
            query["UserName"] = request.UserName;
            query["OldPassword"] = request.OldPassword;
            query["NewPassword"] = request.NewPassword;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDedicatedHostUser",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDedicatedHostUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDedicatedHostUserResponse ModifyDedicatedHostUser(ModifyDedicatedHostUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedHostUserWithOptions(request, runtime);
        }

        public async Task<ModifyDedicatedHostUserResponse> ModifyDedicatedHostUserAsync(ModifyDedicatedHostUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedHostUserWithOptionsAsync(request, runtime);
        }

        public ModifyDTCSecurityIpHostsForSQLServerResponse ModifyDTCSecurityIpHostsForSQLServerWithOptions(ModifyDTCSecurityIpHostsForSQLServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["SecurityIpHosts"] = request.SecurityIpHosts;
            query["WhiteListGroupName"] = request.WhiteListGroupName;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDTCSecurityIpHostsForSQLServer",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDTCSecurityIpHostsForSQLServerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDTCSecurityIpHostsForSQLServerResponse> ModifyDTCSecurityIpHostsForSQLServerWithOptionsAsync(ModifyDTCSecurityIpHostsForSQLServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["SecurityIpHosts"] = request.SecurityIpHosts;
            query["WhiteListGroupName"] = request.WhiteListGroupName;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDTCSecurityIpHostsForSQLServer",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDTCSecurityIpHostsForSQLServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDTCSecurityIpHostsForSQLServerResponse ModifyDTCSecurityIpHostsForSQLServer(ModifyDTCSecurityIpHostsForSQLServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDTCSecurityIpHostsForSQLServerWithOptions(request, runtime);
        }

        public async Task<ModifyDTCSecurityIpHostsForSQLServerResponse> ModifyDTCSecurityIpHostsForSQLServerAsync(ModifyDTCSecurityIpHostsForSQLServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDTCSecurityIpHostsForSQLServerWithOptionsAsync(request, runtime);
        }

        public ModifyHADiagnoseConfigResponse ModifyHADiagnoseConfigWithOptions(ModifyHADiagnoseConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["TcpConnectionType"] = request.TcpConnectionType;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyHADiagnoseConfig",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyHADiagnoseConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyHADiagnoseConfigResponse> ModifyHADiagnoseConfigWithOptionsAsync(ModifyHADiagnoseConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["TcpConnectionType"] = request.TcpConnectionType;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyHADiagnoseConfig",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyHADiagnoseConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyHADiagnoseConfigResponse ModifyHADiagnoseConfig(ModifyHADiagnoseConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHADiagnoseConfigWithOptions(request, runtime);
        }

        public async Task<ModifyHADiagnoseConfigResponse> ModifyHADiagnoseConfigAsync(ModifyHADiagnoseConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHADiagnoseConfigWithOptionsAsync(request, runtime);
        }

        public ModifyHASwitchConfigResponse ModifyHASwitchConfigWithOptions(ModifyHASwitchConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["HAConfig"] = request.HAConfig;
            query["ManualHATime"] = request.ManualHATime;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyHASwitchConfig",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyHASwitchConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyHASwitchConfigResponse> ModifyHASwitchConfigWithOptionsAsync(ModifyHASwitchConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["HAConfig"] = request.HAConfig;
            query["ManualHATime"] = request.ManualHATime;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyHASwitchConfig",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyHASwitchConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyHASwitchConfigResponse ModifyHASwitchConfig(ModifyHASwitchConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHASwitchConfigWithOptions(request, runtime);
        }

        public async Task<ModifyHASwitchConfigResponse> ModifyHASwitchConfigAsync(ModifyHASwitchConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHASwitchConfigWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceAutoRenewalAttributeResponse ModifyInstanceAutoRenewalAttributeWithOptions(ModifyInstanceAutoRenewalAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["ClientToken"] = request.ClientToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Duration"] = request.Duration;
            query["AutoRenew"] = request.AutoRenew;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceAutoRenewalAttribute",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceAutoRenewalAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyInstanceAutoRenewalAttributeResponse> ModifyInstanceAutoRenewalAttributeWithOptionsAsync(ModifyInstanceAutoRenewalAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["ClientToken"] = request.ClientToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Duration"] = request.Duration;
            query["AutoRenew"] = request.AutoRenew;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceAutoRenewalAttribute",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceAutoRenewalAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyInstanceAutoRenewalAttributeResponse ModifyInstanceAutoRenewalAttribute(ModifyInstanceAutoRenewalAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceAutoRenewalAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceAutoRenewalAttributeResponse> ModifyInstanceAutoRenewalAttributeAsync(ModifyInstanceAutoRenewalAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceAutoRenewalAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceCrossBackupPolicyResponse ModifyInstanceCrossBackupPolicyWithOptions(ModifyInstanceCrossBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            query["CrossBackupType"] = request.CrossBackupType;
            query["LogBackupEnabled"] = request.LogBackupEnabled;
            query["BackupEnabled"] = request.BackupEnabled;
            query["CrossBackupRegion"] = request.CrossBackupRegion;
            query["RetentType"] = request.RetentType;
            query["Retention"] = request.Retention;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceCrossBackupPolicy",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceCrossBackupPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyInstanceCrossBackupPolicyResponse> ModifyInstanceCrossBackupPolicyWithOptionsAsync(ModifyInstanceCrossBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            query["CrossBackupType"] = request.CrossBackupType;
            query["LogBackupEnabled"] = request.LogBackupEnabled;
            query["BackupEnabled"] = request.BackupEnabled;
            query["CrossBackupRegion"] = request.CrossBackupRegion;
            query["RetentType"] = request.RetentType;
            query["Retention"] = request.Retention;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceCrossBackupPolicy",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceCrossBackupPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyInstanceCrossBackupPolicyResponse ModifyInstanceCrossBackupPolicy(ModifyInstanceCrossBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceCrossBackupPolicyWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceCrossBackupPolicyResponse> ModifyInstanceCrossBackupPolicyAsync(ModifyInstanceCrossBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceCrossBackupPolicyWithOptionsAsync(request, runtime);
        }

        public ModifyParameterResponse ModifyParameterWithOptions(ModifyParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Parameters"] = request.Parameters;
            query["Forcerestart"] = request.Forcerestart;
            query["OwnerAccount"] = request.OwnerAccount;
            query["ParameterGroupId"] = request.ParameterGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyParameter",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyParameterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyParameterResponse> ModifyParameterWithOptionsAsync(ModifyParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Parameters"] = request.Parameters;
            query["Forcerestart"] = request.Forcerestart;
            query["OwnerAccount"] = request.OwnerAccount;
            query["ParameterGroupId"] = request.ParameterGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyParameter",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyParameterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyParameterResponse ModifyParameter(ModifyParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyParameterWithOptions(request, runtime);
        }

        public async Task<ModifyParameterResponse> ModifyParameterAsync(ModifyParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyParameterWithOptionsAsync(request, runtime);
        }

        public ModifyParameterGroupResponse ModifyParameterGroupWithOptions(ModifyParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ParameterGroupId"] = request.ParameterGroupId;
            query["ParameterGroupName"] = request.ParameterGroupName;
            query["ParameterGroupDesc"] = request.ParameterGroupDesc;
            query["Parameters"] = request.Parameters;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyParameterGroup",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyParameterGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyParameterGroupResponse> ModifyParameterGroupWithOptionsAsync(ModifyParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ParameterGroupId"] = request.ParameterGroupId;
            query["ParameterGroupName"] = request.ParameterGroupName;
            query["ParameterGroupDesc"] = request.ParameterGroupDesc;
            query["Parameters"] = request.Parameters;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyParameterGroup",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyParameterGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyParameterGroupResponse ModifyParameterGroup(ModifyParameterGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyParameterGroupWithOptions(request, runtime);
        }

        public async Task<ModifyParameterGroupResponse> ModifyParameterGroupAsync(ModifyParameterGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyParameterGroupWithOptionsAsync(request, runtime);
        }

        public ModifyReadonlyInstanceDelayReplicationTimeResponse ModifyReadonlyInstanceDelayReplicationTimeWithOptions(ModifyReadonlyInstanceDelayReplicationTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ReadSQLReplicationTime"] = request.ReadSQLReplicationTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyReadonlyInstanceDelayReplicationTime",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyReadonlyInstanceDelayReplicationTimeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyReadonlyInstanceDelayReplicationTimeResponse> ModifyReadonlyInstanceDelayReplicationTimeWithOptionsAsync(ModifyReadonlyInstanceDelayReplicationTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ReadSQLReplicationTime"] = request.ReadSQLReplicationTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyReadonlyInstanceDelayReplicationTime",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyReadonlyInstanceDelayReplicationTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyReadonlyInstanceDelayReplicationTimeResponse ModifyReadonlyInstanceDelayReplicationTime(ModifyReadonlyInstanceDelayReplicationTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyReadonlyInstanceDelayReplicationTimeWithOptions(request, runtime);
        }

        public async Task<ModifyReadonlyInstanceDelayReplicationTimeResponse> ModifyReadonlyInstanceDelayReplicationTimeAsync(ModifyReadonlyInstanceDelayReplicationTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyReadonlyInstanceDelayReplicationTimeWithOptionsAsync(request, runtime);
        }

        public ModifyReadWriteSplittingConnectionResponse ModifyReadWriteSplittingConnectionWithOptions(ModifyReadWriteSplittingConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ConnectionStringPrefix"] = request.ConnectionStringPrefix;
            query["Port"] = request.Port;
            query["MaxDelayTime"] = request.MaxDelayTime;
            query["DistributionType"] = request.DistributionType;
            query["Weight"] = request.Weight;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyReadWriteSplittingConnection",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyReadWriteSplittingConnectionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyReadWriteSplittingConnectionResponse> ModifyReadWriteSplittingConnectionWithOptionsAsync(ModifyReadWriteSplittingConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ConnectionStringPrefix"] = request.ConnectionStringPrefix;
            query["Port"] = request.Port;
            query["MaxDelayTime"] = request.MaxDelayTime;
            query["DistributionType"] = request.DistributionType;
            query["Weight"] = request.Weight;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyReadWriteSplittingConnection",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyReadWriteSplittingConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyReadWriteSplittingConnectionResponse ModifyReadWriteSplittingConnection(ModifyReadWriteSplittingConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyReadWriteSplittingConnectionWithOptions(request, runtime);
        }

        public async Task<ModifyReadWriteSplittingConnectionResponse> ModifyReadWriteSplittingConnectionAsync(ModifyReadWriteSplittingConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyReadWriteSplittingConnectionWithOptionsAsync(request, runtime);
        }

        public ModifyResourceGroupResponse ModifyResourceGroupWithOptions(ModifyResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyResourceGroup",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyResourceGroupResponse> ModifyResourceGroupWithOptionsAsync(ModifyResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyResourceGroup",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyResourceGroupResponse ModifyResourceGroup(ModifyResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyResourceGroupWithOptions(request, runtime);
        }

        public async Task<ModifyResourceGroupResponse> ModifyResourceGroupAsync(ModifyResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyResourceGroupWithOptionsAsync(request, runtime);
        }

        public ModifySecurityGroupConfigurationResponse ModifySecurityGroupConfigurationWithOptions(ModifySecurityGroupConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["SecurityGroupId"] = request.SecurityGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySecurityGroupConfiguration",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySecurityGroupConfigurationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifySecurityGroupConfigurationResponse> ModifySecurityGroupConfigurationWithOptionsAsync(ModifySecurityGroupConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["SecurityGroupId"] = request.SecurityGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySecurityGroupConfiguration",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySecurityGroupConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifySecurityGroupConfigurationResponse ModifySecurityGroupConfiguration(ModifySecurityGroupConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySecurityGroupConfigurationWithOptions(request, runtime);
        }

        public async Task<ModifySecurityGroupConfigurationResponse> ModifySecurityGroupConfigurationAsync(ModifySecurityGroupConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySecurityGroupConfigurationWithOptionsAsync(request, runtime);
        }

        public ModifySecurityIpsResponse ModifySecurityIpsWithOptions(ModifySecurityIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["SecurityIps"] = request.SecurityIps;
            query["DBInstanceIPArrayName"] = request.DBInstanceIPArrayName;
            query["DBInstanceIPArrayAttribute"] = request.DBInstanceIPArrayAttribute;
            query["SecurityIPType"] = request.SecurityIPType;
            query["WhitelistNetworkType"] = request.WhitelistNetworkType;
            query["ModifyMode"] = request.ModifyMode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySecurityIps",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySecurityIpsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifySecurityIpsResponse> ModifySecurityIpsWithOptionsAsync(ModifySecurityIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["SecurityIps"] = request.SecurityIps;
            query["DBInstanceIPArrayName"] = request.DBInstanceIPArrayName;
            query["DBInstanceIPArrayAttribute"] = request.DBInstanceIPArrayAttribute;
            query["SecurityIPType"] = request.SecurityIPType;
            query["WhitelistNetworkType"] = request.WhitelistNetworkType;
            query["ModifyMode"] = request.ModifyMode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySecurityIps",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySecurityIpsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifySecurityIpsResponse ModifySecurityIps(ModifySecurityIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySecurityIpsWithOptions(request, runtime);
        }

        public async Task<ModifySecurityIpsResponse> ModifySecurityIpsAsync(ModifySecurityIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySecurityIpsWithOptionsAsync(request, runtime);
        }

        public ModifySQLCollectorPolicyResponse ModifySQLCollectorPolicyWithOptions(ModifySQLCollectorPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["SQLCollectorStatus"] = request.SQLCollectorStatus;
            query["OwnerAccount"] = request.OwnerAccount;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySQLCollectorPolicy",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySQLCollectorPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifySQLCollectorPolicyResponse> ModifySQLCollectorPolicyWithOptionsAsync(ModifySQLCollectorPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["SQLCollectorStatus"] = request.SQLCollectorStatus;
            query["OwnerAccount"] = request.OwnerAccount;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySQLCollectorPolicy",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySQLCollectorPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifySQLCollectorPolicyResponse ModifySQLCollectorPolicy(ModifySQLCollectorPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySQLCollectorPolicyWithOptions(request, runtime);
        }

        public async Task<ModifySQLCollectorPolicyResponse> ModifySQLCollectorPolicyAsync(ModifySQLCollectorPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySQLCollectorPolicyWithOptionsAsync(request, runtime);
        }

        public ModifySQLCollectorRetentionResponse ModifySQLCollectorRetentionWithOptions(ModifySQLCollectorRetentionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ConfigValue"] = request.ConfigValue;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySQLCollectorRetention",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySQLCollectorRetentionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifySQLCollectorRetentionResponse> ModifySQLCollectorRetentionWithOptionsAsync(ModifySQLCollectorRetentionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ConfigValue"] = request.ConfigValue;
            query["ResourceGroupId"] = request.ResourceGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySQLCollectorRetention",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySQLCollectorRetentionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifySQLCollectorRetentionResponse ModifySQLCollectorRetention(ModifySQLCollectorRetentionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySQLCollectorRetentionWithOptions(request, runtime);
        }

        public async Task<ModifySQLCollectorRetentionResponse> ModifySQLCollectorRetentionAsync(ModifySQLCollectorRetentionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySQLCollectorRetentionWithOptionsAsync(request, runtime);
        }

        public PurgeDBInstanceLogResponse PurgeDBInstanceLogWithOptions(PurgeDBInstanceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PurgeDBInstanceLog",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PurgeDBInstanceLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PurgeDBInstanceLogResponse> PurgeDBInstanceLogWithOptionsAsync(PurgeDBInstanceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PurgeDBInstanceLog",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PurgeDBInstanceLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PurgeDBInstanceLogResponse PurgeDBInstanceLog(PurgeDBInstanceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PurgeDBInstanceLogWithOptions(request, runtime);
        }

        public async Task<PurgeDBInstanceLogResponse> PurgeDBInstanceLogAsync(PurgeDBInstanceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PurgeDBInstanceLogWithOptionsAsync(request, runtime);
        }

        public RebuildDBInstanceResponse RebuildDBInstanceWithOptions(RebuildDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["RebuildNodeType"] = request.RebuildNodeType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebuildDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebuildDBInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RebuildDBInstanceResponse> RebuildDBInstanceWithOptionsAsync(RebuildDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["RebuildNodeType"] = request.RebuildNodeType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebuildDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebuildDBInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RebuildDBInstanceResponse RebuildDBInstance(RebuildDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RebuildDBInstanceWithOptions(request, runtime);
        }

        public async Task<RebuildDBInstanceResponse> RebuildDBInstanceAsync(RebuildDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RebuildDBInstanceWithOptionsAsync(request, runtime);
        }

        public RecoveryDBInstanceResponse RecoveryDBInstanceWithOptions(RecoveryDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["DBInstanceStorage"] = request.DBInstanceStorage;
            query["PayType"] = request.PayType;
            query["InstanceNetworkType"] = request.InstanceNetworkType;
            query["DBInstanceId"] = request.DBInstanceId;
            query["TargetDBInstanceId"] = request.TargetDBInstanceId;
            query["DbNames"] = request.DbNames;
            query["BackupId"] = request.BackupId;
            query["RestoreTime"] = request.RestoreTime;
            query["VPCId"] = request.VPCId;
            query["VSwitchId"] = request.VSwitchId;
            query["PrivateIpAddress"] = request.PrivateIpAddress;
            query["UsedTime"] = request.UsedTime;
            query["Period"] = request.Period;
            query["DBInstanceStorageType"] = request.DBInstanceStorageType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecoveryDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecoveryDBInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecoveryDBInstanceResponse> RecoveryDBInstanceWithOptionsAsync(RecoveryDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceClass"] = request.DBInstanceClass;
            query["DBInstanceStorage"] = request.DBInstanceStorage;
            query["PayType"] = request.PayType;
            query["InstanceNetworkType"] = request.InstanceNetworkType;
            query["DBInstanceId"] = request.DBInstanceId;
            query["TargetDBInstanceId"] = request.TargetDBInstanceId;
            query["DbNames"] = request.DbNames;
            query["BackupId"] = request.BackupId;
            query["RestoreTime"] = request.RestoreTime;
            query["VPCId"] = request.VPCId;
            query["VSwitchId"] = request.VSwitchId;
            query["PrivateIpAddress"] = request.PrivateIpAddress;
            query["UsedTime"] = request.UsedTime;
            query["Period"] = request.Period;
            query["DBInstanceStorageType"] = request.DBInstanceStorageType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecoveryDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecoveryDBInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecoveryDBInstanceResponse RecoveryDBInstance(RecoveryDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecoveryDBInstanceWithOptions(request, runtime);
        }

        public async Task<RecoveryDBInstanceResponse> RecoveryDBInstanceAsync(RecoveryDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecoveryDBInstanceWithOptionsAsync(request, runtime);
        }

        public ReleaseInstanceConnectionResponse ReleaseInstanceConnectionWithOptions(ReleaseInstanceConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["CurrentConnectionString"] = request.CurrentConnectionString;
            query["InstanceNetworkType"] = request.InstanceNetworkType;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseInstanceConnection",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseInstanceConnectionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReleaseInstanceConnectionResponse> ReleaseInstanceConnectionWithOptionsAsync(ReleaseInstanceConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["CurrentConnectionString"] = request.CurrentConnectionString;
            query["InstanceNetworkType"] = request.InstanceNetworkType;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseInstanceConnection",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseInstanceConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReleaseInstanceConnectionResponse ReleaseInstanceConnection(ReleaseInstanceConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseInstanceConnectionWithOptions(request, runtime);
        }

        public async Task<ReleaseInstanceConnectionResponse> ReleaseInstanceConnectionAsync(ReleaseInstanceConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseInstanceConnectionWithOptionsAsync(request, runtime);
        }

        public ReleaseInstancePublicConnectionResponse ReleaseInstancePublicConnectionWithOptions(ReleaseInstancePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["CurrentConnectionString"] = request.CurrentConnectionString;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseInstancePublicConnection",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseInstancePublicConnectionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReleaseInstancePublicConnectionResponse> ReleaseInstancePublicConnectionWithOptionsAsync(ReleaseInstancePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["CurrentConnectionString"] = request.CurrentConnectionString;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseInstancePublicConnection",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseInstancePublicConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReleaseInstancePublicConnectionResponse ReleaseInstancePublicConnection(ReleaseInstancePublicConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseInstancePublicConnectionWithOptions(request, runtime);
        }

        public async Task<ReleaseInstancePublicConnectionResponse> ReleaseInstancePublicConnectionAsync(ReleaseInstancePublicConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseInstancePublicConnectionWithOptionsAsync(request, runtime);
        }

        public ReleaseReadWriteSplittingConnectionResponse ReleaseReadWriteSplittingConnectionWithOptions(ReleaseReadWriteSplittingConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseReadWriteSplittingConnection",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseReadWriteSplittingConnectionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReleaseReadWriteSplittingConnectionResponse> ReleaseReadWriteSplittingConnectionWithOptionsAsync(ReleaseReadWriteSplittingConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseReadWriteSplittingConnection",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseReadWriteSplittingConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReleaseReadWriteSplittingConnectionResponse ReleaseReadWriteSplittingConnection(ReleaseReadWriteSplittingConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseReadWriteSplittingConnectionWithOptions(request, runtime);
        }

        public async Task<ReleaseReadWriteSplittingConnectionResponse> ReleaseReadWriteSplittingConnectionAsync(ReleaseReadWriteSplittingConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseReadWriteSplittingConnectionWithOptionsAsync(request, runtime);
        }

        public RemoveTagsFromResourceResponse RemoveTagsFromResourceWithOptions(RemoveTagsFromResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["proxyId"] = request.ProxyId;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Tags"] = request.Tags;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveTagsFromResource",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTagsFromResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceWithOptionsAsync(RemoveTagsFromResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["proxyId"] = request.ProxyId;
            query["RegionId"] = request.RegionId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Tags"] = request.Tags;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveTagsFromResource",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTagsFromResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveTagsFromResourceWithOptions(request, runtime);
        }

        public async Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveTagsFromResourceWithOptionsAsync(request, runtime);
        }

        public RenewInstanceResponse RenewInstanceWithOptions(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Period"] = request.Period;
            query["AutoPay"] = request.AutoPay;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RenewInstanceResponse> RenewInstanceWithOptionsAsync(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["Period"] = request.Period;
            query["AutoPay"] = request.AutoPay;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RenewInstanceResponse RenewInstance(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewInstanceWithOptions(request, runtime);
        }

        public async Task<RenewInstanceResponse> RenewInstanceAsync(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewInstanceWithOptionsAsync(request, runtime);
        }

        public ReplaceDedicatedHostResponse ReplaceDedicatedHostWithOptions(ReplaceDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["FailoverMode"] = request.FailoverMode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplaceDedicatedHost",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplaceDedicatedHostResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReplaceDedicatedHostResponse> ReplaceDedicatedHostWithOptionsAsync(ReplaceDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["FailoverMode"] = request.FailoverMode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplaceDedicatedHost",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplaceDedicatedHostResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReplaceDedicatedHostResponse ReplaceDedicatedHost(ReplaceDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReplaceDedicatedHostWithOptions(request, runtime);
        }

        public async Task<ReplaceDedicatedHostResponse> ReplaceDedicatedHostAsync(ReplaceDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReplaceDedicatedHostWithOptionsAsync(request, runtime);
        }

        public ResetAccountResponse ResetAccountWithOptions(ResetAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AccountName"] = request.AccountName;
            query["AccountPassword"] = request.AccountPassword;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetAccount",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ResetAccountResponse> ResetAccountWithOptionsAsync(ResetAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AccountName"] = request.AccountName;
            query["AccountPassword"] = request.AccountPassword;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetAccount",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ResetAccountResponse ResetAccount(ResetAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetAccountWithOptions(request, runtime);
        }

        public async Task<ResetAccountResponse> ResetAccountAsync(ResetAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetAccountWithOptionsAsync(request, runtime);
        }

        public ResetAccountPasswordResponse ResetAccountPasswordWithOptions(ResetAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AccountName"] = request.AccountName;
            query["AccountPassword"] = request.AccountPassword;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetAccountPassword",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetAccountPasswordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ResetAccountPasswordResponse> ResetAccountPasswordWithOptionsAsync(ResetAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AccountName"] = request.AccountName;
            query["AccountPassword"] = request.AccountPassword;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetAccountPassword",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetAccountPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ResetAccountPasswordResponse ResetAccountPassword(ResetAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetAccountPasswordWithOptions(request, runtime);
        }

        public async Task<ResetAccountPasswordResponse> ResetAccountPasswordAsync(ResetAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetAccountPasswordWithOptionsAsync(request, runtime);
        }

        public RestartDBInstanceResponse RestartDBInstanceWithOptions(RestartDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartDBInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RestartDBInstanceResponse> RestartDBInstanceWithOptionsAsync(RestartDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartDBInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RestartDBInstanceResponse RestartDBInstance(RestartDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartDBInstanceWithOptions(request, runtime);
        }

        public async Task<RestartDBInstanceResponse> RestartDBInstanceAsync(RestartDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartDBInstanceWithOptionsAsync(request, runtime);
        }

        public RestartDedicatedHostResponse RestartDedicatedHostWithOptions(RestartDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["FailoverMode"] = request.FailoverMode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartDedicatedHost",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartDedicatedHostResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RestartDedicatedHostResponse> RestartDedicatedHostWithOptionsAsync(RestartDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostId"] = request.DedicatedHostId;
            query["FailoverMode"] = request.FailoverMode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartDedicatedHost",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartDedicatedHostResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RestartDedicatedHostResponse RestartDedicatedHost(RestartDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartDedicatedHostWithOptions(request, runtime);
        }

        public async Task<RestartDedicatedHostResponse> RestartDedicatedHostAsync(RestartDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartDedicatedHostWithOptionsAsync(request, runtime);
        }

        public RestoreDdrTableResponse RestoreDdrTableWithOptions(RestoreDdrTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            query["ClientToken"] = request.ClientToken;
            query["RestoreType"] = request.RestoreType;
            query["BackupId"] = request.BackupId;
            query["RestoreTime"] = request.RestoreTime;
            query["SourceRegion"] = request.SourceRegion;
            query["SourceDBInstanceName"] = request.SourceDBInstanceName;
            query["TableMeta"] = request.TableMeta;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestoreDdrTable",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreDdrTableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RestoreDdrTableResponse> RestoreDdrTableWithOptionsAsync(RestoreDdrTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            query["ClientToken"] = request.ClientToken;
            query["RestoreType"] = request.RestoreType;
            query["BackupId"] = request.BackupId;
            query["RestoreTime"] = request.RestoreTime;
            query["SourceRegion"] = request.SourceRegion;
            query["SourceDBInstanceName"] = request.SourceDBInstanceName;
            query["TableMeta"] = request.TableMeta;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestoreDdrTable",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreDdrTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RestoreDdrTableResponse RestoreDdrTable(RestoreDdrTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestoreDdrTableWithOptions(request, runtime);
        }

        public async Task<RestoreDdrTableResponse> RestoreDdrTableAsync(RestoreDdrTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestoreDdrTableWithOptionsAsync(request, runtime);
        }

        public RestoreTableResponse RestoreTableWithOptions(RestoreTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["BackupId"] = request.BackupId;
            query["RestoreTime"] = request.RestoreTime;
            query["OwnerAccount"] = request.OwnerAccount;
            query["TableMeta"] = request.TableMeta;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestoreTable",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreTableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RestoreTableResponse> RestoreTableWithOptionsAsync(RestoreTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["BackupId"] = request.BackupId;
            query["RestoreTime"] = request.RestoreTime;
            query["OwnerAccount"] = request.OwnerAccount;
            query["TableMeta"] = request.TableMeta;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestoreTable",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RestoreTableResponse RestoreTable(RestoreTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestoreTableWithOptions(request, runtime);
        }

        public async Task<RestoreTableResponse> RestoreTableAsync(RestoreTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestoreTableWithOptionsAsync(request, runtime);
        }

        public RevokeAccountPrivilegeResponse RevokeAccountPrivilegeWithOptions(RevokeAccountPrivilegeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AccountName"] = request.AccountName;
            query["DBName"] = request.DBName;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeAccountPrivilege",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeAccountPrivilegeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RevokeAccountPrivilegeResponse> RevokeAccountPrivilegeWithOptionsAsync(RevokeAccountPrivilegeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AccountName"] = request.AccountName;
            query["DBName"] = request.DBName;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeAccountPrivilege",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeAccountPrivilegeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RevokeAccountPrivilegeResponse RevokeAccountPrivilege(RevokeAccountPrivilegeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeAccountPrivilegeWithOptions(request, runtime);
        }

        public async Task<RevokeAccountPrivilegeResponse> RevokeAccountPrivilegeAsync(RevokeAccountPrivilegeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeAccountPrivilegeWithOptionsAsync(request, runtime);
        }

        public RevokeOperatorPermissionResponse RevokeOperatorPermissionWithOptions(RevokeOperatorPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeOperatorPermission",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeOperatorPermissionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RevokeOperatorPermissionResponse> RevokeOperatorPermissionWithOptionsAsync(RevokeOperatorPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeOperatorPermission",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeOperatorPermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RevokeOperatorPermissionResponse RevokeOperatorPermission(RevokeOperatorPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeOperatorPermissionWithOptions(request, runtime);
        }

        public async Task<RevokeOperatorPermissionResponse> RevokeOperatorPermissionAsync(RevokeOperatorPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeOperatorPermissionWithOptionsAsync(request, runtime);
        }

        public StartDBInstanceResponse StartDBInstanceWithOptions(StartDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["TargetDedicatedHostIdForMaster"] = request.TargetDedicatedHostIdForMaster;
            query["TargetDedicatedHostIdForSlave"] = request.TargetDedicatedHostIdForSlave;
            query["TargetDedicatedHostIdForLog"] = request.TargetDedicatedHostIdForLog;
            query["EffectiveTime"] = request.EffectiveTime;
            query["SpecifiedTime"] = request.SpecifiedTime;
            query["TargetDBInstanceClass"] = request.TargetDBInstanceClass;
            query["EngineVersion"] = request.EngineVersion;
            query["DBInstanceTransType"] = request.DBInstanceTransType;
            query["Storage"] = request.Storage;
            query["VSwitchId"] = request.VSwitchId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDBInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartDBInstanceResponse> StartDBInstanceWithOptionsAsync(StartDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["DedicatedHostGroupId"] = request.DedicatedHostGroupId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["TargetDedicatedHostIdForMaster"] = request.TargetDedicatedHostIdForMaster;
            query["TargetDedicatedHostIdForSlave"] = request.TargetDedicatedHostIdForSlave;
            query["TargetDedicatedHostIdForLog"] = request.TargetDedicatedHostIdForLog;
            query["EffectiveTime"] = request.EffectiveTime;
            query["SpecifiedTime"] = request.SpecifiedTime;
            query["TargetDBInstanceClass"] = request.TargetDBInstanceClass;
            query["EngineVersion"] = request.EngineVersion;
            query["DBInstanceTransType"] = request.DBInstanceTransType;
            query["Storage"] = request.Storage;
            query["VSwitchId"] = request.VSwitchId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDBInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartDBInstanceResponse StartDBInstance(StartDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDBInstanceWithOptions(request, runtime);
        }

        public async Task<StartDBInstanceResponse> StartDBInstanceAsync(StartDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDBInstanceWithOptionsAsync(request, runtime);
        }

        public StopDBInstanceResponse StopDBInstanceWithOptions(StopDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDBInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopDBInstanceResponse> StopDBInstanceWithOptionsAsync(StopDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDBInstance",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDBInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopDBInstanceResponse StopDBInstance(StopDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDBInstanceWithOptions(request, runtime);
        }

        public async Task<StopDBInstanceResponse> StopDBInstanceAsync(StopDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDBInstanceWithOptionsAsync(request, runtime);
        }

        public SwitchDBInstanceHAResponse SwitchDBInstanceHAWithOptions(SwitchDBInstanceHARequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["NodeId"] = request.NodeId;
            query["Force"] = request.Force;
            query["OwnerAccount"] = request.OwnerAccount;
            query["EffectiveTime"] = request.EffectiveTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchDBInstanceHA",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchDBInstanceHAResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SwitchDBInstanceHAResponse> SwitchDBInstanceHAWithOptionsAsync(SwitchDBInstanceHARequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["NodeId"] = request.NodeId;
            query["Force"] = request.Force;
            query["OwnerAccount"] = request.OwnerAccount;
            query["EffectiveTime"] = request.EffectiveTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchDBInstanceHA",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchDBInstanceHAResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SwitchDBInstanceHAResponse SwitchDBInstanceHA(SwitchDBInstanceHARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchDBInstanceHAWithOptions(request, runtime);
        }

        public async Task<SwitchDBInstanceHAResponse> SwitchDBInstanceHAAsync(SwitchDBInstanceHARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchDBInstanceHAWithOptionsAsync(request, runtime);
        }

        public SwitchDBInstanceNetTypeResponse SwitchDBInstanceNetTypeWithOptions(SwitchDBInstanceNetTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ConnectionStringPrefix"] = request.ConnectionStringPrefix;
            query["Port"] = request.Port;
            query["ConnectionStringType"] = request.ConnectionStringType;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchDBInstanceNetType",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchDBInstanceNetTypeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SwitchDBInstanceNetTypeResponse> SwitchDBInstanceNetTypeWithOptionsAsync(SwitchDBInstanceNetTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["ConnectionStringPrefix"] = request.ConnectionStringPrefix;
            query["Port"] = request.Port;
            query["ConnectionStringType"] = request.ConnectionStringType;
            query["OwnerAccount"] = request.OwnerAccount;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchDBInstanceNetType",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchDBInstanceNetTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SwitchDBInstanceNetTypeResponse SwitchDBInstanceNetType(SwitchDBInstanceNetTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchDBInstanceNetTypeWithOptions(request, runtime);
        }

        public async Task<SwitchDBInstanceNetTypeResponse> SwitchDBInstanceNetTypeAsync(SwitchDBInstanceNetTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchDBInstanceNetTypeWithOptionsAsync(request, runtime);
        }

        public SwitchDBInstanceVpcResponse SwitchDBInstanceVpcWithOptions(SwitchDBInstanceVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["VPCId"] = request.VPCId;
            query["VSwitchId"] = request.VSwitchId;
            query["PrivateIpAddress"] = request.PrivateIpAddress;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchDBInstanceVpc",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchDBInstanceVpcResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SwitchDBInstanceVpcResponse> SwitchDBInstanceVpcWithOptionsAsync(SwitchDBInstanceVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["VPCId"] = request.VPCId;
            query["VSwitchId"] = request.VSwitchId;
            query["PrivateIpAddress"] = request.PrivateIpAddress;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchDBInstanceVpc",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchDBInstanceVpcResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SwitchDBInstanceVpcResponse SwitchDBInstanceVpc(SwitchDBInstanceVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchDBInstanceVpcWithOptions(request, runtime);
        }

        public async Task<SwitchDBInstanceVpcResponse> SwitchDBInstanceVpcAsync(SwitchDBInstanceVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchDBInstanceVpcWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceType"] = request.ResourceType;
            query["ResourceId"] = request.ResourceId;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2014-08-15",
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
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceType"] = request.ResourceType;
            query["ResourceId"] = request.ResourceId;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2014-08-15",
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

        public TerminateMigrateTaskResponse TerminateMigrateTaskWithOptions(TerminateMigrateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["MigrateTaskId"] = request.MigrateTaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TerminateMigrateTask",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TerminateMigrateTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TerminateMigrateTaskResponse> TerminateMigrateTaskWithOptionsAsync(TerminateMigrateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["MigrateTaskId"] = request.MigrateTaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TerminateMigrateTask",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TerminateMigrateTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TerminateMigrateTaskResponse TerminateMigrateTask(TerminateMigrateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TerminateMigrateTaskWithOptions(request, runtime);
        }

        public async Task<TerminateMigrateTaskResponse> TerminateMigrateTaskAsync(TerminateMigrateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TerminateMigrateTaskWithOptionsAsync(request, runtime);
        }

        public TransformDBInstancePayTypeResponse TransformDBInstancePayTypeWithOptions(TransformDBInstancePayTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["UsedTime"] = request.UsedTime;
            query["PayType"] = request.PayType;
            query["Period"] = request.Period;
            query["BusinessInfo"] = request.BusinessInfo;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransformDBInstancePayType",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransformDBInstancePayTypeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TransformDBInstancePayTypeResponse> TransformDBInstancePayTypeWithOptionsAsync(TransformDBInstancePayTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["DBInstanceId"] = request.DBInstanceId;
            query["UsedTime"] = request.UsedTime;
            query["PayType"] = request.PayType;
            query["Period"] = request.Period;
            query["BusinessInfo"] = request.BusinessInfo;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransformDBInstancePayType",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransformDBInstancePayTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TransformDBInstancePayTypeResponse TransformDBInstancePayType(TransformDBInstancePayTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransformDBInstancePayTypeWithOptions(request, runtime);
        }

        public async Task<TransformDBInstancePayTypeResponse> TransformDBInstancePayTypeAsync(TransformDBInstancePayTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransformDBInstancePayTypeWithOptionsAsync(request, runtime);
        }

        public UnlockAccountResponse UnlockAccountWithOptions(UnlockAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AccountName"] = request.AccountName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnlockAccount",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnlockAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnlockAccountResponse> UnlockAccountWithOptionsAsync(UnlockAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["AccountName"] = request.AccountName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnlockAccount",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnlockAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnlockAccountResponse UnlockAccount(UnlockAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnlockAccountWithOptions(request, runtime);
        }

        public async Task<UnlockAccountResponse> UnlockAccountAsync(UnlockAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnlockAccountWithOptionsAsync(request, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceType"] = request.ResourceType;
            query["All"] = request.All;
            query["ResourceId"] = request.ResourceId;
            query["TagKey"] = request.TagKey;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2014-08-15",
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
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceType"] = request.ResourceType;
            query["All"] = request.All;
            query["ResourceId"] = request.ResourceId;
            query["TagKey"] = request.TagKey;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2014-08-15",
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

        public UpdateUserBackupFileResponse UpdateUserBackupFileWithOptions(UpdateUserBackupFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["BackupId"] = request.BackupId;
            query["RegionId"] = request.RegionId;
            query["Comment"] = request.Comment;
            query["Retention"] = request.Retention;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserBackupFile",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserBackupFileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateUserBackupFileResponse> UpdateUserBackupFileWithOptionsAsync(UpdateUserBackupFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["BackupId"] = request.BackupId;
            query["RegionId"] = request.RegionId;
            query["Comment"] = request.Comment;
            query["Retention"] = request.Retention;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserBackupFile",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserBackupFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateUserBackupFileResponse UpdateUserBackupFile(UpdateUserBackupFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserBackupFileWithOptions(request, runtime);
        }

        public async Task<UpdateUserBackupFileResponse> UpdateUserBackupFileAsync(UpdateUserBackupFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserBackupFileWithOptionsAsync(request, runtime);
        }

        public UpgradeDBInstanceEngineVersionResponse UpgradeDBInstanceEngineVersionWithOptions(UpgradeDBInstanceEngineVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["EngineVersion"] = request.EngineVersion;
            query["OwnerAccount"] = request.OwnerAccount;
            query["EffectiveTime"] = request.EffectiveTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeDBInstanceEngineVersion",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeDBInstanceEngineVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpgradeDBInstanceEngineVersionResponse> UpgradeDBInstanceEngineVersionWithOptionsAsync(UpgradeDBInstanceEngineVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ClientToken"] = request.ClientToken;
            query["DBInstanceId"] = request.DBInstanceId;
            query["EngineVersion"] = request.EngineVersion;
            query["OwnerAccount"] = request.OwnerAccount;
            query["EffectiveTime"] = request.EffectiveTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeDBInstanceEngineVersion",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeDBInstanceEngineVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpgradeDBInstanceEngineVersionResponse UpgradeDBInstanceEngineVersion(UpgradeDBInstanceEngineVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeDBInstanceEngineVersionWithOptions(request, runtime);
        }

        public async Task<UpgradeDBInstanceEngineVersionResponse> UpgradeDBInstanceEngineVersionAsync(UpgradeDBInstanceEngineVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeDBInstanceEngineVersionWithOptionsAsync(request, runtime);
        }

        public UpgradeDBInstanceKernelVersionResponse UpgradeDBInstanceKernelVersionWithOptions(UpgradeDBInstanceKernelVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["UpgradeTime"] = request.UpgradeTime;
            query["SwitchTime"] = request.SwitchTime;
            query["TargetMinorVersion"] = request.TargetMinorVersion;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeDBInstanceKernelVersion",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeDBInstanceKernelVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpgradeDBInstanceKernelVersionResponse> UpgradeDBInstanceKernelVersionWithOptionsAsync(UpgradeDBInstanceKernelVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["UpgradeTime"] = request.UpgradeTime;
            query["SwitchTime"] = request.SwitchTime;
            query["TargetMinorVersion"] = request.TargetMinorVersion;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeDBInstanceKernelVersion",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeDBInstanceKernelVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpgradeDBInstanceKernelVersionResponse UpgradeDBInstanceKernelVersion(UpgradeDBInstanceKernelVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeDBInstanceKernelVersionWithOptions(request, runtime);
        }

        public async Task<UpgradeDBInstanceKernelVersionResponse> UpgradeDBInstanceKernelVersionAsync(UpgradeDBInstanceKernelVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeDBInstanceKernelVersionWithOptionsAsync(request, runtime);
        }

        public UpgradeDBProxyInstanceKernelVersionResponse UpgradeDBProxyInstanceKernelVersionWithOptions(UpgradeDBProxyInstanceKernelVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["UpgradeTime"] = request.UpgradeTime;
            query["SwitchTime"] = request.SwitchTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeDBProxyInstanceKernelVersion",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeDBProxyInstanceKernelVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpgradeDBProxyInstanceKernelVersionResponse> UpgradeDBProxyInstanceKernelVersionWithOptionsAsync(UpgradeDBProxyInstanceKernelVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["DBInstanceId"] = request.DBInstanceId;
            query["UpgradeTime"] = request.UpgradeTime;
            query["SwitchTime"] = request.SwitchTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeDBProxyInstanceKernelVersion",
                Version = "2014-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeDBProxyInstanceKernelVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpgradeDBProxyInstanceKernelVersionResponse UpgradeDBProxyInstanceKernelVersion(UpgradeDBProxyInstanceKernelVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeDBProxyInstanceKernelVersionWithOptions(request, runtime);
        }

        public async Task<UpgradeDBProxyInstanceKernelVersionResponse> UpgradeDBProxyInstanceKernelVersionAsync(UpgradeDBProxyInstanceKernelVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeDBProxyInstanceKernelVersionWithOptionsAsync(request, runtime);
        }

    }
}
