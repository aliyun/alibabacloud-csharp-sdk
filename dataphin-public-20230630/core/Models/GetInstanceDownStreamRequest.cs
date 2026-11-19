// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetInstanceDownStreamRequest : TeaModel {
        /// <summary>
        /// <para>The number of levels to expand the DAG downwards. Valid values: 1 to 6.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DownStreamDepth")]
        [Validation(Required=false)]
        public int? DownStreamDepth { get; set; }

        /// <summary>
        /// <para>The environment identifier. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DEV: development environment. </description></item>
        /// <item><description>PROD: production environment. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <para>The get request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceGet")]
        [Validation(Required=false)]
        public GetInstanceDownStreamRequestInstanceGet InstanceGet { get; set; }
        public class GetInstanceDownStreamRequestInstanceGet : TeaModel {
            /// <summary>
            /// <para>The instance ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t_5929472_20210411_9577721</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The node type of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BBOX_LOGIC_TABLE_NODE</description></item>
            /// <item><description>BBOX_LOGIC_FIELD_NODE</description></item>
            /// <item><description>BBOX_LOGIC_FIELD_GROUP_NODE</description></item>
            /// <item><description>BBOX_INNER_TEMP_NODE</description></item>
            /// <item><description>DATA_PROCESS</description></item>
            /// <item><description>STREAM_TASK_NODE</description></item>
            /// <item><description>FLINK_BATCH</description></item>
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
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The run status of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>INIT</description></item>
        /// <item><description>WATING</description></item>
        /// <item><description>RUNNING</description></item>
        /// <item><description>SUCCESS</description></item>
        /// <item><description>FAILED</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("RunStatus")]
        [Validation(Required=false)]
        public string RunStatus { get; set; }

    }

}
