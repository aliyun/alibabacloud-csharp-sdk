// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryIncidentTracingJudgeRequest : TeaModel {
        /// <summary>
        /// The ID of the event that you want to query.
        /// 
        /// >  You can call the [DescribeCloudSiemEvents](https://help.aliyun.com/document_detail/2621307.html) operation to query the event ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IncidentId")]
        [Validation(Required=false)]
        public string IncidentId { get; set; }

    }

}
