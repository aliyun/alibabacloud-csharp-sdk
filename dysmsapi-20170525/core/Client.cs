// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dysmsapi20170525.Models;

namespace AlibabaCloud.SDK.Dysmsapi20170525
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-southeast-1", "dysmsapi.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "dysmsapi.ap-southeast-5.aliyuncs.com"},
                {"cn-beijing", "dysmsapi-proxy.cn-beijing.aliyuncs.com"},
                {"cn-hongkong", "dysmsapi-xman.cn-hongkong.aliyuncs.com"},
                {"eu-central-1", "dysmsapi.eu-central-1.aliyuncs.com"},
                {"us-east-1", "dysmsapi.us-east-1.aliyuncs.com"},
                {"cn-zhangjiakou", "dysmsapi.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "dysmsapi.aliyuncs.com"},
                {"cn-shenzhen", "dysmsapi.aliyuncs.com"},
                {"cn-shanghai-finance-1", "dysmsapi.aliyuncs.com"},
                {"cn-qingdao", "dysmsapi.aliyuncs.com"},
                {"cn-north-2-gov-1", "dysmsapi.aliyuncs.com"},
                {"cn-huhehaote", "dysmsapi.aliyuncs.com"},
                {"cn-hangzhou-finance", "dysmsapi.aliyuncs.com"},
                {"cn-hangzhou", "dysmsapi.aliyuncs.com"},
                {"cn-chengdu", "dysmsapi.aliyuncs.com"},
                {"cn-beijing-finance-1", "dysmsapi.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("dysmsapi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>添加验证码签名信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddExtCodeSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddExtCodeSignResponse
        /// </returns>
        public AddExtCodeSignResponse AddExtCodeSignWithOptions(AddExtCodeSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtCode))
            {
                query["ExtCode"] = request.ExtCode;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddExtCodeSign",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddExtCodeSignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加验证码签名信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddExtCodeSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddExtCodeSignResponse
        /// </returns>
        public async Task<AddExtCodeSignResponse> AddExtCodeSignWithOptionsAsync(AddExtCodeSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtCode))
            {
                query["ExtCode"] = request.ExtCode;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddExtCodeSign",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddExtCodeSignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加验证码签名信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddExtCodeSignRequest
        /// </param>
        /// 
        /// <returns>
        /// AddExtCodeSignResponse
        /// </returns>
        public AddExtCodeSignResponse AddExtCodeSign(AddExtCodeSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddExtCodeSignWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加验证码签名信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddExtCodeSignRequest
        /// </param>
        /// 
        /// <returns>
        /// AddExtCodeSignResponse
        /// </returns>
        public async Task<AddExtCodeSignResponse> AddExtCodeSignAsync(AddExtCodeSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddExtCodeSignWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建/编辑5G消息固定菜单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRcsSignMenuRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddRcsSignMenuResponse
        /// </returns>
        public AddRcsSignMenuResponse AddRcsSignMenuWithOptions(AddRcsSignMenuRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MenuContent))
            {
                query["MenuContent"] = request.MenuContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddRcsSignMenu",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRcsSignMenuResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建/编辑5G消息固定菜单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRcsSignMenuRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddRcsSignMenuResponse
        /// </returns>
        public async Task<AddRcsSignMenuResponse> AddRcsSignMenuWithOptionsAsync(AddRcsSignMenuRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MenuContent))
            {
                query["MenuContent"] = request.MenuContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddRcsSignMenu",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRcsSignMenuResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建/编辑5G消息固定菜单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRcsSignMenuRequest
        /// </param>
        /// 
        /// <returns>
        /// AddRcsSignMenuResponse
        /// </returns>
        public AddRcsSignMenuResponse AddRcsSignMenu(AddRcsSignMenuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddRcsSignMenuWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建/编辑5G消息固定菜单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRcsSignMenuRequest
        /// </param>
        /// 
        /// <returns>
        /// AddRcsSignMenuResponse
        /// </returns>
        public async Task<AddRcsSignMenuResponse> AddRcsSignMenuAsync(AddRcsSignMenuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddRcsSignMenuWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a short URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: 
        /// Short Message Service does not currently support this API operation.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can create up to 3,000 short URLs per calendar day.</description></item>
        /// <item><description>After a short URL is generated, it must pass a security review, which typically takes 10 minutes to 2 hours. You cannot access the short URL until it passes this review.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddShortUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddShortUrlResponse
        /// </returns>
        public AddShortUrlResponse AddShortUrlWithOptions(AddShortUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveDays))
            {
                body["EffectiveDays"] = request.EffectiveDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShortUrlName))
            {
                body["ShortUrlName"] = request.ShortUrlName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUrl))
            {
                body["SourceUrl"] = request.SourceUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddShortUrl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddShortUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a short URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: 
        /// Short Message Service does not currently support this API operation.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can create up to 3,000 short URLs per calendar day.</description></item>
        /// <item><description>After a short URL is generated, it must pass a security review, which typically takes 10 minutes to 2 hours. You cannot access the short URL until it passes this review.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddShortUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddShortUrlResponse
        /// </returns>
        public async Task<AddShortUrlResponse> AddShortUrlWithOptionsAsync(AddShortUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveDays))
            {
                body["EffectiveDays"] = request.EffectiveDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShortUrlName))
            {
                body["ShortUrlName"] = request.ShortUrlName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUrl))
            {
                body["SourceUrl"] = request.SourceUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddShortUrl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddShortUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a short URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: 
        /// Short Message Service does not currently support this API operation.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can create up to 3,000 short URLs per calendar day.</description></item>
        /// <item><description>After a short URL is generated, it must pass a security review, which typically takes 10 minutes to 2 hours. You cannot access the short URL until it passes this review.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddShortUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// AddShortUrlResponse
        /// </returns>
        public AddShortUrlResponse AddShortUrl(AddShortUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddShortUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a short URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: 
        /// Short Message Service does not currently support this API operation.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can create up to 3,000 short URLs per calendar day.</description></item>
        /// <item><description>After a short URL is generated, it must pass a security review, which typically takes 10 minutes to 2 hours. You cannot access the short URL until it passes this review.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddShortUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// AddShortUrlResponse
        /// </returns>
        public async Task<AddShortUrlResponse> AddShortUrlAsync(AddShortUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddShortUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API has been discontinued.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>In accordance with the regulations of the Ministry of Industry and Information Technology (MIIT) and the <a href="https://help.aliyun.com/document_detail/2806975.html">relevant requirements</a> of carriers, Alibaba Cloud has made functional modifications to signature-related APIs. To improve the review efficiency and approval rate of your signatures, use the new API <a href="https://help.aliyun.com/document_detail/2807427.html">CreateSmsSign - Apply for an SMS signature</a>.</description></item>
        /// <item><description>An individual user can apply for one signature per natural day under the same Alibaba Cloud account. Enterprise users have no limit on the number of applications. For details about the differences in rights and interests between individual users and enterprise users, see <a href="https://help.aliyun.com/document_detail/55324.html">Usage notes</a>.</description></item>
        /// <item><description>The signature information applied for through the API is synchronized to the SMS console. For operations on signatures in the console, see <a href="https://help.aliyun.com/document_detail/108073.html">SMS signatures</a>.</description></item>
        /// <item><description>After you submit a signature application, you can call the <a href="https://help.aliyun.com/document_detail/419283.html">QuerySmsSign</a> API to query the review status and details of the signature. You can also <a href="https://help.aliyun.com/document_detail/101508.html">configure receipt messages</a> and use <a href="https://help.aliyun.com/document_detail/120998.html">SignSmsReport</a> to obtain signature review status messages.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The single-user QPS limit for this API is 1 call per second. If the limit is exceeded, API calls will be throttled, which may affect your business. Call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddSmsSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddSmsSignResponse
        /// </returns>
        public AddSmsSignResponse AddSmsSignWithOptions(AddSmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignSource))
            {
                query["SignSource"] = request.SignSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignType))
            {
                query["SignType"] = request.SignType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignFileList))
            {
                body["SignFileList"] = request.SignFileList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSmsSign",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSmsSignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API has been discontinued.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>In accordance with the regulations of the Ministry of Industry and Information Technology (MIIT) and the <a href="https://help.aliyun.com/document_detail/2806975.html">relevant requirements</a> of carriers, Alibaba Cloud has made functional modifications to signature-related APIs. To improve the review efficiency and approval rate of your signatures, use the new API <a href="https://help.aliyun.com/document_detail/2807427.html">CreateSmsSign - Apply for an SMS signature</a>.</description></item>
        /// <item><description>An individual user can apply for one signature per natural day under the same Alibaba Cloud account. Enterprise users have no limit on the number of applications. For details about the differences in rights and interests between individual users and enterprise users, see <a href="https://help.aliyun.com/document_detail/55324.html">Usage notes</a>.</description></item>
        /// <item><description>The signature information applied for through the API is synchronized to the SMS console. For operations on signatures in the console, see <a href="https://help.aliyun.com/document_detail/108073.html">SMS signatures</a>.</description></item>
        /// <item><description>After you submit a signature application, you can call the <a href="https://help.aliyun.com/document_detail/419283.html">QuerySmsSign</a> API to query the review status and details of the signature. You can also <a href="https://help.aliyun.com/document_detail/101508.html">configure receipt messages</a> and use <a href="https://help.aliyun.com/document_detail/120998.html">SignSmsReport</a> to obtain signature review status messages.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The single-user QPS limit for this API is 1 call per second. If the limit is exceeded, API calls will be throttled, which may affect your business. Call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddSmsSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddSmsSignResponse
        /// </returns>
        public async Task<AddSmsSignResponse> AddSmsSignWithOptionsAsync(AddSmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignSource))
            {
                query["SignSource"] = request.SignSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignType))
            {
                query["SignType"] = request.SignType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignFileList))
            {
                body["SignFileList"] = request.SignFileList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSmsSign",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSmsSignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API has been discontinued.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>In accordance with the regulations of the Ministry of Industry and Information Technology (MIIT) and the <a href="https://help.aliyun.com/document_detail/2806975.html">relevant requirements</a> of carriers, Alibaba Cloud has made functional modifications to signature-related APIs. To improve the review efficiency and approval rate of your signatures, use the new API <a href="https://help.aliyun.com/document_detail/2807427.html">CreateSmsSign - Apply for an SMS signature</a>.</description></item>
        /// <item><description>An individual user can apply for one signature per natural day under the same Alibaba Cloud account. Enterprise users have no limit on the number of applications. For details about the differences in rights and interests between individual users and enterprise users, see <a href="https://help.aliyun.com/document_detail/55324.html">Usage notes</a>.</description></item>
        /// <item><description>The signature information applied for through the API is synchronized to the SMS console. For operations on signatures in the console, see <a href="https://help.aliyun.com/document_detail/108073.html">SMS signatures</a>.</description></item>
        /// <item><description>After you submit a signature application, you can call the <a href="https://help.aliyun.com/document_detail/419283.html">QuerySmsSign</a> API to query the review status and details of the signature. You can also <a href="https://help.aliyun.com/document_detail/101508.html">configure receipt messages</a> and use <a href="https://help.aliyun.com/document_detail/120998.html">SignSmsReport</a> to obtain signature review status messages.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The single-user QPS limit for this API is 1 call per second. If the limit is exceeded, API calls will be throttled, which may affect your business. Call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddSmsSignRequest
        /// </param>
        /// 
        /// <returns>
        /// AddSmsSignResponse
        /// </returns>
        public AddSmsSignResponse AddSmsSign(AddSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSmsSignWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API has been discontinued.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>In accordance with the regulations of the Ministry of Industry and Information Technology (MIIT) and the <a href="https://help.aliyun.com/document_detail/2806975.html">relevant requirements</a> of carriers, Alibaba Cloud has made functional modifications to signature-related APIs. To improve the review efficiency and approval rate of your signatures, use the new API <a href="https://help.aliyun.com/document_detail/2807427.html">CreateSmsSign - Apply for an SMS signature</a>.</description></item>
        /// <item><description>An individual user can apply for one signature per natural day under the same Alibaba Cloud account. Enterprise users have no limit on the number of applications. For details about the differences in rights and interests between individual users and enterprise users, see <a href="https://help.aliyun.com/document_detail/55324.html">Usage notes</a>.</description></item>
        /// <item><description>The signature information applied for through the API is synchronized to the SMS console. For operations on signatures in the console, see <a href="https://help.aliyun.com/document_detail/108073.html">SMS signatures</a>.</description></item>
        /// <item><description>After you submit a signature application, you can call the <a href="https://help.aliyun.com/document_detail/419283.html">QuerySmsSign</a> API to query the review status and details of the signature. You can also <a href="https://help.aliyun.com/document_detail/101508.html">configure receipt messages</a> and use <a href="https://help.aliyun.com/document_detail/120998.html">SignSmsReport</a> to obtain signature review status messages.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The single-user QPS limit for this API is 1 call per second. If the limit is exceeded, API calls will be throttled, which may affect your business. Call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddSmsSignRequest
        /// </param>
        /// 
        /// <returns>
        /// AddSmsSignResponse
        /// </returns>
        public async Task<AddSmsSignResponse> AddSmsSignAsync(AddSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSmsSignWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI AddSmsTemplate is deprecated, please use Dysmsapi::2017-05-25::CreateSmsTemplate instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An SMS template is the detailed content received by the recipient, including variables and template content. You can apply for verification code, notification, or promotional SMS templates based on your business needs. SMS can only be sent after the template is approved.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>In accordance with the regulations of the Ministry of Industry and Information Technology and the <a href="https://help.aliyun.com/document_detail/2806975.html">related requirements</a> of carriers, Alibaba Cloud has revamped the functionality of template-related APIs. To improve the review efficiency and approval rate of your templates, please use the new operation <a href="https://help.aliyun.com/document_detail/2807431.html">CreateSmsTemplate - Apply for SMS template</a>.</description></item>
        /// <item><description>You can submit a maximum of 100 SMS template applications per natural day via the API. It is recommended that each application be submitted at intervals of at least 30 seconds. There is no limit on the number of submissions when applying for SMS templates through the <a href="https://dysms.console.aliyun.com/domestic/text/template">console</a>.</description></item>
        /// <item><description>Template information applied for through the API is synchronized to the SMS service console. For related template operations in the console, see <a href="https://help.aliyun.com/document_detail/108085.html">SMS templates</a>.</description></item>
        /// <item><description>After submitting the template application, you can query the template review status and details through the <a href="https://help.aliyun.com/document_detail/419289.html">QuerySmsTemplate</a> operation. You can also <a href="https://help.aliyun.com/document_detail/101508.html">configure receipt messages</a> and obtain the template review status messages through <a href="https://help.aliyun.com/document_detail/120999.html">TemplateSmsReport</a>.</description></item>
        /// <item><description>Domestic SMS templates and international/Hong Kong, Macao, and Taiwan SMS templates are not interchangeable (cannot be mixed). Please apply for templates based on your business usage scenarios.</description></item>
        /// <item><description>Only enterprise-verified users can apply for promotional SMS and international/Hong Kong, Macao, and Taiwan messages. For details about the differences between individual and enterprise user privileges, see <a href="https://help.aliyun.com/document_detail/55324.html">Usage notes</a>.</description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <para>The per-user QPS limit for this operation is 1,000 calls per second. If the limit is exceeded, API calls will be throttled, which may affect your business. Please call the operation reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddSmsTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddSmsTemplateResponse
        /// </returns>
        [Obsolete("OpenAPI AddSmsTemplate is deprecated, please use Dysmsapi::2017-05-25::CreateSmsTemplate instead.")]
        // Deprecated
        public AddSmsTemplateResponse AddSmsTemplateWithOptions(AddSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateContent))
            {
                query["TemplateContent"] = request.TemplateContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSmsTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSmsTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI AddSmsTemplate is deprecated, please use Dysmsapi::2017-05-25::CreateSmsTemplate instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An SMS template is the detailed content received by the recipient, including variables and template content. You can apply for verification code, notification, or promotional SMS templates based on your business needs. SMS can only be sent after the template is approved.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>In accordance with the regulations of the Ministry of Industry and Information Technology and the <a href="https://help.aliyun.com/document_detail/2806975.html">related requirements</a> of carriers, Alibaba Cloud has revamped the functionality of template-related APIs. To improve the review efficiency and approval rate of your templates, please use the new operation <a href="https://help.aliyun.com/document_detail/2807431.html">CreateSmsTemplate - Apply for SMS template</a>.</description></item>
        /// <item><description>You can submit a maximum of 100 SMS template applications per natural day via the API. It is recommended that each application be submitted at intervals of at least 30 seconds. There is no limit on the number of submissions when applying for SMS templates through the <a href="https://dysms.console.aliyun.com/domestic/text/template">console</a>.</description></item>
        /// <item><description>Template information applied for through the API is synchronized to the SMS service console. For related template operations in the console, see <a href="https://help.aliyun.com/document_detail/108085.html">SMS templates</a>.</description></item>
        /// <item><description>After submitting the template application, you can query the template review status and details through the <a href="https://help.aliyun.com/document_detail/419289.html">QuerySmsTemplate</a> operation. You can also <a href="https://help.aliyun.com/document_detail/101508.html">configure receipt messages</a> and obtain the template review status messages through <a href="https://help.aliyun.com/document_detail/120999.html">TemplateSmsReport</a>.</description></item>
        /// <item><description>Domestic SMS templates and international/Hong Kong, Macao, and Taiwan SMS templates are not interchangeable (cannot be mixed). Please apply for templates based on your business usage scenarios.</description></item>
        /// <item><description>Only enterprise-verified users can apply for promotional SMS and international/Hong Kong, Macao, and Taiwan messages. For details about the differences between individual and enterprise user privileges, see <a href="https://help.aliyun.com/document_detail/55324.html">Usage notes</a>.</description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <para>The per-user QPS limit for this operation is 1,000 calls per second. If the limit is exceeded, API calls will be throttled, which may affect your business. Please call the operation reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddSmsTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddSmsTemplateResponse
        /// </returns>
        [Obsolete("OpenAPI AddSmsTemplate is deprecated, please use Dysmsapi::2017-05-25::CreateSmsTemplate instead.")]
        // Deprecated
        public async Task<AddSmsTemplateResponse> AddSmsTemplateWithOptionsAsync(AddSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateContent))
            {
                query["TemplateContent"] = request.TemplateContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSmsTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSmsTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI AddSmsTemplate is deprecated, please use Dysmsapi::2017-05-25::CreateSmsTemplate instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An SMS template is the detailed content received by the recipient, including variables and template content. You can apply for verification code, notification, or promotional SMS templates based on your business needs. SMS can only be sent after the template is approved.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>In accordance with the regulations of the Ministry of Industry and Information Technology and the <a href="https://help.aliyun.com/document_detail/2806975.html">related requirements</a> of carriers, Alibaba Cloud has revamped the functionality of template-related APIs. To improve the review efficiency and approval rate of your templates, please use the new operation <a href="https://help.aliyun.com/document_detail/2807431.html">CreateSmsTemplate - Apply for SMS template</a>.</description></item>
        /// <item><description>You can submit a maximum of 100 SMS template applications per natural day via the API. It is recommended that each application be submitted at intervals of at least 30 seconds. There is no limit on the number of submissions when applying for SMS templates through the <a href="https://dysms.console.aliyun.com/domestic/text/template">console</a>.</description></item>
        /// <item><description>Template information applied for through the API is synchronized to the SMS service console. For related template operations in the console, see <a href="https://help.aliyun.com/document_detail/108085.html">SMS templates</a>.</description></item>
        /// <item><description>After submitting the template application, you can query the template review status and details through the <a href="https://help.aliyun.com/document_detail/419289.html">QuerySmsTemplate</a> operation. You can also <a href="https://help.aliyun.com/document_detail/101508.html">configure receipt messages</a> and obtain the template review status messages through <a href="https://help.aliyun.com/document_detail/120999.html">TemplateSmsReport</a>.</description></item>
        /// <item><description>Domestic SMS templates and international/Hong Kong, Macao, and Taiwan SMS templates are not interchangeable (cannot be mixed). Please apply for templates based on your business usage scenarios.</description></item>
        /// <item><description>Only enterprise-verified users can apply for promotional SMS and international/Hong Kong, Macao, and Taiwan messages. For details about the differences between individual and enterprise user privileges, see <a href="https://help.aliyun.com/document_detail/55324.html">Usage notes</a>.</description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <para>The per-user QPS limit for this operation is 1,000 calls per second. If the limit is exceeded, API calls will be throttled, which may affect your business. Please call the operation reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddSmsTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// AddSmsTemplateResponse
        /// </returns>
        [Obsolete("OpenAPI AddSmsTemplate is deprecated, please use Dysmsapi::2017-05-25::CreateSmsTemplate instead.")]
        // Deprecated
        public AddSmsTemplateResponse AddSmsTemplate(AddSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSmsTemplateWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI AddSmsTemplate is deprecated, please use Dysmsapi::2017-05-25::CreateSmsTemplate instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An SMS template is the detailed content received by the recipient, including variables and template content. You can apply for verification code, notification, or promotional SMS templates based on your business needs. SMS can only be sent after the template is approved.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>In accordance with the regulations of the Ministry of Industry and Information Technology and the <a href="https://help.aliyun.com/document_detail/2806975.html">related requirements</a> of carriers, Alibaba Cloud has revamped the functionality of template-related APIs. To improve the review efficiency and approval rate of your templates, please use the new operation <a href="https://help.aliyun.com/document_detail/2807431.html">CreateSmsTemplate - Apply for SMS template</a>.</description></item>
        /// <item><description>You can submit a maximum of 100 SMS template applications per natural day via the API. It is recommended that each application be submitted at intervals of at least 30 seconds. There is no limit on the number of submissions when applying for SMS templates through the <a href="https://dysms.console.aliyun.com/domestic/text/template">console</a>.</description></item>
        /// <item><description>Template information applied for through the API is synchronized to the SMS service console. For related template operations in the console, see <a href="https://help.aliyun.com/document_detail/108085.html">SMS templates</a>.</description></item>
        /// <item><description>After submitting the template application, you can query the template review status and details through the <a href="https://help.aliyun.com/document_detail/419289.html">QuerySmsTemplate</a> operation. You can also <a href="https://help.aliyun.com/document_detail/101508.html">configure receipt messages</a> and obtain the template review status messages through <a href="https://help.aliyun.com/document_detail/120999.html">TemplateSmsReport</a>.</description></item>
        /// <item><description>Domestic SMS templates and international/Hong Kong, Macao, and Taiwan SMS templates are not interchangeable (cannot be mixed). Please apply for templates based on your business usage scenarios.</description></item>
        /// <item><description>Only enterprise-verified users can apply for promotional SMS and international/Hong Kong, Macao, and Taiwan messages. For details about the differences between individual and enterprise user privileges, see <a href="https://help.aliyun.com/document_detail/55324.html">Usage notes</a>.</description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <para>The per-user QPS limit for this operation is 1,000 calls per second. If the limit is exceeded, API calls will be throttled, which may affect your business. Please call the operation reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddSmsTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// AddSmsTemplateResponse
        /// </returns>
        [Obsolete("OpenAPI AddSmsTemplate is deprecated, please use Dysmsapi::2017-05-25::CreateSmsTemplate instead.")]
        // Deprecated
        public async Task<AddSmsTemplateResponse> AddSmsTemplateAsync(AddSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSmsTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the qualification and authorization letter for a signature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeSignatureQualificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeSignatureQualificationResponse
        /// </returns>
        public ChangeSignatureQualificationResponse ChangeSignatureQualificationWithOptions(ChangeSignatureQualificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationLetterId))
            {
                query["AuthorizationLetterId"] = request.AuthorizationLetterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationId))
            {
                query["QualificationId"] = request.QualificationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignatureName))
            {
                query["SignatureName"] = request.SignatureName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeSignatureQualification",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeSignatureQualificationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the qualification and authorization letter for a signature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeSignatureQualificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeSignatureQualificationResponse
        /// </returns>
        public async Task<ChangeSignatureQualificationResponse> ChangeSignatureQualificationWithOptionsAsync(ChangeSignatureQualificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationLetterId))
            {
                query["AuthorizationLetterId"] = request.AuthorizationLetterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationId))
            {
                query["QualificationId"] = request.QualificationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignatureName))
            {
                query["SignatureName"] = request.SignatureName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeSignatureQualification",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeSignatureQualificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the qualification and authorization letter for a signature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeSignatureQualificationRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeSignatureQualificationResponse
        /// </returns>
        public ChangeSignatureQualificationResponse ChangeSignatureQualification(ChangeSignatureQualificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeSignatureQualificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the qualification and authorization letter for a signature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeSignatureQualificationRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeSignatureQualificationResponse
        /// </returns>
        public async Task<ChangeSignatureQualificationResponse> ChangeSignatureQualificationAsync(ChangeSignatureQualificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeSignatureQualificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether phone numbers support card SMS.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Alibaba Cloud accounts that have not activated card SMS cannot call this API.</description></item>
        /// <item><description>Card SMS is currently in the internal invitation phase. Contact your Alibaba Cloud account manager to apply for activation or <a href="https://help.aliyun.com/document_detail/464625.html">contact Alibaba Cloud pre-sales</a>.</description></item>
        /// <item><description>We recommend that you use the new API <a href="~~QueryMobilesCardSupport~~">QueryMobilesCardSupport</a> to query whether phone numbers support card SMS.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit for this API is 2,000 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Make calls reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckMobilesCardSupportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckMobilesCardSupportResponse
        /// </returns>
        public CheckMobilesCardSupportResponse CheckMobilesCardSupportWithOptions(CheckMobilesCardSupportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobiles))
            {
                query["Mobiles"] = request.Mobiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckMobilesCardSupport",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckMobilesCardSupportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether phone numbers support card SMS.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Alibaba Cloud accounts that have not activated card SMS cannot call this API.</description></item>
        /// <item><description>Card SMS is currently in the internal invitation phase. Contact your Alibaba Cloud account manager to apply for activation or <a href="https://help.aliyun.com/document_detail/464625.html">contact Alibaba Cloud pre-sales</a>.</description></item>
        /// <item><description>We recommend that you use the new API <a href="~~QueryMobilesCardSupport~~">QueryMobilesCardSupport</a> to query whether phone numbers support card SMS.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit for this API is 2,000 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Make calls reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckMobilesCardSupportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckMobilesCardSupportResponse
        /// </returns>
        public async Task<CheckMobilesCardSupportResponse> CheckMobilesCardSupportWithOptionsAsync(CheckMobilesCardSupportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobiles))
            {
                query["Mobiles"] = request.Mobiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckMobilesCardSupport",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckMobilesCardSupportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether phone numbers support card SMS.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Alibaba Cloud accounts that have not activated card SMS cannot call this API.</description></item>
        /// <item><description>Card SMS is currently in the internal invitation phase. Contact your Alibaba Cloud account manager to apply for activation or <a href="https://help.aliyun.com/document_detail/464625.html">contact Alibaba Cloud pre-sales</a>.</description></item>
        /// <item><description>We recommend that you use the new API <a href="~~QueryMobilesCardSupport~~">QueryMobilesCardSupport</a> to query whether phone numbers support card SMS.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit for this API is 2,000 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Make calls reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckMobilesCardSupportRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckMobilesCardSupportResponse
        /// </returns>
        public CheckMobilesCardSupportResponse CheckMobilesCardSupport(CheckMobilesCardSupportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckMobilesCardSupportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether phone numbers support card SMS.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Alibaba Cloud accounts that have not activated card SMS cannot call this API.</description></item>
        /// <item><description>Card SMS is currently in the internal invitation phase. Contact your Alibaba Cloud account manager to apply for activation or <a href="https://help.aliyun.com/document_detail/464625.html">contact Alibaba Cloud pre-sales</a>.</description></item>
        /// <item><description>We recommend that you use the new API <a href="~~QueryMobilesCardSupport~~">QueryMobilesCardSupport</a> to query whether phone numbers support card SMS.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit for this API is 2,000 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Make calls reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckMobilesCardSupportRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckMobilesCardSupportResponse
        /// </returns>
        public async Task<CheckMobilesCardSupportResponse> CheckMobilesCardSupportAsync(CheckMobilesCardSupportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckMobilesCardSupportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reports SMS conversion rate statistics to the Alibaba Cloud SMS platform.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>指标说明：转化率=OTP 转化量/OTP 发送量。</para>
        /// <list type="bullet">
        /// <item><description>OTP发送量：验证码发送量。</description></item>
        /// <item><description>OTP转化量：验证码转换量。（用户成功获取验证码，并进行回传）<remarks>
        /// <para>转化率反馈功能会对业务系统有一定的侵入性，为了防止调用转化率 API 的抖动影响业务逻辑，请考虑： </para>
        /// <list type="bullet">
        /// <item><description>使用异步模式（例如：队列或事件驱动）调用 API。 </description></item>
        /// <item><description>添加可降级的方案保护业务逻辑（例如：手动降级开工或者使用断路器自动降级）。</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ConversionDataIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConversionDataIntlResponse
        /// </returns>
        public ConversionDataIntlResponse ConversionDataIntlWithOptions(ConversionDataIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversionRate))
            {
                query["ConversionRate"] = request.ConversionRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportTime))
            {
                query["ReportTime"] = request.ReportTime;
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
                Action = "ConversionDataIntl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConversionDataIntlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reports SMS conversion rate statistics to the Alibaba Cloud SMS platform.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>指标说明：转化率=OTP 转化量/OTP 发送量。</para>
        /// <list type="bullet">
        /// <item><description>OTP发送量：验证码发送量。</description></item>
        /// <item><description>OTP转化量：验证码转换量。（用户成功获取验证码，并进行回传）<remarks>
        /// <para>转化率反馈功能会对业务系统有一定的侵入性，为了防止调用转化率 API 的抖动影响业务逻辑，请考虑： </para>
        /// <list type="bullet">
        /// <item><description>使用异步模式（例如：队列或事件驱动）调用 API。 </description></item>
        /// <item><description>添加可降级的方案保护业务逻辑（例如：手动降级开工或者使用断路器自动降级）。</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ConversionDataIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConversionDataIntlResponse
        /// </returns>
        public async Task<ConversionDataIntlResponse> ConversionDataIntlWithOptionsAsync(ConversionDataIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversionRate))
            {
                query["ConversionRate"] = request.ConversionRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportTime))
            {
                query["ReportTime"] = request.ReportTime;
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
                Action = "ConversionDataIntl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConversionDataIntlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reports SMS conversion rate statistics to the Alibaba Cloud SMS platform.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>指标说明：转化率=OTP 转化量/OTP 发送量。</para>
        /// <list type="bullet">
        /// <item><description>OTP发送量：验证码发送量。</description></item>
        /// <item><description>OTP转化量：验证码转换量。（用户成功获取验证码，并进行回传）<remarks>
        /// <para>转化率反馈功能会对业务系统有一定的侵入性，为了防止调用转化率 API 的抖动影响业务逻辑，请考虑： </para>
        /// <list type="bullet">
        /// <item><description>使用异步模式（例如：队列或事件驱动）调用 API。 </description></item>
        /// <item><description>添加可降级的方案保护业务逻辑（例如：手动降级开工或者使用断路器自动降级）。</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ConversionDataIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// ConversionDataIntlResponse
        /// </returns>
        public ConversionDataIntlResponse ConversionDataIntl(ConversionDataIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConversionDataIntlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reports SMS conversion rate statistics to the Alibaba Cloud SMS platform.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>指标说明：转化率=OTP 转化量/OTP 发送量。</para>
        /// <list type="bullet">
        /// <item><description>OTP发送量：验证码发送量。</description></item>
        /// <item><description>OTP转化量：验证码转换量。（用户成功获取验证码，并进行回传）<remarks>
        /// <para>转化率反馈功能会对业务系统有一定的侵入性，为了防止调用转化率 API 的抖动影响业务逻辑，请考虑： </para>
        /// <list type="bullet">
        /// <item><description>使用异步模式（例如：队列或事件驱动）调用 API。 </description></item>
        /// <item><description>添加可降级的方案保护业务逻辑（例如：手动降级开工或者使用断路器自动降级）。</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ConversionDataIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// ConversionDataIntlResponse
        /// </returns>
        public async Task<ConversionDataIntlResponse> ConversionDataIntlAsync(ConversionDataIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConversionDataIntlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a card SMS template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The card SMS feature is currently available by invitation only. To enable this feature, contact your Alibaba Cloud business manager or our <a href="https://help.aliyun.com/document_detail/464625.html?spm=a2c4g.11186623.0.0.213273d4Xe6UEu#section-81n-72q-ybm">pre-sales consultation</a> team.</description></item>
        /// <item><description>This operation saves a card SMS template, submits it to mobile phone vendors for review, and returns a template code.</description></item>
        /// <item><description>If a card SMS template contains a type or event that a vendor does not support, the system does not submit the template to that vendor for review. For more information, see <a href="https://help.aliyun.com/document_detail/434611.html">Supported template types by vendor</a>.</description></item>
        /// <item><description>For more examples of card SMS templates, see <a href="https://help.aliyun.com/document_detail/435361.html">Card SMS template examples</a>.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for a single user is 300. API calls that exceed this limit are throttled, which may impact your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateCardSmsTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCardSmsTemplateResponse
        /// </returns>
        public CreateCardSmsTemplateResponse CreateCardSmsTemplateWithOptions(CreateCardSmsTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCardSmsTemplateShrinkRequest request = new CreateCardSmsTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Template))
            {
                request.TemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Template, "Template", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Factorys))
            {
                query["Factorys"] = request.Factorys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memo))
            {
                query["Memo"] = request.Memo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateShrink))
            {
                query["Template"] = request.TemplateShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCardSmsTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCardSmsTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a card SMS template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The card SMS feature is currently available by invitation only. To enable this feature, contact your Alibaba Cloud business manager or our <a href="https://help.aliyun.com/document_detail/464625.html?spm=a2c4g.11186623.0.0.213273d4Xe6UEu#section-81n-72q-ybm">pre-sales consultation</a> team.</description></item>
        /// <item><description>This operation saves a card SMS template, submits it to mobile phone vendors for review, and returns a template code.</description></item>
        /// <item><description>If a card SMS template contains a type or event that a vendor does not support, the system does not submit the template to that vendor for review. For more information, see <a href="https://help.aliyun.com/document_detail/434611.html">Supported template types by vendor</a>.</description></item>
        /// <item><description>For more examples of card SMS templates, see <a href="https://help.aliyun.com/document_detail/435361.html">Card SMS template examples</a>.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for a single user is 300. API calls that exceed this limit are throttled, which may impact your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateCardSmsTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCardSmsTemplateResponse
        /// </returns>
        public async Task<CreateCardSmsTemplateResponse> CreateCardSmsTemplateWithOptionsAsync(CreateCardSmsTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCardSmsTemplateShrinkRequest request = new CreateCardSmsTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Template))
            {
                request.TemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Template, "Template", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Factorys))
            {
                query["Factorys"] = request.Factorys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memo))
            {
                query["Memo"] = request.Memo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateShrink))
            {
                query["Template"] = request.TemplateShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCardSmsTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCardSmsTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a card SMS template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The card SMS feature is currently available by invitation only. To enable this feature, contact your Alibaba Cloud business manager or our <a href="https://help.aliyun.com/document_detail/464625.html?spm=a2c4g.11186623.0.0.213273d4Xe6UEu#section-81n-72q-ybm">pre-sales consultation</a> team.</description></item>
        /// <item><description>This operation saves a card SMS template, submits it to mobile phone vendors for review, and returns a template code.</description></item>
        /// <item><description>If a card SMS template contains a type or event that a vendor does not support, the system does not submit the template to that vendor for review. For more information, see <a href="https://help.aliyun.com/document_detail/434611.html">Supported template types by vendor</a>.</description></item>
        /// <item><description>For more examples of card SMS templates, see <a href="https://help.aliyun.com/document_detail/435361.html">Card SMS template examples</a>.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for a single user is 300. API calls that exceed this limit are throttled, which may impact your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCardSmsTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCardSmsTemplateResponse
        /// </returns>
        public CreateCardSmsTemplateResponse CreateCardSmsTemplate(CreateCardSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCardSmsTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a card SMS template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The card SMS feature is currently available by invitation only. To enable this feature, contact your Alibaba Cloud business manager or our <a href="https://help.aliyun.com/document_detail/464625.html?spm=a2c4g.11186623.0.0.213273d4Xe6UEu#section-81n-72q-ybm">pre-sales consultation</a> team.</description></item>
        /// <item><description>This operation saves a card SMS template, submits it to mobile phone vendors for review, and returns a template code.</description></item>
        /// <item><description>If a card SMS template contains a type or event that a vendor does not support, the system does not submit the template to that vendor for review. For more information, see <a href="https://help.aliyun.com/document_detail/434611.html">Supported template types by vendor</a>.</description></item>
        /// <item><description>For more examples of card SMS templates, see <a href="https://help.aliyun.com/document_detail/435361.html">Card SMS template examples</a>.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for a single user is 300. API calls that exceed this limit are throttled, which may impact your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCardSmsTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCardSmsTemplateResponse
        /// </returns>
        public async Task<CreateCardSmsTemplateResponse> CreateCardSmsTemplateAsync(CreateCardSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCardSmsTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an order to add, update, or delete a digital message signature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates, updates, or deletes a signature.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateDigitalSignOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDigitalSignOrderResponse
        /// </returns>
        public CreateDigitalSignOrderResponse CreateDigitalSignOrderWithOptions(CreateDigitalSignOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDigitalSignOrderShrinkRequest request = new CreateDigitalSignOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OrderContext))
            {
                request.OrderContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OrderContext, "OrderContext", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendMessage))
            {
                query["ExtendMessage"] = request.ExtendMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderContextShrink))
            {
                query["OrderContext"] = request.OrderContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationId))
            {
                query["QualificationId"] = request.QualificationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationVersion))
            {
                query["QualificationVersion"] = request.QualificationVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignId))
            {
                query["SignId"] = request.SignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignIndustry))
            {
                query["SignIndustry"] = request.SignIndustry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignSource))
            {
                query["SignSource"] = request.SignSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Submitter))
            {
                query["Submitter"] = request.Submitter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDigitalSignOrder",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDigitalSignOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an order to add, update, or delete a digital message signature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates, updates, or deletes a signature.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateDigitalSignOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDigitalSignOrderResponse
        /// </returns>
        public async Task<CreateDigitalSignOrderResponse> CreateDigitalSignOrderWithOptionsAsync(CreateDigitalSignOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDigitalSignOrderShrinkRequest request = new CreateDigitalSignOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OrderContext))
            {
                request.OrderContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OrderContext, "OrderContext", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendMessage))
            {
                query["ExtendMessage"] = request.ExtendMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderContextShrink))
            {
                query["OrderContext"] = request.OrderContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationId))
            {
                query["QualificationId"] = request.QualificationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationVersion))
            {
                query["QualificationVersion"] = request.QualificationVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignId))
            {
                query["SignId"] = request.SignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignIndustry))
            {
                query["SignIndustry"] = request.SignIndustry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignSource))
            {
                query["SignSource"] = request.SignSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Submitter))
            {
                query["Submitter"] = request.Submitter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDigitalSignOrder",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDigitalSignOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an order to add, update, or delete a digital message signature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates, updates, or deletes a signature.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDigitalSignOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDigitalSignOrderResponse
        /// </returns>
        public CreateDigitalSignOrderResponse CreateDigitalSignOrder(CreateDigitalSignOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDigitalSignOrderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an order to add, update, or delete a digital message signature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates, updates, or deletes a signature.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDigitalSignOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDigitalSignOrderResponse
        /// </returns>
        public async Task<CreateDigitalSignOrderResponse> CreateDigitalSignOrderAsync(CreateDigitalSignOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDigitalSignOrderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a digital SMS template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Use this operation to create a reusable template for your digital SMS messages.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDigitalSmsTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDigitalSmsTemplateResponse
        /// </returns>
        public CreateDigitalSmsTemplateResponse CreateDigitalSmsTemplateWithOptions(CreateDigitalSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateContents))
            {
                query["TemplateContents"] = request.TemplateContents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDigitalSmsTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDigitalSmsTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a digital SMS template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Use this operation to create a reusable template for your digital SMS messages.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDigitalSmsTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDigitalSmsTemplateResponse
        /// </returns>
        public async Task<CreateDigitalSmsTemplateResponse> CreateDigitalSmsTemplateWithOptionsAsync(CreateDigitalSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateContents))
            {
                query["TemplateContents"] = request.TemplateContents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDigitalSmsTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDigitalSmsTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a digital SMS template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Use this operation to create a reusable template for your digital SMS messages.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDigitalSmsTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDigitalSmsTemplateResponse
        /// </returns>
        public CreateDigitalSmsTemplateResponse CreateDigitalSmsTemplate(CreateDigitalSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDigitalSmsTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a digital SMS template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Use this operation to create a reusable template for your digital SMS messages.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDigitalSmsTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDigitalSmsTemplateResponse
        /// </returns>
        public async Task<CreateDigitalSmsTemplateResponse> CreateDigitalSmsTemplateAsync(CreateDigitalSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDigitalSmsTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建终端5G适配情况查询任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRCSMobileCapableTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRCSMobileCapableTaskResponse
        /// </returns>
        public CreateRCSMobileCapableTaskResponse CreateRCSMobileCapableTaskWithOptions(CreateRCSMobileCapableTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumbersFile))
            {
                query["PhoneNumbersFile"] = request.PhoneNumbersFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRCSMobileCapableTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRCSMobileCapableTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建终端5G适配情况查询任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRCSMobileCapableTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRCSMobileCapableTaskResponse
        /// </returns>
        public async Task<CreateRCSMobileCapableTaskResponse> CreateRCSMobileCapableTaskWithOptionsAsync(CreateRCSMobileCapableTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumbersFile))
            {
                query["PhoneNumbersFile"] = request.PhoneNumbersFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRCSMobileCapableTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRCSMobileCapableTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建终端5G适配情况查询任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRCSMobileCapableTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRCSMobileCapableTaskResponse
        /// </returns>
        public CreateRCSMobileCapableTaskResponse CreateRCSMobileCapableTask(CreateRCSMobileCapableTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRCSMobileCapableTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建终端5G适配情况查询任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRCSMobileCapableTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRCSMobileCapableTaskResponse
        /// </returns>
        public async Task<CreateRCSMobileCapableTaskResponse> CreateRCSMobileCapableTaskAsync(CreateRCSMobileCapableTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRCSMobileCapableTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建5G消息模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRCSTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRCSTemplateResponse
        /// </returns>
        public CreateRCSTemplateResponse CreateRCSTemplateWithOptions(CreateRCSTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedSignNames))
            {
                query["RelatedSignNames"] = request.RelatedSignNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateContent))
            {
                query["TemplateContent"] = request.TemplateContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateFormat))
            {
                query["TemplateFormat"] = request.TemplateFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateMenu))
            {
                query["TemplateMenu"] = request.TemplateMenu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateRule))
            {
                query["TemplateRule"] = request.TemplateRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRCSTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRCSTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建5G消息模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRCSTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRCSTemplateResponse
        /// </returns>
        public async Task<CreateRCSTemplateResponse> CreateRCSTemplateWithOptionsAsync(CreateRCSTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedSignNames))
            {
                query["RelatedSignNames"] = request.RelatedSignNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateContent))
            {
                query["TemplateContent"] = request.TemplateContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateFormat))
            {
                query["TemplateFormat"] = request.TemplateFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateMenu))
            {
                query["TemplateMenu"] = request.TemplateMenu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateRule))
            {
                query["TemplateRule"] = request.TemplateRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRCSTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRCSTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建5G消息模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRCSTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRCSTemplateResponse
        /// </returns>
        public CreateRCSTemplateResponse CreateRCSTemplate(CreateRCSTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRCSTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建5G消息模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRCSTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRCSTemplateResponse
        /// </returns>
        public async Task<CreateRCSTemplateResponse> CreateRCSTemplateAsync(CreateRCSTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRCSTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建短链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSmartShortUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSmartShortUrlResponse
        /// </returns>
        public CreateSmartShortUrlResponse CreateSmartShortUrlWithOptions(CreateSmartShortUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumbers))
            {
                query["PhoneNumbers"] = request.PhoneNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUrl))
            {
                query["SourceUrl"] = request.SourceUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSmartShortUrl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSmartShortUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建短链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSmartShortUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSmartShortUrlResponse
        /// </returns>
        public async Task<CreateSmartShortUrlResponse> CreateSmartShortUrlWithOptionsAsync(CreateSmartShortUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumbers))
            {
                query["PhoneNumbers"] = request.PhoneNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUrl))
            {
                query["SourceUrl"] = request.SourceUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSmartShortUrl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSmartShortUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建短链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSmartShortUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSmartShortUrlResponse
        /// </returns>
        public CreateSmartShortUrlResponse CreateSmartShortUrl(CreateSmartShortUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSmartShortUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建短链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSmartShortUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSmartShortUrlResponse
        /// </returns>
        public async Task<CreateSmartShortUrlResponse> CreateSmartShortUrlAsync(CreateSmartShortUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSmartShortUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The process for using a live app as a signature source has changed. If you use an app as the signature source, you must call this operation to create an ICP filing record for it.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: To use a <b>live app</b> as a signature source, you must now provide its ICP filing information. This requires you to upload a screenshot of the app\&quot;s ICP filing.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSmsAppIcpRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSmsAppIcpRecordResponse
        /// </returns>
        public CreateSmsAppIcpRecordResponse CreateSmsAppIcpRecordWithOptions(CreateSmsAppIcpRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppApprovalDate))
            {
                query["AppApprovalDate"] = request.AppApprovalDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIcpLicenseNumber))
            {
                query["AppIcpLicenseNumber"] = request.AppIcpLicenseNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIcpRecordPic))
            {
                query["AppIcpRecordPic"] = request.AppIcpRecordPic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppPrincipalUnitName))
            {
                query["AppPrincipalUnitName"] = request.AppPrincipalUnitName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppRuntimePic))
            {
                query["AppRuntimePic"] = request.AppRuntimePic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppServiceName))
            {
                query["AppServiceName"] = request.AppServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppStoreDownloadPic))
            {
                query["AppStoreDownloadPic"] = request.AppStoreDownloadPic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
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
                Action = "CreateSmsAppIcpRecord",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSmsAppIcpRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The process for using a live app as a signature source has changed. If you use an app as the signature source, you must call this operation to create an ICP filing record for it.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: To use a <b>live app</b> as a signature source, you must now provide its ICP filing information. This requires you to upload a screenshot of the app\&quot;s ICP filing.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSmsAppIcpRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSmsAppIcpRecordResponse
        /// </returns>
        public async Task<CreateSmsAppIcpRecordResponse> CreateSmsAppIcpRecordWithOptionsAsync(CreateSmsAppIcpRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppApprovalDate))
            {
                query["AppApprovalDate"] = request.AppApprovalDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIcpLicenseNumber))
            {
                query["AppIcpLicenseNumber"] = request.AppIcpLicenseNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIcpRecordPic))
            {
                query["AppIcpRecordPic"] = request.AppIcpRecordPic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppPrincipalUnitName))
            {
                query["AppPrincipalUnitName"] = request.AppPrincipalUnitName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppRuntimePic))
            {
                query["AppRuntimePic"] = request.AppRuntimePic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppServiceName))
            {
                query["AppServiceName"] = request.AppServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppStoreDownloadPic))
            {
                query["AppStoreDownloadPic"] = request.AppStoreDownloadPic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
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
                Action = "CreateSmsAppIcpRecord",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSmsAppIcpRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The process for using a live app as a signature source has changed. If you use an app as the signature source, you must call this operation to create an ICP filing record for it.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: To use a <b>live app</b> as a signature source, you must now provide its ICP filing information. This requires you to upload a screenshot of the app\&quot;s ICP filing.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSmsAppIcpRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSmsAppIcpRecordResponse
        /// </returns>
        public CreateSmsAppIcpRecordResponse CreateSmsAppIcpRecord(CreateSmsAppIcpRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSmsAppIcpRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The process for using a live app as a signature source has changed. If you use an app as the signature source, you must call this operation to create an ICP filing record for it.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: To use a <b>live app</b> as a signature source, you must now provide its ICP filing information. This requires you to upload a screenshot of the app\&quot;s ICP filing.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSmsAppIcpRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSmsAppIcpRecordResponse
        /// </returns>
        public async Task<CreateSmsAppIcpRecordResponse> CreateSmsAppIcpRecordAsync(CreateSmsAppIcpRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSmsAppIcpRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If the qualification is intended for use by a third party or the requested signature involves third-party rights, you must obtain third-party authorization and create an authorization letter before submitting the application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before use, please read the <a href="https://help.aliyun.com/document_detail/56741.html">Authorization Letter Specifications</a>. Download the <a href="https://help-static-aliyun-doc.aliyuncs.com/file-manage-files/zh-CN/20250414/bvpcmo/%E6%8E%88%E6%9D%83%E5%A7%94%E6%89%98%E4%B9%A6%E6%A8%A1%E7%89%88.doc">Authorization Letter Template</a>, fill it out and stamp it according to the specifications, and then upload it.</description></item>
        /// <item><description>The authorization letter you create can be used when applying for SMS qualifications or SMS signatures. If your qualification or signature is intended for use by a third party, you must create and submit an authorization letter.</description></item>
        /// <item><description>After creating an authorization letter, you can call <a href="~~QuerySmsAuthorizationLetter~~">QuerySmsAuthorizationLetter</a> to query the details of the created authorization letter. Authorization letter information created through the API is synchronized to the Short Message Service console.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateSmsAuthorizationLetterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSmsAuthorizationLetterResponse
        /// </returns>
        public CreateSmsAuthorizationLetterResponse CreateSmsAuthorizationLetterWithOptions(CreateSmsAuthorizationLetterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSmsAuthorizationLetterShrinkRequest request = new CreateSmsAuthorizationLetterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SignList))
            {
                request.SignListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SignList, "SignList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Authorization))
            {
                query["Authorization"] = request.Authorization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationLetterExpDate))
            {
                query["AuthorizationLetterExpDate"] = request.AuthorizationLetterExpDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationLetterName))
            {
                query["AuthorizationLetterName"] = request.AuthorizationLetterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationLetterPic))
            {
                query["AuthorizationLetterPic"] = request.AuthorizationLetterPic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationCode))
            {
                query["OrganizationCode"] = request.OrganizationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyAuthorization))
            {
                query["ProxyAuthorization"] = request.ProxyAuthorization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignListShrink))
            {
                query["SignList"] = request.SignListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSmsAuthorizationLetter",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSmsAuthorizationLetterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If the qualification is intended for use by a third party or the requested signature involves third-party rights, you must obtain third-party authorization and create an authorization letter before submitting the application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before use, please read the <a href="https://help.aliyun.com/document_detail/56741.html">Authorization Letter Specifications</a>. Download the <a href="https://help-static-aliyun-doc.aliyuncs.com/file-manage-files/zh-CN/20250414/bvpcmo/%E6%8E%88%E6%9D%83%E5%A7%94%E6%89%98%E4%B9%A6%E6%A8%A1%E7%89%88.doc">Authorization Letter Template</a>, fill it out and stamp it according to the specifications, and then upload it.</description></item>
        /// <item><description>The authorization letter you create can be used when applying for SMS qualifications or SMS signatures. If your qualification or signature is intended for use by a third party, you must create and submit an authorization letter.</description></item>
        /// <item><description>After creating an authorization letter, you can call <a href="~~QuerySmsAuthorizationLetter~~">QuerySmsAuthorizationLetter</a> to query the details of the created authorization letter. Authorization letter information created through the API is synchronized to the Short Message Service console.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateSmsAuthorizationLetterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSmsAuthorizationLetterResponse
        /// </returns>
        public async Task<CreateSmsAuthorizationLetterResponse> CreateSmsAuthorizationLetterWithOptionsAsync(CreateSmsAuthorizationLetterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSmsAuthorizationLetterShrinkRequest request = new CreateSmsAuthorizationLetterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SignList))
            {
                request.SignListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SignList, "SignList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Authorization))
            {
                query["Authorization"] = request.Authorization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationLetterExpDate))
            {
                query["AuthorizationLetterExpDate"] = request.AuthorizationLetterExpDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationLetterName))
            {
                query["AuthorizationLetterName"] = request.AuthorizationLetterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationLetterPic))
            {
                query["AuthorizationLetterPic"] = request.AuthorizationLetterPic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationCode))
            {
                query["OrganizationCode"] = request.OrganizationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyAuthorization))
            {
                query["ProxyAuthorization"] = request.ProxyAuthorization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignListShrink))
            {
                query["SignList"] = request.SignListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSmsAuthorizationLetter",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSmsAuthorizationLetterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If the qualification is intended for use by a third party or the requested signature involves third-party rights, you must obtain third-party authorization and create an authorization letter before submitting the application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before use, please read the <a href="https://help.aliyun.com/document_detail/56741.html">Authorization Letter Specifications</a>. Download the <a href="https://help-static-aliyun-doc.aliyuncs.com/file-manage-files/zh-CN/20250414/bvpcmo/%E6%8E%88%E6%9D%83%E5%A7%94%E6%89%98%E4%B9%A6%E6%A8%A1%E7%89%88.doc">Authorization Letter Template</a>, fill it out and stamp it according to the specifications, and then upload it.</description></item>
        /// <item><description>The authorization letter you create can be used when applying for SMS qualifications or SMS signatures. If your qualification or signature is intended for use by a third party, you must create and submit an authorization letter.</description></item>
        /// <item><description>After creating an authorization letter, you can call <a href="~~QuerySmsAuthorizationLetter~~">QuerySmsAuthorizationLetter</a> to query the details of the created authorization letter. Authorization letter information created through the API is synchronized to the Short Message Service console.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSmsAuthorizationLetterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSmsAuthorizationLetterResponse
        /// </returns>
        public CreateSmsAuthorizationLetterResponse CreateSmsAuthorizationLetter(CreateSmsAuthorizationLetterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSmsAuthorizationLetterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If the qualification is intended for use by a third party or the requested signature involves third-party rights, you must obtain third-party authorization and create an authorization letter before submitting the application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before use, please read the <a href="https://help.aliyun.com/document_detail/56741.html">Authorization Letter Specifications</a>. Download the <a href="https://help-static-aliyun-doc.aliyuncs.com/file-manage-files/zh-CN/20250414/bvpcmo/%E6%8E%88%E6%9D%83%E5%A7%94%E6%89%98%E4%B9%A6%E6%A8%A1%E7%89%88.doc">Authorization Letter Template</a>, fill it out and stamp it according to the specifications, and then upload it.</description></item>
        /// <item><description>The authorization letter you create can be used when applying for SMS qualifications or SMS signatures. If your qualification or signature is intended for use by a third party, you must create and submit an authorization letter.</description></item>
        /// <item><description>After creating an authorization letter, you can call <a href="~~QuerySmsAuthorizationLetter~~">QuerySmsAuthorizationLetter</a> to query the details of the created authorization letter. Authorization letter information created through the API is synchronized to the Short Message Service console.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSmsAuthorizationLetterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSmsAuthorizationLetterResponse
        /// </returns>
        public async Task<CreateSmsAuthorizationLetterResponse> CreateSmsAuthorizationLetterAsync(CreateSmsAuthorizationLetterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSmsAuthorizationLetterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An SMS signature identifies the sender of an SMS message. Before sending SMS messages, you must apply for a signature and a template. The system prepends the approved SMS signature to the message content and sends them together to the recipient.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For details about the changes between the new and original operations, see <a href="https://help.aliyun.com/document_detail/2806975.html">Announcement on updating signature and template operations for Short Message Service</a>.</description></item>
        /// <item><description>Users who verify your identity - Individual account can apply for one formal signature per calendar day per Alibaba Cloud account. Users who verify your identity - Enterprise account currently have no such limit. For details about the differences between individual and enterprise user privileges, see <a href="https://help.aliyun.com/document_detail/55324.html">Before you begin</a>.</description></item>
        /// <item><description>Read the <a href="https://help.aliyun.com/document_detail/108076.html">Signature specifications</a> to learn about the SMS signature review standards.</description></item>
        /// <item><description>Signatures applied for through the API are synchronized to the Short Message Service console. For console-related operations, see <a href="https://help.aliyun.com/document_detail/108073.html">SMS signatures</a>.</description></item>
        /// <item><description>After you submit a signature application, you can call the <a href="https://help.aliyun.com/document_detail/2807429.html">GetSmsSign</a> operation to query the signature review status and details. You can also <a href="https://help.aliyun.com/document_detail/101508.html">configure receipt messages</a> and use <a href="https://help.aliyun.com/document_detail/120998.html">SignSmsReport</a> to obtain the signature review status messages.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateSmsSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSmsSignResponse
        /// </returns>
        public CreateSmsSignResponse CreateSmsSignWithOptions(CreateSmsSignRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSmsSignShrinkRequest request = new CreateSmsSignShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MoreData))
            {
                request.MoreDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MoreData, "MoreData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIcpRecordId))
            {
                query["AppIcpRecordId"] = request.AppIcpRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplySceneContent))
            {
                query["ApplySceneContent"] = request.ApplySceneContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationLetterId))
            {
                query["AuthorizationLetterId"] = request.AuthorizationLetterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MoreDataShrink))
            {
                query["MoreData"] = request.MoreDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationId))
            {
                query["QualificationId"] = request.QualificationId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignSource))
            {
                query["SignSource"] = request.SignSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignType))
            {
                query["SignType"] = request.SignType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdParty))
            {
                query["ThirdParty"] = request.ThirdParty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkId))
            {
                query["TrademarkId"] = request.TrademarkId;
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
            return TeaModel.ToObject<CreateSmsSignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An SMS signature identifies the sender of an SMS message. Before sending SMS messages, you must apply for a signature and a template. The system prepends the approved SMS signature to the message content and sends them together to the recipient.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For details about the changes between the new and original operations, see <a href="https://help.aliyun.com/document_detail/2806975.html">Announcement on updating signature and template operations for Short Message Service</a>.</description></item>
        /// <item><description>Users who verify your identity - Individual account can apply for one formal signature per calendar day per Alibaba Cloud account. Users who verify your identity - Enterprise account currently have no such limit. For details about the differences between individual and enterprise user privileges, see <a href="https://help.aliyun.com/document_detail/55324.html">Before you begin</a>.</description></item>
        /// <item><description>Read the <a href="https://help.aliyun.com/document_detail/108076.html">Signature specifications</a> to learn about the SMS signature review standards.</description></item>
        /// <item><description>Signatures applied for through the API are synchronized to the Short Message Service console. For console-related operations, see <a href="https://help.aliyun.com/document_detail/108073.html">SMS signatures</a>.</description></item>
        /// <item><description>After you submit a signature application, you can call the <a href="https://help.aliyun.com/document_detail/2807429.html">GetSmsSign</a> operation to query the signature review status and details. You can also <a href="https://help.aliyun.com/document_detail/101508.html">configure receipt messages</a> and use <a href="https://help.aliyun.com/document_detail/120998.html">SignSmsReport</a> to obtain the signature review status messages.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateSmsSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSmsSignResponse
        /// </returns>
        public async Task<CreateSmsSignResponse> CreateSmsSignWithOptionsAsync(CreateSmsSignRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSmsSignShrinkRequest request = new CreateSmsSignShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MoreData))
            {
                request.MoreDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MoreData, "MoreData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIcpRecordId))
            {
                query["AppIcpRecordId"] = request.AppIcpRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplySceneContent))
            {
                query["ApplySceneContent"] = request.ApplySceneContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationLetterId))
            {
                query["AuthorizationLetterId"] = request.AuthorizationLetterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MoreDataShrink))
            {
                query["MoreData"] = request.MoreDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationId))
            {
                query["QualificationId"] = request.QualificationId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignSource))
            {
                query["SignSource"] = request.SignSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignType))
            {
                query["SignType"] = request.SignType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdParty))
            {
                query["ThirdParty"] = request.ThirdParty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkId))
            {
                query["TrademarkId"] = request.TrademarkId;
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
            return TeaModel.ToObject<CreateSmsSignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An SMS signature identifies the sender of an SMS message. Before sending SMS messages, you must apply for a signature and a template. The system prepends the approved SMS signature to the message content and sends them together to the recipient.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For details about the changes between the new and original operations, see <a href="https://help.aliyun.com/document_detail/2806975.html">Announcement on updating signature and template operations for Short Message Service</a>.</description></item>
        /// <item><description>Users who verify your identity - Individual account can apply for one formal signature per calendar day per Alibaba Cloud account. Users who verify your identity - Enterprise account currently have no such limit. For details about the differences between individual and enterprise user privileges, see <a href="https://help.aliyun.com/document_detail/55324.html">Before you begin</a>.</description></item>
        /// <item><description>Read the <a href="https://help.aliyun.com/document_detail/108076.html">Signature specifications</a> to learn about the SMS signature review standards.</description></item>
        /// <item><description>Signatures applied for through the API are synchronized to the Short Message Service console. For console-related operations, see <a href="https://help.aliyun.com/document_detail/108073.html">SMS signatures</a>.</description></item>
        /// <item><description>After you submit a signature application, you can call the <a href="https://help.aliyun.com/document_detail/2807429.html">GetSmsSign</a> operation to query the signature review status and details. You can also <a href="https://help.aliyun.com/document_detail/101508.html">configure receipt messages</a> and use <a href="https://help.aliyun.com/document_detail/120998.html">SignSmsReport</a> to obtain the signature review status messages.</description></item>
        /// </list>
        /// </description>
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
        /// <para>An SMS signature identifies the sender of an SMS message. Before sending SMS messages, you must apply for a signature and a template. The system prepends the approved SMS signature to the message content and sends them together to the recipient.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For details about the changes between the new and original operations, see <a href="https://help.aliyun.com/document_detail/2806975.html">Announcement on updating signature and template operations for Short Message Service</a>.</description></item>
        /// <item><description>Users who verify your identity - Individual account can apply for one formal signature per calendar day per Alibaba Cloud account. Users who verify your identity - Enterprise account currently have no such limit. For details about the differences between individual and enterprise user privileges, see <a href="https://help.aliyun.com/document_detail/55324.html">Before you begin</a>.</description></item>
        /// <item><description>Read the <a href="https://help.aliyun.com/document_detail/108076.html">Signature specifications</a> to learn about the SMS signature review standards.</description></item>
        /// <item><description>Signatures applied for through the API are synchronized to the Short Message Service console. For console-related operations, see <a href="https://help.aliyun.com/document_detail/108073.html">SMS signatures</a>.</description></item>
        /// <item><description>After you submit a signature application, you can call the <a href="https://help.aliyun.com/document_detail/2807429.html">GetSmsSign</a> operation to query the signature review status and details. You can also <a href="https://help.aliyun.com/document_detail/101508.html">configure receipt messages</a> and use <a href="https://help.aliyun.com/document_detail/120998.html">SignSmsReport</a> to obtain the signature review status messages.</description></item>
        /// </list>
        /// </description>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>A message template defines the content of an SMS message. This content includes the message text and any variables. You can create templates for various business needs, such as sending verification codes, notifications, or promotional messages. A template must be approved before you can use it to send messages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For details on the API changes for signatures and templates, see the <a href="https://help.aliyun.com/document_detail/2806975.html">Announcement on Signature and Template API Updates for Short Message Service</a>.</description></item>
        /// <item><description>Wait at least 30 seconds between API calls when applying for a message template.</description></item>
        /// <item><description>Message templates you apply for via the API are synchronized to the Short Message Service console. For details on how to manage message templates in the console, see <a href="https://help.aliyun.com/document_detail/108085.html">Message templates</a>.</description></item>
        /// <item><description>After you submit a template for review, you can call the <a href="https://help.aliyun.com/document_detail/2807433.html">GetSmsTemplate</a> API to query the template\&quot;s review status and details. You can also <a href="https://help.aliyun.com/document_detail/101508.html">configure status reports</a> to receive the template\&quot;s review status through <a href="https://help.aliyun.com/document_detail/120999.html">TemplateSmsReport</a>.</description></item>
        /// <item><description>Message templates for Chinese mainland messages and international messages are not interchangeable. Apply for message templates based on your use case.</description></item>
        /// <item><description>Only enterprise-verified users can apply for message templates for promotional messages and international messages. For details on the permission differences between individual and enterprise users, see <a href="https://help.aliyun.com/document_detail/55324.html">Usage notes</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateSmsTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSmsTemplateResponse
        /// </returns>
        public CreateSmsTemplateResponse CreateSmsTemplateWithOptions(CreateSmsTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSmsTemplateShrinkRequest request = new CreateSmsTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MoreData))
            {
                request.MoreDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MoreData, "MoreData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplySceneContent))
            {
                query["ApplySceneContent"] = request.ApplySceneContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntlType))
            {
                query["IntlType"] = request.IntlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MoreDataShrink))
            {
                query["MoreData"] = request.MoreDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedSignName))
            {
                query["RelatedSignName"] = request.RelatedSignName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateContent))
            {
                query["TemplateContent"] = request.TemplateContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateRule))
            {
                query["TemplateRule"] = request.TemplateRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficDriving))
            {
                query["TrafficDriving"] = request.TrafficDriving;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSmsTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSmsTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>A message template defines the content of an SMS message. This content includes the message text and any variables. You can create templates for various business needs, such as sending verification codes, notifications, or promotional messages. A template must be approved before you can use it to send messages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For details on the API changes for signatures and templates, see the <a href="https://help.aliyun.com/document_detail/2806975.html">Announcement on Signature and Template API Updates for Short Message Service</a>.</description></item>
        /// <item><description>Wait at least 30 seconds between API calls when applying for a message template.</description></item>
        /// <item><description>Message templates you apply for via the API are synchronized to the Short Message Service console. For details on how to manage message templates in the console, see <a href="https://help.aliyun.com/document_detail/108085.html">Message templates</a>.</description></item>
        /// <item><description>After you submit a template for review, you can call the <a href="https://help.aliyun.com/document_detail/2807433.html">GetSmsTemplate</a> API to query the template\&quot;s review status and details. You can also <a href="https://help.aliyun.com/document_detail/101508.html">configure status reports</a> to receive the template\&quot;s review status through <a href="https://help.aliyun.com/document_detail/120999.html">TemplateSmsReport</a>.</description></item>
        /// <item><description>Message templates for Chinese mainland messages and international messages are not interchangeable. Apply for message templates based on your use case.</description></item>
        /// <item><description>Only enterprise-verified users can apply for message templates for promotional messages and international messages. For details on the permission differences between individual and enterprise users, see <a href="https://help.aliyun.com/document_detail/55324.html">Usage notes</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateSmsTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSmsTemplateResponse
        /// </returns>
        public async Task<CreateSmsTemplateResponse> CreateSmsTemplateWithOptionsAsync(CreateSmsTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSmsTemplateShrinkRequest request = new CreateSmsTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MoreData))
            {
                request.MoreDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MoreData, "MoreData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplySceneContent))
            {
                query["ApplySceneContent"] = request.ApplySceneContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntlType))
            {
                query["IntlType"] = request.IntlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MoreDataShrink))
            {
                query["MoreData"] = request.MoreDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedSignName))
            {
                query["RelatedSignName"] = request.RelatedSignName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateContent))
            {
                query["TemplateContent"] = request.TemplateContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateRule))
            {
                query["TemplateRule"] = request.TemplateRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficDriving))
            {
                query["TrafficDriving"] = request.TrafficDriving;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSmsTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSmsTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>A message template defines the content of an SMS message. This content includes the message text and any variables. You can create templates for various business needs, such as sending verification codes, notifications, or promotional messages. A template must be approved before you can use it to send messages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For details on the API changes for signatures and templates, see the <a href="https://help.aliyun.com/document_detail/2806975.html">Announcement on Signature and Template API Updates for Short Message Service</a>.</description></item>
        /// <item><description>Wait at least 30 seconds between API calls when applying for a message template.</description></item>
        /// <item><description>Message templates you apply for via the API are synchronized to the Short Message Service console. For details on how to manage message templates in the console, see <a href="https://help.aliyun.com/document_detail/108085.html">Message templates</a>.</description></item>
        /// <item><description>After you submit a template for review, you can call the <a href="https://help.aliyun.com/document_detail/2807433.html">GetSmsTemplate</a> API to query the template\&quot;s review status and details. You can also <a href="https://help.aliyun.com/document_detail/101508.html">configure status reports</a> to receive the template\&quot;s review status through <a href="https://help.aliyun.com/document_detail/120999.html">TemplateSmsReport</a>.</description></item>
        /// <item><description>Message templates for Chinese mainland messages and international messages are not interchangeable. Apply for message templates based on your use case.</description></item>
        /// <item><description>Only enterprise-verified users can apply for message templates for promotional messages and international messages. For details on the permission differences between individual and enterprise users, see <a href="https://help.aliyun.com/document_detail/55324.html">Usage notes</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSmsTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSmsTemplateResponse
        /// </returns>
        public CreateSmsTemplateResponse CreateSmsTemplate(CreateSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSmsTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>A message template defines the content of an SMS message. This content includes the message text and any variables. You can create templates for various business needs, such as sending verification codes, notifications, or promotional messages. A template must be approved before you can use it to send messages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For details on the API changes for signatures and templates, see the <a href="https://help.aliyun.com/document_detail/2806975.html">Announcement on Signature and Template API Updates for Short Message Service</a>.</description></item>
        /// <item><description>Wait at least 30 seconds between API calls when applying for a message template.</description></item>
        /// <item><description>Message templates you apply for via the API are synchronized to the Short Message Service console. For details on how to manage message templates in the console, see <a href="https://help.aliyun.com/document_detail/108085.html">Message templates</a>.</description></item>
        /// <item><description>After you submit a template for review, you can call the <a href="https://help.aliyun.com/document_detail/2807433.html">GetSmsTemplate</a> API to query the template\&quot;s review status and details. You can also <a href="https://help.aliyun.com/document_detail/101508.html">configure status reports</a> to receive the template\&quot;s review status through <a href="https://help.aliyun.com/document_detail/120999.html">TemplateSmsReport</a>.</description></item>
        /// <item><description>Message templates for Chinese mainland messages and international messages are not interchangeable. Apply for message templates based on your use case.</description></item>
        /// <item><description>Only enterprise-verified users can apply for message templates for promotional messages and international messages. For details on the permission differences between individual and enterprise users, see <a href="https://help.aliyun.com/document_detail/55324.html">Usage notes</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSmsTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSmsTemplateResponse
        /// </returns>
        public async Task<CreateSmsTemplateResponse> CreateSmsTemplateAsync(CreateSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSmsTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a trademark entity. This operation is used when you need to upload trademark information when the signature source is set to trademark.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The trademark must be searchable on the China Trademark Network of the Trademark Office of the China National Intellectual Property Administration, and the trademark owner must match the enterprise name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSmsTrademarkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSmsTrademarkResponse
        /// </returns>
        public CreateSmsTrademarkResponse CreateSmsTrademarkWithOptions(CreateSmsTrademarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkApplicantName))
            {
                query["TrademarkApplicantName"] = request.TrademarkApplicantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkEffExpDate))
            {
                query["TrademarkEffExpDate"] = request.TrademarkEffExpDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkPic))
            {
                query["TrademarkPic"] = request.TrademarkPic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkRegistrationNumber))
            {
                query["TrademarkRegistrationNumber"] = request.TrademarkRegistrationNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSmsTrademark",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSmsTrademarkResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a trademark entity. This operation is used when you need to upload trademark information when the signature source is set to trademark.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The trademark must be searchable on the China Trademark Network of the Trademark Office of the China National Intellectual Property Administration, and the trademark owner must match the enterprise name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSmsTrademarkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSmsTrademarkResponse
        /// </returns>
        public async Task<CreateSmsTrademarkResponse> CreateSmsTrademarkWithOptionsAsync(CreateSmsTrademarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkApplicantName))
            {
                query["TrademarkApplicantName"] = request.TrademarkApplicantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkEffExpDate))
            {
                query["TrademarkEffExpDate"] = request.TrademarkEffExpDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkPic))
            {
                query["TrademarkPic"] = request.TrademarkPic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkRegistrationNumber))
            {
                query["TrademarkRegistrationNumber"] = request.TrademarkRegistrationNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSmsTrademark",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSmsTrademarkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a trademark entity. This operation is used when you need to upload trademark information when the signature source is set to trademark.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The trademark must be searchable on the China Trademark Network of the Trademark Office of the China National Intellectual Property Administration, and the trademark owner must match the enterprise name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSmsTrademarkRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSmsTrademarkResponse
        /// </returns>
        public CreateSmsTrademarkResponse CreateSmsTrademark(CreateSmsTrademarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSmsTrademarkWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a trademark entity. This operation is used when you need to upload trademark information when the signature source is set to trademark.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The trademark must be searchable on the China Trademark Network of the Trademark Office of the China National Intellectual Property Administration, and the trademark owner must match the enterprise name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSmsTrademarkRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSmsTrademarkResponse
        /// </returns>
        public async Task<CreateSmsTrademarkResponse> CreateSmsTrademarkAsync(CreateSmsTrademarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSmsTrademarkWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除验证码签名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExtCodeSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExtCodeSignResponse
        /// </returns>
        public DeleteExtCodeSignResponse DeleteExtCodeSignWithOptions(DeleteExtCodeSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtCode))
            {
                query["ExtCode"] = request.ExtCode;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExtCodeSign",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExtCodeSignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除验证码签名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExtCodeSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExtCodeSignResponse
        /// </returns>
        public async Task<DeleteExtCodeSignResponse> DeleteExtCodeSignWithOptionsAsync(DeleteExtCodeSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtCode))
            {
                query["ExtCode"] = request.ExtCode;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExtCodeSign",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExtCodeSignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除验证码签名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExtCodeSignRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteExtCodeSignResponse
        /// </returns>
        public DeleteExtCodeSignResponse DeleteExtCodeSign(DeleteExtCodeSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteExtCodeSignWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除验证码签名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExtCodeSignRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteExtCodeSignResponse
        /// </returns>
        public async Task<DeleteExtCodeSignResponse> DeleteExtCodeSignAsync(DeleteExtCodeSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteExtCodeSignWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a short URL. After deletion, the short URL is no longer usable and cannot be resolved to the source URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: 
        /// Short Message Service does not currently support this API operation.</para>
        /// </remarks>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for a single user is 100. Calls that exceed this limit are subject to rate limiting, which may affect your business. To prevent disruptions, call this operation at a reasonable frequency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteShortUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteShortUrlResponse
        /// </returns>
        public DeleteShortUrlResponse DeleteShortUrlWithOptions(DeleteShortUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUrl))
            {
                body["SourceUrl"] = request.SourceUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteShortUrl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteShortUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a short URL. After deletion, the short URL is no longer usable and cannot be resolved to the source URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: 
        /// Short Message Service does not currently support this API operation.</para>
        /// </remarks>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for a single user is 100. Calls that exceed this limit are subject to rate limiting, which may affect your business. To prevent disruptions, call this operation at a reasonable frequency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteShortUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteShortUrlResponse
        /// </returns>
        public async Task<DeleteShortUrlResponse> DeleteShortUrlWithOptionsAsync(DeleteShortUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUrl))
            {
                body["SourceUrl"] = request.SourceUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteShortUrl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteShortUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a short URL. After deletion, the short URL is no longer usable and cannot be resolved to the source URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: 
        /// Short Message Service does not currently support this API operation.</para>
        /// </remarks>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for a single user is 100. Calls that exceed this limit are subject to rate limiting, which may affect your business. To prevent disruptions, call this operation at a reasonable frequency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteShortUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteShortUrlResponse
        /// </returns>
        public DeleteShortUrlResponse DeleteShortUrl(DeleteShortUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteShortUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a short URL. After deletion, the short URL is no longer usable and cannot be resolved to the source URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: 
        /// Short Message Service does not currently support this API operation.</para>
        /// </remarks>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for a single user is 100. Calls that exceed this limit are subject to rate limiting, which may affect your business. To prevent disruptions, call this operation at a reasonable frequency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteShortUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteShortUrlResponse
        /// </returns>
        public async Task<DeleteShortUrlResponse> DeleteShortUrlAsync(DeleteShortUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteShortUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you no longer use an SMS qualification or need to delete it for other reasons, call this API or delete the SMS qualification in the Short Message Service console.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Warning: Once a qualification is deleted, it cannot be restored or selected when you apply for signatures later. Proceed with caution.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Qualifications under review cannot be modified or deleted. You can withdraw the application in the Short Message Service <a href="https://dysms.console.aliyun.com/domestic/text/qualification">console</a> before performing the operation.</description></item>
        /// <item><description>Approved qualifications that have been bound to signatures cannot be deleted.</description></item>
        /// <item><description>Rejected qualifications can be directly resubmitted for review after you <a href="~~UpdateSmsQualification~~">modify the qualification information</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSmsQualificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSmsQualificationResponse
        /// </returns>
        public DeleteSmsQualificationResponse DeleteSmsQualificationWithOptions(DeleteSmsQualificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationGroupId))
            {
                query["QualificationGroupId"] = request.QualificationGroupId;
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
                Action = "DeleteSmsQualification",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSmsQualificationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you no longer use an SMS qualification or need to delete it for other reasons, call this API or delete the SMS qualification in the Short Message Service console.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Warning: Once a qualification is deleted, it cannot be restored or selected when you apply for signatures later. Proceed with caution.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Qualifications under review cannot be modified or deleted. You can withdraw the application in the Short Message Service <a href="https://dysms.console.aliyun.com/domestic/text/qualification">console</a> before performing the operation.</description></item>
        /// <item><description>Approved qualifications that have been bound to signatures cannot be deleted.</description></item>
        /// <item><description>Rejected qualifications can be directly resubmitted for review after you <a href="~~UpdateSmsQualification~~">modify the qualification information</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSmsQualificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSmsQualificationResponse
        /// </returns>
        public async Task<DeleteSmsQualificationResponse> DeleteSmsQualificationWithOptionsAsync(DeleteSmsQualificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationGroupId))
            {
                query["QualificationGroupId"] = request.QualificationGroupId;
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
                Action = "DeleteSmsQualification",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSmsQualificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you no longer use an SMS qualification or need to delete it for other reasons, call this API or delete the SMS qualification in the Short Message Service console.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Warning: Once a qualification is deleted, it cannot be restored or selected when you apply for signatures later. Proceed with caution.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Qualifications under review cannot be modified or deleted. You can withdraw the application in the Short Message Service <a href="https://dysms.console.aliyun.com/domestic/text/qualification">console</a> before performing the operation.</description></item>
        /// <item><description>Approved qualifications that have been bound to signatures cannot be deleted.</description></item>
        /// <item><description>Rejected qualifications can be directly resubmitted for review after you <a href="~~UpdateSmsQualification~~">modify the qualification information</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSmsQualificationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSmsQualificationResponse
        /// </returns>
        public DeleteSmsQualificationResponse DeleteSmsQualification(DeleteSmsQualificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSmsQualificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you no longer use an SMS qualification or need to delete it for other reasons, call this API or delete the SMS qualification in the Short Message Service console.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Warning: Once a qualification is deleted, it cannot be restored or selected when you apply for signatures later. Proceed with caution.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Qualifications under review cannot be modified or deleted. You can withdraw the application in the Short Message Service <a href="https://dysms.console.aliyun.com/domestic/text/qualification">console</a> before performing the operation.</description></item>
        /// <item><description>Approved qualifications that have been bound to signatures cannot be deleted.</description></item>
        /// <item><description>Rejected qualifications can be directly resubmitted for review after you <a href="~~UpdateSmsQualification~~">modify the qualification information</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSmsQualificationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSmsQualificationResponse
        /// </returns>
        public async Task<DeleteSmsQualificationResponse> DeleteSmsQualificationAsync(DeleteSmsQualificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSmsQualificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you no longer use an SMS signature and need to delete it, call this operation or delete the SMS signature in the SMS Service console.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can delete signatures that are in the Withdrawn, Failed, or Approved state. You cannot delete signatures that are in the Pending Approval state.</description></item>
        /// <item><description>Deleted SMS signatures cannot be recovered, and the signature can no longer be used to send SMS messages. Proceed with caution.</description></item>
        /// <item><description>Signature deletion operations performed via the API are synchronized to the SMS Service console. For information about how to manage templates in the console, see <a href="https://help.aliyun.com/document_detail/108073.html">SMS signatures</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSmsSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSmsSignResponse
        /// </returns>
        public DeleteSmsSignResponse DeleteSmsSignWithOptions(DeleteSmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSmsSign",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSmsSignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you no longer use an SMS signature and need to delete it, call this operation or delete the SMS signature in the SMS Service console.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can delete signatures that are in the Withdrawn, Failed, or Approved state. You cannot delete signatures that are in the Pending Approval state.</description></item>
        /// <item><description>Deleted SMS signatures cannot be recovered, and the signature can no longer be used to send SMS messages. Proceed with caution.</description></item>
        /// <item><description>Signature deletion operations performed via the API are synchronized to the SMS Service console. For information about how to manage templates in the console, see <a href="https://help.aliyun.com/document_detail/108073.html">SMS signatures</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSmsSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSmsSignResponse
        /// </returns>
        public async Task<DeleteSmsSignResponse> DeleteSmsSignWithOptionsAsync(DeleteSmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSmsSign",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSmsSignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you no longer use an SMS signature and need to delete it, call this operation or delete the SMS signature in the SMS Service console.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can delete signatures that are in the Withdrawn, Failed, or Approved state. You cannot delete signatures that are in the Pending Approval state.</description></item>
        /// <item><description>Deleted SMS signatures cannot be recovered, and the signature can no longer be used to send SMS messages. Proceed with caution.</description></item>
        /// <item><description>Signature deletion operations performed via the API are synchronized to the SMS Service console. For information about how to manage templates in the console, see <a href="https://help.aliyun.com/document_detail/108073.html">SMS signatures</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSmsSignRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSmsSignResponse
        /// </returns>
        public DeleteSmsSignResponse DeleteSmsSign(DeleteSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSmsSignWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you no longer use an SMS signature and need to delete it, call this operation or delete the SMS signature in the SMS Service console.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can delete signatures that are in the Withdrawn, Failed, or Approved state. You cannot delete signatures that are in the Pending Approval state.</description></item>
        /// <item><description>Deleted SMS signatures cannot be recovered, and the signature can no longer be used to send SMS messages. Proceed with caution.</description></item>
        /// <item><description>Signature deletion operations performed via the API are synchronized to the SMS Service console. For information about how to manage templates in the console, see <a href="https://help.aliyun.com/document_detail/108073.html">SMS signatures</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSmsSignRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSmsSignResponse
        /// </returns>
        public async Task<DeleteSmsSignResponse> DeleteSmsSignAsync(DeleteSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSmsSignWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an SMS template that you no longer need.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>支持删除已撤回、审核失败或审核通过的模板，审核中的短信模板不支持删除。</description></item>
        /// <item><description>删除短信模板后不可恢复，且后续不可再使用该模板发送短信，请谨慎操作。</description></item>
        /// <item><description>通过接口删除模板的操作会在短信服务控制台同步，在控制台对模板的相关操作，请参见<a href="https://help.aliyun.com/document_detail/108085.html">短信模板</a>。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为1000次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSmsTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSmsTemplateResponse
        /// </returns>
        public DeleteSmsTemplateResponse DeleteSmsTemplateWithOptions(DeleteSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSmsTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSmsTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an SMS template that you no longer need.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>支持删除已撤回、审核失败或审核通过的模板，审核中的短信模板不支持删除。</description></item>
        /// <item><description>删除短信模板后不可恢复，且后续不可再使用该模板发送短信，请谨慎操作。</description></item>
        /// <item><description>通过接口删除模板的操作会在短信服务控制台同步，在控制台对模板的相关操作，请参见<a href="https://help.aliyun.com/document_detail/108085.html">短信模板</a>。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为1000次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSmsTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSmsTemplateResponse
        /// </returns>
        public async Task<DeleteSmsTemplateResponse> DeleteSmsTemplateWithOptionsAsync(DeleteSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSmsTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSmsTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an SMS template that you no longer need.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>支持删除已撤回、审核失败或审核通过的模板，审核中的短信模板不支持删除。</description></item>
        /// <item><description>删除短信模板后不可恢复，且后续不可再使用该模板发送短信，请谨慎操作。</description></item>
        /// <item><description>通过接口删除模板的操作会在短信服务控制台同步，在控制台对模板的相关操作，请参见<a href="https://help.aliyun.com/document_detail/108085.html">短信模板</a>。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为1000次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSmsTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSmsTemplateResponse
        /// </returns>
        public DeleteSmsTemplateResponse DeleteSmsTemplate(DeleteSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSmsTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an SMS template that you no longer need.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>支持删除已撤回、审核失败或审核通过的模板，审核中的短信模板不支持删除。</description></item>
        /// <item><description>删除短信模板后不可恢复，且后续不可再使用该模板发送短信，请谨慎操作。</description></item>
        /// <item><description>通过接口删除模板的操作会在短信服务控制台同步，在控制台对模板的相关操作，请参见<a href="https://help.aliyun.com/document_detail/108085.html">短信模板</a>。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为1000次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSmsTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSmsTemplateResponse
        /// </returns>
        public async Task<DeleteSmsTemplateResponse> DeleteSmsTemplateAsync(DeleteSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSmsTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the card SMS sending records and sending status of a single phone number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCardSmsDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCardSmsDetailsResponse
        /// </returns>
        public GetCardSmsDetailsResponse GetCardSmsDetailsWithOptions(GetCardSmsDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCardId))
            {
                query["BizCardId"] = request.BizCardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizDigitId))
            {
                query["BizDigitId"] = request.BizDigitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizSmsId))
            {
                query["BizSmsId"] = request.BizSmsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendDate))
            {
                query["SendDate"] = request.SendDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCardSmsDetails",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCardSmsDetailsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the card SMS sending records and sending status of a single phone number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCardSmsDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCardSmsDetailsResponse
        /// </returns>
        public async Task<GetCardSmsDetailsResponse> GetCardSmsDetailsWithOptionsAsync(GetCardSmsDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCardId))
            {
                query["BizCardId"] = request.BizCardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizDigitId))
            {
                query["BizDigitId"] = request.BizDigitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizSmsId))
            {
                query["BizSmsId"] = request.BizSmsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendDate))
            {
                query["SendDate"] = request.SendDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCardSmsDetails",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCardSmsDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the card SMS sending records and sending status of a single phone number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCardSmsDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCardSmsDetailsResponse
        /// </returns>
        public GetCardSmsDetailsResponse GetCardSmsDetails(GetCardSmsDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCardSmsDetailsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the card SMS sending records and sending status of a single phone number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCardSmsDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCardSmsDetailsResponse
        /// </returns>
        public async Task<GetCardSmsDetailsResponse> GetCardSmsDetailsAsync(GetCardSmsDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCardSmsDetailsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the short URL for a card message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>目前卡片短信在内部邀约阶段，请联系您的阿里云商务经理申请开通或联系<a href="https://help.aliyun.com/document_detail/464625.html?spm=a2c4g.11186623.0.0.213273d4Xe6UEu#section-81n-72q-ybm">阿里云售前咨询</a>。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <list type="bullet">
        /// <item><description>本接口的单用户QPS限制为1000次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCardSmsLinkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCardSmsLinkResponse
        /// </returns>
        public GetCardSmsLinkResponse GetCardSmsLinkWithOptions(GetCardSmsLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardCodeType))
            {
                query["CardCodeType"] = request.CardCodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardLinkType))
            {
                query["CardLinkType"] = request.CardLinkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateCode))
            {
                query["CardTemplateCode"] = request.CardTemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateParamJson))
            {
                query["CardTemplateParamJson"] = request.CardTemplateParamJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomShortCodeJson))
            {
                query["CustomShortCodeJson"] = request.CustomShortCodeJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumberJson))
            {
                query["PhoneNumberJson"] = request.PhoneNumberJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignNameJson))
            {
                query["SignNameJson"] = request.SignNameJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCardSmsLink",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCardSmsLinkResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the short URL for a card message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>目前卡片短信在内部邀约阶段，请联系您的阿里云商务经理申请开通或联系<a href="https://help.aliyun.com/document_detail/464625.html?spm=a2c4g.11186623.0.0.213273d4Xe6UEu#section-81n-72q-ybm">阿里云售前咨询</a>。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <list type="bullet">
        /// <item><description>本接口的单用户QPS限制为1000次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCardSmsLinkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCardSmsLinkResponse
        /// </returns>
        public async Task<GetCardSmsLinkResponse> GetCardSmsLinkWithOptionsAsync(GetCardSmsLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardCodeType))
            {
                query["CardCodeType"] = request.CardCodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardLinkType))
            {
                query["CardLinkType"] = request.CardLinkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateCode))
            {
                query["CardTemplateCode"] = request.CardTemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateParamJson))
            {
                query["CardTemplateParamJson"] = request.CardTemplateParamJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomShortCodeJson))
            {
                query["CustomShortCodeJson"] = request.CustomShortCodeJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumberJson))
            {
                query["PhoneNumberJson"] = request.PhoneNumberJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignNameJson))
            {
                query["SignNameJson"] = request.SignNameJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCardSmsLink",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCardSmsLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the short URL for a card message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>目前卡片短信在内部邀约阶段，请联系您的阿里云商务经理申请开通或联系<a href="https://help.aliyun.com/document_detail/464625.html?spm=a2c4g.11186623.0.0.213273d4Xe6UEu#section-81n-72q-ybm">阿里云售前咨询</a>。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <list type="bullet">
        /// <item><description>本接口的单用户QPS限制为1000次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCardSmsLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCardSmsLinkResponse
        /// </returns>
        public GetCardSmsLinkResponse GetCardSmsLink(GetCardSmsLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCardSmsLinkWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the short URL for a card message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>目前卡片短信在内部邀约阶段，请联系您的阿里云商务经理申请开通或联系<a href="https://help.aliyun.com/document_detail/464625.html?spm=a2c4g.11186623.0.0.213273d4Xe6UEu#section-81n-72q-ybm">阿里云售前咨询</a>。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <list type="bullet">
        /// <item><description>本接口的单用户QPS限制为1000次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCardSmsLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCardSmsLinkResponse
        /// </returns>
        public async Task<GetCardSmsLinkResponse> GetCardSmsLinkAsync(GetCardSmsLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCardSmsLinkWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts images and videos uploaded to OSS storage for card SMS into resource data for unified management, and returns a resource ID. You can manage the returned resource ID as needed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为300次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMediaResourceIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMediaResourceIdResponse
        /// </returns>
        public GetMediaResourceIdResponse GetMediaResourceIdWithOptions(GetMediaResourceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendInfo))
            {
                query["ExtendInfo"] = request.ExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                query["FileSize"] = request.FileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memo))
            {
                query["Memo"] = request.Memo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                query["OssKey"] = request.OssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMediaResourceId",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaResourceIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts images and videos uploaded to OSS storage for card SMS into resource data for unified management, and returns a resource ID. You can manage the returned resource ID as needed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为300次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMediaResourceIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMediaResourceIdResponse
        /// </returns>
        public async Task<GetMediaResourceIdResponse> GetMediaResourceIdWithOptionsAsync(GetMediaResourceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendInfo))
            {
                query["ExtendInfo"] = request.ExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                query["FileSize"] = request.FileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memo))
            {
                query["Memo"] = request.Memo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                query["OssKey"] = request.OssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMediaResourceId",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaResourceIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts images and videos uploaded to OSS storage for card SMS into resource data for unified management, and returns a resource ID. You can manage the returned resource ID as needed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为300次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMediaResourceIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMediaResourceIdResponse
        /// </returns>
        public GetMediaResourceIdResponse GetMediaResourceId(GetMediaResourceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaResourceIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts images and videos uploaded to OSS storage for card SMS into resource data for unified management, and returns a resource ID. You can manage the returned resource ID as needed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为300次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMediaResourceIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMediaResourceIdResponse
        /// </returns>
        public async Task<GetMediaResourceIdResponse> GetMediaResourceIdAsync(GetMediaResourceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaResourceIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the OSS resource configuration information for card messages. This information is used for subsequent OSS file upload operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>您在调用卡片短信相关API接口前，首先需要开通卡片短信功能，目前卡片短信在内部邀约阶段，请联系您的阿里云商务经理申请开通或联系<a href="https://help.aliyun.com/document_detail/464625.html">阿里云售前咨询</a>。</description></item>
        /// <item><description>卡片短信模板中使用的图片、视频等素材资源可上传到OSS文件系统保存。文件上传操作，请参见<a href="https://help.aliyun.com/document_detail/437303.html">OSS文件上传</a>。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为300次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// </description>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOSSInfoForCardTemplateResponse
        /// </returns>
        public GetOSSInfoForCardTemplateResponse GetOSSInfoForCardTemplateWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOSSInfoForCardTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOSSInfoForCardTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the OSS resource configuration information for card messages. This information is used for subsequent OSS file upload operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>您在调用卡片短信相关API接口前，首先需要开通卡片短信功能，目前卡片短信在内部邀约阶段，请联系您的阿里云商务经理申请开通或联系<a href="https://help.aliyun.com/document_detail/464625.html">阿里云售前咨询</a>。</description></item>
        /// <item><description>卡片短信模板中使用的图片、视频等素材资源可上传到OSS文件系统保存。文件上传操作，请参见<a href="https://help.aliyun.com/document_detail/437303.html">OSS文件上传</a>。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为300次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// </description>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOSSInfoForCardTemplateResponse
        /// </returns>
        public async Task<GetOSSInfoForCardTemplateResponse> GetOSSInfoForCardTemplateWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOSSInfoForCardTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOSSInfoForCardTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the OSS resource configuration information for card messages. This information is used for subsequent OSS file upload operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>您在调用卡片短信相关API接口前，首先需要开通卡片短信功能，目前卡片短信在内部邀约阶段，请联系您的阿里云商务经理申请开通或联系<a href="https://help.aliyun.com/document_detail/464625.html">阿里云售前咨询</a>。</description></item>
        /// <item><description>卡片短信模板中使用的图片、视频等素材资源可上传到OSS文件系统保存。文件上传操作，请参见<a href="https://help.aliyun.com/document_detail/437303.html">OSS文件上传</a>。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为300次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// </description>
        /// 
        /// <returns>
        /// GetOSSInfoForCardTemplateResponse
        /// </returns>
        public GetOSSInfoForCardTemplateResponse GetOSSInfoForCardTemplate()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOSSInfoForCardTemplateWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the OSS resource configuration information for card messages. This information is used for subsequent OSS file upload operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>您在调用卡片短信相关API接口前，首先需要开通卡片短信功能，目前卡片短信在内部邀约阶段，请联系您的阿里云商务经理申请开通或联系<a href="https://help.aliyun.com/document_detail/464625.html">阿里云售前咨询</a>。</description></item>
        /// <item><description>卡片短信模板中使用的图片、视频等素材资源可上传到OSS文件系统保存。文件上传操作，请参见<a href="https://help.aliyun.com/document_detail/437303.html">OSS文件上传</a>。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为300次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// </description>
        /// 
        /// <returns>
        /// GetOSSInfoForCardTemplateResponse
        /// </returns>
        public async Task<GetOSSInfoForCardTemplateResponse> GetOSSInfoForCardTemplateAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOSSInfoForCardTemplateWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains OSS resource configuration information, which will be used for subsequent OSS file upload operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>When you create a signature or template, you can upload materials such as login pages with links, backend page screenshots, software copyrights, and supplementary agreements. These materials help reviewers understand the details of your business. If you have multiple materials, you can combine them into one file. The supported formats are png, jpg, jpeg, doc, docx, and pdf.</description></item>
        /// <item><description>Additional materials required for creating a signature or template can be uploaded to the OSS file system for storage. For information about file upload operations, see <a href="https://help.aliyun.com/document_detail/2833114.html">Upload files to OSS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOSSInfoForUploadFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOSSInfoForUploadFileResponse
        /// </returns>
        public GetOSSInfoForUploadFileResponse GetOSSInfoForUploadFileWithOptions(GetOSSInfoForUploadFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetOSSInfoForUploadFile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOSSInfoForUploadFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains OSS resource configuration information, which will be used for subsequent OSS file upload operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>When you create a signature or template, you can upload materials such as login pages with links, backend page screenshots, software copyrights, and supplementary agreements. These materials help reviewers understand the details of your business. If you have multiple materials, you can combine them into one file. The supported formats are png, jpg, jpeg, doc, docx, and pdf.</description></item>
        /// <item><description>Additional materials required for creating a signature or template can be uploaded to the OSS file system for storage. For information about file upload operations, see <a href="https://help.aliyun.com/document_detail/2833114.html">Upload files to OSS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOSSInfoForUploadFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOSSInfoForUploadFileResponse
        /// </returns>
        public async Task<GetOSSInfoForUploadFileResponse> GetOSSInfoForUploadFileWithOptionsAsync(GetOSSInfoForUploadFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetOSSInfoForUploadFile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOSSInfoForUploadFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains OSS resource configuration information, which will be used for subsequent OSS file upload operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>When you create a signature or template, you can upload materials such as login pages with links, backend page screenshots, software copyrights, and supplementary agreements. These materials help reviewers understand the details of your business. If you have multiple materials, you can combine them into one file. The supported formats are png, jpg, jpeg, doc, docx, and pdf.</description></item>
        /// <item><description>Additional materials required for creating a signature or template can be uploaded to the OSS file system for storage. For information about file upload operations, see <a href="https://help.aliyun.com/document_detail/2833114.html">Upload files to OSS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOSSInfoForUploadFileRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOSSInfoForUploadFileResponse
        /// </returns>
        public GetOSSInfoForUploadFileResponse GetOSSInfoForUploadFile(GetOSSInfoForUploadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOSSInfoForUploadFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains OSS resource configuration information, which will be used for subsequent OSS file upload operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>When you create a signature or template, you can upload materials such as login pages with links, backend page screenshots, software copyrights, and supplementary agreements. These materials help reviewers understand the details of your business. If you have multiple materials, you can combine them into one file. The supported formats are png, jpg, jpeg, doc, docx, and pdf.</description></item>
        /// <item><description>Additional materials required for creating a signature or template can be uploaded to the OSS file system for storage. For information about file upload operations, see <a href="https://help.aliyun.com/document_detail/2833114.html">Upload files to OSS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOSSInfoForUploadFileRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOSSInfoForUploadFileResponse
        /// </returns>
        public async Task<GetOSSInfoForUploadFileResponse> GetOSSInfoForUploadFileAsync(GetOSSInfoForUploadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOSSInfoForUploadFileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the OSS resource configuration information for qualification materials. This configuration information will be used for subsequent uploads of qualification files such as authorization letters and enterprise certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>When you apply for a qualification or signature, if the purpose is for other use or involves a third party, you must provide an <a href="https://help.aliyun.com/document_detail/56741.html">authorization letter</a>.</description></item>
        /// <item><description>After you use this API to obtain the OSS resource configuration information, upload the related qualification materials through OSS. For more information, see <a href="https://help.aliyun.com/document_detail/2833114.html">Upload files through OSS</a>.</description></item>
        /// <item><description>The names of files to be uploaded cannot contain Chinese characters or special symbols.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQualificationOssInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualificationOssInfoResponse
        /// </returns>
        public GetQualificationOssInfoResponse GetQualificationOssInfoWithOptions(GetQualificationOssInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetQualificationOssInfo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualificationOssInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the OSS resource configuration information for qualification materials. This configuration information will be used for subsequent uploads of qualification files such as authorization letters and enterprise certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>When you apply for a qualification or signature, if the purpose is for other use or involves a third party, you must provide an <a href="https://help.aliyun.com/document_detail/56741.html">authorization letter</a>.</description></item>
        /// <item><description>After you use this API to obtain the OSS resource configuration information, upload the related qualification materials through OSS. For more information, see <a href="https://help.aliyun.com/document_detail/2833114.html">Upload files through OSS</a>.</description></item>
        /// <item><description>The names of files to be uploaded cannot contain Chinese characters or special symbols.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQualificationOssInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualificationOssInfoResponse
        /// </returns>
        public async Task<GetQualificationOssInfoResponse> GetQualificationOssInfoWithOptionsAsync(GetQualificationOssInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetQualificationOssInfo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualificationOssInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the OSS resource configuration information for qualification materials. This configuration information will be used for subsequent uploads of qualification files such as authorization letters and enterprise certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>When you apply for a qualification or signature, if the purpose is for other use or involves a third party, you must provide an <a href="https://help.aliyun.com/document_detail/56741.html">authorization letter</a>.</description></item>
        /// <item><description>After you use this API to obtain the OSS resource configuration information, upload the related qualification materials through OSS. For more information, see <a href="https://help.aliyun.com/document_detail/2833114.html">Upload files through OSS</a>.</description></item>
        /// <item><description>The names of files to be uploaded cannot contain Chinese characters or special symbols.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQualificationOssInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualificationOssInfoResponse
        /// </returns>
        public GetQualificationOssInfoResponse GetQualificationOssInfo(GetQualificationOssInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualificationOssInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the OSS resource configuration information for qualification materials. This configuration information will be used for subsequent uploads of qualification files such as authorization letters and enterprise certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>When you apply for a qualification or signature, if the purpose is for other use or involves a third party, you must provide an <a href="https://help.aliyun.com/document_detail/56741.html">authorization letter</a>.</description></item>
        /// <item><description>After you use this API to obtain the OSS resource configuration information, upload the related qualification materials through OSS. For more information, see <a href="https://help.aliyun.com/document_detail/2833114.html">Upload files through OSS</a>.</description></item>
        /// <item><description>The names of files to be uploaded cannot contain Chinese characters or special symbols.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQualificationOssInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualificationOssInfoResponse
        /// </returns>
        public async Task<GetQualificationOssInfoResponse> GetQualificationOssInfoAsync(GetQualificationOssInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualificationOssInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询5g短信详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRCSSignatureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRCSSignatureResponse
        /// </returns>
        public GetRCSSignatureResponse GetRCSSignatureWithOptions(GetRCSSignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRCSSignature",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRCSSignatureResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询5g短信详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRCSSignatureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRCSSignatureResponse
        /// </returns>
        public async Task<GetRCSSignatureResponse> GetRCSSignatureWithOptionsAsync(GetRCSSignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRCSSignature",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRCSSignatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询5g短信详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRCSSignatureRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRCSSignatureResponse
        /// </returns>
        public GetRCSSignatureResponse GetRCSSignature(GetRCSSignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRCSSignatureWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询5g短信详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRCSSignatureRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRCSSignatureResponse
        /// </returns>
        public async Task<GetRCSSignatureResponse> GetRCSSignatureAsync(GetRCSSignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRCSSignatureWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the OSS information for OCR.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSmsOcrOssInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSmsOcrOssInfoResponse
        /// </returns>
        public GetSmsOcrOssInfoResponse GetSmsOcrOssInfoWithOptions(GetSmsOcrOssInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSmsOcrOssInfo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSmsOcrOssInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the OSS information for OCR.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSmsOcrOssInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSmsOcrOssInfoResponse
        /// </returns>
        public async Task<GetSmsOcrOssInfoResponse> GetSmsOcrOssInfoWithOptionsAsync(GetSmsOcrOssInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSmsOcrOssInfo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSmsOcrOssInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the OSS information for OCR.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSmsOcrOssInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSmsOcrOssInfoResponse
        /// </returns>
        public GetSmsOcrOssInfoResponse GetSmsOcrOssInfo(GetSmsOcrOssInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSmsOcrOssInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the OSS information for OCR.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSmsOcrOssInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSmsOcrOssInfoResponse
        /// </returns>
        public async Task<GetSmsOcrOssInfoResponse> GetSmsOcrOssInfoAsync(GetSmsOcrOssInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSmsOcrOssInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the review details of a signature after you apply for it.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>仅可查询<b>首次创建</b>的签名资料或者<b>最新审核通过</b>的资料。</description></item>
        /// <item><description>新接口和原接口变更的公告详情请参见<a href="https://help.aliyun.com/document_detail/2806975.html">关于短信服务更新签名&amp;模板接口的公告</a>。</description></item>
        /// <item><description>审核时间：一般情况下，签名提交后，阿里云预计在 2 个小时内审核完成（审核工作时间：周一至周日 9:00~21:00，法定节假日顺延）。</description></item>
        /// <item><description>如果签名未通过审核，会返回审核失败的原因，请参考<a href="https://help.aliyun.com/document_detail/65990.html">短信审核失败的处理建议</a>，调用<a href="https://help.aliyun.com/document_detail/2807428.html">UpdateSmsSign</a>接口或在<a href="https://dysms.console.aliyun.com/domestic/text/sign">签名管理</a>页面修改未审核通过的短信签名。</description></item>
        /// <item><description><a href="~~QuerySmsSignList~~">QuerySmsSignList</a>接口可以查询您账号下的所有签名，包括签名审核状态、签名类型、签名名称等。</description></item>
        /// <item><description>本接口的单用户QPS限制为150次/秒。超过限制，API调用将会被限流，这可能会影响您的业务，请合理调用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSmsSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSmsSignResponse
        /// </returns>
        public GetSmsSignResponse GetSmsSignWithOptions(GetSmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSmsSign",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSmsSignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the review details of a signature after you apply for it.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>仅可查询<b>首次创建</b>的签名资料或者<b>最新审核通过</b>的资料。</description></item>
        /// <item><description>新接口和原接口变更的公告详情请参见<a href="https://help.aliyun.com/document_detail/2806975.html">关于短信服务更新签名&amp;模板接口的公告</a>。</description></item>
        /// <item><description>审核时间：一般情况下，签名提交后，阿里云预计在 2 个小时内审核完成（审核工作时间：周一至周日 9:00~21:00，法定节假日顺延）。</description></item>
        /// <item><description>如果签名未通过审核，会返回审核失败的原因，请参考<a href="https://help.aliyun.com/document_detail/65990.html">短信审核失败的处理建议</a>，调用<a href="https://help.aliyun.com/document_detail/2807428.html">UpdateSmsSign</a>接口或在<a href="https://dysms.console.aliyun.com/domestic/text/sign">签名管理</a>页面修改未审核通过的短信签名。</description></item>
        /// <item><description><a href="~~QuerySmsSignList~~">QuerySmsSignList</a>接口可以查询您账号下的所有签名，包括签名审核状态、签名类型、签名名称等。</description></item>
        /// <item><description>本接口的单用户QPS限制为150次/秒。超过限制，API调用将会被限流，这可能会影响您的业务，请合理调用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSmsSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSmsSignResponse
        /// </returns>
        public async Task<GetSmsSignResponse> GetSmsSignWithOptionsAsync(GetSmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSmsSign",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSmsSignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the review details of a signature after you apply for it.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>仅可查询<b>首次创建</b>的签名资料或者<b>最新审核通过</b>的资料。</description></item>
        /// <item><description>新接口和原接口变更的公告详情请参见<a href="https://help.aliyun.com/document_detail/2806975.html">关于短信服务更新签名&amp;模板接口的公告</a>。</description></item>
        /// <item><description>审核时间：一般情况下，签名提交后，阿里云预计在 2 个小时内审核完成（审核工作时间：周一至周日 9:00~21:00，法定节假日顺延）。</description></item>
        /// <item><description>如果签名未通过审核，会返回审核失败的原因，请参考<a href="https://help.aliyun.com/document_detail/65990.html">短信审核失败的处理建议</a>，调用<a href="https://help.aliyun.com/document_detail/2807428.html">UpdateSmsSign</a>接口或在<a href="https://dysms.console.aliyun.com/domestic/text/sign">签名管理</a>页面修改未审核通过的短信签名。</description></item>
        /// <item><description><a href="~~QuerySmsSignList~~">QuerySmsSignList</a>接口可以查询您账号下的所有签名，包括签名审核状态、签名类型、签名名称等。</description></item>
        /// <item><description>本接口的单用户QPS限制为150次/秒。超过限制，API调用将会被限流，这可能会影响您的业务，请合理调用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSmsSignRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSmsSignResponse
        /// </returns>
        public GetSmsSignResponse GetSmsSign(GetSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSmsSignWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the review details of a signature after you apply for it.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>仅可查询<b>首次创建</b>的签名资料或者<b>最新审核通过</b>的资料。</description></item>
        /// <item><description>新接口和原接口变更的公告详情请参见<a href="https://help.aliyun.com/document_detail/2806975.html">关于短信服务更新签名&amp;模板接口的公告</a>。</description></item>
        /// <item><description>审核时间：一般情况下，签名提交后，阿里云预计在 2 个小时内审核完成（审核工作时间：周一至周日 9:00~21:00，法定节假日顺延）。</description></item>
        /// <item><description>如果签名未通过审核，会返回审核失败的原因，请参考<a href="https://help.aliyun.com/document_detail/65990.html">短信审核失败的处理建议</a>，调用<a href="https://help.aliyun.com/document_detail/2807428.html">UpdateSmsSign</a>接口或在<a href="https://dysms.console.aliyun.com/domestic/text/sign">签名管理</a>页面修改未审核通过的短信签名。</description></item>
        /// <item><description><a href="~~QuerySmsSignList~~">QuerySmsSignList</a>接口可以查询您账号下的所有签名，包括签名审核状态、签名类型、签名名称等。</description></item>
        /// <item><description>本接口的单用户QPS限制为150次/秒。超过限制，API调用将会被限流，这可能会影响您的业务，请合理调用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSmsSignRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSmsSignResponse
        /// </returns>
        public async Task<GetSmsSignResponse> GetSmsSignAsync(GetSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSmsSignWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the approval details of a template after you submit a template application. You can view the approval status of the template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>新接口和原接口变更的公告详情请参见<a href="https://help.aliyun.com/document_detail/2806975.html">关于短信服务更新签名&amp;模板接口的公告</a>。</description></item>
        /// <item><description>审核时间：一般情况下，模板提交后，阿里云预计在2个小时内审核完成（审核工作时间：周一至周日9:00~21:00，法定节假日顺延）。</description></item>
        /// <item><description>如果模板未通过审核，会返回审核失败的原因，请参考<a href="https://help.aliyun.com/document_detail/65990.html">短信审核失败的处理建议</a>，调用<a href="~~UpdateSmsTemplate~~">UpdateSmsTemplate</a>接口或在<a href="https://dysms.console.aliyun.com/domestic/text/template">模板管理</a>页面修改短信模板。</description></item>
        /// <item><description>当前接口是通过模板Code查询单个模板的审核详情。<a href="https://help.aliyun.com/document_detail/419288.html">QuerySmsTemplateList</a>接口可以查询您当前账号下所有模板的模板详情。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSmsTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSmsTemplateResponse
        /// </returns>
        public GetSmsTemplateResponse GetSmsTemplateWithOptions(GetSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSmsTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSmsTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the approval details of a template after you submit a template application. You can view the approval status of the template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>新接口和原接口变更的公告详情请参见<a href="https://help.aliyun.com/document_detail/2806975.html">关于短信服务更新签名&amp;模板接口的公告</a>。</description></item>
        /// <item><description>审核时间：一般情况下，模板提交后，阿里云预计在2个小时内审核完成（审核工作时间：周一至周日9:00~21:00，法定节假日顺延）。</description></item>
        /// <item><description>如果模板未通过审核，会返回审核失败的原因，请参考<a href="https://help.aliyun.com/document_detail/65990.html">短信审核失败的处理建议</a>，调用<a href="~~UpdateSmsTemplate~~">UpdateSmsTemplate</a>接口或在<a href="https://dysms.console.aliyun.com/domestic/text/template">模板管理</a>页面修改短信模板。</description></item>
        /// <item><description>当前接口是通过模板Code查询单个模板的审核详情。<a href="https://help.aliyun.com/document_detail/419288.html">QuerySmsTemplateList</a>接口可以查询您当前账号下所有模板的模板详情。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSmsTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSmsTemplateResponse
        /// </returns>
        public async Task<GetSmsTemplateResponse> GetSmsTemplateWithOptionsAsync(GetSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSmsTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSmsTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the approval details of a template after you submit a template application. You can view the approval status of the template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>新接口和原接口变更的公告详情请参见<a href="https://help.aliyun.com/document_detail/2806975.html">关于短信服务更新签名&amp;模板接口的公告</a>。</description></item>
        /// <item><description>审核时间：一般情况下，模板提交后，阿里云预计在2个小时内审核完成（审核工作时间：周一至周日9:00~21:00，法定节假日顺延）。</description></item>
        /// <item><description>如果模板未通过审核，会返回审核失败的原因，请参考<a href="https://help.aliyun.com/document_detail/65990.html">短信审核失败的处理建议</a>，调用<a href="~~UpdateSmsTemplate~~">UpdateSmsTemplate</a>接口或在<a href="https://dysms.console.aliyun.com/domestic/text/template">模板管理</a>页面修改短信模板。</description></item>
        /// <item><description>当前接口是通过模板Code查询单个模板的审核详情。<a href="https://help.aliyun.com/document_detail/419288.html">QuerySmsTemplateList</a>接口可以查询您当前账号下所有模板的模板详情。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSmsTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSmsTemplateResponse
        /// </returns>
        public GetSmsTemplateResponse GetSmsTemplate(GetSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSmsTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the approval details of a template after you submit a template application. You can view the approval status of the template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>新接口和原接口变更的公告详情请参见<a href="https://help.aliyun.com/document_detail/2806975.html">关于短信服务更新签名&amp;模板接口的公告</a>。</description></item>
        /// <item><description>审核时间：一般情况下，模板提交后，阿里云预计在2个小时内审核完成（审核工作时间：周一至周日9:00~21:00，法定节假日顺延）。</description></item>
        /// <item><description>如果模板未通过审核，会返回审核失败的原因，请参考<a href="https://help.aliyun.com/document_detail/65990.html">短信审核失败的处理建议</a>，调用<a href="~~UpdateSmsTemplate~~">UpdateSmsTemplate</a>接口或在<a href="https://dysms.console.aliyun.com/domestic/text/template">模板管理</a>页面修改短信模板。</description></item>
        /// <item><description>当前接口是通过模板Code查询单个模板的审核详情。<a href="https://help.aliyun.com/document_detail/419288.html">QuerySmsTemplateList</a>接口可以查询您当前账号下所有模板的模板详情。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSmsTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSmsTemplateResponse
        /// </returns>
        public async Task<GetSmsTemplateResponse> GetSmsTemplateAsync(GetSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSmsTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模板列表详情（新接口）</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSmsTemplateListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSmsTemplateListResponse
        /// </returns>
        public GetSmsTemplateListResponse GetSmsTemplateListWithOptions(GetSmsTemplateListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSmsTemplateListShrinkRequest request = new GetSmsTemplateListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UsableStateList))
            {
                request.UsableStateListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UsableStateList, "UsableStateList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateTag))
            {
                query["TemplateTag"] = request.TemplateTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsableStateListShrink))
            {
                query["UsableStateList"] = request.UsableStateListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSmsTemplateList",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSmsTemplateListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模板列表详情（新接口）</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSmsTemplateListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSmsTemplateListResponse
        /// </returns>
        public async Task<GetSmsTemplateListResponse> GetSmsTemplateListWithOptionsAsync(GetSmsTemplateListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSmsTemplateListShrinkRequest request = new GetSmsTemplateListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UsableStateList))
            {
                request.UsableStateListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UsableStateList, "UsableStateList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateTag))
            {
                query["TemplateTag"] = request.TemplateTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsableStateListShrink))
            {
                query["UsableStateList"] = request.UsableStateListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSmsTemplateList",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSmsTemplateListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模板列表详情（新接口）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSmsTemplateListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSmsTemplateListResponse
        /// </returns>
        public GetSmsTemplateListResponse GetSmsTemplateList(GetSmsTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSmsTemplateListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模板列表详情（新接口）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSmsTemplateListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSmsTemplateListResponse
        /// </returns>
        public async Task<GetSmsTemplateListResponse> GetSmsTemplateListAsync(GetSmsTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSmsTemplateListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tags are markers that you add to templates. Each tag consists of a key-value pair (Key-Value). You can query the template codes bound to a tag key-value pair, or query all tags bound to a specific template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can log on to the Short Message Service (SMS) console and go to the <a href="https://dysms.console.aliyun.com/domestic/text/template">Template Management</a> page to filter SMS templates that are bound to tag key-value pairs, or click <b>Details</b> in the Actions column to view the tags that are bound to the current template.</para>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit of this operation is 50 calls per second. If the limit is exceeded, API calls will be throttled, which may affect your business. Call this operation properly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tags are markers that you add to templates. Each tag consists of a key-value pair (Key-Value). You can query the template codes bound to a tag key-value pair, or query all tags bound to a specific template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can log on to the Short Message Service (SMS) console and go to the <a href="https://dysms.console.aliyun.com/domestic/text/template">Template Management</a> page to filter SMS templates that are bound to tag key-value pairs, or click <b>Details</b> in the Actions column to view the tags that are bound to the current template.</para>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit of this operation is 50 calls per second. If the limit is exceeded, API calls will be throttled, which may affect your business. Call this operation properly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tags are markers that you add to templates. Each tag consists of a key-value pair (Key-Value). You can query the template codes bound to a tag key-value pair, or query all tags bound to a specific template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can log on to the Short Message Service (SMS) console and go to the <a href="https://dysms.console.aliyun.com/domestic/text/template">Template Management</a> page to filter SMS templates that are bound to tag key-value pairs, or click <b>Details</b> in the Actions column to view the tags that are bound to the current template.</para>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit of this operation is 50 calls per second. If the limit is exceeded, API calls will be throttled, which may affect your business. Call this operation properly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tags are markers that you add to templates. Each tag consists of a key-value pair (Key-Value). You can query the template codes bound to a tag key-value pair, or query all tags bound to a specific template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can log on to the Short Message Service (SMS) console and go to the <a href="https://dysms.console.aliyun.com/domestic/text/template">Template Management</a> page to filter SMS templates that are bound to tag key-value pairs, or click <b>Details</b> in the Actions column to view the tags that are bound to the current template.</para>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit of this operation is 50 calls per second. If the limit is exceeded, API calls will be throttled, which may affect your business. Call this operation properly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation is discontinued.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>根据工信部规定与运营商<a href="https://help.aliyun.com/document_detail/2806975.html">相关要求</a>，阿里云进行了签名相关API的功能改造。为提升您签名的审核效率和审核通过率，请您使用新接口<a href="https://help.aliyun.com/document_detail/2807428.html">UpdateSmsSign-修改短信签名</a>。</description></item>
        /// <item><description>仅支持修改未通过审核的签名，请参考<a href="https://help.aliyun.com/document_detail/65990.html">短信审核失败的处理建议</a>，调用此接口修改后自动提交审核，签名进入待审核状态。</description></item>
        /// <item><description>通过接口修改签名的操作会在短信服务控制台同步，在控制台对签名的相关操作，请参见<a href="https://help.aliyun.com/document_detail/108073.html">短信签名</a>。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifySmsSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySmsSignResponse
        /// </returns>
        public ModifySmsSignResponse ModifySmsSignWithOptions(ModifySmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignSource))
            {
                query["SignSource"] = request.SignSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignType))
            {
                query["SignType"] = request.SignType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignFileList))
            {
                body["SignFileList"] = request.SignFileList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySmsSign",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySmsSignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation is discontinued.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>根据工信部规定与运营商<a href="https://help.aliyun.com/document_detail/2806975.html">相关要求</a>，阿里云进行了签名相关API的功能改造。为提升您签名的审核效率和审核通过率，请您使用新接口<a href="https://help.aliyun.com/document_detail/2807428.html">UpdateSmsSign-修改短信签名</a>。</description></item>
        /// <item><description>仅支持修改未通过审核的签名，请参考<a href="https://help.aliyun.com/document_detail/65990.html">短信审核失败的处理建议</a>，调用此接口修改后自动提交审核，签名进入待审核状态。</description></item>
        /// <item><description>通过接口修改签名的操作会在短信服务控制台同步，在控制台对签名的相关操作，请参见<a href="https://help.aliyun.com/document_detail/108073.html">短信签名</a>。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifySmsSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySmsSignResponse
        /// </returns>
        public async Task<ModifySmsSignResponse> ModifySmsSignWithOptionsAsync(ModifySmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignSource))
            {
                query["SignSource"] = request.SignSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignType))
            {
                query["SignType"] = request.SignType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignFileList))
            {
                body["SignFileList"] = request.SignFileList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySmsSign",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySmsSignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation is discontinued.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>根据工信部规定与运营商<a href="https://help.aliyun.com/document_detail/2806975.html">相关要求</a>，阿里云进行了签名相关API的功能改造。为提升您签名的审核效率和审核通过率，请您使用新接口<a href="https://help.aliyun.com/document_detail/2807428.html">UpdateSmsSign-修改短信签名</a>。</description></item>
        /// <item><description>仅支持修改未通过审核的签名，请参考<a href="https://help.aliyun.com/document_detail/65990.html">短信审核失败的处理建议</a>，调用此接口修改后自动提交审核，签名进入待审核状态。</description></item>
        /// <item><description>通过接口修改签名的操作会在短信服务控制台同步，在控制台对签名的相关操作，请参见<a href="https://help.aliyun.com/document_detail/108073.html">短信签名</a>。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifySmsSignRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySmsSignResponse
        /// </returns>
        public ModifySmsSignResponse ModifySmsSign(ModifySmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySmsSignWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation is discontinued.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>根据工信部规定与运营商<a href="https://help.aliyun.com/document_detail/2806975.html">相关要求</a>，阿里云进行了签名相关API的功能改造。为提升您签名的审核效率和审核通过率，请您使用新接口<a href="https://help.aliyun.com/document_detail/2807428.html">UpdateSmsSign-修改短信签名</a>。</description></item>
        /// <item><description>仅支持修改未通过审核的签名，请参考<a href="https://help.aliyun.com/document_detail/65990.html">短信审核失败的处理建议</a>，调用此接口修改后自动提交审核，签名进入待审核状态。</description></item>
        /// <item><description>通过接口修改签名的操作会在短信服务控制台同步，在控制台对签名的相关操作，请参见<a href="https://help.aliyun.com/document_detail/108073.html">短信签名</a>。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifySmsSignRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySmsSignResponse
        /// </returns>
        public async Task<ModifySmsSignResponse> ModifySmsSignAsync(ModifySmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySmsSignWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifySmsTemplate is deprecated, please use Dysmsapi::2017-05-25::UpdateSmsTemplate instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation is discontinued.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>根据工信部规定与运营商<a href="https://help.aliyun.com/document_detail/2806975.html">相关要求</a>，阿里云进行了模板相关API的功能改造。为提升您模板的审核效率和审核通过率，请您使用新接口<a href="https://help.aliyun.com/document_detail/2807432.html">UpdateSmsTemplate-修改短信模板</a>。</description></item>
        /// <item><description>仅支持修改未通过审核的模板，请参考<a href="https://help.aliyun.com/document_detail/65990.html">短信审核失败的处理建议</a>，调用此接口修改后重新提交审核。</description></item>
        /// <item><description>通过接口修改模板的操作会在短信服务控制台同步，在控制台对模板的相关操作，请参见<a href="https://help.aliyun.com/document_detail/108085.html">短信模板</a>。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为1000次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifySmsTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySmsTemplateResponse
        /// </returns>
        [Obsolete("OpenAPI ModifySmsTemplate is deprecated, please use Dysmsapi::2017-05-25::UpdateSmsTemplate instead.")]
        // Deprecated
        public ModifySmsTemplateResponse ModifySmsTemplateWithOptions(ModifySmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateContent))
            {
                query["TemplateContent"] = request.TemplateContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySmsTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySmsTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifySmsTemplate is deprecated, please use Dysmsapi::2017-05-25::UpdateSmsTemplate instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation is discontinued.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>根据工信部规定与运营商<a href="https://help.aliyun.com/document_detail/2806975.html">相关要求</a>，阿里云进行了模板相关API的功能改造。为提升您模板的审核效率和审核通过率，请您使用新接口<a href="https://help.aliyun.com/document_detail/2807432.html">UpdateSmsTemplate-修改短信模板</a>。</description></item>
        /// <item><description>仅支持修改未通过审核的模板，请参考<a href="https://help.aliyun.com/document_detail/65990.html">短信审核失败的处理建议</a>，调用此接口修改后重新提交审核。</description></item>
        /// <item><description>通过接口修改模板的操作会在短信服务控制台同步，在控制台对模板的相关操作，请参见<a href="https://help.aliyun.com/document_detail/108085.html">短信模板</a>。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为1000次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifySmsTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySmsTemplateResponse
        /// </returns>
        [Obsolete("OpenAPI ModifySmsTemplate is deprecated, please use Dysmsapi::2017-05-25::UpdateSmsTemplate instead.")]
        // Deprecated
        public async Task<ModifySmsTemplateResponse> ModifySmsTemplateWithOptionsAsync(ModifySmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateContent))
            {
                query["TemplateContent"] = request.TemplateContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySmsTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySmsTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifySmsTemplate is deprecated, please use Dysmsapi::2017-05-25::UpdateSmsTemplate instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation is discontinued.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>根据工信部规定与运营商<a href="https://help.aliyun.com/document_detail/2806975.html">相关要求</a>，阿里云进行了模板相关API的功能改造。为提升您模板的审核效率和审核通过率，请您使用新接口<a href="https://help.aliyun.com/document_detail/2807432.html">UpdateSmsTemplate-修改短信模板</a>。</description></item>
        /// <item><description>仅支持修改未通过审核的模板，请参考<a href="https://help.aliyun.com/document_detail/65990.html">短信审核失败的处理建议</a>，调用此接口修改后重新提交审核。</description></item>
        /// <item><description>通过接口修改模板的操作会在短信服务控制台同步，在控制台对模板的相关操作，请参见<a href="https://help.aliyun.com/document_detail/108085.html">短信模板</a>。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为1000次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifySmsTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySmsTemplateResponse
        /// </returns>
        [Obsolete("OpenAPI ModifySmsTemplate is deprecated, please use Dysmsapi::2017-05-25::UpdateSmsTemplate instead.")]
        // Deprecated
        public ModifySmsTemplateResponse ModifySmsTemplate(ModifySmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySmsTemplateWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifySmsTemplate is deprecated, please use Dysmsapi::2017-05-25::UpdateSmsTemplate instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation is discontinued.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>根据工信部规定与运营商<a href="https://help.aliyun.com/document_detail/2806975.html">相关要求</a>，阿里云进行了模板相关API的功能改造。为提升您模板的审核效率和审核通过率，请您使用新接口<a href="https://help.aliyun.com/document_detail/2807432.html">UpdateSmsTemplate-修改短信模板</a>。</description></item>
        /// <item><description>仅支持修改未通过审核的模板，请参考<a href="https://help.aliyun.com/document_detail/65990.html">短信审核失败的处理建议</a>，调用此接口修改后重新提交审核。</description></item>
        /// <item><description>通过接口修改模板的操作会在短信服务控制台同步，在控制台对模板的相关操作，请参见<a href="https://help.aliyun.com/document_detail/108085.html">短信模板</a>。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为1000次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifySmsTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySmsTemplateResponse
        /// </returns>
        [Obsolete("OpenAPI ModifySmsTemplate is deprecated, please use Dysmsapi::2017-05-25::UpdateSmsTemplate instead.")]
        // Deprecated
        public async Task<ModifySmsTemplateResponse> ModifySmsTemplateAsync(ModifySmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySmsTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the review status of a card SMS template and returns information about the review by mobile phone vendors.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Alibaba Cloud accounts that have not activated the card SMS service cannot call this API.</description></item>
        /// <item><description>The card SMS service is currently in the internal invitation phase. Contact your Alibaba Cloud business manager to apply for activation or <a href="https://help.aliyun.com/document_detail/464625.html">contact Alibaba Cloud pre-sales consultation</a>.</description></item>
        /// <item><description>You can also log on to the <a href="https://dysms.console.aliyun.com/domestic/card">Domestic Card SMS</a> page in the console and query the review status of card SMS templates on the Template Management tab.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit for this operation is 300 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call this operation responsibly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCardSmsTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCardSmsTemplateResponse
        /// </returns>
        public QueryCardSmsTemplateResponse QueryCardSmsTemplateWithOptions(QueryCardSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCardSmsTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCardSmsTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the review status of a card SMS template and returns information about the review by mobile phone vendors.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Alibaba Cloud accounts that have not activated the card SMS service cannot call this API.</description></item>
        /// <item><description>The card SMS service is currently in the internal invitation phase. Contact your Alibaba Cloud business manager to apply for activation or <a href="https://help.aliyun.com/document_detail/464625.html">contact Alibaba Cloud pre-sales consultation</a>.</description></item>
        /// <item><description>You can also log on to the <a href="https://dysms.console.aliyun.com/domestic/card">Domestic Card SMS</a> page in the console and query the review status of card SMS templates on the Template Management tab.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit for this operation is 300 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call this operation responsibly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCardSmsTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCardSmsTemplateResponse
        /// </returns>
        public async Task<QueryCardSmsTemplateResponse> QueryCardSmsTemplateWithOptionsAsync(QueryCardSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCardSmsTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCardSmsTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the review status of a card SMS template and returns information about the review by mobile phone vendors.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Alibaba Cloud accounts that have not activated the card SMS service cannot call this API.</description></item>
        /// <item><description>The card SMS service is currently in the internal invitation phase. Contact your Alibaba Cloud business manager to apply for activation or <a href="https://help.aliyun.com/document_detail/464625.html">contact Alibaba Cloud pre-sales consultation</a>.</description></item>
        /// <item><description>You can also log on to the <a href="https://dysms.console.aliyun.com/domestic/card">Domestic Card SMS</a> page in the console and query the review status of card SMS templates on the Template Management tab.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit for this operation is 300 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call this operation responsibly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCardSmsTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCardSmsTemplateResponse
        /// </returns>
        public QueryCardSmsTemplateResponse QueryCardSmsTemplate(QueryCardSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCardSmsTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the review status of a card SMS template and returns information about the review by mobile phone vendors.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Alibaba Cloud accounts that have not activated the card SMS service cannot call this API.</description></item>
        /// <item><description>The card SMS service is currently in the internal invitation phase. Contact your Alibaba Cloud business manager to apply for activation or <a href="https://help.aliyun.com/document_detail/464625.html">contact Alibaba Cloud pre-sales consultation</a>.</description></item>
        /// <item><description>You can also log on to the <a href="https://dysms.console.aliyun.com/domestic/card">Domestic Card SMS</a> page in the console and query the review status of card SMS templates on the Template Management tab.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit for this operation is 300 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call this operation responsibly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCardSmsTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCardSmsTemplateResponse
        /// </returns>
        public async Task<QueryCardSmsTemplateResponse> QueryCardSmsTemplateAsync(QueryCardSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCardSmsTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the parsing data of a specified card SMS template. The parsing data includes the number of successful SMS parsing receipts, the number of message exposures, and the number of message clicks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit on this operation is 300 calls per second per user. If the number of calls per second exceeds the limit, throttling is triggered. This may affect your business. Call this operation at a reasonable pace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCardSmsTemplateReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCardSmsTemplateReportResponse
        /// </returns>
        public QueryCardSmsTemplateReportResponse QueryCardSmsTemplateReportWithOptions(QueryCardSmsTemplateReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCodes))
            {
                query["TemplateCodes"] = request.TemplateCodes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCardSmsTemplateReport",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCardSmsTemplateReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the parsing data of a specified card SMS template. The parsing data includes the number of successful SMS parsing receipts, the number of message exposures, and the number of message clicks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit on this operation is 300 calls per second per user. If the number of calls per second exceeds the limit, throttling is triggered. This may affect your business. Call this operation at a reasonable pace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCardSmsTemplateReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCardSmsTemplateReportResponse
        /// </returns>
        public async Task<QueryCardSmsTemplateReportResponse> QueryCardSmsTemplateReportWithOptionsAsync(QueryCardSmsTemplateReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCodes))
            {
                query["TemplateCodes"] = request.TemplateCodes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCardSmsTemplateReport",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCardSmsTemplateReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the parsing data of a specified card SMS template. The parsing data includes the number of successful SMS parsing receipts, the number of message exposures, and the number of message clicks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit on this operation is 300 calls per second per user. If the number of calls per second exceeds the limit, throttling is triggered. This may affect your business. Call this operation at a reasonable pace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCardSmsTemplateReportRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCardSmsTemplateReportResponse
        /// </returns>
        public QueryCardSmsTemplateReportResponse QueryCardSmsTemplateReport(QueryCardSmsTemplateReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCardSmsTemplateReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the parsing data of a specified card SMS template. The parsing data includes the number of successful SMS parsing receipts, the number of message exposures, and the number of message clicks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit on this operation is 300 calls per second per user. If the number of calls per second exceeds the limit, throttling is triggered. This may affect your business. Call this operation at a reasonable pace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCardSmsTemplateReportRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCardSmsTemplateReportResponse
        /// </returns>
        public async Task<QueryCardSmsTemplateReportResponse> QueryCardSmsTemplateReportAsync(QueryCardSmsTemplateReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCardSmsTemplateReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a digital SMS signature by its name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query only the digital SMS signatures that belong to your Alibaba Cloud account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryDigitalSignByNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDigitalSignByNameResponse
        /// </returns>
        public QueryDigitalSignByNameResponse QueryDigitalSignByNameWithOptions(QueryDigitalSignByNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDigitalSignByName",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDigitalSignByNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a digital SMS signature by its name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query only the digital SMS signatures that belong to your Alibaba Cloud account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryDigitalSignByNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDigitalSignByNameResponse
        /// </returns>
        public async Task<QueryDigitalSignByNameResponse> QueryDigitalSignByNameWithOptionsAsync(QueryDigitalSignByNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDigitalSignByName",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDigitalSignByNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a digital SMS signature by its name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query only the digital SMS signatures that belong to your Alibaba Cloud account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryDigitalSignByNameRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDigitalSignByNameResponse
        /// </returns>
        public QueryDigitalSignByNameResponse QueryDigitalSignByName(QueryDigitalSignByNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDigitalSignByNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a digital SMS signature by its name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query only the digital SMS signatures that belong to your Alibaba Cloud account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryDigitalSignByNameRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDigitalSignByNameResponse
        /// </returns>
        public async Task<QueryDigitalSignByNameResponse> QueryDigitalSignByNameAsync(QueryDigitalSignByNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDigitalSignByNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询验证码签名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExtCodeSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryExtCodeSignResponse
        /// </returns>
        public QueryExtCodeSignResponse QueryExtCodeSignWithOptions(QueryExtCodeSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtCode))
            {
                query["ExtCode"] = request.ExtCode;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryExtCodeSign",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryExtCodeSignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询验证码签名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExtCodeSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryExtCodeSignResponse
        /// </returns>
        public async Task<QueryExtCodeSignResponse> QueryExtCodeSignWithOptionsAsync(QueryExtCodeSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtCode))
            {
                query["ExtCode"] = request.ExtCode;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryExtCodeSign",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryExtCodeSignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询验证码签名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExtCodeSignRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryExtCodeSignResponse
        /// </returns>
        public QueryExtCodeSignResponse QueryExtCodeSign(QueryExtCodeSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryExtCodeSignWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询验证码签名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExtCodeSignRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryExtCodeSignResponse
        /// </returns>
        public async Task<QueryExtCodeSignResponse> QueryExtCodeSignAsync(QueryExtCodeSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryExtCodeSignWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether a phone number supports card SMS messages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>未开通卡片短信业务的阿里云账号无法调用此API。</description></item>
        /// <item><description>目前卡片短信在内部邀约阶段，请联系您的阿里云商务经理申请开通或<a href="https://help.aliyun.com/document_detail/464625.html">联系阿里云售前咨询</a>。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// QueryMobilesCardSupportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMobilesCardSupportResponse
        /// </returns>
        public QueryMobilesCardSupportResponse QueryMobilesCardSupportWithOptions(QueryMobilesCardSupportRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryMobilesCardSupportShrinkRequest request = new QueryMobilesCardSupportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Mobiles))
            {
                request.MobilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Mobiles, "Mobiles", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptType))
            {
                query["EncryptType"] = request.EncryptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobilesShrink))
            {
                query["Mobiles"] = request.MobilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMobilesCardSupport",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMobilesCardSupportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether a phone number supports card SMS messages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>未开通卡片短信业务的阿里云账号无法调用此API。</description></item>
        /// <item><description>目前卡片短信在内部邀约阶段，请联系您的阿里云商务经理申请开通或<a href="https://help.aliyun.com/document_detail/464625.html">联系阿里云售前咨询</a>。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// QueryMobilesCardSupportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMobilesCardSupportResponse
        /// </returns>
        public async Task<QueryMobilesCardSupportResponse> QueryMobilesCardSupportWithOptionsAsync(QueryMobilesCardSupportRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryMobilesCardSupportShrinkRequest request = new QueryMobilesCardSupportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Mobiles))
            {
                request.MobilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Mobiles, "Mobiles", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptType))
            {
                query["EncryptType"] = request.EncryptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobilesShrink))
            {
                query["Mobiles"] = request.MobilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMobilesCardSupport",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMobilesCardSupportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether a phone number supports card SMS messages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>未开通卡片短信业务的阿里云账号无法调用此API。</description></item>
        /// <item><description>目前卡片短信在内部邀约阶段，请联系您的阿里云商务经理申请开通或<a href="https://help.aliyun.com/document_detail/464625.html">联系阿里云售前咨询</a>。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryMobilesCardSupportRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMobilesCardSupportResponse
        /// </returns>
        public QueryMobilesCardSupportResponse QueryMobilesCardSupport(QueryMobilesCardSupportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMobilesCardSupportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether a phone number supports card SMS messages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>未开通卡片短信业务的阿里云账号无法调用此API。</description></item>
        /// <item><description>目前卡片短信在内部邀约阶段，请联系您的阿里云商务经理申请开通或<a href="https://help.aliyun.com/document_detail/464625.html">联系阿里云售前咨询</a>。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryMobilesCardSupportRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMobilesCardSupportResponse
        /// </returns>
        public async Task<QueryMobilesCardSupportResponse> QueryMobilesCardSupportAsync(QueryMobilesCardSupportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMobilesCardSupportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>点击明细查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPageSmartShortUrlLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPageSmartShortUrlLogResponse
        /// </returns>
        public QueryPageSmartShortUrlLogResponse QueryPageSmartShortUrlLogWithOptions(QueryPageSmartShortUrlLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateDateEnd))
            {
                query["CreateDateEnd"] = request.CreateDateEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateDateStart))
            {
                query["CreateDateStart"] = request.CreateDateStart;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShortUrl))
            {
                query["ShortUrl"] = request.ShortUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPageSmartShortUrlLog",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPageSmartShortUrlLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>点击明细查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPageSmartShortUrlLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPageSmartShortUrlLogResponse
        /// </returns>
        public async Task<QueryPageSmartShortUrlLogResponse> QueryPageSmartShortUrlLogWithOptionsAsync(QueryPageSmartShortUrlLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateDateEnd))
            {
                query["CreateDateEnd"] = request.CreateDateEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateDateStart))
            {
                query["CreateDateStart"] = request.CreateDateStart;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShortUrl))
            {
                query["ShortUrl"] = request.ShortUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPageSmartShortUrlLog",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPageSmartShortUrlLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>点击明细查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPageSmartShortUrlLogRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPageSmartShortUrlLogResponse
        /// </returns>
        public QueryPageSmartShortUrlLogResponse QueryPageSmartShortUrlLog(QueryPageSmartShortUrlLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPageSmartShortUrlLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>点击明细查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPageSmartShortUrlLogRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPageSmartShortUrlLogResponse
        /// </returns>
        public async Task<QueryPageSmartShortUrlLogResponse> QueryPageSmartShortUrlLogAsync(QueryPageSmartShortUrlLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPageSmartShortUrlLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询终端5G适配情况</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRCSMobileCapableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRCSMobileCapableResponse
        /// </returns>
        public QueryRCSMobileCapableResponse QueryRCSMobileCapableWithOptions(QueryRCSMobileCapableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumbers))
            {
                query["PhoneNumbers"] = request.PhoneNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRCSMobileCapable",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRCSMobileCapableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询终端5G适配情况</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRCSMobileCapableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRCSMobileCapableResponse
        /// </returns>
        public async Task<QueryRCSMobileCapableResponse> QueryRCSMobileCapableWithOptionsAsync(QueryRCSMobileCapableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumbers))
            {
                query["PhoneNumbers"] = request.PhoneNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRCSMobileCapable",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRCSMobileCapableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询终端5G适配情况</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRCSMobileCapableRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRCSMobileCapableResponse
        /// </returns>
        public QueryRCSMobileCapableResponse QueryRCSMobileCapable(QueryRCSMobileCapableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRCSMobileCapableWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询终端5G适配情况</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRCSMobileCapableRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRCSMobileCapableResponse
        /// </returns>
        public async Task<QueryRCSMobileCapableResponse> QueryRCSMobileCapableAsync(QueryRCSMobileCapableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRCSMobileCapableWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询终端5G适配情况任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRCSMobileCapableTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRCSMobileCapableTaskResultResponse
        /// </returns>
        public QueryRCSMobileCapableTaskResultResponse QueryRCSMobileCapableTaskResultWithOptions(QueryRCSMobileCapableTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRCSMobileCapableTaskResult",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRCSMobileCapableTaskResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询终端5G适配情况任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRCSMobileCapableTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRCSMobileCapableTaskResultResponse
        /// </returns>
        public async Task<QueryRCSMobileCapableTaskResultResponse> QueryRCSMobileCapableTaskResultWithOptionsAsync(QueryRCSMobileCapableTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRCSMobileCapableTaskResult",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRCSMobileCapableTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询终端5G适配情况任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRCSMobileCapableTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRCSMobileCapableTaskResultResponse
        /// </returns>
        public QueryRCSMobileCapableTaskResultResponse QueryRCSMobileCapableTaskResult(QueryRCSMobileCapableTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRCSMobileCapableTaskResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询终端5G适配情况任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRCSMobileCapableTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRCSMobileCapableTaskResultResponse
        /// </returns>
        public async Task<QueryRCSMobileCapableTaskResultResponse> QueryRCSMobileCapableTaskResultAsync(QueryRCSMobileCapableTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRCSMobileCapableTaskResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询5G模板详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRCSTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRCSTemplateResponse
        /// </returns>
        public QueryRCSTemplateResponse QueryRCSTemplateWithOptions(QueryRCSTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRCSTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRCSTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询5G模板详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRCSTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRCSTemplateResponse
        /// </returns>
        public async Task<QueryRCSTemplateResponse> QueryRCSTemplateWithOptionsAsync(QueryRCSTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRCSTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRCSTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询5G模板详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRCSTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRCSTemplateResponse
        /// </returns>
        public QueryRCSTemplateResponse QueryRCSTemplate(QueryRCSTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRCSTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询5G模板详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRCSTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRCSTemplateResponse
        /// </returns>
        public async Task<QueryRCSTemplateResponse> QueryRCSTemplateAsync(QueryRCSTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRCSTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定版本查看5G消息固定菜单详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRcsSignMenuByVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRcsSignMenuByVersionResponse
        /// </returns>
        public QueryRcsSignMenuByVersionResponse QueryRcsSignMenuByVersionWithOptions(QueryRcsSignMenuByVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RcsMenuVersion))
            {
                query["RcsMenuVersion"] = request.RcsMenuVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRcsSignMenuByVersion",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRcsSignMenuByVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定版本查看5G消息固定菜单详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRcsSignMenuByVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRcsSignMenuByVersionResponse
        /// </returns>
        public async Task<QueryRcsSignMenuByVersionResponse> QueryRcsSignMenuByVersionWithOptionsAsync(QueryRcsSignMenuByVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RcsMenuVersion))
            {
                query["RcsMenuVersion"] = request.RcsMenuVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRcsSignMenuByVersion",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRcsSignMenuByVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定版本查看5G消息固定菜单详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRcsSignMenuByVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRcsSignMenuByVersionResponse
        /// </returns>
        public QueryRcsSignMenuByVersionResponse QueryRcsSignMenuByVersion(QueryRcsSignMenuByVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRcsSignMenuByVersionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定版本查看5G消息固定菜单详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRcsSignMenuByVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRcsSignMenuByVersionResponse
        /// </returns>
        public async Task<QueryRcsSignMenuByVersionResponse> QueryRcsSignMenuByVersionAsync(QueryRcsSignMenuByVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRcsSignMenuByVersionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the delivery records and status of SMS messages sent to a single phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This operation queries the details of SMS messages sent to a specific phone number on a given date. You can also provide the <c>BizId</c> to query a specific delivery record.</description></item>
        /// <item><description>This operation queries delivery details for a single phone number at a time. To view delivery details in bulk, use the <a href="https://help.aliyun.com/document_detail/419276.html">QuerySendStatistics</a> operation to query delivery statistics, or log in to the <a href="https://dysms.console.aliyun.com/record">Delivery Receipts</a> page in the console.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for this operation is 5,000 requests per second per user. Calls that exceed this limit are throttled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySendDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySendDetailsResponse
        /// </returns>
        public QuerySendDetailsResponse QuerySendDetailsWithOptions(QuerySendDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendDate))
            {
                query["SendDate"] = request.SendDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySendDetails",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySendDetailsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the delivery records and status of SMS messages sent to a single phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This operation queries the details of SMS messages sent to a specific phone number on a given date. You can also provide the <c>BizId</c> to query a specific delivery record.</description></item>
        /// <item><description>This operation queries delivery details for a single phone number at a time. To view delivery details in bulk, use the <a href="https://help.aliyun.com/document_detail/419276.html">QuerySendStatistics</a> operation to query delivery statistics, or log in to the <a href="https://dysms.console.aliyun.com/record">Delivery Receipts</a> page in the console.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for this operation is 5,000 requests per second per user. Calls that exceed this limit are throttled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySendDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySendDetailsResponse
        /// </returns>
        public async Task<QuerySendDetailsResponse> QuerySendDetailsWithOptionsAsync(QuerySendDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendDate))
            {
                query["SendDate"] = request.SendDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySendDetails",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySendDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the delivery records and status of SMS messages sent to a single phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This operation queries the details of SMS messages sent to a specific phone number on a given date. You can also provide the <c>BizId</c> to query a specific delivery record.</description></item>
        /// <item><description>This operation queries delivery details for a single phone number at a time. To view delivery details in bulk, use the <a href="https://help.aliyun.com/document_detail/419276.html">QuerySendStatistics</a> operation to query delivery statistics, or log in to the <a href="https://dysms.console.aliyun.com/record">Delivery Receipts</a> page in the console.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for this operation is 5,000 requests per second per user. Calls that exceed this limit are throttled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySendDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySendDetailsResponse
        /// </returns>
        public QuerySendDetailsResponse QuerySendDetails(QuerySendDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySendDetailsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the delivery records and status of SMS messages sent to a single phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This operation queries the details of SMS messages sent to a specific phone number on a given date. You can also provide the <c>BizId</c> to query a specific delivery record.</description></item>
        /// <item><description>This operation queries delivery details for a single phone number at a time. To view delivery details in bulk, use the <a href="https://help.aliyun.com/document_detail/419276.html">QuerySendStatistics</a> operation to query delivery statistics, or log in to the <a href="https://dysms.console.aliyun.com/record">Delivery Receipts</a> page in the console.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for this operation is 5,000 requests per second per user. Calls that exceed this limit are throttled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySendDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySendDetailsResponse
        /// </returns>
        public async Task<QuerySendDetailsResponse> QuerySendDetailsAsync(QuerySendDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySendDetailsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries message delivery statistics, including send dates, the number of successfully sent messages, and the number of received delivery receipts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>If you query data over a long time range, the results are paginated. You can specify the page size and page number to navigate through the Delivery Logs.</description></item>
        /// <item><description>You can also view delivery details by logging in to the <a href="https://dysms.console.aliyun.com/dysms.htm#/overview">Short Message Service console</a> and navigating to the <b>Business Statistics</b> &gt; <b>Delivery Logs</b> page.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySendStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySendStatisticsResponse
        /// </returns>
        public QuerySendStatisticsResponse QuerySendStatisticsWithOptions(QuerySendStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsGlobe))
            {
                query["IsGlobe"] = request.IsGlobe;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySendStatistics",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySendStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries message delivery statistics, including send dates, the number of successfully sent messages, and the number of received delivery receipts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>If you query data over a long time range, the results are paginated. You can specify the page size and page number to navigate through the Delivery Logs.</description></item>
        /// <item><description>You can also view delivery details by logging in to the <a href="https://dysms.console.aliyun.com/dysms.htm#/overview">Short Message Service console</a> and navigating to the <b>Business Statistics</b> &gt; <b>Delivery Logs</b> page.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySendStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySendStatisticsResponse
        /// </returns>
        public async Task<QuerySendStatisticsResponse> QuerySendStatisticsWithOptionsAsync(QuerySendStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsGlobe))
            {
                query["IsGlobe"] = request.IsGlobe;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySendStatistics",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySendStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries message delivery statistics, including send dates, the number of successfully sent messages, and the number of received delivery receipts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>If you query data over a long time range, the results are paginated. You can specify the page size and page number to navigate through the Delivery Logs.</description></item>
        /// <item><description>You can also view delivery details by logging in to the <a href="https://dysms.console.aliyun.com/dysms.htm#/overview">Short Message Service console</a> and navigating to the <b>Business Statistics</b> &gt; <b>Delivery Logs</b> page.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySendStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySendStatisticsResponse
        /// </returns>
        public QuerySendStatisticsResponse QuerySendStatistics(QuerySendStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySendStatisticsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries message delivery statistics, including send dates, the number of successfully sent messages, and the number of received delivery receipts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>If you query data over a long time range, the results are paginated. You can specify the page size and page number to navigate through the Delivery Logs.</description></item>
        /// <item><description>You can also view delivery details by logging in to the <a href="https://dysms.console.aliyun.com/dysms.htm#/overview">Short Message Service console</a> and navigating to the <b>Business Statistics</b> &gt; <b>Delivery Logs</b> page.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySendStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySendStatisticsResponse
        /// </returns>
        public async Task<QuerySendStatisticsResponse> QuerySendStatisticsAsync(QuerySendStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySendStatisticsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the status and availability of a short link.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: 
        /// This API is not currently supported by Short Message Service.</para>
        /// </remarks>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for this API is 20 queries per second per user. API calls that exceed this limit are rate-limited, which can impact your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryShortUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryShortUrlResponse
        /// </returns>
        public QueryShortUrlResponse QueryShortUrlWithOptions(QueryShortUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShortUrl))
            {
                body["ShortUrl"] = request.ShortUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryShortUrl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryShortUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the status and availability of a short link.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: 
        /// This API is not currently supported by Short Message Service.</para>
        /// </remarks>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for this API is 20 queries per second per user. API calls that exceed this limit are rate-limited, which can impact your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryShortUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryShortUrlResponse
        /// </returns>
        public async Task<QueryShortUrlResponse> QueryShortUrlWithOptionsAsync(QueryShortUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShortUrl))
            {
                body["ShortUrl"] = request.ShortUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryShortUrl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryShortUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the status and availability of a short link.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: 
        /// This API is not currently supported by Short Message Service.</para>
        /// </remarks>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for this API is 20 queries per second per user. API calls that exceed this limit are rate-limited, which can impact your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryShortUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryShortUrlResponse
        /// </returns>
        public QueryShortUrlResponse QueryShortUrl(QueryShortUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryShortUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the status and availability of a short link.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: 
        /// This API is not currently supported by Short Message Service.</para>
        /// </remarks>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for this API is 20 queries per second per user. API calls that exceed this limit are rate-limited, which can impact your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryShortUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryShortUrlResponse
        /// </returns>
        public async Task<QueryShortUrlResponse> QueryShortUrlAsync(QueryShortUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryShortUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you apply for SMS qualifications, you can call this operation to query the details of a single qualification.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This API queries the details of a single qualification (enterprise information, legal representative information, and administrator information).</description></item>
        /// <item><description>To query all qualification information under your current account, or to query review details, call the <a href="~~QuerySmsQualificationRecord~~">QuerySmsQualificationRecord</a> operation.</description></item>
        /// <item><description>Affected by the SMS signature real-name registration requirements, the volume of qualification review tickets is growing rapidly, and the review time may be extended. Please be patient. The review is expected to be completed within 2 business days (review hours: Monday to Sunday 9:00-21:00, postponed for legal holidays). In special cases, the review time may be extended. Please be patient.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySingleSmsQualificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySingleSmsQualificationResponse
        /// </returns>
        public QuerySingleSmsQualificationResponse QuerySingleSmsQualificationWithOptions(QuerySingleSmsQualificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationGroupId))
            {
                query["QualificationGroupId"] = request.QualificationGroupId;
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
                Action = "QuerySingleSmsQualification",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySingleSmsQualificationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you apply for SMS qualifications, you can call this operation to query the details of a single qualification.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This API queries the details of a single qualification (enterprise information, legal representative information, and administrator information).</description></item>
        /// <item><description>To query all qualification information under your current account, or to query review details, call the <a href="~~QuerySmsQualificationRecord~~">QuerySmsQualificationRecord</a> operation.</description></item>
        /// <item><description>Affected by the SMS signature real-name registration requirements, the volume of qualification review tickets is growing rapidly, and the review time may be extended. Please be patient. The review is expected to be completed within 2 business days (review hours: Monday to Sunday 9:00-21:00, postponed for legal holidays). In special cases, the review time may be extended. Please be patient.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySingleSmsQualificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySingleSmsQualificationResponse
        /// </returns>
        public async Task<QuerySingleSmsQualificationResponse> QuerySingleSmsQualificationWithOptionsAsync(QuerySingleSmsQualificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationGroupId))
            {
                query["QualificationGroupId"] = request.QualificationGroupId;
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
                Action = "QuerySingleSmsQualification",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySingleSmsQualificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you apply for SMS qualifications, you can call this operation to query the details of a single qualification.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This API queries the details of a single qualification (enterprise information, legal representative information, and administrator information).</description></item>
        /// <item><description>To query all qualification information under your current account, or to query review details, call the <a href="~~QuerySmsQualificationRecord~~">QuerySmsQualificationRecord</a> operation.</description></item>
        /// <item><description>Affected by the SMS signature real-name registration requirements, the volume of qualification review tickets is growing rapidly, and the review time may be extended. Please be patient. The review is expected to be completed within 2 business days (review hours: Monday to Sunday 9:00-21:00, postponed for legal holidays). In special cases, the review time may be extended. Please be patient.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySingleSmsQualificationRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySingleSmsQualificationResponse
        /// </returns>
        public QuerySingleSmsQualificationResponse QuerySingleSmsQualification(QuerySingleSmsQualificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySingleSmsQualificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you apply for SMS qualifications, you can call this operation to query the details of a single qualification.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This API queries the details of a single qualification (enterprise information, legal representative information, and administrator information).</description></item>
        /// <item><description>To query all qualification information under your current account, or to query review details, call the <a href="~~QuerySmsQualificationRecord~~">QuerySmsQualificationRecord</a> operation.</description></item>
        /// <item><description>Affected by the SMS signature real-name registration requirements, the volume of qualification review tickets is growing rapidly, and the review time may be extended. Please be patient. The review is expected to be completed within 2 business days (review hours: Monday to Sunday 9:00-21:00, postponed for legal holidays). In special cases, the review time may be extended. Please be patient.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySingleSmsQualificationRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySingleSmsQualificationResponse
        /// </returns>
        public async Task<QuerySingleSmsQualificationResponse> QuerySingleSmsQualificationAsync(QuerySingleSmsQualificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySingleSmsQualificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries icp record details.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Pass a list of icp record IDs to retrieve their details.
        /// For example, call the QuerySmsSignList or GetSmsSign API to obtain the required icp record IDs.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// QuerySmsAppIcpRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsAppIcpRecordResponse
        /// </returns>
        public QuerySmsAppIcpRecordResponse QuerySmsAppIcpRecordWithOptions(QuerySmsAppIcpRecordRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QuerySmsAppIcpRecordShrinkRequest request = new QuerySmsAppIcpRecordShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AppIcpRecordIdList))
            {
                request.AppIcpRecordIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AppIcpRecordIdList, "AppIcpRecordIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIcpRecordIdListShrink))
            {
                query["AppIcpRecordIdList"] = request.AppIcpRecordIdListShrink;
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
                Action = "QuerySmsAppIcpRecord",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmsAppIcpRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries icp record details.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Pass a list of icp record IDs to retrieve their details.
        /// For example, call the QuerySmsSignList or GetSmsSign API to obtain the required icp record IDs.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// QuerySmsAppIcpRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsAppIcpRecordResponse
        /// </returns>
        public async Task<QuerySmsAppIcpRecordResponse> QuerySmsAppIcpRecordWithOptionsAsync(QuerySmsAppIcpRecordRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QuerySmsAppIcpRecordShrinkRequest request = new QuerySmsAppIcpRecordShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AppIcpRecordIdList))
            {
                request.AppIcpRecordIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AppIcpRecordIdList, "AppIcpRecordIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIcpRecordIdListShrink))
            {
                query["AppIcpRecordIdList"] = request.AppIcpRecordIdListShrink;
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
                Action = "QuerySmsAppIcpRecord",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmsAppIcpRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries icp record details.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Pass a list of icp record IDs to retrieve their details.
        /// For example, call the QuerySmsSignList or GetSmsSign API to obtain the required icp record IDs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsAppIcpRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsAppIcpRecordResponse
        /// </returns>
        public QuerySmsAppIcpRecordResponse QuerySmsAppIcpRecord(QuerySmsAppIcpRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySmsAppIcpRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries icp record details.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Pass a list of icp record IDs to retrieve their details.
        /// For example, call the QuerySmsSignList or GetSmsSign API to obtain the required icp record IDs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsAppIcpRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsAppIcpRecordResponse
        /// </returns>
        public async Task<QuerySmsAppIcpRecordResponse> QuerySmsAppIcpRecordAsync(QuerySmsAppIcpRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySmsAppIcpRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries created letters of authorization. You can view the review status and authorized signature scope of the letters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Supports full query or conditional query:<list type="bullet">
        /// <item><description><b>Full query</b>: Queries the information of all letters of authorization under your current account. No parameters need to be passed. Full query is performed by default.</description></item>
        /// <item><description><b>Conditional query</b>: Supports queries by letter of authorization ID, signature name, and review status of the letter of authorization. Pass the parameters by which you want to filter.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Review duration: Affected by the real-name registration requirements for SMS signatures, the volume of qualification review tickets is currently increasing rapidly, and the review duration may be extended. Please wait patiently. The review is expected to be completed within 2 working days. SMS signatures and templates are expected to be reviewed within 2 hours after submission. Reviews involving governments and enterprises are generally completed within 2 working days. If verification upgrades, a large number of review tasks, or non-working hours are encountered, the review duration may be extended. Please wait patiently. (Review working hours: Monday to Sunday, 9:00–21:00, postponed for statutory holidays.)</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// QuerySmsAuthorizationLetterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsAuthorizationLetterResponse
        /// </returns>
        public QuerySmsAuthorizationLetterResponse QuerySmsAuthorizationLetterWithOptions(QuerySmsAuthorizationLetterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QuerySmsAuthorizationLetterShrinkRequest request = new QuerySmsAuthorizationLetterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AuthorizationLetterIdList))
            {
                request.AuthorizationLetterIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AuthorizationLetterIdList, "AuthorizationLetterIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationLetterIdListShrink))
            {
                query["AuthorizationLetterIdList"] = request.AuthorizationLetterIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationCode))
            {
                query["OrganizationCode"] = request.OrganizationCode;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySmsAuthorizationLetter",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmsAuthorizationLetterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries created letters of authorization. You can view the review status and authorized signature scope of the letters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Supports full query or conditional query:<list type="bullet">
        /// <item><description><b>Full query</b>: Queries the information of all letters of authorization under your current account. No parameters need to be passed. Full query is performed by default.</description></item>
        /// <item><description><b>Conditional query</b>: Supports queries by letter of authorization ID, signature name, and review status of the letter of authorization. Pass the parameters by which you want to filter.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Review duration: Affected by the real-name registration requirements for SMS signatures, the volume of qualification review tickets is currently increasing rapidly, and the review duration may be extended. Please wait patiently. The review is expected to be completed within 2 working days. SMS signatures and templates are expected to be reviewed within 2 hours after submission. Reviews involving governments and enterprises are generally completed within 2 working days. If verification upgrades, a large number of review tasks, or non-working hours are encountered, the review duration may be extended. Please wait patiently. (Review working hours: Monday to Sunday, 9:00–21:00, postponed for statutory holidays.)</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// QuerySmsAuthorizationLetterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsAuthorizationLetterResponse
        /// </returns>
        public async Task<QuerySmsAuthorizationLetterResponse> QuerySmsAuthorizationLetterWithOptionsAsync(QuerySmsAuthorizationLetterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QuerySmsAuthorizationLetterShrinkRequest request = new QuerySmsAuthorizationLetterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AuthorizationLetterIdList))
            {
                request.AuthorizationLetterIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AuthorizationLetterIdList, "AuthorizationLetterIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationLetterIdListShrink))
            {
                query["AuthorizationLetterIdList"] = request.AuthorizationLetterIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationCode))
            {
                query["OrganizationCode"] = request.OrganizationCode;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySmsAuthorizationLetter",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmsAuthorizationLetterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries created letters of authorization. You can view the review status and authorized signature scope of the letters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Supports full query or conditional query:<list type="bullet">
        /// <item><description><b>Full query</b>: Queries the information of all letters of authorization under your current account. No parameters need to be passed. Full query is performed by default.</description></item>
        /// <item><description><b>Conditional query</b>: Supports queries by letter of authorization ID, signature name, and review status of the letter of authorization. Pass the parameters by which you want to filter.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Review duration: Affected by the real-name registration requirements for SMS signatures, the volume of qualification review tickets is currently increasing rapidly, and the review duration may be extended. Please wait patiently. The review is expected to be completed within 2 working days. SMS signatures and templates are expected to be reviewed within 2 hours after submission. Reviews involving governments and enterprises are generally completed within 2 working days. If verification upgrades, a large number of review tasks, or non-working hours are encountered, the review duration may be extended. Please wait patiently. (Review working hours: Monday to Sunday, 9:00–21:00, postponed for statutory holidays.)</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsAuthorizationLetterRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsAuthorizationLetterResponse
        /// </returns>
        public QuerySmsAuthorizationLetterResponse QuerySmsAuthorizationLetter(QuerySmsAuthorizationLetterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySmsAuthorizationLetterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries created letters of authorization. You can view the review status and authorized signature scope of the letters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Supports full query or conditional query:<list type="bullet">
        /// <item><description><b>Full query</b>: Queries the information of all letters of authorization under your current account. No parameters need to be passed. Full query is performed by default.</description></item>
        /// <item><description><b>Conditional query</b>: Supports queries by letter of authorization ID, signature name, and review status of the letter of authorization. Pass the parameters by which you want to filter.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Review duration: Affected by the real-name registration requirements for SMS signatures, the volume of qualification review tickets is currently increasing rapidly, and the review duration may be extended. Please wait patiently. The review is expected to be completed within 2 working days. SMS signatures and templates are expected to be reviewed within 2 hours after submission. Reviews involving governments and enterprises are generally completed within 2 working days. If verification upgrades, a large number of review tasks, or non-working hours are encountered, the review duration may be extended. Please wait patiently. (Review working hours: Monday to Sunday, 9:00–21:00, postponed for statutory holidays.)</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsAuthorizationLetterRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsAuthorizationLetterResponse
        /// </returns>
        public async Task<QuerySmsAuthorizationLetterResponse> QuerySmsAuthorizationLetterAsync(QuerySmsAuthorizationLetterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySmsAuthorizationLetterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of SMS qualifications and their review details after you submit qualification applications. This operation supports filtered query.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>支持全量查询或条件查询：<list type="bullet">
        /// <item><description><b>全量查询</b>：查询您当前帐户下所有短信资质，无需传参。默认全量查询。</description></item>
        /// <item><description><b>条件查询</b>：支持根据资质名称、企业名称、法人姓名、审核状态、审核工单ID、资质用途进行查询，传入您希望筛选的参数即可。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>本接口用于查询资质及其审核信息，如果需要查询单个资质的具体信息（企业信息、法人信息、管理员信息），请调用<a href="~~QuerySingleSmsQualification~~">查询单个资质详情</a>接口。</description></item>
        /// <item><description>受短信签名实名制报备要求影响，当前资质审核工单量增长快速，审核时间可能会延长，请耐心等待，预计2个工作日内完成（审核工作时间：周一至周日 9:00~21:00，法定节假日顺延）。特殊情况可能延长审核时间，请耐心等待。</description></item>
        /// <item><description>如果资质未通过审核，审核备注<c>AuditRemark</c>会返回审核失败的原因，请参考<a href="~~2384377#a96cc318b94x1~~">审核失败的处理建议</a>，调用<a href="~~UpdateSmsQualification~~">修改短信资质</a>接口或在控制台<a href="https://dysms.console.aliyun.com/domestic/text/qualification">资质管理</a>页面修改资质信息后，重新发起审核。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsQualificationRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsQualificationRecordResponse
        /// </returns>
        public QuerySmsQualificationRecordResponse QuerySmsQualificationRecordWithOptions(QuerySmsQualificationRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyName))
            {
                query["CompanyName"] = request.CompanyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonName))
            {
                query["LegalPersonName"] = request.LegalPersonName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationGroupName))
            {
                query["QualificationGroupName"] = request.QualificationGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseBySelf))
            {
                query["UseBySelf"] = request.UseBySelf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkOrderId))
            {
                query["WorkOrderId"] = request.WorkOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySmsQualificationRecord",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmsQualificationRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of SMS qualifications and their review details after you submit qualification applications. This operation supports filtered query.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>支持全量查询或条件查询：<list type="bullet">
        /// <item><description><b>全量查询</b>：查询您当前帐户下所有短信资质，无需传参。默认全量查询。</description></item>
        /// <item><description><b>条件查询</b>：支持根据资质名称、企业名称、法人姓名、审核状态、审核工单ID、资质用途进行查询，传入您希望筛选的参数即可。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>本接口用于查询资质及其审核信息，如果需要查询单个资质的具体信息（企业信息、法人信息、管理员信息），请调用<a href="~~QuerySingleSmsQualification~~">查询单个资质详情</a>接口。</description></item>
        /// <item><description>受短信签名实名制报备要求影响，当前资质审核工单量增长快速，审核时间可能会延长，请耐心等待，预计2个工作日内完成（审核工作时间：周一至周日 9:00~21:00，法定节假日顺延）。特殊情况可能延长审核时间，请耐心等待。</description></item>
        /// <item><description>如果资质未通过审核，审核备注<c>AuditRemark</c>会返回审核失败的原因，请参考<a href="~~2384377#a96cc318b94x1~~">审核失败的处理建议</a>，调用<a href="~~UpdateSmsQualification~~">修改短信资质</a>接口或在控制台<a href="https://dysms.console.aliyun.com/domestic/text/qualification">资质管理</a>页面修改资质信息后，重新发起审核。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsQualificationRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsQualificationRecordResponse
        /// </returns>
        public async Task<QuerySmsQualificationRecordResponse> QuerySmsQualificationRecordWithOptionsAsync(QuerySmsQualificationRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyName))
            {
                query["CompanyName"] = request.CompanyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonName))
            {
                query["LegalPersonName"] = request.LegalPersonName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationGroupName))
            {
                query["QualificationGroupName"] = request.QualificationGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseBySelf))
            {
                query["UseBySelf"] = request.UseBySelf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkOrderId))
            {
                query["WorkOrderId"] = request.WorkOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySmsQualificationRecord",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmsQualificationRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of SMS qualifications and their review details after you submit qualification applications. This operation supports filtered query.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>支持全量查询或条件查询：<list type="bullet">
        /// <item><description><b>全量查询</b>：查询您当前帐户下所有短信资质，无需传参。默认全量查询。</description></item>
        /// <item><description><b>条件查询</b>：支持根据资质名称、企业名称、法人姓名、审核状态、审核工单ID、资质用途进行查询，传入您希望筛选的参数即可。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>本接口用于查询资质及其审核信息，如果需要查询单个资质的具体信息（企业信息、法人信息、管理员信息），请调用<a href="~~QuerySingleSmsQualification~~">查询单个资质详情</a>接口。</description></item>
        /// <item><description>受短信签名实名制报备要求影响，当前资质审核工单量增长快速，审核时间可能会延长，请耐心等待，预计2个工作日内完成（审核工作时间：周一至周日 9:00~21:00，法定节假日顺延）。特殊情况可能延长审核时间，请耐心等待。</description></item>
        /// <item><description>如果资质未通过审核，审核备注<c>AuditRemark</c>会返回审核失败的原因，请参考<a href="~~2384377#a96cc318b94x1~~">审核失败的处理建议</a>，调用<a href="~~UpdateSmsQualification~~">修改短信资质</a>接口或在控制台<a href="https://dysms.console.aliyun.com/domestic/text/qualification">资质管理</a>页面修改资质信息后，重新发起审核。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsQualificationRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsQualificationRecordResponse
        /// </returns>
        public QuerySmsQualificationRecordResponse QuerySmsQualificationRecord(QuerySmsQualificationRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySmsQualificationRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of SMS qualifications and their review details after you submit qualification applications. This operation supports filtered query.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>支持全量查询或条件查询：<list type="bullet">
        /// <item><description><b>全量查询</b>：查询您当前帐户下所有短信资质，无需传参。默认全量查询。</description></item>
        /// <item><description><b>条件查询</b>：支持根据资质名称、企业名称、法人姓名、审核状态、审核工单ID、资质用途进行查询，传入您希望筛选的参数即可。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>本接口用于查询资质及其审核信息，如果需要查询单个资质的具体信息（企业信息、法人信息、管理员信息），请调用<a href="~~QuerySingleSmsQualification~~">查询单个资质详情</a>接口。</description></item>
        /// <item><description>受短信签名实名制报备要求影响，当前资质审核工单量增长快速，审核时间可能会延长，请耐心等待，预计2个工作日内完成（审核工作时间：周一至周日 9:00~21:00，法定节假日顺延）。特殊情况可能延长审核时间，请耐心等待。</description></item>
        /// <item><description>如果资质未通过审核，审核备注<c>AuditRemark</c>会返回审核失败的原因，请参考<a href="~~2384377#a96cc318b94x1~~">审核失败的处理建议</a>，调用<a href="~~UpdateSmsQualification~~">修改短信资质</a>接口或在控制台<a href="https://dysms.console.aliyun.com/domestic/text/qualification">资质管理</a>页面修改资质信息后，重新发起审核。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsQualificationRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsQualificationRecordResponse
        /// </returns>
        public async Task<QuerySmsQualificationRecordResponse> QuerySmsQualificationRecordAsync(QuerySmsQualificationRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySmsQualificationRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the review status of an SMS signature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>To comply with regulations from the Ministry of Industry and Information Technology (MIIT) and <a href="https://help.aliyun.com/document_detail/2806975.html">related requirements</a> from carriers, Alibaba Cloud has upgraded its SMS signature management APIs. We recommend using the new <a href="https://help.aliyun.com/document_detail/2807429.html">GetSmsSign - Query Signature Details</a> API, which returns more detailed information about signatures than this API.</description></item>
        /// <item><description>We typically review signatures within two hours of submission. The review service is available from 9:00 to 21:00, Monday to Sunday. Reviews may be delayed during public holidays. We recommend submitting your application before 18:00 for a timely review.</description></item>
        /// <item><description>If a signature is rejected, the response includes the review reason. For troubleshooting information, see <a href="https://help.aliyun.com/document_detail/65990.html">Troubleshooting Signature Review Failures</a>. You can then call the <a href="https://help.aliyun.com/document_detail/419287.html">ModifySmsTemplate</a> API or modify the SMS signature on the <a href="https://dysms.console.aliyun.com/domestic/text">Signature Management</a> page.</description></item>
        /// <item><description>This API queries the review details for a single signature by name. To query all signatures in your account, call the <a href="https://help.aliyun.com/document_detail/419288.html">QuerySmsSignList</a> API.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsSignResponse
        /// </returns>
        public QuerySmsSignResponse QuerySmsSignWithOptions(QuerySmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySmsSign",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmsSignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the review status of an SMS signature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>To comply with regulations from the Ministry of Industry and Information Technology (MIIT) and <a href="https://help.aliyun.com/document_detail/2806975.html">related requirements</a> from carriers, Alibaba Cloud has upgraded its SMS signature management APIs. We recommend using the new <a href="https://help.aliyun.com/document_detail/2807429.html">GetSmsSign - Query Signature Details</a> API, which returns more detailed information about signatures than this API.</description></item>
        /// <item><description>We typically review signatures within two hours of submission. The review service is available from 9:00 to 21:00, Monday to Sunday. Reviews may be delayed during public holidays. We recommend submitting your application before 18:00 for a timely review.</description></item>
        /// <item><description>If a signature is rejected, the response includes the review reason. For troubleshooting information, see <a href="https://help.aliyun.com/document_detail/65990.html">Troubleshooting Signature Review Failures</a>. You can then call the <a href="https://help.aliyun.com/document_detail/419287.html">ModifySmsTemplate</a> API or modify the SMS signature on the <a href="https://dysms.console.aliyun.com/domestic/text">Signature Management</a> page.</description></item>
        /// <item><description>This API queries the review details for a single signature by name. To query all signatures in your account, call the <a href="https://help.aliyun.com/document_detail/419288.html">QuerySmsSignList</a> API.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsSignResponse
        /// </returns>
        public async Task<QuerySmsSignResponse> QuerySmsSignWithOptionsAsync(QuerySmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySmsSign",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmsSignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the review status of an SMS signature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>To comply with regulations from the Ministry of Industry and Information Technology (MIIT) and <a href="https://help.aliyun.com/document_detail/2806975.html">related requirements</a> from carriers, Alibaba Cloud has upgraded its SMS signature management APIs. We recommend using the new <a href="https://help.aliyun.com/document_detail/2807429.html">GetSmsSign - Query Signature Details</a> API, which returns more detailed information about signatures than this API.</description></item>
        /// <item><description>We typically review signatures within two hours of submission. The review service is available from 9:00 to 21:00, Monday to Sunday. Reviews may be delayed during public holidays. We recommend submitting your application before 18:00 for a timely review.</description></item>
        /// <item><description>If a signature is rejected, the response includes the review reason. For troubleshooting information, see <a href="https://help.aliyun.com/document_detail/65990.html">Troubleshooting Signature Review Failures</a>. You can then call the <a href="https://help.aliyun.com/document_detail/419287.html">ModifySmsTemplate</a> API or modify the SMS signature on the <a href="https://dysms.console.aliyun.com/domestic/text">Signature Management</a> page.</description></item>
        /// <item><description>This API queries the review details for a single signature by name. To query all signatures in your account, call the <a href="https://help.aliyun.com/document_detail/419288.html">QuerySmsSignList</a> API.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsSignRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsSignResponse
        /// </returns>
        public QuerySmsSignResponse QuerySmsSign(QuerySmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySmsSignWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the review status of an SMS signature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>To comply with regulations from the Ministry of Industry and Information Technology (MIIT) and <a href="https://help.aliyun.com/document_detail/2806975.html">related requirements</a> from carriers, Alibaba Cloud has upgraded its SMS signature management APIs. We recommend using the new <a href="https://help.aliyun.com/document_detail/2807429.html">GetSmsSign - Query Signature Details</a> API, which returns more detailed information about signatures than this API.</description></item>
        /// <item><description>We typically review signatures within two hours of submission. The review service is available from 9:00 to 21:00, Monday to Sunday. Reviews may be delayed during public holidays. We recommend submitting your application before 18:00 for a timely review.</description></item>
        /// <item><description>If a signature is rejected, the response includes the review reason. For troubleshooting information, see <a href="https://help.aliyun.com/document_detail/65990.html">Troubleshooting Signature Review Failures</a>. You can then call the <a href="https://help.aliyun.com/document_detail/419287.html">ModifySmsTemplate</a> API or modify the SMS signature on the <a href="https://dysms.console.aliyun.com/domestic/text">Signature Management</a> page.</description></item>
        /// <item><description>This API queries the review details for a single signature by name. To query all signatures in your account, call the <a href="https://help.aliyun.com/document_detail/419288.html">QuerySmsSignList</a> API.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsSignRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsSignResponse
        /// </returns>
        public async Task<QuerySmsSignResponse> QuerySmsSignAsync(QuerySmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySmsSignWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call this operation to query all signatures under your account, including signature audit status, signature type, and signature name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the signature information that was <b>first created</b> or the <b>most recently approved</b> signature details under your current account. If you need to query more information such as application scenario content or files uploaded during application, you can call the <a href="~~GetSmsSign~~">GetSmsSign</a> operation to query the audit details of a single signature by signature name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsSignListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsSignListResponse
        /// </returns>
        public QuerySmsSignListResponse QuerySmsSignListWithOptions(QuerySmsSignListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "QuerySmsSignList",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmsSignListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call this operation to query all signatures under your account, including signature audit status, signature type, and signature name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the signature information that was <b>first created</b> or the <b>most recently approved</b> signature details under your current account. If you need to query more information such as application scenario content or files uploaded during application, you can call the <a href="~~GetSmsSign~~">GetSmsSign</a> operation to query the audit details of a single signature by signature name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsSignListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsSignListResponse
        /// </returns>
        public async Task<QuerySmsSignListResponse> QuerySmsSignListWithOptionsAsync(QuerySmsSignListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "QuerySmsSignList",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmsSignListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call this operation to query all signatures under your account, including signature audit status, signature type, and signature name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the signature information that was <b>first created</b> or the <b>most recently approved</b> signature details under your current account. If you need to query more information such as application scenario content or files uploaded during application, you can call the <a href="~~GetSmsSign~~">GetSmsSign</a> operation to query the audit details of a single signature by signature name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsSignListRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsSignListResponse
        /// </returns>
        public QuerySmsSignListResponse QuerySmsSignList(QuerySmsSignListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySmsSignListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call this operation to query all signatures under your account, including signature audit status, signature type, and signature name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the signature information that was <b>first created</b> or the <b>most recently approved</b> signature details under your current account. If you need to query more information such as application scenario content or files uploaded during application, you can call the <a href="~~GetSmsSign~~">GetSmsSign</a> operation to query the audit details of a single signature by signature name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsSignListRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsSignListResponse
        /// </returns>
        public async Task<QuerySmsSignListResponse> QuerySmsSignListAsync(QuerySmsSignListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySmsSignListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI QuerySmsTemplate is deprecated, please use Dysmsapi::2017-05-25::GetSmsTemplate instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API has been deprecated.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Alibaba Cloud has updated its template-related APIs to comply with regulatory and <a href="https://help.aliyun.com/document_detail/2806975.html">carrier requirements</a>. We recommend that you use the new <a href="https://help.aliyun.com/document_detail/2807433.html">GetSmsTemplate - Query template review details</a> API. The new API returns more detailed template information in its response.</description></item>
        /// <item><description>Review timeline: After you submit a template, Alibaba Cloud typically completes the review within two hours. Review hours are 9:00 to 21:00 (UTC+8) from Monday to Sunday. Reviews are postponed during public holidays. We recommend that you submit your templates before 18:00 (UTC+8).</description></item>
        /// <item><description>If a template fails review, the response includes the reason for the rejection. For more information, see <a href="https://help.aliyun.com/document_detail/65990.html">Suggestions for handling a failed review</a>. You can then call the <a href="https://help.aliyun.com/document_detail/419287.html">ModifySmsTemplate</a> API or modify the template on the <a href="https://dysms.console.aliyun.com/domestic/text/template">Template Management</a> page.</description></item>
        /// <item><description>QuerySmsTemplate queries the review details of a single template by its template code. To query the details of all templates in your account, call the <a href="https://help.aliyun.com/document_detail/419288.html">QuerySmsTemplateList</a> API.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsTemplateResponse
        /// </returns>
        [Obsolete("OpenAPI QuerySmsTemplate is deprecated, please use Dysmsapi::2017-05-25::GetSmsTemplate instead.")]
        // Deprecated
        public QuerySmsTemplateResponse QuerySmsTemplateWithOptions(QuerySmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySmsTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmsTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI QuerySmsTemplate is deprecated, please use Dysmsapi::2017-05-25::GetSmsTemplate instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API has been deprecated.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Alibaba Cloud has updated its template-related APIs to comply with regulatory and <a href="https://help.aliyun.com/document_detail/2806975.html">carrier requirements</a>. We recommend that you use the new <a href="https://help.aliyun.com/document_detail/2807433.html">GetSmsTemplate - Query template review details</a> API. The new API returns more detailed template information in its response.</description></item>
        /// <item><description>Review timeline: After you submit a template, Alibaba Cloud typically completes the review within two hours. Review hours are 9:00 to 21:00 (UTC+8) from Monday to Sunday. Reviews are postponed during public holidays. We recommend that you submit your templates before 18:00 (UTC+8).</description></item>
        /// <item><description>If a template fails review, the response includes the reason for the rejection. For more information, see <a href="https://help.aliyun.com/document_detail/65990.html">Suggestions for handling a failed review</a>. You can then call the <a href="https://help.aliyun.com/document_detail/419287.html">ModifySmsTemplate</a> API or modify the template on the <a href="https://dysms.console.aliyun.com/domestic/text/template">Template Management</a> page.</description></item>
        /// <item><description>QuerySmsTemplate queries the review details of a single template by its template code. To query the details of all templates in your account, call the <a href="https://help.aliyun.com/document_detail/419288.html">QuerySmsTemplateList</a> API.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsTemplateResponse
        /// </returns>
        [Obsolete("OpenAPI QuerySmsTemplate is deprecated, please use Dysmsapi::2017-05-25::GetSmsTemplate instead.")]
        // Deprecated
        public async Task<QuerySmsTemplateResponse> QuerySmsTemplateWithOptionsAsync(QuerySmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySmsTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmsTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI QuerySmsTemplate is deprecated, please use Dysmsapi::2017-05-25::GetSmsTemplate instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API has been deprecated.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Alibaba Cloud has updated its template-related APIs to comply with regulatory and <a href="https://help.aliyun.com/document_detail/2806975.html">carrier requirements</a>. We recommend that you use the new <a href="https://help.aliyun.com/document_detail/2807433.html">GetSmsTemplate - Query template review details</a> API. The new API returns more detailed template information in its response.</description></item>
        /// <item><description>Review timeline: After you submit a template, Alibaba Cloud typically completes the review within two hours. Review hours are 9:00 to 21:00 (UTC+8) from Monday to Sunday. Reviews are postponed during public holidays. We recommend that you submit your templates before 18:00 (UTC+8).</description></item>
        /// <item><description>If a template fails review, the response includes the reason for the rejection. For more information, see <a href="https://help.aliyun.com/document_detail/65990.html">Suggestions for handling a failed review</a>. You can then call the <a href="https://help.aliyun.com/document_detail/419287.html">ModifySmsTemplate</a> API or modify the template on the <a href="https://dysms.console.aliyun.com/domestic/text/template">Template Management</a> page.</description></item>
        /// <item><description>QuerySmsTemplate queries the review details of a single template by its template code. To query the details of all templates in your account, call the <a href="https://help.aliyun.com/document_detail/419288.html">QuerySmsTemplateList</a> API.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsTemplateResponse
        /// </returns>
        [Obsolete("OpenAPI QuerySmsTemplate is deprecated, please use Dysmsapi::2017-05-25::GetSmsTemplate instead.")]
        // Deprecated
        public QuerySmsTemplateResponse QuerySmsTemplate(QuerySmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySmsTemplateWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI QuerySmsTemplate is deprecated, please use Dysmsapi::2017-05-25::GetSmsTemplate instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API has been deprecated.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Alibaba Cloud has updated its template-related APIs to comply with regulatory and <a href="https://help.aliyun.com/document_detail/2806975.html">carrier requirements</a>. We recommend that you use the new <a href="https://help.aliyun.com/document_detail/2807433.html">GetSmsTemplate - Query template review details</a> API. The new API returns more detailed template information in its response.</description></item>
        /// <item><description>Review timeline: After you submit a template, Alibaba Cloud typically completes the review within two hours. Review hours are 9:00 to 21:00 (UTC+8) from Monday to Sunday. Reviews are postponed during public holidays. We recommend that you submit your templates before 18:00 (UTC+8).</description></item>
        /// <item><description>If a template fails review, the response includes the reason for the rejection. For more information, see <a href="https://help.aliyun.com/document_detail/65990.html">Suggestions for handling a failed review</a>. You can then call the <a href="https://help.aliyun.com/document_detail/419287.html">ModifySmsTemplate</a> API or modify the template on the <a href="https://dysms.console.aliyun.com/domestic/text/template">Template Management</a> page.</description></item>
        /// <item><description>QuerySmsTemplate queries the review details of a single template by its template code. To query the details of all templates in your account, call the <a href="https://help.aliyun.com/document_detail/419288.html">QuerySmsTemplateList</a> API.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsTemplateResponse
        /// </returns>
        [Obsolete("OpenAPI QuerySmsTemplate is deprecated, please use Dysmsapi::2017-05-25::GetSmsTemplate instead.")]
        // Deprecated
        public async Task<QuerySmsTemplateResponse> QuerySmsTemplateAsync(QuerySmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySmsTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call this operation to query all templates under your account. This way, you can view template details, including the template approval status, template type, and template content.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This operation queries the template details of all templates under your current account. To query more details such as the template variable content and the file information uploaded during application, you can call the <a href="~~GetSmsTemplate~~">GetSmsTemplate</a> operation to query the approval details of a single template by template code.</description></item>
        /// <item><description>You can also log on to the Short Message Service (SMS) console and view the template details of all templates under your current account on the <a href="https://dysms.console.aliyun.com/domestic/text/template">Template Management</a> page.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsTemplateListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsTemplateListResponse
        /// </returns>
        public QuerySmsTemplateListResponse QuerySmsTemplateListWithOptions(QuerySmsTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "QuerySmsTemplateList",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmsTemplateListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call this operation to query all templates under your account. This way, you can view template details, including the template approval status, template type, and template content.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This operation queries the template details of all templates under your current account. To query more details such as the template variable content and the file information uploaded during application, you can call the <a href="~~GetSmsTemplate~~">GetSmsTemplate</a> operation to query the approval details of a single template by template code.</description></item>
        /// <item><description>You can also log on to the Short Message Service (SMS) console and view the template details of all templates under your current account on the <a href="https://dysms.console.aliyun.com/domestic/text/template">Template Management</a> page.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsTemplateListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsTemplateListResponse
        /// </returns>
        public async Task<QuerySmsTemplateListResponse> QuerySmsTemplateListWithOptionsAsync(QuerySmsTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "QuerySmsTemplateList",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmsTemplateListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call this operation to query all templates under your account. This way, you can view template details, including the template approval status, template type, and template content.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This operation queries the template details of all templates under your current account. To query more details such as the template variable content and the file information uploaded during application, you can call the <a href="~~GetSmsTemplate~~">GetSmsTemplate</a> operation to query the approval details of a single template by template code.</description></item>
        /// <item><description>You can also log on to the Short Message Service (SMS) console and view the template details of all templates under your current account on the <a href="https://dysms.console.aliyun.com/domestic/text/template">Template Management</a> page.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsTemplateListRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsTemplateListResponse
        /// </returns>
        public QuerySmsTemplateListResponse QuerySmsTemplateList(QuerySmsTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySmsTemplateListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call this operation to query all templates under your account. This way, you can view template details, including the template approval status, template type, and template content.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This operation queries the template details of all templates under your current account. To query more details such as the template variable content and the file information uploaded during application, you can call the <a href="~~GetSmsTemplate~~">GetSmsTemplate</a> operation to query the approval details of a single template by template code.</description></item>
        /// <item><description>You can also log on to the Short Message Service (SMS) console and view the template details of all templates under your current account on the <a href="https://dysms.console.aliyun.com/domestic/text/template">Template Management</a> page.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsTemplateListRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsTemplateListResponse
        /// </returns>
        public async Task<QuerySmsTemplateListResponse> QuerySmsTemplateListAsync(QuerySmsTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySmsTemplateListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of one or more trademarks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the details of trademarks by using a list of trademark IDs.
        /// For example, you can obtain trademark IDs by calling signature query operations such as <c>QuerySmsSignList</c> or <c>GetSmsSign</c>. You can then use this operation to retrieve the details of each trademark.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// QuerySmsTrademarkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsTrademarkResponse
        /// </returns>
        public QuerySmsTrademarkResponse QuerySmsTrademarkWithOptions(QuerySmsTrademarkRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QuerySmsTrademarkShrinkRequest request = new QuerySmsTrademarkShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TrademarkIdList))
            {
                request.TrademarkIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TrademarkIdList, "TrademarkIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkIdListShrink))
            {
                query["TrademarkIdList"] = request.TrademarkIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySmsTrademark",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmsTrademarkResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of one or more trademarks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the details of trademarks by using a list of trademark IDs.
        /// For example, you can obtain trademark IDs by calling signature query operations such as <c>QuerySmsSignList</c> or <c>GetSmsSign</c>. You can then use this operation to retrieve the details of each trademark.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// QuerySmsTrademarkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsTrademarkResponse
        /// </returns>
        public async Task<QuerySmsTrademarkResponse> QuerySmsTrademarkWithOptionsAsync(QuerySmsTrademarkRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QuerySmsTrademarkShrinkRequest request = new QuerySmsTrademarkShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TrademarkIdList))
            {
                request.TrademarkIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TrademarkIdList, "TrademarkIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkIdListShrink))
            {
                query["TrademarkIdList"] = request.TrademarkIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySmsTrademark",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmsTrademarkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of one or more trademarks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the details of trademarks by using a list of trademark IDs.
        /// For example, you can obtain trademark IDs by calling signature query operations such as <c>QuerySmsSignList</c> or <c>GetSmsSign</c>. You can then use this operation to retrieve the details of each trademark.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsTrademarkRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsTrademarkResponse
        /// </returns>
        public QuerySmsTrademarkResponse QuerySmsTrademark(QuerySmsTrademarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySmsTrademarkWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of one or more trademarks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the details of trademarks by using a list of trademark IDs.
        /// For example, you can obtain trademark IDs by calling signature query operations such as <c>QuerySmsSignList</c> or <c>GetSmsSign</c>. You can then use this operation to retrieve the details of each trademark.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySmsTrademarkRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySmsTrademarkResponse
        /// </returns>
        public async Task<QuerySmsTrademarkResponse> QuerySmsTrademarkAsync(QuerySmsTrademarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySmsTrademarkWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>When applying for SMS qualification, the administrator\&quot;s phone number must be verified. Use this operation to obtain an SMS verification code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>After you receive the phone verification code, pass it to the <c>CertifyCode</c> parameter of the <a href="~~SubmitSmsQualification~~">SubmitSmsQualification</a> or <a href="~~UpdateSmsQualification~~">UpdateSmsQualification</a> operation.</description></item>
        /// <item><description>You can call the <a href="~~ValidPhoneCode~~">ValidPhoneCode</a> operation to verify whether the SMS verification code is correct.</description></item>
        /// <item><description>This operation is subject to <a href="~~44335#section-0wh-xn6-0t7~~">throttling</a>. Do not call it too frequently. For the same phone number, a maximum of 1 message per minute, 5 messages per hour, and 10 messages per day are supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RequiredPhoneCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RequiredPhoneCodeResponse
        /// </returns>
        public RequiredPhoneCodeResponse RequiredPhoneCodeWithOptions(RequiredPhoneCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNo))
            {
                query["PhoneNo"] = request.PhoneNo;
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
                Action = "RequiredPhoneCode",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RequiredPhoneCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>When applying for SMS qualification, the administrator\&quot;s phone number must be verified. Use this operation to obtain an SMS verification code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>After you receive the phone verification code, pass it to the <c>CertifyCode</c> parameter of the <a href="~~SubmitSmsQualification~~">SubmitSmsQualification</a> or <a href="~~UpdateSmsQualification~~">UpdateSmsQualification</a> operation.</description></item>
        /// <item><description>You can call the <a href="~~ValidPhoneCode~~">ValidPhoneCode</a> operation to verify whether the SMS verification code is correct.</description></item>
        /// <item><description>This operation is subject to <a href="~~44335#section-0wh-xn6-0t7~~">throttling</a>. Do not call it too frequently. For the same phone number, a maximum of 1 message per minute, 5 messages per hour, and 10 messages per day are supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RequiredPhoneCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RequiredPhoneCodeResponse
        /// </returns>
        public async Task<RequiredPhoneCodeResponse> RequiredPhoneCodeWithOptionsAsync(RequiredPhoneCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNo))
            {
                query["PhoneNo"] = request.PhoneNo;
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
                Action = "RequiredPhoneCode",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RequiredPhoneCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>When applying for SMS qualification, the administrator\&quot;s phone number must be verified. Use this operation to obtain an SMS verification code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>After you receive the phone verification code, pass it to the <c>CertifyCode</c> parameter of the <a href="~~SubmitSmsQualification~~">SubmitSmsQualification</a> or <a href="~~UpdateSmsQualification~~">UpdateSmsQualification</a> operation.</description></item>
        /// <item><description>You can call the <a href="~~ValidPhoneCode~~">ValidPhoneCode</a> operation to verify whether the SMS verification code is correct.</description></item>
        /// <item><description>This operation is subject to <a href="~~44335#section-0wh-xn6-0t7~~">throttling</a>. Do not call it too frequently. For the same phone number, a maximum of 1 message per minute, 5 messages per hour, and 10 messages per day are supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RequiredPhoneCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// RequiredPhoneCodeResponse
        /// </returns>
        public RequiredPhoneCodeResponse RequiredPhoneCode(RequiredPhoneCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RequiredPhoneCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>When applying for SMS qualification, the administrator\&quot;s phone number must be verified. Use this operation to obtain an SMS verification code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>After you receive the phone verification code, pass it to the <c>CertifyCode</c> parameter of the <a href="~~SubmitSmsQualification~~">SubmitSmsQualification</a> or <a href="~~UpdateSmsQualification~~">UpdateSmsQualification</a> operation.</description></item>
        /// <item><description>You can call the <a href="~~ValidPhoneCode~~">ValidPhoneCode</a> operation to verify whether the SMS verification code is correct.</description></item>
        /// <item><description>This operation is subject to <a href="~~44335#section-0wh-xn6-0t7~~">throttling</a>. Do not call it too frequently. For the same phone number, a maximum of 1 message per minute, 5 messages per hour, and 10 messages per day are supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RequiredPhoneCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// RequiredPhoneCodeResponse
        /// </returns>
        public async Task<RequiredPhoneCodeResponse> RequiredPhoneCodeAsync(RequiredPhoneCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RequiredPhoneCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends card SMS messages in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Sending card SMS messages is a billable operation. You are not charged if a card SMS message fails to be sent or rendered. For more information, see <a href="https://help.aliyun.com/document_detail/437951.html">Multimedia SMS pricing</a>.</description></item>
        /// <item><description>The card SMS feature is currently in the internal invitation phase. Contact your Alibaba Cloud business manager to apply for activation, or contact <a href="https://help.aliyun.com/document_detail/464625.html?spm=a2c4g.11186623.0.0.213219fcSn2Ykj#section-81n-72q-ybm">Alibaba Cloud pre-sales consulting</a>.</description></item>
        /// <item><description>We recommend that you set the timeout period for card SMS messages to a value greater than or equal to 3 seconds. If a timeout failure occurs, we recommend that you check the delivery status before deciding whether to retry. We also recommend that you do not enable SDK retry logic when calling this operation; otherwise, multiple sending attempts may occur. For more information about timeout and retry settings, see <a href="https://help.aliyun.com/document_detail/262079.html">Timeout mechanism</a> and <a href="https://help.aliyun.com/document_detail/262080.html">Retry mechanism</a>.</description></item>
        /// <item><description>Domestic SMS, international SMS, and multimedia SMS do not currently support idempotency. Implement idempotency control to prevent duplicate operations caused by multiple retries.</description></item>
        /// <item><description>Before you send a card SMS message, you must add and obtain approval for a card SMS template. When this operation is called to send an SMS message, the system checks whether the phone number supports card SMS messages. If the phone number does not support card SMS messages, you can configure whether to accept fallback to digital SMS or text SMS in the operation to improve the delivery rate.</description></item>
        /// <item><description>When you send card SMS messages in batches, each phone number can use a different signature and a different fallback. In a single request, you can send card SMS messages to a maximum of 100 phone numbers.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit per user for this operation is 1,000 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call this operation in a reasonable manner.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendBatchCardSmsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendBatchCardSmsResponse
        /// </returns>
        public SendBatchCardSmsResponse SendBatchCardSmsWithOptions(SendBatchCardSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateCode))
            {
                query["CardTemplateCode"] = request.CardTemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateParamJson))
            {
                query["CardTemplateParamJson"] = request.CardTemplateParamJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalTemplateCode))
            {
                query["DigitalTemplateCode"] = request.DigitalTemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalTemplateParamJson))
            {
                query["DigitalTemplateParamJson"] = request.DigitalTemplateParamJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallbackType))
            {
                query["FallbackType"] = request.FallbackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumberJson))
            {
                query["PhoneNumberJson"] = request.PhoneNumberJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignNameJson))
            {
                query["SignNameJson"] = request.SignNameJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateCode))
            {
                query["SmsTemplateCode"] = request.SmsTemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateParamJson))
            {
                query["SmsTemplateParamJson"] = request.SmsTemplateParamJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsUpExtendCodeJson))
            {
                query["SmsUpExtendCodeJson"] = request.SmsUpExtendCodeJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParamJson))
            {
                query["TemplateParamJson"] = request.TemplateParamJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendBatchCardSms",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendBatchCardSmsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends card SMS messages in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Sending card SMS messages is a billable operation. You are not charged if a card SMS message fails to be sent or rendered. For more information, see <a href="https://help.aliyun.com/document_detail/437951.html">Multimedia SMS pricing</a>.</description></item>
        /// <item><description>The card SMS feature is currently in the internal invitation phase. Contact your Alibaba Cloud business manager to apply for activation, or contact <a href="https://help.aliyun.com/document_detail/464625.html?spm=a2c4g.11186623.0.0.213219fcSn2Ykj#section-81n-72q-ybm">Alibaba Cloud pre-sales consulting</a>.</description></item>
        /// <item><description>We recommend that you set the timeout period for card SMS messages to a value greater than or equal to 3 seconds. If a timeout failure occurs, we recommend that you check the delivery status before deciding whether to retry. We also recommend that you do not enable SDK retry logic when calling this operation; otherwise, multiple sending attempts may occur. For more information about timeout and retry settings, see <a href="https://help.aliyun.com/document_detail/262079.html">Timeout mechanism</a> and <a href="https://help.aliyun.com/document_detail/262080.html">Retry mechanism</a>.</description></item>
        /// <item><description>Domestic SMS, international SMS, and multimedia SMS do not currently support idempotency. Implement idempotency control to prevent duplicate operations caused by multiple retries.</description></item>
        /// <item><description>Before you send a card SMS message, you must add and obtain approval for a card SMS template. When this operation is called to send an SMS message, the system checks whether the phone number supports card SMS messages. If the phone number does not support card SMS messages, you can configure whether to accept fallback to digital SMS or text SMS in the operation to improve the delivery rate.</description></item>
        /// <item><description>When you send card SMS messages in batches, each phone number can use a different signature and a different fallback. In a single request, you can send card SMS messages to a maximum of 100 phone numbers.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit per user for this operation is 1,000 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call this operation in a reasonable manner.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendBatchCardSmsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendBatchCardSmsResponse
        /// </returns>
        public async Task<SendBatchCardSmsResponse> SendBatchCardSmsWithOptionsAsync(SendBatchCardSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateCode))
            {
                query["CardTemplateCode"] = request.CardTemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateParamJson))
            {
                query["CardTemplateParamJson"] = request.CardTemplateParamJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalTemplateCode))
            {
                query["DigitalTemplateCode"] = request.DigitalTemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalTemplateParamJson))
            {
                query["DigitalTemplateParamJson"] = request.DigitalTemplateParamJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallbackType))
            {
                query["FallbackType"] = request.FallbackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumberJson))
            {
                query["PhoneNumberJson"] = request.PhoneNumberJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignNameJson))
            {
                query["SignNameJson"] = request.SignNameJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateCode))
            {
                query["SmsTemplateCode"] = request.SmsTemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateParamJson))
            {
                query["SmsTemplateParamJson"] = request.SmsTemplateParamJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsUpExtendCodeJson))
            {
                query["SmsUpExtendCodeJson"] = request.SmsUpExtendCodeJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParamJson))
            {
                query["TemplateParamJson"] = request.TemplateParamJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendBatchCardSms",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendBatchCardSmsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends card SMS messages in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Sending card SMS messages is a billable operation. You are not charged if a card SMS message fails to be sent or rendered. For more information, see <a href="https://help.aliyun.com/document_detail/437951.html">Multimedia SMS pricing</a>.</description></item>
        /// <item><description>The card SMS feature is currently in the internal invitation phase. Contact your Alibaba Cloud business manager to apply for activation, or contact <a href="https://help.aliyun.com/document_detail/464625.html?spm=a2c4g.11186623.0.0.213219fcSn2Ykj#section-81n-72q-ybm">Alibaba Cloud pre-sales consulting</a>.</description></item>
        /// <item><description>We recommend that you set the timeout period for card SMS messages to a value greater than or equal to 3 seconds. If a timeout failure occurs, we recommend that you check the delivery status before deciding whether to retry. We also recommend that you do not enable SDK retry logic when calling this operation; otherwise, multiple sending attempts may occur. For more information about timeout and retry settings, see <a href="https://help.aliyun.com/document_detail/262079.html">Timeout mechanism</a> and <a href="https://help.aliyun.com/document_detail/262080.html">Retry mechanism</a>.</description></item>
        /// <item><description>Domestic SMS, international SMS, and multimedia SMS do not currently support idempotency. Implement idempotency control to prevent duplicate operations caused by multiple retries.</description></item>
        /// <item><description>Before you send a card SMS message, you must add and obtain approval for a card SMS template. When this operation is called to send an SMS message, the system checks whether the phone number supports card SMS messages. If the phone number does not support card SMS messages, you can configure whether to accept fallback to digital SMS or text SMS in the operation to improve the delivery rate.</description></item>
        /// <item><description>When you send card SMS messages in batches, each phone number can use a different signature and a different fallback. In a single request, you can send card SMS messages to a maximum of 100 phone numbers.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit per user for this operation is 1,000 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call this operation in a reasonable manner.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendBatchCardSmsRequest
        /// </param>
        /// 
        /// <returns>
        /// SendBatchCardSmsResponse
        /// </returns>
        public SendBatchCardSmsResponse SendBatchCardSms(SendBatchCardSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendBatchCardSmsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends card SMS messages in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Sending card SMS messages is a billable operation. You are not charged if a card SMS message fails to be sent or rendered. For more information, see <a href="https://help.aliyun.com/document_detail/437951.html">Multimedia SMS pricing</a>.</description></item>
        /// <item><description>The card SMS feature is currently in the internal invitation phase. Contact your Alibaba Cloud business manager to apply for activation, or contact <a href="https://help.aliyun.com/document_detail/464625.html?spm=a2c4g.11186623.0.0.213219fcSn2Ykj#section-81n-72q-ybm">Alibaba Cloud pre-sales consulting</a>.</description></item>
        /// <item><description>We recommend that you set the timeout period for card SMS messages to a value greater than or equal to 3 seconds. If a timeout failure occurs, we recommend that you check the delivery status before deciding whether to retry. We also recommend that you do not enable SDK retry logic when calling this operation; otherwise, multiple sending attempts may occur. For more information about timeout and retry settings, see <a href="https://help.aliyun.com/document_detail/262079.html">Timeout mechanism</a> and <a href="https://help.aliyun.com/document_detail/262080.html">Retry mechanism</a>.</description></item>
        /// <item><description>Domestic SMS, international SMS, and multimedia SMS do not currently support idempotency. Implement idempotency control to prevent duplicate operations caused by multiple retries.</description></item>
        /// <item><description>Before you send a card SMS message, you must add and obtain approval for a card SMS template. When this operation is called to send an SMS message, the system checks whether the phone number supports card SMS messages. If the phone number does not support card SMS messages, you can configure whether to accept fallback to digital SMS or text SMS in the operation to improve the delivery rate.</description></item>
        /// <item><description>When you send card SMS messages in batches, each phone number can use a different signature and a different fallback. In a single request, you can send card SMS messages to a maximum of 100 phone numbers.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit per user for this operation is 1,000 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call this operation in a reasonable manner.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendBatchCardSmsRequest
        /// </param>
        /// 
        /// <returns>
        /// SendBatchCardSmsResponse
        /// </returns>
        public async Task<SendBatchCardSmsResponse> SendBatchCardSmsAsync(SendBatchCardSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendBatchCardSmsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation sends messages to different phone numbers using a single template, with different signatures and template variables for each recipient.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Basic information</h3>
        /// <list type="bullet">
        /// <item><description>You can send messages to a maximum of 100 phone numbers in a single call.</description></item>
        /// <item><description>The global <a href="https://help.aliyun.com/document_detail/419270.html">endpoint</a> is <c>dysmsapi.aliyuncs.com</c>. For a list of region-specific endpoints, see <a href="https://help.aliyun.com/document_detail/419270.html">Endpoints</a>.</description></item>
        /// </list>
        /// <h3>API calls</h3>
        /// <list type="bullet">
        /// <item><description>We recommend calling this operation using an SDK. For more information, see <a href="https://help.aliyun.com/document_detail/2841024.html">Make your first API call</a>.</description></item>
        /// <item><description>To send messages from the console, see <a href="https://help.aliyun.com/document_detail/108266.html">Send group messages</a>.</description></item>
        /// <item><description>To build your own API requests, see <a href="https://help.aliyun.com/document_detail/2593177.html">V3 request body and signature mechanism</a>.</description></item>
        /// </list>
        /// <h3>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>For domestic SMS, we recommend setting the timeout period to 1 second or longer. If a timeout occurs, check the delivery receipt status before you retry the request. For more information about timeout and retry settings, see <a href="https://help.aliyun.com/document_detail/262079.html">timeout mechanism</a> and <a href="https://help.aliyun.com/document_detail/262080.html">retry mechanism</a>.</description></item>
        /// <item><description>This operation does not support idempotence for domestic SMS, international SMS, or Multimedia Messaging Service (MMS) messages. You must implement your own idempotence controls to prevent duplicate operations caused by multiple retries.</description></item>
        /// <item><description>This is a billable operation. For domestic SMS, you are charged based on the delivery receipt status from the carrier. You are not charged for messages that are successfully submitted but fail carrier delivery. For more information, see <a href="https://help.aliyun.com/document_detail/44340.html">Billing overview</a>.<remarks>
        /// <para>Warning: 
        /// Batch message delivery may be delayed due to system capacity limits. For time-sensitive messages, such as verification codes or alert notifications, use the SendSms operation to send messages individually.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The Queries Per Second (QPS) limit for a single user is 5,000. Calls that exceed this limit are throttled. Plan your usage accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendBatchSmsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendBatchSmsResponse
        /// </returns>
        public SendBatchSmsResponse SendBatchSmsWithOptions(SendBatchSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumberJson))
            {
                body["PhoneNumberJson"] = request.PhoneNumberJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignNameJson))
            {
                body["SignNameJson"] = request.SignNameJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsUpExtendCodeJson))
            {
                body["SmsUpExtendCodeJson"] = request.SmsUpExtendCodeJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParamJson))
            {
                body["TemplateParamJson"] = request.TemplateParamJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendBatchSms",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendBatchSmsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation sends messages to different phone numbers using a single template, with different signatures and template variables for each recipient.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Basic information</h3>
        /// <list type="bullet">
        /// <item><description>You can send messages to a maximum of 100 phone numbers in a single call.</description></item>
        /// <item><description>The global <a href="https://help.aliyun.com/document_detail/419270.html">endpoint</a> is <c>dysmsapi.aliyuncs.com</c>. For a list of region-specific endpoints, see <a href="https://help.aliyun.com/document_detail/419270.html">Endpoints</a>.</description></item>
        /// </list>
        /// <h3>API calls</h3>
        /// <list type="bullet">
        /// <item><description>We recommend calling this operation using an SDK. For more information, see <a href="https://help.aliyun.com/document_detail/2841024.html">Make your first API call</a>.</description></item>
        /// <item><description>To send messages from the console, see <a href="https://help.aliyun.com/document_detail/108266.html">Send group messages</a>.</description></item>
        /// <item><description>To build your own API requests, see <a href="https://help.aliyun.com/document_detail/2593177.html">V3 request body and signature mechanism</a>.</description></item>
        /// </list>
        /// <h3>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>For domestic SMS, we recommend setting the timeout period to 1 second or longer. If a timeout occurs, check the delivery receipt status before you retry the request. For more information about timeout and retry settings, see <a href="https://help.aliyun.com/document_detail/262079.html">timeout mechanism</a> and <a href="https://help.aliyun.com/document_detail/262080.html">retry mechanism</a>.</description></item>
        /// <item><description>This operation does not support idempotence for domestic SMS, international SMS, or Multimedia Messaging Service (MMS) messages. You must implement your own idempotence controls to prevent duplicate operations caused by multiple retries.</description></item>
        /// <item><description>This is a billable operation. For domestic SMS, you are charged based on the delivery receipt status from the carrier. You are not charged for messages that are successfully submitted but fail carrier delivery. For more information, see <a href="https://help.aliyun.com/document_detail/44340.html">Billing overview</a>.<remarks>
        /// <para>Warning: 
        /// Batch message delivery may be delayed due to system capacity limits. For time-sensitive messages, such as verification codes or alert notifications, use the SendSms operation to send messages individually.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The Queries Per Second (QPS) limit for a single user is 5,000. Calls that exceed this limit are throttled. Plan your usage accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendBatchSmsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendBatchSmsResponse
        /// </returns>
        public async Task<SendBatchSmsResponse> SendBatchSmsWithOptionsAsync(SendBatchSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumberJson))
            {
                body["PhoneNumberJson"] = request.PhoneNumberJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignNameJson))
            {
                body["SignNameJson"] = request.SignNameJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsUpExtendCodeJson))
            {
                body["SmsUpExtendCodeJson"] = request.SmsUpExtendCodeJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParamJson))
            {
                body["TemplateParamJson"] = request.TemplateParamJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendBatchSms",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendBatchSmsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation sends messages to different phone numbers using a single template, with different signatures and template variables for each recipient.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Basic information</h3>
        /// <list type="bullet">
        /// <item><description>You can send messages to a maximum of 100 phone numbers in a single call.</description></item>
        /// <item><description>The global <a href="https://help.aliyun.com/document_detail/419270.html">endpoint</a> is <c>dysmsapi.aliyuncs.com</c>. For a list of region-specific endpoints, see <a href="https://help.aliyun.com/document_detail/419270.html">Endpoints</a>.</description></item>
        /// </list>
        /// <h3>API calls</h3>
        /// <list type="bullet">
        /// <item><description>We recommend calling this operation using an SDK. For more information, see <a href="https://help.aliyun.com/document_detail/2841024.html">Make your first API call</a>.</description></item>
        /// <item><description>To send messages from the console, see <a href="https://help.aliyun.com/document_detail/108266.html">Send group messages</a>.</description></item>
        /// <item><description>To build your own API requests, see <a href="https://help.aliyun.com/document_detail/2593177.html">V3 request body and signature mechanism</a>.</description></item>
        /// </list>
        /// <h3>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>For domestic SMS, we recommend setting the timeout period to 1 second or longer. If a timeout occurs, check the delivery receipt status before you retry the request. For more information about timeout and retry settings, see <a href="https://help.aliyun.com/document_detail/262079.html">timeout mechanism</a> and <a href="https://help.aliyun.com/document_detail/262080.html">retry mechanism</a>.</description></item>
        /// <item><description>This operation does not support idempotence for domestic SMS, international SMS, or Multimedia Messaging Service (MMS) messages. You must implement your own idempotence controls to prevent duplicate operations caused by multiple retries.</description></item>
        /// <item><description>This is a billable operation. For domestic SMS, you are charged based on the delivery receipt status from the carrier. You are not charged for messages that are successfully submitted but fail carrier delivery. For more information, see <a href="https://help.aliyun.com/document_detail/44340.html">Billing overview</a>.<remarks>
        /// <para>Warning: 
        /// Batch message delivery may be delayed due to system capacity limits. For time-sensitive messages, such as verification codes or alert notifications, use the SendSms operation to send messages individually.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The Queries Per Second (QPS) limit for a single user is 5,000. Calls that exceed this limit are throttled. Plan your usage accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendBatchSmsRequest
        /// </param>
        /// 
        /// <returns>
        /// SendBatchSmsResponse
        /// </returns>
        public SendBatchSmsResponse SendBatchSms(SendBatchSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendBatchSmsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation sends messages to different phone numbers using a single template, with different signatures and template variables for each recipient.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Basic information</h3>
        /// <list type="bullet">
        /// <item><description>You can send messages to a maximum of 100 phone numbers in a single call.</description></item>
        /// <item><description>The global <a href="https://help.aliyun.com/document_detail/419270.html">endpoint</a> is <c>dysmsapi.aliyuncs.com</c>. For a list of region-specific endpoints, see <a href="https://help.aliyun.com/document_detail/419270.html">Endpoints</a>.</description></item>
        /// </list>
        /// <h3>API calls</h3>
        /// <list type="bullet">
        /// <item><description>We recommend calling this operation using an SDK. For more information, see <a href="https://help.aliyun.com/document_detail/2841024.html">Make your first API call</a>.</description></item>
        /// <item><description>To send messages from the console, see <a href="https://help.aliyun.com/document_detail/108266.html">Send group messages</a>.</description></item>
        /// <item><description>To build your own API requests, see <a href="https://help.aliyun.com/document_detail/2593177.html">V3 request body and signature mechanism</a>.</description></item>
        /// </list>
        /// <h3>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>For domestic SMS, we recommend setting the timeout period to 1 second or longer. If a timeout occurs, check the delivery receipt status before you retry the request. For more information about timeout and retry settings, see <a href="https://help.aliyun.com/document_detail/262079.html">timeout mechanism</a> and <a href="https://help.aliyun.com/document_detail/262080.html">retry mechanism</a>.</description></item>
        /// <item><description>This operation does not support idempotence for domestic SMS, international SMS, or Multimedia Messaging Service (MMS) messages. You must implement your own idempotence controls to prevent duplicate operations caused by multiple retries.</description></item>
        /// <item><description>This is a billable operation. For domestic SMS, you are charged based on the delivery receipt status from the carrier. You are not charged for messages that are successfully submitted but fail carrier delivery. For more information, see <a href="https://help.aliyun.com/document_detail/44340.html">Billing overview</a>.<remarks>
        /// <para>Warning: 
        /// Batch message delivery may be delayed due to system capacity limits. For time-sensitive messages, such as verification codes or alert notifications, use the SendSms operation to send messages individually.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The Queries Per Second (QPS) limit for a single user is 5,000. Calls that exceed this limit are throttled. Plan your usage accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendBatchSmsRequest
        /// </param>
        /// 
        /// <returns>
        /// SendBatchSmsResponse
        /// </returns>
        public async Task<SendBatchSmsResponse> SendBatchSmsAsync(SendBatchSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendBatchSmsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a card message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>发送卡片短信为计费接口，卡片短信发送失败或渲染失败时不计费，详情请参见<a href="https://help.aliyun.com/document_detail/437951.html">多媒体短信定价</a>。</description></item>
        /// <item><description>目前卡片短信在内部邀约阶段，请联系您的阿里云商务经理申请开通或联系<a href="https://help.aliyun.com/document_detail/464625.html?spm=a2c4g.11186623.0.0.213219fcSn2Ykj#section-81n-72q-ybm">阿里云售前咨询</a>。</description></item>
        /// <item><description>卡片短信超时时间建议设置为≥3S；发生超时失败的情况时，建议查看回执状态后再判断是否重试。同时建议您在调用此接口时，不要开启SDK重试逻辑，否则可能会造成多次发送的情况。超时和重试的相关设置，请参见<a href="https://help.aliyun.com/document_detail/262079.html">超时机制</a>、<a href="https://help.aliyun.com/document_detail/262080.html">重试机制</a>。</description></item>
        /// <item><description>国内短信、国际短信及多媒体短信目前均不支持幂等的能力，请您做好幂等控制，防止因多次重试而导致的重复操作问题。</description></item>
        /// <item><description>发送卡片短信前需添加卡片短信模板且模板审核通过。本接口在发送短信时，会校验号码是否支持卡片短信。如果该手机号不支持发送卡片短信，可在接口中设置是否接受数字短信和文本短信的回落，提升发送的触达率。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为1000次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendCardSmsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendCardSmsResponse
        /// </returns>
        public SendCardSmsResponse SendCardSmsWithOptions(SendCardSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardObjects))
            {
                query["CardObjects"] = request.CardObjects;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateCode))
            {
                query["CardTemplateCode"] = request.CardTemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalTemplateCode))
            {
                query["DigitalTemplateCode"] = request.DigitalTemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalTemplateParam))
            {
                query["DigitalTemplateParam"] = request.DigitalTemplateParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallbackType))
            {
                query["FallbackType"] = request.FallbackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateCode))
            {
                query["SmsTemplateCode"] = request.SmsTemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateParam))
            {
                query["SmsTemplateParam"] = request.SmsTemplateParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsUpExtendCode))
            {
                query["SmsUpExtendCode"] = request.SmsUpExtendCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParam))
            {
                query["TemplateParam"] = request.TemplateParam;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendCardSms",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendCardSmsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a card message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>发送卡片短信为计费接口，卡片短信发送失败或渲染失败时不计费，详情请参见<a href="https://help.aliyun.com/document_detail/437951.html">多媒体短信定价</a>。</description></item>
        /// <item><description>目前卡片短信在内部邀约阶段，请联系您的阿里云商务经理申请开通或联系<a href="https://help.aliyun.com/document_detail/464625.html?spm=a2c4g.11186623.0.0.213219fcSn2Ykj#section-81n-72q-ybm">阿里云售前咨询</a>。</description></item>
        /// <item><description>卡片短信超时时间建议设置为≥3S；发生超时失败的情况时，建议查看回执状态后再判断是否重试。同时建议您在调用此接口时，不要开启SDK重试逻辑，否则可能会造成多次发送的情况。超时和重试的相关设置，请参见<a href="https://help.aliyun.com/document_detail/262079.html">超时机制</a>、<a href="https://help.aliyun.com/document_detail/262080.html">重试机制</a>。</description></item>
        /// <item><description>国内短信、国际短信及多媒体短信目前均不支持幂等的能力，请您做好幂等控制，防止因多次重试而导致的重复操作问题。</description></item>
        /// <item><description>发送卡片短信前需添加卡片短信模板且模板审核通过。本接口在发送短信时，会校验号码是否支持卡片短信。如果该手机号不支持发送卡片短信，可在接口中设置是否接受数字短信和文本短信的回落，提升发送的触达率。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为1000次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendCardSmsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendCardSmsResponse
        /// </returns>
        public async Task<SendCardSmsResponse> SendCardSmsWithOptionsAsync(SendCardSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardObjects))
            {
                query["CardObjects"] = request.CardObjects;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateCode))
            {
                query["CardTemplateCode"] = request.CardTemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalTemplateCode))
            {
                query["DigitalTemplateCode"] = request.DigitalTemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalTemplateParam))
            {
                query["DigitalTemplateParam"] = request.DigitalTemplateParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallbackType))
            {
                query["FallbackType"] = request.FallbackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateCode))
            {
                query["SmsTemplateCode"] = request.SmsTemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateParam))
            {
                query["SmsTemplateParam"] = request.SmsTemplateParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsUpExtendCode))
            {
                query["SmsUpExtendCode"] = request.SmsUpExtendCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParam))
            {
                query["TemplateParam"] = request.TemplateParam;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendCardSms",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendCardSmsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a card message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>发送卡片短信为计费接口，卡片短信发送失败或渲染失败时不计费，详情请参见<a href="https://help.aliyun.com/document_detail/437951.html">多媒体短信定价</a>。</description></item>
        /// <item><description>目前卡片短信在内部邀约阶段，请联系您的阿里云商务经理申请开通或联系<a href="https://help.aliyun.com/document_detail/464625.html?spm=a2c4g.11186623.0.0.213219fcSn2Ykj#section-81n-72q-ybm">阿里云售前咨询</a>。</description></item>
        /// <item><description>卡片短信超时时间建议设置为≥3S；发生超时失败的情况时，建议查看回执状态后再判断是否重试。同时建议您在调用此接口时，不要开启SDK重试逻辑，否则可能会造成多次发送的情况。超时和重试的相关设置，请参见<a href="https://help.aliyun.com/document_detail/262079.html">超时机制</a>、<a href="https://help.aliyun.com/document_detail/262080.html">重试机制</a>。</description></item>
        /// <item><description>国内短信、国际短信及多媒体短信目前均不支持幂等的能力，请您做好幂等控制，防止因多次重试而导致的重复操作问题。</description></item>
        /// <item><description>发送卡片短信前需添加卡片短信模板且模板审核通过。本接口在发送短信时，会校验号码是否支持卡片短信。如果该手机号不支持发送卡片短信，可在接口中设置是否接受数字短信和文本短信的回落，提升发送的触达率。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为1000次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendCardSmsRequest
        /// </param>
        /// 
        /// <returns>
        /// SendCardSmsResponse
        /// </returns>
        public SendCardSmsResponse SendCardSms(SendCardSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendCardSmsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a card message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>发送卡片短信为计费接口，卡片短信发送失败或渲染失败时不计费，详情请参见<a href="https://help.aliyun.com/document_detail/437951.html">多媒体短信定价</a>。</description></item>
        /// <item><description>目前卡片短信在内部邀约阶段，请联系您的阿里云商务经理申请开通或联系<a href="https://help.aliyun.com/document_detail/464625.html?spm=a2c4g.11186623.0.0.213219fcSn2Ykj#section-81n-72q-ybm">阿里云售前咨询</a>。</description></item>
        /// <item><description>卡片短信超时时间建议设置为≥3S；发生超时失败的情况时，建议查看回执状态后再判断是否重试。同时建议您在调用此接口时，不要开启SDK重试逻辑，否则可能会造成多次发送的情况。超时和重试的相关设置，请参见<a href="https://help.aliyun.com/document_detail/262079.html">超时机制</a>、<a href="https://help.aliyun.com/document_detail/262080.html">重试机制</a>。</description></item>
        /// <item><description>国内短信、国际短信及多媒体短信目前均不支持幂等的能力，请您做好幂等控制，防止因多次重试而导致的重复操作问题。</description></item>
        /// <item><description>发送卡片短信前需添加卡片短信模板且模板审核通过。本接口在发送短信时，会校验号码是否支持卡片短信。如果该手机号不支持发送卡片短信，可在接口中设置是否接受数字短信和文本短信的回落，提升发送的触达率。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为1000次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendCardSmsRequest
        /// </param>
        /// 
        /// <returns>
        /// SendCardSmsResponse
        /// </returns>
        public async Task<SendCardSmsResponse> SendCardSmsAsync(SendCardSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendCardSmsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送物流短信</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendLogisticsSmsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendLogisticsSmsResponse
        /// </returns>
        public SendLogisticsSmsResponse SendLogisticsSmsWithOptions(SendLogisticsSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpressCompanyCode))
            {
                query["ExpressCompanyCode"] = request.ExpressCompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MailNo))
            {
                query["MailNo"] = request.MailNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformCompanyCode))
            {
                query["PlatformCompanyCode"] = request.PlatformCompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParam))
            {
                query["TemplateParam"] = request.TemplateParam;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendLogisticsSms",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendLogisticsSmsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送物流短信</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendLogisticsSmsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendLogisticsSmsResponse
        /// </returns>
        public async Task<SendLogisticsSmsResponse> SendLogisticsSmsWithOptionsAsync(SendLogisticsSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpressCompanyCode))
            {
                query["ExpressCompanyCode"] = request.ExpressCompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MailNo))
            {
                query["MailNo"] = request.MailNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformCompanyCode))
            {
                query["PlatformCompanyCode"] = request.PlatformCompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParam))
            {
                query["TemplateParam"] = request.TemplateParam;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendLogisticsSms",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendLogisticsSmsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送物流短信</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendLogisticsSmsRequest
        /// </param>
        /// 
        /// <returns>
        /// SendLogisticsSmsResponse
        /// </returns>
        public SendLogisticsSmsResponse SendLogisticsSms(SendLogisticsSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendLogisticsSmsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送物流短信</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendLogisticsSmsRequest
        /// </param>
        /// 
        /// <returns>
        /// SendLogisticsSmsResponse
        /// </returns>
        public async Task<SendLogisticsSmsResponse> SendLogisticsSmsAsync(SendLogisticsSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendLogisticsSmsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>5G消息首次下行</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendRCSRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendRCSResponse
        /// </returns>
        public SendRCSResponse SendRCSWithOptions(SendRCSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumbers))
            {
                query["PhoneNumbers"] = request.PhoneNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParam))
            {
                query["TemplateParam"] = request.TemplateParam;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendRCS",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendRCSResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>5G消息首次下行</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendRCSRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendRCSResponse
        /// </returns>
        public async Task<SendRCSResponse> SendRCSWithOptionsAsync(SendRCSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumbers))
            {
                query["PhoneNumbers"] = request.PhoneNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParam))
            {
                query["TemplateParam"] = request.TemplateParam;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendRCS",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendRCSResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>5G消息首次下行</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendRCSRequest
        /// </param>
        /// 
        /// <returns>
        /// SendRCSResponse
        /// </returns>
        public SendRCSResponse SendRCS(SendRCSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendRCSWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>5G消息首次下行</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendRCSRequest
        /// </param>
        /// 
        /// <returns>
        /// SendRCSResponse
        /// </returns>
        public async Task<SendRCSResponse> SendRCSAsync(SendRCSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendRCSWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>5G消息交互下行</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendRCSReplyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendRCSReplyResponse
        /// </returns>
        public SendRCSReplyResponse SendRCSReplyWithOptions(SendRCSReplyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InReplyToRcsID))
            {
                query["InReplyToRcsID"] = request.InReplyToRcsID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumbers))
            {
                query["PhoneNumbers"] = request.PhoneNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParam))
            {
                query["TemplateParam"] = request.TemplateParam;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendRCSReply",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendRCSReplyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>5G消息交互下行</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendRCSReplyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendRCSReplyResponse
        /// </returns>
        public async Task<SendRCSReplyResponse> SendRCSReplyWithOptionsAsync(SendRCSReplyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InReplyToRcsID))
            {
                query["InReplyToRcsID"] = request.InReplyToRcsID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumbers))
            {
                query["PhoneNumbers"] = request.PhoneNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParam))
            {
                query["TemplateParam"] = request.TemplateParam;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendRCSReply",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendRCSReplyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>5G消息交互下行</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendRCSReplyRequest
        /// </param>
        /// 
        /// <returns>
        /// SendRCSReplyResponse
        /// </returns>
        public SendRCSReplyResponse SendRCSReply(SendRCSReplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendRCSReplyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>5G消息交互下行</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendRCSReplyRequest
        /// </param>
        /// 
        /// <returns>
        /// SendRCSReplyResponse
        /// </returns>
        public async Task<SendRCSReplyResponse> SendRCSReplyAsync(SendRCSReplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendRCSReplyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends an SMS message to one or more specified mobile numbers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Use this API to send an SMS message to a single mobile number. This API also supports sending messages with the same signature and template variables to multiple mobile numbers, up to 1,000 per request. Note that bulk sending may experience some latency. If you need to send messages with different signatures or template variables to multiple recipients, use the <a href="https://help.aliyun.com/document_detail/419274.html">SendBatchSms</a> API, which supports up to 100 mobile numbers per request.</para>
        /// <h3>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>For SMS messages sent to the Chinese mainland, we recommend setting the timeout period to 1 second or longer. If a timeout occurs, check the delivery receipt status before retrying the request. For more information about timeout and retry settings, see <a href="https://help.aliyun.com/document_detail/262079.html">Timeout mechanism</a> and <a href="https://help.aliyun.com/document_detail/262080.html">Retry mechanism</a>.</description></item>
        /// <item><description>This API does not support idempotence for domestic, international, or multimedia SMS messages. You must implement your own idempotence controls to prevent sending duplicate messages during retries.</description></item>
        /// <item><description>This is a billable API. For messages sent to the Chinese mainland, billing is based on the delivery receipt status from the carrier. You are not charged if the API call is successful but the carrier fails to deliver the message. For more information, see <a href="https://help.aliyun.com/document_detail/44340.html">Billing</a>.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>This API has a queries per second (QPS) limit of 5,000 for each user. The system throttles calls that exceed this limit. To avoid throttling, use this API within the specified limit.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendSmsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendSmsResponse
        /// </returns>
        public SendSmsResponse SendSmsWithOptions(SendSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumbers))
            {
                query["PhoneNumbers"] = request.PhoneNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsUpExtendCode))
            {
                query["SmsUpExtendCode"] = request.SmsUpExtendCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParam))
            {
                query["TemplateParam"] = request.TemplateParam;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendSms",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendSmsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends an SMS message to one or more specified mobile numbers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Use this API to send an SMS message to a single mobile number. This API also supports sending messages with the same signature and template variables to multiple mobile numbers, up to 1,000 per request. Note that bulk sending may experience some latency. If you need to send messages with different signatures or template variables to multiple recipients, use the <a href="https://help.aliyun.com/document_detail/419274.html">SendBatchSms</a> API, which supports up to 100 mobile numbers per request.</para>
        /// <h3>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>For SMS messages sent to the Chinese mainland, we recommend setting the timeout period to 1 second or longer. If a timeout occurs, check the delivery receipt status before retrying the request. For more information about timeout and retry settings, see <a href="https://help.aliyun.com/document_detail/262079.html">Timeout mechanism</a> and <a href="https://help.aliyun.com/document_detail/262080.html">Retry mechanism</a>.</description></item>
        /// <item><description>This API does not support idempotence for domestic, international, or multimedia SMS messages. You must implement your own idempotence controls to prevent sending duplicate messages during retries.</description></item>
        /// <item><description>This is a billable API. For messages sent to the Chinese mainland, billing is based on the delivery receipt status from the carrier. You are not charged if the API call is successful but the carrier fails to deliver the message. For more information, see <a href="https://help.aliyun.com/document_detail/44340.html">Billing</a>.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>This API has a queries per second (QPS) limit of 5,000 for each user. The system throttles calls that exceed this limit. To avoid throttling, use this API within the specified limit.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendSmsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendSmsResponse
        /// </returns>
        public async Task<SendSmsResponse> SendSmsWithOptionsAsync(SendSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumbers))
            {
                query["PhoneNumbers"] = request.PhoneNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsUpExtendCode))
            {
                query["SmsUpExtendCode"] = request.SmsUpExtendCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParam))
            {
                query["TemplateParam"] = request.TemplateParam;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendSms",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendSmsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends an SMS message to one or more specified mobile numbers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Use this API to send an SMS message to a single mobile number. This API also supports sending messages with the same signature and template variables to multiple mobile numbers, up to 1,000 per request. Note that bulk sending may experience some latency. If you need to send messages with different signatures or template variables to multiple recipients, use the <a href="https://help.aliyun.com/document_detail/419274.html">SendBatchSms</a> API, which supports up to 100 mobile numbers per request.</para>
        /// <h3>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>For SMS messages sent to the Chinese mainland, we recommend setting the timeout period to 1 second or longer. If a timeout occurs, check the delivery receipt status before retrying the request. For more information about timeout and retry settings, see <a href="https://help.aliyun.com/document_detail/262079.html">Timeout mechanism</a> and <a href="https://help.aliyun.com/document_detail/262080.html">Retry mechanism</a>.</description></item>
        /// <item><description>This API does not support idempotence for domestic, international, or multimedia SMS messages. You must implement your own idempotence controls to prevent sending duplicate messages during retries.</description></item>
        /// <item><description>This is a billable API. For messages sent to the Chinese mainland, billing is based on the delivery receipt status from the carrier. You are not charged if the API call is successful but the carrier fails to deliver the message. For more information, see <a href="https://help.aliyun.com/document_detail/44340.html">Billing</a>.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>This API has a queries per second (QPS) limit of 5,000 for each user. The system throttles calls that exceed this limit. To avoid throttling, use this API within the specified limit.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendSmsRequest
        /// </param>
        /// 
        /// <returns>
        /// SendSmsResponse
        /// </returns>
        public SendSmsResponse SendSms(SendSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendSmsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends an SMS message to one or more specified mobile numbers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Use this API to send an SMS message to a single mobile number. This API also supports sending messages with the same signature and template variables to multiple mobile numbers, up to 1,000 per request. Note that bulk sending may experience some latency. If you need to send messages with different signatures or template variables to multiple recipients, use the <a href="https://help.aliyun.com/document_detail/419274.html">SendBatchSms</a> API, which supports up to 100 mobile numbers per request.</para>
        /// <h3>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>For SMS messages sent to the Chinese mainland, we recommend setting the timeout period to 1 second or longer. If a timeout occurs, check the delivery receipt status before retrying the request. For more information about timeout and retry settings, see <a href="https://help.aliyun.com/document_detail/262079.html">Timeout mechanism</a> and <a href="https://help.aliyun.com/document_detail/262080.html">Retry mechanism</a>.</description></item>
        /// <item><description>This API does not support idempotence for domestic, international, or multimedia SMS messages. You must implement your own idempotence controls to prevent sending duplicate messages during retries.</description></item>
        /// <item><description>This is a billable API. For messages sent to the Chinese mainland, billing is based on the delivery receipt status from the carrier. You are not charged if the API call is successful but the carrier fails to deliver the message. For more information, see <a href="https://help.aliyun.com/document_detail/44340.html">Billing</a>.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>This API has a queries per second (QPS) limit of 5,000 for each user. The system throttles calls that exceed this limit. To avoid throttling, use this API within the specified limit.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendSmsRequest
        /// </param>
        /// 
        /// <returns>
        /// SendSmsResponse
        /// </returns>
        public async Task<SendSmsResponse> SendSmsAsync(SendSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendSmsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Feeds back the SMS delivery status corresponding to each message ID (MessageId) to the Alibaba Cloud International SMS platform.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Metric definitions:</para>
        /// <list type="bullet">
        /// <item><description>OTP send volume: the number of verification codes sent.</description></item>
        /// <item><description>OTP conversion volume: the number of verification codes converted (the number of times a user successfully obtained a verification code and reported it back).
        /// Conversion rate = OTP conversion volume / OTP send volume.<remarks>
        /// <para>The conversion rate feedback feature has a certain level of intrusiveness on the business system. To prevent jitter in conversion rate API calls from affecting business logic, please consider the following:  - Call the API in asynchronous mode (for example, using a queue or event-driven approach).  - Add a degradable solution to protect business logic (for example, manual degradation, or automatic degradation using a circuit breaker).</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SmsConversionIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SmsConversionIntlResponse
        /// </returns>
        public SmsConversionIntlResponse SmsConversionIntlWithOptions(SmsConversionIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversionTime))
            {
                query["ConversionTime"] = request.ConversionTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delivered))
            {
                query["Delivered"] = request.Delivered;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
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
                Action = "SmsConversionIntl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmsConversionIntlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Feeds back the SMS delivery status corresponding to each message ID (MessageId) to the Alibaba Cloud International SMS platform.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Metric definitions:</para>
        /// <list type="bullet">
        /// <item><description>OTP send volume: the number of verification codes sent.</description></item>
        /// <item><description>OTP conversion volume: the number of verification codes converted (the number of times a user successfully obtained a verification code and reported it back).
        /// Conversion rate = OTP conversion volume / OTP send volume.<remarks>
        /// <para>The conversion rate feedback feature has a certain level of intrusiveness on the business system. To prevent jitter in conversion rate API calls from affecting business logic, please consider the following:  - Call the API in asynchronous mode (for example, using a queue or event-driven approach).  - Add a degradable solution to protect business logic (for example, manual degradation, or automatic degradation using a circuit breaker).</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SmsConversionIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SmsConversionIntlResponse
        /// </returns>
        public async Task<SmsConversionIntlResponse> SmsConversionIntlWithOptionsAsync(SmsConversionIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversionTime))
            {
                query["ConversionTime"] = request.ConversionTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delivered))
            {
                query["Delivered"] = request.Delivered;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
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
                Action = "SmsConversionIntl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmsConversionIntlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Feeds back the SMS delivery status corresponding to each message ID (MessageId) to the Alibaba Cloud International SMS platform.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Metric definitions:</para>
        /// <list type="bullet">
        /// <item><description>OTP send volume: the number of verification codes sent.</description></item>
        /// <item><description>OTP conversion volume: the number of verification codes converted (the number of times a user successfully obtained a verification code and reported it back).
        /// Conversion rate = OTP conversion volume / OTP send volume.<remarks>
        /// <para>The conversion rate feedback feature has a certain level of intrusiveness on the business system. To prevent jitter in conversion rate API calls from affecting business logic, please consider the following:  - Call the API in asynchronous mode (for example, using a queue or event-driven approach).  - Add a degradable solution to protect business logic (for example, manual degradation, or automatic degradation using a circuit breaker).</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SmsConversionIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// SmsConversionIntlResponse
        /// </returns>
        public SmsConversionIntlResponse SmsConversionIntl(SmsConversionIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SmsConversionIntlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Feeds back the SMS delivery status corresponding to each message ID (MessageId) to the Alibaba Cloud International SMS platform.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Metric definitions:</para>
        /// <list type="bullet">
        /// <item><description>OTP send volume: the number of verification codes sent.</description></item>
        /// <item><description>OTP conversion volume: the number of verification codes converted (the number of times a user successfully obtained a verification code and reported it back).
        /// Conversion rate = OTP conversion volume / OTP send volume.<remarks>
        /// <para>The conversion rate feedback feature has a certain level of intrusiveness on the business system. To prevent jitter in conversion rate API calls from affecting business logic, please consider the following:  - Call the API in asynchronous mode (for example, using a queue or event-driven approach).  - Add a degradable solution to protect business logic (for example, manual degradation, or automatic degradation using a circuit breaker).</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SmsConversionIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// SmsConversionIntlResponse
        /// </returns>
        public async Task<SmsConversionIntlResponse> SmsConversionIntlAsync(SmsConversionIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SmsConversionIntlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an SMS qualification application. As required by the Ministry of Industry and Information Technology (MIIT) and carriers for real-name SMS sending, domestic SMS services require qualification credential information of the signature owner. Apply for an SMS qualification first, and then apply for signatures and templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before submitting an application, read <a href="https://help.aliyun.com/document_detail/2384377.html">Qualification material description</a> and prepare the required qualification materials.</description></item>
        /// <item><description>Currently, only users who have completed <b>verify your identity - Enterprise account</b> can use the API to apply for SMS qualifications. If your Alibaba Cloud account has completed verify your identity - Individual account, apply for qualifications through the Short Message Service <a href="https://dysms.console.aliyun.com/domestic/text/qualification/add">console</a>, or <a href="https://help.aliyun.com/document_detail/37178.html">upgrade to verify your identity - Enterprise account</a>. <a href="https://myaccount.console.aliyun.com/cert-info">View my account verification type</a></description></item>
        /// <item><description>Batch qualification applications are not supported. Wait at least 5 seconds between applications.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// SubmitSmsQualificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitSmsQualificationResponse
        /// </returns>
        public SubmitSmsQualificationResponse SubmitSmsQualificationWithOptions(SubmitSmsQualificationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitSmsQualificationShrinkRequest request = new SubmitSmsQualificationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BusinessLicensePics))
            {
                request.BusinessLicensePicsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BusinessLicensePics, "BusinessLicensePics", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OtherFiles))
            {
                request.OtherFilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OtherFiles, "OtherFiles", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminIDCardExpDate))
            {
                query["AdminIDCardExpDate"] = request.AdminIDCardExpDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminIDCardFrontFace))
            {
                query["AdminIDCardFrontFace"] = request.AdminIDCardFrontFace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminIDCardNo))
            {
                query["AdminIDCardNo"] = request.AdminIDCardNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminIDCardPic))
            {
                query["AdminIDCardPic"] = request.AdminIDCardPic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminIDCardType))
            {
                query["AdminIDCardType"] = request.AdminIDCardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminName))
            {
                query["AdminName"] = request.AdminName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminPhoneNo))
            {
                query["AdminPhoneNo"] = request.AdminPhoneNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLicensePicsShrink))
            {
                query["BusinessLicensePics"] = request.BusinessLicensePicsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BussinessLicenseExpDate))
            {
                query["BussinessLicenseExpDate"] = request.BussinessLicenseExpDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyCode))
            {
                query["CertifyCode"] = request.CertifyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyName))
            {
                query["CompanyName"] = request.CompanyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyType))
            {
                query["CompanyType"] = request.CompanyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIDCardNo))
            {
                query["LegalPersonIDCardNo"] = request.LegalPersonIDCardNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIDCardType))
            {
                query["LegalPersonIDCardType"] = request.LegalPersonIDCardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIdCardBackSide))
            {
                query["LegalPersonIdCardBackSide"] = request.LegalPersonIdCardBackSide;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIdCardEffTime))
            {
                query["LegalPersonIdCardEffTime"] = request.LegalPersonIdCardEffTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIdCardFrontSide))
            {
                query["LegalPersonIdCardFrontSide"] = request.LegalPersonIdCardFrontSide;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonName))
            {
                query["LegalPersonName"] = request.LegalPersonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationCode))
            {
                query["OrganizationCode"] = request.OrganizationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherFilesShrink))
            {
                query["OtherFiles"] = request.OtherFilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationName))
            {
                query["QualificationName"] = request.QualificationName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseBySelf))
            {
                query["UseBySelf"] = request.UseBySelf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhetherShare))
            {
                query["WhetherShare"] = request.WhetherShare;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSmsQualification",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSmsQualificationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an SMS qualification application. As required by the Ministry of Industry and Information Technology (MIIT) and carriers for real-name SMS sending, domestic SMS services require qualification credential information of the signature owner. Apply for an SMS qualification first, and then apply for signatures and templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before submitting an application, read <a href="https://help.aliyun.com/document_detail/2384377.html">Qualification material description</a> and prepare the required qualification materials.</description></item>
        /// <item><description>Currently, only users who have completed <b>verify your identity - Enterprise account</b> can use the API to apply for SMS qualifications. If your Alibaba Cloud account has completed verify your identity - Individual account, apply for qualifications through the Short Message Service <a href="https://dysms.console.aliyun.com/domestic/text/qualification/add">console</a>, or <a href="https://help.aliyun.com/document_detail/37178.html">upgrade to verify your identity - Enterprise account</a>. <a href="https://myaccount.console.aliyun.com/cert-info">View my account verification type</a></description></item>
        /// <item><description>Batch qualification applications are not supported. Wait at least 5 seconds between applications.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// SubmitSmsQualificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitSmsQualificationResponse
        /// </returns>
        public async Task<SubmitSmsQualificationResponse> SubmitSmsQualificationWithOptionsAsync(SubmitSmsQualificationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitSmsQualificationShrinkRequest request = new SubmitSmsQualificationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BusinessLicensePics))
            {
                request.BusinessLicensePicsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BusinessLicensePics, "BusinessLicensePics", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OtherFiles))
            {
                request.OtherFilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OtherFiles, "OtherFiles", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminIDCardExpDate))
            {
                query["AdminIDCardExpDate"] = request.AdminIDCardExpDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminIDCardFrontFace))
            {
                query["AdminIDCardFrontFace"] = request.AdminIDCardFrontFace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminIDCardNo))
            {
                query["AdminIDCardNo"] = request.AdminIDCardNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminIDCardPic))
            {
                query["AdminIDCardPic"] = request.AdminIDCardPic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminIDCardType))
            {
                query["AdminIDCardType"] = request.AdminIDCardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminName))
            {
                query["AdminName"] = request.AdminName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminPhoneNo))
            {
                query["AdminPhoneNo"] = request.AdminPhoneNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLicensePicsShrink))
            {
                query["BusinessLicensePics"] = request.BusinessLicensePicsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BussinessLicenseExpDate))
            {
                query["BussinessLicenseExpDate"] = request.BussinessLicenseExpDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyCode))
            {
                query["CertifyCode"] = request.CertifyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyName))
            {
                query["CompanyName"] = request.CompanyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyType))
            {
                query["CompanyType"] = request.CompanyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIDCardNo))
            {
                query["LegalPersonIDCardNo"] = request.LegalPersonIDCardNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIDCardType))
            {
                query["LegalPersonIDCardType"] = request.LegalPersonIDCardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIdCardBackSide))
            {
                query["LegalPersonIdCardBackSide"] = request.LegalPersonIdCardBackSide;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIdCardEffTime))
            {
                query["LegalPersonIdCardEffTime"] = request.LegalPersonIdCardEffTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIdCardFrontSide))
            {
                query["LegalPersonIdCardFrontSide"] = request.LegalPersonIdCardFrontSide;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonName))
            {
                query["LegalPersonName"] = request.LegalPersonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationCode))
            {
                query["OrganizationCode"] = request.OrganizationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherFilesShrink))
            {
                query["OtherFiles"] = request.OtherFilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationName))
            {
                query["QualificationName"] = request.QualificationName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseBySelf))
            {
                query["UseBySelf"] = request.UseBySelf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhetherShare))
            {
                query["WhetherShare"] = request.WhetherShare;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSmsQualification",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSmsQualificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an SMS qualification application. As required by the Ministry of Industry and Information Technology (MIIT) and carriers for real-name SMS sending, domestic SMS services require qualification credential information of the signature owner. Apply for an SMS qualification first, and then apply for signatures and templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before submitting an application, read <a href="https://help.aliyun.com/document_detail/2384377.html">Qualification material description</a> and prepare the required qualification materials.</description></item>
        /// <item><description>Currently, only users who have completed <b>verify your identity - Enterprise account</b> can use the API to apply for SMS qualifications. If your Alibaba Cloud account has completed verify your identity - Individual account, apply for qualifications through the Short Message Service <a href="https://dysms.console.aliyun.com/domestic/text/qualification/add">console</a>, or <a href="https://help.aliyun.com/document_detail/37178.html">upgrade to verify your identity - Enterprise account</a>. <a href="https://myaccount.console.aliyun.com/cert-info">View my account verification type</a></description></item>
        /// <item><description>Batch qualification applications are not supported. Wait at least 5 seconds between applications.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitSmsQualificationRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitSmsQualificationResponse
        /// </returns>
        public SubmitSmsQualificationResponse SubmitSmsQualification(SubmitSmsQualificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSmsQualificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an SMS qualification application. As required by the Ministry of Industry and Information Technology (MIIT) and carriers for real-name SMS sending, domestic SMS services require qualification credential information of the signature owner. Apply for an SMS qualification first, and then apply for signatures and templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before submitting an application, read <a href="https://help.aliyun.com/document_detail/2384377.html">Qualification material description</a> and prepare the required qualification materials.</description></item>
        /// <item><description>Currently, only users who have completed <b>verify your identity - Enterprise account</b> can use the API to apply for SMS qualifications. If your Alibaba Cloud account has completed verify your identity - Individual account, apply for qualifications through the Short Message Service <a href="https://dysms.console.aliyun.com/domestic/text/qualification/add">console</a>, or <a href="https://help.aliyun.com/document_detail/37178.html">upgrade to verify your identity - Enterprise account</a>. <a href="https://myaccount.console.aliyun.com/cert-info">View my account verification type</a></description></item>
        /// <item><description>Batch qualification applications are not supported. Wait at least 5 seconds between applications.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitSmsQualificationRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitSmsQualificationResponse
        /// </returns>
        public async Task<SubmitSmsQualificationResponse> SubmitSmsQualificationAsync(SubmitSmsQualificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSmsQualificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tags can mark resources, allowing enterprises or individuals to classify templates of the same type for easier search and resource aggregation. Call this operation to bind tags to SMS templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Each template can be bound to up to 20 tags.</description></item>
        /// <item><description>The tag key (Key) must be unique within the same template. If a template has two tags with the same Key but different Values, the new value overwrites the old value.</description></item>
        /// <item><description>This feature is only available for domestic text messages of Short Message Service on the China site.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit of this operation is 50 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call this operation at a reasonable frequency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tags can mark resources, allowing enterprises or individuals to classify templates of the same type for easier search and resource aggregation. Call this operation to bind tags to SMS templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Each template can be bound to up to 20 tags.</description></item>
        /// <item><description>The tag key (Key) must be unique within the same template. If a template has two tags with the same Key but different Values, the new value overwrites the old value.</description></item>
        /// <item><description>This feature is only available for domestic text messages of Short Message Service on the China site.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit of this operation is 50 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call this operation at a reasonable frequency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tags can mark resources, allowing enterprises or individuals to classify templates of the same type for easier search and resource aggregation. Call this operation to bind tags to SMS templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Each template can be bound to up to 20 tags.</description></item>
        /// <item><description>The tag key (Key) must be unique within the same template. If a template has two tags with the same Key but different Values, the new value overwrites the old value.</description></item>
        /// <item><description>This feature is only available for domestic text messages of Short Message Service on the China site.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit of this operation is 50 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call this operation at a reasonable frequency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tags can mark resources, allowing enterprises or individuals to classify templates of the same type for easier search and resource aggregation. Call this operation to bind tags to SMS templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Each template can be bound to up to 20 tags.</description></item>
        /// <item><description>The tag key (Key) must be unique within the same template. If a template has two tags with the same Key but different Values, the new value overwrites the old value.</description></item>
        /// <item><description>This feature is only available for domestic text messages of Short Message Service on the China site.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit of this operation is 50 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call this operation at a reasonable frequency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tags can mark resources, allowing enterprises or individuals to categorize templates of the same type for easier search and resource aggregation. If a template is no longer applicable to its currently bound tags, you can unbind the tags from the template. You can delete a single tag or delete tags in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit per user for this operation is 50 calls per second. If the limit is exceeded, API calls will be throttled, which may affect your business. Please call the operation reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tags can mark resources, allowing enterprises or individuals to categorize templates of the same type for easier search and resource aggregation. If a template is no longer applicable to its currently bound tags, you can unbind the tags from the template. You can delete a single tag or delete tags in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit per user for this operation is 50 calls per second. If the limit is exceeded, API calls will be throttled, which may affect your business. Please call the operation reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tags can mark resources, allowing enterprises or individuals to categorize templates of the same type for easier search and resource aggregation. If a template is no longer applicable to its currently bound tags, you can unbind the tags from the template. You can delete a single tag or delete tags in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit per user for this operation is 50 calls per second. If the limit is exceeded, API calls will be throttled, which may affect your business. Please call the operation reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tags can mark resources, allowing enterprises or individuals to categorize templates of the same type for easier search and resource aggregation. If a template is no longer applicable to its currently bound tags, you can unbind the tags from the template. You can delete a single tag or delete tags in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit per user for this operation is 50 calls per second. If the limit is exceeded, API calls will be throttled, which may affect your business. Please call the operation reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改验证码签名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExtCodeSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExtCodeSignResponse
        /// </returns>
        public UpdateExtCodeSignResponse UpdateExtCodeSignWithOptions(UpdateExtCodeSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExistExtCode))
            {
                query["ExistExtCode"] = request.ExistExtCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewExtCode))
            {
                query["NewExtCode"] = request.NewExtCode;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExtCodeSign",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExtCodeSignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改验证码签名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExtCodeSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExtCodeSignResponse
        /// </returns>
        public async Task<UpdateExtCodeSignResponse> UpdateExtCodeSignWithOptionsAsync(UpdateExtCodeSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExistExtCode))
            {
                query["ExistExtCode"] = request.ExistExtCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewExtCode))
            {
                query["NewExtCode"] = request.NewExtCode;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExtCodeSign",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExtCodeSignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改验证码签名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExtCodeSignRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExtCodeSignResponse
        /// </returns>
        public UpdateExtCodeSignResponse UpdateExtCodeSign(UpdateExtCodeSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateExtCodeSignWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改验证码签名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExtCodeSignRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExtCodeSignResponse
        /// </returns>
        public async Task<UpdateExtCodeSignResponse> UpdateExtCodeSignAsync(UpdateExtCodeSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateExtCodeSignWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑5g签名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRCSSignatureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRCSSignatureResponse
        /// </returns>
        public UpdateRCSSignatureResponse UpdateRCSSignatureWithOptions(UpdateRCSSignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundImage))
            {
                query["BackgroundImage"] = request.BackgroundImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BubbleColor))
            {
                query["BubbleColor"] = request.BubbleColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Latitude))
            {
                query["Latitude"] = request.Latitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logo))
            {
                query["Logo"] = request.Logo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Longitude))
            {
                query["Longitude"] = request.Longitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeAddress))
            {
                query["OfficeAddress"] = request.OfficeAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceEmail))
            {
                query["ServiceEmail"] = request.ServiceEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePhone))
            {
                query["ServicePhone"] = request.ServicePhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceTerms))
            {
                query["ServiceTerms"] = request.ServiceTerms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceWebsite))
            {
                query["ServiceWebsite"] = request.ServiceWebsite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRCSSignature",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRCSSignatureResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑5g签名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRCSSignatureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRCSSignatureResponse
        /// </returns>
        public async Task<UpdateRCSSignatureResponse> UpdateRCSSignatureWithOptionsAsync(UpdateRCSSignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundImage))
            {
                query["BackgroundImage"] = request.BackgroundImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BubbleColor))
            {
                query["BubbleColor"] = request.BubbleColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Latitude))
            {
                query["Latitude"] = request.Latitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logo))
            {
                query["Logo"] = request.Logo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Longitude))
            {
                query["Longitude"] = request.Longitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeAddress))
            {
                query["OfficeAddress"] = request.OfficeAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceEmail))
            {
                query["ServiceEmail"] = request.ServiceEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePhone))
            {
                query["ServicePhone"] = request.ServicePhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceTerms))
            {
                query["ServiceTerms"] = request.ServiceTerms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceWebsite))
            {
                query["ServiceWebsite"] = request.ServiceWebsite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRCSSignature",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRCSSignatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑5g签名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRCSSignatureRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRCSSignatureResponse
        /// </returns>
        public UpdateRCSSignatureResponse UpdateRCSSignature(UpdateRCSSignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRCSSignatureWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑5g签名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRCSSignatureRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRCSSignatureResponse
        /// </returns>
        public async Task<UpdateRCSSignatureResponse> UpdateRCSSignatureAsync(UpdateRCSSignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRCSSignatureWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you need to update SMS qualification information, you can submit a modification request through this API. After submission, it will re-enter the review process.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Qualifications under review do not support modification. Please wait for the review process to finish, or <a href="https://dysms.console.aliyun.com/domestic/text/qualification">withdraw the application</a> in the SMS Service console before making modifications.</description></item>
        /// <item><description>The modified SMS qualification <b>must be re-reviewed</b> (including qualifications that have already passed review). Please upload materials that meet the specifications according to the <a href="https://help.aliyun.com/document_detail/2384377.html">Qualification Material Description</a>.</description></item>
        /// <item><description><b>Modification is not supported</b> for the qualification name, application purpose, or unified social credit code.</description></item>
        /// <item><description>Batch modification of SMS qualifications is not supported. It is recommended to leave at least 5 seconds between modifications.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateSmsQualificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSmsQualificationResponse
        /// </returns>
        public UpdateSmsQualificationResponse UpdateSmsQualificationWithOptions(UpdateSmsQualificationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSmsQualificationShrinkRequest request = new UpdateSmsQualificationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BusinessLicensePics))
            {
                request.BusinessLicensePicsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BusinessLicensePics, "BusinessLicensePics", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OtherFiles))
            {
                request.OtherFilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OtherFiles, "OtherFiles", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminIDCardExpDate))
            {
                query["AdminIDCardExpDate"] = request.AdminIDCardExpDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminIDCardFrontFace))
            {
                query["AdminIDCardFrontFace"] = request.AdminIDCardFrontFace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminIDCardNo))
            {
                query["AdminIDCardNo"] = request.AdminIDCardNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminIDCardPic))
            {
                query["AdminIDCardPic"] = request.AdminIDCardPic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminIDCardType))
            {
                query["AdminIDCardType"] = request.AdminIDCardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminName))
            {
                query["AdminName"] = request.AdminName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminPhoneNo))
            {
                query["AdminPhoneNo"] = request.AdminPhoneNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLicensePicsShrink))
            {
                query["BusinessLicensePics"] = request.BusinessLicensePicsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BussinessLicenseExpDate))
            {
                query["BussinessLicenseExpDate"] = request.BussinessLicenseExpDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyCode))
            {
                query["CertifyCode"] = request.CertifyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyName))
            {
                query["CompanyName"] = request.CompanyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIDCardNo))
            {
                query["LegalPersonIDCardNo"] = request.LegalPersonIDCardNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIDCardType))
            {
                query["LegalPersonIDCardType"] = request.LegalPersonIDCardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIdCardBackSide))
            {
                query["LegalPersonIdCardBackSide"] = request.LegalPersonIdCardBackSide;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIdCardEffTime))
            {
                query["LegalPersonIdCardEffTime"] = request.LegalPersonIdCardEffTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIdCardFrontSide))
            {
                query["LegalPersonIdCardFrontSide"] = request.LegalPersonIdCardFrontSide;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonName))
            {
                query["LegalPersonName"] = request.LegalPersonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherFilesShrink))
            {
                query["OtherFiles"] = request.OtherFilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationGroupId))
            {
                query["QualificationGroupId"] = request.QualificationGroupId;
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
                Action = "UpdateSmsQualification",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSmsQualificationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you need to update SMS qualification information, you can submit a modification request through this API. After submission, it will re-enter the review process.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Qualifications under review do not support modification. Please wait for the review process to finish, or <a href="https://dysms.console.aliyun.com/domestic/text/qualification">withdraw the application</a> in the SMS Service console before making modifications.</description></item>
        /// <item><description>The modified SMS qualification <b>must be re-reviewed</b> (including qualifications that have already passed review). Please upload materials that meet the specifications according to the <a href="https://help.aliyun.com/document_detail/2384377.html">Qualification Material Description</a>.</description></item>
        /// <item><description><b>Modification is not supported</b> for the qualification name, application purpose, or unified social credit code.</description></item>
        /// <item><description>Batch modification of SMS qualifications is not supported. It is recommended to leave at least 5 seconds between modifications.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateSmsQualificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSmsQualificationResponse
        /// </returns>
        public async Task<UpdateSmsQualificationResponse> UpdateSmsQualificationWithOptionsAsync(UpdateSmsQualificationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSmsQualificationShrinkRequest request = new UpdateSmsQualificationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BusinessLicensePics))
            {
                request.BusinessLicensePicsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BusinessLicensePics, "BusinessLicensePics", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OtherFiles))
            {
                request.OtherFilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OtherFiles, "OtherFiles", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminIDCardExpDate))
            {
                query["AdminIDCardExpDate"] = request.AdminIDCardExpDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminIDCardFrontFace))
            {
                query["AdminIDCardFrontFace"] = request.AdminIDCardFrontFace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminIDCardNo))
            {
                query["AdminIDCardNo"] = request.AdminIDCardNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminIDCardPic))
            {
                query["AdminIDCardPic"] = request.AdminIDCardPic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminIDCardType))
            {
                query["AdminIDCardType"] = request.AdminIDCardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminName))
            {
                query["AdminName"] = request.AdminName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminPhoneNo))
            {
                query["AdminPhoneNo"] = request.AdminPhoneNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLicensePicsShrink))
            {
                query["BusinessLicensePics"] = request.BusinessLicensePicsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BussinessLicenseExpDate))
            {
                query["BussinessLicenseExpDate"] = request.BussinessLicenseExpDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyCode))
            {
                query["CertifyCode"] = request.CertifyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyName))
            {
                query["CompanyName"] = request.CompanyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIDCardNo))
            {
                query["LegalPersonIDCardNo"] = request.LegalPersonIDCardNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIDCardType))
            {
                query["LegalPersonIDCardType"] = request.LegalPersonIDCardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIdCardBackSide))
            {
                query["LegalPersonIdCardBackSide"] = request.LegalPersonIdCardBackSide;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIdCardEffTime))
            {
                query["LegalPersonIdCardEffTime"] = request.LegalPersonIdCardEffTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIdCardFrontSide))
            {
                query["LegalPersonIdCardFrontSide"] = request.LegalPersonIdCardFrontSide;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonName))
            {
                query["LegalPersonName"] = request.LegalPersonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherFilesShrink))
            {
                query["OtherFiles"] = request.OtherFilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationGroupId))
            {
                query["QualificationGroupId"] = request.QualificationGroupId;
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
                Action = "UpdateSmsQualification",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSmsQualificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you need to update SMS qualification information, you can submit a modification request through this API. After submission, it will re-enter the review process.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Qualifications under review do not support modification. Please wait for the review process to finish, or <a href="https://dysms.console.aliyun.com/domestic/text/qualification">withdraw the application</a> in the SMS Service console before making modifications.</description></item>
        /// <item><description>The modified SMS qualification <b>must be re-reviewed</b> (including qualifications that have already passed review). Please upload materials that meet the specifications according to the <a href="https://help.aliyun.com/document_detail/2384377.html">Qualification Material Description</a>.</description></item>
        /// <item><description><b>Modification is not supported</b> for the qualification name, application purpose, or unified social credit code.</description></item>
        /// <item><description>Batch modification of SMS qualifications is not supported. It is recommended to leave at least 5 seconds between modifications.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSmsQualificationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSmsQualificationResponse
        /// </returns>
        public UpdateSmsQualificationResponse UpdateSmsQualification(UpdateSmsQualificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSmsQualificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you need to update SMS qualification information, you can submit a modification request through this API. After submission, it will re-enter the review process.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Qualifications under review do not support modification. Please wait for the review process to finish, or <a href="https://dysms.console.aliyun.com/domestic/text/qualification">withdraw the application</a> in the SMS Service console before making modifications.</description></item>
        /// <item><description>The modified SMS qualification <b>must be re-reviewed</b> (including qualifications that have already passed review). Please upload materials that meet the specifications according to the <a href="https://help.aliyun.com/document_detail/2384377.html">Qualification Material Description</a>.</description></item>
        /// <item><description><b>Modification is not supported</b> for the qualification name, application purpose, or unified social credit code.</description></item>
        /// <item><description>Batch modification of SMS qualifications is not supported. It is recommended to leave at least 5 seconds between modifications.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSmsQualificationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSmsQualificationResponse
        /// </returns>
        public async Task<UpdateSmsQualificationResponse> UpdateSmsQualificationAsync(UpdateSmsQualificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSmsQualificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can modify rejected or approved signatures. A modified signature is automatically submitted for review, and its status changes to pending review.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For details about the updates to the signature and template APIs, see <a href="https://help.aliyun.com/document_detail/2806975.html">Announcement on Updating Signature &amp; Template APIs for Short Message Service</a>.</description></item>
        /// <item><description>You can modify signatures that are either <b>rejected</b> or <b>approved</b>. For guidance on handling review failures, see <a href="https://help.aliyun.com/document_detail/65990.html">Handling signature review failures</a>. Call this API to modify and resubmit the signature for review.</description></item>
        /// <item><description>You cannot use this API to edit the name of a <b>rejected</b> signature. To edit the name, go to the <a href="https://dysms.console.aliyun.com/domestic/text/sign">Short Message Service console</a>.</description></item>
        /// <item><description>Signatures you request using this API are synchronized with the Short Message Service console. For information on managing signatures in the console, see <a href="https://help.aliyun.com/document_detail/108073.html">Signatures</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateSmsSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSmsSignResponse
        /// </returns>
        public UpdateSmsSignResponse UpdateSmsSignWithOptions(UpdateSmsSignRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSmsSignShrinkRequest request = new UpdateSmsSignShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MoreData))
            {
                request.MoreDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MoreData, "MoreData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIcpRecordId))
            {
                query["AppIcpRecordId"] = request.AppIcpRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplySceneContent))
            {
                query["ApplySceneContent"] = request.ApplySceneContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationLetterId))
            {
                query["AuthorizationLetterId"] = request.AuthorizationLetterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MoreDataShrink))
            {
                query["MoreData"] = request.MoreDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationId))
            {
                query["QualificationId"] = request.QualificationId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignSource))
            {
                query["SignSource"] = request.SignSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignType))
            {
                query["SignType"] = request.SignType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdParty))
            {
                query["ThirdParty"] = request.ThirdParty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkId))
            {
                query["TrademarkId"] = request.TrademarkId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSmsSign",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSmsSignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can modify rejected or approved signatures. A modified signature is automatically submitted for review, and its status changes to pending review.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For details about the updates to the signature and template APIs, see <a href="https://help.aliyun.com/document_detail/2806975.html">Announcement on Updating Signature &amp; Template APIs for Short Message Service</a>.</description></item>
        /// <item><description>You can modify signatures that are either <b>rejected</b> or <b>approved</b>. For guidance on handling review failures, see <a href="https://help.aliyun.com/document_detail/65990.html">Handling signature review failures</a>. Call this API to modify and resubmit the signature for review.</description></item>
        /// <item><description>You cannot use this API to edit the name of a <b>rejected</b> signature. To edit the name, go to the <a href="https://dysms.console.aliyun.com/domestic/text/sign">Short Message Service console</a>.</description></item>
        /// <item><description>Signatures you request using this API are synchronized with the Short Message Service console. For information on managing signatures in the console, see <a href="https://help.aliyun.com/document_detail/108073.html">Signatures</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateSmsSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSmsSignResponse
        /// </returns>
        public async Task<UpdateSmsSignResponse> UpdateSmsSignWithOptionsAsync(UpdateSmsSignRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSmsSignShrinkRequest request = new UpdateSmsSignShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MoreData))
            {
                request.MoreDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MoreData, "MoreData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIcpRecordId))
            {
                query["AppIcpRecordId"] = request.AppIcpRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplySceneContent))
            {
                query["ApplySceneContent"] = request.ApplySceneContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationLetterId))
            {
                query["AuthorizationLetterId"] = request.AuthorizationLetterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MoreDataShrink))
            {
                query["MoreData"] = request.MoreDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationId))
            {
                query["QualificationId"] = request.QualificationId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignSource))
            {
                query["SignSource"] = request.SignSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignType))
            {
                query["SignType"] = request.SignType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdParty))
            {
                query["ThirdParty"] = request.ThirdParty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkId))
            {
                query["TrademarkId"] = request.TrademarkId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSmsSign",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSmsSignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can modify rejected or approved signatures. A modified signature is automatically submitted for review, and its status changes to pending review.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For details about the updates to the signature and template APIs, see <a href="https://help.aliyun.com/document_detail/2806975.html">Announcement on Updating Signature &amp; Template APIs for Short Message Service</a>.</description></item>
        /// <item><description>You can modify signatures that are either <b>rejected</b> or <b>approved</b>. For guidance on handling review failures, see <a href="https://help.aliyun.com/document_detail/65990.html">Handling signature review failures</a>. Call this API to modify and resubmit the signature for review.</description></item>
        /// <item><description>You cannot use this API to edit the name of a <b>rejected</b> signature. To edit the name, go to the <a href="https://dysms.console.aliyun.com/domestic/text/sign">Short Message Service console</a>.</description></item>
        /// <item><description>Signatures you request using this API are synchronized with the Short Message Service console. For information on managing signatures in the console, see <a href="https://help.aliyun.com/document_detail/108073.html">Signatures</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSmsSignRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSmsSignResponse
        /// </returns>
        public UpdateSmsSignResponse UpdateSmsSign(UpdateSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSmsSignWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can modify rejected or approved signatures. A modified signature is automatically submitted for review, and its status changes to pending review.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For details about the updates to the signature and template APIs, see <a href="https://help.aliyun.com/document_detail/2806975.html">Announcement on Updating Signature &amp; Template APIs for Short Message Service</a>.</description></item>
        /// <item><description>You can modify signatures that are either <b>rejected</b> or <b>approved</b>. For guidance on handling review failures, see <a href="https://help.aliyun.com/document_detail/65990.html">Handling signature review failures</a>. Call this API to modify and resubmit the signature for review.</description></item>
        /// <item><description>You cannot use this API to edit the name of a <b>rejected</b> signature. To edit the name, go to the <a href="https://dysms.console.aliyun.com/domestic/text/sign">Short Message Service console</a>.</description></item>
        /// <item><description>Signatures you request using this API are synchronized with the Short Message Service console. For information on managing signatures in the console, see <a href="https://help.aliyun.com/document_detail/108073.html">Signatures</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSmsSignRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSmsSignResponse
        /// </returns>
        public async Task<UpdateSmsSignResponse> UpdateSmsSignAsync(UpdateSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSmsSignWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API modifies a template that failed review and automatically resubmits it.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For details about the changes to the signature and template APIs, see <a href="https://help.aliyun.com/document_detail/2806975.html">Announcement on Updating Signature &amp; Template APIs for Short Message Service</a>.</description></item>
        /// <item><description>You can only modify templates that have failed review. For troubleshooting, see <a href="https://help.aliyun.com/document_detail/65990.html">Suggestions for handling failed SMS template reviews</a>. After modifying a template with this API, you must resubmit it for review.</description></item>
        /// <item><description>Template changes made using this API are synchronized with the Short Message Service console. To learn more about managing templates in the console, see <a href="https://help.aliyun.com/document_detail/108085.html">SMS templates</a>.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for this API is 1,000 queries per second per user. If you exceed this limit, your API calls will be throttled. This can affect your business, so please use the API responsibly.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateSmsTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSmsTemplateResponse
        /// </returns>
        public UpdateSmsTemplateResponse UpdateSmsTemplateWithOptions(UpdateSmsTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSmsTemplateShrinkRequest request = new UpdateSmsTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MoreData))
            {
                request.MoreDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MoreData, "MoreData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplySceneContent))
            {
                query["ApplySceneContent"] = request.ApplySceneContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntlType))
            {
                query["IntlType"] = request.IntlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MoreDataShrink))
            {
                query["MoreData"] = request.MoreDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedSignName))
            {
                query["RelatedSignName"] = request.RelatedSignName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateContent))
            {
                query["TemplateContent"] = request.TemplateContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateRule))
            {
                query["TemplateRule"] = request.TemplateRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficDriving))
            {
                query["TrafficDriving"] = request.TrafficDriving;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSmsTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSmsTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API modifies a template that failed review and automatically resubmits it.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For details about the changes to the signature and template APIs, see <a href="https://help.aliyun.com/document_detail/2806975.html">Announcement on Updating Signature &amp; Template APIs for Short Message Service</a>.</description></item>
        /// <item><description>You can only modify templates that have failed review. For troubleshooting, see <a href="https://help.aliyun.com/document_detail/65990.html">Suggestions for handling failed SMS template reviews</a>. After modifying a template with this API, you must resubmit it for review.</description></item>
        /// <item><description>Template changes made using this API are synchronized with the Short Message Service console. To learn more about managing templates in the console, see <a href="https://help.aliyun.com/document_detail/108085.html">SMS templates</a>.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for this API is 1,000 queries per second per user. If you exceed this limit, your API calls will be throttled. This can affect your business, so please use the API responsibly.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateSmsTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSmsTemplateResponse
        /// </returns>
        public async Task<UpdateSmsTemplateResponse> UpdateSmsTemplateWithOptionsAsync(UpdateSmsTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSmsTemplateShrinkRequest request = new UpdateSmsTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MoreData))
            {
                request.MoreDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MoreData, "MoreData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplySceneContent))
            {
                query["ApplySceneContent"] = request.ApplySceneContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntlType))
            {
                query["IntlType"] = request.IntlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MoreDataShrink))
            {
                query["MoreData"] = request.MoreDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedSignName))
            {
                query["RelatedSignName"] = request.RelatedSignName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateContent))
            {
                query["TemplateContent"] = request.TemplateContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateRule))
            {
                query["TemplateRule"] = request.TemplateRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficDriving))
            {
                query["TrafficDriving"] = request.TrafficDriving;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSmsTemplate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSmsTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API modifies a template that failed review and automatically resubmits it.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For details about the changes to the signature and template APIs, see <a href="https://help.aliyun.com/document_detail/2806975.html">Announcement on Updating Signature &amp; Template APIs for Short Message Service</a>.</description></item>
        /// <item><description>You can only modify templates that have failed review. For troubleshooting, see <a href="https://help.aliyun.com/document_detail/65990.html">Suggestions for handling failed SMS template reviews</a>. After modifying a template with this API, you must resubmit it for review.</description></item>
        /// <item><description>Template changes made using this API are synchronized with the Short Message Service console. To learn more about managing templates in the console, see <a href="https://help.aliyun.com/document_detail/108085.html">SMS templates</a>.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for this API is 1,000 queries per second per user. If you exceed this limit, your API calls will be throttled. This can affect your business, so please use the API responsibly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSmsTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSmsTemplateResponse
        /// </returns>
        public UpdateSmsTemplateResponse UpdateSmsTemplate(UpdateSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSmsTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API modifies a template that failed review and automatically resubmits it.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For details about the changes to the signature and template APIs, see <a href="https://help.aliyun.com/document_detail/2806975.html">Announcement on Updating Signature &amp; Template APIs for Short Message Service</a>.</description></item>
        /// <item><description>You can only modify templates that have failed review. For troubleshooting, see <a href="https://help.aliyun.com/document_detail/65990.html">Suggestions for handling failed SMS template reviews</a>. After modifying a template with this API, you must resubmit it for review.</description></item>
        /// <item><description>Template changes made using this API are synchronized with the Short Message Service console. To learn more about managing templates in the console, see <a href="https://help.aliyun.com/document_detail/108085.html">SMS templates</a>.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for this API is 1,000 queries per second per user. If you exceed this limit, your API calls will be throttled. This can affect your business, so please use the API responsibly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSmsTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSmsTemplateResponse
        /// </returns>
        public async Task<UpdateSmsTemplateResponse> UpdateSmsTemplateAsync(UpdateSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSmsTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>升级文本短信为5g签名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeToRCSSignatureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeToRCSSignatureResponse
        /// </returns>
        public UpgradeToRCSSignatureResponse UpgradeToRCSSignatureWithOptions(UpgradeToRCSSignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundImage))
            {
                query["BackgroundImage"] = request.BackgroundImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BubbleColor))
            {
                query["BubbleColor"] = request.BubbleColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Latitude))
            {
                query["Latitude"] = request.Latitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logo))
            {
                query["Logo"] = request.Logo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Longitude))
            {
                query["Longitude"] = request.Longitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeAddress))
            {
                query["OfficeAddress"] = request.OfficeAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceEmail))
            {
                query["ServiceEmail"] = request.ServiceEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePhone))
            {
                query["ServicePhone"] = request.ServicePhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceTerms))
            {
                query["ServiceTerms"] = request.ServiceTerms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceWebsite))
            {
                query["ServiceWebsite"] = request.ServiceWebsite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeToRCSSignature",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeToRCSSignatureResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>升级文本短信为5g签名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeToRCSSignatureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeToRCSSignatureResponse
        /// </returns>
        public async Task<UpgradeToRCSSignatureResponse> UpgradeToRCSSignatureWithOptionsAsync(UpgradeToRCSSignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundImage))
            {
                query["BackgroundImage"] = request.BackgroundImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BubbleColor))
            {
                query["BubbleColor"] = request.BubbleColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Latitude))
            {
                query["Latitude"] = request.Latitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logo))
            {
                query["Logo"] = request.Logo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Longitude))
            {
                query["Longitude"] = request.Longitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeAddress))
            {
                query["OfficeAddress"] = request.OfficeAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceEmail))
            {
                query["ServiceEmail"] = request.ServiceEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePhone))
            {
                query["ServicePhone"] = request.ServicePhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceTerms))
            {
                query["ServiceTerms"] = request.ServiceTerms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceWebsite))
            {
                query["ServiceWebsite"] = request.ServiceWebsite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeToRCSSignature",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeToRCSSignatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>升级文本短信为5g签名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeToRCSSignatureRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeToRCSSignatureResponse
        /// </returns>
        public UpgradeToRCSSignatureResponse UpgradeToRCSSignature(UpgradeToRCSSignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeToRCSSignatureWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>升级文本短信为5g签名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeToRCSSignatureRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeToRCSSignatureResponse
        /// </returns>
        public async Task<UpgradeToRCSSignatureResponse> UpgradeToRCSSignatureAsync(UpgradeToRCSSignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeToRCSSignatureWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>When applying for SMS qualification, the administrator\&quot;s phone number must be verified. This operation verifies the phone number and the received verification code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Call the <a href="~~RequiredPhoneCode~~">RequiredPhoneCode</a> operation first. Alibaba Cloud sends an SMS verification code to the phone number that you provided.</description></item>
        /// <item><description>This operation does not affect the SMS qualification application process and is used only to verify the SMS verification code. When you submit the actual application, pass the verification code into the <c>CertifyCode</c> parameter of the <a href="~~SubmitSmsQualification~~">SubmitSmsQualification</a> operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ValidPhoneCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidPhoneCodeResponse
        /// </returns>
        public ValidPhoneCodeResponse ValidPhoneCodeWithOptions(ValidPhoneCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyCode))
            {
                query["CertifyCode"] = request.CertifyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNo))
            {
                query["PhoneNo"] = request.PhoneNo;
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
                Action = "ValidPhoneCode",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidPhoneCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>When applying for SMS qualification, the administrator\&quot;s phone number must be verified. This operation verifies the phone number and the received verification code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Call the <a href="~~RequiredPhoneCode~~">RequiredPhoneCode</a> operation first. Alibaba Cloud sends an SMS verification code to the phone number that you provided.</description></item>
        /// <item><description>This operation does not affect the SMS qualification application process and is used only to verify the SMS verification code. When you submit the actual application, pass the verification code into the <c>CertifyCode</c> parameter of the <a href="~~SubmitSmsQualification~~">SubmitSmsQualification</a> operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ValidPhoneCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidPhoneCodeResponse
        /// </returns>
        public async Task<ValidPhoneCodeResponse> ValidPhoneCodeWithOptionsAsync(ValidPhoneCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyCode))
            {
                query["CertifyCode"] = request.CertifyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNo))
            {
                query["PhoneNo"] = request.PhoneNo;
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
                Action = "ValidPhoneCode",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidPhoneCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>When applying for SMS qualification, the administrator\&quot;s phone number must be verified. This operation verifies the phone number and the received verification code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Call the <a href="~~RequiredPhoneCode~~">RequiredPhoneCode</a> operation first. Alibaba Cloud sends an SMS verification code to the phone number that you provided.</description></item>
        /// <item><description>This operation does not affect the SMS qualification application process and is used only to verify the SMS verification code. When you submit the actual application, pass the verification code into the <c>CertifyCode</c> parameter of the <a href="~~SubmitSmsQualification~~">SubmitSmsQualification</a> operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ValidPhoneCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidPhoneCodeResponse
        /// </returns>
        public ValidPhoneCodeResponse ValidPhoneCode(ValidPhoneCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ValidPhoneCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>When applying for SMS qualification, the administrator\&quot;s phone number must be verified. This operation verifies the phone number and the received verification code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Call the <a href="~~RequiredPhoneCode~~">RequiredPhoneCode</a> operation first. Alibaba Cloud sends an SMS verification code to the phone number that you provided.</description></item>
        /// <item><description>This operation does not affect the SMS qualification application process and is used only to verify the SMS verification code. When you submit the actual application, pass the verification code into the <c>CertifyCode</c> parameter of the <a href="~~SubmitSmsQualification~~">SubmitSmsQualification</a> operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ValidPhoneCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidPhoneCodeResponse
        /// </returns>
        public async Task<ValidPhoneCodeResponse> ValidPhoneCodeAsync(ValidPhoneCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ValidPhoneCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>物流短信运单号校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyLogisticsSmsMailNoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyLogisticsSmsMailNoResponse
        /// </returns>
        public VerifyLogisticsSmsMailNoResponse VerifyLogisticsSmsMailNoWithOptions(VerifyLogisticsSmsMailNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpressCompanyCode))
            {
                query["ExpressCompanyCode"] = request.ExpressCompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MailNo))
            {
                query["MailNo"] = request.MailNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformCompanyCode))
            {
                query["PlatformCompanyCode"] = request.PlatformCompanyCode;
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
                Action = "VerifyLogisticsSmsMailNo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyLogisticsSmsMailNoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>物流短信运单号校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyLogisticsSmsMailNoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyLogisticsSmsMailNoResponse
        /// </returns>
        public async Task<VerifyLogisticsSmsMailNoResponse> VerifyLogisticsSmsMailNoWithOptionsAsync(VerifyLogisticsSmsMailNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpressCompanyCode))
            {
                query["ExpressCompanyCode"] = request.ExpressCompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MailNo))
            {
                query["MailNo"] = request.MailNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformCompanyCode))
            {
                query["PlatformCompanyCode"] = request.PlatformCompanyCode;
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
                Action = "VerifyLogisticsSmsMailNo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyLogisticsSmsMailNoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>物流短信运单号校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyLogisticsSmsMailNoRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyLogisticsSmsMailNoResponse
        /// </returns>
        public VerifyLogisticsSmsMailNoResponse VerifyLogisticsSmsMailNo(VerifyLogisticsSmsMailNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyLogisticsSmsMailNoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>物流短信运单号校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyLogisticsSmsMailNoRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyLogisticsSmsMailNoResponse
        /// </returns>
        public async Task<VerifyLogisticsSmsMailNoResponse> VerifyLogisticsSmsMailNoAsync(VerifyLogisticsSmsMailNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyLogisticsSmsMailNoWithOptionsAsync(request, runtime);
        }

    }
}
