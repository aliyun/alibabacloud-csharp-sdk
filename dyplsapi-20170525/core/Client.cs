// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dyplsapi20170525.Models;

namespace AlibabaCloud.SDK.Dyplsapi20170525
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("dyplsapi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddAxnTrackNoResponse AddAxnTrackNoWithOptions(AddAxnTrackNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["PhoneNoX"] = request.PhoneNoX;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SubsId"] = request.SubsId;
            query["trackNo"] = request.TrackNo;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddAxnTrackNo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAxnTrackNoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddAxnTrackNoResponse> AddAxnTrackNoWithOptionsAsync(AddAxnTrackNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["PhoneNoX"] = request.PhoneNoX;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SubsId"] = request.SubsId;
            query["trackNo"] = request.TrackNo;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddAxnTrackNo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAxnTrackNoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddAxnTrackNoResponse AddAxnTrackNo(AddAxnTrackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAxnTrackNoWithOptions(request, runtime);
        }

        public async Task<AddAxnTrackNoResponse> AddAxnTrackNoAsync(AddAxnTrackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAxnTrackNoWithOptionsAsync(request, runtime);
        }

        public AddSecretBlacklistResponse AddSecretBlacklistWithOptions(AddSecretBlacklistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BlackNo"] = request.BlackNo;
            query["BlackType"] = request.BlackType;
            query["PoolKey"] = request.PoolKey;
            query["Remark"] = request.Remark;
            query["WayControl"] = request.WayControl;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSecretBlacklist",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSecretBlacklistResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddSecretBlacklistResponse> AddSecretBlacklistWithOptionsAsync(AddSecretBlacklistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BlackNo"] = request.BlackNo;
            query["BlackType"] = request.BlackType;
            query["PoolKey"] = request.PoolKey;
            query["Remark"] = request.Remark;
            query["WayControl"] = request.WayControl;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSecretBlacklist",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSecretBlacklistResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddSecretBlacklistResponse AddSecretBlacklist(AddSecretBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSecretBlacklistWithOptions(request, runtime);
        }

        public async Task<AddSecretBlacklistResponse> AddSecretBlacklistAsync(AddSecretBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSecretBlacklistWithOptionsAsync(request, runtime);
        }

        public BindAxbResponse BindAxbWithOptions(BindAxbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ASRModelId"] = request.ASRModelId;
            query["ASRStatus"] = request.ASRStatus;
            query["CallDisplayType"] = request.CallDisplayType;
            query["CallRestrict"] = request.CallRestrict;
            query["CallTimeout"] = request.CallTimeout;
            query["ExpectCity"] = request.ExpectCity;
            query["Expiration"] = request.Expiration;
            query["IsRecordingEnabled"] = request.IsRecordingEnabled;
            query["OutId"] = request.OutId;
            query["OutOrderId"] = request.OutOrderId;
            query["OwnerId"] = request.OwnerId;
            query["PhoneNoA"] = request.PhoneNoA;
            query["PhoneNoB"] = request.PhoneNoB;
            query["PhoneNoX"] = request.PhoneNoX;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RingConfig"] = request.RingConfig;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAxb",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAxbResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BindAxbResponse> BindAxbWithOptionsAsync(BindAxbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ASRModelId"] = request.ASRModelId;
            query["ASRStatus"] = request.ASRStatus;
            query["CallDisplayType"] = request.CallDisplayType;
            query["CallRestrict"] = request.CallRestrict;
            query["CallTimeout"] = request.CallTimeout;
            query["ExpectCity"] = request.ExpectCity;
            query["Expiration"] = request.Expiration;
            query["IsRecordingEnabled"] = request.IsRecordingEnabled;
            query["OutId"] = request.OutId;
            query["OutOrderId"] = request.OutOrderId;
            query["OwnerId"] = request.OwnerId;
            query["PhoneNoA"] = request.PhoneNoA;
            query["PhoneNoB"] = request.PhoneNoB;
            query["PhoneNoX"] = request.PhoneNoX;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RingConfig"] = request.RingConfig;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAxb",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAxbResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BindAxbResponse BindAxb(BindAxbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAxbWithOptions(request, runtime);
        }

        public async Task<BindAxbResponse> BindAxbAsync(BindAxbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAxbWithOptionsAsync(request, runtime);
        }

        public BindAxgResponse BindAxgWithOptions(BindAxgRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ASRModelId"] = request.ASRModelId;
            query["ASRStatus"] = request.ASRStatus;
            query["CallDisplayType"] = request.CallDisplayType;
            query["CallRestrict"] = request.CallRestrict;
            query["ExpectCity"] = request.ExpectCity;
            query["Expiration"] = request.Expiration;
            query["GroupId"] = request.GroupId;
            query["IsRecordingEnabled"] = request.IsRecordingEnabled;
            query["OutId"] = request.OutId;
            query["OutOrderId"] = request.OutOrderId;
            query["OwnerId"] = request.OwnerId;
            query["PhoneNoA"] = request.PhoneNoA;
            query["PhoneNoB"] = request.PhoneNoB;
            query["PhoneNoX"] = request.PhoneNoX;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RingConfig"] = request.RingConfig;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAxg",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAxgResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BindAxgResponse> BindAxgWithOptionsAsync(BindAxgRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ASRModelId"] = request.ASRModelId;
            query["ASRStatus"] = request.ASRStatus;
            query["CallDisplayType"] = request.CallDisplayType;
            query["CallRestrict"] = request.CallRestrict;
            query["ExpectCity"] = request.ExpectCity;
            query["Expiration"] = request.Expiration;
            query["GroupId"] = request.GroupId;
            query["IsRecordingEnabled"] = request.IsRecordingEnabled;
            query["OutId"] = request.OutId;
            query["OutOrderId"] = request.OutOrderId;
            query["OwnerId"] = request.OwnerId;
            query["PhoneNoA"] = request.PhoneNoA;
            query["PhoneNoB"] = request.PhoneNoB;
            query["PhoneNoX"] = request.PhoneNoX;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RingConfig"] = request.RingConfig;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAxg",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAxgResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BindAxgResponse BindAxg(BindAxgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAxgWithOptions(request, runtime);
        }

        public async Task<BindAxgResponse> BindAxgAsync(BindAxgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAxgWithOptionsAsync(request, runtime);
        }

        public BindAxnResponse BindAxnWithOptions(BindAxnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ASRModelId"] = request.ASRModelId;
            query["ASRStatus"] = request.ASRStatus;
            query["CallDisplayType"] = request.CallDisplayType;
            query["CallRestrict"] = request.CallRestrict;
            query["CallTimeout"] = request.CallTimeout;
            query["ExpectCity"] = request.ExpectCity;
            query["Expiration"] = request.Expiration;
            query["IsRecordingEnabled"] = request.IsRecordingEnabled;
            query["NoType"] = request.NoType;
            query["OutId"] = request.OutId;
            query["OutOrderId"] = request.OutOrderId;
            query["OwnerId"] = request.OwnerId;
            query["PhoneNoA"] = request.PhoneNoA;
            query["PhoneNoB"] = request.PhoneNoB;
            query["PhoneNoX"] = request.PhoneNoX;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RingConfig"] = request.RingConfig;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAxn",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAxnResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BindAxnResponse> BindAxnWithOptionsAsync(BindAxnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ASRModelId"] = request.ASRModelId;
            query["ASRStatus"] = request.ASRStatus;
            query["CallDisplayType"] = request.CallDisplayType;
            query["CallRestrict"] = request.CallRestrict;
            query["CallTimeout"] = request.CallTimeout;
            query["ExpectCity"] = request.ExpectCity;
            query["Expiration"] = request.Expiration;
            query["IsRecordingEnabled"] = request.IsRecordingEnabled;
            query["NoType"] = request.NoType;
            query["OutId"] = request.OutId;
            query["OutOrderId"] = request.OutOrderId;
            query["OwnerId"] = request.OwnerId;
            query["PhoneNoA"] = request.PhoneNoA;
            query["PhoneNoB"] = request.PhoneNoB;
            query["PhoneNoX"] = request.PhoneNoX;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RingConfig"] = request.RingConfig;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAxn",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAxnResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BindAxnResponse BindAxn(BindAxnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAxnWithOptions(request, runtime);
        }

        public async Task<BindAxnResponse> BindAxnAsync(BindAxnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAxnWithOptionsAsync(request, runtime);
        }

        public BindAxnExtensionResponse BindAxnExtensionWithOptions(BindAxnExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ASRModelId"] = request.ASRModelId;
            query["ASRStatus"] = request.ASRStatus;
            query["CallDisplayType"] = request.CallDisplayType;
            query["CallRestrict"] = request.CallRestrict;
            query["ExpectCity"] = request.ExpectCity;
            query["Expiration"] = request.Expiration;
            query["Extension"] = request.Extension;
            query["IsRecordingEnabled"] = request.IsRecordingEnabled;
            query["OutId"] = request.OutId;
            query["OutOrderId"] = request.OutOrderId;
            query["OwnerId"] = request.OwnerId;
            query["PhoneNoA"] = request.PhoneNoA;
            query["PhoneNoB"] = request.PhoneNoB;
            query["PhoneNoX"] = request.PhoneNoX;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RingConfig"] = request.RingConfig;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAxnExtension",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAxnExtensionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BindAxnExtensionResponse> BindAxnExtensionWithOptionsAsync(BindAxnExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ASRModelId"] = request.ASRModelId;
            query["ASRStatus"] = request.ASRStatus;
            query["CallDisplayType"] = request.CallDisplayType;
            query["CallRestrict"] = request.CallRestrict;
            query["ExpectCity"] = request.ExpectCity;
            query["Expiration"] = request.Expiration;
            query["Extension"] = request.Extension;
            query["IsRecordingEnabled"] = request.IsRecordingEnabled;
            query["OutId"] = request.OutId;
            query["OutOrderId"] = request.OutOrderId;
            query["OwnerId"] = request.OwnerId;
            query["PhoneNoA"] = request.PhoneNoA;
            query["PhoneNoB"] = request.PhoneNoB;
            query["PhoneNoX"] = request.PhoneNoX;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RingConfig"] = request.RingConfig;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAxnExtension",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAxnExtensionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BindAxnExtensionResponse BindAxnExtension(BindAxnExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAxnExtensionWithOptions(request, runtime);
        }

        public async Task<BindAxnExtensionResponse> BindAxnExtensionAsync(BindAxnExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAxnExtensionWithOptionsAsync(request, runtime);
        }

        public BuySecretNoResponse BuySecretNoWithOptions(BuySecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["City"] = request.City;
            query["DisplayPool"] = request.DisplayPool;
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            query["SpecId"] = request.SpecId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BuySecretNo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BuySecretNoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BuySecretNoResponse> BuySecretNoWithOptionsAsync(BuySecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["City"] = request.City;
            query["DisplayPool"] = request.DisplayPool;
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            query["SpecId"] = request.SpecId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BuySecretNo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BuySecretNoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BuySecretNoResponse BuySecretNo(BuySecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BuySecretNoWithOptions(request, runtime);
        }

        public async Task<BuySecretNoResponse> BuySecretNoAsync(BuySecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BuySecretNoWithOptionsAsync(request, runtime);
        }

        public CancelPickUpWaybillResponse CancelPickUpWaybillWithOptions(CancelPickUpWaybillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CancelDesc"] = request.CancelDesc;
            query["OuterOrderCode"] = request.OuterOrderCode;
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
                Action = "CancelPickUpWaybill",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelPickUpWaybillResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelPickUpWaybillResponse> CancelPickUpWaybillWithOptionsAsync(CancelPickUpWaybillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CancelDesc"] = request.CancelDesc;
            query["OuterOrderCode"] = request.OuterOrderCode;
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
                Action = "CancelPickUpWaybill",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelPickUpWaybillResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelPickUpWaybillResponse CancelPickUpWaybill(CancelPickUpWaybillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelPickUpWaybillWithOptions(request, runtime);
        }

        public async Task<CancelPickUpWaybillResponse> CancelPickUpWaybillAsync(CancelPickUpWaybillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelPickUpWaybillWithOptionsAsync(request, runtime);
        }

        public ConfirmSendSmsResponse ConfirmSendSmsWithOptions(ConfirmSendSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallId"] = request.CallId;
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmSendSms",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmSendSmsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ConfirmSendSmsResponse> ConfirmSendSmsWithOptionsAsync(ConfirmSendSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallId"] = request.CallId;
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmSendSms",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmSendSmsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ConfirmSendSmsResponse ConfirmSendSms(ConfirmSendSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfirmSendSmsWithOptions(request, runtime);
        }

        public async Task<ConfirmSendSmsResponse> ConfirmSendSmsAsync(ConfirmSendSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfirmSendSmsWithOptionsAsync(request, runtime);
        }

        public CreateAxgGroupResponse CreateAxgGroupWithOptions(CreateAxgGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Name"] = request.Name;
            query["Numbers"] = request.Numbers;
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["Remark"] = request.Remark;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAxgGroup",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAxgGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateAxgGroupResponse> CreateAxgGroupWithOptionsAsync(CreateAxgGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Name"] = request.Name;
            query["Numbers"] = request.Numbers;
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["Remark"] = request.Remark;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAxgGroup",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAxgGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateAxgGroupResponse CreateAxgGroup(CreateAxgGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAxgGroupWithOptions(request, runtime);
        }

        public async Task<CreateAxgGroupResponse> CreateAxgGroupAsync(CreateAxgGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAxgGroupWithOptionsAsync(request, runtime);
        }

        public CreatePickUpWaybillResponse CreatePickUpWaybillWithOptions(CreatePickUpWaybillRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePickUpWaybillShrinkRequest request = new CreatePickUpWaybillShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConsigneeAddress.ToMap()))
            {
                request.ConsigneeAddressShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConsigneeAddress.ToMap(), "ConsigneeAddress", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GoodsInfos))
            {
                request.GoodsInfosShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GoodsInfos, "GoodsInfos", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SendAddress.ToMap()))
            {
                request.SendAddressShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SendAddress.ToMap(), "SendAddress", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ConsigneeAddress"] = request.ConsigneeAddressShrink;
            query["ConsigneeMobile"] = request.ConsigneeMobile;
            query["ConsigneeName"] = request.ConsigneeName;
            query["ConsigneePhone"] = request.ConsigneePhone;
            query["CpCode"] = request.CpCode;
            query["GoodsInfos"] = request.GoodsInfosShrink;
            query["OrderChannels"] = request.OrderChannels;
            query["OuterOrderCode"] = request.OuterOrderCode;
            query["Remark"] = request.Remark;
            query["SendAddress"] = request.SendAddressShrink;
            query["SendMobile"] = request.SendMobile;
            query["SendName"] = request.SendName;
            query["SendPhone"] = request.SendPhone;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePickUpWaybill",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePickUpWaybillResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreatePickUpWaybillResponse> CreatePickUpWaybillWithOptionsAsync(CreatePickUpWaybillRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePickUpWaybillShrinkRequest request = new CreatePickUpWaybillShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConsigneeAddress.ToMap()))
            {
                request.ConsigneeAddressShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConsigneeAddress.ToMap(), "ConsigneeAddress", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GoodsInfos))
            {
                request.GoodsInfosShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GoodsInfos, "GoodsInfos", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SendAddress.ToMap()))
            {
                request.SendAddressShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SendAddress.ToMap(), "SendAddress", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ConsigneeAddress"] = request.ConsigneeAddressShrink;
            query["ConsigneeMobile"] = request.ConsigneeMobile;
            query["ConsigneeName"] = request.ConsigneeName;
            query["ConsigneePhone"] = request.ConsigneePhone;
            query["CpCode"] = request.CpCode;
            query["GoodsInfos"] = request.GoodsInfosShrink;
            query["OrderChannels"] = request.OrderChannels;
            query["OuterOrderCode"] = request.OuterOrderCode;
            query["Remark"] = request.Remark;
            query["SendAddress"] = request.SendAddressShrink;
            query["SendMobile"] = request.SendMobile;
            query["SendName"] = request.SendName;
            query["SendPhone"] = request.SendPhone;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePickUpWaybill",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePickUpWaybillResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreatePickUpWaybillResponse CreatePickUpWaybill(CreatePickUpWaybillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePickUpWaybillWithOptions(request, runtime);
        }

        public async Task<CreatePickUpWaybillResponse> CreatePickUpWaybillAsync(CreatePickUpWaybillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePickUpWaybillWithOptionsAsync(request, runtime);
        }

        public CreateSubscriptionResponse CreateSubscriptionWithOptions(CreateSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BindToken"] = request.BindToken;
            query["OwnerId"] = request.OwnerId;
            query["PhoneNo"] = request.PhoneNo;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSubscription",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSubscriptionResponse> CreateSubscriptionWithOptionsAsync(CreateSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BindToken"] = request.BindToken;
            query["OwnerId"] = request.OwnerId;
            query["PhoneNo"] = request.PhoneNo;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSubscription",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateSubscriptionResponse CreateSubscription(CreateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSubscriptionWithOptions(request, runtime);
        }

        public async Task<CreateSubscriptionResponse> CreateSubscriptionAsync(CreateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSubscriptionWithOptionsAsync(request, runtime);
        }

        public DeleteSecretBlacklistResponse DeleteSecretBlacklistWithOptions(DeleteSecretBlacklistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BlackNo"] = request.BlackNo;
            query["BlackType"] = request.BlackType;
            query["PoolKey"] = request.PoolKey;
            query["Remark"] = request.Remark;
            query["WayControl"] = request.WayControl;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSecretBlacklist",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSecretBlacklistResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteSecretBlacklistResponse> DeleteSecretBlacklistWithOptionsAsync(DeleteSecretBlacklistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BlackNo"] = request.BlackNo;
            query["BlackType"] = request.BlackType;
            query["PoolKey"] = request.PoolKey;
            query["Remark"] = request.Remark;
            query["WayControl"] = request.WayControl;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSecretBlacklist",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSecretBlacklistResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteSecretBlacklistResponse DeleteSecretBlacklist(DeleteSecretBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSecretBlacklistWithOptions(request, runtime);
        }

        public async Task<DeleteSecretBlacklistResponse> DeleteSecretBlacklistAsync(DeleteSecretBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSecretBlacklistWithOptionsAsync(request, runtime);
        }

        public GetFaceVerifyResponse GetFaceVerifyWithOptions(GetFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["VerifyToken"] = request.VerifyToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFaceVerify",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFaceVerifyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFaceVerifyResponse> GetFaceVerifyWithOptionsAsync(GetFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["VerifyToken"] = request.VerifyToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFaceVerify",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFaceVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetFaceVerifyResponse GetFaceVerify(GetFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFaceVerifyWithOptions(request, runtime);
        }

        public async Task<GetFaceVerifyResponse> GetFaceVerifyAsync(GetFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFaceVerifyWithOptionsAsync(request, runtime);
        }

        public GetSecretAsrDetailResponse GetSecretAsrDetailWithOptions(GetSecretAsrDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallId"] = request.CallId;
            query["CallTime"] = request.CallTime;
            query["PoolKey"] = request.PoolKey;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecretAsrDetail",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecretAsrDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetSecretAsrDetailResponse> GetSecretAsrDetailWithOptionsAsync(GetSecretAsrDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallId"] = request.CallId;
            query["CallTime"] = request.CallTime;
            query["PoolKey"] = request.PoolKey;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecretAsrDetail",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecretAsrDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetSecretAsrDetailResponse GetSecretAsrDetail(GetSecretAsrDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSecretAsrDetailWithOptions(request, runtime);
        }

        public async Task<GetSecretAsrDetailResponse> GetSecretAsrDetailAsync(GetSecretAsrDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSecretAsrDetailWithOptionsAsync(request, runtime);
        }

        public GetSubscriptionDetailResponse GetSubscriptionDetailWithOptions(GetSubscriptionDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            query["SubsId"] = request.SubsId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubscriptionDetail",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubscriptionDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetSubscriptionDetailResponse> GetSubscriptionDetailWithOptionsAsync(GetSubscriptionDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            query["SubsId"] = request.SubsId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubscriptionDetail",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubscriptionDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetSubscriptionDetailResponse GetSubscriptionDetail(GetSubscriptionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSubscriptionDetailWithOptions(request, runtime);
        }

        public async Task<GetSubscriptionDetailResponse> GetSubscriptionDetailAsync(GetSubscriptionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSubscriptionDetailWithOptionsAsync(request, runtime);
        }

        public GetTotalPublicUrlResponse GetTotalPublicUrlWithOptions(GetTotalPublicUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallId"] = request.CallId;
            query["CallTime"] = request.CallTime;
            query["CheckSubs"] = request.CheckSubs;
            query["OwnerId"] = request.OwnerId;
            query["PartnerKey"] = request.PartnerKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTotalPublicUrl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTotalPublicUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetTotalPublicUrlResponse> GetTotalPublicUrlWithOptionsAsync(GetTotalPublicUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallId"] = request.CallId;
            query["CallTime"] = request.CallTime;
            query["CheckSubs"] = request.CheckSubs;
            query["OwnerId"] = request.OwnerId;
            query["PartnerKey"] = request.PartnerKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTotalPublicUrl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTotalPublicUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetTotalPublicUrlResponse GetTotalPublicUrl(GetTotalPublicUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTotalPublicUrlWithOptions(request, runtime);
        }

        public async Task<GetTotalPublicUrlResponse> GetTotalPublicUrlAsync(GetTotalPublicUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTotalPublicUrlWithOptionsAsync(request, runtime);
        }

        public InitFaceVerifyResponse InitFaceVerifyWithOptions(InitFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MetaInfo"] = request.MetaInfo;
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
                Action = "InitFaceVerify",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitFaceVerifyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InitFaceVerifyResponse> InitFaceVerifyWithOptionsAsync(InitFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MetaInfo"] = request.MetaInfo;
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
                Action = "InitFaceVerify",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitFaceVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InitFaceVerifyResponse InitFaceVerify(InitFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitFaceVerifyWithOptions(request, runtime);
        }

        public async Task<InitFaceVerifyResponse> InitFaceVerifyAsync(InitFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitFaceVerifyWithOptionsAsync(request, runtime);
        }

        public LockSecretNoResponse LockSecretNoWithOptions(LockSecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LockSecretNo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<LockSecretNoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<LockSecretNoResponse> LockSecretNoWithOptionsAsync(LockSecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LockSecretNo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<LockSecretNoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public LockSecretNoResponse LockSecretNo(LockSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LockSecretNoWithOptions(request, runtime);
        }

        public async Task<LockSecretNoResponse> LockSecretNoAsync(LockSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LockSecretNoWithOptionsAsync(request, runtime);
        }

        public OperateAxgGroupResponse OperateAxgGroupWithOptions(OperateAxgGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GroupId"] = request.GroupId;
            query["Numbers"] = request.Numbers;
            query["OperateType"] = request.OperateType;
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateAxgGroup",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateAxgGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<OperateAxgGroupResponse> OperateAxgGroupWithOptionsAsync(OperateAxgGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GroupId"] = request.GroupId;
            query["Numbers"] = request.Numbers;
            query["OperateType"] = request.OperateType;
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateAxgGroup",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateAxgGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public OperateAxgGroupResponse OperateAxgGroup(OperateAxgGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateAxgGroupWithOptions(request, runtime);
        }

        public async Task<OperateAxgGroupResponse> OperateAxgGroupAsync(OperateAxgGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateAxgGroupWithOptionsAsync(request, runtime);
        }

        public OperateBlackNoResponse OperateBlackNoWithOptions(OperateBlackNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BlackNo"] = request.BlackNo;
            query["OperateType"] = request.OperateType;
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Tips"] = request.Tips;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateBlackNo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateBlackNoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<OperateBlackNoResponse> OperateBlackNoWithOptionsAsync(OperateBlackNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BlackNo"] = request.BlackNo;
            query["OperateType"] = request.OperateType;
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Tips"] = request.Tips;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateBlackNo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateBlackNoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public OperateBlackNoResponse OperateBlackNo(OperateBlackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateBlackNoWithOptions(request, runtime);
        }

        public async Task<OperateBlackNoResponse> OperateBlackNoAsync(OperateBlackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateBlackNoWithOptionsAsync(request, runtime);
        }

        public QueryCallStatusResponse QueryCallStatusWithOptions(QueryCallStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallNo"] = request.CallNo;
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SubsId"] = request.SubsId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCallStatus",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCallStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryCallStatusResponse> QueryCallStatusWithOptionsAsync(QueryCallStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallNo"] = request.CallNo;
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SubsId"] = request.SubsId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCallStatus",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCallStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryCallStatusResponse QueryCallStatus(QueryCallStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCallStatusWithOptions(request, runtime);
        }

        public async Task<QueryCallStatusResponse> QueryCallStatusAsync(QueryCallStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCallStatusWithOptionsAsync(request, runtime);
        }

        public QueryPhoneNoAByTrackNoResponse QueryPhoneNoAByTrackNoWithOptions(QueryPhoneNoAByTrackNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CabinetNo"] = request.CabinetNo;
            query["OwnerId"] = request.OwnerId;
            query["PhoneNoX"] = request.PhoneNoX;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["trackNo"] = request.TrackNo;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPhoneNoAByTrackNo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPhoneNoAByTrackNoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryPhoneNoAByTrackNoResponse> QueryPhoneNoAByTrackNoWithOptionsAsync(QueryPhoneNoAByTrackNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CabinetNo"] = request.CabinetNo;
            query["OwnerId"] = request.OwnerId;
            query["PhoneNoX"] = request.PhoneNoX;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["trackNo"] = request.TrackNo;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPhoneNoAByTrackNo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPhoneNoAByTrackNoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryPhoneNoAByTrackNoResponse QueryPhoneNoAByTrackNo(QueryPhoneNoAByTrackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPhoneNoAByTrackNoWithOptions(request, runtime);
        }

        public async Task<QueryPhoneNoAByTrackNoResponse> QueryPhoneNoAByTrackNoAsync(QueryPhoneNoAByTrackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPhoneNoAByTrackNoWithOptionsAsync(request, runtime);
        }

        public QueryRecordFileDownloadUrlResponse QueryRecordFileDownloadUrlWithOptions(QueryRecordFileDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallId"] = request.CallId;
            query["CallTime"] = request.CallTime;
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ProductType"] = request.ProductType;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRecordFileDownloadUrl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordFileDownloadUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryRecordFileDownloadUrlResponse> QueryRecordFileDownloadUrlWithOptionsAsync(QueryRecordFileDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallId"] = request.CallId;
            query["CallTime"] = request.CallTime;
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ProductType"] = request.ProductType;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRecordFileDownloadUrl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordFileDownloadUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryRecordFileDownloadUrlResponse QueryRecordFileDownloadUrl(QueryRecordFileDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRecordFileDownloadUrlWithOptions(request, runtime);
        }

        public async Task<QueryRecordFileDownloadUrlResponse> QueryRecordFileDownloadUrlAsync(QueryRecordFileDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRecordFileDownloadUrlWithOptionsAsync(request, runtime);
        }

        public QuerySecretNoDetailResponse QuerySecretNoDetailWithOptions(QuerySecretNoDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySecretNoDetail",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySecretNoDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QuerySecretNoDetailResponse> QuerySecretNoDetailWithOptionsAsync(QuerySecretNoDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySecretNoDetail",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySecretNoDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QuerySecretNoDetailResponse QuerySecretNoDetail(QuerySecretNoDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySecretNoDetailWithOptions(request, runtime);
        }

        public async Task<QuerySecretNoDetailResponse> QuerySecretNoDetailAsync(QuerySecretNoDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySecretNoDetailWithOptionsAsync(request, runtime);
        }

        public QuerySecretNoRemainResponse QuerySecretNoRemainWithOptions(QuerySecretNoRemainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["City"] = request.City;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            query["SpecId"] = request.SpecId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySecretNoRemain",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySecretNoRemainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QuerySecretNoRemainResponse> QuerySecretNoRemainWithOptionsAsync(QuerySecretNoRemainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["City"] = request.City;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            query["SpecId"] = request.SpecId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySecretNoRemain",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySecretNoRemainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QuerySecretNoRemainResponse QuerySecretNoRemain(QuerySecretNoRemainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySecretNoRemainWithOptions(request, runtime);
        }

        public async Task<QuerySecretNoRemainResponse> QuerySecretNoRemainAsync(QuerySecretNoRemainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySecretNoRemainWithOptionsAsync(request, runtime);
        }

        public QuerySubsIdResponse QuerySubsIdWithOptions(QuerySubsIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["PhoneNoX"] = request.PhoneNoX;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySubsId",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySubsIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QuerySubsIdResponse> QuerySubsIdWithOptionsAsync(QuerySubsIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["PhoneNoX"] = request.PhoneNoX;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySubsId",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySubsIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QuerySubsIdResponse QuerySubsId(QuerySubsIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySubsIdWithOptions(request, runtime);
        }

        public async Task<QuerySubsIdResponse> QuerySubsIdAsync(QuerySubsIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySubsIdWithOptionsAsync(request, runtime);
        }

        public QuerySubscriptionDetailResponse QuerySubscriptionDetailWithOptions(QuerySubscriptionDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["PhoneNoX"] = request.PhoneNoX;
            query["PoolKey"] = request.PoolKey;
            query["ProductType"] = request.ProductType;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SubsId"] = request.SubsId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySubscriptionDetail",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySubscriptionDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QuerySubscriptionDetailResponse> QuerySubscriptionDetailWithOptionsAsync(QuerySubscriptionDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["PhoneNoX"] = request.PhoneNoX;
            query["PoolKey"] = request.PoolKey;
            query["ProductType"] = request.ProductType;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SubsId"] = request.SubsId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySubscriptionDetail",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySubscriptionDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QuerySubscriptionDetailResponse QuerySubscriptionDetail(QuerySubscriptionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySubscriptionDetailWithOptions(request, runtime);
        }

        public async Task<QuerySubscriptionDetailResponse> QuerySubscriptionDetailAsync(QuerySubscriptionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySubscriptionDetailWithOptionsAsync(request, runtime);
        }

        public ReleaseSecretNoResponse ReleaseSecretNoWithOptions(ReleaseSecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseSecretNo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseSecretNoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReleaseSecretNoResponse> ReleaseSecretNoWithOptionsAsync(ReleaseSecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseSecretNo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseSecretNoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReleaseSecretNoResponse ReleaseSecretNo(ReleaseSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseSecretNoWithOptions(request, runtime);
        }

        public async Task<ReleaseSecretNoResponse> ReleaseSecretNoAsync(ReleaseSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseSecretNoWithOptionsAsync(request, runtime);
        }

        public UnbindSubscriptionResponse UnbindSubscriptionWithOptions(UnbindSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ProductType"] = request.ProductType;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            query["SubsId"] = request.SubsId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindSubscription",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnbindSubscriptionResponse> UnbindSubscriptionWithOptionsAsync(UnbindSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ProductType"] = request.ProductType;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            query["SubsId"] = request.SubsId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindSubscription",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnbindSubscriptionResponse UnbindSubscription(UnbindSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindSubscriptionWithOptions(request, runtime);
        }

        public async Task<UnbindSubscriptionResponse> UnbindSubscriptionAsync(UnbindSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindSubscriptionWithOptionsAsync(request, runtime);
        }

        public UnlockSecretNoResponse UnlockSecretNoWithOptions(UnlockSecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnlockSecretNo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnlockSecretNoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnlockSecretNoResponse> UnlockSecretNoWithOptionsAsync(UnlockSecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnlockSecretNo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnlockSecretNoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnlockSecretNoResponse UnlockSecretNo(UnlockSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnlockSecretNoWithOptions(request, runtime);
        }

        public async Task<UnlockSecretNoResponse> UnlockSecretNoAsync(UnlockSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnlockSecretNoWithOptionsAsync(request, runtime);
        }

        public UpdateDefaultBResponse UpdateDefaultBWithOptions(UpdateDefaultBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["PhoneNo"] = request.PhoneNo;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            query["SubsId"] = request.SubsId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDefaultB",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDefaultBResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateDefaultBResponse> UpdateDefaultBWithOptionsAsync(UpdateDefaultBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["PhoneNo"] = request.PhoneNo;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            query["SubsId"] = request.SubsId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDefaultB",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDefaultBResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateDefaultBResponse UpdateDefaultB(UpdateDefaultBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDefaultBWithOptions(request, runtime);
        }

        public async Task<UpdateDefaultBResponse> UpdateDefaultBAsync(UpdateDefaultBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDefaultBWithOptionsAsync(request, runtime);
        }

        public UpdatePhoneNumberResponse UpdatePhoneNumberWithOptions(UpdatePhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BindToken"] = request.BindToken;
            query["NewPhoneNo"] = request.NewPhoneNo;
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            query["SubsId"] = request.SubsId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePhoneNumber",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePhoneNumberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdatePhoneNumberResponse> UpdatePhoneNumberWithOptionsAsync(UpdatePhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BindToken"] = request.BindToken;
            query["NewPhoneNo"] = request.NewPhoneNo;
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            query["SubsId"] = request.SubsId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePhoneNumber",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePhoneNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdatePhoneNumberResponse UpdatePhoneNumber(UpdatePhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePhoneNumberWithOptions(request, runtime);
        }

        public async Task<UpdatePhoneNumberResponse> UpdatePhoneNumberAsync(UpdatePhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePhoneNumberWithOptionsAsync(request, runtime);
        }

        public UpdatePhoneSwitchResponse UpdatePhoneSwitchWithOptions(UpdatePhoneSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            query["SubsId"] = request.SubsId;
            query["SwitchStatus"] = request.SwitchStatus;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePhoneSwitch",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePhoneSwitchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdatePhoneSwitchResponse> UpdatePhoneSwitchWithOptionsAsync(UpdatePhoneSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["PoolKey"] = request.PoolKey;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SecretNo"] = request.SecretNo;
            query["SubsId"] = request.SubsId;
            query["SwitchStatus"] = request.SwitchStatus;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePhoneSwitch",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePhoneSwitchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdatePhoneSwitchResponse UpdatePhoneSwitch(UpdatePhoneSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePhoneSwitchWithOptions(request, runtime);
        }

        public async Task<UpdatePhoneSwitchResponse> UpdatePhoneSwitchAsync(UpdatePhoneSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePhoneSwitchWithOptionsAsync(request, runtime);
        }

        public UpdateSubscriptionResponse UpdateSubscriptionWithOptions(UpdateSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ASRModelId"] = request.ASRModelId;
            query["ASRStatus"] = request.ASRStatus;
            query["CallDisplayType"] = request.CallDisplayType;
            query["CallRestrict"] = request.CallRestrict;
            query["Expiration"] = request.Expiration;
            query["GroupId"] = request.GroupId;
            query["IsRecordingEnabled"] = request.IsRecordingEnabled;
            query["OperateType"] = request.OperateType;
            query["OutId"] = request.OutId;
            query["OwnerId"] = request.OwnerId;
            query["PhoneNoA"] = request.PhoneNoA;
            query["PhoneNoB"] = request.PhoneNoB;
            query["PhoneNoX"] = request.PhoneNoX;
            query["PoolKey"] = request.PoolKey;
            query["ProductType"] = request.ProductType;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RingConfig"] = request.RingConfig;
            query["SubsId"] = request.SubsId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSubscription",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateSubscriptionResponse> UpdateSubscriptionWithOptionsAsync(UpdateSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ASRModelId"] = request.ASRModelId;
            query["ASRStatus"] = request.ASRStatus;
            query["CallDisplayType"] = request.CallDisplayType;
            query["CallRestrict"] = request.CallRestrict;
            query["Expiration"] = request.Expiration;
            query["GroupId"] = request.GroupId;
            query["IsRecordingEnabled"] = request.IsRecordingEnabled;
            query["OperateType"] = request.OperateType;
            query["OutId"] = request.OutId;
            query["OwnerId"] = request.OwnerId;
            query["PhoneNoA"] = request.PhoneNoA;
            query["PhoneNoB"] = request.PhoneNoB;
            query["PhoneNoX"] = request.PhoneNoX;
            query["PoolKey"] = request.PoolKey;
            query["ProductType"] = request.ProductType;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RingConfig"] = request.RingConfig;
            query["SubsId"] = request.SubsId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSubscription",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateSubscriptionResponse UpdateSubscription(UpdateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSubscriptionWithOptions(request, runtime);
        }

        public async Task<UpdateSubscriptionResponse> UpdateSubscriptionAsync(UpdateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSubscriptionWithOptionsAsync(request, runtime);
        }

    }
}
