// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class ListFlowAliasesResponseBody : TeaModel {
        [NameInMap("Aliases")]
        [Validation(Required=false)]
        public List<ListFlowAliasesResponseBodyAliases> Aliases { get; set; }
        public class ListFlowAliasesResponseBodyAliases : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-10-24T14:11:26+08:00</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my alias description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my-alias-name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RoutingConfigurations")]
            [Validation(Required=false)]
            public List<ListFlowAliasesResponseBodyAliasesRoutingConfigurations> RoutingConfigurations { get; set; }
            public class ListFlowAliasesResponseBodyAliasesRoutingConfigurations : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public string Weight { get; set; }

            }

        }

        /// <summary>
        /// <para>list token</para>
        /// 
        /// <b>Example:</b>
        /// <para>testNextToken</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>3A44E113-9962-5B0B-AB92-14060EFE3164</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
