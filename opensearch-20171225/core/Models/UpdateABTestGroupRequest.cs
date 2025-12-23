// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class UpdateABTestGroupRequest : TeaModel {
        /// <summary>
        /// <para>The request body. For more information, see <a href="https://help.aliyun.com/document_detail/178935.html">ABTestGroup</a>.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public ABTestGroup Body { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs only a dry run. No endpoint is created. The system checks whether your AccessKey is valid, whether Resource Access Management (RAM) users are authorized, and whether the required parameters are set.</description></item>
        /// <item><description>false (default): creates an endpoint immediately.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
