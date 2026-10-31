// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class DeleteSecurityClassifyRequest : TeaModel {
        /// <summary>
        /// <para>The update command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeleteCommand")]
        [Validation(Required=false)]
        public DeleteSecurityClassifyRequestDeleteCommand DeleteCommand { get; set; }
        public class DeleteSecurityClassifyRequestDeleteCommand : TeaModel {
            /// <summary>
            /// <para>The category ID. If this parameter is not provided, the category is matched and deleted based on the category name and parent path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The category name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The category path. Default value: /.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("ParentPath")]
            [Validation(Required=false)]
            public string ParentPath { get; set; }

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
        /// <para>The operator user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
