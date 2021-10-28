// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Sgw20180511.Models;

namespace AlibabaCloud.SDK.Sgw20180511
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "sgw.cn-shanghai.aliyuncs.com"},
                {"cn-beijing", "sgw.cn-shanghai.aliyuncs.com"},
                {"cn-chengdu", "sgw.cn-shanghai.aliyuncs.com"},
                {"cn-zhangjiakou", "sgw.cn-shanghai.aliyuncs.com"},
                {"cn-huhehaote", "sgw.cn-shanghai.aliyuncs.com"},
                {"cn-hangzhou", "sgw.cn-shanghai.aliyuncs.com"},
                {"cn-shenzhen", "sgw.cn-shanghai.aliyuncs.com"},
                {"cn-hongkong", "sgw.cn-shanghai.aliyuncs.com"},
                {"us-east-1", "sgw.us-west-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("sgw", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ActivateAllInOneGatewayResponse ActivateAllInOneGatewayWithOptions(ActivateAllInOneGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientUUID"] = request.ClientUUID;
            query["DeviceNumber"] = request.DeviceNumber;
            query["GatewayId"] = request.GatewayId;
            query["Model"] = request.Model;
            query["SecurityToken"] = request.SecurityToken;
            query["SerialNumber"] = request.SerialNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateAllInOneGateway",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateAllInOneGatewayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ActivateAllInOneGatewayResponse> ActivateAllInOneGatewayWithOptionsAsync(ActivateAllInOneGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientUUID"] = request.ClientUUID;
            query["DeviceNumber"] = request.DeviceNumber;
            query["GatewayId"] = request.GatewayId;
            query["Model"] = request.Model;
            query["SecurityToken"] = request.SecurityToken;
            query["SerialNumber"] = request.SerialNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateAllInOneGateway",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateAllInOneGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ActivateAllInOneGatewayResponse ActivateAllInOneGateway(ActivateAllInOneGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActivateAllInOneGatewayWithOptions(request, runtime);
        }

        public async Task<ActivateAllInOneGatewayResponse> ActivateAllInOneGatewayAsync(ActivateAllInOneGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActivateAllInOneGatewayWithOptionsAsync(request, runtime);
        }

        public ActivateGatewayResponse ActivateGatewayWithOptions(ActivateGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Category"] = request.Category;
            query["ClientUUID"] = request.ClientUUID;
            query["Model"] = request.Model;
            query["SecurityToken"] = request.SecurityToken;
            query["SerialNumber"] = request.SerialNumber;
            query["Token"] = request.Token;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateGateway",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateGatewayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ActivateGatewayResponse> ActivateGatewayWithOptionsAsync(ActivateGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Category"] = request.Category;
            query["ClientUUID"] = request.ClientUUID;
            query["Model"] = request.Model;
            query["SecurityToken"] = request.SecurityToken;
            query["SerialNumber"] = request.SerialNumber;
            query["Token"] = request.Token;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateGateway",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ActivateGatewayResponse ActivateGateway(ActivateGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActivateGatewayWithOptions(request, runtime);
        }

        public async Task<ActivateGatewayResponse> ActivateGatewayAsync(ActivateGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActivateGatewayWithOptionsAsync(request, runtime);
        }

        public AddSharesToExpressSyncResponse AddSharesToExpressSyncWithOptions(AddSharesToExpressSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ExpressSyncId"] = request.ExpressSyncId;
            query["GatewayShares"] = request.GatewayShares;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSharesToExpressSync",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSharesToExpressSyncResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddSharesToExpressSyncResponse> AddSharesToExpressSyncWithOptionsAsync(AddSharesToExpressSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ExpressSyncId"] = request.ExpressSyncId;
            query["GatewayShares"] = request.GatewayShares;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSharesToExpressSync",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSharesToExpressSyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddSharesToExpressSyncResponse AddSharesToExpressSync(AddSharesToExpressSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSharesToExpressSyncWithOptions(request, runtime);
        }

        public async Task<AddSharesToExpressSyncResponse> AddSharesToExpressSyncAsync(AddSharesToExpressSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSharesToExpressSyncWithOptionsAsync(request, runtime);
        }

        public AddTagsToGatewayResponse AddTagsToGatewayWithOptions(AddTagsToGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["Tags"] = request.Tags;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTagsToGateway",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTagsToGatewayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddTagsToGatewayResponse> AddTagsToGatewayWithOptionsAsync(AddTagsToGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["Tags"] = request.Tags;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTagsToGateway",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTagsToGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddTagsToGatewayResponse AddTagsToGateway(AddTagsToGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTagsToGatewayWithOptions(request, runtime);
        }

        public async Task<AddTagsToGatewayResponse> AddTagsToGatewayAsync(AddTagsToGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTagsToGatewayWithOptionsAsync(request, runtime);
        }

        public CheckActivationKeyResponse CheckActivationKeyWithOptions(CheckActivationKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CryptKey"] = request.CryptKey;
            query["CryptText"] = request.CryptText;
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["Token"] = request.Token;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckActivationKey",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckActivationKeyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckActivationKeyResponse> CheckActivationKeyWithOptionsAsync(CheckActivationKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CryptKey"] = request.CryptKey;
            query["CryptText"] = request.CryptText;
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["Token"] = request.Token;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckActivationKey",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckActivationKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckActivationKeyResponse CheckActivationKey(CheckActivationKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckActivationKeyWithOptions(request, runtime);
        }

        public async Task<CheckActivationKeyResponse> CheckActivationKeyAsync(CheckActivationKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckActivationKeyWithOptionsAsync(request, runtime);
        }

        public CheckBlockVolumeNameResponse CheckBlockVolumeNameWithOptions(CheckBlockVolumeNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BucketEndpoint"] = request.BucketEndpoint;
            query["BucketName"] = request.BucketName;
            query["SecurityToken"] = request.SecurityToken;
            query["VolumeName"] = request.VolumeName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckBlockVolumeName",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckBlockVolumeNameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckBlockVolumeNameResponse> CheckBlockVolumeNameWithOptionsAsync(CheckBlockVolumeNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BucketEndpoint"] = request.BucketEndpoint;
            query["BucketName"] = request.BucketName;
            query["SecurityToken"] = request.SecurityToken;
            query["VolumeName"] = request.VolumeName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckBlockVolumeName",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckBlockVolumeNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckBlockVolumeNameResponse CheckBlockVolumeName(CheckBlockVolumeNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckBlockVolumeNameWithOptions(request, runtime);
        }

        public async Task<CheckBlockVolumeNameResponse> CheckBlockVolumeNameAsync(CheckBlockVolumeNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckBlockVolumeNameWithOptionsAsync(request, runtime);
        }

        public CheckGatewayEssdSupportResponse CheckGatewayEssdSupportWithOptions(CheckGatewayEssdSupportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckGatewayEssdSupport",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckGatewayEssdSupportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckGatewayEssdSupportResponse> CheckGatewayEssdSupportWithOptionsAsync(CheckGatewayEssdSupportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckGatewayEssdSupport",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckGatewayEssdSupportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckGatewayEssdSupportResponse CheckGatewayEssdSupport(CheckGatewayEssdSupportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckGatewayEssdSupportWithOptions(request, runtime);
        }

        public async Task<CheckGatewayEssdSupportResponse> CheckGatewayEssdSupportAsync(CheckGatewayEssdSupportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckGatewayEssdSupportWithOptionsAsync(request, runtime);
        }

        public CheckMnsServiceResponse CheckMnsServiceWithOptions(CheckMnsServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckMnsService",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckMnsServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckMnsServiceResponse> CheckMnsServiceWithOptionsAsync(CheckMnsServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckMnsService",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckMnsServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckMnsServiceResponse CheckMnsService(CheckMnsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckMnsServiceWithOptions(request, runtime);
        }

        public async Task<CheckMnsServiceResponse> CheckMnsServiceAsync(CheckMnsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckMnsServiceWithOptionsAsync(request, runtime);
        }

        public CheckRoleResponse CheckRoleWithOptions(CheckRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RoleType"] = request.RoleType;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckRole",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckRoleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckRoleResponse> CheckRoleWithOptionsAsync(CheckRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RoleType"] = request.RoleType;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckRole",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckRoleResponse CheckRole(CheckRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckRoleWithOptions(request, runtime);
        }

        public async Task<CheckRoleResponse> CheckRoleAsync(CheckRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckRoleWithOptionsAsync(request, runtime);
        }

        public CheckSlrRoleResponse CheckSlrRoleWithOptions(CheckSlrRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CreateIfNotExist"] = request.CreateIfNotExist;
            query["RoleName"] = request.RoleName;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckSlrRole",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckSlrRoleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckSlrRoleResponse> CheckSlrRoleWithOptionsAsync(CheckSlrRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CreateIfNotExist"] = request.CreateIfNotExist;
            query["RoleName"] = request.RoleName;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckSlrRole",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckSlrRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckSlrRoleResponse CheckSlrRole(CheckSlrRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckSlrRoleWithOptions(request, runtime);
        }

        public async Task<CheckSlrRoleResponse> CheckSlrRoleAsync(CheckSlrRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckSlrRoleWithOptionsAsync(request, runtime);
        }

        public CheckUpgradeVersionResponse CheckUpgradeVersionWithOptions(CheckUpgradeVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientUUID"] = request.ClientUUID;
            query["GatewayId"] = request.GatewayId;
            query["GatewayVersion"] = request.GatewayVersion;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckUpgradeVersion",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckUpgradeVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckUpgradeVersionResponse> CheckUpgradeVersionWithOptionsAsync(CheckUpgradeVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientUUID"] = request.ClientUUID;
            query["GatewayId"] = request.GatewayId;
            query["GatewayVersion"] = request.GatewayVersion;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckUpgradeVersion",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckUpgradeVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckUpgradeVersionResponse CheckUpgradeVersion(CheckUpgradeVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckUpgradeVersionWithOptions(request, runtime);
        }

        public async Task<CheckUpgradeVersionResponse> CheckUpgradeVersionAsync(CheckUpgradeVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckUpgradeVersionWithOptionsAsync(request, runtime);
        }

        public CreateCacheResponse CreateCacheWithOptions(CreateCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Category"] = request.Category;
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["SizeInGB"] = request.SizeInGB;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCache",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCacheResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateCacheResponse> CreateCacheWithOptionsAsync(CreateCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Category"] = request.Category;
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["SizeInGB"] = request.SizeInGB;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCache",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCacheResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateCacheResponse CreateCache(CreateCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCacheWithOptions(request, runtime);
        }

        public async Task<CreateCacheResponse> CreateCacheAsync(CreateCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCacheWithOptionsAsync(request, runtime);
        }

        public CreateElasticGatewayPrivateZoneResponse CreateElasticGatewayPrivateZoneWithOptions(CreateElasticGatewayPrivateZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateElasticGatewayPrivateZone",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateElasticGatewayPrivateZoneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateElasticGatewayPrivateZoneResponse> CreateElasticGatewayPrivateZoneWithOptionsAsync(CreateElasticGatewayPrivateZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateElasticGatewayPrivateZone",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateElasticGatewayPrivateZoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateElasticGatewayPrivateZoneResponse CreateElasticGatewayPrivateZone(CreateElasticGatewayPrivateZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateElasticGatewayPrivateZoneWithOptions(request, runtime);
        }

        public async Task<CreateElasticGatewayPrivateZoneResponse> CreateElasticGatewayPrivateZoneAsync(CreateElasticGatewayPrivateZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateElasticGatewayPrivateZoneWithOptionsAsync(request, runtime);
        }

        public CreateExpressSyncResponse CreateExpressSyncWithOptions(CreateExpressSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BucketName"] = request.BucketName;
            query["BucketPrefix"] = request.BucketPrefix;
            query["BucketRegion"] = request.BucketRegion;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExpressSync",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExpressSyncResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateExpressSyncResponse> CreateExpressSyncWithOptionsAsync(CreateExpressSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BucketName"] = request.BucketName;
            query["BucketPrefix"] = request.BucketPrefix;
            query["BucketRegion"] = request.BucketRegion;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExpressSync",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExpressSyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateExpressSyncResponse CreateExpressSync(CreateExpressSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateExpressSyncWithOptions(request, runtime);
        }

        public async Task<CreateExpressSyncResponse> CreateExpressSyncAsync(CreateExpressSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateExpressSyncWithOptionsAsync(request, runtime);
        }

        public CreateGatewayResponse CreateGatewayWithOptions(CreateGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["GatewayClass"] = request.GatewayClass;
            query["Location"] = request.Location;
            query["Name"] = request.Name;
            query["PostPaid"] = request.PostPaid;
            query["PublicNetworkBandwidth"] = request.PublicNetworkBandwidth;
            query["ReleaseAfterExpiration"] = request.ReleaseAfterExpiration;
            query["SecurityToken"] = request.SecurityToken;
            query["StorageBundleId"] = request.StorageBundleId;
            query["Type"] = request.Type;
            query["VSwitchId"] = request.VSwitchId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGateway",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateGatewayResponse> CreateGatewayWithOptionsAsync(CreateGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["GatewayClass"] = request.GatewayClass;
            query["Location"] = request.Location;
            query["Name"] = request.Name;
            query["PostPaid"] = request.PostPaid;
            query["PublicNetworkBandwidth"] = request.PublicNetworkBandwidth;
            query["ReleaseAfterExpiration"] = request.ReleaseAfterExpiration;
            query["SecurityToken"] = request.SecurityToken;
            query["StorageBundleId"] = request.StorageBundleId;
            query["Type"] = request.Type;
            query["VSwitchId"] = request.VSwitchId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGateway",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
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

        public CreateGatewayBlockVolumeResponse CreateGatewayBlockVolumeWithOptions(CreateGatewayBlockVolumeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CacheMode"] = request.CacheMode;
            query["ChapEnabled"] = request.ChapEnabled;
            query["ChapInPassword"] = request.ChapInPassword;
            query["ChapInUser"] = request.ChapInUser;
            query["ChunkSize"] = request.ChunkSize;
            query["GatewayId"] = request.GatewayId;
            query["LocalFilePath"] = request.LocalFilePath;
            query["Name"] = request.Name;
            query["OssBucketName"] = request.OssBucketName;
            query["OssBucketSsl"] = request.OssBucketSsl;
            query["OssEndpoint"] = request.OssEndpoint;
            query["Recovery"] = request.Recovery;
            query["SecurityToken"] = request.SecurityToken;
            query["Size"] = request.Size;
            query["VolumeProtocol"] = request.VolumeProtocol;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGatewayBlockVolume",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayBlockVolumeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateGatewayBlockVolumeResponse> CreateGatewayBlockVolumeWithOptionsAsync(CreateGatewayBlockVolumeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CacheMode"] = request.CacheMode;
            query["ChapEnabled"] = request.ChapEnabled;
            query["ChapInPassword"] = request.ChapInPassword;
            query["ChapInUser"] = request.ChapInUser;
            query["ChunkSize"] = request.ChunkSize;
            query["GatewayId"] = request.GatewayId;
            query["LocalFilePath"] = request.LocalFilePath;
            query["Name"] = request.Name;
            query["OssBucketName"] = request.OssBucketName;
            query["OssBucketSsl"] = request.OssBucketSsl;
            query["OssEndpoint"] = request.OssEndpoint;
            query["Recovery"] = request.Recovery;
            query["SecurityToken"] = request.SecurityToken;
            query["Size"] = request.Size;
            query["VolumeProtocol"] = request.VolumeProtocol;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGatewayBlockVolume",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayBlockVolumeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateGatewayBlockVolumeResponse CreateGatewayBlockVolume(CreateGatewayBlockVolumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGatewayBlockVolumeWithOptions(request, runtime);
        }

        public async Task<CreateGatewayBlockVolumeResponse> CreateGatewayBlockVolumeAsync(CreateGatewayBlockVolumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGatewayBlockVolumeWithOptionsAsync(request, runtime);
        }

        public CreateGatewayCacheDiskResponse CreateGatewayCacheDiskWithOptions(CreateGatewayCacheDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CacheDiskCategory"] = request.CacheDiskCategory;
            query["CacheDiskSizeInGB"] = request.CacheDiskSizeInGB;
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGatewayCacheDisk",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayCacheDiskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateGatewayCacheDiskResponse> CreateGatewayCacheDiskWithOptionsAsync(CreateGatewayCacheDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CacheDiskCategory"] = request.CacheDiskCategory;
            query["CacheDiskSizeInGB"] = request.CacheDiskSizeInGB;
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGatewayCacheDisk",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayCacheDiskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateGatewayCacheDiskResponse CreateGatewayCacheDisk(CreateGatewayCacheDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGatewayCacheDiskWithOptions(request, runtime);
        }

        public async Task<CreateGatewayCacheDiskResponse> CreateGatewayCacheDiskAsync(CreateGatewayCacheDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGatewayCacheDiskWithOptionsAsync(request, runtime);
        }

        public CreateGatewayFileShareResponse CreateGatewayFileShareWithOptions(CreateGatewayFileShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccessBasedEnumeration"] = request.AccessBasedEnumeration;
            query["BackendLimit"] = request.BackendLimit;
            query["Browsable"] = request.Browsable;
            query["BypassCacheRead"] = request.BypassCacheRead;
            query["CacheMode"] = request.CacheMode;
            query["ClientSideCmk"] = request.ClientSideCmk;
            query["ClientSideEncryption"] = request.ClientSideEncryption;
            query["DirectIO"] = request.DirectIO;
            query["DownloadLimit"] = request.DownloadLimit;
            query["FastReclaim"] = request.FastReclaim;
            query["FrontendLimit"] = request.FrontendLimit;
            query["GatewayId"] = request.GatewayId;
            query["IgnoreDelete"] = request.IgnoreDelete;
            query["InPlace"] = request.InPlace;
            query["KmsRotatePeriod"] = request.KmsRotatePeriod;
            query["LagPeriod"] = request.LagPeriod;
            query["LocalFilePath"] = request.LocalFilePath;
            query["Name"] = request.Name;
            query["NfsV4Optimization"] = request.NfsV4Optimization;
            query["OssBucketName"] = request.OssBucketName;
            query["OssBucketSsl"] = request.OssBucketSsl;
            query["OssEndpoint"] = request.OssEndpoint;
            query["PartialSyncPaths"] = request.PartialSyncPaths;
            query["PathPrefix"] = request.PathPrefix;
            query["PollingInterval"] = request.PollingInterval;
            query["ReadOnlyClientList"] = request.ReadOnlyClientList;
            query["ReadOnlyUserList"] = request.ReadOnlyUserList;
            query["ReadWriteClientList"] = request.ReadWriteClientList;
            query["ReadWriteUserList"] = request.ReadWriteUserList;
            query["RemoteSync"] = request.RemoteSync;
            query["RemoteSyncDownload"] = request.RemoteSyncDownload;
            query["SecurityToken"] = request.SecurityToken;
            query["ServerSideAlgorithm"] = request.ServerSideAlgorithm;
            query["ServerSideCmk"] = request.ServerSideCmk;
            query["ServerSideEncryption"] = request.ServerSideEncryption;
            query["ShareProtocol"] = request.ShareProtocol;
            query["Squash"] = request.Squash;
            query["SupportArchive"] = request.SupportArchive;
            query["TransferAcceleration"] = request.TransferAcceleration;
            query["WindowsAcl"] = request.WindowsAcl;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGatewayFileShare",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayFileShareResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateGatewayFileShareResponse> CreateGatewayFileShareWithOptionsAsync(CreateGatewayFileShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccessBasedEnumeration"] = request.AccessBasedEnumeration;
            query["BackendLimit"] = request.BackendLimit;
            query["Browsable"] = request.Browsable;
            query["BypassCacheRead"] = request.BypassCacheRead;
            query["CacheMode"] = request.CacheMode;
            query["ClientSideCmk"] = request.ClientSideCmk;
            query["ClientSideEncryption"] = request.ClientSideEncryption;
            query["DirectIO"] = request.DirectIO;
            query["DownloadLimit"] = request.DownloadLimit;
            query["FastReclaim"] = request.FastReclaim;
            query["FrontendLimit"] = request.FrontendLimit;
            query["GatewayId"] = request.GatewayId;
            query["IgnoreDelete"] = request.IgnoreDelete;
            query["InPlace"] = request.InPlace;
            query["KmsRotatePeriod"] = request.KmsRotatePeriod;
            query["LagPeriod"] = request.LagPeriod;
            query["LocalFilePath"] = request.LocalFilePath;
            query["Name"] = request.Name;
            query["NfsV4Optimization"] = request.NfsV4Optimization;
            query["OssBucketName"] = request.OssBucketName;
            query["OssBucketSsl"] = request.OssBucketSsl;
            query["OssEndpoint"] = request.OssEndpoint;
            query["PartialSyncPaths"] = request.PartialSyncPaths;
            query["PathPrefix"] = request.PathPrefix;
            query["PollingInterval"] = request.PollingInterval;
            query["ReadOnlyClientList"] = request.ReadOnlyClientList;
            query["ReadOnlyUserList"] = request.ReadOnlyUserList;
            query["ReadWriteClientList"] = request.ReadWriteClientList;
            query["ReadWriteUserList"] = request.ReadWriteUserList;
            query["RemoteSync"] = request.RemoteSync;
            query["RemoteSyncDownload"] = request.RemoteSyncDownload;
            query["SecurityToken"] = request.SecurityToken;
            query["ServerSideAlgorithm"] = request.ServerSideAlgorithm;
            query["ServerSideCmk"] = request.ServerSideCmk;
            query["ServerSideEncryption"] = request.ServerSideEncryption;
            query["ShareProtocol"] = request.ShareProtocol;
            query["Squash"] = request.Squash;
            query["SupportArchive"] = request.SupportArchive;
            query["TransferAcceleration"] = request.TransferAcceleration;
            query["WindowsAcl"] = request.WindowsAcl;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGatewayFileShare",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayFileShareResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateGatewayFileShareResponse CreateGatewayFileShare(CreateGatewayFileShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGatewayFileShareWithOptions(request, runtime);
        }

        public async Task<CreateGatewayFileShareResponse> CreateGatewayFileShareAsync(CreateGatewayFileShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGatewayFileShareWithOptionsAsync(request, runtime);
        }

        public CreateGatewayLoggingResponse CreateGatewayLoggingWithOptions(CreateGatewayLoggingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["SlsLogstore"] = request.SlsLogstore;
            query["SlsProject"] = request.SlsProject;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGatewayLogging",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayLoggingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateGatewayLoggingResponse> CreateGatewayLoggingWithOptionsAsync(CreateGatewayLoggingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["SlsLogstore"] = request.SlsLogstore;
            query["SlsProject"] = request.SlsProject;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGatewayLogging",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayLoggingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateGatewayLoggingResponse CreateGatewayLogging(CreateGatewayLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGatewayLoggingWithOptions(request, runtime);
        }

        public async Task<CreateGatewayLoggingResponse> CreateGatewayLoggingAsync(CreateGatewayLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGatewayLoggingWithOptionsAsync(request, runtime);
        }

        public CreateGatewaySMBUserResponse CreateGatewaySMBUserWithOptions(CreateGatewaySMBUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["Password"] = request.Password;
            query["SecurityToken"] = request.SecurityToken;
            query["Username"] = request.Username;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGatewaySMBUser",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewaySMBUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateGatewaySMBUserResponse> CreateGatewaySMBUserWithOptionsAsync(CreateGatewaySMBUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["Password"] = request.Password;
            query["SecurityToken"] = request.SecurityToken;
            query["Username"] = request.Username;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGatewaySMBUser",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewaySMBUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateGatewaySMBUserResponse CreateGatewaySMBUser(CreateGatewaySMBUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGatewaySMBUserWithOptions(request, runtime);
        }

        public async Task<CreateGatewaySMBUserResponse> CreateGatewaySMBUserAsync(CreateGatewaySMBUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGatewaySMBUserWithOptionsAsync(request, runtime);
        }

        public CreateStorageBundleResponse CreateStorageBundleWithOptions(CreateStorageBundleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackendBucketRegionId"] = request.BackendBucketRegionId;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStorageBundle",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStorageBundleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateStorageBundleResponse> CreateStorageBundleWithOptionsAsync(CreateStorageBundleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackendBucketRegionId"] = request.BackendBucketRegionId;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStorageBundle",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStorageBundleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateStorageBundleResponse CreateStorageBundle(CreateStorageBundleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStorageBundleWithOptions(request, runtime);
        }

        public async Task<CreateStorageBundleResponse> CreateStorageBundleAsync(CreateStorageBundleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStorageBundleWithOptionsAsync(request, runtime);
        }

        public DeleteCSGClientsResponse DeleteCSGClientsWithOptions(DeleteCSGClientsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteCSGClientsShrinkRequest request = new DeleteCSGClientsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClientIds))
            {
                request.ClientIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClientIds, "ClientIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientIds"] = request.ClientIdsShrink;
            query["ClientRegionId"] = request.ClientRegionId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCSGClients",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCSGClientsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteCSGClientsResponse> DeleteCSGClientsWithOptionsAsync(DeleteCSGClientsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteCSGClientsShrinkRequest request = new DeleteCSGClientsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClientIds))
            {
                request.ClientIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClientIds, "ClientIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientIds"] = request.ClientIdsShrink;
            query["ClientRegionId"] = request.ClientRegionId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCSGClients",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCSGClientsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteCSGClientsResponse DeleteCSGClients(DeleteCSGClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCSGClientsWithOptions(request, runtime);
        }

        public async Task<DeleteCSGClientsResponse> DeleteCSGClientsAsync(DeleteCSGClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCSGClientsWithOptionsAsync(request, runtime);
        }

        public DeleteElasticGatewayPrivateZoneResponse DeleteElasticGatewayPrivateZoneWithOptions(DeleteElasticGatewayPrivateZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteElasticGatewayPrivateZone",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteElasticGatewayPrivateZoneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteElasticGatewayPrivateZoneResponse> DeleteElasticGatewayPrivateZoneWithOptionsAsync(DeleteElasticGatewayPrivateZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteElasticGatewayPrivateZone",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteElasticGatewayPrivateZoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteElasticGatewayPrivateZoneResponse DeleteElasticGatewayPrivateZone(DeleteElasticGatewayPrivateZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteElasticGatewayPrivateZoneWithOptions(request, runtime);
        }

        public async Task<DeleteElasticGatewayPrivateZoneResponse> DeleteElasticGatewayPrivateZoneAsync(DeleteElasticGatewayPrivateZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteElasticGatewayPrivateZoneWithOptionsAsync(request, runtime);
        }

        public DeleteExpressSyncResponse DeleteExpressSyncWithOptions(DeleteExpressSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ExpressSyncId"] = request.ExpressSyncId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExpressSync",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExpressSyncResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteExpressSyncResponse> DeleteExpressSyncWithOptionsAsync(DeleteExpressSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ExpressSyncId"] = request.ExpressSyncId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExpressSync",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExpressSyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteExpressSyncResponse DeleteExpressSync(DeleteExpressSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteExpressSyncWithOptions(request, runtime);
        }

        public async Task<DeleteExpressSyncResponse> DeleteExpressSyncAsync(DeleteExpressSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteExpressSyncWithOptionsAsync(request, runtime);
        }

        public DeleteGatewayResponse DeleteGatewayWithOptions(DeleteGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["ReasonDetail"] = request.ReasonDetail;
            query["ReasonType"] = request.ReasonType;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGateway",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteGatewayResponse> DeleteGatewayWithOptionsAsync(DeleteGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["ReasonDetail"] = request.ReasonDetail;
            query["ReasonType"] = request.ReasonType;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGateway",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
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

        public DeleteGatewayBlockVolumesResponse DeleteGatewayBlockVolumesWithOptions(DeleteGatewayBlockVolumesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["IndexId"] = request.IndexId;
            query["IsSourceDeletion"] = request.IsSourceDeletion;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewayBlockVolumes",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayBlockVolumesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteGatewayBlockVolumesResponse> DeleteGatewayBlockVolumesWithOptionsAsync(DeleteGatewayBlockVolumesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["IndexId"] = request.IndexId;
            query["IsSourceDeletion"] = request.IsSourceDeletion;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewayBlockVolumes",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayBlockVolumesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteGatewayBlockVolumesResponse DeleteGatewayBlockVolumes(DeleteGatewayBlockVolumesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGatewayBlockVolumesWithOptions(request, runtime);
        }

        public async Task<DeleteGatewayBlockVolumesResponse> DeleteGatewayBlockVolumesAsync(DeleteGatewayBlockVolumesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGatewayBlockVolumesWithOptionsAsync(request, runtime);
        }

        public DeleteGatewayCacheDiskResponse DeleteGatewayCacheDiskWithOptions(DeleteGatewayCacheDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CacheId"] = request.CacheId;
            query["GatewayId"] = request.GatewayId;
            query["LocalFilePath"] = request.LocalFilePath;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewayCacheDisk",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayCacheDiskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteGatewayCacheDiskResponse> DeleteGatewayCacheDiskWithOptionsAsync(DeleteGatewayCacheDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CacheId"] = request.CacheId;
            query["GatewayId"] = request.GatewayId;
            query["LocalFilePath"] = request.LocalFilePath;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewayCacheDisk",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayCacheDiskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteGatewayCacheDiskResponse DeleteGatewayCacheDisk(DeleteGatewayCacheDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGatewayCacheDiskWithOptions(request, runtime);
        }

        public async Task<DeleteGatewayCacheDiskResponse> DeleteGatewayCacheDiskAsync(DeleteGatewayCacheDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGatewayCacheDiskWithOptionsAsync(request, runtime);
        }

        public DeleteGatewayFileSharesResponse DeleteGatewayFileSharesWithOptions(DeleteGatewayFileSharesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Force"] = request.Force;
            query["GatewayId"] = request.GatewayId;
            query["IndexId"] = request.IndexId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewayFileShares",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayFileSharesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteGatewayFileSharesResponse> DeleteGatewayFileSharesWithOptionsAsync(DeleteGatewayFileSharesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Force"] = request.Force;
            query["GatewayId"] = request.GatewayId;
            query["IndexId"] = request.IndexId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewayFileShares",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayFileSharesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteGatewayFileSharesResponse DeleteGatewayFileShares(DeleteGatewayFileSharesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGatewayFileSharesWithOptions(request, runtime);
        }

        public async Task<DeleteGatewayFileSharesResponse> DeleteGatewayFileSharesAsync(DeleteGatewayFileSharesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGatewayFileSharesWithOptionsAsync(request, runtime);
        }

        public DeleteGatewayLoggingResponse DeleteGatewayLoggingWithOptions(DeleteGatewayLoggingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewayLogging",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayLoggingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteGatewayLoggingResponse> DeleteGatewayLoggingWithOptionsAsync(DeleteGatewayLoggingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewayLogging",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayLoggingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteGatewayLoggingResponse DeleteGatewayLogging(DeleteGatewayLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGatewayLoggingWithOptions(request, runtime);
        }

        public async Task<DeleteGatewayLoggingResponse> DeleteGatewayLoggingAsync(DeleteGatewayLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGatewayLoggingWithOptionsAsync(request, runtime);
        }

        public DeleteGatewaySMBUserResponse DeleteGatewaySMBUserWithOptions(DeleteGatewaySMBUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["Username"] = request.Username;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewaySMBUser",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewaySMBUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteGatewaySMBUserResponse> DeleteGatewaySMBUserWithOptionsAsync(DeleteGatewaySMBUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["Username"] = request.Username;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewaySMBUser",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewaySMBUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteGatewaySMBUserResponse DeleteGatewaySMBUser(DeleteGatewaySMBUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGatewaySMBUserWithOptions(request, runtime);
        }

        public async Task<DeleteGatewaySMBUserResponse> DeleteGatewaySMBUserAsync(DeleteGatewaySMBUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGatewaySMBUserWithOptionsAsync(request, runtime);
        }

        public DeleteStorageBundleResponse DeleteStorageBundleWithOptions(DeleteStorageBundleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            query["StorageBundleId"] = request.StorageBundleId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStorageBundle",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStorageBundleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteStorageBundleResponse> DeleteStorageBundleWithOptionsAsync(DeleteStorageBundleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            query["StorageBundleId"] = request.StorageBundleId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStorageBundle",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStorageBundleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteStorageBundleResponse DeleteStorageBundle(DeleteStorageBundleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteStorageBundleWithOptions(request, runtime);
        }

        public async Task<DeleteStorageBundleResponse> DeleteStorageBundleAsync(DeleteStorageBundleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteStorageBundleWithOptionsAsync(request, runtime);
        }

        public DeployCSGClientsResponse DeployCSGClientsWithOptions(DeployCSGClientsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeployCSGClientsShrinkRequest request = new DeployCSGClientsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcsInstanceIds))
            {
                request.EcsInstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcsInstanceIds, "EcsInstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientRegionId"] = request.ClientRegionId;
            query["EcsInstanceIds"] = request.EcsInstanceIdsShrink;
            query["SecurityToken"] = request.SecurityToken;
            query["VpcId"] = request.VpcId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployCSGClients",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployCSGClientsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeployCSGClientsResponse> DeployCSGClientsWithOptionsAsync(DeployCSGClientsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeployCSGClientsShrinkRequest request = new DeployCSGClientsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcsInstanceIds))
            {
                request.EcsInstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcsInstanceIds, "EcsInstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientRegionId"] = request.ClientRegionId;
            query["EcsInstanceIds"] = request.EcsInstanceIdsShrink;
            query["SecurityToken"] = request.SecurityToken;
            query["VpcId"] = request.VpcId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployCSGClients",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployCSGClientsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeployCSGClientsResponse DeployCSGClients(DeployCSGClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeployCSGClientsWithOptions(request, runtime);
        }

        public async Task<DeployCSGClientsResponse> DeployCSGClientsAsync(DeployCSGClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeployCSGClientsWithOptionsAsync(request, runtime);
        }

        public DeployCacheDiskResponse DeployCacheDiskWithOptions(DeployCacheDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CacheConfig"] = request.CacheConfig;
            query["DiskCategory"] = request.DiskCategory;
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["SizeInGB"] = request.SizeInGB;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployCacheDisk",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployCacheDiskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeployCacheDiskResponse> DeployCacheDiskWithOptionsAsync(DeployCacheDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CacheConfig"] = request.CacheConfig;
            query["DiskCategory"] = request.DiskCategory;
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["SizeInGB"] = request.SizeInGB;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployCacheDisk",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployCacheDiskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeployCacheDiskResponse DeployCacheDisk(DeployCacheDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeployCacheDiskWithOptions(request, runtime);
        }

        public async Task<DeployCacheDiskResponse> DeployCacheDiskAsync(DeployCacheDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeployCacheDiskWithOptionsAsync(request, runtime);
        }

        public DeployGatewayResponse DeployGatewayWithOptions(DeployGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayClass"] = request.GatewayClass;
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployGateway",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployGatewayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeployGatewayResponse> DeployGatewayWithOptionsAsync(DeployGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayClass"] = request.GatewayClass;
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployGateway",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeployGatewayResponse DeployGateway(DeployGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeployGatewayWithOptions(request, runtime);
        }

        public async Task<DeployGatewayResponse> DeployGatewayAsync(DeployGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeployGatewayWithOptionsAsync(request, runtime);
        }

        public DescribeAccountConfigResponse DescribeAccountConfigWithOptions(DescribeAccountConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccountConfig",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccountConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAccountConfigResponse> DescribeAccountConfigWithOptionsAsync(DescribeAccountConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccountConfig",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccountConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAccountConfigResponse DescribeAccountConfig(DescribeAccountConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccountConfigWithOptions(request, runtime);
        }

        public async Task<DescribeAccountConfigResponse> DescribeAccountConfigAsync(DescribeAccountConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccountConfigWithOptionsAsync(request, runtime);
        }

        public DescribeBlockVolumeSnapshotsResponse DescribeBlockVolumeSnapshotsWithOptions(DescribeBlockVolumeSnapshotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["IndexId"] = request.IndexId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBlockVolumeSnapshots",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBlockVolumeSnapshotsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeBlockVolumeSnapshotsResponse> DescribeBlockVolumeSnapshotsWithOptionsAsync(DescribeBlockVolumeSnapshotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["IndexId"] = request.IndexId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBlockVolumeSnapshots",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBlockVolumeSnapshotsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeBlockVolumeSnapshotsResponse DescribeBlockVolumeSnapshots(DescribeBlockVolumeSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBlockVolumeSnapshotsWithOptions(request, runtime);
        }

        public async Task<DescribeBlockVolumeSnapshotsResponse> DescribeBlockVolumeSnapshotsAsync(DescribeBlockVolumeSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBlockVolumeSnapshotsWithOptionsAsync(request, runtime);
        }

        public DescribeCSGClientTasksResponse DescribeCSGClientTasksWithOptions(DescribeCSGClientTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientId"] = request.ClientId;
            query["ClientRegionId"] = request.ClientRegionId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCSGClientTasks",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCSGClientTasksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCSGClientTasksResponse> DescribeCSGClientTasksWithOptionsAsync(DescribeCSGClientTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientId"] = request.ClientId;
            query["ClientRegionId"] = request.ClientRegionId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCSGClientTasks",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCSGClientTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCSGClientTasksResponse DescribeCSGClientTasks(DescribeCSGClientTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCSGClientTasksWithOptions(request, runtime);
        }

        public async Task<DescribeCSGClientTasksResponse> DescribeCSGClientTasksAsync(DescribeCSGClientTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCSGClientTasksWithOptionsAsync(request, runtime);
        }

        public DescribeCSGClientsResponse DescribeCSGClientsWithOptions(DescribeCSGClientsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientRegionId"] = request.ClientRegionId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCSGClients",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCSGClientsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCSGClientsResponse> DescribeCSGClientsWithOptionsAsync(DescribeCSGClientsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientRegionId"] = request.ClientRegionId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCSGClients",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCSGClientsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCSGClientsResponse DescribeCSGClients(DescribeCSGClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCSGClientsWithOptions(request, runtime);
        }

        public async Task<DescribeCSGClientsResponse> DescribeCSGClientsAsync(DescribeCSGClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCSGClientsWithOptionsAsync(request, runtime);
        }

        public DescribeDashboardResponse DescribeDashboardWithOptions(DescribeDashboardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackendBucketRegionId"] = request.BackendBucketRegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDashboard",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDashboardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDashboardResponse> DescribeDashboardWithOptionsAsync(DescribeDashboardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackendBucketRegionId"] = request.BackendBucketRegionId;
            query["ResourceGroupId"] = request.ResourceGroupId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDashboard",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDashboardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDashboardResponse DescribeDashboard(DescribeDashboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDashboardWithOptions(request, runtime);
        }

        public async Task<DescribeDashboardResponse> DescribeDashboardAsync(DescribeDashboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDashboardWithOptionsAsync(request, runtime);
        }

        public DescribeExpireCachesResponse DescribeExpireCachesWithOptions(DescribeExpireCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExpireCaches",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExpireCachesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeExpireCachesResponse> DescribeExpireCachesWithOptionsAsync(DescribeExpireCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExpireCaches",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExpireCachesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeExpireCachesResponse DescribeExpireCaches(DescribeExpireCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExpireCachesWithOptions(request, runtime);
        }

        public async Task<DescribeExpireCachesResponse> DescribeExpireCachesAsync(DescribeExpireCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExpireCachesWithOptionsAsync(request, runtime);
        }

        public DescribeExpressSyncSharesResponse DescribeExpressSyncSharesWithOptions(DescribeExpressSyncSharesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ExpressSyncIds"] = request.ExpressSyncIds;
            query["IsExternal"] = request.IsExternal;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExpressSyncShares",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExpressSyncSharesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeExpressSyncSharesResponse> DescribeExpressSyncSharesWithOptionsAsync(DescribeExpressSyncSharesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ExpressSyncIds"] = request.ExpressSyncIds;
            query["IsExternal"] = request.IsExternal;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExpressSyncShares",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExpressSyncSharesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeExpressSyncSharesResponse DescribeExpressSyncShares(DescribeExpressSyncSharesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExpressSyncSharesWithOptions(request, runtime);
        }

        public async Task<DescribeExpressSyncSharesResponse> DescribeExpressSyncSharesAsync(DescribeExpressSyncSharesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExpressSyncSharesWithOptionsAsync(request, runtime);
        }

        public DescribeExpressSyncsResponse DescribeExpressSyncsWithOptions(DescribeExpressSyncsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BucketName"] = request.BucketName;
            query["BucketPrefix"] = request.BucketPrefix;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExpressSyncs",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExpressSyncsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeExpressSyncsResponse> DescribeExpressSyncsWithOptionsAsync(DescribeExpressSyncsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BucketName"] = request.BucketName;
            query["BucketPrefix"] = request.BucketPrefix;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExpressSyncs",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExpressSyncsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeExpressSyncsResponse DescribeExpressSyncs(DescribeExpressSyncsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExpressSyncsWithOptions(request, runtime);
        }

        public async Task<DescribeExpressSyncsResponse> DescribeExpressSyncsAsync(DescribeExpressSyncsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExpressSyncsWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayResponse DescribeGatewayWithOptions(DescribeGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGateway",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayResponse> DescribeGatewayWithOptionsAsync(DescribeGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGateway",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayResponse DescribeGateway(DescribeGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayResponse> DescribeGatewayAsync(DescribeGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayADInfoResponse DescribeGatewayADInfoWithOptions(DescribeGatewayADInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayADInfo",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayADInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayADInfoResponse> DescribeGatewayADInfoWithOptionsAsync(DescribeGatewayADInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayADInfo",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayADInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayADInfoResponse DescribeGatewayADInfo(DescribeGatewayADInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayADInfoWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayADInfoResponse> DescribeGatewayADInfoAsync(DescribeGatewayADInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayADInfoWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayActionsResponse DescribeGatewayActionsWithOptions(DescribeGatewayActionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayActions",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayActionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayActionsResponse> DescribeGatewayActionsWithOptionsAsync(DescribeGatewayActionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayActions",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayActionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayActionsResponse DescribeGatewayActions(DescribeGatewayActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayActionsWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayActionsResponse> DescribeGatewayActionsAsync(DescribeGatewayActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayActionsWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayAuthInfoResponse DescribeGatewayAuthInfoWithOptions(DescribeGatewayAuthInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayAuthInfo",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayAuthInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayAuthInfoResponse> DescribeGatewayAuthInfoWithOptionsAsync(DescribeGatewayAuthInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayAuthInfo",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayAuthInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayAuthInfoResponse DescribeGatewayAuthInfo(DescribeGatewayAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayAuthInfoWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayAuthInfoResponse> DescribeGatewayAuthInfoAsync(DescribeGatewayAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayAuthInfoWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayBlockVolumesResponse DescribeGatewayBlockVolumesWithOptions(DescribeGatewayBlockVolumesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["IndexId"] = request.IndexId;
            query["Refresh"] = request.Refresh;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayBlockVolumes",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayBlockVolumesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayBlockVolumesResponse> DescribeGatewayBlockVolumesWithOptionsAsync(DescribeGatewayBlockVolumesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["IndexId"] = request.IndexId;
            query["Refresh"] = request.Refresh;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayBlockVolumes",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayBlockVolumesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayBlockVolumesResponse DescribeGatewayBlockVolumes(DescribeGatewayBlockVolumesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayBlockVolumesWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayBlockVolumesResponse> DescribeGatewayBlockVolumesAsync(DescribeGatewayBlockVolumesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayBlockVolumesWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayBucketCachesResponse DescribeGatewayBucketCachesWithOptions(DescribeGatewayBucketCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BucketName"] = request.BucketName;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayBucketCaches",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayBucketCachesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayBucketCachesResponse> DescribeGatewayBucketCachesWithOptionsAsync(DescribeGatewayBucketCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BucketName"] = request.BucketName;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayBucketCaches",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayBucketCachesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayBucketCachesResponse DescribeGatewayBucketCaches(DescribeGatewayBucketCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayBucketCachesWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayBucketCachesResponse> DescribeGatewayBucketCachesAsync(DescribeGatewayBucketCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayBucketCachesWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayCachesResponse DescribeGatewayCachesWithOptions(DescribeGatewayCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayCaches",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayCachesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayCachesResponse> DescribeGatewayCachesWithOptionsAsync(DescribeGatewayCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayCaches",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayCachesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayCachesResponse DescribeGatewayCaches(DescribeGatewayCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayCachesWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayCachesResponse> DescribeGatewayCachesAsync(DescribeGatewayCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayCachesWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayCapacityLimitResponse DescribeGatewayCapacityLimitWithOptions(DescribeGatewayCapacityLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["SizeInGB"] = request.SizeInGB;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayCapacityLimit",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayCapacityLimitResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayCapacityLimitResponse> DescribeGatewayCapacityLimitWithOptionsAsync(DescribeGatewayCapacityLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["SizeInGB"] = request.SizeInGB;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayCapacityLimit",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayCapacityLimitResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayCapacityLimitResponse DescribeGatewayCapacityLimit(DescribeGatewayCapacityLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayCapacityLimitWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayCapacityLimitResponse> DescribeGatewayCapacityLimitAsync(DescribeGatewayCapacityLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayCapacityLimitWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayCategoriesResponse DescribeGatewayCategoriesWithOptions(DescribeGatewayCategoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayLocation"] = request.GatewayLocation;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayCategories",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayCategoriesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayCategoriesResponse> DescribeGatewayCategoriesWithOptionsAsync(DescribeGatewayCategoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayLocation"] = request.GatewayLocation;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayCategories",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayCategoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayCategoriesResponse DescribeGatewayCategories(DescribeGatewayCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayCategoriesWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayCategoriesResponse> DescribeGatewayCategoriesAsync(DescribeGatewayCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayCategoriesWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayClassesResponse DescribeGatewayClassesWithOptions(DescribeGatewayClassesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayClasses",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayClassesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayClassesResponse> DescribeGatewayClassesWithOptionsAsync(DescribeGatewayClassesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayClasses",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayClassesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayClassesResponse DescribeGatewayClasses(DescribeGatewayClassesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayClassesWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayClassesResponse> DescribeGatewayClassesAsync(DescribeGatewayClassesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayClassesWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayCredentialResponse DescribeGatewayCredentialWithOptions(DescribeGatewayCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayCredential",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayCredentialResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayCredentialResponse> DescribeGatewayCredentialWithOptionsAsync(DescribeGatewayCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayCredential",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayCredentialResponse DescribeGatewayCredential(DescribeGatewayCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayCredentialWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayCredentialResponse> DescribeGatewayCredentialAsync(DescribeGatewayCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayCredentialWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayDNSResponse DescribeGatewayDNSWithOptions(DescribeGatewayDNSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayDNS",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayDNSResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayDNSResponse> DescribeGatewayDNSWithOptionsAsync(DescribeGatewayDNSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayDNS",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayDNSResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayDNSResponse DescribeGatewayDNS(DescribeGatewayDNSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayDNSWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayDNSResponse> DescribeGatewayDNSAsync(DescribeGatewayDNSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayDNSWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayFileSharesResponse DescribeGatewayFileSharesWithOptions(DescribeGatewayFileSharesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["IndexId"] = request.IndexId;
            query["Refresh"] = request.Refresh;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayFileShares",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayFileSharesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayFileSharesResponse> DescribeGatewayFileSharesWithOptionsAsync(DescribeGatewayFileSharesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["IndexId"] = request.IndexId;
            query["Refresh"] = request.Refresh;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayFileShares",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayFileSharesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayFileSharesResponse DescribeGatewayFileShares(DescribeGatewayFileSharesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayFileSharesWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayFileSharesResponse> DescribeGatewayFileSharesAsync(DescribeGatewayFileSharesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayFileSharesWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayFileStatusResponse DescribeGatewayFileStatusWithOptions(DescribeGatewayFileStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["FilePath"] = request.FilePath;
            query["GatewayId"] = request.GatewayId;
            query["IndexId"] = request.IndexId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayFileStatus",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayFileStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayFileStatusResponse> DescribeGatewayFileStatusWithOptionsAsync(DescribeGatewayFileStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["FilePath"] = request.FilePath;
            query["GatewayId"] = request.GatewayId;
            query["IndexId"] = request.IndexId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayFileStatus",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayFileStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayFileStatusResponse DescribeGatewayFileStatus(DescribeGatewayFileStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayFileStatusWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayFileStatusResponse> DescribeGatewayFileStatusAsync(DescribeGatewayFileStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayFileStatusWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayImagesResponse DescribeGatewayImagesWithOptions(DescribeGatewayImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayImages",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayImagesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayImagesResponse> DescribeGatewayImagesWithOptionsAsync(DescribeGatewayImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayImages",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayImagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayImagesResponse DescribeGatewayImages(DescribeGatewayImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayImagesWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayImagesResponse> DescribeGatewayImagesAsync(DescribeGatewayImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayImagesWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayInfoResponse DescribeGatewayInfoWithOptions(DescribeGatewayInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayInfo",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayInfoResponse> DescribeGatewayInfoWithOptionsAsync(DescribeGatewayInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayInfo",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayInfoResponse DescribeGatewayInfo(DescribeGatewayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayInfoWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayInfoResponse> DescribeGatewayInfoAsync(DescribeGatewayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayInfoWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayLDAPInfoResponse DescribeGatewayLDAPInfoWithOptions(DescribeGatewayLDAPInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayLDAPInfo",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayLDAPInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayLDAPInfoResponse> DescribeGatewayLDAPInfoWithOptionsAsync(DescribeGatewayLDAPInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayLDAPInfo",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayLDAPInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayLDAPInfoResponse DescribeGatewayLDAPInfo(DescribeGatewayLDAPInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayLDAPInfoWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayLDAPInfoResponse> DescribeGatewayLDAPInfoAsync(DescribeGatewayLDAPInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayLDAPInfoWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayLocationsResponse DescribeGatewayLocationsWithOptions(DescribeGatewayLocationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayLocations",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayLocationsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayLocationsResponse> DescribeGatewayLocationsWithOptionsAsync(DescribeGatewayLocationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayLocations",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayLocationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayLocationsResponse DescribeGatewayLocations(DescribeGatewayLocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayLocationsWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayLocationsResponse> DescribeGatewayLocationsAsync(DescribeGatewayLocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayLocationsWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayLoggingResponse DescribeGatewayLoggingWithOptions(DescribeGatewayLoggingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayLogging",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayLoggingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayLoggingResponse> DescribeGatewayLoggingWithOptionsAsync(DescribeGatewayLoggingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayLogging",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayLoggingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayLoggingResponse DescribeGatewayLogging(DescribeGatewayLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayLoggingWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayLoggingResponse> DescribeGatewayLoggingAsync(DescribeGatewayLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayLoggingWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayLogsResponse DescribeGatewayLogsWithOptions(DescribeGatewayLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["LogFilePath"] = request.LogFilePath;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayLogs",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayLogsResponse> DescribeGatewayLogsWithOptionsAsync(DescribeGatewayLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["LogFilePath"] = request.LogFilePath;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayLogs",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayLogsResponse DescribeGatewayLogs(DescribeGatewayLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayLogsWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayLogsResponse> DescribeGatewayLogsAsync(DescribeGatewayLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayLogsWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayModificationClassesResponse DescribeGatewayModificationClassesWithOptions(DescribeGatewayModificationClassesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayModificationClasses",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayModificationClassesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayModificationClassesResponse> DescribeGatewayModificationClassesWithOptionsAsync(DescribeGatewayModificationClassesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayModificationClasses",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayModificationClassesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayModificationClassesResponse DescribeGatewayModificationClasses(DescribeGatewayModificationClassesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayModificationClassesWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayModificationClassesResponse> DescribeGatewayModificationClassesAsync(DescribeGatewayModificationClassesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayModificationClassesWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayNFSClientsResponse DescribeGatewayNFSClientsWithOptions(DescribeGatewayNFSClientsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayNFSClients",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayNFSClientsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayNFSClientsResponse> DescribeGatewayNFSClientsWithOptionsAsync(DescribeGatewayNFSClientsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayNFSClients",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayNFSClientsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayNFSClientsResponse DescribeGatewayNFSClients(DescribeGatewayNFSClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayNFSClientsWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayNFSClientsResponse> DescribeGatewayNFSClientsAsync(DescribeGatewayNFSClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayNFSClientsWithOptionsAsync(request, runtime);
        }

        public DescribeGatewaySMBUsersResponse DescribeGatewaySMBUsersWithOptions(DescribeGatewaySMBUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewaySMBUsers",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewaySMBUsersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewaySMBUsersResponse> DescribeGatewaySMBUsersWithOptionsAsync(DescribeGatewaySMBUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewaySMBUsers",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewaySMBUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewaySMBUsersResponse DescribeGatewaySMBUsers(DescribeGatewaySMBUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewaySMBUsersWithOptions(request, runtime);
        }

        public async Task<DescribeGatewaySMBUsersResponse> DescribeGatewaySMBUsersAsync(DescribeGatewaySMBUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewaySMBUsersWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayStatisticsResponse DescribeGatewayStatisticsWithOptions(DescribeGatewayStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTimestamp"] = request.EndTimestamp;
            query["GatewayCategory"] = request.GatewayCategory;
            query["GatewayLocation"] = request.GatewayLocation;
            query["SecurityToken"] = request.SecurityToken;
            query["StartTimestamp"] = request.StartTimestamp;
            query["TargetAccountId"] = request.TargetAccountId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayStatistics",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayStatisticsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayStatisticsResponse> DescribeGatewayStatisticsWithOptionsAsync(DescribeGatewayStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTimestamp"] = request.EndTimestamp;
            query["GatewayCategory"] = request.GatewayCategory;
            query["GatewayLocation"] = request.GatewayLocation;
            query["SecurityToken"] = request.SecurityToken;
            query["StartTimestamp"] = request.StartTimestamp;
            query["TargetAccountId"] = request.TargetAccountId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayStatistics",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayStatisticsResponse DescribeGatewayStatistics(DescribeGatewayStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayStatisticsResponse> DescribeGatewayStatisticsAsync(DescribeGatewayStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayStatisticsWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayStockResponse DescribeGatewayStockWithOptions(DescribeGatewayStockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayRegionId"] = request.GatewayRegionId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayStock",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayStockResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayStockResponse> DescribeGatewayStockWithOptionsAsync(DescribeGatewayStockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayRegionId"] = request.GatewayRegionId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayStock",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayStockResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayStockResponse DescribeGatewayStock(DescribeGatewayStockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayStockWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayStockResponse> DescribeGatewayStockAsync(DescribeGatewayStockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayStockWithOptionsAsync(request, runtime);
        }

        public DescribeGatewayTypesResponse DescribeGatewayTypesWithOptions(DescribeGatewayTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayLocation"] = request.GatewayLocation;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayTypes",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayTypesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewayTypesResponse> DescribeGatewayTypesWithOptionsAsync(DescribeGatewayTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayLocation"] = request.GatewayLocation;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewayTypes",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayTypesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewayTypesResponse DescribeGatewayTypes(DescribeGatewayTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewayTypesWithOptions(request, runtime);
        }

        public async Task<DescribeGatewayTypesResponse> DescribeGatewayTypesAsync(DescribeGatewayTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewayTypesWithOptionsAsync(request, runtime);
        }

        public DescribeGatewaysResponse DescribeGatewaysWithOptions(DescribeGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            query["StorageBundleId"] = request.StorageBundleId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGateways",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewaysResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewaysResponse> DescribeGatewaysWithOptionsAsync(DescribeGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            query["StorageBundleId"] = request.StorageBundleId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGateways",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewaysResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewaysResponse DescribeGateways(DescribeGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewaysWithOptions(request, runtime);
        }

        public async Task<DescribeGatewaysResponse> DescribeGatewaysAsync(DescribeGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewaysWithOptionsAsync(request, runtime);
        }

        public DescribeGatewaysForCmsResponse DescribeGatewaysForCmsWithOptions(DescribeGatewaysForCmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayRegionId"] = request.GatewayRegionId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewaysForCms",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewaysForCmsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewaysForCmsResponse> DescribeGatewaysForCmsWithOptionsAsync(DescribeGatewaysForCmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayRegionId"] = request.GatewayRegionId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewaysForCms",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewaysForCmsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewaysForCmsResponse DescribeGatewaysForCms(DescribeGatewaysForCmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewaysForCmsWithOptions(request, runtime);
        }

        public async Task<DescribeGatewaysForCmsResponse> DescribeGatewaysForCmsAsync(DescribeGatewaysForCmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewaysForCmsWithOptionsAsync(request, runtime);
        }

        public DescribeGatewaysTagsResponse DescribeGatewaysTagsWithOptions(DescribeGatewaysTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayIds"] = request.GatewayIds;
            query["SecurityToken"] = request.SecurityToken;
            query["StorageBundleId"] = request.StorageBundleId;
            query["TagCategory"] = request.TagCategory;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewaysTags",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewaysTagsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewaysTagsResponse> DescribeGatewaysTagsWithOptionsAsync(DescribeGatewaysTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayIds"] = request.GatewayIds;
            query["SecurityToken"] = request.SecurityToken;
            query["StorageBundleId"] = request.StorageBundleId;
            query["TagCategory"] = request.TagCategory;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGatewaysTags",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewaysTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewaysTagsResponse DescribeGatewaysTags(DescribeGatewaysTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewaysTagsWithOptions(request, runtime);
        }

        public async Task<DescribeGatewaysTagsResponse> DescribeGatewaysTagsAsync(DescribeGatewaysTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewaysTagsWithOptionsAsync(request, runtime);
        }

        public DescribeKmsKeyResponse DescribeKmsKeyWithOptions(DescribeKmsKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["KmsKey"] = request.KmsKey;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeKmsKey",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeKmsKeyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeKmsKeyResponse> DescribeKmsKeyWithOptionsAsync(DescribeKmsKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["KmsKey"] = request.KmsKey;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeKmsKey",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeKmsKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeKmsKeyResponse DescribeKmsKey(DescribeKmsKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeKmsKeyWithOptions(request, runtime);
        }

        public async Task<DescribeKmsKeyResponse> DescribeKmsKeyAsync(DescribeKmsKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeKmsKeyWithOptionsAsync(request, runtime);
        }

        public DescribeMqttConfigResponse DescribeMqttConfigWithOptions(DescribeMqttConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMqttConfig",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMqttConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMqttConfigResponse> DescribeMqttConfigWithOptionsAsync(DescribeMqttConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMqttConfig",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMqttConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMqttConfigResponse DescribeMqttConfig(DescribeMqttConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMqttConfigWithOptions(request, runtime);
        }

        public async Task<DescribeMqttConfigResponse> DescribeMqttConfigAsync(DescribeMqttConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMqttConfigWithOptionsAsync(request, runtime);
        }

        public DescribeOssBucketInfoResponse DescribeOssBucketInfoWithOptions(DescribeOssBucketInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BucketEndpoint"] = request.BucketEndpoint;
            query["BucketName"] = request.BucketName;
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOssBucketInfo",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOssBucketInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeOssBucketInfoResponse> DescribeOssBucketInfoWithOptionsAsync(DescribeOssBucketInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BucketEndpoint"] = request.BucketEndpoint;
            query["BucketName"] = request.BucketName;
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOssBucketInfo",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOssBucketInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeOssBucketInfoResponse DescribeOssBucketInfo(DescribeOssBucketInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOssBucketInfoWithOptions(request, runtime);
        }

        public async Task<DescribeOssBucketInfoResponse> DescribeOssBucketInfoAsync(DescribeOssBucketInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOssBucketInfoWithOptionsAsync(request, runtime);
        }

        public DescribeOssBucketsResponse DescribeOssBucketsWithOptions(DescribeOssBucketsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BucketEndpoint"] = request.BucketEndpoint;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOssBuckets",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOssBucketsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeOssBucketsResponse> DescribeOssBucketsWithOptionsAsync(DescribeOssBucketsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BucketEndpoint"] = request.BucketEndpoint;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOssBuckets",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOssBucketsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeOssBucketsResponse DescribeOssBuckets(DescribeOssBucketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOssBucketsWithOptions(request, runtime);
        }

        public async Task<DescribeOssBucketsResponse> DescribeOssBucketsAsync(DescribeOssBucketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOssBucketsWithOptionsAsync(request, runtime);
        }

        public DescribePayAsYouGoPriceResponse DescribePayAsYouGoPriceWithOptions(DescribePayAsYouGoPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayClass"] = request.GatewayClass;
            query["RegionId"] = request.RegionId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePayAsYouGoPrice",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePayAsYouGoPriceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribePayAsYouGoPriceResponse> DescribePayAsYouGoPriceWithOptionsAsync(DescribePayAsYouGoPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayClass"] = request.GatewayClass;
            query["RegionId"] = request.RegionId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePayAsYouGoPrice",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePayAsYouGoPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribePayAsYouGoPriceResponse DescribePayAsYouGoPrice(DescribePayAsYouGoPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePayAsYouGoPriceWithOptions(request, runtime);
        }

        public async Task<DescribePayAsYouGoPriceResponse> DescribePayAsYouGoPriceAsync(DescribePayAsYouGoPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePayAsYouGoPriceWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2018-05-11",
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
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2018-05-11",
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

        public DescribeSharesBucketInfoForExpressSyncResponse DescribeSharesBucketInfoForExpressSyncWithOptions(DescribeSharesBucketInfoForExpressSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BucketName"] = request.BucketName;
            query["BucketRegion"] = request.BucketRegion;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSharesBucketInfoForExpressSync",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSharesBucketInfoForExpressSyncResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSharesBucketInfoForExpressSyncResponse> DescribeSharesBucketInfoForExpressSyncWithOptionsAsync(DescribeSharesBucketInfoForExpressSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BucketName"] = request.BucketName;
            query["BucketRegion"] = request.BucketRegion;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSharesBucketInfoForExpressSync",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSharesBucketInfoForExpressSyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSharesBucketInfoForExpressSyncResponse DescribeSharesBucketInfoForExpressSync(DescribeSharesBucketInfoForExpressSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSharesBucketInfoForExpressSyncWithOptions(request, runtime);
        }

        public async Task<DescribeSharesBucketInfoForExpressSyncResponse> DescribeSharesBucketInfoForExpressSyncAsync(DescribeSharesBucketInfoForExpressSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSharesBucketInfoForExpressSyncWithOptionsAsync(request, runtime);
        }

        public DescribeStorageBundleResponse DescribeStorageBundleWithOptions(DescribeStorageBundleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            query["StorageBundleId"] = request.StorageBundleId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStorageBundle",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStorageBundleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeStorageBundleResponse> DescribeStorageBundleWithOptionsAsync(DescribeStorageBundleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            query["StorageBundleId"] = request.StorageBundleId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStorageBundle",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStorageBundleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeStorageBundleResponse DescribeStorageBundle(DescribeStorageBundleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStorageBundleWithOptions(request, runtime);
        }

        public async Task<DescribeStorageBundleResponse> DescribeStorageBundleAsync(DescribeStorageBundleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStorageBundleWithOptionsAsync(request, runtime);
        }

        public DescribeStorageBundlesResponse DescribeStorageBundlesWithOptions(DescribeStorageBundlesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackendBucketRegionId"] = request.BackendBucketRegionId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStorageBundles",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStorageBundlesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeStorageBundlesResponse> DescribeStorageBundlesWithOptionsAsync(DescribeStorageBundlesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackendBucketRegionId"] = request.BackendBucketRegionId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStorageBundles",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStorageBundlesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeStorageBundlesResponse DescribeStorageBundles(DescribeStorageBundlesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStorageBundlesWithOptions(request, runtime);
        }

        public async Task<DescribeStorageBundlesResponse> DescribeStorageBundlesAsync(DescribeStorageBundlesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStorageBundlesWithOptionsAsync(request, runtime);
        }

        public DescribeSubscriptionPriceResponse DescribeSubscriptionPriceWithOptions(DescribeSubscriptionPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CacheCloudEfficiencySize"] = request.CacheCloudEfficiencySize;
            query["CacheSSDSize"] = request.CacheSSDSize;
            query["GatewayClass"] = request.GatewayClass;
            query["PeriodQuantity"] = request.PeriodQuantity;
            query["PeriodUnit"] = request.PeriodUnit;
            query["RegionId"] = request.RegionId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSubscriptionPrice",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSubscriptionPriceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSubscriptionPriceResponse> DescribeSubscriptionPriceWithOptionsAsync(DescribeSubscriptionPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CacheCloudEfficiencySize"] = request.CacheCloudEfficiencySize;
            query["CacheSSDSize"] = request.CacheSSDSize;
            query["GatewayClass"] = request.GatewayClass;
            query["PeriodQuantity"] = request.PeriodQuantity;
            query["PeriodUnit"] = request.PeriodUnit;
            query["RegionId"] = request.RegionId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSubscriptionPrice",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSubscriptionPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSubscriptionPriceResponse DescribeSubscriptionPrice(DescribeSubscriptionPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSubscriptionPriceWithOptions(request, runtime);
        }

        public async Task<DescribeSubscriptionPriceResponse> DescribeSubscriptionPriceAsync(DescribeSubscriptionPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSubscriptionPriceWithOptionsAsync(request, runtime);
        }

        public DescribeTasksResponse DescribeTasksWithOptions(DescribeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            query["TargetId"] = request.TargetId;
            query["TaskId"] = request.TaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTasks",
                Version = "2018-05-11",
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
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            query["TargetId"] = request.TargetId;
            query["TaskId"] = request.TaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTasks",
                Version = "2018-05-11",
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

        public DescribeUserBusinessStatusResponse DescribeUserBusinessStatusWithOptions(DescribeUserBusinessStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserBusinessStatus",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserBusinessStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeUserBusinessStatusResponse> DescribeUserBusinessStatusWithOptionsAsync(DescribeUserBusinessStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserBusinessStatus",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserBusinessStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeUserBusinessStatusResponse DescribeUserBusinessStatus(DescribeUserBusinessStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserBusinessStatusWithOptions(request, runtime);
        }

        public async Task<DescribeUserBusinessStatusResponse> DescribeUserBusinessStatusAsync(DescribeUserBusinessStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserBusinessStatusWithOptionsAsync(request, runtime);
        }

        public DescribeVSwitchesResponse DescribeVSwitchesWithOptions(DescribeVSwitchesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            query["StorageBundleId"] = request.StorageBundleId;
            query["VSwitchId"] = request.VSwitchId;
            query["VpcId"] = request.VpcId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVSwitches",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVSwitchesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeVSwitchesResponse> DescribeVSwitchesWithOptionsAsync(DescribeVSwitchesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            query["StorageBundleId"] = request.StorageBundleId;
            query["VSwitchId"] = request.VSwitchId;
            query["VpcId"] = request.VpcId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVSwitches",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVSwitchesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeVSwitchesResponse DescribeVSwitches(DescribeVSwitchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVSwitchesWithOptions(request, runtime);
        }

        public async Task<DescribeVSwitchesResponse> DescribeVSwitchesAsync(DescribeVSwitchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVSwitchesWithOptionsAsync(request, runtime);
        }

        public DescribeVpcsResponse DescribeVpcsWithOptions(DescribeVpcsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            query["StorageBundleId"] = request.StorageBundleId;
            query["VpcId"] = request.VpcId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcs",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeVpcsResponse> DescribeVpcsWithOptionsAsync(DescribeVpcsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            query["StorageBundleId"] = request.StorageBundleId;
            query["VpcId"] = request.VpcId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcs",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeVpcsResponse DescribeVpcs(DescribeVpcsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcsWithOptions(request, runtime);
        }

        public async Task<DescribeVpcsResponse> DescribeVpcsAsync(DescribeVpcsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcsWithOptionsAsync(request, runtime);
        }

        public DescribeZonesResponse DescribeZonesWithOptions(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeZones",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeZonesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeZonesResponse> DescribeZonesWithOptionsAsync(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeZones",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeZonesResponse DescribeZones(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeZonesWithOptions(request, runtime);
        }

        public async Task<DescribeZonesResponse> DescribeZonesAsync(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeZonesWithOptionsAsync(request, runtime);
        }

        public DisableGatewayLoggingResponse DisableGatewayLoggingWithOptions(DisableGatewayLoggingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableGatewayLogging",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableGatewayLoggingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisableGatewayLoggingResponse> DisableGatewayLoggingWithOptionsAsync(DisableGatewayLoggingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableGatewayLogging",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableGatewayLoggingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisableGatewayLoggingResponse DisableGatewayLogging(DisableGatewayLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableGatewayLoggingWithOptions(request, runtime);
        }

        public async Task<DisableGatewayLoggingResponse> DisableGatewayLoggingAsync(DisableGatewayLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableGatewayLoggingWithOptionsAsync(request, runtime);
        }

        public DisableGatewayNFSVersionResponse DisableGatewayNFSVersionWithOptions(DisableGatewayNFSVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["NFSVersion"] = request.NFSVersion;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableGatewayNFSVersion",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableGatewayNFSVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisableGatewayNFSVersionResponse> DisableGatewayNFSVersionWithOptionsAsync(DisableGatewayNFSVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["NFSVersion"] = request.NFSVersion;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableGatewayNFSVersion",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableGatewayNFSVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisableGatewayNFSVersionResponse DisableGatewayNFSVersion(DisableGatewayNFSVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableGatewayNFSVersionWithOptions(request, runtime);
        }

        public async Task<DisableGatewayNFSVersionResponse> DisableGatewayNFSVersionAsync(DisableGatewayNFSVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableGatewayNFSVersionWithOptionsAsync(request, runtime);
        }

        public EnableGatewayIpv6Response EnableGatewayIpv6WithOptions(EnableGatewayIpv6Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableGatewayIpv6",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableGatewayIpv6Response>(CallApi(params_, req, runtime));
        }

        public async Task<EnableGatewayIpv6Response> EnableGatewayIpv6WithOptionsAsync(EnableGatewayIpv6Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableGatewayIpv6",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableGatewayIpv6Response>(await CallApiAsync(params_, req, runtime));
        }

        public EnableGatewayIpv6Response EnableGatewayIpv6(EnableGatewayIpv6Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableGatewayIpv6WithOptions(request, runtime);
        }

        public async Task<EnableGatewayIpv6Response> EnableGatewayIpv6Async(EnableGatewayIpv6Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableGatewayIpv6WithOptionsAsync(request, runtime);
        }

        public EnableGatewayLoggingResponse EnableGatewayLoggingWithOptions(EnableGatewayLoggingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableGatewayLogging",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableGatewayLoggingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableGatewayLoggingResponse> EnableGatewayLoggingWithOptionsAsync(EnableGatewayLoggingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableGatewayLogging",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableGatewayLoggingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableGatewayLoggingResponse EnableGatewayLogging(EnableGatewayLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableGatewayLoggingWithOptions(request, runtime);
        }

        public async Task<EnableGatewayLoggingResponse> EnableGatewayLoggingAsync(EnableGatewayLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableGatewayLoggingWithOptionsAsync(request, runtime);
        }

        public ExpandCacheDiskResponse ExpandCacheDiskWithOptions(ExpandCacheDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["LocalFilePath"] = request.LocalFilePath;
            query["NewSizeInGB"] = request.NewSizeInGB;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExpandCacheDisk",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExpandCacheDiskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ExpandCacheDiskResponse> ExpandCacheDiskWithOptionsAsync(ExpandCacheDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["LocalFilePath"] = request.LocalFilePath;
            query["NewSizeInGB"] = request.NewSizeInGB;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExpandCacheDisk",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExpandCacheDiskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ExpandCacheDiskResponse ExpandCacheDisk(ExpandCacheDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExpandCacheDiskWithOptions(request, runtime);
        }

        public async Task<ExpandCacheDiskResponse> ExpandCacheDiskAsync(ExpandCacheDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExpandCacheDiskWithOptionsAsync(request, runtime);
        }

        public ExpandGatewayNetworkBandwidthResponse ExpandGatewayNetworkBandwidthWithOptions(ExpandGatewayNetworkBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["NewNetworkBandwidth"] = request.NewNetworkBandwidth;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExpandGatewayNetworkBandwidth",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExpandGatewayNetworkBandwidthResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ExpandGatewayNetworkBandwidthResponse> ExpandGatewayNetworkBandwidthWithOptionsAsync(ExpandGatewayNetworkBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["NewNetworkBandwidth"] = request.NewNetworkBandwidth;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExpandGatewayNetworkBandwidth",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExpandGatewayNetworkBandwidthResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ExpandGatewayNetworkBandwidthResponse ExpandGatewayNetworkBandwidth(ExpandGatewayNetworkBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExpandGatewayNetworkBandwidthWithOptions(request, runtime);
        }

        public async Task<ExpandGatewayNetworkBandwidthResponse> ExpandGatewayNetworkBandwidthAsync(ExpandGatewayNetworkBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExpandGatewayNetworkBandwidthWithOptionsAsync(request, runtime);
        }

        public GenerateGatewayTokenResponse GenerateGatewayTokenWithOptions(GenerateGatewayTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateGatewayToken",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateGatewayTokenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GenerateGatewayTokenResponse> GenerateGatewayTokenWithOptionsAsync(GenerateGatewayTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateGatewayToken",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateGatewayTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GenerateGatewayTokenResponse GenerateGatewayToken(GenerateGatewayTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateGatewayTokenWithOptions(request, runtime);
        }

        public async Task<GenerateGatewayTokenResponse> GenerateGatewayTokenAsync(GenerateGatewayTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateGatewayTokenWithOptionsAsync(request, runtime);
        }

        public GenerateMqttTokenResponse GenerateMqttTokenWithOptions(GenerateMqttTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientUUID"] = request.ClientUUID;
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateMqttToken",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateMqttTokenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GenerateMqttTokenResponse> GenerateMqttTokenWithOptionsAsync(GenerateMqttTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientUUID"] = request.ClientUUID;
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateMqttToken",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateMqttTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GenerateMqttTokenResponse GenerateMqttToken(GenerateMqttTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateMqttTokenWithOptions(request, runtime);
        }

        public async Task<GenerateMqttTokenResponse> GenerateMqttTokenAsync(GenerateMqttTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateMqttTokenWithOptionsAsync(request, runtime);
        }

        public GenerateStsTokenResponse GenerateStsTokenWithOptions(GenerateStsTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ExpireInSeconds"] = request.ExpireInSeconds;
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["TokenType"] = request.TokenType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateStsToken",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateStsTokenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GenerateStsTokenResponse> GenerateStsTokenWithOptionsAsync(GenerateStsTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ExpireInSeconds"] = request.ExpireInSeconds;
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["TokenType"] = request.TokenType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateStsToken",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateStsTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GenerateStsTokenResponse GenerateStsToken(GenerateStsTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateStsTokenWithOptions(request, runtime);
        }

        public async Task<GenerateStsTokenResponse> GenerateStsTokenAsync(GenerateStsTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateStsTokenWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NextToken"] = request.NextToken;
            query["RegionId"] = request.RegionId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceRegionId"] = request.ResourceRegionId;
            query["ResourceType"] = request.ResourceType;
            query["SecurityToken"] = request.SecurityToken;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2018-05-11",
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
            query["ResourceRegionId"] = request.ResourceRegionId;
            query["ResourceType"] = request.ResourceType;
            query["SecurityToken"] = request.SecurityToken;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2018-05-11",
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

        public ModifyGatewayResponse ModifyGatewayWithOptions(ModifyGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["GatewayId"] = request.GatewayId;
            query["Name"] = request.Name;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGateway",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyGatewayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyGatewayResponse> ModifyGatewayWithOptionsAsync(ModifyGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["GatewayId"] = request.GatewayId;
            query["Name"] = request.Name;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGateway",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
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

        public ModifyGatewayBlockVolumeResponse ModifyGatewayBlockVolumeWithOptions(ModifyGatewayBlockVolumeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CacheConfig"] = request.CacheConfig;
            query["GatewayId"] = request.GatewayId;
            query["IndexId"] = request.IndexId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGatewayBlockVolume",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyGatewayBlockVolumeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyGatewayBlockVolumeResponse> ModifyGatewayBlockVolumeWithOptionsAsync(ModifyGatewayBlockVolumeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CacheConfig"] = request.CacheConfig;
            query["GatewayId"] = request.GatewayId;
            query["IndexId"] = request.IndexId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGatewayBlockVolume",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyGatewayBlockVolumeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyGatewayBlockVolumeResponse ModifyGatewayBlockVolume(ModifyGatewayBlockVolumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyGatewayBlockVolumeWithOptions(request, runtime);
        }

        public async Task<ModifyGatewayBlockVolumeResponse> ModifyGatewayBlockVolumeAsync(ModifyGatewayBlockVolumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyGatewayBlockVolumeWithOptionsAsync(request, runtime);
        }

        public ModifyGatewayClassResponse ModifyGatewayClassWithOptions(ModifyGatewayClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayClass"] = request.GatewayClass;
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGatewayClass",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyGatewayClassResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyGatewayClassResponse> ModifyGatewayClassWithOptionsAsync(ModifyGatewayClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayClass"] = request.GatewayClass;
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGatewayClass",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyGatewayClassResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyGatewayClassResponse ModifyGatewayClass(ModifyGatewayClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyGatewayClassWithOptions(request, runtime);
        }

        public async Task<ModifyGatewayClassResponse> ModifyGatewayClassAsync(ModifyGatewayClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyGatewayClassWithOptionsAsync(request, runtime);
        }

        public ModifyGatewayFileShareResponse ModifyGatewayFileShareWithOptions(ModifyGatewayFileShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CacheConfig"] = request.CacheConfig;
            query["GatewayId"] = request.GatewayId;
            query["IndexId"] = request.IndexId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGatewayFileShare",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyGatewayFileShareResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyGatewayFileShareResponse> ModifyGatewayFileShareWithOptionsAsync(ModifyGatewayFileShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CacheConfig"] = request.CacheConfig;
            query["GatewayId"] = request.GatewayId;
            query["IndexId"] = request.IndexId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGatewayFileShare",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyGatewayFileShareResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyGatewayFileShareResponse ModifyGatewayFileShare(ModifyGatewayFileShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyGatewayFileShareWithOptions(request, runtime);
        }

        public async Task<ModifyGatewayFileShareResponse> ModifyGatewayFileShareAsync(ModifyGatewayFileShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyGatewayFileShareWithOptionsAsync(request, runtime);
        }

        public ModifyGatewayFileShareWatermarkResponse ModifyGatewayFileShareWatermarkWithOptions(ModifyGatewayFileShareWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["IndexId"] = request.IndexId;
            query["SecurityToken"] = request.SecurityToken;
            query["Watermark"] = request.Watermark;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGatewayFileShareWatermark",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyGatewayFileShareWatermarkResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyGatewayFileShareWatermarkResponse> ModifyGatewayFileShareWatermarkWithOptionsAsync(ModifyGatewayFileShareWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["IndexId"] = request.IndexId;
            query["SecurityToken"] = request.SecurityToken;
            query["Watermark"] = request.Watermark;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGatewayFileShareWatermark",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyGatewayFileShareWatermarkResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyGatewayFileShareWatermarkResponse ModifyGatewayFileShareWatermark(ModifyGatewayFileShareWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyGatewayFileShareWatermarkWithOptions(request, runtime);
        }

        public async Task<ModifyGatewayFileShareWatermarkResponse> ModifyGatewayFileShareWatermarkAsync(ModifyGatewayFileShareWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyGatewayFileShareWatermarkWithOptionsAsync(request, runtime);
        }

        public ModifyStorageBundleResponse ModifyStorageBundleWithOptions(ModifyStorageBundleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["SecurityToken"] = request.SecurityToken;
            query["StorageBundleId"] = request.StorageBundleId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyStorageBundle",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyStorageBundleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyStorageBundleResponse> ModifyStorageBundleWithOptionsAsync(ModifyStorageBundleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["SecurityToken"] = request.SecurityToken;
            query["StorageBundleId"] = request.StorageBundleId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyStorageBundle",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyStorageBundleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyStorageBundleResponse ModifyStorageBundle(ModifyStorageBundleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyStorageBundleWithOptions(request, runtime);
        }

        public async Task<ModifyStorageBundleResponse> ModifyStorageBundleAsync(ModifyStorageBundleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyStorageBundleWithOptionsAsync(request, runtime);
        }

        public OpenSgwServiceResponse OpenSgwServiceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenSgwService",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenSgwServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<OpenSgwServiceResponse> OpenSgwServiceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenSgwService",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenSgwServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public OpenSgwServiceResponse OpenSgwService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenSgwServiceWithOptions(runtime);
        }

        public async Task<OpenSgwServiceResponse> OpenSgwServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenSgwServiceWithOptionsAsync(runtime);
        }

        public OperateGatewayResponse OperateGatewayWithOptions(OperateGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["OperateAction"] = request.OperateAction;
            query["Params"] = request.Params;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateGateway",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateGatewayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<OperateGatewayResponse> OperateGatewayWithOptionsAsync(OperateGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["OperateAction"] = request.OperateAction;
            query["Params"] = request.Params;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateGateway",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        public OperateGatewayResponse OperateGateway(OperateGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateGatewayWithOptions(request, runtime);
        }

        public async Task<OperateGatewayResponse> OperateGatewayAsync(OperateGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateGatewayWithOptionsAsync(request, runtime);
        }

        public ReleaseServiceResponse ReleaseServiceWithOptions(ReleaseServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseService",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReleaseServiceResponse> ReleaseServiceWithOptionsAsync(ReleaseServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseService",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReleaseServiceResponse ReleaseService(ReleaseServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseServiceWithOptions(request, runtime);
        }

        public async Task<ReleaseServiceResponse> ReleaseServiceAsync(ReleaseServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseServiceWithOptionsAsync(request, runtime);
        }

        public RemoveSharesFromExpressSyncResponse RemoveSharesFromExpressSyncWithOptions(RemoveSharesFromExpressSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ExpressSyncId"] = request.ExpressSyncId;
            query["GatewayShares"] = request.GatewayShares;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveSharesFromExpressSync",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveSharesFromExpressSyncResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveSharesFromExpressSyncResponse> RemoveSharesFromExpressSyncWithOptionsAsync(RemoveSharesFromExpressSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ExpressSyncId"] = request.ExpressSyncId;
            query["GatewayShares"] = request.GatewayShares;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveSharesFromExpressSync",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveSharesFromExpressSyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveSharesFromExpressSyncResponse RemoveSharesFromExpressSync(RemoveSharesFromExpressSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveSharesFromExpressSyncWithOptions(request, runtime);
        }

        public async Task<RemoveSharesFromExpressSyncResponse> RemoveSharesFromExpressSyncAsync(RemoveSharesFromExpressSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveSharesFromExpressSyncWithOptionsAsync(request, runtime);
        }

        public RemoveTagsFromGatewayResponse RemoveTagsFromGatewayWithOptions(RemoveTagsFromGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["Tags"] = request.Tags;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveTagsFromGateway",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTagsFromGatewayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveTagsFromGatewayResponse> RemoveTagsFromGatewayWithOptionsAsync(RemoveTagsFromGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["Tags"] = request.Tags;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveTagsFromGateway",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTagsFromGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveTagsFromGatewayResponse RemoveTagsFromGateway(RemoveTagsFromGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveTagsFromGatewayWithOptions(request, runtime);
        }

        public async Task<RemoveTagsFromGatewayResponse> RemoveTagsFromGatewayAsync(RemoveTagsFromGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveTagsFromGatewayWithOptionsAsync(request, runtime);
        }

        public ReportBlockVolumesResponse ReportBlockVolumesWithOptions(ReportBlockVolumesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientUUID"] = request.ClientUUID;
            query["GatewayId"] = request.GatewayId;
            query["Info"] = request.Info;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportBlockVolumes",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportBlockVolumesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReportBlockVolumesResponse> ReportBlockVolumesWithOptionsAsync(ReportBlockVolumesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientUUID"] = request.ClientUUID;
            query["GatewayId"] = request.GatewayId;
            query["Info"] = request.Info;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportBlockVolumes",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportBlockVolumesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReportBlockVolumesResponse ReportBlockVolumes(ReportBlockVolumesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportBlockVolumesWithOptions(request, runtime);
        }

        public async Task<ReportBlockVolumesResponse> ReportBlockVolumesAsync(ReportBlockVolumesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportBlockVolumesWithOptionsAsync(request, runtime);
        }

        public ReportFileSharesResponse ReportFileSharesWithOptions(ReportFileSharesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientUUID"] = request.ClientUUID;
            query["GatewayId"] = request.GatewayId;
            query["Info"] = request.Info;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportFileShares",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportFileSharesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReportFileSharesResponse> ReportFileSharesWithOptionsAsync(ReportFileSharesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientUUID"] = request.ClientUUID;
            query["GatewayId"] = request.GatewayId;
            query["Info"] = request.Info;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportFileShares",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportFileSharesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReportFileSharesResponse ReportFileShares(ReportFileSharesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportFileSharesWithOptions(request, runtime);
        }

        public async Task<ReportFileSharesResponse> ReportFileSharesAsync(ReportFileSharesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportFileSharesWithOptionsAsync(request, runtime);
        }

        public ReportGatewayInfoResponse ReportGatewayInfoWithOptions(ReportGatewayInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientUUID"] = request.ClientUUID;
            query["GatewayId"] = request.GatewayId;
            query["GatewayStatus"] = request.GatewayStatus;
            query["Info"] = request.Info;
            query["SecurityToken"] = request.SecurityToken;
            query["Time"] = request.Time;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportGatewayInfo",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportGatewayInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReportGatewayInfoResponse> ReportGatewayInfoWithOptionsAsync(ReportGatewayInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientUUID"] = request.ClientUUID;
            query["GatewayId"] = request.GatewayId;
            query["GatewayStatus"] = request.GatewayStatus;
            query["Info"] = request.Info;
            query["SecurityToken"] = request.SecurityToken;
            query["Time"] = request.Time;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportGatewayInfo",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportGatewayInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReportGatewayInfoResponse ReportGatewayInfo(ReportGatewayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportGatewayInfoWithOptions(request, runtime);
        }

        public async Task<ReportGatewayInfoResponse> ReportGatewayInfoAsync(ReportGatewayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportGatewayInfoWithOptionsAsync(request, runtime);
        }

        public ReportGatewayUsageResponse ReportGatewayUsageWithOptions(ReportGatewayUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientUUID"] = request.ClientUUID;
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["Usage"] = request.Usage;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportGatewayUsage",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportGatewayUsageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReportGatewayUsageResponse> ReportGatewayUsageWithOptionsAsync(ReportGatewayUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientUUID"] = request.ClientUUID;
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["Usage"] = request.Usage;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportGatewayUsage",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportGatewayUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReportGatewayUsageResponse ReportGatewayUsage(ReportGatewayUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportGatewayUsageWithOptions(request, runtime);
        }

        public async Task<ReportGatewayUsageResponse> ReportGatewayUsageAsync(ReportGatewayUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportGatewayUsageWithOptionsAsync(request, runtime);
        }

        public ResetGatewayPasswordResponse ResetGatewayPasswordWithOptions(ResetGatewayPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["Password"] = request.Password;
            query["SecurityToken"] = request.SecurityToken;
            query["Username"] = request.Username;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetGatewayPassword",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetGatewayPasswordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ResetGatewayPasswordResponse> ResetGatewayPasswordWithOptionsAsync(ResetGatewayPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["Password"] = request.Password;
            query["SecurityToken"] = request.SecurityToken;
            query["Username"] = request.Username;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetGatewayPassword",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetGatewayPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ResetGatewayPasswordResponse ResetGatewayPassword(ResetGatewayPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetGatewayPasswordWithOptions(request, runtime);
        }

        public async Task<ResetGatewayPasswordResponse> ResetGatewayPasswordAsync(ResetGatewayPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetGatewayPasswordWithOptionsAsync(request, runtime);
        }

        public RestartFileSharesResponse RestartFileSharesWithOptions(RestartFileSharesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["ShareProtocol"] = request.ShareProtocol;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartFileShares",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartFileSharesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RestartFileSharesResponse> RestartFileSharesWithOptionsAsync(RestartFileSharesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            query["ShareProtocol"] = request.ShareProtocol;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartFileShares",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartFileSharesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RestartFileSharesResponse RestartFileShares(RestartFileSharesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartFileSharesWithOptions(request, runtime);
        }

        public async Task<RestartFileSharesResponse> RestartFileSharesAsync(RestartFileSharesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartFileSharesWithOptionsAsync(request, runtime);
        }

        public SetGatewayADInfoResponse SetGatewayADInfoWithOptions(SetGatewayADInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["IsEnabled"] = request.IsEnabled;
            query["Password"] = request.Password;
            query["SecurityToken"] = request.SecurityToken;
            query["ServerIp"] = request.ServerIp;
            query["Username"] = request.Username;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetGatewayADInfo",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetGatewayADInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetGatewayADInfoResponse> SetGatewayADInfoWithOptionsAsync(SetGatewayADInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["IsEnabled"] = request.IsEnabled;
            query["Password"] = request.Password;
            query["SecurityToken"] = request.SecurityToken;
            query["ServerIp"] = request.ServerIp;
            query["Username"] = request.Username;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetGatewayADInfo",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetGatewayADInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetGatewayADInfoResponse SetGatewayADInfo(SetGatewayADInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetGatewayADInfoWithOptions(request, runtime);
        }

        public async Task<SetGatewayADInfoResponse> SetGatewayADInfoAsync(SetGatewayADInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetGatewayADInfoWithOptionsAsync(request, runtime);
        }

        public SetGatewayDNSResponse SetGatewayDNSWithOptions(SetGatewayDNSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DnsServer"] = request.DnsServer;
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetGatewayDNS",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetGatewayDNSResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetGatewayDNSResponse> SetGatewayDNSWithOptionsAsync(SetGatewayDNSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DnsServer"] = request.DnsServer;
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetGatewayDNS",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetGatewayDNSResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetGatewayDNSResponse SetGatewayDNS(SetGatewayDNSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetGatewayDNSWithOptions(request, runtime);
        }

        public async Task<SetGatewayDNSResponse> SetGatewayDNSAsync(SetGatewayDNSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetGatewayDNSWithOptionsAsync(request, runtime);
        }

        public SetGatewayLDAPInfoResponse SetGatewayLDAPInfoWithOptions(SetGatewayLDAPInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BaseDN"] = request.BaseDN;
            query["GatewayId"] = request.GatewayId;
            query["IsEnabled"] = request.IsEnabled;
            query["IsTls"] = request.IsTls;
            query["Password"] = request.Password;
            query["RootDN"] = request.RootDN;
            query["SecurityToken"] = request.SecurityToken;
            query["ServerIp"] = request.ServerIp;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetGatewayLDAPInfo",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetGatewayLDAPInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetGatewayLDAPInfoResponse> SetGatewayLDAPInfoWithOptionsAsync(SetGatewayLDAPInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BaseDN"] = request.BaseDN;
            query["GatewayId"] = request.GatewayId;
            query["IsEnabled"] = request.IsEnabled;
            query["IsTls"] = request.IsTls;
            query["Password"] = request.Password;
            query["RootDN"] = request.RootDN;
            query["SecurityToken"] = request.SecurityToken;
            query["ServerIp"] = request.ServerIp;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetGatewayLDAPInfo",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetGatewayLDAPInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetGatewayLDAPInfoResponse SetGatewayLDAPInfo(SetGatewayLDAPInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetGatewayLDAPInfoWithOptions(request, runtime);
        }

        public async Task<SetGatewayLDAPInfoResponse> SetGatewayLDAPInfoAsync(SetGatewayLDAPInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetGatewayLDAPInfoWithOptionsAsync(request, runtime);
        }

        public SwitchCSGClientsReverseSyncConfigurationResponse SwitchCSGClientsReverseSyncConfigurationWithOptions(SwitchCSGClientsReverseSyncConfigurationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SwitchCSGClientsReverseSyncConfigurationShrinkRequest request = new SwitchCSGClientsReverseSyncConfigurationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClientIds))
            {
                request.ClientIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClientIds, "ClientIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientIds"] = request.ClientIdsShrink;
            query["ClientRegionId"] = request.ClientRegionId;
            query["IsReverseSync"] = request.IsReverseSync;
            query["ReverseSyncInternalSecond"] = request.ReverseSyncInternalSecond;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchCSGClientsReverseSyncConfiguration",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchCSGClientsReverseSyncConfigurationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SwitchCSGClientsReverseSyncConfigurationResponse> SwitchCSGClientsReverseSyncConfigurationWithOptionsAsync(SwitchCSGClientsReverseSyncConfigurationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SwitchCSGClientsReverseSyncConfigurationShrinkRequest request = new SwitchCSGClientsReverseSyncConfigurationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClientIds))
            {
                request.ClientIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClientIds, "ClientIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientIds"] = request.ClientIdsShrink;
            query["ClientRegionId"] = request.ClientRegionId;
            query["IsReverseSync"] = request.IsReverseSync;
            query["ReverseSyncInternalSecond"] = request.ReverseSyncInternalSecond;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchCSGClientsReverseSyncConfiguration",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchCSGClientsReverseSyncConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SwitchCSGClientsReverseSyncConfigurationResponse SwitchCSGClientsReverseSyncConfiguration(SwitchCSGClientsReverseSyncConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchCSGClientsReverseSyncConfigurationWithOptions(request, runtime);
        }

        public async Task<SwitchCSGClientsReverseSyncConfigurationResponse> SwitchCSGClientsReverseSyncConfigurationAsync(SwitchCSGClientsReverseSyncConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchCSGClientsReverseSyncConfigurationWithOptionsAsync(request, runtime);
        }

        public SwitchGatewayExpirationPolicyResponse SwitchGatewayExpirationPolicyWithOptions(SwitchGatewayExpirationPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchGatewayExpirationPolicy",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchGatewayExpirationPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SwitchGatewayExpirationPolicyResponse> SwitchGatewayExpirationPolicyWithOptionsAsync(SwitchGatewayExpirationPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchGatewayExpirationPolicy",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchGatewayExpirationPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SwitchGatewayExpirationPolicyResponse SwitchGatewayExpirationPolicy(SwitchGatewayExpirationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchGatewayExpirationPolicyWithOptions(request, runtime);
        }

        public async Task<SwitchGatewayExpirationPolicyResponse> SwitchGatewayExpirationPolicyAsync(SwitchGatewayExpirationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchGatewayExpirationPolicyWithOptionsAsync(request, runtime);
        }

        public SwitchToSubscriptionResponse SwitchToSubscriptionWithOptions(SwitchToSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchToSubscription",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchToSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SwitchToSubscriptionResponse> SwitchToSubscriptionWithOptionsAsync(SwitchToSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchToSubscription",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchToSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SwitchToSubscriptionResponse SwitchToSubscription(SwitchToSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchToSubscriptionWithOptions(request, runtime);
        }

        public async Task<SwitchToSubscriptionResponse> SwitchToSubscriptionAsync(SwitchToSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchToSubscriptionWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceRegionId"] = request.ResourceRegionId;
            query["ResourceType"] = request.ResourceType;
            query["SecurityToken"] = request.SecurityToken;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2018-05-11",
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
            query["ResourceRegionId"] = request.ResourceRegionId;
            query["ResourceType"] = request.ResourceType;
            query["SecurityToken"] = request.SecurityToken;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2018-05-11",
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

        public TriggerGatewayRemoteSyncResponse TriggerGatewayRemoteSyncWithOptions(TriggerGatewayRemoteSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["IndexId"] = request.IndexId;
            query["Path"] = request.Path;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerGatewayRemoteSync",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerGatewayRemoteSyncResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TriggerGatewayRemoteSyncResponse> TriggerGatewayRemoteSyncWithOptionsAsync(TriggerGatewayRemoteSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            query["IndexId"] = request.IndexId;
            query["Path"] = request.Path;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerGatewayRemoteSync",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerGatewayRemoteSyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TriggerGatewayRemoteSyncResponse TriggerGatewayRemoteSync(TriggerGatewayRemoteSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TriggerGatewayRemoteSyncWithOptions(request, runtime);
        }

        public async Task<TriggerGatewayRemoteSyncResponse> TriggerGatewayRemoteSyncAsync(TriggerGatewayRemoteSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TriggerGatewayRemoteSyncWithOptionsAsync(request, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["All"] = request.All;
            query["RegionId"] = request.RegionId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceRegionId"] = request.ResourceRegionId;
            query["ResourceType"] = request.ResourceType;
            query["SecurityToken"] = request.SecurityToken;
            query["TagKey"] = request.TagKey;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2018-05-11",
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
            query["ResourceRegionId"] = request.ResourceRegionId;
            query["ResourceType"] = request.ResourceType;
            query["SecurityToken"] = request.SecurityToken;
            query["TagKey"] = request.TagKey;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2018-05-11",
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

        public UpdateGatewayBlockVolumeResponse UpdateGatewayBlockVolumeWithOptions(UpdateGatewayBlockVolumeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ChapEnabled"] = request.ChapEnabled;
            query["ChapInPassword"] = request.ChapInPassword;
            query["ChapInUser"] = request.ChapInUser;
            query["GatewayId"] = request.GatewayId;
            query["IndexId"] = request.IndexId;
            query["SecurityToken"] = request.SecurityToken;
            query["Size"] = request.Size;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGatewayBlockVolume",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGatewayBlockVolumeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateGatewayBlockVolumeResponse> UpdateGatewayBlockVolumeWithOptionsAsync(UpdateGatewayBlockVolumeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ChapEnabled"] = request.ChapEnabled;
            query["ChapInPassword"] = request.ChapInPassword;
            query["ChapInUser"] = request.ChapInUser;
            query["GatewayId"] = request.GatewayId;
            query["IndexId"] = request.IndexId;
            query["SecurityToken"] = request.SecurityToken;
            query["Size"] = request.Size;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGatewayBlockVolume",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGatewayBlockVolumeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateGatewayBlockVolumeResponse UpdateGatewayBlockVolume(UpdateGatewayBlockVolumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGatewayBlockVolumeWithOptions(request, runtime);
        }

        public async Task<UpdateGatewayBlockVolumeResponse> UpdateGatewayBlockVolumeAsync(UpdateGatewayBlockVolumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGatewayBlockVolumeWithOptionsAsync(request, runtime);
        }

        public UpdateGatewayFileShareResponse UpdateGatewayFileShareWithOptions(UpdateGatewayFileShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccessBasedEnumeration"] = request.AccessBasedEnumeration;
            query["BackendLimit"] = request.BackendLimit;
            query["Browsable"] = request.Browsable;
            query["BypassCacheRead"] = request.BypassCacheRead;
            query["CacheMode"] = request.CacheMode;
            query["ClientSideCmk"] = request.ClientSideCmk;
            query["ClientSideEncryption"] = request.ClientSideEncryption;
            query["DirectIO"] = request.DirectIO;
            query["DownloadLimit"] = request.DownloadLimit;
            query["FastReclaim"] = request.FastReclaim;
            query["FrontendLimit"] = request.FrontendLimit;
            query["GatewayId"] = request.GatewayId;
            query["IgnoreDelete"] = request.IgnoreDelete;
            query["InPlace"] = request.InPlace;
            query["IndexId"] = request.IndexId;
            query["KmsRotatePeriod"] = request.KmsRotatePeriod;
            query["LagPeriod"] = request.LagPeriod;
            query["Name"] = request.Name;
            query["NfsV4Optimization"] = request.NfsV4Optimization;
            query["PollingInterval"] = request.PollingInterval;
            query["ReadOnlyClientList"] = request.ReadOnlyClientList;
            query["ReadOnlyUserList"] = request.ReadOnlyUserList;
            query["ReadWriteClientList"] = request.ReadWriteClientList;
            query["ReadWriteUserList"] = request.ReadWriteUserList;
            query["RemoteSync"] = request.RemoteSync;
            query["RemoteSyncDownload"] = request.RemoteSyncDownload;
            query["SecurityToken"] = request.SecurityToken;
            query["ServerSideCmk"] = request.ServerSideCmk;
            query["ServerSideEncryption"] = request.ServerSideEncryption;
            query["Squash"] = request.Squash;
            query["TransferAcceleration"] = request.TransferAcceleration;
            query["WindowsAcl"] = request.WindowsAcl;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGatewayFileShare",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGatewayFileShareResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateGatewayFileShareResponse> UpdateGatewayFileShareWithOptionsAsync(UpdateGatewayFileShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccessBasedEnumeration"] = request.AccessBasedEnumeration;
            query["BackendLimit"] = request.BackendLimit;
            query["Browsable"] = request.Browsable;
            query["BypassCacheRead"] = request.BypassCacheRead;
            query["CacheMode"] = request.CacheMode;
            query["ClientSideCmk"] = request.ClientSideCmk;
            query["ClientSideEncryption"] = request.ClientSideEncryption;
            query["DirectIO"] = request.DirectIO;
            query["DownloadLimit"] = request.DownloadLimit;
            query["FastReclaim"] = request.FastReclaim;
            query["FrontendLimit"] = request.FrontendLimit;
            query["GatewayId"] = request.GatewayId;
            query["IgnoreDelete"] = request.IgnoreDelete;
            query["InPlace"] = request.InPlace;
            query["IndexId"] = request.IndexId;
            query["KmsRotatePeriod"] = request.KmsRotatePeriod;
            query["LagPeriod"] = request.LagPeriod;
            query["Name"] = request.Name;
            query["NfsV4Optimization"] = request.NfsV4Optimization;
            query["PollingInterval"] = request.PollingInterval;
            query["ReadOnlyClientList"] = request.ReadOnlyClientList;
            query["ReadOnlyUserList"] = request.ReadOnlyUserList;
            query["ReadWriteClientList"] = request.ReadWriteClientList;
            query["ReadWriteUserList"] = request.ReadWriteUserList;
            query["RemoteSync"] = request.RemoteSync;
            query["RemoteSyncDownload"] = request.RemoteSyncDownload;
            query["SecurityToken"] = request.SecurityToken;
            query["ServerSideCmk"] = request.ServerSideCmk;
            query["ServerSideEncryption"] = request.ServerSideEncryption;
            query["Squash"] = request.Squash;
            query["TransferAcceleration"] = request.TransferAcceleration;
            query["WindowsAcl"] = request.WindowsAcl;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGatewayFileShare",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGatewayFileShareResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateGatewayFileShareResponse UpdateGatewayFileShare(UpdateGatewayFileShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGatewayFileShareWithOptions(request, runtime);
        }

        public async Task<UpdateGatewayFileShareResponse> UpdateGatewayFileShareAsync(UpdateGatewayFileShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGatewayFileShareWithOptionsAsync(request, runtime);
        }

        public UpgradeGatewayResponse UpgradeGatewayWithOptions(UpgradeGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeGateway",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeGatewayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpgradeGatewayResponse> UpgradeGatewayWithOptionsAsync(UpgradeGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeGateway",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpgradeGatewayResponse UpgradeGateway(UpgradeGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeGatewayWithOptions(request, runtime);
        }

        public async Task<UpgradeGatewayResponse> UpgradeGatewayAsync(UpgradeGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeGatewayWithOptionsAsync(request, runtime);
        }

        public UploadCSGClientLogResponse UploadCSGClientLogWithOptions(UploadCSGClientLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientId"] = request.ClientId;
            query["ClientRegionId"] = request.ClientRegionId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadCSGClientLog",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadCSGClientLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UploadCSGClientLogResponse> UploadCSGClientLogWithOptionsAsync(UploadCSGClientLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientId"] = request.ClientId;
            query["ClientRegionId"] = request.ClientRegionId;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadCSGClientLog",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadCSGClientLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UploadCSGClientLogResponse UploadCSGClientLog(UploadCSGClientLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadCSGClientLogWithOptions(request, runtime);
        }

        public async Task<UploadCSGClientLogResponse> UploadCSGClientLogAsync(UploadCSGClientLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadCSGClientLogWithOptionsAsync(request, runtime);
        }

        public UploadGatewayLogResponse UploadGatewayLogWithOptions(UploadGatewayLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadGatewayLog",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadGatewayLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UploadGatewayLogResponse> UploadGatewayLogWithOptionsAsync(UploadGatewayLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GatewayId"] = request.GatewayId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadGatewayLog",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadGatewayLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UploadGatewayLogResponse UploadGatewayLog(UploadGatewayLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadGatewayLogWithOptions(request, runtime);
        }

        public async Task<UploadGatewayLogResponse> UploadGatewayLogAsync(UploadGatewayLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadGatewayLogWithOptionsAsync(request, runtime);
        }

        public ValidateExpressSyncConfigResponse ValidateExpressSyncConfigWithOptions(ValidateExpressSyncConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BucketName"] = request.BucketName;
            query["BucketPrefix"] = request.BucketPrefix;
            query["BucketRegion"] = request.BucketRegion;
            query["Name"] = request.Name;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateExpressSyncConfig",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateExpressSyncConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ValidateExpressSyncConfigResponse> ValidateExpressSyncConfigWithOptionsAsync(ValidateExpressSyncConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BucketName"] = request.BucketName;
            query["BucketPrefix"] = request.BucketPrefix;
            query["BucketRegion"] = request.BucketRegion;
            query["Name"] = request.Name;
            query["SecurityToken"] = request.SecurityToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateExpressSyncConfig",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateExpressSyncConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ValidateExpressSyncConfigResponse ValidateExpressSyncConfig(ValidateExpressSyncConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ValidateExpressSyncConfigWithOptions(request, runtime);
        }

        public async Task<ValidateExpressSyncConfigResponse> ValidateExpressSyncConfigAsync(ValidateExpressSyncConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ValidateExpressSyncConfigWithOptionsAsync(request, runtime);
        }

        public ValidateGatewayNameResponse ValidateGatewayNameWithOptions(ValidateGatewayNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Name"] = request.Name;
            query["StorageBundleId"] = request.StorageBundleId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateGatewayName",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateGatewayNameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ValidateGatewayNameResponse> ValidateGatewayNameWithOptionsAsync(ValidateGatewayNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Name"] = request.Name;
            query["StorageBundleId"] = request.StorageBundleId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateGatewayName",
                Version = "2018-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateGatewayNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ValidateGatewayNameResponse ValidateGatewayName(ValidateGatewayNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ValidateGatewayNameWithOptions(request, runtime);
        }

        public async Task<ValidateGatewayNameResponse> ValidateGatewayNameAsync(ValidateGatewayNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ValidateGatewayNameWithOptionsAsync(request, runtime);
        }

    }
}
