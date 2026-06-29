// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class DeleteStandardRelationsRequest : TeaModel {
        /// <summary>
        /// <para>The delete instruction.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeleteCommand")]
        [Validation(Required=false)]
        public DeleteStandardRelationsRequestDeleteCommand DeleteCommand { get; set; }
        public class DeleteStandardRelationsRequestDeleteCommand : TeaModel {
            /// <summary>
            /// <para>The standard association type: RELATIVE.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RELATIVE</para>
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

            /// <summary>
            /// <para>The list of referenced standards.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("StandardRefList")]
            [Validation(Required=false)]
            public List<DeleteStandardRelationsRequestDeleteCommandStandardRefList> StandardRefList { get; set; }
            public class DeleteStandardRelationsRequestDeleteCommandStandardRefList : TeaModel {
                /// <summary>
                /// <para>The standard ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("StandardId")]
                [Validation(Required=false)]
                public long? StandardId { get; set; }

            }

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
