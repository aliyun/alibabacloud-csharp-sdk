// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateGreyTagRouteRequest : TeaModel {
        /// <summary>
        /// 规则名称
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Dubbo规则
        /// </summary>
        [NameInMap("DubboRules")]
        [Validation(Required=false)]
        public string DubboRules { get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [NameInMap("GreyTagRouteId")]
        [Validation(Required=false)]
        public long? GreyTagRouteId { get; set; }

        /// <summary>
        /// SpringCloud规则
        /// </summary>
        [NameInMap("ScRules")]
        [Validation(Required=false)]
        public string ScRules { get; set; }

    }

}
