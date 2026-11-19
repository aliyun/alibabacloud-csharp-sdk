// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class ListEventRulesRequest : TeaModel {
        /// <summary>
        /// <para><b>[Deprecated]</b> Use PageSize for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> Use PageNum for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cd7NlPlX4kgKCdsCWMiMR/+HnVzPLQ4/XLvjR64jZ7F9AQ+Mr3T59J6IVkuXeV3w</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number of the returned results. Valid values: 1 to 100000. If the specified value is less than 1, the system defaults to 1. If the specified value is greater than 100000, the system defaults to 100000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 10 to 50. If the specified value is less than 10, the system defaults to 10. If the specified value is greater than 50, the system defaults to 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the cloud service for event notifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <para>The resource name in the matching rules, used to filter rules. For example, in OSS, this is the OSS bucket name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-bucket</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The filter condition for the rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule-xsXDW</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The subscription endpoint.</para>
        /// </summary>
        [NameInMap("Subscription")]
        [Validation(Required=false)]
        public ListEventRulesRequestSubscription Subscription { get; set; }
        public class ListEventRulesRequestSubscription : TeaModel {
            /// <summary>
            /// <para>The endpoint type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>topic</b>: The topic type. A topic supports delivery to multiple subscription endpoints. You can add or remove subscription endpoints later.</description></item>
            /// <item><description><b>queue</b>: The queue type. Messages are delivered directly to a queue. This reduces the link path, but you cannot add new subscription endpoints later.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>topic</para>
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// <para>The actual value of the receiving endpoint. When EndpointType is set to topic, this is the topic name. When EndpointType is set to queue, this is the queue name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-topic</para>
            /// </summary>
            [NameInMap("EndpointValue")]
            [Validation(Required=false)]
            public string EndpointValue { get; set; }

        }

        /// <summary>
        /// <para>The name of the topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-topic</para>
        /// </summary>
        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}
