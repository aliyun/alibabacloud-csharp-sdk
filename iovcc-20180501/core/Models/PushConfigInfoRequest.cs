// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class PushConfigInfoRequest : TeaModel {
        /// <summary>
        /// 项目ID
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 主机设备id
        /// </summary>
        [NameInMap("HostDeviceId")]
        [Validation(Required=false)]
        public string HostDeviceId { get; set; }

        /// <summary>
        /// 配置信息
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

    }

}
