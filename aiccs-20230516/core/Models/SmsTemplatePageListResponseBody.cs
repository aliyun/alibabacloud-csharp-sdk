// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class SmsTemplatePageListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
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
                /// <para>短信内容</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>创建时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-09-26 11:34:59</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>模板所需参数</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public string Properties { get; set; }

                /// <summary>
                /// <para>智能短链ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>46</para>
                /// </summary>
                [NameInMap("ShortUrlTaskId")]
                [Validation(Required=false)]
                public long? ShortUrlTaskId { get; set; }

                /// <summary>
                /// <para>短信签名</para>
                /// 
                /// <b>Example:</b>
                /// <para>a234n</para>
                /// </summary>
                [NameInMap("Sign")]
                [Validation(Required=false)]
                public string Sign { get; set; }

                /// <summary>
                /// <para>短信类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("SmsType")]
                [Validation(Required=false)]
                public string SmsType { get; set; }

                /// <summary>
                /// <para>模板状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// <para>模板ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>67</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

                /// <summary>
                /// <para>模板名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// <para>模板类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>56</para>
                /// </summary>
                [NameInMap("TemplateType")]
                [Validation(Required=false)]
                public long? TemplateType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>53</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>42</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>31</para>
            /// </summary>
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }

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
        /// <para>true</para>
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
