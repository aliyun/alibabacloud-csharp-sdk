// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Push20160801.Models;

namespace AlibabaCloud.SDK.Push20160801
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "cloudpush.aliyuncs.com"},
                {"ap-northeast-2-pop", "cloudpush.aliyuncs.com"},
                {"ap-south-1", "cloudpush.aliyuncs.com"},
                {"ap-southeast-1", "cloudpush.aliyuncs.com"},
                {"ap-southeast-2", "cloudpush.aliyuncs.com"},
                {"ap-southeast-3", "cloudpush.aliyuncs.com"},
                {"ap-southeast-5", "cloudpush.aliyuncs.com"},
                {"cn-beijing", "cloudpush.aliyuncs.com"},
                {"cn-beijing-finance-1", "cloudpush.aliyuncs.com"},
                {"cn-beijing-finance-pop", "cloudpush.aliyuncs.com"},
                {"cn-beijing-gov-1", "cloudpush.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "cloudpush.aliyuncs.com"},
                {"cn-chengdu", "cloudpush.aliyuncs.com"},
                {"cn-edge-1", "cloudpush.aliyuncs.com"},
                {"cn-fujian", "cloudpush.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou-finance", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou-test-306", "cloudpush.aliyuncs.com"},
                {"cn-hongkong", "cloudpush.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "cloudpush.aliyuncs.com"},
                {"cn-huhehaote", "cloudpush.aliyuncs.com"},
                {"cn-north-2-gov-1", "cloudpush.aliyuncs.com"},
                {"cn-qingdao", "cloudpush.aliyuncs.com"},
                {"cn-qingdao-nebula", "cloudpush.aliyuncs.com"},
                {"cn-shanghai", "cloudpush.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "cloudpush.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "cloudpush.aliyuncs.com"},
                {"cn-shanghai-finance-1", "cloudpush.aliyuncs.com"},
                {"cn-shanghai-inner", "cloudpush.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "cloudpush.aliyuncs.com"},
                {"cn-shenzhen", "cloudpush.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "cloudpush.aliyuncs.com"},
                {"cn-shenzhen-inner", "cloudpush.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "cloudpush.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "cloudpush.aliyuncs.com"},
                {"cn-wuhan", "cloudpush.aliyuncs.com"},
                {"cn-yushanfang", "cloudpush.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "cloudpush.aliyuncs.com"},
                {"cn-zhangjiakou", "cloudpush.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "cloudpush.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "cloudpush.aliyuncs.com"},
                {"eu-central-1", "cloudpush.aliyuncs.com"},
                {"eu-west-1", "cloudpush.aliyuncs.com"},
                {"eu-west-1-oxs", "cloudpush.aliyuncs.com"},
                {"me-east-1", "cloudpush.aliyuncs.com"},
                {"rus-west-1-pop", "cloudpush.aliyuncs.com"},
                {"us-east-1", "cloudpush.aliyuncs.com"},
                {"us-west-1", "cloudpush.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("push", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Attach an alias to a device.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can attach up to 10 aliases in a single request. The attachment takes effect immediately.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BindAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindAliasResponse
        /// </returns>
        public BindAliasResponse BindAliasWithOptions(BindAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                query["AliasName"] = request.AliasName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAlias",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAliasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Attach an alias to a device.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can attach up to 10 aliases in a single request. The attachment takes effect immediately.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BindAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindAliasResponse
        /// </returns>
        public async Task<BindAliasResponse> BindAliasWithOptionsAsync(BindAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                query["AliasName"] = request.AliasName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAlias",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Attach an alias to a device.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can attach up to 10 aliases in a single request. The attachment takes effect immediately.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BindAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// BindAliasResponse
        /// </returns>
        public BindAliasResponse BindAlias(BindAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAliasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Attach an alias to a device.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can attach up to 10 aliases in a single request. The attachment takes effect immediately.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BindAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// BindAliasResponse
        /// </returns>
        public async Task<BindAliasResponse> BindAliasAsync(BindAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAliasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Attaches a device to a phone number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindPhoneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindPhoneResponse
        /// </returns>
        public BindPhoneResponse BindPhoneWithOptions(BindPhoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindPhone",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindPhoneResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Attaches a device to a phone number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindPhoneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindPhoneResponse
        /// </returns>
        public async Task<BindPhoneResponse> BindPhoneWithOptionsAsync(BindPhoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindPhone",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindPhoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Attaches a device to a phone number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindPhoneRequest
        /// </param>
        /// 
        /// <returns>
        /// BindPhoneResponse
        /// </returns>
        public BindPhoneResponse BindPhone(BindPhoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindPhoneWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Attaches a device to a phone number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindPhoneRequest
        /// </param>
        /// 
        /// <returns>
        /// BindPhoneResponse
        /// </returns>
        public async Task<BindPhoneResponse> BindPhoneAsync(BindPhoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindPhoneWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds tags to specified device targets. Tag bindings take effect within 10 minutes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindTagResponse
        /// </returns>
        public BindTagResponse BindTagWithOptions(BindTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientKey))
            {
                query["ClientKey"] = request.ClientKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyType))
            {
                query["KeyType"] = request.KeyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindTag",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds tags to specified device targets. Tag bindings take effect within 10 minutes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindTagResponse
        /// </returns>
        public async Task<BindTagResponse> BindTagWithOptionsAsync(BindTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientKey))
            {
                query["ClientKey"] = request.ClientKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyType))
            {
                query["KeyType"] = request.KeyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindTag",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds tags to specified device targets. Tag bindings take effect within 10 minutes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindTagRequest
        /// </param>
        /// 
        /// <returns>
        /// BindTagResponse
        /// </returns>
        public BindTagResponse BindTag(BindTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds tags to specified device targets. Tag bindings take effect within 10 minutes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindTagRequest
        /// </param>
        /// 
        /// <returns>
        /// BindTagResponse
        /// </returns>
        public async Task<BindTagResponse> BindTagAsync(BindTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindTagWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a scheduled push task that has not yet been executed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelPushRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelPushResponse
        /// </returns>
        public CancelPushResponse CancelPushWithOptions(CancelPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelPush",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelPushResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a scheduled push task that has not yet been executed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelPushRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelPushResponse
        /// </returns>
        public async Task<CancelPushResponse> CancelPushWithOptionsAsync(CancelPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelPush",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelPushResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a scheduled push task that has not yet been executed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelPushRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelPushResponse
        /// </returns>
        public CancelPushResponse CancelPush(CancelPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelPushWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a scheduled push task that has not yet been executed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelPushRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelPushResponse
        /// </returns>
        public async Task<CancelPushResponse> CancelPushAsync(CancelPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelPushWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the expiration time and current status of the iOS certificate for a specified app.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>If the returned ExpireTime value is later than the current timestamp, the certificate is not necessarily valid. Also verify that the Status is OK.</description></item>
        /// <item><description>The REVOKED status originates from the Apple Push Notification service (APNs) server. If a certificate has a REVOKED status, at least one push notification to APNs has failed in the corresponding environment.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckCertificateResponse
        /// </returns>
        public CheckCertificateResponse CheckCertificateWithOptions(CheckCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckCertificate",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckCertificateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the expiration time and current status of the iOS certificate for a specified app.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>If the returned ExpireTime value is later than the current timestamp, the certificate is not necessarily valid. Also verify that the Status is OK.</description></item>
        /// <item><description>The REVOKED status originates from the Apple Push Notification service (APNs) server. If a certificate has a REVOKED status, at least one push notification to APNs has failed in the corresponding environment.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckCertificateResponse
        /// </returns>
        public async Task<CheckCertificateResponse> CheckCertificateWithOptionsAsync(CheckCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckCertificate",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the expiration time and current status of the iOS certificate for a specified app.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>If the returned ExpireTime value is later than the current timestamp, the certificate is not necessarily valid. Also verify that the Status is OK.</description></item>
        /// <item><description>The REVOKED status originates from the Apple Push Notification service (APNs) server. If a certificate has a REVOKED status, at least one push notification to APNs has failed in the corresponding environment.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckCertificateResponse
        /// </returns>
        public CheckCertificateResponse CheckCertificate(CheckCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the expiration time and current status of the iOS certificate for a specified app.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>If the returned ExpireTime value is later than the current timestamp, the certificate is not necessarily valid. Also verify that the Status is OK.</description></item>
        /// <item><description>The REVOKED status originates from the Apple Push Notification service (APNs) server. If a certificate has a REVOKED status, at least one push notification to APNs has failed in the corresponding environment.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckCertificateResponse
        /// </returns>
        public async Task<CheckCertificateResponse> CheckCertificateAsync(CheckCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CheckDevice is deprecated, please use Push::2016-08-01::CheckDevices instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validates the specified (device).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckDeviceResponse
        /// </returns>
        [Obsolete("OpenAPI CheckDevice is deprecated, please use Push::2016-08-01::CheckDevices instead.")]
        // Deprecated
        public CheckDeviceResponse CheckDeviceWithOptions(CheckDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDevice",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDeviceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CheckDevice is deprecated, please use Push::2016-08-01::CheckDevices instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validates the specified (device).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckDeviceResponse
        /// </returns>
        [Obsolete("OpenAPI CheckDevice is deprecated, please use Push::2016-08-01::CheckDevices instead.")]
        // Deprecated
        public async Task<CheckDeviceResponse> CheckDeviceWithOptionsAsync(CheckDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDevice",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CheckDevice is deprecated, please use Push::2016-08-01::CheckDevices instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validates the specified (device).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckDeviceResponse
        /// </returns>
        [Obsolete("OpenAPI CheckDevice is deprecated, please use Push::2016-08-01::CheckDevices instead.")]
        // Deprecated
        public CheckDeviceResponse CheckDevice(CheckDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDeviceWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CheckDevice is deprecated, please use Push::2016-08-01::CheckDevices instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validates the specified (device).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckDeviceResponse
        /// </returns>
        [Obsolete("OpenAPI CheckDevice is deprecated, please use Push::2016-08-01::CheckDevices instead.")]
        // Deprecated
        public async Task<CheckDeviceResponse> CheckDeviceAsync(CheckDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDeviceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validate a specified group of devices.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDevicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckDevicesResponse
        /// </returns>
        public CheckDevicesResponse CheckDevicesWithOptions(CheckDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIds))
            {
                query["DeviceIds"] = request.DeviceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDevices",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDevicesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validate a specified group of devices.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDevicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckDevicesResponse
        /// </returns>
        public async Task<CheckDevicesResponse> CheckDevicesWithOptionsAsync(CheckDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIds))
            {
                query["DeviceIds"] = request.DeviceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDevices",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validate a specified group of devices.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDevicesRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckDevicesResponse
        /// </returns>
        public CheckDevicesResponse CheckDevices(CheckDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDevicesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validate a specified group of devices.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDevicesRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckDevicesResponse
        /// </returns>
        public async Task<CheckDevicesResponse> CheckDevicesAsync(CheckDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDevicesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually ends a continuous push task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you do not call this operation, the continuous push task automatically ends when it reaches its time-to-live (TTL).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CompleteContinuouslyPushRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CompleteContinuouslyPushResponse
        /// </returns>
        public CompleteContinuouslyPushResponse CompleteContinuouslyPushWithOptions(CompleteContinuouslyPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompleteContinuouslyPush",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompleteContinuouslyPushResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually ends a continuous push task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you do not call this operation, the continuous push task automatically ends when it reaches its time-to-live (TTL).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CompleteContinuouslyPushRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CompleteContinuouslyPushResponse
        /// </returns>
        public async Task<CompleteContinuouslyPushResponse> CompleteContinuouslyPushWithOptionsAsync(CompleteContinuouslyPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompleteContinuouslyPush",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompleteContinuouslyPushResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually ends a continuous push task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you do not call this operation, the continuous push task automatically ends when it reaches its time-to-live (TTL).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CompleteContinuouslyPushRequest
        /// </param>
        /// 
        /// <returns>
        /// CompleteContinuouslyPushResponse
        /// </returns>
        public CompleteContinuouslyPushResponse CompleteContinuouslyPush(CompleteContinuouslyPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompleteContinuouslyPushWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually ends a continuous push task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you do not call this operation, the continuous push task automatically ends when it reaches its time-to-live (TTL).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CompleteContinuouslyPushRequest
        /// </param>
        /// 
        /// <returns>
        /// CompleteContinuouslyPushResponse
        /// </returns>
        public async Task<CompleteContinuouslyPushResponse> CompleteContinuouslyPushAsync(CompleteContinuouslyPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompleteContinuouslyPushWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a predefined continuous push task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API addresses the limitations of the <a href="https://help.aliyun.com/document_detail/2249916.html">Push Advanced Push API</a>, where push-by-device, push-by-account, and push-by-alias operations each have a maximum target count per single call.</para>
        /// <list type="bullet">
        /// <item><description>You can use continuous push when your scenario requires sending the same message to many devices. In this case, you can call the continuous push API repeatedly, each time specifying a group of targets for aggregation (the current limit is 1,000 targets per call for device, account, or alias pushes). The total number of pushes for the same MessageId is restricted to 10,000. If you need a higher limit, contact technical support to evaluate your specific scenario.</description></item>
        /// <item><description>Before using this API, you must first call the Push API with Target set to TBD (To Be Determined) and include your message content. This returns a MessageId from the push system. You can then use this MessageId to repeatedly call the continuous push API, specifying different target groups to deliver the same message.</description></item>
        /// <item><description>After calling the Push API with Target set to TBD and obtaining a MessageId, the message is stored in the push system for 24 hours by default. You can use this API to push to specified targets at any time before expiration. Pushes are not allowed after expiration or after reaching the total push limit.</description></item>
        /// <item><description>Each call to this API sends the message immediately. Scheduled pushes are not supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ContinuouslyPushRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ContinuouslyPushResponse
        /// </returns>
        public ContinuouslyPushResponse ContinuouslyPushWithOptions(ContinuouslyPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ContinuouslyPush",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContinuouslyPushResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a predefined continuous push task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API addresses the limitations of the <a href="https://help.aliyun.com/document_detail/2249916.html">Push Advanced Push API</a>, where push-by-device, push-by-account, and push-by-alias operations each have a maximum target count per single call.</para>
        /// <list type="bullet">
        /// <item><description>You can use continuous push when your scenario requires sending the same message to many devices. In this case, you can call the continuous push API repeatedly, each time specifying a group of targets for aggregation (the current limit is 1,000 targets per call for device, account, or alias pushes). The total number of pushes for the same MessageId is restricted to 10,000. If you need a higher limit, contact technical support to evaluate your specific scenario.</description></item>
        /// <item><description>Before using this API, you must first call the Push API with Target set to TBD (To Be Determined) and include your message content. This returns a MessageId from the push system. You can then use this MessageId to repeatedly call the continuous push API, specifying different target groups to deliver the same message.</description></item>
        /// <item><description>After calling the Push API with Target set to TBD and obtaining a MessageId, the message is stored in the push system for 24 hours by default. You can use this API to push to specified targets at any time before expiration. Pushes are not allowed after expiration or after reaching the total push limit.</description></item>
        /// <item><description>Each call to this API sends the message immediately. Scheduled pushes are not supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ContinuouslyPushRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ContinuouslyPushResponse
        /// </returns>
        public async Task<ContinuouslyPushResponse> ContinuouslyPushWithOptionsAsync(ContinuouslyPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ContinuouslyPush",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContinuouslyPushResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a predefined continuous push task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API addresses the limitations of the <a href="https://help.aliyun.com/document_detail/2249916.html">Push Advanced Push API</a>, where push-by-device, push-by-account, and push-by-alias operations each have a maximum target count per single call.</para>
        /// <list type="bullet">
        /// <item><description>You can use continuous push when your scenario requires sending the same message to many devices. In this case, you can call the continuous push API repeatedly, each time specifying a group of targets for aggregation (the current limit is 1,000 targets per call for device, account, or alias pushes). The total number of pushes for the same MessageId is restricted to 10,000. If you need a higher limit, contact technical support to evaluate your specific scenario.</description></item>
        /// <item><description>Before using this API, you must first call the Push API with Target set to TBD (To Be Determined) and include your message content. This returns a MessageId from the push system. You can then use this MessageId to repeatedly call the continuous push API, specifying different target groups to deliver the same message.</description></item>
        /// <item><description>After calling the Push API with Target set to TBD and obtaining a MessageId, the message is stored in the push system for 24 hours by default. You can use this API to push to specified targets at any time before expiration. Pushes are not allowed after expiration or after reaching the total push limit.</description></item>
        /// <item><description>Each call to this API sends the message immediately. Scheduled pushes are not supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ContinuouslyPushRequest
        /// </param>
        /// 
        /// <returns>
        /// ContinuouslyPushResponse
        /// </returns>
        public ContinuouslyPushResponse ContinuouslyPush(ContinuouslyPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ContinuouslyPushWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a predefined continuous push task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API addresses the limitations of the <a href="https://help.aliyun.com/document_detail/2249916.html">Push Advanced Push API</a>, where push-by-device, push-by-account, and push-by-alias operations each have a maximum target count per single call.</para>
        /// <list type="bullet">
        /// <item><description>You can use continuous push when your scenario requires sending the same message to many devices. In this case, you can call the continuous push API repeatedly, each time specifying a group of targets for aggregation (the current limit is 1,000 targets per call for device, account, or alias pushes). The total number of pushes for the same MessageId is restricted to 10,000. If you need a higher limit, contact technical support to evaluate your specific scenario.</description></item>
        /// <item><description>Before using this API, you must first call the Push API with Target set to TBD (To Be Determined) and include your message content. This returns a MessageId from the push system. You can then use this MessageId to repeatedly call the continuous push API, specifying different target groups to deliver the same message.</description></item>
        /// <item><description>After calling the Push API with Target set to TBD and obtaining a MessageId, the message is stored in the push system for 24 hours by default. You can use this API to push to specified targets at any time before expiration. Pushes are not allowed after expiration or after reaching the total push limit.</description></item>
        /// <item><description>Each call to this API sends the message immediately. Scheduled pushes are not supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ContinuouslyPushRequest
        /// </param>
        /// 
        /// <returns>
        /// ContinuouslyPushResponse
        /// </returns>
        public async Task<ContinuouslyPushResponse> ContinuouslyPushAsync(ContinuouslyPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ContinuouslyPushWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListSummaryApps is deprecated, please use Mhub::2017-08-25::ListApps instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the list of all applications associated with your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSummaryAppsResponse
        /// </returns>
        [Obsolete("OpenAPI ListSummaryApps is deprecated, please use Mhub::2017-08-25::ListApps instead.")]
        // Deprecated
        public ListSummaryAppsResponse ListSummaryAppsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSummaryApps",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSummaryAppsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListSummaryApps is deprecated, please use Mhub::2017-08-25::ListApps instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the list of all applications associated with your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSummaryAppsResponse
        /// </returns>
        [Obsolete("OpenAPI ListSummaryApps is deprecated, please use Mhub::2017-08-25::ListApps instead.")]
        // Deprecated
        public async Task<ListSummaryAppsResponse> ListSummaryAppsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSummaryApps",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSummaryAppsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListSummaryApps is deprecated, please use Mhub::2017-08-25::ListApps instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the list of all applications associated with your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListSummaryAppsResponse
        /// </returns>
        [Obsolete("OpenAPI ListSummaryApps is deprecated, please use Mhub::2017-08-25::ListApps instead.")]
        // Deprecated
        public ListSummaryAppsResponse ListSummaryApps()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSummaryAppsWithOptions(runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListSummaryApps is deprecated, please use Mhub::2017-08-25::ListApps instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the list of all applications associated with your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListSummaryAppsResponse
        /// </returns>
        [Obsolete("OpenAPI ListSummaryApps is deprecated, please use Mhub::2017-08-25::ListApps instead.")]
        // Deprecated
        public async Task<ListSummaryAppsResponse> ListSummaryAppsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSummaryAppsWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags of an app. A maximum of 100 records are returned.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagsResponse
        /// </returns>
        public ListTagsResponse ListTagsWithOptions(ListTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTags",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags of an app. A maximum of 100 records are returned.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagsResponse
        /// </returns>
        public async Task<ListTagsResponse> ListTagsWithOptionsAsync(ListTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTags",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags of an app. A maximum of 100 records are returned.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagsResponse
        /// </returns>
        public ListTagsResponse ListTags(ListTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags of an app. A maximum of 100 records are returned.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagsResponse
        /// </returns>
        public async Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends different messages or notifications to multiple devices in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before you use this API, make sure that you understand the <a href="https://help.aliyun.com/document_detail/434638.html">billing methods and pricing</a> of EMAS Mobile Push.</em>*
        /// Some business scenarios require you to send many different messages to many devices in a short period. This can generate a high number of Queries Per Second (QPS) and cause requests to exceed the QPS limit for a single source IP address, resulting in push failures.
        /// This API is designed to solve this issue. You can include up to 100 independent push tasks in a single call. This request aggregation reduces the QPS and improves the stability and success rate of individual pushes. A single account is limited to 500 batch push calls per second.
        /// Each independent push task supports pushes to devices, accounts, or aliases. SMS integration is not supported.</para>
        /// <remarks>
        /// <para>You must upgrade the SDK to version 3.11.0 or later.</para>
        /// </remarks>
        /// <h2>PushTask properties</h2>
        /// <list type="bullet">
        /// <item><description>The format for PushTask properties is PushTask.N.Property. These properties include the following:<list type="bullet">
        /// <item><description>Push target (destination)</description></item>
        /// <item><description>Push configuration (config)</description></item>
        /// <item><description>iOS notification task configuration</description></item>
        /// <item><description>Android notification task configuration</description></item>
        /// <item><description>Android auxiliary pop-up configuration</description></item>
        /// <item><description>HarmonyOS notification task configuration</description></item>
        /// <item><description>Push control</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Each PushTask represents an independent push task. A maximum of 100 tasks are supported per call. The push configurations are the same as those for the Push API.</description></item>
        /// <item><description>The PushTask.N.Target parameter supports only the DEVICE, ACCOUNT, and ALIAS types.</description></item>
        /// <item><description>PushTask does not support SMS filter interaction.</description></item>
        /// <item><description>The product of the parent node and child nodes cannot exceed 10,000. If this limit is exceeded, the parameters are considered invalid.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MassPushRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MassPushResponse
        /// </returns>
        public MassPushResponse MassPushWithOptions(MassPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentToken))
            {
                query["IdempotentToken"] = request.IdempotentToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushTask))
            {
                body["PushTask"] = request.PushTask;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MassPush",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MassPushResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends different messages or notifications to multiple devices in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before you use this API, make sure that you understand the <a href="https://help.aliyun.com/document_detail/434638.html">billing methods and pricing</a> of EMAS Mobile Push.</em>*
        /// Some business scenarios require you to send many different messages to many devices in a short period. This can generate a high number of Queries Per Second (QPS) and cause requests to exceed the QPS limit for a single source IP address, resulting in push failures.
        /// This API is designed to solve this issue. You can include up to 100 independent push tasks in a single call. This request aggregation reduces the QPS and improves the stability and success rate of individual pushes. A single account is limited to 500 batch push calls per second.
        /// Each independent push task supports pushes to devices, accounts, or aliases. SMS integration is not supported.</para>
        /// <remarks>
        /// <para>You must upgrade the SDK to version 3.11.0 or later.</para>
        /// </remarks>
        /// <h2>PushTask properties</h2>
        /// <list type="bullet">
        /// <item><description>The format for PushTask properties is PushTask.N.Property. These properties include the following:<list type="bullet">
        /// <item><description>Push target (destination)</description></item>
        /// <item><description>Push configuration (config)</description></item>
        /// <item><description>iOS notification task configuration</description></item>
        /// <item><description>Android notification task configuration</description></item>
        /// <item><description>Android auxiliary pop-up configuration</description></item>
        /// <item><description>HarmonyOS notification task configuration</description></item>
        /// <item><description>Push control</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Each PushTask represents an independent push task. A maximum of 100 tasks are supported per call. The push configurations are the same as those for the Push API.</description></item>
        /// <item><description>The PushTask.N.Target parameter supports only the DEVICE, ACCOUNT, and ALIAS types.</description></item>
        /// <item><description>PushTask does not support SMS filter interaction.</description></item>
        /// <item><description>The product of the parent node and child nodes cannot exceed 10,000. If this limit is exceeded, the parameters are considered invalid.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MassPushRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MassPushResponse
        /// </returns>
        public async Task<MassPushResponse> MassPushWithOptionsAsync(MassPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentToken))
            {
                query["IdempotentToken"] = request.IdempotentToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushTask))
            {
                body["PushTask"] = request.PushTask;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MassPush",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MassPushResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends different messages or notifications to multiple devices in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before you use this API, make sure that you understand the <a href="https://help.aliyun.com/document_detail/434638.html">billing methods and pricing</a> of EMAS Mobile Push.</em>*
        /// Some business scenarios require you to send many different messages to many devices in a short period. This can generate a high number of Queries Per Second (QPS) and cause requests to exceed the QPS limit for a single source IP address, resulting in push failures.
        /// This API is designed to solve this issue. You can include up to 100 independent push tasks in a single call. This request aggregation reduces the QPS and improves the stability and success rate of individual pushes. A single account is limited to 500 batch push calls per second.
        /// Each independent push task supports pushes to devices, accounts, or aliases. SMS integration is not supported.</para>
        /// <remarks>
        /// <para>You must upgrade the SDK to version 3.11.0 or later.</para>
        /// </remarks>
        /// <h2>PushTask properties</h2>
        /// <list type="bullet">
        /// <item><description>The format for PushTask properties is PushTask.N.Property. These properties include the following:<list type="bullet">
        /// <item><description>Push target (destination)</description></item>
        /// <item><description>Push configuration (config)</description></item>
        /// <item><description>iOS notification task configuration</description></item>
        /// <item><description>Android notification task configuration</description></item>
        /// <item><description>Android auxiliary pop-up configuration</description></item>
        /// <item><description>HarmonyOS notification task configuration</description></item>
        /// <item><description>Push control</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Each PushTask represents an independent push task. A maximum of 100 tasks are supported per call. The push configurations are the same as those for the Push API.</description></item>
        /// <item><description>The PushTask.N.Target parameter supports only the DEVICE, ACCOUNT, and ALIAS types.</description></item>
        /// <item><description>PushTask does not support SMS filter interaction.</description></item>
        /// <item><description>The product of the parent node and child nodes cannot exceed 10,000. If this limit is exceeded, the parameters are considered invalid.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MassPushRequest
        /// </param>
        /// 
        /// <returns>
        /// MassPushResponse
        /// </returns>
        public MassPushResponse MassPush(MassPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MassPushWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends different messages or notifications to multiple devices in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before you use this API, make sure that you understand the <a href="https://help.aliyun.com/document_detail/434638.html">billing methods and pricing</a> of EMAS Mobile Push.</em>*
        /// Some business scenarios require you to send many different messages to many devices in a short period. This can generate a high number of Queries Per Second (QPS) and cause requests to exceed the QPS limit for a single source IP address, resulting in push failures.
        /// This API is designed to solve this issue. You can include up to 100 independent push tasks in a single call. This request aggregation reduces the QPS and improves the stability and success rate of individual pushes. A single account is limited to 500 batch push calls per second.
        /// Each independent push task supports pushes to devices, accounts, or aliases. SMS integration is not supported.</para>
        /// <remarks>
        /// <para>You must upgrade the SDK to version 3.11.0 or later.</para>
        /// </remarks>
        /// <h2>PushTask properties</h2>
        /// <list type="bullet">
        /// <item><description>The format for PushTask properties is PushTask.N.Property. These properties include the following:<list type="bullet">
        /// <item><description>Push target (destination)</description></item>
        /// <item><description>Push configuration (config)</description></item>
        /// <item><description>iOS notification task configuration</description></item>
        /// <item><description>Android notification task configuration</description></item>
        /// <item><description>Android auxiliary pop-up configuration</description></item>
        /// <item><description>HarmonyOS notification task configuration</description></item>
        /// <item><description>Push control</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Each PushTask represents an independent push task. A maximum of 100 tasks are supported per call. The push configurations are the same as those for the Push API.</description></item>
        /// <item><description>The PushTask.N.Target parameter supports only the DEVICE, ACCOUNT, and ALIAS types.</description></item>
        /// <item><description>PushTask does not support SMS filter interaction.</description></item>
        /// <item><description>The product of the parent node and child nodes cannot exceed 10,000. If this limit is exceeded, the parameters are considered invalid.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MassPushRequest
        /// </param>
        /// 
        /// <returns>
        /// MassPushResponse
        /// </returns>
        public async Task<MassPushResponse> MassPushAsync(MassPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MassPushWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Advanced push API v2.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before using this API, review the <a href="https://help.aliyun.com/document_detail/434638.html">pricing and billing details</a> for EMAS Mobile Push.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// MassPushV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MassPushV2Response
        /// </returns>
        public MassPushV2Response MassPushV2WithOptions(MassPushV2Request tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            MassPushV2ShrinkRequest request = new MassPushV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PushTasks))
            {
                request.PushTasksShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PushTasks, "PushTasks", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentToken))
            {
                query["IdempotentToken"] = request.IdempotentToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushTasksShrink))
            {
                query["PushTasks"] = request.PushTasksShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MassPushV2",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MassPushV2Response>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Advanced push API v2.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before using this API, review the <a href="https://help.aliyun.com/document_detail/434638.html">pricing and billing details</a> for EMAS Mobile Push.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// MassPushV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MassPushV2Response
        /// </returns>
        public async Task<MassPushV2Response> MassPushV2WithOptionsAsync(MassPushV2Request tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            MassPushV2ShrinkRequest request = new MassPushV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PushTasks))
            {
                request.PushTasksShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PushTasks, "PushTasks", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentToken))
            {
                query["IdempotentToken"] = request.IdempotentToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushTasksShrink))
            {
                query["PushTasks"] = request.PushTasksShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MassPushV2",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MassPushV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Advanced push API v2.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before using this API, review the <a href="https://help.aliyun.com/document_detail/434638.html">pricing and billing details</a> for EMAS Mobile Push.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MassPushV2Request
        /// </param>
        /// 
        /// <returns>
        /// MassPushV2Response
        /// </returns>
        public MassPushV2Response MassPushV2(MassPushV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MassPushV2WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Advanced push API v2.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before using this API, review the <a href="https://help.aliyun.com/document_detail/434638.html">pricing and billing details</a> for EMAS Mobile Push.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MassPushV2Request
        /// </param>
        /// 
        /// <returns>
        /// MassPushV2Response
        /// </returns>
        public async Task<MassPushV2Response> MassPushV2Async(MassPushV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MassPushV2WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This advanced push API sends notifications or messages to various devices. It provides a rich set of custom parameters to implement push behaviors for various scenarios.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before you use this API, make sure you understand the <a href="https://help.aliyun.com/document_detail/434638.html">billing methods and pricing</a> of EMAS Mobile Push.</em>*
        /// This API supports pushes to Android, iOS, and HarmonyOS devices. For each platform, you must provide the corresponding AppKey.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// PushRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushResponse
        /// </returns>
        public PushResponse PushWithOptions(PushRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushShrinkRequest request = new PushShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AndroidOppoPrivateContentParameters))
            {
                request.AndroidOppoPrivateContentParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AndroidOppoPrivateContentParameters, "AndroidOppoPrivateContentParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AndroidOppoPrivateTitleParameters))
            {
                request.AndroidOppoPrivateTitleParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AndroidOppoPrivateTitleParameters, "AndroidOppoPrivateTitleParameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidActivity))
            {
                query["AndroidActivity"] = request.AndroidActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidBadgeAddNum))
            {
                query["AndroidBadgeAddNum"] = request.AndroidBadgeAddNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidBadgeClass))
            {
                query["AndroidBadgeClass"] = request.AndroidBadgeClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidBadgeSetNum))
            {
                query["AndroidBadgeSetNum"] = request.AndroidBadgeSetNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidBigBody))
            {
                query["AndroidBigBody"] = request.AndroidBigBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidBigPictureUrl))
            {
                query["AndroidBigPictureUrl"] = request.AndroidBigPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidBigTitle))
            {
                query["AndroidBigTitle"] = request.AndroidBigTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidExtParameters))
            {
                query["AndroidExtParameters"] = request.AndroidExtParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidHonorTargetUserType))
            {
                query["AndroidHonorTargetUserType"] = request.AndroidHonorTargetUserType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidHuaweiBusinessType))
            {
                query["AndroidHuaweiBusinessType"] = request.AndroidHuaweiBusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidHuaweiLiveNotificationPayload))
            {
                query["AndroidHuaweiLiveNotificationPayload"] = request.AndroidHuaweiLiveNotificationPayload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidHuaweiReceiptId))
            {
                query["AndroidHuaweiReceiptId"] = request.AndroidHuaweiReceiptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidHuaweiTargetUserType))
            {
                query["AndroidHuaweiTargetUserType"] = request.AndroidHuaweiTargetUserType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidImageUrl))
            {
                query["AndroidImageUrl"] = request.AndroidImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInboxBody))
            {
                query["AndroidInboxBody"] = request.AndroidInboxBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMeizuNoticeMsgType))
            {
                query["AndroidMeizuNoticeMsgType"] = request.AndroidMeizuNoticeMsgType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMessageHuaweiCategory))
            {
                query["AndroidMessageHuaweiCategory"] = request.AndroidMessageHuaweiCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMessageHuaweiUrgency))
            {
                query["AndroidMessageHuaweiUrgency"] = request.AndroidMessageHuaweiUrgency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMessageOppoCategory))
            {
                query["AndroidMessageOppoCategory"] = request.AndroidMessageOppoCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMessageOppoNotifyLevel))
            {
                query["AndroidMessageOppoNotifyLevel"] = request.AndroidMessageOppoNotifyLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMessageVivoCategory))
            {
                query["AndroidMessageVivoCategory"] = request.AndroidMessageVivoCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMusic))
            {
                query["AndroidMusic"] = request.AndroidMusic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationBarPriority))
            {
                query["AndroidNotificationBarPriority"] = request.AndroidNotificationBarPriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationBarType))
            {
                query["AndroidNotificationBarType"] = request.AndroidNotificationBarType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationChannel))
            {
                query["AndroidNotificationChannel"] = request.AndroidNotificationChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationGroup))
            {
                query["AndroidNotificationGroup"] = request.AndroidNotificationGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationHonorChannel))
            {
                query["AndroidNotificationHonorChannel"] = request.AndroidNotificationHonorChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationHuaweiChannel))
            {
                query["AndroidNotificationHuaweiChannel"] = request.AndroidNotificationHuaweiChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationNotifyId))
            {
                query["AndroidNotificationNotifyId"] = request.AndroidNotificationNotifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationThreadId))
            {
                query["AndroidNotificationThreadId"] = request.AndroidNotificationThreadId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationVivoChannel))
            {
                query["AndroidNotificationVivoChannel"] = request.AndroidNotificationVivoChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationXiaomiChannel))
            {
                query["AndroidNotificationXiaomiChannel"] = request.AndroidNotificationXiaomiChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotifyType))
            {
                query["AndroidNotifyType"] = request.AndroidNotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidOpenType))
            {
                query["AndroidOpenType"] = request.AndroidOpenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidOpenUrl))
            {
                query["AndroidOpenUrl"] = request.AndroidOpenUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidOppoDeleteIntentData))
            {
                query["AndroidOppoDeleteIntentData"] = request.AndroidOppoDeleteIntentData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidOppoIntelligentIntent))
            {
                query["AndroidOppoIntelligentIntent"] = request.AndroidOppoIntelligentIntent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidOppoIntentEnv))
            {
                query["AndroidOppoIntentEnv"] = request.AndroidOppoIntentEnv;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidOppoPrivateContentParametersShrink))
            {
                query["AndroidOppoPrivateContentParameters"] = request.AndroidOppoPrivateContentParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidOppoPrivateMsgTemplateId))
            {
                query["AndroidOppoPrivateMsgTemplateId"] = request.AndroidOppoPrivateMsgTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidOppoPrivateTitleParametersShrink))
            {
                query["AndroidOppoPrivateTitleParameters"] = request.AndroidOppoPrivateTitleParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPopupActivity))
            {
                query["AndroidPopupActivity"] = request.AndroidPopupActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPopupBody))
            {
                query["AndroidPopupBody"] = request.AndroidPopupBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPopupTitle))
            {
                query["AndroidPopupTitle"] = request.AndroidPopupTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidRemind))
            {
                query["AndroidRemind"] = request.AndroidRemind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidRenderStyle))
            {
                query["AndroidRenderStyle"] = request.AndroidRenderStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidTargetUserType))
            {
                query["AndroidTargetUserType"] = request.AndroidTargetUserType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidVivoLiveMessage))
            {
                query["AndroidVivoLiveMessage"] = request.AndroidVivoLiveMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidVivoPushMode))
            {
                query["AndroidVivoPushMode"] = request.AndroidVivoPushMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidVivoReceiptId))
            {
                query["AndroidVivoReceiptId"] = request.AndroidVivoReceiptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaoMiActivity))
            {
                query["AndroidXiaoMiActivity"] = request.AndroidXiaoMiActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaoMiNotifyBody))
            {
                query["AndroidXiaoMiNotifyBody"] = request.AndroidXiaoMiNotifyBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaoMiNotifyTitle))
            {
                query["AndroidXiaoMiNotifyTitle"] = request.AndroidXiaoMiNotifyTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaomiBigPictureUrl))
            {
                query["AndroidXiaomiBigPictureUrl"] = request.AndroidXiaomiBigPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaomiFocusParam))
            {
                query["AndroidXiaomiFocusParam"] = request.AndroidXiaomiFocusParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaomiFocusPics))
            {
                query["AndroidXiaomiFocusPics"] = request.AndroidXiaomiFocusPics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaomiImageUrl))
            {
                query["AndroidXiaomiImageUrl"] = request.AndroidXiaomiImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaomiTemplateId))
            {
                query["AndroidXiaomiTemplateId"] = request.AndroidXiaomiTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaomiTemplateParams))
            {
                query["AndroidXiaomiTemplateParams"] = request.AndroidXiaomiTemplateParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                query["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                query["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyAction))
            {
                query["HarmonyAction"] = request.HarmonyAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyActionType))
            {
                query["HarmonyActionType"] = request.HarmonyActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyBadgeAddNum))
            {
                query["HarmonyBadgeAddNum"] = request.HarmonyBadgeAddNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyBadgeSetNum))
            {
                query["HarmonyBadgeSetNum"] = request.HarmonyBadgeSetNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyCategory))
            {
                query["HarmonyCategory"] = request.HarmonyCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyExtParameters))
            {
                query["HarmonyExtParameters"] = request.HarmonyExtParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyExtensionExtraData))
            {
                query["HarmonyExtensionExtraData"] = request.HarmonyExtensionExtraData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyExtensionPush))
            {
                query["HarmonyExtensionPush"] = request.HarmonyExtensionPush;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyImageUrl))
            {
                query["HarmonyImageUrl"] = request.HarmonyImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyInboxContent))
            {
                query["HarmonyInboxContent"] = request.HarmonyInboxContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyLiveViewPayload))
            {
                query["HarmonyLiveViewPayload"] = request.HarmonyLiveViewPayload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyNotificationSlotType))
            {
                query["HarmonyNotificationSlotType"] = request.HarmonyNotificationSlotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyNotifyId))
            {
                query["HarmonyNotifyId"] = request.HarmonyNotifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyReceiptId))
            {
                query["HarmonyReceiptId"] = request.HarmonyReceiptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyRemind))
            {
                query["HarmonyRemind"] = request.HarmonyRemind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyRemindBody))
            {
                query["HarmonyRemindBody"] = request.HarmonyRemindBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyRemindTitle))
            {
                query["HarmonyRemindTitle"] = request.HarmonyRemindTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyRenderStyle))
            {
                query["HarmonyRenderStyle"] = request.HarmonyRenderStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyTestMessage))
            {
                query["HarmonyTestMessage"] = request.HarmonyTestMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyUri))
            {
                query["HarmonyUri"] = request.HarmonyUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentToken))
            {
                query["IdempotentToken"] = request.IdempotentToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobKey))
            {
                query["JobKey"] = request.JobKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushTime))
            {
                query["PushTime"] = request.PushTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushType))
            {
                query["PushType"] = request.PushType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendChannels))
            {
                query["SendChannels"] = request.SendChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendSpeed))
            {
                query["SendSpeed"] = request.SendSpeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsDelaySecs))
            {
                query["SmsDelaySecs"] = request.SmsDelaySecs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsParams))
            {
                query["SmsParams"] = request.SmsParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsSendPolicy))
            {
                query["SmsSendPolicy"] = request.SmsSendPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsSignName))
            {
                query["SmsSignName"] = request.SmsSignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateName))
            {
                query["SmsTemplateName"] = request.SmsTemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreOffline))
            {
                query["StoreOffline"] = request.StoreOffline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Trim))
            {
                query["Trim"] = request.Trim;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSApnsEnv))
            {
                query["iOSApnsEnv"] = request.IOSApnsEnv;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSBadge))
            {
                query["iOSBadge"] = request.IOSBadge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSBadgeAutoIncrement))
            {
                query["iOSBadgeAutoIncrement"] = request.IOSBadgeAutoIncrement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSExtParameters))
            {
                query["iOSExtParameters"] = request.IOSExtParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSInterruptionLevel))
            {
                query["iOSInterruptionLevel"] = request.IOSInterruptionLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSLiveActivityAttributes))
            {
                query["iOSLiveActivityAttributes"] = request.IOSLiveActivityAttributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSLiveActivityAttributesType))
            {
                query["iOSLiveActivityAttributesType"] = request.IOSLiveActivityAttributesType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSLiveActivityContentState))
            {
                query["iOSLiveActivityContentState"] = request.IOSLiveActivityContentState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSLiveActivityDismissalDate))
            {
                query["iOSLiveActivityDismissalDate"] = request.IOSLiveActivityDismissalDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSLiveActivityEvent))
            {
                query["iOSLiveActivityEvent"] = request.IOSLiveActivityEvent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSLiveActivityId))
            {
                query["iOSLiveActivityId"] = request.IOSLiveActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSLiveActivityStaleDate))
            {
                query["iOSLiveActivityStaleDate"] = request.IOSLiveActivityStaleDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSMusic))
            {
                query["iOSMusic"] = request.IOSMusic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSMutableContent))
            {
                query["iOSMutableContent"] = request.IOSMutableContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSNotificationCategory))
            {
                query["iOSNotificationCategory"] = request.IOSNotificationCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSNotificationCollapseId))
            {
                query["iOSNotificationCollapseId"] = request.IOSNotificationCollapseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSNotificationThreadId))
            {
                query["iOSNotificationThreadId"] = request.IOSNotificationThreadId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSRelevanceScore))
            {
                query["iOSRelevanceScore"] = request.IOSRelevanceScore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSRemind))
            {
                query["iOSRemind"] = request.IOSRemind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSRemindBody))
            {
                query["iOSRemindBody"] = request.IOSRemindBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSSilentNotification))
            {
                query["iOSSilentNotification"] = request.IOSSilentNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSSubtitle))
            {
                query["iOSSubtitle"] = request.IOSSubtitle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Push",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This advanced push API sends notifications or messages to various devices. It provides a rich set of custom parameters to implement push behaviors for various scenarios.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before you use this API, make sure you understand the <a href="https://help.aliyun.com/document_detail/434638.html">billing methods and pricing</a> of EMAS Mobile Push.</em>*
        /// This API supports pushes to Android, iOS, and HarmonyOS devices. For each platform, you must provide the corresponding AppKey.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// PushRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushResponse
        /// </returns>
        public async Task<PushResponse> PushWithOptionsAsync(PushRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushShrinkRequest request = new PushShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AndroidOppoPrivateContentParameters))
            {
                request.AndroidOppoPrivateContentParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AndroidOppoPrivateContentParameters, "AndroidOppoPrivateContentParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AndroidOppoPrivateTitleParameters))
            {
                request.AndroidOppoPrivateTitleParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AndroidOppoPrivateTitleParameters, "AndroidOppoPrivateTitleParameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidActivity))
            {
                query["AndroidActivity"] = request.AndroidActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidBadgeAddNum))
            {
                query["AndroidBadgeAddNum"] = request.AndroidBadgeAddNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidBadgeClass))
            {
                query["AndroidBadgeClass"] = request.AndroidBadgeClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidBadgeSetNum))
            {
                query["AndroidBadgeSetNum"] = request.AndroidBadgeSetNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidBigBody))
            {
                query["AndroidBigBody"] = request.AndroidBigBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidBigPictureUrl))
            {
                query["AndroidBigPictureUrl"] = request.AndroidBigPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidBigTitle))
            {
                query["AndroidBigTitle"] = request.AndroidBigTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidExtParameters))
            {
                query["AndroidExtParameters"] = request.AndroidExtParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidHonorTargetUserType))
            {
                query["AndroidHonorTargetUserType"] = request.AndroidHonorTargetUserType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidHuaweiBusinessType))
            {
                query["AndroidHuaweiBusinessType"] = request.AndroidHuaweiBusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidHuaweiLiveNotificationPayload))
            {
                query["AndroidHuaweiLiveNotificationPayload"] = request.AndroidHuaweiLiveNotificationPayload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidHuaweiReceiptId))
            {
                query["AndroidHuaweiReceiptId"] = request.AndroidHuaweiReceiptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidHuaweiTargetUserType))
            {
                query["AndroidHuaweiTargetUserType"] = request.AndroidHuaweiTargetUserType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidImageUrl))
            {
                query["AndroidImageUrl"] = request.AndroidImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInboxBody))
            {
                query["AndroidInboxBody"] = request.AndroidInboxBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMeizuNoticeMsgType))
            {
                query["AndroidMeizuNoticeMsgType"] = request.AndroidMeizuNoticeMsgType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMessageHuaweiCategory))
            {
                query["AndroidMessageHuaweiCategory"] = request.AndroidMessageHuaweiCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMessageHuaweiUrgency))
            {
                query["AndroidMessageHuaweiUrgency"] = request.AndroidMessageHuaweiUrgency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMessageOppoCategory))
            {
                query["AndroidMessageOppoCategory"] = request.AndroidMessageOppoCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMessageOppoNotifyLevel))
            {
                query["AndroidMessageOppoNotifyLevel"] = request.AndroidMessageOppoNotifyLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMessageVivoCategory))
            {
                query["AndroidMessageVivoCategory"] = request.AndroidMessageVivoCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMusic))
            {
                query["AndroidMusic"] = request.AndroidMusic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationBarPriority))
            {
                query["AndroidNotificationBarPriority"] = request.AndroidNotificationBarPriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationBarType))
            {
                query["AndroidNotificationBarType"] = request.AndroidNotificationBarType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationChannel))
            {
                query["AndroidNotificationChannel"] = request.AndroidNotificationChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationGroup))
            {
                query["AndroidNotificationGroup"] = request.AndroidNotificationGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationHonorChannel))
            {
                query["AndroidNotificationHonorChannel"] = request.AndroidNotificationHonorChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationHuaweiChannel))
            {
                query["AndroidNotificationHuaweiChannel"] = request.AndroidNotificationHuaweiChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationNotifyId))
            {
                query["AndroidNotificationNotifyId"] = request.AndroidNotificationNotifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationThreadId))
            {
                query["AndroidNotificationThreadId"] = request.AndroidNotificationThreadId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationVivoChannel))
            {
                query["AndroidNotificationVivoChannel"] = request.AndroidNotificationVivoChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationXiaomiChannel))
            {
                query["AndroidNotificationXiaomiChannel"] = request.AndroidNotificationXiaomiChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotifyType))
            {
                query["AndroidNotifyType"] = request.AndroidNotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidOpenType))
            {
                query["AndroidOpenType"] = request.AndroidOpenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidOpenUrl))
            {
                query["AndroidOpenUrl"] = request.AndroidOpenUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidOppoDeleteIntentData))
            {
                query["AndroidOppoDeleteIntentData"] = request.AndroidOppoDeleteIntentData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidOppoIntelligentIntent))
            {
                query["AndroidOppoIntelligentIntent"] = request.AndroidOppoIntelligentIntent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidOppoIntentEnv))
            {
                query["AndroidOppoIntentEnv"] = request.AndroidOppoIntentEnv;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidOppoPrivateContentParametersShrink))
            {
                query["AndroidOppoPrivateContentParameters"] = request.AndroidOppoPrivateContentParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidOppoPrivateMsgTemplateId))
            {
                query["AndroidOppoPrivateMsgTemplateId"] = request.AndroidOppoPrivateMsgTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidOppoPrivateTitleParametersShrink))
            {
                query["AndroidOppoPrivateTitleParameters"] = request.AndroidOppoPrivateTitleParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPopupActivity))
            {
                query["AndroidPopupActivity"] = request.AndroidPopupActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPopupBody))
            {
                query["AndroidPopupBody"] = request.AndroidPopupBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPopupTitle))
            {
                query["AndroidPopupTitle"] = request.AndroidPopupTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidRemind))
            {
                query["AndroidRemind"] = request.AndroidRemind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidRenderStyle))
            {
                query["AndroidRenderStyle"] = request.AndroidRenderStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidTargetUserType))
            {
                query["AndroidTargetUserType"] = request.AndroidTargetUserType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidVivoLiveMessage))
            {
                query["AndroidVivoLiveMessage"] = request.AndroidVivoLiveMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidVivoPushMode))
            {
                query["AndroidVivoPushMode"] = request.AndroidVivoPushMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidVivoReceiptId))
            {
                query["AndroidVivoReceiptId"] = request.AndroidVivoReceiptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaoMiActivity))
            {
                query["AndroidXiaoMiActivity"] = request.AndroidXiaoMiActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaoMiNotifyBody))
            {
                query["AndroidXiaoMiNotifyBody"] = request.AndroidXiaoMiNotifyBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaoMiNotifyTitle))
            {
                query["AndroidXiaoMiNotifyTitle"] = request.AndroidXiaoMiNotifyTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaomiBigPictureUrl))
            {
                query["AndroidXiaomiBigPictureUrl"] = request.AndroidXiaomiBigPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaomiFocusParam))
            {
                query["AndroidXiaomiFocusParam"] = request.AndroidXiaomiFocusParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaomiFocusPics))
            {
                query["AndroidXiaomiFocusPics"] = request.AndroidXiaomiFocusPics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaomiImageUrl))
            {
                query["AndroidXiaomiImageUrl"] = request.AndroidXiaomiImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaomiTemplateId))
            {
                query["AndroidXiaomiTemplateId"] = request.AndroidXiaomiTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaomiTemplateParams))
            {
                query["AndroidXiaomiTemplateParams"] = request.AndroidXiaomiTemplateParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                query["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                query["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyAction))
            {
                query["HarmonyAction"] = request.HarmonyAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyActionType))
            {
                query["HarmonyActionType"] = request.HarmonyActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyBadgeAddNum))
            {
                query["HarmonyBadgeAddNum"] = request.HarmonyBadgeAddNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyBadgeSetNum))
            {
                query["HarmonyBadgeSetNum"] = request.HarmonyBadgeSetNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyCategory))
            {
                query["HarmonyCategory"] = request.HarmonyCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyExtParameters))
            {
                query["HarmonyExtParameters"] = request.HarmonyExtParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyExtensionExtraData))
            {
                query["HarmonyExtensionExtraData"] = request.HarmonyExtensionExtraData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyExtensionPush))
            {
                query["HarmonyExtensionPush"] = request.HarmonyExtensionPush;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyImageUrl))
            {
                query["HarmonyImageUrl"] = request.HarmonyImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyInboxContent))
            {
                query["HarmonyInboxContent"] = request.HarmonyInboxContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyLiveViewPayload))
            {
                query["HarmonyLiveViewPayload"] = request.HarmonyLiveViewPayload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyNotificationSlotType))
            {
                query["HarmonyNotificationSlotType"] = request.HarmonyNotificationSlotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyNotifyId))
            {
                query["HarmonyNotifyId"] = request.HarmonyNotifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyReceiptId))
            {
                query["HarmonyReceiptId"] = request.HarmonyReceiptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyRemind))
            {
                query["HarmonyRemind"] = request.HarmonyRemind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyRemindBody))
            {
                query["HarmonyRemindBody"] = request.HarmonyRemindBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyRemindTitle))
            {
                query["HarmonyRemindTitle"] = request.HarmonyRemindTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyRenderStyle))
            {
                query["HarmonyRenderStyle"] = request.HarmonyRenderStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyTestMessage))
            {
                query["HarmonyTestMessage"] = request.HarmonyTestMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyUri))
            {
                query["HarmonyUri"] = request.HarmonyUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentToken))
            {
                query["IdempotentToken"] = request.IdempotentToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobKey))
            {
                query["JobKey"] = request.JobKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushTime))
            {
                query["PushTime"] = request.PushTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushType))
            {
                query["PushType"] = request.PushType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendChannels))
            {
                query["SendChannels"] = request.SendChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendSpeed))
            {
                query["SendSpeed"] = request.SendSpeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsDelaySecs))
            {
                query["SmsDelaySecs"] = request.SmsDelaySecs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsParams))
            {
                query["SmsParams"] = request.SmsParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsSendPolicy))
            {
                query["SmsSendPolicy"] = request.SmsSendPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsSignName))
            {
                query["SmsSignName"] = request.SmsSignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateName))
            {
                query["SmsTemplateName"] = request.SmsTemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreOffline))
            {
                query["StoreOffline"] = request.StoreOffline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Trim))
            {
                query["Trim"] = request.Trim;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSApnsEnv))
            {
                query["iOSApnsEnv"] = request.IOSApnsEnv;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSBadge))
            {
                query["iOSBadge"] = request.IOSBadge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSBadgeAutoIncrement))
            {
                query["iOSBadgeAutoIncrement"] = request.IOSBadgeAutoIncrement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSExtParameters))
            {
                query["iOSExtParameters"] = request.IOSExtParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSInterruptionLevel))
            {
                query["iOSInterruptionLevel"] = request.IOSInterruptionLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSLiveActivityAttributes))
            {
                query["iOSLiveActivityAttributes"] = request.IOSLiveActivityAttributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSLiveActivityAttributesType))
            {
                query["iOSLiveActivityAttributesType"] = request.IOSLiveActivityAttributesType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSLiveActivityContentState))
            {
                query["iOSLiveActivityContentState"] = request.IOSLiveActivityContentState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSLiveActivityDismissalDate))
            {
                query["iOSLiveActivityDismissalDate"] = request.IOSLiveActivityDismissalDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSLiveActivityEvent))
            {
                query["iOSLiveActivityEvent"] = request.IOSLiveActivityEvent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSLiveActivityId))
            {
                query["iOSLiveActivityId"] = request.IOSLiveActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSLiveActivityStaleDate))
            {
                query["iOSLiveActivityStaleDate"] = request.IOSLiveActivityStaleDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSMusic))
            {
                query["iOSMusic"] = request.IOSMusic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSMutableContent))
            {
                query["iOSMutableContent"] = request.IOSMutableContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSNotificationCategory))
            {
                query["iOSNotificationCategory"] = request.IOSNotificationCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSNotificationCollapseId))
            {
                query["iOSNotificationCollapseId"] = request.IOSNotificationCollapseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSNotificationThreadId))
            {
                query["iOSNotificationThreadId"] = request.IOSNotificationThreadId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSRelevanceScore))
            {
                query["iOSRelevanceScore"] = request.IOSRelevanceScore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSRemind))
            {
                query["iOSRemind"] = request.IOSRemind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSRemindBody))
            {
                query["iOSRemindBody"] = request.IOSRemindBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSSilentNotification))
            {
                query["iOSSilentNotification"] = request.IOSSilentNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSSubtitle))
            {
                query["iOSSubtitle"] = request.IOSSubtitle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Push",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This advanced push API sends notifications or messages to various devices. It provides a rich set of custom parameters to implement push behaviors for various scenarios.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before you use this API, make sure you understand the <a href="https://help.aliyun.com/document_detail/434638.html">billing methods and pricing</a> of EMAS Mobile Push.</em>*
        /// This API supports pushes to Android, iOS, and HarmonyOS devices. For each platform, you must provide the corresponding AppKey.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PushRequest
        /// </param>
        /// 
        /// <returns>
        /// PushResponse
        /// </returns>
        public PushResponse Push(PushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This advanced push API sends notifications or messages to various devices. It provides a rich set of custom parameters to implement push behaviors for various scenarios.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before you use this API, make sure you understand the <a href="https://help.aliyun.com/document_detail/434638.html">billing methods and pricing</a> of EMAS Mobile Push.</em>*
        /// This API supports pushes to Android, iOS, and HarmonyOS devices. For each platform, you must provide the corresponding AppKey.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PushRequest
        /// </param>
        /// 
        /// <returns>
        /// PushResponse
        /// </returns>
        public async Task<PushResponse> PushAsync(PushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a message to an Android device through the Alibaba Cloud Mobile Push proprietary channel. After the app on the device receives the message, it must handle subsequent actions, such as implementing business logic or displaying a local notification.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>This operation will be deprecated soon. Use the <a href="https://help.aliyun.com/document_detail/2249916.html">advanced push API</a>, which provides enhanced push capabilities. To achieve the same result, set the <c>DeviceType</c> parameter to <c>ANDROID</c> and the <c>PushType</c> parameter to <c>MESSAGE</c> in the advanced push API.</em>*
        /// <b>Before using this operation, review the <a href="https://help.aliyun.com/document_detail/434638.html">billing methods and pricing</a> for EMAS Mobile Push.</b>
        /// By default, this operation sends messages only to online devices. If a device is offline, set the <c>StoreOffline</c> parameter. The push system then stores the message and delivers it automatically when the device comes online.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PushMessageToAndroidRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushMessageToAndroidResponse
        /// </returns>
        public PushMessageToAndroidResponse PushMessageToAndroidWithOptions(PushMessageToAndroidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                query["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobKey))
            {
                query["JobKey"] = request.JobKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreOffline))
            {
                query["StoreOffline"] = request.StoreOffline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushMessageToAndroid",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushMessageToAndroidResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a message to an Android device through the Alibaba Cloud Mobile Push proprietary channel. After the app on the device receives the message, it must handle subsequent actions, such as implementing business logic or displaying a local notification.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>This operation will be deprecated soon. Use the <a href="https://help.aliyun.com/document_detail/2249916.html">advanced push API</a>, which provides enhanced push capabilities. To achieve the same result, set the <c>DeviceType</c> parameter to <c>ANDROID</c> and the <c>PushType</c> parameter to <c>MESSAGE</c> in the advanced push API.</em>*
        /// <b>Before using this operation, review the <a href="https://help.aliyun.com/document_detail/434638.html">billing methods and pricing</a> for EMAS Mobile Push.</b>
        /// By default, this operation sends messages only to online devices. If a device is offline, set the <c>StoreOffline</c> parameter. The push system then stores the message and delivers it automatically when the device comes online.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PushMessageToAndroidRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushMessageToAndroidResponse
        /// </returns>
        public async Task<PushMessageToAndroidResponse> PushMessageToAndroidWithOptionsAsync(PushMessageToAndroidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                query["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobKey))
            {
                query["JobKey"] = request.JobKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreOffline))
            {
                query["StoreOffline"] = request.StoreOffline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushMessageToAndroid",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushMessageToAndroidResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a message to an Android device through the Alibaba Cloud Mobile Push proprietary channel. After the app on the device receives the message, it must handle subsequent actions, such as implementing business logic or displaying a local notification.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>This operation will be deprecated soon. Use the <a href="https://help.aliyun.com/document_detail/2249916.html">advanced push API</a>, which provides enhanced push capabilities. To achieve the same result, set the <c>DeviceType</c> parameter to <c>ANDROID</c> and the <c>PushType</c> parameter to <c>MESSAGE</c> in the advanced push API.</em>*
        /// <b>Before using this operation, review the <a href="https://help.aliyun.com/document_detail/434638.html">billing methods and pricing</a> for EMAS Mobile Push.</b>
        /// By default, this operation sends messages only to online devices. If a device is offline, set the <c>StoreOffline</c> parameter. The push system then stores the message and delivers it automatically when the device comes online.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PushMessageToAndroidRequest
        /// </param>
        /// 
        /// <returns>
        /// PushMessageToAndroidResponse
        /// </returns>
        public PushMessageToAndroidResponse PushMessageToAndroid(PushMessageToAndroidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushMessageToAndroidWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a message to an Android device through the Alibaba Cloud Mobile Push proprietary channel. After the app on the device receives the message, it must handle subsequent actions, such as implementing business logic or displaying a local notification.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>This operation will be deprecated soon. Use the <a href="https://help.aliyun.com/document_detail/2249916.html">advanced push API</a>, which provides enhanced push capabilities. To achieve the same result, set the <c>DeviceType</c> parameter to <c>ANDROID</c> and the <c>PushType</c> parameter to <c>MESSAGE</c> in the advanced push API.</em>*
        /// <b>Before using this operation, review the <a href="https://help.aliyun.com/document_detail/434638.html">billing methods and pricing</a> for EMAS Mobile Push.</b>
        /// By default, this operation sends messages only to online devices. If a device is offline, set the <c>StoreOffline</c> parameter. The push system then stores the message and delivers it automatically when the device comes online.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PushMessageToAndroidRequest
        /// </param>
        /// 
        /// <returns>
        /// PushMessageToAndroidResponse
        /// </returns>
        public async Task<PushMessageToAndroidResponse> PushMessageToAndroidAsync(PushMessageToAndroidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushMessageToAndroidWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pushes messages to iOS devices. These messages are delivered through the proprietary channel of Alibaba Cloud Mobile Push. After the app on a device receives a message, it must handle subsequent actions, such as implementing business behaviors or creating local notifications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>This API is deprecated. Use the <a href="https://help.aliyun.com/document_detail/2249916.html">advanced push API</a> for more push capabilities. In that API, set the push platform <c>DeviceType</c> to <c>iOS</c> and the push type <c>PushType</c> to <c>MESSAGE</c> to achieve the same effect.</em>*
        /// <b>Before you use this API, review the <a href="https://help.aliyun.com/document_detail/434638.html">billing methods and pricing</a> for EMAS Mobile Push.</b>
        /// By default, this API sends messages only to online devices. If a device is offline, you can set the <c>StoreOffline</c> parameter. The push system then saves the message and automatically delivers it when the device comes back online.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PushMessageToiOSRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushMessageToiOSResponse
        /// </returns>
        public PushMessageToiOSResponse PushMessageToiOSWithOptions(PushMessageToiOSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                query["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobKey))
            {
                query["JobKey"] = request.JobKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreOffline))
            {
                query["StoreOffline"] = request.StoreOffline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushMessageToiOS",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushMessageToiOSResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pushes messages to iOS devices. These messages are delivered through the proprietary channel of Alibaba Cloud Mobile Push. After the app on a device receives a message, it must handle subsequent actions, such as implementing business behaviors or creating local notifications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>This API is deprecated. Use the <a href="https://help.aliyun.com/document_detail/2249916.html">advanced push API</a> for more push capabilities. In that API, set the push platform <c>DeviceType</c> to <c>iOS</c> and the push type <c>PushType</c> to <c>MESSAGE</c> to achieve the same effect.</em>*
        /// <b>Before you use this API, review the <a href="https://help.aliyun.com/document_detail/434638.html">billing methods and pricing</a> for EMAS Mobile Push.</b>
        /// By default, this API sends messages only to online devices. If a device is offline, you can set the <c>StoreOffline</c> parameter. The push system then saves the message and automatically delivers it when the device comes back online.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PushMessageToiOSRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushMessageToiOSResponse
        /// </returns>
        public async Task<PushMessageToiOSResponse> PushMessageToiOSWithOptionsAsync(PushMessageToiOSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                query["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobKey))
            {
                query["JobKey"] = request.JobKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreOffline))
            {
                query["StoreOffline"] = request.StoreOffline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushMessageToiOS",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushMessageToiOSResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pushes messages to iOS devices. These messages are delivered through the proprietary channel of Alibaba Cloud Mobile Push. After the app on a device receives a message, it must handle subsequent actions, such as implementing business behaviors or creating local notifications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>This API is deprecated. Use the <a href="https://help.aliyun.com/document_detail/2249916.html">advanced push API</a> for more push capabilities. In that API, set the push platform <c>DeviceType</c> to <c>iOS</c> and the push type <c>PushType</c> to <c>MESSAGE</c> to achieve the same effect.</em>*
        /// <b>Before you use this API, review the <a href="https://help.aliyun.com/document_detail/434638.html">billing methods and pricing</a> for EMAS Mobile Push.</b>
        /// By default, this API sends messages only to online devices. If a device is offline, you can set the <c>StoreOffline</c> parameter. The push system then saves the message and automatically delivers it when the device comes back online.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PushMessageToiOSRequest
        /// </param>
        /// 
        /// <returns>
        /// PushMessageToiOSResponse
        /// </returns>
        public PushMessageToiOSResponse PushMessageToiOS(PushMessageToiOSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushMessageToiOSWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pushes messages to iOS devices. These messages are delivered through the proprietary channel of Alibaba Cloud Mobile Push. After the app on a device receives a message, it must handle subsequent actions, such as implementing business behaviors or creating local notifications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>This API is deprecated. Use the <a href="https://help.aliyun.com/document_detail/2249916.html">advanced push API</a> for more push capabilities. In that API, set the push platform <c>DeviceType</c> to <c>iOS</c> and the push type <c>PushType</c> to <c>MESSAGE</c> to achieve the same effect.</em>*
        /// <b>Before you use this API, review the <a href="https://help.aliyun.com/document_detail/434638.html">billing methods and pricing</a> for EMAS Mobile Push.</b>
        /// By default, this API sends messages only to online devices. If a device is offline, you can set the <c>StoreOffline</c> parameter. The push system then saves the message and automatically delivers it when the device comes back online.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PushMessageToiOSRequest
        /// </param>
        /// 
        /// <returns>
        /// PushMessageToiOSResponse
        /// </returns>
        public async Task<PushMessageToiOSResponse> PushMessageToiOSAsync(PushMessageToiOSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushMessageToiOSWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a notification to Android devices. The notification appears directly in the device’s notification tray and may be delivered through Alibaba Cloud’s proprietary channel or the device manufacturer’s channel, depending on the scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>This operation is deprecated. Use the <a href="https://help.aliyun.com/document_detail/2249916.html">Advanced Push API</a> instead. In that API, set the <c>DeviceType</c> parameter to <c>ANDROID</c> and the <c>PushType</c> parameter to <c>NOTICE</c>.</em>*
        /// <b>Before using this operation, review the <a href="https://help.aliyun.com/document_detail/434638.html">pricing and billing model</a> for EMAS Mobile Push.</b></para>
        /// </description>
        /// 
        /// <param name="request">
        /// PushNoticeToAndroidRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushNoticeToAndroidResponse
        /// </returns>
        public PushNoticeToAndroidResponse PushNoticeToAndroidWithOptions(PushNoticeToAndroidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                query["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtParameters))
            {
                query["ExtParameters"] = request.ExtParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobKey))
            {
                query["JobKey"] = request.JobKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreOffline))
            {
                query["StoreOffline"] = request.StoreOffline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushNoticeToAndroid",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushNoticeToAndroidResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a notification to Android devices. The notification appears directly in the device’s notification tray and may be delivered through Alibaba Cloud’s proprietary channel or the device manufacturer’s channel, depending on the scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>This operation is deprecated. Use the <a href="https://help.aliyun.com/document_detail/2249916.html">Advanced Push API</a> instead. In that API, set the <c>DeviceType</c> parameter to <c>ANDROID</c> and the <c>PushType</c> parameter to <c>NOTICE</c>.</em>*
        /// <b>Before using this operation, review the <a href="https://help.aliyun.com/document_detail/434638.html">pricing and billing model</a> for EMAS Mobile Push.</b></para>
        /// </description>
        /// 
        /// <param name="request">
        /// PushNoticeToAndroidRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushNoticeToAndroidResponse
        /// </returns>
        public async Task<PushNoticeToAndroidResponse> PushNoticeToAndroidWithOptionsAsync(PushNoticeToAndroidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                query["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtParameters))
            {
                query["ExtParameters"] = request.ExtParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobKey))
            {
                query["JobKey"] = request.JobKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreOffline))
            {
                query["StoreOffline"] = request.StoreOffline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushNoticeToAndroid",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushNoticeToAndroidResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a notification to Android devices. The notification appears directly in the device’s notification tray and may be delivered through Alibaba Cloud’s proprietary channel or the device manufacturer’s channel, depending on the scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>This operation is deprecated. Use the <a href="https://help.aliyun.com/document_detail/2249916.html">Advanced Push API</a> instead. In that API, set the <c>DeviceType</c> parameter to <c>ANDROID</c> and the <c>PushType</c> parameter to <c>NOTICE</c>.</em>*
        /// <b>Before using this operation, review the <a href="https://help.aliyun.com/document_detail/434638.html">pricing and billing model</a> for EMAS Mobile Push.</b></para>
        /// </description>
        /// 
        /// <param name="request">
        /// PushNoticeToAndroidRequest
        /// </param>
        /// 
        /// <returns>
        /// PushNoticeToAndroidResponse
        /// </returns>
        public PushNoticeToAndroidResponse PushNoticeToAndroid(PushNoticeToAndroidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushNoticeToAndroidWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a notification to Android devices. The notification appears directly in the device’s notification tray and may be delivered through Alibaba Cloud’s proprietary channel or the device manufacturer’s channel, depending on the scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>This operation is deprecated. Use the <a href="https://help.aliyun.com/document_detail/2249916.html">Advanced Push API</a> instead. In that API, set the <c>DeviceType</c> parameter to <c>ANDROID</c> and the <c>PushType</c> parameter to <c>NOTICE</c>.</em>*
        /// <b>Before using this operation, review the <a href="https://help.aliyun.com/document_detail/434638.html">pricing and billing model</a> for EMAS Mobile Push.</b></para>
        /// </description>
        /// 
        /// <param name="request">
        /// PushNoticeToAndroidRequest
        /// </param>
        /// 
        /// <returns>
        /// PushNoticeToAndroidResponse
        /// </returns>
        public async Task<PushNoticeToAndroidResponse> PushNoticeToAndroidAsync(PushNoticeToAndroidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushNoticeToAndroidWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Send a notification to iOS devices. The notification uses Apple’s APNs channel and appears directly in the device notification center.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>This operation is deprecated. Use the <a href="https://help.aliyun.com/document_detail/2249916.html">Advanced Push API</a> instead. Set the <c>DeviceType</c> parameter to <c>iOS</c> and the <c>PushType</c> parameter to <c>NOTICE</c>.</em>*
        /// <b>Before you use this operation, review the <a href="https://help.aliyun.com/document_detail/434638.html">pricing and billing model</a> for EMAS Mobile Push.</b></para>
        /// </description>
        /// 
        /// <param name="request">
        /// PushNoticeToiOSRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushNoticeToiOSResponse
        /// </returns>
        public PushNoticeToiOSResponse PushNoticeToiOSWithOptions(PushNoticeToiOSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApnsEnv))
            {
                query["ApnsEnv"] = request.ApnsEnv;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                query["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtParameters))
            {
                query["ExtParameters"] = request.ExtParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobKey))
            {
                query["JobKey"] = request.JobKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushNoticeToiOS",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushNoticeToiOSResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Send a notification to iOS devices. The notification uses Apple’s APNs channel and appears directly in the device notification center.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>This operation is deprecated. Use the <a href="https://help.aliyun.com/document_detail/2249916.html">Advanced Push API</a> instead. Set the <c>DeviceType</c> parameter to <c>iOS</c> and the <c>PushType</c> parameter to <c>NOTICE</c>.</em>*
        /// <b>Before you use this operation, review the <a href="https://help.aliyun.com/document_detail/434638.html">pricing and billing model</a> for EMAS Mobile Push.</b></para>
        /// </description>
        /// 
        /// <param name="request">
        /// PushNoticeToiOSRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushNoticeToiOSResponse
        /// </returns>
        public async Task<PushNoticeToiOSResponse> PushNoticeToiOSWithOptionsAsync(PushNoticeToiOSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApnsEnv))
            {
                query["ApnsEnv"] = request.ApnsEnv;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                query["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtParameters))
            {
                query["ExtParameters"] = request.ExtParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobKey))
            {
                query["JobKey"] = request.JobKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushNoticeToiOS",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushNoticeToiOSResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Send a notification to iOS devices. The notification uses Apple’s APNs channel and appears directly in the device notification center.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>This operation is deprecated. Use the <a href="https://help.aliyun.com/document_detail/2249916.html">Advanced Push API</a> instead. Set the <c>DeviceType</c> parameter to <c>iOS</c> and the <c>PushType</c> parameter to <c>NOTICE</c>.</em>*
        /// <b>Before you use this operation, review the <a href="https://help.aliyun.com/document_detail/434638.html">pricing and billing model</a> for EMAS Mobile Push.</b></para>
        /// </description>
        /// 
        /// <param name="request">
        /// PushNoticeToiOSRequest
        /// </param>
        /// 
        /// <returns>
        /// PushNoticeToiOSResponse
        /// </returns>
        public PushNoticeToiOSResponse PushNoticeToiOS(PushNoticeToiOSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushNoticeToiOSWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Send a notification to iOS devices. The notification uses Apple’s APNs channel and appears directly in the device notification center.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>This operation is deprecated. Use the <a href="https://help.aliyun.com/document_detail/2249916.html">Advanced Push API</a> instead. Set the <c>DeviceType</c> parameter to <c>iOS</c> and the <c>PushType</c> parameter to <c>NOTICE</c>.</em>*
        /// <b>Before you use this operation, review the <a href="https://help.aliyun.com/document_detail/434638.html">pricing and billing model</a> for EMAS Mobile Push.</b></para>
        /// </description>
        /// 
        /// <param name="request">
        /// PushNoticeToiOSRequest
        /// </param>
        /// 
        /// <returns>
        /// PushNoticeToiOSResponse
        /// </returns>
        public async Task<PushNoticeToiOSResponse> PushNoticeToiOSAsync(PushNoticeToiOSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushNoticeToiOSWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This is the advanced push API v2.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this API, review the <a href="https://help.aliyun.com/document_detail/434638.html">pricing and billing methods</a> for EMAS Mobile Push.</em>*
        /// This API supports Android, iOS, and HarmonyOS. For each platform, pass its assigned AppKey.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// PushV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushV2Response
        /// </returns>
        public PushV2Response PushV2WithOptions(PushV2Request tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushV2ShrinkRequest request = new PushV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PushTask))
            {
                request.PushTaskShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PushTask, "PushTask", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentToken))
            {
                query["IdempotentToken"] = request.IdempotentToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushTaskShrink))
            {
                query["PushTask"] = request.PushTaskShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushV2",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushV2Response>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This is the advanced push API v2.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this API, review the <a href="https://help.aliyun.com/document_detail/434638.html">pricing and billing methods</a> for EMAS Mobile Push.</em>*
        /// This API supports Android, iOS, and HarmonyOS. For each platform, pass its assigned AppKey.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// PushV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushV2Response
        /// </returns>
        public async Task<PushV2Response> PushV2WithOptionsAsync(PushV2Request tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushV2ShrinkRequest request = new PushV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PushTask))
            {
                request.PushTaskShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PushTask, "PushTask", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentToken))
            {
                query["IdempotentToken"] = request.IdempotentToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushTaskShrink))
            {
                query["PushTask"] = request.PushTaskShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushV2",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This is the advanced push API v2.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this API, review the <a href="https://help.aliyun.com/document_detail/434638.html">pricing and billing methods</a> for EMAS Mobile Push.</em>*
        /// This API supports Android, iOS, and HarmonyOS. For each platform, pass its assigned AppKey.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PushV2Request
        /// </param>
        /// 
        /// <returns>
        /// PushV2Response
        /// </returns>
        public PushV2Response PushV2(PushV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushV2WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This is the advanced push API v2.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this API, review the <a href="https://help.aliyun.com/document_detail/434638.html">pricing and billing methods</a> for EMAS Mobile Push.</em>*
        /// This API supports Android, iOS, and HarmonyOS. For each platform, pass its assigned AppKey.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PushV2Request
        /// </param>
        /// 
        /// <returns>
        /// PushV2Response
        /// </returns>
        public async Task<PushV2Response> PushV2Async(PushV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushV2WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of aliases attached to a specified device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAliasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAliasesResponse
        /// </returns>
        public QueryAliasesResponse QueryAliasesWithOptions(QueryAliasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAliases",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAliasesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of aliases attached to a specified device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAliasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAliasesResponse
        /// </returns>
        public async Task<QueryAliasesResponse> QueryAliasesWithOptionsAsync(QueryAliasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAliases",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAliasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of aliases attached to a specified device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAliasesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAliasesResponse
        /// </returns>
        public QueryAliasesResponse QueryAliases(QueryAliasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAliasesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of aliases attached to a specified device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAliasesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAliasesResponse
        /// </returns>
        public async Task<QueryAliasesResponse> QueryAliasesAsync(QueryAliasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAliasesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query details of a specified device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceInfoResponse
        /// </returns>
        public QueryDeviceInfoResponse QueryDeviceInfoWithOptions(QueryDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceInfo",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query details of a specified device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceInfoResponse
        /// </returns>
        public async Task<QueryDeviceInfoResponse> QueryDeviceInfoWithOptionsAsync(QueryDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceInfo",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query details of a specified device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceInfoResponse
        /// </returns>
        public QueryDeviceInfoResponse QueryDeviceInfo(QueryDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query details of a specified device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceInfoResponse
        /// </returns>
        public async Task<QueryDeviceInfoResponse> QueryDeviceInfoAsync(QueryDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries device statistics by application dimension.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Currently, this API supports only daily data. The daily dimension lets you query data for up to 31 days. Days are calculated based on UTC+8.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryDeviceStatRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceStatResponse
        /// </returns>
        public QueryDeviceStatResponse QueryDeviceStatWithOptions(QueryDeviceStatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                query["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
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
                Action = "QueryDeviceStat",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceStatResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries device statistics by application dimension.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Currently, this API supports only daily data. The daily dimension lets you query data for up to 31 days. Days are calculated based on UTC+8.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryDeviceStatRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceStatResponse
        /// </returns>
        public async Task<QueryDeviceStatResponse> QueryDeviceStatWithOptionsAsync(QueryDeviceStatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                query["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
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
                Action = "QueryDeviceStat",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceStatResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries device statistics by application dimension.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Currently, this API supports only daily data. The daily dimension lets you query data for up to 31 days. Days are calculated based on UTC+8.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryDeviceStatRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceStatResponse
        /// </returns>
        public QueryDeviceStatResponse QueryDeviceStat(QueryDeviceStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceStatWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries device statistics by application dimension.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Currently, this API supports only daily data. The daily dimension lets you query data for up to 31 days. Days are calculated based on UTC+8.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryDeviceStatRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceStatResponse
        /// </returns>
        public async Task<QueryDeviceStatResponse> QueryDeviceStatAsync(QueryDeviceStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceStatWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the list of devices associated with an account using the account name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDevicesByAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDevicesByAccountResponse
        /// </returns>
        public QueryDevicesByAccountResponse QueryDevicesByAccountWithOptions(QueryDevicesByAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                query["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDevicesByAccount",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicesByAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the list of devices associated with an account using the account name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDevicesByAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDevicesByAccountResponse
        /// </returns>
        public async Task<QueryDevicesByAccountResponse> QueryDevicesByAccountWithOptionsAsync(QueryDevicesByAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                query["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDevicesByAccount",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicesByAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the list of devices associated with an account using the account name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDevicesByAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDevicesByAccountResponse
        /// </returns>
        public QueryDevicesByAccountResponse QueryDevicesByAccount(QueryDevicesByAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDevicesByAccountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the list of devices associated with an account using the account name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDevicesByAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDevicesByAccountResponse
        /// </returns>
        public async Task<QueryDevicesByAccountResponse> QueryDevicesByAccountAsync(QueryDevicesByAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDevicesByAccountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of devices by alias.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDevicesByAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDevicesByAliasResponse
        /// </returns>
        public QueryDevicesByAliasResponse QueryDevicesByAliasWithOptions(QueryDevicesByAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                query["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDevicesByAlias",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicesByAliasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of devices by alias.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDevicesByAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDevicesByAliasResponse
        /// </returns>
        public async Task<QueryDevicesByAliasResponse> QueryDevicesByAliasWithOptionsAsync(QueryDevicesByAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                query["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDevicesByAlias",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicesByAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of devices by alias.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDevicesByAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDevicesByAliasResponse
        /// </returns>
        public QueryDevicesByAliasResponse QueryDevicesByAlias(QueryDevicesByAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDevicesByAliasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of devices by alias.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDevicesByAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDevicesByAliasResponse
        /// </returns>
        public async Task<QueryDevicesByAliasResponse> QueryDevicesByAliasAsync(QueryDevicesByAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDevicesByAliasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can query push records with pagination and basic filtering.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPushRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPushRecordsResponse
        /// </returns>
        public QueryPushRecordsResponse QueryPushRecordsWithOptions(QueryPushRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushType))
            {
                query["PushType"] = request.PushType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPushRecords",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPushRecordsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can query push records with pagination and basic filtering.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPushRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPushRecordsResponse
        /// </returns>
        public async Task<QueryPushRecordsResponse> QueryPushRecordsWithOptionsAsync(QueryPushRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushType))
            {
                query["PushType"] = request.PushType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPushRecords",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPushRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can query push records with pagination and basic filtering.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPushRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPushRecordsResponse
        /// </returns>
        public QueryPushRecordsResponse QueryPushRecords(QueryPushRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPushRecordsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can query push records with pagination and basic filtering.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPushRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPushRecordsResponse
        /// </returns>
        public async Task<QueryPushRecordsResponse> QueryPushRecordsAsync(QueryPushRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPushRecordsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query push statistics for an app.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPushStatByAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPushStatByAppResponse
        /// </returns>
        public QueryPushStatByAppResponse QueryPushStatByAppWithOptions(QueryPushStatByAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
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
                Action = "QueryPushStatByApp",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPushStatByAppResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query push statistics for an app.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPushStatByAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPushStatByAppResponse
        /// </returns>
        public async Task<QueryPushStatByAppResponse> QueryPushStatByAppWithOptionsAsync(QueryPushStatByAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
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
                Action = "QueryPushStatByApp",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPushStatByAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query push statistics for an app.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPushStatByAppRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPushStatByAppResponse
        /// </returns>
        public QueryPushStatByAppResponse QueryPushStatByApp(QueryPushStatByAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPushStatByAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query push statistics for an app.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPushStatByAppRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPushStatByAppResponse
        /// </returns>
        public async Task<QueryPushStatByAppResponse> QueryPushStatByAppAsync(QueryPushStatByAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPushStatByAppWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries push statistics for a message.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPushStatByMsgRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPushStatByMsgResponse
        /// </returns>
        public QueryPushStatByMsgResponse QueryPushStatByMsgWithOptions(QueryPushStatByMsgRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPushStatByMsg",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPushStatByMsgResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries push statistics for a message.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPushStatByMsgRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPushStatByMsgResponse
        /// </returns>
        public async Task<QueryPushStatByMsgResponse> QueryPushStatByMsgWithOptionsAsync(QueryPushStatByMsgRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPushStatByMsg",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPushStatByMsgResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries push statistics for a message.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPushStatByMsgRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPushStatByMsgResponse
        /// </returns>
        public QueryPushStatByMsgResponse QueryPushStatByMsg(QueryPushStatByMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPushStatByMsgWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries push statistics for a message.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPushStatByMsgRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPushStatByMsgResponse
        /// </returns>
        public async Task<QueryPushStatByMsgResponse> QueryPushStatByMsgAsync(QueryPushStatByMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPushStatByMsgWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tags for a specified object, such as a device, account, or alias.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTagsResponse
        /// </returns>
        public QueryTagsResponse QueryTagsWithOptions(QueryTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientKey))
            {
                query["ClientKey"] = request.ClientKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyType))
            {
                query["KeyType"] = request.KeyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTags",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTagsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tags for a specified object, such as a device, account, or alias.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTagsResponse
        /// </returns>
        public async Task<QueryTagsResponse> QueryTagsWithOptionsAsync(QueryTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientKey))
            {
                query["ClientKey"] = request.ClientKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyType))
            {
                query["KeyType"] = request.KeyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTags",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tags for a specified object, such as a device, account, or alias.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTagsResponse
        /// </returns>
        public QueryTagsResponse QueryTags(QueryTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTagsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tags for a specified object, such as a device, account, or alias.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTagsResponse
        /// </returns>
        public async Task<QueryTagsResponse> QueryTagsAsync(QueryTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTagsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain deduplicated device statistics for an app.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation returns data only at the daily granularity. You can query up to 31 days of data. Deduplicated device counts reset on the first day of each month.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryUniqueDeviceStatRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUniqueDeviceStatResponse
        /// </returns>
        public QueryUniqueDeviceStatResponse QueryUniqueDeviceStatWithOptions(QueryUniqueDeviceStatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
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
                Action = "QueryUniqueDeviceStat",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUniqueDeviceStatResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain deduplicated device statistics for an app.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation returns data only at the daily granularity. You can query up to 31 days of data. Deduplicated device counts reset on the first day of each month.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryUniqueDeviceStatRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUniqueDeviceStatResponse
        /// </returns>
        public async Task<QueryUniqueDeviceStatResponse> QueryUniqueDeviceStatWithOptionsAsync(QueryUniqueDeviceStatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
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
                Action = "QueryUniqueDeviceStat",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUniqueDeviceStatResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain deduplicated device statistics for an app.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation returns data only at the daily granularity. You can query up to 31 days of data. Deduplicated device counts reset on the first day of each month.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryUniqueDeviceStatRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUniqueDeviceStatResponse
        /// </returns>
        public QueryUniqueDeviceStatResponse QueryUniqueDeviceStat(QueryUniqueDeviceStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUniqueDeviceStatWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain deduplicated device statistics for an app.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation returns data only at the daily granularity. You can query up to 31 days of data. Deduplicated device counts reset on the first day of each month.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryUniqueDeviceStatRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUniqueDeviceStatResponse
        /// </returns>
        public async Task<QueryUniqueDeviceStatResponse> QueryUniqueDeviceStatAsync(QueryUniqueDeviceStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUniqueDeviceStatWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a tag from an app.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deleting a tag takes time. The time required depends on the number of tagged resources. Do not immediately recreate a tag with the same name after you delete it. Wait at least 5 minutes before you recreate a tag in the same app. If you delete multiple tags, wait at least 5 minutes for each deleted tag before you recreate them.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveTagResponse
        /// </returns>
        public RemoveTagResponse RemoveTagWithOptions(RemoveTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveTag",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a tag from an app.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deleting a tag takes time. The time required depends on the number of tagged resources. Do not immediately recreate a tag with the same name after you delete it. Wait at least 5 minutes before you recreate a tag in the same app. If you delete multiple tags, wait at least 5 minutes for each deleted tag before you recreate them.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveTagResponse
        /// </returns>
        public async Task<RemoveTagResponse> RemoveTagWithOptionsAsync(RemoveTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveTag",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a tag from an app.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deleting a tag takes time. The time required depends on the number of tagged resources. Do not immediately recreate a tag with the same name after you delete it. Wait at least 5 minutes before you recreate a tag in the same app. If you delete multiple tags, wait at least 5 minutes for each deleted tag before you recreate them.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveTagRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveTagResponse
        /// </returns>
        public RemoveTagResponse RemoveTag(RemoveTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a tag from an app.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deleting a tag takes time. The time required depends on the number of tagged resources. Do not immediately recreate a tag with the same name after you delete it. Wait at least 5 minutes before you recreate a tag in the same app. If you delete multiple tags, wait at least 5 minutes for each deleted tag before you recreate them.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveTagRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveTagResponse
        /// </returns>
        public async Task<RemoveTagResponse> RemoveTagAsync(RemoveTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveTagWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds an alias. The change takes effect immediately.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindAliasResponse
        /// </returns>
        public UnbindAliasResponse UnbindAliasWithOptions(UnbindAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                query["AliasName"] = request.AliasName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnbindAll))
            {
                query["UnbindAll"] = request.UnbindAll;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindAlias",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindAliasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds an alias. The change takes effect immediately.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindAliasResponse
        /// </returns>
        public async Task<UnbindAliasResponse> UnbindAliasWithOptionsAsync(UnbindAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                query["AliasName"] = request.AliasName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnbindAll))
            {
                query["UnbindAll"] = request.UnbindAll;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindAlias",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds an alias. The change takes effect immediately.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindAliasResponse
        /// </returns>
        public UnbindAliasResponse UnbindAlias(UnbindAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindAliasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds an alias. The change takes effect immediately.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindAliasResponse
        /// </returns>
        public async Task<UnbindAliasResponse> UnbindAliasAsync(UnbindAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindAliasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbind the mobile phone number from a specified device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindPhoneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindPhoneResponse
        /// </returns>
        public UnbindPhoneResponse UnbindPhoneWithOptions(UnbindPhoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindPhone",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindPhoneResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbind the mobile phone number from a specified device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindPhoneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindPhoneResponse
        /// </returns>
        public async Task<UnbindPhoneResponse> UnbindPhoneWithOptionsAsync(UnbindPhoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindPhone",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindPhoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbind the mobile phone number from a specified device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindPhoneRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindPhoneResponse
        /// </returns>
        public UnbindPhoneResponse UnbindPhone(UnbindPhoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindPhoneWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbind the mobile phone number from a specified device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindPhoneRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindPhoneResponse
        /// </returns>
        public async Task<UnbindPhoneResponse> UnbindPhoneAsync(UnbindPhoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindPhoneWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds one or more tags from a specified target.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindTagResponse
        /// </returns>
        public UnbindTagResponse UnbindTagWithOptions(UnbindTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientKey))
            {
                query["ClientKey"] = request.ClientKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyType))
            {
                query["KeyType"] = request.KeyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindTag",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds one or more tags from a specified target.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindTagResponse
        /// </returns>
        public async Task<UnbindTagResponse> UnbindTagWithOptionsAsync(UnbindTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientKey))
            {
                query["ClientKey"] = request.ClientKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyType))
            {
                query["KeyType"] = request.KeyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindTag",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds one or more tags from a specified target.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindTagRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindTagResponse
        /// </returns>
        public UnbindTagResponse UnbindTag(UnbindTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds one or more tags from a specified target.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindTagRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindTagResponse
        /// </returns>
        public async Task<UnbindTagResponse> UnbindTagAsync(UnbindTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindTagWithOptionsAsync(request, runtime);
        }

    }
}
