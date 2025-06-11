// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListAccessConfigurationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The access configurations.</para>
        /// </summary>
        [NameInMap("AccessConfigurations")]
        [Validation(Required=false)]
        public List<ListAccessConfigurationsResponseBodyAccessConfigurations> AccessConfigurations { get; set; }
        public class ListAccessConfigurationsResponseBodyAccessConfigurations : TeaModel {
            /// <summary>
            /// <para>The ID of the access configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ac-00jhtfl8thteu6uj****</para>
            /// </summary>
            [NameInMap("AccessConfigurationId")]
            [Validation(Required=false)]
            public string AccessConfigurationId { get; set; }

            /// <summary>
            /// <para>The name of the access configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS-Admin</para>
            /// </summary>
            [NameInMap("AccessConfigurationName")]
            [Validation(Required=false)]
            public string AccessConfigurationName { get; set; }

            /// <summary>
            /// <para>The time when the access configuration was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-02T08:44:23Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the access configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is an access configuration.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The initial web page</para>
            /// <para>that is displayed after a CloudSSO user uses the access configuration to access an account in your resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cloudsso.console.aliyun.com">https://cloudsso.console.aliyun.com</a></para>
            /// </summary>
            [NameInMap("RelayState")]
            [Validation(Required=false)]
            public string RelayState { get; set; }

            /// <summary>
            /// <para>The duration of a session</para>
            /// <para>in which a CloudSSO user uses the access configuration to access an account in your resource directory.</para>
            /// <para>Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>900</para>
            /// </summary>
            [NameInMap("SessionDuration")]
            [Validation(Required=false)]
            public int? SessionDuration { get; set; }

            /// <summary>
            /// <para>The status notifications.</para>
            /// </summary>
            [NameInMap("StatusNotifications")]
            [Validation(Required=false)]
            public List<string> StatusNotifications { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListAccessConfigurationsResponseBodyAccessConfigurationsTags> Tags { get; set; }
            public class ListAccessConfigurationsResponseBodyAccessConfigurationsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The time when the information about the access configuration was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-02T08:44:23Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the queried entries are truncated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// <remarks>
        /// <para> This parameter is returned only when the value of the <c>IsTruncated</c> parameter is <c>true</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>K1c3o9K7pFxoTtxH1Nm7MMLb7zrDGvftYBQBPDVv7AD3a8yhRb3Mk8L9ivmN6bFSjfkZNTAg3h4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2BC0CBAC-45E1-5BD3-BF6E-F69D1D5391C2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public int? TotalCounts { get; set; }

    }

}
