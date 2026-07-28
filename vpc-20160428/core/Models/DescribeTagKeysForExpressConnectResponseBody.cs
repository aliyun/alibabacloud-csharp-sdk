// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeTagKeysForExpressConnectResponseBody : TeaModel {
        /// <summary>
        /// <para>The token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next query exists.</description></item>
        /// <item><description>If <b>NextToken</b> has a return value, the value indicates the token for the next query.</description></item>
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
        /// <para>54B48E3D-DF70-471B-AA93-08E683A1B45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public DescribeTagKeysForExpressConnectResponseBodyTagKeys TagKeys { get; set; }
        public class DescribeTagKeysForExpressConnectResponseBodyTagKeys : TeaModel {
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public List<DescribeTagKeysForExpressConnectResponseBodyTagKeysTagKey> TagKey { get; set; }
            public class DescribeTagKeysForExpressConnectResponseBodyTagKeysTagKey : TeaModel {
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
