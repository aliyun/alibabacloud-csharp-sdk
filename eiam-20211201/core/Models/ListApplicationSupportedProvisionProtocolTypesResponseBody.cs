// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListApplicationSupportedProvisionProtocolTypesResponseBody : TeaModel {
        [NameInMap("ApplicationSupportedProvisionProtocolType")]
        [Validation(Required=false)]
        public ListApplicationSupportedProvisionProtocolTypesResponseBodyApplicationSupportedProvisionProtocolType ApplicationSupportedProvisionProtocolType { get; set; }
        public class ListApplicationSupportedProvisionProtocolTypesResponseBodyApplicationSupportedProvisionProtocolType : TeaModel {
            /// <summary>
            /// <para>账户同步支持类型</para>
            /// </summary>
            [NameInMap("ProvisionProtocolType")]
            [Validation(Required=false)]
            public List<string> ProvisionProtocolType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
