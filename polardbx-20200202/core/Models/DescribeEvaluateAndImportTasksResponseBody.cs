// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeEvaluateAndImportTasksResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeEvaluateAndImportTasksResponseBodyData> Data { get; set; }
        public class DescribeEvaluateAndImportTasksResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>26842</para>
            /// </summary>
            [NameInMap("Bid")]
            [Validation(Required=false)]
            public string Bid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>346650</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fase</para>
            /// </summary>
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-01-08T15:00Z</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public long? GmtCreated { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-04-02T02:10:59Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ap-northeast-1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e3plus_*****_prod</para>
            /// </summary>
            [NameInMap("SlinkDstDb")]
            [Validation(Required=false)]
            public string SlinkDstDb { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pxc-hzrehc****5zye</para>
            /// </summary>
            [NameInMap("SlinkDstResId")]
            [Validation(Required=false)]
            public string SlinkDstResId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dts_temp_2_23</para>
            /// </summary>
            [NameInMap("SlinkDstUserName")]
            [Validation(Required=false)]
            public string SlinkDstUserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>stock</para>
            /// </summary>
            [NameInMap("SlinkSrcDb")]
            [Validation(Required=false)]
            public string SlinkSrcDb { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>drdshbga*****w4p</para>
            /// </summary>
            [NameInMap("SlinkSrcResId")]
            [Validation(Required=false)]
            public string SlinkSrcResId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RDS_MYSQL</para>
            /// </summary>
            [NameInMap("SlinkSrcResType")]
            [Validation(Required=false)]
            public string SlinkSrcResType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dtdba</para>
            /// </summary>
            [NameInMap("SlinkSrcUserName")]
            [Validation(Required=false)]
            public string SlinkSrcUserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DATA_IMPORT_RUNNING</para>
            /// </summary>
            [NameInMap("SlinkStage")]
            [Validation(Required=false)]
            public string SlinkStage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>IMPORT_NOT_BEGIN</para>
            /// </summary>
            [NameInMap("SlinkStatus")]
            [Validation(Required=false)]
            public string SlinkStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("SlinkTaskDesc")]
            [Validation(Required=false)]
            public string SlinkTaskDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>etx-szr2rr6i*****</para>
            /// </summary>
            [NameInMap("SlinkTaskId")]
            [Validation(Required=false)]
            public string SlinkTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>evaluate_import</para>
            /// </summary>
            [NameInMap("SlinkType")]
            [Validation(Required=false)]
            public string SlinkType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>81519FDE-713B-****-B6F1-231479A4C9DB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalNumber")]
        [Validation(Required=false)]
        public long? TotalNumber { get; set; }

    }

}
