// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ListCustomAgentToolsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCustomAgentToolsResponseBodyData> Data { get; set; }
        public class ListCustomAgentToolsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The description in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Queries RDS instances.</para>
            /// </summary>
            [NameInMap("En")]
            [Validation(Required=false)]
            public string En { get; set; }

            /// <summary>
            /// <para>The description in Japanese.</para>
            /// </summary>
            [NameInMap("Ja")]
            [Validation(Required=false)]
            public string Ja { get; set; }

            /// <summary>
            /// <para>The tool name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>describe_db_instances</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The description in Traditional Chinese.</para>
            /// </summary>
            [NameInMap("Tc")]
            [Validation(Required=false)]
            public string Tc { get; set; }

            /// <summary>
            /// <para>The read/write type of the tool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>get</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The description in Simplified Chinese.</para>
            /// </summary>
            [NameInMap("Zh")]
            [Validation(Required=false)]
            public string Zh { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32DEFB4A-861F-5D1D-ADD5-918E4FD7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
