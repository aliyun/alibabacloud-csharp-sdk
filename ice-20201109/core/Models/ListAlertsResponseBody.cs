// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListAlertsResponseBody : TeaModel {
        /// <summary>
        /// <para>The alerts.</para>
        /// </summary>
        [NameInMap("Alerts")]
        [Validation(Required=false)]
        public List<ListAlertsResponseBodyAlerts> Alerts { get; set; }
        public class ListAlertsResponseBodyAlerts : TeaModel {
            /// <summary>
            /// <para>The alert type.</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ScheduleError</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The time when the alert was received in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-16T10:03Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the alert was modified in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-16T10:03Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxx</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The ARN of the related resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ims:mediaweaver:<regionId>:<userId>:vodSource/mySourceLocation/MySource</para>
            /// </summary>
            [NameInMap("RelatedResourceArns")]
            [Validation(Required=false)]
            public string RelatedResourceArns { get; set; }

            /// <summary>
            /// <para>The ARN of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ims:mediaweaver:<regionId>:<userId>:vodSource/mySourceLocation/MySource</para>
            /// </summary>
            [NameInMap("ResourceArn")]
            [Validation(Required=false)]
            public string ResourceArn { get; set; }

        }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para><b>Request ID</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx-xxxx-xxxxx-xxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
