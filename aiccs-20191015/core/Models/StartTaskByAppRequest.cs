// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class StartTaskByAppRequest : TeaModel {
        /// <summary>
        /// app
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// operator
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// token
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// envTypes
        /// </summary>
        [NameInMap("EnvTypes")]
        [Validation(Required=false)]
        public string EnvTypes { get; set; }

        /// <summary>
        /// appName
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// appId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public int? AppId { get; set; }

        /// <summary>
        /// buildId
        /// </summary>
        [NameInMap("BuildId")]
        [Validation(Required=false)]
        public string BuildId { get; set; }

        /// <summary>
        /// siteType
        /// </summary>
        [NameInMap("SiteType")]
        [Validation(Required=false)]
        public string SiteType { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
