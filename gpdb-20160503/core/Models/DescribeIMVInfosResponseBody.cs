// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeIMVInfosResponseBody : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The queried materialized views.
        /// </summary>
        [NameInMap("ImvInfos")]
        [Validation(Required=false)]
        public List<DescribeIMVInfosResponseBodyImvInfos> ImvInfos { get; set; }
        public class DescribeIMVInfosResponseBodyImvInfos : TeaModel {
            /// <summary>
            /// The name of the table based on which the materialized view is created.
            /// </summary>
            [NameInMap("Base")]
            [Validation(Required=false)]
            public string Base { get; set; }

            /// <summary>
            /// The dependency between the materialized view and the base table and all metric values, which can be used to build a lineage graph.
            /// </summary>
            [NameInMap("DetailInfo")]
            [Validation(Required=false)]
            public string DetailInfo { get; set; }

            /// <summary>
            /// The name of the materialized view.
            /// </summary>
            [NameInMap("MV")]
            [Validation(Required=false)]
            public string MV { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
