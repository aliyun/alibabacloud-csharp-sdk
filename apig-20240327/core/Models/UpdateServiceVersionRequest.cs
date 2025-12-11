// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateServiceVersionRequest : TeaModel {
        /// <summary>
        /// <para>The list of tags.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public List<UpdateServiceVersionRequestLabels> Labels { get; set; }
        public class UpdateServiceVersionRequestLabels : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>topology.kubernetes.io/zone</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-k</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
