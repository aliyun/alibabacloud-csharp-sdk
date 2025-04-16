// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class PAL7ConfigRewriteOp : TeaModel {
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("OldValue")]
        [Validation(Required=false)]
        public string OldValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>add,set,delete,replace</para>
        /// </summary>
        [NameInMap("Op")]
        [Validation(Required=false)]
        public string Op { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        [NameInMap("ValueVariable")]
        [Validation(Required=false)]
        public string ValueVariable { get; set; }

    }

}
