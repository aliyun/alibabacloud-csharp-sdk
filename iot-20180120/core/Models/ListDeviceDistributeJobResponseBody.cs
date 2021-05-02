// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListDeviceDistributeJobResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDeviceDistributeJobResponseBodyData Data { get; set; }
        public class ListDeviceDistributeJobResponseBodyData : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
            [NameInMap("JobInfo")]
            [Validation(Required=false)]
            public ListDeviceDistributeJobResponseBodyDataJobInfo JobInfo { get; set; }
            public class ListDeviceDistributeJobResponseBodyDataJobInfo : TeaModel {
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<ListDeviceDistributeJobResponseBodyDataJobInfoItems> Items { get; set; }
                public class ListDeviceDistributeJobResponseBodyDataJobInfoItems : TeaModel {
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public long? GmtCreate { get; set; }

                    [NameInMap("SourceUid")]
                    [Validation(Required=false)]
                    public string SourceUid { get; set; }

                    [NameInMap("TargetUid")]
                    [Validation(Required=false)]
                    public string TargetUid { get; set; }

                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    [NameInMap("SourceInstanceId")]
                    [Validation(Required=false)]
                    public string SourceInstanceId { get; set; }

                    [NameInMap("ProductKey")]
                    [Validation(Required=false)]
                    public string ProductKey { get; set; }

                    [NameInMap("Total")]
                    [Validation(Required=false)]
                    public int? Total { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("Strategy")]
                    [Validation(Required=false)]
                    public int? Strategy { get; set; }

                    [NameInMap("SourceRegion")]
                    [Validation(Required=false)]
                    public string SourceRegion { get; set; }

                    [NameInMap("SourceInstanceName")]
                    [Validation(Required=false)]
                    public string SourceInstanceName { get; set; }

                    [NameInMap("TargetInstanceConfigs")]
                    [Validation(Required=false)]
                    public ListDeviceDistributeJobResponseBodyDataJobInfoItemsTargetInstanceConfigs TargetInstanceConfigs { get; set; }
                    public class ListDeviceDistributeJobResponseBodyDataJobInfoItemsTargetInstanceConfigs : TeaModel {
                        [NameInMap("targetInstanceConfigs")]
                        [Validation(Required=false)]
                        public List<ListDeviceDistributeJobResponseBodyDataJobInfoItemsTargetInstanceConfigsTargetInstanceConfigs> TargetInstanceConfigs { get; set; }
                        public class ListDeviceDistributeJobResponseBodyDataJobInfoItemsTargetInstanceConfigsTargetInstanceConfigs : TeaModel {
                            public string TargetInstanceId { get; set; }
                            public string TargetRegion { get; set; }
                            public string TargetInstanceName { get; set; }
                        }
                    };

                }

            }
        };

    }

}
