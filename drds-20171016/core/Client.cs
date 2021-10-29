// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Drds20171016.Models;

namespace AlibabaCloud.SDK.Drds20171016
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "drds.ap-southeast-1.aliyuncs.com"},
                {"ap-northeast-2-pop", "drds.ap-southeast-1.aliyuncs.com"},
                {"ap-south-1", "drds.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "drds.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-3", "drds.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "drds.ap-southeast-1.aliyuncs.com"},
                {"cn-beijing-finance-1", "drds.aliyuncs.com"},
                {"cn-beijing-finance-pop", "drds.aliyuncs.com"},
                {"cn-beijing-gov-1", "drds.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "drds.aliyuncs.com"},
                {"cn-chengdu", "drds.aliyuncs.com"},
                {"cn-edge-1", "drds.aliyuncs.com"},
                {"cn-fujian", "drds.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "drds.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "drds.aliyuncs.com"},
                {"cn-hangzhou-finance", "drds.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "drds.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "drds.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "drds.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "drds.aliyuncs.com"},
                {"cn-hangzhou-test-306", "drds.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "drds.aliyuncs.com"},
                {"cn-qingdao-nebula", "drds.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "drds.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "drds.aliyuncs.com"},
                {"cn-shanghai-inner", "drds.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "drds.aliyuncs.com"},
                {"cn-shenzhen-inner", "drds.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "drds.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "drds.aliyuncs.com"},
                {"cn-wuhan", "drds.aliyuncs.com"},
                {"cn-yushanfang", "drds.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "drds.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "drds.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "drds.aliyuncs.com"},
                {"eu-central-1", "drds.ap-southeast-1.aliyuncs.com"},
                {"eu-west-1", "drds.ap-southeast-1.aliyuncs.com"},
                {"eu-west-1-oxs", "drds.ap-southeast-1.aliyuncs.com"},
                {"me-east-1", "drds.ap-southeast-1.aliyuncs.com"},
                {"rus-west-1-pop", "drds.ap-southeast-1.aliyuncs.com"},
                {"us-west-1", "drds.ap-southeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("drds", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateDrdsAccountResponse CreateDrdsAccountWithOptions(CreateDrdsAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["Password"] = request.Password;
            query["UserName"] = request.UserName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDrdsAccount",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDrdsAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDrdsAccountResponse> CreateDrdsAccountWithOptionsAsync(CreateDrdsAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["Password"] = request.Password;
            query["UserName"] = request.UserName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDrdsAccount",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDrdsAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDrdsAccountResponse CreateDrdsAccount(CreateDrdsAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDrdsAccountWithOptions(request, runtime);
        }

        public async Task<CreateDrdsAccountResponse> CreateDrdsAccountAsync(CreateDrdsAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDrdsAccountWithOptionsAsync(request, runtime);
        }

        public CreateDrdsDBResponse CreateDrdsDBWithOptions(CreateDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["Encode"] = request.Encode;
            query["Password"] = request.Password;
            query["RdsInstances"] = request.RdsInstances;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDrdsDB",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDrdsDBResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDrdsDBResponse> CreateDrdsDBWithOptionsAsync(CreateDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["Encode"] = request.Encode;
            query["Password"] = request.Password;
            query["RdsInstances"] = request.RdsInstances;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDrdsDB",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDrdsDBResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDrdsDBResponse CreateDrdsDB(CreateDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDrdsDBWithOptions(request, runtime);
        }

        public async Task<CreateDrdsDBResponse> CreateDrdsDBAsync(CreateDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDrdsDBWithOptionsAsync(request, runtime);
        }

        public CreateDrdsInstanceResponse CreateDrdsInstanceWithOptions(CreateDrdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["Duration"] = request.Duration;
            query["InstanceSeries"] = request.InstanceSeries;
            query["IsAutoRenew"] = request.IsAutoRenew;
            query["IsHa"] = request.IsHa;
            query["PayType"] = request.PayType;
            query["PricingCycle"] = request.PricingCycle;
            query["Quantity"] = request.Quantity;
            query["RegionId"] = request.RegionId;
            query["Specification"] = request.Specification;
            query["Type"] = request.Type;
            query["VpcId"] = request.VpcId;
            query["VswitchId"] = request.VswitchId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDrdsInstance",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDrdsInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDrdsInstanceResponse> CreateDrdsInstanceWithOptionsAsync(CreateDrdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["Duration"] = request.Duration;
            query["InstanceSeries"] = request.InstanceSeries;
            query["IsAutoRenew"] = request.IsAutoRenew;
            query["IsHa"] = request.IsHa;
            query["PayType"] = request.PayType;
            query["PricingCycle"] = request.PricingCycle;
            query["Quantity"] = request.Quantity;
            query["RegionId"] = request.RegionId;
            query["Specification"] = request.Specification;
            query["Type"] = request.Type;
            query["VpcId"] = request.VpcId;
            query["VswitchId"] = request.VswitchId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDrdsInstance",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDrdsInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDrdsInstanceResponse CreateDrdsInstance(CreateDrdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDrdsInstanceWithOptions(request, runtime);
        }

        public async Task<CreateDrdsInstanceResponse> CreateDrdsInstanceAsync(CreateDrdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDrdsInstanceWithOptionsAsync(request, runtime);
        }

        public CreateReadOnlyAccountResponse CreateReadOnlyAccountWithOptions(CreateReadOnlyAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["password"] = request.Password;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateReadOnlyAccount",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateReadOnlyAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateReadOnlyAccountResponse> CreateReadOnlyAccountWithOptionsAsync(CreateReadOnlyAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["password"] = request.Password;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateReadOnlyAccount",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateReadOnlyAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateReadOnlyAccountResponse CreateReadOnlyAccount(CreateReadOnlyAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateReadOnlyAccountWithOptions(request, runtime);
        }

        public async Task<CreateReadOnlyAccountResponse> CreateReadOnlyAccountAsync(CreateReadOnlyAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateReadOnlyAccountWithOptionsAsync(request, runtime);
        }

        public DeleteDrdsDBResponse DeleteDrdsDBWithOptions(DeleteDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDrdsDB",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDrdsDBResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDrdsDBResponse> DeleteDrdsDBWithOptionsAsync(DeleteDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDrdsDB",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDrdsDBResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDrdsDBResponse DeleteDrdsDB(DeleteDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDrdsDBWithOptions(request, runtime);
        }

        public async Task<DeleteDrdsDBResponse> DeleteDrdsDBAsync(DeleteDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDrdsDBWithOptionsAsync(request, runtime);
        }

        public DeleteFailedDrdsDBResponse DeleteFailedDrdsDBWithOptions(DeleteFailedDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFailedDrdsDB",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFailedDrdsDBResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFailedDrdsDBResponse> DeleteFailedDrdsDBWithOptionsAsync(DeleteFailedDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFailedDrdsDB",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFailedDrdsDBResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFailedDrdsDBResponse DeleteFailedDrdsDB(DeleteFailedDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFailedDrdsDBWithOptions(request, runtime);
        }

        public async Task<DeleteFailedDrdsDBResponse> DeleteFailedDrdsDBAsync(DeleteFailedDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFailedDrdsDBWithOptionsAsync(request, runtime);
        }

        public DescribeCreateDrdsInstanceStatusResponse DescribeCreateDrdsInstanceStatusWithOptions(DescribeCreateDrdsInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCreateDrdsInstanceStatus",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCreateDrdsInstanceStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCreateDrdsInstanceStatusResponse> DescribeCreateDrdsInstanceStatusWithOptionsAsync(DescribeCreateDrdsInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCreateDrdsInstanceStatus",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCreateDrdsInstanceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCreateDrdsInstanceStatusResponse DescribeCreateDrdsInstanceStatus(DescribeCreateDrdsInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCreateDrdsInstanceStatusWithOptions(request, runtime);
        }

        public async Task<DescribeCreateDrdsInstanceStatusResponse> DescribeCreateDrdsInstanceStatusAsync(DescribeCreateDrdsInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCreateDrdsInstanceStatusWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsDBResponse DescribeDrdsDBWithOptions(DescribeDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsDB",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDBResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDrdsDBResponse> DescribeDrdsDBWithOptionsAsync(DescribeDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsDB",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDBResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDrdsDBResponse DescribeDrdsDB(DescribeDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsDBWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsDBResponse> DescribeDrdsDBAsync(DescribeDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsDBWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsDBIpWhiteListResponse DescribeDrdsDBIpWhiteListWithOptions(DescribeDrdsDBIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["GroupName"] = request.GroupName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsDBIpWhiteList",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDBIpWhiteListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDrdsDBIpWhiteListResponse> DescribeDrdsDBIpWhiteListWithOptionsAsync(DescribeDrdsDBIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["GroupName"] = request.GroupName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsDBIpWhiteList",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDBIpWhiteListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDrdsDBIpWhiteListResponse DescribeDrdsDBIpWhiteList(DescribeDrdsDBIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsDBIpWhiteListWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsDBIpWhiteListResponse> DescribeDrdsDBIpWhiteListAsync(DescribeDrdsDBIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsDBIpWhiteListWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsDBsResponse DescribeDrdsDBsWithOptions(DescribeDrdsDBsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsDBs",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDBsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDrdsDBsResponse> DescribeDrdsDBsWithOptionsAsync(DescribeDrdsDBsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsDBs",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDBsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDrdsDBsResponse DescribeDrdsDBs(DescribeDrdsDBsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsDBsWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsDBsResponse> DescribeDrdsDBsAsync(DescribeDrdsDBsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsDBsWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsInstanceResponse DescribeDrdsInstanceWithOptions(DescribeDrdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsInstance",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDrdsInstanceResponse> DescribeDrdsInstanceWithOptionsAsync(DescribeDrdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsInstance",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDrdsInstanceResponse DescribeDrdsInstance(DescribeDrdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsInstanceResponse> DescribeDrdsInstanceAsync(DescribeDrdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsInstanceDbMonitorResponse DescribeDrdsInstanceDbMonitorWithOptions(DescribeDrdsInstanceDbMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["EndTime"] = request.EndTime;
            query["Key"] = request.Key;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsInstanceDbMonitor",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstanceDbMonitorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDrdsInstanceDbMonitorResponse> DescribeDrdsInstanceDbMonitorWithOptionsAsync(DescribeDrdsInstanceDbMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["EndTime"] = request.EndTime;
            query["Key"] = request.Key;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsInstanceDbMonitor",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstanceDbMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDrdsInstanceDbMonitorResponse DescribeDrdsInstanceDbMonitor(DescribeDrdsInstanceDbMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsInstanceDbMonitorWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsInstanceDbMonitorResponse> DescribeDrdsInstanceDbMonitorAsync(DescribeDrdsInstanceDbMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsInstanceDbMonitorWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsInstanceMonitorResponse DescribeDrdsInstanceMonitorWithOptions(DescribeDrdsInstanceMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["EndTime"] = request.EndTime;
            query["Key"] = request.Key;
            query["PeriodMultiple"] = request.PeriodMultiple;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsInstanceMonitor",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstanceMonitorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDrdsInstanceMonitorResponse> DescribeDrdsInstanceMonitorWithOptionsAsync(DescribeDrdsInstanceMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["EndTime"] = request.EndTime;
            query["Key"] = request.Key;
            query["PeriodMultiple"] = request.PeriodMultiple;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsInstanceMonitor",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstanceMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDrdsInstanceMonitorResponse DescribeDrdsInstanceMonitor(DescribeDrdsInstanceMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsInstanceMonitorWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsInstanceMonitorResponse> DescribeDrdsInstanceMonitorAsync(DescribeDrdsInstanceMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsInstanceMonitorWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsInstanceNetInfoForInnerResponse DescribeDrdsInstanceNetInfoForInnerWithOptions(DescribeDrdsInstanceNetInfoForInnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsInstanceNetInfoForInner",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstanceNetInfoForInnerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDrdsInstanceNetInfoForInnerResponse> DescribeDrdsInstanceNetInfoForInnerWithOptionsAsync(DescribeDrdsInstanceNetInfoForInnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsInstanceNetInfoForInner",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstanceNetInfoForInnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDrdsInstanceNetInfoForInnerResponse DescribeDrdsInstanceNetInfoForInner(DescribeDrdsInstanceNetInfoForInnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsInstanceNetInfoForInnerWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsInstanceNetInfoForInnerResponse> DescribeDrdsInstanceNetInfoForInnerAsync(DescribeDrdsInstanceNetInfoForInnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsInstanceNetInfoForInnerWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsInstancesResponse DescribeDrdsInstancesWithOptions(DescribeDrdsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["Tags"] = request.Tags;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsInstances",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDrdsInstancesResponse> DescribeDrdsInstancesWithOptionsAsync(DescribeDrdsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["Tags"] = request.Tags;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsInstances",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDrdsInstancesResponse DescribeDrdsInstances(DescribeDrdsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsInstancesResponse> DescribeDrdsInstancesAsync(DescribeDrdsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeRdsListResponse DescribeRdsListWithOptions(DescribeRdsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRdsList",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRdsListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRdsListResponse> DescribeRdsListWithOptionsAsync(DescribeRdsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRdsList",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRdsListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRdsListResponse DescribeRdsList(DescribeRdsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRdsListWithOptions(request, runtime);
        }

        public async Task<DescribeRdsListResponse> DescribeRdsListAsync(DescribeRdsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRdsListWithOptionsAsync(request, runtime);
        }

        public DescribeReadOnlyAccountResponse DescribeReadOnlyAccountWithOptions(DescribeReadOnlyAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeReadOnlyAccount",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeReadOnlyAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeReadOnlyAccountResponse> DescribeReadOnlyAccountWithOptionsAsync(DescribeReadOnlyAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeReadOnlyAccount",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeReadOnlyAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeReadOnlyAccountResponse DescribeReadOnlyAccount(DescribeReadOnlyAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeReadOnlyAccountWithOptions(request, runtime);
        }

        public async Task<DescribeReadOnlyAccountResponse> DescribeReadOnlyAccountAsync(DescribeReadOnlyAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeReadOnlyAccountWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2017-10-16",
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

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2017-10-16",
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

        public DescribeRegionsResponse DescribeRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(runtime);
        }

        public DescribeShardDBsResponse DescribeShardDBsWithOptions(DescribeShardDBsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeShardDBs",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeShardDBsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeShardDBsResponse> DescribeShardDBsWithOptionsAsync(DescribeShardDBsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeShardDBs",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeShardDBsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeShardDBsResponse DescribeShardDBs(DescribeShardDBsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeShardDBsWithOptions(request, runtime);
        }

        public async Task<DescribeShardDBsResponse> DescribeShardDBsAsync(DescribeShardDBsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeShardDBsWithOptionsAsync(request, runtime);
        }

        public DescribeShardDbConnectionInfoResponse DescribeShardDbConnectionInfoWithOptions(DescribeShardDbConnectionInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["SubDbName"] = request.SubDbName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeShardDbConnectionInfo",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeShardDbConnectionInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeShardDbConnectionInfoResponse> DescribeShardDbConnectionInfoWithOptionsAsync(DescribeShardDbConnectionInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["SubDbName"] = request.SubDbName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeShardDbConnectionInfo",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeShardDbConnectionInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeShardDbConnectionInfoResponse DescribeShardDbConnectionInfo(DescribeShardDbConnectionInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeShardDbConnectionInfoWithOptions(request, runtime);
        }

        public async Task<DescribeShardDbConnectionInfoResponse> DescribeShardDbConnectionInfoAsync(DescribeShardDbConnectionInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeShardDbConnectionInfoWithOptionsAsync(request, runtime);
        }

        public EnableInstanceResponse EnableInstanceWithOptions(EnableInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackupId"] = request.BackupId;
            query["ClientToken"] = request.ClientToken;
            query["DbInstanceClass"] = request.DbInstanceClass;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["EngineVersion"] = request.EngineVersion;
            query["RestoreTime"] = request.RestoreTime;
            query["SourceDbInstId"] = request.SourceDbInstId;
            query["SwitchId"] = request.SwitchId;
            query["VpcId"] = request.VpcId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableInstance",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableInstanceResponse> EnableInstanceWithOptionsAsync(EnableInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackupId"] = request.BackupId;
            query["ClientToken"] = request.ClientToken;
            query["DbInstanceClass"] = request.DbInstanceClass;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["EngineVersion"] = request.EngineVersion;
            query["RestoreTime"] = request.RestoreTime;
            query["SourceDbInstId"] = request.SourceDbInstId;
            query["SwitchId"] = request.SwitchId;
            query["VpcId"] = request.VpcId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableInstance",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableInstanceResponse EnableInstance(EnableInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableInstanceWithOptions(request, runtime);
        }

        public async Task<EnableInstanceResponse> EnableInstanceAsync(EnableInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableInstanceWithOptionsAsync(request, runtime);
        }

        public ModifyDrdsDBPasswdResponse ModifyDrdsDBPasswdWithOptions(ModifyDrdsDBPasswdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["NewPasswd"] = request.NewPasswd;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDrdsDBPasswd",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDrdsDBPasswdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDrdsDBPasswdResponse> ModifyDrdsDBPasswdWithOptionsAsync(ModifyDrdsDBPasswdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["NewPasswd"] = request.NewPasswd;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDrdsDBPasswd",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDrdsDBPasswdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDrdsDBPasswdResponse ModifyDrdsDBPasswd(ModifyDrdsDBPasswdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDrdsDBPasswdWithOptions(request, runtime);
        }

        public async Task<ModifyDrdsDBPasswdResponse> ModifyDrdsDBPasswdAsync(ModifyDrdsDBPasswdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDrdsDBPasswdWithOptionsAsync(request, runtime);
        }

        public ModifyDrdsInstanceDescriptionResponse ModifyDrdsInstanceDescriptionWithOptions(ModifyDrdsInstanceDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDrdsInstanceDescription",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDrdsInstanceDescriptionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDrdsInstanceDescriptionResponse> ModifyDrdsInstanceDescriptionWithOptionsAsync(ModifyDrdsInstanceDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDrdsInstanceDescription",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDrdsInstanceDescriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDrdsInstanceDescriptionResponse ModifyDrdsInstanceDescription(ModifyDrdsInstanceDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDrdsInstanceDescriptionWithOptions(request, runtime);
        }

        public async Task<ModifyDrdsInstanceDescriptionResponse> ModifyDrdsInstanceDescriptionAsync(ModifyDrdsInstanceDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDrdsInstanceDescriptionWithOptionsAsync(request, runtime);
        }

        public ModifyDrdsIpWhiteListResponse ModifyDrdsIpWhiteListWithOptions(ModifyDrdsIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["GroupAttribute"] = request.GroupAttribute;
            query["GroupName"] = request.GroupName;
            query["IpWhiteList"] = request.IpWhiteList;
            query["Mode"] = request.Mode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDrdsIpWhiteList",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDrdsIpWhiteListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDrdsIpWhiteListResponse> ModifyDrdsIpWhiteListWithOptionsAsync(ModifyDrdsIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["GroupAttribute"] = request.GroupAttribute;
            query["GroupName"] = request.GroupName;
            query["IpWhiteList"] = request.IpWhiteList;
            query["Mode"] = request.Mode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDrdsIpWhiteList",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDrdsIpWhiteListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDrdsIpWhiteListResponse ModifyDrdsIpWhiteList(ModifyDrdsIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDrdsIpWhiteListWithOptions(request, runtime);
        }

        public async Task<ModifyDrdsIpWhiteListResponse> ModifyDrdsIpWhiteListAsync(ModifyDrdsIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDrdsIpWhiteListWithOptionsAsync(request, runtime);
        }

        public ModifyFullTableScanResponse ModifyFullTableScanWithOptions(ModifyFullTableScanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["FullTableScan"] = request.FullTableScan;
            query["TableNames"] = request.TableNames;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFullTableScan",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFullTableScanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyFullTableScanResponse> ModifyFullTableScanWithOptionsAsync(ModifyFullTableScanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["FullTableScan"] = request.FullTableScan;
            query["TableNames"] = request.TableNames;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFullTableScan",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFullTableScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyFullTableScanResponse ModifyFullTableScan(ModifyFullTableScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFullTableScanWithOptions(request, runtime);
        }

        public async Task<ModifyFullTableScanResponse> ModifyFullTableScanAsync(ModifyFullTableScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFullTableScanWithOptionsAsync(request, runtime);
        }

        public ModifyRdsReadWeightResponse ModifyRdsReadWeightWithOptions(ModifyRdsReadWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["InstanceNames"] = request.InstanceNames;
            query["Weights"] = request.Weights;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyRdsReadWeight",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRdsReadWeightResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyRdsReadWeightResponse> ModifyRdsReadWeightWithOptionsAsync(ModifyRdsReadWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["InstanceNames"] = request.InstanceNames;
            query["Weights"] = request.Weights;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyRdsReadWeight",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRdsReadWeightResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyRdsReadWeightResponse ModifyRdsReadWeight(ModifyRdsReadWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRdsReadWeightWithOptions(request, runtime);
        }

        public async Task<ModifyRdsReadWeightResponse> ModifyRdsReadWeightAsync(ModifyRdsReadWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRdsReadWeightWithOptionsAsync(request, runtime);
        }

        public ModifyReadOnlyAccountPasswordResponse ModifyReadOnlyAccountPasswordWithOptions(ModifyReadOnlyAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["NewPasswd"] = request.NewPasswd;
            query["OriginPassword"] = request.OriginPassword;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyReadOnlyAccountPassword",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyReadOnlyAccountPasswordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyReadOnlyAccountPasswordResponse> ModifyReadOnlyAccountPasswordWithOptionsAsync(ModifyReadOnlyAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["NewPasswd"] = request.NewPasswd;
            query["OriginPassword"] = request.OriginPassword;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyReadOnlyAccountPassword",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyReadOnlyAccountPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyReadOnlyAccountPasswordResponse ModifyReadOnlyAccountPassword(ModifyReadOnlyAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyReadOnlyAccountPasswordWithOptions(request, runtime);
        }

        public async Task<ModifyReadOnlyAccountPasswordResponse> ModifyReadOnlyAccountPasswordAsync(ModifyReadOnlyAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyReadOnlyAccountPasswordWithOptionsAsync(request, runtime);
        }

        public QueryInstanceInfoByConnResponse QueryInstanceInfoByConnWithOptions(QueryInstanceInfoByConnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Host"] = request.Host;
            query["Port"] = request.Port;
            query["UserName"] = request.UserName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryInstanceInfoByConn",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInstanceInfoByConnResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryInstanceInfoByConnResponse> QueryInstanceInfoByConnWithOptionsAsync(QueryInstanceInfoByConnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Host"] = request.Host;
            query["Port"] = request.Port;
            query["UserName"] = request.UserName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryInstanceInfoByConn",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInstanceInfoByConnResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryInstanceInfoByConnResponse QueryInstanceInfoByConn(QueryInstanceInfoByConnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInstanceInfoByConnWithOptions(request, runtime);
        }

        public async Task<QueryInstanceInfoByConnResponse> QueryInstanceInfoByConnAsync(QueryInstanceInfoByConnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInstanceInfoByConnWithOptionsAsync(request, runtime);
        }

        public RemoveDrdsInstanceResponse RemoveDrdsInstanceWithOptions(RemoveDrdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveDrdsInstance",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveDrdsInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveDrdsInstanceResponse> RemoveDrdsInstanceWithOptionsAsync(RemoveDrdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveDrdsInstance",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveDrdsInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveDrdsInstanceResponse RemoveDrdsInstance(RemoveDrdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveDrdsInstanceWithOptions(request, runtime);
        }

        public async Task<RemoveDrdsInstanceResponse> RemoveDrdsInstanceAsync(RemoveDrdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveDrdsInstanceWithOptionsAsync(request, runtime);
        }

        public RemoveReadOnlyAccountResponse RemoveReadOnlyAccountWithOptions(RemoveReadOnlyAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveReadOnlyAccount",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveReadOnlyAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveReadOnlyAccountResponse> RemoveReadOnlyAccountWithOptionsAsync(RemoveReadOnlyAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveReadOnlyAccount",
                Version = "2017-10-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveReadOnlyAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveReadOnlyAccountResponse RemoveReadOnlyAccount(RemoveReadOnlyAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveReadOnlyAccountWithOptions(request, runtime);
        }

        public async Task<RemoveReadOnlyAccountResponse> RemoveReadOnlyAccountAsync(RemoveReadOnlyAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveReadOnlyAccountWithOptionsAsync(request, runtime);
        }

    }
}
