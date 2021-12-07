// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Drds20190123.Models;

namespace AlibabaCloud.SDK.Drds20190123
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

        public ChangeAccountPasswordResponse ChangeAccountPasswordWithOptions(ChangeAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["Password"] = request.Password;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeAccountPassword",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeAccountPasswordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ChangeAccountPasswordResponse> ChangeAccountPasswordWithOptionsAsync(ChangeAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["Password"] = request.Password;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeAccountPassword",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeAccountPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ChangeAccountPasswordResponse ChangeAccountPassword(ChangeAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeAccountPasswordWithOptions(request, runtime);
        }

        public async Task<ChangeAccountPasswordResponse> ChangeAccountPasswordAsync(ChangeAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeAccountPasswordWithOptionsAsync(request, runtime);
        }

        public ChangeInstanceAzoneResponse ChangeInstanceAzoneWithOptions(ChangeInstanceAzoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["DrdsRegionId"] = request.DrdsRegionId;
            query["OriginAzoneId"] = request.OriginAzoneId;
            query["TargetAzoneId"] = request.TargetAzoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeInstanceAzone",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeInstanceAzoneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ChangeInstanceAzoneResponse> ChangeInstanceAzoneWithOptionsAsync(ChangeInstanceAzoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["DrdsRegionId"] = request.DrdsRegionId;
            query["OriginAzoneId"] = request.OriginAzoneId;
            query["TargetAzoneId"] = request.TargetAzoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeInstanceAzone",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeInstanceAzoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ChangeInstanceAzoneResponse ChangeInstanceAzone(ChangeInstanceAzoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeInstanceAzoneWithOptions(request, runtime);
        }

        public async Task<ChangeInstanceAzoneResponse> ChangeInstanceAzoneAsync(ChangeInstanceAzoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeInstanceAzoneWithOptionsAsync(request, runtime);
        }

        public ChangeInstanceNetworkResponse ChangeInstanceNetworkWithOptions(ChangeInstanceNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClassicExpiredDays"] = request.ClassicExpiredDays;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RetainClassic"] = request.RetainClassic;
            query["SrcInstanceNetworkType"] = request.SrcInstanceNetworkType;
            query["VpcId"] = request.VpcId;
            query["VswitchId"] = request.VswitchId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeInstanceNetwork",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeInstanceNetworkResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ChangeInstanceNetworkResponse> ChangeInstanceNetworkWithOptionsAsync(ChangeInstanceNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClassicExpiredDays"] = request.ClassicExpiredDays;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RetainClassic"] = request.RetainClassic;
            query["SrcInstanceNetworkType"] = request.SrcInstanceNetworkType;
            query["VpcId"] = request.VpcId;
            query["VswitchId"] = request.VswitchId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeInstanceNetwork",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeInstanceNetworkResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ChangeInstanceNetworkResponse ChangeInstanceNetwork(ChangeInstanceNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeInstanceNetworkWithOptions(request, runtime);
        }

        public async Task<ChangeInstanceNetworkResponse> ChangeInstanceNetworkAsync(ChangeInstanceNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeInstanceNetworkWithOptionsAsync(request, runtime);
        }

        public CheckDrdsDbNameResponse CheckDrdsDbNameWithOptions(CheckDrdsDbNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CheckDrdsDbName",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDrdsDbNameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckDrdsDbNameResponse> CheckDrdsDbNameWithOptionsAsync(CheckDrdsDbNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CheckDrdsDbName",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDrdsDbNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckDrdsDbNameResponse CheckDrdsDbName(CheckDrdsDbNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDrdsDbNameWithOptions(request, runtime);
        }

        public async Task<CheckDrdsDbNameResponse> CheckDrdsDbNameAsync(CheckDrdsDbNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDrdsDbNameWithOptionsAsync(request, runtime);
        }

        public CheckExpandStatusResponse CheckExpandStatusWithOptions(CheckExpandStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CheckExpandStatus",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckExpandStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckExpandStatusResponse> CheckExpandStatusWithOptionsAsync(CheckExpandStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CheckExpandStatus",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckExpandStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckExpandStatusResponse CheckExpandStatus(CheckExpandStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckExpandStatusWithOptions(request, runtime);
        }

        public async Task<CheckExpandStatusResponse> CheckExpandStatusAsync(CheckExpandStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckExpandStatusWithOptionsAsync(request, runtime);
        }

        public CheckRdsSuperAccountResponse CheckRdsSuperAccountWithOptions(CheckRdsSuperAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["DbInstanceId"] = request.DbInstanceId;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["Password"] = request.Password;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckRdsSuperAccount",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckRdsSuperAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckRdsSuperAccountResponse> CheckRdsSuperAccountWithOptionsAsync(CheckRdsSuperAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["DbInstanceId"] = request.DbInstanceId;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["Password"] = request.Password;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckRdsSuperAccount",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckRdsSuperAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckRdsSuperAccountResponse CheckRdsSuperAccount(CheckRdsSuperAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckRdsSuperAccountWithOptions(request, runtime);
        }

        public async Task<CheckRdsSuperAccountResponse> CheckRdsSuperAccountAsync(CheckRdsSuperAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckRdsSuperAccountWithOptionsAsync(request, runtime);
        }

        public CheckSqlAuditEnableStatusResponse CheckSqlAuditEnableStatusWithOptions(CheckSqlAuditEnableStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CheckSqlAuditEnableStatus",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckSqlAuditEnableStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckSqlAuditEnableStatusResponse> CheckSqlAuditEnableStatusWithOptionsAsync(CheckSqlAuditEnableStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CheckSqlAuditEnableStatus",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckSqlAuditEnableStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckSqlAuditEnableStatusResponse CheckSqlAuditEnableStatus(CheckSqlAuditEnableStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckSqlAuditEnableStatusWithOptions(request, runtime);
        }

        public async Task<CheckSqlAuditEnableStatusResponse> CheckSqlAuditEnableStatusAsync(CheckSqlAuditEnableStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckSqlAuditEnableStatusWithOptionsAsync(request, runtime);
        }

        public ConfigureDrdsDbInstancesResponse ConfigureDrdsDbInstancesWithOptions(ConfigureDrdsDbInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbInstance"] = request.DbInstance;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureDrdsDbInstances",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureDrdsDbInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ConfigureDrdsDbInstancesResponse> ConfigureDrdsDbInstancesWithOptionsAsync(ConfigureDrdsDbInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbInstance"] = request.DbInstance;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureDrdsDbInstances",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureDrdsDbInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ConfigureDrdsDbInstancesResponse ConfigureDrdsDbInstances(ConfigureDrdsDbInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigureDrdsDbInstancesWithOptions(request, runtime);
        }

        public async Task<ConfigureDrdsDbInstancesResponse> ConfigureDrdsDbInstancesAsync(ConfigureDrdsDbInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigureDrdsDbInstancesWithOptionsAsync(request, runtime);
        }

        public CreateDrdsDBResponse CreateDrdsDBWithOptions(CreateDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["DbInstType"] = request.DbInstType;
            query["DbInstanceIsCreating"] = request.DbInstanceIsCreating;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["Encode"] = request.Encode;
            query["InstDbName"] = request.InstDbName;
            query["Password"] = request.Password;
            query["RdsInstance"] = request.RdsInstance;
            query["RdsSuperAccount"] = request.RdsSuperAccount;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDrdsDB",
                Version = "2019-01-23",
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
            query["AccountName"] = request.AccountName;
            query["DbInstType"] = request.DbInstType;
            query["DbInstanceIsCreating"] = request.DbInstanceIsCreating;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["Encode"] = request.Encode;
            query["InstDbName"] = request.InstDbName;
            query["Password"] = request.Password;
            query["RdsInstance"] = request.RdsInstance;
            query["RdsSuperAccount"] = request.RdsSuperAccount;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDrdsDB",
                Version = "2019-01-23",
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

        public CreateDrdsDBPreCheckResponse CreateDrdsDBPreCheckWithOptions(CreateDrdsDBPreCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["DbInstType"] = request.DbInstType;
            query["DbInstanceIsCreating"] = request.DbInstanceIsCreating;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["Encode"] = request.Encode;
            query["InstDbName"] = request.InstDbName;
            query["Password"] = request.Password;
            query["RdsInstance"] = request.RdsInstance;
            query["RdsSuperAccount"] = request.RdsSuperAccount;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDrdsDBPreCheck",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDrdsDBPreCheckResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDrdsDBPreCheckResponse> CreateDrdsDBPreCheckWithOptionsAsync(CreateDrdsDBPreCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["DbInstType"] = request.DbInstType;
            query["DbInstanceIsCreating"] = request.DbInstanceIsCreating;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["Encode"] = request.Encode;
            query["InstDbName"] = request.InstDbName;
            query["Password"] = request.Password;
            query["RdsInstance"] = request.RdsInstance;
            query["RdsSuperAccount"] = request.RdsSuperAccount;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDrdsDBPreCheck",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDrdsDBPreCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDrdsDBPreCheckResponse CreateDrdsDBPreCheck(CreateDrdsDBPreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDrdsDBPreCheckWithOptions(request, runtime);
        }

        public async Task<CreateDrdsDBPreCheckResponse> CreateDrdsDBPreCheckAsync(CreateDrdsDBPreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDrdsDBPreCheckWithOptionsAsync(request, runtime);
        }

        public CreateDrdsDBPreviewResponse CreateDrdsDBPreviewWithOptions(CreateDrdsDBPreviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["DbInstType"] = request.DbInstType;
            query["DbInstanceIsCreating"] = request.DbInstanceIsCreating;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["InstDbName"] = request.InstDbName;
            query["OrderId"] = request.OrderId;
            query["RdsInstance"] = request.RdsInstance;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDrdsDBPreview",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDrdsDBPreviewResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDrdsDBPreviewResponse> CreateDrdsDBPreviewWithOptionsAsync(CreateDrdsDBPreviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["DbInstType"] = request.DbInstType;
            query["DbInstanceIsCreating"] = request.DbInstanceIsCreating;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["InstDbName"] = request.InstDbName;
            query["OrderId"] = request.OrderId;
            query["RdsInstance"] = request.RdsInstance;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDrdsDBPreview",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDrdsDBPreviewResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDrdsDBPreviewResponse CreateDrdsDBPreview(CreateDrdsDBPreviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDrdsDBPreviewWithOptions(request, runtime);
        }

        public async Task<CreateDrdsDBPreviewResponse> CreateDrdsDBPreviewAsync(CreateDrdsDBPreviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDrdsDBPreviewWithOptionsAsync(request, runtime);
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
            query["MasterInstId"] = request.MasterInstId;
            query["MySQLVersion"] = request.MySQLVersion;
            query["PayType"] = request.PayType;
            query["PricingCycle"] = request.PricingCycle;
            query["Quantity"] = request.Quantity;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["Specification"] = request.Specification;
            query["Type"] = request.Type;
            query["VpcId"] = request.VpcId;
            query["VswitchId"] = request.VswitchId;
            query["ZoneId"] = request.ZoneId;
            query["isHa"] = request.IsHa;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDrdsInstance",
                Version = "2019-01-23",
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
            query["MasterInstId"] = request.MasterInstId;
            query["MySQLVersion"] = request.MySQLVersion;
            query["PayType"] = request.PayType;
            query["PricingCycle"] = request.PricingCycle;
            query["Quantity"] = request.Quantity;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["Specification"] = request.Specification;
            query["Type"] = request.Type;
            query["VpcId"] = request.VpcId;
            query["VswitchId"] = request.VswitchId;
            query["ZoneId"] = request.ZoneId;
            query["isHa"] = request.IsHa;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDrdsInstance",
                Version = "2019-01-23",
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

        public CreateEvaluatePreCheckTaskResponse CreateEvaluatePreCheckTaskWithOptions(CreateEvaluatePreCheckTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AvgQpsGrowthScale"] = request.AvgQpsGrowthScale;
            query["DataGrowthScale"] = request.DataGrowthScale;
            query["DbInfo"] = request.DbInfo;
            query["EvaluateHours"] = request.EvaluateHours;
            query["TaskName"] = request.TaskName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEvaluatePreCheckTask",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEvaluatePreCheckTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateEvaluatePreCheckTaskResponse> CreateEvaluatePreCheckTaskWithOptionsAsync(CreateEvaluatePreCheckTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AvgQpsGrowthScale"] = request.AvgQpsGrowthScale;
            query["DataGrowthScale"] = request.DataGrowthScale;
            query["DbInfo"] = request.DbInfo;
            query["EvaluateHours"] = request.EvaluateHours;
            query["TaskName"] = request.TaskName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEvaluatePreCheckTask",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEvaluatePreCheckTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateEvaluatePreCheckTaskResponse CreateEvaluatePreCheckTask(CreateEvaluatePreCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEvaluatePreCheckTaskWithOptions(request, runtime);
        }

        public async Task<CreateEvaluatePreCheckTaskResponse> CreateEvaluatePreCheckTaskAsync(CreateEvaluatePreCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEvaluatePreCheckTaskWithOptionsAsync(request, runtime);
        }

        public CreateInstanceAccountResponse CreateInstanceAccountWithOptions(CreateInstanceAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["DbPrivilege"] = request.DbPrivilege;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["Password"] = request.Password;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceAccount",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateInstanceAccountResponse> CreateInstanceAccountWithOptionsAsync(CreateInstanceAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["DbPrivilege"] = request.DbPrivilege;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["Password"] = request.Password;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceAccount",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateInstanceAccountResponse CreateInstanceAccount(CreateInstanceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceAccountWithOptions(request, runtime);
        }

        public async Task<CreateInstanceAccountResponse> CreateInstanceAccountAsync(CreateInstanceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceAccountWithOptionsAsync(request, runtime);
        }

        public CreateInstanceInternetAddressResponse CreateInstanceInternetAddressWithOptions(CreateInstanceInternetAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceInternetAddress",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceInternetAddressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateInstanceInternetAddressResponse> CreateInstanceInternetAddressWithOptionsAsync(CreateInstanceInternetAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceInternetAddress",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceInternetAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateInstanceInternetAddressResponse CreateInstanceInternetAddress(CreateInstanceInternetAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceInternetAddressWithOptions(request, runtime);
        }

        public async Task<CreateInstanceInternetAddressResponse> CreateInstanceInternetAddressAsync(CreateInstanceInternetAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceInternetAddressWithOptionsAsync(request, runtime);
        }

        public CreateOrderForRdsResponse CreateOrderForRdsWithOptions(CreateOrderForRdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Params"] = request.Params;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrderForRds",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrderForRdsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateOrderForRdsResponse> CreateOrderForRdsWithOptionsAsync(CreateOrderForRdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Params"] = request.Params;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrderForRds",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrderForRdsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateOrderForRdsResponse CreateOrderForRds(CreateOrderForRdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOrderForRdsWithOptions(request, runtime);
        }

        public async Task<CreateOrderForRdsResponse> CreateOrderForRdsAsync(CreateOrderForRdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOrderForRdsWithOptionsAsync(request, runtime);
        }

        public CreateShardTaskResponse CreateShardTaskWithOptions(CreateShardTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["SourceTableName"] = request.SourceTableName;
            query["TargetTableName"] = request.TargetTableName;
            query["TaskType"] = request.TaskType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateShardTask",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateShardTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateShardTaskResponse> CreateShardTaskWithOptionsAsync(CreateShardTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["SourceTableName"] = request.SourceTableName;
            query["TargetTableName"] = request.TargetTableName;
            query["TaskType"] = request.TaskType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateShardTask",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateShardTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateShardTaskResponse CreateShardTask(CreateShardTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateShardTaskWithOptions(request, runtime);
        }

        public async Task<CreateShardTaskResponse> CreateShardTaskAsync(CreateShardTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateShardTaskWithOptionsAsync(request, runtime);
        }

        public DescribeBackMenuResponse DescribeBackMenuWithOptions(DescribeBackMenuRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeBackMenu",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackMenuResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeBackMenuResponse> DescribeBackMenuWithOptionsAsync(DescribeBackMenuRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeBackMenu",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackMenuResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeBackMenuResponse DescribeBackMenu(DescribeBackMenuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackMenuWithOptions(request, runtime);
        }

        public async Task<DescribeBackMenuResponse> DescribeBackMenuAsync(DescribeBackMenuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackMenuWithOptionsAsync(request, runtime);
        }

        public DescribeBackupDbsResponse DescribeBackupDbsWithOptions(DescribeBackupDbsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackupId"] = request.BackupId;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PreferredRestoreTime"] = request.PreferredRestoreTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupDbs",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupDbsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeBackupDbsResponse> DescribeBackupDbsWithOptionsAsync(DescribeBackupDbsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackupId"] = request.BackupId;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PreferredRestoreTime"] = request.PreferredRestoreTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupDbs",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupDbsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeBackupDbsResponse DescribeBackupDbs(DescribeBackupDbsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupDbsWithOptions(request, runtime);
        }

        public async Task<DescribeBackupDbsResponse> DescribeBackupDbsAsync(DescribeBackupDbsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupDbsWithOptionsAsync(request, runtime);
        }

        public DescribeBackupLocalResponse DescribeBackupLocalWithOptions(DescribeBackupLocalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeBackupLocal",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupLocalResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeBackupLocalResponse> DescribeBackupLocalWithOptionsAsync(DescribeBackupLocalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeBackupLocal",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupLocalResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeBackupLocalResponse DescribeBackupLocal(DescribeBackupLocalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupLocalWithOptions(request, runtime);
        }

        public async Task<DescribeBackupLocalResponse> DescribeBackupLocalAsync(DescribeBackupLocalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupLocalWithOptionsAsync(request, runtime);
        }

        public DescribeBackupPolicyResponse DescribeBackupPolicyWithOptions(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeBackupPolicy",
                Version = "2019-01-23",
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
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupPolicy",
                Version = "2019-01-23",
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

        public DescribeBackupSetsResponse DescribeBackupSetsWithOptions(DescribeBackupSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["EndTime"] = request.EndTime;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupSets",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupSetsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeBackupSetsResponse> DescribeBackupSetsWithOptionsAsync(DescribeBackupSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["EndTime"] = request.EndTime;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupSets",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupSetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeBackupSetsResponse DescribeBackupSets(DescribeBackupSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupSetsWithOptions(request, runtime);
        }

        public async Task<DescribeBackupSetsResponse> DescribeBackupSetsAsync(DescribeBackupSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupSetsWithOptionsAsync(request, runtime);
        }

        public DescribeBackupTimesResponse DescribeBackupTimesWithOptions(DescribeBackupTimesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeBackupTimes",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupTimesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeBackupTimesResponse> DescribeBackupTimesWithOptionsAsync(DescribeBackupTimesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeBackupTimes",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupTimesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeBackupTimesResponse DescribeBackupTimes(DescribeBackupTimesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupTimesWithOptions(request, runtime);
        }

        public async Task<DescribeBackupTimesResponse> DescribeBackupTimesAsync(DescribeBackupTimesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupTimesWithOptionsAsync(request, runtime);
        }

        public DescribeBroadcastTablesResponse DescribeBroadcastTablesWithOptions(DescribeBroadcastTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CurrentPage"] = request.CurrentPage;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PageSize"] = request.PageSize;
            query["Query"] = request.Query;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBroadcastTables",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBroadcastTablesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeBroadcastTablesResponse> DescribeBroadcastTablesWithOptionsAsync(DescribeBroadcastTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CurrentPage"] = request.CurrentPage;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PageSize"] = request.PageSize;
            query["Query"] = request.Query;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBroadcastTables",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBroadcastTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeBroadcastTablesResponse DescribeBroadcastTables(DescribeBroadcastTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBroadcastTablesWithOptions(request, runtime);
        }

        public async Task<DescribeBroadcastTablesResponse> DescribeBroadcastTablesAsync(DescribeBroadcastTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBroadcastTablesWithOptionsAsync(request, runtime);
        }

        public DescribeDataImportTaskReportResponse DescribeDataImportTaskReportWithOptions(DescribeDataImportTaskReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TaskId"] = request.TaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataImportTaskReport",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataImportTaskReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDataImportTaskReportResponse> DescribeDataImportTaskReportWithOptionsAsync(DescribeDataImportTaskReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TaskId"] = request.TaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataImportTaskReport",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataImportTaskReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDataImportTaskReportResponse DescribeDataImportTaskReport(DescribeDataImportTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataImportTaskReportWithOptions(request, runtime);
        }

        public async Task<DescribeDataImportTaskReportResponse> DescribeDataImportTaskReportAsync(DescribeDataImportTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataImportTaskReportWithOptionsAsync(request, runtime);
        }

        public DescribeDbInstanceDbsResponse DescribeDbInstanceDbsWithOptions(DescribeDbInstanceDbsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["DbInstType"] = request.DbInstType;
            query["DbInstanceId"] = request.DbInstanceId;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["Password"] = request.Password;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDbInstanceDbs",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDbInstanceDbsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDbInstanceDbsResponse> DescribeDbInstanceDbsWithOptionsAsync(DescribeDbInstanceDbsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["DbInstType"] = request.DbInstType;
            query["DbInstanceId"] = request.DbInstanceId;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["Password"] = request.Password;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDbInstanceDbs",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDbInstanceDbsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDbInstanceDbsResponse DescribeDbInstanceDbs(DescribeDbInstanceDbsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDbInstanceDbsWithOptions(request, runtime);
        }

        public async Task<DescribeDbInstanceDbsResponse> DescribeDbInstanceDbsAsync(DescribeDbInstanceDbsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDbInstanceDbsWithOptionsAsync(request, runtime);
        }

        public DescribeDbInstancesResponse DescribeDbInstancesWithOptions(DescribeDbInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbInstType"] = request.DbInstType;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["Search"] = request.Search;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDbInstances",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDbInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDbInstancesResponse> DescribeDbInstancesWithOptionsAsync(DescribeDbInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbInstType"] = request.DbInstType;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["Search"] = request.Search;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDbInstances",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDbInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDbInstancesResponse DescribeDbInstances(DescribeDbInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDbInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeDbInstancesResponse> DescribeDbInstancesAsync(DescribeDbInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDbInstancesWithOptionsAsync(request, runtime);
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
                Version = "2019-01-23",
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
                Version = "2019-01-23",
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

        public DescribeDrdsDBClusterResponse DescribeDrdsDBClusterWithOptions(DescribeDrdsDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbInstanceId"] = request.DbInstanceId;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsDBCluster",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDBClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDrdsDBClusterResponse> DescribeDrdsDBClusterWithOptionsAsync(DescribeDrdsDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbInstanceId"] = request.DbInstanceId;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsDBCluster",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDBClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDrdsDBClusterResponse DescribeDrdsDBCluster(DescribeDrdsDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsDBClusterWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsDBClusterResponse> DescribeDrdsDBClusterAsync(DescribeDrdsDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsDBClusterWithOptionsAsync(request, runtime);
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
                Version = "2019-01-23",
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
                Version = "2019-01-23",
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
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsDBs",
                Version = "2019-01-23",
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
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsDBs",
                Version = "2019-01-23",
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

        public DescribeDrdsDbInstanceResponse DescribeDrdsDbInstanceWithOptions(DescribeDrdsDbInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbInstanceId"] = request.DbInstanceId;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsDbInstance",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDbInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDrdsDbInstanceResponse> DescribeDrdsDbInstanceWithOptionsAsync(DescribeDrdsDbInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbInstanceId"] = request.DbInstanceId;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsDbInstance",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDbInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDrdsDbInstanceResponse DescribeDrdsDbInstance(DescribeDrdsDbInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsDbInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsDbInstanceResponse> DescribeDrdsDbInstanceAsync(DescribeDrdsDbInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsDbInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsDbInstancesResponse DescribeDrdsDbInstancesWithOptions(DescribeDrdsDbInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsDbInstances",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDbInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDrdsDbInstancesResponse> DescribeDrdsDbInstancesWithOptionsAsync(DescribeDrdsDbInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsDbInstances",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDbInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDrdsDbInstancesResponse DescribeDrdsDbInstances(DescribeDrdsDbInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsDbInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsDbInstancesResponse> DescribeDrdsDbInstancesAsync(DescribeDrdsDbInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsDbInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsDbRdsNameListResponse DescribeDrdsDbRdsNameListWithOptions(DescribeDrdsDbRdsNameListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDrdsDbRdsNameList",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDbRdsNameListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDrdsDbRdsNameListResponse> DescribeDrdsDbRdsNameListWithOptionsAsync(DescribeDrdsDbRdsNameListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDrdsDbRdsNameList",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDbRdsNameListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDrdsDbRdsNameListResponse DescribeDrdsDbRdsNameList(DescribeDrdsDbRdsNameListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsDbRdsNameListWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsDbRdsNameListResponse> DescribeDrdsDbRdsNameListAsync(DescribeDrdsDbRdsNameListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsDbRdsNameListWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsDbSpecAndPriceResponse DescribeDrdsDbSpecAndPriceWithOptions(DescribeDrdsDbSpecAndPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DBName"] = request.DBName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsDbSpecAndPrice",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDbSpecAndPriceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDrdsDbSpecAndPriceResponse> DescribeDrdsDbSpecAndPriceWithOptionsAsync(DescribeDrdsDbSpecAndPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DBName"] = request.DBName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsDbSpecAndPrice",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDbSpecAndPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDrdsDbSpecAndPriceResponse DescribeDrdsDbSpecAndPrice(DescribeDrdsDbSpecAndPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsDbSpecAndPriceWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsDbSpecAndPriceResponse> DescribeDrdsDbSpecAndPriceAsync(DescribeDrdsDbSpecAndPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsDbSpecAndPriceWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsDbTasksResponse DescribeDrdsDbTasksWithOptions(DescribeDrdsDbTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["TaskType"] = request.TaskType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsDbTasks",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDbTasksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDrdsDbTasksResponse> DescribeDrdsDbTasksWithOptionsAsync(DescribeDrdsDbTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["TaskType"] = request.TaskType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsDbTasks",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDbTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDrdsDbTasksResponse DescribeDrdsDbTasks(DescribeDrdsDbTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsDbTasksWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsDbTasksResponse> DescribeDrdsDbTasksAsync(DescribeDrdsDbTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsDbTasksWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsInstanceResponse DescribeDrdsInstanceWithOptions(DescribeDrdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsInstance",
                Version = "2019-01-23",
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
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsInstance",
                Version = "2019-01-23",
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
            query["RegionId"] = request.RegionId;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsInstanceDbMonitor",
                Version = "2019-01-23",
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
            query["RegionId"] = request.RegionId;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsInstanceDbMonitor",
                Version = "2019-01-23",
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

        public DescribeDrdsInstanceLevelTasksResponse DescribeDrdsInstanceLevelTasksWithOptions(DescribeDrdsInstanceLevelTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDrdsInstanceLevelTasks",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstanceLevelTasksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDrdsInstanceLevelTasksResponse> DescribeDrdsInstanceLevelTasksWithOptionsAsync(DescribeDrdsInstanceLevelTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDrdsInstanceLevelTasks",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstanceLevelTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDrdsInstanceLevelTasksResponse DescribeDrdsInstanceLevelTasks(DescribeDrdsInstanceLevelTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsInstanceLevelTasksWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsInstanceLevelTasksResponse> DescribeDrdsInstanceLevelTasksAsync(DescribeDrdsInstanceLevelTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsInstanceLevelTasksWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsInstanceMonitorResponse DescribeDrdsInstanceMonitorWithOptions(DescribeDrdsInstanceMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["EndTime"] = request.EndTime;
            query["Key"] = request.Key;
            query["PeriodMultiple"] = request.PeriodMultiple;
            query["RegionId"] = request.RegionId;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsInstanceMonitor",
                Version = "2019-01-23",
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
            query["RegionId"] = request.RegionId;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsInstanceMonitor",
                Version = "2019-01-23",
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

        public DescribeDrdsInstanceVersionResponse DescribeDrdsInstanceVersionWithOptions(DescribeDrdsInstanceVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsInstanceVersion",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstanceVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDrdsInstanceVersionResponse> DescribeDrdsInstanceVersionWithOptionsAsync(DescribeDrdsInstanceVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsInstanceVersion",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstanceVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDrdsInstanceVersionResponse DescribeDrdsInstanceVersion(DescribeDrdsInstanceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsInstanceVersionWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsInstanceVersionResponse> DescribeDrdsInstanceVersionAsync(DescribeDrdsInstanceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsInstanceVersionWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsInstancesResponse DescribeDrdsInstancesWithOptions(DescribeDrdsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["Expired"] = request.Expired;
            query["Mix"] = request.Mix;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProductVersion"] = request.ProductVersion;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["Tag"] = request.Tag;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsInstances",
                Version = "2019-01-23",
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
            query["Description"] = request.Description;
            query["Expired"] = request.Expired;
            query["Mix"] = request.Mix;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProductVersion"] = request.ProductVersion;
            query["RegionId"] = request.RegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["Tag"] = request.Tag;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsInstances",
                Version = "2019-01-23",
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

        public DescribeDrdsParamsResponse DescribeDrdsParamsWithOptions(DescribeDrdsParamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["ParamLevel"] = request.ParamLevel;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsParams",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsParamsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDrdsParamsResponse> DescribeDrdsParamsWithOptionsAsync(DescribeDrdsParamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["ParamLevel"] = request.ParamLevel;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsParams",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsParamsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDrdsParamsResponse DescribeDrdsParams(DescribeDrdsParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsParamsWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsParamsResponse> DescribeDrdsParamsAsync(DescribeDrdsParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsParamsWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsRdsInstancesResponse DescribeDrdsRdsInstancesWithOptions(DescribeDrdsRdsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDrdsRdsInstances",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsRdsInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDrdsRdsInstancesResponse> DescribeDrdsRdsInstancesWithOptionsAsync(DescribeDrdsRdsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDrdsRdsInstances",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsRdsInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDrdsRdsInstancesResponse DescribeDrdsRdsInstances(DescribeDrdsRdsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsRdsInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsRdsInstancesResponse> DescribeDrdsRdsInstancesAsync(DescribeDrdsRdsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsRdsInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsShardingDbsResponse DescribeDrdsShardingDbsWithOptions(DescribeDrdsShardingDbsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DbNamePattern"] = request.DbNamePattern;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsShardingDbs",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsShardingDbsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDrdsShardingDbsResponse> DescribeDrdsShardingDbsWithOptionsAsync(DescribeDrdsShardingDbsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DbNamePattern"] = request.DbNamePattern;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsShardingDbs",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsShardingDbsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDrdsShardingDbsResponse DescribeDrdsShardingDbs(DescribeDrdsShardingDbsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsShardingDbsWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsShardingDbsResponse> DescribeDrdsShardingDbsAsync(DescribeDrdsShardingDbsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsShardingDbsWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsSlowSqlsResponse DescribeDrdsSlowSqlsWithOptions(DescribeDrdsSlowSqlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["EndTime"] = request.EndTime;
            query["ExeTime"] = request.ExeTime;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsSlowSqls",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsSlowSqlsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDrdsSlowSqlsResponse> DescribeDrdsSlowSqlsWithOptionsAsync(DescribeDrdsSlowSqlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["EndTime"] = request.EndTime;
            query["ExeTime"] = request.ExeTime;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsSlowSqls",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsSlowSqlsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDrdsSlowSqlsResponse DescribeDrdsSlowSqls(DescribeDrdsSlowSqlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsSlowSqlsWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsSlowSqlsResponse> DescribeDrdsSlowSqlsAsync(DescribeDrdsSlowSqlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsSlowSqlsWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsSqlAuditStatusResponse DescribeDrdsSqlAuditStatusWithOptions(DescribeDrdsSqlAuditStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDrdsSqlAuditStatus",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsSqlAuditStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDrdsSqlAuditStatusResponse> DescribeDrdsSqlAuditStatusWithOptionsAsync(DescribeDrdsSqlAuditStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDrdsSqlAuditStatus",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsSqlAuditStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDrdsSqlAuditStatusResponse DescribeDrdsSqlAuditStatus(DescribeDrdsSqlAuditStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsSqlAuditStatusWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsSqlAuditStatusResponse> DescribeDrdsSqlAuditStatusAsync(DescribeDrdsSqlAuditStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsSqlAuditStatusWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsTasksResponse DescribeDrdsTasksWithOptions(DescribeDrdsTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["TaskType"] = request.TaskType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsTasks",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsTasksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDrdsTasksResponse> DescribeDrdsTasksWithOptionsAsync(DescribeDrdsTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["TaskType"] = request.TaskType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDrdsTasks",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDrdsTasksResponse DescribeDrdsTasks(DescribeDrdsTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsTasksWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsTasksResponse> DescribeDrdsTasksAsync(DescribeDrdsTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsTasksWithOptionsAsync(request, runtime);
        }

        public DescribeExpandLogicTableInfoListResponse DescribeExpandLogicTableInfoListWithOptions(DescribeExpandLogicTableInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeExpandLogicTableInfoList",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExpandLogicTableInfoListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeExpandLogicTableInfoListResponse> DescribeExpandLogicTableInfoListWithOptionsAsync(DescribeExpandLogicTableInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeExpandLogicTableInfoList",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExpandLogicTableInfoListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeExpandLogicTableInfoListResponse DescribeExpandLogicTableInfoList(DescribeExpandLogicTableInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExpandLogicTableInfoListWithOptions(request, runtime);
        }

        public async Task<DescribeExpandLogicTableInfoListResponse> DescribeExpandLogicTableInfoListAsync(DescribeExpandLogicTableInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExpandLogicTableInfoListWithOptionsAsync(request, runtime);
        }

        public DescribeHiStoreInstanceInfoResponse DescribeHiStoreInstanceInfoWithOptions(DescribeHiStoreInstanceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["HistoreInstanceId"] = request.HistoreInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHiStoreInstanceInfo",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHiStoreInstanceInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeHiStoreInstanceInfoResponse> DescribeHiStoreInstanceInfoWithOptionsAsync(DescribeHiStoreInstanceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["HistoreInstanceId"] = request.HistoreInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHiStoreInstanceInfo",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHiStoreInstanceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeHiStoreInstanceInfoResponse DescribeHiStoreInstanceInfo(DescribeHiStoreInstanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHiStoreInstanceInfoWithOptions(request, runtime);
        }

        public async Task<DescribeHiStoreInstanceInfoResponse> DescribeHiStoreInstanceInfoAsync(DescribeHiStoreInstanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHiStoreInstanceInfoWithOptionsAsync(request, runtime);
        }

        public DescribeHotDbListResponse DescribeHotDbListWithOptions(DescribeHotDbListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeHotDbList",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHotDbListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeHotDbListResponse> DescribeHotDbListWithOptionsAsync(DescribeHotDbListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeHotDbList",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHotDbListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeHotDbListResponse DescribeHotDbList(DescribeHotDbListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHotDbListWithOptions(request, runtime);
        }

        public async Task<DescribeHotDbListResponse> DescribeHotDbListAsync(DescribeHotDbListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHotDbListWithOptionsAsync(request, runtime);
        }

        public DescribeInstDbLogInfoResponse DescribeInstDbLogInfoWithOptions(DescribeInstDbLogInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeInstDbLogInfo",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstDbLogInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeInstDbLogInfoResponse> DescribeInstDbLogInfoWithOptionsAsync(DescribeInstDbLogInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeInstDbLogInfo",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstDbLogInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeInstDbLogInfoResponse DescribeInstDbLogInfo(DescribeInstDbLogInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstDbLogInfoWithOptions(request, runtime);
        }

        public async Task<DescribeInstDbLogInfoResponse> DescribeInstDbLogInfoAsync(DescribeInstDbLogInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstDbLogInfoWithOptionsAsync(request, runtime);
        }

        public DescribeInstDbSlsInfoResponse DescribeInstDbSlsInfoWithOptions(DescribeInstDbSlsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeInstDbSlsInfo",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstDbSlsInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeInstDbSlsInfoResponse> DescribeInstDbSlsInfoWithOptionsAsync(DescribeInstDbSlsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeInstDbSlsInfo",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstDbSlsInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeInstDbSlsInfoResponse DescribeInstDbSlsInfo(DescribeInstDbSlsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstDbSlsInfoWithOptions(request, runtime);
        }

        public async Task<DescribeInstDbSlsInfoResponse> DescribeInstDbSlsInfoAsync(DescribeInstDbSlsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstDbSlsInfoWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceAccountsResponse DescribeInstanceAccountsWithOptions(DescribeInstanceAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeInstanceAccounts",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceAccountsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeInstanceAccountsResponse> DescribeInstanceAccountsWithOptionsAsync(DescribeInstanceAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeInstanceAccounts",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceAccountsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeInstanceAccountsResponse DescribeInstanceAccounts(DescribeInstanceAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceAccountsWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceAccountsResponse> DescribeInstanceAccountsAsync(DescribeInstanceAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceAccountsWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceMenuSwitchResponse DescribeInstanceMenuSwitchWithOptions(DescribeInstanceMenuSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeInstanceMenuSwitch",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceMenuSwitchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeInstanceMenuSwitchResponse> DescribeInstanceMenuSwitchWithOptionsAsync(DescribeInstanceMenuSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeInstanceMenuSwitch",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceMenuSwitchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeInstanceMenuSwitchResponse DescribeInstanceMenuSwitch(DescribeInstanceMenuSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceMenuSwitchWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceMenuSwitchResponse> DescribeInstanceMenuSwitchAsync(DescribeInstanceMenuSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceMenuSwitchWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceSwitchAzoneResponse DescribeInstanceSwitchAzoneWithOptions(DescribeInstanceSwitchAzoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeInstanceSwitchAzone",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceSwitchAzoneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeInstanceSwitchAzoneResponse> DescribeInstanceSwitchAzoneWithOptionsAsync(DescribeInstanceSwitchAzoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeInstanceSwitchAzone",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceSwitchAzoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeInstanceSwitchAzoneResponse DescribeInstanceSwitchAzone(DescribeInstanceSwitchAzoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceSwitchAzoneWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceSwitchAzoneResponse> DescribeInstanceSwitchAzoneAsync(DescribeInstanceSwitchAzoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceSwitchAzoneWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceSwitchNetworkResponse DescribeInstanceSwitchNetworkWithOptions(DescribeInstanceSwitchNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeInstanceSwitchNetwork",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceSwitchNetworkResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeInstanceSwitchNetworkResponse> DescribeInstanceSwitchNetworkWithOptionsAsync(DescribeInstanceSwitchNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeInstanceSwitchNetwork",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceSwitchNetworkResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeInstanceSwitchNetworkResponse DescribeInstanceSwitchNetwork(DescribeInstanceSwitchNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceSwitchNetworkWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceSwitchNetworkResponse> DescribeInstanceSwitchNetworkAsync(DescribeInstanceSwitchNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceSwitchNetworkWithOptionsAsync(request, runtime);
        }

        public DescribePreCheckResultResponse DescribePreCheckResultWithOptions(DescribePreCheckResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["TaskId"] = request.TaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePreCheckResult",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePreCheckResultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribePreCheckResultResponse> DescribePreCheckResultWithOptionsAsync(DescribePreCheckResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["TaskId"] = request.TaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePreCheckResult",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePreCheckResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribePreCheckResultResponse DescribePreCheckResult(DescribePreCheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePreCheckResultWithOptions(request, runtime);
        }

        public async Task<DescribePreCheckResultResponse> DescribePreCheckResultAsync(DescribePreCheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePreCheckResultWithOptionsAsync(request, runtime);
        }

        public DescribeRDSPerformanceResponse DescribeRDSPerformanceWithOptions(DescribeRDSPerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbInstType"] = request.DbInstType;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["EndTime"] = request.EndTime;
            query["Keys"] = request.Keys;
            query["RdsInstanceId"] = request.RdsInstanceId;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRDSPerformance",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRDSPerformanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRDSPerformanceResponse> DescribeRDSPerformanceWithOptionsAsync(DescribeRDSPerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbInstType"] = request.DbInstType;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["EndTime"] = request.EndTime;
            query["Keys"] = request.Keys;
            query["RdsInstanceId"] = request.RdsInstanceId;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRDSPerformance",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRDSPerformanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRDSPerformanceResponse DescribeRDSPerformance(DescribeRDSPerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRDSPerformanceWithOptions(request, runtime);
        }

        public async Task<DescribeRDSPerformanceResponse> DescribeRDSPerformanceAsync(DescribeRDSPerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRDSPerformanceWithOptionsAsync(request, runtime);
        }

        public DescribeRdsCommodityResponse DescribeRdsCommodityWithOptions(DescribeRdsCommodityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CommodityCode"] = request.CommodityCode;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["OrderType"] = request.OrderType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRdsCommodity",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRdsCommodityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRdsCommodityResponse> DescribeRdsCommodityWithOptionsAsync(DescribeRdsCommodityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CommodityCode"] = request.CommodityCode;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["OrderType"] = request.OrderType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRdsCommodity",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRdsCommodityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRdsCommodityResponse DescribeRdsCommodity(DescribeRdsCommodityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRdsCommodityWithOptions(request, runtime);
        }

        public async Task<DescribeRdsCommodityResponse> DescribeRdsCommodityAsync(DescribeRdsCommodityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRdsCommodityWithOptionsAsync(request, runtime);
        }

        public DescribeRdsDrdsDBResponse DescribeRdsDrdsDBWithOptions(DescribeRdsDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RdsInstanceId"] = request.RdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRdsDrdsDB",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRdsDrdsDBResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRdsDrdsDBResponse> DescribeRdsDrdsDBWithOptionsAsync(DescribeRdsDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RdsInstanceId"] = request.RdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRdsDrdsDB",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRdsDrdsDBResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRdsDrdsDBResponse DescribeRdsDrdsDB(DescribeRdsDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRdsDrdsDBWithOptions(request, runtime);
        }

        public async Task<DescribeRdsDrdsDBResponse> DescribeRdsDrdsDBAsync(DescribeRdsDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRdsDrdsDBWithOptionsAsync(request, runtime);
        }

        public DescribeRdsPerformanceSummaryResponse DescribeRdsPerformanceSummaryWithOptions(DescribeRdsPerformanceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RdsInstanceId"] = request.RdsInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRdsPerformanceSummary",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRdsPerformanceSummaryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRdsPerformanceSummaryResponse> DescribeRdsPerformanceSummaryWithOptionsAsync(DescribeRdsPerformanceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RdsInstanceId"] = request.RdsInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRdsPerformanceSummary",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRdsPerformanceSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRdsPerformanceSummaryResponse DescribeRdsPerformanceSummary(DescribeRdsPerformanceSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRdsPerformanceSummaryWithOptions(request, runtime);
        }

        public async Task<DescribeRdsPerformanceSummaryResponse> DescribeRdsPerformanceSummaryAsync(DescribeRdsPerformanceSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRdsPerformanceSummaryWithOptionsAsync(request, runtime);
        }

        public DescribeRdsPriceResponse DescribeRdsPriceWithOptions(DescribeRdsPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Params"] = request.Params;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRdsPrice",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRdsPriceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRdsPriceResponse> DescribeRdsPriceWithOptionsAsync(DescribeRdsPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Params"] = request.Params;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRdsPrice",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRdsPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRdsPriceResponse DescribeRdsPrice(DescribeRdsPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRdsPriceWithOptions(request, runtime);
        }

        public async Task<DescribeRdsPriceResponse> DescribeRdsPriceAsync(DescribeRdsPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRdsPriceWithOptionsAsync(request, runtime);
        }

        public DescribeRdsReadOnlyResponse DescribeRdsReadOnlyWithOptions(DescribeRdsReadOnlyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbInstType"] = request.DbInstType;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RdsInstanceId"] = request.RdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRdsReadOnly",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRdsReadOnlyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRdsReadOnlyResponse> DescribeRdsReadOnlyWithOptionsAsync(DescribeRdsReadOnlyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbInstType"] = request.DbInstType;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RdsInstanceId"] = request.RdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRdsReadOnly",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRdsReadOnlyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRdsReadOnlyResponse DescribeRdsReadOnly(DescribeRdsReadOnlyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRdsReadOnlyWithOptions(request, runtime);
        }

        public async Task<DescribeRdsReadOnlyResponse> DescribeRdsReadOnlyAsync(DescribeRdsReadOnlyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRdsReadOnlyWithOptionsAsync(request, runtime);
        }

        public DescribeRdsSuperAccountInstancesResponse DescribeRdsSuperAccountInstancesWithOptions(DescribeRdsSuperAccountInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbInstType"] = request.DbInstType;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RdsInstance"] = request.RdsInstance;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRdsSuperAccountInstances",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRdsSuperAccountInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRdsSuperAccountInstancesResponse> DescribeRdsSuperAccountInstancesWithOptionsAsync(DescribeRdsSuperAccountInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbInstType"] = request.DbInstType;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RdsInstance"] = request.RdsInstance;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRdsSuperAccountInstances",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRdsSuperAccountInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRdsSuperAccountInstancesResponse DescribeRdsSuperAccountInstances(DescribeRdsSuperAccountInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRdsSuperAccountInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeRdsSuperAccountInstancesResponse> DescribeRdsSuperAccountInstancesAsync(DescribeRdsSuperAccountInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRdsSuperAccountInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeRdsVpcForZoneResponse DescribeRdsVpcForZoneWithOptions(DescribeRdsVpcForZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRdsVpcForZone",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRdsVpcForZoneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRdsVpcForZoneResponse> DescribeRdsVpcForZoneWithOptionsAsync(DescribeRdsVpcForZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRdsVpcForZone",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRdsVpcForZoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRdsVpcForZoneResponse DescribeRdsVpcForZone(DescribeRdsVpcForZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRdsVpcForZoneWithOptions(request, runtime);
        }

        public async Task<DescribeRdsVpcForZoneResponse> DescribeRdsVpcForZoneAsync(DescribeRdsVpcForZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRdsVpcForZoneWithOptionsAsync(request, runtime);
        }

        public DescribeRecycleBinStatusResponse DescribeRecycleBinStatusWithOptions(DescribeRecycleBinStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeRecycleBinStatus",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecycleBinStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRecycleBinStatusResponse> DescribeRecycleBinStatusWithOptionsAsync(DescribeRecycleBinStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeRecycleBinStatus",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecycleBinStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRecycleBinStatusResponse DescribeRecycleBinStatus(DescribeRecycleBinStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecycleBinStatusWithOptions(request, runtime);
        }

        public async Task<DescribeRecycleBinStatusResponse> DescribeRecycleBinStatusAsync(DescribeRecycleBinStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecycleBinStatusWithOptionsAsync(request, runtime);
        }

        public DescribeRecycleBinTablesResponse DescribeRecycleBinTablesWithOptions(DescribeRecycleBinTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeRecycleBinTables",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecycleBinTablesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRecycleBinTablesResponse> DescribeRecycleBinTablesWithOptionsAsync(DescribeRecycleBinTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeRecycleBinTables",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecycleBinTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRecycleBinTablesResponse DescribeRecycleBinTables(DescribeRecycleBinTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecycleBinTablesWithOptions(request, runtime);
        }

        public async Task<DescribeRecycleBinTablesResponse> DescribeRecycleBinTablesAsync(DescribeRecycleBinTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecycleBinTablesWithOptionsAsync(request, runtime);
        }

        public DescribeRestoreOrderResponse DescribeRestoreOrderWithOptions(DescribeRestoreOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackupDbNames"] = request.BackupDbNames;
            query["BackupId"] = request.BackupId;
            query["BackupLevel"] = request.BackupLevel;
            query["BackupMode"] = request.BackupMode;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PreferredBackupTime"] = request.PreferredBackupTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRestoreOrder",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRestoreOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRestoreOrderResponse> DescribeRestoreOrderWithOptionsAsync(DescribeRestoreOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackupDbNames"] = request.BackupDbNames;
            query["BackupId"] = request.BackupId;
            query["BackupLevel"] = request.BackupLevel;
            query["BackupMode"] = request.BackupMode;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PreferredBackupTime"] = request.PreferredBackupTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRestoreOrder",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRestoreOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRestoreOrderResponse DescribeRestoreOrder(DescribeRestoreOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRestoreOrderWithOptions(request, runtime);
        }

        public async Task<DescribeRestoreOrderResponse> DescribeRestoreOrderAsync(DescribeRestoreOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRestoreOrderWithOptionsAsync(request, runtime);
        }

        public DescribeShardTaskInfoResponse DescribeShardTaskInfoWithOptions(DescribeShardTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["SourceTableName"] = request.SourceTableName;
            query["TargetTableName"] = request.TargetTableName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeShardTaskInfo",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeShardTaskInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeShardTaskInfoResponse> DescribeShardTaskInfoWithOptionsAsync(DescribeShardTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["SourceTableName"] = request.SourceTableName;
            query["TargetTableName"] = request.TargetTableName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeShardTaskInfo",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeShardTaskInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeShardTaskInfoResponse DescribeShardTaskInfo(DescribeShardTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeShardTaskInfoWithOptions(request, runtime);
        }

        public async Task<DescribeShardTaskInfoResponse> DescribeShardTaskInfoAsync(DescribeShardTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeShardTaskInfoWithOptionsAsync(request, runtime);
        }

        public DescribeShardTaskListResponse DescribeShardTaskListWithOptions(DescribeShardTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CurrentPage"] = request.CurrentPage;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PageSize"] = request.PageSize;
            query["Query"] = request.Query;
            query["RegionId"] = request.RegionId;
            query["TaskType"] = request.TaskType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeShardTaskList",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeShardTaskListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeShardTaskListResponse> DescribeShardTaskListWithOptionsAsync(DescribeShardTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CurrentPage"] = request.CurrentPage;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PageSize"] = request.PageSize;
            query["Query"] = request.Query;
            query["RegionId"] = request.RegionId;
            query["TaskType"] = request.TaskType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeShardTaskList",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeShardTaskListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeShardTaskListResponse DescribeShardTaskList(DescribeShardTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeShardTaskListWithOptions(request, runtime);
        }

        public async Task<DescribeShardTaskListResponse> DescribeShardTaskListAsync(DescribeShardTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeShardTaskListWithOptionsAsync(request, runtime);
        }

        public DescribeSqlFlashbakTaskResponse DescribeSqlFlashbakTaskWithOptions(DescribeSqlFlashbakTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeSqlFlashbakTask",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlFlashbakTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSqlFlashbakTaskResponse> DescribeSqlFlashbakTaskWithOptionsAsync(DescribeSqlFlashbakTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeSqlFlashbakTask",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlFlashbakTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSqlFlashbakTaskResponse DescribeSqlFlashbakTask(DescribeSqlFlashbakTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSqlFlashbakTaskWithOptions(request, runtime);
        }

        public async Task<DescribeSqlFlashbakTaskResponse> DescribeSqlFlashbakTaskAsync(DescribeSqlFlashbakTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSqlFlashbakTaskWithOptionsAsync(request, runtime);
        }

        public DescribeSrcRdsListResponse DescribeSrcRdsListWithOptions(DescribeSrcRdsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PartitionMapping"] = request.PartitionMapping;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSrcRdsList",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSrcRdsListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSrcRdsListResponse> DescribeSrcRdsListWithOptionsAsync(DescribeSrcRdsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PartitionMapping"] = request.PartitionMapping;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSrcRdsList",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSrcRdsListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSrcRdsListResponse DescribeSrcRdsList(DescribeSrcRdsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSrcRdsListWithOptions(request, runtime);
        }

        public async Task<DescribeSrcRdsListResponse> DescribeSrcRdsListAsync(DescribeSrcRdsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSrcRdsListWithOptionsAsync(request, runtime);
        }

        public DescribeTableResponse DescribeTableWithOptions(DescribeTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["TableName"] = request.TableName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTable",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeTableResponse> DescribeTableWithOptionsAsync(DescribeTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["TableName"] = request.TableName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTable",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeTableResponse DescribeTable(DescribeTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTableWithOptions(request, runtime);
        }

        public async Task<DescribeTableResponse> DescribeTableAsync(DescribeTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTableWithOptionsAsync(request, runtime);
        }

        public DescribeTableListByTypeResponse DescribeTableListByTypeWithOptions(DescribeTableListByTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CurrentPage"] = request.CurrentPage;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PageSize"] = request.PageSize;
            query["Query"] = request.Query;
            query["RegionId"] = request.RegionId;
            query["TableType"] = request.TableType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTableListByType",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTableListByTypeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeTableListByTypeResponse> DescribeTableListByTypeWithOptionsAsync(DescribeTableListByTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CurrentPage"] = request.CurrentPage;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PageSize"] = request.PageSize;
            query["Query"] = request.Query;
            query["RegionId"] = request.RegionId;
            query["TableType"] = request.TableType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTableListByType",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTableListByTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeTableListByTypeResponse DescribeTableListByType(DescribeTableListByTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTableListByTypeWithOptions(request, runtime);
        }

        public async Task<DescribeTableListByTypeResponse> DescribeTableListByTypeAsync(DescribeTableListByTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTableListByTypeWithOptionsAsync(request, runtime);
        }

        public DescribeTablesResponse DescribeTablesWithOptions(DescribeTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CurrentPage"] = request.CurrentPage;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PageSize"] = request.PageSize;
            query["Query"] = request.Query;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTables",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTablesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeTablesResponse> DescribeTablesWithOptionsAsync(DescribeTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CurrentPage"] = request.CurrentPage;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PageSize"] = request.PageSize;
            query["Query"] = request.Query;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTables",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeTablesResponse DescribeTables(DescribeTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTablesWithOptions(request, runtime);
        }

        public async Task<DescribeTablesResponse> DescribeTablesAsync(DescribeTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTablesWithOptionsAsync(request, runtime);
        }

        public DisableSqlAuditResponse DisableSqlAuditWithOptions(DisableSqlAuditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DisableSqlAudit",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableSqlAuditResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisableSqlAuditResponse> DisableSqlAuditWithOptionsAsync(DisableSqlAuditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DisableSqlAudit",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableSqlAuditResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisableSqlAuditResponse DisableSqlAudit(DisableSqlAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableSqlAuditWithOptions(request, runtime);
        }

        public async Task<DisableSqlAuditResponse> DisableSqlAuditAsync(DisableSqlAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableSqlAuditWithOptionsAsync(request, runtime);
        }

        public EnableInstanceIpv6AddressResponse EnableInstanceIpv6AddressWithOptions(EnableInstanceIpv6AddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableInstanceIpv6Address",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableInstanceIpv6AddressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableInstanceIpv6AddressResponse> EnableInstanceIpv6AddressWithOptionsAsync(EnableInstanceIpv6AddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableInstanceIpv6Address",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableInstanceIpv6AddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableInstanceIpv6AddressResponse EnableInstanceIpv6Address(EnableInstanceIpv6AddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableInstanceIpv6AddressWithOptions(request, runtime);
        }

        public async Task<EnableInstanceIpv6AddressResponse> EnableInstanceIpv6AddressAsync(EnableInstanceIpv6AddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableInstanceIpv6AddressWithOptionsAsync(request, runtime);
        }

        public EnableSqlAuditResponse EnableSqlAuditWithOptions(EnableSqlAuditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["IsRecall"] = request.IsRecall;
            query["RecallEndTimestamp"] = request.RecallEndTimestamp;
            query["RecallStartTimestamp"] = request.RecallStartTimestamp;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableSqlAudit",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableSqlAuditResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableSqlAuditResponse> EnableSqlAuditWithOptionsAsync(EnableSqlAuditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["IsRecall"] = request.IsRecall;
            query["RecallEndTimestamp"] = request.RecallEndTimestamp;
            query["RecallStartTimestamp"] = request.RecallStartTimestamp;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableSqlAudit",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableSqlAuditResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableSqlAuditResponse EnableSqlAudit(EnableSqlAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableSqlAuditWithOptions(request, runtime);
        }

        public async Task<EnableSqlAuditResponse> EnableSqlAuditAsync(EnableSqlAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableSqlAuditWithOptionsAsync(request, runtime);
        }

        public EnableSqlFlashbackMatchSwitchResponse EnableSqlFlashbackMatchSwitchWithOptions(EnableSqlFlashbackMatchSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "EnableSqlFlashbackMatchSwitch",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableSqlFlashbackMatchSwitchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableSqlFlashbackMatchSwitchResponse> EnableSqlFlashbackMatchSwitchWithOptionsAsync(EnableSqlFlashbackMatchSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "EnableSqlFlashbackMatchSwitch",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableSqlFlashbackMatchSwitchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableSqlFlashbackMatchSwitchResponse EnableSqlFlashbackMatchSwitch(EnableSqlFlashbackMatchSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableSqlFlashbackMatchSwitchWithOptions(request, runtime);
        }

        public async Task<EnableSqlFlashbackMatchSwitchResponse> EnableSqlFlashbackMatchSwitchAsync(EnableSqlFlashbackMatchSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableSqlFlashbackMatchSwitchWithOptionsAsync(request, runtime);
        }

        public FlashbackRecycleBinTableResponse FlashbackRecycleBinTableWithOptions(FlashbackRecycleBinTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["TableName"] = request.TableName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlashbackRecycleBinTable",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlashbackRecycleBinTableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FlashbackRecycleBinTableResponse> FlashbackRecycleBinTableWithOptionsAsync(FlashbackRecycleBinTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["TableName"] = request.TableName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlashbackRecycleBinTable",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlashbackRecycleBinTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FlashbackRecycleBinTableResponse FlashbackRecycleBinTable(FlashbackRecycleBinTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FlashbackRecycleBinTableWithOptions(request, runtime);
        }

        public async Task<FlashbackRecycleBinTableResponse> FlashbackRecycleBinTableAsync(FlashbackRecycleBinTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FlashbackRecycleBinTableWithOptionsAsync(request, runtime);
        }

        public GetDrdsDbRdsRelationInfoResponse GetDrdsDbRdsRelationInfoWithOptions(GetDrdsDbRdsRelationInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDrdsDbRdsRelationInfo",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDrdsDbRdsRelationInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDrdsDbRdsRelationInfoResponse> GetDrdsDbRdsRelationInfoWithOptionsAsync(GetDrdsDbRdsRelationInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDrdsDbRdsRelationInfo",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDrdsDbRdsRelationInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDrdsDbRdsRelationInfoResponse GetDrdsDbRdsRelationInfo(GetDrdsDbRdsRelationInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDrdsDbRdsRelationInfoWithOptions(request, runtime);
        }

        public async Task<GetDrdsDbRdsRelationInfoResponse> GetDrdsDbRdsRelationInfoAsync(GetDrdsDbRdsRelationInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDrdsDbRdsRelationInfoWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NextToken"] = request.NextToken;
            query["RegionId"] = request.RegionId;
            query["ResourceId"] = request.ResourceId;
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
                Version = "2019-01-23",
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
                Version = "2019-01-23",
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

        public ListUserReportsResponse ListUserReportsWithOptions(ListUserReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["ReportId"] = request.ReportId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserReports",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserReportsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListUserReportsResponse> ListUserReportsWithOptionsAsync(ListUserReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["ReportId"] = request.ReportId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserReports",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserReportsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListUserReportsResponse ListUserReports(ListUserReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserReportsWithOptions(request, runtime);
        }

        public async Task<ListUserReportsResponse> ListUserReportsAsync(ListUserReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserReportsWithOptionsAsync(request, runtime);
        }

        public ListVersionsResponse ListVersionsWithOptions(ListVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["DrdsVer"] = request.DrdsVer;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVersions",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVersionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListVersionsResponse> ListVersionsWithOptionsAsync(ListVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["DrdsVer"] = request.DrdsVer;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVersions",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListVersionsResponse ListVersions(ListVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVersionsWithOptions(request, runtime);
        }

        public async Task<ListVersionsResponse> ListVersionsAsync(ListVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVersionsWithOptionsAsync(request, runtime);
        }

        public ManagePrivateRdsResponse ManagePrivateRdsWithOptions(ManagePrivateRdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DBInstanceId"] = request.DBInstanceId;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["Params"] = request.Params;
            query["RdsAction"] = request.RdsAction;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ManagePrivateRds",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManagePrivateRdsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ManagePrivateRdsResponse> ManagePrivateRdsWithOptionsAsync(ManagePrivateRdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DBInstanceId"] = request.DBInstanceId;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["Params"] = request.Params;
            query["RdsAction"] = request.RdsAction;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ManagePrivateRds",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManagePrivateRdsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ManagePrivateRdsResponse ManagePrivateRds(ManagePrivateRdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ManagePrivateRdsWithOptions(request, runtime);
        }

        public async Task<ManagePrivateRdsResponse> ManagePrivateRdsAsync(ManagePrivateRdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ManagePrivateRdsWithOptionsAsync(request, runtime);
        }

        public ModifyAccountDescriptionResponse ModifyAccountDescriptionWithOptions(ModifyAccountDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["Description"] = request.Description;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAccountDescription",
                Version = "2019-01-23",
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
            query["AccountName"] = request.AccountName;
            query["Description"] = request.Description;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAccountDescription",
                Version = "2019-01-23",
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

        public ModifyAccountPrivilegeResponse ModifyAccountPrivilegeWithOptions(ModifyAccountPrivilegeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["DbPrivilege"] = request.DbPrivilege;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAccountPrivilege",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAccountPrivilegeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyAccountPrivilegeResponse> ModifyAccountPrivilegeWithOptionsAsync(ModifyAccountPrivilegeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["DbPrivilege"] = request.DbPrivilege;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAccountPrivilege",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAccountPrivilegeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyAccountPrivilegeResponse ModifyAccountPrivilege(ModifyAccountPrivilegeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAccountPrivilegeWithOptions(request, runtime);
        }

        public async Task<ModifyAccountPrivilegeResponse> ModifyAccountPrivilegeAsync(ModifyAccountPrivilegeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAccountPrivilegeWithOptionsAsync(request, runtime);
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
                Version = "2019-01-23",
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
                Version = "2019-01-23",
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
                Version = "2019-01-23",
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
                Version = "2019-01-23",
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

        public ModifyEventTaskStatusResponse ModifyEventTaskStatusWithOptions(ModifyEventTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EventId"] = request.EventId;
            query["Region"] = request.Region;
            query["SwitchTime"] = request.SwitchTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyEventTaskStatus",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyEventTaskStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyEventTaskStatusResponse> ModifyEventTaskStatusWithOptionsAsync(ModifyEventTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EventId"] = request.EventId;
            query["Region"] = request.Region;
            query["SwitchTime"] = request.SwitchTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyEventTaskStatus",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyEventTaskStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyEventTaskStatusResponse ModifyEventTaskStatus(ModifyEventTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyEventTaskStatusWithOptions(request, runtime);
        }

        public async Task<ModifyEventTaskStatusResponse> ModifyEventTaskStatusAsync(ModifyEventTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyEventTaskStatusWithOptionsAsync(request, runtime);
        }

        public ModifyPolarDbReadWeightResponse ModifyPolarDbReadWeightWithOptions(ModifyPolarDbReadWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbInstanceId"] = request.DbInstanceId;
            query["DbName"] = request.DbName;
            query["DbNodeIds"] = request.DbNodeIds;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["Weights"] = request.Weights;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPolarDbReadWeight",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPolarDbReadWeightResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyPolarDbReadWeightResponse> ModifyPolarDbReadWeightWithOptionsAsync(ModifyPolarDbReadWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbInstanceId"] = request.DbInstanceId;
            query["DbName"] = request.DbName;
            query["DbNodeIds"] = request.DbNodeIds;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["Weights"] = request.Weights;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPolarDbReadWeight",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPolarDbReadWeightResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyPolarDbReadWeightResponse ModifyPolarDbReadWeight(ModifyPolarDbReadWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPolarDbReadWeightWithOptions(request, runtime);
        }

        public async Task<ModifyPolarDbReadWeightResponse> ModifyPolarDbReadWeightAsync(ModifyPolarDbReadWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPolarDbReadWeightWithOptionsAsync(request, runtime);
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
                Version = "2019-01-23",
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
                Version = "2019-01-23",
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

        public PreCheckSqlFlashbackTaskResponse PreCheckSqlFlashbackTaskWithOptions(PreCheckSqlFlashbackTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["EndTime"] = request.EndTime;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreCheckSqlFlashbackTask",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreCheckSqlFlashbackTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PreCheckSqlFlashbackTaskResponse> PreCheckSqlFlashbackTaskWithOptionsAsync(PreCheckSqlFlashbackTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["EndTime"] = request.EndTime;
            query["StartTime"] = request.StartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreCheckSqlFlashbackTask",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreCheckSqlFlashbackTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PreCheckSqlFlashbackTaskResponse PreCheckSqlFlashbackTask(PreCheckSqlFlashbackTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PreCheckSqlFlashbackTaskWithOptions(request, runtime);
        }

        public async Task<PreCheckSqlFlashbackTaskResponse> PreCheckSqlFlashbackTaskAsync(PreCheckSqlFlashbackTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PreCheckSqlFlashbackTaskWithOptionsAsync(request, runtime);
        }

        public PutRestorePreCheckResponse PutRestorePreCheckWithOptions(PutRestorePreCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackupDbNames"] = request.BackupDbNames;
            query["BackupId"] = request.BackupId;
            query["BackupLevel"] = request.BackupLevel;
            query["BackupMode"] = request.BackupMode;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PreferredBackupTime"] = request.PreferredBackupTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutRestorePreCheck",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutRestorePreCheckResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PutRestorePreCheckResponse> PutRestorePreCheckWithOptionsAsync(PutRestorePreCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackupDbNames"] = request.BackupDbNames;
            query["BackupId"] = request.BackupId;
            query["BackupLevel"] = request.BackupLevel;
            query["BackupMode"] = request.BackupMode;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PreferredBackupTime"] = request.PreferredBackupTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutRestorePreCheck",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutRestorePreCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PutRestorePreCheckResponse PutRestorePreCheck(PutRestorePreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutRestorePreCheckWithOptions(request, runtime);
        }

        public async Task<PutRestorePreCheckResponse> PutRestorePreCheckAsync(PutRestorePreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutRestorePreCheckWithOptionsAsync(request, runtime);
        }

        public PutStartBackupResponse PutStartBackupWithOptions(PutStartBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackupDbNames"] = request.BackupDbNames;
            query["BackupLevel"] = request.BackupLevel;
            query["BackupMode"] = request.BackupMode;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutStartBackup",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutStartBackupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PutStartBackupResponse> PutStartBackupWithOptionsAsync(PutStartBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackupDbNames"] = request.BackupDbNames;
            query["BackupLevel"] = request.BackupLevel;
            query["BackupMode"] = request.BackupMode;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutStartBackup",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutStartBackupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PutStartBackupResponse PutStartBackup(PutStartBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutStartBackupWithOptions(request, runtime);
        }

        public async Task<PutStartBackupResponse> PutStartBackupAsync(PutStartBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutStartBackupWithOptionsAsync(request, runtime);
        }

        public RearrangeDbToInstanceResponse RearrangeDbToInstanceWithOptions(RearrangeDbToInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ChooseRds"] = request.ChooseRds;
            query["ChooseSubDb"] = request.ChooseSubDb;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["InstanceList"] = request.InstanceList;
            query["OrderId"] = request.OrderId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RearrangeDbToInstance",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RearrangeDbToInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RearrangeDbToInstanceResponse> RearrangeDbToInstanceWithOptionsAsync(RearrangeDbToInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ChooseRds"] = request.ChooseRds;
            query["ChooseSubDb"] = request.ChooseSubDb;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["InstanceList"] = request.InstanceList;
            query["OrderId"] = request.OrderId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RearrangeDbToInstance",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RearrangeDbToInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RearrangeDbToInstanceResponse RearrangeDbToInstance(RearrangeDbToInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RearrangeDbToInstanceWithOptions(request, runtime);
        }

        public async Task<RearrangeDbToInstanceResponse> RearrangeDbToInstanceAsync(RearrangeDbToInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RearrangeDbToInstanceWithOptionsAsync(request, runtime);
        }

        public RefreshDrdsAtomUrlResponse RefreshDrdsAtomUrlWithOptions(RefreshDrdsAtomUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RefreshDrdsAtomUrl",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshDrdsAtomUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RefreshDrdsAtomUrlResponse> RefreshDrdsAtomUrlWithOptionsAsync(RefreshDrdsAtomUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RefreshDrdsAtomUrl",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshDrdsAtomUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RefreshDrdsAtomUrlResponse RefreshDrdsAtomUrl(RefreshDrdsAtomUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshDrdsAtomUrlWithOptions(request, runtime);
        }

        public async Task<RefreshDrdsAtomUrlResponse> RefreshDrdsAtomUrlAsync(RefreshDrdsAtomUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshDrdsAtomUrlWithOptionsAsync(request, runtime);
        }

        public ReleaseInstanceInternetAddressResponse ReleaseInstanceInternetAddressWithOptions(ReleaseInstanceInternetAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseInstanceInternetAddress",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseInstanceInternetAddressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReleaseInstanceInternetAddressResponse> ReleaseInstanceInternetAddressWithOptionsAsync(ReleaseInstanceInternetAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseInstanceInternetAddress",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseInstanceInternetAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReleaseInstanceInternetAddressResponse ReleaseInstanceInternetAddress(ReleaseInstanceInternetAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseInstanceInternetAddressWithOptions(request, runtime);
        }

        public async Task<ReleaseInstanceInternetAddressResponse> ReleaseInstanceInternetAddressAsync(ReleaseInstanceInternetAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseInstanceInternetAddressWithOptionsAsync(request, runtime);
        }

        public RemoveBackupsSetResponse RemoveBackupsSetWithOptions(RemoveBackupsSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackupId"] = request.BackupId;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveBackupsSet",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveBackupsSetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveBackupsSetResponse> RemoveBackupsSetWithOptionsAsync(RemoveBackupsSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackupId"] = request.BackupId;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveBackupsSet",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveBackupsSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveBackupsSetResponse RemoveBackupsSet(RemoveBackupsSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveBackupsSetWithOptions(request, runtime);
        }

        public async Task<RemoveBackupsSetResponse> RemoveBackupsSetAsync(RemoveBackupsSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveBackupsSetWithOptionsAsync(request, runtime);
        }

        public RemoveDrdsDbResponse RemoveDrdsDbWithOptions(RemoveDrdsDbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RemoveDrdsDb",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveDrdsDbResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveDrdsDbResponse> RemoveDrdsDbWithOptionsAsync(RemoveDrdsDbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RemoveDrdsDb",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveDrdsDbResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveDrdsDbResponse RemoveDrdsDb(RemoveDrdsDbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveDrdsDbWithOptions(request, runtime);
        }

        public async Task<RemoveDrdsDbResponse> RemoveDrdsDbAsync(RemoveDrdsDbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveDrdsDbWithOptionsAsync(request, runtime);
        }

        public RemoveDrdsDbFailedRecordResponse RemoveDrdsDbFailedRecordWithOptions(RemoveDrdsDbFailedRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RemoveDrdsDbFailedRecord",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveDrdsDbFailedRecordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveDrdsDbFailedRecordResponse> RemoveDrdsDbFailedRecordWithOptionsAsync(RemoveDrdsDbFailedRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RemoveDrdsDbFailedRecord",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveDrdsDbFailedRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveDrdsDbFailedRecordResponse RemoveDrdsDbFailedRecord(RemoveDrdsDbFailedRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveDrdsDbFailedRecordWithOptions(request, runtime);
        }

        public async Task<RemoveDrdsDbFailedRecordResponse> RemoveDrdsDbFailedRecordAsync(RemoveDrdsDbFailedRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveDrdsDbFailedRecordWithOptionsAsync(request, runtime);
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
                Version = "2019-01-23",
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
                Version = "2019-01-23",
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

        public RemoveDrdsMysqlResponse RemoveDrdsMysqlWithOptions(RemoveDrdsMysqlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbInstanceId"] = request.DbInstanceId;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["Force"] = request.Force;
            query["RoDbInstanceId"] = request.RoDbInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveDrdsMysql",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveDrdsMysqlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveDrdsMysqlResponse> RemoveDrdsMysqlWithOptionsAsync(RemoveDrdsMysqlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbInstanceId"] = request.DbInstanceId;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["Force"] = request.Force;
            query["RoDbInstanceId"] = request.RoDbInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveDrdsMysql",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveDrdsMysqlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveDrdsMysqlResponse RemoveDrdsMysql(RemoveDrdsMysqlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveDrdsMysqlWithOptions(request, runtime);
        }

        public async Task<RemoveDrdsMysqlResponse> RemoveDrdsMysqlAsync(RemoveDrdsMysqlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveDrdsMysqlWithOptionsAsync(request, runtime);
        }

        public RemoveInstanceAccountResponse RemoveInstanceAccountWithOptions(RemoveInstanceAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveInstanceAccount",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveInstanceAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveInstanceAccountResponse> RemoveInstanceAccountWithOptionsAsync(RemoveInstanceAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccountName"] = request.AccountName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveInstanceAccount",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveInstanceAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveInstanceAccountResponse RemoveInstanceAccount(RemoveInstanceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveInstanceAccountWithOptions(request, runtime);
        }

        public async Task<RemoveInstanceAccountResponse> RemoveInstanceAccountAsync(RemoveInstanceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveInstanceAccountWithOptionsAsync(request, runtime);
        }

        public RemoveRecycleBinTableResponse RemoveRecycleBinTableWithOptions(RemoveRecycleBinTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["TableName"] = request.TableName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveRecycleBinTable",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveRecycleBinTableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveRecycleBinTableResponse> RemoveRecycleBinTableWithOptionsAsync(RemoveRecycleBinTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["TableName"] = request.TableName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveRecycleBinTable",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveRecycleBinTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveRecycleBinTableResponse RemoveRecycleBinTable(RemoveRecycleBinTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveRecycleBinTableWithOptions(request, runtime);
        }

        public async Task<RemoveRecycleBinTableResponse> RemoveRecycleBinTableAsync(RemoveRecycleBinTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveRecycleBinTableWithOptionsAsync(request, runtime);
        }

        public RestartDrdsInstanceResponse RestartDrdsInstanceWithOptions(RestartDrdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RestartDrdsInstance",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartDrdsInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RestartDrdsInstanceResponse> RestartDrdsInstanceWithOptionsAsync(RestartDrdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RestartDrdsInstance",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartDrdsInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RestartDrdsInstanceResponse RestartDrdsInstance(RestartDrdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartDrdsInstanceWithOptions(request, runtime);
        }

        public async Task<RestartDrdsInstanceResponse> RestartDrdsInstanceAsync(RestartDrdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartDrdsInstanceWithOptionsAsync(request, runtime);
        }

        public RollbackInstanceVersionResponse RollbackInstanceVersionWithOptions(RollbackInstanceVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackInstanceVersion",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackInstanceVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RollbackInstanceVersionResponse> RollbackInstanceVersionWithOptionsAsync(RollbackInstanceVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackInstanceVersion",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackInstanceVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RollbackInstanceVersionResponse RollbackInstanceVersion(RollbackInstanceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RollbackInstanceVersionWithOptions(request, runtime);
        }

        public async Task<RollbackInstanceVersionResponse> RollbackInstanceVersionAsync(RollbackInstanceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RollbackInstanceVersionWithOptionsAsync(request, runtime);
        }

        public SetBackupLocalResponse SetBackupLocalWithOptions(SetBackupLocalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["HighSpaceUsageProtection"] = request.HighSpaceUsageProtection;
            query["LocalLogRetentionHours"] = request.LocalLogRetentionHours;
            query["LocalLogRetentionSpace"] = request.LocalLogRetentionSpace;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetBackupLocal",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetBackupLocalResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetBackupLocalResponse> SetBackupLocalWithOptionsAsync(SetBackupLocalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["HighSpaceUsageProtection"] = request.HighSpaceUsageProtection;
            query["LocalLogRetentionHours"] = request.LocalLogRetentionHours;
            query["LocalLogRetentionSpace"] = request.LocalLogRetentionSpace;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetBackupLocal",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetBackupLocalResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetBackupLocalResponse SetBackupLocal(SetBackupLocalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetBackupLocalWithOptions(request, runtime);
        }

        public async Task<SetBackupLocalResponse> SetBackupLocalAsync(SetBackupLocalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetBackupLocalWithOptionsAsync(request, runtime);
        }

        public SetBackupPolicyResponse SetBackupPolicyWithOptions(SetBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackupDbNames"] = request.BackupDbNames;
            query["BackupLevel"] = request.BackupLevel;
            query["BackupLog"] = request.BackupLog;
            query["BackupMode"] = request.BackupMode;
            query["DataBackupRetentionPeriod"] = request.DataBackupRetentionPeriod;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["LogBackupRetentionPeriod"] = request.LogBackupRetentionPeriod;
            query["PreferredBackupEndTime"] = request.PreferredBackupEndTime;
            query["PreferredBackupPeriod"] = request.PreferredBackupPeriod;
            query["PreferredBackupStartTime"] = request.PreferredBackupStartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetBackupPolicy",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetBackupPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetBackupPolicyResponse> SetBackupPolicyWithOptionsAsync(SetBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackupDbNames"] = request.BackupDbNames;
            query["BackupLevel"] = request.BackupLevel;
            query["BackupLog"] = request.BackupLog;
            query["BackupMode"] = request.BackupMode;
            query["DataBackupRetentionPeriod"] = request.DataBackupRetentionPeriod;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["LogBackupRetentionPeriod"] = request.LogBackupRetentionPeriod;
            query["PreferredBackupEndTime"] = request.PreferredBackupEndTime;
            query["PreferredBackupPeriod"] = request.PreferredBackupPeriod;
            query["PreferredBackupStartTime"] = request.PreferredBackupStartTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetBackupPolicy",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetBackupPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetBackupPolicyResponse SetBackupPolicy(SetBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetBackupPolicyWithOptions(request, runtime);
        }

        public async Task<SetBackupPolicyResponse> SetBackupPolicyAsync(SetBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetBackupPolicyWithOptionsAsync(request, runtime);
        }

        public SetupBroadcastTablesResponse SetupBroadcastTablesWithOptions(SetupBroadcastTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Active"] = request.Active;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["TableName"] = request.TableName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetupBroadcastTables",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetupBroadcastTablesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetupBroadcastTablesResponse> SetupBroadcastTablesWithOptionsAsync(SetupBroadcastTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Active"] = request.Active;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["TableName"] = request.TableName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetupBroadcastTables",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetupBroadcastTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetupBroadcastTablesResponse SetupBroadcastTables(SetupBroadcastTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetupBroadcastTablesWithOptions(request, runtime);
        }

        public async Task<SetupBroadcastTablesResponse> SetupBroadcastTablesAsync(SetupBroadcastTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetupBroadcastTablesWithOptionsAsync(request, runtime);
        }

        public SetupDrdsParamsResponse SetupDrdsParamsWithOptions(SetupDrdsParamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Data"] = request.Data;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["ParamLevel"] = request.ParamLevel;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetupDrdsParams",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetupDrdsParamsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetupDrdsParamsResponse> SetupDrdsParamsWithOptionsAsync(SetupDrdsParamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Data"] = request.Data;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["ParamLevel"] = request.ParamLevel;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetupDrdsParams",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetupDrdsParamsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetupDrdsParamsResponse SetupDrdsParams(SetupDrdsParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetupDrdsParamsWithOptions(request, runtime);
        }

        public async Task<SetupDrdsParamsResponse> SetupDrdsParamsAsync(SetupDrdsParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetupDrdsParamsWithOptionsAsync(request, runtime);
        }

        public SetupRecycleBinStatusResponse SetupRecycleBinStatusWithOptions(SetupRecycleBinStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["StatusAction"] = request.StatusAction;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetupRecycleBinStatus",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetupRecycleBinStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetupRecycleBinStatusResponse> SetupRecycleBinStatusWithOptionsAsync(SetupRecycleBinStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["StatusAction"] = request.StatusAction;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetupRecycleBinStatus",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetupRecycleBinStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetupRecycleBinStatusResponse SetupRecycleBinStatus(SetupRecycleBinStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetupRecycleBinStatusWithOptions(request, runtime);
        }

        public async Task<SetupRecycleBinStatusResponse> SetupRecycleBinStatusAsync(SetupRecycleBinStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetupRecycleBinStatusWithOptionsAsync(request, runtime);
        }

        public SetupTableResponse SetupTableWithOptions(SetupTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AllowFullTableScan"] = request.AllowFullTableScan;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["TableName"] = request.TableName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetupTable",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetupTableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetupTableResponse> SetupTableWithOptionsAsync(SetupTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AllowFullTableScan"] = request.AllowFullTableScan;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["TableName"] = request.TableName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetupTable",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetupTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetupTableResponse SetupTable(SetupTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetupTableWithOptions(request, runtime);
        }

        public async Task<SetupTableResponse> SetupTableAsync(SetupTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetupTableWithOptionsAsync(request, runtime);
        }

        public SetupTableAsyncResponse SetupTableAsyncWithOptions(SetupTableAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AllowFullTableScan"] = request.AllowFullTableScan;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["TableName"] = request.TableName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetupTableAsync",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetupTableAsyncResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetupTableAsyncResponse> SetupTableAsyncWithOptionsAsync(SetupTableAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AllowFullTableScan"] = request.AllowFullTableScan;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["TableName"] = request.TableName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetupTableAsync",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetupTableAsyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetupTableAsyncResponse SetupTableAsync(SetupTableAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetupTableAsyncWithOptions(request, runtime);
        }

        public async Task<SetupTableAsyncResponse> SetupTableAsyncAsync(SetupTableAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetupTableAsyncWithOptionsAsync(request, runtime);
        }

        public SqlCompatibilityCancelResponse SqlCompatibilityCancelWithOptions(SqlCompatibilityCancelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["TaskId"] = request.TaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SqlCompatibilityCancel",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SqlCompatibilityCancelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SqlCompatibilityCancelResponse> SqlCompatibilityCancelWithOptionsAsync(SqlCompatibilityCancelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["TaskId"] = request.TaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SqlCompatibilityCancel",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SqlCompatibilityCancelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SqlCompatibilityCancelResponse SqlCompatibilityCancel(SqlCompatibilityCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SqlCompatibilityCancelWithOptions(request, runtime);
        }

        public async Task<SqlCompatibilityCancelResponse> SqlCompatibilityCancelAsync(SqlCompatibilityCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SqlCompatibilityCancelWithOptionsAsync(request, runtime);
        }

        public SqlCompatibilityStartResponse SqlCompatibilityStartWithOptions(SqlCompatibilityStartRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PerformanceTest"] = request.PerformanceTest;
            query["TargetVersion"] = request.TargetVersion;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SqlCompatibilityStart",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SqlCompatibilityStartResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SqlCompatibilityStartResponse> SqlCompatibilityStartWithOptionsAsync(SqlCompatibilityStartRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PerformanceTest"] = request.PerformanceTest;
            query["TargetVersion"] = request.TargetVersion;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SqlCompatibilityStart",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SqlCompatibilityStartResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SqlCompatibilityStartResponse SqlCompatibilityStart(SqlCompatibilityStartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SqlCompatibilityStartWithOptions(request, runtime);
        }

        public async Task<SqlCompatibilityStartResponse> SqlCompatibilityStartAsync(SqlCompatibilityStartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SqlCompatibilityStartWithOptionsAsync(request, runtime);
        }

        public StartRestoreResponse StartRestoreWithOptions(StartRestoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackupDbNames"] = request.BackupDbNames;
            query["BackupId"] = request.BackupId;
            query["BackupLevel"] = request.BackupLevel;
            query["BackupMode"] = request.BackupMode;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PreferredBackupTime"] = request.PreferredBackupTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartRestore",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartRestoreResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartRestoreResponse> StartRestoreWithOptionsAsync(StartRestoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackupDbNames"] = request.BackupDbNames;
            query["BackupId"] = request.BackupId;
            query["BackupLevel"] = request.BackupLevel;
            query["BackupMode"] = request.BackupMode;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PreferredBackupTime"] = request.PreferredBackupTime;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartRestore",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartRestoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartRestoreResponse StartRestore(StartRestoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartRestoreWithOptions(request, runtime);
        }

        public async Task<StartRestoreResponse> StartRestoreAsync(StartRestoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartRestoreWithOptionsAsync(request, runtime);
        }

        public SubmitCleanTaskResponse SubmitCleanTaskWithOptions(SubmitCleanTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["ExpandType"] = request.ExpandType;
            query["JobId"] = request.JobId;
            query["ParentJobId"] = request.ParentJobId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitCleanTask",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitCleanTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitCleanTaskResponse> SubmitCleanTaskWithOptionsAsync(SubmitCleanTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["ExpandType"] = request.ExpandType;
            query["JobId"] = request.JobId;
            query["ParentJobId"] = request.ParentJobId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitCleanTask",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitCleanTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitCleanTaskResponse SubmitCleanTask(SubmitCleanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitCleanTaskWithOptions(request, runtime);
        }

        public async Task<SubmitCleanTaskResponse> SubmitCleanTaskAsync(SubmitCleanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitCleanTaskWithOptionsAsync(request, runtime);
        }

        public SubmitHotExpandPreCheckTaskResponse SubmitHotExpandPreCheckTaskWithOptions(SubmitHotExpandPreCheckTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbInstType"] = request.DbInstType;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["TableList"] = request.TableList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitHotExpandPreCheckTask",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitHotExpandPreCheckTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitHotExpandPreCheckTaskResponse> SubmitHotExpandPreCheckTaskWithOptionsAsync(SubmitHotExpandPreCheckTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbInstType"] = request.DbInstType;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["TableList"] = request.TableList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitHotExpandPreCheckTask",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitHotExpandPreCheckTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitHotExpandPreCheckTaskResponse SubmitHotExpandPreCheckTask(SubmitHotExpandPreCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitHotExpandPreCheckTaskWithOptions(request, runtime);
        }

        public async Task<SubmitHotExpandPreCheckTaskResponse> SubmitHotExpandPreCheckTaskAsync(SubmitHotExpandPreCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitHotExpandPreCheckTaskWithOptionsAsync(request, runtime);
        }

        public SubmitHotExpandTaskResponse SubmitHotExpandTaskWithOptions(SubmitHotExpandTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["ExtendedMapping"] = request.ExtendedMapping;
            query["InstanceDbMapping"] = request.InstanceDbMapping;
            query["Mapping"] = request.Mapping;
            query["SupperAccountMapping"] = request.SupperAccountMapping;
            query["TaskDesc"] = request.TaskDesc;
            query["TaskName"] = request.TaskName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitHotExpandTask",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitHotExpandTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitHotExpandTaskResponse> SubmitHotExpandTaskWithOptionsAsync(SubmitHotExpandTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["ExtendedMapping"] = request.ExtendedMapping;
            query["InstanceDbMapping"] = request.InstanceDbMapping;
            query["Mapping"] = request.Mapping;
            query["SupperAccountMapping"] = request.SupperAccountMapping;
            query["TaskDesc"] = request.TaskDesc;
            query["TaskName"] = request.TaskName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitHotExpandTask",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitHotExpandTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitHotExpandTaskResponse SubmitHotExpandTask(SubmitHotExpandTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitHotExpandTaskWithOptions(request, runtime);
        }

        public async Task<SubmitHotExpandTaskResponse> SubmitHotExpandTaskAsync(SubmitHotExpandTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitHotExpandTaskWithOptionsAsync(request, runtime);
        }

        public SubmitSmoothExpandPreCheckResponse SubmitSmoothExpandPreCheckWithOptions(SubmitSmoothExpandPreCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbInstType"] = request.DbInstType;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSmoothExpandPreCheck",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSmoothExpandPreCheckResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitSmoothExpandPreCheckResponse> SubmitSmoothExpandPreCheckWithOptionsAsync(SubmitSmoothExpandPreCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbInstType"] = request.DbInstType;
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSmoothExpandPreCheck",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSmoothExpandPreCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitSmoothExpandPreCheckResponse SubmitSmoothExpandPreCheck(SubmitSmoothExpandPreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSmoothExpandPreCheckWithOptions(request, runtime);
        }

        public async Task<SubmitSmoothExpandPreCheckResponse> SubmitSmoothExpandPreCheckAsync(SubmitSmoothExpandPreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSmoothExpandPreCheckWithOptionsAsync(request, runtime);
        }

        public SubmitSmoothExpandPreCheckTaskResponse SubmitSmoothExpandPreCheckTaskWithOptions(SubmitSmoothExpandPreCheckTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SubmitSmoothExpandPreCheckTask",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSmoothExpandPreCheckTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitSmoothExpandPreCheckTaskResponse> SubmitSmoothExpandPreCheckTaskWithOptionsAsync(SubmitSmoothExpandPreCheckTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SubmitSmoothExpandPreCheckTask",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSmoothExpandPreCheckTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitSmoothExpandPreCheckTaskResponse SubmitSmoothExpandPreCheckTask(SubmitSmoothExpandPreCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSmoothExpandPreCheckTaskWithOptions(request, runtime);
        }

        public async Task<SubmitSmoothExpandPreCheckTaskResponse> SubmitSmoothExpandPreCheckTaskAsync(SubmitSmoothExpandPreCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSmoothExpandPreCheckTaskWithOptionsAsync(request, runtime);
        }

        public SubmitSqlFlashbackTaskResponse SubmitSqlFlashbackTaskWithOptions(SubmitSqlFlashbackTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["EndTime"] = request.EndTime;
            query["RecallRestoreType"] = request.RecallRestoreType;
            query["RecallType"] = request.RecallType;
            query["SqlPk"] = request.SqlPk;
            query["SqlType"] = request.SqlType;
            query["StartTime"] = request.StartTime;
            query["TableName"] = request.TableName;
            query["TraceId"] = request.TraceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSqlFlashbackTask",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSqlFlashbackTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitSqlFlashbackTaskResponse> SubmitSqlFlashbackTaskWithOptionsAsync(SubmitSqlFlashbackTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["EndTime"] = request.EndTime;
            query["RecallRestoreType"] = request.RecallRestoreType;
            query["RecallType"] = request.RecallType;
            query["SqlPk"] = request.SqlPk;
            query["SqlType"] = request.SqlType;
            query["StartTime"] = request.StartTime;
            query["TableName"] = request.TableName;
            query["TraceId"] = request.TraceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSqlFlashbackTask",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSqlFlashbackTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitSqlFlashbackTaskResponse SubmitSqlFlashbackTask(SubmitSqlFlashbackTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSqlFlashbackTaskWithOptions(request, runtime);
        }

        public async Task<SubmitSqlFlashbackTaskResponse> SubmitSqlFlashbackTaskAsync(SubmitSqlFlashbackTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSqlFlashbackTaskWithOptionsAsync(request, runtime);
        }

        public SwitchGlobalBroadcastTypeResponse SwitchGlobalBroadcastTypeWithOptions(SwitchGlobalBroadcastTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SwitchGlobalBroadcastType",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchGlobalBroadcastTypeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SwitchGlobalBroadcastTypeResponse> SwitchGlobalBroadcastTypeWithOptionsAsync(SwitchGlobalBroadcastTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SwitchGlobalBroadcastType",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchGlobalBroadcastTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SwitchGlobalBroadcastTypeResponse SwitchGlobalBroadcastType(SwitchGlobalBroadcastTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchGlobalBroadcastTypeWithOptions(request, runtime);
        }

        public async Task<SwitchGlobalBroadcastTypeResponse> SwitchGlobalBroadcastTypeAsync(SwitchGlobalBroadcastTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchGlobalBroadcastTypeWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["ResourceId"] = request.ResourceId;
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
                Version = "2019-01-23",
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
                Version = "2019-01-23",
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

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["All"] = request.All;
            query["RegionId"] = request.RegionId;
            query["ResourceId"] = request.ResourceId;
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
                Version = "2019-01-23",
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
                Version = "2019-01-23",
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

        public UpdateInstanceNetworkResponse UpdateInstanceNetworkWithOptions(UpdateInstanceNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClassicExpiredDays"] = request.ClassicExpiredDays;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RetainClassic"] = request.RetainClassic;
            query["SrcInstanceNetworkType"] = request.SrcInstanceNetworkType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceNetwork",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceNetworkResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateInstanceNetworkResponse> UpdateInstanceNetworkWithOptionsAsync(UpdateInstanceNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClassicExpiredDays"] = request.ClassicExpiredDays;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RetainClassic"] = request.RetainClassic;
            query["SrcInstanceNetworkType"] = request.SrcInstanceNetworkType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceNetwork",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceNetworkResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateInstanceNetworkResponse UpdateInstanceNetwork(UpdateInstanceNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceNetworkWithOptions(request, runtime);
        }

        public async Task<UpdateInstanceNetworkResponse> UpdateInstanceNetworkAsync(UpdateInstanceNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceNetworkWithOptionsAsync(request, runtime);
        }

        public UpdatePrivateRdsClassResponse UpdatePrivateRdsClassWithOptions(UpdatePrivateRdsClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoUseCoupon"] = request.AutoUseCoupon;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PrePayDuration"] = request.PrePayDuration;
            query["RdsClass"] = request.RdsClass;
            query["Storage"] = request.Storage;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePrivateRdsClass",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePrivateRdsClassResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdatePrivateRdsClassResponse> UpdatePrivateRdsClassWithOptionsAsync(UpdatePrivateRdsClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoUseCoupon"] = request.AutoUseCoupon;
            query["DBInstanceId"] = request.DBInstanceId;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["PrePayDuration"] = request.PrePayDuration;
            query["RdsClass"] = request.RdsClass;
            query["Storage"] = request.Storage;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePrivateRdsClass",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePrivateRdsClassResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdatePrivateRdsClassResponse UpdatePrivateRdsClass(UpdatePrivateRdsClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePrivateRdsClassWithOptions(request, runtime);
        }

        public async Task<UpdatePrivateRdsClassResponse> UpdatePrivateRdsClassAsync(UpdatePrivateRdsClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePrivateRdsClassWithOptionsAsync(request, runtime);
        }

        public UpdateResourceGroupAttributeResponse UpdateResourceGroupAttributeWithOptions(UpdateResourceGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["NewResourceGroupId"] = request.NewResourceGroupId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourceGroupAttribute",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceGroupAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateResourceGroupAttributeResponse> UpdateResourceGroupAttributeWithOptionsAsync(UpdateResourceGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["NewResourceGroupId"] = request.NewResourceGroupId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourceGroupAttribute",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceGroupAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateResourceGroupAttributeResponse UpdateResourceGroupAttribute(UpdateResourceGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateResourceGroupAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateResourceGroupAttributeResponse> UpdateResourceGroupAttributeAsync(UpdateResourceGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateResourceGroupAttributeWithOptionsAsync(request, runtime);
        }

        public UpgradeHiStoreInstanceResponse UpgradeHiStoreInstanceWithOptions(UpgradeHiStoreInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["HistoreInstanceId"] = request.HistoreInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeHiStoreInstance",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeHiStoreInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpgradeHiStoreInstanceResponse> UpgradeHiStoreInstanceWithOptionsAsync(UpgradeHiStoreInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["HistoreInstanceId"] = request.HistoreInstanceId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeHiStoreInstance",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeHiStoreInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpgradeHiStoreInstanceResponse UpgradeHiStoreInstance(UpgradeHiStoreInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeHiStoreInstanceWithOptions(request, runtime);
        }

        public async Task<UpgradeHiStoreInstanceResponse> UpgradeHiStoreInstanceAsync(UpgradeHiStoreInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeHiStoreInstanceWithOptionsAsync(request, runtime);
        }

        public UpgradeInstanceVersionResponse UpgradeInstanceVersionWithOptions(UpgradeInstanceVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["Rpm"] = request.Rpm;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeInstanceVersion",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeInstanceVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpgradeInstanceVersionResponse> UpgradeInstanceVersionWithOptionsAsync(UpgradeInstanceVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["Rpm"] = request.Rpm;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeInstanceVersion",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeInstanceVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpgradeInstanceVersionResponse UpgradeInstanceVersion(UpgradeInstanceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeInstanceVersionWithOptions(request, runtime);
        }

        public async Task<UpgradeInstanceVersionResponse> UpgradeInstanceVersionAsync(UpgradeInstanceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeInstanceVersionWithOptionsAsync(request, runtime);
        }

        public ValidateShardTaskResponse ValidateShardTaskWithOptions(ValidateShardTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["SourceTableName"] = request.SourceTableName;
            query["TargetTableName"] = request.TargetTableName;
            query["TaskType"] = request.TaskType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateShardTask",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateShardTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ValidateShardTaskResponse> ValidateShardTaskWithOptionsAsync(ValidateShardTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DbName"] = request.DbName;
            query["DrdsInstanceId"] = request.DrdsInstanceId;
            query["RegionId"] = request.RegionId;
            query["SourceTableName"] = request.SourceTableName;
            query["TargetTableName"] = request.TargetTableName;
            query["TaskType"] = request.TaskType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateShardTask",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateShardTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ValidateShardTaskResponse ValidateShardTask(ValidateShardTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ValidateShardTaskWithOptions(request, runtime);
        }

        public async Task<ValidateShardTaskResponse> ValidateShardTaskAsync(ValidateShardTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ValidateShardTaskWithOptionsAsync(request, runtime);
        }

        public DescribeRdsInstInfosResponse DescribeRdsInstInfosWithOptions(DescribeRdsInstInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["Search"] = request.Search;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "describeRdsInstInfos",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRdsInstInfosResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRdsInstInfosResponse> DescribeRdsInstInfosWithOptionsAsync(DescribeRdsInstInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["Search"] = request.Search;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "describeRdsInstInfos",
                Version = "2019-01-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRdsInstInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRdsInstInfosResponse DescribeRdsInstInfos(DescribeRdsInstInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRdsInstInfosWithOptions(request, runtime);
        }

        public async Task<DescribeRdsInstInfosResponse> DescribeRdsInstInfosAsync(DescribeRdsInstInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRdsInstInfosWithOptionsAsync(request, runtime);
        }

    }
}
