// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class QueryPerspectivesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of perspectives.</para>
        /// </summary>
        [NameInMap("Perspectives")]
        [Validation(Required=false)]
        public List<QueryPerspectivesResponseBodyPerspectives> Perspectives { get; set; }
        public class QueryPerspectivesResponseBodyPerspectives : TeaModel {
            /// <summary>
            /// <para>The creation time in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-12T06:30:17Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The modification time in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-29T03:38:54Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The perspective name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>移动端视角</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The perspective code (used for the Q\&amp;A API).</para>
            /// 
            /// <b>Example:</b>
            /// <para>FZJBY3raWr</para>
            /// </summary>
            [NameInMap("PerspectiveCode")]
            [Validation(Required=false)]
            public string PerspectiveCode { get; set; }

            /// <summary>
            /// <para>The perspective ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3001</para>
            /// </summary>
            [NameInMap("PerspectiveId")]
            [Validation(Required=false)]
            public string PerspectiveId { get; set; }

            /// <summary>
            /// <para>Indicates whether the perspective is custom-defined.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SelfDefine")]
            [Validation(Required=false)]
            public bool? SelfDefine { get; set; }

            /// <summary>
            /// <para>The status of the perspective. Valid values are 3 (enabled) and 1 (disabled).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F285D735-D580-18A8-B97F-B2E72B00F101</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
