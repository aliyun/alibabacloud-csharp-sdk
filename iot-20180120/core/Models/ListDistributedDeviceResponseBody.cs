// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListDistributedDeviceResponseBody : TeaModel {
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
        public ListDistributedDeviceResponseBodyData Data { get; set; }
        public class ListDistributedDeviceResponseBodyData : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
            [NameInMap("Info")]
            [Validation(Required=false)]
            public ListDistributedDeviceResponseBodyDataInfo Info { get; set; }
            public class ListDistributedDeviceResponseBodyDataInfo : TeaModel {
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<ListDistributedDeviceResponseBodyDataInfoItems> Items { get; set; }
                public class ListDistributedDeviceResponseBodyDataInfoItems : TeaModel {
                    [NameInMap("SourceUid")]
                    [Validation(Required=false)]
                    public string SourceUid { get; set; }

                    [NameInMap("TargetUid")]
                    [Validation(Required=false)]
                    public string TargetUid { get; set; }

                    [NameInMap("ProductKey")]
                    [Validation(Required=false)]
                    public string ProductKey { get; set; }

                    [NameInMap("DeviceName")]
                    [Validation(Required=false)]
                    public string DeviceName { get; set; }

                    [NameInMap("SourceInstanceId")]
                    [Validation(Required=false)]
                    public string SourceInstanceId { get; set; }

                    [NameInMap("TargetInstanceId")]
                    [Validation(Required=false)]
                    public string TargetInstanceId { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public long? GmtCreate { get; set; }

                    [NameInMap("TargetAliyunId")]
                    [Validation(Required=false)]
                    public string TargetAliyunId { get; set; }

                    [NameInMap("SourceRegion")]
                    [Validation(Required=false)]
                    public string SourceRegion { get; set; }

                    [NameInMap("TargetRegion")]
                    [Validation(Required=false)]
                    public string TargetRegion { get; set; }

                    [NameInMap("SourceInstanceName")]
                    [Validation(Required=false)]
                    public string SourceInstanceName { get; set; }

                    [NameInMap("TargetInstanceName")]
                    [Validation(Required=false)]
                    public string TargetInstanceName { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public long? GmtModified { get; set; }

                }

            }
        };

    }

}
