// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListTagResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The token that determines the start point of the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c374bf4864448****</para>
        /// </summary>
        [NameInMap("next_token")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E368C761-F8F6-4A36-9B58-BD53D5******</para>
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The collection of tag resources.</para>
        /// </summary>
        [NameInMap("tag_resources")]
        [Validation(Required=false)]
        public ListTagResourcesResponseBodyTagResources TagResources { get; set; }
        public class ListTagResourcesResponseBodyTagResources : TeaModel {
            /// <summary>
            /// <para>The tag resource.</para>
            /// </summary>
            [NameInMap("tag_resource")]
            [Validation(Required=false)]
            public List<ListTagResourcesResponseBodyTagResourcesTagResource> TagResource { get; set; }
            public class ListTagResourcesResponseBodyTagResourcesTagResource : TeaModel {
                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c2e39566adf23481fa1164ed510****</para>
                /// </summary>
                [NameInMap("resource_id")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN::CS::CLUSTER</para>
                /// </summary>
                [NameInMap("resource_type")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ack.aliyun.com</para>
                /// </summary>
                [NameInMap("tag_key")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c71cf3d796c374bf48644482cb0c3****</para>
                /// </summary>
                [NameInMap("tag_value")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

    }

}
