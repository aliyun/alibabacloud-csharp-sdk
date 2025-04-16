// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class AddFolderRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Option")]
        [Validation(Required=false)]
        public AddFolderRequestOption Option { get; set; }
        public class AddFolderRequestOption : TeaModel {
            [NameInMap("AppProperties")]
            [Validation(Required=false)]
            public List<AddFolderRequestOptionAppProperties> AppProperties { get; set; }
            public class AddFolderRequestOptionAppProperties : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PUBLIC</para>
                /// </summary>
                [NameInMap("Visibility")]
                [Validation(Required=false)]
                public string Visibility { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AUTO_RENAME</para>
            /// </summary>
            [NameInMap("ConflictStrategy")]
            [Validation(Required=false)]
            public string ConflictStrategy { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>140822073803</para>
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xPar2SZ63KodG3aV</para>
        /// </summary>
        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public AddFolderRequestTenantContext TenantContext { get; set; }
        public class AddFolderRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
