// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateTaskFlowRelationsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the task flow. You can call the <a href="https://help.aliyun.com/document_detail/424565.html">ListTaskFlow</a> or <a href="https://help.aliyun.com/document_detail/426672.html">ListLhTaskFlowAndScenario</a> operation to query the task flow ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15***</para>
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// <para>The list of task flow edges to be updated.</para>
        /// </summary>
        [NameInMap("Edges")]
        [Validation(Required=false)]
        public List<UpdateTaskFlowRelationsRequestEdges> Edges { get; set; }
        public class UpdateTaskFlowRelationsRequestEdges : TeaModel {
            /// <summary>
            /// <para>The ID of the task flow edge.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24***</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The ID of the end node on the edge.</para>
            /// 
            /// <b>Example:</b>
            /// <para>44***</para>
            /// </summary>
            [NameInMap("NodeEnd")]
            [Validation(Required=false)]
            public long? NodeEnd { get; set; }

            /// <summary>
            /// <para>The ID of the start node on the edge.</para>
            /// 
            /// <b>Example:</b>
            /// <para>44***</para>
            /// </summary>
            [NameInMap("NodeFrom")]
            [Validation(Required=false)]
            public long? NodeFrom { get; set; }

        }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para> To view the ID of the tenant, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see <a href="https://help.aliyun.com/document_detail/181330.html">View information about the current tenant</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
