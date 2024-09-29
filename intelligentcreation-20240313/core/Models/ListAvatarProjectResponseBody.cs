// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class ListAvatarProjectResponseBody : TeaModel {
        [NameInMap("queryAvatarProjectResultList")]
        [Validation(Required=false)]
        public List<ListAvatarProjectResponseBodyQueryAvatarProjectResultList> QueryAvatarProjectResultList { get; set; }
        public class ListAvatarProjectResponseBodyQueryAvatarProjectResultList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1000206</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            [NameInMap("errorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12826084562688</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("projectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DEPLOYING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D7F2B74F-63F2-5DD6-95E4-F408EAD6617E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
