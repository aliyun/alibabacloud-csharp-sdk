// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreatePolicyV2ShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the backup policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Data is backed up at 10:00:00 every day and replicated to the China (Shanghai) region for geo-redundancy.</para>
        /// </summary>
        [NameInMap("PolicyDescription")]
        [Validation(Required=false)]
        public string PolicyDescription { get; set; }

        /// <summary>
        /// <para>The name of the backup policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily Local Backup + Remote Backup</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <para>The rules in the backup policy.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string RulesShrink { get; set; }

    }

}
