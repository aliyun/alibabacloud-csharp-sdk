// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListTagsForPrivateAccessApplicationResponseBody : TeaModel {
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<ListTagsForPrivateAccessApplicationResponseBodyApplications> Applications { get; set; }
        public class ListTagsForPrivateAccessApplicationResponseBodyApplications : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>pa-application-7a4445897856****</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTagsForPrivateAccessApplicationResponseBodyApplicationsTags> Tags { get; set; }
            public class ListTagsForPrivateAccessApplicationResponseBodyApplicationsTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-07-01 16:05:26</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tag_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tag-c0cb77857a99****</para>
                /// </summary>
                [NameInMap("TagId")]
                [Validation(Required=false)]
                public string TagId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Default</para>
                /// </summary>
                [NameInMap("TagType")]
                [Validation(Required=false)]
                public string TagType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7241F45B-E8D3-5BA3-8172-8A58AC2AB0FC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
