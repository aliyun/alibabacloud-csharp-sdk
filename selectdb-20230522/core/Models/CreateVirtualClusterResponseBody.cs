// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class CreateVirtualClusterResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateVirtualClusterResponseBodyData Data { get; set; }
        public class CreateVirtualClusterResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>selectdb-cn-7213cjv2ez-be</para>
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
        /// <para>5ED62C81-9948-5612-81E1-EA3853752306</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
