// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyHostRequest : TeaModel {
        /// <summary>
        /// <para>The new description of the host. The description can be up to 500 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Host for test.</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The ID of the host to be updated.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/200665.html">ListHosts</a> operation to query the host ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// <para>The new name of the host. The name can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestHost</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The new private network address of the host. You can specify a domain name or an IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>193.168.XX.XX</para>
        /// </summary>
        [NameInMap("HostPrivateAddress")]
        [Validation(Required=false)]
        public string HostPrivateAddress { get; set; }

        /// <summary>
        /// <para>The new public address of the host. You can specify a domain name or an IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200.1.XX.XX</para>
        /// </summary>
        [NameInMap("HostPublicAddress")]
        [Validation(Required=false)]
        public string HostPublicAddress { get; set; }

        /// <summary>
        /// <para>The ID of the Bastionhost instance to which the host belongs.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the instance ID.</para>
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
        /// <para>The ID of the network domain to which the host belongs.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2758827.html">ListNetworkDomains</a> operation to query the network domain ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NetworkDomainId")]
        [Validation(Required=false)]
        public string NetworkDomainId { get; set; }

        /// <summary>
        /// <para>The new operating system type of the host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Linux</b></description></item>
        /// <item><description><b>Windows</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Linux</para>
        /// </summary>
        [NameInMap("OSType")]
        [Validation(Required=false)]
        public string OSType { get; set; }

        /// <summary>
        /// <para>The preferred key exchange algorithm for the host. You can modify this parameter only when the OSType parameter is set to Linux. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>default</b>: Default mode.</description></item>
        /// <item><description><b>diffie-hellman-group1-sha1</b>: Compatibility mode for the diffie-hellman-group1-sha1 algorithm.</description></item>
        /// <item><description><b>diffie-hellman-group14-sha1</b>: Compatibility mode for the diffie-hellman-group14-sha1 algorithm.</description></item>
        /// <item><description><b>diffie-hellman-group-exchange-sha1</b>: Compatibility mode for the diffie-hellman-group-exchange-sha1 algorithm.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("PrefKex")]
        [Validation(Required=false)]
        public string PrefKex { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The region ID of the Bastionhost instance to which the host belongs.</para>
        /// <remarks>
        /// <para>For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
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
