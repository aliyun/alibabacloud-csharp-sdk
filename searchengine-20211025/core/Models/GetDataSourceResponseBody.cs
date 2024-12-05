// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetDataSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE03180A-0E29-5474-8A86-33F0683294A4</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the data source.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetDataSourceResponseBodyResult Result { get; set; }
        public class GetDataSourceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The data center where the data source is deployed in offline mode</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc_hz_domain_1</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The list of index information</para>
            /// </summary>
            [NameInMap("indexes")]
            [Validation(Required=false)]
            public List<string> Indexes { get; set; }

            /// <summary>
            /// <para>The time when the full data of the data source was last queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1718787219</para>
            /// </summary>
            [NameInMap("lastFulTime")]
            [Validation(Required=false)]
            public long? LastFulTime { get; set; }

            /// <summary>
            /// <para>The name of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_index</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the data source. Valid values: new: The data source is being created. publish: The data source is in the normal state. trash: The data source is being deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NEW</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the data source</para>
            /// 
            /// <b>Example:</b>
            /// <para>odps</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
