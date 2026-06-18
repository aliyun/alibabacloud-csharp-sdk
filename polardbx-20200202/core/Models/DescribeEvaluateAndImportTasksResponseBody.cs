// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeEvaluateAndImportTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The task details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeEvaluateAndImportTasksResponseBodyData> Data { get; set; }
        public class DescribeEvaluateAndImportTasksResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The business ID of the import task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26842</para>
            /// </summary>
            [NameInMap("Bid")]
            [Validation(Required=false)]
            public string Bid { get; set; }

            /// <summary>
            /// <para>The creator of the import task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>346650</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>Indicates whether the task is deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fase</para>
            /// </summary>
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            /// <summary>
            /// <para>The task creation timestamp, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-08T15:00Z</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public long? GmtCreated { get; set; }

            /// <summary>
            /// <para>The modification time of the metadata information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-02T02:10:59Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-northeast-1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the slink destination database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e3plus_*****_prod</para>
            /// </summary>
            [NameInMap("SlinkDstDb")]
            [Validation(Required=false)]
            public string SlinkDstDb { get; set; }

            /// <summary>
            /// <para>The instance ID of the destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-hzrehc****5zye</para>
            /// </summary>
            [NameInMap("SlinkDstResId")]
            [Validation(Required=false)]
            public string SlinkDstResId { get; set; }

            /// <summary>
            /// <para>The username for the data connection of the destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dts_temp_2_23</para>
            /// </summary>
            [NameInMap("SlinkDstUserName")]
            [Validation(Required=false)]
            public string SlinkDstUserName { get; set; }

            /// <summary>
            /// <para>The name of the slink source database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stock</para>
            /// </summary>
            [NameInMap("SlinkSrcDb")]
            [Validation(Required=false)]
            public string SlinkSrcDb { get; set; }

            /// <summary>
            /// <para>The instance ID of the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>drdshbga*****w4p</para>
            /// </summary>
            [NameInMap("SlinkSrcResId")]
            [Validation(Required=false)]
            public string SlinkSrcResId { get; set; }

            /// <summary>
            /// <para>The resource type of the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS_MYSQL</para>
            /// </summary>
            [NameInMap("SlinkSrcResType")]
            [Validation(Required=false)]
            public string SlinkSrcResType { get; set; }

            /// <summary>
            /// <para>The username for the data connection of the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtdba</para>
            /// </summary>
            [NameInMap("SlinkSrcUserName")]
            [Validation(Required=false)]
            public string SlinkSrcUserName { get; set; }

            /// <summary>
            /// <para>The stage of the synchronization task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DATA_IMPORT_RUNNING</para>
            /// </summary>
            [NameInMap("SlinkStage")]
            [Validation(Required=false)]
            public string SlinkStage { get; set; }

            /// <summary>
            /// <para>The running status of the synchronization task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IMPORT_NOT_BEGIN</para>
            /// </summary>
            [NameInMap("SlinkStatus")]
            [Validation(Required=false)]
            public string SlinkStatus { get; set; }

            /// <summary>
            /// <para>The description of the slink task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("SlinkTaskDesc")]
            [Validation(Required=false)]
            public string SlinkTaskDesc { get; set; }

            /// <summary>
            /// <para>The slink task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>etx-szr2rr6i*****</para>
            /// </summary>
            [NameInMap("SlinkTaskId")]
            [Validation(Required=false)]
            public string SlinkTaskId { get; set; }

            /// <summary>
            /// <para>The synchronization type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>evaluate_import</para>
            /// </summary>
            [NameInMap("SlinkType")]
            [Validation(Required=false)]
            public string SlinkType { get; set; }

        }

        /// <summary>
        /// <para>The returned message. &gt; This parameter is empty when the request succeeds. When the request fails, exception information (such as error codes) is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>81519FDE-713B-****-B6F1-231479A4C9DB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalNumber")]
        [Validation(Required=false)]
        public long? TotalNumber { get; set; }

    }

}
