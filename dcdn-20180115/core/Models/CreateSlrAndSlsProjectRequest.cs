// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CreateSlrAndSlsProjectRequest : TeaModel {
        /// <summary>
        /// *   ****
        /// *   ****
        /// *   ****
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
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
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}
