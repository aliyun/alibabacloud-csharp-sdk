// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetTemplateListByUserIdResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>12312131231</para>
        /// </summary>
        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public long? NextCursor { get; set; }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("templateList")]
        [Validation(Required=false)]
        public List<GetTemplateListByUserIdResponseBodyTemplateList> TemplateList { get; set; }
        public class GetTemplateListByUserIdResponseBodyTemplateList : TeaModel {
            [NameInMap("IconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11111</para>
            /// </summary>
            [NameInMap("ReportCode")]
            [Validation(Required=false)]
            public string ReportCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://scsss/sss">https://scsss/sss</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
