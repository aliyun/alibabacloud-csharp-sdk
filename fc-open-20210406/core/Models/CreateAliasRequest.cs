// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class CreateAliasRequest : TeaModel {
        /// <summary>
        /// 额外版本权重
        /// </summary>
        [NameInMap("additionalVersionWeight")]
        [Validation(Required=false)]
        public Dictionary<string, float?> AdditionalVersionWeight { get; set; }

        /// <summary>
        /// 别名名称
        /// </summary>
        [NameInMap("aliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// 别名描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 版本ID
        /// </summary>
        [NameInMap("versionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
