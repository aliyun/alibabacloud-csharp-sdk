// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListNodeDownStreamRequest : TeaModel {
        /// <summary>
        /// <para>The environment identifier. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DEV: development environment. </description></item>
        /// <item><description>PROD (default): production environment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <para>The request for querying node downstream.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListNodeDownStreamRequestListQuery ListQuery { get; set; }
        public class ListNodeDownStreamRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The depth. Default value: 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DownStreamDepth")]
            [Validation(Required=false)]
            public int? DownStreamDepth { get; set; }

            /// <summary>
            /// <para>The filters. You can include or exclude results based on projects or nodes. Default value: empty.</para>
            /// </summary>
            [NameInMap("FilterList")]
            [Validation(Required=false)]
            public List<ListNodeDownStreamRequestListQueryFilterList> FilterList { get; set; }
            public class ListNodeDownStreamRequestListQueryFilterList : TeaModel {
                /// <summary>
                /// <para>Specifies whether to exclude the matched results. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Exclude")]
                [Validation(Required=false)]
                public bool? Exclude { get; set; }

                /// <summary>
                /// <para>The filter key. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PROJECT: project</description></item>
                /// <item><description>PHYSICAL_NODE_ID: physical node ID</description></item>
                /// <item><description>LOGICAL_TABLE_NODE_ID: logical table ID.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PROJECT</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The list of filter values.</para>
                /// </summary>
                [NameInMap("ValueList")]
                [Validation(Required=false)]
                public List<string> ValueList { get; set; }

            }

            /// <summary>
            /// <para>The list of nodes.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("NodeIdList")]
            [Validation(Required=false)]
            public List<ListNodeDownStreamRequestListQueryNodeIdList> NodeIdList { get; set; }
            public class ListNodeDownStreamRequestListQueryNodeIdList : TeaModel {
                /// <summary>
                /// <para>The list of field IDs. This parameter can be specified when the node ID is a logical table node ID. If this parameter is not specified, all fields in the table are used by default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>112</para>
                /// </summary>
                [NameInMap("FieldIdList")]
                [Validation(Required=false)]
                public List<string> FieldIdList { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_23431</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123011</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
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
