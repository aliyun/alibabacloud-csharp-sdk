// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListTagsForPrivateAccessApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>List of private network access applications.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<ListTagsForPrivateAccessApplicationResponseBodyApplications> Applications { get; set; }
        public class ListTagsForPrivateAccessApplicationResponseBodyApplications : TeaModel {
            /// <summary>
            /// <para>Private network access application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pa-application-7a4445897856****</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>Collection of private network access tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTagsForPrivateAccessApplicationResponseBodyApplicationsTags> Tags { get; set; }
            public class ListTagsForPrivateAccessApplicationResponseBodyApplicationsTags : TeaModel {
                /// <summary>
                /// <para>Creation time of the private network access tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-01 16:05:26</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Description of the private network access tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>这是一条内网访问标签</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Name of the internal network access tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Private network access tag ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag-c0cb77857a99****</para>
                /// </summary>
                [NameInMap("TagId")]
                [Validation(Required=false)]
                public string TagId { get; set; }

                /// <summary>
                /// <para>Private network access tag type. Values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Default</b>: Default.</para>
                /// </description></item>
                /// <item><description><para><b>Custom</b>: Custom.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Default</para>
                /// </summary>
                [NameInMap("TagType")]
                [Validation(Required=false)]
                public string TagType { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7241F45B-E8D3-5BA3-8172-8A58AC2AB0FC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
