// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class CheckComponentsVersionResponseBody : TeaModel {
        [NameInMap("Components")]
        [Validation(Required=false)]
        public CheckComponentsVersionResponseBodyComponents Components { get; set; }
        public class CheckComponentsVersionResponseBodyComponents : TeaModel {
            [NameInMap("Component")]
            [Validation(Required=false)]
            public List<CheckComponentsVersionResponseBodyComponentsComponent> Component { get; set; }
            public class CheckComponentsVersionResponseBodyComponentsComponent : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>HBASE</para>
                /// </summary>
                [NameInMap("Component")]
                [Validation(Required=false)]
                public string Component { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsLatestVersion")]
                [Validation(Required=false)]
                public string IsLatestVersion { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E3537EB4-1100-41CA-A147-C74CCC8BB12C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
