// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.InternetBankOpen20240612.Models;

namespace AlibabaCloud.SDK.InternetBankOpen20240612
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "InternetBankOpen";
            AlibabaCloud.GatewayPop.Client gatewayClient = new AlibabaCloud.GatewayPop.Client();
            this._spi = gatewayClient;
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing", "internetbankopen.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("internetbankopen", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>查询AI报告</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询数据产品附带的 AI 报告状态，并在报告可用时返回临时下载地址。本接口是只读查询，不会再次调用数据服务方，也不会启动或重新生成报告。
        /// callId 与 reportId 必须且只能提供一个，参数名大小写以本页定义为准。按次报告：先调用 InvokeDataProduct 获取 callId，再用 callId 查询；报告状态为 AVAILABLE 时，从 Report 获取下载地址。周期报告：先调用 ListProductReports 获取 ReportId，再将该编号作为 reportId 查询；按周期商品的 callId 查询始终返回 WAITING_PERIOD，即使对应周期报告已经生成，也不会返回下载地址。内部任务编号不是本接口的查询键。
        /// 查询范围限定为当前云账号（主账号）所属的调用和报告；编号不存在或不属于该账号时，均返回 ReportNotFound（HTTP 404），不区分两种原因。使用 RAM 身份调用时，由网关校验 internetbank:GetAiReport 操作权限。
        /// 仅 ReportStatus 为 AVAILABLE 时返回 Report 对象。DownloadUrl 为临时签名下载地址，签发有效期不超过 300 秒，且不晚于 ContentExpiresAt；应在 UrlExpiresAt 前使用，不要公开分享。链接到期而报告内容仍在保留期内时，可以再次查询获取新链接。报告过期或被暂停交付时不返回下载地址；对象核验或签名等交付异常返回 ReportDeliveryFailed（HTTP 500）。参数不合法返回对应的 InvalidParameter 类错误（HTTP 400）。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAiReportRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAiReportResponse
        /// </returns>
        public GetAiReportResponse GetAiReportWithOptions(GetAiReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["callId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["reportId"] = request.ReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAiReport",
                Version = "2024-06-12",
                Protocol = "HTTPS",
                Pathname = "/pop/api/v1/ai-report",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAiReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询AI报告</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询数据产品附带的 AI 报告状态，并在报告可用时返回临时下载地址。本接口是只读查询，不会再次调用数据服务方，也不会启动或重新生成报告。
        /// callId 与 reportId 必须且只能提供一个，参数名大小写以本页定义为准。按次报告：先调用 InvokeDataProduct 获取 callId，再用 callId 查询；报告状态为 AVAILABLE 时，从 Report 获取下载地址。周期报告：先调用 ListProductReports 获取 ReportId，再将该编号作为 reportId 查询；按周期商品的 callId 查询始终返回 WAITING_PERIOD，即使对应周期报告已经生成，也不会返回下载地址。内部任务编号不是本接口的查询键。
        /// 查询范围限定为当前云账号（主账号）所属的调用和报告；编号不存在或不属于该账号时，均返回 ReportNotFound（HTTP 404），不区分两种原因。使用 RAM 身份调用时，由网关校验 internetbank:GetAiReport 操作权限。
        /// 仅 ReportStatus 为 AVAILABLE 时返回 Report 对象。DownloadUrl 为临时签名下载地址，签发有效期不超过 300 秒，且不晚于 ContentExpiresAt；应在 UrlExpiresAt 前使用，不要公开分享。链接到期而报告内容仍在保留期内时，可以再次查询获取新链接。报告过期或被暂停交付时不返回下载地址；对象核验或签名等交付异常返回 ReportDeliveryFailed（HTTP 500）。参数不合法返回对应的 InvalidParameter 类错误（HTTP 400）。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAiReportRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAiReportResponse
        /// </returns>
        public async Task<GetAiReportResponse> GetAiReportWithOptionsAsync(GetAiReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["callId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["reportId"] = request.ReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAiReport",
                Version = "2024-06-12",
                Protocol = "HTTPS",
                Pathname = "/pop/api/v1/ai-report",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAiReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询AI报告</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询数据产品附带的 AI 报告状态，并在报告可用时返回临时下载地址。本接口是只读查询，不会再次调用数据服务方，也不会启动或重新生成报告。
        /// callId 与 reportId 必须且只能提供一个，参数名大小写以本页定义为准。按次报告：先调用 InvokeDataProduct 获取 callId，再用 callId 查询；报告状态为 AVAILABLE 时，从 Report 获取下载地址。周期报告：先调用 ListProductReports 获取 ReportId，再将该编号作为 reportId 查询；按周期商品的 callId 查询始终返回 WAITING_PERIOD，即使对应周期报告已经生成，也不会返回下载地址。内部任务编号不是本接口的查询键。
        /// 查询范围限定为当前云账号（主账号）所属的调用和报告；编号不存在或不属于该账号时，均返回 ReportNotFound（HTTP 404），不区分两种原因。使用 RAM 身份调用时，由网关校验 internetbank:GetAiReport 操作权限。
        /// 仅 ReportStatus 为 AVAILABLE 时返回 Report 对象。DownloadUrl 为临时签名下载地址，签发有效期不超过 300 秒，且不晚于 ContentExpiresAt；应在 UrlExpiresAt 前使用，不要公开分享。链接到期而报告内容仍在保留期内时，可以再次查询获取新链接。报告过期或被暂停交付时不返回下载地址；对象核验或签名等交付异常返回 ReportDeliveryFailed（HTTP 500）。参数不合法返回对应的 InvalidParameter 类错误（HTTP 400）。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAiReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAiReportResponse
        /// </returns>
        public GetAiReportResponse GetAiReport(GetAiReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAiReportWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询AI报告</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询数据产品附带的 AI 报告状态，并在报告可用时返回临时下载地址。本接口是只读查询，不会再次调用数据服务方，也不会启动或重新生成报告。
        /// callId 与 reportId 必须且只能提供一个，参数名大小写以本页定义为准。按次报告：先调用 InvokeDataProduct 获取 callId，再用 callId 查询；报告状态为 AVAILABLE 时，从 Report 获取下载地址。周期报告：先调用 ListProductReports 获取 ReportId，再将该编号作为 reportId 查询；按周期商品的 callId 查询始终返回 WAITING_PERIOD，即使对应周期报告已经生成，也不会返回下载地址。内部任务编号不是本接口的查询键。
        /// 查询范围限定为当前云账号（主账号）所属的调用和报告；编号不存在或不属于该账号时，均返回 ReportNotFound（HTTP 404），不区分两种原因。使用 RAM 身份调用时，由网关校验 internetbank:GetAiReport 操作权限。
        /// 仅 ReportStatus 为 AVAILABLE 时返回 Report 对象。DownloadUrl 为临时签名下载地址，签发有效期不超过 300 秒，且不晚于 ContentExpiresAt；应在 UrlExpiresAt 前使用，不要公开分享。链接到期而报告内容仍在保留期内时，可以再次查询获取新链接。报告过期或被暂停交付时不返回下载地址；对象核验或签名等交付异常返回 ReportDeliveryFailed（HTTP 500）。参数不合法返回对应的 InvalidParameter 类错误（HTTP 400）。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAiReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAiReportResponse
        /// </returns>
        public async Task<GetAiReportResponse> GetAiReportAsync(GetAiReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAiReportWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a unified entry point to invoke data products.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Provides a unified entry point to invoke data products. After the gateway completes identity parsing, RAM authentication, and product authorization, it forwards the request to the data service provider corresponding to the data product and returns the business data. If the invocation is successful, HTTP 200 is returned, and the response body contains RequestId and Data. If the invocation fails, the corresponding HTTP status code is returned (400 for parameter errors, 403 for no permissions or inactive products, 409 if the first request with the same ClientToken is still being processed, 429 for throttled requests, 503 for temporarily unavailable services, and 500 for internal errors), and the response body includes Code and Message to explain the cause.
        /// This operation accepts only three business parameters: ClientToken, ProductCode, and ServiceParameters. It does not accept TaskId, Operation, parameters starting with Ai, or EnableAiArtifact (including when set to false). If these are passed, an InvalidParameter error is returned. Whether a product includes an AI report is determined by the product configuration corresponding to the ProductCode. For products that include reports, you can call ListProductReports to query the report list, and use GetAiReport to retrieve the report by CallId or ReportId.
        /// Prerequisites for invocation: When calling this operation with a RAM user, you must first grant the RAM user the operation permissions for this operation in RAM. Set Action to internetbank:InvokeDataProduct and Resource to acs:internetbank:<em>:<your Alibaba Cloud account UID>:</em>. No additional authorization is required when calling this operation directly with the AccessKey of an Alibaba Cloud account.
        /// Service-linked role: After the preceding authorization is completed, the system performs automatic creation of the service-linked role (SLR) AliyunServiceRoleForInternetBankPredict under your Alibaba Cloud account. This role is used to invoke the corresponding data service provider on behalf of the customer as a service. You can view the invocation records that associate with your account in ActionTrail.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InvokeDataProductRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvokeDataProductResponse
        /// </returns>
        public InvokeDataProductResponse InvokeDataProductWithOptions(InvokeDataProductRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                query["serviceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokeDataProduct",
                Version = "2024-06-12",
                Protocol = "HTTPS",
                Pathname = "/pop/api/v1/rpc",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokeDataProductResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a unified entry point to invoke data products.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Provides a unified entry point to invoke data products. After the gateway completes identity parsing, RAM authentication, and product authorization, it forwards the request to the data service provider corresponding to the data product and returns the business data. If the invocation is successful, HTTP 200 is returned, and the response body contains RequestId and Data. If the invocation fails, the corresponding HTTP status code is returned (400 for parameter errors, 403 for no permissions or inactive products, 409 if the first request with the same ClientToken is still being processed, 429 for throttled requests, 503 for temporarily unavailable services, and 500 for internal errors), and the response body includes Code and Message to explain the cause.
        /// This operation accepts only three business parameters: ClientToken, ProductCode, and ServiceParameters. It does not accept TaskId, Operation, parameters starting with Ai, or EnableAiArtifact (including when set to false). If these are passed, an InvalidParameter error is returned. Whether a product includes an AI report is determined by the product configuration corresponding to the ProductCode. For products that include reports, you can call ListProductReports to query the report list, and use GetAiReport to retrieve the report by CallId or ReportId.
        /// Prerequisites for invocation: When calling this operation with a RAM user, you must first grant the RAM user the operation permissions for this operation in RAM. Set Action to internetbank:InvokeDataProduct and Resource to acs:internetbank:<em>:<your Alibaba Cloud account UID>:</em>. No additional authorization is required when calling this operation directly with the AccessKey of an Alibaba Cloud account.
        /// Service-linked role: After the preceding authorization is completed, the system performs automatic creation of the service-linked role (SLR) AliyunServiceRoleForInternetBankPredict under your Alibaba Cloud account. This role is used to invoke the corresponding data service provider on behalf of the customer as a service. You can view the invocation records that associate with your account in ActionTrail.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InvokeDataProductRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvokeDataProductResponse
        /// </returns>
        public async Task<InvokeDataProductResponse> InvokeDataProductWithOptionsAsync(InvokeDataProductRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                query["serviceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokeDataProduct",
                Version = "2024-06-12",
                Protocol = "HTTPS",
                Pathname = "/pop/api/v1/rpc",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokeDataProductResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a unified entry point to invoke data products.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Provides a unified entry point to invoke data products. After the gateway completes identity parsing, RAM authentication, and product authorization, it forwards the request to the data service provider corresponding to the data product and returns the business data. If the invocation is successful, HTTP 200 is returned, and the response body contains RequestId and Data. If the invocation fails, the corresponding HTTP status code is returned (400 for parameter errors, 403 for no permissions or inactive products, 409 if the first request with the same ClientToken is still being processed, 429 for throttled requests, 503 for temporarily unavailable services, and 500 for internal errors), and the response body includes Code and Message to explain the cause.
        /// This operation accepts only three business parameters: ClientToken, ProductCode, and ServiceParameters. It does not accept TaskId, Operation, parameters starting with Ai, or EnableAiArtifact (including when set to false). If these are passed, an InvalidParameter error is returned. Whether a product includes an AI report is determined by the product configuration corresponding to the ProductCode. For products that include reports, you can call ListProductReports to query the report list, and use GetAiReport to retrieve the report by CallId or ReportId.
        /// Prerequisites for invocation: When calling this operation with a RAM user, you must first grant the RAM user the operation permissions for this operation in RAM. Set Action to internetbank:InvokeDataProduct and Resource to acs:internetbank:<em>:<your Alibaba Cloud account UID>:</em>. No additional authorization is required when calling this operation directly with the AccessKey of an Alibaba Cloud account.
        /// Service-linked role: After the preceding authorization is completed, the system performs automatic creation of the service-linked role (SLR) AliyunServiceRoleForInternetBankPredict under your Alibaba Cloud account. This role is used to invoke the corresponding data service provider on behalf of the customer as a service. You can view the invocation records that associate with your account in ActionTrail.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InvokeDataProductRequest
        /// </param>
        /// 
        /// <returns>
        /// InvokeDataProductResponse
        /// </returns>
        public InvokeDataProductResponse InvokeDataProduct(InvokeDataProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InvokeDataProductWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a unified entry point to invoke data products.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Provides a unified entry point to invoke data products. After the gateway completes identity parsing, RAM authentication, and product authorization, it forwards the request to the data service provider corresponding to the data product and returns the business data. If the invocation is successful, HTTP 200 is returned, and the response body contains RequestId and Data. If the invocation fails, the corresponding HTTP status code is returned (400 for parameter errors, 403 for no permissions or inactive products, 409 if the first request with the same ClientToken is still being processed, 429 for throttled requests, 503 for temporarily unavailable services, and 500 for internal errors), and the response body includes Code and Message to explain the cause.
        /// This operation accepts only three business parameters: ClientToken, ProductCode, and ServiceParameters. It does not accept TaskId, Operation, parameters starting with Ai, or EnableAiArtifact (including when set to false). If these are passed, an InvalidParameter error is returned. Whether a product includes an AI report is determined by the product configuration corresponding to the ProductCode. For products that include reports, you can call ListProductReports to query the report list, and use GetAiReport to retrieve the report by CallId or ReportId.
        /// Prerequisites for invocation: When calling this operation with a RAM user, you must first grant the RAM user the operation permissions for this operation in RAM. Set Action to internetbank:InvokeDataProduct and Resource to acs:internetbank:<em>:<your Alibaba Cloud account UID>:</em>. No additional authorization is required when calling this operation directly with the AccessKey of an Alibaba Cloud account.
        /// Service-linked role: After the preceding authorization is completed, the system performs automatic creation of the service-linked role (SLR) AliyunServiceRoleForInternetBankPredict under your Alibaba Cloud account. This role is used to invoke the corresponding data service provider on behalf of the customer as a service. You can view the invocation records that associate with your account in ActionTrail.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InvokeDataProductRequest
        /// </param>
        /// 
        /// <returns>
        /// InvokeDataProductResponse
        /// </returns>
        public async Task<InvokeDataProductResponse> InvokeDataProductAsync(InvokeDataProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InvokeDataProductWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询商品周期报告列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询当前云账号（主账号）下指定商品已经生成的可用周期报告。列表只用于发现报告编号和所属周期，不返回下载地址；取得 ReportId 后，调用 GetAiReport，并将该编号作为 reportId 获取最新状态及下载地址。本接口不会调用数据服务方，也不会触发报告生成。
        /// LatestOnly 省略或为 false 时，在最近十个已结束的北京时间自然周范围内查询，按周期从新到旧返回，最多十条报告记录；没有报告的周不会补空记录，不保证返回十份报告。LatestOnly 为 true 时，从所有已结束的历史周期中查找最近一条可用报告，最多返回一条，不受最近十周范围限制。
        /// 自然周按北京时间（Asia/Shanghai）计算，从周一 00:00:00 到下一周周一 00:00:00，区间左闭右开，不包含当前尚未结束的自然周。PeriodStart 与 PeriodEnd 使用 UTC RFC 3339 格式输出。一个自然周可能对应多条报告记录，因此两条记录的周期起止相同不表示重复，使用 ReportId 区分。
        /// 列表依据已发布报告的资产记录判断可用性，不返回已过期或被暂停交付的报告；实际下载状态以 GetAiReport 查询结果为准。没有可用报告时，成功返回空 Reports 数组，不返回 ReportNotFound。本接口只提供 ProductCode 和 LatestOnly 两个业务参数，不支持分页及自定义周期过滤；传入 PeriodStart、PageSize 或 NextToken 时返回对应的 InvalidParameter 类错误（HTTP 400）。
        /// 使用 RAM 身份调用时，由网关校验 internetbank:ListProductReports 操作权限。查询只读取当前账号的既有报告，不再次检查商品商业开通状态。参数错误返回对应的 InvalidParameter 类错误（HTTP 400）；报告资产记录不一致或查询异常返回 ReportDeliveryFailed（HTTP 500）。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListProductReportsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProductReportsResponse
        /// </returns>
        public ListProductReportsResponse ListProductReportsWithOptions(ListProductReportsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LatestOnly))
            {
                query["LatestOnly"] = request.LatestOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductReports",
                Version = "2024-06-12",
                Protocol = "HTTPS",
                Pathname = "/pop/api/v1/product-reports",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductReportsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询商品周期报告列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询当前云账号（主账号）下指定商品已经生成的可用周期报告。列表只用于发现报告编号和所属周期，不返回下载地址；取得 ReportId 后，调用 GetAiReport，并将该编号作为 reportId 获取最新状态及下载地址。本接口不会调用数据服务方，也不会触发报告生成。
        /// LatestOnly 省略或为 false 时，在最近十个已结束的北京时间自然周范围内查询，按周期从新到旧返回，最多十条报告记录；没有报告的周不会补空记录，不保证返回十份报告。LatestOnly 为 true 时，从所有已结束的历史周期中查找最近一条可用报告，最多返回一条，不受最近十周范围限制。
        /// 自然周按北京时间（Asia/Shanghai）计算，从周一 00:00:00 到下一周周一 00:00:00，区间左闭右开，不包含当前尚未结束的自然周。PeriodStart 与 PeriodEnd 使用 UTC RFC 3339 格式输出。一个自然周可能对应多条报告记录，因此两条记录的周期起止相同不表示重复，使用 ReportId 区分。
        /// 列表依据已发布报告的资产记录判断可用性，不返回已过期或被暂停交付的报告；实际下载状态以 GetAiReport 查询结果为准。没有可用报告时，成功返回空 Reports 数组，不返回 ReportNotFound。本接口只提供 ProductCode 和 LatestOnly 两个业务参数，不支持分页及自定义周期过滤；传入 PeriodStart、PageSize 或 NextToken 时返回对应的 InvalidParameter 类错误（HTTP 400）。
        /// 使用 RAM 身份调用时，由网关校验 internetbank:ListProductReports 操作权限。查询只读取当前账号的既有报告，不再次检查商品商业开通状态。参数错误返回对应的 InvalidParameter 类错误（HTTP 400）；报告资产记录不一致或查询异常返回 ReportDeliveryFailed（HTTP 500）。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListProductReportsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProductReportsResponse
        /// </returns>
        public async Task<ListProductReportsResponse> ListProductReportsWithOptionsAsync(ListProductReportsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LatestOnly))
            {
                query["LatestOnly"] = request.LatestOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductReports",
                Version = "2024-06-12",
                Protocol = "HTTPS",
                Pathname = "/pop/api/v1/product-reports",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductReportsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询商品周期报告列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询当前云账号（主账号）下指定商品已经生成的可用周期报告。列表只用于发现报告编号和所属周期，不返回下载地址；取得 ReportId 后，调用 GetAiReport，并将该编号作为 reportId 获取最新状态及下载地址。本接口不会调用数据服务方，也不会触发报告生成。
        /// LatestOnly 省略或为 false 时，在最近十个已结束的北京时间自然周范围内查询，按周期从新到旧返回，最多十条报告记录；没有报告的周不会补空记录，不保证返回十份报告。LatestOnly 为 true 时，从所有已结束的历史周期中查找最近一条可用报告，最多返回一条，不受最近十周范围限制。
        /// 自然周按北京时间（Asia/Shanghai）计算，从周一 00:00:00 到下一周周一 00:00:00，区间左闭右开，不包含当前尚未结束的自然周。PeriodStart 与 PeriodEnd 使用 UTC RFC 3339 格式输出。一个自然周可能对应多条报告记录，因此两条记录的周期起止相同不表示重复，使用 ReportId 区分。
        /// 列表依据已发布报告的资产记录判断可用性，不返回已过期或被暂停交付的报告；实际下载状态以 GetAiReport 查询结果为准。没有可用报告时，成功返回空 Reports 数组，不返回 ReportNotFound。本接口只提供 ProductCode 和 LatestOnly 两个业务参数，不支持分页及自定义周期过滤；传入 PeriodStart、PageSize 或 NextToken 时返回对应的 InvalidParameter 类错误（HTTP 400）。
        /// 使用 RAM 身份调用时，由网关校验 internetbank:ListProductReports 操作权限。查询只读取当前账号的既有报告，不再次检查商品商业开通状态。参数错误返回对应的 InvalidParameter 类错误（HTTP 400）；报告资产记录不一致或查询异常返回 ReportDeliveryFailed（HTTP 500）。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListProductReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProductReportsResponse
        /// </returns>
        public ListProductReportsResponse ListProductReports(ListProductReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProductReportsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询商品周期报告列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询当前云账号（主账号）下指定商品已经生成的可用周期报告。列表只用于发现报告编号和所属周期，不返回下载地址；取得 ReportId 后，调用 GetAiReport，并将该编号作为 reportId 获取最新状态及下载地址。本接口不会调用数据服务方，也不会触发报告生成。
        /// LatestOnly 省略或为 false 时，在最近十个已结束的北京时间自然周范围内查询，按周期从新到旧返回，最多十条报告记录；没有报告的周不会补空记录，不保证返回十份报告。LatestOnly 为 true 时，从所有已结束的历史周期中查找最近一条可用报告，最多返回一条，不受最近十周范围限制。
        /// 自然周按北京时间（Asia/Shanghai）计算，从周一 00:00:00 到下一周周一 00:00:00，区间左闭右开，不包含当前尚未结束的自然周。PeriodStart 与 PeriodEnd 使用 UTC RFC 3339 格式输出。一个自然周可能对应多条报告记录，因此两条记录的周期起止相同不表示重复，使用 ReportId 区分。
        /// 列表依据已发布报告的资产记录判断可用性，不返回已过期或被暂停交付的报告；实际下载状态以 GetAiReport 查询结果为准。没有可用报告时，成功返回空 Reports 数组，不返回 ReportNotFound。本接口只提供 ProductCode 和 LatestOnly 两个业务参数，不支持分页及自定义周期过滤；传入 PeriodStart、PageSize 或 NextToken 时返回对应的 InvalidParameter 类错误（HTTP 400）。
        /// 使用 RAM 身份调用时，由网关校验 internetbank:ListProductReports 操作权限。查询只读取当前账号的既有报告，不再次检查商品商业开通状态。参数错误返回对应的 InvalidParameter 类错误（HTTP 400）；报告资产记录不一致或查询异常返回 ReportDeliveryFailed（HTTP 500）。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListProductReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProductReportsResponse
        /// </returns>
        public async Task<ListProductReportsResponse> ListProductReportsAsync(ListProductReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProductReportsWithOptionsAsync(request, headers, runtime);
        }

    }
}
