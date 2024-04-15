// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ExportDesktopGroupInfoResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The URL from which you can download the exported cloud computer pools. The details of the cloud computer pools include:
        /// 
        /// *   IDs and names of the cloud computer pools
        /// *   IDs and names of the office networks
        /// *   Cloud computer pool templates
        /// *   Number of CPU cores and memory size
        /// *   System disks and data disks
        /// *   Names of security policies
        /// *   Number of current authorized users
        /// *   Billing methods
        /// *   The time when the cloud computer pools were created
        /// *   The time when the cloud computer pools expire
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
