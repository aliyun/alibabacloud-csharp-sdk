// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class UpgradeColumnarVersionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>polarx-col-kernel-5.4.20-20250819_17555906</para>
        /// </summary>
        [NameInMap("ColumnarVersion")]
        [Validation(Required=false)]
        public string ColumnarVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pxc-xxx</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pxc-hzrh51fze****pon-cdc</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SwitchMode")]
        [Validation(Required=false)]
        public string SwitchMode { get; set; }

    }

}
