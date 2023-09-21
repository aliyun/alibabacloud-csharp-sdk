// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAttachRecordsRequest : TeaModel {
        /// <summary>
        /// The application group ID.
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// The UUIDs of ECS instances to be queried.
        /// </summary>
        [NameInMap("EcsUUIDList")]
        [Validation(Required=false)]
        public List<string> EcsUUIDList { get; set; }

    }

}
