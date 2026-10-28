// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class QuotaConfig : TeaModel {
        /// <summary>
        /// <para>The maximum allowed priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("AllowedMaxPriority")]
        [Validation(Required=false)]
        public int? AllowedMaxPriority { get; set; }

        /// <summary>
        /// <para>Specifies whether DLC is enabled.</para>
        /// </summary>
        [NameInMap("EnableDLC")]
        [Validation(Required=false)]
        public bool? EnableDLC { get; set; }

        /// <summary>
        /// <para>Specifies whether DSW is enabled.</para>
        /// </summary>
        [NameInMap("EnableDSW")]
        [Validation(Required=false)]
        public bool? EnableDSW { get; set; }

        /// <summary>
        /// <para>Specifies whether to use tide resources.</para>
        /// </summary>
        [NameInMap("EnableTideResource")]
        [Validation(Required=false)]
        public bool? EnableTideResource { get; set; }

        /// <summary>
        /// <para>The resource level (L0, L1).</para>
        /// 
        /// <b>Example:</b>
        /// <para>L0</para>
        /// </summary>
        [NameInMap("ResourceLevel")]
        [Validation(Required=false)]
        public string ResourceLevel { get; set; }

    }

}
