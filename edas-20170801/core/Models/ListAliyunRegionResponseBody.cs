// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListAliyunRegionResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The message that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The details of the regions.
        /// </summary>
        [NameInMap("RegionEntityList")]
        [Validation(Required=false)]
        public ListAliyunRegionResponseBodyRegionEntityList RegionEntityList { get; set; }
        public class ListAliyunRegionResponseBodyRegionEntityList : TeaModel {
            [NameInMap("RegionEntity")]
            [Validation(Required=false)]
            public List<ListAliyunRegionResponseBodyRegionEntityListRegionEntity> RegionEntity { get; set; }
            public class ListAliyunRegionResponseBodyRegionEntityListRegionEntity : TeaModel {
                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The name of the region.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
