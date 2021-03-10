// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListDeviceDistributeJobResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListDeviceDistributeJobResponseData Data { get; set; }
        public class ListDeviceDistributeJobResponseData : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }
            [NameInMap("JobInfo")]
            [Validation(Required=true)]
            public ListDeviceDistributeJobResponseDataJobInfo JobInfo { get; set; }
            public class ListDeviceDistributeJobResponseDataJobInfo : TeaModel {
                [NameInMap("items")]
                [Validation(Required=true)]
                public List<ListDeviceDistributeJobResponseDataJobInfoItems> Items { get; set; }
                public class ListDeviceDistributeJobResponseDataJobInfoItems : TeaModel {
                    [NameInMap("GmtCreate")]
                    [Validation(Required=true)]
                    public long? GmtCreate { get; set; }

                    [NameInMap("SourceUid")]
                    [Validation(Required=true)]
                    public string SourceUid { get; set; }

                    [NameInMap("TargetUid")]
                    [Validation(Required=true)]
                    public string TargetUid { get; set; }

                    [NameInMap("JobId")]
                    [Validation(Required=true)]
                    public string JobId { get; set; }

                    [NameInMap("SourceInstanceId")]
                    [Validation(Required=true)]
                    public string SourceInstanceId { get; set; }

                    [NameInMap("ProductKey")]
                    [Validation(Required=true)]
                    public string ProductKey { get; set; }

                    [NameInMap("Total")]
                    [Validation(Required=true)]
                    public int? Total { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=true)]
                    public int? Status { get; set; }

                    [NameInMap("Strategy")]
                    [Validation(Required=true)]
                    public int? Strategy { get; set; }

                    [NameInMap("TargetInstanceConfigs")]
                    [Validation(Required=true)]
                    public ListDeviceDistributeJobResponseDataJobInfoItemsTargetInstanceConfigs TargetInstanceConfigs { get; set; }
                    public class ListDeviceDistributeJobResponseDataJobInfoItemsTargetInstanceConfigs : TeaModel {
                        [NameInMap("targetInstanceConfigs")]
                        [Validation(Required=true)]
                        public List<ListDeviceDistributeJobResponseDataJobInfoItemsTargetInstanceConfigsTargetInstanceConfigs> TargetInstanceConfigs { get; set; }
                        public class ListDeviceDistributeJobResponseDataJobInfoItemsTargetInstanceConfigsTargetInstanceConfigs : TeaModel {
                            public string TargetInstanceId { get; set; }
                        }
                    };

                }

            }
        };

    }

}
