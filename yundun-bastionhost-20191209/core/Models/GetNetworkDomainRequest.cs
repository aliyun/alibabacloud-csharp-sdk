// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetNetworkDomainRequest : TeaModel {
        /// <summary>
        /// <para>The bastion host ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances </a>operation to query the bastion host ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-i7m2btk6g48</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the network domain to query.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2758827.html">ListNetworkDomains </a>operation to query the network domain ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("NetworkDomainId")]
        [Validation(Required=false)]
        public string NetworkDomainId { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host.</para>
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
