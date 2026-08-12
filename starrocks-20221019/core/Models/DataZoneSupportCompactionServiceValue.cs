// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DataZoneSupportCompactionServiceValue : TeaModel {
        /// <summary>
        /// <para>The availability zone ID.</para>
        /// </summary>
        [NameInMap("zoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The resource level.</para>
        /// </summary>
        [NameInMap("resourceLevel")]
        [Validation(Required=false)]
        public string ResourceLevel { get; set; }

        /// <summary>
        /// <para>Indicates whether this is the recommended option.</para>
        /// </summary>
        [NameInMap("recommended")]
        [Validation(Required=false)]
        public bool? Recommended { get; set; }

    }

}
