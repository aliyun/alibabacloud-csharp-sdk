// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class PublishAndDeployTaskFlowResponseBody : TeaModel {
        [NameInMap("DeployId")]
        [Validation(Required=false)]
        public long? DeployId { get; set; }

        /// <summary>
        /// <PublishAndDeployTaskFlowResponse>
        ///     <RequestId>64E26249-B61F-51C6-B6DF-47EFF50128CC</RequestId>
        ///     <ErrorCode>UnknownError</ErrorCode>
        ///     <ErrorMessage>Unknown server error</ErrorMessage>
        ///     <Success>true</Success>
        /// </PublishAndDeployTaskFlowResponse>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Publishes and deploys a task flow.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 12**
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// WB01220210
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
