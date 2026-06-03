// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class ListDataSourceAttributeResponseBody : TeaModel {
        [NameInMap("DbList")]
        [Validation(Required=false)]
        public List<ListDataSourceAttributeResponseBodyDbList> DbList { get; set; }
        public class ListDataSourceAttributeResponseBodyDbList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>All</para>
            /// </summary>
            [NameInMap("AuditMode")]
            [Validation(Required=false)]
            public string AuditMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public int? DbId { get; set; }

            [NameInMap("FreqAuditMode")]
            [Validation(Required=false)]
            public string FreqAuditMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ResultAuditMaxLine")]
            [Validation(Required=false)]
            public int? ResultAuditMaxLine { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ResultAuditMaxSize")]
            [Validation(Required=false)]
            public int? ResultAuditMaxSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Close</para>
            /// </summary>
            [NameInMap("ResultAuditMode")]
            [Validation(Required=false)]
            public string ResultAuditMode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1B217656-2267-4FBF-B26C-CDD201BDC3B8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
