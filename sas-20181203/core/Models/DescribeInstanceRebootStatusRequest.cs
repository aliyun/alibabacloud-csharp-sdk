// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstanceRebootStatusRequest : TeaModel {
        /// <summary>
        /// The UUIDs of the servers that you restart. Separate multiple UUIDs with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
