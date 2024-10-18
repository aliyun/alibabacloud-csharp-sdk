// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListNavigationByFormTypeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListNavigationByFormTypeResponseBodyResult> Result { get; set; }
        public class ListNavigationByFormTypeResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>FORM-EF6Yxxx</para>
            /// </summary>
            [NameInMap("FormUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TPROC--X1Gxxx</para>
            /// </summary>
            [NameInMap("ProcessCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public ListNavigationByFormTypeResponseBodyResultTitle Title { get; set; }
            public class ListNavigationByFormTypeResponseBodyResultTitle : TeaModel {
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
                /// <para>未知</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

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
