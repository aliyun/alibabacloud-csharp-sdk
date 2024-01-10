// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dg20190327.Models;

namespace AlibabaCloud.SDK.Dg20190327
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "dg.aliyuncs.com"},
                {"ap-northeast-2-pop", "dg.aliyuncs.com"},
                {"ap-south-1", "dg.aliyuncs.com"},
                {"ap-southeast-1", "dg.aliyuncs.com"},
                {"ap-southeast-2", "dg.aliyuncs.com"},
                {"ap-southeast-3", "dg.aliyuncs.com"},
                {"ap-southeast-5", "dg.aliyuncs.com"},
                {"cn-beijing", "dg.aliyuncs.com"},
                {"cn-beijing-finance-1", "dg.aliyuncs.com"},
                {"cn-beijing-finance-pop", "dg.aliyuncs.com"},
                {"cn-beijing-gov-1", "dg.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "dg.aliyuncs.com"},
                {"cn-chengdu", "dg.aliyuncs.com"},
                {"cn-edge-1", "dg.aliyuncs.com"},
                {"cn-fujian", "dg.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "dg.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "dg.aliyuncs.com"},
                {"cn-hangzhou-finance", "dg.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "dg.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "dg.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "dg.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "dg.aliyuncs.com"},
                {"cn-hangzhou-test-306", "dg.aliyuncs.com"},
                {"cn-hongkong", "dg.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "dg.aliyuncs.com"},
                {"cn-huhehaote", "dg.aliyuncs.com"},
                {"cn-north-2-gov-1", "dg.aliyuncs.com"},
                {"cn-qingdao", "dg.aliyuncs.com"},
                {"cn-qingdao-nebula", "dg.aliyuncs.com"},
                {"cn-shanghai", "dg.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "dg.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "dg.aliyuncs.com"},
                {"cn-shanghai-finance-1", "dg.aliyuncs.com"},
                {"cn-shanghai-inner", "dg.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "dg.aliyuncs.com"},
                {"cn-shenzhen", "dg.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "dg.aliyuncs.com"},
                {"cn-shenzhen-inner", "dg.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "dg.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "dg.aliyuncs.com"},
                {"cn-wuhan", "dg.aliyuncs.com"},
                {"cn-yushanfang", "dg.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "dg.aliyuncs.com"},
                {"cn-zhangjiakou", "dg.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "dg.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "dg.aliyuncs.com"},
                {"eu-central-1", "dg.aliyuncs.com"},
                {"eu-west-1", "dg.aliyuncs.com"},
                {"eu-west-1-oxs", "dg.aliyuncs.com"},
                {"me-east-1", "dg.aliyuncs.com"},
                {"rus-west-1-pop", "dg.aliyuncs.com"},
                {"us-east-1", "dg.aliyuncs.com"},
                {"us-west-1", "dg.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("dg", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddDatabaseResponse AddDatabaseWithOptions(AddDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbDescription))
            {
                body["DbDescription"] = request.DbDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbPassword))
            {
                body["DbPassword"] = request.DbPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbType))
            {
                body["DbType"] = request.DbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbUserName))
            {
                body["DbUserName"] = request.DbUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                body["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                body["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDatabase",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDatabaseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddDatabaseResponse> AddDatabaseWithOptionsAsync(AddDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbDescription))
            {
                body["DbDescription"] = request.DbDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbPassword))
            {
                body["DbPassword"] = request.DbPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbType))
            {
                body["DbType"] = request.DbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbUserName))
            {
                body["DbUserName"] = request.DbUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                body["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                body["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDatabase",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddDatabaseResponse AddDatabase(AddDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDatabaseWithOptions(request, runtime);
        }

        public async Task<AddDatabaseResponse> AddDatabaseAsync(AddDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDatabaseWithOptionsAsync(request, runtime);
        }

        public AddDatabaseListResponse AddDatabaseListWithOptions(AddDatabaseListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseString))
            {
                body["DatabaseString"] = request.DatabaseString;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDatabaseList",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDatabaseListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddDatabaseListResponse> AddDatabaseListWithOptionsAsync(AddDatabaseListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseString))
            {
                body["DatabaseString"] = request.DatabaseString;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDatabaseList",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDatabaseListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddDatabaseListResponse AddDatabaseList(AddDatabaseListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDatabaseListWithOptions(request, runtime);
        }

        public async Task<AddDatabaseListResponse> AddDatabaseListAsync(AddDatabaseListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDatabaseListWithOptionsAsync(request, runtime);
        }

        public ConnectDatabaseResponse ConnectDatabaseWithOptions(ConnectDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbPassword))
            {
                body["DbPassword"] = request.DbPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbType))
            {
                body["DbType"] = request.DbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbUserName))
            {
                body["DbUserName"] = request.DbUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                body["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                body["Port"] = request.Port;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConnectDatabase",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConnectDatabaseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ConnectDatabaseResponse> ConnectDatabaseWithOptionsAsync(ConnectDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbPassword))
            {
                body["DbPassword"] = request.DbPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbType))
            {
                body["DbType"] = request.DbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbUserName))
            {
                body["DbUserName"] = request.DbUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                body["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                body["Port"] = request.Port;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConnectDatabase",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConnectDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ConnectDatabaseResponse ConnectDatabase(ConnectDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConnectDatabaseWithOptions(request, runtime);
        }

        public async Task<ConnectDatabaseResponse> ConnectDatabaseAsync(ConnectDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConnectDatabaseWithOptionsAsync(request, runtime);
        }

        public CreateDatabaseAccessPointResponse CreateDatabaseAccessPointWithOptions(CreateDatabaseAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbInstanceId))
            {
                body["DbInstanceId"] = request.DbInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                body["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcAZone))
            {
                body["VpcAZone"] = request.VpcAZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcRegionId))
            {
                body["VpcRegionId"] = request.VpcRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatabaseAccessPoint",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatabaseAccessPointResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDatabaseAccessPointResponse> CreateDatabaseAccessPointWithOptionsAsync(CreateDatabaseAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbInstanceId))
            {
                body["DbInstanceId"] = request.DbInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                body["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcAZone))
            {
                body["VpcAZone"] = request.VpcAZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcRegionId))
            {
                body["VpcRegionId"] = request.VpcRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatabaseAccessPoint",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatabaseAccessPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDatabaseAccessPointResponse CreateDatabaseAccessPoint(CreateDatabaseAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDatabaseAccessPointWithOptions(request, runtime);
        }

        public async Task<CreateDatabaseAccessPointResponse> CreateDatabaseAccessPointAsync(CreateDatabaseAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDatabaseAccessPointWithOptionsAsync(request, runtime);
        }

        public CreateGatewayResponse CreateGatewayWithOptions(CreateGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayDesc))
            {
                body["GatewayDesc"] = request.GatewayDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayName))
            {
                body["GatewayName"] = request.GatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGateway",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateGatewayResponse> CreateGatewayWithOptionsAsync(CreateGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayDesc))
            {
                body["GatewayDesc"] = request.GatewayDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayName))
            {
                body["GatewayName"] = request.GatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGateway",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateGatewayResponse CreateGateway(CreateGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGatewayWithOptions(request, runtime);
        }

        public async Task<CreateGatewayResponse> CreateGatewayAsync(CreateGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGatewayWithOptionsAsync(request, runtime);
        }

        public CreateGatewayVerifyCodeResponse CreateGatewayVerifyCodeWithOptions(CreateGatewayVerifyCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGatewayVerifyCode",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayVerifyCodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateGatewayVerifyCodeResponse> CreateGatewayVerifyCodeWithOptionsAsync(CreateGatewayVerifyCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGatewayVerifyCode",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayVerifyCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateGatewayVerifyCodeResponse CreateGatewayVerifyCode(CreateGatewayVerifyCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGatewayVerifyCodeWithOptions(request, runtime);
        }

        public async Task<CreateGatewayVerifyCodeResponse> CreateGatewayVerifyCodeAsync(CreateGatewayVerifyCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGatewayVerifyCodeWithOptionsAsync(request, runtime);
        }

        public DeleteDatabaseResponse DeleteDatabaseWithOptions(DeleteDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatabase",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatabaseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDatabaseResponse> DeleteDatabaseWithOptionsAsync(DeleteDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatabase",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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

        public DeleteDatabaseAccessPointResponse DeleteDatabaseAccessPointWithOptions(DeleteDatabaseAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbInstanceId))
            {
                body["DbInstanceId"] = request.DbInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                body["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcAZone))
            {
                body["VpcAZone"] = request.VpcAZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcRegionId))
            {
                body["VpcRegionId"] = request.VpcRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatabaseAccessPoint",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatabaseAccessPointResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDatabaseAccessPointResponse> DeleteDatabaseAccessPointWithOptionsAsync(DeleteDatabaseAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbInstanceId))
            {
                body["DbInstanceId"] = request.DbInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                body["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcAZone))
            {
                body["VpcAZone"] = request.VpcAZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcRegionId))
            {
                body["VpcRegionId"] = request.VpcRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatabaseAccessPoint",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatabaseAccessPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDatabaseAccessPointResponse DeleteDatabaseAccessPoint(DeleteDatabaseAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDatabaseAccessPointWithOptions(request, runtime);
        }

        public async Task<DeleteDatabaseAccessPointResponse> DeleteDatabaseAccessPointAsync(DeleteDatabaseAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDatabaseAccessPointWithOptionsAsync(request, runtime);
        }

        public DeleteGatewayResponse DeleteGatewayWithOptions(DeleteGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGateway",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteGatewayResponse> DeleteGatewayWithOptionsAsync(DeleteGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGateway",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteGatewayResponse DeleteGateway(DeleteGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGatewayWithOptions(request, runtime);
        }

        public async Task<DeleteGatewayResponse> DeleteGatewayAsync(DeleteGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGatewayWithOptionsAsync(request, runtime);
        }

        public DeleteGatewayInstanceResponse DeleteGatewayInstanceWithOptions(DeleteGatewayInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayInstanceId))
            {
                body["GatewayInstanceId"] = request.GatewayInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewayInstance",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteGatewayInstanceResponse> DeleteGatewayInstanceWithOptionsAsync(DeleteGatewayInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayInstanceId))
            {
                body["GatewayInstanceId"] = request.GatewayInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewayInstance",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteGatewayInstanceResponse DeleteGatewayInstance(DeleteGatewayInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGatewayInstanceWithOptions(request, runtime);
        }

        public async Task<DeleteGatewayInstanceResponse> DeleteGatewayInstanceAsync(DeleteGatewayInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGatewayInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2019-03-27",
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2019-03-27",
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

        public DownloadGatewayProgramResponse DownloadGatewayProgramWithOptions(DownloadGatewayProgramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DgVersion))
            {
                body["DgVersion"] = request.DgVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserOS))
            {
                body["UserOS"] = request.UserOS;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadGatewayProgram",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadGatewayProgramResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DownloadGatewayProgramResponse> DownloadGatewayProgramWithOptionsAsync(DownloadGatewayProgramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DgVersion))
            {
                body["DgVersion"] = request.DgVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserOS))
            {
                body["UserOS"] = request.UserOS;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadGatewayProgram",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadGatewayProgramResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DownloadGatewayProgramResponse DownloadGatewayProgram(DownloadGatewayProgramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadGatewayProgramWithOptions(request, runtime);
        }

        public async Task<DownloadGatewayProgramResponse> DownloadGatewayProgramAsync(DownloadGatewayProgramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadGatewayProgramWithOptionsAsync(request, runtime);
        }

        public FindUserGatewayByIdResponse FindUserGatewayByIdWithOptions(FindUserGatewayByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindUserGatewayById",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindUserGatewayByIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FindUserGatewayByIdResponse> FindUserGatewayByIdWithOptionsAsync(FindUserGatewayByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindUserGatewayById",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindUserGatewayByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FindUserGatewayByIdResponse FindUserGatewayById(FindUserGatewayByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindUserGatewayByIdWithOptions(request, runtime);
        }

        public async Task<FindUserGatewayByIdResponse> FindUserGatewayByIdAsync(FindUserGatewayByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindUserGatewayByIdWithOptionsAsync(request, runtime);
        }

        public GetUserDatabasesResponse GetUserDatabasesWithOptions(GetUserDatabasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbType))
            {
                body["DbType"] = request.DbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                body["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                body["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                body["SearchKey"] = request.SearchKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserDatabases",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserDatabasesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUserDatabasesResponse> GetUserDatabasesWithOptionsAsync(GetUserDatabasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbType))
            {
                body["DbType"] = request.DbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                body["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                body["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                body["SearchKey"] = request.SearchKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserDatabases",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserDatabasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetUserDatabasesResponse GetUserDatabases(GetUserDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserDatabasesWithOptions(request, runtime);
        }

        public async Task<GetUserDatabasesResponse> GetUserDatabasesAsync(GetUserDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserDatabasesWithOptionsAsync(request, runtime);
        }

        public GetUserGatewayInstancesResponse GetUserGatewayInstancesWithOptions(GetUserGatewayInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserGatewayInstances",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserGatewayInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUserGatewayInstancesResponse> GetUserGatewayInstancesWithOptionsAsync(GetUserGatewayInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserGatewayInstances",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserGatewayInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetUserGatewayInstancesResponse GetUserGatewayInstances(GetUserGatewayInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserGatewayInstancesWithOptions(request, runtime);
        }

        public async Task<GetUserGatewayInstancesResponse> GetUserGatewayInstancesAsync(GetUserGatewayInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserGatewayInstancesWithOptionsAsync(request, runtime);
        }

        public GetUserGatewaysResponse GetUserGatewaysWithOptions(GetUserGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                body["SearchKey"] = request.SearchKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserGateways",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserGatewaysResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUserGatewaysResponse> GetUserGatewaysWithOptionsAsync(GetUserGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                body["SearchKey"] = request.SearchKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserGateways",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserGatewaysResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetUserGatewaysResponse GetUserGateways(GetUserGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserGatewaysWithOptions(request, runtime);
        }

        public async Task<GetUserGatewaysResponse> GetUserGatewaysAsync(GetUserGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserGatewaysWithOptionsAsync(request, runtime);
        }

        public ListDatabaseAccessPointResponse ListDatabaseAccessPointWithOptions(ListDatabaseAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbInstanceId))
            {
                body["DbInstanceId"] = request.DbInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                body["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                body["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                body["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatabaseAccessPoint",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatabaseAccessPointResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDatabaseAccessPointResponse> ListDatabaseAccessPointWithOptionsAsync(ListDatabaseAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbInstanceId))
            {
                body["DbInstanceId"] = request.DbInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                body["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                body["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                body["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatabaseAccessPoint",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatabaseAccessPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDatabaseAccessPointResponse ListDatabaseAccessPoint(ListDatabaseAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDatabaseAccessPointWithOptions(request, runtime);
        }

        public async Task<ListDatabaseAccessPointResponse> ListDatabaseAccessPointAsync(ListDatabaseAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDatabaseAccessPointWithOptionsAsync(request, runtime);
        }

        public ModifyDatabaseResponse ModifyDatabaseWithOptions(ModifyDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbDescription))
            {
                body["DbDescription"] = request.DbDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbPassword))
            {
                body["DbPassword"] = request.DbPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbType))
            {
                body["DbType"] = request.DbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbUserName))
            {
                body["DbUserName"] = request.DbUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                body["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                body["Port"] = request.Port;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDatabase",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDatabaseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDatabaseResponse> ModifyDatabaseWithOptionsAsync(ModifyDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbDescription))
            {
                body["DbDescription"] = request.DbDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbPassword))
            {
                body["DbPassword"] = request.DbPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbType))
            {
                body["DbType"] = request.DbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbUserName))
            {
                body["DbUserName"] = request.DbUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                body["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                body["Port"] = request.Port;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDatabase",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDatabaseResponse ModifyDatabase(ModifyDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDatabaseWithOptions(request, runtime);
        }

        public async Task<ModifyDatabaseResponse> ModifyDatabaseAsync(ModifyDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDatabaseWithOptionsAsync(request, runtime);
        }

        public ModifyGatewayResponse ModifyGatewayWithOptions(ModifyGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayDesc))
            {
                body["GatewayDesc"] = request.GatewayDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayName))
            {
                body["GatewayName"] = request.GatewayName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGateway",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyGatewayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyGatewayResponse> ModifyGatewayWithOptionsAsync(ModifyGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayDesc))
            {
                body["GatewayDesc"] = request.GatewayDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayName))
            {
                body["GatewayName"] = request.GatewayName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGateway",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyGatewayResponse ModifyGateway(ModifyGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyGatewayWithOptions(request, runtime);
        }

        public async Task<ModifyGatewayResponse> ModifyGatewayAsync(ModifyGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyGatewayWithOptionsAsync(request, runtime);
        }

        public RetryDatabaseResponse RetryDatabaseWithOptions(RetryDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbDescription))
            {
                body["DbDescription"] = request.DbDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbPassword))
            {
                body["DbPassword"] = request.DbPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbType))
            {
                body["DbType"] = request.DbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbUserName))
            {
                body["DbUserName"] = request.DbUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                body["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                body["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryDatabase",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryDatabaseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RetryDatabaseResponse> RetryDatabaseWithOptionsAsync(RetryDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbDescription))
            {
                body["DbDescription"] = request.DbDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbPassword))
            {
                body["DbPassword"] = request.DbPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbType))
            {
                body["DbType"] = request.DbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbUserName))
            {
                body["DbUserName"] = request.DbUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                body["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                body["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryDatabase",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RetryDatabaseResponse RetryDatabase(RetryDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RetryDatabaseWithOptions(request, runtime);
        }

        public async Task<RetryDatabaseResponse> RetryDatabaseAsync(RetryDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RetryDatabaseWithOptionsAsync(request, runtime);
        }

        public StopGatewayResponse StopGatewayWithOptions(StopGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayInstanceId))
            {
                body["GatewayInstanceId"] = request.GatewayInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopGateway",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopGatewayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopGatewayResponse> StopGatewayWithOptionsAsync(StopGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayInstanceId))
            {
                body["GatewayInstanceId"] = request.GatewayInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopGateway",
                Version = "2019-03-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopGatewayResponse StopGateway(StopGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopGatewayWithOptions(request, runtime);
        }

        public async Task<StopGatewayResponse> StopGatewayAsync(StopGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopGatewayWithOptionsAsync(request, runtime);
        }

    }
}
