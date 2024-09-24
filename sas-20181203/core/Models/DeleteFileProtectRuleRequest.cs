// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteFileProtectRuleRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the core file monitoring rules that you want to delete.</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public List<long?> Id { get; set; }

    }

}
