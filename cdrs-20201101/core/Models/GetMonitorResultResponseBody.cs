// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class GetMonitorResultResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
                public string PicUrl { get; set; }
                public string RightBottomY { get; set; }
                public string Score { get; set; }
                public string MonitorPicUrl { get; set; }
                public string RightBottomX { get; set; }
                public GetMonitorResultResponseBodyDataRecordsExtendInfo ExtendInfo { get; set; }
                public class GetMonitorResultResponseBodyDataRecordsExtendInfo : TeaModel {
                    [NameInMap("PlateNo")]
                    [Validation(Required=false)]
                    public string PlateNo { get; set; }

                }
                public string GbId { get; set; }
                public string LeftUpY { get; set; }
                public string LeftUpX { get; set; }
                public string ShotTime { get; set; }
                public string TaskId { get; set; }
                public string TargetPicUrl { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
