// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class ListAppsRequest : TeaModel {
        /// <summary>
        /// 集成方式：- 一体化SDK：paasSDK - 样板间：standardRoom
        /// </summary>
        [NameInMap("IntegrationMode")]
        [Validation(Required=false)]
        public string IntegrationMode { get; set; }

        /// <summary>
        /// 查询页码，参数为空默认查询第1页。
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 每页显示个数，参数为空默认显示个数为10。
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 应用状态
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
