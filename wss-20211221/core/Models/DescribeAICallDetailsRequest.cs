// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeAICallDetailsRequest : TeaModel {
        /// <summary>
        /// <para>业务版本，沿用售卖 BizType：ENTERPRISE 或 1 为企业版；BUSINESS 或 20 为商业版。未传默认企业版。</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>带时区的 ISO 8601 结束时间，整秒精度，默认当前时间；应大于开始时间且不晚于当前时间，区间左闭右开。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-06T00:00:00+08:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>网关日志地域：cn-shanghai（国内）、cn-hongkong（香港）、ap-southeast-1（新加坡）、us-east-1（美国）；兼容 cn-hangzhou，仅查询路由等同 cn-shanghai；杭州预发实际数据地域为 cn-hangzhou。不传时使用当前站点默认地域；预发只查询预发日志，国内映射杭州预发，美国预发未配置时返回 ServiceUnavailable。</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("GatewayRegion")]
        [Validation(Required=false)]
        public string GatewayRegion { get; set; }

        /// <summary>
        /// <para>可选请求模型 ID；不传或空白时不筛选，非空时精确匹配 custom_log.requestedModel 或 ai_log.request_model 任一字段，与 SearchRequestId、WyIds 等条件取交集。不按 ai_log.model 筛选，不支持模糊匹配。</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-model</para>
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>页码，从 1 开始；分页偏移超过查询上限时返回 InvalidParameter。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>每页返回数量，最大 50。</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>可选请求 ID；不传或空白时不筛选，非空时精确匹配 SLS request_id，与 ModelId、WyIds 等条件取交集。不得包含控制字符或管道符。</para>
        /// 
        /// <b>Example:</b>
        /// <para>model-call-example-001</para>
        /// </summary>
        [NameInMap("SearchRequestId")]
        [Validation(Required=false)]
        public string SearchRequestId { get; set; }

        /// <summary>
        /// <para>带时区的 ISO 8601 开始时间，整秒精度，默认 UTC+8 今日零点；不得早于当前时间按 UTC+8 回退 3 个自然月，区间不超过 30 天。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-05T00:00:00+08:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>可选用户 ID 列表，最多 50 项；不传或空数组时不筛选。非空时精确匹配 custom_log.wyId，列表内取 OR，与租户、BizType、SearchRequestId 和 ModelId 条件取 AND。每项去除首尾空白后为 1 至 128 个字符，不允许控制字符或管道符。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;wy-example-001&quot;]</para>
        /// </summary>
        [NameInMap("WyIds")]
        [Validation(Required=false)]
        public List<string> WyIds { get; set; }

    }

}
