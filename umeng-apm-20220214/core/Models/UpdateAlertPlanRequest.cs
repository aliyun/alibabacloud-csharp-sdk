// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_apm20220214.Models
{
    public class UpdateAlertPlanRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("planId")]
        [Validation(Required=false)]
        public long? PlanId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("versions")]
        [Validation(Required=false)]
        public string Versions { get; set; }

    }

}
