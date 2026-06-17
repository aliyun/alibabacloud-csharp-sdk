// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateNetworkChannelRequest : TeaModel {
        /// <summary>
        /// <para>The name of the network channel. The name must consist of lowercase letters, digits, and underscores (_). It must start and end with a letter or a digit. The name can be up to 64 characters long.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ch4</para>
        /// </summary>
        [NameInMap("ChannelName")]
        [Validation(Required=false)]
        public string ChannelName { get; set; }

        /// <summary>
        /// <para>A client token that ensures the request is idempotent. The client generates this token. The token must be unique for each request. It is case-sensitive and can be up to 64 ASCII characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f5********************</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of the source instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-*****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The notes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Notes")]
        [Validation(Required=false)]
        public string Notes { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-re*********</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The name of the destination instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-*****************</para>
        /// </summary>
        [NameInMap("TargetDBClusterId")]
        [Validation(Required=false)]
        public string TargetDBClusterId { get; set; }

        /// <summary>
        /// <para>The IP address of the destination instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.<b>.</b>.46</para>
        /// </summary>
        [NameInMap("TargetIp")]
        [Validation(Required=false)]
        public string TargetIp { get; set; }

        /// <summary>
        /// <para>The port of the destination instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9032</para>
        /// </summary>
        [NameInMap("TargetPort")]
        [Validation(Required=false)]
        public string TargetPort { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) where the endpoint is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-25cdvfeq58pl****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
