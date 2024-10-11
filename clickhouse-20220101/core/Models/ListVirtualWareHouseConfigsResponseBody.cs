// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20220101.Models
{
    public class ListVirtualWareHouseConfigsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListVirtualWareHouseConfigsResponseBodyData> Data { get; set; }
        public class ListVirtualWareHouseConfigsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>keep_alive_timeout</para>
            /// </summary>
            [NameInMap("ConfigFullPath")]
            [Validation(Required=false)]
            public string ConfigFullPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>config.xml</para>
            /// </summary>
            [NameInMap("ConfigType")]
            [Validation(Required=false)]
            public string ConfigType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>The number of seconds that ClickHouse HTTP server waits for incoming requests before closing the connection</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedRestart")]
            [Validation(Required=false)]
            public bool? NeedRestart { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <remarks>
            /// <para>=10</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>87B839E3-7384-52D5-9CAB-756DD3BF7B9B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
