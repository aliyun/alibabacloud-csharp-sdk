// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DescribeInstanceConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denied error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;PolicyType&quot;: &quot;AccountLevelIdentityBasedPolicy&quot;,     &quot;AuthPrincipalOwnerId&quot;: &quot;xxx&quot;,     &quot;EncodedDiagnosticMessage&quot;: &quot;xxx&quot;,     &quot;AuthPrincipalType&quot;: &quot;xxx&quot;,     &quot;AuthPrincipalDisplayName&quot;: &quot;xxx&quot;,     &quot;NoPermissionType&quot;: &quot;ImplicitDeny&quot;,     &quot;AuthAction&quot;: &quot;sr:xxx&quot;   }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeInstanceConfigsResponseBodyData> Data { get; set; }
        public class DescribeInstanceConfigsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the configuration item can be modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowModify")]
            [Validation(Required=false)]
            public string AllowModify { get; set; }

            /// <summary>
            /// <para>The key of the configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enable_udf</para>
            /// </summary>
            [NameInMap("ConfigKey")]
            [Validation(Required=false)]
            public string ConfigKey { get; set; }

            /// <summary>
            /// <para>The type of the configuration item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>FE</para>
            /// </description></item>
            /// <item><description><para>BE</para>
            /// </description></item>
            /// <item><description><para>CORE</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FE</para>
            /// </summary>
            [NameInMap("ConfigType")]
            [Validation(Required=false)]
            public string ConfigType { get; set; }

            /// <summary>
            /// <para>The value of the configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ConfigValue")]
            [Validation(Required=false)]
            public string ConfigValue { get; set; }

            /// <summary>
            /// <para>Indicates whether the item is a custom configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Custom")]
            [Validation(Required=false)]
            public bool? Custom { get; set; }

            /// <summary>
            /// <para>Indicates whether it is the default compute group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DefaultNodeGroup")]
            [Validation(Required=false)]
            public bool? DefaultNodeGroup { get; set; }

            /// <summary>
            /// <para>The default value of the configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// <para>The description of the configuration item\&quot;s feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Whether to enable UDF.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The English description of the configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A boolean value to control whether to enable the synchronization of the tablet metadata. true indicates enabling synchronization, and false indicates disabling it.</para>
            /// </summary>
            [NameInMap("DescriptionEn")]
            [Validation(Required=false)]
            public string DescriptionEn { get; set; }

            /// <summary>
            /// <para>The compute group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ng-3d5ce6454354****</para>
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            /// <summary>
            /// <para>The name of the compute group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ng_1</para>
            /// </summary>
            [NameInMap("NodeGroupName")]
            [Validation(Required=false)]
            public string NodeGroupName { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance needs to be restarted after the configuration item is changed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Restart.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Do not restart.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Restart")]
            [Validation(Required=false)]
            public bool? Restart { get; set; }

            /// <summary>
            /// <para>The unit of the configuration item. An empty string is returned if no unit is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            /// <summary>
            /// <para>The value range of the configuration item. An empty string is returned if no value range is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true,false</para>
            /// </summary>
            [NameInMap("ValueRange")]
            [Validation(Required=false)]
            public string ValueRange { get; set; }

            /// <summary>
            /// <para>The data type of the configuration item\&quot;s value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INT</para>
            /// </summary>
            [NameInMap("ValueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParams</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid params: [instance not exists].</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP request status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32A44F0D-BFF6-5664-999A-218BBDE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
