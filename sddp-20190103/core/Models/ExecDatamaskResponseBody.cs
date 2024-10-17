// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ExecDatamaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The de-identified data, which is described in a JSON string. The JSON string contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><b>dataHeaderList</b>: the names of columns that contain the de-identified data.</description></item>
        /// <item><description><b>dataList</b>: the de-identified data. The column order of the de-identified data is the same as that indicated by the dataHeaderList parameter.</description></item>
        /// <item><description><b>ruleList</b>: the IDs of sensitive data detection rules.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dataHeaderList&quot;:[&quot;name&quot;,&quot;age&quot;],&quot;dataList&quot;:[[&quot;l***&quot;,18],[&quot;l***&quot;,17]],&quot;ruleList&quot;:[1002,null]}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>813BA9FA-D062-42C4-8CD5-11A7640B96E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
