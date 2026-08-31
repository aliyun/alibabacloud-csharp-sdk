// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateDataAssetsGovernObjectStatusRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateDataAssetsGovernObjectStatusRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateDataAssetsGovernObjectStatusRequestUpdateCommand : TeaModel {
            [NameInMap("AlertOwners")]
            [Validation(Required=false)]
            public bool? AlertOwners { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("GovernObjectIds")]
            [Validation(Required=false)]
            public List<long?> GovernObjectIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>问题已修复</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
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
