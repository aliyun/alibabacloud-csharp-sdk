// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteUnknownThreatDetectProcessRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the processes to delete.</para>
        /// </summary>
        [NameInMap("ProcessIdList")]
        [Validation(Required=false)]
        public List<string> ProcessIdList { get; set; }

    }

}
