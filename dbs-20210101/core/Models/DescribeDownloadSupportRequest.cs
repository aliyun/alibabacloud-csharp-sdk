// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class DescribeDownloadSupportRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The ID of the region in which the instance resides. You can call the [DescribeDBInstanceAttribute](https://help.aliyun.com/document_detail/26231.html) operation to query the region ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionCode")]
        [Validation(Required=false)]
        public string RegionCode { get; set; }

    }

}
