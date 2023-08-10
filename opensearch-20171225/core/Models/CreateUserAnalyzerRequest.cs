// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateUserAnalyzerRequest : TeaModel {
        /// <summary>
        /// 基础分词器
        /// </summary>
        [NameInMap("business")]
        [Validation(Required=false)]
        public string Business { get; set; }

        [NameInMap("businessAppGroupId")]
        [Validation(Required=false)]
        public string BusinessAppGroupId { get; set; }

        /// <summary>
        /// 基础分词器类型 (AUTO, MODEL, SYSTEM, USER)
        /// </summary>
        [NameInMap("businessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 引擎类型 (HA3, ES)
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
