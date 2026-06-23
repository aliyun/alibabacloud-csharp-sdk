// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class CreateHostRequest : TeaModel {
        /// <summary>
        /// <para>The address type of the host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Public</b>: a public address</para>
        /// </description></item>
        /// <item><description><para><b>Private</b>: a private address</para>
        /// </description></item>
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
        /// <para>The comment for the host. The comment can be up to 500 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Local Host</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The name of the host. The name can be up to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>host01</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The private address of the host. You can use a domain name or an IP address.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>ActiveAddressType</b> is set to <b>Private</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("HostPrivateAddress")]
        [Validation(Required=false)]
        public string HostPrivateAddress { get; set; }

        /// <summary>
        /// <para>The public address of the host. You can use a domain name or an IP address.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>ActiveAddressType</b> is set to <b>Public</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.XX.XX</para>
        /// </summary>
        [NameInMap("HostPublicAddress")]
        [Validation(Required=false)]
        public string HostPublicAddress { get; set; }

        /// <summary>
        /// <para>The ID of the Bastionhost instance where you want to create the host.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain this parameter.</para>
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
        /// <para>The ID of the Alibaba Cloud account to which the ECS instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1605494xxxx</para>
        /// </summary>
        [NameInMap("InstanceMemberId")]
        [Validation(Required=false)]
        public long? InstanceMemberId { get; set; }

        /// <summary>
        /// <para>The region ID of the ECS instance or the host in the dedicated cluster.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>Source</b> is set to <b>Ecs</b> or <b>Rds</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("InstanceRegionId")]
        [Validation(Required=false)]
        public string InstanceRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the network domain to which the host belongs.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2758827.html">ListNetworkDomains </a>operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NetworkDomainId")]
        [Validation(Required=false)]
        public string NetworkDomainId { get; set; }

        /// <summary>
        /// <para>The operating system of the host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Linux</b></para>
        /// </description></item>
        /// <item><description><para><b>Windows</b></para>
        /// </description></item>
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
        /// <para>The region ID of the Bastionhost instance where you want to create the host.</para>
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

        /// <summary>
        /// <para>The source of the host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Local</b>: a local host</para>
        /// </description></item>
        /// <item><description><para><b>Ecs</b>: an ECS instance</para>
        /// </description></item>
        /// <item><description><para><b>Rds</b>: a host in an ApsaraDB RDS dedicated cluster</para>
        /// </description></item>
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
        /// <para>The ID of the ECS instance or the host in the dedicated cluster.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>Source</b> is set to <b>Ecs</b> or <b>Rds</b>.</para>
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
