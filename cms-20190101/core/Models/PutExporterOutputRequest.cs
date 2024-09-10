// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutExporterOutputRequest : TeaModel {
        /// <summary>
        /// The configuration set for exporting monitoring data. It is a JSON object string. The string must include the following fields:
        /// 
        /// *   endpoint: the endpoint of Log Service.
        /// *   project: the Log Service project to which monitoring data is exported.
        /// *   logstore: the Log Service Logstore to which the monitoring data is exported.
        /// *   ak: the AccessKey ID.
        /// *   as: the AccessKey secret.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConfigJson")]
        [Validation(Required=false)]
        public string ConfigJson { get; set; }

        /// <summary>
        /// The description of the configuration set.
        /// </summary>
        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// The name of the configuration set.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestName")]
        [Validation(Required=false)]
        public string DestName { get; set; }

        /// <summary>
        /// The service to which the monitoring data is exported.
        /// </summary>
        [NameInMap("DestType")]
        [Validation(Required=false)]
        public string DestType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
