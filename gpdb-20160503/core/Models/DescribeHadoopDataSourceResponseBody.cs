// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeHadoopDataSourceResponseBody : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("DataSourceDescription")]
        [Validation(Required=false)]
        public string DataSourceDescription { get; set; }

        [NameInMap("DataSourceDir")]
        [Validation(Required=false)]
        public string DataSourceDir { get; set; }

        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        [NameInMap("DataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        [NameInMap("DataSourceStatus")]
        [Validation(Required=false)]
        public string DataSourceStatus { get; set; }

        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        [NameInMap("EmrInstanceId")]
        [Validation(Required=false)]
        public string EmrInstanceId { get; set; }

        [NameInMap("HDFSConf")]
        [Validation(Required=false)]
        public string HDFSConf { get; set; }

        [NameInMap("HadoopCoreConf")]
        [Validation(Required=false)]
        public string HadoopCoreConf { get; set; }

        [NameInMap("HadoopCreateType")]
        [Validation(Required=false)]
        public string HadoopCreateType { get; set; }

        [NameInMap("HadoopHostsAddress")]
        [Validation(Required=false)]
        public string HadoopHostsAddress { get; set; }

        [NameInMap("HiveConf")]
        [Validation(Required=false)]
        public string HiveConf { get; set; }

        [NameInMap("MapReduceConf")]
        [Validation(Required=false)]
        public string MapReduceConf { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StatusMessage")]
        [Validation(Required=false)]
        public string StatusMessage { get; set; }

        [NameInMap("YarnConf")]
        [Validation(Required=false)]
        public string YarnConf { get; set; }

    }

}
