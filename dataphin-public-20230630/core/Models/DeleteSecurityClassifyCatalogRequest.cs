// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class DeleteSecurityClassifyCatalogRequest : TeaModel {
        /// <summary>
        /// <para>The delete command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeleteCommand")]
        [Validation(Required=false)]
        public DeleteSecurityClassifyCatalogRequestDeleteCommand DeleteCommand { get; set; }
        public class DeleteSecurityClassifyCatalogRequestDeleteCommand : TeaModel {
            /// <summary>
            /// <para>The full path of the original folder.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/d1/d2/</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>Specifies whether to return the deletion details. Default value: true.</para>
            /// </summary>
            [NameInMap("ReturnRemovedDetails")]
            [Validation(Required=false)]
            public bool? ReturnRemovedDetails { get; set; }

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
        /// <para>The user ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
