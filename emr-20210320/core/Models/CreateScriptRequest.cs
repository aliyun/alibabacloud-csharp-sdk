// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class CreateScriptRequest : TeaModel {
        /// <summary>
        /// 集群ID。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 区域ID。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// 集群脚本类型。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScriptType")]
        [Validation(Required=false)]
        public string ScriptType { get; set; }

        /// <summary>
        /// 集群脚本列表。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Scripts")]
        [Validation(Required=false)]
        public List<Script> Scripts { get; set; }

    }

}
