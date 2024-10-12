// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.ESA20240910.Models;

namespace AlibabaCloud.SDK.ESA20240910
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("esa", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>激活客户端证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActivateClientCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActivateClientCertificateResponse
        /// </returns>
        public ActivateClientCertificateResponse ActivateClientCertificateWithOptions(ActivateClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateClientCertificate",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateClientCertificateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>激活客户端证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActivateClientCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActivateClientCertificateResponse
        /// </returns>
        public async Task<ActivateClientCertificateResponse> ActivateClientCertificateWithOptionsAsync(ActivateClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateClientCertificate",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateClientCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>激活客户端证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActivateClientCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// ActivateClientCertificateResponse
        /// </returns>
        public ActivateClientCertificateResponse ActivateClientCertificate(ActivateClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActivateClientCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>激活客户端证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActivateClientCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// ActivateClientCertificateResponse
        /// </returns>
        public async Task<ActivateClientCertificateResponse> ActivateClientCertificateAsync(ActivateClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActivateClientCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建记录</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchCreateRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateRecordsResponse
        /// </returns>
        public BatchCreateRecordsResponse BatchCreateRecordsWithOptions(BatchCreateRecordsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchCreateRecordsShrinkRequest request = new BatchCreateRecordsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RecordList))
            {
                request.RecordListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RecordList, "RecordList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordListShrink))
            {
                query["RecordList"] = request.RecordListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCreateRecords",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateRecordsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建记录</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchCreateRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateRecordsResponse
        /// </returns>
        public async Task<BatchCreateRecordsResponse> BatchCreateRecordsWithOptionsAsync(BatchCreateRecordsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchCreateRecordsShrinkRequest request = new BatchCreateRecordsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RecordList))
            {
                request.RecordListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RecordList, "RecordList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordListShrink))
            {
                query["RecordList"] = request.RecordListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCreateRecords",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateRecordsResponse
        /// </returns>
        public BatchCreateRecordsResponse BatchCreateRecords(BatchCreateRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchCreateRecordsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateRecordsResponse
        /// </returns>
        public async Task<BatchCreateRecordsResponse> BatchCreateRecordsAsync(BatchCreateRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchCreateRecordsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建WAF规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchCreateWafRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateWafRulesResponse
        /// </returns>
        public BatchCreateWafRulesResponse BatchCreateWafRulesWithOptions(BatchCreateWafRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchCreateWafRulesShrinkRequest request = new BatchCreateWafRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Configs))
            {
                request.ConfigsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Configs, "Configs", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Shared))
            {
                request.SharedShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Shared, "Shared", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigsShrink))
            {
                body["Configs"] = request.ConfigsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                body["Phase"] = request.Phase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharedShrink))
            {
                body["Shared"] = request.SharedShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCreateWafRules",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateWafRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建WAF规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchCreateWafRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateWafRulesResponse
        /// </returns>
        public async Task<BatchCreateWafRulesResponse> BatchCreateWafRulesWithOptionsAsync(BatchCreateWafRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchCreateWafRulesShrinkRequest request = new BatchCreateWafRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Configs))
            {
                request.ConfigsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Configs, "Configs", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Shared))
            {
                request.SharedShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Shared, "Shared", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigsShrink))
            {
                body["Configs"] = request.ConfigsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                body["Phase"] = request.Phase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharedShrink))
            {
                body["Shared"] = request.SharedShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCreateWafRules",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateWafRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建WAF规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateWafRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateWafRulesResponse
        /// </returns>
        public BatchCreateWafRulesResponse BatchCreateWafRules(BatchCreateWafRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchCreateWafRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建WAF规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateWafRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateWafRulesResponse
        /// </returns>
        public async Task<BatchCreateWafRulesResponse> BatchCreateWafRulesAsync(BatchCreateWafRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchCreateWafRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除Namespace的key-value对</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchDeleteKvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteKvResponse
        /// </returns>
        public BatchDeleteKvResponse BatchDeleteKvWithOptions(BatchDeleteKvRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchDeleteKvShrinkRequest request = new BatchDeleteKvShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Keys))
            {
                request.KeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Keys, "Keys", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeysShrink))
            {
                body["Keys"] = request.KeysShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteKv",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteKvResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除Namespace的key-value对</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchDeleteKvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteKvResponse
        /// </returns>
        public async Task<BatchDeleteKvResponse> BatchDeleteKvWithOptionsAsync(BatchDeleteKvRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchDeleteKvShrinkRequest request = new BatchDeleteKvShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Keys))
            {
                request.KeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Keys, "Keys", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeysShrink))
            {
                body["Keys"] = request.KeysShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteKv",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteKvResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除Namespace的key-value对</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteKvRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteKvResponse
        /// </returns>
        public BatchDeleteKvResponse BatchDeleteKv(BatchDeleteKvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDeleteKvWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除Namespace的key-value对</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteKvRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteKvResponse
        /// </returns>
        public async Task<BatchDeleteKvResponse> BatchDeleteKvAsync(BatchDeleteKvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDeleteKvWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除Namespace下的KV队，支持大body的上传，上限100M</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteKvWithHighCapacityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteKvWithHighCapacityResponse
        /// </returns>
        public BatchDeleteKvWithHighCapacityResponse BatchDeleteKvWithHighCapacityWithOptions(BatchDeleteKvWithHighCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteKvWithHighCapacity",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteKvWithHighCapacityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除Namespace下的KV队，支持大body的上传，上限100M</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteKvWithHighCapacityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteKvWithHighCapacityResponse
        /// </returns>
        public async Task<BatchDeleteKvWithHighCapacityResponse> BatchDeleteKvWithHighCapacityWithOptionsAsync(BatchDeleteKvWithHighCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteKvWithHighCapacity",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteKvWithHighCapacityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除Namespace下的KV队，支持大body的上传，上限100M</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteKvWithHighCapacityRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteKvWithHighCapacityResponse
        /// </returns>
        public BatchDeleteKvWithHighCapacityResponse BatchDeleteKvWithHighCapacity(BatchDeleteKvWithHighCapacityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDeleteKvWithHighCapacityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除Namespace下的KV队，支持大body的上传，上限100M</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteKvWithHighCapacityRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteKvWithHighCapacityResponse
        /// </returns>
        public async Task<BatchDeleteKvWithHighCapacityResponse> BatchDeleteKvWithHighCapacityAsync(BatchDeleteKvWithHighCapacityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDeleteKvWithHighCapacityWithOptionsAsync(request, runtime);
        }

        public BatchDeleteKvWithHighCapacityResponse BatchDeleteKvWithHighCapacityAdvance(BatchDeleteKvWithHighCapacityAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "ESA",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            BatchDeleteKvWithHighCapacityRequest batchDeleteKvWithHighCapacityReq = new BatchDeleteKvWithHighCapacityRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, batchDeleteKvWithHighCapacityReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.UrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                batchDeleteKvWithHighCapacityReq.Url = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            BatchDeleteKvWithHighCapacityResponse batchDeleteKvWithHighCapacityResp = BatchDeleteKvWithHighCapacityWithOptions(batchDeleteKvWithHighCapacityReq, runtime);
            return batchDeleteKvWithHighCapacityResp;
        }

        public async Task<BatchDeleteKvWithHighCapacityResponse> BatchDeleteKvWithHighCapacityAdvanceAsync(BatchDeleteKvWithHighCapacityAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "ESA",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            BatchDeleteKvWithHighCapacityRequest batchDeleteKvWithHighCapacityReq = new BatchDeleteKvWithHighCapacityRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, batchDeleteKvWithHighCapacityReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.UrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                batchDeleteKvWithHighCapacityReq.Url = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            BatchDeleteKvWithHighCapacityResponse batchDeleteKvWithHighCapacityResp = await BatchDeleteKvWithHighCapacityWithOptionsAsync(batchDeleteKvWithHighCapacityReq, runtime);
            return batchDeleteKvWithHighCapacityResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取表达式的匹配项</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchGetExpressionFieldsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetExpressionFieldsResponse
        /// </returns>
        public BatchGetExpressionFieldsResponse BatchGetExpressionFieldsWithOptions(BatchGetExpressionFieldsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchGetExpressionFieldsShrinkRequest request = new BatchGetExpressionFieldsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Expressions))
            {
                request.ExpressionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Expressions, "Expressions", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpressionsShrink))
            {
                body["Expressions"] = request.ExpressionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                body["Phase"] = request.Phase;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetExpressionFields",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetExpressionFieldsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取表达式的匹配项</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchGetExpressionFieldsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetExpressionFieldsResponse
        /// </returns>
        public async Task<BatchGetExpressionFieldsResponse> BatchGetExpressionFieldsWithOptionsAsync(BatchGetExpressionFieldsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchGetExpressionFieldsShrinkRequest request = new BatchGetExpressionFieldsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Expressions))
            {
                request.ExpressionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Expressions, "Expressions", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpressionsShrink))
            {
                body["Expressions"] = request.ExpressionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                body["Phase"] = request.Phase;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetExpressionFields",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetExpressionFieldsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取表达式的匹配项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetExpressionFieldsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetExpressionFieldsResponse
        /// </returns>
        public BatchGetExpressionFieldsResponse BatchGetExpressionFields(BatchGetExpressionFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetExpressionFieldsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取表达式的匹配项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetExpressionFieldsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetExpressionFieldsResponse
        /// </returns>
        public async Task<BatchGetExpressionFieldsResponse> BatchGetExpressionFieldsAsync(BatchGetExpressionFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetExpressionFieldsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量设置Namespace的key-value对</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchPutKvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchPutKvResponse
        /// </returns>
        public BatchPutKvResponse BatchPutKvWithOptions(BatchPutKvRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchPutKvShrinkRequest request = new BatchPutKvShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.KvList))
            {
                request.KvListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.KvList, "KvList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KvListShrink))
            {
                body["KvList"] = request.KvListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchPutKv",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchPutKvResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量设置Namespace的key-value对</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchPutKvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchPutKvResponse
        /// </returns>
        public async Task<BatchPutKvResponse> BatchPutKvWithOptionsAsync(BatchPutKvRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchPutKvShrinkRequest request = new BatchPutKvShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.KvList))
            {
                request.KvListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.KvList, "KvList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KvListShrink))
            {
                body["KvList"] = request.KvListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchPutKv",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchPutKvResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量设置Namespace的key-value对</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchPutKvRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchPutKvResponse
        /// </returns>
        public BatchPutKvResponse BatchPutKv(BatchPutKvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchPutKvWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量设置Namespace的key-value对</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchPutKvRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchPutKvResponse
        /// </returns>
        public async Task<BatchPutKvResponse> BatchPutKvAsync(BatchPutKvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchPutKvWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量设置Namespace的key-value对，支持最大100M的请求体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchPutKvWithHighCapacityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchPutKvWithHighCapacityResponse
        /// </returns>
        public BatchPutKvWithHighCapacityResponse BatchPutKvWithHighCapacityWithOptions(BatchPutKvWithHighCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchPutKvWithHighCapacity",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchPutKvWithHighCapacityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量设置Namespace的key-value对，支持最大100M的请求体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchPutKvWithHighCapacityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchPutKvWithHighCapacityResponse
        /// </returns>
        public async Task<BatchPutKvWithHighCapacityResponse> BatchPutKvWithHighCapacityWithOptionsAsync(BatchPutKvWithHighCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchPutKvWithHighCapacity",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchPutKvWithHighCapacityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量设置Namespace的key-value对，支持最大100M的请求体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchPutKvWithHighCapacityRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchPutKvWithHighCapacityResponse
        /// </returns>
        public BatchPutKvWithHighCapacityResponse BatchPutKvWithHighCapacity(BatchPutKvWithHighCapacityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchPutKvWithHighCapacityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量设置Namespace的key-value对，支持最大100M的请求体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchPutKvWithHighCapacityRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchPutKvWithHighCapacityResponse
        /// </returns>
        public async Task<BatchPutKvWithHighCapacityResponse> BatchPutKvWithHighCapacityAsync(BatchPutKvWithHighCapacityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchPutKvWithHighCapacityWithOptionsAsync(request, runtime);
        }

        public BatchPutKvWithHighCapacityResponse BatchPutKvWithHighCapacityAdvance(BatchPutKvWithHighCapacityAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "ESA",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            BatchPutKvWithHighCapacityRequest batchPutKvWithHighCapacityReq = new BatchPutKvWithHighCapacityRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, batchPutKvWithHighCapacityReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.UrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                batchPutKvWithHighCapacityReq.Url = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            BatchPutKvWithHighCapacityResponse batchPutKvWithHighCapacityResp = BatchPutKvWithHighCapacityWithOptions(batchPutKvWithHighCapacityReq, runtime);
            return batchPutKvWithHighCapacityResp;
        }

        public async Task<BatchPutKvWithHighCapacityResponse> BatchPutKvWithHighCapacityAdvanceAsync(BatchPutKvWithHighCapacityAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "ESA",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            BatchPutKvWithHighCapacityRequest batchPutKvWithHighCapacityReq = new BatchPutKvWithHighCapacityRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, batchPutKvWithHighCapacityReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.UrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                batchPutKvWithHighCapacityReq.Url = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            BatchPutKvWithHighCapacityResponse batchPutKvWithHighCapacityResp = await BatchPutKvWithHighCapacityWithOptionsAsync(batchPutKvWithHighCapacityReq, runtime);
            return batchPutKvWithHighCapacityResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改WAF规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchUpdateWafRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateWafRulesResponse
        /// </returns>
        public BatchUpdateWafRulesResponse BatchUpdateWafRulesWithOptions(BatchUpdateWafRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchUpdateWafRulesShrinkRequest request = new BatchUpdateWafRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Configs))
            {
                request.ConfigsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Configs, "Configs", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Shared))
            {
                request.SharedShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Shared, "Shared", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigsShrink))
            {
                body["Configs"] = request.ConfigsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                body["Phase"] = request.Phase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RulesetId))
            {
                body["RulesetId"] = request.RulesetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharedShrink))
            {
                body["Shared"] = request.SharedShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUpdateWafRules",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateWafRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改WAF规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchUpdateWafRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateWafRulesResponse
        /// </returns>
        public async Task<BatchUpdateWafRulesResponse> BatchUpdateWafRulesWithOptionsAsync(BatchUpdateWafRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchUpdateWafRulesShrinkRequest request = new BatchUpdateWafRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Configs))
            {
                request.ConfigsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Configs, "Configs", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Shared))
            {
                request.SharedShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Shared, "Shared", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigsShrink))
            {
                body["Configs"] = request.ConfigsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                body["Phase"] = request.Phase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RulesetId))
            {
                body["RulesetId"] = request.RulesetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharedShrink))
            {
                body["Shared"] = request.SharedShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUpdateWafRules",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateWafRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改WAF规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateWafRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateWafRulesResponse
        /// </returns>
        public BatchUpdateWafRulesResponse BatchUpdateWafRules(BatchUpdateWafRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUpdateWafRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改WAF规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateWafRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateWafRulesResponse
        /// </returns>
        public async Task<BatchUpdateWafRulesResponse> BatchUpdateWafRulesAsync(BatchUpdateWafRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUpdateWafRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>URL封禁</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BlockObjectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BlockObjectResponse
        /// </returns>
        public BlockObjectResponse BlockObjectWithOptions(BlockObjectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BlockObjectShrinkRequest request = new BlockObjectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Content))
            {
                request.ContentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Content, "Content", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentShrink))
            {
                query["Content"] = request.ContentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                query["Extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Maxage))
            {
                query["Maxage"] = request.Maxage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
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
                Action = "BlockObject",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BlockObjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>URL封禁</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BlockObjectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BlockObjectResponse
        /// </returns>
        public async Task<BlockObjectResponse> BlockObjectWithOptionsAsync(BlockObjectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BlockObjectShrinkRequest request = new BlockObjectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Content))
            {
                request.ContentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Content, "Content", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentShrink))
            {
                query["Content"] = request.ContentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                query["Extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Maxage))
            {
                query["Maxage"] = request.Maxage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
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
                Action = "BlockObject",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BlockObjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>URL封禁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BlockObjectRequest
        /// </param>
        /// 
        /// <returns>
        /// BlockObjectResponse
        /// </returns>
        public BlockObjectResponse BlockObject(BlockObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BlockObjectWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>URL封禁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BlockObjectRequest
        /// </param>
        /// 
        /// <returns>
        /// BlockObjectResponse
        /// </returns>
        public async Task<BlockObjectResponse> BlockObjectAsync(BlockObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BlockObjectWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改站点的企业资源组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroupWithOptions(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改站点的企业资源组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupWithOptionsAsync(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改站点的企业资源组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroup(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeResourceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改站点的企业资源组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeResourceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验站点名称是否可用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckSiteNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckSiteNameResponse
        /// </returns>
        public CheckSiteNameResponse CheckSiteNameWithOptions(CheckSiteNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteName))
            {
                query["SiteName"] = request.SiteName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckSiteName",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckSiteNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验站点名称是否可用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckSiteNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckSiteNameResponse
        /// </returns>
        public async Task<CheckSiteNameResponse> CheckSiteNameWithOptionsAsync(CheckSiteNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteName))
            {
                query["SiteName"] = request.SiteName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckSiteName",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckSiteNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验站点名称是否可用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckSiteNameRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckSiteNameResponse
        /// </returns>
        public CheckSiteNameResponse CheckSiteName(CheckSiteNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckSiteNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验站点名称是否可用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckSiteNameRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckSiteNameResponse
        /// </returns>
        public async Task<CheckSiteNameResponse> CheckSiteNameAsync(CheckSiteNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckSiteNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时日志任务投递名检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckSiteProjectNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckSiteProjectNameResponse
        /// </returns>
        public CheckSiteProjectNameResponse CheckSiteProjectNameWithOptions(CheckSiteProjectNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckSiteProjectName",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckSiteProjectNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时日志任务投递名检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckSiteProjectNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckSiteProjectNameResponse
        /// </returns>
        public async Task<CheckSiteProjectNameResponse> CheckSiteProjectNameWithOptionsAsync(CheckSiteProjectNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckSiteProjectName",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckSiteProjectNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时日志任务投递名检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckSiteProjectNameRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckSiteProjectNameResponse
        /// </returns>
        public CheckSiteProjectNameResponse CheckSiteProjectName(CheckSiteProjectNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckSiteProjectNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时日志任务投递名检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckSiteProjectNameRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckSiteProjectNameResponse
        /// </returns>
        public async Task<CheckSiteProjectNameResponse> CheckSiteProjectNameAsync(CheckSiteProjectNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckSiteProjectNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时日志用户任务投递名检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckUserProjectNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckUserProjectNameResponse
        /// </returns>
        public CheckUserProjectNameResponse CheckUserProjectNameWithOptions(CheckUserProjectNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckUserProjectName",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckUserProjectNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时日志用户任务投递名检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckUserProjectNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckUserProjectNameResponse
        /// </returns>
        public async Task<CheckUserProjectNameResponse> CheckUserProjectNameWithOptionsAsync(CheckUserProjectNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckUserProjectName",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckUserProjectNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时日志用户任务投递名检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckUserProjectNameRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckUserProjectNameResponse
        /// </returns>
        public CheckUserProjectNameResponse CheckUserProjectName(CheckUserProjectNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckUserProjectNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时日志用户任务投递名检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckUserProjectNameRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckUserProjectNameResponse
        /// </returns>
        public async Task<CheckUserProjectNameResponse> CheckUserProjectNameAsync(CheckUserProjectNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckUserProjectNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建定制场景策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomScenePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomScenePolicyResponse
        /// </returns>
        public CreateCustomScenePolicyResponse CreateCustomScenePolicyWithOptions(CreateCustomScenePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Objects))
            {
                query["Objects"] = request.Objects;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Template))
            {
                query["Template"] = request.Template;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomScenePolicy",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomScenePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建定制场景策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomScenePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomScenePolicyResponse
        /// </returns>
        public async Task<CreateCustomScenePolicyResponse> CreateCustomScenePolicyWithOptionsAsync(CreateCustomScenePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Objects))
            {
                query["Objects"] = request.Objects;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Template))
            {
                query["Template"] = request.Template;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomScenePolicy",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomScenePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建定制场景策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomScenePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomScenePolicyResponse
        /// </returns>
        public CreateCustomScenePolicyResponse CreateCustomScenePolicy(CreateCustomScenePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomScenePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建定制场景策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomScenePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomScenePolicyResponse
        /// </returns>
        public async Task<CreateCustomScenePolicyResponse> CreateCustomScenePolicyAsync(CreateCustomScenePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomScenePolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加Namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKvNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKvNamespaceResponse
        /// </returns>
        public CreateKvNamespaceResponse CreateKvNamespaceWithOptions(CreateKvNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKvNamespace",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKvNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加Namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKvNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKvNamespaceResponse
        /// </returns>
        public async Task<CreateKvNamespaceResponse> CreateKvNamespaceWithOptionsAsync(CreateKvNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKvNamespace",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKvNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加Namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKvNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKvNamespaceResponse
        /// </returns>
        public CreateKvNamespaceResponse CreateKvNamespace(CreateKvNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateKvNamespaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加Namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKvNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKvNamespaceResponse
        /// </returns>
        public async Task<CreateKvNamespaceResponse> CreateKvNamespaceAsync(CreateKvNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateKvNamespaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateListResponse
        /// </returns>
        public CreateListResponse CreateListWithOptions(CreateListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateListShrinkRequest request = new CreateListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Items))
            {
                request.ItemsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Items, "Items", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemsShrink))
            {
                body["Items"] = request.ItemsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Kind))
            {
                body["Kind"] = request.Kind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateList",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateListResponse
        /// </returns>
        public async Task<CreateListResponse> CreateListWithOptionsAsync(CreateListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateListShrinkRequest request = new CreateListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Items))
            {
                request.ItemsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Items, "Items", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemsShrink))
            {
                body["Items"] = request.ItemsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Kind))
            {
                body["Kind"] = request.Kind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateList",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateListRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateListResponse
        /// </returns>
        public CreateListResponse CreateList(CreateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateListRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateListResponse
        /// </returns>
        public async Task<CreateListResponse> CreateListAsync(CreateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用CreatePage创建自定义响应页面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePageResponse
        /// </returns>
        public CreatePageResponse CreatePageWithOptions(CreatePageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["ContentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePage",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用CreatePage创建自定义响应页面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePageResponse
        /// </returns>
        public async Task<CreatePageResponse> CreatePageWithOptionsAsync(CreatePageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["ContentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePage",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用CreatePage创建自定义响应页面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePageRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePageResponse
        /// </returns>
        public CreatePageResponse CreatePage(CreatePageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用CreatePage创建自定义响应页面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePageRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePageResponse
        /// </returns>
        public async Task<CreatePageResponse> CreatePageAsync(CreatePageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建记录</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRecordResponse
        /// </returns>
        public CreateRecordResponse CreateRecordWithOptions(CreateRecordRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateRecordShrinkRequest request = new CreateRecordShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AuthConf))
            {
                request.AuthConfShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AuthConf, "AuthConf", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Data))
            {
                request.DataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Data, "Data", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfShrink))
            {
                query["AuthConf"] = request.AuthConfShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                query["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataShrink))
            {
                query["Data"] = request.DataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostPolicy))
            {
                query["HostPolicy"] = request.HostPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proxied))
            {
                query["Proxied"] = request.Proxied;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordName))
            {
                query["RecordName"] = request.RecordName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                query["Ttl"] = request.Ttl;
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
                Action = "CreateRecord",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建记录</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRecordResponse
        /// </returns>
        public async Task<CreateRecordResponse> CreateRecordWithOptionsAsync(CreateRecordRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateRecordShrinkRequest request = new CreateRecordShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AuthConf))
            {
                request.AuthConfShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AuthConf, "AuthConf", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Data))
            {
                request.DataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Data, "Data", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfShrink))
            {
                query["AuthConf"] = request.AuthConfShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                query["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataShrink))
            {
                query["Data"] = request.DataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostPolicy))
            {
                query["HostPolicy"] = request.HostPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proxied))
            {
                query["Proxied"] = request.Proxied;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordName))
            {
                query["RecordName"] = request.RecordName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                query["Ttl"] = request.Ttl;
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
                Action = "CreateRecord",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRecordResponse
        /// </returns>
        public CreateRecordResponse CreateRecord(CreateRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRecordResponse
        /// </returns>
        public async Task<CreateRecordResponse> CreateRecordAsync(CreateRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增定时预热任务的计划</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateScheduledPreloadExecutionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledPreloadExecutionsResponse
        /// </returns>
        public CreateScheduledPreloadExecutionsResponse CreateScheduledPreloadExecutionsWithOptions(CreateScheduledPreloadExecutionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateScheduledPreloadExecutionsShrinkRequest request = new CreateScheduledPreloadExecutionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Executions))
            {
                request.ExecutionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Executions, "Executions", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionsShrink))
            {
                body["Executions"] = request.ExecutionsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduledPreloadExecutions",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduledPreloadExecutionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增定时预热任务的计划</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateScheduledPreloadExecutionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledPreloadExecutionsResponse
        /// </returns>
        public async Task<CreateScheduledPreloadExecutionsResponse> CreateScheduledPreloadExecutionsWithOptionsAsync(CreateScheduledPreloadExecutionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateScheduledPreloadExecutionsShrinkRequest request = new CreateScheduledPreloadExecutionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Executions))
            {
                request.ExecutionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Executions, "Executions", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionsShrink))
            {
                body["Executions"] = request.ExecutionsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduledPreloadExecutions",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduledPreloadExecutionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增定时预热任务的计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScheduledPreloadExecutionsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledPreloadExecutionsResponse
        /// </returns>
        public CreateScheduledPreloadExecutionsResponse CreateScheduledPreloadExecutions(CreateScheduledPreloadExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScheduledPreloadExecutionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增定时预热任务的计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScheduledPreloadExecutionsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledPreloadExecutionsResponse
        /// </returns>
        public async Task<CreateScheduledPreloadExecutionsResponse> CreateScheduledPreloadExecutionsAsync(CreateScheduledPreloadExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScheduledPreloadExecutionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增定时预热任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScheduledPreloadJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledPreloadJobResponse
        /// </returns>
        public CreateScheduledPreloadJobResponse CreateScheduledPreloadJobWithOptions(CreateScheduledPreloadJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InsertWay))
            {
                body["InsertWay"] = request.InsertWay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssUrl))
            {
                body["OssUrl"] = request.OssUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                body["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlList))
            {
                body["UrlList"] = request.UrlList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduledPreloadJob",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduledPreloadJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增定时预热任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScheduledPreloadJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledPreloadJobResponse
        /// </returns>
        public async Task<CreateScheduledPreloadJobResponse> CreateScheduledPreloadJobWithOptionsAsync(CreateScheduledPreloadJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InsertWay))
            {
                body["InsertWay"] = request.InsertWay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssUrl))
            {
                body["OssUrl"] = request.OssUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                body["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlList))
            {
                body["UrlList"] = request.UrlList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduledPreloadJob",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduledPreloadJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增定时预热任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScheduledPreloadJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledPreloadJobResponse
        /// </returns>
        public CreateScheduledPreloadJobResponse CreateScheduledPreloadJob(CreateScheduledPreloadJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScheduledPreloadJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增定时预热任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScheduledPreloadJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledPreloadJobResponse
        /// </returns>
        public async Task<CreateScheduledPreloadJobResponse> CreateScheduledPreloadJobAsync(CreateScheduledPreloadJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScheduledPreloadJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建站点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSiteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSiteResponse
        /// </returns>
        public CreateSiteResponse CreateSiteWithOptions(CreateSiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessType))
            {
                query["AccessType"] = request.AccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Coverage))
            {
                query["Coverage"] = request.Coverage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteName))
            {
                query["SiteName"] = request.SiteName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSite",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSiteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建站点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSiteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSiteResponse
        /// </returns>
        public async Task<CreateSiteResponse> CreateSiteWithOptionsAsync(CreateSiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessType))
            {
                query["AccessType"] = request.AccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Coverage))
            {
                query["Coverage"] = request.Coverage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteName))
            {
                query["SiteName"] = request.SiteName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSite",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSiteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建站点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSiteRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSiteResponse
        /// </returns>
        public CreateSiteResponse CreateSite(CreateSiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSiteWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建站点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSiteRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSiteResponse
        /// </returns>
        public async Task<CreateSiteResponse> CreateSiteAsync(CreateSiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSiteWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建自定义字段</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateSiteCustomLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSiteCustomLogResponse
        /// </returns>
        public CreateSiteCustomLogResponse CreateSiteCustomLogWithOptions(CreateSiteCustomLogRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSiteCustomLogShrinkRequest request = new CreateSiteCustomLogShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Cookies))
            {
                request.CookiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Cookies, "Cookies", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestHeaders))
            {
                request.RequestHeadersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestHeaders, "RequestHeaders", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResponseHeaders))
            {
                request.ResponseHeadersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResponseHeaders, "ResponseHeaders", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CookiesShrink))
            {
                body["Cookies"] = request.CookiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestHeadersShrink))
            {
                body["RequestHeaders"] = request.RequestHeadersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseHeadersShrink))
            {
                body["ResponseHeaders"] = request.ResponseHeadersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                body["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSiteCustomLog",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSiteCustomLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建自定义字段</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateSiteCustomLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSiteCustomLogResponse
        /// </returns>
        public async Task<CreateSiteCustomLogResponse> CreateSiteCustomLogWithOptionsAsync(CreateSiteCustomLogRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSiteCustomLogShrinkRequest request = new CreateSiteCustomLogShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Cookies))
            {
                request.CookiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Cookies, "Cookies", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestHeaders))
            {
                request.RequestHeadersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestHeaders, "RequestHeaders", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResponseHeaders))
            {
                request.ResponseHeadersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResponseHeaders, "ResponseHeaders", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CookiesShrink))
            {
                body["Cookies"] = request.CookiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestHeadersShrink))
            {
                body["RequestHeaders"] = request.RequestHeadersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseHeadersShrink))
            {
                body["ResponseHeaders"] = request.ResponseHeadersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                body["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSiteCustomLog",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSiteCustomLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建自定义字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSiteCustomLogRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSiteCustomLogResponse
        /// </returns>
        public CreateSiteCustomLogResponse CreateSiteCustomLog(CreateSiteCustomLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSiteCustomLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建自定义字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSiteCustomLogRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSiteCustomLogResponse
        /// </returns>
        public async Task<CreateSiteCustomLogResponse> CreateSiteCustomLogAsync(CreateSiteCustomLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSiteCustomLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建一个任务投递</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateSiteDeliveryTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSiteDeliveryTaskResponse
        /// </returns>
        public CreateSiteDeliveryTaskResponse CreateSiteDeliveryTaskWithOptions(CreateSiteDeliveryTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSiteDeliveryTaskShrinkRequest request = new CreateSiteDeliveryTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HttpDelivery))
            {
                request.HttpDeliveryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HttpDelivery, "HttpDelivery", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.KafkaDelivery))
            {
                request.KafkaDeliveryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.KafkaDelivery, "KafkaDelivery", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OssDelivery))
            {
                request.OssDeliveryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OssDelivery, "OssDelivery", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.S3Delivery))
            {
                request.S3DeliveryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.S3Delivery, "S3Delivery", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SlsDelivery))
            {
                request.SlsDeliveryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SlsDelivery, "SlsDelivery", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                body["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCenter))
            {
                body["DataCenter"] = request.DataCenter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryType))
            {
                body["DeliveryType"] = request.DeliveryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscardRate))
            {
                body["DiscardRate"] = request.DiscardRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldName))
            {
                body["FieldName"] = request.FieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpDeliveryShrink))
            {
                body["HttpDelivery"] = request.HttpDeliveryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KafkaDeliveryShrink))
            {
                body["KafkaDelivery"] = request.KafkaDeliveryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssDeliveryShrink))
            {
                body["OssDelivery"] = request.OssDeliveryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.S3DeliveryShrink))
            {
                body["S3Delivery"] = request.S3DeliveryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                body["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsDeliveryShrink))
            {
                body["SlsDelivery"] = request.SlsDeliveryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSiteDeliveryTask",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSiteDeliveryTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建一个任务投递</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateSiteDeliveryTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSiteDeliveryTaskResponse
        /// </returns>
        public async Task<CreateSiteDeliveryTaskResponse> CreateSiteDeliveryTaskWithOptionsAsync(CreateSiteDeliveryTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSiteDeliveryTaskShrinkRequest request = new CreateSiteDeliveryTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HttpDelivery))
            {
                request.HttpDeliveryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HttpDelivery, "HttpDelivery", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.KafkaDelivery))
            {
                request.KafkaDeliveryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.KafkaDelivery, "KafkaDelivery", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OssDelivery))
            {
                request.OssDeliveryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OssDelivery, "OssDelivery", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.S3Delivery))
            {
                request.S3DeliveryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.S3Delivery, "S3Delivery", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SlsDelivery))
            {
                request.SlsDeliveryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SlsDelivery, "SlsDelivery", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                body["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCenter))
            {
                body["DataCenter"] = request.DataCenter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryType))
            {
                body["DeliveryType"] = request.DeliveryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscardRate))
            {
                body["DiscardRate"] = request.DiscardRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldName))
            {
                body["FieldName"] = request.FieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpDeliveryShrink))
            {
                body["HttpDelivery"] = request.HttpDeliveryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KafkaDeliveryShrink))
            {
                body["KafkaDelivery"] = request.KafkaDeliveryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssDeliveryShrink))
            {
                body["OssDelivery"] = request.OssDeliveryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.S3DeliveryShrink))
            {
                body["S3Delivery"] = request.S3DeliveryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                body["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsDeliveryShrink))
            {
                body["SlsDelivery"] = request.SlsDeliveryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSiteDeliveryTask",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSiteDeliveryTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建一个任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSiteDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSiteDeliveryTaskResponse
        /// </returns>
        public CreateSiteDeliveryTaskResponse CreateSiteDeliveryTask(CreateSiteDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSiteDeliveryTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建一个任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSiteDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSiteDeliveryTaskResponse
        /// </returns>
        public async Task<CreateSiteDeliveryTaskResponse> CreateSiteDeliveryTaskAsync(CreateSiteDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSiteDeliveryTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建一个用户粒度任务投递</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateUserDeliveryTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserDeliveryTaskResponse
        /// </returns>
        public CreateUserDeliveryTaskResponse CreateUserDeliveryTaskWithOptions(CreateUserDeliveryTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateUserDeliveryTaskShrinkRequest request = new CreateUserDeliveryTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HttpDelivery))
            {
                request.HttpDeliveryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HttpDelivery, "HttpDelivery", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.KafkaDelivery))
            {
                request.KafkaDeliveryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.KafkaDelivery, "KafkaDelivery", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OssDelivery))
            {
                request.OssDeliveryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OssDelivery, "OssDelivery", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.S3Delivery))
            {
                request.S3DeliveryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.S3Delivery, "S3Delivery", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SlsDelivery))
            {
                request.SlsDeliveryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SlsDelivery, "SlsDelivery", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                body["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCenter))
            {
                body["DataCenter"] = request.DataCenter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryType))
            {
                body["DeliveryType"] = request.DeliveryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscardRate))
            {
                body["DiscardRate"] = request.DiscardRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldName))
            {
                body["FieldName"] = request.FieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpDeliveryShrink))
            {
                body["HttpDelivery"] = request.HttpDeliveryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KafkaDeliveryShrink))
            {
                body["KafkaDelivery"] = request.KafkaDeliveryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssDeliveryShrink))
            {
                body["OssDelivery"] = request.OssDeliveryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.S3DeliveryShrink))
            {
                body["S3Delivery"] = request.S3DeliveryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsDeliveryShrink))
            {
                body["SlsDelivery"] = request.SlsDeliveryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserDeliveryTask",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserDeliveryTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建一个用户粒度任务投递</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateUserDeliveryTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserDeliveryTaskResponse
        /// </returns>
        public async Task<CreateUserDeliveryTaskResponse> CreateUserDeliveryTaskWithOptionsAsync(CreateUserDeliveryTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateUserDeliveryTaskShrinkRequest request = new CreateUserDeliveryTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HttpDelivery))
            {
                request.HttpDeliveryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HttpDelivery, "HttpDelivery", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.KafkaDelivery))
            {
                request.KafkaDeliveryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.KafkaDelivery, "KafkaDelivery", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OssDelivery))
            {
                request.OssDeliveryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OssDelivery, "OssDelivery", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.S3Delivery))
            {
                request.S3DeliveryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.S3Delivery, "S3Delivery", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SlsDelivery))
            {
                request.SlsDeliveryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SlsDelivery, "SlsDelivery", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                body["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCenter))
            {
                body["DataCenter"] = request.DataCenter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryType))
            {
                body["DeliveryType"] = request.DeliveryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscardRate))
            {
                body["DiscardRate"] = request.DiscardRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldName))
            {
                body["FieldName"] = request.FieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpDeliveryShrink))
            {
                body["HttpDelivery"] = request.HttpDeliveryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KafkaDeliveryShrink))
            {
                body["KafkaDelivery"] = request.KafkaDeliveryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssDeliveryShrink))
            {
                body["OssDelivery"] = request.OssDeliveryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.S3DeliveryShrink))
            {
                body["S3Delivery"] = request.S3DeliveryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsDeliveryShrink))
            {
                body["SlsDelivery"] = request.SlsDeliveryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserDeliveryTask",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserDeliveryTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建一个用户粒度任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserDeliveryTaskResponse
        /// </returns>
        public CreateUserDeliveryTaskResponse CreateUserDeliveryTask(CreateUserDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserDeliveryTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建一个用户粒度任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserDeliveryTaskResponse
        /// </returns>
        public async Task<CreateUserDeliveryTaskResponse> CreateUserDeliveryTaskAsync(CreateUserDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserDeliveryTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建WAF规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateWafRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWafRuleResponse
        /// </returns>
        public CreateWafRuleResponse CreateWafRuleWithOptions(CreateWafRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateWafRuleShrinkRequest request = new CreateWafRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Config))
            {
                request.ConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Config, "Config", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigShrink))
            {
                body["Config"] = request.ConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                body["Phase"] = request.Phase;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWafRule",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWafRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建WAF规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateWafRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWafRuleResponse
        /// </returns>
        public async Task<CreateWafRuleResponse> CreateWafRuleWithOptionsAsync(CreateWafRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateWafRuleShrinkRequest request = new CreateWafRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Config))
            {
                request.ConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Config, "Config", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigShrink))
            {
                body["Config"] = request.ConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                body["Phase"] = request.Phase;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWafRule",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWafRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建WAF规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWafRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWafRuleResponse
        /// </returns>
        public CreateWafRuleResponse CreateWafRule(CreateWafRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWafRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建WAF规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWafRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWafRuleResponse
        /// </returns>
        public async Task<CreateWafRuleResponse> CreateWafRuleAsync(CreateWafRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWafRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建等候室</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateWaitingRoomRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWaitingRoomResponse
        /// </returns>
        public CreateWaitingRoomResponse CreateWaitingRoomWithOptions(CreateWaitingRoomRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateWaitingRoomShrinkRequest request = new CreateWaitingRoomShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HostNameAndPath))
            {
                request.HostNameAndPathShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HostNameAndPath, "HostNameAndPath", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CookieName))
            {
                query["CookieName"] = request.CookieName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPageHtml))
            {
                query["CustomPageHtml"] = request.CustomPageHtml;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableSessionRenewalEnable))
            {
                query["DisableSessionRenewalEnable"] = request.DisableSessionRenewalEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostNameAndPathShrink))
            {
                query["HostNameAndPath"] = request.HostNameAndPathShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonResponseEnable))
            {
                query["JsonResponseEnable"] = request.JsonResponseEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewUsersPerMinute))
            {
                query["NewUsersPerMinute"] = request.NewUsersPerMinute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueAllEnable))
            {
                query["QueueAllEnable"] = request.QueueAllEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueuingMethod))
            {
                query["QueuingMethod"] = request.QueuingMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueuingStatusCode))
            {
                query["QueuingStatusCode"] = request.QueuingStatusCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionDuration))
            {
                query["SessionDuration"] = request.SessionDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalActiveUsers))
            {
                query["TotalActiveUsers"] = request.TotalActiveUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomType))
            {
                query["WaitingRoomType"] = request.WaitingRoomType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWaitingRoom",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWaitingRoomResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建等候室</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateWaitingRoomRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWaitingRoomResponse
        /// </returns>
        public async Task<CreateWaitingRoomResponse> CreateWaitingRoomWithOptionsAsync(CreateWaitingRoomRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateWaitingRoomShrinkRequest request = new CreateWaitingRoomShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HostNameAndPath))
            {
                request.HostNameAndPathShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HostNameAndPath, "HostNameAndPath", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CookieName))
            {
                query["CookieName"] = request.CookieName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPageHtml))
            {
                query["CustomPageHtml"] = request.CustomPageHtml;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableSessionRenewalEnable))
            {
                query["DisableSessionRenewalEnable"] = request.DisableSessionRenewalEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostNameAndPathShrink))
            {
                query["HostNameAndPath"] = request.HostNameAndPathShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonResponseEnable))
            {
                query["JsonResponseEnable"] = request.JsonResponseEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewUsersPerMinute))
            {
                query["NewUsersPerMinute"] = request.NewUsersPerMinute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueAllEnable))
            {
                query["QueueAllEnable"] = request.QueueAllEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueuingMethod))
            {
                query["QueuingMethod"] = request.QueuingMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueuingStatusCode))
            {
                query["QueuingStatusCode"] = request.QueuingStatusCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionDuration))
            {
                query["SessionDuration"] = request.SessionDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalActiveUsers))
            {
                query["TotalActiveUsers"] = request.TotalActiveUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomType))
            {
                query["WaitingRoomType"] = request.WaitingRoomType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWaitingRoom",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWaitingRoomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建等候室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWaitingRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWaitingRoomResponse
        /// </returns>
        public CreateWaitingRoomResponse CreateWaitingRoom(CreateWaitingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWaitingRoomWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建等候室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWaitingRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWaitingRoomResponse
        /// </returns>
        public async Task<CreateWaitingRoomResponse> CreateWaitingRoomAsync(CreateWaitingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWaitingRoomWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建等候室事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWaitingRoomEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWaitingRoomEventResponse
        /// </returns>
        public CreateWaitingRoomEventResponse CreateWaitingRoomEventWithOptions(CreateWaitingRoomEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPageHtml))
            {
                query["CustomPageHtml"] = request.CustomPageHtml;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableSessionRenewalEnable))
            {
                query["DisableSessionRenewalEnable"] = request.DisableSessionRenewalEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonResponseEnable))
            {
                query["JsonResponseEnable"] = request.JsonResponseEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewUsersPerMinute))
            {
                query["NewUsersPerMinute"] = request.NewUsersPerMinute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreQueueEnable))
            {
                query["PreQueueEnable"] = request.PreQueueEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreQueueStartTime))
            {
                query["PreQueueStartTime"] = request.PreQueueStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueuingMethod))
            {
                query["QueuingMethod"] = request.QueuingMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueuingStatusCode))
            {
                query["QueuingStatusCode"] = request.QueuingStatusCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RandomPreQueueEnable))
            {
                query["RandomPreQueueEnable"] = request.RandomPreQueueEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionDuration))
            {
                query["SessionDuration"] = request.SessionDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalActiveUsers))
            {
                query["TotalActiveUsers"] = request.TotalActiveUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomId))
            {
                query["WaitingRoomId"] = request.WaitingRoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomType))
            {
                query["WaitingRoomType"] = request.WaitingRoomType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWaitingRoomEvent",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWaitingRoomEventResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建等候室事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWaitingRoomEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWaitingRoomEventResponse
        /// </returns>
        public async Task<CreateWaitingRoomEventResponse> CreateWaitingRoomEventWithOptionsAsync(CreateWaitingRoomEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPageHtml))
            {
                query["CustomPageHtml"] = request.CustomPageHtml;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableSessionRenewalEnable))
            {
                query["DisableSessionRenewalEnable"] = request.DisableSessionRenewalEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonResponseEnable))
            {
                query["JsonResponseEnable"] = request.JsonResponseEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewUsersPerMinute))
            {
                query["NewUsersPerMinute"] = request.NewUsersPerMinute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreQueueEnable))
            {
                query["PreQueueEnable"] = request.PreQueueEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreQueueStartTime))
            {
                query["PreQueueStartTime"] = request.PreQueueStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueuingMethod))
            {
                query["QueuingMethod"] = request.QueuingMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueuingStatusCode))
            {
                query["QueuingStatusCode"] = request.QueuingStatusCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RandomPreQueueEnable))
            {
                query["RandomPreQueueEnable"] = request.RandomPreQueueEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionDuration))
            {
                query["SessionDuration"] = request.SessionDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalActiveUsers))
            {
                query["TotalActiveUsers"] = request.TotalActiveUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomId))
            {
                query["WaitingRoomId"] = request.WaitingRoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomType))
            {
                query["WaitingRoomType"] = request.WaitingRoomType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWaitingRoomEvent",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWaitingRoomEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建等候室事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWaitingRoomEventRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWaitingRoomEventResponse
        /// </returns>
        public CreateWaitingRoomEventResponse CreateWaitingRoomEvent(CreateWaitingRoomEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWaitingRoomEventWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建等候室事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWaitingRoomEventRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWaitingRoomEventResponse
        /// </returns>
        public async Task<CreateWaitingRoomEventResponse> CreateWaitingRoomEventAsync(CreateWaitingRoomEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWaitingRoomEventWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建等候室规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWaitingRoomRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWaitingRoomRuleResponse
        /// </returns>
        public CreateWaitingRoomRuleResponse CreateWaitingRoomRuleWithOptions(CreateWaitingRoomRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                query["Rule"] = request.Rule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleEnable))
            {
                query["RuleEnable"] = request.RuleEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomId))
            {
                query["WaitingRoomId"] = request.WaitingRoomId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWaitingRoomRule",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWaitingRoomRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建等候室规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWaitingRoomRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWaitingRoomRuleResponse
        /// </returns>
        public async Task<CreateWaitingRoomRuleResponse> CreateWaitingRoomRuleWithOptionsAsync(CreateWaitingRoomRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                query["Rule"] = request.Rule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleEnable))
            {
                query["RuleEnable"] = request.RuleEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomId))
            {
                query["WaitingRoomId"] = request.WaitingRoomId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWaitingRoomRule",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWaitingRoomRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建等候室规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWaitingRoomRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWaitingRoomRuleResponse
        /// </returns>
        public CreateWaitingRoomRuleResponse CreateWaitingRoomRule(CreateWaitingRoomRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWaitingRoomRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建等候室规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWaitingRoomRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWaitingRoomRuleResponse
        /// </returns>
        public async Task<CreateWaitingRoomRuleResponse> CreateWaitingRoomRuleAsync(CreateWaitingRoomRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWaitingRoomRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除定制场景策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomScenePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomScenePolicyResponse
        /// </returns>
        public DeleteCustomScenePolicyResponse DeleteCustomScenePolicyWithOptions(DeleteCustomScenePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomScenePolicy",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomScenePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除定制场景策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomScenePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomScenePolicyResponse
        /// </returns>
        public async Task<DeleteCustomScenePolicyResponse> DeleteCustomScenePolicyWithOptionsAsync(DeleteCustomScenePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomScenePolicy",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomScenePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除定制场景策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomScenePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomScenePolicyResponse
        /// </returns>
        public DeleteCustomScenePolicyResponse DeleteCustomScenePolicy(DeleteCustomScenePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomScenePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除定制场景策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomScenePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomScenePolicyResponse
        /// </returns>
        public async Task<DeleteCustomScenePolicyResponse> DeleteCustomScenePolicyAsync(DeleteCustomScenePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomScenePolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Namespace的Key-Value对</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKvResponse
        /// </returns>
        public DeleteKvResponse DeleteKvWithOptions(DeleteKvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKv",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKvResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Namespace的Key-Value对</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKvResponse
        /// </returns>
        public async Task<DeleteKvResponse> DeleteKvWithOptionsAsync(DeleteKvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKv",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKvResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Namespace的Key-Value对</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKvRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteKvResponse
        /// </returns>
        public DeleteKvResponse DeleteKv(DeleteKvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteKvWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Namespace的Key-Value对</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKvRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteKvResponse
        /// </returns>
        public async Task<DeleteKvResponse> DeleteKvAsync(DeleteKvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteKvWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKvNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKvNamespaceResponse
        /// </returns>
        public DeleteKvNamespaceResponse DeleteKvNamespaceWithOptions(DeleteKvNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKvNamespace",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKvNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKvNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKvNamespaceResponse
        /// </returns>
        public async Task<DeleteKvNamespaceResponse> DeleteKvNamespaceWithOptionsAsync(DeleteKvNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKvNamespace",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKvNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKvNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteKvNamespaceResponse
        /// </returns>
        public DeleteKvNamespaceResponse DeleteKvNamespace(DeleteKvNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteKvNamespaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKvNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteKvNamespaceResponse
        /// </returns>
        public async Task<DeleteKvNamespaceResponse> DeleteKvNamespaceAsync(DeleteKvNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteKvNamespaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteListResponse
        /// </returns>
        public DeleteListResponse DeleteListWithOptions(DeleteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteList",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteListResponse
        /// </returns>
        public async Task<DeleteListResponse> DeleteListWithOptionsAsync(DeleteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteList",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteListRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteListResponse
        /// </returns>
        public DeleteListResponse DeleteList(DeleteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteListRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteListResponse
        /// </returns>
        public async Task<DeleteListResponse> DeleteListAsync(DeleteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义响应页面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePageResponse
        /// </returns>
        public DeletePageResponse DeletePageWithOptions(DeletePageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePage",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义响应页面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePageResponse
        /// </returns>
        public async Task<DeletePageResponse> DeletePageWithOptionsAsync(DeletePageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePage",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义响应页面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePageRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePageResponse
        /// </returns>
        public DeletePageResponse DeletePage(DeletePageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义响应页面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePageRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePageResponse
        /// </returns>
        public async Task<DeletePageResponse> DeletePageAsync(DeletePageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRecordResponse
        /// </returns>
        public DeleteRecordResponse DeleteRecordWithOptions(DeleteRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["RecordId"] = request.RecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRecord",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRecordResponse
        /// </returns>
        public async Task<DeleteRecordResponse> DeleteRecordWithOptionsAsync(DeleteRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["RecordId"] = request.RecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRecord",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRecordResponse
        /// </returns>
        public DeleteRecordResponse DeleteRecord(DeleteRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRecordResponse
        /// </returns>
        public async Task<DeleteRecordResponse> DeleteRecordAsync(DeleteRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除单个定时预热计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScheduledPreloadExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduledPreloadExecutionResponse
        /// </returns>
        public DeleteScheduledPreloadExecutionResponse DeleteScheduledPreloadExecutionWithOptions(DeleteScheduledPreloadExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScheduledPreloadExecution",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScheduledPreloadExecutionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除单个定时预热计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScheduledPreloadExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduledPreloadExecutionResponse
        /// </returns>
        public async Task<DeleteScheduledPreloadExecutionResponse> DeleteScheduledPreloadExecutionWithOptionsAsync(DeleteScheduledPreloadExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScheduledPreloadExecution",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScheduledPreloadExecutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除单个定时预热计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScheduledPreloadExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduledPreloadExecutionResponse
        /// </returns>
        public DeleteScheduledPreloadExecutionResponse DeleteScheduledPreloadExecution(DeleteScheduledPreloadExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScheduledPreloadExecutionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除单个定时预热计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScheduledPreloadExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduledPreloadExecutionResponse
        /// </returns>
        public async Task<DeleteScheduledPreloadExecutionResponse> DeleteScheduledPreloadExecutionAsync(DeleteScheduledPreloadExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScheduledPreloadExecutionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定定时预热任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScheduledPreloadJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduledPreloadJobResponse
        /// </returns>
        public DeleteScheduledPreloadJobResponse DeleteScheduledPreloadJobWithOptions(DeleteScheduledPreloadJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScheduledPreloadJob",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScheduledPreloadJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定定时预热任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScheduledPreloadJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduledPreloadJobResponse
        /// </returns>
        public async Task<DeleteScheduledPreloadJobResponse> DeleteScheduledPreloadJobWithOptionsAsync(DeleteScheduledPreloadJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScheduledPreloadJob",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScheduledPreloadJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定定时预热任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScheduledPreloadJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduledPreloadJobResponse
        /// </returns>
        public DeleteScheduledPreloadJobResponse DeleteScheduledPreloadJob(DeleteScheduledPreloadJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScheduledPreloadJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定定时预热任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScheduledPreloadJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduledPreloadJobResponse
        /// </returns>
        public async Task<DeleteScheduledPreloadJobResponse> DeleteScheduledPreloadJobAsync(DeleteScheduledPreloadJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScheduledPreloadJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除站点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSiteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSiteResponse
        /// </returns>
        public DeleteSiteResponse DeleteSiteWithOptions(DeleteSiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSite",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSiteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除站点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSiteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSiteResponse
        /// </returns>
        public async Task<DeleteSiteResponse> DeleteSiteWithOptionsAsync(DeleteSiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSite",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSiteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除站点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSiteRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSiteResponse
        /// </returns>
        public DeleteSiteResponse DeleteSite(DeleteSiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSiteWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除站点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSiteRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSiteResponse
        /// </returns>
        public async Task<DeleteSiteResponse> DeleteSiteAsync(DeleteSiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSiteWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSiteDeliveryTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSiteDeliveryTaskResponse
        /// </returns>
        public DeleteSiteDeliveryTaskResponse DeleteSiteDeliveryTaskWithOptions(DeleteSiteDeliveryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                body["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSiteDeliveryTask",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSiteDeliveryTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSiteDeliveryTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSiteDeliveryTaskResponse
        /// </returns>
        public async Task<DeleteSiteDeliveryTaskResponse> DeleteSiteDeliveryTaskWithOptionsAsync(DeleteSiteDeliveryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                body["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSiteDeliveryTask",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSiteDeliveryTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSiteDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSiteDeliveryTaskResponse
        /// </returns>
        public DeleteSiteDeliveryTaskResponse DeleteSiteDeliveryTask(DeleteSiteDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSiteDeliveryTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSiteDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSiteDeliveryTaskResponse
        /// </returns>
        public async Task<DeleteSiteDeliveryTaskResponse> DeleteSiteDeliveryTaskAsync(DeleteSiteDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSiteDeliveryTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个用户任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserDeliveryTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserDeliveryTaskResponse
        /// </returns>
        public DeleteUserDeliveryTaskResponse DeleteUserDeliveryTaskWithOptions(DeleteUserDeliveryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserDeliveryTask",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserDeliveryTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个用户任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserDeliveryTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserDeliveryTaskResponse
        /// </returns>
        public async Task<DeleteUserDeliveryTaskResponse> DeleteUserDeliveryTaskWithOptionsAsync(DeleteUserDeliveryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserDeliveryTask",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserDeliveryTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个用户任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserDeliveryTaskResponse
        /// </returns>
        public DeleteUserDeliveryTaskResponse DeleteUserDeliveryTask(DeleteUserDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserDeliveryTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个用户任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserDeliveryTaskResponse
        /// </returns>
        public async Task<DeleteUserDeliveryTaskResponse> DeleteUserDeliveryTaskAsync(DeleteUserDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserDeliveryTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除WAF规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWafRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWafRuleResponse
        /// </returns>
        public DeleteWafRuleResponse DeleteWafRuleWithOptions(DeleteWafRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWafRule",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWafRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除WAF规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWafRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWafRuleResponse
        /// </returns>
        public async Task<DeleteWafRuleResponse> DeleteWafRuleWithOptionsAsync(DeleteWafRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWafRule",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWafRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除WAF规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWafRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWafRuleResponse
        /// </returns>
        public DeleteWafRuleResponse DeleteWafRule(DeleteWafRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWafRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除WAF规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWafRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWafRuleResponse
        /// </returns>
        public async Task<DeleteWafRuleResponse> DeleteWafRuleAsync(DeleteWafRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWafRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除WAF规则集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWafRulesetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWafRulesetResponse
        /// </returns>
        public DeleteWafRulesetResponse DeleteWafRulesetWithOptions(DeleteWafRulesetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWafRuleset",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWafRulesetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除WAF规则集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWafRulesetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWafRulesetResponse
        /// </returns>
        public async Task<DeleteWafRulesetResponse> DeleteWafRulesetWithOptionsAsync(DeleteWafRulesetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWafRuleset",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWafRulesetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除WAF规则集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWafRulesetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWafRulesetResponse
        /// </returns>
        public DeleteWafRulesetResponse DeleteWafRuleset(DeleteWafRulesetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWafRulesetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除WAF规则集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWafRulesetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWafRulesetResponse
        /// </returns>
        public async Task<DeleteWafRulesetResponse> DeleteWafRulesetAsync(DeleteWafRulesetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWafRulesetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除等候室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWaitingRoomRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWaitingRoomResponse
        /// </returns>
        public DeleteWaitingRoomResponse DeleteWaitingRoomWithOptions(DeleteWaitingRoomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomId))
            {
                query["WaitingRoomId"] = request.WaitingRoomId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWaitingRoom",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWaitingRoomResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除等候室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWaitingRoomRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWaitingRoomResponse
        /// </returns>
        public async Task<DeleteWaitingRoomResponse> DeleteWaitingRoomWithOptionsAsync(DeleteWaitingRoomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomId))
            {
                query["WaitingRoomId"] = request.WaitingRoomId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWaitingRoom",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWaitingRoomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除等候室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWaitingRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWaitingRoomResponse
        /// </returns>
        public DeleteWaitingRoomResponse DeleteWaitingRoom(DeleteWaitingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWaitingRoomWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除等候室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWaitingRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWaitingRoomResponse
        /// </returns>
        public async Task<DeleteWaitingRoomResponse> DeleteWaitingRoomAsync(DeleteWaitingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWaitingRoomWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除等候室事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWaitingRoomEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWaitingRoomEventResponse
        /// </returns>
        public DeleteWaitingRoomEventResponse DeleteWaitingRoomEventWithOptions(DeleteWaitingRoomEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomEventId))
            {
                query["WaitingRoomEventId"] = request.WaitingRoomEventId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWaitingRoomEvent",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWaitingRoomEventResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除等候室事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWaitingRoomEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWaitingRoomEventResponse
        /// </returns>
        public async Task<DeleteWaitingRoomEventResponse> DeleteWaitingRoomEventWithOptionsAsync(DeleteWaitingRoomEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomEventId))
            {
                query["WaitingRoomEventId"] = request.WaitingRoomEventId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWaitingRoomEvent",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWaitingRoomEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除等候室事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWaitingRoomEventRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWaitingRoomEventResponse
        /// </returns>
        public DeleteWaitingRoomEventResponse DeleteWaitingRoomEvent(DeleteWaitingRoomEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWaitingRoomEventWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除等候室事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWaitingRoomEventRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWaitingRoomEventResponse
        /// </returns>
        public async Task<DeleteWaitingRoomEventResponse> DeleteWaitingRoomEventAsync(DeleteWaitingRoomEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWaitingRoomEventWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除等候室规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWaitingRoomRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWaitingRoomRuleResponse
        /// </returns>
        public DeleteWaitingRoomRuleResponse DeleteWaitingRoomRuleWithOptions(DeleteWaitingRoomRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomRuleId))
            {
                query["WaitingRoomRuleId"] = request.WaitingRoomRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWaitingRoomRule",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWaitingRoomRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除等候室规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWaitingRoomRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWaitingRoomRuleResponse
        /// </returns>
        public async Task<DeleteWaitingRoomRuleResponse> DeleteWaitingRoomRuleWithOptionsAsync(DeleteWaitingRoomRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomRuleId))
            {
                query["WaitingRoomRuleId"] = request.WaitingRoomRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWaitingRoomRule",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWaitingRoomRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除等候室规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWaitingRoomRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWaitingRoomRuleResponse
        /// </returns>
        public DeleteWaitingRoomRuleResponse DeleteWaitingRoomRule(DeleteWaitingRoomRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWaitingRoomRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除等候室规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWaitingRoomRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWaitingRoomRuleResponse
        /// </returns>
        public async Task<DeleteWaitingRoomRuleResponse> DeleteWaitingRoomRuleAsync(DeleteWaitingRoomRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWaitingRoomRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询定制场景策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomScenePoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomScenePoliciesResponse
        /// </returns>
        public DescribeCustomScenePoliciesResponse DescribeCustomScenePoliciesWithOptions(DescribeCustomScenePoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomScenePolicies",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomScenePoliciesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询定制场景策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomScenePoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomScenePoliciesResponse
        /// </returns>
        public async Task<DescribeCustomScenePoliciesResponse> DescribeCustomScenePoliciesWithOptionsAsync(DescribeCustomScenePoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomScenePolicies",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomScenePoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询定制场景策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomScenePoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomScenePoliciesResponse
        /// </returns>
        public DescribeCustomScenePoliciesResponse DescribeCustomScenePolicies(DescribeCustomScenePoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomScenePoliciesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询定制场景策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomScenePoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomScenePoliciesResponse
        /// </returns>
        public async Task<DescribeCustomScenePoliciesResponse> DescribeCustomScenePoliciesAsync(DescribeCustomScenePoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomScenePoliciesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>攻击分析-查询攻击事件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDDoSAllEventListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDDoSAllEventListResponse
        /// </returns>
        public DescribeDDoSAllEventListResponse DescribeDDoSAllEventListWithOptions(DescribeDDoSAllEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
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
                Action = "DescribeDDoSAllEventList",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDDoSAllEventListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>攻击分析-查询攻击事件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDDoSAllEventListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDDoSAllEventListResponse
        /// </returns>
        public async Task<DescribeDDoSAllEventListResponse> DescribeDDoSAllEventListWithOptionsAsync(DescribeDDoSAllEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
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
                Action = "DescribeDDoSAllEventList",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDDoSAllEventListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>攻击分析-查询攻击事件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDDoSAllEventListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDDoSAllEventListResponse
        /// </returns>
        public DescribeDDoSAllEventListResponse DescribeDDoSAllEventList(DescribeDDoSAllEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDDoSAllEventListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>攻击分析-查询攻击事件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDDoSAllEventListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDDoSAllEventListResponse
        /// </returns>
        public async Task<DescribeDDoSAllEventListResponse> DescribeDDoSAllEventListAsync(DescribeDDoSAllEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDDoSAllEventListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询HTTP DDoS智能防护配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHttpDDoSAttackIntelligentProtectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHttpDDoSAttackIntelligentProtectionResponse
        /// </returns>
        public DescribeHttpDDoSAttackIntelligentProtectionResponse DescribeHttpDDoSAttackIntelligentProtectionWithOptions(DescribeHttpDDoSAttackIntelligentProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHttpDDoSAttackIntelligentProtection",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHttpDDoSAttackIntelligentProtectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询HTTP DDoS智能防护配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHttpDDoSAttackIntelligentProtectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHttpDDoSAttackIntelligentProtectionResponse
        /// </returns>
        public async Task<DescribeHttpDDoSAttackIntelligentProtectionResponse> DescribeHttpDDoSAttackIntelligentProtectionWithOptionsAsync(DescribeHttpDDoSAttackIntelligentProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHttpDDoSAttackIntelligentProtection",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHttpDDoSAttackIntelligentProtectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询HTTP DDoS智能防护配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHttpDDoSAttackIntelligentProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHttpDDoSAttackIntelligentProtectionResponse
        /// </returns>
        public DescribeHttpDDoSAttackIntelligentProtectionResponse DescribeHttpDDoSAttackIntelligentProtection(DescribeHttpDDoSAttackIntelligentProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHttpDDoSAttackIntelligentProtectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询HTTP DDoS智能防护配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHttpDDoSAttackIntelligentProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHttpDDoSAttackIntelligentProtectionResponse
        /// </returns>
        public async Task<DescribeHttpDDoSAttackIntelligentProtectionResponse> DescribeHttpDDoSAttackIntelligentProtectionAsync(DescribeHttpDDoSAttackIntelligentProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHttpDDoSAttackIntelligentProtectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询HTTP DDoS攻击防护配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHttpDDoSAttackProtectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHttpDDoSAttackProtectionResponse
        /// </returns>
        public DescribeHttpDDoSAttackProtectionResponse DescribeHttpDDoSAttackProtectionWithOptions(DescribeHttpDDoSAttackProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHttpDDoSAttackProtection",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHttpDDoSAttackProtectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询HTTP DDoS攻击防护配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHttpDDoSAttackProtectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHttpDDoSAttackProtectionResponse
        /// </returns>
        public async Task<DescribeHttpDDoSAttackProtectionResponse> DescribeHttpDDoSAttackProtectionWithOptionsAsync(DescribeHttpDDoSAttackProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHttpDDoSAttackProtection",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHttpDDoSAttackProtectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询HTTP DDoS攻击防护配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHttpDDoSAttackProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHttpDDoSAttackProtectionResponse
        /// </returns>
        public DescribeHttpDDoSAttackProtectionResponse DescribeHttpDDoSAttackProtection(DescribeHttpDDoSAttackProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHttpDDoSAttackProtectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询HTTP DDoS攻击防护配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHttpDDoSAttackProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHttpDDoSAttackProtectionResponse
        /// </returns>
        public async Task<DescribeHttpDDoSAttackProtectionResponse> DescribeHttpDDoSAttackProtectionAsync(DescribeHttpDDoSAttackProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHttpDDoSAttackProtectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询加速服务节点IP段列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeIPRangeListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeIPRangeListResponse
        /// </returns>
        public DescribeIPRangeListResponse DescribeIPRangeListWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIPRangeList",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIPRangeListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询加速服务节点IP段列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeIPRangeListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeIPRangeListResponse
        /// </returns>
        public async Task<DescribeIPRangeListResponse> DescribeIPRangeListWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIPRangeList",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIPRangeListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询加速服务节点IP段列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeIPRangeListResponse
        /// </returns>
        public DescribeIPRangeListResponse DescribeIPRangeList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIPRangeListWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询加速服务节点IP段列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeIPRangeListResponse
        /// </returns>
        public async Task<DescribeIPRangeListResponse> DescribeIPRangeListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIPRangeListWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询账户的KV状态信</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeKvAccountStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeKvAccountStatusResponse
        /// </returns>
        public DescribeKvAccountStatusResponse DescribeKvAccountStatusWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeKvAccountStatus",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeKvAccountStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询账户的KV状态信</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeKvAccountStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeKvAccountStatusResponse
        /// </returns>
        public async Task<DescribeKvAccountStatusResponse> DescribeKvAccountStatusWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeKvAccountStatus",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeKvAccountStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询账户的KV状态信</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeKvAccountStatusResponse
        /// </returns>
        public DescribeKvAccountStatusResponse DescribeKvAccountStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeKvAccountStatusWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询账户的KV状态信</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeKvAccountStatusResponse
        /// </returns>
        public async Task<DescribeKvAccountStatusResponse> DescribeKvAccountStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeKvAccountStatusWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预热任务查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePreloadTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePreloadTasksResponse
        /// </returns>
        public DescribePreloadTasksResponse DescribePreloadTasksWithOptions(DescribePreloadTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePreloadTasks",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePreloadTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预热任务查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePreloadTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePreloadTasksResponse
        /// </returns>
        public async Task<DescribePreloadTasksResponse> DescribePreloadTasksWithOptionsAsync(DescribePreloadTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePreloadTasks",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePreloadTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预热任务查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePreloadTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePreloadTasksResponse
        /// </returns>
        public DescribePreloadTasksResponse DescribePreloadTasks(DescribePreloadTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePreloadTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预热任务查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePreloadTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePreloadTasksResponse
        /// </returns>
        public async Task<DescribePreloadTasksResponse> DescribePreloadTasksAsync(DescribePreloadTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePreloadTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>刷新任务查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePurgeTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePurgeTasksResponse
        /// </returns>
        public DescribePurgeTasksResponse DescribePurgeTasksWithOptions(DescribePurgeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePurgeTasks",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePurgeTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>刷新任务查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePurgeTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePurgeTasksResponse
        /// </returns>
        public async Task<DescribePurgeTasksResponse> DescribePurgeTasksWithOptionsAsync(DescribePurgeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePurgeTasks",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePurgeTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>刷新任务查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePurgeTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePurgeTasksResponse
        /// </returns>
        public DescribePurgeTasksResponse DescribePurgeTasks(DescribePurgeTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePurgeTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>刷新任务查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePurgeTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePurgeTasksResponse
        /// </returns>
        public async Task<DescribePurgeTasksResponse> DescribePurgeTasksAsync(DescribePurgeTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePurgeTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>禁用定制场景策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableCustomScenePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableCustomScenePolicyResponse
        /// </returns>
        public DisableCustomScenePolicyResponse DisableCustomScenePolicyWithOptions(DisableCustomScenePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableCustomScenePolicy",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableCustomScenePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>禁用定制场景策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableCustomScenePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableCustomScenePolicyResponse
        /// </returns>
        public async Task<DisableCustomScenePolicyResponse> DisableCustomScenePolicyWithOptionsAsync(DisableCustomScenePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableCustomScenePolicy",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableCustomScenePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>禁用定制场景策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableCustomScenePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableCustomScenePolicyResponse
        /// </returns>
        public DisableCustomScenePolicyResponse DisableCustomScenePolicy(DisableCustomScenePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableCustomScenePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>禁用定制场景策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableCustomScenePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableCustomScenePolicyResponse
        /// </returns>
        public async Task<DisableCustomScenePolicyResponse> DisableCustomScenePolicyAsync(DisableCustomScenePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableCustomScenePolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑站点WAF配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// EditSiteWafSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditSiteWafSettingsResponse
        /// </returns>
        public EditSiteWafSettingsResponse EditSiteWafSettingsWithOptions(EditSiteWafSettingsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EditSiteWafSettingsShrinkRequest request = new EditSiteWafSettingsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Settings))
            {
                request.SettingsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Settings, "Settings", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettingsShrink))
            {
                body["Settings"] = request.SettingsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditSiteWafSettings",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditSiteWafSettingsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑站点WAF配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// EditSiteWafSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditSiteWafSettingsResponse
        /// </returns>
        public async Task<EditSiteWafSettingsResponse> EditSiteWafSettingsWithOptionsAsync(EditSiteWafSettingsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EditSiteWafSettingsShrinkRequest request = new EditSiteWafSettingsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Settings))
            {
                request.SettingsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Settings, "Settings", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettingsShrink))
            {
                body["Settings"] = request.SettingsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditSiteWafSettings",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditSiteWafSettingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑站点WAF配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditSiteWafSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// EditSiteWafSettingsResponse
        /// </returns>
        public EditSiteWafSettingsResponse EditSiteWafSettings(EditSiteWafSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditSiteWafSettingsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑站点WAF配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditSiteWafSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// EditSiteWafSettingsResponse
        /// </returns>
        public async Task<EditSiteWafSettingsResponse> EditSiteWafSettingsAsync(EditSiteWafSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditSiteWafSettingsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动定制场景策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableCustomScenePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableCustomScenePolicyResponse
        /// </returns>
        public EnableCustomScenePolicyResponse EnableCustomScenePolicyWithOptions(EnableCustomScenePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableCustomScenePolicy",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableCustomScenePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动定制场景策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableCustomScenePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableCustomScenePolicyResponse
        /// </returns>
        public async Task<EnableCustomScenePolicyResponse> EnableCustomScenePolicyWithOptionsAsync(EnableCustomScenePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableCustomScenePolicy",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableCustomScenePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动定制场景策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableCustomScenePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableCustomScenePolicyResponse
        /// </returns>
        public EnableCustomScenePolicyResponse EnableCustomScenePolicy(EnableCustomScenePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableCustomScenePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动定制场景策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableCustomScenePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableCustomScenePolicyResponse
        /// </returns>
        public async Task<EnableCustomScenePolicyResponse> EnableCustomScenePolicyAsync(EnableCustomScenePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableCustomScenePolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportRecordsResponse
        /// </returns>
        public ExportRecordsResponse ExportRecordsWithOptions(ExportRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportRecords",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportRecordsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportRecordsResponse
        /// </returns>
        public async Task<ExportRecordsResponse> ExportRecordsWithOptionsAsync(ExportRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportRecords",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportRecordsResponse
        /// </returns>
        public ExportRecordsResponse ExportRecords(ExportRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportRecordsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportRecordsResponse
        /// </returns>
        public async Task<ExportRecordsResponse> ExportRecordsAsync(ExportRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportRecordsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询缓存保持实例规格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCacheReserveSpecificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCacheReserveSpecificationResponse
        /// </returns>
        public GetCacheReserveSpecificationResponse GetCacheReserveSpecificationWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCacheReserveSpecification",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCacheReserveSpecificationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询缓存保持实例规格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCacheReserveSpecificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCacheReserveSpecificationResponse
        /// </returns>
        public async Task<GetCacheReserveSpecificationResponse> GetCacheReserveSpecificationWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCacheReserveSpecification",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCacheReserveSpecificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询缓存保持实例规格</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCacheReserveSpecificationResponse
        /// </returns>
        public GetCacheReserveSpecificationResponse GetCacheReserveSpecification()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCacheReserveSpecificationWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询缓存保持实例规格</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCacheReserveSpecificationResponse
        /// </returns>
        public async Task<GetCacheReserveSpecificationResponse> GetCacheReserveSpecificationAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCacheReserveSpecificationWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Key-Value对的某个Key值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKvResponse
        /// </returns>
        public GetKvResponse GetKvWithOptions(GetKvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKv",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKvResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Key-Value对的某个Key值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKvResponse
        /// </returns>
        public async Task<GetKvResponse> GetKvWithOptionsAsync(GetKvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKv",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKvResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Key-Value对的某个Key值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKvRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKvResponse
        /// </returns>
        public GetKvResponse GetKv(GetKvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetKvWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Key-Value对的某个Key值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKvRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKvResponse
        /// </returns>
        public async Task<GetKvResponse> GetKvAsync(GetKvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetKvWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出账号下的NS</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKvAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKvAccountResponse
        /// </returns>
        public GetKvAccountResponse GetKvAccountWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKvAccount",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKvAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出账号下的NS</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKvAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKvAccountResponse
        /// </returns>
        public async Task<GetKvAccountResponse> GetKvAccountWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKvAccount",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKvAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出账号下的NS</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetKvAccountResponse
        /// </returns>
        public GetKvAccountResponse GetKvAccount()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetKvAccountWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出账号下的NS</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetKvAccountResponse
        /// </returns>
        public async Task<GetKvAccountResponse> GetKvAccountAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetKvAccountWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Namespace信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKvNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKvNamespaceResponse
        /// </returns>
        public GetKvNamespaceResponse GetKvNamespaceWithOptions(GetKvNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKvNamespace",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKvNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Namespace信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKvNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKvNamespaceResponse
        /// </returns>
        public async Task<GetKvNamespaceResponse> GetKvNamespaceWithOptionsAsync(GetKvNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKvNamespace",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKvNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Namespace信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKvNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKvNamespaceResponse
        /// </returns>
        public GetKvNamespaceResponse GetKvNamespace(GetKvNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetKvNamespaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Namespace信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKvNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKvNamespaceResponse
        /// </returns>
        public async Task<GetKvNamespaceResponse> GetKvNamespaceAsync(GetKvNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetKvNamespaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个自定义列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetListResponse
        /// </returns>
        public GetListResponse GetListWithOptions(GetListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetList",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个自定义列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetListResponse
        /// </returns>
        public async Task<GetListResponse> GetListWithOptionsAsync(GetListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetList",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个自定义列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetListResponse
        /// </returns>
        public GetListResponse GetList(GetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个自定义列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetListResponse
        /// </returns>
        public async Task<GetListResponse> GetListAsync(GetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个自定义响应页面详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPageResponse
        /// </returns>
        public GetPageResponse GetPageWithOptions(GetPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPage",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个自定义响应页面详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPageResponse
        /// </returns>
        public async Task<GetPageResponse> GetPageWithOptionsAsync(GetPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPage",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个自定义响应页面详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPageResponse
        /// </returns>
        public GetPageResponse GetPage(GetPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个自定义响应页面详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPageResponse
        /// </returns>
        public async Task<GetPageResponse> GetPageAsync(GetPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取刷新Quota</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPurgeQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPurgeQuotaResponse
        /// </returns>
        public GetPurgeQuotaResponse GetPurgeQuotaWithOptions(GetPurgeQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPurgeQuota",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPurgeQuotaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取刷新Quota</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPurgeQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPurgeQuotaResponse
        /// </returns>
        public async Task<GetPurgeQuotaResponse> GetPurgeQuotaWithOptionsAsync(GetPurgeQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPurgeQuota",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPurgeQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取刷新Quota</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPurgeQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPurgeQuotaResponse
        /// </returns>
        public GetPurgeQuotaResponse GetPurgeQuota(GetPurgeQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPurgeQuotaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取刷新Quota</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPurgeQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPurgeQuotaResponse
        /// </returns>
        public async Task<GetPurgeQuotaResponse> GetPurgeQuotaAsync(GetPurgeQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPurgeQuotaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ub日志字段列表接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRealtimeDeliveryFieldRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRealtimeDeliveryFieldResponse
        /// </returns>
        public GetRealtimeDeliveryFieldResponse GetRealtimeDeliveryFieldWithOptions(GetRealtimeDeliveryFieldRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRealtimeDeliveryField",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRealtimeDeliveryFieldResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ub日志字段列表接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRealtimeDeliveryFieldRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRealtimeDeliveryFieldResponse
        /// </returns>
        public async Task<GetRealtimeDeliveryFieldResponse> GetRealtimeDeliveryFieldWithOptionsAsync(GetRealtimeDeliveryFieldRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRealtimeDeliveryField",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRealtimeDeliveryFieldResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ub日志字段列表接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRealtimeDeliveryFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRealtimeDeliveryFieldResponse
        /// </returns>
        public GetRealtimeDeliveryFieldResponse GetRealtimeDeliveryField(GetRealtimeDeliveryFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRealtimeDeliveryFieldWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ub日志字段列表接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRealtimeDeliveryFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRealtimeDeliveryFieldResponse
        /// </returns>
        public async Task<GetRealtimeDeliveryFieldResponse> GetRealtimeDeliveryFieldAsync(GetRealtimeDeliveryFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRealtimeDeliveryFieldWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个记录信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecordResponse
        /// </returns>
        public GetRecordResponse GetRecordWithOptions(GetRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRecord",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个记录信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecordResponse
        /// </returns>
        public async Task<GetRecordResponse> GetRecordWithOptionsAsync(GetRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRecord",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个记录信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecordResponse
        /// </returns>
        public GetRecordResponse GetRecord(GetRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个记录信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecordResponse
        /// </returns>
        public async Task<GetRecordResponse> GetRecordAsync(GetRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个定时预热任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduledPreloadJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledPreloadJobResponse
        /// </returns>
        public GetScheduledPreloadJobResponse GetScheduledPreloadJobWithOptions(GetScheduledPreloadJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScheduledPreloadJob",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScheduledPreloadJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个定时预热任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduledPreloadJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledPreloadJobResponse
        /// </returns>
        public async Task<GetScheduledPreloadJobResponse> GetScheduledPreloadJobWithOptionsAsync(GetScheduledPreloadJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScheduledPreloadJob",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScheduledPreloadJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个定时预热任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduledPreloadJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledPreloadJobResponse
        /// </returns>
        public GetScheduledPreloadJobResponse GetScheduledPreloadJob(GetScheduledPreloadJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetScheduledPreloadJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个定时预热任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduledPreloadJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledPreloadJobResponse
        /// </returns>
        public async Task<GetScheduledPreloadJobResponse> GetScheduledPreloadJobAsync(GetScheduledPreloadJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetScheduledPreloadJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个站点信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSiteResponse
        /// </returns>
        public GetSiteResponse GetSiteWithOptions(GetSiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSite",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSiteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个站点信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSiteResponse
        /// </returns>
        public async Task<GetSiteResponse> GetSiteWithOptionsAsync(GetSiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSite",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSiteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个站点信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSiteResponse
        /// </returns>
        public GetSiteResponse GetSite(GetSiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSiteWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个站点信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSiteResponse
        /// </returns>
        public async Task<GetSiteResponse> GetSiteAsync(GetSiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSiteWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前NS列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteCurrentNSRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSiteCurrentNSResponse
        /// </returns>
        public GetSiteCurrentNSResponse GetSiteCurrentNSWithOptions(GetSiteCurrentNSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSiteCurrentNS",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSiteCurrentNSResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前NS列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteCurrentNSRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSiteCurrentNSResponse
        /// </returns>
        public async Task<GetSiteCurrentNSResponse> GetSiteCurrentNSWithOptionsAsync(GetSiteCurrentNSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSiteCurrentNS",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSiteCurrentNSResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前NS列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteCurrentNSRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSiteCurrentNSResponse
        /// </returns>
        public GetSiteCurrentNSResponse GetSiteCurrentNS(GetSiteCurrentNSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSiteCurrentNSWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前NS列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteCurrentNSRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSiteCurrentNSResponse
        /// </returns>
        public async Task<GetSiteCurrentNSResponse> GetSiteCurrentNSAsync(GetSiteCurrentNSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSiteCurrentNSWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自定义字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteCustomLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSiteCustomLogResponse
        /// </returns>
        public GetSiteCustomLogResponse GetSiteCustomLogWithOptions(GetSiteCustomLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSiteCustomLog",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSiteCustomLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自定义字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteCustomLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSiteCustomLogResponse
        /// </returns>
        public async Task<GetSiteCustomLogResponse> GetSiteCustomLogWithOptionsAsync(GetSiteCustomLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSiteCustomLog",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSiteCustomLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自定义字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteCustomLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSiteCustomLogResponse
        /// </returns>
        public GetSiteCustomLogResponse GetSiteCustomLog(GetSiteCustomLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSiteCustomLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自定义字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteCustomLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSiteCustomLogResponse
        /// </returns>
        public async Task<GetSiteCustomLogResponse> GetSiteCustomLogAsync(GetSiteCustomLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSiteCustomLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一个实时日志任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteDeliveryTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSiteDeliveryTaskResponse
        /// </returns>
        public GetSiteDeliveryTaskResponse GetSiteDeliveryTaskWithOptions(GetSiteDeliveryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSiteDeliveryTask",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSiteDeliveryTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一个实时日志任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteDeliveryTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSiteDeliveryTaskResponse
        /// </returns>
        public async Task<GetSiteDeliveryTaskResponse> GetSiteDeliveryTaskWithOptionsAsync(GetSiteDeliveryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSiteDeliveryTask",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSiteDeliveryTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一个实时日志任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSiteDeliveryTaskResponse
        /// </returns>
        public GetSiteDeliveryTaskResponse GetSiteDeliveryTask(GetSiteDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSiteDeliveryTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一个实时日志任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSiteDeliveryTaskResponse
        /// </returns>
        public async Task<GetSiteDeliveryTaskResponse> GetSiteDeliveryTaskAsync(GetSiteDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSiteDeliveryTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志投递任务quota数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteLogDeliveryQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSiteLogDeliveryQuotaResponse
        /// </returns>
        public GetSiteLogDeliveryQuotaResponse GetSiteLogDeliveryQuotaWithOptions(GetSiteLogDeliveryQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSiteLogDeliveryQuota",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSiteLogDeliveryQuotaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志投递任务quota数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteLogDeliveryQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSiteLogDeliveryQuotaResponse
        /// </returns>
        public async Task<GetSiteLogDeliveryQuotaResponse> GetSiteLogDeliveryQuotaWithOptionsAsync(GetSiteLogDeliveryQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSiteLogDeliveryQuota",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSiteLogDeliveryQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志投递任务quota数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteLogDeliveryQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSiteLogDeliveryQuotaResponse
        /// </returns>
        public GetSiteLogDeliveryQuotaResponse GetSiteLogDeliveryQuota(GetSiteLogDeliveryQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSiteLogDeliveryQuotaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志投递任务quota数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteLogDeliveryQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSiteLogDeliveryQuotaResponse
        /// </returns>
        public async Task<GetSiteLogDeliveryQuotaResponse> GetSiteLogDeliveryQuotaAsync(GetSiteLogDeliveryQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSiteLogDeliveryQuotaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取站点WAF配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteWafSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSiteWafSettingsResponse
        /// </returns>
        public GetSiteWafSettingsResponse GetSiteWafSettingsWithOptions(GetSiteWafSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSiteWafSettings",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSiteWafSettingsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取站点WAF配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteWafSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSiteWafSettingsResponse
        /// </returns>
        public async Task<GetSiteWafSettingsResponse> GetSiteWafSettingsWithOptionsAsync(GetSiteWafSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSiteWafSettings",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSiteWafSettingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取站点WAF配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteWafSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSiteWafSettingsResponse
        /// </returns>
        public GetSiteWafSettingsResponse GetSiteWafSettings(GetSiteWafSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSiteWafSettingsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取站点WAF配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSiteWafSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSiteWafSettingsResponse
        /// </returns>
        public async Task<GetSiteWafSettingsResponse> GetSiteWafSettingsAsync(GetSiteWafSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSiteWafSettingsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文件上传任务查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUploadTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUploadTaskResponse
        /// </returns>
        public GetUploadTaskResponse GetUploadTaskWithOptions(GetUploadTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUploadTask",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文件上传任务查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUploadTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUploadTaskResponse
        /// </returns>
        public async Task<GetUploadTaskResponse> GetUploadTaskWithOptionsAsync(GetUploadTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUploadTask",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文件上传任务查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUploadTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUploadTaskResponse
        /// </returns>
        public GetUploadTaskResponse GetUploadTask(GetUploadTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUploadTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文件上传任务查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUploadTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUploadTaskResponse
        /// </returns>
        public async Task<GetUploadTaskResponse> GetUploadTaskAsync(GetUploadTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUploadTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一个用户粒度任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserDeliveryTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserDeliveryTaskResponse
        /// </returns>
        public GetUserDeliveryTaskResponse GetUserDeliveryTaskWithOptions(GetUserDeliveryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserDeliveryTask",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserDeliveryTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一个用户粒度任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserDeliveryTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserDeliveryTaskResponse
        /// </returns>
        public async Task<GetUserDeliveryTaskResponse> GetUserDeliveryTaskWithOptionsAsync(GetUserDeliveryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserDeliveryTask",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserDeliveryTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一个用户粒度任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserDeliveryTaskResponse
        /// </returns>
        public GetUserDeliveryTaskResponse GetUserDeliveryTask(GetUserDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserDeliveryTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一个用户粒度任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserDeliveryTaskResponse
        /// </returns>
        public async Task<GetUserDeliveryTaskResponse> GetUserDeliveryTaskAsync(GetUserDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserDeliveryTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志投递任务用户quota数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserLogDeliveryQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserLogDeliveryQuotaResponse
        /// </returns>
        public GetUserLogDeliveryQuotaResponse GetUserLogDeliveryQuotaWithOptions(GetUserLogDeliveryQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserLogDeliveryQuota",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserLogDeliveryQuotaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志投递任务用户quota数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserLogDeliveryQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserLogDeliveryQuotaResponse
        /// </returns>
        public async Task<GetUserLogDeliveryQuotaResponse> GetUserLogDeliveryQuotaWithOptionsAsync(GetUserLogDeliveryQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserLogDeliveryQuota",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserLogDeliveryQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志投递任务用户quota数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserLogDeliveryQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserLogDeliveryQuotaResponse
        /// </returns>
        public GetUserLogDeliveryQuotaResponse GetUserLogDeliveryQuota(GetUserLogDeliveryQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserLogDeliveryQuotaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志投递任务用户quota数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserLogDeliveryQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserLogDeliveryQuotaResponse
        /// </returns>
        public async Task<GetUserLogDeliveryQuotaResponse> GetUserLogDeliveryQuotaAsync(GetUserLogDeliveryQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserLogDeliveryQuotaWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetWafBotAppKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWafBotAppKeyResponse
        /// </returns>
        public GetWafBotAppKeyResponse GetWafBotAppKeyWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWafBotAppKey",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWafBotAppKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetWafBotAppKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWafBotAppKeyResponse
        /// </returns>
        public async Task<GetWafBotAppKeyResponse> GetWafBotAppKeyWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWafBotAppKey",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWafBotAppKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// GetWafBotAppKeyResponse
        /// </returns>
        public GetWafBotAppKeyResponse GetWafBotAppKey()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWafBotAppKeyWithOptions(runtime);
        }

        /// <returns>
        /// GetWafBotAppKeyResponse
        /// </returns>
        public async Task<GetWafBotAppKeyResponse> GetWafBotAppKeyAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWafBotAppKeyWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将匹配项转换为表达式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWafFilterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWafFilterResponse
        /// </returns>
        public GetWafFilterResponse GetWafFilterWithOptions(GetWafFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                query["Phase"] = request.Phase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
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
                Action = "GetWafFilter",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWafFilterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将匹配项转换为表达式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWafFilterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWafFilterResponse
        /// </returns>
        public async Task<GetWafFilterResponse> GetWafFilterWithOptionsAsync(GetWafFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                query["Phase"] = request.Phase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
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
                Action = "GetWafFilter",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWafFilterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将匹配项转换为表达式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWafFilterRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWafFilterResponse
        /// </returns>
        public GetWafFilterResponse GetWafFilter(GetWafFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWafFilterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将匹配项转换为表达式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWafFilterRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWafFilterResponse
        /// </returns>
        public async Task<GetWafFilterResponse> GetWafFilterAsync(GetWafFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWafFilterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取WAF配额详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWafQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWafQuotaResponse
        /// </returns>
        public GetWafQuotaResponse GetWafQuotaWithOptions(GetWafQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Paths))
            {
                query["Paths"] = request.Paths;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWafQuota",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWafQuotaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取WAF配额详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWafQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWafQuotaResponse
        /// </returns>
        public async Task<GetWafQuotaResponse> GetWafQuotaWithOptionsAsync(GetWafQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Paths))
            {
                query["Paths"] = request.Paths;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWafQuota",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWafQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取WAF配额详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWafQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWafQuotaResponse
        /// </returns>
        public GetWafQuotaResponse GetWafQuota(GetWafQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWafQuotaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取WAF配额详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWafQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWafQuotaResponse
        /// </returns>
        public async Task<GetWafQuotaResponse> GetWafQuotaAsync(GetWafQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWafQuotaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个WAF规则详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWafRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWafRuleResponse
        /// </returns>
        public GetWafRuleResponse GetWafRuleWithOptions(GetWafRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWafRule",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWafRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个WAF规则详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWafRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWafRuleResponse
        /// </returns>
        public async Task<GetWafRuleResponse> GetWafRuleWithOptionsAsync(GetWafRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWafRule",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWafRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个WAF规则详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWafRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWafRuleResponse
        /// </returns>
        public GetWafRuleResponse GetWafRule(GetWafRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWafRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个WAF规则详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWafRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWafRuleResponse
        /// </returns>
        public async Task<GetWafRuleResponse> GetWafRuleAsync(GetWafRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWafRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取WAF规则集详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWafRulesetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWafRulesetResponse
        /// </returns>
        public GetWafRulesetResponse GetWafRulesetWithOptions(GetWafRulesetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                query["Phase"] = request.Phase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWafRuleset",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWafRulesetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取WAF规则集详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWafRulesetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWafRulesetResponse
        /// </returns>
        public async Task<GetWafRulesetResponse> GetWafRulesetWithOptionsAsync(GetWafRulesetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                query["Phase"] = request.Phase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWafRuleset",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWafRulesetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取WAF规则集详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWafRulesetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWafRulesetResponse
        /// </returns>
        public GetWafRulesetResponse GetWafRuleset(GetWafRulesetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWafRulesetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取WAF规则集详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWafRulesetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWafRulesetResponse
        /// </returns>
        public async Task<GetWafRulesetResponse> GetWafRulesetAsync(GetWafRulesetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWafRulesetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询缓存保持实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCacheReserveInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCacheReserveInstancesResponse
        /// </returns>
        public ListCacheReserveInstancesResponse ListCacheReserveInstancesWithOptions(ListCacheReserveInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCacheReserveInstances",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCacheReserveInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询缓存保持实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCacheReserveInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCacheReserveInstancesResponse
        /// </returns>
        public async Task<ListCacheReserveInstancesResponse> ListCacheReserveInstancesWithOptionsAsync(ListCacheReserveInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCacheReserveInstances",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCacheReserveInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询缓存保持实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCacheReserveInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCacheReserveInstancesResponse
        /// </returns>
        public ListCacheReserveInstancesResponse ListCacheReserveInstances(ListCacheReserveInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCacheReserveInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询缓存保持实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCacheReserveInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCacheReserveInstancesResponse
        /// </returns>
        public async Task<ListCacheReserveInstancesResponse> ListCacheReserveInstancesAsync(ListCacheReserveInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCacheReserveInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询站点下客户端证书列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClientCertificatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClientCertificatesResponse
        /// </returns>
        public ListClientCertificatesResponse ListClientCertificatesWithOptions(ListClientCertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClientCertificates",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClientCertificatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询站点下客户端证书列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClientCertificatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClientCertificatesResponse
        /// </returns>
        public async Task<ListClientCertificatesResponse> ListClientCertificatesWithOptionsAsync(ListClientCertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClientCertificates",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClientCertificatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询站点下客户端证书列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClientCertificatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListClientCertificatesResponse
        /// </returns>
        public ListClientCertificatesResponse ListClientCertificates(ListClientCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClientCertificatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询站点下客户端证书列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClientCertificatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListClientCertificatesResponse
        /// </returns>
        public async Task<ListClientCertificatesResponse> ListClientCertificatesAsync(ListClientCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClientCertificatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一个边缘容器应用的全部域名记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeContainerAppRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeContainerAppRecordsResponse
        /// </returns>
        public ListEdgeContainerAppRecordsResponse ListEdgeContainerAppRecordsWithOptions(ListEdgeContainerAppRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEdgeContainerAppRecords",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEdgeContainerAppRecordsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一个边缘容器应用的全部域名记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeContainerAppRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeContainerAppRecordsResponse
        /// </returns>
        public async Task<ListEdgeContainerAppRecordsResponse> ListEdgeContainerAppRecordsWithOptionsAsync(ListEdgeContainerAppRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEdgeContainerAppRecords",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEdgeContainerAppRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一个边缘容器应用的全部域名记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeContainerAppRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeContainerAppRecordsResponse
        /// </returns>
        public ListEdgeContainerAppRecordsResponse ListEdgeContainerAppRecords(ListEdgeContainerAppRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEdgeContainerAppRecordsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一个边缘容器应用的全部域名记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeContainerAppRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeContainerAppRecordsResponse
        /// </returns>
        public async Task<ListEdgeContainerAppRecordsResponse> ListEdgeContainerAppRecordsAsync(ListEdgeContainerAppRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEdgeContainerAppRecordsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户全部边缘容器应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeContainerAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeContainerAppsResponse
        /// </returns>
        public ListEdgeContainerAppsResponse ListEdgeContainerAppsWithOptions(ListEdgeContainerAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderKey))
            {
                query["OrderKey"] = request.OrderKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["SearchType"] = request.SearchType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEdgeContainerApps",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEdgeContainerAppsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户全部边缘容器应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeContainerAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeContainerAppsResponse
        /// </returns>
        public async Task<ListEdgeContainerAppsResponse> ListEdgeContainerAppsWithOptionsAsync(ListEdgeContainerAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderKey))
            {
                query["OrderKey"] = request.OrderKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["SearchType"] = request.SearchType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEdgeContainerApps",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEdgeContainerAppsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户全部边缘容器应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeContainerAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeContainerAppsResponse
        /// </returns>
        public ListEdgeContainerAppsResponse ListEdgeContainerApps(ListEdgeContainerAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEdgeContainerAppsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户全部边缘容器应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeContainerAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeContainerAppsResponse
        /// </returns>
        public async Task<ListEdgeContainerAppsResponse> ListEdgeContainerAppsAsync(ListEdgeContainerAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEdgeContainerAppsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询站点的边缘容器记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeContainerRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeContainerRecordsResponse
        /// </returns>
        public ListEdgeContainerRecordsResponse ListEdgeContainerRecordsWithOptions(ListEdgeContainerRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEdgeContainerRecords",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEdgeContainerRecordsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询站点的边缘容器记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeContainerRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeContainerRecordsResponse
        /// </returns>
        public async Task<ListEdgeContainerRecordsResponse> ListEdgeContainerRecordsWithOptionsAsync(ListEdgeContainerRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEdgeContainerRecords",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEdgeContainerRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询站点的边缘容器记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeContainerRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeContainerRecordsResponse
        /// </returns>
        public ListEdgeContainerRecordsResponse ListEdgeContainerRecords(ListEdgeContainerRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEdgeContainerRecordsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询站点的边缘容器记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeContainerRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeContainerRecordsResponse
        /// </returns>
        public async Task<ListEdgeContainerRecordsResponse> ListEdgeContainerRecordsAsync(ListEdgeContainerRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEdgeContainerRecordsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户可购买的边缘函数的套餐</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeRoutinePlansRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeRoutinePlansResponse
        /// </returns>
        public ListEdgeRoutinePlansResponse ListEdgeRoutinePlansWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEdgeRoutinePlans",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEdgeRoutinePlansResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户可购买的边缘函数的套餐</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeRoutinePlansRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeRoutinePlansResponse
        /// </returns>
        public async Task<ListEdgeRoutinePlansResponse> ListEdgeRoutinePlansWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEdgeRoutinePlans",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEdgeRoutinePlansResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户可购买的边缘函数的套餐</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListEdgeRoutinePlansResponse
        /// </returns>
        public ListEdgeRoutinePlansResponse ListEdgeRoutinePlans()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEdgeRoutinePlansWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户可购买的边缘函数的套餐</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListEdgeRoutinePlansResponse
        /// </returns>
        public async Task<ListEdgeRoutinePlansResponse> ListEdgeRoutinePlansAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEdgeRoutinePlansWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询站点的边缘路由记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeRoutineRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeRoutineRecordsResponse
        /// </returns>
        public ListEdgeRoutineRecordsResponse ListEdgeRoutineRecordsWithOptions(ListEdgeRoutineRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEdgeRoutineRecords",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEdgeRoutineRecordsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询站点的边缘路由记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeRoutineRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeRoutineRecordsResponse
        /// </returns>
        public async Task<ListEdgeRoutineRecordsResponse> ListEdgeRoutineRecordsWithOptionsAsync(ListEdgeRoutineRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEdgeRoutineRecords",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEdgeRoutineRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询站点的边缘路由记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeRoutineRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeRoutineRecordsResponse
        /// </returns>
        public ListEdgeRoutineRecordsResponse ListEdgeRoutineRecords(ListEdgeRoutineRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEdgeRoutineRecordsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询站点的边缘路由记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeRoutineRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeRoutineRecordsResponse
        /// </returns>
        public async Task<ListEdgeRoutineRecordsResponse> ListEdgeRoutineRecordsAsync(ListEdgeRoutineRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEdgeRoutineRecordsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例或者站点的quota值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceQuotasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceQuotasResponse
        /// </returns>
        public ListInstanceQuotasResponse ListInstanceQuotasWithOptions(ListInstanceQuotasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceQuotas",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceQuotasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例或者站点的quota值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceQuotasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceQuotasResponse
        /// </returns>
        public async Task<ListInstanceQuotasResponse> ListInstanceQuotasWithOptionsAsync(ListInstanceQuotasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceQuotas",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceQuotasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例或者站点的quota值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceQuotasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceQuotasResponse
        /// </returns>
        public ListInstanceQuotasResponse ListInstanceQuotas(ListInstanceQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstanceQuotasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例或者站点的quota值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceQuotasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceQuotasResponse
        /// </returns>
        public async Task<ListInstanceQuotasResponse> ListInstanceQuotasAsync(ListInstanceQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstanceQuotasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询功能quota和用量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceQuotasWithUsageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceQuotasWithUsageResponse
        /// </returns>
        public ListInstanceQuotasWithUsageResponse ListInstanceQuotasWithUsageWithOptions(ListInstanceQuotasWithUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceQuotasWithUsage",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceQuotasWithUsageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询功能quota和用量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceQuotasWithUsageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceQuotasWithUsageResponse
        /// </returns>
        public async Task<ListInstanceQuotasWithUsageResponse> ListInstanceQuotasWithUsageWithOptionsAsync(ListInstanceQuotasWithUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceQuotasWithUsage",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceQuotasWithUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询功能quota和用量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceQuotasWithUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceQuotasWithUsageResponse
        /// </returns>
        public ListInstanceQuotasWithUsageResponse ListInstanceQuotasWithUsage(ListInstanceQuotasWithUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstanceQuotasWithUsageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询功能quota和用量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceQuotasWithUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceQuotasWithUsageResponse
        /// </returns>
        public async Task<ListInstanceQuotasWithUsageResponse> ListInstanceQuotasWithUsageAsync(ListInstanceQuotasWithUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstanceQuotasWithUsageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>遍历Namespace的Key值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKvsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKvsResponse
        /// </returns>
        public ListKvsResponse ListKvsWithOptions(ListKvsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKvs",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKvsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>遍历Namespace的Key值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKvsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKvsResponse
        /// </returns>
        public async Task<ListKvsResponse> ListKvsWithOptionsAsync(ListKvsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKvs",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKvsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>遍历Namespace的Key值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKvsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKvsResponse
        /// </returns>
        public ListKvsResponse ListKvs(ListKvsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListKvsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>遍历Namespace的Key值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKvsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKvsResponse
        /// </returns>
        public async Task<ListKvsResponse> ListKvsAsync(ListKvsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListKvsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举自定义列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListListsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListListsResponse
        /// </returns>
        public ListListsResponse ListListsWithOptions(ListListsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListListsShrinkRequest request = new ListListsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryArgs))
            {
                request.QueryArgsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryArgs, "QueryArgs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryArgsShrink))
            {
                query["QueryArgs"] = request.QueryArgsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLists",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListListsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举自定义列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListListsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListListsResponse
        /// </returns>
        public async Task<ListListsResponse> ListListsWithOptionsAsync(ListListsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListListsShrinkRequest request = new ListListsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryArgs))
            {
                request.QueryArgsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryArgs, "QueryArgs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryArgsShrink))
            {
                query["QueryArgs"] = request.QueryArgsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLists",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListListsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举自定义列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListListsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListListsResponse
        /// </returns>
        public ListListsResponse ListLists(ListListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListListsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举自定义列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListListsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListListsResponse
        /// </returns>
        public async Task<ListListsResponse> ListListsAsync(ListListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListListsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询负载均衡区域列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLoadBalancerRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLoadBalancerRegionsResponse
        /// </returns>
        public ListLoadBalancerRegionsResponse ListLoadBalancerRegionsWithOptions(ListLoadBalancerRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLoadBalancerRegions",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLoadBalancerRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询负载均衡区域列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLoadBalancerRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLoadBalancerRegionsResponse
        /// </returns>
        public async Task<ListLoadBalancerRegionsResponse> ListLoadBalancerRegionsWithOptionsAsync(ListLoadBalancerRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLoadBalancerRegions",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLoadBalancerRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询负载均衡区域列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLoadBalancerRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLoadBalancerRegionsResponse
        /// </returns>
        public ListLoadBalancerRegionsResponse ListLoadBalancerRegions(ListLoadBalancerRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLoadBalancerRegionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询负载均衡区域列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLoadBalancerRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLoadBalancerRegionsResponse
        /// </returns>
        public async Task<ListLoadBalancerRegionsResponse> ListLoadBalancerRegionsAsync(ListLoadBalancerRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLoadBalancerRegionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举自定义托管规则组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListManagedRulesGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListManagedRulesGroupsResponse
        /// </returns>
        public ListManagedRulesGroupsResponse ListManagedRulesGroupsWithOptions(ListManagedRulesGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListManagedRulesGroups",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListManagedRulesGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举自定义托管规则组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListManagedRulesGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListManagedRulesGroupsResponse
        /// </returns>
        public async Task<ListManagedRulesGroupsResponse> ListManagedRulesGroupsWithOptionsAsync(ListManagedRulesGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListManagedRulesGroups",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListManagedRulesGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举自定义托管规则组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListManagedRulesGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListManagedRulesGroupsResponse
        /// </returns>
        public ListManagedRulesGroupsResponse ListManagedRulesGroups(ListManagedRulesGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListManagedRulesGroupsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举自定义托管规则组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListManagedRulesGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListManagedRulesGroupsResponse
        /// </returns>
        public async Task<ListManagedRulesGroupsResponse> ListManagedRulesGroupsAsync(ListManagedRulesGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListManagedRulesGroupsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举自定义响应页面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPagesResponse
        /// </returns>
        public ListPagesResponse ListPagesWithOptions(ListPagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPages",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPagesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举自定义响应页面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPagesResponse
        /// </returns>
        public async Task<ListPagesResponse> ListPagesWithOptionsAsync(ListPagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPages",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举自定义响应页面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPagesResponse
        /// </returns>
        public ListPagesResponse ListPages(ListPagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPagesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举自定义响应页面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPagesResponse
        /// </returns>
        public async Task<ListPagesResponse> ListPagesAsync(ListPagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPagesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询站点下的记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRecordsResponse
        /// </returns>
        public ListRecordsResponse ListRecordsWithOptions(ListRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRecords",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecordsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询站点下的记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRecordsResponse
        /// </returns>
        public async Task<ListRecordsResponse> ListRecordsWithOptionsAsync(ListRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRecords",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询站点下的记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRecordsResponse
        /// </returns>
        public ListRecordsResponse ListRecords(ListRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRecordsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询站点下的记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRecordsResponse
        /// </returns>
        public async Task<ListRecordsResponse> ListRecordsAsync(ListRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRecordsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出指定任务下的执行计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledPreloadExecutionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledPreloadExecutionsResponse
        /// </returns>
        public ListScheduledPreloadExecutionsResponse ListScheduledPreloadExecutionsWithOptions(ListScheduledPreloadExecutionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScheduledPreloadExecutions",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScheduledPreloadExecutionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出指定任务下的执行计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledPreloadExecutionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledPreloadExecutionsResponse
        /// </returns>
        public async Task<ListScheduledPreloadExecutionsResponse> ListScheduledPreloadExecutionsWithOptionsAsync(ListScheduledPreloadExecutionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScheduledPreloadExecutions",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScheduledPreloadExecutionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出指定任务下的执行计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledPreloadExecutionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledPreloadExecutionsResponse
        /// </returns>
        public ListScheduledPreloadExecutionsResponse ListScheduledPreloadExecutions(ListScheduledPreloadExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScheduledPreloadExecutionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出指定任务下的执行计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledPreloadExecutionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledPreloadExecutionsResponse
        /// </returns>
        public async Task<ListScheduledPreloadExecutionsResponse> ListScheduledPreloadExecutionsAsync(ListScheduledPreloadExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScheduledPreloadExecutionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出定时预热任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledPreloadJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledPreloadJobsResponse
        /// </returns>
        public ListScheduledPreloadJobsResponse ListScheduledPreloadJobsWithOptions(ListScheduledPreloadJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScheduledPreloadJobs",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScheduledPreloadJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出定时预热任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledPreloadJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledPreloadJobsResponse
        /// </returns>
        public async Task<ListScheduledPreloadJobsResponse> ListScheduledPreloadJobsWithOptionsAsync(ListScheduledPreloadJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScheduledPreloadJobs",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScheduledPreloadJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出定时预热任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledPreloadJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledPreloadJobsResponse
        /// </returns>
        public ListScheduledPreloadJobsResponse ListScheduledPreloadJobs(ListScheduledPreloadJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScheduledPreloadJobsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出定时预热任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledPreloadJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledPreloadJobsResponse
        /// </returns>
        public async Task<ListScheduledPreloadJobsResponse> ListScheduledPreloadJobsAsync(ListScheduledPreloadJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScheduledPreloadJobsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出全部任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSiteDeliveryTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSiteDeliveryTasksResponse
        /// </returns>
        public ListSiteDeliveryTasksResponse ListSiteDeliveryTasksWithOptions(ListSiteDeliveryTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSiteDeliveryTasks",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSiteDeliveryTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出全部任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSiteDeliveryTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSiteDeliveryTasksResponse
        /// </returns>
        public async Task<ListSiteDeliveryTasksResponse> ListSiteDeliveryTasksWithOptionsAsync(ListSiteDeliveryTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSiteDeliveryTasks",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSiteDeliveryTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出全部任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSiteDeliveryTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSiteDeliveryTasksResponse
        /// </returns>
        public ListSiteDeliveryTasksResponse ListSiteDeliveryTasks(ListSiteDeliveryTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSiteDeliveryTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出全部任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSiteDeliveryTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSiteDeliveryTasksResponse
        /// </returns>
        public async Task<ListSiteDeliveryTasksResponse> ListSiteDeliveryTasksAsync(ListSiteDeliveryTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSiteDeliveryTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询站点列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListSitesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSitesResponse
        /// </returns>
        public ListSitesResponse ListSitesWithOptions(ListSitesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListSitesShrinkRequest request = new ListSitesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagFilter))
            {
                request.TagFilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagFilter, "TagFilter", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSites",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSitesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询站点列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListSitesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSitesResponse
        /// </returns>
        public async Task<ListSitesResponse> ListSitesWithOptionsAsync(ListSitesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListSitesShrinkRequest request = new ListSitesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagFilter))
            {
                request.TagFilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagFilter, "TagFilter", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSites",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSitesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询站点列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSitesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSitesResponse
        /// </returns>
        public ListSitesResponse ListSites(ListSitesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSitesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询站点列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSitesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSitesResponse
        /// </returns>
        public async Task<ListSitesResponse> ListSitesAsync(ListSitesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSitesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云资源已经绑定的标签列表</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItem))
            {
                query["MaxItem"] = request.MaxItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
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
                Version = "2024-09-10",
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
        /// <para>查询云资源已经绑定的标签列表</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItem))
            {
                query["MaxItem"] = request.MaxItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
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
                Version = "2024-09-10",
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
        /// <para>查询云资源已经绑定的标签列表</para>
        /// </summary>
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
        /// <para>查询云资源已经绑定的标签列表</para>
        /// </summary>
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
        /// <para>获取文件上传任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUploadTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUploadTasksResponse
        /// </returns>
        public ListUploadTasksResponse ListUploadTasksWithOptions(ListUploadTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUploadTasks",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUploadTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件上传任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUploadTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUploadTasksResponse
        /// </returns>
        public async Task<ListUploadTasksResponse> ListUploadTasksWithOptionsAsync(ListUploadTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUploadTasks",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUploadTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件上传任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUploadTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUploadTasksResponse
        /// </returns>
        public ListUploadTasksResponse ListUploadTasks(ListUploadTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUploadTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件上传任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUploadTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUploadTasksResponse
        /// </returns>
        public async Task<ListUploadTasksResponse> ListUploadTasksAsync(ListUploadTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUploadTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出用户全部任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserDeliveryTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserDeliveryTasksResponse
        /// </returns>
        public ListUserDeliveryTasksResponse ListUserDeliveryTasksWithOptions(ListUserDeliveryTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserDeliveryTasks",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserDeliveryTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出用户全部任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserDeliveryTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserDeliveryTasksResponse
        /// </returns>
        public async Task<ListUserDeliveryTasksResponse> ListUserDeliveryTasksWithOptionsAsync(ListUserDeliveryTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserDeliveryTasks",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserDeliveryTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出用户全部任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserDeliveryTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserDeliveryTasksResponse
        /// </returns>
        public ListUserDeliveryTasksResponse ListUserDeliveryTasks(ListUserDeliveryTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserDeliveryTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出用户全部任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserDeliveryTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserDeliveryTasksResponse
        /// </returns>
        public async Task<ListUserDeliveryTasksResponse> ListUserDeliveryTasksAsync(ListUserDeliveryTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserDeliveryTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询该用户下可用的已购套餐实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserRatePlanInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserRatePlanInstancesResponse
        /// </returns>
        public ListUserRatePlanInstancesResponse ListUserRatePlanInstancesWithOptions(ListUserRatePlanInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserRatePlanInstances",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserRatePlanInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询该用户下可用的已购套餐实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserRatePlanInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserRatePlanInstancesResponse
        /// </returns>
        public async Task<ListUserRatePlanInstancesResponse> ListUserRatePlanInstancesWithOptionsAsync(ListUserRatePlanInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserRatePlanInstances",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserRatePlanInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询该用户下可用的已购套餐实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserRatePlanInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserRatePlanInstancesResponse
        /// </returns>
        public ListUserRatePlanInstancesResponse ListUserRatePlanInstances(ListUserRatePlanInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserRatePlanInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询该用户下可用的已购套餐实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserRatePlanInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserRatePlanInstancesResponse
        /// </returns>
        public async Task<ListUserRatePlanInstancesResponse> ListUserRatePlanInstancesAsync(ListUserRatePlanInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserRatePlanInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF托管规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListWafManagedRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWafManagedRulesResponse
        /// </returns>
        public ListWafManagedRulesResponse ListWafManagedRulesWithOptions(ListWafManagedRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWafManagedRulesShrinkRequest request = new ListWafManagedRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryArgs))
            {
                request.QueryArgsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryArgs, "QueryArgs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttackType))
            {
                query["AttackType"] = request.AttackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryArgsShrink))
            {
                query["QueryArgs"] = request.QueryArgsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWafManagedRules",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWafManagedRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF托管规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListWafManagedRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWafManagedRulesResponse
        /// </returns>
        public async Task<ListWafManagedRulesResponse> ListWafManagedRulesWithOptionsAsync(ListWafManagedRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWafManagedRulesShrinkRequest request = new ListWafManagedRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryArgs))
            {
                request.QueryArgsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryArgs, "QueryArgs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttackType))
            {
                query["AttackType"] = request.AttackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryArgsShrink))
            {
                query["QueryArgs"] = request.QueryArgsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWafManagedRules",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWafManagedRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF托管规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWafManagedRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWafManagedRulesResponse
        /// </returns>
        public ListWafManagedRulesResponse ListWafManagedRules(ListWafManagedRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWafManagedRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF托管规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWafManagedRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWafManagedRulesResponse
        /// </returns>
        public async Task<ListWafManagedRulesResponse> ListWafManagedRulesAsync(ListWafManagedRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWafManagedRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF阶段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWafPhasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWafPhasesResponse
        /// </returns>
        public ListWafPhasesResponse ListWafPhasesWithOptions(ListWafPhasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWafPhases",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWafPhasesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF阶段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWafPhasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWafPhasesResponse
        /// </returns>
        public async Task<ListWafPhasesResponse> ListWafPhasesWithOptionsAsync(ListWafPhasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWafPhases",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWafPhasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF阶段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWafPhasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWafPhasesResponse
        /// </returns>
        public ListWafPhasesResponse ListWafPhases(ListWafPhasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWafPhasesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF阶段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWafPhasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWafPhasesResponse
        /// </returns>
        public async Task<ListWafPhasesResponse> ListWafPhasesAsync(ListWafPhasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWafPhasesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListWafRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWafRulesResponse
        /// </returns>
        public ListWafRulesResponse ListWafRulesWithOptions(ListWafRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWafRulesShrinkRequest request = new ListWafRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryArgs))
            {
                request.QueryArgsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryArgs, "QueryArgs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                query["Phase"] = request.Phase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryArgsShrink))
            {
                query["QueryArgs"] = request.QueryArgsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWafRules",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWafRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListWafRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWafRulesResponse
        /// </returns>
        public async Task<ListWafRulesResponse> ListWafRulesWithOptionsAsync(ListWafRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWafRulesShrinkRequest request = new ListWafRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryArgs))
            {
                request.QueryArgsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryArgs, "QueryArgs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                query["Phase"] = request.Phase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryArgsShrink))
            {
                query["QueryArgs"] = request.QueryArgsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWafRules",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWafRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWafRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWafRulesResponse
        /// </returns>
        public ListWafRulesResponse ListWafRules(ListWafRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWafRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWafRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWafRulesResponse
        /// </returns>
        public async Task<ListWafRulesResponse> ListWafRulesAsync(ListWafRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWafRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF规则集</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListWafRulesetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWafRulesetsResponse
        /// </returns>
        public ListWafRulesetsResponse ListWafRulesetsWithOptions(ListWafRulesetsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWafRulesetsShrinkRequest request = new ListWafRulesetsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryArgs))
            {
                request.QueryArgsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryArgs, "QueryArgs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                query["Phase"] = request.Phase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryArgsShrink))
            {
                query["QueryArgs"] = request.QueryArgsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWafRulesets",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWafRulesetsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF规则集</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListWafRulesetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWafRulesetsResponse
        /// </returns>
        public async Task<ListWafRulesetsResponse> ListWafRulesetsWithOptionsAsync(ListWafRulesetsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWafRulesetsShrinkRequest request = new ListWafRulesetsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryArgs))
            {
                request.QueryArgsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryArgs, "QueryArgs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                query["Phase"] = request.Phase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryArgsShrink))
            {
                query["QueryArgs"] = request.QueryArgsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWafRulesets",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWafRulesetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF规则集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWafRulesetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWafRulesetsResponse
        /// </returns>
        public ListWafRulesetsResponse ListWafRulesets(ListWafRulesetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWafRulesetsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF规则集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWafRulesetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWafRulesetsResponse
        /// </returns>
        public async Task<ListWafRulesetsResponse> ListWafRulesetsAsync(ListWafRulesetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWafRulesetsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF模板规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListWafTemplateRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWafTemplateRulesResponse
        /// </returns>
        public ListWafTemplateRulesResponse ListWafTemplateRulesWithOptions(ListWafTemplateRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWafTemplateRulesShrinkRequest request = new ListWafTemplateRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryArgs))
            {
                request.QueryArgsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryArgs, "QueryArgs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                query["Phase"] = request.Phase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryArgsShrink))
            {
                query["QueryArgs"] = request.QueryArgsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWafTemplateRules",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWafTemplateRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF模板规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListWafTemplateRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWafTemplateRulesResponse
        /// </returns>
        public async Task<ListWafTemplateRulesResponse> ListWafTemplateRulesWithOptionsAsync(ListWafTemplateRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWafTemplateRulesShrinkRequest request = new ListWafTemplateRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryArgs))
            {
                request.QueryArgsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryArgs, "QueryArgs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                query["Phase"] = request.Phase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryArgsShrink))
            {
                query["QueryArgs"] = request.QueryArgsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWafTemplateRules",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWafTemplateRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF模板规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWafTemplateRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWafTemplateRulesResponse
        /// </returns>
        public ListWafTemplateRulesResponse ListWafTemplateRules(ListWafTemplateRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWafTemplateRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF模板规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWafTemplateRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWafTemplateRulesResponse
        /// </returns>
        public async Task<ListWafTemplateRulesResponse> ListWafTemplateRulesAsync(ListWafTemplateRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWafTemplateRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF规则使用情况</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWafUsageOfRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWafUsageOfRulesResponse
        /// </returns>
        public ListWafUsageOfRulesResponse ListWafUsageOfRulesWithOptions(ListWafUsageOfRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                query["Phase"] = request.Phase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWafUsageOfRules",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWafUsageOfRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF规则使用情况</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWafUsageOfRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWafUsageOfRulesResponse
        /// </returns>
        public async Task<ListWafUsageOfRulesResponse> ListWafUsageOfRulesWithOptionsAsync(ListWafUsageOfRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                query["Phase"] = request.Phase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWafUsageOfRules",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWafUsageOfRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF规则使用情况</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWafUsageOfRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWafUsageOfRulesResponse
        /// </returns>
        public ListWafUsageOfRulesResponse ListWafUsageOfRules(ListWafUsageOfRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWafUsageOfRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举WAF规则使用情况</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWafUsageOfRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWafUsageOfRulesResponse
        /// </returns>
        public async Task<ListWafUsageOfRulesResponse> ListWafUsageOfRulesAsync(ListWafUsageOfRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWafUsageOfRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询等候室事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWaitingRoomEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWaitingRoomEventsResponse
        /// </returns>
        public ListWaitingRoomEventsResponse ListWaitingRoomEventsWithOptions(ListWaitingRoomEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWaitingRoomEvents",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWaitingRoomEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询等候室事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWaitingRoomEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWaitingRoomEventsResponse
        /// </returns>
        public async Task<ListWaitingRoomEventsResponse> ListWaitingRoomEventsWithOptionsAsync(ListWaitingRoomEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWaitingRoomEvents",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWaitingRoomEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询等候室事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWaitingRoomEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWaitingRoomEventsResponse
        /// </returns>
        public ListWaitingRoomEventsResponse ListWaitingRoomEvents(ListWaitingRoomEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWaitingRoomEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询等候室事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWaitingRoomEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWaitingRoomEventsResponse
        /// </returns>
        public async Task<ListWaitingRoomEventsResponse> ListWaitingRoomEventsAsync(ListWaitingRoomEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWaitingRoomEventsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询等候室绕过规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWaitingRoomRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWaitingRoomRulesResponse
        /// </returns>
        public ListWaitingRoomRulesResponse ListWaitingRoomRulesWithOptions(ListWaitingRoomRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWaitingRoomRules",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWaitingRoomRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询等候室绕过规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWaitingRoomRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWaitingRoomRulesResponse
        /// </returns>
        public async Task<ListWaitingRoomRulesResponse> ListWaitingRoomRulesWithOptionsAsync(ListWaitingRoomRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWaitingRoomRules",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWaitingRoomRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询等候室绕过规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWaitingRoomRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWaitingRoomRulesResponse
        /// </returns>
        public ListWaitingRoomRulesResponse ListWaitingRoomRules(ListWaitingRoomRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWaitingRoomRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询等候室绕过规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWaitingRoomRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWaitingRoomRulesResponse
        /// </returns>
        public async Task<ListWaitingRoomRulesResponse> ListWaitingRoomRulesAsync(ListWaitingRoomRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWaitingRoomRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询等候室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWaitingRoomsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWaitingRoomsResponse
        /// </returns>
        public ListWaitingRoomsResponse ListWaitingRoomsWithOptions(ListWaitingRoomsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWaitingRooms",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWaitingRoomsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询等候室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWaitingRoomsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWaitingRoomsResponse
        /// </returns>
        public async Task<ListWaitingRoomsResponse> ListWaitingRoomsWithOptionsAsync(ListWaitingRoomsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWaitingRooms",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWaitingRoomsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询等候室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWaitingRoomsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWaitingRoomsResponse
        /// </returns>
        public ListWaitingRoomsResponse ListWaitingRooms(ListWaitingRoomsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWaitingRoomsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询等候室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWaitingRoomsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWaitingRoomsResponse
        /// </returns>
        public async Task<ListWaitingRoomsResponse> ListWaitingRoomsAsync(ListWaitingRoomsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWaitingRoomsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>缓存预热</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PreloadCachesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreloadCachesResponse
        /// </returns>
        public PreloadCachesResponse PreloadCachesWithOptions(PreloadCachesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PreloadCachesShrinkRequest request = new PreloadCachesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Content))
            {
                request.ContentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Content, "Content", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Headers))
            {
                request.HeadersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Headers, "Headers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentShrink))
            {
                query["Content"] = request.ContentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HeadersShrink))
            {
                query["Headers"] = request.HeadersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreloadCaches",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreloadCachesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>缓存预热</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PreloadCachesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreloadCachesResponse
        /// </returns>
        public async Task<PreloadCachesResponse> PreloadCachesWithOptionsAsync(PreloadCachesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PreloadCachesShrinkRequest request = new PreloadCachesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Content))
            {
                request.ContentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Content, "Content", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Headers))
            {
                request.HeadersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Headers, "Headers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentShrink))
            {
                query["Content"] = request.ContentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HeadersShrink))
            {
                query["Headers"] = request.HeadersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreloadCaches",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreloadCachesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>缓存预热</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreloadCachesRequest
        /// </param>
        /// 
        /// <returns>
        /// PreloadCachesResponse
        /// </returns>
        public PreloadCachesResponse PreloadCaches(PreloadCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PreloadCachesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>缓存预热</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreloadCachesRequest
        /// </param>
        /// 
        /// <returns>
        /// PreloadCachesResponse
        /// </returns>
        public async Task<PreloadCachesResponse> PreloadCachesAsync(PreloadCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PreloadCachesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>缓存刷新</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PurgeCachesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PurgeCachesResponse
        /// </returns>
        public PurgeCachesResponse PurgeCachesWithOptions(PurgeCachesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PurgeCachesShrinkRequest request = new PurgeCachesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Content))
            {
                request.ContentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Content, "Content", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentShrink))
            {
                query["Content"] = request.ContentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdgeComputePurge))
            {
                query["EdgeComputePurge"] = request.EdgeComputePurge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
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
                Action = "PurgeCaches",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PurgeCachesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>缓存刷新</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PurgeCachesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PurgeCachesResponse
        /// </returns>
        public async Task<PurgeCachesResponse> PurgeCachesWithOptionsAsync(PurgeCachesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PurgeCachesShrinkRequest request = new PurgeCachesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Content))
            {
                request.ContentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Content, "Content", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentShrink))
            {
                query["Content"] = request.ContentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdgeComputePurge))
            {
                query["EdgeComputePurge"] = request.EdgeComputePurge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
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
                Action = "PurgeCaches",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PurgeCachesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>缓存刷新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PurgeCachesRequest
        /// </param>
        /// 
        /// <returns>
        /// PurgeCachesResponse
        /// </returns>
        public PurgeCachesResponse PurgeCaches(PurgeCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PurgeCachesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>缓存刷新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PurgeCachesRequest
        /// </param>
        /// 
        /// <returns>
        /// PurgeCachesResponse
        /// </returns>
        public async Task<PurgeCachesResponse> PurgeCachesAsync(PurgeCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PurgeCachesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置Namespace的Key-Value对</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutKvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutKvResponse
        /// </returns>
        public PutKvResponse PutKvWithOptions(PutKvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Base64))
            {
                query["Base64"] = request.Base64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expiration))
            {
                query["Expiration"] = request.Expiration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpirationTtl))
            {
                query["ExpirationTtl"] = request.ExpirationTtl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutKv",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutKvResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置Namespace的Key-Value对</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutKvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutKvResponse
        /// </returns>
        public async Task<PutKvResponse> PutKvWithOptionsAsync(PutKvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Base64))
            {
                query["Base64"] = request.Base64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expiration))
            {
                query["Expiration"] = request.Expiration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpirationTtl))
            {
                query["ExpirationTtl"] = request.ExpirationTtl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutKv",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutKvResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置Namespace的Key-Value对</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutKvRequest
        /// </param>
        /// 
        /// <returns>
        /// PutKvResponse
        /// </returns>
        public PutKvResponse PutKv(PutKvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutKvWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置Namespace的Key-Value对</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutKvRequest
        /// </param>
        /// 
        /// <returns>
        /// PutKvResponse
        /// </returns>
        public async Task<PutKvResponse> PutKvAsync(PutKvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutKvWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置Namespace的Key-Value对，支持最大25M的Body</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutKvWithHighCapacityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutKvWithHighCapacityResponse
        /// </returns>
        public PutKvWithHighCapacityResponse PutKvWithHighCapacityWithOptions(PutKvWithHighCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutKvWithHighCapacity",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutKvWithHighCapacityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置Namespace的Key-Value对，支持最大25M的Body</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutKvWithHighCapacityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutKvWithHighCapacityResponse
        /// </returns>
        public async Task<PutKvWithHighCapacityResponse> PutKvWithHighCapacityWithOptionsAsync(PutKvWithHighCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutKvWithHighCapacity",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutKvWithHighCapacityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置Namespace的Key-Value对，支持最大25M的Body</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutKvWithHighCapacityRequest
        /// </param>
        /// 
        /// <returns>
        /// PutKvWithHighCapacityResponse
        /// </returns>
        public PutKvWithHighCapacityResponse PutKvWithHighCapacity(PutKvWithHighCapacityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutKvWithHighCapacityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置Namespace的Key-Value对，支持最大25M的Body</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutKvWithHighCapacityRequest
        /// </param>
        /// 
        /// <returns>
        /// PutKvWithHighCapacityResponse
        /// </returns>
        public async Task<PutKvWithHighCapacityResponse> PutKvWithHighCapacityAsync(PutKvWithHighCapacityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutKvWithHighCapacityWithOptionsAsync(request, runtime);
        }

        public PutKvWithHighCapacityResponse PutKvWithHighCapacityAdvance(PutKvWithHighCapacityAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "ESA",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            PutKvWithHighCapacityRequest putKvWithHighCapacityReq = new PutKvWithHighCapacityRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, putKvWithHighCapacityReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.UrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                putKvWithHighCapacityReq.Url = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            PutKvWithHighCapacityResponse putKvWithHighCapacityResp = PutKvWithHighCapacityWithOptions(putKvWithHighCapacityReq, runtime);
            return putKvWithHighCapacityResp;
        }

        public async Task<PutKvWithHighCapacityResponse> PutKvWithHighCapacityAdvanceAsync(PutKvWithHighCapacityAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "ESA",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            PutKvWithHighCapacityRequest putKvWithHighCapacityReq = new PutKvWithHighCapacityRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, putKvWithHighCapacityReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.UrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                putKvWithHighCapacityReq.Url = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            PutKvWithHighCapacityResponse putKvWithHighCapacityResp = await PutKvWithHighCapacityWithOptionsAsync(putKvWithHighCapacityReq, runtime);
            return putKvWithHighCapacityResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置定时预热任务的进度，从头开始预热</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetScheduledPreloadJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetScheduledPreloadJobResponse
        /// </returns>
        public ResetScheduledPreloadJobResponse ResetScheduledPreloadJobWithOptions(ResetScheduledPreloadJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetScheduledPreloadJob",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetScheduledPreloadJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置定时预热任务的进度，从头开始预热</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetScheduledPreloadJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetScheduledPreloadJobResponse
        /// </returns>
        public async Task<ResetScheduledPreloadJobResponse> ResetScheduledPreloadJobWithOptionsAsync(ResetScheduledPreloadJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetScheduledPreloadJob",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetScheduledPreloadJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置定时预热任务的进度，从头开始预热</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetScheduledPreloadJobRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetScheduledPreloadJobResponse
        /// </returns>
        public ResetScheduledPreloadJobResponse ResetScheduledPreloadJob(ResetScheduledPreloadJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetScheduledPreloadJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置定时预热任务的进度，从头开始预热</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetScheduledPreloadJobRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetScheduledPreloadJobResponse
        /// </returns>
        public async Task<ResetScheduledPreloadJobResponse> ResetScheduledPreloadJobAsync(ResetScheduledPreloadJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetScheduledPreloadJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetCertificateResponse
        /// </returns>
        public SetCertificateResponse SetCertificateWithOptions(SetCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CasId))
            {
                body["CasId"] = request.CasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Certificate))
            {
                body["Certificate"] = request.Certificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateKey))
            {
                body["PrivateKey"] = request.PrivateKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                body["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Update))
            {
                body["Update"] = request.Update;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetCertificate",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCertificateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetCertificateResponse
        /// </returns>
        public async Task<SetCertificateResponse> SetCertificateWithOptionsAsync(SetCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CasId))
            {
                body["CasId"] = request.CasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Certificate))
            {
                body["Certificate"] = request.Certificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateKey))
            {
                body["PrivateKey"] = request.PrivateKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                body["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Update))
            {
                body["Update"] = request.Update;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetCertificate",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// SetCertificateResponse
        /// </returns>
        public SetCertificateResponse SetCertificate(SetCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// SetCertificateResponse
        /// </returns>
        public async Task<SetCertificateResponse> SetCertificateAsync(SetCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置HTTP DDoS智能防护配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetHttpDDoSAttackIntelligentProtectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetHttpDDoSAttackIntelligentProtectionResponse
        /// </returns>
        public SetHttpDDoSAttackIntelligentProtectionResponse SetHttpDDoSAttackIntelligentProtectionWithOptions(SetHttpDDoSAttackIntelligentProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AiMode))
            {
                query["AiMode"] = request.AiMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AiTemplate))
            {
                query["AiTemplate"] = request.AiTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetHttpDDoSAttackIntelligentProtection",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetHttpDDoSAttackIntelligentProtectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置HTTP DDoS智能防护配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetHttpDDoSAttackIntelligentProtectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetHttpDDoSAttackIntelligentProtectionResponse
        /// </returns>
        public async Task<SetHttpDDoSAttackIntelligentProtectionResponse> SetHttpDDoSAttackIntelligentProtectionWithOptionsAsync(SetHttpDDoSAttackIntelligentProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AiMode))
            {
                query["AiMode"] = request.AiMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AiTemplate))
            {
                query["AiTemplate"] = request.AiTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetHttpDDoSAttackIntelligentProtection",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetHttpDDoSAttackIntelligentProtectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置HTTP DDoS智能防护配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetHttpDDoSAttackIntelligentProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// SetHttpDDoSAttackIntelligentProtectionResponse
        /// </returns>
        public SetHttpDDoSAttackIntelligentProtectionResponse SetHttpDDoSAttackIntelligentProtection(SetHttpDDoSAttackIntelligentProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetHttpDDoSAttackIntelligentProtectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置HTTP DDoS智能防护配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetHttpDDoSAttackIntelligentProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// SetHttpDDoSAttackIntelligentProtectionResponse
        /// </returns>
        public async Task<SetHttpDDoSAttackIntelligentProtectionResponse> SetHttpDDoSAttackIntelligentProtectionAsync(SetHttpDDoSAttackIntelligentProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetHttpDDoSAttackIntelligentProtectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置HTTP DDoS攻击防护配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetHttpDDoSAttackProtectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetHttpDDoSAttackProtectionResponse
        /// </returns>
        public SetHttpDDoSAttackProtectionResponse SetHttpDDoSAttackProtectionWithOptions(SetHttpDDoSAttackProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalMode))
            {
                query["GlobalMode"] = request.GlobalMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetHttpDDoSAttackProtection",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetHttpDDoSAttackProtectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置HTTP DDoS攻击防护配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetHttpDDoSAttackProtectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetHttpDDoSAttackProtectionResponse
        /// </returns>
        public async Task<SetHttpDDoSAttackProtectionResponse> SetHttpDDoSAttackProtectionWithOptionsAsync(SetHttpDDoSAttackProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalMode))
            {
                query["GlobalMode"] = request.GlobalMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetHttpDDoSAttackProtection",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetHttpDDoSAttackProtectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置HTTP DDoS攻击防护配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetHttpDDoSAttackProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// SetHttpDDoSAttackProtectionResponse
        /// </returns>
        public SetHttpDDoSAttackProtectionResponse SetHttpDDoSAttackProtection(SetHttpDDoSAttackProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetHttpDDoSAttackProtectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置HTTP DDoS攻击防护配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetHttpDDoSAttackProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// SetHttpDDoSAttackProtectionResponse
        /// </returns>
        public async Task<SetHttpDDoSAttackProtectionResponse> SetHttpDDoSAttackProtectionAsync(SetHttpDDoSAttackProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetHttpDDoSAttackProtectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开始单个定时预热计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartScheduledPreloadExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartScheduledPreloadExecutionResponse
        /// </returns>
        public StartScheduledPreloadExecutionResponse StartScheduledPreloadExecutionWithOptions(StartScheduledPreloadExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartScheduledPreloadExecution",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartScheduledPreloadExecutionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开始单个定时预热计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartScheduledPreloadExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartScheduledPreloadExecutionResponse
        /// </returns>
        public async Task<StartScheduledPreloadExecutionResponse> StartScheduledPreloadExecutionWithOptionsAsync(StartScheduledPreloadExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartScheduledPreloadExecution",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartScheduledPreloadExecutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开始单个定时预热计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartScheduledPreloadExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// StartScheduledPreloadExecutionResponse
        /// </returns>
        public StartScheduledPreloadExecutionResponse StartScheduledPreloadExecution(StartScheduledPreloadExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartScheduledPreloadExecutionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开始单个定时预热计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartScheduledPreloadExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// StartScheduledPreloadExecutionResponse
        /// </returns>
        public async Task<StartScheduledPreloadExecutionResponse> StartScheduledPreloadExecutionAsync(StartScheduledPreloadExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartScheduledPreloadExecutionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止单个定时预热计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopScheduledPreloadExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopScheduledPreloadExecutionResponse
        /// </returns>
        public StopScheduledPreloadExecutionResponse StopScheduledPreloadExecutionWithOptions(StopScheduledPreloadExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopScheduledPreloadExecution",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopScheduledPreloadExecutionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止单个定时预热计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopScheduledPreloadExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopScheduledPreloadExecutionResponse
        /// </returns>
        public async Task<StopScheduledPreloadExecutionResponse> StopScheduledPreloadExecutionWithOptionsAsync(StopScheduledPreloadExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopScheduledPreloadExecution",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopScheduledPreloadExecutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止单个定时预热计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopScheduledPreloadExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// StopScheduledPreloadExecutionResponse
        /// </returns>
        public StopScheduledPreloadExecutionResponse StopScheduledPreloadExecution(StopScheduledPreloadExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopScheduledPreloadExecutionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止单个定时预热计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopScheduledPreloadExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// StopScheduledPreloadExecutionResponse
        /// </returns>
        public async Task<StopScheduledPreloadExecutionResponse> StopScheduledPreloadExecutionAsync(StopScheduledPreloadExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopScheduledPreloadExecutionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将表达式转换为匹配项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransformExpressionToMatchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransformExpressionToMatchResponse
        /// </returns>
        public TransformExpressionToMatchResponse TransformExpressionToMatchWithOptions(TransformExpressionToMatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expression))
            {
                body["Expression"] = request.Expression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                body["Phase"] = request.Phase;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransformExpressionToMatch",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransformExpressionToMatchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将表达式转换为匹配项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransformExpressionToMatchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransformExpressionToMatchResponse
        /// </returns>
        public async Task<TransformExpressionToMatchResponse> TransformExpressionToMatchWithOptionsAsync(TransformExpressionToMatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expression))
            {
                body["Expression"] = request.Expression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                body["Phase"] = request.Phase;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransformExpressionToMatch",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransformExpressionToMatchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将表达式转换为匹配项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransformExpressionToMatchRequest
        /// </param>
        /// 
        /// <returns>
        /// TransformExpressionToMatchResponse
        /// </returns>
        public TransformExpressionToMatchResponse TransformExpressionToMatch(TransformExpressionToMatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransformExpressionToMatchWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将表达式转换为匹配项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransformExpressionToMatchRequest
        /// </param>
        /// 
        /// <returns>
        /// TransformExpressionToMatchResponse
        /// </returns>
        public async Task<TransformExpressionToMatchResponse> TransformExpressionToMatchAsync(TransformExpressionToMatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransformExpressionToMatchWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将匹配项转换为表达式</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// TransformMatchToExpressionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransformMatchToExpressionResponse
        /// </returns>
        public TransformMatchToExpressionResponse TransformMatchToExpressionWithOptions(TransformMatchToExpressionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TransformMatchToExpressionShrinkRequest request = new TransformMatchToExpressionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Match))
            {
                request.MatchShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Match, "Match", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchShrink))
            {
                body["Match"] = request.MatchShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                body["Phase"] = request.Phase;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransformMatchToExpression",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransformMatchToExpressionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将匹配项转换为表达式</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// TransformMatchToExpressionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransformMatchToExpressionResponse
        /// </returns>
        public async Task<TransformMatchToExpressionResponse> TransformMatchToExpressionWithOptionsAsync(TransformMatchToExpressionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TransformMatchToExpressionShrinkRequest request = new TransformMatchToExpressionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Match))
            {
                request.MatchShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Match, "Match", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchShrink))
            {
                body["Match"] = request.MatchShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                body["Phase"] = request.Phase;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransformMatchToExpression",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransformMatchToExpressionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将匹配项转换为表达式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransformMatchToExpressionRequest
        /// </param>
        /// 
        /// <returns>
        /// TransformMatchToExpressionResponse
        /// </returns>
        public TransformMatchToExpressionResponse TransformMatchToExpression(TransformMatchToExpressionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransformMatchToExpressionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将匹配项转换为表达式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransformMatchToExpressionRequest
        /// </param>
        /// 
        /// <returns>
        /// TransformMatchToExpressionResponse
        /// </returns>
        public async Task<TransformMatchToExpressionResponse> TransformMatchToExpressionAsync(TransformMatchToExpressionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransformMatchToExpressionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为资源列表统一解绑标签</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
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
                Version = "2024-09-10",
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
        /// <para>为资源列表统一解绑标签</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
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
                Version = "2024-09-10",
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
        /// <para>为资源列表统一解绑标签</para>
        /// </summary>
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
        /// <para>为资源列表统一解绑标签</para>
        /// </summary>
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
        /// <para>修改定制场景策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomScenePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomScenePolicyResponse
        /// </returns>
        public UpdateCustomScenePolicyResponse UpdateCustomScenePolicyWithOptions(UpdateCustomScenePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Objects))
            {
                query["Objects"] = request.Objects;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Template))
            {
                query["Template"] = request.Template;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomScenePolicy",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomScenePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改定制场景策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomScenePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomScenePolicyResponse
        /// </returns>
        public async Task<UpdateCustomScenePolicyResponse> UpdateCustomScenePolicyWithOptionsAsync(UpdateCustomScenePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Objects))
            {
                query["Objects"] = request.Objects;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Template))
            {
                query["Template"] = request.Template;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomScenePolicy",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomScenePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改定制场景策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomScenePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomScenePolicyResponse
        /// </returns>
        public UpdateCustomScenePolicyResponse UpdateCustomScenePolicy(UpdateCustomScenePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCustomScenePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改定制场景策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomScenePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomScenePolicyResponse
        /// </returns>
        public async Task<UpdateCustomScenePolicyResponse> UpdateCustomScenePolicyAsync(UpdateCustomScenePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCustomScenePolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重命名账号下的Namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKvNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKvNamespaceResponse
        /// </returns>
        public UpdateKvNamespaceResponse UpdateKvNamespaceWithOptions(UpdateKvNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
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
                Action = "UpdateKvNamespace",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKvNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重命名账号下的Namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKvNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKvNamespaceResponse
        /// </returns>
        public async Task<UpdateKvNamespaceResponse> UpdateKvNamespaceWithOptionsAsync(UpdateKvNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
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
                Action = "UpdateKvNamespace",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKvNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重命名账号下的Namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKvNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKvNamespaceResponse
        /// </returns>
        public UpdateKvNamespaceResponse UpdateKvNamespace(UpdateKvNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateKvNamespaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重命名账号下的Namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKvNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKvNamespaceResponse
        /// </returns>
        public async Task<UpdateKvNamespaceResponse> UpdateKvNamespaceAsync(UpdateKvNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateKvNamespaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自定义列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateListResponse
        /// </returns>
        public UpdateListResponse UpdateListWithOptions(UpdateListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateListShrinkRequest request = new UpdateListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Items))
            {
                request.ItemsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Items, "Items", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemsShrink))
            {
                body["Items"] = request.ItemsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateList",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自定义列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateListResponse
        /// </returns>
        public async Task<UpdateListResponse> UpdateListWithOptionsAsync(UpdateListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateListShrinkRequest request = new UpdateListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Items))
            {
                request.ItemsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Items, "Items", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemsShrink))
            {
                body["Items"] = request.ItemsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateList",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自定义列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateListRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateListResponse
        /// </returns>
        public UpdateListResponse UpdateList(UpdateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自定义列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateListRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateListResponse
        /// </returns>
        public async Task<UpdateListResponse> UpdateListAsync(UpdateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自定义响应页面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePageResponse
        /// </returns>
        public UpdatePageResponse UpdatePageWithOptions(UpdatePageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["ContentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePage",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自定义响应页面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePageResponse
        /// </returns>
        public async Task<UpdatePageResponse> UpdatePageWithOptionsAsync(UpdatePageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["ContentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePage",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自定义响应页面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePageResponse
        /// </returns>
        public UpdatePageResponse UpdatePage(UpdatePageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自定义响应页面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePageResponse
        /// </returns>
        public async Task<UpdatePageResponse> UpdatePageAsync(UpdatePageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新记录</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRecordResponse
        /// </returns>
        public UpdateRecordResponse UpdateRecordWithOptions(UpdateRecordRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateRecordShrinkRequest request = new UpdateRecordShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AuthConf))
            {
                request.AuthConfShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AuthConf, "AuthConf", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Data))
            {
                request.DataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Data, "Data", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfShrink))
            {
                query["AuthConf"] = request.AuthConfShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                query["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataShrink))
            {
                query["Data"] = request.DataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostPolicy))
            {
                query["HostPolicy"] = request.HostPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proxied))
            {
                query["Proxied"] = request.Proxied;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["RecordId"] = request.RecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                query["Ttl"] = request.Ttl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRecord",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新记录</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRecordResponse
        /// </returns>
        public async Task<UpdateRecordResponse> UpdateRecordWithOptionsAsync(UpdateRecordRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateRecordShrinkRequest request = new UpdateRecordShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AuthConf))
            {
                request.AuthConfShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AuthConf, "AuthConf", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Data))
            {
                request.DataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Data, "Data", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfShrink))
            {
                query["AuthConf"] = request.AuthConfShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                query["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataShrink))
            {
                query["Data"] = request.DataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostPolicy))
            {
                query["HostPolicy"] = request.HostPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proxied))
            {
                query["Proxied"] = request.Proxied;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["RecordId"] = request.RecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                query["Ttl"] = request.Ttl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRecord",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRecordResponse
        /// </returns>
        public UpdateRecordResponse UpdateRecord(UpdateRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRecordResponse
        /// </returns>
        public async Task<UpdateRecordResponse> UpdateRecordAsync(UpdateRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新单个定时预热计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScheduledPreloadExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduledPreloadExecutionResponse
        /// </returns>
        public UpdateScheduledPreloadExecutionResponse UpdateScheduledPreloadExecutionWithOptions(UpdateScheduledPreloadExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                body["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SliceLen))
            {
                body["SliceLen"] = request.SliceLen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateScheduledPreloadExecution",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScheduledPreloadExecutionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新单个定时预热计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScheduledPreloadExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduledPreloadExecutionResponse
        /// </returns>
        public async Task<UpdateScheduledPreloadExecutionResponse> UpdateScheduledPreloadExecutionWithOptionsAsync(UpdateScheduledPreloadExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                body["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SliceLen))
            {
                body["SliceLen"] = request.SliceLen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateScheduledPreloadExecution",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScheduledPreloadExecutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新单个定时预热计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScheduledPreloadExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduledPreloadExecutionResponse
        /// </returns>
        public UpdateScheduledPreloadExecutionResponse UpdateScheduledPreloadExecution(UpdateScheduledPreloadExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateScheduledPreloadExecutionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新单个定时预热计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScheduledPreloadExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduledPreloadExecutionResponse
        /// </returns>
        public async Task<UpdateScheduledPreloadExecutionResponse> UpdateScheduledPreloadExecutionAsync(UpdateScheduledPreloadExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateScheduledPreloadExecutionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改站点接入方式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSiteAccessTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteAccessTypeResponse
        /// </returns>
        public UpdateSiteAccessTypeResponse UpdateSiteAccessTypeWithOptions(UpdateSiteAccessTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessType))
            {
                query["AccessType"] = request.AccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSiteAccessType",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSiteAccessTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改站点接入方式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSiteAccessTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteAccessTypeResponse
        /// </returns>
        public async Task<UpdateSiteAccessTypeResponse> UpdateSiteAccessTypeWithOptionsAsync(UpdateSiteAccessTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessType))
            {
                query["AccessType"] = request.AccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSiteAccessType",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSiteAccessTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改站点接入方式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSiteAccessTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteAccessTypeResponse
        /// </returns>
        public UpdateSiteAccessTypeResponse UpdateSiteAccessType(UpdateSiteAccessTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSiteAccessTypeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改站点接入方式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSiteAccessTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteAccessTypeResponse
        /// </returns>
        public async Task<UpdateSiteAccessTypeResponse> UpdateSiteAccessTypeAsync(UpdateSiteAccessTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSiteAccessTypeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新站点加速区域</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSiteCoverageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteCoverageResponse
        /// </returns>
        public UpdateSiteCoverageResponse UpdateSiteCoverageWithOptions(UpdateSiteCoverageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Coverage))
            {
                query["Coverage"] = request.Coverage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSiteCoverage",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSiteCoverageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新站点加速区域</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSiteCoverageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteCoverageResponse
        /// </returns>
        public async Task<UpdateSiteCoverageResponse> UpdateSiteCoverageWithOptionsAsync(UpdateSiteCoverageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Coverage))
            {
                query["Coverage"] = request.Coverage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSiteCoverage",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSiteCoverageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新站点加速区域</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSiteCoverageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteCoverageResponse
        /// </returns>
        public UpdateSiteCoverageResponse UpdateSiteCoverage(UpdateSiteCoverageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSiteCoverageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新站点加速区域</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSiteCoverageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteCoverageResponse
        /// </returns>
        public async Task<UpdateSiteCoverageResponse> UpdateSiteCoverageAsync(UpdateSiteCoverageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSiteCoverageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自定义字段</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateSiteCustomLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteCustomLogResponse
        /// </returns>
        public UpdateSiteCustomLogResponse UpdateSiteCustomLogWithOptions(UpdateSiteCustomLogRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSiteCustomLogShrinkRequest request = new UpdateSiteCustomLogShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Cookies))
            {
                request.CookiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Cookies, "Cookies", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestHeaders))
            {
                request.RequestHeadersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestHeaders, "RequestHeaders", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResponseHeaders))
            {
                request.ResponseHeadersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResponseHeaders, "ResponseHeaders", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CookiesShrink))
            {
                body["Cookies"] = request.CookiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestHeadersShrink))
            {
                body["RequestHeaders"] = request.RequestHeadersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseHeadersShrink))
            {
                body["ResponseHeaders"] = request.ResponseHeadersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                body["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSiteCustomLog",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSiteCustomLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自定义字段</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateSiteCustomLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteCustomLogResponse
        /// </returns>
        public async Task<UpdateSiteCustomLogResponse> UpdateSiteCustomLogWithOptionsAsync(UpdateSiteCustomLogRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSiteCustomLogShrinkRequest request = new UpdateSiteCustomLogShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Cookies))
            {
                request.CookiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Cookies, "Cookies", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestHeaders))
            {
                request.RequestHeadersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestHeaders, "RequestHeaders", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResponseHeaders))
            {
                request.ResponseHeadersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResponseHeaders, "ResponseHeaders", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CookiesShrink))
            {
                body["Cookies"] = request.CookiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestHeadersShrink))
            {
                body["RequestHeaders"] = request.RequestHeadersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseHeadersShrink))
            {
                body["ResponseHeaders"] = request.ResponseHeadersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                body["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSiteCustomLog",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSiteCustomLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自定义字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSiteCustomLogRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteCustomLogResponse
        /// </returns>
        public UpdateSiteCustomLogResponse UpdateSiteCustomLog(UpdateSiteCustomLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSiteCustomLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自定义字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSiteCustomLogRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteCustomLogResponse
        /// </returns>
        public async Task<UpdateSiteCustomLogResponse> UpdateSiteCustomLogAsync(UpdateSiteCustomLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSiteCustomLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改一个任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSiteDeliveryTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteDeliveryTaskResponse
        /// </returns>
        public UpdateSiteDeliveryTaskResponse UpdateSiteDeliveryTaskWithOptions(UpdateSiteDeliveryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                body["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscardRate))
            {
                body["DiscardRate"] = request.DiscardRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldName))
            {
                body["FieldName"] = request.FieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                body["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSiteDeliveryTask",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSiteDeliveryTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改一个任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSiteDeliveryTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteDeliveryTaskResponse
        /// </returns>
        public async Task<UpdateSiteDeliveryTaskResponse> UpdateSiteDeliveryTaskWithOptionsAsync(UpdateSiteDeliveryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                body["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscardRate))
            {
                body["DiscardRate"] = request.DiscardRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldName))
            {
                body["FieldName"] = request.FieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                body["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSiteDeliveryTask",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSiteDeliveryTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改一个任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSiteDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteDeliveryTaskResponse
        /// </returns>
        public UpdateSiteDeliveryTaskResponse UpdateSiteDeliveryTask(UpdateSiteDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSiteDeliveryTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改一个任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSiteDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteDeliveryTaskResponse
        /// </returns>
        public async Task<UpdateSiteDeliveryTaskResponse> UpdateSiteDeliveryTaskAsync(UpdateSiteDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSiteDeliveryTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上下线一个任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSiteDeliveryTaskStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteDeliveryTaskStatusResponse
        /// </returns>
        public UpdateSiteDeliveryTaskStatusResponse UpdateSiteDeliveryTaskStatusWithOptions(UpdateSiteDeliveryTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSiteDeliveryTaskStatus",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSiteDeliveryTaskStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上下线一个任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSiteDeliveryTaskStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteDeliveryTaskStatusResponse
        /// </returns>
        public async Task<UpdateSiteDeliveryTaskStatusResponse> UpdateSiteDeliveryTaskStatusWithOptionsAsync(UpdateSiteDeliveryTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSiteDeliveryTaskStatus",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSiteDeliveryTaskStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上下线一个任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSiteDeliveryTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteDeliveryTaskStatusResponse
        /// </returns>
        public UpdateSiteDeliveryTaskStatusResponse UpdateSiteDeliveryTaskStatus(UpdateSiteDeliveryTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSiteDeliveryTaskStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上下线一个任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSiteDeliveryTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteDeliveryTaskStatusResponse
        /// </returns>
        public async Task<UpdateSiteDeliveryTaskStatusResponse> UpdateSiteDeliveryTaskStatusAsync(UpdateSiteDeliveryTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSiteDeliveryTaskStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改站点自定义NS</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSiteVanityNSRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteVanityNSResponse
        /// </returns>
        public UpdateSiteVanityNSResponse UpdateSiteVanityNSWithOptions(UpdateSiteVanityNSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VanityNSList))
            {
                query["VanityNSList"] = request.VanityNSList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSiteVanityNS",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSiteVanityNSResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改站点自定义NS</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSiteVanityNSRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteVanityNSResponse
        /// </returns>
        public async Task<UpdateSiteVanityNSResponse> UpdateSiteVanityNSWithOptionsAsync(UpdateSiteVanityNSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VanityNSList))
            {
                query["VanityNSList"] = request.VanityNSList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSiteVanityNS",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSiteVanityNSResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改站点自定义NS</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSiteVanityNSRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteVanityNSResponse
        /// </returns>
        public UpdateSiteVanityNSResponse UpdateSiteVanityNS(UpdateSiteVanityNSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSiteVanityNSWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改站点自定义NS</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSiteVanityNSRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSiteVanityNSResponse
        /// </returns>
        public async Task<UpdateSiteVanityNSResponse> UpdateSiteVanityNSAsync(UpdateSiteVanityNSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSiteVanityNSWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改一个用户粒度任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserDeliveryTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserDeliveryTaskResponse
        /// </returns>
        public UpdateUserDeliveryTaskResponse UpdateUserDeliveryTaskWithOptions(UpdateUserDeliveryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                body["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscardRate))
            {
                body["DiscardRate"] = request.DiscardRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldName))
            {
                body["FieldName"] = request.FieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserDeliveryTask",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserDeliveryTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改一个用户粒度任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserDeliveryTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserDeliveryTaskResponse
        /// </returns>
        public async Task<UpdateUserDeliveryTaskResponse> UpdateUserDeliveryTaskWithOptionsAsync(UpdateUserDeliveryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                body["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscardRate))
            {
                body["DiscardRate"] = request.DiscardRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldName))
            {
                body["FieldName"] = request.FieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserDeliveryTask",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserDeliveryTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改一个用户粒度任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserDeliveryTaskResponse
        /// </returns>
        public UpdateUserDeliveryTaskResponse UpdateUserDeliveryTask(UpdateUserDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserDeliveryTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改一个用户粒度任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserDeliveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserDeliveryTaskResponse
        /// </returns>
        public async Task<UpdateUserDeliveryTaskResponse> UpdateUserDeliveryTaskAsync(UpdateUserDeliveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserDeliveryTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上下线一个用户任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserDeliveryTaskStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserDeliveryTaskStatusResponse
        /// </returns>
        public UpdateUserDeliveryTaskStatusResponse UpdateUserDeliveryTaskStatusWithOptions(UpdateUserDeliveryTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserDeliveryTaskStatus",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserDeliveryTaskStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上下线一个用户任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserDeliveryTaskStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserDeliveryTaskStatusResponse
        /// </returns>
        public async Task<UpdateUserDeliveryTaskStatusResponse> UpdateUserDeliveryTaskStatusWithOptionsAsync(UpdateUserDeliveryTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserDeliveryTaskStatus",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserDeliveryTaskStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上下线一个用户任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserDeliveryTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserDeliveryTaskStatusResponse
        /// </returns>
        public UpdateUserDeliveryTaskStatusResponse UpdateUserDeliveryTaskStatus(UpdateUserDeliveryTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserDeliveryTaskStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上下线一个用户任务投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserDeliveryTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserDeliveryTaskStatusResponse
        /// </returns>
        public async Task<UpdateUserDeliveryTaskStatusResponse> UpdateUserDeliveryTaskStatusAsync(UpdateUserDeliveryTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserDeliveryTaskStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新WAF规则页面</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateWafRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWafRuleResponse
        /// </returns>
        public UpdateWafRuleResponse UpdateWafRuleWithOptions(UpdateWafRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateWafRuleShrinkRequest request = new UpdateWafRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Config))
            {
                request.ConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Config, "Config", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigShrink))
            {
                body["Config"] = request.ConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Position))
            {
                body["Position"] = request.Position;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWafRule",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWafRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新WAF规则页面</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateWafRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWafRuleResponse
        /// </returns>
        public async Task<UpdateWafRuleResponse> UpdateWafRuleWithOptionsAsync(UpdateWafRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateWafRuleShrinkRequest request = new UpdateWafRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Config))
            {
                request.ConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Config, "Config", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigShrink))
            {
                body["Config"] = request.ConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Position))
            {
                body["Position"] = request.Position;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWafRule",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWafRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新WAF规则页面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWafRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWafRuleResponse
        /// </returns>
        public UpdateWafRuleResponse UpdateWafRule(UpdateWafRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWafRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新WAF规则页面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWafRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWafRuleResponse
        /// </returns>
        public async Task<UpdateWafRuleResponse> UpdateWafRuleAsync(UpdateWafRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWafRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新WAF规则集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWafRulesetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWafRulesetResponse
        /// </returns>
        public UpdateWafRulesetResponse UpdateWafRulesetWithOptions(UpdateWafRulesetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWafRuleset",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWafRulesetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新WAF规则集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWafRulesetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWafRulesetResponse
        /// </returns>
        public async Task<UpdateWafRulesetResponse> UpdateWafRulesetWithOptionsAsync(UpdateWafRulesetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteVersion))
            {
                query["SiteVersion"] = request.SiteVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWafRuleset",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWafRulesetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新WAF规则集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWafRulesetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWafRulesetResponse
        /// </returns>
        public UpdateWafRulesetResponse UpdateWafRuleset(UpdateWafRulesetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWafRulesetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新WAF规则集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWafRulesetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWafRulesetResponse
        /// </returns>
        public async Task<UpdateWafRulesetResponse> UpdateWafRulesetAsync(UpdateWafRulesetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWafRulesetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改等候室</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateWaitingRoomRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWaitingRoomResponse
        /// </returns>
        public UpdateWaitingRoomResponse UpdateWaitingRoomWithOptions(UpdateWaitingRoomRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateWaitingRoomShrinkRequest request = new UpdateWaitingRoomShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HostNameAndPath))
            {
                request.HostNameAndPathShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HostNameAndPath, "HostNameAndPath", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CookieName))
            {
                query["CookieName"] = request.CookieName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPageHtml))
            {
                query["CustomPageHtml"] = request.CustomPageHtml;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableSessionRenewalEnable))
            {
                query["DisableSessionRenewalEnable"] = request.DisableSessionRenewalEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostNameAndPathShrink))
            {
                query["HostNameAndPath"] = request.HostNameAndPathShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonResponseEnable))
            {
                query["JsonResponseEnable"] = request.JsonResponseEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewUsersPerMinute))
            {
                query["NewUsersPerMinute"] = request.NewUsersPerMinute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueAllEnable))
            {
                query["QueueAllEnable"] = request.QueueAllEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueuingMethod))
            {
                query["QueuingMethod"] = request.QueuingMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueuingStatusCode))
            {
                query["QueuingStatusCode"] = request.QueuingStatusCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionDuration))
            {
                query["SessionDuration"] = request.SessionDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalActiveUsers))
            {
                query["TotalActiveUsers"] = request.TotalActiveUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomId))
            {
                query["WaitingRoomId"] = request.WaitingRoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomType))
            {
                query["WaitingRoomType"] = request.WaitingRoomType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWaitingRoom",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWaitingRoomResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改等候室</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateWaitingRoomRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWaitingRoomResponse
        /// </returns>
        public async Task<UpdateWaitingRoomResponse> UpdateWaitingRoomWithOptionsAsync(UpdateWaitingRoomRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateWaitingRoomShrinkRequest request = new UpdateWaitingRoomShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HostNameAndPath))
            {
                request.HostNameAndPathShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HostNameAndPath, "HostNameAndPath", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CookieName))
            {
                query["CookieName"] = request.CookieName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPageHtml))
            {
                query["CustomPageHtml"] = request.CustomPageHtml;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableSessionRenewalEnable))
            {
                query["DisableSessionRenewalEnable"] = request.DisableSessionRenewalEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostNameAndPathShrink))
            {
                query["HostNameAndPath"] = request.HostNameAndPathShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonResponseEnable))
            {
                query["JsonResponseEnable"] = request.JsonResponseEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewUsersPerMinute))
            {
                query["NewUsersPerMinute"] = request.NewUsersPerMinute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueAllEnable))
            {
                query["QueueAllEnable"] = request.QueueAllEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueuingMethod))
            {
                query["QueuingMethod"] = request.QueuingMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueuingStatusCode))
            {
                query["QueuingStatusCode"] = request.QueuingStatusCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionDuration))
            {
                query["SessionDuration"] = request.SessionDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalActiveUsers))
            {
                query["TotalActiveUsers"] = request.TotalActiveUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomId))
            {
                query["WaitingRoomId"] = request.WaitingRoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomType))
            {
                query["WaitingRoomType"] = request.WaitingRoomType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWaitingRoom",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWaitingRoomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改等候室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWaitingRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWaitingRoomResponse
        /// </returns>
        public UpdateWaitingRoomResponse UpdateWaitingRoom(UpdateWaitingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWaitingRoomWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改等候室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWaitingRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWaitingRoomResponse
        /// </returns>
        public async Task<UpdateWaitingRoomResponse> UpdateWaitingRoomAsync(UpdateWaitingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWaitingRoomWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改等候室事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWaitingRoomEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWaitingRoomEventResponse
        /// </returns>
        public UpdateWaitingRoomEventResponse UpdateWaitingRoomEventWithOptions(UpdateWaitingRoomEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPageHtml))
            {
                query["CustomPageHtml"] = request.CustomPageHtml;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableSessionRenewalEnable))
            {
                query["DisableSessionRenewalEnable"] = request.DisableSessionRenewalEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonResponseEnable))
            {
                query["JsonResponseEnable"] = request.JsonResponseEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewUsersPerMinute))
            {
                query["NewUsersPerMinute"] = request.NewUsersPerMinute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreQueueEnable))
            {
                query["PreQueueEnable"] = request.PreQueueEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreQueueStartTime))
            {
                query["PreQueueStartTime"] = request.PreQueueStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueuingMethod))
            {
                query["QueuingMethod"] = request.QueuingMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueuingStatusCode))
            {
                query["QueuingStatusCode"] = request.QueuingStatusCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RandomPreQueueEnable))
            {
                query["RandomPreQueueEnable"] = request.RandomPreQueueEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionDuration))
            {
                query["SessionDuration"] = request.SessionDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalActiveUsers))
            {
                query["TotalActiveUsers"] = request.TotalActiveUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomEventId))
            {
                query["WaitingRoomEventId"] = request.WaitingRoomEventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomType))
            {
                query["WaitingRoomType"] = request.WaitingRoomType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWaitingRoomEvent",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWaitingRoomEventResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改等候室事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWaitingRoomEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWaitingRoomEventResponse
        /// </returns>
        public async Task<UpdateWaitingRoomEventResponse> UpdateWaitingRoomEventWithOptionsAsync(UpdateWaitingRoomEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPageHtml))
            {
                query["CustomPageHtml"] = request.CustomPageHtml;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableSessionRenewalEnable))
            {
                query["DisableSessionRenewalEnable"] = request.DisableSessionRenewalEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonResponseEnable))
            {
                query["JsonResponseEnable"] = request.JsonResponseEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewUsersPerMinute))
            {
                query["NewUsersPerMinute"] = request.NewUsersPerMinute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreQueueEnable))
            {
                query["PreQueueEnable"] = request.PreQueueEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreQueueStartTime))
            {
                query["PreQueueStartTime"] = request.PreQueueStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueuingMethod))
            {
                query["QueuingMethod"] = request.QueuingMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueuingStatusCode))
            {
                query["QueuingStatusCode"] = request.QueuingStatusCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RandomPreQueueEnable))
            {
                query["RandomPreQueueEnable"] = request.RandomPreQueueEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionDuration))
            {
                query["SessionDuration"] = request.SessionDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalActiveUsers))
            {
                query["TotalActiveUsers"] = request.TotalActiveUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomEventId))
            {
                query["WaitingRoomEventId"] = request.WaitingRoomEventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomType))
            {
                query["WaitingRoomType"] = request.WaitingRoomType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWaitingRoomEvent",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWaitingRoomEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改等候室事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWaitingRoomEventRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWaitingRoomEventResponse
        /// </returns>
        public UpdateWaitingRoomEventResponse UpdateWaitingRoomEvent(UpdateWaitingRoomEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWaitingRoomEventWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改等候室事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWaitingRoomEventRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWaitingRoomEventResponse
        /// </returns>
        public async Task<UpdateWaitingRoomEventResponse> UpdateWaitingRoomEventAsync(UpdateWaitingRoomEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWaitingRoomEventWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改等候室规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWaitingRoomRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWaitingRoomRuleResponse
        /// </returns>
        public UpdateWaitingRoomRuleResponse UpdateWaitingRoomRuleWithOptions(UpdateWaitingRoomRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                query["Rule"] = request.Rule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleEnable))
            {
                query["RuleEnable"] = request.RuleEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomRuleId))
            {
                query["WaitingRoomRuleId"] = request.WaitingRoomRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWaitingRoomRule",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWaitingRoomRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改等候室规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWaitingRoomRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWaitingRoomRuleResponse
        /// </returns>
        public async Task<UpdateWaitingRoomRuleResponse> UpdateWaitingRoomRuleWithOptionsAsync(UpdateWaitingRoomRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                query["Rule"] = request.Rule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleEnable))
            {
                query["RuleEnable"] = request.RuleEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitingRoomRuleId))
            {
                query["WaitingRoomRuleId"] = request.WaitingRoomRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWaitingRoomRule",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWaitingRoomRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改等候室规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWaitingRoomRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWaitingRoomRuleResponse
        /// </returns>
        public UpdateWaitingRoomRuleResponse UpdateWaitingRoomRule(UpdateWaitingRoomRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWaitingRoomRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改等候室规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWaitingRoomRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWaitingRoomRuleResponse
        /// </returns>
        public async Task<UpdateWaitingRoomRuleResponse> UpdateWaitingRoomRuleAsync(UpdateWaitingRoomRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWaitingRoomRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>缓存刷新文件上传</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadFileResponse
        /// </returns>
        public UploadFileResponse UploadFileWithOptions(UploadFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadTaskName))
            {
                query["UploadTaskName"] = request.UploadTaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadFile",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>缓存刷新文件上传</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadFileResponse
        /// </returns>
        public async Task<UploadFileResponse> UploadFileWithOptionsAsync(UploadFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadTaskName))
            {
                query["UploadTaskName"] = request.UploadTaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadFile",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>缓存刷新文件上传</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadFileRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadFileResponse
        /// </returns>
        public UploadFileResponse UploadFile(UploadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>缓存刷新文件上传</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadFileRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadFileResponse
        /// </returns>
        public async Task<UploadFileResponse> UploadFileAsync(UploadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadFileWithOptionsAsync(request, runtime);
        }

        public UploadFileResponse UploadFileAdvance(UploadFileAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "ESA",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            UploadFileRequest uploadFileReq = new UploadFileRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, uploadFileReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.UrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                uploadFileReq.Url = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            UploadFileResponse uploadFileResp = UploadFileWithOptions(uploadFileReq, runtime);
            return uploadFileResp;
        }

        public async Task<UploadFileResponse> UploadFileAdvanceAsync(UploadFileAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "ESA",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            UploadFileRequest uploadFileReq = new UploadFileRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, uploadFileReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.UrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                uploadFileReq.Url = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            UploadFileResponse uploadFileResp = await UploadFileWithOptionsAsync(uploadFileReq, runtime);
            return uploadFileResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验站点的归属</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifySiteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifySiteResponse
        /// </returns>
        public VerifySiteResponse VerifySiteWithOptions(VerifySiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifySite",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifySiteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验站点的归属</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifySiteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifySiteResponse
        /// </returns>
        public async Task<VerifySiteResponse> VerifySiteWithOptionsAsync(VerifySiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifySite",
                Version = "2024-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifySiteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验站点的归属</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifySiteRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifySiteResponse
        /// </returns>
        public VerifySiteResponse VerifySite(VerifySiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifySiteWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验站点的归属</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifySiteRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifySiteResponse
        /// </returns>
        public async Task<VerifySiteResponse> VerifySiteAsync(VerifySiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifySiteWithOptionsAsync(request, runtime);
        }

    }
}
