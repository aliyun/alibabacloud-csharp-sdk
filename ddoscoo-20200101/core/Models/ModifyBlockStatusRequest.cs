// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyBlockStatusRequest : TeaModel {
        /// <summary>
        /// <para>The blocking period. Valid values: <b>15</b> to <b>43200</b>. Unit: minutes.</para>
        /// <remarks>
        /// <para>If you set <b>Status</b> to <b>do</b>, you must also specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The ID of the Anti-DDoS Proxy (Chinese Mainland) instance to manage.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/157459.html">DescribeInstanceIds</a> operation to query the IDs of all Anti-DDoS Proxy instances.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-mp91j1ao****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>An array consisting of the Internet service provider (ISP) lines from which traffic is blocked.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ct</para>
        /// </summary>
        [NameInMap("Lines")]
        [Validation(Required=false)]
        public List<string> Lines { get; set; }

        /// <summary>
        /// <para>Specifies the status of the Diversion from Origin Server policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>do</b>: enables the policy.</description></item>
        /// <item><description><b>undo</b>: disables the policy.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>do</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
