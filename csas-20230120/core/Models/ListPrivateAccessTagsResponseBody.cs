// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPrivateAccessTagsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54C1D236-CDB9-586C-B44D-AFDCEA195545</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The internal access tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListPrivateAccessTagsResponseBodyTags> Tags { get; set; }
        public class ListPrivateAccessTagsResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The IDs of the internal access applications.</para>
            /// </summary>
            [NameInMap("ApplicationIds")]
            [Validation(Required=false)]
            public List<string> ApplicationIds { get; set; }

            /// <summary>
            /// <para>The time when the internal access tag was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-10 11:39:34</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the internal access tag.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the internal access tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag_name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The IDs of the internal access policies.</para>
            /// </summary>
            [NameInMap("PolicyIds")]
            [Validation(Required=false)]
            public List<string> PolicyIds { get; set; }

            /// <summary>
            /// <para>The ID of the internal access tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-d3f64e8bdd4a****</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

            /// <summary>
            /// <para>The type of the internal access tag. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Default</b></description></item>
            /// <item><description><b>Custom</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("TagType")]
            [Validation(Required=false)]
            public string TagType { get; set; }

        }

        /// <summary>
        /// <para>The total number of internal access tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
