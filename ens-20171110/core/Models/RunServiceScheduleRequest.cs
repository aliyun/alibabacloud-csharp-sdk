// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RunServiceScheduleRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=true)]
        public string AppId { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=true)]
        public string Uuid { get; set; }

        [NameInMap("ClientIp")]
        [Validation(Required=true)]
        public string ClientIp { get; set; }

        [NameInMap("ServiceAction")]
        [Validation(Required=true)]
        public string ServiceAction { get; set; }

        [NameInMap("PodConfigName")]
        [Validation(Required=false)]
        public string PodConfigName { get; set; }

        [NameInMap("PreLockedTimeout")]
        [Validation(Required=false)]
        public int? PreLockedTimeout { get; set; }

        [NameInMap("Directorys")]
        [Validation(Required=false)]
        public string Directorys { get; set; }

        [NameInMap("ServiceCommands")]
        [Validation(Required=false)]
        public string ServiceCommands { get; set; }

        [NameInMap("ScheduleStrategy")]
        [Validation(Required=false)]
        public string ScheduleStrategy { get; set; }

    }

}
