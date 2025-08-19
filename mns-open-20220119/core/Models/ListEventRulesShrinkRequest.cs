// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class ListEventRulesShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cd7NlPlX4kgKCdsCWMiMR/+HnVzPLQ4/XLvjR64jZ7F9AQ+Mr3T59J6IVkuXeV3w</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-bucket</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rule-xsXDW</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("Subscription")]
        [Validation(Required=false)]
        public string SubscriptionShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-topic</para>
        /// </summary>
        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}
