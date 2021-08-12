// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListProxyAccessesResponseBody : TeaModel {
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

        [NameInMap("ProxyAccessList")]
        [Validation(Required=false)]
        public List<ListProxyAccessesResponseBodyProxyAccessList> ProxyAccessList { get; set; }
        public class ListProxyAccessesResponseBodyProxyAccessList : TeaModel {
            [NameInMap("ProxyAccessId")]
            [Validation(Required=false)]
            public long? ProxyAccessId { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }

            [NameInMap("OriginInfo")]
            [Validation(Required=false)]
            public string OriginInfo { get; set; }

            [NameInMap("IndepAccount")]
            [Validation(Required=false)]
            public string IndepAccount { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            [NameInMap("UserUid")]
            [Validation(Required=false)]
            public string UserUid { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("ProxyId")]
            [Validation(Required=false)]
            public long? ProxyId { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

        }

    }

}
