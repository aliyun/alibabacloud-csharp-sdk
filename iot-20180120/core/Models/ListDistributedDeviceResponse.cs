// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListDistributedDeviceResponse : TeaModel {
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
        public ListDistributedDeviceResponseData Data { get; set; }
        public class ListDistributedDeviceResponseData : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }
            [NameInMap("Info")]
            [Validation(Required=true)]
            public ListDistributedDeviceResponseDataInfo Info { get; set; }
            public class ListDistributedDeviceResponseDataInfo : TeaModel {
                [NameInMap("items")]
                [Validation(Required=true)]
                public List<ListDistributedDeviceResponseDataInfoItems> Items { get; set; }
                public class ListDistributedDeviceResponseDataInfoItems : TeaModel {
                    [NameInMap("SourceUid")]
                    [Validation(Required=true)]
                    public string SourceUid { get; set; }

                    [NameInMap("TargetUid")]
                    [Validation(Required=true)]
                    public string TargetUid { get; set; }

                    [NameInMap("ProductKey")]
                    [Validation(Required=true)]
                    public string ProductKey { get; set; }

                    [NameInMap("DeviceName")]
                    [Validation(Required=true)]
                    public string DeviceName { get; set; }

                    [NameInMap("SourceInstanceId")]
                    [Validation(Required=true)]
                    public string SourceInstanceId { get; set; }

                    [NameInMap("TargetInstanceId")]
                    [Validation(Required=true)]
                    public string TargetInstanceId { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=true)]
                    public long? GmtCreate { get; set; }

                    [NameInMap("TargetAliyunId")]
                    [Validation(Required=true)]
                    public string TargetAliyunId { get; set; }

                    [NameInMap("SourceRegion")]
                    [Validation(Required=true)]
                    public string SourceRegion { get; set; }

                    [NameInMap("TargetRegion")]
                    [Validation(Required=true)]
                    public string TargetRegion { get; set; }

                    [NameInMap("SourceInstanceName")]
                    [Validation(Required=true)]
                    public string SourceInstanceName { get; set; }

                    [NameInMap("TargetInstanceName")]
                    [Validation(Required=true)]
                    public string TargetInstanceName { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=true)]
                    public long? GmtModified { get; set; }

                }

            }
        };

    }

}
