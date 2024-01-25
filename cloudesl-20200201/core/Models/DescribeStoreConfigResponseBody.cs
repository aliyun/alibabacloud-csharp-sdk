// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20200201.Models
{
    public class DescribeStoreConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StoreConfigInfo")]
        [Validation(Required=false)]
        public DescribeStoreConfigResponseBodyStoreConfigInfo StoreConfigInfo { get; set; }
        public class DescribeStoreConfigResponseBodyStoreConfigInfo : TeaModel {
            [NameInMap("EnableNotification")]
            [Validation(Required=false)]
            public bool? EnableNotification { get; set; }

            [NameInMap("NotificationSilentTimes")]
            [Validation(Required=false)]
            public string NotificationSilentTimes { get; set; }

            [NameInMap("NotificationWebHook")]
            [Validation(Required=false)]
            public string NotificationWebHook { get; set; }

            [NameInMap("StoreId")]
            [Validation(Required=false)]
            public string StoreId { get; set; }

            [NameInMap("SubscribeContents")]
            [Validation(Required=false)]
            public List<DescribeStoreConfigResponseBodyStoreConfigInfoSubscribeContents> SubscribeContents { get; set; }
            public class DescribeStoreConfigResponseBodyStoreConfigInfoSubscribeContents : TeaModel {
                [NameInMap("AtAll")]
                [Validation(Required=false)]
                public bool? AtAll { get; set; }

                [NameInMap("AtMobileList")]
                [Validation(Required=false)]
                public string AtMobileList { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
