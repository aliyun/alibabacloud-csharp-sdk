// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateGreyTagRouteRequest : TeaModel {
        /// <summary>
        /// 应用ID
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

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
        /// 规则名称
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// SpringCloud规则
        /// </summary>
        [NameInMap("ScRules")]
        [Validation(Required=false)]
        public string ScRules { get; set; }

    }

}
