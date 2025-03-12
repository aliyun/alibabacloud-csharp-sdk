// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateOmsMysqlDataSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The return result of the request.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateOmsMysqlDataSourceResponseBodyData Data { get; set; }
        public class CreateOmsMysqlDataSourceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the data source record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e_1234abcd*****</para>
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
