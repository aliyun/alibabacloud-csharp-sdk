// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class QueryOutboundJobDataRequest : TeaModel {
        /// <summary>
        /// 结束时间 yyyyMMddHHmmss
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        [NameInMap("SaasId")]
        [Validation(Required=false)]
        public string SaasId { get; set; }

        /// <summary>
        /// 开始时间 yyyyMMddHHmmss
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("UserProfile")]
        [Validation(Required=false)]
        public QueryOutboundJobDataRequestUserProfile UserProfile { get; set; }
        public class QueryOutboundJobDataRequestUserProfile : TeaModel {
            [NameInMap("AppCode")]
            [Validation(Required=false)]
            public string AppCode { get; set; }
            [NameInMap("BuId")]
            [Validation(Required=false)]
            public long? BuId { get; set; }
            [NameInMap("PlatformCode")]
            [Validation(Required=false)]
            public string PlatformCode { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }
            [NameInMap("UserNick")]
            [Validation(Required=false)]
            public string UserNick { get; set; }
        };

    }

}
