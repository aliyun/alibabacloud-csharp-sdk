// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeStructureImportTaskInfoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeStructureImportTaskInfoResponseBodyData Data { get; set; }
        public class DescribeStructureImportTaskInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>STRUCTURE_IMPORT</para>
            /// </summary>
            [NameInMap("SlinkStage")]
            [Validation(Required=false)]
            public string SlinkStage { get; set; }

            [NameInMap("StructureImportResult")]
            [Validation(Required=false)]
            public DescribeStructureImportTaskInfoResponseBodyDataStructureImportResult StructureImportResult { get; set; }
            public class DescribeStructureImportTaskInfoResponseBodyDataStructureImportResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>java.sql.SQLException: [1a7a5f22aa403000][10.239.190.4:3058][hash_realtime_new]ERR-CODE: [TDDL-5123][ERR_INSTANCE_READ_ONLY_OPTION_NOT_SUPPORT] server is running with the instance-read-only option so it cannot execute this statement</para>
                /// </summary>
                [NameInMap("ExceptionDetail")]
                [Validation(Required=false)]
                public string ExceptionDetail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hash_realtime_new.wm_in_job_et</para>
                /// </summary>
                [NameInMap("ExceptionFullTableName")]
                [Validation(Required=false)]
                public string ExceptionFullTableName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>118</para>
                /// </summary>
                [NameInMap("FinishedNum")]
                [Validation(Required=false)]
                public int? FinishedNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public int? Percentage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>finish</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TotalNum")]
                [Validation(Required=false)]
                public int? TotalNum { get; set; }

            }

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
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
