// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class UpdateLindormV2WhiteIpListRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call the GetLindormV2InstanceList operation to query the instance ID.</para>
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
        /// <para>The ID of the region where the instance resides. You can call the <a href="https://help.aliyun.com/document_detail/426062.html">DescribeRegions</a> operation to query the region ID.</para>
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
        /// <para>The list of whitelist groups.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WhiteIpGroupList")]
        [Validation(Required=false)]
        public List<UpdateLindormV2WhiteIpListRequestWhiteIpGroupList> WhiteIpGroupList { get; set; }
        public class UpdateLindormV2WhiteIpListRequestWhiteIpGroupList : TeaModel {
            /// <summary>
            /// <para>The name of the whitelist group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user001</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The IP addresses to be added to the whitelist.</para>
            /// <remarks>
            /// <para>127.0.0.1 indicates that access from all IP addresses is denied. For example, 192.168.0.0/24 indicates that access from all IP addresses in the 192.168.0.X CIDR block is allowed to the Lindorm instance. Separate multiple IP addresses with commas (,).</para>
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
