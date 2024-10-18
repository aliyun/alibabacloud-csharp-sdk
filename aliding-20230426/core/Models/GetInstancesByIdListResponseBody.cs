// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetInstancesByIdListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetInstancesByIdListResponseBodyResult> Result { get; set; }
        public class GetInstancesByIdListResponseBodyResult : TeaModel {
            [NameInMap("ActionExecutor")]
            [Validation(Required=false)]
            public List<GetInstancesByIdListResponseBodyResultActionExecutor> ActionExecutor { get; set; }
            public class GetInstancesByIdListResponseBodyResultActionExecutor : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>开发部</para>
                /// </summary>
                [NameInMap("DepartmentName")]
                [Validation(Required=false)]
                public string DepartmentName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:abc@alimail.com">abc@alimail.com</a></para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public GetInstancesByIdListResponseBodyResultActionExecutorName Name { get; set; }
                public class GetInstancesByIdListResponseBodyResultActionExecutorName : TeaModel {
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
            [NameInMap("ApprovedResult")]
            [Validation(Required=false)]
            public string ApprovedResult { get; set; }

            [NameInMap("Data")]
            [Validation(Required=false)]
            public Dictionary<string, object> Data { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FORM-EF6Y4G8WO2FN0SUB43TDQ3CGC3FMFQ1G9400RCJ3</para>
            /// </summary>
            [NameInMap("FormUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            [NameInMap("Originator")]
            [Validation(Required=false)]
            public GetInstancesByIdListResponseBodyResultOriginator Originator { get; set; }
            public class GetInstancesByIdListResponseBodyResultOriginator : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>开发部</para>
                /// </summary>
                [NameInMap("DepartmentName")]
                [Validation(Required=false)]
                public string DepartmentName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:abc@alimail.com">abc@alimail.com</a></para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public GetInstancesByIdListResponseBodyResultOriginatorName Name { get; set; }
                public class GetInstancesByIdListResponseBodyResultOriginatorName : TeaModel {
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
            [NameInMap("ProcessCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>f30233fb-72e1-4xxx</para>
            /// </summary>
            [NameInMap("ProcessInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>李四发起的请购单</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

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

    }

}
