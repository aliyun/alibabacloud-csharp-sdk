// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class PutConcurrencyConfigRequest : TeaModel {
        /// <summary>
        /// <para>The concurrency configurations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public PutConcurrencyInput Body { get; set; }

    }

}
