// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class Application : TeaModel {
        /// <summary>
        /// 应用名称。从EMR控制台集群创建页面可查看到指定发行版的应用名称列表。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

    }

}
