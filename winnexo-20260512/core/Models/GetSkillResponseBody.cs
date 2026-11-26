// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetSkillResponseBody : TeaModel {
        /// <summary>
        /// <para>The simplified parameter schema that describes the required arguments for runSkill.arguments. This is automatically extracted from inputConfigFormatted.</para>
        /// </summary>
        [NameInMap("arguments")]
        [Validation(Required=false)]
        public List<GetSkillResponseBodyArguments> Arguments { get; set; }
        public class GetSkillResponseBodyArguments : TeaModel {
            /// <summary>
            /// <para>The default value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("default")]
            [Validation(Required=false)]
            public string Default { get; set; }

            /// <summary>
            /// <para>The parameter description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of valid values when options are limited.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;123&quot;]</para>
            /// </summary>
            [NameInMap("enum")]
            [Validation(Required=false)]
            public List<string> Enum { get; set; }

            /// <summary>
            /// <para>The parameter name, which corresponds to the key in runSkill.arguments.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SampleName.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether the parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            /// <summary>
            /// <para>The parameter type. Valid values: string, number, boolean, and array.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The creation time in ISO8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-10-01T12:00:00Z</para>
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The description of the skill, resolved by i18n.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The detailed logic of the skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("detailLogic")]
        [Validation(Required=false)]
        public string DetailLogic { get; set; }

        /// <summary>
        /// <para>The display name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The execution mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("executeMode")]
        [Validation(Required=false)]
        public string ExecuteMode { get; set; }

        /// <summary>
        /// <para>Indicates whether the skill is globally accessible.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("globalAccess")]
        [Validation(Required=false)]
        public bool? GlobalAccess { get; set; }

        /// <summary>
        /// <para>Indicates whether there are unpublished draft changes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasDraftChanges")]
        [Validation(Required=false)]
        public bool? HasDraftChanges { get; set; }

        /// <summary>
        /// <para>The raw text of the input parameter configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("inputConfig")]
        [Validation(Required=false)]
        public string InputConfig { get; set; }

        /// <summary>
        /// <para>The array of the structured input parameter schema.</para>
        /// </summary>
        [NameInMap("inputConfigFormatted")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> InputConfigFormatted { get; set; }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The name of the skill, resolved by i18n.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleName.pdf</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The globally unique code of the skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("skillCode")]
        [Validation(Required=false)]
        public string SkillCode { get; set; }

        /// <summary>
        /// <para>The nested tree of skill files. This is returned only when includeSkillFiles is set to true.</para>
        /// </summary>
        [NameInMap("skillFiles")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> SkillFiles { get; set; }

        /// <summary>
        /// <para>The ID of the skill definition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("skillHubDefinitionId")]
        [Validation(Required=false)]
        public long? SkillHubDefinitionId { get; set; }

        /// <summary>
        /// <para>The summary of SKILL.md, generated by an LLM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("skillMdSummary")]
        [Validation(Required=false)]
        public string SkillMdSummary { get; set; }

        /// <summary>
        /// <para>The source type. Valid values: BUILTIN and CUSTOM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The status of the skill. Valid values: ACTIVE and DRAFT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>READY</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of tags, resolved by i18n.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;[{\&quot;value\&quot;:\&quot;dataworks#0#1#33935#176145#T3_26059405665#94046932754\&quot;,\&quot;key\&quot;:\&quot;dataworksTag\&quot;}]&quot;]</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// <para>The update time in ISO8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-10-01T12:00:00Z</para>
        /// </summary>
        [NameInMap("updatedTime")]
        [Validation(Required=false)]
        public string UpdatedTime { get; set; }

        /// <summary>
        /// <para>The total number of versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("versionCount")]
        [Validation(Required=false)]
        public long? VersionCount { get; set; }

        /// <summary>
        /// <para>The version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("versionNumber")]
        [Validation(Required=false)]
        public string VersionNumber { get; set; }

    }

}
