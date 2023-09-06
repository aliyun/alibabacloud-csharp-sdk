// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class UpdateScheduleConferenceRequest : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("ScheduleConferenceId")]
        [Validation(Required=false)]
        public string ScheduleConferenceId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public UpdateScheduleConferenceRequestTenantContext TenantContext { get; set; }
        public class UpdateScheduleConferenceRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
