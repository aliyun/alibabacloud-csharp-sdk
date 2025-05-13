// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class PrometheusManagedInstance : TeaModel {
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("prometheusInstanceId")]
        [Validation(Required=false)]
        public string PrometheusInstanceId { get; set; }

        [NameInMap("prometheusInstanceName")]
        [Validation(Required=false)]
        public string PrometheusInstanceName { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
