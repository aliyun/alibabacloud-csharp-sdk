// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateCloudDriveServiceResponseBody : TeaModel {
        /// <summary>
        /// The ID of the attached cloud disk.
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// The name of the cloud disk that is created in Cloud Drive Service.
        /// </summary>
        [NameInMap("CdsName")]
        [Validation(Required=false)]
        public string CdsName { get; set; }

        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The maximum capacity of each instance in Cloud Drive Service. Unit: GiB
        /// </summary>
        [NameInMap("MaxSize")]
        [Validation(Required=false)]
        public string MaxSize { get; set; }

        [NameInMap("OfficeSiteType")]
        [Validation(Required=false)]
        public string OfficeSiteType { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
