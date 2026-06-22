// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeScanTaskProgressResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique ID for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EA15BA8A-D631-4375-8D40-CB7C769B0279</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The progress of the virus scan task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>init</b>: The scan task is being initialized.</description></item>
        /// <item><description><b>Processing</b>: The scan task is in progress.</description></item>
        /// <item><description><b>Success</b>: The scan task is complete.</description></item>
        /// <item><description><b>Failed</b>: The scan task failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("ScanTaskProgress")]
        [Validation(Required=false)]
        public string ScanTaskProgress { get; set; }

        /// <summary>
        /// <para>The asset information scanned by the virus scan node. This parameter is a string converted from a JSON array in character format. The following fields are included:</para>
        /// <list type="bullet">
        /// <item><description><b>type</b>: The Asset Type on which the virus scan is executed. Valid values:<list type="bullet">
        /// <item><description><b>groupId</b>: server group.</description></item>
        /// <item><description><b>uuid</b>: server.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>name</b>: The name of the server group or server.</description></item>
        /// <item><description><b>target</b>: The asset on which the virus scan is executed. The following describes the values of this field:<list type="bullet">
        /// <item><description>If <b>type</b> is set to <b>groupId</b>, this field specifies the server group ID.</description></item>
        /// <item><description>If <b>type</b> is set to <b>uuid</b>, this field specifies the UUID of the server.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;type&quot;:&quot;uuid&quot;,&quot;name&quot;:&quot;host001&quot;,&quot;target&quot;:&quot;503201a7-14c6-4280-801b-1169ed42****&quot;}]</para>
        /// </summary>
        [NameInMap("TargetInfo")]
        [Validation(Required=false)]
        public string TargetInfo { get; set; }

    }

}
