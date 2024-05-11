// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class InitEnvironmentRequest : TeaModel {
        /// <summary>
        /// The language. Valid values: zh and en. Default value: zh.
        /// </summary>
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// Whether to create a Token in order to enhance the security of data retrieval.
        /// </summary>
        [NameInMap("CreateAuthToken")]
        [Validation(Required=false)]
        public bool? CreateAuthToken { get; set; }

        /// <summary>
        /// The ID of the environment instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnvironmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Whether agents or exporters are managed. Valid values:
        /// 
        /// *   none: No. By default, no managed agents or exporters are provided for ACK clusters.
        /// *   agent: Agents are managed. By default, managed agents are provided for ASK clusters, ACS clusters, and ACK One clusters.
        /// *   agent-exproter: Agents and exporters are managed. By default, managed agents and exporters are provided for cloud services.
        /// </summary>
        [NameInMap("ManagedType")]
        [Validation(Required=false)]
        public string ManagedType { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
