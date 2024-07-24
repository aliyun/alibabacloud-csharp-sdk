// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetGrafanaWorkspaceRequest : TeaModel {
        /// <summary>
        /// The language. Valid values: zh and en. Default value: zh.
        /// </summary>
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// The ID of the workspace.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GrafanaWorkspaceId")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceId { get; set; }

        /// <summary>
        /// The region ID. Default value: cn-hangzhou.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
