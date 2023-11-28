// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDefaultCollectorConfigurationsRequest : TeaModel {
        /// <summary>
        /// The shipper type. Valid values:
        /// 
        /// *   fileBeat
        /// *   metricBeat
        /// *   heartBeat
        /// *   auditBeat
        /// </summary>
        [NameInMap("resType")]
        [Validation(Required=false)]
        public string ResType { get; set; }

        /// <summary>
        /// The shipper version. The shipper version varies based on the type of the machine on which the shipper is deployed. Valid values:
        /// 
        /// *   ECS: 6.8.5\_with_community
        /// *   ACK: 6.8.13\_with_community
        /// </summary>
        [NameInMap("resVersion")]
        [Validation(Required=false)]
        public string ResVersion { get; set; }

        /// <summary>
        /// The type of the machine on which the shipper is deployed. If you do not configure this parameter, the default configuration files of shippers deployed on all types of machines are returned. Valid values:
        /// 
        /// *   ECS: ECS instance
        /// *   ACK: ACK cluster
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
