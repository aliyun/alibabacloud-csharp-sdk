// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListAccountFactoryBaselineItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The baseline items.</para>
        /// </summary>
        [NameInMap("BaselineItems")]
        [Validation(Required=false)]
        public List<ListAccountFactoryBaselineItemsResponseBodyBaselineItems> BaselineItems { get; set; }
        public class ListAccountFactoryBaselineItemsResponseBodyBaselineItems : TeaModel {
            /// <summary>
            /// <para>The dependency of the baseline item.</para>
            /// </summary>
            [NameInMap("DependsOn")]
            [Validation(Required=false)]
            public List<ListAccountFactoryBaselineItemsResponseBodyBaselineItemsDependsOn> DependsOn { get; set; }
            public class ListAccountFactoryBaselineItemsResponseBodyBaselineItemsDependsOn : TeaModel {
                /// <summary>
                /// <para>The name of the baseline item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS-BP_ACCOUNT_FACTORY_VPC</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the baseline item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AccountFactory</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The version of the baseline item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The description of the baseline item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Notification.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the baseline item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS-BP_ACCOUNT_FACTORY_ACCOUNT_NOTIFICATION</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the baseline item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AccountFactory</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The version of the baseline item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAACDGQdAEX3m42z3sQ+f3VTK2Xr2DzYbz/SAfc/zJRqod</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B40D73D8-76AC-5D3C-AC63-4FC8AFCE6671</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
