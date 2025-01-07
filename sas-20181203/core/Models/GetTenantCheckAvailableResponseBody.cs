// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetTenantCheckAvailableResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTenantCheckAvailableResponseBodyData Data { get; set; }
        public class GetTenantCheckAvailableResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1725530005357</para>
            /// </summary>
            [NameInMap("NextScanTime")]
            [Validation(Required=false)]
            public long? NextScanTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>69BFFCDE-37D6-5A49-A8BC-BB03AC83****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
