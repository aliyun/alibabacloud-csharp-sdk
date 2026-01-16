// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ScaleClusterNodePoolRequest : TeaModel {
        [NameInMap("Body")]
        [Validation(Required=false)]
        public ScaleClusterNodePoolRequestBody Body { get; set; }
        public class ScaleClusterNodePoolRequestBody : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eck-xxxxxxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>np2201da356f5245cf8faa522a8a4c8224</para>
        /// </summary>
        [NameInMap("NodepoolId")]
        [Validation(Required=false)]
        public string NodepoolId { get; set; }

    }

}
