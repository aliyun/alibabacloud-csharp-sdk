// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetOperationRecordByIdRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DetailCommand")]
        [Validation(Required=false)]
        public GetOperationRecordByIdRequestDetailCommand DetailCommand { get; set; }
        public class GetOperationRecordByIdRequestDetailCommand : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>987654321</para>
            /// </summary>
            [NameInMap("OperationId")]
            [Validation(Required=false)]
            public long? OperationId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131211211</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

        /// <summary>
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
