// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class ChartsValue : TeaModel {
        /// <summary>
        /// <para>The X-axis.</para>
        /// </summary>
        [NameInMap("X")]
        [Validation(Required=false)]
        public List<string> X { get; set; }

        /// <summary>
        /// <para>The Y-axis.</para>
        /// </summary>
        [NameInMap("Y")]
        [Validation(Required=false)]
        public List<ChartsValueY> Y { get; set; }
        public class ChartsValueY : TeaModel {
            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The QPS at the point in time.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<long?> Data { get; set; }

        }

    }

}
