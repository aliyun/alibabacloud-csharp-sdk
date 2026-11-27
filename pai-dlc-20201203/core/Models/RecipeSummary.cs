// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RecipeSummary : TeaModel {
        /// <summary>
        /// <para>The list of algorithm labels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;grpo&quot;]</para>
        /// </summary>
        [NameInMap("AlgorithmLabel")]
        [Validation(Required=false)]
        public List<string> AlgorithmLabel { get; set; }

        /// <summary>
        /// <para>The user ID of the creator. This field is used for auditing and Owner=mine filtering, and is not used as a basis for permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The recipe description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GRPO training recipe for Qwen2.5-7B-Instruct</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The creation time in UTC RFC 3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-08T07:00:00Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The modification time in UTC RFC 3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-08T09:30:00Z</para>
        /// </summary>
        [NameInMap("GmtModifyTime")]
        [Validation(Required=false)]
        public string GmtModifyTime { get; set; }

        /// <summary>
        /// <para>The default recipe indicator for the model. The list can return both the default recipe for the current workspace and the public official default recipe. Job parsing prioritizes the default recipe of the current workspace and falls back to the public official default if no match is found. All read operations still require RAM authentication in the current workspace. Other records with empty workspaces are not exposed simply because they have the default indicator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDefaultRecipe")]
        [Validation(Required=false)]
        public bool? IsDefaultRecipe { get; set; }

        /// <summary>
        /// <para>The name of the associated model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The recipe name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-grpo</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The owner type derived from the source. A value of preset maps to platform, and custom maps to user. A recipe is considered a public official preset only when Source is preset, OwnerType is platform, and the persistent WorkspaceId is empty. The presence of OwnerType or an empty workspace alone is not sufficient to expose the record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("OwnerType")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        /// <summary>
        /// <para>The recipe ID. This field is always returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>recipe-20260908-qwen-grpo</para>
        /// </summary>
        [NameInMap("RecipeId")]
        [Validation(Required=false)]
        public string RecipeId { get; set; }

        /// <summary>
        /// <para>The list of recipe types. Valid values: train and eval. A value of [&quot;train&quot;] indicates training, [&quot;eval&quot;] indicates independent evaluation, and [&quot;train&quot;,&quot;eval&quot;] indicates both.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;train&quot;]</para>
        /// </summary>
        [NameInMap("RecipeType")]
        [Validation(Required=false)]
        public List<string> RecipeType { get; set; }

        /// <summary>
        /// <para>The source of the recipe. Valid values: preset (platform preset) and custom (user-created).</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The persistent workspace to which the recipe belongs. Returns the actual workspace ID for custom recipes and an empty string for public official preset recipes. A public official preset recipe must simultaneously meet the following conditions: Source is preset, OwnerType is platform, and WorkspaceId is empty. Other records with empty workspaces are not exposed. Access to official items requires the RAM permissions of the current request workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-20210126170216-mtl37ge7gkvdz</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
