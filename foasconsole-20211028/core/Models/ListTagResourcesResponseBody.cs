// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class ListTagResourcesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>27AE00</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0E5D17CE-BD83-5DC9-8CD2-3C40C2F7A135</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>87AE00</para>
        /// </summary>
        [NameInMap("TagReponseId")]
        [Validation(Required=false)]
        public string TagReponseId { get; set; }

        [NameInMap("TagResources")]
        [Validation(Required=false)]
        public List<ListTagResourcesResponseBodyTagResources> TagResources { get; set; }
        public class ListTagResourcesResponseBodyTagResources : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>f-cn-tyts</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vvpinstance</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tag</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

    }

}
