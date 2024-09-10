// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAllRegionsStatisticsRequest : TeaModel {
        /// <summary>
        /// The source of the request. Default value: **aqs**. Valid values:
        /// 
        /// *   **sas**: Security Center.
        /// *   **aqs**: Server Guard.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// The ID of the asset group that you want to query.
        /// 
        /// >  You can call the [DescribeAllGroups](https://help.aliyun.com/document_detail/130972.html) operation to query the ID.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// The name or public IP address of the asset.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
