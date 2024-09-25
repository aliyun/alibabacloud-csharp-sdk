// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListMigrationTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The array structure.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListMigrationTaskResponseBodyData> Data { get; set; }
        public class ListMigrationTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The type of the instance.</para>
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
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-07T10:07:57.000+0000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-30T06:41:52.000+0000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The address of the source instance node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.1:8848</para>
            /// </summary>
            [NameInMap("OriginInstanceAddress")]
            [Validation(Required=false)]
            public string OriginInstanceAddress { get; set; }

            /// <summary>
            /// <para>The name of the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("OriginInstanceName")]
            [Validation(Required=false)]
            public string OriginInstanceName { get; set; }

            /// <summary>
            /// <para>The list of namespaces. This parameter is optional if applications are migrated from a Nacos instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fsdfsdfdsf</para>
            /// </summary>
            [NameInMap("OriginInstanceNamespace")]
            [Validation(Required=false)]
            public string OriginInstanceNamespace { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ProjectDesc")]
            [Validation(Required=false)]
            public string ProjectDesc { get; set; }

            [NameInMap("SyncType")]
            [Validation(Required=false)]
            public string SyncType { get; set; }

            /// <summary>
            /// <para>The name of the destination instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>multiple-nacos</para>
            /// </summary>
            [NameInMap("TargetClusterName")]
            [Validation(Required=false)]
            public string TargetClusterName { get; set; }

            /// <summary>
            /// <para>The URL of the destination instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-f1******-nacos-ans.mse.aliyuncs.com:8848</para>
            /// </summary>
            [NameInMap("TargetClusterUrl")]
            [Validation(Required=false)]
            public string TargetClusterUrl { get; set; }

            /// <summary>
            /// <para>The ID of the destination instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-cn-zv*****</para>
            /// </summary>
            [NameInMap("TargetInstanceId")]
            [Validation(Required=false)]
            public string TargetInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-100-000</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request was successfully processed.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>451EBE59-5F33-5B15-83C1-78593B9*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request was successful.</description></item>
        /// <item><description><c>false</c>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
