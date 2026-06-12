// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetNetworkAvailableZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetNetworkAvailableZonesResponseBodyData Data { get; set; }
        public class GetNetworkAvailableZonesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of zone IDs.</para>
            /// </summary>
            [NameInMap("ZoneIdList")]
            [Validation(Required=false)]
            public List<string> ZoneIdList { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E8EF75BC-14E4-597A-BE66-FFA9393C0875</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
