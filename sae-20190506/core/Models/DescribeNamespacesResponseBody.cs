// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeNamespacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The request was redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: The request was invalid.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: A server-side error occurred.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the namespaces.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeNamespacesResponseBodyData Data { get; set; }
        public class DescribeNamespacesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
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
                /// <para>The access key ID for Application Configuration Management (ACM), used to manage data in an ACM namespace. For more information, see <a href="https://help.aliyun.com/document_detail/68941.html">Differences between an Alibaba Cloud access key and an ACM-specific access key</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b34dbe3315c64f9f99b58ea447ec****</para>
                /// </summary>
                [NameInMap("AccessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                /// <summary>
                /// <para>The service endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>addr-bj-internal.edas.aliyun.com</para>
                /// </summary>
                [NameInMap("AddressServerHost")]
                [Validation(Required=false)]
                public string AddressServerHost { get; set; }

                /// <summary>
                /// <para>The short ID of the namespace.</para>
                /// 
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
                /// <para>The namespace ID. The default namespace cannot be queried, modified, or deleted.</para>
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
                /// <para>The ID of the region. For example, \&quot;cn-beijing\&quot; indicates China (Beijing).</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The secret access key for Application Configuration Management (ACM), used to manage data in an ACM namespace. For more information, see <a href="https://help.aliyun.com/document_detail/68941.html">Differences between an Alibaba Cloud access key and an ACM-specific access key</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>G/w6sseK7+nb3S6HBmANDBMD****</para>
                /// </summary>
                [NameInMap("SecretKey")]
                [Validation(Required=false)]
                public string SecretKey { get; set; }

                /// <summary>
                /// <para>The tenant ID.</para>
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
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is returned only if the request fails.</para>
        /// </description></item>
        /// <item><description><para>For more information, see the <b>Error codes</b> section in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The message returned by the system.</para>
        /// <list type="bullet">
        /// <item><description><para>Returns <b>success</b> if the request is successful.</para>
        /// </description></item>
        /// <item><description><para>Returns a specific error message if the request fails.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID that can be used to query the details of a call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a981dd515966966104121683d****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
