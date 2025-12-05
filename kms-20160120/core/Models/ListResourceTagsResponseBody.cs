// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListResourceTagsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4162a6af-bc99-40b3-a552-89dcc8aaf7c8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The tags of the CMK.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public ListResourceTagsResponseBodyTags Tags { get; set; }
        public class ListResourceTagsResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<ListResourceTagsResponseBodyTagsTag> Tag { get; set; }
            public class ListResourceTagsResponseBodyTagsTag : TeaModel {
                /// <summary>
                /// <para>The globally unique ID of the CMK.</para>
                /// 
                /// <b>Example:</b>
                /// <para>33caea95-c3e5-4b3e-a9c6-cec76e4e****</para>
                /// </summary>
                [NameInMap("KeyId")]
                [Validation(Required=false)]
                public string KeyId { get; set; }

                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Project</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

    }

}
