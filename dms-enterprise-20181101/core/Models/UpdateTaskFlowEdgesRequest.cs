// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateTaskFlowEdgesRequest : TeaModel {
        /// <summary>
        /// <para>The task flow ID. You can call the <a href="https://help.aliyun.com/document_detail/424565.html">ListTaskFlow</a> or <a href="https://help.aliyun.com/document_detail/426672.html">ListLhTaskFlowAndScenario</a> operation to query the task flow ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15***</para>
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// <para>The list of updated task flow edges.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Edges")]
        [Validation(Required=false)]
        public List<UpdateTaskFlowEdgesRequestEdges> Edges { get; set; }
        public class UpdateTaskFlowEdgesRequestEdges : TeaModel {
            /// <summary>
            /// <para>The ID of the task flow edge.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24***</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The ID of the end node of the edge.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>44***</para>
            /// </summary>
            [NameInMap("NodeEnd")]
            [Validation(Required=false)]
            public long? NodeEnd { get; set; }

            /// <summary>
            /// <para>The ID of the start node of the edge.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>44***</para>
            /// </summary>
            [NameInMap("NodeFrom")]
            [Validation(Required=false)]
            public long? NodeFrom { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <remarks>
        /// <para>To view the tenant ID, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see <a href="https://help.aliyun.com/document_detail/181330.html">Manage DMS tenants</a>.</para>
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
