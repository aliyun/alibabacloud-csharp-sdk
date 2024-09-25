// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeTagsResponseBody : TeaModel {
        /// <summary>
        /// <para>The token that is used for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the value of <b>NextToken</b> is not returned, it indicates that no next query is to be sent.</description></item>
        /// <item><description>If a value of <b>NextToken</b> is returned, the value is the token that is used for the subsequent query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C46FF5A8-C5F0-4024-8262-B16B639225A0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of tags that meet the filter conditions.</para>
        /// </summary>
        [NameInMap("TagResources")]
        [Validation(Required=false)]
        public DescribeTagsResponseBodyTagResources TagResources { get; set; }
        public class DescribeTagsResponseBodyTagResources : TeaModel {
            [NameInMap("TagResource")]
            [Validation(Required=false)]
            public List<DescribeTagsResponseBodyTagResourcesTagResource> TagResource { get; set; }
            public class DescribeTagsResponseBodyTagResourcesTagResource : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceJoshua</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

    }

}
