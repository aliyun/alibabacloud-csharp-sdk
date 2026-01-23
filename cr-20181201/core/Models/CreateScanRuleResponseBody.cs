// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateScanRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned HTTP or HTTPS status code.</para>
        /// 
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
        /// <para>EAEAB520-2456-5BF2-BCB5-AC998DFA3A51</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crscnr-k3gdm5vrn2nzf5hw</para>
        /// </summary>
        [NameInMap("ScanRuleId")]
        [Validation(Required=false)]
        public string ScanRuleId { get; set; }

    }

}
