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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a tracking number for a private number in the AXN binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddAxnTrackNoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddAxnTrackNoResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddAxnTrackNoResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddAxnTrackNoResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a tracking number for a private number in the AXN binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddAxnTrackNoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddAxnTrackNoResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddAxnTrackNoResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddAxnTrackNoResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a tracking number for a private number in the AXN binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddAxnTrackNoRequest
        /// </param>
        /// 
        /// <returns>
        /// AddAxnTrackNoResponse
        /// </returns>
        public AddAxnTrackNoResponse AddAxnTrackNo(AddAxnTrackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAxnTrackNoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a tracking number for a private number in the AXN binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddAxnTrackNoRequest
        /// </param>
        /// 
        /// <returns>
        /// AddAxnTrackNoResponse
        /// </returns>
        public async Task<AddAxnTrackNoResponse> AddAxnTrackNoAsync(AddAxnTrackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAxnTrackNoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a blacklist.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddSecretBlacklistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddSecretBlacklistResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddSecretBlacklistResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddSecretBlacklistResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a blacklist.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddSecretBlacklistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddSecretBlacklistResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddSecretBlacklistResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddSecretBlacklistResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a blacklist.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddSecretBlacklistRequest
        /// </param>
        /// 
        /// <returns>
        /// AddSecretBlacklistResponse
        /// </returns>
        public AddSecretBlacklistResponse AddSecretBlacklist(AddSecretBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSecretBlacklistWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a blacklist.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddSecretBlacklistRequest
        /// </param>
        /// 
        /// <returns>
        /// AddSecretBlacklistResponse
        /// </returns>
        public async Task<AddSecretBlacklistResponse> AddSecretBlacklistAsync(AddSecretBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSecretBlacklistWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用本接口向工作号平台请求为员工B的工作号X建立呼叫绑定（B，X，A），允许B通过X呼叫客户A</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindAXBCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindAXBCallResponse
        /// </returns>
        public BindAXBCallResponse BindAXBCallWithOptions(BindAXBCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthId))
            {
                query["AuthId"] = request.AuthId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerPoolKey))
            {
                query["CustomerPoolKey"] = request.CustomerPoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expiration))
            {
                query["Expiration"] = request.Expiration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelA))
            {
                query["TelA"] = request.TelA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAXBCall",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<BindAXBCallResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<BindAXBCallResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用本接口向工作号平台请求为员工B的工作号X建立呼叫绑定（B，X，A），允许B通过X呼叫客户A</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindAXBCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindAXBCallResponse
        /// </returns>
        public async Task<BindAXBCallResponse> BindAXBCallWithOptionsAsync(BindAXBCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthId))
            {
                query["AuthId"] = request.AuthId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerPoolKey))
            {
                query["CustomerPoolKey"] = request.CustomerPoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expiration))
            {
                query["Expiration"] = request.Expiration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelA))
            {
                query["TelA"] = request.TelA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAXBCall",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<BindAXBCallResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<BindAXBCallResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用本接口向工作号平台请求为员工B的工作号X建立呼叫绑定（B，X，A），允许B通过X呼叫客户A</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindAXBCallRequest
        /// </param>
        /// 
        /// <returns>
        /// BindAXBCallResponse
        /// </returns>
        public BindAXBCallResponse BindAXBCall(BindAXBCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAXBCallWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用本接口向工作号平台请求为员工B的工作号X建立呼叫绑定（B，X，A），允许B通过X呼叫客户A</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindAXBCallRequest
        /// </param>
        /// 
        /// <returns>
        /// BindAXBCallResponse
        /// </returns>
        public async Task<BindAXBCallResponse> BindAXBCallAsync(BindAXBCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAXBCallWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an AXB binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you add an AXB binding, we recommend that you specify role A and role B in the AXB device certificate (ProductKey, DeviceName, and DeviceSecret) in your business scenario. For example, in a taxi-hailing scenario, role A is the passenger and role B is the driver.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BindAxbRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindAxbResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<BindAxbResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<BindAxbResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an AXB binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you add an AXB binding, we recommend that you specify role A and role B in the AXB device certificate (ProductKey, DeviceName, and DeviceSecret) in your business scenario. For example, in a taxi-hailing scenario, role A is the passenger and role B is the driver.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BindAxbRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindAxbResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<BindAxbResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<BindAxbResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an AXB binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you add an AXB binding, we recommend that you specify role A and role B in the AXB device certificate (ProductKey, DeviceName, and DeviceSecret) in your business scenario. For example, in a taxi-hailing scenario, role A is the passenger and role B is the driver.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BindAxbRequest
        /// </param>
        /// 
        /// <returns>
        /// BindAxbResponse
        /// </returns>
        public BindAxbResponse BindAxb(BindAxbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAxbWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an AXB binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you add an AXB binding, we recommend that you specify role A and role B in the AXB device certificate (ProductKey, DeviceName, and DeviceSecret) in your business scenario. For example, in a taxi-hailing scenario, role A is the passenger and role B is the driver.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BindAxbRequest
        /// </param>
        /// 
        /// <returns>
        /// BindAxbResponse
        /// </returns>
        public async Task<BindAxbResponse> BindAxbAsync(BindAxbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAxbWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an AXG binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>An AXG protection solution can be configured to meet the requirements for grading users, limiting the scope of calls, and restricting order snatching. The letter G represents a phone number group to which you can add phone numbers as needed.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BindAxgRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindAxgResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<BindAxgResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<BindAxgResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an AXG binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>An AXG protection solution can be configured to meet the requirements for grading users, limiting the scope of calls, and restricting order snatching. The letter G represents a phone number group to which you can add phone numbers as needed.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BindAxgRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindAxgResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<BindAxgResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<BindAxgResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an AXG binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>An AXG protection solution can be configured to meet the requirements for grading users, limiting the scope of calls, and restricting order snatching. The letter G represents a phone number group to which you can add phone numbers as needed.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BindAxgRequest
        /// </param>
        /// 
        /// <returns>
        /// BindAxgResponse
        /// </returns>
        public BindAxgResponse BindAxg(BindAxgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAxgWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an AXG binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>An AXG protection solution can be configured to meet the requirements for grading users, limiting the scope of calls, and restricting order snatching. The letter G represents a phone number group to which you can add phone numbers as needed.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BindAxgRequest
        /// </param>
        /// 
        /// <returns>
        /// BindAxgResponse
        /// </returns>
        public async Task<BindAxgResponse> BindAxgAsync(BindAxgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAxgWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an AXN binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> An AXN private number is a dedicated private number assigned to phone number A. When an N-side number is used to call phone number X, the call is forwarded to phone number A.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// BindAxnRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindAxnResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                query["Extend"] = request.Extend;
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<BindAxnResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<BindAxnResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an AXN binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> An AXN private number is a dedicated private number assigned to phone number A. When an N-side number is used to call phone number X, the call is forwarded to phone number A.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// BindAxnRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindAxnResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                query["Extend"] = request.Extend;
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<BindAxnResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<BindAxnResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an AXN binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> An AXN private number is a dedicated private number assigned to phone number A. When an N-side number is used to call phone number X, the call is forwarded to phone number A.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// BindAxnRequest
        /// </param>
        /// 
        /// <returns>
        /// BindAxnResponse
        /// </returns>
        public BindAxnResponse BindAxn(BindAxnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAxnWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an AXN binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> An AXN private number is a dedicated private number assigned to phone number A. When an N-side number is used to call phone number X, the call is forwarded to phone number A.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// BindAxnRequest
        /// </param>
        /// 
        /// <returns>
        /// BindAxnResponse
        /// </returns>
        public async Task<BindAxnResponse> BindAxnAsync(BindAxnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAxnWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an AXN extension binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you add an AXN extension binding, confirm phone number A and phone number N in the business scenario. Phone number A belongs to a customer, and phone number X is the private number assigned to the customer. When any other phone number is used to call phone number X and the extension, the call is transferred to phone number A. When phone number A is used to call phone number X, the call is transferred to the default phone number B that is specified during the phone number binding.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BindAxnExtensionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindAxnExtensionResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<BindAxnExtensionResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<BindAxnExtensionResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an AXN extension binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you add an AXN extension binding, confirm phone number A and phone number N in the business scenario. Phone number A belongs to a customer, and phone number X is the private number assigned to the customer. When any other phone number is used to call phone number X and the extension, the call is transferred to phone number A. When phone number A is used to call phone number X, the call is transferred to the default phone number B that is specified during the phone number binding.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BindAxnExtensionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindAxnExtensionResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<BindAxnExtensionResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<BindAxnExtensionResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an AXN extension binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you add an AXN extension binding, confirm phone number A and phone number N in the business scenario. Phone number A belongs to a customer, and phone number X is the private number assigned to the customer. When any other phone number is used to call phone number X and the extension, the call is transferred to phone number A. When phone number A is used to call phone number X, the call is transferred to the default phone number B that is specified during the phone number binding.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BindAxnExtensionRequest
        /// </param>
        /// 
        /// <returns>
        /// BindAxnExtensionResponse
        /// </returns>
        public BindAxnExtensionResponse BindAxnExtension(BindAxnExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAxnExtensionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an AXN extension binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you add an AXN extension binding, confirm phone number A and phone number N in the business scenario. Phone number A belongs to a customer, and phone number X is the private number assigned to the customer. When any other phone number is used to call phone number X and the extension, the call is transferred to phone number A. When phone number A is used to call phone number X, the call is transferred to the default phone number B that is specified during the phone number binding.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BindAxnExtensionRequest
        /// </param>
        /// 
        /// <returns>
        /// BindAxnExtensionResponse
        /// </returns>
        public async Task<BindAxnExtensionResponse> BindAxnExtensionAsync(BindAxnExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAxnExtensionWithOptionsAsync(request, runtime);
        }

        /// <param name="tmpReq">
        /// BindBatchAxgRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindBatchAxgResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<BindBatchAxgResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<BindBatchAxgResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="tmpReq">
        /// BindBatchAxgRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindBatchAxgResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<BindBatchAxgResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<BindBatchAxgResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// BindBatchAxgRequest
        /// </param>
        /// 
        /// <returns>
        /// BindBatchAxgResponse
        /// </returns>
        public BindBatchAxgResponse BindBatchAxg(BindBatchAxgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindBatchAxgWithOptions(request, runtime);
        }

        /// <param name="request">
        /// BindBatchAxgRequest
        /// </param>
        /// 
        /// <returns>
        /// BindBatchAxgResponse
        /// </returns>
        public async Task<BindBatchAxgResponse> BindBatchAxgAsync(BindBatchAxgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindBatchAxgWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>平台指定工作号X 和员工号B建立关联，完成X 实名认证，绑定生效后，所有X 的呼叫都会转接到B</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindXBRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindXBResponse
        /// </returns>
        public BindXBResponse BindXBWithOptions(BindXBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerPoolKey))
            {
                query["CustomerPoolKey"] = request.CustomerPoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelB))
            {
                query["TelB"] = request.TelB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelX))
            {
                query["TelX"] = request.TelX;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindXB",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<BindXBResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<BindXBResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>平台指定工作号X 和员工号B建立关联，完成X 实名认证，绑定生效后，所有X 的呼叫都会转接到B</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindXBRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindXBResponse
        /// </returns>
        public async Task<BindXBResponse> BindXBWithOptionsAsync(BindXBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerPoolKey))
            {
                query["CustomerPoolKey"] = request.CustomerPoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelB))
            {
                query["TelB"] = request.TelB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelX))
            {
                query["TelX"] = request.TelX;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindXB",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<BindXBResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<BindXBResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>平台指定工作号X 和员工号B建立关联，完成X 实名认证，绑定生效后，所有X 的呼叫都会转接到B</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindXBRequest
        /// </param>
        /// 
        /// <returns>
        /// BindXBResponse
        /// </returns>
        public BindXBResponse BindXB(BindXBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindXBWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>平台指定工作号X 和员工号B建立关联，完成X 实名认证，绑定生效后，所有X 的呼叫都会转接到B</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindXBRequest
        /// </param>
        /// 
        /// <returns>
        /// BindXBResponse
        /// </returns>
        public async Task<BindXBResponse> BindXBAsync(BindXBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindXBWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Purchases a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you create a phone number pool in the Phone Number Protection console, the phone number pool is empty by default. You must purchase phone numbers and add them to the phone number pool.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/59825.html">pricing</a> of Phone Number Protection.</description></item>
        /// <item><description>When purchasing a phone number, specify the home location. If no sufficient phone numbers are available for purchase in the home location, the purchase of the phone number fails. Before you call this operation to purchase a phone number, check the quantity of phone numbers available for purchase by using the <a href="https://help.aliyun.com/document_detail/111699.html">QuerySecretNoRemain</a> operation.</description></item>
        /// <item><description>The account used to purchase a phone number must be an enterprise account that has passed real-name verification. For more information about how to perform real-name verification, see <a href="https://help.aliyun.com/document_detail/37172.html">Enterprise verification FAQs</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// BuySecretNoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BuySecretNoResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<BuySecretNoResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<BuySecretNoResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Purchases a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you create a phone number pool in the Phone Number Protection console, the phone number pool is empty by default. You must purchase phone numbers and add them to the phone number pool.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/59825.html">pricing</a> of Phone Number Protection.</description></item>
        /// <item><description>When purchasing a phone number, specify the home location. If no sufficient phone numbers are available for purchase in the home location, the purchase of the phone number fails. Before you call this operation to purchase a phone number, check the quantity of phone numbers available for purchase by using the <a href="https://help.aliyun.com/document_detail/111699.html">QuerySecretNoRemain</a> operation.</description></item>
        /// <item><description>The account used to purchase a phone number must be an enterprise account that has passed real-name verification. For more information about how to perform real-name verification, see <a href="https://help.aliyun.com/document_detail/37172.html">Enterprise verification FAQs</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// BuySecretNoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BuySecretNoResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<BuySecretNoResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<BuySecretNoResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Purchases a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you create a phone number pool in the Phone Number Protection console, the phone number pool is empty by default. You must purchase phone numbers and add them to the phone number pool.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/59825.html">pricing</a> of Phone Number Protection.</description></item>
        /// <item><description>When purchasing a phone number, specify the home location. If no sufficient phone numbers are available for purchase in the home location, the purchase of the phone number fails. Before you call this operation to purchase a phone number, check the quantity of phone numbers available for purchase by using the <a href="https://help.aliyun.com/document_detail/111699.html">QuerySecretNoRemain</a> operation.</description></item>
        /// <item><description>The account used to purchase a phone number must be an enterprise account that has passed real-name verification. For more information about how to perform real-name verification, see <a href="https://help.aliyun.com/document_detail/37172.html">Enterprise verification FAQs</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// BuySecretNoRequest
        /// </param>
        /// 
        /// <returns>
        /// BuySecretNoResponse
        /// </returns>
        public BuySecretNoResponse BuySecretNo(BuySecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BuySecretNoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Purchases a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you create a phone number pool in the Phone Number Protection console, the phone number pool is empty by default. You must purchase phone numbers and add them to the phone number pool.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/59825.html">pricing</a> of Phone Number Protection.</description></item>
        /// <item><description>When purchasing a phone number, specify the home location. If no sufficient phone numbers are available for purchase in the home location, the purchase of the phone number fails. Before you call this operation to purchase a phone number, check the quantity of phone numbers available for purchase by using the <a href="https://help.aliyun.com/document_detail/111699.html">QuerySecretNoRemain</a> operation.</description></item>
        /// <item><description>The account used to purchase a phone number must be an enterprise account that has passed real-name verification. For more information about how to perform real-name verification, see <a href="https://help.aliyun.com/document_detail/37172.html">Enterprise verification FAQs</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// BuySecretNoRequest
        /// </param>
        /// 
        /// <returns>
        /// BuySecretNoResponse
        /// </returns>
        public async Task<BuySecretNoResponse> BuySecretNoAsync(BuySecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BuySecretNoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a door-to-door delivery order.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelPickUpWaybillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelPickUpWaybillResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CancelPickUpWaybillResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CancelPickUpWaybillResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a door-to-door delivery order.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelPickUpWaybillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelPickUpWaybillResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CancelPickUpWaybillResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CancelPickUpWaybillResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a door-to-door delivery order.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelPickUpWaybillRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelPickUpWaybillResponse
        /// </returns>
        public CancelPickUpWaybillResponse CancelPickUpWaybill(CancelPickUpWaybillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelPickUpWaybillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a door-to-door delivery order.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelPickUpWaybillRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelPickUpWaybillResponse
        /// </returns>
        public async Task<CancelPickUpWaybillResponse> CancelPickUpWaybillAsync(CancelPickUpWaybillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelPickUpWaybillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置X号码，单独对工作号的话音呼叫、企业名片等通信功能进行配置操作</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ConfigXRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigXResponse
        /// </returns>
        public ConfigXResponse ConfigXWithOptions(ConfigXRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ConfigXShrinkRequest request = new ConfigXShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SequenceCalls))
            {
                request.SequenceCallsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SequenceCalls, "SequenceCalls", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallAbility))
            {
                query["CallAbility"] = request.CallAbility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerPoolKey))
            {
                query["CustomerPoolKey"] = request.CustomerPoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GNFlag))
            {
                query["GNFlag"] = request.GNFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SequenceCallsShrink))
            {
                query["SequenceCalls"] = request.SequenceCallsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SequenceMode))
            {
                query["SequenceMode"] = request.SequenceMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsAbility))
            {
                query["SmsAbility"] = request.SmsAbility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsSignMode))
            {
                query["SmsSignMode"] = request.SmsSignMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelX))
            {
                query["TelX"] = request.TelX;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigX",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ConfigXResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ConfigXResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置X号码，单独对工作号的话音呼叫、企业名片等通信功能进行配置操作</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ConfigXRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigXResponse
        /// </returns>
        public async Task<ConfigXResponse> ConfigXWithOptionsAsync(ConfigXRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ConfigXShrinkRequest request = new ConfigXShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SequenceCalls))
            {
                request.SequenceCallsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SequenceCalls, "SequenceCalls", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallAbility))
            {
                query["CallAbility"] = request.CallAbility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerPoolKey))
            {
                query["CustomerPoolKey"] = request.CustomerPoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GNFlag))
            {
                query["GNFlag"] = request.GNFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SequenceCallsShrink))
            {
                query["SequenceCalls"] = request.SequenceCallsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SequenceMode))
            {
                query["SequenceMode"] = request.SequenceMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsAbility))
            {
                query["SmsAbility"] = request.SmsAbility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsSignMode))
            {
                query["SmsSignMode"] = request.SmsSignMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelX))
            {
                query["TelX"] = request.TelX;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigX",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ConfigXResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ConfigXResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置X号码，单独对工作号的话音呼叫、企业名片等通信功能进行配置操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfigXRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigXResponse
        /// </returns>
        public ConfigXResponse ConfigX(ConfigXRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigXWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置X号码，单独对工作号的话音呼叫、企业名片等通信功能进行配置操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfigXRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigXResponse
        /// </returns>
        public async Task<ConfigXResponse> ConfigXAsync(ConfigXRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigXWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates number group G.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you add an AXG binding, you must purchase phone number X, create number group G, and then add phone numbers to number group G. If you do not add phone numbers to number group G after you create number group G, you can call the <a href="https://help.aliyun.com/document_detail/110252.htm">OperateAxgGroup</a> operation to add phone numbers to number group G.</para>
        /// <remarks>
        /// <para> Up to 2,000 number groups G can be added for a single phone number pool.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAxgGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAxgGroupResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateAxgGroupResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateAxgGroupResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates number group G.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you add an AXG binding, you must purchase phone number X, create number group G, and then add phone numbers to number group G. If you do not add phone numbers to number group G after you create number group G, you can call the <a href="https://help.aliyun.com/document_detail/110252.htm">OperateAxgGroup</a> operation to add phone numbers to number group G.</para>
        /// <remarks>
        /// <para> Up to 2,000 number groups G can be added for a single phone number pool.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAxgGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAxgGroupResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateAxgGroupResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateAxgGroupResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates number group G.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you add an AXG binding, you must purchase phone number X, create number group G, and then add phone numbers to number group G. If you do not add phone numbers to number group G after you create number group G, you can call the <a href="https://help.aliyun.com/document_detail/110252.htm">OperateAxgGroup</a> operation to add phone numbers to number group G.</para>
        /// <remarks>
        /// <para> Up to 2,000 number groups G can be added for a single phone number pool.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAxgGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAxgGroupResponse
        /// </returns>
        public CreateAxgGroupResponse CreateAxgGroup(CreateAxgGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAxgGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates number group G.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you add an AXG binding, you must purchase phone number X, create number group G, and then add phone numbers to number group G. If you do not add phone numbers to number group G after you create number group G, you can call the <a href="https://help.aliyun.com/document_detail/110252.htm">OperateAxgGroup</a> operation to add phone numbers to number group G.</para>
        /// <remarks>
        /// <para> Up to 2,000 number groups G can be added for a single phone number pool.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAxgGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAxgGroupResponse
        /// </returns>
        public async Task<CreateAxgGroupResponse> CreateAxgGroupAsync(CreateAxgGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAxgGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过API收集小号a号码手机号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePhoneNoAReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePhoneNoAReportResponse
        /// </returns>
        public CreatePhoneNoAReportResponse CreatePhoneNoAReportWithOptions(CreatePhoneNoAReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ANoWhiteGroupId))
            {
                query["ANoWhiteGroupId"] = request.ANoWhiteGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustName))
            {
                query["CustName"] = request.CustName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentNumber))
            {
                query["DocumentNumber"] = request.DocumentNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentType))
            {
                query["DocumentType"] = request.DocumentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardAlivePhoto))
            {
                query["IdCardAlivePhoto"] = request.IdCardAlivePhoto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardBackPhoto))
            {
                query["IdCardBackPhoto"] = request.IdCardBackPhoto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardFrontPhoto))
            {
                query["IdCardFrontPhoto"] = request.IdCardFrontPhoto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoA))
            {
                query["PhoneNoA"] = request.PhoneNoA;
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
                Action = "CreatePhoneNoAReport",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreatePhoneNoAReportResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreatePhoneNoAReportResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过API收集小号a号码手机号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePhoneNoAReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePhoneNoAReportResponse
        /// </returns>
        public async Task<CreatePhoneNoAReportResponse> CreatePhoneNoAReportWithOptionsAsync(CreatePhoneNoAReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ANoWhiteGroupId))
            {
                query["ANoWhiteGroupId"] = request.ANoWhiteGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustName))
            {
                query["CustName"] = request.CustName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentNumber))
            {
                query["DocumentNumber"] = request.DocumentNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentType))
            {
                query["DocumentType"] = request.DocumentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardAlivePhoto))
            {
                query["IdCardAlivePhoto"] = request.IdCardAlivePhoto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardBackPhoto))
            {
                query["IdCardBackPhoto"] = request.IdCardBackPhoto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardFrontPhoto))
            {
                query["IdCardFrontPhoto"] = request.IdCardFrontPhoto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNoA))
            {
                query["PhoneNoA"] = request.PhoneNoA;
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
                Action = "CreatePhoneNoAReport",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreatePhoneNoAReportResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreatePhoneNoAReportResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过API收集小号a号码手机号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePhoneNoAReportRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePhoneNoAReportResponse
        /// </returns>
        public CreatePhoneNoAReportResponse CreatePhoneNoAReport(CreatePhoneNoAReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePhoneNoAReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过API收集小号a号码手机号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePhoneNoAReportRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePhoneNoAReportResponse
        /// </returns>
        public async Task<CreatePhoneNoAReportResponse> CreatePhoneNoAReportAsync(CreatePhoneNoAReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePhoneNoAReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a door-to-door delivery order.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreatePickUpWaybillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePickUpWaybillResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreatePickUpWaybillResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreatePickUpWaybillResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a door-to-door delivery order.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreatePickUpWaybillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePickUpWaybillResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreatePickUpWaybillResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreatePickUpWaybillResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a door-to-door delivery order.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePickUpWaybillRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePickUpWaybillResponse
        /// </returns>
        public CreatePickUpWaybillResponse CreatePickUpWaybill(CreatePickUpWaybillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePickUpWaybillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a door-to-door delivery order.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePickUpWaybillRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePickUpWaybillResponse
        /// </returns>
        public async Task<CreatePickUpWaybillResponse> CreatePickUpWaybillAsync(CreatePickUpWaybillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePickUpWaybillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a pickup order.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreatePickUpWaybillPreQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePickUpWaybillPreQueryResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreatePickUpWaybillPreQueryResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreatePickUpWaybillPreQueryResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a pickup order.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreatePickUpWaybillPreQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePickUpWaybillPreQueryResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreatePickUpWaybillPreQueryResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreatePickUpWaybillPreQueryResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a pickup order.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePickUpWaybillPreQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePickUpWaybillPreQueryResponse
        /// </returns>
        public CreatePickUpWaybillPreQueryResponse CreatePickUpWaybillPreQuery(CreatePickUpWaybillPreQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePickUpWaybillPreQueryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a pickup order.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePickUpWaybillPreQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePickUpWaybillPreQueryResponse
        /// </returns>
        public async Task<CreatePickUpWaybillPreQueryResponse> CreatePickUpWaybillPreQueryAsync(CreatePickUpWaybillPreQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePickUpWaybillPreQueryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>B向A 发短信，客户端获取“短信标签”，尾部添加“标签”。通过“标签”解析被叫A，发短信到A。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSmsSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSmsSignResponse
        /// </returns>
        public CreateSmsSignResponse CreateSmsSignWithOptions(CreateSmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNo))
            {
                query["CalledNo"] = request.CalledNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNo))
            {
                query["CallingNo"] = request.CallingNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerPoolKey))
            {
                query["CustomerPoolKey"] = request.CustomerPoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
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
                Action = "CreateSmsSign",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateSmsSignResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateSmsSignResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>B向A 发短信，客户端获取“短信标签”，尾部添加“标签”。通过“标签”解析被叫A，发短信到A。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSmsSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSmsSignResponse
        /// </returns>
        public async Task<CreateSmsSignResponse> CreateSmsSignWithOptionsAsync(CreateSmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNo))
            {
                query["CalledNo"] = request.CalledNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNo))
            {
                query["CallingNo"] = request.CallingNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerPoolKey))
            {
                query["CustomerPoolKey"] = request.CustomerPoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
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
                Action = "CreateSmsSign",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateSmsSignResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateSmsSignResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>B向A 发短信，客户端获取“短信标签”，尾部添加“标签”。通过“标签”解析被叫A，发短信到A。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSmsSignRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSmsSignResponse
        /// </returns>
        public CreateSmsSignResponse CreateSmsSign(CreateSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSmsSignWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>B向A 发短信，客户端获取“短信标签”，尾部添加“标签”。通过“标签”解析被叫A，发短信到A。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSmsSignRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSmsSignResponse
        /// </returns>
        public async Task<CreateSmsSignResponse> CreateSmsSignAsync(CreateSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSmsSignWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteAxgGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAxgGroupResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteAxgGroupResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteAxgGroupResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DeleteAxgGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAxgGroupResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteAxgGroupResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteAxgGroupResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DeleteAxgGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAxgGroupResponse
        /// </returns>
        public DeleteAxgGroupResponse DeleteAxgGroup(DeleteAxgGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAxgGroupWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteAxgGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAxgGroupResponse
        /// </returns>
        public async Task<DeleteAxgGroupResponse> DeleteAxgGroupAsync(DeleteAxgGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAxgGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a blacklist.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSecretBlacklistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecretBlacklistResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteSecretBlacklistResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteSecretBlacklistResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a blacklist.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSecretBlacklistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecretBlacklistResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteSecretBlacklistResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteSecretBlacklistResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a blacklist.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSecretBlacklistRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecretBlacklistResponse
        /// </returns>
        public DeleteSecretBlacklistResponse DeleteSecretBlacklist(DeleteSecretBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSecretBlacklistWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a blacklist.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSecretBlacklistRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecretBlacklistResponse
        /// </returns>
        public async Task<DeleteSecretBlacklistResponse> DeleteSecretBlacklistAsync(DeleteSecretBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSecretBlacklistWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>隐私号上传文件，获取 OSS 信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDyplsOSSInfoForUploadFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDyplsOSSInfoForUploadFileResponse
        /// </returns>
        public GetDyplsOSSInfoForUploadFileResponse GetDyplsOSSInfoForUploadFileWithOptions(GetDyplsOSSInfoForUploadFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
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
                Action = "GetDyplsOSSInfoForUploadFile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetDyplsOSSInfoForUploadFileResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetDyplsOSSInfoForUploadFileResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>隐私号上传文件，获取 OSS 信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDyplsOSSInfoForUploadFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDyplsOSSInfoForUploadFileResponse
        /// </returns>
        public async Task<GetDyplsOSSInfoForUploadFileResponse> GetDyplsOSSInfoForUploadFileWithOptionsAsync(GetDyplsOSSInfoForUploadFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
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
                Action = "GetDyplsOSSInfoForUploadFile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetDyplsOSSInfoForUploadFileResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetDyplsOSSInfoForUploadFileResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>隐私号上传文件，获取 OSS 信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDyplsOSSInfoForUploadFileRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDyplsOSSInfoForUploadFileResponse
        /// </returns>
        public GetDyplsOSSInfoForUploadFileResponse GetDyplsOSSInfoForUploadFile(GetDyplsOSSInfoForUploadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDyplsOSSInfoForUploadFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>隐私号上传文件，获取 OSS 信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDyplsOSSInfoForUploadFileRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDyplsOSSInfoForUploadFileResponse
        /// </returns>
        public async Task<GetDyplsOSSInfoForUploadFileResponse> GetDyplsOSSInfoForUploadFileAsync(GetDyplsOSSInfoForUploadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDyplsOSSInfoForUploadFileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of the automatic speech recognition (ASR) result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call the GetSecretAsrDetail operation, set the ASRStatus parameter to true in the <a href="https://help.aliyun.com/document_detail/400483.html">BindAxn operation</a>. This ensures that you can obtain the ASR result properly.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSecretAsrDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecretAsrDetailResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetSecretAsrDetailResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetSecretAsrDetailResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of the automatic speech recognition (ASR) result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call the GetSecretAsrDetail operation, set the ASRStatus parameter to true in the <a href="https://help.aliyun.com/document_detail/400483.html">BindAxn operation</a>. This ensures that you can obtain the ASR result properly.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSecretAsrDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecretAsrDetailResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetSecretAsrDetailResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetSecretAsrDetailResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of the automatic speech recognition (ASR) result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call the GetSecretAsrDetail operation, set the ASRStatus parameter to true in the <a href="https://help.aliyun.com/document_detail/400483.html">BindAxn operation</a>. This ensures that you can obtain the ASR result properly.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSecretAsrDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecretAsrDetailResponse
        /// </returns>
        public GetSecretAsrDetailResponse GetSecretAsrDetail(GetSecretAsrDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSecretAsrDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of the automatic speech recognition (ASR) result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call the GetSecretAsrDetail operation, set the ASRStatus parameter to true in the <a href="https://help.aliyun.com/document_detail/400483.html">BindAxn operation</a>. This ensures that you can obtain the ASR result properly.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSecretAsrDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecretAsrDetailResponse
        /// </returns>
        public async Task<GetSecretAsrDetailResponse> GetSecretAsrDetailAsync(GetSecretAsrDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSecretAsrDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the download URL of a recorded ringing tone.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTotalPublicUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTotalPublicUrlResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetTotalPublicUrlResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetTotalPublicUrlResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the download URL of a recorded ringing tone.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTotalPublicUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTotalPublicUrlResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetTotalPublicUrlResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetTotalPublicUrlResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the download URL of a recorded ringing tone.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTotalPublicUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTotalPublicUrlResponse
        /// </returns>
        public GetTotalPublicUrlResponse GetTotalPublicUrl(GetTotalPublicUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTotalPublicUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the download URL of a recorded ringing tone.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTotalPublicUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTotalPublicUrlResponse
        /// </returns>
        public async Task<GetTotalPublicUrlResponse> GetTotalPublicUrlAsync(GetTotalPublicUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTotalPublicUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取X号码配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetXConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetXConfigResponse
        /// </returns>
        public GetXConfigResponse GetXConfigWithOptions(GetXConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerPoolKey))
            {
                query["CustomerPoolKey"] = request.CustomerPoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelX))
            {
                query["TelX"] = request.TelX;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetXConfig",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetXConfigResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetXConfigResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取X号码配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetXConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetXConfigResponse
        /// </returns>
        public async Task<GetXConfigResponse> GetXConfigWithOptionsAsync(GetXConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerPoolKey))
            {
                query["CustomerPoolKey"] = request.CustomerPoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelX))
            {
                query["TelX"] = request.TelX;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetXConfig",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetXConfigResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetXConfigResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取X号码配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetXConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetXConfigResponse
        /// </returns>
        public GetXConfigResponse GetXConfig(GetXConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetXConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取X号码配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetXConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetXConfigResponse
        /// </returns>
        public async Task<GetXConfigResponse> GetXConfigAsync(GetXConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetXConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取X号码默认配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetXDefaultConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetXDefaultConfigResponse
        /// </returns>
        public GetXDefaultConfigResponse GetXDefaultConfigWithOptions(GetXDefaultConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerPoolKey))
            {
                query["CustomerPoolKey"] = request.CustomerPoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelX))
            {
                query["TelX"] = request.TelX;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetXDefaultConfig",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetXDefaultConfigResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetXDefaultConfigResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取X号码默认配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetXDefaultConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetXDefaultConfigResponse
        /// </returns>
        public async Task<GetXDefaultConfigResponse> GetXDefaultConfigWithOptionsAsync(GetXDefaultConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerPoolKey))
            {
                query["CustomerPoolKey"] = request.CustomerPoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelX))
            {
                query["TelX"] = request.TelX;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetXDefaultConfig",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetXDefaultConfigResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetXDefaultConfigResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取X号码默认配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetXDefaultConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetXDefaultConfigResponse
        /// </returns>
        public GetXDefaultConfigResponse GetXDefaultConfig(GetXDefaultConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetXDefaultConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取X号码默认配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetXDefaultConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetXDefaultConfigResponse
        /// </returns>
        public async Task<GetXDefaultConfigResponse> GetXDefaultConfigAsync(GetXDefaultConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetXDefaultConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询客户名下X号码列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListXTelephonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListXTelephonesResponse
        /// </returns>
        public ListXTelephonesResponse ListXTelephonesWithOptions(ListXTelephonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerPoolKey))
            {
                query["CustomerPoolKey"] = request.CustomerPoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
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
                Action = "ListXTelephones",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListXTelephonesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListXTelephonesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询客户名下X号码列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListXTelephonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListXTelephonesResponse
        /// </returns>
        public async Task<ListXTelephonesResponse> ListXTelephonesWithOptionsAsync(ListXTelephonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerPoolKey))
            {
                query["CustomerPoolKey"] = request.CustomerPoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
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
                Action = "ListXTelephones",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListXTelephonesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListXTelephonesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询客户名下X号码列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListXTelephonesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListXTelephonesResponse
        /// </returns>
        public ListXTelephonesResponse ListXTelephones(ListXTelephonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListXTelephonesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询客户名下X号码列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListXTelephonesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListXTelephonesResponse
        /// </returns>
        public async Task<ListXTelephonesResponse> ListXTelephonesAsync(ListXTelephonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListXTelephonesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Locks a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a phone number is locked, the locked phone number cannot be selected when you call an operation to create a binding.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// LockSecretNoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LockSecretNoResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<LockSecretNoResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<LockSecretNoResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Locks a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a phone number is locked, the locked phone number cannot be selected when you call an operation to create a binding.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// LockSecretNoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LockSecretNoResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<LockSecretNoResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<LockSecretNoResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Locks a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a phone number is locked, the locked phone number cannot be selected when you call an operation to create a binding.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// LockSecretNoRequest
        /// </param>
        /// 
        /// <returns>
        /// LockSecretNoResponse
        /// </returns>
        public LockSecretNoResponse LockSecretNo(LockSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LockSecretNoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Locks a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a phone number is locked, the locked phone number cannot be selected when you call an operation to create a binding.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// LockSecretNoRequest
        /// </param>
        /// 
        /// <returns>
        /// LockSecretNoResponse
        /// </returns>
        public async Task<LockSecretNoResponse> LockSecretNoAsync(LockSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LockSecretNoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies number group G.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create number group G, you can call the OperateAxgGroup operation to modify number group G. For example, you can add phone numbers to number group G, delete phone numbers from number group G, and replace all phone numbers in number group G.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// OperateAxgGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateAxgGroupResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<OperateAxgGroupResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<OperateAxgGroupResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies number group G.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create number group G, you can call the OperateAxgGroup operation to modify number group G. For example, you can add phone numbers to number group G, delete phone numbers from number group G, and replace all phone numbers in number group G.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// OperateAxgGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateAxgGroupResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<OperateAxgGroupResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<OperateAxgGroupResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies number group G.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create number group G, you can call the OperateAxgGroup operation to modify number group G. For example, you can add phone numbers to number group G, delete phone numbers from number group G, and replace all phone numbers in number group G.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// OperateAxgGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateAxgGroupResponse
        /// </returns>
        public OperateAxgGroupResponse OperateAxgGroup(OperateAxgGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateAxgGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies number group G.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create number group G, you can call the OperateAxgGroup operation to modify number group G. For example, you can add phone numbers to number group G, delete phone numbers from number group G, and replace all phone numbers in number group G.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// OperateAxgGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateAxgGroupResponse
        /// </returns>
        public async Task<OperateAxgGroupResponse> OperateAxgGroupAsync(OperateAxgGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateAxgGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a phone number to a blacklist or deletes a phone number from a blacklist.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The OperateBlackNo operation supports the following number pool types: AXN, AXN extension, and 95AXN.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// OperateBlackNoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateBlackNoResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<OperateBlackNoResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<OperateBlackNoResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a phone number to a blacklist or deletes a phone number from a blacklist.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The OperateBlackNo operation supports the following number pool types: AXN, AXN extension, and 95AXN.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// OperateBlackNoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateBlackNoResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<OperateBlackNoResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<OperateBlackNoResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a phone number to a blacklist or deletes a phone number from a blacklist.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The OperateBlackNo operation supports the following number pool types: AXN, AXN extension, and 95AXN.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// OperateBlackNoRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateBlackNoResponse
        /// </returns>
        public OperateBlackNoResponse OperateBlackNo(OperateBlackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateBlackNoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a phone number to a blacklist or deletes a phone number from a blacklist.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The OperateBlackNo operation supports the following number pool types: AXN, AXN extension, and 95AXN.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// OperateBlackNoRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateBlackNoResponse
        /// </returns>
        public async Task<OperateBlackNoResponse> OperateBlackNoAsync(OperateBlackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateBlackNoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a tracking number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryPhoneNoAByTrackNoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPhoneNoAByTrackNoResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryPhoneNoAByTrackNoResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryPhoneNoAByTrackNoResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a tracking number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryPhoneNoAByTrackNoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPhoneNoAByTrackNoResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryPhoneNoAByTrackNoResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryPhoneNoAByTrackNoResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a tracking number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryPhoneNoAByTrackNoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPhoneNoAByTrackNoResponse
        /// </returns>
        public QueryPhoneNoAByTrackNoResponse QueryPhoneNoAByTrackNo(QueryPhoneNoAByTrackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPhoneNoAByTrackNoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a tracking number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryPhoneNoAByTrackNoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPhoneNoAByTrackNoResponse
        /// </returns>
        public async Task<QueryPhoneNoAByTrackNoResponse> QueryPhoneNoAByTrackNoAsync(QueryPhoneNoAByTrackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPhoneNoAByTrackNoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the download URL of a recording file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the recording feature is enabled for a binding, all calls made by the bound phone numbers are recorded. You can obtain the download URL of a recording file by calling the QueryRecordFileDownloadUrl operation and download the recording file.</para>
        /// <remarks>
        /// <para> We recommend that you subscribe to <a href="https://help.aliyun.com/document_detail/109198.html">the recording status report SecretRecording</a>. The values of the response parameters in SecretRecording can be used as the values of the request parameters for downloading a recording file.</para>
        /// </remarks>
        /// <h3><a href="#"></a>Procedure for obtaining a recording file</h3>
        /// <ol>
        /// <item><description>Specify the request parameter in an update or binding operation to enable the recording feature.</description></item>
        /// <item><description>Subscribe to recording message receipts in the Phone Number Protection console.</description></item>
        /// <item><description>After a recording message receipt is returned, call the QueryRecordFileDownloadUrl operation to obtain the download URL of the recording file, and download the recording file.<remarks>
        /// </remarks>
        /// </description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>A download URL is valid for 2 hours. Download the recording file as soon as possible after obtaining a download URL.</description></item>
        /// <item><description>The storage period of recording files is 30 days. You can download only the recording files of calls recorded in the last 30 days.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRecordFileDownloadUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRecordFileDownloadUrlResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryRecordFileDownloadUrlResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryRecordFileDownloadUrlResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the download URL of a recording file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the recording feature is enabled for a binding, all calls made by the bound phone numbers are recorded. You can obtain the download URL of a recording file by calling the QueryRecordFileDownloadUrl operation and download the recording file.</para>
        /// <remarks>
        /// <para> We recommend that you subscribe to <a href="https://help.aliyun.com/document_detail/109198.html">the recording status report SecretRecording</a>. The values of the response parameters in SecretRecording can be used as the values of the request parameters for downloading a recording file.</para>
        /// </remarks>
        /// <h3><a href="#"></a>Procedure for obtaining a recording file</h3>
        /// <ol>
        /// <item><description>Specify the request parameter in an update or binding operation to enable the recording feature.</description></item>
        /// <item><description>Subscribe to recording message receipts in the Phone Number Protection console.</description></item>
        /// <item><description>After a recording message receipt is returned, call the QueryRecordFileDownloadUrl operation to obtain the download URL of the recording file, and download the recording file.<remarks>
        /// </remarks>
        /// </description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>A download URL is valid for 2 hours. Download the recording file as soon as possible after obtaining a download URL.</description></item>
        /// <item><description>The storage period of recording files is 30 days. You can download only the recording files of calls recorded in the last 30 days.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRecordFileDownloadUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRecordFileDownloadUrlResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryRecordFileDownloadUrlResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryRecordFileDownloadUrlResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the download URL of a recording file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the recording feature is enabled for a binding, all calls made by the bound phone numbers are recorded. You can obtain the download URL of a recording file by calling the QueryRecordFileDownloadUrl operation and download the recording file.</para>
        /// <remarks>
        /// <para> We recommend that you subscribe to <a href="https://help.aliyun.com/document_detail/109198.html">the recording status report SecretRecording</a>. The values of the response parameters in SecretRecording can be used as the values of the request parameters for downloading a recording file.</para>
        /// </remarks>
        /// <h3><a href="#"></a>Procedure for obtaining a recording file</h3>
        /// <ol>
        /// <item><description>Specify the request parameter in an update or binding operation to enable the recording feature.</description></item>
        /// <item><description>Subscribe to recording message receipts in the Phone Number Protection console.</description></item>
        /// <item><description>After a recording message receipt is returned, call the QueryRecordFileDownloadUrl operation to obtain the download URL of the recording file, and download the recording file.<remarks>
        /// </remarks>
        /// </description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>A download URL is valid for 2 hours. Download the recording file as soon as possible after obtaining a download URL.</description></item>
        /// <item><description>The storage period of recording files is 30 days. You can download only the recording files of calls recorded in the last 30 days.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRecordFileDownloadUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRecordFileDownloadUrlResponse
        /// </returns>
        public QueryRecordFileDownloadUrlResponse QueryRecordFileDownloadUrl(QueryRecordFileDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRecordFileDownloadUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the download URL of a recording file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the recording feature is enabled for a binding, all calls made by the bound phone numbers are recorded. You can obtain the download URL of a recording file by calling the QueryRecordFileDownloadUrl operation and download the recording file.</para>
        /// <remarks>
        /// <para> We recommend that you subscribe to <a href="https://help.aliyun.com/document_detail/109198.html">the recording status report SecretRecording</a>. The values of the response parameters in SecretRecording can be used as the values of the request parameters for downloading a recording file.</para>
        /// </remarks>
        /// <h3><a href="#"></a>Procedure for obtaining a recording file</h3>
        /// <ol>
        /// <item><description>Specify the request parameter in an update or binding operation to enable the recording feature.</description></item>
        /// <item><description>Subscribe to recording message receipts in the Phone Number Protection console.</description></item>
        /// <item><description>After a recording message receipt is returned, call the QueryRecordFileDownloadUrl operation to obtain the download URL of the recording file, and download the recording file.<remarks>
        /// </remarks>
        /// </description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>A download URL is valid for 2 hours. Download the recording file as soon as possible after obtaining a download URL.</description></item>
        /// <item><description>The storage period of recording files is 30 days. You can download only the recording files of calls recorded in the last 30 days.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRecordFileDownloadUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRecordFileDownloadUrlResponse
        /// </returns>
        public async Task<QueryRecordFileDownloadUrlResponse> QueryRecordFileDownloadUrlAsync(QueryRecordFileDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRecordFileDownloadUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the attributes of a private number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySecretNoDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySecretNoDetailResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QuerySecretNoDetailResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QuerySecretNoDetailResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the attributes of a private number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySecretNoDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySecretNoDetailResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QuerySecretNoDetailResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QuerySecretNoDetailResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the attributes of a private number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySecretNoDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySecretNoDetailResponse
        /// </returns>
        public QuerySecretNoDetailResponse QuerySecretNoDetail(QuerySecretNoDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySecretNoDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the attributes of a private number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySecretNoDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySecretNoDetailResponse
        /// </returns>
        public async Task<QuerySecretNoDetailResponse> QuerySecretNoDetailAsync(QuerySecretNoDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySecretNoDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quantity of remaining phone numbers available for online purchase.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When purchasing a phone number, specify the home location. If no sufficient phone numbers are available for purchase in the home location, the purchase of the phone number fails. Before calling the <a href="~~BuySecretNo~~">BuySecretNo</a> operation to purchase a phone number, call the <a href="~~QuerySecretNoRemain~~">QuerySecretNoRemain</a> operation to query the quantity of remaining phone numbers available for online purchase.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySecretNoRemainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySecretNoRemainResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QuerySecretNoRemainResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QuerySecretNoRemainResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quantity of remaining phone numbers available for online purchase.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When purchasing a phone number, specify the home location. If no sufficient phone numbers are available for purchase in the home location, the purchase of the phone number fails. Before calling the <a href="~~BuySecretNo~~">BuySecretNo</a> operation to purchase a phone number, call the <a href="~~QuerySecretNoRemain~~">QuerySecretNoRemain</a> operation to query the quantity of remaining phone numbers available for online purchase.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySecretNoRemainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySecretNoRemainResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QuerySecretNoRemainResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QuerySecretNoRemainResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quantity of remaining phone numbers available for online purchase.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When purchasing a phone number, specify the home location. If no sufficient phone numbers are available for purchase in the home location, the purchase of the phone number fails. Before calling the <a href="~~BuySecretNo~~">BuySecretNo</a> operation to purchase a phone number, call the <a href="~~QuerySecretNoRemain~~">QuerySecretNoRemain</a> operation to query the quantity of remaining phone numbers available for online purchase.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySecretNoRemainRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySecretNoRemainResponse
        /// </returns>
        public QuerySecretNoRemainResponse QuerySecretNoRemain(QuerySecretNoRemainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySecretNoRemainWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quantity of remaining phone numbers available for online purchase.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When purchasing a phone number, specify the home location. If no sufficient phone numbers are available for purchase in the home location, the purchase of the phone number fails. Before calling the <a href="~~BuySecretNo~~">BuySecretNo</a> operation to purchase a phone number, call the <a href="~~QuerySecretNoRemain~~">QuerySecretNoRemain</a> operation to query the quantity of remaining phone numbers available for online purchase.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySecretNoRemainRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySecretNoRemainResponse
        /// </returns>
        public async Task<QuerySecretNoRemainResponse> QuerySecretNoRemainAsync(QuerySecretNoRemainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySecretNoRemainWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询通话录音链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySoundRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySoundRecordResponse
        /// </returns>
        public QuerySoundRecordResponse QuerySoundRecordWithOptions(QuerySoundRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerPoolKey))
            {
                query["CustomerPoolKey"] = request.CustomerPoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
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
                Action = "QuerySoundRecord",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QuerySoundRecordResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QuerySoundRecordResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询通话录音链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySoundRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySoundRecordResponse
        /// </returns>
        public async Task<QuerySoundRecordResponse> QuerySoundRecordWithOptionsAsync(QuerySoundRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerPoolKey))
            {
                query["CustomerPoolKey"] = request.CustomerPoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
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
                Action = "QuerySoundRecord",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QuerySoundRecordResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QuerySoundRecordResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询通话录音链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySoundRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySoundRecordResponse
        /// </returns>
        public QuerySoundRecordResponse QuerySoundRecord(QuerySoundRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySoundRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询通话录音链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySoundRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySoundRecordResponse
        /// </returns>
        public async Task<QuerySoundRecordResponse> QuerySoundRecordAsync(QuerySoundRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySoundRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries binding IDs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query binding IDs by phone number X. In the AXB product, multiple bindings may exist for the same phone number X. In this case, multiple binding IDs may be obtained for the same phone number X.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySubsIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySubsIdResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QuerySubsIdResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QuerySubsIdResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries binding IDs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query binding IDs by phone number X. In the AXB product, multiple bindings may exist for the same phone number X. In this case, multiple binding IDs may be obtained for the same phone number X.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySubsIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySubsIdResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QuerySubsIdResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QuerySubsIdResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries binding IDs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query binding IDs by phone number X. In the AXB product, multiple bindings may exist for the same phone number X. In this case, multiple binding IDs may be obtained for the same phone number X.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySubsIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySubsIdResponse
        /// </returns>
        public QuerySubsIdResponse QuerySubsId(QuerySubsIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySubsIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries binding IDs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query binding IDs by phone number X. In the AXB product, multiple bindings may exist for the same phone number X. In this case, multiple binding IDs may be obtained for the same phone number X.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySubsIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySubsIdResponse
        /// </returns>
        public async Task<QuerySubsIdResponse> QuerySubsIdAsync(QuerySubsIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySubsIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a phone number binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// <h3><a href="#poolkeyproducttype"></a>Limits on PoolKey and ProductType</h3>
        /// <para>You must specify either PoolKey or ProductType. If both parameters are not specified, an error is reported when you call the QuerySubscriptionDetail operation. We recommend that you specify the ProductType parameter for the original key accounts of Alibaba Cloud and the PoolKey parameter for Alibaba Cloud users.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySubscriptionDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySubscriptionDetailResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QuerySubscriptionDetailResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QuerySubscriptionDetailResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a phone number binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// <h3><a href="#poolkeyproducttype"></a>Limits on PoolKey and ProductType</h3>
        /// <para>You must specify either PoolKey or ProductType. If both parameters are not specified, an error is reported when you call the QuerySubscriptionDetail operation. We recommend that you specify the ProductType parameter for the original key accounts of Alibaba Cloud and the PoolKey parameter for Alibaba Cloud users.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySubscriptionDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySubscriptionDetailResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QuerySubscriptionDetailResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QuerySubscriptionDetailResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a phone number binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// <h3><a href="#poolkeyproducttype"></a>Limits on PoolKey and ProductType</h3>
        /// <para>You must specify either PoolKey or ProductType. If both parameters are not specified, an error is reported when you call the QuerySubscriptionDetail operation. We recommend that you specify the ProductType parameter for the original key accounts of Alibaba Cloud and the PoolKey parameter for Alibaba Cloud users.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySubscriptionDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySubscriptionDetailResponse
        /// </returns>
        public QuerySubscriptionDetailResponse QuerySubscriptionDetail(QuerySubscriptionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySubscriptionDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a phone number binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// <h3><a href="#poolkeyproducttype"></a>Limits on PoolKey and ProductType</h3>
        /// <para>You must specify either PoolKey or ProductType. If both parameters are not specified, an error is reported when you call the QuerySubscriptionDetail operation. We recommend that you specify the ProductType parameter for the original key accounts of Alibaba Cloud and the PoolKey parameter for Alibaba Cloud users.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySubscriptionDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySubscriptionDetailResponse
        /// </returns>
        public async Task<QuerySubscriptionDetailResponse> QuerySubscriptionDetailAsync(QuerySubscriptionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySubscriptionDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After a phone number is released, it will no longer be charged from the following month.</para>
        /// <list type="bullet">
        /// <item><description>Before you release a phone number, log on to the <a href="https://dypls.console.aliyun.com/dypls.htm#/account">Phone Number Protection console</a> to check whether the phone number is bound to other phone numbers. The phone number can be released only if it is not bound to other phone numbers.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleaseSecretNoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseSecretNoResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ReleaseSecretNoResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ReleaseSecretNoResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After a phone number is released, it will no longer be charged from the following month.</para>
        /// <list type="bullet">
        /// <item><description>Before you release a phone number, log on to the <a href="https://dypls.console.aliyun.com/dypls.htm#/account">Phone Number Protection console</a> to check whether the phone number is bound to other phone numbers. The phone number can be released only if it is not bound to other phone numbers.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleaseSecretNoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseSecretNoResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ReleaseSecretNoResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ReleaseSecretNoResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After a phone number is released, it will no longer be charged from the following month.</para>
        /// <list type="bullet">
        /// <item><description>Before you release a phone number, log on to the <a href="https://dypls.console.aliyun.com/dypls.htm#/account">Phone Number Protection console</a> to check whether the phone number is bound to other phone numbers. The phone number can be released only if it is not bound to other phone numbers.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleaseSecretNoRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseSecretNoResponse
        /// </returns>
        public ReleaseSecretNoResponse ReleaseSecretNo(ReleaseSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseSecretNoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After a phone number is released, it will no longer be charged from the following month.</para>
        /// <list type="bullet">
        /// <item><description>Before you release a phone number, log on to the <a href="https://dypls.console.aliyun.com/dypls.htm#/account">Phone Number Protection console</a> to check whether the phone number is bound to other phone numbers. The phone number can be released only if it is not bound to other phone numbers.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleaseSecretNoRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseSecretNoResponse
        /// </returns>
        public async Task<ReleaseSecretNoResponse> ReleaseSecretNoAsync(ReleaseSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseSecretNoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解除指定的呼叫绑定关系（A，X，B），解决呼叫绑定关系后，员工B不能通过工作号X呼叫到客户A。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnBindAXBRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnBindAXBResponse
        /// </returns>
        public UnBindAXBResponse UnBindAXBWithOptions(UnBindAXBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindId))
            {
                query["BindId"] = request.BindId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerPoolKey))
            {
                query["CustomerPoolKey"] = request.CustomerPoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
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
                Action = "UnBindAXB",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UnBindAXBResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UnBindAXBResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解除指定的呼叫绑定关系（A，X，B），解决呼叫绑定关系后，员工B不能通过工作号X呼叫到客户A。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnBindAXBRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnBindAXBResponse
        /// </returns>
        public async Task<UnBindAXBResponse> UnBindAXBWithOptionsAsync(UnBindAXBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindId))
            {
                query["BindId"] = request.BindId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerPoolKey))
            {
                query["CustomerPoolKey"] = request.CustomerPoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
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
                Action = "UnBindAXB",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UnBindAXBResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UnBindAXBResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解除指定的呼叫绑定关系（A，X，B），解决呼叫绑定关系后，员工B不能通过工作号X呼叫到客户A。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnBindAXBRequest
        /// </param>
        /// 
        /// <returns>
        /// UnBindAXBResponse
        /// </returns>
        public UnBindAXBResponse UnBindAXB(UnBindAXBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnBindAXBWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解除指定的呼叫绑定关系（A，X，B），解决呼叫绑定关系后，员工B不能通过工作号X呼叫到客户A。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnBindAXBRequest
        /// </param>
        /// 
        /// <returns>
        /// UnBindAXBResponse
        /// </returns>
        public async Task<UnBindAXBResponse> UnBindAXBAsync(UnBindAXBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnBindAXBWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用本接口可取消工作号X与员工号码B的绑定。绑定解除后，对X的呼叫都不会转接给B。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnBindXBRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnBindXBResponse
        /// </returns>
        public UnBindXBResponse UnBindXBWithOptions(UnBindXBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthId))
            {
                query["AuthId"] = request.AuthId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerPoolKey))
            {
                query["CustomerPoolKey"] = request.CustomerPoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelX))
            {
                query["TelX"] = request.TelX;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnBindXB",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UnBindXBResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UnBindXBResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用本接口可取消工作号X与员工号码B的绑定。绑定解除后，对X的呼叫都不会转接给B。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnBindXBRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnBindXBResponse
        /// </returns>
        public async Task<UnBindXBResponse> UnBindXBWithOptionsAsync(UnBindXBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthId))
            {
                query["AuthId"] = request.AuthId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerPoolKey))
            {
                query["CustomerPoolKey"] = request.CustomerPoolKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelX))
            {
                query["TelX"] = request.TelX;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnBindXB",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UnBindXBResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UnBindXBResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用本接口可取消工作号X与员工号码B的绑定。绑定解除后，对X的呼叫都不会转接给B。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnBindXBRequest
        /// </param>
        /// 
        /// <returns>
        /// UnBindXBResponse
        /// </returns>
        public UnBindXBResponse UnBindXB(UnBindXBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnBindXBWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用本接口可取消工作号X与员工号码B的绑定。绑定解除后，对X的呼叫都不会转接给B。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnBindXBRequest
        /// </param>
        /// 
        /// <returns>
        /// UnBindXBResponse
        /// </returns>
        public async Task<UnBindXBResponse> UnBindXBAsync(UnBindXBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnBindXBWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before releasing a phone number, you must call the UnbindSubscription operation to unbind the phone number.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UnbindSubscriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindSubscriptionResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UnbindSubscriptionResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UnbindSubscriptionResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before releasing a phone number, you must call the UnbindSubscription operation to unbind the phone number.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UnbindSubscriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindSubscriptionResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UnbindSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UnbindSubscriptionResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before releasing a phone number, you must call the UnbindSubscription operation to unbind the phone number.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UnbindSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindSubscriptionResponse
        /// </returns>
        public UnbindSubscriptionResponse UnbindSubscription(UnbindSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindSubscriptionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before releasing a phone number, you must call the UnbindSubscription operation to unbind the phone number.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UnbindSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindSubscriptionResponse
        /// </returns>
        public async Task<UnbindSubscriptionResponse> UnbindSubscriptionAsync(UnbindSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindSubscriptionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unlocks a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a phone number is unlocked, you can reselect the unlocked phone number when you call an operation to create a binding.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UnlockSecretNoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnlockSecretNoResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UnlockSecretNoResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UnlockSecretNoResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unlocks a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a phone number is unlocked, you can reselect the unlocked phone number when you call an operation to create a binding.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UnlockSecretNoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnlockSecretNoResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UnlockSecretNoResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UnlockSecretNoResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unlocks a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a phone number is unlocked, you can reselect the unlocked phone number when you call an operation to create a binding.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UnlockSecretNoRequest
        /// </param>
        /// 
        /// <returns>
        /// UnlockSecretNoResponse
        /// </returns>
        public UnlockSecretNoResponse UnlockSecretNo(UnlockSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnlockSecretNoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unlocks a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a phone number is unlocked, you can reselect the unlocked phone number when you call an operation to create a binding.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UnlockSecretNoRequest
        /// </param>
        /// 
        /// <returns>
        /// UnlockSecretNoResponse
        /// </returns>
        public async Task<UnlockSecretNoResponse> UnlockSecretNoAsync(UnlockSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnlockSecretNoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a phone number binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 10,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSubscriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSubscriptionResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateSubscriptionResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateSubscriptionResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a phone number binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 10,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSubscriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSubscriptionResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateSubscriptionResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a phone number binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 10,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSubscriptionResponse
        /// </returns>
        public UpdateSubscriptionResponse UpdateSubscription(UpdateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSubscriptionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a phone number binding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 10,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSubscriptionResponse
        /// </returns>
        public async Task<UpdateSubscriptionResponse> UpdateSubscriptionAsync(UpdateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSubscriptionWithOptionsAsync(request, runtime);
        }

    }
}
