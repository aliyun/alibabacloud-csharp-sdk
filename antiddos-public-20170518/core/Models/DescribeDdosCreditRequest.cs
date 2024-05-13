// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeDdosCreditRequest : TeaModel {
        /// <summary>
        /// The ID of the region.
        /// 
        /// > You can call the [DescribeRegions](https://help.aliyun.com/document_detail/353250.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DdosRegionId")]
        [Validation(Required=false)]
        public string DdosRegionId { get; set; }

    }

}
