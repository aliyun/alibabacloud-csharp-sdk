// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListRouteRulesRequest : TeaModel {
        /// <summary>
        /// 规则名称
        /// </summary>
        [NameInMap("ruleName")]
        [Validation(Required=false)]
        public byte[] RuleName { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [NameInMap("serviceName")]
        [Validation(Required=false)]
        public byte[] ServiceName { get; set; }

        /// <summary>
        /// 第几页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 页的大小
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 幂等号
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
