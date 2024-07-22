// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class BuySessionPackageRequest : TeaModel {
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("MaxSessions")]
        [Validation(Required=false)]
        public int? MaxSessions { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("SessionPackageName")]
        [Validation(Required=false)]
        public string SessionPackageName { get; set; }

        [NameInMap("SessionPackageType")]
        [Validation(Required=false)]
        public string SessionPackageType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SessionSpec")]
        [Validation(Required=false)]
        public string SessionSpec { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SessionType")]
        [Validation(Required=false)]
        public string SessionType { get; set; }

    }

}
