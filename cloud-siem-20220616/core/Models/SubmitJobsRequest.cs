// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class SubmitJobsRequest : TeaModel {
        /// <summary>
        /// The parameters of the logs that you want to add. The value is a JSON array, which contains the following parameters:\\
        /// 
        /// 
        /// *   SourceProdCode: the code of the cloud service.
        /// 
        /// *   SourceLogCode: the code of the log.
        /// 
        /// *   Deleted: specifies whether to add the log. Valid values:
        /// 
        ///     *   0: yes
        ///     *   1: no
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("JsonParam")]
        [Validation(Required=false)]
        public string JsonParam { get; set; }

        /// <summary>
        /// The region in which the data management center of the threat analysis feature resides. Specify this parameter based on the regions in which your assets reside. Valid values:
        /// 
        /// *   cn-hangzhou: Your assets reside in regions in China.
        /// *   ap-southeast-1: Your assets reside in regions outside China.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
