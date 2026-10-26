// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class QueryNotifyResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned fields.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryNotifyResponseBodyData Data { get; set; }
        public class QueryNotifyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of notifications.</para>
            /// </summary>
            [NameInMap("NotifyItemList")]
            [Validation(Required=false)]
            public List<QueryNotifyResponseBodyDataNotifyItemList> NotifyItemList { get; set; }
            public class QueryNotifyResponseBodyDataNotifyItemList : TeaModel {
                /// <summary>
                /// <para>The ID of the current Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22973492****</para>
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public long? AliUid { get; set; }

                /// <summary>
                /// <para>Indicates whether the notification has been received. This indicates whether the <a href="https://help.aliyun.com/document_detail/610444.html">ConfirmNotify</a> operation was called to mark the notification as confirmed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Yes.</description></item>
                /// <item><description><b>false</b>: No.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ConfirmFlag")]
                [Validation(Required=false)]
                public bool? ConfirmFlag { get; set; }

                /// <summary>
                /// <para>The UID of the user who received the notification under the current Alibaba Cloud account. This user called the <a href="https://help.aliyun.com/document_detail/610444.html">ConfirmNotify</a> operation to mark the notification as confirmed.</para>
                /// <para>A value of <b>0</b> indicates that the notification was automatically received by the system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Confirmor")]
                [Validation(Required=false)]
                public long? Confirmor { get; set; }

                /// <summary>
                /// <para>The time when the notification was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-04-21T02:04:04Z</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <para>The time when the notification was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-04-21T02:10:47Z</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The notification ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>103499</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The number of times that duplicate notifications were blocked.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IdempotentCount")]
                [Validation(Required=false)]
                public string IdempotentCount { get; set; }

                /// <summary>
                /// <para>The ID used to ensure the idempotence of the notification and prevent duplicate notifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ETnLKlblzczshOTUbOCz****</para>
                /// </summary>
                [NameInMap("IdempotentId")]
                [Validation(Required=false)]
                public string IdempotentId { get; set; }

                /// <summary>
                /// <para>The level of the notification. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>help</b>: Help level.</description></item>
                /// <item><description><b>success</b>: Success level.</description></item>
                /// <item><description><b>warning</b>: Warning level.</description></item>
                /// <item><description><b>error</b>: Error level.</description></item>
                /// <item><description><b>loading</b>: In progress.</description></item>
                /// <item><description><b>notice</b>: Notice level.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>error</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The elements in the notification template, which consist of a JSON string. The parameters contained in the JSON string vary based on the <b>TemplateName</b>.</para>
                /// <list type="bullet">
                /// <item><description>If <b>TemplateName</b> is <b>RenewalRecommend</b>:<list type="bullet">
                /// <item><description><b>instanceName</b>: the ID of the instance that is about to expire.</description></item>
                /// <item><description><b>reservedTime</b>: the number of remaining days.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>If <b>TemplateName</b> is <b>InstanceCreateFailed</b>:<list type="bullet">
                /// <item><description><b>orderId</b>: the order ID for purchasing the instance.</description></item>
                /// <item><description><b>reason</b>: the reason why the instance failed to be created.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;orderId\&quot;:21466****}</para>
                /// </summary>
                [NameInMap("NotifyElement")]
                [Validation(Required=false)]
                public string NotifyElement { get; set; }

                /// <summary>
                /// <para>The notification template. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>RenewalRecommend</b>: Renewal recommendation.</description></item>
                /// <item><description><b>InstanceCreateFailed</b>: Instance creation failure and refund.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>InstanceCreateFailed</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// <para>The notification type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Sell</b>: Sales notification.</description></item>
                /// <item><description><b>Operation</b>: O&amp;M notification.</description></item>
                /// <item><description><b>Promotion</b>: Promotional notification.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Sell</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

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
            /// <para>25</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalRecordCount")]
            [Validation(Required=false)]
            public int? TotalRecordCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94CB8D93-017A-5AE7-A118-6E0F89D93C0A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
