// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class ListDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried data.</para>
        /// </summary>
        [NameInMap("dataSources")]
        [Validation(Required=false)]
        public List<ListDataSourcesResponseBodyDataSources> DataSources { get; set; }
        public class ListDataSourcesResponseBodyDataSources : TeaModel {
            /// <summary>
            /// <para>The ID of the data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
