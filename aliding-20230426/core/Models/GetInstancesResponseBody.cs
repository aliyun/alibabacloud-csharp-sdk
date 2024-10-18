// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetInstancesResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetInstancesResponseBodyData> Data { get; set; }
        public class GetInstancesResponseBodyData : TeaModel {
            [NameInMap("ActionExecutor")]
            [Validation(Required=false)]
            public List<GetInstancesResponseBodyDataActionExecutor> ActionExecutor { get; set; }
            public class GetInstancesResponseBodyDataActionExecutor : TeaModel {
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
                public GetInstancesResponseBodyDataActionExecutorName Name { get; set; }
                public class GetInstancesResponseBodyDataActionExecutorName : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-05-01</para>
            /// </summary>
            [NameInMap("CreateTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

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

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-05-01</para>
            /// </summary>
            [NameInMap("ModifiedTimeGMT")]
            [Validation(Required=false)]
            public string ModifiedTimeGMT { get; set; }

            [NameInMap("Originator")]
            [Validation(Required=false)]
            public GetInstancesResponseBodyDataOriginator Originator { get; set; }
            public class GetInstancesResponseBodyDataOriginator : TeaModel {
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
                public GetInstancesResponseBodyDataOriginatorName Name { get; set; }
                public class GetInstancesResponseBodyDataOriginatorName : TeaModel {
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
            /// <para>f30233fb-72e1-4af4-8cb8-c7e0ea9ee530</para>
            /// </summary>
            [NameInMap("ProcessInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>小红发起的请购单</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

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
