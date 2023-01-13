// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySpeechPushJobResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QuerySpeechPushJobResponseData Data { get; set; }
        public class QuerySpeechPushJobResponseData : TeaModel {
            [NameInMap("PageId")]
            [Validation(Required=true)]
            public int? PageId { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }

            [NameInMap("List")]
            [Validation(Required=true)]
            public QuerySpeechPushJobResponseDataList List { get; set; }
            public class QuerySpeechPushJobResponseDataList : TeaModel {
                [NameInMap("Items")]
                [Validation(Required=true)]
                public List<QuerySpeechPushJobResponseDataListItems> Items { get; set; }
                public class QuerySpeechPushJobResponseDataListItems : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=true)]
                    public string Code { get; set; }

                    [NameInMap("CreatedTime")]
                    [Validation(Required=true)]
                    public long? CreatedTime { get; set; }

                    [NameInMap("DeviceName")]
                    [Validation(Required=true)]
                    public string DeviceName { get; set; }

                    [NameInMap("ExpiredTime")]
                    [Validation(Required=true)]
                    public long? ExpiredTime { get; set; }

                    [NameInMap("FailDeviceNum")]
                    [Validation(Required=true)]
                    public int? FailDeviceNum { get; set; }

                    [NameInMap("GroupId")]
                    [Validation(Required=true)]
                    public string GroupId { get; set; }

                    [NameInMap("GroupName")]
                    [Validation(Required=true)]
                    public string GroupName { get; set; }

                    [NameInMap("IotId")]
                    [Validation(Required=true)]
                    public string IotId { get; set; }

                    [NameInMap("ProductKey")]
                    [Validation(Required=true)]
                    public string ProductKey { get; set; }

                    [NameInMap("PushMode")]
                    [Validation(Required=true)]
                    public string PushMode { get; set; }

                    [NameInMap("RunningDeviceNum")]
                    [Validation(Required=true)]
                    public int? RunningDeviceNum { get; set; }

                    [NameInMap("SpeechNum")]
                    [Validation(Required=true)]
                    public int? SpeechNum { get; set; }

                    [NameInMap("SpeechStatus")]
                    [Validation(Required=true)]
                    public bool? SpeechStatus { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=true)]
                    public string Status { get; set; }

                    [NameInMap("SuccessDeviceNum")]
                    [Validation(Required=true)]
                    public int? SuccessDeviceNum { get; set; }

                    [NameInMap("TotalDeviceNum")]
                    [Validation(Required=true)]
                    public int? TotalDeviceNum { get; set; }

                }

            }

        }

    }

}
