// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateSecurityClassifyCatalogRequest : TeaModel {
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
        /// <para>The update instruction.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateSecurityClassifyCatalogRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateSecurityClassifyCatalogRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para>The name of the classification folder.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of administrator IDs. This parameter takes effect only when the parent folder is the root folder.</para>
            /// </summary>
            [NameInMap("OwnerList")]
            [Validation(Required=false)]
            public List<string> OwnerList { get; set; }

            /// <summary>
            /// <para>The full path of the parent classification folder. Default value: /.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/d1/</para>
            /// </summary>
            [NameInMap("ParentPath")]
            [Validation(Required=false)]
            public string ParentPath { get; set; }

            /// <summary>
            /// <para>The original full path of the folder.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/d1/d2/</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The visibility scope of the classification folder. This parameter takes effect only when the parent folder is the root folder. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PUBLIC: visible to all users.</description></item>
            /// <item><description>PRIVATE: visible only to administrators.
            /// Default value: PUBLIC.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLIC</para>
            /// </summary>
            [NameInMap("VisibleType")]
            [Validation(Required=false)]
            public string VisibleType { get; set; }

        }

    }

}
