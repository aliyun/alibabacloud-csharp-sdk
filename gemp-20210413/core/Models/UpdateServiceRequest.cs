// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class UpdateServiceRequest : TeaModel {
        /// <summary>
        /// 服务描述
        /// </summary>
        [NameInMap("serviceDescription")]
        [Validation(Required=false)]
        public string ServiceDescription { get; set; }

        /// <summary>
        /// 服务名字
        /// </summary>
        [NameInMap("serviceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        [NameInMap("serviceId")]
        [Validation(Required=false)]
        public long? ServiceId { get; set; }

        /// <summary>
        /// 幂等号
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
