// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListSoftwaresRequest : TeaModel {
        /// <summary>
        /// The version of the E-HPC client.
        /// 
        /// You can call the [ListCurrentClientVersion](~~87223~~) operation to query the E-HPC client version.
        /// </summary>
        [NameInMap("EhpcVersion")]
        [Validation(Required=false)]
        public string EhpcVersion { get; set; }

        /// <summary>
        /// The image tag of the cluster.
        /// 
        /// You can use the [ListImages](~~87213~~) to query the image tag of the cluster.
        /// </summary>
        [NameInMap("OsTag")]
        [Validation(Required=false)]
        public string OsTag { get; set; }

    }

}
