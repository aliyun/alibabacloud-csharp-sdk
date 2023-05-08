// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshAdditionalStatusRequest : TeaModel {
        /// <summary>
        /// The check result of the SLB instance. Valid values:
        /// 
        /// *   `exist`: The SLB instance exists.
        /// *   `not_exist`: The SLB instance does not exist.
        /// *   `conflict`: Conflicts are detected.
        /// *   `failed`: The check fails.
        /// *   `time_out`: The check times out.
        /// </summary>
        [NameInMap("CheckMode")]
        [Validation(Required=false)]
        public string CheckMode { get; set; }

        /// <summary>
        /// The check results of the SLB instances created for exposing the API server.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
