// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeTagKeysResponseBody : TeaModel {
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
        /// <para>DE65F6B7-7566-4802-9007-96F2494AC512</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of tag keys.</para>
        /// </summary>
        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public DescribeTagKeysResponseBodyTagKeys TagKeys { get; set; }
        public class DescribeTagKeysResponseBodyTagKeys : TeaModel {
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public List<DescribeTagKeysResponseBodyTagKeysTagKey> TagKey { get; set; }
            public class DescribeTagKeysResponseBodyTagKeysTagKey : TeaModel {
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
                /// <para>The type of the tag key. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Custom</b>: custom</description></item>
                /// <item><description><b>System</b>: system</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Custom</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
