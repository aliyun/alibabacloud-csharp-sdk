// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class ConfigureDrdsDbInstancesRequest : TeaModel {
        [NameInMap("DbInstance")]
        [Validation(Required=false)]
        public List<ConfigureDrdsDbInstancesRequestDbInstance> DbInstance { get; set; }
        public class ConfigureDrdsDbInstancesRequestDbInstance : TeaModel {
            [NameInMap("MasterDbInstanceId")]
            [Validation(Required=false)]
            public string MasterDbInstanceId { get; set; }

            [NameInMap("SlaveDbInstanceId")]
            [Validation(Required=false)]
            public string SlaveDbInstanceId { get; set; }

            [NameInMap("SlaveDbInstanceType")]
            [Validation(Required=false)]
            public string SlaveDbInstanceType { get; set; }

        }

        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

    }

}
