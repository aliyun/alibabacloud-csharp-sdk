// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class RecommendNextActionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. 200 indicates success. A failure returns a backend error code (ERR.* / InvalidParameter.*).</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The next-step recommendations.</para>
        /// </summary>
        [NameInMap("nextActions")]
        [Validation(Required=false)]
        public List<RecommendNextActionsResponseBodyNextActions> NextActions { get; set; }
        public class RecommendNextActionsResponseBodyNextActions : TeaModel {
            /// <summary>
            /// <para>The recommendation title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Continue analyzing this metric</para>
            /// </summary>
            [NameInMap("actionTitle")]
            [Validation(Required=false)]
            public string ActionTitle { get; set; }

            /// <summary>
            /// <para>The skill code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleSkillCode</para>
            /// </summary>
            [NameInMap("skillCode")]
            [Validation(Required=false)]
            public string SkillCode { get; set; }

            /// <summary>
            /// <para>The skill name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample skill</para>
            /// </summary>
            [NameInMap("skillName")]
            [Validation(Required=false)]
            public string SkillName { get; set; }

            /// <summary>
            /// <para>The recommendation type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>recommend_reply</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The meeting reservation title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample session title</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
