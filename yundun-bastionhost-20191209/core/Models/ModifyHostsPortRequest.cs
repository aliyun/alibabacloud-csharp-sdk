// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyHostsPortRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the host for which you want to change the port. The value is a JSON string. You can add up to 100 host IDs. If you specify multiple IDs, separate the IDs with commas (,).</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/200665.html">ListHosts</a> operation to query the IDs of hosts.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;1&quot;,&quot;2&quot;,&quot;3&quot;]</para>
        /// </summary>
        [NameInMap("HostIds")]
        [Validation(Required=false)]
        public string HostIds { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host for which you want to change the port of the host.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the ID of the bastion host.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-st220aw****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The new port of the host. The port number must be an integer. Valid values: 22 to 65535.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The protocol that is used to connect to the host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SSH</b></description></item>
        /// <item><description><b>RDP</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SSH</para>
        /// </summary>
        [NameInMap("ProtocolName")]
        [Validation(Required=false)]
        public string ProtocolName { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host for which you want to change the port of the host.</para>
        /// <remarks>
        /// <para> For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
