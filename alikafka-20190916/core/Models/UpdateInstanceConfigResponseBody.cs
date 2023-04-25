// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class UpdateInstanceConfigResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// ## **Permissions**
        /// 
        /// If a RAM user wants to call the **UpdateInstanceConfig** operation, the RAM user must be granted the required permissions. For more information about how to grant permissions, see [RAM policies](~~185815~~).
        /// 
        /// |API|Action|Resource|
        /// |---|---|---|
        /// |UpdateInstanceConfig|alikafka: UpdateInstance|acs:alikafka:*:*:{instanceId}|
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// ### Config parameters
        /// 
        /// |Parameter|Type|Valid values|Default value|Description|
        /// |---|---|---|---|---|
        /// |enable.vpc\_sasl\_ssl|Boolean|true/false|false|Specifies whether to enable virtual private cloud (VPC) transmission encryption. If VPC transmission encryption is enabled, you must also enable the access control list (ACL) feature.|
        /// |enable.acl|Boolean|true/false|false|Specifies whether to enable the ACL feature.|
        /// |kafka.log.retention.hours|Integer|24~480|72|The retention period of messages. Unit: hours.|
        /// |kafka.message.max.bytes|Integer|1048576~10485760|1048576|The maximum size of a message. Unit: bytes.|
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Modifies the configuration of a Message Queue for Apache Kafka instance.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
