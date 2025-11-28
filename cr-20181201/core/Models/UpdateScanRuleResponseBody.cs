// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class UpdateScanRuleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>Request Id</para>
        /// 
        /// <b>Example:</b>
        /// <para>33EF1695-E2B7-5D57-B4E1-3D655FE1EBD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>crscnr-3qmkeiuggfpjkfrq</para>
        /// </summary>
        [NameInMap("ScanRuleId")]
        [Validation(Required=false)]
        public string ScanRuleId { get; set; }

    }

}
