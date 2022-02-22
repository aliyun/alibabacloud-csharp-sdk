// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class ListDeployConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDeployConfigResponseBodyData> Data { get; set; }
        public class ListDeployConfigResponseBodyData : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            [NameInMap("ContainerCodePath")]
            [Validation(Required=false)]
            public ListDeployConfigResponseBodyDataContainerCodePath ContainerCodePath { get; set; }
            public class ListDeployConfigResponseBodyDataContainerCodePath : TeaModel {
                [NameInMap("CodePath")]
                [Validation(Required=false)]
                public string CodePath { get; set; }
            };

            [NameInMap("ContainerYamlConf")]
            [Validation(Required=false)]
            public ListDeployConfigResponseBodyDataContainerYamlConf ContainerYamlConf { get; set; }
            public class ListDeployConfigResponseBodyDataContainerYamlConf : TeaModel {
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
                [NameInMap("SecretList")]
                [Validation(Required=false)]
                public List<string> SecretList { get; set; }
                [NameInMap("StatefulSet")]
                [Validation(Required=false)]
                public string StatefulSet { get; set; }
            };

            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
