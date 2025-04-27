// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class SwitchOverMajorVersionUpgradeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pgm-m5e4gegx63fh92bn</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public byte[] RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SwitchoverTimeout")]
        [Validation(Required=false)]
        public int? SwitchoverTimeout { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>switch</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
