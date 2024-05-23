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

        /**
         * @param request CreateDrdsAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDrdsAccountResponse
         */
        public CreateDrdsAccountResponse CreateDrdsAccountWithOptions(CreateDrdsAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDrdsAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateDrdsAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDrdsAccountResponse
         */
        public async Task<CreateDrdsAccountResponse> CreateDrdsAccountWithOptionsAsync(CreateDrdsAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDrdsAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateDrdsAccountRequest
         * @return CreateDrdsAccountResponse
         */
        public CreateDrdsAccountResponse CreateDrdsAccount(CreateDrdsAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDrdsAccountWithOptions(request, runtime);
        }

        /**
         * @param request CreateDrdsAccountRequest
         * @return CreateDrdsAccountResponse
         */
        public async Task<CreateDrdsAccountResponse> CreateDrdsAccountAsync(CreateDrdsAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDrdsAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateDrdsDBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDrdsDBResponse
         */
        public CreateDrdsDBResponse CreateDrdsDBWithOptions(CreateDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Encode))
            {
                query["Encode"] = request.Encode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RdsInstances))
            {
                query["RdsInstances"] = request.RdsInstances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDrdsDBResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateDrdsDBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDrdsDBResponse
         */
        public async Task<CreateDrdsDBResponse> CreateDrdsDBWithOptionsAsync(CreateDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Encode))
            {
                query["Encode"] = request.Encode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RdsInstances))
            {
                query["RdsInstances"] = request.RdsInstances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDrdsDBResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateDrdsDBRequest
         * @return CreateDrdsDBResponse
         */
        public CreateDrdsDBResponse CreateDrdsDB(CreateDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDrdsDBWithOptions(request, runtime);
        }

        /**
         * @param request CreateDrdsDBRequest
         * @return CreateDrdsDBResponse
         */
        public async Task<CreateDrdsDBResponse> CreateDrdsDBAsync(CreateDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDrdsDBWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateDrdsInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDrdsInstanceResponse
         */
        public CreateDrdsInstanceResponse CreateDrdsInstanceWithOptions(CreateDrdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceSeries))
            {
                query["InstanceSeries"] = request.InstanceSeries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAutoRenew))
            {
                query["IsAutoRenew"] = request.IsAutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsHa))
            {
                query["IsHa"] = request.IsHa;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                query["Quantity"] = request.Quantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswitchId))
            {
                query["VswitchId"] = request.VswitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDrdsInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateDrdsInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDrdsInstanceResponse
         */
        public async Task<CreateDrdsInstanceResponse> CreateDrdsInstanceWithOptionsAsync(CreateDrdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceSeries))
            {
                query["InstanceSeries"] = request.InstanceSeries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAutoRenew))
            {
                query["IsAutoRenew"] = request.IsAutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsHa))
            {
                query["IsHa"] = request.IsHa;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                query["Quantity"] = request.Quantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswitchId))
            {
                query["VswitchId"] = request.VswitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDrdsInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateDrdsInstanceRequest
         * @return CreateDrdsInstanceResponse
         */
        public CreateDrdsInstanceResponse CreateDrdsInstance(CreateDrdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDrdsInstanceWithOptions(request, runtime);
        }

        /**
         * @param request CreateDrdsInstanceRequest
         * @return CreateDrdsInstanceResponse
         */
        public async Task<CreateDrdsInstanceResponse> CreateDrdsInstanceAsync(CreateDrdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDrdsInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateReadOnlyAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateReadOnlyAccountResponse
         */
        public CreateReadOnlyAccountResponse CreateReadOnlyAccountWithOptions(CreateReadOnlyAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["password"] = request.Password;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateReadOnlyAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateReadOnlyAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateReadOnlyAccountResponse
         */
        public async Task<CreateReadOnlyAccountResponse> CreateReadOnlyAccountWithOptionsAsync(CreateReadOnlyAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["password"] = request.Password;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateReadOnlyAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateReadOnlyAccountRequest
         * @return CreateReadOnlyAccountResponse
         */
        public CreateReadOnlyAccountResponse CreateReadOnlyAccount(CreateReadOnlyAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateReadOnlyAccountWithOptions(request, runtime);
        }

        /**
         * @param request CreateReadOnlyAccountRequest
         * @return CreateReadOnlyAccountResponse
         */
        public async Task<CreateReadOnlyAccountResponse> CreateReadOnlyAccountAsync(CreateReadOnlyAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateReadOnlyAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteDrdsDBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDrdsDBResponse
         */
        public DeleteDrdsDBResponse DeleteDrdsDBWithOptions(DeleteDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDrdsDBResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteDrdsDBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDrdsDBResponse
         */
        public async Task<DeleteDrdsDBResponse> DeleteDrdsDBWithOptionsAsync(DeleteDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDrdsDBResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteDrdsDBRequest
         * @return DeleteDrdsDBResponse
         */
        public DeleteDrdsDBResponse DeleteDrdsDB(DeleteDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDrdsDBWithOptions(request, runtime);
        }

        /**
         * @param request DeleteDrdsDBRequest
         * @return DeleteDrdsDBResponse
         */
        public async Task<DeleteDrdsDBResponse> DeleteDrdsDBAsync(DeleteDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDrdsDBWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteFailedDrdsDBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFailedDrdsDBResponse
         */
        public DeleteFailedDrdsDBResponse DeleteFailedDrdsDBWithOptions(DeleteFailedDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFailedDrdsDBResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteFailedDrdsDBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFailedDrdsDBResponse
         */
        public async Task<DeleteFailedDrdsDBResponse> DeleteFailedDrdsDBWithOptionsAsync(DeleteFailedDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFailedDrdsDBResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteFailedDrdsDBRequest
         * @return DeleteFailedDrdsDBResponse
         */
        public DeleteFailedDrdsDBResponse DeleteFailedDrdsDB(DeleteFailedDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFailedDrdsDBWithOptions(request, runtime);
        }

        /**
         * @param request DeleteFailedDrdsDBRequest
         * @return DeleteFailedDrdsDBResponse
         */
        public async Task<DeleteFailedDrdsDBResponse> DeleteFailedDrdsDBAsync(DeleteFailedDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFailedDrdsDBWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeCreateDrdsInstanceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCreateDrdsInstanceStatusResponse
         */
        public DescribeCreateDrdsInstanceStatusResponse DescribeCreateDrdsInstanceStatusWithOptions(DescribeCreateDrdsInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCreateDrdsInstanceStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeCreateDrdsInstanceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCreateDrdsInstanceStatusResponse
         */
        public async Task<DescribeCreateDrdsInstanceStatusResponse> DescribeCreateDrdsInstanceStatusWithOptionsAsync(DescribeCreateDrdsInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCreateDrdsInstanceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeCreateDrdsInstanceStatusRequest
         * @return DescribeCreateDrdsInstanceStatusResponse
         */
        public DescribeCreateDrdsInstanceStatusResponse DescribeCreateDrdsInstanceStatus(DescribeCreateDrdsInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCreateDrdsInstanceStatusWithOptions(request, runtime);
        }

        /**
         * @param request DescribeCreateDrdsInstanceStatusRequest
         * @return DescribeCreateDrdsInstanceStatusResponse
         */
        public async Task<DescribeCreateDrdsInstanceStatusResponse> DescribeCreateDrdsInstanceStatusAsync(DescribeCreateDrdsInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCreateDrdsInstanceStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDrdsDBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDrdsDBResponse
         */
        public DescribeDrdsDBResponse DescribeDrdsDBWithOptions(DescribeDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDBResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDrdsDBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDrdsDBResponse
         */
        public async Task<DescribeDrdsDBResponse> DescribeDrdsDBWithOptionsAsync(DescribeDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDBResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDrdsDBRequest
         * @return DescribeDrdsDBResponse
         */
        public DescribeDrdsDBResponse DescribeDrdsDB(DescribeDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsDBWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDrdsDBRequest
         * @return DescribeDrdsDBResponse
         */
        public async Task<DescribeDrdsDBResponse> DescribeDrdsDBAsync(DescribeDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsDBWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDrdsDBIpWhiteListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDrdsDBIpWhiteListResponse
         */
        public DescribeDrdsDBIpWhiteListResponse DescribeDrdsDBIpWhiteListWithOptions(DescribeDrdsDBIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDBIpWhiteListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDrdsDBIpWhiteListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDrdsDBIpWhiteListResponse
         */
        public async Task<DescribeDrdsDBIpWhiteListResponse> DescribeDrdsDBIpWhiteListWithOptionsAsync(DescribeDrdsDBIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDBIpWhiteListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDrdsDBIpWhiteListRequest
         * @return DescribeDrdsDBIpWhiteListResponse
         */
        public DescribeDrdsDBIpWhiteListResponse DescribeDrdsDBIpWhiteList(DescribeDrdsDBIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsDBIpWhiteListWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDrdsDBIpWhiteListRequest
         * @return DescribeDrdsDBIpWhiteListResponse
         */
        public async Task<DescribeDrdsDBIpWhiteListResponse> DescribeDrdsDBIpWhiteListAsync(DescribeDrdsDBIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsDBIpWhiteListWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDrdsDBsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDrdsDBsResponse
         */
        public DescribeDrdsDBsResponse DescribeDrdsDBsWithOptions(DescribeDrdsDBsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDBsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDrdsDBsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDrdsDBsResponse
         */
        public async Task<DescribeDrdsDBsResponse> DescribeDrdsDBsWithOptionsAsync(DescribeDrdsDBsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsDBsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDrdsDBsRequest
         * @return DescribeDrdsDBsResponse
         */
        public DescribeDrdsDBsResponse DescribeDrdsDBs(DescribeDrdsDBsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsDBsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDrdsDBsRequest
         * @return DescribeDrdsDBsResponse
         */
        public async Task<DescribeDrdsDBsResponse> DescribeDrdsDBsAsync(DescribeDrdsDBsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsDBsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDrdsInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDrdsInstanceResponse
         */
        public DescribeDrdsInstanceResponse DescribeDrdsInstanceWithOptions(DescribeDrdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDrdsInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDrdsInstanceResponse
         */
        public async Task<DescribeDrdsInstanceResponse> DescribeDrdsInstanceWithOptionsAsync(DescribeDrdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDrdsInstanceRequest
         * @return DescribeDrdsInstanceResponse
         */
        public DescribeDrdsInstanceResponse DescribeDrdsInstance(DescribeDrdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsInstanceWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDrdsInstanceRequest
         * @return DescribeDrdsInstanceResponse
         */
        public async Task<DescribeDrdsInstanceResponse> DescribeDrdsInstanceAsync(DescribeDrdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDrdsInstanceDbMonitorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDrdsInstanceDbMonitorResponse
         */
        public DescribeDrdsInstanceDbMonitorResponse DescribeDrdsInstanceDbMonitorWithOptions(DescribeDrdsInstanceDbMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstanceDbMonitorResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDrdsInstanceDbMonitorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDrdsInstanceDbMonitorResponse
         */
        public async Task<DescribeDrdsInstanceDbMonitorResponse> DescribeDrdsInstanceDbMonitorWithOptionsAsync(DescribeDrdsInstanceDbMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstanceDbMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDrdsInstanceDbMonitorRequest
         * @return DescribeDrdsInstanceDbMonitorResponse
         */
        public DescribeDrdsInstanceDbMonitorResponse DescribeDrdsInstanceDbMonitor(DescribeDrdsInstanceDbMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsInstanceDbMonitorWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDrdsInstanceDbMonitorRequest
         * @return DescribeDrdsInstanceDbMonitorResponse
         */
        public async Task<DescribeDrdsInstanceDbMonitorResponse> DescribeDrdsInstanceDbMonitorAsync(DescribeDrdsInstanceDbMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsInstanceDbMonitorWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDrdsInstanceMonitorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDrdsInstanceMonitorResponse
         */
        public DescribeDrdsInstanceMonitorResponse DescribeDrdsInstanceMonitorWithOptions(DescribeDrdsInstanceMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodMultiple))
            {
                query["PeriodMultiple"] = request.PeriodMultiple;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstanceMonitorResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDrdsInstanceMonitorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDrdsInstanceMonitorResponse
         */
        public async Task<DescribeDrdsInstanceMonitorResponse> DescribeDrdsInstanceMonitorWithOptionsAsync(DescribeDrdsInstanceMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodMultiple))
            {
                query["PeriodMultiple"] = request.PeriodMultiple;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstanceMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDrdsInstanceMonitorRequest
         * @return DescribeDrdsInstanceMonitorResponse
         */
        public DescribeDrdsInstanceMonitorResponse DescribeDrdsInstanceMonitor(DescribeDrdsInstanceMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsInstanceMonitorWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDrdsInstanceMonitorRequest
         * @return DescribeDrdsInstanceMonitorResponse
         */
        public async Task<DescribeDrdsInstanceMonitorResponse> DescribeDrdsInstanceMonitorAsync(DescribeDrdsInstanceMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsInstanceMonitorWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDrdsInstanceNetInfoForInnerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDrdsInstanceNetInfoForInnerResponse
         */
        public DescribeDrdsInstanceNetInfoForInnerResponse DescribeDrdsInstanceNetInfoForInnerWithOptions(DescribeDrdsInstanceNetInfoForInnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstanceNetInfoForInnerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDrdsInstanceNetInfoForInnerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDrdsInstanceNetInfoForInnerResponse
         */
        public async Task<DescribeDrdsInstanceNetInfoForInnerResponse> DescribeDrdsInstanceNetInfoForInnerWithOptionsAsync(DescribeDrdsInstanceNetInfoForInnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstanceNetInfoForInnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDrdsInstanceNetInfoForInnerRequest
         * @return DescribeDrdsInstanceNetInfoForInnerResponse
         */
        public DescribeDrdsInstanceNetInfoForInnerResponse DescribeDrdsInstanceNetInfoForInner(DescribeDrdsInstanceNetInfoForInnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsInstanceNetInfoForInnerWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDrdsInstanceNetInfoForInnerRequest
         * @return DescribeDrdsInstanceNetInfoForInnerResponse
         */
        public async Task<DescribeDrdsInstanceNetInfoForInnerResponse> DescribeDrdsInstanceNetInfoForInnerAsync(DescribeDrdsInstanceNetInfoForInnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsInstanceNetInfoForInnerWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDrdsInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDrdsInstancesResponse
         */
        public DescribeDrdsInstancesResponse DescribeDrdsInstancesWithOptions(DescribeDrdsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDrdsInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDrdsInstancesResponse
         */
        public async Task<DescribeDrdsInstancesResponse> DescribeDrdsInstancesWithOptionsAsync(DescribeDrdsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDrdsInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDrdsInstancesRequest
         * @return DescribeDrdsInstancesResponse
         */
        public DescribeDrdsInstancesResponse DescribeDrdsInstances(DescribeDrdsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsInstancesWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDrdsInstancesRequest
         * @return DescribeDrdsInstancesResponse
         */
        public async Task<DescribeDrdsInstancesResponse> DescribeDrdsInstancesAsync(DescribeDrdsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeRdsListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRdsListResponse
         */
        public DescribeRdsListResponse DescribeRdsListWithOptions(DescribeRdsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRdsListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeRdsListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRdsListResponse
         */
        public async Task<DescribeRdsListResponse> DescribeRdsListWithOptionsAsync(DescribeRdsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRdsListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeRdsListRequest
         * @return DescribeRdsListResponse
         */
        public DescribeRdsListResponse DescribeRdsList(DescribeRdsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRdsListWithOptions(request, runtime);
        }

        /**
         * @param request DescribeRdsListRequest
         * @return DescribeRdsListResponse
         */
        public async Task<DescribeRdsListResponse> DescribeRdsListAsync(DescribeRdsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRdsListWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeReadOnlyAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeReadOnlyAccountResponse
         */
        public DescribeReadOnlyAccountResponse DescribeReadOnlyAccountWithOptions(DescribeReadOnlyAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeReadOnlyAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeReadOnlyAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeReadOnlyAccountResponse
         */
        public async Task<DescribeReadOnlyAccountResponse> DescribeReadOnlyAccountWithOptionsAsync(DescribeReadOnlyAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeReadOnlyAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeReadOnlyAccountRequest
         * @return DescribeReadOnlyAccountResponse
         */
        public DescribeReadOnlyAccountResponse DescribeReadOnlyAccount(DescribeReadOnlyAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeReadOnlyAccountWithOptions(request, runtime);
        }

        /**
         * @param request DescribeReadOnlyAccountRequest
         * @return DescribeReadOnlyAccountResponse
         */
        public async Task<DescribeReadOnlyAccountResponse> DescribeReadOnlyAccountAsync(DescribeReadOnlyAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeReadOnlyAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(runtime);
        }

        /**
         * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(runtime);
        }

        /**
         * @param request DescribeShardDBsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeShardDBsResponse
         */
        public DescribeShardDBsResponse DescribeShardDBsWithOptions(DescribeShardDBsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeShardDBsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeShardDBsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeShardDBsResponse
         */
        public async Task<DescribeShardDBsResponse> DescribeShardDBsWithOptionsAsync(DescribeShardDBsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeShardDBsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeShardDBsRequest
         * @return DescribeShardDBsResponse
         */
        public DescribeShardDBsResponse DescribeShardDBs(DescribeShardDBsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeShardDBsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeShardDBsRequest
         * @return DescribeShardDBsResponse
         */
        public async Task<DescribeShardDBsResponse> DescribeShardDBsAsync(DescribeShardDBsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeShardDBsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeShardDbConnectionInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeShardDbConnectionInfoResponse
         */
        public DescribeShardDbConnectionInfoResponse DescribeShardDbConnectionInfoWithOptions(DescribeShardDbConnectionInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDbName))
            {
                query["SubDbName"] = request.SubDbName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeShardDbConnectionInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeShardDbConnectionInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeShardDbConnectionInfoResponse
         */
        public async Task<DescribeShardDbConnectionInfoResponse> DescribeShardDbConnectionInfoWithOptionsAsync(DescribeShardDbConnectionInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDbName))
            {
                query["SubDbName"] = request.SubDbName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeShardDbConnectionInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeShardDbConnectionInfoRequest
         * @return DescribeShardDbConnectionInfoResponse
         */
        public DescribeShardDbConnectionInfoResponse DescribeShardDbConnectionInfo(DescribeShardDbConnectionInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeShardDbConnectionInfoWithOptions(request, runtime);
        }

        /**
         * @param request DescribeShardDbConnectionInfoRequest
         * @return DescribeShardDbConnectionInfoResponse
         */
        public async Task<DescribeShardDbConnectionInfoResponse> DescribeShardDbConnectionInfoAsync(DescribeShardDbConnectionInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeShardDbConnectionInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @param request EnableInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableInstanceResponse
         */
        public EnableInstanceResponse EnableInstanceWithOptions(EnableInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbInstanceClass))
            {
                query["DbInstanceClass"] = request.DbInstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTime))
            {
                query["RestoreTime"] = request.RestoreTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDbInstId))
            {
                query["SourceDbInstId"] = request.SourceDbInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchId))
            {
                query["SwitchId"] = request.SwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request EnableInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableInstanceResponse
         */
        public async Task<EnableInstanceResponse> EnableInstanceWithOptionsAsync(EnableInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbInstanceClass))
            {
                query["DbInstanceClass"] = request.DbInstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTime))
            {
                query["RestoreTime"] = request.RestoreTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDbInstId))
            {
                query["SourceDbInstId"] = request.SourceDbInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchId))
            {
                query["SwitchId"] = request.SwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request EnableInstanceRequest
         * @return EnableInstanceResponse
         */
        public EnableInstanceResponse EnableInstance(EnableInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableInstanceWithOptions(request, runtime);
        }

        /**
         * @param request EnableInstanceRequest
         * @return EnableInstanceResponse
         */
        public async Task<EnableInstanceResponse> EnableInstanceAsync(EnableInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyDrdsDBPasswdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDrdsDBPasswdResponse
         */
        public ModifyDrdsDBPasswdResponse ModifyDrdsDBPasswdWithOptions(ModifyDrdsDBPasswdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPasswd))
            {
                query["NewPasswd"] = request.NewPasswd;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDrdsDBPasswdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyDrdsDBPasswdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDrdsDBPasswdResponse
         */
        public async Task<ModifyDrdsDBPasswdResponse> ModifyDrdsDBPasswdWithOptionsAsync(ModifyDrdsDBPasswdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPasswd))
            {
                query["NewPasswd"] = request.NewPasswd;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDrdsDBPasswdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyDrdsDBPasswdRequest
         * @return ModifyDrdsDBPasswdResponse
         */
        public ModifyDrdsDBPasswdResponse ModifyDrdsDBPasswd(ModifyDrdsDBPasswdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDrdsDBPasswdWithOptions(request, runtime);
        }

        /**
         * @param request ModifyDrdsDBPasswdRequest
         * @return ModifyDrdsDBPasswdResponse
         */
        public async Task<ModifyDrdsDBPasswdResponse> ModifyDrdsDBPasswdAsync(ModifyDrdsDBPasswdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDrdsDBPasswdWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyDrdsInstanceDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDrdsInstanceDescriptionResponse
         */
        public ModifyDrdsInstanceDescriptionResponse ModifyDrdsInstanceDescriptionWithOptions(ModifyDrdsInstanceDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDrdsInstanceDescriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyDrdsInstanceDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDrdsInstanceDescriptionResponse
         */
        public async Task<ModifyDrdsInstanceDescriptionResponse> ModifyDrdsInstanceDescriptionWithOptionsAsync(ModifyDrdsInstanceDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDrdsInstanceDescriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyDrdsInstanceDescriptionRequest
         * @return ModifyDrdsInstanceDescriptionResponse
         */
        public ModifyDrdsInstanceDescriptionResponse ModifyDrdsInstanceDescription(ModifyDrdsInstanceDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDrdsInstanceDescriptionWithOptions(request, runtime);
        }

        /**
         * @param request ModifyDrdsInstanceDescriptionRequest
         * @return ModifyDrdsInstanceDescriptionResponse
         */
        public async Task<ModifyDrdsInstanceDescriptionResponse> ModifyDrdsInstanceDescriptionAsync(ModifyDrdsInstanceDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDrdsInstanceDescriptionWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyDrdsIpWhiteListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDrdsIpWhiteListResponse
         */
        public ModifyDrdsIpWhiteListResponse ModifyDrdsIpWhiteListWithOptions(ModifyDrdsIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupAttribute))
            {
                query["GroupAttribute"] = request.GroupAttribute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhiteList))
            {
                query["IpWhiteList"] = request.IpWhiteList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDrdsIpWhiteListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyDrdsIpWhiteListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDrdsIpWhiteListResponse
         */
        public async Task<ModifyDrdsIpWhiteListResponse> ModifyDrdsIpWhiteListWithOptionsAsync(ModifyDrdsIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupAttribute))
            {
                query["GroupAttribute"] = request.GroupAttribute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhiteList))
            {
                query["IpWhiteList"] = request.IpWhiteList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDrdsIpWhiteListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyDrdsIpWhiteListRequest
         * @return ModifyDrdsIpWhiteListResponse
         */
        public ModifyDrdsIpWhiteListResponse ModifyDrdsIpWhiteList(ModifyDrdsIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDrdsIpWhiteListWithOptions(request, runtime);
        }

        /**
         * @param request ModifyDrdsIpWhiteListRequest
         * @return ModifyDrdsIpWhiteListResponse
         */
        public async Task<ModifyDrdsIpWhiteListResponse> ModifyDrdsIpWhiteListAsync(ModifyDrdsIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDrdsIpWhiteListWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyFullTableScanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyFullTableScanResponse
         */
        public ModifyFullTableScanResponse ModifyFullTableScanWithOptions(ModifyFullTableScanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FullTableScan))
            {
                query["FullTableScan"] = request.FullTableScan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNames))
            {
                query["TableNames"] = request.TableNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFullTableScanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyFullTableScanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyFullTableScanResponse
         */
        public async Task<ModifyFullTableScanResponse> ModifyFullTableScanWithOptionsAsync(ModifyFullTableScanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FullTableScan))
            {
                query["FullTableScan"] = request.FullTableScan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNames))
            {
                query["TableNames"] = request.TableNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFullTableScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyFullTableScanRequest
         * @return ModifyFullTableScanResponse
         */
        public ModifyFullTableScanResponse ModifyFullTableScan(ModifyFullTableScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFullTableScanWithOptions(request, runtime);
        }

        /**
         * @param request ModifyFullTableScanRequest
         * @return ModifyFullTableScanResponse
         */
        public async Task<ModifyFullTableScanResponse> ModifyFullTableScanAsync(ModifyFullTableScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFullTableScanWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyRdsReadWeightRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyRdsReadWeightResponse
         */
        public ModifyRdsReadWeightResponse ModifyRdsReadWeightWithOptions(ModifyRdsReadWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceNames))
            {
                query["InstanceNames"] = request.InstanceNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Weights))
            {
                query["Weights"] = request.Weights;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRdsReadWeightResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyRdsReadWeightRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyRdsReadWeightResponse
         */
        public async Task<ModifyRdsReadWeightResponse> ModifyRdsReadWeightWithOptionsAsync(ModifyRdsReadWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceNames))
            {
                query["InstanceNames"] = request.InstanceNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Weights))
            {
                query["Weights"] = request.Weights;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRdsReadWeightResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyRdsReadWeightRequest
         * @return ModifyRdsReadWeightResponse
         */
        public ModifyRdsReadWeightResponse ModifyRdsReadWeight(ModifyRdsReadWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRdsReadWeightWithOptions(request, runtime);
        }

        /**
         * @param request ModifyRdsReadWeightRequest
         * @return ModifyRdsReadWeightResponse
         */
        public async Task<ModifyRdsReadWeightResponse> ModifyRdsReadWeightAsync(ModifyRdsReadWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRdsReadWeightWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyReadOnlyAccountPasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyReadOnlyAccountPasswordResponse
         */
        public ModifyReadOnlyAccountPasswordResponse ModifyReadOnlyAccountPasswordWithOptions(ModifyReadOnlyAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPasswd))
            {
                query["NewPasswd"] = request.NewPasswd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginPassword))
            {
                query["OriginPassword"] = request.OriginPassword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyReadOnlyAccountPasswordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyReadOnlyAccountPasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyReadOnlyAccountPasswordResponse
         */
        public async Task<ModifyReadOnlyAccountPasswordResponse> ModifyReadOnlyAccountPasswordWithOptionsAsync(ModifyReadOnlyAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPasswd))
            {
                query["NewPasswd"] = request.NewPasswd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginPassword))
            {
                query["OriginPassword"] = request.OriginPassword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyReadOnlyAccountPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyReadOnlyAccountPasswordRequest
         * @return ModifyReadOnlyAccountPasswordResponse
         */
        public ModifyReadOnlyAccountPasswordResponse ModifyReadOnlyAccountPassword(ModifyReadOnlyAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyReadOnlyAccountPasswordWithOptions(request, runtime);
        }

        /**
         * @param request ModifyReadOnlyAccountPasswordRequest
         * @return ModifyReadOnlyAccountPasswordResponse
         */
        public async Task<ModifyReadOnlyAccountPasswordResponse> ModifyReadOnlyAccountPasswordAsync(ModifyReadOnlyAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyReadOnlyAccountPasswordWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryInstanceInfoByConnRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryInstanceInfoByConnResponse
         */
        public QueryInstanceInfoByConnResponse QueryInstanceInfoByConnWithOptions(QueryInstanceInfoByConnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInstanceInfoByConnResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QueryInstanceInfoByConnRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryInstanceInfoByConnResponse
         */
        public async Task<QueryInstanceInfoByConnResponse> QueryInstanceInfoByConnWithOptionsAsync(QueryInstanceInfoByConnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInstanceInfoByConnResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QueryInstanceInfoByConnRequest
         * @return QueryInstanceInfoByConnResponse
         */
        public QueryInstanceInfoByConnResponse QueryInstanceInfoByConn(QueryInstanceInfoByConnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInstanceInfoByConnWithOptions(request, runtime);
        }

        /**
         * @param request QueryInstanceInfoByConnRequest
         * @return QueryInstanceInfoByConnResponse
         */
        public async Task<QueryInstanceInfoByConnResponse> QueryInstanceInfoByConnAsync(QueryInstanceInfoByConnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInstanceInfoByConnWithOptionsAsync(request, runtime);
        }

        /**
         * @param request RemoveDrdsInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveDrdsInstanceResponse
         */
        public RemoveDrdsInstanceResponse RemoveDrdsInstanceWithOptions(RemoveDrdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveDrdsInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request RemoveDrdsInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveDrdsInstanceResponse
         */
        public async Task<RemoveDrdsInstanceResponse> RemoveDrdsInstanceWithOptionsAsync(RemoveDrdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveDrdsInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request RemoveDrdsInstanceRequest
         * @return RemoveDrdsInstanceResponse
         */
        public RemoveDrdsInstanceResponse RemoveDrdsInstance(RemoveDrdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveDrdsInstanceWithOptions(request, runtime);
        }

        /**
         * @param request RemoveDrdsInstanceRequest
         * @return RemoveDrdsInstanceResponse
         */
        public async Task<RemoveDrdsInstanceResponse> RemoveDrdsInstanceAsync(RemoveDrdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveDrdsInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request RemoveReadOnlyAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveReadOnlyAccountResponse
         */
        public RemoveReadOnlyAccountResponse RemoveReadOnlyAccountWithOptions(RemoveReadOnlyAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveReadOnlyAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request RemoveReadOnlyAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveReadOnlyAccountResponse
         */
        public async Task<RemoveReadOnlyAccountResponse> RemoveReadOnlyAccountWithOptionsAsync(RemoveReadOnlyAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrdsInstanceId))
            {
                query["DrdsInstanceId"] = request.DrdsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveReadOnlyAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request RemoveReadOnlyAccountRequest
         * @return RemoveReadOnlyAccountResponse
         */
        public RemoveReadOnlyAccountResponse RemoveReadOnlyAccount(RemoveReadOnlyAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveReadOnlyAccountWithOptions(request, runtime);
        }

        /**
         * @param request RemoveReadOnlyAccountRequest
         * @return RemoveReadOnlyAccountResponse
         */
        public async Task<RemoveReadOnlyAccountResponse> RemoveReadOnlyAccountAsync(RemoveReadOnlyAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveReadOnlyAccountWithOptionsAsync(request, runtime);
        }

    }
}
