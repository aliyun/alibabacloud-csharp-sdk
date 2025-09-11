// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class CheckIpExistsInSecurityIpListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CheckIpExistsInSecurityIpListResponseBodyData Data { get; set; }
        public class CheckIpExistsInSecurityIpListResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IpExists")]
            [Validation(Required=false)]
            public bool? IpExists { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4773E4EC-025D-509F-AEA9-D53123FDFB0F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
