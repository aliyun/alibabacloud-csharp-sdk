// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class ListEgressProxyConfigurationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of egress proxy configurations.</para>
        /// </summary>
        [NameInMap("EgressProxyConfigurations")]
        [Validation(Required=false)]
        public List<ListEgressProxyConfigurationsResponseBodyEgressProxyConfigurations> EgressProxyConfigurations { get; set; }
        public class ListEgressProxyConfigurationsResponseBodyEgressProxyConfigurations : TeaModel {
            /// <summary>
            /// <para>The time when the egress proxy configuration was created. The time is displayed in UTC in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-02T02:49:05Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the egress proxy configuration. The description must be 2 to 256 characters in length, and can contain Chinese characters, letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (_).</para>
            /// 
            /// <b>Example:</b>
            /// <para>testEpg</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the egress proxy configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>epc-gw80d16a969933e7****</para>
            /// </summary>
            [NameInMap("EgressProxyConfigurationId")]
            [Validation(Required=false)]
            public string EgressProxyConfigurationId { get; set; }

            /// <summary>
            /// <para>The name of the egress proxy configuration. The name must be 2 to 128 characters in length, and must start with a letter or a Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>testEpg</para>
            /// </summary>
            [NameInMap("EgressProxyConfigurationName")]
            [Validation(Required=false)]
            public string EgressProxyConfigurationName { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek6jw4dpt****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The status of the egress proxy configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Provisioning</b>: The egress proxy configuration is being created.</para>
            /// </description></item>
            /// <item><description><para><b>Available</b>: The egress proxy configuration is available.</para>
            /// </description></item>
            /// <item><description><para><b>Configuring</b>: The specifications of the egress proxy configuration are being changed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListEgressProxyConfigurationsResponseBodyEgressProxyConfigurationsTags> Tags { get; set; }
            public class ListEgressProxyConfigurationsResponseBodyEgressProxyConfigurationsTags : TeaModel {
                /// <summary>
                /// <para>The tag key. The key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value. The value can be up to 256 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The maximum number of entries returned for the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If NextToken is empty, no next query is required.</description></item>
        /// <item><description>If NextToken is returned, the value indicates the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A05ABD-A4C0-5F6B-A554-AEEEC73F9F70</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of egress proxy configurations that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
