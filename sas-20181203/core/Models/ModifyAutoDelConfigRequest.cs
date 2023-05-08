// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyAutoDelConfigRequest : TeaModel {
        /// <summary>
        /// The number of days after which a detected vulnerability is automatically deleted. Unit: days. Valid values:
        /// 
        /// *   7
        /// *   30
        /// *   90
        /// </summary>
        [NameInMap("Days")]
        [Validation(Required=false)]
        public int? Days { get; set; }

    }

}
