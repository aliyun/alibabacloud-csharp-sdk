// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceBySQLRequest : TeaModel {
        /// <summary>
        /// The ID of the instance. You can view the **ID** of the instance on the **Instance Overview** page in the IoT Platform console.
        /// 
        /// 
        /// **Important**
        /// 
        /// *   If your instance has an ID, you must specify the ID for this parameter. Otherwise, the call fails.****
        /// *   If no **Overview** page or **ID** is generated for your instance, you do not need to configure this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The SQL-like statement that you want to execute to query devices. For more information about specific requirements and examples, see the following section.
        /// </summary>
        [NameInMap("SQL")]
        [Validation(Required=false)]
        public string SQL { get; set; }

    }

}
