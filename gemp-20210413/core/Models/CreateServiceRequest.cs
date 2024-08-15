// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateServiceRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("escalationPlanId")]
        [Validation(Required=false)]
        public long? EscalationPlanId { get; set; }

        [NameInMap("serviceDescription")]
        [Validation(Required=false)]
        public string ServiceDescription { get; set; }

        [NameInMap("serviceGroupIdList")]
        [Validation(Required=false)]
        public List<long?> ServiceGroupIdList { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("serviceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
