// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteAntiBruteForceRuleRequest : TeaModel {
        /// <summary>
        /// An array that consists of the IDs of the defense rules against brute-force attacks to delete.
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public List<long?> Ids { get; set; }

    }

}
