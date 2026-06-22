// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeLatestScanTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The timestamp of the most recent scan, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1671610264000</para>
        /// </summary>
        [NameInMap("LastCheckTime")]
        [Validation(Required=false)]
        public long? LastCheckTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E0618A9-D5EF-4220-9471-C42XXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of virus risks detected on the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskNum")]
        [Validation(Required=false)]
        public int? RiskNum { get; set; }

        /// <summary>
        /// <para>The asset information scanned by the virus scan node. This parameter is expressed as a character string converted from a JSON array. The following fields are included:</para>
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
        /// <para>[{&quot;type&quot;:&quot;uuid&quot;,&quot;name&quot;:&quot;Host001&quot;,&quot;target&quot;:&quot;503201a7-14c6-4280-801b-1169ed42****&quot;}]</para>
        /// </summary>
        [NameInMap("TargetInfo")]
        [Validation(Required=false)]
        public string TargetInfo { get; set; }

        /// <summary>
        /// <para>The list of UUIDs of the assets.</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public List<string> Uuids { get; set; }

    }

}
