// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class DeleteStandardInValidMappingRequest : TeaModel {
        /// <summary>
        /// <para>The delete instruction.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeleteCommand")]
        [Validation(Required=false)]
        public DeleteStandardInValidMappingRequestDeleteCommand DeleteCommand { get; set; }
        public class DeleteStandardInValidMappingRequestDeleteCommand : TeaModel {
            /// <summary>
            /// <para>The list of parent GUIDs. A maximum of 1000 GUIDs are supported.</para>
            /// </summary>
            [NameInMap("BelongGuidList")]
            [Validation(Required=false)]
            public List<string> BelongGuidList { get; set; }

            /// <summary>
            /// <para>The list of GUIDs. A maximum of 1000 GUIDs are supported.</para>
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
