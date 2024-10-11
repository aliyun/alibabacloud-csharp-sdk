// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class CheckModifyConfigNeedRestartResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the cluster was restarted after you modified the configuration parameters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The cluster was restarted.</description></item>
        /// <item><description><b>false</b>: The cluster was not restarted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedRestart")]
        [Validation(Required=false)]
        public bool? NeedRestart { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06798FEE-BEF2-5FAF-A30D-728973BBE97C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
