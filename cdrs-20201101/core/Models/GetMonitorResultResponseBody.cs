// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class GetMonitorResultResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMonitorResultResponseBodyData Data { get; set; }
        public class GetMonitorResultResponseBodyData : TeaModel {
            [NameInMap("MaxId")]
            [Validation(Required=false)]
            public string MaxId { get; set; }

            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<GetMonitorResultResponseBodyDataRecords> Records { get; set; }
            public class GetMonitorResultResponseBodyDataRecords : TeaModel {
                [NameInMap("ExtendInfo")]
                [Validation(Required=false)]
                public GetMonitorResultResponseBodyDataRecordsExtendInfo ExtendInfo { get; set; }
                public class GetMonitorResultResponseBodyDataRecordsExtendInfo : TeaModel {
                    [NameInMap("PlateNo")]
                    [Validation(Required=false)]
                    public string PlateNo { get; set; }

                }

                [NameInMap("GbId")]
                [Validation(Required=false)]
                public string GbId { get; set; }

                [NameInMap("LeftUpX")]
                [Validation(Required=false)]
                public string LeftUpX { get; set; }

                [NameInMap("LeftUpY")]
                [Validation(Required=false)]
                public string LeftUpY { get; set; }

                [NameInMap("MonitorPicUrl")]
                [Validation(Required=false)]
                public string MonitorPicUrl { get; set; }

                [NameInMap("PicUrl")]
                [Validation(Required=false)]
                public string PicUrl { get; set; }

                [NameInMap("RightBottomX")]
                [Validation(Required=false)]
                public string RightBottomX { get; set; }

                [NameInMap("RightBottomY")]
                [Validation(Required=false)]
                public string RightBottomY { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                [NameInMap("ShotTime")]
                [Validation(Required=false)]
                public string ShotTime { get; set; }

                [NameInMap("TargetPicUrl")]
                [Validation(Required=false)]
                public string TargetPicUrl { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
