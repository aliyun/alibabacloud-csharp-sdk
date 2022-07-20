// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListSystemTemplatesResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 模板信息列表
        /// </summary>
        [NameInMap("SystemTemplateList")]
        [Validation(Required=false)]
        public List<ListSystemTemplatesResponseBodySystemTemplateList> SystemTemplateList { get; set; }
        public class ListSystemTemplatesResponseBodySystemTemplateList : TeaModel {
            /// <summary>
            /// 模板状态
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 模板子类型ID
            /// </summary>
            [NameInMap("Subtype")]
            [Validation(Required=false)]
            public int? Subtype { get; set; }

            /// <summary>
            /// 模板子类型名称
            /// </summary>
            [NameInMap("SubtypeName")]
            [Validation(Required=false)]
            public string SubtypeName { get; set; }

            /// <summary>
            /// 模板参数
            /// </summary>
            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            public string TemplateConfig { get; set; }

            /// <summary>
            /// 模板Id
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// 模板名称
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// 模板类型ID
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// 模板类型名称
            /// </summary>
            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

        }

        /// <summary>
        /// 模板总数
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
