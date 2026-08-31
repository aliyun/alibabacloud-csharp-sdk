// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetAssetAttributesRequest : TeaModel {
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
        /// <para>The ID of the operator user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The query instruction.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("QueryCommand")]
        [Validation(Required=false)]
        public GetAssetAttributesRequestQueryCommand QueryCommand { get; set; }
        public class GetAssetAttributesRequestQueryCommand : TeaModel {
            /// <summary>
            /// <para>The list of property codes to return. If this parameter is not specified, all custom properties of the asset are returned.</para>
            /// </summary>
            [NameInMap("AttributeCodeList")]
            [Validation(Required=false)]
            public List<string> AttributeCodeList { get; set; }

            /// <summary>
            /// <para>The list of asset GUIDs. A maximum of 50 GUIDs are supported.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("GuidList")]
            [Validation(Required=false)]
            public List<string> GuidList { get; set; }

        }

    }

}
