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
            this._signatureAlgorithm = "v2";
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

        /**
         * @summary Adds a tracking number for a private number in the AXN binding.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddAxnTrackNoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddAxnTrackNoResponse
         */
        public AddAxnTrackNoResponse AddAxnTrackNoWithOptions(AddAxnTrackNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoX))
            {
                query["PhoneNoX"] = request.PhoneNoX;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubsId))
            {
                query["SubsId"] = request.SubsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrackNo))
            {
                query["trackNo"] = request.TrackNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAxnTrackNoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds a tracking number for a private number in the AXN binding.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddAxnTrackNoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddAxnTrackNoResponse
         */
        public async Task<AddAxnTrackNoResponse> AddAxnTrackNoWithOptionsAsync(AddAxnTrackNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoX))
            {
                query["PhoneNoX"] = request.PhoneNoX;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubsId))
            {
                query["SubsId"] = request.SubsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrackNo))
            {
                query["trackNo"] = request.TrackNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAxnTrackNoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds a tracking number for a private number in the AXN binding.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddAxnTrackNoRequest
         * @return AddAxnTrackNoResponse
         */
        public AddAxnTrackNoResponse AddAxnTrackNo(AddAxnTrackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAxnTrackNoWithOptions(request, runtime);
        }

        /**
         * @summary Adds a tracking number for a private number in the AXN binding.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddAxnTrackNoRequest
         * @return AddAxnTrackNoResponse
         */
        public async Task<AddAxnTrackNoResponse> AddAxnTrackNoAsync(AddAxnTrackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAxnTrackNoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds a blacklist.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddSecretBlacklistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddSecretBlacklistResponse
         */
        public AddSecretBlacklistResponse AddSecretBlacklistWithOptions(AddSecretBlacklistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackNo))
            {
                query["BlackNo"] = request.BlackNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackType))
            {
                query["BlackType"] = request.BlackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WayControl))
            {
                query["WayControl"] = request.WayControl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSecretBlacklistResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds a blacklist.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddSecretBlacklistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddSecretBlacklistResponse
         */
        public async Task<AddSecretBlacklistResponse> AddSecretBlacklistWithOptionsAsync(AddSecretBlacklistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackNo))
            {
                query["BlackNo"] = request.BlackNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackType))
            {
                query["BlackType"] = request.BlackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WayControl))
            {
                query["WayControl"] = request.WayControl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSecretBlacklistResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds a blacklist.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddSecretBlacklistRequest
         * @return AddSecretBlacklistResponse
         */
        public AddSecretBlacklistResponse AddSecretBlacklist(AddSecretBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSecretBlacklistWithOptions(request, runtime);
        }

        /**
         * @summary Adds a blacklist.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddSecretBlacklistRequest
         * @return AddSecretBlacklistResponse
         */
        public async Task<AddSecretBlacklistResponse> AddSecretBlacklistAsync(AddSecretBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSecretBlacklistWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds an AXB binding.
         *
         * @description Before you add an AXB binding, we recommend that you specify role A and role B in the AXB device certificate (ProductKey, DeviceName, and DeviceSecret) in your business scenario. For example, in a taxi-hailing scenario, role A is the passenger and role B is the driver.
         * ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request BindAxbRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindAxbResponse
         */
        public BindAxbResponse BindAxbWithOptions(BindAxbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASRModelId))
            {
                query["ASRModelId"] = request.ASRModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASRStatus))
            {
                query["ASRStatus"] = request.ASRStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallDisplayType))
            {
                query["CallDisplayType"] = request.CallDisplayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallRestrict))
            {
                query["CallRestrict"] = request.CallRestrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallTimeout))
            {
                query["CallTimeout"] = request.CallTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtmfConfig))
            {
                query["DtmfConfig"] = request.DtmfConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectCity))
            {
                query["ExpectCity"] = request.ExpectCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expiration))
            {
                query["Expiration"] = request.Expiration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecordingEnabled))
            {
                query["IsRecordingEnabled"] = request.IsRecordingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                query["OutOrderId"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoA))
            {
                query["PhoneNoA"] = request.PhoneNoA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoB))
            {
                query["PhoneNoB"] = request.PhoneNoB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoX))
            {
                query["PhoneNoX"] = request.PhoneNoX;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RingConfig))
            {
                query["RingConfig"] = request.RingConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAxbResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds an AXB binding.
         *
         * @description Before you add an AXB binding, we recommend that you specify role A and role B in the AXB device certificate (ProductKey, DeviceName, and DeviceSecret) in your business scenario. For example, in a taxi-hailing scenario, role A is the passenger and role B is the driver.
         * ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request BindAxbRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindAxbResponse
         */
        public async Task<BindAxbResponse> BindAxbWithOptionsAsync(BindAxbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASRModelId))
            {
                query["ASRModelId"] = request.ASRModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASRStatus))
            {
                query["ASRStatus"] = request.ASRStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallDisplayType))
            {
                query["CallDisplayType"] = request.CallDisplayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallRestrict))
            {
                query["CallRestrict"] = request.CallRestrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallTimeout))
            {
                query["CallTimeout"] = request.CallTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtmfConfig))
            {
                query["DtmfConfig"] = request.DtmfConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectCity))
            {
                query["ExpectCity"] = request.ExpectCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expiration))
            {
                query["Expiration"] = request.Expiration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecordingEnabled))
            {
                query["IsRecordingEnabled"] = request.IsRecordingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                query["OutOrderId"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoA))
            {
                query["PhoneNoA"] = request.PhoneNoA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoB))
            {
                query["PhoneNoB"] = request.PhoneNoB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoX))
            {
                query["PhoneNoX"] = request.PhoneNoX;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RingConfig))
            {
                query["RingConfig"] = request.RingConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAxbResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds an AXB binding.
         *
         * @description Before you add an AXB binding, we recommend that you specify role A and role B in the AXB device certificate (ProductKey, DeviceName, and DeviceSecret) in your business scenario. For example, in a taxi-hailing scenario, role A is the passenger and role B is the driver.
         * ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request BindAxbRequest
         * @return BindAxbResponse
         */
        public BindAxbResponse BindAxb(BindAxbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAxbWithOptions(request, runtime);
        }

        /**
         * @summary Adds an AXB binding.
         *
         * @description Before you add an AXB binding, we recommend that you specify role A and role B in the AXB device certificate (ProductKey, DeviceName, and DeviceSecret) in your business scenario. For example, in a taxi-hailing scenario, role A is the passenger and role B is the driver.
         * ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request BindAxbRequest
         * @return BindAxbResponse
         */
        public async Task<BindAxbResponse> BindAxbAsync(BindAxbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAxbWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds an AXG binding.
         *
         * @description An AXG protection solution can be configured to meet the requirements for grading users, limiting the scope of calls, and restricting order snatching. The letter G represents a phone number group to which you can add phone numbers as needed.
         * ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request BindAxgRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindAxgResponse
         */
        public BindAxgResponse BindAxgWithOptions(BindAxgRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASRModelId))
            {
                query["ASRModelId"] = request.ASRModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASRStatus))
            {
                query["ASRStatus"] = request.ASRStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallDisplayType))
            {
                query["CallDisplayType"] = request.CallDisplayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallRestrict))
            {
                query["CallRestrict"] = request.CallRestrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectCity))
            {
                query["ExpectCity"] = request.ExpectCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expiration))
            {
                query["Expiration"] = request.Expiration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecordingEnabled))
            {
                query["IsRecordingEnabled"] = request.IsRecordingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                query["OutOrderId"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoA))
            {
                query["PhoneNoA"] = request.PhoneNoA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoB))
            {
                query["PhoneNoB"] = request.PhoneNoB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoX))
            {
                query["PhoneNoX"] = request.PhoneNoX;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RingConfig))
            {
                query["RingConfig"] = request.RingConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAxgResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds an AXG binding.
         *
         * @description An AXG protection solution can be configured to meet the requirements for grading users, limiting the scope of calls, and restricting order snatching. The letter G represents a phone number group to which you can add phone numbers as needed.
         * ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request BindAxgRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindAxgResponse
         */
        public async Task<BindAxgResponse> BindAxgWithOptionsAsync(BindAxgRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASRModelId))
            {
                query["ASRModelId"] = request.ASRModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASRStatus))
            {
                query["ASRStatus"] = request.ASRStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallDisplayType))
            {
                query["CallDisplayType"] = request.CallDisplayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallRestrict))
            {
                query["CallRestrict"] = request.CallRestrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectCity))
            {
                query["ExpectCity"] = request.ExpectCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expiration))
            {
                query["Expiration"] = request.Expiration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecordingEnabled))
            {
                query["IsRecordingEnabled"] = request.IsRecordingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                query["OutOrderId"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoA))
            {
                query["PhoneNoA"] = request.PhoneNoA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoB))
            {
                query["PhoneNoB"] = request.PhoneNoB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoX))
            {
                query["PhoneNoX"] = request.PhoneNoX;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RingConfig))
            {
                query["RingConfig"] = request.RingConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAxgResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds an AXG binding.
         *
         * @description An AXG protection solution can be configured to meet the requirements for grading users, limiting the scope of calls, and restricting order snatching. The letter G represents a phone number group to which you can add phone numbers as needed.
         * ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request BindAxgRequest
         * @return BindAxgResponse
         */
        public BindAxgResponse BindAxg(BindAxgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAxgWithOptions(request, runtime);
        }

        /**
         * @summary Adds an AXG binding.
         *
         * @description An AXG protection solution can be configured to meet the requirements for grading users, limiting the scope of calls, and restricting order snatching. The letter G represents a phone number group to which you can add phone numbers as needed.
         * ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request BindAxgRequest
         * @return BindAxgResponse
         */
        public async Task<BindAxgResponse> BindAxgAsync(BindAxgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAxgWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds an AXN binding.
         *
         * @description >  An AXN private number is a dedicated private number assigned to phone number A. When an N-side number is used to call phone number X, the call is forwarded to phone number A.
         *
         * @param request BindAxnRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindAxnResponse
         */
        public BindAxnResponse BindAxnWithOptions(BindAxnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASRModelId))
            {
                query["ASRModelId"] = request.ASRModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASRStatus))
            {
                query["ASRStatus"] = request.ASRStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallDisplayType))
            {
                query["CallDisplayType"] = request.CallDisplayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallRestrict))
            {
                query["CallRestrict"] = request.CallRestrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallTimeout))
            {
                query["CallTimeout"] = request.CallTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectCity))
            {
                query["ExpectCity"] = request.ExpectCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expiration))
            {
                query["Expiration"] = request.Expiration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecordingEnabled))
            {
                query["IsRecordingEnabled"] = request.IsRecordingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoType))
            {
                query["NoType"] = request.NoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                query["OutOrderId"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoA))
            {
                query["PhoneNoA"] = request.PhoneNoA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoB))
            {
                query["PhoneNoB"] = request.PhoneNoB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoX))
            {
                query["PhoneNoX"] = request.PhoneNoX;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RingConfig))
            {
                query["RingConfig"] = request.RingConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAxnResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds an AXN binding.
         *
         * @description >  An AXN private number is a dedicated private number assigned to phone number A. When an N-side number is used to call phone number X, the call is forwarded to phone number A.
         *
         * @param request BindAxnRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindAxnResponse
         */
        public async Task<BindAxnResponse> BindAxnWithOptionsAsync(BindAxnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASRModelId))
            {
                query["ASRModelId"] = request.ASRModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASRStatus))
            {
                query["ASRStatus"] = request.ASRStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallDisplayType))
            {
                query["CallDisplayType"] = request.CallDisplayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallRestrict))
            {
                query["CallRestrict"] = request.CallRestrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallTimeout))
            {
                query["CallTimeout"] = request.CallTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectCity))
            {
                query["ExpectCity"] = request.ExpectCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expiration))
            {
                query["Expiration"] = request.Expiration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecordingEnabled))
            {
                query["IsRecordingEnabled"] = request.IsRecordingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoType))
            {
                query["NoType"] = request.NoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                query["OutOrderId"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoA))
            {
                query["PhoneNoA"] = request.PhoneNoA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoB))
            {
                query["PhoneNoB"] = request.PhoneNoB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoX))
            {
                query["PhoneNoX"] = request.PhoneNoX;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RingConfig))
            {
                query["RingConfig"] = request.RingConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAxnResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds an AXN binding.
         *
         * @description >  An AXN private number is a dedicated private number assigned to phone number A. When an N-side number is used to call phone number X, the call is forwarded to phone number A.
         *
         * @param request BindAxnRequest
         * @return BindAxnResponse
         */
        public BindAxnResponse BindAxn(BindAxnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAxnWithOptions(request, runtime);
        }

        /**
         * @summary Adds an AXN binding.
         *
         * @description >  An AXN private number is a dedicated private number assigned to phone number A. When an N-side number is used to call phone number X, the call is forwarded to phone number A.
         *
         * @param request BindAxnRequest
         * @return BindAxnResponse
         */
        public async Task<BindAxnResponse> BindAxnAsync(BindAxnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAxnWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds an AXN extension binding.
         *
         * @description Before you add an AXN extension binding, confirm phone number A and phone number N in the business scenario. Phone number A belongs to a customer, and phone number X is the private number assigned to the customer. When any other phone number is used to call phone number X and the extension, the call is transferred to phone number A. When phone number A is used to call phone number X, the call is transferred to the default phone number B that is specified during the phone number binding.
         * ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request BindAxnExtensionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindAxnExtensionResponse
         */
        public BindAxnExtensionResponse BindAxnExtensionWithOptions(BindAxnExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASRModelId))
            {
                query["ASRModelId"] = request.ASRModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASRStatus))
            {
                query["ASRStatus"] = request.ASRStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallDisplayType))
            {
                query["CallDisplayType"] = request.CallDisplayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallRestrict))
            {
                query["CallRestrict"] = request.CallRestrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectCity))
            {
                query["ExpectCity"] = request.ExpectCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expiration))
            {
                query["Expiration"] = request.Expiration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                query["Extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                query["Extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecordingEnabled))
            {
                query["IsRecordingEnabled"] = request.IsRecordingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                query["OutOrderId"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoA))
            {
                query["PhoneNoA"] = request.PhoneNoA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoB))
            {
                query["PhoneNoB"] = request.PhoneNoB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoX))
            {
                query["PhoneNoX"] = request.PhoneNoX;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RingConfig))
            {
                query["RingConfig"] = request.RingConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAxnExtensionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds an AXN extension binding.
         *
         * @description Before you add an AXN extension binding, confirm phone number A and phone number N in the business scenario. Phone number A belongs to a customer, and phone number X is the private number assigned to the customer. When any other phone number is used to call phone number X and the extension, the call is transferred to phone number A. When phone number A is used to call phone number X, the call is transferred to the default phone number B that is specified during the phone number binding.
         * ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request BindAxnExtensionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindAxnExtensionResponse
         */
        public async Task<BindAxnExtensionResponse> BindAxnExtensionWithOptionsAsync(BindAxnExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASRModelId))
            {
                query["ASRModelId"] = request.ASRModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASRStatus))
            {
                query["ASRStatus"] = request.ASRStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallDisplayType))
            {
                query["CallDisplayType"] = request.CallDisplayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallRestrict))
            {
                query["CallRestrict"] = request.CallRestrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectCity))
            {
                query["ExpectCity"] = request.ExpectCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expiration))
            {
                query["Expiration"] = request.Expiration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                query["Extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                query["Extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecordingEnabled))
            {
                query["IsRecordingEnabled"] = request.IsRecordingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                query["OutOrderId"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoA))
            {
                query["PhoneNoA"] = request.PhoneNoA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoB))
            {
                query["PhoneNoB"] = request.PhoneNoB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoX))
            {
                query["PhoneNoX"] = request.PhoneNoX;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RingConfig))
            {
                query["RingConfig"] = request.RingConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAxnExtensionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds an AXN extension binding.
         *
         * @description Before you add an AXN extension binding, confirm phone number A and phone number N in the business scenario. Phone number A belongs to a customer, and phone number X is the private number assigned to the customer. When any other phone number is used to call phone number X and the extension, the call is transferred to phone number A. When phone number A is used to call phone number X, the call is transferred to the default phone number B that is specified during the phone number binding.
         * ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request BindAxnExtensionRequest
         * @return BindAxnExtensionResponse
         */
        public BindAxnExtensionResponse BindAxnExtension(BindAxnExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAxnExtensionWithOptions(request, runtime);
        }

        /**
         * @summary Adds an AXN extension binding.
         *
         * @description Before you add an AXN extension binding, confirm phone number A and phone number N in the business scenario. Phone number A belongs to a customer, and phone number X is the private number assigned to the customer. When any other phone number is used to call phone number X and the extension, the call is transferred to phone number A. When phone number A is used to call phone number X, the call is transferred to the default phone number B that is specified during the phone number binding.
         * ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request BindAxnExtensionRequest
         * @return BindAxnExtensionResponse
         */
        public async Task<BindAxnExtensionResponse> BindAxnExtensionAsync(BindAxnExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAxnExtensionWithOptionsAsync(request, runtime);
        }

        /**
         * @param tmpReq BindBatchAxgRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindBatchAxgResponse
         */
        public BindBatchAxgResponse BindBatchAxgWithOptions(BindBatchAxgRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BindBatchAxgShrinkRequest request = new BindBatchAxgShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AxgBindList))
            {
                request.AxgBindListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AxgBindList, "AxgBindList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AxgBindListShrink))
            {
                query["AxgBindList"] = request.AxgBindListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindBatchAxg",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindBatchAxgResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param tmpReq BindBatchAxgRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindBatchAxgResponse
         */
        public async Task<BindBatchAxgResponse> BindBatchAxgWithOptionsAsync(BindBatchAxgRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BindBatchAxgShrinkRequest request = new BindBatchAxgShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AxgBindList))
            {
                request.AxgBindListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AxgBindList, "AxgBindList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AxgBindListShrink))
            {
                query["AxgBindList"] = request.AxgBindListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindBatchAxg",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindBatchAxgResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request BindBatchAxgRequest
         * @return BindBatchAxgResponse
         */
        public BindBatchAxgResponse BindBatchAxg(BindBatchAxgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindBatchAxgWithOptions(request, runtime);
        }

        /**
         * @param request BindBatchAxgRequest
         * @return BindBatchAxgResponse
         */
        public async Task<BindBatchAxgResponse> BindBatchAxgAsync(BindBatchAxgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindBatchAxgWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Purchases a phone number.
         *
         * @description *   After you create a phone number pool in the Phone Number Protection console, the phone number pool is empty by default. You must purchase phone numbers and add them to the phone number pool.
         * *   Before you call this operation, make sure that you are familiar with the [pricing](https://help.aliyun.com/document_detail/59825.html) of Phone Number Protection.
         * *   When purchasing a phone number, specify the home location. If no sufficient phone numbers are available for purchase in the home location, the purchase of the phone number fails. Before you call this operation to purchase a phone number, check the quantity of phone numbers available for purchase by using the [QuerySecretNoRemain](https://help.aliyun.com/document_detail/111699.html) operation.
         * *   The account used to purchase a phone number must be an enterprise account that has passed real-name verification. For more information about how to perform real-name verification, see [Enterprise verification FAQs](https://help.aliyun.com/document_detail/37172.html).
         *
         * @param request BuySecretNoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BuySecretNoResponse
         */
        public BuySecretNoResponse BuySecretNoWithOptions(BuySecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayPool))
            {
                query["DisplayPool"] = request.DisplayPool;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretNo))
            {
                query["SecretNo"] = request.SecretNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecId))
            {
                query["SpecId"] = request.SpecId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BuySecretNoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Purchases a phone number.
         *
         * @description *   After you create a phone number pool in the Phone Number Protection console, the phone number pool is empty by default. You must purchase phone numbers and add them to the phone number pool.
         * *   Before you call this operation, make sure that you are familiar with the [pricing](https://help.aliyun.com/document_detail/59825.html) of Phone Number Protection.
         * *   When purchasing a phone number, specify the home location. If no sufficient phone numbers are available for purchase in the home location, the purchase of the phone number fails. Before you call this operation to purchase a phone number, check the quantity of phone numbers available for purchase by using the [QuerySecretNoRemain](https://help.aliyun.com/document_detail/111699.html) operation.
         * *   The account used to purchase a phone number must be an enterprise account that has passed real-name verification. For more information about how to perform real-name verification, see [Enterprise verification FAQs](https://help.aliyun.com/document_detail/37172.html).
         *
         * @param request BuySecretNoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BuySecretNoResponse
         */
        public async Task<BuySecretNoResponse> BuySecretNoWithOptionsAsync(BuySecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayPool))
            {
                query["DisplayPool"] = request.DisplayPool;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretNo))
            {
                query["SecretNo"] = request.SecretNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecId))
            {
                query["SpecId"] = request.SpecId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BuySecretNoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Purchases a phone number.
         *
         * @description *   After you create a phone number pool in the Phone Number Protection console, the phone number pool is empty by default. You must purchase phone numbers and add them to the phone number pool.
         * *   Before you call this operation, make sure that you are familiar with the [pricing](https://help.aliyun.com/document_detail/59825.html) of Phone Number Protection.
         * *   When purchasing a phone number, specify the home location. If no sufficient phone numbers are available for purchase in the home location, the purchase of the phone number fails. Before you call this operation to purchase a phone number, check the quantity of phone numbers available for purchase by using the [QuerySecretNoRemain](https://help.aliyun.com/document_detail/111699.html) operation.
         * *   The account used to purchase a phone number must be an enterprise account that has passed real-name verification. For more information about how to perform real-name verification, see [Enterprise verification FAQs](https://help.aliyun.com/document_detail/37172.html).
         *
         * @param request BuySecretNoRequest
         * @return BuySecretNoResponse
         */
        public BuySecretNoResponse BuySecretNo(BuySecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BuySecretNoWithOptions(request, runtime);
        }

        /**
         * @summary Purchases a phone number.
         *
         * @description *   After you create a phone number pool in the Phone Number Protection console, the phone number pool is empty by default. You must purchase phone numbers and add them to the phone number pool.
         * *   Before you call this operation, make sure that you are familiar with the [pricing](https://help.aliyun.com/document_detail/59825.html) of Phone Number Protection.
         * *   When purchasing a phone number, specify the home location. If no sufficient phone numbers are available for purchase in the home location, the purchase of the phone number fails. Before you call this operation to purchase a phone number, check the quantity of phone numbers available for purchase by using the [QuerySecretNoRemain](https://help.aliyun.com/document_detail/111699.html) operation.
         * *   The account used to purchase a phone number must be an enterprise account that has passed real-name verification. For more information about how to perform real-name verification, see [Enterprise verification FAQs](https://help.aliyun.com/document_detail/37172.html).
         *
         * @param request BuySecretNoRequest
         * @return BuySecretNoResponse
         */
        public async Task<BuySecretNoResponse> BuySecretNoAsync(BuySecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BuySecretNoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Cancels a door-to-door delivery order.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CancelPickUpWaybillRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelPickUpWaybillResponse
         */
        public CancelPickUpWaybillResponse CancelPickUpWaybillWithOptions(CancelPickUpWaybillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CancelDesc))
            {
                query["CancelDesc"] = request.CancelDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderCode))
            {
                query["OuterOrderCode"] = request.OuterOrderCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelPickUpWaybillResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Cancels a door-to-door delivery order.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CancelPickUpWaybillRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelPickUpWaybillResponse
         */
        public async Task<CancelPickUpWaybillResponse> CancelPickUpWaybillWithOptionsAsync(CancelPickUpWaybillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CancelDesc))
            {
                query["CancelDesc"] = request.CancelDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderCode))
            {
                query["OuterOrderCode"] = request.OuterOrderCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelPickUpWaybillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Cancels a door-to-door delivery order.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CancelPickUpWaybillRequest
         * @return CancelPickUpWaybillResponse
         */
        public CancelPickUpWaybillResponse CancelPickUpWaybill(CancelPickUpWaybillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelPickUpWaybillWithOptions(request, runtime);
        }

        /**
         * @summary Cancels a door-to-door delivery order.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CancelPickUpWaybillRequest
         * @return CancelPickUpWaybillResponse
         */
        public async Task<CancelPickUpWaybillResponse> CancelPickUpWaybillAsync(CancelPickUpWaybillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelPickUpWaybillWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates number group G.
         *
         * @description Before you add an AXG binding, you must purchase phone number X, create number group G, and then add phone numbers to number group G. If you do not add phone numbers to number group G after you create number group G, you can call the [OperateAxgGroup](https://help.aliyun.com/document_detail/110252.htm) operation to add phone numbers to number group G.
         * >  Up to 2,000 number groups G can be added for a single phone number pool.
         *
         * @param request CreateAxgGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAxgGroupResponse
         */
        public CreateAxgGroupResponse CreateAxgGroupWithOptions(CreateAxgGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Numbers))
            {
                query["Numbers"] = request.Numbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAxgGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates number group G.
         *
         * @description Before you add an AXG binding, you must purchase phone number X, create number group G, and then add phone numbers to number group G. If you do not add phone numbers to number group G after you create number group G, you can call the [OperateAxgGroup](https://help.aliyun.com/document_detail/110252.htm) operation to add phone numbers to number group G.
         * >  Up to 2,000 number groups G can be added for a single phone number pool.
         *
         * @param request CreateAxgGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAxgGroupResponse
         */
        public async Task<CreateAxgGroupResponse> CreateAxgGroupWithOptionsAsync(CreateAxgGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Numbers))
            {
                query["Numbers"] = request.Numbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAxgGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates number group G.
         *
         * @description Before you add an AXG binding, you must purchase phone number X, create number group G, and then add phone numbers to number group G. If you do not add phone numbers to number group G after you create number group G, you can call the [OperateAxgGroup](https://help.aliyun.com/document_detail/110252.htm) operation to add phone numbers to number group G.
         * >  Up to 2,000 number groups G can be added for a single phone number pool.
         *
         * @param request CreateAxgGroupRequest
         * @return CreateAxgGroupResponse
         */
        public CreateAxgGroupResponse CreateAxgGroup(CreateAxgGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAxgGroupWithOptions(request, runtime);
        }

        /**
         * @summary Creates number group G.
         *
         * @description Before you add an AXG binding, you must purchase phone number X, create number group G, and then add phone numbers to number group G. If you do not add phone numbers to number group G after you create number group G, you can call the [OperateAxgGroup](https://help.aliyun.com/document_detail/110252.htm) operation to add phone numbers to number group G.
         * >  Up to 2,000 number groups G can be added for a single phone number pool.
         *
         * @param request CreateAxgGroupRequest
         * @return CreateAxgGroupResponse
         */
        public async Task<CreateAxgGroupResponse> CreateAxgGroupAsync(CreateAxgGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAxgGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a door-to-door delivery order.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param tmpReq CreatePickUpWaybillRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePickUpWaybillResponse
         */
        public CreatePickUpWaybillResponse CreatePickUpWaybillWithOptions(CreatePickUpWaybillRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePickUpWaybillShrinkRequest request = new CreatePickUpWaybillShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConsigneeAddress))
            {
                request.ConsigneeAddressShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConsigneeAddress, "ConsigneeAddress", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GoodsInfos))
            {
                request.GoodsInfosShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GoodsInfos, "GoodsInfos", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SendAddress))
            {
                request.SendAddressShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SendAddress, "SendAddress", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppointGotEndTime))
            {
                query["AppointGotEndTime"] = request.AppointGotEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppointGotStartTime))
            {
                query["AppointGotStartTime"] = request.AppointGotStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsigneeAddressShrink))
            {
                query["ConsigneeAddress"] = request.ConsigneeAddressShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsigneeMobile))
            {
                query["ConsigneeMobile"] = request.ConsigneeMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsigneeName))
            {
                query["ConsigneeName"] = request.ConsigneeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsigneePhone))
            {
                query["ConsigneePhone"] = request.ConsigneePhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpCode))
            {
                query["CpCode"] = request.CpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsInfosShrink))
            {
                query["GoodsInfos"] = request.GoodsInfosShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderChannels))
            {
                query["OrderChannels"] = request.OrderChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderCode))
            {
                query["OuterOrderCode"] = request.OuterOrderCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendAddressShrink))
            {
                query["SendAddress"] = request.SendAddressShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendMobile))
            {
                query["SendMobile"] = request.SendMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendName))
            {
                query["SendName"] = request.SendName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendPhone))
            {
                query["SendPhone"] = request.SendPhone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePickUpWaybillResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a door-to-door delivery order.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param tmpReq CreatePickUpWaybillRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePickUpWaybillResponse
         */
        public async Task<CreatePickUpWaybillResponse> CreatePickUpWaybillWithOptionsAsync(CreatePickUpWaybillRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePickUpWaybillShrinkRequest request = new CreatePickUpWaybillShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConsigneeAddress))
            {
                request.ConsigneeAddressShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConsigneeAddress, "ConsigneeAddress", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GoodsInfos))
            {
                request.GoodsInfosShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GoodsInfos, "GoodsInfos", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SendAddress))
            {
                request.SendAddressShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SendAddress, "SendAddress", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppointGotEndTime))
            {
                query["AppointGotEndTime"] = request.AppointGotEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppointGotStartTime))
            {
                query["AppointGotStartTime"] = request.AppointGotStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsigneeAddressShrink))
            {
                query["ConsigneeAddress"] = request.ConsigneeAddressShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsigneeMobile))
            {
                query["ConsigneeMobile"] = request.ConsigneeMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsigneeName))
            {
                query["ConsigneeName"] = request.ConsigneeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsigneePhone))
            {
                query["ConsigneePhone"] = request.ConsigneePhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpCode))
            {
                query["CpCode"] = request.CpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsInfosShrink))
            {
                query["GoodsInfos"] = request.GoodsInfosShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderChannels))
            {
                query["OrderChannels"] = request.OrderChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderCode))
            {
                query["OuterOrderCode"] = request.OuterOrderCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendAddressShrink))
            {
                query["SendAddress"] = request.SendAddressShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendMobile))
            {
                query["SendMobile"] = request.SendMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendName))
            {
                query["SendName"] = request.SendName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendPhone))
            {
                query["SendPhone"] = request.SendPhone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePickUpWaybillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a door-to-door delivery order.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreatePickUpWaybillRequest
         * @return CreatePickUpWaybillResponse
         */
        public CreatePickUpWaybillResponse CreatePickUpWaybill(CreatePickUpWaybillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePickUpWaybillWithOptions(request, runtime);
        }

        /**
         * @summary Creates a door-to-door delivery order.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreatePickUpWaybillRequest
         * @return CreatePickUpWaybillResponse
         */
        public async Task<CreatePickUpWaybillResponse> CreatePickUpWaybillAsync(CreatePickUpWaybillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePickUpWaybillWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a pickup order.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param tmpReq CreatePickUpWaybillPreQueryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePickUpWaybillPreQueryResponse
         */
        public CreatePickUpWaybillPreQueryResponse CreatePickUpWaybillPreQueryWithOptions(CreatePickUpWaybillPreQueryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePickUpWaybillPreQueryShrinkRequest request = new CreatePickUpWaybillPreQueryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConsigneeInfo))
            {
                request.ConsigneeInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConsigneeInfo, "ConsigneeInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SenderInfo))
            {
                request.SenderInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SenderInfo, "SenderInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsigneeInfoShrink))
            {
                query["ConsigneeInfo"] = request.ConsigneeInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpCode))
            {
                query["CpCode"] = request.CpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderChannels))
            {
                query["OrderChannels"] = request.OrderChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderCode))
            {
                query["OuterOrderCode"] = request.OuterOrderCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreWeight))
            {
                query["PreWeight"] = request.PreWeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderInfoShrink))
            {
                query["SenderInfo"] = request.SenderInfoShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePickUpWaybillPreQuery",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePickUpWaybillPreQueryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a pickup order.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param tmpReq CreatePickUpWaybillPreQueryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePickUpWaybillPreQueryResponse
         */
        public async Task<CreatePickUpWaybillPreQueryResponse> CreatePickUpWaybillPreQueryWithOptionsAsync(CreatePickUpWaybillPreQueryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePickUpWaybillPreQueryShrinkRequest request = new CreatePickUpWaybillPreQueryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConsigneeInfo))
            {
                request.ConsigneeInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConsigneeInfo, "ConsigneeInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SenderInfo))
            {
                request.SenderInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SenderInfo, "SenderInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsigneeInfoShrink))
            {
                query["ConsigneeInfo"] = request.ConsigneeInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpCode))
            {
                query["CpCode"] = request.CpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderChannels))
            {
                query["OrderChannels"] = request.OrderChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderCode))
            {
                query["OuterOrderCode"] = request.OuterOrderCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreWeight))
            {
                query["PreWeight"] = request.PreWeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderInfoShrink))
            {
                query["SenderInfo"] = request.SenderInfoShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePickUpWaybillPreQuery",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePickUpWaybillPreQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a pickup order.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreatePickUpWaybillPreQueryRequest
         * @return CreatePickUpWaybillPreQueryResponse
         */
        public CreatePickUpWaybillPreQueryResponse CreatePickUpWaybillPreQuery(CreatePickUpWaybillPreQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePickUpWaybillPreQueryWithOptions(request, runtime);
        }

        /**
         * @summary Queries a pickup order.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreatePickUpWaybillPreQueryRequest
         * @return CreatePickUpWaybillPreQueryResponse
         */
        public async Task<CreatePickUpWaybillPreQueryResponse> CreatePickUpWaybillPreQueryAsync(CreatePickUpWaybillPreQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePickUpWaybillPreQueryWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteAxgGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAxgGroupResponse
         */
        public DeleteAxgGroupResponse DeleteAxgGroupWithOptions(DeleteAxgGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAxgGroup",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAxgGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteAxgGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAxgGroupResponse
         */
        public async Task<DeleteAxgGroupResponse> DeleteAxgGroupWithOptionsAsync(DeleteAxgGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAxgGroup",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAxgGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteAxgGroupRequest
         * @return DeleteAxgGroupResponse
         */
        public DeleteAxgGroupResponse DeleteAxgGroup(DeleteAxgGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAxgGroupWithOptions(request, runtime);
        }

        /**
         * @param request DeleteAxgGroupRequest
         * @return DeleteAxgGroupResponse
         */
        public async Task<DeleteAxgGroupResponse> DeleteAxgGroupAsync(DeleteAxgGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAxgGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a blacklist.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteSecretBlacklistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSecretBlacklistResponse
         */
        public DeleteSecretBlacklistResponse DeleteSecretBlacklistWithOptions(DeleteSecretBlacklistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackNo))
            {
                query["BlackNo"] = request.BlackNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackType))
            {
                query["BlackType"] = request.BlackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WayControl))
            {
                query["WayControl"] = request.WayControl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSecretBlacklistResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a blacklist.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteSecretBlacklistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSecretBlacklistResponse
         */
        public async Task<DeleteSecretBlacklistResponse> DeleteSecretBlacklistWithOptionsAsync(DeleteSecretBlacklistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackNo))
            {
                query["BlackNo"] = request.BlackNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackType))
            {
                query["BlackType"] = request.BlackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WayControl))
            {
                query["WayControl"] = request.WayControl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSecretBlacklistResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a blacklist.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteSecretBlacklistRequest
         * @return DeleteSecretBlacklistResponse
         */
        public DeleteSecretBlacklistResponse DeleteSecretBlacklist(DeleteSecretBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSecretBlacklistWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a blacklist.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteSecretBlacklistRequest
         * @return DeleteSecretBlacklistResponse
         */
        public async Task<DeleteSecretBlacklistResponse> DeleteSecretBlacklistAsync(DeleteSecretBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSecretBlacklistWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the details of the automatic speech recognition (ASR) result.
         *
         * @description Before you call the GetSecretAsrDetail operation, set the ASRStatus parameter to true in the [BindAxn operation](https://help.aliyun.com/document_detail/400483.html). This ensures that you can obtain the ASR result properly.
         * ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetSecretAsrDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSecretAsrDetailResponse
         */
        public GetSecretAsrDetailResponse GetSecretAsrDetailWithOptions(GetSecretAsrDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallTime))
            {
                query["CallTime"] = request.CallTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecretAsrDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the details of the automatic speech recognition (ASR) result.
         *
         * @description Before you call the GetSecretAsrDetail operation, set the ASRStatus parameter to true in the [BindAxn operation](https://help.aliyun.com/document_detail/400483.html). This ensures that you can obtain the ASR result properly.
         * ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetSecretAsrDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSecretAsrDetailResponse
         */
        public async Task<GetSecretAsrDetailResponse> GetSecretAsrDetailWithOptionsAsync(GetSecretAsrDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallTime))
            {
                query["CallTime"] = request.CallTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecretAsrDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the details of the automatic speech recognition (ASR) result.
         *
         * @description Before you call the GetSecretAsrDetail operation, set the ASRStatus parameter to true in the [BindAxn operation](https://help.aliyun.com/document_detail/400483.html). This ensures that you can obtain the ASR result properly.
         * ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetSecretAsrDetailRequest
         * @return GetSecretAsrDetailResponse
         */
        public GetSecretAsrDetailResponse GetSecretAsrDetail(GetSecretAsrDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSecretAsrDetailWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the details of the automatic speech recognition (ASR) result.
         *
         * @description Before you call the GetSecretAsrDetail operation, set the ASRStatus parameter to true in the [BindAxn operation](https://help.aliyun.com/document_detail/400483.html). This ensures that you can obtain the ASR result properly.
         * ### [](#qps)QPS limits
         * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetSecretAsrDetailRequest
         * @return GetSecretAsrDetailResponse
         */
        public async Task<GetSecretAsrDetailResponse> GetSecretAsrDetailAsync(GetSecretAsrDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSecretAsrDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the download URL of a recorded ringing tone.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetTotalPublicUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTotalPublicUrlResponse
         */
        public GetTotalPublicUrlResponse GetTotalPublicUrlWithOptions(GetTotalPublicUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallTime))
            {
                query["CallTime"] = request.CallTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckSubs))
            {
                query["CheckSubs"] = request.CheckSubs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerKey))
            {
                query["PartnerKey"] = request.PartnerKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTotalPublicUrlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the download URL of a recorded ringing tone.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetTotalPublicUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTotalPublicUrlResponse
         */
        public async Task<GetTotalPublicUrlResponse> GetTotalPublicUrlWithOptionsAsync(GetTotalPublicUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallTime))
            {
                query["CallTime"] = request.CallTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckSubs))
            {
                query["CheckSubs"] = request.CheckSubs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerKey))
            {
                query["PartnerKey"] = request.PartnerKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTotalPublicUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the download URL of a recorded ringing tone.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetTotalPublicUrlRequest
         * @return GetTotalPublicUrlResponse
         */
        public GetTotalPublicUrlResponse GetTotalPublicUrl(GetTotalPublicUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTotalPublicUrlWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the download URL of a recorded ringing tone.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetTotalPublicUrlRequest
         * @return GetTotalPublicUrlResponse
         */
        public async Task<GetTotalPublicUrlResponse> GetTotalPublicUrlAsync(GetTotalPublicUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTotalPublicUrlWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Locks a phone number.
         *
         * @description After a phone number is locked, the locked phone number cannot be selected when you call an operation to create a binding.
         * ### [](#qps)QPS limits
         * You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request LockSecretNoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return LockSecretNoResponse
         */
        public LockSecretNoResponse LockSecretNoWithOptions(LockSecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretNo))
            {
                query["SecretNo"] = request.SecretNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LockSecretNoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Locks a phone number.
         *
         * @description After a phone number is locked, the locked phone number cannot be selected when you call an operation to create a binding.
         * ### [](#qps)QPS limits
         * You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request LockSecretNoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return LockSecretNoResponse
         */
        public async Task<LockSecretNoResponse> LockSecretNoWithOptionsAsync(LockSecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretNo))
            {
                query["SecretNo"] = request.SecretNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LockSecretNoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Locks a phone number.
         *
         * @description After a phone number is locked, the locked phone number cannot be selected when you call an operation to create a binding.
         * ### [](#qps)QPS limits
         * You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request LockSecretNoRequest
         * @return LockSecretNoResponse
         */
        public LockSecretNoResponse LockSecretNo(LockSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LockSecretNoWithOptions(request, runtime);
        }

        /**
         * @summary Locks a phone number.
         *
         * @description After a phone number is locked, the locked phone number cannot be selected when you call an operation to create a binding.
         * ### [](#qps)QPS limits
         * You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request LockSecretNoRequest
         * @return LockSecretNoResponse
         */
        public async Task<LockSecretNoResponse> LockSecretNoAsync(LockSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LockSecretNoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies number group G.
         *
         * @description After you create number group G, you can call the OperateAxgGroup operation to modify number group G. For example, you can add phone numbers to number group G, delete phone numbers from number group G, and replace all phone numbers in number group G.
         * ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request OperateAxgGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OperateAxgGroupResponse
         */
        public OperateAxgGroupResponse OperateAxgGroupWithOptions(OperateAxgGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Numbers))
            {
                query["Numbers"] = request.Numbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateAxgGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies number group G.
         *
         * @description After you create number group G, you can call the OperateAxgGroup operation to modify number group G. For example, you can add phone numbers to number group G, delete phone numbers from number group G, and replace all phone numbers in number group G.
         * ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request OperateAxgGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OperateAxgGroupResponse
         */
        public async Task<OperateAxgGroupResponse> OperateAxgGroupWithOptionsAsync(OperateAxgGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Numbers))
            {
                query["Numbers"] = request.Numbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateAxgGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies number group G.
         *
         * @description After you create number group G, you can call the OperateAxgGroup operation to modify number group G. For example, you can add phone numbers to number group G, delete phone numbers from number group G, and replace all phone numbers in number group G.
         * ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request OperateAxgGroupRequest
         * @return OperateAxgGroupResponse
         */
        public OperateAxgGroupResponse OperateAxgGroup(OperateAxgGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateAxgGroupWithOptions(request, runtime);
        }

        /**
         * @summary Modifies number group G.
         *
         * @description After you create number group G, you can call the OperateAxgGroup operation to modify number group G. For example, you can add phone numbers to number group G, delete phone numbers from number group G, and replace all phone numbers in number group G.
         * ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request OperateAxgGroupRequest
         * @return OperateAxgGroupResponse
         */
        public async Task<OperateAxgGroupResponse> OperateAxgGroupAsync(OperateAxgGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateAxgGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds a phone number to a blacklist or deletes a phone number from a blacklist.
         *
         * @description The OperateBlackNo operation supports the following number pool types: AXN, AXN extension, and 95AXN.
         * ### [](#qps)QPS limits
         * You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request OperateBlackNoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OperateBlackNoResponse
         */
        public OperateBlackNoResponse OperateBlackNoWithOptions(OperateBlackNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackNo))
            {
                query["BlackNo"] = request.BlackNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tips))
            {
                query["Tips"] = request.Tips;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateBlackNoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds a phone number to a blacklist or deletes a phone number from a blacklist.
         *
         * @description The OperateBlackNo operation supports the following number pool types: AXN, AXN extension, and 95AXN.
         * ### [](#qps)QPS limits
         * You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request OperateBlackNoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OperateBlackNoResponse
         */
        public async Task<OperateBlackNoResponse> OperateBlackNoWithOptionsAsync(OperateBlackNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackNo))
            {
                query["BlackNo"] = request.BlackNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tips))
            {
                query["Tips"] = request.Tips;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateBlackNoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds a phone number to a blacklist or deletes a phone number from a blacklist.
         *
         * @description The OperateBlackNo operation supports the following number pool types: AXN, AXN extension, and 95AXN.
         * ### [](#qps)QPS limits
         * You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request OperateBlackNoRequest
         * @return OperateBlackNoResponse
         */
        public OperateBlackNoResponse OperateBlackNo(OperateBlackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateBlackNoWithOptions(request, runtime);
        }

        /**
         * @summary Adds a phone number to a blacklist or deletes a phone number from a blacklist.
         *
         * @description The OperateBlackNo operation supports the following number pool types: AXN, AXN extension, and 95AXN.
         * ### [](#qps)QPS limits
         * You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request OperateBlackNoRequest
         * @return OperateBlackNoResponse
         */
        public async Task<OperateBlackNoResponse> OperateBlackNoAsync(OperateBlackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateBlackNoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details about a tracking number.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request QueryPhoneNoAByTrackNoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPhoneNoAByTrackNoResponse
         */
        public QueryPhoneNoAByTrackNoResponse QueryPhoneNoAByTrackNoWithOptions(QueryPhoneNoAByTrackNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinetNo))
            {
                query["CabinetNo"] = request.CabinetNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoX))
            {
                query["PhoneNoX"] = request.PhoneNoX;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrackNo))
            {
                query["trackNo"] = request.TrackNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPhoneNoAByTrackNoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details about a tracking number.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request QueryPhoneNoAByTrackNoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPhoneNoAByTrackNoResponse
         */
        public async Task<QueryPhoneNoAByTrackNoResponse> QueryPhoneNoAByTrackNoWithOptionsAsync(QueryPhoneNoAByTrackNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinetNo))
            {
                query["CabinetNo"] = request.CabinetNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoX))
            {
                query["PhoneNoX"] = request.PhoneNoX;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrackNo))
            {
                query["trackNo"] = request.TrackNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPhoneNoAByTrackNoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details about a tracking number.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request QueryPhoneNoAByTrackNoRequest
         * @return QueryPhoneNoAByTrackNoResponse
         */
        public QueryPhoneNoAByTrackNoResponse QueryPhoneNoAByTrackNo(QueryPhoneNoAByTrackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPhoneNoAByTrackNoWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details about a tracking number.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request QueryPhoneNoAByTrackNoRequest
         * @return QueryPhoneNoAByTrackNoResponse
         */
        public async Task<QueryPhoneNoAByTrackNoResponse> QueryPhoneNoAByTrackNoAsync(QueryPhoneNoAByTrackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPhoneNoAByTrackNoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the download URL of a recording file.
         *
         * @description If the recording feature is enabled for a binding, all calls made by the bound phone numbers are recorded. You can obtain the download URL of a recording file by calling the QueryRecordFileDownloadUrl operation and download the recording file.
         * >  We recommend that you subscribe to [the recording status report SecretRecording](https://help.aliyun.com/document_detail/109198.html). The values of the response parameters in SecretRecording can be used as the values of the request parameters for downloading a recording file.
         * ### [](#)Procedure for obtaining a recording file
         * 1.  Specify the request parameter in an update or binding operation to enable the recording feature.
         * 2.  Subscribe to recording message receipts in the Phone Number Protection console.
         * 3.  After a recording message receipt is returned, call the QueryRecordFileDownloadUrl operation to obtain the download URL of the recording file, and download the recording file.
         * > 
         * *   A download URL is valid for 2 hours. Download the recording file as soon as possible after obtaining a download URL.
         * *   The storage period of recording files is 30 days. You can download only the recording files of calls recorded in the last 30 days.
         *
         * @param request QueryRecordFileDownloadUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryRecordFileDownloadUrlResponse
         */
        public QueryRecordFileDownloadUrlResponse QueryRecordFileDownloadUrlWithOptions(QueryRecordFileDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallTime))
            {
                query["CallTime"] = request.CallTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordFileDownloadUrlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the download URL of a recording file.
         *
         * @description If the recording feature is enabled for a binding, all calls made by the bound phone numbers are recorded. You can obtain the download URL of a recording file by calling the QueryRecordFileDownloadUrl operation and download the recording file.
         * >  We recommend that you subscribe to [the recording status report SecretRecording](https://help.aliyun.com/document_detail/109198.html). The values of the response parameters in SecretRecording can be used as the values of the request parameters for downloading a recording file.
         * ### [](#)Procedure for obtaining a recording file
         * 1.  Specify the request parameter in an update or binding operation to enable the recording feature.
         * 2.  Subscribe to recording message receipts in the Phone Number Protection console.
         * 3.  After a recording message receipt is returned, call the QueryRecordFileDownloadUrl operation to obtain the download URL of the recording file, and download the recording file.
         * > 
         * *   A download URL is valid for 2 hours. Download the recording file as soon as possible after obtaining a download URL.
         * *   The storage period of recording files is 30 days. You can download only the recording files of calls recorded in the last 30 days.
         *
         * @param request QueryRecordFileDownloadUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryRecordFileDownloadUrlResponse
         */
        public async Task<QueryRecordFileDownloadUrlResponse> QueryRecordFileDownloadUrlWithOptionsAsync(QueryRecordFileDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallTime))
            {
                query["CallTime"] = request.CallTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordFileDownloadUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the download URL of a recording file.
         *
         * @description If the recording feature is enabled for a binding, all calls made by the bound phone numbers are recorded. You can obtain the download URL of a recording file by calling the QueryRecordFileDownloadUrl operation and download the recording file.
         * >  We recommend that you subscribe to [the recording status report SecretRecording](https://help.aliyun.com/document_detail/109198.html). The values of the response parameters in SecretRecording can be used as the values of the request parameters for downloading a recording file.
         * ### [](#)Procedure for obtaining a recording file
         * 1.  Specify the request parameter in an update or binding operation to enable the recording feature.
         * 2.  Subscribe to recording message receipts in the Phone Number Protection console.
         * 3.  After a recording message receipt is returned, call the QueryRecordFileDownloadUrl operation to obtain the download URL of the recording file, and download the recording file.
         * > 
         * *   A download URL is valid for 2 hours. Download the recording file as soon as possible after obtaining a download URL.
         * *   The storage period of recording files is 30 days. You can download only the recording files of calls recorded in the last 30 days.
         *
         * @param request QueryRecordFileDownloadUrlRequest
         * @return QueryRecordFileDownloadUrlResponse
         */
        public QueryRecordFileDownloadUrlResponse QueryRecordFileDownloadUrl(QueryRecordFileDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRecordFileDownloadUrlWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the download URL of a recording file.
         *
         * @description If the recording feature is enabled for a binding, all calls made by the bound phone numbers are recorded. You can obtain the download URL of a recording file by calling the QueryRecordFileDownloadUrl operation and download the recording file.
         * >  We recommend that you subscribe to [the recording status report SecretRecording](https://help.aliyun.com/document_detail/109198.html). The values of the response parameters in SecretRecording can be used as the values of the request parameters for downloading a recording file.
         * ### [](#)Procedure for obtaining a recording file
         * 1.  Specify the request parameter in an update or binding operation to enable the recording feature.
         * 2.  Subscribe to recording message receipts in the Phone Number Protection console.
         * 3.  After a recording message receipt is returned, call the QueryRecordFileDownloadUrl operation to obtain the download URL of the recording file, and download the recording file.
         * > 
         * *   A download URL is valid for 2 hours. Download the recording file as soon as possible after obtaining a download URL.
         * *   The storage period of recording files is 30 days. You can download only the recording files of calls recorded in the last 30 days.
         *
         * @param request QueryRecordFileDownloadUrlRequest
         * @return QueryRecordFileDownloadUrlResponse
         */
        public async Task<QueryRecordFileDownloadUrlResponse> QueryRecordFileDownloadUrlAsync(QueryRecordFileDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRecordFileDownloadUrlWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the attributes of a private number.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. We recommend that you take note of the limit when you call this operation.
         *
         * @param request QuerySecretNoDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySecretNoDetailResponse
         */
        public QuerySecretNoDetailResponse QuerySecretNoDetailWithOptions(QuerySecretNoDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretNo))
            {
                query["SecretNo"] = request.SecretNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySecretNoDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the attributes of a private number.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. We recommend that you take note of the limit when you call this operation.
         *
         * @param request QuerySecretNoDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySecretNoDetailResponse
         */
        public async Task<QuerySecretNoDetailResponse> QuerySecretNoDetailWithOptionsAsync(QuerySecretNoDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretNo))
            {
                query["SecretNo"] = request.SecretNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySecretNoDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the attributes of a private number.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. We recommend that you take note of the limit when you call this operation.
         *
         * @param request QuerySecretNoDetailRequest
         * @return QuerySecretNoDetailResponse
         */
        public QuerySecretNoDetailResponse QuerySecretNoDetail(QuerySecretNoDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySecretNoDetailWithOptions(request, runtime);
        }

        /**
         * @summary Queries the attributes of a private number.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. We recommend that you take note of the limit when you call this operation.
         *
         * @param request QuerySecretNoDetailRequest
         * @return QuerySecretNoDetailResponse
         */
        public async Task<QuerySecretNoDetailResponse> QuerySecretNoDetailAsync(QuerySecretNoDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySecretNoDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the quantity of remaining phone numbers available for online purchase.
         *
         * @description When purchasing a phone number, specify the home location. If no sufficient phone numbers are available for purchase in the home location, the purchase of the phone number fails. Before calling the [BuySecretNo](~~BuySecretNo~~) operation to purchase a phone number, call the [QuerySecretNoRemain](~~QuerySecretNoRemain~~) operation to query the quantity of remaining phone numbers available for online purchase.
         *
         * @param request QuerySecretNoRemainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySecretNoRemainResponse
         */
        public QuerySecretNoRemainResponse QuerySecretNoRemainWithOptions(QuerySecretNoRemainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretNo))
            {
                query["SecretNo"] = request.SecretNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecId))
            {
                query["SpecId"] = request.SpecId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySecretNoRemainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the quantity of remaining phone numbers available for online purchase.
         *
         * @description When purchasing a phone number, specify the home location. If no sufficient phone numbers are available for purchase in the home location, the purchase of the phone number fails. Before calling the [BuySecretNo](~~BuySecretNo~~) operation to purchase a phone number, call the [QuerySecretNoRemain](~~QuerySecretNoRemain~~) operation to query the quantity of remaining phone numbers available for online purchase.
         *
         * @param request QuerySecretNoRemainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySecretNoRemainResponse
         */
        public async Task<QuerySecretNoRemainResponse> QuerySecretNoRemainWithOptionsAsync(QuerySecretNoRemainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretNo))
            {
                query["SecretNo"] = request.SecretNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecId))
            {
                query["SpecId"] = request.SpecId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySecretNoRemainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the quantity of remaining phone numbers available for online purchase.
         *
         * @description When purchasing a phone number, specify the home location. If no sufficient phone numbers are available for purchase in the home location, the purchase of the phone number fails. Before calling the [BuySecretNo](~~BuySecretNo~~) operation to purchase a phone number, call the [QuerySecretNoRemain](~~QuerySecretNoRemain~~) operation to query the quantity of remaining phone numbers available for online purchase.
         *
         * @param request QuerySecretNoRemainRequest
         * @return QuerySecretNoRemainResponse
         */
        public QuerySecretNoRemainResponse QuerySecretNoRemain(QuerySecretNoRemainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySecretNoRemainWithOptions(request, runtime);
        }

        /**
         * @summary Queries the quantity of remaining phone numbers available for online purchase.
         *
         * @description When purchasing a phone number, specify the home location. If no sufficient phone numbers are available for purchase in the home location, the purchase of the phone number fails. Before calling the [BuySecretNo](~~BuySecretNo~~) operation to purchase a phone number, call the [QuerySecretNoRemain](~~QuerySecretNoRemain~~) operation to query the quantity of remaining phone numbers available for online purchase.
         *
         * @param request QuerySecretNoRemainRequest
         * @return QuerySecretNoRemainResponse
         */
        public async Task<QuerySecretNoRemainResponse> QuerySecretNoRemainAsync(QuerySecretNoRemainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySecretNoRemainWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries binding IDs.
         *
         * @description You can query binding IDs by phone number X. In the AXB product, multiple bindings may exist for the same phone number X. In this case, multiple binding IDs may be obtained for the same phone number X.
         *
         * @param request QuerySubsIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySubsIdResponse
         */
        public QuerySubsIdResponse QuerySubsIdWithOptions(QuerySubsIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoX))
            {
                query["PhoneNoX"] = request.PhoneNoX;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySubsIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries binding IDs.
         *
         * @description You can query binding IDs by phone number X. In the AXB product, multiple bindings may exist for the same phone number X. In this case, multiple binding IDs may be obtained for the same phone number X.
         *
         * @param request QuerySubsIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySubsIdResponse
         */
        public async Task<QuerySubsIdResponse> QuerySubsIdWithOptionsAsync(QuerySubsIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoX))
            {
                query["PhoneNoX"] = request.PhoneNoX;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySubsIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries binding IDs.
         *
         * @description You can query binding IDs by phone number X. In the AXB product, multiple bindings may exist for the same phone number X. In this case, multiple binding IDs may be obtained for the same phone number X.
         *
         * @param request QuerySubsIdRequest
         * @return QuerySubsIdResponse
         */
        public QuerySubsIdResponse QuerySubsId(QuerySubsIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySubsIdWithOptions(request, runtime);
        }

        /**
         * @summary Queries binding IDs.
         *
         * @description You can query binding IDs by phone number X. In the AXB product, multiple bindings may exist for the same phone number X. In this case, multiple binding IDs may be obtained for the same phone number X.
         *
         * @param request QuerySubsIdRequest
         * @return QuerySubsIdResponse
         */
        public async Task<QuerySubsIdResponse> QuerySubsIdAsync(QuerySubsIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySubsIdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details about a phone number binding.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         * ### [](#poolkeyproducttype)Limits on PoolKey and ProductType
         * You must specify either PoolKey or ProductType. If both parameters are not specified, an error is reported when you call the QuerySubscriptionDetail operation. We recommend that you specify the ProductType parameter for the original key accounts of Alibaba Cloud and the PoolKey parameter for Alibaba Cloud users.
         *
         * @param request QuerySubscriptionDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySubscriptionDetailResponse
         */
        public QuerySubscriptionDetailResponse QuerySubscriptionDetailWithOptions(QuerySubscriptionDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoX))
            {
                query["PhoneNoX"] = request.PhoneNoX;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubsId))
            {
                query["SubsId"] = request.SubsId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySubscriptionDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details about a phone number binding.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         * ### [](#poolkeyproducttype)Limits on PoolKey and ProductType
         * You must specify either PoolKey or ProductType. If both parameters are not specified, an error is reported when you call the QuerySubscriptionDetail operation. We recommend that you specify the ProductType parameter for the original key accounts of Alibaba Cloud and the PoolKey parameter for Alibaba Cloud users.
         *
         * @param request QuerySubscriptionDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySubscriptionDetailResponse
         */
        public async Task<QuerySubscriptionDetailResponse> QuerySubscriptionDetailWithOptionsAsync(QuerySubscriptionDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoX))
            {
                query["PhoneNoX"] = request.PhoneNoX;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubsId))
            {
                query["SubsId"] = request.SubsId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySubscriptionDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details about a phone number binding.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         * ### [](#poolkeyproducttype)Limits on PoolKey and ProductType
         * You must specify either PoolKey or ProductType. If both parameters are not specified, an error is reported when you call the QuerySubscriptionDetail operation. We recommend that you specify the ProductType parameter for the original key accounts of Alibaba Cloud and the PoolKey parameter for Alibaba Cloud users.
         *
         * @param request QuerySubscriptionDetailRequest
         * @return QuerySubscriptionDetailResponse
         */
        public QuerySubscriptionDetailResponse QuerySubscriptionDetail(QuerySubscriptionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySubscriptionDetailWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details about a phone number binding.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         * ### [](#poolkeyproducttype)Limits on PoolKey and ProductType
         * You must specify either PoolKey or ProductType. If both parameters are not specified, an error is reported when you call the QuerySubscriptionDetail operation. We recommend that you specify the ProductType parameter for the original key accounts of Alibaba Cloud and the PoolKey parameter for Alibaba Cloud users.
         *
         * @param request QuerySubscriptionDetailRequest
         * @return QuerySubscriptionDetailResponse
         */
        public async Task<QuerySubscriptionDetailResponse> QuerySubscriptionDetailAsync(QuerySubscriptionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySubscriptionDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Releases a phone number.
         *
         * @description *   After a phone number is released, it will no longer be charged from the following month.
         * *   Before you release a phone number, log on to the [Phone Number Protection console](https://dypls.console.aliyun.com/dypls.htm#/account) to check whether the phone number is bound to other phone numbers. The phone number can be released only if it is not bound to other phone numbers.
         *
         * @param request ReleaseSecretNoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseSecretNoResponse
         */
        public ReleaseSecretNoResponse ReleaseSecretNoWithOptions(ReleaseSecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretNo))
            {
                query["SecretNo"] = request.SecretNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseSecretNoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Releases a phone number.
         *
         * @description *   After a phone number is released, it will no longer be charged from the following month.
         * *   Before you release a phone number, log on to the [Phone Number Protection console](https://dypls.console.aliyun.com/dypls.htm#/account) to check whether the phone number is bound to other phone numbers. The phone number can be released only if it is not bound to other phone numbers.
         *
         * @param request ReleaseSecretNoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseSecretNoResponse
         */
        public async Task<ReleaseSecretNoResponse> ReleaseSecretNoWithOptionsAsync(ReleaseSecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretNo))
            {
                query["SecretNo"] = request.SecretNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseSecretNoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Releases a phone number.
         *
         * @description *   After a phone number is released, it will no longer be charged from the following month.
         * *   Before you release a phone number, log on to the [Phone Number Protection console](https://dypls.console.aliyun.com/dypls.htm#/account) to check whether the phone number is bound to other phone numbers. The phone number can be released only if it is not bound to other phone numbers.
         *
         * @param request ReleaseSecretNoRequest
         * @return ReleaseSecretNoResponse
         */
        public ReleaseSecretNoResponse ReleaseSecretNo(ReleaseSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseSecretNoWithOptions(request, runtime);
        }

        /**
         * @summary Releases a phone number.
         *
         * @description *   After a phone number is released, it will no longer be charged from the following month.
         * *   Before you release a phone number, log on to the [Phone Number Protection console](https://dypls.console.aliyun.com/dypls.htm#/account) to check whether the phone number is bound to other phone numbers. The phone number can be released only if it is not bound to other phone numbers.
         *
         * @param request ReleaseSecretNoRequest
         * @return ReleaseSecretNoResponse
         */
        public async Task<ReleaseSecretNoResponse> ReleaseSecretNoAsync(ReleaseSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseSecretNoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Unbinds a phone number.
         *
         * @description Before releasing a phone number, you must call the UnbindSubscription operation to unbind the phone number.
         *
         * @param request UnbindSubscriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindSubscriptionResponse
         */
        public UnbindSubscriptionResponse UnbindSubscriptionWithOptions(UnbindSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretNo))
            {
                query["SecretNo"] = request.SecretNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubsId))
            {
                query["SubsId"] = request.SubsId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Unbinds a phone number.
         *
         * @description Before releasing a phone number, you must call the UnbindSubscription operation to unbind the phone number.
         *
         * @param request UnbindSubscriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindSubscriptionResponse
         */
        public async Task<UnbindSubscriptionResponse> UnbindSubscriptionWithOptionsAsync(UnbindSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretNo))
            {
                query["SecretNo"] = request.SecretNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubsId))
            {
                query["SubsId"] = request.SubsId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Unbinds a phone number.
         *
         * @description Before releasing a phone number, you must call the UnbindSubscription operation to unbind the phone number.
         *
         * @param request UnbindSubscriptionRequest
         * @return UnbindSubscriptionResponse
         */
        public UnbindSubscriptionResponse UnbindSubscription(UnbindSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindSubscriptionWithOptions(request, runtime);
        }

        /**
         * @summary Unbinds a phone number.
         *
         * @description Before releasing a phone number, you must call the UnbindSubscription operation to unbind the phone number.
         *
         * @param request UnbindSubscriptionRequest
         * @return UnbindSubscriptionResponse
         */
        public async Task<UnbindSubscriptionResponse> UnbindSubscriptionAsync(UnbindSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindSubscriptionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Unlocks a phone number.
         *
         * @description After a phone number is unlocked, you can reselect the unlocked phone number when you call an operation to create a binding.
         * ### [](#qps)QPS limits
         * You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request UnlockSecretNoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnlockSecretNoResponse
         */
        public UnlockSecretNoResponse UnlockSecretNoWithOptions(UnlockSecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretNo))
            {
                query["SecretNo"] = request.SecretNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnlockSecretNoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Unlocks a phone number.
         *
         * @description After a phone number is unlocked, you can reselect the unlocked phone number when you call an operation to create a binding.
         * ### [](#qps)QPS limits
         * You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request UnlockSecretNoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnlockSecretNoResponse
         */
        public async Task<UnlockSecretNoResponse> UnlockSecretNoWithOptionsAsync(UnlockSecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretNo))
            {
                query["SecretNo"] = request.SecretNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnlockSecretNoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Unlocks a phone number.
         *
         * @description After a phone number is unlocked, you can reselect the unlocked phone number when you call an operation to create a binding.
         * ### [](#qps)QPS limits
         * You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request UnlockSecretNoRequest
         * @return UnlockSecretNoResponse
         */
        public UnlockSecretNoResponse UnlockSecretNo(UnlockSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnlockSecretNoWithOptions(request, runtime);
        }

        /**
         * @summary Unlocks a phone number.
         *
         * @description After a phone number is unlocked, you can reselect the unlocked phone number when you call an operation to create a binding.
         * ### [](#qps)QPS limits
         * You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request UnlockSecretNoRequest
         * @return UnlockSecretNoResponse
         */
        public async Task<UnlockSecretNoResponse> UnlockSecretNoAsync(UnlockSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnlockSecretNoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a phone number binding.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 10,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request UpdateSubscriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSubscriptionResponse
         */
        public UpdateSubscriptionResponse UpdateSubscriptionWithOptions(UpdateSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASRModelId))
            {
                query["ASRModelId"] = request.ASRModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASRStatus))
            {
                query["ASRStatus"] = request.ASRStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallDisplayType))
            {
                query["CallDisplayType"] = request.CallDisplayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallRestrict))
            {
                query["CallRestrict"] = request.CallRestrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expiration))
            {
                query["Expiration"] = request.Expiration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecordingEnabled))
            {
                query["IsRecordingEnabled"] = request.IsRecordingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoA))
            {
                query["PhoneNoA"] = request.PhoneNoA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoB))
            {
                query["PhoneNoB"] = request.PhoneNoB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoX))
            {
                query["PhoneNoX"] = request.PhoneNoX;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RingConfig))
            {
                query["RingConfig"] = request.RingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubsId))
            {
                query["SubsId"] = request.SubsId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies a phone number binding.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 10,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request UpdateSubscriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSubscriptionResponse
         */
        public async Task<UpdateSubscriptionResponse> UpdateSubscriptionWithOptionsAsync(UpdateSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASRModelId))
            {
                query["ASRModelId"] = request.ASRModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASRStatus))
            {
                query["ASRStatus"] = request.ASRStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallDisplayType))
            {
                query["CallDisplayType"] = request.CallDisplayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallRestrict))
            {
                query["CallRestrict"] = request.CallRestrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expiration))
            {
                query["Expiration"] = request.Expiration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecordingEnabled))
            {
                query["IsRecordingEnabled"] = request.IsRecordingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoA))
            {
                query["PhoneNoA"] = request.PhoneNoA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoB))
            {
                query["PhoneNoB"] = request.PhoneNoB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoX))
            {
                query["PhoneNoX"] = request.PhoneNoX;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolKey))
            {
                query["PoolKey"] = request.PoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RingConfig))
            {
                query["RingConfig"] = request.RingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubsId))
            {
                query["SubsId"] = request.SubsId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a phone number binding.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 10,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request UpdateSubscriptionRequest
         * @return UpdateSubscriptionResponse
         */
        public UpdateSubscriptionResponse UpdateSubscription(UpdateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSubscriptionWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a phone number binding.
         *
         * @description ### [](#qps)QPS limits
         * You can call this operation up to 10,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request UpdateSubscriptionRequest
         * @return UpdateSubscriptionResponse
         */
        public async Task<UpdateSubscriptionResponse> UpdateSubscriptionAsync(UpdateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSubscriptionWithOptionsAsync(request, runtime);
        }

    }
}
