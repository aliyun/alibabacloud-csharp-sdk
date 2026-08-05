// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class GetFunctionInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Controls the richness of the returned information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>simple: displays only basic information.</description></item>
        /// <item><description>normal: displays information such as createParameters and cron. This is the default value.</description></item>
        /// <item><description>detail: returns training task information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("output")]
        [Validation(Required=false)]
        public string Output { get; set; }

    }

}
