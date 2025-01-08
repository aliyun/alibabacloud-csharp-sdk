// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class SyncSensitiveWordShrinkRequest : TeaModel {
        [NameInMap("BodyData")]
        [Validation(Required=false)]
        public string BodyDataShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Commit")]
        [Validation(Required=false)]
        public bool? Commit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
