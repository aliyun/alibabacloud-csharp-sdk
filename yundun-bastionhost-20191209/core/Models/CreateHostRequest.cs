// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class CreateHostRequest : TeaModel {
        /// <summary>
        /// <para>The endpoint type of the host that you want to create. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Public</b>: public endpoint</description></item>
        /// <item><description><b>Private</b>: internal endpoint</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("ActiveAddressType")]
        [Validation(Required=false)]
        public string ActiveAddressType { get; set; }

        /// <summary>
        /// <para>The description of the host that you want to create. The value can be up to 500 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Local Host</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The name of the host that you want to create. The name can be up to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>host01</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The internal endpoint of the host that you want to create. You can set this parameter to a domain name or an IP address.</para>
        /// <remarks>
        /// <para>This parameter is required if the <b>ActiveAddressType</b> parameter is set to <b>Private</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("HostPrivateAddress")]
        [Validation(Required=false)]
        public string HostPrivateAddress { get; set; }

        /// <summary>
        /// <para>The public endpoint of the host that you want to create. You can set this parameter to a domain name or an IP address.</para>
        /// <remarks>
        /// <para>This parameter is required if the <b>ActiveAddressType</b> parameter is set to <b>Public</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.XX.XX</para>
        /// </summary>
        [NameInMap("HostPublicAddress")]
        [Validation(Required=false)]
        public string HostPublicAddress { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host in which you want to create the host.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the ID of the bastion host.</para>
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
        /// <para>The ID of the region to which the ECS instance or the host in an ApsaraDB MyBase dedicated cluster belongs.</para>
        /// <remarks>
        /// <para>This parameter is required if the <b>Source</b> parameter is set to <b>Ecs</b> or <b>Rds</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("InstanceRegionId")]
        [Validation(Required=false)]
        public string InstanceRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the network domain to which the host to be imported belongs.</para>
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
        /// <para>The operating system of the host that you want to create. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Linux</b></description></item>
        /// <item><description><b>Windows</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Linux</para>
        /// </summary>
        [NameInMap("OSType")]
        [Validation(Required=false)]
        public string OSType { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host to which you want to import the host.</para>
        /// <remarks>
        /// <para>For information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The source of the host that you want to create. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Local</b>: a host in a data center</description></item>
        /// <item><description><b>Ecs</b>: an Elastic Compute Service (ECS) instance</description></item>
        /// <item><description><b>Rds</b>: a host in an ApsaraDB MyBase dedicated cluster</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Local</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The ID of the ECS instance or the host in an ApsaraDB MyBase dedicated cluster.</para>
        /// <remarks>
        /// <para>This parameter is required if the <b>Source</b> parameter is set to <b>Ecs</b> or <b>Rds</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>i-dfabfda</para>
        /// </summary>
        [NameInMap("SourceInstanceId")]
        [Validation(Required=false)]
        public string SourceInstanceId { get; set; }

    }

}
