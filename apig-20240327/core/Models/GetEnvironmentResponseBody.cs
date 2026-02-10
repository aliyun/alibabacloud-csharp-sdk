// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetEnvironmentResponseBody : TeaModel {
        /// <summary>
        /// <para>The response message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The environment ID.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetEnvironmentResponseBodyData Data { get; set; }
        public class GetEnvironmentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Test environment</para>
            /// 
            /// <b>Example:</b>
            /// <para>The environment description.</para>
            /// </summary>
            [NameInMap("alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The update timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719386834548</para>
            /// </summary>
            [NameInMap("createTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>The creation timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("default")]
            [Validation(Required=false)]
            public bool? Default { get; set; }

            /// <summary>
            /// <para>Testing environment for xx project of xxx</para>
            /// 
            /// <b>Example:</b>
            /// <para>The instance information.</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The environment name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env-cq7l5s5lhtgi6qasrdc0</para>
            /// </summary>
            [NameInMap("environmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            /// <summary>
            /// <para>The subdomains.</para>
            /// </summary>
            [NameInMap("gatewayInfo")]
            [Validation(Required=false)]
            public GatewayInfo GatewayInfo { get; set; }

            /// <summary>
            /// <para>The environment alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>rg-aekzzzntl5njbpi</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekz4us4iruleja</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The information about online resources.</para>
            /// </summary>
            [NameInMap("statisticsInfo")]
            [Validation(Required=false)]
            public GetEnvironmentResponseBodyDataStatisticsInfo StatisticsInfo { get; set; }
            public class GetEnvironmentResponseBodyDataStatisticsInfo : TeaModel {
                /// <summary>
                /// <para>4</para>
                /// </summary>
                [NameInMap("resourceStatistics")]
                [Validation(Required=false)]
                public List<ResourceStatistic> ResourceStatistics { get; set; }

                /// <summary>
                /// <para>The total number of entries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>The subdomain information.</para>
            /// </summary>
            [NameInMap("subDomainInfos")]
            [Validation(Required=false)]
            public List<SubDomainInfo> SubDomainInfos { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719386834548</para>
            /// </summary>
            [NameInMap("updateTimestamp")]
            [Validation(Required=false)]
            public long? UpdateTimestamp { get; set; }

        }

        /// <summary>
        /// <para>The response data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3F8EE674-BB08-5E92-BE6F-E4756A748B0F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
