// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateDataServiceAppMemberRequest : TeaModel {
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
        /// <para>The command to update regular members of a data service application.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateDataServiceAppMemberRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateDataServiceAppMemberRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200000000</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public int? AppId { get; set; }

            /// <summary>
            /// <para>The list of members.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("MemberList")]
            [Validation(Required=false)]
            public List<UpdateDataServiceAppMemberRequestUpdateCommandMemberList> MemberList { get; set; }
            public class UpdateDataServiceAppMemberRequestUpdateCommandMemberList : TeaModel {
                /// <summary>
                /// <para>The authorization expiration time.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-12-12</para>
                /// </summary>
                [NameInMap("EffectiveEnd")]
                [Validation(Required=false)]
                public string EffectiveEnd { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
