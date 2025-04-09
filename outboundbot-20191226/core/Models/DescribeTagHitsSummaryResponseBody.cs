// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeTagHitsSummaryResponseBody : TeaModel {
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
        /// <para>5391EB13-A0E7-402D-A407-B99D4ABAF22A</para>
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
        public List<DescribeTagHitsSummaryResponseBodyTagGroups> TagGroups { get; set; }
        public class DescribeTagHitsSummaryResponseBodyTagGroups : TeaModel {
            /// <summary>
            /// <para>ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>8bb6f8ca-85a3-49f8-86a5-3127902a2156</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>84fc7c41-f918-4a47-b742-a439b35a8567</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            [NameInMap("TagGroup")]
            [Validation(Required=false)]
            public string TagGroup { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TagGroupIndex")]
            [Validation(Required=false)]
            public int? TagGroupIndex { get; set; }

        }

        [NameInMap("TagHitsList")]
        [Validation(Required=false)]
        public List<DescribeTagHitsSummaryResponseBodyTagHitsList> TagHitsList { get; set; }
        public class DescribeTagHitsSummaryResponseBodyTagHitsList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HitCount")]
            [Validation(Required=false)]
            public int? HitCount { get; set; }

            [NameInMap("TagGroup")]
            [Validation(Required=false)]
            public string TagGroup { get; set; }

            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

    }

}
