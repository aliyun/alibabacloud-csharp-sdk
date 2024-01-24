// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class ModifyDrdsIpWhiteListRequest : TeaModel {
        /// <summary>
        /// The name of the DRDS database.
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// The ID of the Message Queue for Apache Kafka instance.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// The attribute of the IP address whitelist group.
        /// </summary>
        [NameInMap("GroupAttribute")]
        [Validation(Required=false)]
        public string GroupAttribute { get; set; }

        /// <summary>
        /// The name of the IP address whitelist group.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The modified whitelist. Separate multiple IP addresses with commas (,).
        /// </summary>
        [NameInMap("IpWhiteList")]
        [Validation(Required=false)]
        public string IpWhiteList { get; set; }

        /// <summary>
        /// Specifies the mode. Valid values:
        /// 
        /// *   `True`: append modifications
        /// *   `False`: overwrite modification
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public bool? Mode { get; set; }

    }

}
