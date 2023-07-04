// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class SmsTemplatePageListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public SmsTemplatePageListResponseBodyModel Model { get; set; }
        public class SmsTemplatePageListResponseBodyModel : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<SmsTemplatePageListResponseBodyModelList> List { get; set; }
            public class SmsTemplatePageListResponseBodyModelList : TeaModel {
                /// <summary>
                /// 短信内容
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// 创建时间
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// 模板所需参数
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public string Properties { get; set; }

                /// <summary>
                /// 智能短链ID
                /// </summary>
                [NameInMap("ShortUrlTaskId")]
                [Validation(Required=false)]
                public long? ShortUrlTaskId { get; set; }

                /// <summary>
                /// 短信签名
                /// </summary>
                [NameInMap("Sign")]
                [Validation(Required=false)]
                public string Sign { get; set; }

                /// <summary>
                /// 短信类型
                /// </summary>
                [NameInMap("SmsType")]
                [Validation(Required=false)]
                public string SmsType { get; set; }

                /// <summary>
                /// 模板状态
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// 模板ID
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

                /// <summary>
                /// 模板名称
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// 模板类型
                /// </summary>
                [NameInMap("TemplateType")]
                [Validation(Required=false)]
                public long? TemplateType { get; set; }

            }

            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
