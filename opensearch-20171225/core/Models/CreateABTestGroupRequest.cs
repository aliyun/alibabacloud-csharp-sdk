// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateABTestGroupRequest : TeaModel {
        /// <summary>
        /// <para>The request body. For more information, see <a href="https://help.aliyun.com/document_detail/178935.html">ABTestGroup</a>.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public ABTestGroup Body { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the validity of input parameters. Default value: false.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: checks only the validity of input parameters.</description></item>
        /// <item><description><b>false</b>: checks the validity of input parameters and creates an attribution configuration.</description></item>
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
