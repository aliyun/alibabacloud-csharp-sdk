// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreatePatchBaselineResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the patch baseline.</para>
        /// </summary>
        [NameInMap("PatchBaseline")]
        [Validation(Required=false)]
        public CreatePatchBaselineResponseBodyPatchBaseline PatchBaseline { get; set; }
        public class CreatePatchBaselineResponseBodyPatchBaseline : TeaModel {
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
            /// <para>The creator of the patch baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root(130900000)</para>
            /// </summary>
            [NameInMap("CreatedBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// <para>The time when the patch baseline was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-08T06:25:41Z</para>
            /// </summary>
            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }

            /// <summary>
            /// <para>The description of the patch baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PatchBaseline</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the patch baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pb-0a0aeda72ed147eb97ea</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the patch baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyPatchBaseline</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the operating system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OperationSystem")]
            [Validation(Required=false)]
            public string OperationSystem { get; set; }

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
            /// <para>&quot;ALLOW_AS_DEPENDENCY&quot;</para>
            /// </summary>
            [NameInMap("RejectedPatchesAction")]
            [Validation(Required=false)]
            public string RejectedPatchesAction { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfm3comlufxpva</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The share type of the patch baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Private</para>
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

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
            public List<CreatePatchBaselineResponseBodyPatchBaselineTags> Tags { get; set; }
            public class CreatePatchBaselineResponseBodyPatchBaselineTags : TeaModel {
                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The Alibaba Cloud account that last modified the information about the patch baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root(130900000)</para>
            /// </summary>
            [NameInMap("UpdatedBy")]
            [Validation(Required=false)]
            public string UpdatedBy { get; set; }

            /// <summary>
            /// <para>The time when the information about the patch baseline was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-08T06:25:41Z</para>
            /// </summary>
            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5173FF6-D10D-5E8C-8F71-943C2A3E25C0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
