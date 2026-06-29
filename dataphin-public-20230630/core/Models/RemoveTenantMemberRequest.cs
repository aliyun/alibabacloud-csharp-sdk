// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class RemoveTenantMemberRequest : TeaModel {
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
        /// <para>The request command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RemoveCommand")]
        [Validation(Required=false)]
        public RemoveTenantMemberRequestRemoveCommand RemoveCommand { get; set; }
        public class RemoveTenantMemberRequestRemoveCommand : TeaModel {
            /// <summary>
            /// <para>The source ID of the user.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:123@xx.com">123@xx.com</a></para>
            /// </summary>
            [NameInMap("SourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

        }

    }

}
