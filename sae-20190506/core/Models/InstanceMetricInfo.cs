// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class InstanceMetricInfo : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>a03aa9f9-3d32-4655-8394-05fd10dcbd8a</para>
        /// </summary>
        [NameInMap("applicationID")]
        [Validation(Required=false)]
        public string ApplicationID { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.98</para>
        /// </summary>
        [NameInMap("cpuPercent")]
        [Validation(Required=false)]
        public float? CpuPercent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>35.0</para>
        /// </summary>
        [NameInMap("cpuQuotaPercent")]
        [Validation(Required=false)]
        public float? CpuQuotaPercent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c-6498f0fe-33bb4f9249b54789a023</para>
        /// </summary>
        [NameInMap("instanceID")]
        [Validation(Required=false)]
        public string InstanceID { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>512.0</para>
        /// </summary>
        [NameInMap("memoryLimitMB")]
        [Validation(Required=false)]
        public float? MemoryLimitMB { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8.81</para>
        /// </summary>
        [NameInMap("memoryUsageMB")]
        [Validation(Required=false)]
        public float? MemoryUsageMB { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1686568800000</para>
        /// </summary>
        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
