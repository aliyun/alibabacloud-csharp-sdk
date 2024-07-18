// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpdateServiceInstanceAttributeRequest : TeaModel {
        /// <summary>
        /// The time when the service instance expires.
        /// 
        /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The License Data
        /// </summary>
        [NameInMap("LicenseData")]
        [Validation(Required=false)]
        public UpdateServiceInstanceAttributeRequestLicenseData LicenseData { get; set; }
        public class UpdateServiceInstanceAttributeRequestLicenseData : TeaModel {
            /// <summary>
            /// The Custom Data
            /// </summary>
            [NameInMap("CustomData")]
            [Validation(Required=false)]
            public string CustomData { get; set; }

        }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The service instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

    }

}
