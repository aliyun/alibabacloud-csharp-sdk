// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpcPrefixListRequest : TeaModel {
        /// <summary>
        /// <para>The information about CIDR blocks to be added to the prefix list.</para>
        /// </summary>
        [NameInMap("AddPrefixListEntry")]
        [Validation(Required=false)]
        public List<ModifyVpcPrefixListRequestAddPrefixListEntry> AddPrefixListEntry { get; set; }
        public class ModifyVpcPrefixListRequestAddPrefixListEntry : TeaModel {
            /// <summary>
            /// <para>The CIDR block to be added to the prefix list.</para>
            /// <remarks>
            /// <para> If the CIDR block already exists in the prefix list, you can only modify the description of the CIDR block by setting the <b>AddPrefixListEntry.N.Description</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.0.0/12</para>
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            /// <summary>
            /// <para>The description of the CIDR block to be added to the prefix list.</para>
            /// <para>The description must be 1 to 128 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system uses <b>RequestId</b> as <b>ClientToken</b>. <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: checks the request without performing the operation. The system prechecks the required parameters, request syntax, and limits. If the request fails the precheck, an error message is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends the request. If the request passes the check, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The maximum number of CIDR blocks supported by the prefix list after the configuration of the prefix list is modified.</para>
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
        /// <para>The description must be 1 to 256 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>newdescription</para>
        /// </summary>
        [NameInMap("PrefixListDescription")]
        [Validation(Required=false)]
        public string PrefixListDescription { get; set; }

        /// <summary>
        /// <para>The ID of the prefix list.</para>
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
        /// <para>The name must be 1 to 128 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>newname</para>
        /// </summary>
        [NameInMap("PrefixListName")]
        [Validation(Required=false)]
        public string PrefixListName { get; set; }

        /// <summary>
        /// <para>The region ID of the prefix list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The information about CIDR blocks to be deleted to the prefix list.</para>
        /// </summary>
        [NameInMap("RemovePrefixListEntry")]
        [Validation(Required=false)]
        public List<ModifyVpcPrefixListRequestRemovePrefixListEntry> RemovePrefixListEntry { get; set; }
        public class ModifyVpcPrefixListRequestRemovePrefixListEntry : TeaModel {
            /// <summary>
            /// <para>The CIDR block that you want to delete from the prefix list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.0/16</para>
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            /// <summary>
            /// <para>The description of the CIDR block that you want to delete.</para>
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
