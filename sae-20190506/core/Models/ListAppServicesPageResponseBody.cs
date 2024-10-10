// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListAppServicesPageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAppServicesPageResponseBodyData> Data { get; set; }
        public class ListAppServicesPageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public string CurrentPage { get; set; }

            /// <summary>
            /// <para>The returned result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9999</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <para>The version of the service. You can create a custom version.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListAppServicesPageResponseBodyDataResult> Result { get; set; }
            public class ListAppServicesPageResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The group to which the service belongs. You can create a custom group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hc4fs1****@98314c8790b****</para>
                /// </summary>
                [NameInMap("EdasAppId")]
                [Validation(Required=false)]
                public string EdasAppId { get; set; }

                /// <summary>
                /// <para>The total number of instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-zhangjiakou-micro-service-******</para>
                /// </summary>
                [NameInMap("EdasAppName")]
                [Validation(Required=false)]
                public string EdasAppName { get; set; }

                /// <summary>
                /// <para>The HTTP status code. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>2xx</b>: indicates that the call was successful.</description></item>
                /// <item><description><b>3xx</b>: indicates that the call was redirected.</description></item>
                /// <item><description><b>4xx</b>: indicates that the call failed.</description></item>
                /// <item><description><b>5xx</b>: indicates that a server error occurred.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>springCloud</para>
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                /// <summary>
                /// <para>The name of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InstanceNum")]
                [Validation(Required=false)]
                public long? InstanceNum { get; set; }

                /// <summary>
                /// <para>The returned error code. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>If the call is successful, the <b>ErrorCode</b> parameter is not returned.</description></item>
                /// <item><description>If the call fails, the <b>ErrorCode</b> parameter is returned. For more information, see the &quot;<b>Error codes</b>&quot; section of this topic.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>edas.service.provider</para>
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The number of entries returned per page. Valid values: 0 to 9999.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public string TotalSize { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the microservice list was obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The list was obtained.</description></item>
        /// <item><description><b>false</b>: The list failed to be obtained.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The details of microservices.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the trace. The ID is used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2583E089-99C2-562E-8B7E-73512136****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The page number of the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0be3e0c816394483660457498e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
