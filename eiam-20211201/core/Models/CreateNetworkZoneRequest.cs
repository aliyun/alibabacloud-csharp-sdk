// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateNetworkZoneRequest : TeaModel {
        /// <summary>
        /// <para>保证请求幂等性。从您的客户端生成一个参数值，确保不同请求间该参数值唯一。ClientToken只支持ASCII字符，且不能超过64个字符。</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>网络区域描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试描述</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>IDaaS EIAM实例的ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>网络区域ipv4Cidr</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("Ipv4Cidrs")]
        [Validation(Required=false)]
        public List<string> Ipv4Cidrs { get; set; }

        /// <summary>
        /// <para>网络区域ipv6Cidr</para>
        /// 
        /// <b>Example:</b>
        /// <para>::/0</para>
        /// </summary>
        [NameInMap("Ipv6Cidrs")]
        [Validation(Required=false)]
        public List<string> Ipv6Cidrs { get; set; }

        /// <summary>
        /// <para>网络区域名称</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPV4Test</para>
        /// </summary>
        [NameInMap("NetworkZoneName")]
        [Validation(Required=false)]
        public string NetworkZoneName { get; set; }

        /// <summary>
        /// <para>网络区域类型</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arn:alibaba:idaas:network:zone:classic</para>
        /// </summary>
        [NameInMap("NetworkZoneType")]
        [Validation(Required=false)]
        public string NetworkZoneType { get; set; }

        /// <summary>
        /// <para>专有网络VpcId</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc_xxxxx</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
