// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class EnableRightsSeparationRequest : TeaModel {
        [NameInMap("AuditAccountDescription")]
        [Validation(Required=false)]
        public string AuditAccountDescription { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AuditAccountName")]
        [Validation(Required=false)]
        public string AuditAccountName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AuditAccountPassword")]
        [Validation(Required=false)]
        public string AuditAccountPassword { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SecurityAccountDescription")]
        [Validation(Required=false)]
        public string SecurityAccountDescription { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecurityAccountName")]
        [Validation(Required=false)]
        public string SecurityAccountName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecurityAccountPassword")]
        [Validation(Required=false)]
        public string SecurityAccountPassword { get; set; }

    }

}
