// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeNamespacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: indicates that the request was successful.</description></item>
        /// <item><description><b>3xx</b>: indicates that the request was redirected.</description></item>
        /// <item><description><b>4xx</b>: indicates that the request failed.</description></item>
        /// <item><description><b>5xx</b>: indicates that a server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information of namespaces.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeNamespacesResponseBodyData Data { get; set; }
        public class DescribeNamespacesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The list of namespaces.</para>
            /// </summary>
            [NameInMap("Namespaces")]
            [Validation(Required=false)]
            public List<DescribeNamespacesResponseBodyDataNamespaces> Namespaces { get; set; }
            public class DescribeNamespacesResponseBodyDataNamespaces : TeaModel {
                /// <summary>
                /// <para>The ACM-specific AccessKey ID. It can be used to manage data in an Application Configuration Management (ACM) namespace. For more information, see <a href="~~~~">Differences between Alibaba Cloud AccessKey and ACM-specific AccessKey</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b34dbe3315c64f9f99b58ea447ec****</para>
                /// </summary>
                [NameInMap("AccessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>addr-bj-internal.edas.aliyun.com</para>
                /// </summary>
                [NameInMap("AddressServerHost")]
                [Validation(Required=false)]
                public string AddressServerHost { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("NameSpaceShortId")]
                [Validation(Required=false)]
                public string NameSpaceShortId { get; set; }

                /// <summary>
                /// <para>The description of the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>desc</para>
                /// </summary>
                [NameInMap("NamespaceDescription")]
                [Validation(Required=false)]
                public string NamespaceDescription { get; set; }

                /// <summary>
                /// <para>The ID of the namespace. The information of the default namespace cannot be queried or modified. The default namespace cannot be deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing:test</para>
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                /// <summary>
                /// <para>The name of the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("NamespaceName")]
                [Validation(Required=false)]
                public string NamespaceName { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ACM-specific AccessKey secret. It can be used to manage data in an ACM namespace. For more information, see <a href="~~~~">Differences between Alibaba Cloud AccessKey and ACM-specific AccessKey</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>G/w6sseK7+nb3S6HBmANDBMD****</para>
                /// </summary>
                [NameInMap("SecretKey")]
                [Validation(Required=false)]
                public string SecretKey { get; set; }

                /// <summary>
                /// <para>The ID of the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>838cad95-973f-48fe-830b-2a8546d7****</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

            }

            /// <summary>
            /// <para>The number of entries returned on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of namespaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The error code. </para>
        /// <list type="bullet">
        /// <item><description>The <b>ErrorCode</b> parameter is not returned when the request succeeds.</description></item>
        /// <item><description>The <b>ErrorCode</b> parameter is returned when the request fails. For more information, see <b>Error codes</b> in this topic.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <list type="bullet">
        /// <item><description><b>success</b> is returned when the request succeeds.</description></item>
        /// <item><description>An error message is returned when the request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the details of namespaces were queried successfully. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: indicates that the query was successful.</description></item>
        /// <item><description><b>false</b>: indicates that the query failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of the trace. It can be used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a981dd515966966104121683d****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
