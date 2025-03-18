// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20210114.Models
{
    public class ListGlobalUserConfigResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListGlobalUserConfigResponseBodyData> Data { get; set; }
        public class ListGlobalUserConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("GlobalConfigSwitch")]
            [Validation(Required=false)]
            public bool? GlobalConfigSwitch { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ransomware_breaking</para>
            /// </summary>
            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D81DD78E-E006-5C65-A171-C8CB09XXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
