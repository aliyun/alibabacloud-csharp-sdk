// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeBackupStatusResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>opened</para>
        /// </summary>
        [NameInMap("BackupStatus")]
        [Validation(Required=false)]
        public string BackupStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bds-m5e54q06ceyhxxxx</para>
        /// </summary>
        [NameInMap("BdsClusterId")]
        [Validation(Required=false)]
        public string BdsClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ld-m5eznlga4k5bcxxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F7E71430-A825-470A-B40B-DF3F3AAC9BEE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
