// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateStandardMappingRequest : TeaModel {
        /// <summary>
        /// <para>The creation command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateStandardMappingRequestCreateCommand CreateCommand { get; set; }
        public class CreateStandardMappingRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The list of asset GUIDs.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("AssetGuidList")]
            [Validation(Required=false)]
            public List<string> AssetGuidList { get; set; }

            /// <summary>
            /// <para>The processing policy for invalid mappings when importing mapping relationships. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SET_INVALID_TO_VALID: Changes invalid mappings to valid mappings.</description></item>
            /// <item><description>KEEP_INVALID_AND_SKIP: Retains invalid mappings and skips them.
            /// Default value: SET_INVALID_TO_VALID.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SET_INVALID_TO_VALID</para>
            /// </summary>
            [NameInMap("InvalidMappingRelationOperationType")]
            [Validation(Required=false)]
            public string InvalidMappingRelationOperationType { get; set; }

            /// <summary>
            /// <para>The mapping relationship type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>VALID: Valid mapping.</description></item>
            /// <item><description>INVALID: Invalid mapping.
            /// Default value: VALID.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VALID</para>
            /// </summary>
            [NameInMap("RelationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

            /// <summary>
            /// <para>The standard ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StandardId")]
            [Validation(Required=false)]
            public long? StandardId { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
