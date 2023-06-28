// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CustomHealthCheckConfig : TeaModel {
        [NameInMap("failureThreshold")]
        [Validation(Required=false)]
        public int? FailureThreshold { get; set; }

        [NameInMap("httpGetUrl")]
        [Validation(Required=false)]
        public string HttpGetUrl { get; set; }

        [NameInMap("initialDelaySeconds")]
        [Validation(Required=false)]
        public int? InitialDelaySeconds { get; set; }

        [NameInMap("periodSeconds")]
        [Validation(Required=false)]
        public int? PeriodSeconds { get; set; }

        [NameInMap("successThreshold")]
        [Validation(Required=false)]
        public int? SuccessThreshold { get; set; }

        [NameInMap("timeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

    }

}
