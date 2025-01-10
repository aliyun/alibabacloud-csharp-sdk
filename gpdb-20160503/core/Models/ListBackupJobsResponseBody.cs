// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListBackupJobsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public ListBackupJobsResponseBodyItems Items { get; set; }
        public class ListBackupJobsResponseBodyItems : TeaModel {
            [NameInMap("BackupJob")]
            [Validation(Required=false)]
            public List<ListBackupJobsResponseBodyItemsBackupJob> BackupJob { get; set; }
            public class ListBackupJobsResponseBodyItemsBackupJob : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("BackupJobId")]
                [Validation(Required=false)]
                public string BackupJobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Automated</para>
                /// </summary>
                [NameInMap("BackupMode")]
                [Validation(Required=false)]
                public string BackupMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("BackupStatus")]
                [Validation(Required=false)]
                public string BackupStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50%</para>
                /// </summary>
                [NameInMap("Process")]
                [Validation(Required=false)]
                public string Process { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-08-11T09:26:43Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
