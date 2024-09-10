// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAssetsScaProcessNumResponseBody : TeaModel {
        /// <summary>
        /// The statistical results.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAssetsScaProcessNumResponseBodyData> Data { get; set; }
        public class DescribeAssetsScaProcessNumResponseBodyData : TeaModel {
            /// <summary>
            /// The number of Java processes.
            /// 
            /// >  If no processes exist on the asset, no statistical result is returned.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The UUID of the asset.
            /// 
            /// >  If no processes exist on the asset, no statistical result is returned.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
