// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetInstanceDownStreamRequest : TeaModel {
        /// <summary>
        /// <para>Number of levels to expand downstream in the DAG query. Valid values: 1 to 6.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DownStreamDepth")]
        [Validation(Required=false)]
        public int? DownStreamDepth { get; set; }

        /// <summary>
        /// <para>Environment identifier.</para>
        /// <list type="bullet">
        /// <item><description>DEV: Development environment.</description></item>
        /// <item><description>PROD (default): Production environment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <para>The request body.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceGet")]
        [Validation(Required=false)]
        public GetInstanceDownStreamRequestInstanceGet InstanceGet { get; set; }
        public class GetInstanceDownStreamRequestInstanceGet : TeaModel {
            /// <summary>
            /// <para>Instance ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t_5929472_20210411_9577721</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Node type of the instance.</para>
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
        /// <para>Tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>Run status of the instance.</para>
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
