// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeComponentIndexResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F99407AB-2FA9-489E-A259-40CF6DCC47D9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeComponentIndexResponseBodyResult Result { get; set; }
        public class DescribeComponentIndexResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The metadata, which is used to store information such as remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;description&quot;: &quot;set number of shards to one&quot; }</para>
            /// </summary>
            [NameInMap("_meta")]
            [Validation(Required=false)]
            public Dictionary<string, object> Meta { get; set; }

            /// <summary>
            /// <para>The template information.</para>
            /// </summary>
            [NameInMap("template")]
            [Validation(Required=false)]
            public DescribeComponentIndexResponseBodyResultTemplate Template { get; set; }
            public class DescribeComponentIndexResponseBodyResultTemplate : TeaModel {
                /// <summary>
                /// <para>The alias configuration of the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("aliases")]
                [Validation(Required=false)]
                public Dictionary<string, object> Aliases { get; set; }

                /// <summary>
                /// <para>The mappings configuration of the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;properties&quot;: { &quot;@timestamp&quot;: { &quot;type&quot;: &quot;date&quot; } } }</para>
                /// </summary>
                [NameInMap("mappings")]
                [Validation(Required=false)]
                public Dictionary<string, object> Mappings { get; set; }

                /// <summary>
                /// <para>The settings configuration of the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;index.number_of_replicas&quot;: 0 }</para>
                /// </summary>
                [NameInMap("settings")]
                [Validation(Required=false)]
                public Dictionary<string, object> Settings { get; set; }

            }

        }

    }

}
