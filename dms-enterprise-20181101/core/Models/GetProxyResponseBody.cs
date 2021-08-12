// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetProxyResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ProxyId")]
        [Validation(Required=false)]
        public long? ProxyId { get; set; }

        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public long? CreatorId { get; set; }

        [NameInMap("CreatorName")]
        [Validation(Required=false)]
        public string CreatorName { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        [NameInMap("PrivateEnable")]
        [Validation(Required=false)]
        public bool? PrivateEnable { get; set; }

        [NameInMap("PrivateHost")]
        [Validation(Required=false)]
        public string PrivateHost { get; set; }

        [NameInMap("PublicEnable")]
        [Validation(Required=false)]
        public bool? PublicEnable { get; set; }

        [NameInMap("PublicHost")]
        [Validation(Required=false)]
        public string PublicHost { get; set; }

        [NameInMap("MysqlPort")]
        [Validation(Required=false)]
        public int? MysqlPort { get; set; }

        [NameInMap("HttpsPort")]
        [Validation(Required=false)]
        public int? HttpsPort { get; set; }

    }

}
