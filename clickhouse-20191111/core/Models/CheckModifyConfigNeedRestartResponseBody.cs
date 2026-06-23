// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class CheckModifyConfigNeedRestartResponseBody : TeaModel {
        /// <summary>
        /// <para>变更配置参数后是否重启。取值说明：</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>：重启。</para>
        /// </description></item>
        /// <item><description><para><b>false</b>：不重启。</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedRestart")]
        [Validation(Required=false)]
        public bool? NeedRestart { get; set; }

        /// <summary>
        /// <para>请求 ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>06798FEE-BEF2-5FAF-A30D-728973BBE97C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
