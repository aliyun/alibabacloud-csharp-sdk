// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class DescribeSecurityEventMarkMissListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of whitelist rules.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeSecurityEventMarkMissListResponseBodyList> List { get; set; }
        public class DescribeSecurityEventMarkMissListResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>176618589410****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The ID of the Endpoint Detection and Response (EDR) asset scope associated with the alert rule. You can call the DescribeAssetScope operation to query the corresponding scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1932</para>
            /// </summary>
            [NameInMap("AssetScopeId")]
            [Validation(Required=false)]
            public long? AssetScopeId { get; set; }

            /// <summary>
            /// <para>The disposal method of the rule. The current operation does not assign a value to this field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>auto_add_white</b>: Automatic whitelisting.</description></item>
            /// <item><description><b>defense_not_notification</b>: Defense only without notification.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>auto_add_white</para>
            /// </summary>
            [NameInMap("DisposalWay")]
            [Validation(Required=false)]
            public string DisposalWay { get; set; }

            /// <summary>
            /// <para>The display text of the alert name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Untrusted process startup</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The original identifier of the alert name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SASE non-whitelist startup interception_PC</para>
            /// </summary>
            [NameInMap("EventNameOriginal")]
            [Validation(Required=false)]
            public string EventNameOriginal { get; set; }

            /// <summary>
            /// <para>The display name of the alerting type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Precise defense</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The original identifier of the alerting type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Precise defense</para>
            /// </summary>
            [NameInMap("EventTypeOriginal")]
            [Validation(Required=false)]
            public string EventTypeOriginal { get; set; }

            /// <summary>
            /// <para>The name of the rule matching field. The field used when creating a rule is subject to the corresponding FiledName returned by DescribeSecurityEventOperations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cmd</para>
            /// </summary>
            [NameInMap("Field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            /// <summary>
            /// <para>The rule matching value, which defines the matching condition together with Field and Operate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C:\Windows\System32\RuntimeBroker.exe -Embedding</para>
            /// </summary>
            [NameInMap("FieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

            /// <summary>
            /// <para>The alias of the whitelisting field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Command line</para>
            /// </summary>
            [NameInMap("FiledAliasName")]
            [Validation(Required=false)]
            public string FiledAliasName { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> This field is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1775095792000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> This field is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1780539705000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The number of hits for the alert whitelist rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("HitCount")]
            [Validation(Required=false)]
            public int? HitCount { get; set; }

            /// <summary>
            /// <para>The ID of the alert whitelist rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>104037</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The instance identity of the terminal or asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c208107c-3b39-4fc1-bbdb-************</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iZ0rqjt4wqw****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the terminal or asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.210.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the terminal or asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.25.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The rule matching operator. The available operators for a specific field are subject to the corresponding SupportedMisTypes field returned by DescribeSecurityEventOperations. The following shared operators are available, but not all fields support all values:</para>
            /// <list type="bullet">
            /// <item><description><b>contains</b>: Contains.</description></item>
            /// <item><description><b>notContains</b>: Does not contain.</description></item>
            /// <item><description><b>strEqual</b>: Equal to.</description></item>
            /// <item><description><b>strNotEqual</b>: Not equal to.</description></item>
            /// <item><description><b>regex</b>: Regular expression match.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>strEqual</para>
            /// </summary>
            [NameInMap("Operate")]
            [Validation(Required=false)]
            public string Operate { get; set; }

            /// <summary>
            /// <para>The UUID of the asset instance. For rules associated with an asset scope, the effective scope is identified by AssetScopeId, and the UUID of the target asset is not returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>inet-pc-c6641e3e-2646-4688-ac38-************</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The list of UUIDs of associated assets. Multiple values are separated by commas (,). The current operation does not assign a value to this field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>inet-pc-c6641e3e-2646-4688-ac38-************</para>
            /// </summary>
            [NameInMap("Uuids")]
            [Validation(Required=false)]
            public string Uuids { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records to return in a single query. This field is reserved for compatibility. The backend currently uses CurrentPage and PageSize for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N6hiD08qrLdwJ9Fh0qdsJD61D5V7sa12H194Q1******</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeSecurityEventMarkMissListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeSecurityEventMarkMissListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of whitelist rules on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of whitelist rules to return on each page in a paging query. Default value: <b>20</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of queried whitelist rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. It is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A20733-10A0-4AF6-BE6B-E3322413BB68</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
