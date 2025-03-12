// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantZonesReadResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether a read-only connection needs to be created for the zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// </summary>
        [NameInMap("TenantZones")]
        [Validation(Required=false)]
        public List<DescribeTenantZonesReadResponseBodyTenantZones> TenantZones { get; set; }
        public class DescribeTenantZonesReadResponseBodyTenantZones : TeaModel {
            /// <summary>
            /// <para>Example 1</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsElectable")]
            [Validation(Required=false)]
            public bool? IsElectable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsPrimary")]
            [Validation(Required=false)]
            public bool? IsPrimary { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsReadable")]
            [Validation(Required=false)]
            public string IsReadable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

        }

    }

}
