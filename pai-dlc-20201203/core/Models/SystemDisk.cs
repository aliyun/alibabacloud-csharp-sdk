// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class SystemDisk : TeaModel {
        /// <summary>
        /// <para>The system cloud disk type, such as cloud_essd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The performance level of the ESSD cloud disk, such as PL0 and PL1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// <para>The size of the system cloud disk, in GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

    }

}
