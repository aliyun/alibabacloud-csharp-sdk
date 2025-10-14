// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDataImportTaskInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDataImportTaskInfoResponseBodyData Data { get; set; }
        public class DescribeDataImportTaskInfoResponseBodyData : TeaModel {
            [NameInMap("DataImportTaskDetailInfo")]
            [Validation(Required=false)]
            public DescribeDataImportTaskInfoResponseBodyDataDataImportTaskDetailInfo DataImportTaskDetailInfo { get; set; }
            public class DescribeDataImportTaskInfoResponseBodyDataDataImportTaskDetailInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FsmId")]
                [Validation(Required=false)]
                public long? FsmId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RECON_FINISHED_CATCH_UP</para>
                /// </summary>
                [NameInMap("FsmState")]
                [Validation(Required=false)]
                public string FsmState { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>IMPORT_NOT_BEGIN</para>
                /// </summary>
                [NameInMap("FsmStatus")]
                [Validation(Required=false)]
                public string FsmStatus { get; set; }

                [NameInMap("ServiceDetailList")]
                [Validation(Required=false)]
                public List<DescribeDataImportTaskInfoResponseBodyDataDataImportTaskDetailInfoServiceDetailList> ServiceDetailList { get; set; }
                public class DescribeDataImportTaskInfoResponseBodyDataDataImportTaskDetailInfoServiceDetailList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1991609</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>FINISHED</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("TaskDetailList")]
                    [Validation(Required=false)]
                    public List<DescribeDataImportTaskInfoResponseBodyDataDataImportTaskDetailInfoServiceDetailListTaskDetailList> TaskDetailList { get; set; }
                    public class DescribeDataImportTaskInfoResponseBodyDataDataImportTaskDetailInfoServiceDetailListTaskDetailList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>58329</para>
                        /// </summary>
                        [NameInMap("Delay")]
                        [Validation(Required=false)]
                        public long? Delay { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("LastError")]
                        [Validation(Required=false)]
                        public string LastError { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>drds_test</para>
                        /// </summary>
                        [NameInMap("PhysicalDbName")]
                        [Validation(Required=false)]
                        public string PhysicalDbName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Progress")]
                        [Validation(Required=false)]
                        public long? Progress { get; set; }

                        /// <summary>
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
                        /// <b>Example:</b>
                        /// <para>active</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>fc3b1568-ad96-****-adca-dfe018b38077</para>
                        /// </summary>
                        [NameInMap("TaskId")]
                        [Validation(Required=false)]
                        public long? TaskId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>FULL_COPY</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
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
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9B2F3840-5C98-****-B269-2D5C3A31797C</para>
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
        public string Success { get; set; }

    }

}
