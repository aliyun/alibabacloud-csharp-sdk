// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateStandardMappingRequest : TeaModel {
        /// <summary>
        /// <para>The create command.</para>
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
            /// <item><description>SET_INVALID_TO_VALID: sets invalid mappings to valid mappings.</description></item>
            /// <item><description>KEEP_INVALID_AND_SKIP: retains invalid mappings and skips them.</description></item>
            /// </list>
            /// <para>Default value: SET_INVALID_TO_VALID.</para>
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
            /// <item><description>VALID: valid mapping.</description></item>
            /// <item><description>INVALID: invalid mapping.</description></item>
            /// </list>
            /// <para>Default value: VALID.</para>
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

    }

}
