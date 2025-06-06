// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ToolsetStatus : TeaModel {
        [NameInMap("observedGeneration")]
        [Validation(Required=false)]
        public long? ObservedGeneration { get; set; }

        [NameInMap("observedTime")]
        [Validation(Required=false)]
        public string ObservedTime { get; set; }

        [NameInMap("outputs")]
        [Validation(Required=false)]
        public Dictionary<string, object> Outputs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Installed</para>
        /// </summary>
        [NameInMap("phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

    }

}
