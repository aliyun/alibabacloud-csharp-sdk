// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20200618.Models
{
    public class DescribeSmsDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeSmsDetailResponseBodyItems> Items { get; set; }
        public class DescribeSmsDetailResponseBodyItems : TeaModel {
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("OuterOrderNo")]
            [Validation(Required=false)]
            public string OuterOrderNo { get; set; }

            [NameInMap("ReceiveDate")]
            [Validation(Required=false)]
            public string ReceiveDate { get; set; }

            [NameInMap("SendDate")]
            [Validation(Required=false)]
            public string SendDate { get; set; }

            [NameInMap("SendStatus")]
            [Validation(Required=false)]
            public string SendStatus { get; set; }

            [NameInMap("SignName")]
            [Validation(Required=false)]
            public string SignName { get; set; }

            [NameInMap("SmsSize")]
            [Validation(Required=false)]
            public int? SmsSize { get; set; }

            [NameInMap("TaskDate")]
            [Validation(Required=false)]
            public string TaskDate { get; set; }

            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
