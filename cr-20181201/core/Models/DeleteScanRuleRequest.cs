// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class DeleteScanRuleRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-kmsiwlxxdcva****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The rule ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>crscnr-aemytkwad2h7fyhb</para>
        /// </summary>
        [NameInMap("ScanRuleId")]
        [Validation(Required=false)]
        public string ScanRuleId { get; set; }

    }

}
