// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class DeleteClientRuleStrategyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of IDs of the policies to delete. Use the policy IDs returned by the create operation or obtained from the policy list or details operations.</para>
        /// </summary>
        [NameInMap("IdList")]
        [Validation(Required=false)]
        public string IdListShrink { get; set; }

    }

}
