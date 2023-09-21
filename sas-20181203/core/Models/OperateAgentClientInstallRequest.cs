// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateAgentClientInstallRequest : TeaModel {
        /// <summary>
        /// The IDs of the servers on which you want to install the Security Center agent. Separate multiple IDs with commas (,).
        /// 
        /// > : You must specify at least one of **InstanceIds** and **Uuids**. If you specify **InstanceIds**, you must also specify **Region** and **Os**.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

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
        /// The operating system of the servers. Valid values:
        /// 
        /// *   **linux**
        /// *   **windows**
        /// </summary>
        [NameInMap("Os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        /// <summary>
        /// The region where the servers reside. Valid values include the following regions:
        /// 
        /// *   cn-hangzhou: China (Hangzhou)
        /// *   cn-beijing: China (Beijing)
        /// *   cn-shanghai: China (Shanghai)
        /// *   cn-zhangjiakou: China (Zhangjiakou)
        /// *   cn-shenzhen: China (Shenzhen)
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The UUIDs of the servers on which you want to install the Security Center agent. Separate multiple UUIDs with commas (,).
        /// 
        /// > You must specify at least one of the **InstanceIds** and **Uuids** parameters before you can call this operation.
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
