// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListPatchBaselinesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The number of entries returned on each page.</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The patch baselines.</para>
        /// </summary>
        [NameInMap("PatchBaselines")]
        [Validation(Required=false)]
        public List<ListPatchBaselinesResponseBodyPatchBaselines> PatchBaselines { get; set; }
        public class ListPatchBaselinesResponseBodyPatchBaselines : TeaModel {
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
            /// <para>The user who created the patch baseline.</para>
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
            /// <para>2021-09-08T03:41:23Z</para>
            /// </summary>
            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }

            /// <summary>
            /// <para>The description of the patch baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ListPatchBaseline</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the patch baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pb-c2838b5d89b540e19ee6</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the patch baseline is set as the default patch baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

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
            /// <para>AliyunLinux</para>
            /// </summary>
            [NameInMap("OperationSystem")]
            [Validation(Required=false)]
            public string OperationSystem { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek256ia6vhsndy</para>
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
            /// <para>The configurations of patch sources.</para>
            /// </summary>
            [NameInMap("Sources")]
            [Validation(Required=false)]
            public List<string> Sources { get; set; }

            /// <summary>
            /// <para>The tags of the patch baseline.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListPatchBaselinesResponseBodyPatchBaselinesTags> Tags { get; set; }
            public class ListPatchBaselinesResponseBodyPatchBaselinesTags : TeaModel {
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
            /// <para>The user who last updated the patch baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root(130900000)</para>
            /// </summary>
            [NameInMap("UpdatedBy")]
            [Validation(Required=false)]
            public string UpdatedBy { get; set; }

            /// <summary>
            /// <para>The time when the patch baseline was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-08T03:44:34Z</para>
            /// </summary>
            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>432996A1-03C0-5C4C-A8E6-66C4110765B8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
