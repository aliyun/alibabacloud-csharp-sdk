// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpcPrefixListRequest : TeaModel {
        /// <summary>
        /// <para>The list of Classless Inter-Domain Routing blocks to add to the prefix list instance.</para>
        /// </summary>
        [NameInMap("AddPrefixListEntry")]
        [Validation(Required=false)]
        public List<ModifyVpcPrefixListRequestAddPrefixListEntry> AddPrefixListEntry { get; set; }
        public class ModifyVpcPrefixListRequestAddPrefixListEntry : TeaModel {
            /// <summary>
            /// <para>The Classless Inter-Domain Routing block to add to the prefix list instance.</para>
            /// <remarks>
            /// <para>If the Classless Inter-Domain Routing block already exists in the prefix list, only the value of <b>AddPrefixListEntry.N.Description</b> is modified, which means only the description of the Classless Inter-Domain Routing block is updated.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.0.0/12</para>
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            /// <summary>
            /// <para>The description of the Classless Inter-Domain Routing block to add to the prefix list instance.</para>
            /// <para>The description must be 1 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>newcidr</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may differ for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run without modifying the prefix list configuration. The system checks the required parameters, request format, and service limits. If the check fails, the corresponding error is returned. If the check succeeds, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request. If the check succeeds, an HTTP 2xx status code is returned and the prefix list configuration is modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The new maximum number of Classless Inter-Domain Routing block entries in the prefix list instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxEntries")]
        [Validation(Required=false)]
        public int? MaxEntries { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The new description of the prefix list.</para>
        /// <para>The description must be 1 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>newdescription</para>
        /// </summary>
        [NameInMap("PrefixListDescription")]
        [Validation(Required=false)]
        public string PrefixListDescription { get; set; }

        /// <summary>
        /// <para>The instance ID of the prefix list that you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-0b7hwu67****</para>
        /// </summary>
        [NameInMap("PrefixListId")]
        [Validation(Required=false)]
        public string PrefixListId { get; set; }

        /// <summary>
        /// <para>The new name of the prefix list.</para>
        /// <para>The name must be 1 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>newname</para>
        /// </summary>
        [NameInMap("PrefixListName")]
        [Validation(Required=false)]
        public string PrefixListName { get; set; }

        /// <summary>
        /// <para>The region ID of the prefix list that you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of Classless Inter-Domain Routing blocks to delete from the prefix list instance.</para>
        /// </summary>
        [NameInMap("RemovePrefixListEntry")]
        [Validation(Required=false)]
        public List<ModifyVpcPrefixListRequestRemovePrefixListEntry> RemovePrefixListEntry { get; set; }
        public class ModifyVpcPrefixListRequestRemovePrefixListEntry : TeaModel {
            /// <summary>
            /// <para>The Classless Inter-Domain Routing block to delete from the prefix list instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.0/16</para>
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            /// <summary>
            /// <para>The description of the Classless Inter-Domain Routing block to delete from the prefix list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cidr</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
