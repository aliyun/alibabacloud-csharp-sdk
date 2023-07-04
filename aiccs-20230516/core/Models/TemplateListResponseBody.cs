// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class TemplateListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public List<TemplateListResponseBodyModel> Model { get; set; }
        public class TemplateListResponseBodyModel : TeaModel {
            /// <summary>
            /// 意向标签
            /// </summary>
            [NameInMap("IntentTags")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> IntentTags { get; set; }

            /// <summary>
            /// 个性标签
            /// </summary>
            [NameInMap("PersonalityTags")]
            [Validation(Required=false)]
            public List<string> PersonalityTags { get; set; }

            /// <summary>
            /// 话术所需参数
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }

            /// <summary>
            /// AI话术ID
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// 话术模板名称
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
