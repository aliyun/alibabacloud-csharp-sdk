// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20200618.Models
{
    public class DescribeSmsDetailResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=true)]
        public int? CurrentPage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalItem")]
        [Validation(Required=true)]
        public int? TotalItem { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=true)]
        public int? TotalPage { get; set; }

        [NameInMap("Items")]
        [Validation(Required=true)]
        public List<DescribeSmsDetailResponseItems> Items { get; set; }
        public class DescribeSmsDetailResponseItems : TeaModel {
            [NameInMap("BizId")]
            [Validation(Required=true)]
            public string BizId { get; set; }

            [NameInMap("Content")]
            [Validation(Required=true)]
            public string Content { get; set; }

            [NameInMap("ErrorCode")]
            [Validation(Required=true)]
            public string ErrorCode { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=true)]
            public string ErrorMessage { get; set; }

            [NameInMap("Mobile")]
            [Validation(Required=true)]
            public string Mobile { get; set; }

            [NameInMap("OuterOrderNo")]
            [Validation(Required=true)]
            public string OuterOrderNo { get; set; }

            [NameInMap("ReceiveDate")]
            [Validation(Required=true)]
            public string ReceiveDate { get; set; }

            [NameInMap("SendDate")]
            [Validation(Required=true)]
            public string SendDate { get; set; }

            [NameInMap("SendStatus")]
            [Validation(Required=true)]
            public string SendStatus { get; set; }

            [NameInMap("SignName")]
            [Validation(Required=true)]
            public string SignName { get; set; }

            [NameInMap("SmsSize")]
            [Validation(Required=true)]
            public int? SmsSize { get; set; }

            [NameInMap("TaskDate")]
            [Validation(Required=true)]
            public string TaskDate { get; set; }

            [NameInMap("TemplateCode")]
            [Validation(Required=true)]
            public string TemplateCode { get; set; }

        }

    }

}
