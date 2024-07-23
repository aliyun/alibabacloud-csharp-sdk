// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class QueryNotifyResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryNotifyResponseBodyData Data { get; set; }
        public class QueryNotifyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of notifications.</para>
            /// </summary>
            [NameInMap("NotifyItemList")]
            [Validation(Required=false)]
            public List<QueryNotifyResponseBodyDataNotifyItemList> NotifyItemList { get; set; }
            public class QueryNotifyResponseBodyDataNotifyItemList : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22973492**********</para>
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public long? AliUid { get; set; }

                /// <summary>
                /// <para>Indicates whether the notification has been confirmed. You can call the <a href="https://help.aliyun.com/document_detail/610444.html">ConfirmNotify</a> operation to mark the notification as confirmed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ConfirmFlag")]
                [Validation(Required=false)]
                public bool? ConfirmFlag { get; set; }

                /// <summary>
                /// <para>The UID of the contact who called the <a href="https://help.aliyun.com/document_detail/610444.html">ConfirmNotify</a> operation to mark the notification as confirmed. The contact belongs to the current Alibaba Cloud account.</para>
                /// <para>The value <b>0</b> indicates that the notification is automatically confirmed by the system.</para>
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
                /// <para>The ID of the notification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>103499</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The number of times that repeatedly sent notifications are blocked.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IdempotentCount")]
                [Validation(Required=false)]
                public string IdempotentCount { get; set; }

                /// <summary>
                /// <para>This parameter ensures the idempotence of the notification and prevents the notification from being repeatedly sent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ETnLKlblzczshOTUbOCzxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("IdempotentId")]
                [Validation(Required=false)]
                public string IdempotentId { get; set; }

                /// <summary>
                /// <para>The level of the notification. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>help</b></description></item>
                /// <item><description><b>success</b></description></item>
                /// <item><description><b>warning</b></description></item>
                /// <item><description><b>error</b></description></item>
                /// <item><description><b>loading</b></description></item>
                /// <item><description><b>notice</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>error</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The element in the notification template. This parameter is a JSON string. Fields in the JSON string vary based on the value of the <b>TemplateName</b> parameter.</para>
                /// <list type="bullet">
                /// <item><description><para>If the <b>TemplateName</b> parameter is <b>RenewalRecommend</b>, the JSON string contains the following fields:</para>
                /// <list type="bullet">
                /// <item><description><b>instanceName</b>: the ID of the instance that is about to expire</description></item>
                /// <item><description><b>reservedTime</b>: the remaining validity period of the instance in days</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If the <b>TemplateName</b> parameter is <b>InstanceCreateFailed</b>, the JSON string contains the following fields:</para>
                /// <list type="bullet">
                /// <item><description><b>orderId</b>: the ID of the order to purchase the instance</description></item>
                /// <item><description><b>reason</b>: the cause of the instance creation failure</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;orderId\&quot;:21466**********}</para>
                /// </summary>
                [NameInMap("NotifyElement")]
                [Validation(Required=false)]
                public string NotifyElement { get; set; }

                /// <summary>
                /// <para>The template of the notification. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>RenewalRecommend</b>: The template that is used to notify of renewal suggestions.</description></item>
                /// <item><description><b>InstanceCreateFailed</b>: The template that is used to notify that an instance fails to be created and is refunded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>InstanceCreateFailed</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// <para>The type of the notification. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Sell</b>: sales notification</description></item>
                /// <item><description><b>Operation</b>: O\&amp;M notification</description></item>
                /// <item><description><b>Promotion</b>: promotion notification</description></item>
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
            /// <para>The page number of the page returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
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
