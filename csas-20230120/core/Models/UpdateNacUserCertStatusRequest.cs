// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateNacUserCertStatusRequest : TeaModel {
        [NameInMap("IdList")]
        [Validation(Required=false)]
        public List<UpdateNacUserCertStatusRequestIdList> IdList { get; set; }
        public class UpdateNacUserCertStatusRequestIdList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>36efa42d-2c32-c4dc-e3fc-8541e33a****</para>
            /// </summary>
            [NameInMap("DevTag")]
            [Validation(Required=false)]
            public string DevTag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
