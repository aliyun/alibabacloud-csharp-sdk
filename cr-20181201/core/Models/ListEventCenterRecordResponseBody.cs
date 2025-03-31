// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListEventCenterRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of historical events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<ListEventCenterRecordResponseBodyRecords> Records { get; set; }
        public class ListEventCenterRecordResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>The time when the event was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1638188622000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The event notification channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EVENT_BRIDGE</para>
            /// </summary>
            [NameInMap("EventChannel")]
            [Validation(Required=false)]
            public string EventChannel { get; set; }

            /// <summary>
            /// <para>The ID of the event notification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7d478419-61df-49e5-b92b-30ce730c2127</para>
            /// </summary>
            [NameInMap("EventNotifyId")]
            [Validation(Required=false)]
            public string EventNotifyId { get; set; }

            /// <summary>
            /// <para>The notification method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>http</c>: The notification is sent over HTTP.</description></item>
            /// <item><description><c>https</c>: The notification is sent over HTTPS.</description></item>
            /// <item><description><c>dingding</c>: The notification is sent by using DingTalk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>http</para>
            /// </summary>
            [NameInMap("EventNotifyMethod")]
            [Validation(Required=false)]
            public string EventNotifyMethod { get; set; }

            /// <summary>
            /// <para>The type of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cr:Artifact:DeliveryChainCompleted</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-gl34plsa****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mychain</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The ID of the event record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crecrr-ctdbzwtkpr*****</para>
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

            /// <summary>
            /// <para>The name of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ruby-2.4.0</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <para>The ID of the event notification rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crecr-n6pbhgjxtla*****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The name of the event notification rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chain-demo</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ruby-2.4.0</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The time when the event was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1638188622000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>665C7A5E-BAEC-5BCD-AF9F-5F9260D672BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total entries of historical events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
