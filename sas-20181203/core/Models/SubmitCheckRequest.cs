// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SubmitCheckRequest : TeaModel {
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The scan range. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FULL</b>: scans all check items</description></item>
        /// <item><description><b>POLICY</b>: scans custom-configured check items</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>POLICY</para>
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public string ScanRange { get; set; }

        /// <summary>
        /// <para>The task source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>YAO_CHI</b>: Alibaba Cloud ApsaraDB console.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>YAO_CHI</para>
        /// </summary>
        [NameInMap("TaskSource")]
        [Validation(Required=false)]
        public string TaskSource { get; set; }

    }

}
