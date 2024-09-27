// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListAccountFactoryBaselineItemsResponseBody : TeaModel {
        [NameInMap("BaselineItems")]
        [Validation(Required=false)]
        public List<ListAccountFactoryBaselineItemsResponseBodyBaselineItems> BaselineItems { get; set; }
        public class ListAccountFactoryBaselineItemsResponseBodyBaselineItems : TeaModel {
            [NameInMap("DependsOn")]
            [Validation(Required=false)]
            public List<ListAccountFactoryBaselineItemsResponseBodyBaselineItemsDependsOn> DependsOn { get; set; }
            public class ListAccountFactoryBaselineItemsResponseBodyBaselineItemsDependsOn : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ACS-BP_ACCOUNT_FACTORY_VPC</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AccountFactory</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Notification.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ACS-BP_ACCOUNT_FACTORY_ACCOUNT_NOTIFICATION</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AccountFactory</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAACDGQdAEX3m42z3sQ+f3VTK2Xr2DzYbz/SAfc/zJRqod</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B40D73D8-76AC-5D3C-AC63-4FC8AFCE6671</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
