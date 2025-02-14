// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetEnvironmentResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetEnvironmentResponseBodyData Data { get; set; }
        public class GetEnvironmentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Environment alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试环境</para>
            /// </summary>
            [NameInMap("alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>Creation timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719386834548</para>
            /// </summary>
            [NameInMap("createTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>Whether it is the default environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("default")]
            [Validation(Required=false)]
            public bool? Default { get; set; }

            /// <summary>
            /// <para>Environment description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>这是xxx的xx项目测试环境</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Environment ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env-cq7l5s5lhtgi6qasrdc0</para>
            /// </summary>
            [NameInMap("environmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            /// <summary>
            /// <para>Gateway information</para>
            /// </summary>
            [NameInMap("gatewayInfo")]
            [Validation(Required=false)]
            public GatewayInfo GatewayInfo { get; set; }

            /// <summary>
            /// <para>Environment name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzzzntl5njbpi</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Related resource information.</para>
            /// </summary>
            [NameInMap("statisticsInfo")]
            [Validation(Required=false)]
            public GetEnvironmentResponseBodyDataStatisticsInfo StatisticsInfo { get; set; }
            public class GetEnvironmentResponseBodyDataStatisticsInfo : TeaModel {
                /// <summary>
                /// <para>The array of related resource information.</para>
                /// </summary>
                [NameInMap("resourceStatistics")]
                [Validation(Required=false)]
                public List<ResourceStatistic> ResourceStatistics { get; set; }

                /// <summary>
                /// <para>The total number of entries returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>List of subdomains.</para>
            /// </summary>
            [NameInMap("subDomainInfos")]
            [Validation(Required=false)]
            public List<SubDomainInfo> SubDomainInfos { get; set; }

            /// <summary>
            /// <para>Update timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719386834548</para>
            /// </summary>
            [NameInMap("updateTimestamp")]
            [Validation(Required=false)]
            public long? UpdateTimestamp { get; set; }

        }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID, used for tracing the API call chain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3F8EE674-BB08-5E92-BE6F-E4756A748B0F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
