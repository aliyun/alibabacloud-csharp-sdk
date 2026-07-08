// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appflow20230904.Models
{
    public class ListFlowsRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListFlowsRequestFilter> Filter { get; set; }
        public class ListFlowsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The name of the filter field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FlowId\FlowName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The filter values.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAVY3rYiv9VoUJQSiCitgjgTlo5Q2D1qyq9rPPhxWJPl6j8bgHiGAwZWnCMJPepC+WRjTa7fpTA0Diy2AQ4aWoPY=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Specifies the object tags to which the rule applies. You can specify multiple tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListFlowsRequestTag> Tag { get; set; }
        public class ListFlowsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can filter the cluster list by tag. You can specify up to 20 tag pairs. The numeric value n for each tag pair must be unique and must be a consecutive integer starting from 1. The value of Tag.N.Key corresponds to Tag.N.Value.</para>
            /// <remarks>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c>, <c>acs:</c>, <c>http://</c>, or <c>https://</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>CreateBy</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The authentication content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhangsan</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
