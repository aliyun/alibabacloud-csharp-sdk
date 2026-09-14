// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateComputeResourceAuthUserMappingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The data object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateComputeResourceAuthUserMappingsResponseBodyData Data { get; set; }
        public class UpdateComputeResourceAuthUserMappingsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The change record ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123xx</para>
            /// </summary>
            [NameInMap("ChangeRecordId")]
            [Validation(Required=false)]
            public long? ChangeRecordId { get; set; }

            /// <summary>
            /// <para>Indicates whether the operation succeeded. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>success: The update succeeded.</description></item>
            /// <item><description>fail: The update failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
