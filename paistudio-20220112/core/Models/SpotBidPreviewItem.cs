// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class SpotBidPreviewItem : TeaModel {
        /// <summary>
        /// <para>Indicates whether the spot bid is active. If set to <c>false</c>, the bid is paused.</para>
        /// </summary>
        [NameInMap("active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// <para>Determines whether instances can be deployed across different High-Performance Network (HPN) zones. Defaults to <c>false</c>.</para>
        /// </summary>
        [NameInMap("allowCrossHpnZone")]
        [Validation(Required=false)]
        public bool? AllowCrossHpnZone { get; set; }

        /// <summary>
        /// <para>The ID of the cluster where resources are provisioned.</para>
        /// </summary>
        [NameInMap("clusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The GC level for the spot instance.</para>
        /// </summary>
        [NameInMap("gcLevel")]
        [Validation(Required=false)]
        public string GcLevel { get; set; }

        /// <summary>
        /// <para>The type of compute instance.</para>
        /// </summary>
        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The name of the associated job.</para>
        /// </summary>
        [NameInMap("jobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The maximum discount percentage from the on-demand price.</para>
        /// </summary>
        [NameInMap("maxDiscount")]
        [Validation(Required=false)]
        public double? MaxDiscount { get; set; }

        /// <summary>
        /// <para>A message that provides additional details about the current phase.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The name of the spot bid preview.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The current phase of the spot bid preview. Valid values are <c>Pending</c>, <c>Active</c>, and <c>Failed</c>.</para>
        /// </summary>
        [NameInMap("phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>The number of instance replicas.</para>
        /// </summary>
        [NameInMap("replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

    }

}
