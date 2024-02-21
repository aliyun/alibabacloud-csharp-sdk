// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDataCheckReportUrlRequest : TeaModel {
        /// <summary>
        /// The data verification method. Valid values:
        /// 
        /// *   **1**: full data verification.
        /// *   **2**: incremental data verification.
        /// </summary>
        [NameInMap("CheckType")]
        [Validation(Required=false)]
        public int? CheckType { get; set; }

        /// <summary>
        /// The name of the verified source database.
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// The ID of the Data Transmission Service (DTS) task. You can call the [DescribeDtsJobs](~~209702~~) operation to query the task ID.
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// The name of the table verified in the source database.
        /// </summary>
        [NameInMap("TbName")]
        [Validation(Required=false)]
        public string TbName { get; set; }

    }

}
