// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListAvailableEsInstanceIdsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListAvailableEsInstanceIdsResponseBodyResult> Result { get; set; }
        public class ListAvailableEsInstanceIdsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The name of the Elasticsearch cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instanceName</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The address that is used to access the Elasticsearch cluster over the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://es-cn-n6w1o1x0w001c****.elasticsearch.aliyuncs.com:9200">http://es-cn-n6w1o1x0w001c****.elasticsearch.aliyuncs.com:9200</a></para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The ID of the Elasticsearch cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-n6w1o1x0w001c****</para>
            /// </summary>
            [NameInMap("esInstanceId")]
            [Validation(Required=false)]
            public string EsInstanceId { get; set; }

            /// <summary>
            /// <para>The address that is used to access the Kibana console of the Elasticsearch cluster over the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://es-cn-n6w1o1x0w001c****.kibana.elasticsearch.aliyuncs.com:5601">https://es-cn-n6w1o1x0w001c****.kibana.elasticsearch.aliyuncs.com:5601</a></para>
            /// </summary>
            [NameInMap("kibanaEndpoint")]
            [Validation(Required=false)]
            public string KibanaEndpoint { get; set; }

        }

    }

}
