// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeIncrementBackupListResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Param.NotFound</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter %s value is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of incremental backup tasks.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeIncrementBackupListResponseBodyItems Items { get; set; }
        public class DescribeIncrementBackupListResponseBodyItems : TeaModel {
            [NameInMap("IncrementBackupFile")]
            [Validation(Required=false)]
            public List<DescribeIncrementBackupListResponseBodyItemsIncrementBackupFile> IncrementBackupFile { get; set; }
            public class DescribeIncrementBackupListResponseBodyItemsIncrementBackupFile : TeaModel {
                /// <summary>
                /// <para>The point in time when the backup set expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1711506719000</para>
                /// </summary>
                [NameInMap("BackupSetExpiredTime")]
                [Validation(Required=false)]
                public long? BackupSetExpiredTime { get; set; }

                /// <summary>
                /// <para>The ID of the backup set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql-bin.00****</para>
                /// </summary>
                [NameInMap("BackupSetId")]
                [Validation(Required=false)]
                public string BackupSetId { get; set; }

                /// <summary>
                /// <para>The ID of the incremental backup task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1hv5g9wk4****</para>
                /// </summary>
                [NameInMap("BackupSetJobId")]
                [Validation(Required=false)]
                public string BackupSetJobId { get; set; }

                /// <summary>
                /// <para>The size of the backup set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18535</para>
                /// </summary>
                [NameInMap("BackupSize")]
                [Validation(Required=false)]
                public long? BackupSize { get; set; }

                /// <summary>
                /// <para>The status of the incremental backup task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>INIT</b>: The incremental backup task is not started.</description></item>
                /// <item><description><b>FILLING</b>: The incremental backup task is in progress.</description></item>
                /// <item><description><b>COMPLETED</b>: The incremental backup task is complete.</description></item>
                /// <item><description><b>UNCOMPLETED</b>: The incremental backup task is not complete.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FILLING</para>
                /// </summary>
                [NameInMap("BackupStatus")]
                [Validation(Required=false)]
                public string BackupStatus { get; set; }

                /// <summary>
                /// <para>The end time of the incremental backup task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1648434713000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The endpoint that is used to connect to the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.1XX.103.1:4XXX</para>
                /// </summary>
                [NameInMap("SourceEndpointIpPort")]
                [Validation(Required=false)]
                public string SourceEndpointIpPort { get; set; }

                /// <summary>
                /// <para>The start time of the incremental backup task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1648433764000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The storage class of the backup data. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Standard</b>: The storage class is Standard.</description></item>
                /// <item><description><b>IA</b>: The storage class is Infrequent Access (IA).</description></item>
                /// <item><description><b>Archive</b>: The storage class is Archive.</description></item>
                /// <item><description><b>UNKNOWN</b>: The storage class is unknown. This value is returned because the task is not complete.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("StorageMethod")]
                [Validation(Required=false)]
                public string StorageMethod { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
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
        /// <para>A5D52069-E8AA-5056-8C5C-654C3610****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of incremental backup tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalElements")]
        [Validation(Required=false)]
        public int? TotalElements { get; set; }

        /// <summary>
        /// <para>The total number of returned pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
