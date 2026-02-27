// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class PAL7ConfigRewriteOp : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>X-Test-Param</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>old_value</para>
        /// </summary>
        [NameInMap("OldValue")]
        [Validation(Required=false)]
        public string OldValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>add</para>
        /// </summary>
        [NameInMap("Op")]
        [Validation(Required=false)]
        public string Op { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>new_value</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sase_app_name</para>
        /// </summary>
        [NameInMap("ValueVariable")]
        [Validation(Required=false)]
        public string ValueVariable { get; set; }

    }

}
