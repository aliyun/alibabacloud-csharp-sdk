// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetFunctionInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the richness of returned information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>simple: displays only the basic information.</description></item>
        /// <item><description>normal: displays information such as createParameters and cron. This is the default value.</description></item>
        /// <item><description>detail: returns the details of the training task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>detail</para>
        /// </summary>
        [NameInMap("output")]
        [Validation(Required=false)]
        public string Output { get; set; }

    }

}
