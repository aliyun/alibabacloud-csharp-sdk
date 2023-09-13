// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateDomainRequest : TeaModel {
        /// <summary>
        /// 域名。最大长度限制255，格式由数字、字母、横线（-）点（.）组成;
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// 备案信息参数。
        /// </summary>
        [NameInMap("Filing")]
        [Validation(Required=false)]
        public CreateDomainRequestFiling Filing { get; set; }
        public class CreateDomainRequestFiling : TeaModel {
            /// <summary>
            /// 域名关联的备案号，长度最大限制64。
            /// </summary>
            [NameInMap("IcpNumber")]
            [Validation(Required=false)]
            public string IcpNumber { get; set; }

        }

        /// <summary>
        /// IDaaS EIAM实例的ID。
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
