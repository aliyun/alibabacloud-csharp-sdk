// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class AddSQLRateLimitingRulesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID. Usage notes: SQL throttling is supported only for PostgreSQL and Oracle engines, and is not supported for MySQL engines.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The JSON string of the configuration parameters and their values for the SQL throttling rule to be modified. All parameter values are of the string type. Example: <c>{&quot;id&quot;:&quot;test&quot;,&quot;enabled&quot;:&quot;true&quot;,&quot;match_mode&quot;:&quot;0&quot;,&quot;template&quot;:&quot;dXBkYXRlIHQgc2V0IGEgPSAxIHdoZXJlIGlkID0gMQ==&quot;,&quot;user&quot;:&quot;&quot;,&quot;database&quot;:&quot;&quot;,&quot;waiting&quot;:1024,&quot;endpoint&quot;:&quot;[{&quot;EndpointName&quot;:&quot;pe-***********&quot;,&quot;EndpointType&quot;:&quot;Cluster&quot;,&quot;DBEndpointDescription&quot;:&quot;Cluster Address&quot;}]&quot;,&quot;throttle_mode&quot;:0,&quot;concurrency&quot;:1}</c>. Parameters:</para>
        /// <list type="bullet">
        /// <item><description><c>&quot;id&quot;</c>: Required. The name of the throttling rule. The name must meet the following requirements:<list type="bullet">
        /// <item><description>The name cannot exceed 30 characters in length.</description></item>
        /// <item><description>The name must consist of uppercase and lowercase letters and digits.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;id&quot;:&quot;test&quot;,&quot;enabled&quot;:&quot;true&quot;,&quot;match_mode&quot;:&quot;0&quot;,&quot;template&quot;:&quot;dXBkYXRlIHQgc2V0IGEgPSAxIHdoZXJlIGlkID0gMQ==&quot;,&quot;user&quot;:&quot;&quot;,&quot;database&quot;:&quot;&quot;,&quot;waiting&quot;:1024,&quot;endpoint&quot;:&quot;[{&quot;EndpointName&quot;:&quot;pe-***********&quot;,&quot;EndpointType&quot;:&quot;Cluster&quot;,&quot;DBEndpointDescription&quot;:&quot;Cluster Address&quot;}]&quot;,&quot;throttle_mode&quot;:0,&quot;concurrency&quot;:1}</para>
        /// </summary>
        [NameInMap("RuleConfig")]
        [Validation(Required=false)]
        public string RuleConfig { get; set; }

        /// <summary>
        /// <para>The name of the SQL throttling rule. You can specify only one rule name at a time.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/212573.html">DescribeSQLRateLimitingRules</a> operation to query the details of all SQL throttling rules in the specified cluster, including the rule names.</description></item>
        /// <item><description>If the specified rule name does not exist in the current cluster, the system automatically creates an SQL throttling rule based on the name and the <c>RuleConfig</c> value.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testrule</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
