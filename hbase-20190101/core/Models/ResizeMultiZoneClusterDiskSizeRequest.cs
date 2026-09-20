// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class ResizeMultiZoneClusterDiskSizeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the multi-zone instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-f5d6vc2r8d6****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The disk size of core nodes. The value must be greater than the current disk size and must be a multiple of 40. Unit: GB. Maximum value: 64000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>480</para>
        /// </summary>
        [NameInMap("CoreDiskSize")]
        [Validation(Required=false)]
        public int? CoreDiskSize { get; set; }

        /// <summary>
        /// <para>The disk size of log nodes. The value must be greater than the current disk size of log nodes and must be a multiple of 40. Unit: GB. Maximum value: 8000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>440</para>
        /// </summary>
        [NameInMap("LogDiskSize")]
        [Validation(Required=false)]
        public int? LogDiskSize { get; set; }

    }

}
