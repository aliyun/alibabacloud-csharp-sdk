// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class StartPipelineIntegratedTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Context")]
        [Validation(Required=false)]
        public StartPipelineIntegratedTaskRequestContext Context { get; set; }
        public class StartPipelineIntegratedTaskRequestContext : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30110121</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StartCommand")]
        [Validation(Required=false)]
        public StartPipelineIntegratedTaskRequestStartCommand StartCommand { get; set; }
        public class StartPipelineIntegratedTaskRequestStartCommand : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ByteSpeed")]
            [Validation(Required=false)]
            public int? ByteSpeed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-09-22 15:28:31</para>
            /// </summary>
            [NameInMap("Checkpoint")]
            [Validation(Required=false)]
            public string Checkpoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Concurrent")]
            [Validation(Required=false)]
            public int? Concurrent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RELAY</para>
            /// </summary>
            [NameInMap("FullTaskMode")]
            [Validation(Required=false)]
            public string FullTaskMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>t_1234567890_123123</para>
            /// </summary>
            [NameInMap("IncrementalTaskId")]
            [Validation(Required=false)]
            public string IncrementalTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>n_1234567890</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("QuotaGroupId")]
            [Validation(Required=false)]
            public string QuotaGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DI_DF</para>
            /// </summary>
            [NameInMap("SyncMode")]
            [Validation(Required=false)]
            public string SyncMode { get; set; }

        }

    }

}
