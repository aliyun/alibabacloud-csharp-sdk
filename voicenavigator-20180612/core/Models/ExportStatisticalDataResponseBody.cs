// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class ExportStatisticalDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>6be5a9f1-406e-424e-a17b-b6fb86ee3cc9</para>
        /// </summary>
        [NameInMap("ExportTaskId")]
        [Validation(Required=false)]
        public string ExportTaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c62e6789-28a8-41db-941e-171a01d3b3b9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
