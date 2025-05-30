// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeTagResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34AB41F1-04A5-496F-8C8D-634BDBE6A9FB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The tags that are attached to the specified resource.</para>
        /// </summary>
        [NameInMap("TagResources")]
        [Validation(Required=false)]
        public List<DescribeTagResourcesResponseBodyTagResources> TagResources { get; set; }
        public class DescribeTagResourcesResponseBodyTagResources : TeaModel {
            /// <summary>
            /// <para>The ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The key-value pair of the tag.</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeTagResourcesResponseBodyTagResourcesTag> Tag { get; set; }
            public class DescribeTagResourcesResponseBodyTagResourcesTag : TeaModel {
                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>product</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
