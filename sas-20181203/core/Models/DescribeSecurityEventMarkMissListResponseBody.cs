// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
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
            /// <para>The alert event name (child class).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Login with unusual location</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The alert event name (parent class).</para>
            /// 
            /// <b>Example:</b>
            /// <para>login_common_location</para>
            /// </summary>
            [NameInMap("EventNameOriginal")]
            [Validation(Required=false)]
            public string EventNameOriginal { get; set; }

            /// <summary>
            /// <para>The alert event type (child class).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unusual Logon</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The alert event type (parent class).</para>
            /// 
            /// <b>Example:</b>
            /// <para>login_common_location</para>
            /// </summary>
            [NameInMap("EventTypeOriginal")]
            [Validation(Required=false)]
            public string EventTypeOriginal { get; set; }

            /// <summary>
            /// <para>The whitelist field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>type</para>
            /// </summary>
            [NameInMap("Field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            /// <summary>
            /// <para>The whitelist value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("FieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

            /// <summary>
            /// <para>The alias of the whitelist field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Logon Time</para>
            /// </summary>
            [NameInMap("FiledAliasName")]
            [Validation(Required=false)]
            public string FiledAliasName { get; set; }

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
            /// <para>The server instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1e8t4q15sr3****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sql-test-001</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.210.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.25.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The operator. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>contains</b>: contains</description></item>
            /// <item><description><b>notContains</b>: does not contain</description></item>
            /// <item><description><b>strEqual</b>: equals</description></item>
            /// <item><description><b>strNotEqual</b>: does not equal</description></item>
            /// <item><description><b>regex</b>: regular expression.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>contains</para>
            /// </summary>
            [NameInMap("Operate")]
            [Validation(Required=false)]
            public string Operate { get; set; }

            /// <summary>
            /// <para>The UUID of the asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49e25e0f-bb51-4a5a-a1b3-13a4ddaa****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

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
            /// <para>The page number of the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of whitelist rules to display on each page in a paged query. Default value: <b>20</b>, which indicates that 20 whitelist rules are displayed on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of whitelist rules returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A20733-10A0-4AF6-BE6B-E3322413BB68</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
