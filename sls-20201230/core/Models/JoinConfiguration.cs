// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class JoinConfiguration : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>$0.id == $1.id</para>
        /// </summary>
        [NameInMap("condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>left_join</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
