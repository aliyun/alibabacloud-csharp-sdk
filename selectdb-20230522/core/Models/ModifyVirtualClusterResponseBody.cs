// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class ModifyVirtualClusterResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyVirtualClusterResponseBodyData Data { get; set; }
        public class ModifyVirtualClusterResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>selectdb-vcg-b****-be</para>
            /// </summary>
            [NameInMap("DbClusterId")]
            [Validation(Required=false)]
            public string DbClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>selectdb-cn-7213cjv****</para>
            /// </summary>
            [NameInMap("DbInstanceId")]
            [Validation(Required=false)]
            public string DbInstanceId { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>06758CAB-1204-5852-A471-29C87D5C1D0F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
