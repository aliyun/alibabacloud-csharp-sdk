// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20181015.Models
{
    public class GrafanaWorkspaceAlertNotification : TeaModel {
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("isArms")]
        [Validation(Required=false)]
        public bool? IsArms { get; set; }

        [NameInMap("isDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("sendReminder")]
        [Validation(Required=false)]
        public bool? SendReminder { get; set; }

        [NameInMap("settings")]
        [Validation(Required=false)]
        public string Settings { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
