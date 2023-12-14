// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class AddDataSourceRequest : TeaModel {
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("CloudCode")]
        [Validation(Required=false)]
        public string CloudCode { get; set; }

        [NameInMap("DataSourceInstanceName")]
        [Validation(Required=false)]
        public string DataSourceInstanceName { get; set; }

        [NameInMap("DataSourceInstanceParams")]
        [Validation(Required=false)]
        public string DataSourceInstanceParams { get; set; }

        [NameInMap("DataSourceInstanceRemark")]
        [Validation(Required=false)]
        public string DataSourceInstanceRemark { get; set; }

        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
