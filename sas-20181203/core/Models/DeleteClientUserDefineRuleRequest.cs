// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteClientUserDefineRuleRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the custom defense rules.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IdList")]
        [Validation(Required=false)]
        public List<long?> IdList { get; set; }

    }

}
