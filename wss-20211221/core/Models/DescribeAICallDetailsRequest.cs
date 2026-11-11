// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeAICallDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The business edition. Valid values: ENTERPRISE or 1 for Enterprise Edition, and BUSINESS or 20 for Business Edition. Default value: Enterprise Edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The end time of the query, exclusive. Specify the time in ISO 8601 format with time zone, accurate to seconds. Default value: the current time. The end time must be later than StartTime and cannot be later than the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-06T00:00:00+08:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The region of the AI gateway logs. Valid values: cn-shanghai (Shanghai), cn-hongkong (Hong Kong), ap-southeast-1 (Singapore), and us-east-1 (US East). The cn-hangzhou value is also supported and routed to cn-shanghai in the production environment. If this parameter is not specified, the default value is cn-shanghai for the China site and ap-southeast-1 for the international site.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("GatewayRegion")]
        [Validation(Required=false)]
        public string GatewayRegion { get; set; }

        /// <summary>
        /// <para>The requested model ID during invocation for exact match. Fuzzy match is not supported. This ID may be different from the actual executed model Model returned in the response. If this parameter is not specified or is left empty, no filtering is performed. The value can be up to 128 characters in length and cannot contain control characters or vertical bars.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-model</para>
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1. The product of PageNumber and PageSize cannot exceed 1,000,000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 50. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The model invocation request ID for exact match. This ID is different from the RequestId of the current API operation. If this parameter is not specified or is left empty, no filtering is performed. The value can be up to 128 characters in length and cannot contain control characters or vertical bars. This condition is combined with other filter conditions by using the AND operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model-call-example-001</para>
        /// </summary>
        [NameInMap("SearchRequestId")]
        [Validation(Required=false)]
        public string SearchRequestId { get; set; }

        /// <summary>
        /// <para>The start time of the query, inclusive. Specify the time in ISO 8601 format with time zone, accurate to seconds. Default value: 00:00:00 (UTC+8) of the current day. The start time cannot be earlier than three calendar months before the current time, and the query time range cannot exceed 30 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-05T00:00:00+08:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The list of user IDs. You can specify up to 50 user IDs. If this parameter is not specified or an empty array is passed, no filtering is performed. The user IDs in the list are combined by using the OR operator, and this condition is combined with other filter conditions by using the AND operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;wy-example-001&quot;]</para>
        /// </summary>
        [NameInMap("WyIds")]
        [Validation(Required=false)]
        public List<string> WyIds { get; set; }

    }

}
