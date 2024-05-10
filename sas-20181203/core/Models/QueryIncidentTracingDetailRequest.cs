// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryIncidentTracingDetailRequest : TeaModel {
        /// <summary>
        /// The ID of the event.
        /// 
        /// >  You can call the [DescribeCloudSiemEvents](https://help.aliyun.com/document_detail/2621307.html) operation to query the IDs of events.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IncidentId")]
        [Validation(Required=false)]
        public string IncidentId { get; set; }

    }

}
