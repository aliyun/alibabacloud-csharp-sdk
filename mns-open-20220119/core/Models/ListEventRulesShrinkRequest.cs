// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class ListEventRulesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is deprecated. Use PageSize for paged queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated. Use PageNum for paged queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cd7NlPlX4kgKCdsCWMiMR/+HnVzPLQ4/XLvjR64jZ7F9AQ+Mr3T59J6IVkuXeV3w</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number of the results to return.
        /// Valid values: 1 to 100000.
        /// If you set this parameter to a value less than 1, the system uses 1. If you set this parameter to a value greater than 100000, the system uses 100000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.
        /// Valid values: 10 to 50.
        /// If you set this parameter to a value less than 10, the system uses 10. If you set this parameter to a value greater than 50, the system uses 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the Alibaba Cloud service for which event notifications are configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <para>The resource name in the matching rule. This parameter is used to filter rules. For example, for Object Storage Service (OSS), this is the bucket name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-bucket</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule-xsXDW</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The subscriber.</para>
        /// </summary>
        [NameInMap("Subscription")]
        [Validation(Required=false)]
        public string SubscriptionShrink { get; set; }

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
