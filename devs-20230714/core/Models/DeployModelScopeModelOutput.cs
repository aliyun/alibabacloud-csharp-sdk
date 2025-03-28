// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class DeployModelScopeModelOutput : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public DeployModelScopeModelOutputData Data { get; set; }
        public class DeployModelScopeModelOutputData : TeaModel {
            [NameInMap("deploymentTaskID")]
            [Validation(Required=false)]
            public string DeploymentTaskID { get; set; }

            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("finished")]
            [Validation(Required=false)]
            public bool? Finished { get; set; }

            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("traceID")]
            [Validation(Required=false)]
            public string TraceID { get; set; }

            [NameInMap("urlInternet")]
            [Validation(Required=false)]
            public string UrlInternet { get; set; }

            [NameInMap("urlIntranet")]
            [Validation(Required=false)]
            public string UrlIntranet { get; set; }

        }

        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("errMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
