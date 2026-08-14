// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class UpdateLindormV2WhiteIpListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance. You can call the GetLindormV2InstanceList operation to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-2ze5ipz9zx1e4****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance is located. You can call the <a href="https://help.aliyun.com/document_detail/426062.html">DescribeRegions</a> operation to obtain this ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The list of IP whitelist groups.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WhiteIpGroupList")]
        [Validation(Required=false)]
        public List<UpdateLindormV2WhiteIpListRequestWhiteIpGroupList> WhiteIpGroupList { get; set; }
        public class UpdateLindormV2WhiteIpListRequestWhiteIpGroupList : TeaModel {
            /// <summary>
            /// <para>The name of the IP whitelist group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user001</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The IP addresses to add to the IP whitelist.</para>
            /// <remarks>
            /// <para>The value 127.0.0.1 denies access from all IP addresses. For example, 192.168.0.0/24 allows all IP addresses in that range to access the Lindorm instance. Use a comma (,) to separate multiple IP addresses or CIDR blocks.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.X/24</para>
            /// </summary>
            [NameInMap("WhiteIpList")]
            [Validation(Required=false)]
            public string WhiteIpList { get; set; }

        }

    }

}
