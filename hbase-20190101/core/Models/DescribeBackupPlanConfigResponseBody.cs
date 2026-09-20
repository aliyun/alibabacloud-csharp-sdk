// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeBackupPlanConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The full backup cycle.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("FullBackupCycle")]
        [Validation(Required=false)]
        public int? FullBackupCycle { get; set; }

        /// <summary>
        /// <para>The number of full backups to retain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MinHFileBackupCount")]
        [Validation(Required=false)]
        public int? MinHFileBackupCount { get; set; }

        /// <summary>
        /// <para>The date of the next full backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-09T18:00:00Z</para>
        /// </summary>
        [NameInMap("NextFullBackupDate")]
        [Validation(Required=false)]
        public string NextFullBackupDate { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33A23201-6038-4A6A-B76A-61047EA04E6A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tables")]
        [Validation(Required=false)]
        public DescribeBackupPlanConfigResponseBodyTables Tables { get; set; }
        public class DescribeBackupPlanConfigResponseBodyTables : TeaModel {
            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<string> Table { get; set; }

        }

    }

}
