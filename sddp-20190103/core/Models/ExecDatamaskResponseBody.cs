// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ExecDatamaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The data after it is masked. The data is a string in JSON format and includes the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>dataHeaderList</b>: The column names of the masked data.</para>
        /// </description></item>
        /// <item><description><para><b>dataList</b>: The masked data. The order of the fields corresponds to the order of the column names.</para>
        /// </description></item>
        /// <item><description><para><b>ruleList</b>: The sensitive data type IDs. Each ID corresponds to the unique ID of a sensitive data type that is returned by the <a href="https://help.aliyun.com/document_detail/410141.html">DescribeRules</a> operation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dataHeaderList&quot;:[&quot;name&quot;,&quot;age&quot;],&quot;dataList&quot;:[[&quot;l***&quot;,18],[&quot;l***&quot;,17]],&quot;ruleList&quot;:[1002,null]}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique ID for each request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>813BA9FA-D062-42C4-8CD5-11A7640B96E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
