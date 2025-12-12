// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeDBClusterStatusSetResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DE309AA1-BD83-5E1F-9945-8A4D336E0829</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StatusSet")]
        [Validation(Required=false)]
        public List<string> StatusSet { get; set; }

    }

}
