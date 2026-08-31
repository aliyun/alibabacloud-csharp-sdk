// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateNodeOpsOwnerRequest : TeaModel {
        /// <summary>
        /// <para>The command for updating O&amp;M owners.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public UpdateNodeOpsOwnerRequestCommand Command { get; set; }
        public class UpdateNodeOpsOwnerRequestCommand : TeaModel {
            /// <summary>
            /// <para>The list of nodes. Only offline nodes are supported.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("NodeIdList")]
            [Validation(Required=false)]
            public List<UpdateNodeOpsOwnerRequestCommandNodeIdList> NodeIdList { get; set; }
            public class UpdateNodeOpsOwnerRequestCommandNodeIdList : TeaModel {
                /// <summary>
                /// <para>The node ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_8198365584737107968</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The node source type. Only offline nodes are supported. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DATA_PROCESS: compute node.</description></item>
                /// <item><description>PIPELINE: integration node.</description></item>
                /// <item><description>BLACK_BOX: logical table.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DATA_PROCESS</para>
                /// </summary>
                [NameInMap("NodeFromType")]
                [Validation(Required=false)]
                public string NodeFromType { get; set; }

                /// <summary>
                /// <para>The node type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DATA_PROCESS: compute node.</description></item>
                /// <item><description>PIPELINE_NODE: integration node.</description></item>
                /// <item><description>BBOX_LOGIC_TABLE_NODE: logical table.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DATA_PROCESS</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

            }

            /// <summary>
            /// <para>The updated O&amp;M owners. Specify a list of user account IDs. A maximum of 50 IDs are supported.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("OpsOwnerList")]
            [Validation(Required=false)]
            public List<string> OpsOwnerList { get; set; }

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

        /// <summary>
        /// <para>The ID of the operator user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
