// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class LookupEventsRequest : TeaModel {
        /// <summary>
        /// <para>The order in which details of events are to be retrieved. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FORWARD: ascending order.</description></item>
        /// <item><description>BACKWARD: descending order. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BACKWARD</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The default time is the current time. Specify the time in the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-15T11:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Query conditions.</para>
        /// </summary>
        [NameInMap("LookupAttribute")]
        [Validation(Required=false)]
        public List<LookupEventsRequestLookupAttribute> LookupAttribute { get; set; }
        public class LookupEventsRequestLookupAttribute : TeaModel {
            /// <summary>
            /// <para>The key of the query condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ServiceName: the name of a specific Alibaba Cloud service.</description></item>
            /// <item><description>EventName: the name of a specific event.</description></item>
            /// <item><description>User: the name of the RAM user who calls a specific operation.</description></item>
            /// <item><description>EventId: the ID of a specific event.</description></item>
            /// <item><description>ResourceType: the type of resources.</description></item>
            /// <item><description>ResourceName: the name of a specific resource.</description></item>
            /// <item><description>EventRW: the read/write type of events.</description></item>
            /// <item><description>EventAccessKeyId: the AccessKey ID used in events.</description></item>
            /// </list>
            /// <remarks>
            /// <para>You can use only one query condition for each query.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ServiceName</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the query condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>When the LookupAttribute.N.Key parameter is set to ServiceName, you can set this parameter to a value such as <c>Ecs</c>.</description></item>
            /// <item><description>When the LookupAttribute.N.Key parameter is set to EventName, you can set this parameter to a value such as <c>ConsoleSignin</c>.</description></item>
            /// <item><description>When the LookupAttribute.N.Key parameter is set to User, you can set this parameter to a value such as <c>Alice</c>.</description></item>
            /// <item><description>When the LookupAttribute.N.Key parameter is set to EventId, you can set this parameter to a value such as <c>B702AFA3-FD4B-40E3-88E4-C0752FAA****</c>.</description></item>
            /// <item><description>When the LookupAttribute.N.Key parameter is set to ResourceType, you can set this parameter to a value such as <c>ACS::ECS::Instance</c>.</description></item>
            /// <item><description>When the LookupAttribute.N.Key parameter is set to ResourceName, you can set this parameter to a value such as <c>i-bp14664y88udkt45****</c>.</description></item>
            /// <item><description>When the LookupAttribute.N.Key parameter is set to EventRW, you can set this parameter to <c>Read</c> or <c>Write</c>.</description></item>
            /// <item><description>When the LookupAttribute.N.Key parameter is set to EventAccessKeyId, you can set this parameter to a value such as <c>LTAI****************</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Ecs</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries to be returned.</para>
        /// <para>Valid values: 0 to 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to request the next page of query results.</para>
        /// <remarks>
        /// <para>The request parameters must be the same as those of the last request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>eyJhY2NvdW50IjoiMTQyNDM3OTU4NjM4NzE2MSIsImV2ZW50SWQiOiI3MkJDRTExRi02OTU3LTQ0NUItQjY0MC1CNEUyMkM4NUEwQzgiLCJsb2dJZCI6IjgyLTE0MjQzNzk1ODYzODcxNjEiLCJ0aW1lIjoxNjAyMzExNTQwMD****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The default time is seven days prior to the current time. Specify the time in the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-08T11:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
