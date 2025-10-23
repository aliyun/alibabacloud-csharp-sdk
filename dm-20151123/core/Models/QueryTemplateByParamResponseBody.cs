// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class QueryTemplateByParamResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10Axxxxxxxxxxxx37</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryTemplateByParamResponseBodyData Data { get; set; }
        public class QueryTemplateByParamResponseBodyData : TeaModel {
            [NameInMap("template")]
            [Validation(Required=false)]
            public List<QueryTemplateByParamResponseBodyDataTemplate> Template { get; set; }
            public class QueryTemplateByParamResponseBodyDataTemplate : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-09-29T13:28Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("SmsStatus")]
                [Validation(Required=false)]
                public int? SmsStatus { get; set; }

                [NameInMap("SmsTemplateCode")]
                [Validation(Required=false)]
                public int? SmsTemplateCode { get; set; }

                [NameInMap("Smsrejectinfo")]
                [Validation(Required=false)]
                public int? Smsrejectinfo { get; set; }

                [NameInMap("TemplateComment")]
                [Validation(Required=false)]
                public string TemplateComment { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3xxxx8</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TemplateStatus")]
                [Validation(Required=false)]
                public string TemplateStatus { get; set; }

                [NameInMap("TemplateType")]
                [Validation(Required=false)]
                public int? TemplateType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1661830382</para>
                /// </summary>
                [NameInMap("UtcCreatetime")]
                [Validation(Required=false)]
                public long? UtcCreatetime { get; set; }

            }

        }

    }

}
