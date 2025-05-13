// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class TemplateListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public List<TemplateListResponseBodyModel> Model { get; set; }
        public class TemplateListResponseBodyModel : TeaModel {
            /// <summary>
            /// <para>意向标签</para>
            /// </summary>
            [NameInMap("IntentTags")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> IntentTags { get; set; }

            /// <summary>
            /// <para>个性标签</para>
            /// </summary>
            [NameInMap("PersonalityTags")]
            [Validation(Required=false)]
            public List<string> PersonalityTags { get; set; }

            /// <summary>
            /// <para>话术所需参数</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }

            /// <summary>
            /// <para>AI话术ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>59</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// <para>话术模板名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>模板类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>55</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public long? TemplateType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8EFC6D10-307B-1ECA-A8C6-7CBDF776AAD2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1683440860035</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
