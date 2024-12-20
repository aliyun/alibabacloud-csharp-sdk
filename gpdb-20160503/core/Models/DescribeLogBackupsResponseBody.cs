// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeLogBackupsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the backup sets.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeLogBackupsResponseBodyItems> Items { get; set; }
        public class DescribeLogBackupsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The ID of the backup set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12413721782</para>
            /// </summary>
            [NameInMap("BackupId")]
            [Validation(Required=false)]
            public string BackupId { get; set; }

            /// <summary>
            /// <para>The ID of the coordinator node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gp-bp12ga6v69h86****-master</para>
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the log backup set that is stored in Object Storage Service (OSS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>000000010000000400000012</para>
            /// </summary>
            [NameInMap("LogFileName")]
            [Validation(Required=false)]
            public string LogFileName { get; set; }

            /// <summary>
            /// <para>The size of the log backup set. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>77350</para>
            /// </summary>
            [NameInMap("LogFileSize")]
            [Validation(Required=false)]
            public long? LogFileSize { get; set; }

            /// <summary>
            /// <para>The timestamp of the log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-12T02:14:26Z</para>
            /// </summary>
            [NameInMap("LogTime")]
            [Validation(Required=false)]
            public string LogTime { get; set; }

            /// <summary>
            /// <para>The name of the compute node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>segment-0</para>
            /// </summary>
            [NameInMap("SegmentName")]
            [Validation(Required=false)]
            public string SegmentName { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of backup sets on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24B9FCAF-2CBC-51C3-B563-F1C70D750187</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total size of logs in the time range. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>386748</para>
        /// </summary>
        [NameInMap("TotalLogSize")]
        [Validation(Required=false)]
        public long? TotalLogSize { get; set; }

    }

}
