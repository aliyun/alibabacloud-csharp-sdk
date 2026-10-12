// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListSkillsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListSkillsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListSkillsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The maximum number of entries returned in this request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token for the next page. An empty value indicates that the last page has been reached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The list of skills.</para>
            /// </summary>
            [NameInMap("Skills")]
            [Validation(Required=false)]
            public List<ListSkillsResponseBodyPagingInfoSkills> Skills { get; set; }
            public class ListSkillsResponseBodyPagingInfoSkills : TeaModel {
                /// <summary>
                /// <para><b>The creator ID.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para><b>The skill description.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>Data analytics skill</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// <para>The format is a 13-digit number, such as <c>1780555634000</c>.</para>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>1780555634000</para>
                /// </summary>
                [NameInMap("GmtCreateTime")]
                [Validation(Required=false)]
                public string GmtCreateTime { get; set; }

                /// <summary>
                /// <para><b>The ID of the last modifier.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("ModifierId")]
                [Validation(Required=false)]
                public string ModifierId { get; set; }

                /// <summary>
                /// <para><b>The skill name.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>my-skill</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para><b>The visibility level.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>TENANT</para>
                /// </summary>
                [NameInMap("Visibility")]
                [Validation(Required=false)]
                public string Visibility { get; set; }

            }

            /// <summary>
            /// <para>The total number of matching entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>824F80BA-1778-5D8A-BAFF-668A4D9C4CC7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
