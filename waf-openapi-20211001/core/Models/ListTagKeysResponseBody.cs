// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ListTagKeysResponseBody : TeaModel {
        /// <summary>
        /// <para>The keys and types of the tags.</para>
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public List<ListTagKeysResponseBodyKeys> Keys { get; set; }
        public class ListTagKeysResponseBodyKeys : TeaModel {
            /// <summary>
            /// <para>The type of the tag. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>custom</description></item>
            /// <item><description>system</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demoTagKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0*****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8CB8BB88-24C7-5608-BF5E-4DCA****CF1C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
