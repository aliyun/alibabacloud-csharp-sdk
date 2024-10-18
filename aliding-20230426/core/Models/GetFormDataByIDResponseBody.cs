// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetFormDataByIDResponseBody : TeaModel {
        [NameInMap("formData")]
        [Validation(Required=false)]
        public Dictionary<string, object> FormData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FORM_INST_12345</para>
        /// </summary>
        [NameInMap("formInstId")]
        [Validation(Required=false)]
        public string FormInstId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-05-01</para>
        /// </summary>
        [NameInMap("modifiedTimeGMT")]
        [Validation(Required=false)]
        public string ModifiedTimeGMT { get; set; }

        [NameInMap("originator")]
        [Validation(Required=false)]
        public GetFormDataByIDResponseBodyOriginator Originator { get; set; }
        public class GetFormDataByIDResponseBodyOriginator : TeaModel {
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
            public GetFormDataByIDResponseBodyOriginatorName Name { get; set; }
            public class GetFormDataByIDResponseBodyOriginatorName : TeaModel {
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
            /// <para>012345</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
