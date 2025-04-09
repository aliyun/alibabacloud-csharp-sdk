// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListTagsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
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

        [NameInMap("TagGroups")]
        [Validation(Required=false)]
        public List<ListTagsResponseBodyTagGroups> TagGroups { get; set; }
        public class ListTagsResponseBodyTagGroups : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>8a4c6d3d-5ed6-44ca-b779-16c20f8862be</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            [NameInMap("TagGroup")]
            [Validation(Required=false)]
            public string TagGroup { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>38c03261-9fe8-4b9b-8c3b-983a60319012</para>
            /// </summary>
            [NameInMap("TagGroupId")]
            [Validation(Required=false)]
            public string TagGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TagGroupIndex")]
            [Validation(Required=false)]
            public int? TagGroupIndex { get; set; }

        }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListTagsResponseBodyTags> Tags { get; set; }
        public class ListTagsResponseBodyTags : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>8a4c6d3d-5ed6-44ca-b779-16c20f8862be</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            [NameInMap("TagGroup")]
            [Validation(Required=false)]
            public string TagGroup { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>d62be647-6202-4b1f-9708-0baeec552635</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TagIndex")]
            [Validation(Required=false)]
            public int? TagIndex { get; set; }

            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

    }

}
