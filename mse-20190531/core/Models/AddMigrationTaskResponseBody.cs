// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddMigrationTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Data structure.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddMigrationTaskResponseBodyData Data { get; set; }
        public class AddMigrationTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Cluster type.</para>
            /// <list type="bullet">
            /// <item><description>Nacos-Ans</description></item>
            /// <item><description>ZooKeeper</description></item>
            /// <item><description>Eureka</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Nacos-Ans</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>Task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Source instance node address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.1:8848</para>
            /// </summary>
            [NameInMap("OriginInstanceAddress")]
            [Validation(Required=false)]
            public string OriginInstanceAddress { get; set; }

            /// <summary>
            /// <para>Source instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Source instance</para>
            /// </summary>
            [NameInMap("OriginInstanceName")]
            [Validation(Required=false)]
            public string OriginInstanceName { get; set; }

            /// <summary>
            /// <para>Namespace list, required when the source cluster is Nacos.</para>
            /// 
            /// <b>Example:</b>
            /// <para>namesapceId1,namesapceId2</para>
            /// </summary>
            [NameInMap("OriginInstanceNamespace")]
            [Validation(Required=false)]
            public string OriginInstanceNamespace { get; set; }

            /// <summary>
            /// <para>Description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testsdfsdfsd</para>
            /// </summary>
            [NameInMap("ProjectDesc")]
            [Validation(Required=false)]
            public string ProjectDesc { get; set; }

            /// <summary>
            /// <para>SyncType</para>
            /// 
            /// <b>Example:</b>
            /// <para>Service</para>
            /// </summary>
            [NameInMap("SyncType")]
            [Validation(Required=false)]
            public string SyncType { get; set; }

            /// <summary>
            /// <para>Target instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Destination instance</para>
            /// </summary>
            [NameInMap("TargetClusterName")]
            [Validation(Required=false)]
            public string TargetClusterName { get; set; }

            /// <summary>
            /// <para>Target instance URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-94d****-nacos-ans.mse.aliyuncs.com:8848</para>
            /// </summary>
            [NameInMap("TargetClusterUrl")]
            [Validation(Required=false)]
            public string TargetClusterUrl { get; set; }

            /// <summary>
            /// <para>Target instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-cn-7pp2w*****</para>
            /// </summary>
            [NameInMap("TargetInstanceId")]
            [Validation(Required=false)]
            public string TargetInstanceId { get; set; }

            /// <summary>
            /// <para>User ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>183876217*****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>Error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-100-000</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request is processed successfully.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7466566F-F30F-4A29-965D-3E0AF21D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>请求结果，取值如下：</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>：请求成功。</description></item>
        /// <item><description><c>false</c>：请求失败。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
