// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class StartPipelineIntegratedTaskRequest : TeaModel {
        /// <summary>
        /// <para>The request context.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Context")]
        [Validation(Required=false)]
        public StartPipelineIntegratedTaskRequestContext Context { get; set; }
        public class StartPipelineIntegratedTaskRequestContext : TeaModel {
            /// <summary>
            /// <para>The current operating environment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DEV: Development environment.</description></item>
            /// <item><description>PROD: Production environment.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The ID of the project to which the integration pipeline node belongs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890</para>
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

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30110121</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The startup parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StartCommand")]
        [Validation(Required=false)]
        public StartPipelineIntegratedTaskRequestStartCommand StartCommand { get; set; }
        public class StartPipelineIntegratedTaskRequestStartCommand : TeaModel {
            /// <summary>
            /// <para>The bandwidth limit for the offline full task. Unit: MB/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ByteSpeed")]
            [Validation(Required=false)]
            public int? ByteSpeed { get; set; }

            /// <summary>
            /// <para>The specified time checkpoint for starting in pure incremental mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-22 15:28:31</para>
            /// </summary>
            [NameInMap("Checkpoint")]
            [Validation(Required=false)]
            public string Checkpoint { get; set; }

            /// <summary>
            /// <para>The concurrency for the offline full task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Concurrent")]
            [Validation(Required=false)]
            public int? Concurrent { get; set; }

            /// <summary>
            /// <para>The startup mode for the full table task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INIT</description></item>
            /// <item><description>RELAY</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RELAY</para>
            /// </summary>
            [NameInMap("FullTaskMode")]
            [Validation(Required=false)]
            public string FullTaskMode { get; set; }

            /// <summary>
            /// <para>The incremental instance ID required when restarting the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t_1234567890_123123</para>
            /// </summary>
            [NameInMap("IncrementalTaskId")]
            [Validation(Required=false)]
            public string IncrementalTaskId { get; set; }

            /// <summary>
            /// <para>The memory for the offline full task. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// <para>The ID of the real-time node required when starting from a node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n_1234567890</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group used by the full table instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("QuotaGroupId")]
            [Validation(Required=false)]
            public string QuotaGroupId { get; set; }

            /// <summary>
            /// <para>The synchronization mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DI_DF</description></item>
            /// <item><description>DI</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DI_DF</para>
            /// </summary>
            [NameInMap("SyncMode")]
            [Validation(Required=false)]
            public string SyncMode { get; set; }

        }

    }

}
