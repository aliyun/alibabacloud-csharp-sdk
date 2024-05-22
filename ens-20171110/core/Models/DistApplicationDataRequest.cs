// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DistApplicationDataRequest : TeaModel {
        /// <summary>
        /// The ID of the application. To obtain the application ID, call the ListApplications operation.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The list of data files that you want to distribute. The value must be a JSON string.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// The canary release policy. The value must be a JSON string. You can specify multiple distribution policies. By default, all data files are distributed.
        /// </summary>
        [NameInMap("DistStrategy")]
        [Validation(Required=false)]
        public string DistStrategy { get; set; }

    }

}
