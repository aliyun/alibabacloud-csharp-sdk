// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetBackupStorageCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the anti-ransomware capacity.</para>
        /// </summary>
        [NameInMap("BackupStorageCount")]
        [Validation(Required=false)]
        public GetBackupStorageCountResponseBodyBackupStorageCount BackupStorageCount { get; set; }
        public class GetBackupStorageCountResponseBodyBackupStorageCount : TeaModel {
            /// <summary>
            /// <para>The anti-ransomware capacity that you purchased. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2276332666880</para>
            /// </summary>
            [NameInMap("BuyStorageByte")]
            [Validation(Required=false)]
            public long? BuyStorageByte { get; set; }

            /// <summary>
            /// <para>The storage capacity that is occupied by the backup data of your servers. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>817262417803</para>
            /// </summary>
            [NameInMap("EcsUsageStorageByte")]
            [Validation(Required=false)]
            public long? EcsUsageStorageByte { get; set; }

            /// <summary>
            /// <para>Indicates whether the anti-ransomware capacity that is used exceeds the anti-ransomware capacity that you purchased. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: no</description></item>
            /// <item><description><b>1</b>: yes</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Overflow")]
            [Validation(Required=false)]
            public int? Overflow { get; set; }

            /// <summary>
            /// <para>The storage capacity that is occupied by the backup data of your databases. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7453049350</para>
            /// </summary>
            [NameInMap("UniUsageStorageByte")]
            [Validation(Required=false)]
            public long? UniUsageStorageByte { get; set; }

            /// <summary>
            /// <para>The total anti-ransomware capacity that is used. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>839621565853</para>
            /// </summary>
            [NameInMap("UsageStorageByte")]
            [Validation(Required=false)]
            public long? UsageStorageByte { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33C2CCFF-4BF8-5F88-9B5C-22F932F80E5A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
