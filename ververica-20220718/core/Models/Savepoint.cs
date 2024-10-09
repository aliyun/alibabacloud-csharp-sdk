// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Savepoint : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1659066711</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1d716b22-6aad-4be2-85c2-50cfc757****</para>
        /// </summary>
        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5af678c0-7db0-4650-94c2-d2604f0a****</para>
        /// </summary>
        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1659069473</para>
        /// </summary>
        [NameInMap("modifiedAt")]
        [Validation(Required=false)]
        public long? ModifiedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>namespacetest</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TRUE</para>
        /// </summary>
        [NameInMap("nativeFormat")]
        [Validation(Required=false)]
        public bool? NativeFormat { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>354dde66-a3ae-463e-967a-0b4107fd****</para>
        /// </summary>
        [NameInMap("savepointId")]
        [Validation(Required=false)]
        public string SavepointId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://oss/bucket/flink/flink-jobs/namespaces/vvp-team/deployments/5a19a71b-1c42-4f34-94fd-86cf60782c81/checkpoints/sp-3285">https://oss/bucket/flink/flink-jobs/namespaces/vvp-team/deployments/5a19a71b-1c42-4f34-94fd-86cf60782c81/checkpoints/sp-3285</a></para>
        /// </summary>
        [NameInMap("savepointLocation")]
        [Validation(Required=false)]
        public string SavepointLocation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>USER_REQUEST</para>
        /// </summary>
        [NameInMap("savepointOrigin")]
        [Validation(Required=false)]
        public string SavepointOrigin { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public SavepointStatus Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TRUE</para>
        /// </summary>
        [NameInMap("stopWithDrainEnabled")]
        [Validation(Required=false)]
        public bool? StopWithDrainEnabled { get; set; }

    }

}
