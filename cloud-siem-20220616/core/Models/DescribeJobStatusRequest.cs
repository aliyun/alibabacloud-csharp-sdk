// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeJobStatusRequest : TeaModel {
        /// <summary>
        /// The region where the service resides. Default value: cn-shanghai.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the collection task. The ID is the value of the submitId parameter in the response of the [BatchJobSubmit](https://next.api.aliyun.com/api/cloud-siem/2022-06-16/BatchSubmitJob?lang=JAVA\\&useCommon=true) operation.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SubmitId")]
        [Validation(Required=false)]
        public string SubmitId { get; set; }

    }

}
