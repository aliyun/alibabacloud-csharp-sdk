// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetDoctorHDFSUGIRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Specify the date in the ISO 8601 standard. For example, 2023-01-01 represents January 1, 2023.
        /// </summary>
        [NameInMap("DateTime")]
        [Validation(Required=false)]
        public string DateTime { get; set; }

        /// <summary>
        /// Set this parameter based on the value of Type.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The filter condition. Valid values:
        /// 
        /// *   user
        /// *   group
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
