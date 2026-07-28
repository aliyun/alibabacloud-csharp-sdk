// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeTagKeysResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination token. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no subsequent query exists.</description></item>
        /// <item><description>If <b>NextToken</b> is returned, the value indicates the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DE65F6B7-7566-4802-9007-96F2494AC512</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public DescribeTagKeysResponseBodyTagKeys TagKeys { get; set; }
        public class DescribeTagKeysResponseBodyTagKeys : TeaModel {
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public List<DescribeTagKeysResponseBodyTagKeysTagKey> TagKey { get; set; }
            public class DescribeTagKeysResponseBodyTagKeysTagKey : TeaModel {
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
