// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeDBClusterNodeInfosResponseBody : TeaModel {
        [NameInMap("NodeInfos")]
        [Validation(Required=false)]
        public List<DescribeDBClusterNodeInfosResponseBodyNodeInfos> NodeInfos { get; set; }
        public class DescribeDBClusterNodeInfosResponseBodyNodeInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FailoverTesting")]
            [Validation(Required=false)]
            public bool? FailoverTesting { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>172.168.0.1</para>
            /// </summary>
            [NameInMap("NodeIp")]
            [Validation(Required=false)]
            public string NodeIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ck-bp108z124a8****</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReplicaId")]
            [Validation(Required=false)]
            public string ReplicaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ShardId")]
            [Validation(Required=false)]
            public string ShardId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>746CD303-0B82-5E8D-886D-93A9FAF3A876</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNodeCount")]
        [Validation(Required=false)]
        public int? TotalNodeCount { get; set; }

        [NameInMap("ZkNodeInfos")]
        [Validation(Required=false)]
        public List<DescribeDBClusterNodeInfosResponseBodyZkNodeInfos> ZkNodeInfos { get; set; }
        public class DescribeDBClusterNodeInfosResponseBodyZkNodeInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FailoverTesting")]
            [Validation(Required=false)]
            public bool? FailoverTesting { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ck-bp108z124a8****</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReplicaId")]
            [Validation(Required=false)]
            public string ReplicaId { get; set; }

        }

    }

}
