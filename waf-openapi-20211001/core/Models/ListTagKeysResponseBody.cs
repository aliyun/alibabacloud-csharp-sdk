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
            /// <item><description><para>custom: The custom tag.</para>
            /// </description></item>
            /// <item><description><para>system: The system tag.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demoTagKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

        }

        /// <summary>
        /// <para>The pagination token. If NextToken is empty, there are no more results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0*****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8CB8BB88-24C7-5608-BF5E-4DCA****CF1C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
