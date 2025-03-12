// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeMetricsDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[
        ///                 {
        ///                     &quot;sql_select_count&quot;:75.<b><b>15</b></b>1515,
        ///                     &quot;timestamp&quot;:165079****
        ///                 },
        ///                 ......
        ///             ]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<string> Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-<b><b>-</b></b>-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
