// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDataImportTaskInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. This parameter is empty when the request succeeds. When the request fails, an exception message such as an error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The returned result set.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDataImportTaskInfoResponseBodyData Data { get; set; }
        public class DescribeDataImportTaskInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The task details.</para>
            /// </summary>
            [NameInMap("DataImportTaskDetailInfo")]
            [Validation(Required=false)]
            public DescribeDataImportTaskInfoResponseBodyDataDataImportTaskDetailInfo DataImportTaskDetailInfo { get; set; }
            public class DescribeDataImportTaskInfoResponseBodyDataDataImportTaskDetailInfo : TeaModel {
                /// <summary>
                /// <para>The progress ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FsmId")]
                [Validation(Required=false)]
                public long? FsmId { get; set; }

                /// <summary>
                /// <para>The state identifier in a data migration or synchronization task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RECON_FINISHED_CATCH_UP</para>
                /// </summary>
                [NameInMap("FsmState")]
                [Validation(Required=false)]
                public string FsmState { get; set; }

                /// <summary>
                /// <para>The status in a data migration, import, or synchronization system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IMPORT_NOT_BEGIN</para>
                /// </summary>
                [NameInMap("FsmStatus")]
                [Validation(Required=false)]
                public string FsmStatus { get; set; }

                /// <summary>
                /// <para>The data import task details.</para>
                /// </summary>
                [NameInMap("ServiceDetailList")]
                [Validation(Required=false)]
                public List<DescribeDataImportTaskInfoResponseBodyDataDataImportTaskDetailInfoServiceDetailList> ServiceDetailList { get; set; }
                public class DescribeDataImportTaskInfoResponseBodyDataDataImportTaskDetailInfoServiceDetailList : TeaModel {
                    /// <summary>
                    /// <para>The service detail ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1991609</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The task execution status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FINISHED</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The task details.</para>
                    /// </summary>
                    [NameInMap("TaskDetailList")]
                    [Validation(Required=false)]
                    public List<DescribeDataImportTaskInfoResponseBodyDataDataImportTaskDetailInfoServiceDetailListTaskDetailList> TaskDetailList { get; set; }
                    public class DescribeDataImportTaskInfoResponseBodyDataDataImportTaskDetailInfoServiceDetailListTaskDetailList : TeaModel {
                        /// <summary>
                        /// <para>The delay time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>58329</para>
                        /// </summary>
                        [NameInMap("Delay")]
                        [Validation(Required=false)]
                        public long? Delay { get; set; }

                        /// <summary>
                        /// <para>The most recent error message.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("LastError")]
                        [Validation(Required=false)]
                        public string LastError { get; set; }

                        /// <summary>
                        /// <para>The physical database name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>drds_test</para>
                        /// </summary>
                        [NameInMap("PhysicalDbName")]
                        [Validation(Required=false)]
                        public string PhysicalDbName { get; set; }

                        /// <summary>
                        /// <para>The data import progress.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Progress")]
                        [Validation(Required=false)]
                        public long? Progress { get; set; }

                        /// <summary>
                        /// <para>The performance and runtime metrics collected during the execution of the data migration or import task.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{
                        ///   &quot;applyCount&quot;: 0,
                        ///   &quot;cpuUseRatio&quot;: 41,
                        ///   &quot;fsmId&quot;: 1,
                        ///   &quot;fullGcCount&quot;: 
                        /// }</para>
                        /// </summary>
                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        /// <summary>
                        /// <para>The task status.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>active</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// <para>The task ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>fc3b1568-ad96-****-adca-dfe018b38077</para>
                        /// </summary>
                        [NameInMap("TaskId")]
                        [Validation(Required=false)]
                        public long? TaskId { get; set; }

                        /// <summary>
                        /// <para>The task type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FULL_COPY</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>FULL_COPY: full replication.</description></item>
                    /// <item><description>INC_COPY: incremental replication.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FULL_COPY</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The returned message. This parameter has a value only when the task status is success. Otherwise, an empty value is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B2F3840-5C98-****-B269-2D5C3A31797C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
