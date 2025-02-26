// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DeleteKeyPairsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the ADB key pairs.</para>
        /// </summary>
        [NameInMap("KeyPairIds")]
        [Validation(Required=false)]
        public List<string> KeyPairIds { get; set; }

    }

}
