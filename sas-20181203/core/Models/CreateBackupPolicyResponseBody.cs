// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the anti-ransomware policy.</para>
        /// </summary>
        [NameInMap("BackupPolicy")]
        [Validation(Required=false)]
        public CreateBackupPolicyResponseBodyBackupPolicy BackupPolicy { get; set; }
        public class CreateBackupPolicyResponseBodyBackupPolicy : TeaModel {
            /// <summary>
            /// <para>The ID of the anti-ransomware policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1301575</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The status of the anti-ransomware policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>enabled</b></description></item>
            /// <item><description><b>disabled</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> After you create an anti-ransomware policy, the policy is enabled by default.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A20733-10A0-4AF6-BE6B-E3322413BB68</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
