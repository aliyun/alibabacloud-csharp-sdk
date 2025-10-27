// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class UpdateFlowAliasResponseBody : TeaModel {
        [NameInMap("Alias")]
        [Validation(Required=false)]
        public UpdateFlowAliasResponseBodyAlias Alias { get; set; }
        public class UpdateFlowAliasResponseBodyAlias : TeaModel {
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
            public List<UpdateFlowAliasResponseBodyAliasRoutingConfigurations> RoutingConfigurations { get; set; }
            public class UpdateFlowAliasResponseBodyAliasRoutingConfigurations : TeaModel {
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
                public int? Weight { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>294D68C1-5108-5971-853A-1A9CC87B4816</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
