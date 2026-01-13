// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class SplitTrafficControlTargetRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>learn-pairec-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("SetPoints")]
        [Validation(Required=false)]
        public List<long?> SetPoints { get; set; }

        [NameInMap("SetValues")]
        [Validation(Required=false)]
        public List<long?> SetValues { get; set; }

        [NameInMap("TimePoints")]
        [Validation(Required=false)]
        public List<long?> TimePoints { get; set; }

    }

}
