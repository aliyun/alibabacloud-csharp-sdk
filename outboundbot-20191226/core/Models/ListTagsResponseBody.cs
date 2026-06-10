// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListTagsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The list of tag groups.</para>
        /// </summary>
        [NameInMap("TagGroups")]
        [Validation(Required=false)]
        public List<ListTagsResponseBodyTagGroups> TagGroups { get; set; }
        public class ListTagsResponseBodyTagGroups : TeaModel {
            /// <summary>
            /// <para>The ID of the script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>365b955d-6f4d-4ab5-a6e1-9a301307f4b1</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <para>The name of the tag group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>当前学历</para>
            /// </summary>
            [NameInMap("TagGroup")]
            [Validation(Required=false)]
            public string TagGroup { get; set; }

            /// <summary>
            /// <para>The ID of the tag group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>38c03261-9fe8-4b9b-8c3b-983a60319012</para>
            /// </summary>
            [NameInMap("TagGroupId")]
            [Validation(Required=false)]
            public string TagGroupId { get; set; }

            /// <summary>
            /// <para>The index of the tag group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TagGroupIndex")]
            [Validation(Required=false)]
            public int? TagGroupIndex { get; set; }

        }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListTagsResponseBodyTags> Tags { get; set; }
        public class ListTagsResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The ID of the script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8a4c6d3d-5ed6-44ca-b779-16c20f8862be</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <para>The name of the tag group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>当前学历</para>
            /// </summary>
            [NameInMap("TagGroup")]
            [Validation(Required=false)]
            public string TagGroup { get; set; }

            /// <summary>
            /// <para>The ID of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d62be647-6202-4b1f-9708-0baeec552635</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

            /// <summary>
            /// <para>The index of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TagIndex")]
            [Validation(Required=false)]
            public int? TagIndex { get; set; }

            /// <summary>
            /// <para>The name of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>本科</para>
            /// </summary>
            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

    }

}
