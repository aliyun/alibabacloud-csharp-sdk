// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListAlertsResponseBody : TeaModel {
        /// <summary>
        /// <para>The alert details.</para>
        /// </summary>
        [NameInMap("Alerts")]
        [Validation(Required=false)]
        public List<ListAlertsResponseBodyAlerts> Alerts { get; set; }
        public class ListAlertsResponseBodyAlerts : TeaModel {
            /// <summary>
            /// <para>The alert details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;alert_uuid&quot;:&quot;a3f8c2e1-9b7d-4f6a-8c2e-1d5b9a7f****&quot;}</para>
            /// </summary>
            [NameInMap("AlertRecord")]
            [Validation(Required=false)]
            public string AlertRecord { get; set; }

            /// <summary>
            /// <para>The alert UUID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>798341271677187</para>
            /// </summary>
            [NameInMap("AlertUuid")]
            [Validation(Required=false)]
            public string AlertUuid { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries to return in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
