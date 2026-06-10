// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeTagHitsSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. <c>OK</c> indicates a successful request.</para>
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
        /// <para>5391EB13-A0E7-402D-A407-B99D4ABAF22A</para>
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
        /// <para>A list of tag groups.</para>
        /// </summary>
        [NameInMap("TagGroups")]
        [Validation(Required=false)]
        public List<DescribeTagHitsSummaryResponseBodyTagGroups> TagGroups { get; set; }
        public class DescribeTagHitsSummaryResponseBodyTagGroups : TeaModel {
            /// <summary>
            /// <para>The ID of the tag group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8bb6f8ca-85a3-49f8-86a5-3127902a2156</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The script ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8a4c6d3d-5ed6-44ca-b779-16c20f8862be</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <para>The tag group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>标签组</para>
            /// </summary>
            [NameInMap("TagGroup")]
            [Validation(Required=false)]
            public string TagGroup { get; set; }

            /// <summary>
            /// <para>The index of the tag group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TagGroupIndex")]
            [Validation(Required=false)]
            public int? TagGroupIndex { get; set; }

        }

        /// <summary>
        /// <para>A list of tag hit statistics.</para>
        /// </summary>
        [NameInMap("TagHitsList")]
        [Validation(Required=false)]
        public List<DescribeTagHitsSummaryResponseBodyTagHitsList> TagHitsList { get; set; }
        public class DescribeTagHitsSummaryResponseBodyTagHitsList : TeaModel {
            /// <summary>
            /// <para>The hit count for the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HitCount")]
            [Validation(Required=false)]
            public int? HitCount { get; set; }

            /// <summary>
            /// <para>The tag group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>当前学历</para>
            /// </summary>
            [NameInMap("TagGroup")]
            [Validation(Required=false)]
            public string TagGroup { get; set; }

            /// <summary>
            /// <para>The tag name.</para>
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
