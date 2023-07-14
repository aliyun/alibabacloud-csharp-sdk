// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryCertUrlByApplyIdRequest : TeaModel {
        /// <summary>
        /// The application ID. You can view the application ID in the result that is returned by the [BatchRegisterDeviceWithApplyId](~~69514~~) or [BatchRegisterDevice](~~69473~~) operation.
        /// </summary>
        [NameInMap("ApplyId")]
        [Validation(Required=false)]
        public long? ApplyId { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// You can obtain the **ID** of the instance on the **Overview** page in the IoT Platform console. If your instance has an ID, you must specify this parameter. Otherwise, the request fails.
        /// 
        /// > The ID of a public instance may not be displayed on the Overview page. For information about how to obtain the instance ID, see [How do I obtain an instance ID?](~~267533~~)
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

    }

}
