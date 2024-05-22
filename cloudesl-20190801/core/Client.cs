// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cloudesl20190801.Models;

namespace AlibabaCloud.SDK.Cloudesl20190801
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "cloudesl.aliyuncs.com"},
                {"ap-northeast-2-pop", "cloudesl.aliyuncs.com"},
                {"ap-south-1", "cloudesl.aliyuncs.com"},
                {"ap-southeast-1", "cloudesl.aliyuncs.com"},
                {"ap-southeast-2", "cloudesl.aliyuncs.com"},
                {"ap-southeast-3", "cloudesl.aliyuncs.com"},
                {"ap-southeast-5", "cloudesl.aliyuncs.com"},
                {"cn-beijing", "cloudesl.aliyuncs.com"},
                {"cn-beijing-finance-1", "cloudesl.aliyuncs.com"},
                {"cn-beijing-finance-pop", "cloudesl.aliyuncs.com"},
                {"cn-beijing-gov-1", "cloudesl.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "cloudesl.aliyuncs.com"},
                {"cn-chengdu", "cloudesl.aliyuncs.com"},
                {"cn-edge-1", "cloudesl.aliyuncs.com"},
                {"cn-fujian", "cloudesl.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "cloudesl.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "cloudesl.aliyuncs.com"},
                {"cn-hangzhou-finance", "cloudesl.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "cloudesl.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "cloudesl.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "cloudesl.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "cloudesl.aliyuncs.com"},
                {"cn-hangzhou-test-306", "cloudesl.aliyuncs.com"},
                {"cn-hongkong", "cloudesl.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "cloudesl.aliyuncs.com"},
                {"cn-huhehaote", "cloudesl.aliyuncs.com"},
                {"cn-north-2-gov-1", "cloudesl.aliyuncs.com"},
                {"cn-qingdao", "cloudesl.aliyuncs.com"},
                {"cn-qingdao-nebula", "cloudesl.aliyuncs.com"},
                {"cn-shanghai", "cloudesl.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "cloudesl.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "cloudesl.aliyuncs.com"},
                {"cn-shanghai-finance-1", "cloudesl.aliyuncs.com"},
                {"cn-shanghai-inner", "cloudesl.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "cloudesl.aliyuncs.com"},
                {"cn-shenzhen", "cloudesl.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "cloudesl.aliyuncs.com"},
                {"cn-shenzhen-inner", "cloudesl.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "cloudesl.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "cloudesl.aliyuncs.com"},
                {"cn-wuhan", "cloudesl.aliyuncs.com"},
                {"cn-yushanfang", "cloudesl.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "cloudesl.aliyuncs.com"},
                {"cn-zhangjiakou", "cloudesl.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "cloudesl.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "cloudesl.aliyuncs.com"},
                {"eu-central-1", "cloudesl.aliyuncs.com"},
                {"eu-west-1", "cloudesl.aliyuncs.com"},
                {"eu-west-1-oxs", "cloudesl.aliyuncs.com"},
                {"me-east-1", "cloudesl.aliyuncs.com"},
                {"rus-west-1-pop", "cloudesl.aliyuncs.com"},
                {"us-east-1", "cloudesl.aliyuncs.com"},
                {"us-west-1", "cloudesl.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("cloudesl", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @param request ActivateApDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ActivateApDeviceResponse
         */
        public ActivateApDeviceResponse ActivateApDeviceWithOptions(ActivateApDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                body["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateApDevice",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateApDeviceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ActivateApDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ActivateApDeviceResponse
         */
        public async Task<ActivateApDeviceResponse> ActivateApDeviceWithOptionsAsync(ActivateApDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                body["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateApDevice",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateApDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ActivateApDeviceRequest
         * @return ActivateApDeviceResponse
         */
        public ActivateApDeviceResponse ActivateApDevice(ActivateApDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActivateApDeviceWithOptions(request, runtime);
        }

        /**
         * @param request ActivateApDeviceRequest
         * @return ActivateApDeviceResponse
         */
        public async Task<ActivateApDeviceResponse> ActivateApDeviceAsync(ActivateApDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActivateApDeviceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request AddApDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddApDeviceResponse
         */
        public AddApDeviceResponse AddApDeviceWithOptions(AddApDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                body["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddApDevice",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddApDeviceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request AddApDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddApDeviceResponse
         */
        public async Task<AddApDeviceResponse> AddApDeviceWithOptionsAsync(AddApDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                body["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddApDevice",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddApDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request AddApDeviceRequest
         * @return AddApDeviceResponse
         */
        public AddApDeviceResponse AddApDevice(AddApDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddApDeviceWithOptions(request, runtime);
        }

        /**
         * @param request AddApDeviceRequest
         * @return AddApDeviceResponse
         */
        public async Task<AddApDeviceResponse> AddApDeviceAsync(AddApDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddApDeviceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request AddEslDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddEslDeviceResponse
         */
        public AddEslDeviceResponse AddEslDeviceWithOptions(AddEslDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddEslDevice",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddEslDeviceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request AddEslDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddEslDeviceResponse
         */
        public async Task<AddEslDeviceResponse> AddEslDeviceWithOptionsAsync(AddEslDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddEslDevice",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddEslDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request AddEslDeviceRequest
         * @return AddEslDeviceResponse
         */
        public AddEslDeviceResponse AddEslDevice(AddEslDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddEslDeviceWithOptions(request, runtime);
        }

        /**
         * @param request AddEslDeviceRequest
         * @return AddEslDeviceResponse
         */
        public async Task<AddEslDeviceResponse> AddEslDeviceAsync(AddEslDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddEslDeviceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request AddUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddUserResponse
         */
        public AddUserResponse AddUserWithOptions(AddUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUser",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request AddUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddUserResponse
         */
        public async Task<AddUserResponse> AddUserWithOptionsAsync(AddUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUser",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request AddUserRequest
         * @return AddUserResponse
         */
        public AddUserResponse AddUser(AddUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUserWithOptions(request, runtime);
        }

        /**
         * @param request AddUserRequest
         * @return AddUserResponse
         */
        public async Task<AddUserResponse> AddUserAsync(AddUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUserWithOptionsAsync(request, runtime);
        }

        /**
         * @param request AssignUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AssignUserResponse
         */
        public AssignUserResponse AssignUserWithOptions(AssignUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stores))
            {
                body["Stores"] = request.Stores;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                body["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignUser",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request AssignUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AssignUserResponse
         */
        public async Task<AssignUserResponse> AssignUserWithOptionsAsync(AssignUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stores))
            {
                body["Stores"] = request.Stores;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                body["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignUser",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request AssignUserRequest
         * @return AssignUserResponse
         */
        public AssignUserResponse AssignUser(AssignUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssignUserWithOptions(request, runtime);
        }

        /**
         * @param request AssignUserRequest
         * @return AssignUserResponse
         */
        public async Task<AssignUserResponse> AssignUserAsync(AssignUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssignUserWithOptionsAsync(request, runtime);
        }

        /**
         * @param request BatchInsertItemsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchInsertItemsResponse
         */
        public BatchInsertItemsResponse BatchInsertItemsWithOptions(BatchInsertItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemInfo))
            {
                body["ItemInfo"] = request.ItemInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchInsertItems",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchInsertItemsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request BatchInsertItemsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchInsertItemsResponse
         */
        public async Task<BatchInsertItemsResponse> BatchInsertItemsWithOptionsAsync(BatchInsertItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemInfo))
            {
                body["ItemInfo"] = request.ItemInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchInsertItems",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchInsertItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request BatchInsertItemsRequest
         * @return BatchInsertItemsResponse
         */
        public BatchInsertItemsResponse BatchInsertItems(BatchInsertItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchInsertItemsWithOptions(request, runtime);
        }

        /**
         * @param request BatchInsertItemsRequest
         * @return BatchInsertItemsResponse
         */
        public async Task<BatchInsertItemsResponse> BatchInsertItemsAsync(BatchInsertItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchInsertItemsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request BindEslDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindEslDeviceResponse
         */
        public BindEslDeviceResponse BindEslDeviceWithOptions(BindEslDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindEslDevice",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindEslDeviceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request BindEslDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindEslDeviceResponse
         */
        public async Task<BindEslDeviceResponse> BindEslDeviceWithOptionsAsync(BindEslDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindEslDevice",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindEslDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request BindEslDeviceRequest
         * @return BindEslDeviceResponse
         */
        public BindEslDeviceResponse BindEslDevice(BindEslDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindEslDeviceWithOptions(request, runtime);
        }

        /**
         * @param request BindEslDeviceRequest
         * @return BindEslDeviceResponse
         */
        public async Task<BindEslDeviceResponse> BindEslDeviceAsync(BindEslDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindEslDeviceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request BindEslDeviceShelfRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindEslDeviceShelfResponse
         */
        public BindEslDeviceShelfResponse BindEslDeviceShelfWithOptions(BindEslDeviceShelfRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShelfCode))
            {
                body["ShelfCode"] = request.ShelfCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindEslDeviceShelf",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindEslDeviceShelfResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request BindEslDeviceShelfRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindEslDeviceShelfResponse
         */
        public async Task<BindEslDeviceShelfResponse> BindEslDeviceShelfWithOptionsAsync(BindEslDeviceShelfRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShelfCode))
            {
                body["ShelfCode"] = request.ShelfCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindEslDeviceShelf",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindEslDeviceShelfResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request BindEslDeviceShelfRequest
         * @return BindEslDeviceShelfResponse
         */
        public BindEslDeviceShelfResponse BindEslDeviceShelf(BindEslDeviceShelfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindEslDeviceShelfWithOptions(request, runtime);
        }

        /**
         * @param request BindEslDeviceShelfRequest
         * @return BindEslDeviceShelfResponse
         */
        public async Task<BindEslDeviceShelfResponse> BindEslDeviceShelfAsync(BindEslDeviceShelfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindEslDeviceShelfWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ConfirmLogisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConfirmLogisticsResponse
         */
        public ConfirmLogisticsResponse ConfirmLogisticsWithOptions(ConfirmLogisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogisticsDocuments))
            {
                body["LogisticsDocuments"] = request.LogisticsDocuments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoNumber))
            {
                body["PoNumber"] = request.PoNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrNumber))
            {
                body["PrNumber"] = request.PrNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmLogistics",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmLogisticsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ConfirmLogisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConfirmLogisticsResponse
         */
        public async Task<ConfirmLogisticsResponse> ConfirmLogisticsWithOptionsAsync(ConfirmLogisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogisticsDocuments))
            {
                body["LogisticsDocuments"] = request.LogisticsDocuments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoNumber))
            {
                body["PoNumber"] = request.PoNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrNumber))
            {
                body["PrNumber"] = request.PrNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmLogistics",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmLogisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ConfirmLogisticsRequest
         * @return ConfirmLogisticsResponse
         */
        public ConfirmLogisticsResponse ConfirmLogistics(ConfirmLogisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfirmLogisticsWithOptions(request, runtime);
        }

        /**
         * @param request ConfirmLogisticsRequest
         * @return ConfirmLogisticsResponse
         */
        public async Task<ConfirmLogisticsResponse> ConfirmLogisticsAsync(ConfirmLogisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfirmLogisticsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateStoreRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateStoreResponse
         */
        public CreateStoreResponse CreateStoreWithOptions(CreateStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Brand))
            {
                body["Brand"] = request.Brand;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                body["Comments"] = request.Comments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyId))
            {
                body["CompanyId"] = request.CompanyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Groups))
            {
                body["Groups"] = request.Groups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                body["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["ParentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreName))
            {
                body["StoreName"] = request.StoreName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStore",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStoreResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateStoreRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateStoreResponse
         */
        public async Task<CreateStoreResponse> CreateStoreWithOptionsAsync(CreateStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Brand))
            {
                body["Brand"] = request.Brand;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                body["Comments"] = request.Comments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyId))
            {
                body["CompanyId"] = request.CompanyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Groups))
            {
                body["Groups"] = request.Groups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                body["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["ParentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreName))
            {
                body["StoreName"] = request.StoreName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStore",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateStoreRequest
         * @return CreateStoreResponse
         */
        public CreateStoreResponse CreateStore(CreateStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStoreWithOptions(request, runtime);
        }

        /**
         * @param request CreateStoreRequest
         * @return CreateStoreResponse
         */
        public async Task<CreateStoreResponse> CreateStoreAsync(CreateStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStoreWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteApDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteApDeviceResponse
         */
        public DeleteApDeviceResponse DeleteApDeviceWithOptions(DeleteApDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                body["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApDevice",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApDeviceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteApDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteApDeviceResponse
         */
        public async Task<DeleteApDeviceResponse> DeleteApDeviceWithOptionsAsync(DeleteApDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                body["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApDevice",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteApDeviceRequest
         * @return DeleteApDeviceResponse
         */
        public DeleteApDeviceResponse DeleteApDevice(DeleteApDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApDeviceWithOptions(request, runtime);
        }

        /**
         * @param request DeleteApDeviceRequest
         * @return DeleteApDeviceResponse
         */
        public async Task<DeleteApDeviceResponse> DeleteApDeviceAsync(DeleteApDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApDeviceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteEslDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEslDeviceResponse
         */
        public DeleteEslDeviceResponse DeleteEslDeviceWithOptions(DeleteEslDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEslDevice",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEslDeviceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteEslDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEslDeviceResponse
         */
        public async Task<DeleteEslDeviceResponse> DeleteEslDeviceWithOptionsAsync(DeleteEslDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEslDevice",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEslDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteEslDeviceRequest
         * @return DeleteEslDeviceResponse
         */
        public DeleteEslDeviceResponse DeleteEslDevice(DeleteEslDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEslDeviceWithOptions(request, runtime);
        }

        /**
         * @param request DeleteEslDeviceRequest
         * @return DeleteEslDeviceResponse
         */
        public async Task<DeleteEslDeviceResponse> DeleteEslDeviceAsync(DeleteEslDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEslDeviceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteItemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteItemResponse
         */
        public DeleteItemResponse DeleteItemWithOptions(DeleteItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteItem",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteItemResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteItemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteItemResponse
         */
        public async Task<DeleteItemResponse> DeleteItemWithOptionsAsync(DeleteItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteItem",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteItemRequest
         * @return DeleteItemResponse
         */
        public DeleteItemResponse DeleteItem(DeleteItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteItemWithOptions(request, runtime);
        }

        /**
         * @param request DeleteItemRequest
         * @return DeleteItemResponse
         */
        public async Task<DeleteItemResponse> DeleteItemAsync(DeleteItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteItemWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteItemBySkuIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteItemBySkuIdResponse
         */
        public DeleteItemBySkuIdResponse DeleteItemBySkuIdWithOptions(DeleteItemBySkuIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkuId))
            {
                body["SkuId"] = request.SkuId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteItemBySkuId",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteItemBySkuIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteItemBySkuIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteItemBySkuIdResponse
         */
        public async Task<DeleteItemBySkuIdResponse> DeleteItemBySkuIdWithOptionsAsync(DeleteItemBySkuIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkuId))
            {
                body["SkuId"] = request.SkuId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteItemBySkuId",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteItemBySkuIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteItemBySkuIdRequest
         * @return DeleteItemBySkuIdResponse
         */
        public DeleteItemBySkuIdResponse DeleteItemBySkuId(DeleteItemBySkuIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteItemBySkuIdWithOptions(request, runtime);
        }

        /**
         * @param request DeleteItemBySkuIdRequest
         * @return DeleteItemBySkuIdResponse
         */
        public async Task<DeleteItemBySkuIdResponse> DeleteItemBySkuIdAsync(DeleteItemBySkuIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteItemBySkuIdWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteStoreRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteStoreResponse
         */
        public DeleteStoreResponse DeleteStoreWithOptions(DeleteStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStore",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStoreResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteStoreRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteStoreResponse
         */
        public async Task<DeleteStoreResponse> DeleteStoreWithOptionsAsync(DeleteStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStore",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteStoreRequest
         * @return DeleteStoreResponse
         */
        public DeleteStoreResponse DeleteStore(DeleteStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteStoreWithOptions(request, runtime);
        }

        /**
         * @param request DeleteStoreRequest
         * @return DeleteStoreResponse
         */
        public async Task<DeleteStoreResponse> DeleteStoreAsync(DeleteStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteStoreWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserResponse
         */
        public DeleteUserResponse DeleteUserWithOptions(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserResponse
         */
        public async Task<DeleteUserResponse> DeleteUserWithOptionsAsync(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteUserRequest
         * @return DeleteUserResponse
         */
        public DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserWithOptions(request, runtime);
        }

        /**
         * @param request DeleteUserRequest
         * @return DeleteUserResponse
         */
        public async Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAlarmsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAlarmsResponse
         */
        public DescribeAlarmsResponse DescribeAlarmsWithOptions(DescribeAlarmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmId))
            {
                body["AlarmId"] = request.AlarmId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmStatus))
            {
                body["AlarmStatus"] = request.AlarmStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmType))
            {
                body["AlarmType"] = request.AlarmType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorType))
            {
                body["ErrorType"] = request.ErrorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromAlarmTime))
            {
                body["FromAlarmTime"] = request.FromAlarmTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToAlarmTime))
            {
                body["ToAlarmTime"] = request.ToAlarmTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlarms",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlarmsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAlarmsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAlarmsResponse
         */
        public async Task<DescribeAlarmsResponse> DescribeAlarmsWithOptionsAsync(DescribeAlarmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmId))
            {
                body["AlarmId"] = request.AlarmId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmStatus))
            {
                body["AlarmStatus"] = request.AlarmStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmType))
            {
                body["AlarmType"] = request.AlarmType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorType))
            {
                body["ErrorType"] = request.ErrorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromAlarmTime))
            {
                body["FromAlarmTime"] = request.FromAlarmTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToAlarmTime))
            {
                body["ToAlarmTime"] = request.ToAlarmTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlarms",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlarmsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAlarmsRequest
         * @return DescribeAlarmsResponse
         */
        public DescribeAlarmsResponse DescribeAlarms(DescribeAlarmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlarmsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAlarmsRequest
         * @return DescribeAlarmsResponse
         */
        public async Task<DescribeAlarmsResponse> DescribeAlarmsAsync(DescribeAlarmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlarmsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeApDevicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApDevicesResponse
         */
        public DescribeApDevicesResponse DescribeApDevicesWithOptions(DescribeApDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Activated))
            {
                body["Activated"] = request.Activated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                body["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApDevices",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApDevicesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeApDevicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApDevicesResponse
         */
        public async Task<DescribeApDevicesResponse> DescribeApDevicesWithOptionsAsync(DescribeApDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Activated))
            {
                body["Activated"] = request.Activated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                body["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApDevices",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApDevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeApDevicesRequest
         * @return DescribeApDevicesResponse
         */
        public DescribeApDevicesResponse DescribeApDevices(DescribeApDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApDevicesWithOptions(request, runtime);
        }

        /**
         * @param request DescribeApDevicesRequest
         * @return DescribeApDevicesResponse
         */
        public async Task<DescribeApDevicesResponse> DescribeApDevicesAsync(DescribeApDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApDevicesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeEslDevicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEslDevicesResponse
         */
        public DescribeEslDevicesResponse DescribeEslDevicesWithOptions(DescribeEslDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeBind))
            {
                body["BeBind"] = request.BeBind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslStatus))
            {
                body["EslStatus"] = request.EslStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromBatteryLevel))
            {
                body["FromBatteryLevel"] = request.FromBatteryLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                body["Mac"] = request.Mac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShelfCode))
            {
                body["ShelfCode"] = request.ShelfCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToBatteryLevel))
            {
                body["ToBatteryLevel"] = request.ToBatteryLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vendor))
            {
                body["Vendor"] = request.Vendor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEslDevices",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEslDevicesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeEslDevicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEslDevicesResponse
         */
        public async Task<DescribeEslDevicesResponse> DescribeEslDevicesWithOptionsAsync(DescribeEslDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeBind))
            {
                body["BeBind"] = request.BeBind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslStatus))
            {
                body["EslStatus"] = request.EslStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromBatteryLevel))
            {
                body["FromBatteryLevel"] = request.FromBatteryLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                body["Mac"] = request.Mac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShelfCode))
            {
                body["ShelfCode"] = request.ShelfCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToBatteryLevel))
            {
                body["ToBatteryLevel"] = request.ToBatteryLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vendor))
            {
                body["Vendor"] = request.Vendor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEslDevices",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEslDevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeEslDevicesRequest
         * @return DescribeEslDevicesResponse
         */
        public DescribeEslDevicesResponse DescribeEslDevices(DescribeEslDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEslDevicesWithOptions(request, runtime);
        }

        /**
         * @param request DescribeEslDevicesRequest
         * @return DescribeEslDevicesResponse
         */
        public async Task<DescribeEslDevicesResponse> DescribeEslDevicesAsync(DescribeEslDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEslDevicesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeItemsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeItemsResponse
         */
        public DescribeItemsResponse DescribeItemsWithOptions(DescribeItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BePromotion))
            {
                body["BePromotion"] = request.BePromotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                body["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTitle))
            {
                body["ItemTitle"] = request.ItemTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkuId))
            {
                body["SkuId"] = request.SkuId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeItems",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeItemsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeItemsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeItemsResponse
         */
        public async Task<DescribeItemsResponse> DescribeItemsWithOptionsAsync(DescribeItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BePromotion))
            {
                body["BePromotion"] = request.BePromotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                body["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTitle))
            {
                body["ItemTitle"] = request.ItemTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkuId))
            {
                body["SkuId"] = request.SkuId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeItems",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeItemsRequest
         * @return DescribeItemsResponse
         */
        public DescribeItemsResponse DescribeItems(DescribeItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeItemsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeItemsRequest
         * @return DescribeItemsResponse
         */
        public async Task<DescribeItemsResponse> DescribeItemsAsync(DescribeItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeItemsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeLogisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLogisticsResponse
         */
        public DescribeLogisticsResponse DescribeLogisticsWithOptions(DescribeLogisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["OrderId"] = request.OrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogistics",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogisticsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeLogisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLogisticsResponse
         */
        public async Task<DescribeLogisticsResponse> DescribeLogisticsWithOptionsAsync(DescribeLogisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["OrderId"] = request.OrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogistics",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeLogisticsRequest
         * @return DescribeLogisticsResponse
         */
        public DescribeLogisticsResponse DescribeLogistics(DescribeLogisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLogisticsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeLogisticsRequest
         * @return DescribeLogisticsResponse
         */
        public async Task<DescribeLogisticsResponse> DescribeLogisticsAsync(DescribeLogisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLogisticsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribePayOrdersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePayOrdersResponse
         */
        public DescribePayOrdersResponse DescribePayOrdersWithOptions(DescribePayOrdersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDate))
            {
                body["FromDate"] = request.FromDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDate))
            {
                body["ToDate"] = request.ToDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePayOrders",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePayOrdersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribePayOrdersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePayOrdersResponse
         */
        public async Task<DescribePayOrdersResponse> DescribePayOrdersWithOptionsAsync(DescribePayOrdersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDate))
            {
                body["FromDate"] = request.FromDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDate))
            {
                body["ToDate"] = request.ToDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePayOrders",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePayOrdersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribePayOrdersRequest
         * @return DescribePayOrdersResponse
         */
        public DescribePayOrdersResponse DescribePayOrders(DescribePayOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePayOrdersWithOptions(request, runtime);
        }

        /**
         * @param request DescribePayOrdersRequest
         * @return DescribePayOrdersResponse
         */
        public async Task<DescribePayOrdersResponse> DescribePayOrdersAsync(DescribePayOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePayOrdersWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribePlanogramRailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePlanogramRailsResponse
         */
        public DescribePlanogramRailsResponse DescribePlanogramRailsWithOptions(DescribePlanogramRailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layer))
            {
                body["Layer"] = request.Layer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RailCode))
            {
                body["RailCode"] = request.RailCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shelf))
            {
                body["Shelf"] = request.Shelf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlanogramRails",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlanogramRailsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribePlanogramRailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePlanogramRailsResponse
         */
        public async Task<DescribePlanogramRailsResponse> DescribePlanogramRailsWithOptionsAsync(DescribePlanogramRailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layer))
            {
                body["Layer"] = request.Layer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RailCode))
            {
                body["RailCode"] = request.RailCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shelf))
            {
                body["Shelf"] = request.Shelf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlanogramRails",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlanogramRailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribePlanogramRailsRequest
         * @return DescribePlanogramRailsResponse
         */
        public DescribePlanogramRailsResponse DescribePlanogramRails(DescribePlanogramRailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlanogramRailsWithOptions(request, runtime);
        }

        /**
         * @param request DescribePlanogramRailsRequest
         * @return DescribePlanogramRailsResponse
         */
        public async Task<DescribePlanogramRailsResponse> DescribePlanogramRailsAsync(DescribePlanogramRailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlanogramRailsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeStoresRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeStoresResponse
         */
        public DescribeStoresResponse DescribeStoresWithOptions(DescribeStoresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Brand))
            {
                body["Brand"] = request.Brand;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyId))
            {
                body["CompanyId"] = request.CompanyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDate))
            {
                body["FromDate"] = request.FromDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreName))
            {
                body["StoreName"] = request.StoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDate))
            {
                body["ToDate"] = request.ToDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStores",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStoresResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeStoresRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeStoresResponse
         */
        public async Task<DescribeStoresResponse> DescribeStoresWithOptionsAsync(DescribeStoresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Brand))
            {
                body["Brand"] = request.Brand;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyId))
            {
                body["CompanyId"] = request.CompanyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDate))
            {
                body["FromDate"] = request.FromDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreName))
            {
                body["StoreName"] = request.StoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDate))
            {
                body["ToDate"] = request.ToDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStores",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStoresResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeStoresRequest
         * @return DescribeStoresResponse
         */
        public DescribeStoresResponse DescribeStores(DescribeStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStoresWithOptions(request, runtime);
        }

        /**
         * @param request DescribeStoresRequest
         * @return DescribeStoresResponse
         */
        public async Task<DescribeStoresResponse> DescribeStoresAsync(DescribeStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStoresWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeUserLogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserLogResponse
         */
        public DescribeUserLogResponse DescribeUserLogWithOptions(DescribeUserLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDate))
            {
                body["FromDate"] = request.FromDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                body["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTitle))
            {
                body["ItemTitle"] = request.ItemTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateStatus))
            {
                body["OperateStatus"] = request.OperateStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                body["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                body["OperateUserId"] = request.OperateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                body["Reverse"] = request.Reverse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDate))
            {
                body["ToDate"] = request.ToDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserLog",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserLogResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeUserLogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserLogResponse
         */
        public async Task<DescribeUserLogResponse> DescribeUserLogWithOptionsAsync(DescribeUserLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDate))
            {
                body["FromDate"] = request.FromDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                body["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTitle))
            {
                body["ItemTitle"] = request.ItemTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateStatus))
            {
                body["OperateStatus"] = request.OperateStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                body["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                body["OperateUserId"] = request.OperateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                body["Reverse"] = request.Reverse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDate))
            {
                body["ToDate"] = request.ToDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserLog",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeUserLogRequest
         * @return DescribeUserLogResponse
         */
        public DescribeUserLogResponse DescribeUserLog(DescribeUserLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserLogWithOptions(request, runtime);
        }

        /**
         * @param request DescribeUserLogRequest
         * @return DescribeUserLogResponse
         */
        public async Task<DescribeUserLogResponse> DescribeUserLogAsync(DescribeUserLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserLogWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUsersResponse
         */
        public DescribeUsersResponse DescribeUsersWithOptions(DescribeUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                body["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsers",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUsersResponse
         */
        public async Task<DescribeUsersResponse> DescribeUsersWithOptionsAsync(DescribeUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                body["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsers",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeUsersRequest
         * @return DescribeUsersResponse
         */
        public DescribeUsersResponse DescribeUsers(DescribeUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUsersWithOptions(request, runtime);
        }

        /**
         * @param request DescribeUsersRequest
         * @return DescribeUsersResponse
         */
        public async Task<DescribeUsersResponse> DescribeUsersAsync(DescribeUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetCompanyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCompanyResponse
         */
        public GetCompanyResponse GetCompanyWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCompany",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCompanyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetCompanyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCompanyResponse
         */
        public async Task<GetCompanyResponse> GetCompanyWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCompany",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCompanyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return GetCompanyResponse
         */
        public GetCompanyResponse GetCompany()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCompanyWithOptions(runtime);
        }

        /**
         * @return GetCompanyResponse
         */
        public async Task<GetCompanyResponse> GetCompanyAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCompanyWithOptionsAsync(runtime);
        }

        /**
         * @param request GetUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserResponse
         */
        public GetUserResponse GetUserWithOptions(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2019-08-01",
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

        /**
         * @param request GetUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserResponse
         */
        public async Task<GetUserResponse> GetUserWithOptionsAsync(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2019-08-01",
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

        /**
         * @param request GetUserRequest
         * @return GetUserResponse
         */
        public GetUserResponse GetUser(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserWithOptions(request, runtime);
        }

        /**
         * @param request GetUserRequest
         * @return GetUserResponse
         */
        public async Task<GetUserResponse> GetUserAsync(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserWithOptionsAsync(request, runtime);
        }

        /**
         * @param request MapPlanogramRailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MapPlanogramRailResponse
         */
        public MapPlanogramRailResponse MapPlanogramRailWithOptions(MapPlanogramRailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layer))
            {
                body["Layer"] = request.Layer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RailCode))
            {
                body["RailCode"] = request.RailCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shelf))
            {
                body["Shelf"] = request.Shelf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MapPlanogramRail",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MapPlanogramRailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request MapPlanogramRailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MapPlanogramRailResponse
         */
        public async Task<MapPlanogramRailResponse> MapPlanogramRailWithOptionsAsync(MapPlanogramRailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layer))
            {
                body["Layer"] = request.Layer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RailCode))
            {
                body["RailCode"] = request.RailCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shelf))
            {
                body["Shelf"] = request.Shelf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MapPlanogramRail",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MapPlanogramRailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request MapPlanogramRailRequest
         * @return MapPlanogramRailResponse
         */
        public MapPlanogramRailResponse MapPlanogramRail(MapPlanogramRailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MapPlanogramRailWithOptions(request, runtime);
        }

        /**
         * @param request MapPlanogramRailRequest
         * @return MapPlanogramRailResponse
         */
        public async Task<MapPlanogramRailResponse> MapPlanogramRailAsync(MapPlanogramRailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MapPlanogramRailWithOptionsAsync(request, runtime);
        }

        /**
         * @param request RefreshTaobaoItemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefreshTaobaoItemResponse
         */
        public RefreshTaobaoItemResponse RefreshTaobaoItemWithOptions(RefreshTaobaoItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterId))
            {
                body["OuterId"] = request.OuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkuId))
            {
                body["SkuId"] = request.SkuId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaobaoItemId))
            {
                body["TaobaoItemId"] = request.TaobaoItemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshTaobaoItem",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshTaobaoItemResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request RefreshTaobaoItemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefreshTaobaoItemResponse
         */
        public async Task<RefreshTaobaoItemResponse> RefreshTaobaoItemWithOptionsAsync(RefreshTaobaoItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterId))
            {
                body["OuterId"] = request.OuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkuId))
            {
                body["SkuId"] = request.SkuId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaobaoItemId))
            {
                body["TaobaoItemId"] = request.TaobaoItemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshTaobaoItem",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshTaobaoItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request RefreshTaobaoItemRequest
         * @return RefreshTaobaoItemResponse
         */
        public RefreshTaobaoItemResponse RefreshTaobaoItem(RefreshTaobaoItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshTaobaoItemWithOptions(request, runtime);
        }

        /**
         * @param request RefreshTaobaoItemRequest
         * @return RefreshTaobaoItemResponse
         */
        public async Task<RefreshTaobaoItemResponse> RefreshTaobaoItemAsync(RefreshTaobaoItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshTaobaoItemWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UnassignUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnassignUserResponse
         */
        public UnassignUserResponse UnassignUserWithOptions(UnassignUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnassignUser",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnassignUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UnassignUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnassignUserResponse
         */
        public async Task<UnassignUserResponse> UnassignUserWithOptionsAsync(UnassignUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnassignUser",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnassignUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UnassignUserRequest
         * @return UnassignUserResponse
         */
        public UnassignUserResponse UnassignUser(UnassignUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnassignUserWithOptions(request, runtime);
        }

        /**
         * @param request UnassignUserRequest
         * @return UnassignUserResponse
         */
        public async Task<UnassignUserResponse> UnassignUserAsync(UnassignUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnassignUserWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UnbindEslDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindEslDeviceResponse
         */
        public UnbindEslDeviceResponse UnbindEslDeviceWithOptions(UnbindEslDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindEslDevice",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindEslDeviceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UnbindEslDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindEslDeviceResponse
         */
        public async Task<UnbindEslDeviceResponse> UnbindEslDeviceWithOptionsAsync(UnbindEslDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindEslDevice",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindEslDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UnbindEslDeviceRequest
         * @return UnbindEslDeviceResponse
         */
        public UnbindEslDeviceResponse UnbindEslDevice(UnbindEslDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindEslDeviceWithOptions(request, runtime);
        }

        /**
         * @param request UnbindEslDeviceRequest
         * @return UnbindEslDeviceResponse
         */
        public async Task<UnbindEslDeviceResponse> UnbindEslDeviceAsync(UnbindEslDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindEslDeviceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UnbindEslDeviceShelfRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindEslDeviceShelfResponse
         */
        public UnbindEslDeviceShelfResponse UnbindEslDeviceShelfWithOptions(UnbindEslDeviceShelfRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindEslDeviceShelf",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindEslDeviceShelfResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UnbindEslDeviceShelfRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindEslDeviceShelfResponse
         */
        public async Task<UnbindEslDeviceShelfResponse> UnbindEslDeviceShelfWithOptionsAsync(UnbindEslDeviceShelfRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindEslDeviceShelf",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindEslDeviceShelfResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UnbindEslDeviceShelfRequest
         * @return UnbindEslDeviceShelfResponse
         */
        public UnbindEslDeviceShelfResponse UnbindEslDeviceShelf(UnbindEslDeviceShelfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindEslDeviceShelfWithOptions(request, runtime);
        }

        /**
         * @param request UnbindEslDeviceShelfRequest
         * @return UnbindEslDeviceShelfResponse
         */
        public async Task<UnbindEslDeviceShelfResponse> UnbindEslDeviceShelfAsync(UnbindEslDeviceShelfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindEslDeviceShelfWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UnmapPlanogramRailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnmapPlanogramRailResponse
         */
        public UnmapPlanogramRailResponse UnmapPlanogramRailWithOptions(UnmapPlanogramRailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RailCode))
            {
                body["RailCode"] = request.RailCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnmapPlanogramRail",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnmapPlanogramRailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UnmapPlanogramRailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnmapPlanogramRailResponse
         */
        public async Task<UnmapPlanogramRailResponse> UnmapPlanogramRailWithOptionsAsync(UnmapPlanogramRailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RailCode))
            {
                body["RailCode"] = request.RailCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnmapPlanogramRail",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnmapPlanogramRailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UnmapPlanogramRailRequest
         * @return UnmapPlanogramRailResponse
         */
        public UnmapPlanogramRailResponse UnmapPlanogramRail(UnmapPlanogramRailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnmapPlanogramRailWithOptions(request, runtime);
        }

        /**
         * @param request UnmapPlanogramRailRequest
         * @return UnmapPlanogramRailResponse
         */
        public async Task<UnmapPlanogramRailResponse> UnmapPlanogramRailAsync(UnmapPlanogramRailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnmapPlanogramRailWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateEslDeviceLightRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateEslDeviceLightResponse
         */
        public UpdateEslDeviceLightResponse UpdateEslDeviceLightWithOptions(UpdateEslDeviceLightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Frequency))
            {
                body["Frequency"] = request.Frequency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LedColor))
            {
                body["LedColor"] = request.LedColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LightUpTime))
            {
                body["LightUpTime"] = request.LightUpTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEslDeviceLight",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEslDeviceLightResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateEslDeviceLightRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateEslDeviceLightResponse
         */
        public async Task<UpdateEslDeviceLightResponse> UpdateEslDeviceLightWithOptionsAsync(UpdateEslDeviceLightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Frequency))
            {
                body["Frequency"] = request.Frequency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LedColor))
            {
                body["LedColor"] = request.LedColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LightUpTime))
            {
                body["LightUpTime"] = request.LightUpTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEslDeviceLight",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEslDeviceLightResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateEslDeviceLightRequest
         * @return UpdateEslDeviceLightResponse
         */
        public UpdateEslDeviceLightResponse UpdateEslDeviceLight(UpdateEslDeviceLightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEslDeviceLightWithOptions(request, runtime);
        }

        /**
         * @param request UpdateEslDeviceLightRequest
         * @return UpdateEslDeviceLightResponse
         */
        public async Task<UpdateEslDeviceLightResponse> UpdateEslDeviceLightAsync(UpdateEslDeviceLightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEslDeviceLightWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateStoreRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateStoreResponse
         */
        public UpdateStoreResponse UpdateStoreWithOptions(UpdateStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Brand))
            {
                body["Brand"] = request.Brand;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                body["Comments"] = request.Comments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Groups))
            {
                body["Groups"] = request.Groups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                body["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreName))
            {
                body["StoreName"] = request.StoreName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStore",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStoreResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateStoreRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateStoreResponse
         */
        public async Task<UpdateStoreResponse> UpdateStoreWithOptionsAsync(UpdateStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Brand))
            {
                body["Brand"] = request.Brand;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                body["Comments"] = request.Comments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Groups))
            {
                body["Groups"] = request.Groups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                body["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreName))
            {
                body["StoreName"] = request.StoreName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStore",
                Version = "2019-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateStoreRequest
         * @return UpdateStoreResponse
         */
        public UpdateStoreResponse UpdateStore(UpdateStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateStoreWithOptions(request, runtime);
        }

        /**
         * @param request UpdateStoreRequest
         * @return UpdateStoreResponse
         */
        public async Task<UpdateStoreResponse> UpdateStoreAsync(UpdateStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateStoreWithOptionsAsync(request, runtime);
        }

    }
}
