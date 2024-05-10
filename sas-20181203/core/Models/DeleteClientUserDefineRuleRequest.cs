// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteClientUserDefineRuleRequest : TeaModel {
        /// <summary>
        /// The IDs of the custom defense rules.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IdList")]
        [Validation(Required=false)]
        public List<long?> IdList { get; set; }

    }

}
