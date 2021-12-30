// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeSlinkTaskInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSlinkTaskInfoResponseBodyData Data { get; set; }
        public class DescribeSlinkTaskInfoResponseBodyData : TeaModel {
            [NameInMap("DataImportTaskDetailInfo")]
            [Validation(Required=false)]
            public DescribeSlinkTaskInfoResponseBodyDataDataImportTaskDetailInfo DataImportTaskDetailInfo { get; set; }
            public class DescribeSlinkTaskInfoResponseBodyDataDataImportTaskDetailInfo : TeaModel {
                [NameInMap("FsmId")]
                [Validation(Required=false)]
                public long? FsmId { get; set; }

                [NameInMap("FsmState")]
                [Validation(Required=false)]
                public string FsmState { get; set; }

                [NameInMap("FsmStatus")]
                [Validation(Required=false)]
                public string FsmStatus { get; set; }

                [NameInMap("ServiceDetailList")]
                [Validation(Required=false)]
                public List<DescribeSlinkTaskInfoResponseBodyDataDataImportTaskDetailInfoServiceDetailList> ServiceDetailList { get; set; }
                public class DescribeSlinkTaskInfoResponseBodyDataDataImportTaskDetailInfoServiceDetailList : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("TaskDetailList")]
                    [Validation(Required=false)]
                    public List<DescribeSlinkTaskInfoResponseBodyDataDataImportTaskDetailInfoServiceDetailListTaskDetailList> TaskDetailList { get; set; }
                    public class DescribeSlinkTaskInfoResponseBodyDataDataImportTaskDetailInfoServiceDetailListTaskDetailList : TeaModel {
                        [NameInMap("Delay")]
                        [Validation(Required=false)]
                        public long? Delay { get; set; }

                        [NameInMap("LastError")]
                        [Validation(Required=false)]
                        public string LastError { get; set; }

                        [NameInMap("PhysicalDbName")]
                        [Validation(Required=false)]
                        public string PhysicalDbName { get; set; }

                        [NameInMap("Progress")]
                        [Validation(Required=false)]
                        public long? Progress { get; set; }

                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        [NameInMap("TaskId")]
                        [Validation(Required=false)]
                        public long? TaskId { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
