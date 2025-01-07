// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeLatestScanTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The timestamp when the last check was performed. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1671610264000</para>
        /// </summary>
        [NameInMap("LastCheckTime")]
        [Validation(Required=false)]
        public long? LastCheckTime { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E0618A9-D5EF-4220-9471-C42XXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of virus detection risks on the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskNum")]
        [Validation(Required=false)]
        public int? RiskNum { get; set; }

        /// <summary>
        /// <para>The applicable scope of the whitelist. The value of this parameter is in the JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>type</b>: the type of the applicable scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>GroupId</b>: the ID of a server group</description></item>
        /// <item><description><b>Uuid</b>: the UUID of a server</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>uuids</b>: the UUIDs of servers</para>
        /// </description></item>
        /// <item><description><para><b>groupIds</b>: the IDs of server groups</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> If you leave this parameter empty, all servers are added to the whitelist. If you set the <b>type</b> field to <b>GroupId</b>, you must also specify the <b>groupIds</b> field. If you set the <b>type</b> field to <b>Uuid</b>, you must also specify the <b>uuids</b> field.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;type&quot;:&quot;uuid&quot;,&quot;name&quot;:&quot;Host001&quot;,&quot;target&quot;:&quot;503201a7-14c6-4280-801b-1169ed42****&quot;}]</para>
        /// </summary>
        [NameInMap("TargetInfo")]
        [Validation(Required=false)]
        public string TargetInfo { get; set; }

        /// <summary>
        /// <para>The UUIDs of the assets.</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public List<string> Uuids { get; set; }

    }

}
