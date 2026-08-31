// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class SubmitAssetsOffShelveRequest : TeaModel {
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
        /// <para>The delisting submit command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SubmitCommand")]
        [Validation(Required=false)]
        public SubmitAssetsOffShelveRequestSubmitCommand SubmitCommand { get; set; }
        public class SubmitAssetsOffShelveRequestSubmitCommand : TeaModel {
            /// <summary>
            /// <para>The list of asset GUIDs to be delisted. A maximum of 50 GUIDs can be specified per request.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("GuidList")]
            [Validation(Required=false)]
            public List<string> GuidList { get; set; }

            /// <summary>
            /// <para>The delisting description. The value must be 1 to 100 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Business adjustment, no longer available externally</para>
            /// </summary>
            [NameInMap("OffShelveDescription")]
            [Validation(Required=false)]
            public string OffShelveDescription { get; set; }

        }

    }

}
