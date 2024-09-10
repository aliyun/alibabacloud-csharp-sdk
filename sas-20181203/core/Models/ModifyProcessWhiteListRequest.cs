// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyProcessWhiteListRequest : TeaModel {
        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The MD5 hash value of the process startup file.
        /// 
        /// >  You can call the [DescribeWhiteListProcess](~~DescribeWhiteListProcess~~) operation to obtain the MD5 hash value.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Md5s")]
        [Validation(Required=false)]
        public string Md5s { get; set; }

        /// <summary>
        /// The source IP address of the request. You do not need to specify this parameter. It is automatically obtained by the system.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The whitelist status of the process. Valid values:
        /// 
        /// *   **1**: removes a process from the whitelist.
        /// *   **2**: adds a process to the whitelist.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The ID of the policy.
        /// 
        /// >  You can call the [DescribeWhiteListStrategyList](~~DescribeWhiteListStrategyList~~) operation to obtain the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public long? StrategyId { get; set; }

    }

}
