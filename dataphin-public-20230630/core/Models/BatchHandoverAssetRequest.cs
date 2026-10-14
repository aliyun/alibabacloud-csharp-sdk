// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class BatchHandoverAssetRequest : TeaModel {
        /// <summary>
        /// <para>The batch transfer command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("HandoverCommand")]
        [Validation(Required=false)]
        public BatchHandoverAssetRequestHandoverCommand HandoverCommand { get; set; }
        public class BatchHandoverAssetRequestHandoverCommand : TeaModel {
            /// <summary>
            /// <para>The list of asset GUIDs to be transferred. A maximum of 50 assets can be transferred at a time. Currently, only physical tables and logical tables are supported. Data source tables are not supported.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("GuidList")]
            [Validation(Required=false)]
            public List<string> GuidList { get; set; }

            /// <summary>
            /// <para>The user ID of the transfer recipient.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300004567</para>
            /// </summary>
            [NameInMap("TargetUserId")]
            [Validation(Required=false)]
            public string TargetUserId { get; set; }

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

        /// <summary>
        /// <para>The operator user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
