// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class DescribeFlowAliasResponseBody : TeaModel {
        [NameInMap("Alias")]
        [Validation(Required=false)]
        public DescribeFlowAliasResponseBodyAlias Alias { get; set; }
        public class DescribeFlowAliasResponseBodyAlias : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-04-22T06:09:39.907Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alias description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alias-name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RoutingConfigurations")]
            [Validation(Required=false)]
            public List<DescribeFlowAliasResponseBodyAliasRoutingConfigurations> RoutingConfigurations { get; set; }
            public class DescribeFlowAliasResponseBodyAliasRoutingConfigurations : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
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
