// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class BatchEditQueueSpec : TeaModel {
        /// <summary>
        /// <para>The description of the queue. If this parameter is not specified, the description is not modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Development and debugging queue</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The runtime environments. If this parameter is not specified, the runtime environments are not modified.</para>
        /// </summary>
        [NameInMap("environments")]
        [Validation(Required=false)]
        public List<string> Environments { get; set; }

        /// <summary>
        /// <para>The list of GPU instance types. If this parameter is not specified, the GPU specifications are not modified.</para>
        /// </summary>
        [NameInMap("gpuSpec")]
        [Validation(Required=false)]
        public List<string> GpuSpec { get; set; }

        /// <summary>
        /// <para>The resource specifications, which represent the absolute target value. If this parameter is not specified, only the description, environments, or GPU specifications are modified, and the quota is not recalculated.</para>
        /// </summary>
        [NameInMap("resourceSpec")]
        [Validation(Required=false)]
        public ResourceSpec ResourceSpec { get; set; }

        /// <summary>
        /// <para>The name of the queue.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dev_queue</para>
        /// </summary>
        [NameInMap("workspaceQueueName")]
        [Validation(Required=false)]
        public string WorkspaceQueueName { get; set; }

    }

}
