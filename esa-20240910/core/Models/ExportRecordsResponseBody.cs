// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ExportRecordsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>;; site:example.com.\n;; Exported:2024-01-24 15:54:35\n\n;; A Records\na1.example.com. 30 IN A 1.1.1.1 direct\na2.example.com. 30 IN A 1.1.1.1 direct\na3.example.com. 30 IN A 1.1.1.1 direct\n</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C69B5894-D1BA-592C-95D0-DADBE7AEAC63</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
