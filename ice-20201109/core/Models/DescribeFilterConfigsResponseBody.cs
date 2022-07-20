// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribeFilterConfigsResponseBody : TeaModel {
        [NameInMap("FilterConfigs")]
        [Validation(Required=false)]
        public List<DescribeFilterConfigsResponseBodyFilterConfigs> FilterConfigs { get; set; }
        public class DescribeFilterConfigsResponseBodyFilterConfigs : TeaModel {
            [NameInMap("FilterName")]
            [Validation(Required=false)]
            public string FilterName { get; set; }

            [NameInMap("ItemConfigs")]
            [Validation(Required=false)]
            public string ItemConfigs { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
