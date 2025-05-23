// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeBackupEncryptedStringResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeBackupEncryptedStringResponseBodyData Data { get; set; }
        public class DescribeBackupEncryptedStringResponseBodyData : TeaModel {
            [NameInMap("BackupInfoJson")]
            [Validation(Required=false)]
            public string BackupInfoJson { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-<b><b>-</b></b>-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
