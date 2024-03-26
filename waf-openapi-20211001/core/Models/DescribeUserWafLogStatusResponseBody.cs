// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeUserWafLogStatusResponseBody : TeaModel {
        /// <summary>
        /// The ID of the region where WAF logs are stored. Valid values:
        /// 
        /// *   **cn-hangzhou**: China (Hangzhou).
        /// *   **cn-beijing**: China (Beijing).
        /// *   **cn-hongkong**: China (Hong Kong).
        /// *   **ap-southeast-1**: Singapore.
        /// *   **ap-southeast-2**: Australia (Sydney).
        /// *   **ap-southeast-3**: Malaysia (Kuala Lumpur).
        /// *   **ap-southeast-5**: Indonesia (Jakarta).
        /// *   **ap-southeast-6**: Philippines (Manila).
        /// *   **ap-southeast-7**: Thailand (Bangkok).
        /// *   **me-east-1**: UAE (Dubai).
        /// *   **eu-central-1**: Germany (Frankfurt).
        /// *   **us-east-1**: US (Virginia).
        /// *   **us-west-1**: US (Silicon Valley).
        /// *   **ap-northeast-1**: Japan (Tokyo).
        /// *   **ap-northeast-2**: South Korea (Seoul).
        /// *   **ap-south-1**: India (Mumbai).
        /// *   **eu-west-1**: UK (London).
        /// *   **cn-hangzhou-finance**: China East 1 Finance.
        /// *   **cn-shanghai-finance-1**: China East 2 Finance.
        /// *   **cn-shenzhen-finance**: China South 1 Finance.
        /// 
        /// >  The China East 1 Finance, China East 2 Finance, and China South 1 Finance regions are available only for Alibaba Finance Cloud users. Alibaba Finance Cloud users are also limited to storing logs within these specific regions.
        /// </summary>
        [NameInMap("LogRegionId")]
        [Validation(Required=false)]
        public string LogRegionId { get; set; }

        /// <summary>
        /// The status of WAF logs.
        /// 
        /// *   **initializing**
        /// *   **initialize_failed**
        /// *   **normal**
        /// *   **releasing**
        /// *   **release_failed**
        /// </summary>
        [NameInMap("LogStatus")]
        [Validation(Required=false)]
        public string LogStatus { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The time when the log status was modified. Unit: milliseconds.
        /// </summary>
        [NameInMap("StatusUpdateTime")]
        [Validation(Required=false)]
        public long? StatusUpdateTime { get; set; }

    }

}
