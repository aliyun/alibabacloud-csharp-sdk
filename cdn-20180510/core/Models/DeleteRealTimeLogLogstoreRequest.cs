// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DeleteRealTimeLogLogstoreRequest : TeaModel {
        /// <summary>
        /// The name of the Logstore to which log entries are delivered.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// The name of the Log Service project that is used for real-time log delivery.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// The ID of the region where the Log Service project is deployed. For more information, see [Regions that support real-time log delivery](https://help.aliyun.com/document_detail/144883.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}
