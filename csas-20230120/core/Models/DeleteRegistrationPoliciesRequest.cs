// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class DeleteRegistrationPoliciesRequest : TeaModel {
        /// <summary>
        /// <para>A collection of device registration policy IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PolicyIds")]
        [Validation(Required=false)]
        public List<string> PolicyIds { get; set; }

    }

}
