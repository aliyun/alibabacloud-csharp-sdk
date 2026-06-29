// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class RemoveDataServiceAppMemberRequest : TeaModel {
        /// <summary>
        /// <para>Tenant ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>Remove regular members from a data service application</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RemoveCommand")]
        [Validation(Required=false)]
        public RemoveDataServiceAppMemberRequestRemoveCommand RemoveCommand { get; set; }
        public class RemoveDataServiceAppMemberRequestRemoveCommand : TeaModel {
            /// <summary>
            /// <para>Application ID</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200000000</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public int? AppId { get; set; }

            /// <summary>
            /// <para>List of application member IDs</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("MemberIds")]
            [Validation(Required=false)]
            public List<string> MemberIds { get; set; }

        }

    }

}
