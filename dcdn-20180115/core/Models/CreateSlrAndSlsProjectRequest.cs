// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CreateSlrAndSlsProjectRequest : TeaModel {
        /// <summary>
        /// The type of the collected logs. Default value: cdn_log_access_l1. Valid values:
        /// 
        /// *   **cdn_log_access_l1**: access logs of L1 Dynamic Route for CDN (DCDN) points of presence (POPs)
        /// *   **cdn_log_origin**: back-to-origin logs
        /// *   **cdn_log_er**: EdgeRoutine logs
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// The region where Log Service resides. Valid values:
        /// 
        /// *   **cn-hangzhou**
        /// *   **cn-shanghai**
        /// *   **cn-qingdao**
        /// *   **cn-beijing**
        /// *   **cn-zhangjiakou**
        /// *   **cn-shenzhen**
        /// *   **eu-central-1**
        /// *   **us-west-1**
        /// *   **ap-south-1**
        /// *   **ap-southeast-1**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}
