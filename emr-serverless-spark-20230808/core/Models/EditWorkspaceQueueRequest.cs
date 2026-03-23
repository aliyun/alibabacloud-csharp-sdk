// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class EditWorkspaceQueueRequest : TeaModel {
        [NameInMap("environments")]
        [Validation(Required=false)]
        public List<string> Environments { get; set; }

        [NameInMap("gpuSpec")]
        [Validation(Required=false)]
        public List<string> GpuSpec { get; set; }

        [NameInMap("resourceSpec")]
        [Validation(Required=false)]
        public EditWorkspaceQueueRequestResourceSpec ResourceSpec { get; set; }
        public class EditWorkspaceQueueRequestResourceSpec : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("cu")]
            [Validation(Required=false)]
            public long? Cu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("gpu")]
            [Validation(Required=false)]
            public int? Gpu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("maxCu")]
            [Validation(Required=false)]
            public long? MaxCu { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>w-975bcfda9625****</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dev_queue</para>
        /// </summary>
        [NameInMap("workspaceQueueName")]
        [Validation(Required=false)]
        public string WorkspaceQueueName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
