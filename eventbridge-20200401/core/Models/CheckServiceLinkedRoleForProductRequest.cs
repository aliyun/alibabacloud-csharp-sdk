// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CheckServiceLinkedRoleForProductRequest : TeaModel {
        /// <summary>
        /// <para>The name of the service-linked role associated with the cloud service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunServiceRoleForEventBridgeConnectVPC</para>
        /// </summary>
        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

    }

}
