// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateStandardMappingToInvalidRequest : TeaModel {
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
        /// <para>The operator user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The update instruction.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateStandardMappingToInvalidRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateStandardMappingToInvalidRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para>The list of parent GUIDs. The maximum number of items is 1,000.</para>
            /// </summary>
            [NameInMap("BelongGuidList")]
            [Validation(Required=false)]
            public List<string> BelongGuidList { get; set; }

            /// <summary>
            /// <para>The list of GUIDs. The maximum number of items is 1,000.</para>
            /// </summary>
            [NameInMap("GuidList")]
            [Validation(Required=false)]
            public List<string> GuidList { get; set; }

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

    }

}
