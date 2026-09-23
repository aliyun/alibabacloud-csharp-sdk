// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateDataAssetsGovernObjectStatusRequest : TeaModel {
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
        /// <para>The update command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateDataAssetsGovernObjectStatusRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateDataAssetsGovernObjectStatusRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para>Specifies whether to notify the owner. This parameter takes effect only when the status is reverted to NEW.</para>
            /// </summary>
            [NameInMap("AlertOwners")]
            [Validation(Required=false)]
            public bool? AlertOwners { get; set; }

            /// <summary>
            /// <para>The list of governance object IDs.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("GovernObjectIds")]
            [Validation(Required=false)]
            public List<long?> GovernObjectIds { get; set; }

            /// <summary>
            /// <para>The operation description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Issue fixed</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The target status. Valid values: FINISHED / NEW / IGNORE / CANCEL_IGNORE.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FINISHED</para>
            /// </summary>
            [NameInMap("TargetStatus")]
            [Validation(Required=false)]
            public string TargetStatus { get; set; }

        }

    }

}
