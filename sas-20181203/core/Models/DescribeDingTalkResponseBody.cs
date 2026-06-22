// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDingTalkResponseBody : TeaModel {
        /// <summary>
        /// <para>The notification list.</para>
        /// </summary>
        [NameInMap("ActionList")]
        [Validation(Required=false)]
        public List<DescribeDingTalkResponseBodyActionList> ActionList { get; set; }
        public class DescribeDingTalkResponseBodyActionList : TeaModel {
            /// <summary>
            /// <para>The notification name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestRuleAction</para>
            /// </summary>
            [NameInMap("ActionName")]
            [Validation(Required=false)]
            public string ActionName { get; set; }

            /// <summary>
            /// <para>The UID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12312412341</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The notification scope configuration for messages. The value is a JSON string that contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>type</b>: the notification type.</description></item>
            /// <item><description><b>configItemList</b>: the notification scope.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;type&quot;:&quot;sas_analysis_pre-sas-operation-log-sas-event-suspicious&quot;,&quot;configItemList&quot;:[{&quot;key&quot;:&quot;item_level&quot;,&quot;valueList&quot;:[&quot;all&quot;]}]},{&quot;type&quot;:&quot;sas_analysis_pre-sas-operation-log-sas-event-hc&quot;,&quot;configItemList&quot;:[{&quot;key&quot;:&quot;item_level&quot;,&quot;valueList&quot;:[&quot;all&quot;]}]}]</para>
            /// </summary>
            [NameInMap("ConfigList")]
            [Validation(Required=false)]
            public string ConfigList { get; set; }

            /// <summary>
            /// <para>The language of the notification. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>zh</b>: Chinese</description></item>
            /// <item><description><b>en</b>: English.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("DingTalkLang")]
            [Validation(Required=false)]
            public string DingTalkLang { get; set; }

            /// <summary>
            /// <para>The creation timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1550828400000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1550828400000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The list of group IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;123,456&quot;</para>
            /// </summary>
            [NameInMap("GroupIdList")]
            [Validation(Required=false)]
            public string GroupIdList { get; set; }

            /// <summary>
            /// <para>The notification message ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para>The time interval. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("IntervalTime")]
            [Validation(Required=false)]
            public int? IntervalTime { get; set; }

            /// <summary>
            /// <para>The notification status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The notification parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://oapi.dingtalk.com/robot/send">https://oapi.dingtalk.com/robot/send</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeDingTalkResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeDingTalkResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The page number of the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries displayed per page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>149</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of this request, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B256A525-7E42-4BB9-A27C-9017FDDFF1A2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
