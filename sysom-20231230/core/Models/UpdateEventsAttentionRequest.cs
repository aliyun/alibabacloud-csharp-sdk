// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class UpdateEventsAttentionRequest : TeaModel {
        [NameInMap("mode")]
        [Validation(Required=false)]
        public int? Mode { get; set; }

        [NameInMap("range")]
        [Validation(Required=false)]
        public string Range { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
