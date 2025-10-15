// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListApplicationsForNetworkAccessEndpointResponseBody : TeaModel {
        [NameInMap("ApplicationsForNetworkAccessEndpoint")]
        [Validation(Required=false)]
        public List<ListApplicationsForNetworkAccessEndpointResponseBodyApplicationsForNetworkAccessEndpoint> ApplicationsForNetworkAccessEndpoint { get; set; }
        public class ListApplicationsForNetworkAccessEndpointResponseBodyApplicationsForNetworkAccessEndpoint : TeaModel {
            /// <summary>
            /// <para>应用ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_m5nzr3kk4njkco2nnc4wjxxxxx</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>应用名称。</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 实例ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_6ed5syotlwdrgmbzn7qn5xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// <para>本次调用返回的查询凭证（Token）值，用于下一次翻页查询。</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
