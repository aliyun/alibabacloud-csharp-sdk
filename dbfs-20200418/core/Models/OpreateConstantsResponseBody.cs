// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class OpreateConstantsResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("RegionData")]
        [Validation(Required=false)]
        public string RegionData { get; set; }

        [NameInMap("ZoneData")]
        [Validation(Required=false)]
        public string ZoneData { get; set; }

        [NameInMap("OsversionData")]
        [Validation(Required=false)]
        public string OsversionData { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("ProductCodeData")]
        [Validation(Required=false)]
        public string ProductCodeData { get; set; }

        [NameInMap("MasterData")]
        [Validation(Required=false)]
        public string MasterData { get; set; }

        [NameInMap("EndpointData")]
        [Validation(Required=false)]
        public string EndpointData { get; set; }

        [NameInMap("AccessData")]
        [Validation(Required=false)]
        public string AccessData { get; set; }

    }

}
