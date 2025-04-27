// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDataTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1D***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The return results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDataTasksResponseBodyResult> Result { get; set; }
        public class ListDataTasksResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The time when the site monitoring task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-07-30 06:32:18</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The information of the target cluster.</para>
            /// </summary>
            [NameInMap("sinkCluster")]
            [Validation(Required=false)]
            public ListDataTasksResponseBodyResultSinkCluster SinkCluster { get; set; }
            public class ListDataTasksResponseBodyResultSinkCluster : TeaModel {
                /// <summary>
                /// <para>The type of the target cluster. Default value: elasticsearch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("dataSourceType")]
                [Validation(Required=false)]
                public string DataSourceType { get; set; }

                /// <summary>
                /// <para>The public network access address of the target cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://192.168.xx.xx:4101">http://192.168.xx.xx:4101</a></para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The target index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>product_info</para>
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// <para>The type of the destination index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>_doc</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The ID of the VPC to which the cluster belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2ze55voww95g82gak****</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The instance ID or Server Load Balancer (SLB) ID of the current cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>es-cn-09k1rnu3g0002****-worker</para>
                /// </summary>
                [NameInMap("vpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }

                /// <summary>
                /// <para>The access port number of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9200</para>
                /// </summary>
                [NameInMap("vpcInstancePort")]
                [Validation(Required=false)]
                public string VpcInstancePort { get; set; }

            }

            /// <summary>
            /// <para>The information about the source cluster.</para>
            /// </summary>
            [NameInMap("sourceCluster")]
            [Validation(Required=false)]
            public ListDataTasksResponseBodyResultSourceCluster SourceCluster { get; set; }
            public class ListDataTasksResponseBodyResultSourceCluster : TeaModel {
                /// <summary>
                /// <para>The type of the source cluster. Default value: elasticsearch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("dataSourceType")]
                [Validation(Required=false)]
                public string DataSourceType { get; set; }

                /// <summary>
                /// <para>The index whose data you want to migrate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>product_info</para>
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// <para>The Mapping configuration of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;_doc\&quot;:{\&quot;properties\&quot;:{\&quot;user\&quot;:{\&quot;properties\&quot;:{\&quot;last\&quot;:{\&quot;type\&quot;:\&quot;text\&quot;,...}}}}}}</para>
                /// </summary>
                [NameInMap("mapping")]
                [Validation(Required=false)]
                public string Mapping { get; set; }

                /// <summary>
                /// <para>The routing field to index the table. It is set to the primary key by default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>_id</para>
                /// </summary>
                [NameInMap("routing")]
                [Validation(Required=false)]
                public string Routing { get; set; }

                /// <summary>
                /// <para>The Settings of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\n  \&quot;index\&quot;: {\n    \&quot;replication\&quot;: {\n}.....}}</para>
                /// </summary>
                [NameInMap("settings")]
                [Validation(Required=false)]
                public string Settings { get; set; }

                /// <summary>
                /// <para>The type of the destination index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>_doc</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The status of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>et_cn_mfv1233r47272****</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
