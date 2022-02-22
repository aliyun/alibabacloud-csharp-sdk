// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class CreateDeployConfigRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        [NameInMap("CodePath")]
        [Validation(Required=false)]
        public string CodePath { get; set; }

        [NameInMap("ConfigMap")]
        [Validation(Required=false)]
        public string ConfigMap { get; set; }

        [NameInMap("ConfigMapList")]
        [Validation(Required=false)]
        public List<string> ConfigMapList { get; set; }

        [NameInMap("CronJob")]
        [Validation(Required=false)]
        public string CronJob { get; set; }

        [NameInMap("Deployment")]
        [Validation(Required=false)]
        public string Deployment { get; set; }

        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("SecretList")]
        [Validation(Required=false)]
        public List<string> SecretList { get; set; }

        [NameInMap("StatefulSet")]
        [Validation(Required=false)]
        public string StatefulSet { get; set; }

    }

}
