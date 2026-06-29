// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateSecurityIdentifyResultStatusRequest : TeaModel {
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
        public UpdateSecurityIdentifyResultStatusRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateSecurityIdentifyResultStatusRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para>Specifies whether the result is effective.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The list of identification result IDs.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("IdentifyResultIdList")]
            [Validation(Required=false)]
            public List<long?> IdentifyResultIdList { get; set; }

        }

    }

}
