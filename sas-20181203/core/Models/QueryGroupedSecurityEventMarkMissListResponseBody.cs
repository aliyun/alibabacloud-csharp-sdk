// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryGroupedSecurityEventMarkMissListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned. The status code <b>200</b> indicates that the request is successful. Other status codes indicate that the request fails. You can identify the cause of the failure based on the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>An array that consists of the whitelist rules.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<QueryGroupedSecurityEventMarkMissListResponseBodyList> List { get; set; }
        public class QueryGroupedSecurityEventMarkMissListResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>31412647</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The handling method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>auto_add_white</b>: Automatically Added to Whitelist</description></item>
            /// <item><description><b>defense_not_notification</b>: Defense Without Notification</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>auto_add_white</para>
            /// </summary>
            [NameInMap("DisposalWay")]
            [Validation(Required=false)]
            public string DisposalWay { get; set; }

            /// <summary>
            /// <para>The name of the alert event. The value indicates a subtype.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Login with unusual location</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The name of the alert event. The value indicates a type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>login_common_location</para>
            /// </summary>
            [NameInMap("EventNameOriginal")]
            [Validation(Required=false)]
            public string EventNameOriginal { get; set; }

            /// <summary>
            /// <para>The subtype of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unusual Logon</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The type of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unusual logon</para>
            /// </summary>
            [NameInMap("EventTypeOriginal")]
            [Validation(Required=false)]
            public string EventTypeOriginal { get; set; }

            /// <summary>
            /// <para>The field that is used in the whitelist rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>type</para>
            /// </summary>
            [NameInMap("Field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            /// <summary>
            /// <para>The value of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("FieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

            /// <summary>
            /// <para>The alias of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Logon Time</para>
            /// </summary>
            [NameInMap("FiledAliasName")]
            [Validation(Required=false)]
            public string FiledAliasName { get; set; }

            /// <summary>
            /// <para>The operator. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>contains</b>: contains</description></item>
            /// <item><description><b>notContains</b>: does not contain</description></item>
            /// <item><description><b>strEqual</b>: equals</description></item>
            /// <item><description><b>strNotEqual</b>: does not equal</description></item>
            /// <item><description><b>regex</b>: regular expression</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>contains</para>
            /// </summary>
            [NameInMap("Operate")]
            [Validation(Required=false)]
            public string Operate { get; set; }

            /// <summary>
            /// <para>The UUIDs of assets. Multiple UUIDs are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>6985b88c-eb19-4d27-98ad-e4a42312****,5721d503-9b04-4243-89ca-1fb8ca5e****,db2678c3-10e3-4a20-92f1-265f6****</para>
            /// </summary>
            [NameInMap("Uuids")]
            [Validation(Required=false)]
            public string Uuids { get; set; }

        }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>There was an error with your request.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public QueryGroupedSecurityEventMarkMissListResponseBodyPageInfo PageInfo { get; set; }
        public class QueryGroupedSecurityEventMarkMissListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page. Default value: <b>20</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>965F9282-D403-4FA2-B1B9-10F62DC719BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
