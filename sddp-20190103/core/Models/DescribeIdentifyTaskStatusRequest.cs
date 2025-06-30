// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeIdentifyTaskStatusRequest : TeaModel {
        /// <summary>
        /// <para>Task ID, obtained from the ID field in the response after calling CreateScanTask or ScanOssObjectV1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>268</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Language type for request and response messages, default is <b>zh_cn</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Chinese (Simplified)</description></item>
        /// <item><description><b>en_us</b>: English (United States)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
