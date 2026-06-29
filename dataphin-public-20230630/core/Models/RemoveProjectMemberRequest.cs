// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class RemoveProjectMemberRequest : TeaModel {
        /// <summary>
        /// <para>The project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>711833</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

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
        /// <para>The command to remove a member.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RemoveCommand")]
        [Validation(Required=false)]
        public RemoveProjectMemberRequestRemoveCommand RemoveCommand { get; set; }
        public class RemoveProjectMemberRequestRemoveCommand : TeaModel {
            /// <summary>
            /// <para>The environment identifier. Valid values: DEV and PROD.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The user IDs.</para>
            /// </summary>
            [NameInMap("UserIdList")]
            [Validation(Required=false)]
            public List<string> UserIdList { get; set; }

        }

    }

}
