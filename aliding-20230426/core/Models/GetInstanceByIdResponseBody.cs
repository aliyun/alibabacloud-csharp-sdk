// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetInstanceByIdResponseBody : TeaModel {
        [NameInMap("actionExecutor")]
        [Validation(Required=false)]
        public List<GetInstanceByIdResponseBodyActionExecutor> ActionExecutor { get; set; }
        public class GetInstanceByIdResponseBodyActionExecutor : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>开发部</para>
            /// </summary>
            [NameInMap("DeptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:abc@alimail.com">abc@alimail.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public GetInstanceByIdResponseBodyActionExecutorName Name { get; set; }
            public class GetInstanceByIdResponseBodyActionExecutorName : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("NameInChinese")]
                [Validation(Required=false)]
                public string NameInChinese { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ZhangSan</para>
                /// </summary>
                [NameInMap("NameInEnglish")]
                [Validation(Required=false)]
                public string NameInEnglish { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>i18n</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>manager123</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>agree</para>
        /// </summary>
        [NameInMap("approvedResult")]
        [Validation(Required=false)]
        public string ApprovedResult { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-05-01</para>
        /// </summary>
        [NameInMap("createTimeGMT")]
        [Validation(Required=false)]
        public string CreateTimeGMT { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public Dictionary<string, object> Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FORM-EF6Y4xxx</para>
        /// </summary>
        [NameInMap("formUuid")]
        [Validation(Required=false)]
        public string FormUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("instanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-05-01</para>
        /// </summary>
        [NameInMap("modifiedTimeGMT")]
        [Validation(Required=false)]
        public string ModifiedTimeGMT { get; set; }

        [NameInMap("originator")]
        [Validation(Required=false)]
        public GetInstanceByIdResponseBodyOriginator Originator { get; set; }
        public class GetInstanceByIdResponseBodyOriginator : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>开发部</para>
            /// </summary>
            [NameInMap("DeptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:abc@alimail.com">abc@alimail.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public GetInstanceByIdResponseBodyOriginatorName Name { get; set; }
            public class GetInstanceByIdResponseBodyOriginatorName : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("NameInChinese")]
                [Validation(Required=false)]
                public string NameInChinese { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ZhangSan</para>
                /// </summary>
                [NameInMap("NameInEnglish")]
                [Validation(Required=false)]
                public string NameInEnglish { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>i18n</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>manager123</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TPROC--X1Gxxx</para>
        /// </summary>
        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>f30233fb-72e1-4xxx</para>
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>李四发起的请购单</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public long? Version { get; set; }

    }

}
