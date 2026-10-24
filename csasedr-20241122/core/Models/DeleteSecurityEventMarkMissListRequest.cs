// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class DeleteSecurityEventMarkMissListRequest : TeaModel {
        /// <summary>
        /// <para>The list of alert whitelist rule IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public List<long?> Ids { get; set; }

    }

}
