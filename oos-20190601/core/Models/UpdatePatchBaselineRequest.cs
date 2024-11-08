// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class UpdatePatchBaselineRequest : TeaModel {
        /// <summary>
        /// <para>The rules of scanning and installing patches for the specified operating system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;PatchRules&quot;:[{&quot;PatchFilterGroup&quot;:[{&quot;Key&quot;:&quot;PatchSet&quot;,&quot;Values&quot;:[&quot;OS&quot;]},{&quot;Key&quot;:&quot;ProductFamily&quot;,&quot;Values&quot;:[&quot;Windows&quot;]},{&quot;Key&quot;:&quot;Product&quot;,&quot;Values&quot;:[&quot;Windows 10&quot;,&quot;Windows 7&quot;]},{&quot;Key&quot;:&quot;Classification&quot;,&quot;Values&quot;:[&quot;Security Updates&quot;,&quot;Updates&quot;,&quot;Update Rollups&quot;,&quot;Critical Updates&quot;]},{&quot;Key&quot;:&quot;Severity&quot;,&quot;Values&quot;:[&quot;Critical&quot;,&quot;Important&quot;,&quot;Moderate&quot;]}],&quot;ApproveAfterDays&quot;:7,&quot;ApproveUntilDate&quot;:&quot;&quot;,&quot;EnableNonSecurity&quot;:true,&quot;ComplianceLevel&quot;:&quot;Medium&quot;}]}</para>
        /// </summary>
        [NameInMap("ApprovalRules")]
        [Validation(Required=false)]
        public string ApprovalRules { get; set; }

        /// <summary>
        /// <para>The approved patches.</para>
        /// </summary>
        [NameInMap("ApprovedPatches")]
        [Validation(Required=false)]
        public List<string> ApprovedPatches { get; set; }

        /// <summary>
        /// <para>Indicates whether the approved patch involves updates other than security-related updates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ApprovedPatchesEnableNonSecurity")]
        [Validation(Required=false)]
        public bool? ApprovedPatchesEnableNonSecurity { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the patch baseline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UpdatePatchBaseline</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the patch baseline.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyPatchBaseline</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The rejected patches.</para>
        /// </summary>
        [NameInMap("RejectedPatches")]
        [Validation(Required=false)]
        public List<string> RejectedPatches { get; set; }

        /// <summary>
        /// <para>The action of the rejected patch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALLOW_AS_DEPENDENCY</para>
        /// </summary>
        [NameInMap("RejectedPatchesAction")]
        [Validation(Required=false)]
        public string RejectedPatchesAction { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxsn4m4******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The patch source configurations.</para>
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public List<string> Sources { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<UpdatePatchBaselineRequestTags> Tags { get; set; }
        public class UpdatePatchBaselineRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
