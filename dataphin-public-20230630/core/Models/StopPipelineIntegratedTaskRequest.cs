// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class StopPipelineIntegratedTaskRequest : TeaModel {
        /// <summary>
        /// <para>The request context information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Context")]
        [Validation(Required=false)]
        public StopPipelineIntegratedTaskRequestContext Context { get; set; }
        public class StopPipelineIntegratedTaskRequestContext : TeaModel {
            /// <summary>
            /// <para>The current operating environment. Valid values: DEV: development environment. PROD: production environment.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROD</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The ID of the project to which the integration pipeline task belongs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
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
        /// <para>30121101</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The stop parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StopCommand")]
        [Validation(Required=false)]
        public StopPipelineIntegratedTaskRequestStopCommand StopCommand { get; set; }
        public class StopPipelineIntegratedTaskRequestStopCommand : TeaModel {
            /// <summary>
            /// <para>The list of instance IDs of the incremental instances to stop.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("TaskIds")]
            [Validation(Required=false)]
            public List<string> TaskIds { get; set; }

        }

    }

}
