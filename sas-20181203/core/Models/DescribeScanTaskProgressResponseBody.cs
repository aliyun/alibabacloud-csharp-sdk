// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeScanTaskProgressResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
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
        /// <item><description><b>init</b>: The task is being initialized.</description></item>
        /// <item><description><b>Processing</b>: The task is running.</description></item>
        /// <item><description><b>Success</b>: The task is complete.</description></item>
        /// <item><description><b>Failed</b>: The task fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("ScanTaskProgress")]
        [Validation(Required=false)]
        public string ScanTaskProgress { get; set; }

        /// <summary>
        /// <para>The information about the asset on which the virus scan task runs. The value is a string that consists of JSON arrays. Each element in a JSON array is a JSON struct that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>type</b>: the type of the asset on which you want to perform a virus scan task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>groupId</b>: server group.</description></item>
        /// <item><description><b>uuid</b>: server.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>name</b>: the name of the server group or server.</para>
        /// </description></item>
        /// <item><description><para><b>target</b>: the asset on which the virus scan task runs. The value of this field varies based on the value of the type field.</para>
        /// <list type="bullet">
        /// <item><description>If the <b>type</b> field is set to <b>groupId</b>, the value of this field is the ID of the server group.</description></item>
        /// <item><description>If the <b>type</b> field is set to <b>uuid</b>, the value of this field is the universally unique identifier (UUID) of the server.</description></item>
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
