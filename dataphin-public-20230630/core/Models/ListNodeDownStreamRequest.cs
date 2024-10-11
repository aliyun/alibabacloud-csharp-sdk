// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListNodeDownStreamRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListNodeDownStreamRequestListQuery ListQuery { get; set; }
        public class ListNodeDownStreamRequestListQuery : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DownStreamDepth")]
            [Validation(Required=false)]
            public int? DownStreamDepth { get; set; }

            [NameInMap("FilterList")]
            [Validation(Required=false)]
            public List<ListNodeDownStreamRequestListQueryFilterList> FilterList { get; set; }
            public class ListNodeDownStreamRequestListQueryFilterList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Exclude")]
                [Validation(Required=false)]
                public bool? Exclude { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PROJECT</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("ValueList")]
                [Validation(Required=false)]
                public List<string> ValueList { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("NodeIdList")]
            [Validation(Required=false)]
            public List<ListNodeDownStreamRequestListQueryNodeIdList> NodeIdList { get; set; }
            public class ListNodeDownStreamRequestListQueryNodeIdList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>112</para>
                /// </summary>
                [NameInMap("FieldIdList")]
                [Validation(Required=false)]
                public List<string> FieldIdList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>n_23431</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123011</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
