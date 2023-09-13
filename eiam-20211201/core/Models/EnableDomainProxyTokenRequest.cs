// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class EnableDomainProxyTokenRequest : TeaModel {
        /// <summary>
        /// 域名ID。
        /// </summary>
        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// 域名代理Token ID。
        /// </summary>
        [NameInMap("DomainProxyTokenId")]
        [Validation(Required=false)]
        public string DomainProxyTokenId { get; set; }

        /// <summary>
        /// IDaaS EIAM实例的ID。
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
