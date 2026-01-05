// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class ListLaunchOptionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The launch options.</para>
        /// </summary>
        [NameInMap("LaunchOptionSummaries")]
        [Validation(Required=false)]
        public List<ListLaunchOptionsResponseBodyLaunchOptionSummaries> LaunchOptionSummaries { get; set; }
        public class ListLaunchOptionsResponseBodyLaunchOptionSummaries : TeaModel {
            /// <summary>
            /// <para>The constraints.</para>
            /// </summary>
            [NameInMap("ConstraintSummaries")]
            [Validation(Required=false)]
            public List<ListLaunchOptionsResponseBodyLaunchOptionSummariesConstraintSummaries> ConstraintSummaries { get; set; }
            public class ListLaunchOptionsResponseBodyLaunchOptionSummariesConstraintSummaries : TeaModel {
                /// <summary>
                /// <para>The type of the constraint. Valid values:</para>
                /// <ol>
                /// <item><description>Launch</description></item>
                /// <item><description>Template</description></item>
                /// <item><description>Approval</description></item>
                /// <item><description>StackRegion</description></item>
                /// </ol>
                /// 
                /// <b>Example:</b>
                /// <para>Launch</para>
                /// </summary>
                [NameInMap("ConstraintType")]
                [Validation(Required=false)]
                public string ConstraintType { get; set; }

                /// <summary>
                /// <para>The description of the constraint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Launch as local role TestRole</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The types of operations that require approval. If the type of the constraint is Approval, this parameter is not empty.</para>
                /// </summary>
                [NameInMap("OperationTypes")]
                [Validation(Required=false)]
                public List<string> OperationTypes { get; set; }

                /// <summary>
                /// <para>The regions in which users can launch the service. If the type of the constraint is StackRegion, this parameter is not empty.</para>
                /// </summary>
                [NameInMap("StackRegions")]
                [Validation(Required=false)]
                public List<string> StackRegions { get; set; }

            }

            /// <summary>
            /// <para>The ID of the product portfolio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>port-bp1yt7582g****</para>
            /// </summary>
            [NameInMap("PortfolioId")]
            [Validation(Required=false)]
            public string PortfolioId { get; set; }

            /// <summary>
            /// <para>The name of the product portfolio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEMO-IT services</para>
            /// </summary>
            [NameInMap("PortfolioName")]
            [Validation(Required=false)]
            public string PortfolioName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FEEF92D-4052-5202-87D0-3D8EC16F81BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
