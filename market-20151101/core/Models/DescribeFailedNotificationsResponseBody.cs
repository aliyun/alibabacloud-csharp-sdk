// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeFailedNotificationsResponseBody : TeaModel {
        [NameInMap("NotificationList")]
        [Validation(Required=false)]
        public List<DescribeFailedNotificationsResponseBodyNotificationList> NotificationList { get; set; }
        public class DescribeFailedNotificationsResponseBodyNotificationList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>orderPay</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1665988512000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;productCode&quot;:&quot;cmgj00001&quot;,&quot;orderId&quot;:&quot;123456&quot;,&quot;orderBizId&quot;:&quot;111222&quot;,&quot;action&quot;:&quot;orderPay&quot;,&quot;aliUid&quot;:&quot;12211222211&quot;,&quot;skuId&quot;:&quot;cmgj00001-prepay&quot;}</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>deab3673236843a3b378c7d8d25c5f01</para>
            /// </summary>
            [NameInMap("NotificationRequestId")]
            [Validation(Required=false)]
            public string NotificationRequestId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6EF60BEC-0242-43AF-BB20-270359FB54A7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>55</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
