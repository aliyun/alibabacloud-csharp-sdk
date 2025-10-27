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
        /// <para>绑定别名</para>
        /// </summary>
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
        /// <para>绑定别名</para>
        /// </summary>
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
        /// <para>绑定别名</para>
        /// </summary>
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
        /// <para>绑定别名</para>
        /// </summary>
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
        /// <para>绑定手机号码</para>
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
        /// <para>绑定手机号码</para>
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
        /// <para>绑定手机号码</para>
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
        /// <para>绑定手机号码</para>
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
        /// <para>绑定标签</para>
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
        /// <para>绑定标签</para>
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
        /// <para>绑定标签</para>
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
        /// <para>绑定标签</para>
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
        /// <para>取消定时推送任务</para>
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
        /// <para>取消定时推送任务</para>
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
        /// <para>取消定时推送任务</para>
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
        /// <para>取消定时推送任务</para>
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
        /// <para>【废弃】验证设备有效性</para>
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
        /// <para>【废弃】验证设备有效性</para>
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
        /// <para>【废弃】验证设备有效性</para>
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
        /// <para>【废弃】验证设备有效性</para>
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
        /// <para>批量检查设备有效性</para>
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
        /// <para>批量检查设备有效性</para>
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
        /// <para>批量检查设备有效性</para>
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
        /// <para>批量检查设备有效性</para>
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
        /// <para>完成持续推送任务</para>
        /// </summary>
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
        /// <para>完成持续推送任务</para>
        /// </summary>
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
        /// <para>完成持续推送任务</para>
        /// </summary>
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
        /// <para>完成持续推送任务</para>
        /// </summary>
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
        /// <para>持续推送</para>
        /// </summary>
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
        /// <para>持续推送</para>
        /// </summary>
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
        /// <para>持续推送</para>
        /// </summary>
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
        /// <para>持续推送</para>
        /// </summary>
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
        /// <para>【废弃】查询用户已创建的app列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSummaryAppsRequest
        /// </param>
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
        /// <para>【废弃】查询用户已创建的app列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSummaryAppsRequest
        /// </param>
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
        /// <para>【废弃】查询用户已创建的app列表</para>
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
        /// <para>【废弃】查询用户已创建的app列表</para>
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
        /// <para>获取标签列表</para>
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
        /// <para>获取标签列表</para>
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
        /// <para>获取标签列表</para>
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
        /// <para>获取标签列表</para>
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
        /// <para>批量推送</para>
        /// </summary>
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
        /// <para>批量推送</para>
        /// </summary>
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
        /// <para>批量推送</para>
        /// </summary>
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
        /// <para>批量推送</para>
        /// </summary>
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
        /// <para>新版高级推送接口</para>
        /// </summary>
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
        /// <para>新版高级推送接口</para>
        /// </summary>
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
        /// <para>新版高级推送接口</para>
        /// </summary>
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
        /// <para>新版高级推送接口</para>
        /// </summary>
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
        /// <para>高级推送接口</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaomiImageUrl))
            {
                query["AndroidXiaomiImageUrl"] = request.AndroidXiaomiImageUrl;
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
        /// <para>高级推送接口</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaomiImageUrl))
            {
                query["AndroidXiaomiImageUrl"] = request.AndroidXiaomiImageUrl;
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
        /// <para>高级推送接口</para>
        /// </summary>
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
        /// <para>高级推送接口</para>
        /// </summary>
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
        /// <para>推送消息给Android设备</para>
        /// </summary>
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
        /// <para>推送消息给Android设备</para>
        /// </summary>
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
        /// <para>推送消息给Android设备</para>
        /// </summary>
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
        /// <para>推送消息给Android设备</para>
        /// </summary>
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
        /// <para>推送消息给iOS设备</para>
        /// </summary>
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
        /// <para>推送消息给iOS设备</para>
        /// </summary>
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
        /// <para>推送消息给iOS设备</para>
        /// </summary>
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
        /// <para>推送消息给iOS设备</para>
        /// </summary>
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
        /// <para>推送通知给Android设备</para>
        /// </summary>
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
        /// <para>推送通知给Android设备</para>
        /// </summary>
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
        /// <para>推送通知给Android设备</para>
        /// </summary>
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
        /// <para>推送通知给Android设备</para>
        /// </summary>
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
        /// <para>推送通知给iOS设备</para>
        /// </summary>
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
        /// <para>推送通知给iOS设备</para>
        /// </summary>
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
        /// <para>推送通知给iOS设备</para>
        /// </summary>
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
        /// <para>推送通知给iOS设备</para>
        /// </summary>
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
        /// <para>新版高级推送接口</para>
        /// </summary>
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
        /// <para>新版高级推送接口</para>
        /// </summary>
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
        /// <para>新版高级推送接口</para>
        /// </summary>
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
        /// <para>新版高级推送接口</para>
        /// </summary>
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
        /// <para>查询别名</para>
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
        /// <para>查询别名</para>
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
        /// <para>查询别名</para>
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
        /// <para>查询别名</para>
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
        /// <para>查询设备详情</para>
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
        /// <para>查询设备详情</para>
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
        /// <para>查询设备详情</para>
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
        /// <para>查询设备详情</para>
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
        /// <para>设备新增与留存</para>
        /// </summary>
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
        /// <para>设备新增与留存</para>
        /// </summary>
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
        /// <para>设备新增与留存</para>
        /// </summary>
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
        /// <para>设备新增与留存</para>
        /// </summary>
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
        /// <para>通过账户查询设备列表</para>
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
        /// <para>通过账户查询设备列表</para>
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
        /// <para>通过账户查询设备列表</para>
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
        /// <para>通过账户查询设备列表</para>
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
        /// <para>通过别名查询设备列表</para>
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
        /// <para>通过别名查询设备列表</para>
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
        /// <para>通过别名查询设备列表</para>
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
        /// <para>通过别名查询设备列表</para>
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
        /// <para>App维度推送统计</para>
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
        /// <para>App维度推送统计</para>
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
        /// <para>App维度推送统计</para>
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
        /// <para>App维度推送统计</para>
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
        /// <para>任务维度推送统计</para>
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
        /// <para>任务维度推送统计</para>
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
        /// <para>任务维度推送统计</para>
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
        /// <para>任务维度推送统计</para>
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
        /// <para>查询标签列表</para>
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
        /// <para>查询标签列表</para>
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
        /// <para>查询标签列表</para>
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
        /// <para>查询标签列表</para>
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
        /// <para>去重设备统计</para>
        /// </summary>
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
        /// <para>去重设备统计</para>
        /// </summary>
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
        /// <para>去重设备统计</para>
        /// </summary>
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
        /// <para>去重设备统计</para>
        /// </summary>
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
        /// <para>删除标签</para>
        /// </summary>
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
        /// <para>删除标签</para>
        /// </summary>
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
        /// <para>删除标签</para>
        /// </summary>
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
        /// <para>删除标签</para>
        /// </summary>
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
        /// <para>解绑别名</para>
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
        /// <para>解绑别名</para>
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
        /// <para>解绑别名</para>
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
        /// <para>解绑别名</para>
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
        /// <para>解绑手机号码</para>
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
        /// <para>解绑手机号码</para>
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
        /// <para>解绑手机号码</para>
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
        /// <para>解绑手机号码</para>
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
        /// <para>绑定标签</para>
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
        /// <para>绑定标签</para>
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
        /// <para>绑定标签</para>
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
        /// <para>绑定标签</para>
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
