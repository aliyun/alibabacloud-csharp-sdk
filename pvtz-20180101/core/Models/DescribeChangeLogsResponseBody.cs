// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeChangeLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The operation logs.</para>
        /// </summary>
        [NameInMap("ChangeLogs")]
        [Validation(Required=false)]
        public DescribeChangeLogsResponseBodyChangeLogs ChangeLogs { get; set; }
        public class DescribeChangeLogsResponseBodyChangeLogs : TeaModel {
            [NameInMap("ChangeLog")]
            [Validation(Required=false)]
            public List<DescribeChangeLogsResponseBodyChangeLogsChangeLog> ChangeLog { get; set; }
            public class DescribeChangeLogsResponseBodyChangeLogsChangeLog : TeaModel {
                /// <summary>
                /// <para>The operation content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Add RR:test.03 Type:A Line:default TTL:300 Value:172.20.XX.XX</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The operator ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>141339776561****</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The subtype of the operator. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CUSTOMER: Alibaba Cloud account</description></item>
                /// <item><description>SUB: RAM user</description></item>
                /// <item><description>STS: assumed role that obtains the Security Token Service (STS) token of a RAM role</description></item>
                /// <item><description>OTHER: other types</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SUB</para>
                /// </summary>
                [NameInMap("CreatorSubType")]
                [Validation(Required=false)]
                public string CreatorSubType { get; set; }

                /// <summary>
                /// <para>The operator type. No value or <b>USER</b> is returned for this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>USER</para>
                /// </summary>
                [NameInMap("CreatorType")]
                [Validation(Required=false)]
                public string CreatorType { get; set; }

                /// <summary>
                /// <para>The operator ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>141339776561****</para>
                /// </summary>
                [NameInMap("CreatorUserId")]
                [Validation(Required=false)]
                public string CreatorUserId { get; set; }

                /// <summary>
                /// <para>The unique ID of the zone, user-defined line, forwarding rule, outbound endpoint, or inbound endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>df2d03865266bd9842306db586d3****</para>
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>The name of the object on which the operation was performed, such as the domain name, user-defined line, cache retention domain name, forwarding rule, outbound endpoint, or inbound endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-api.com</para>
                /// </summary>
                [NameInMap("EntityName")]
                [Validation(Required=false)]
                public string EntityName { get; set; }

                /// <summary>
                /// <para>The ID of the operation log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90761578646770****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The specific operation performed on the object, such as adding, deleting, modifying, or associating the object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>add</para>
                /// </summary>
                [NameInMap("OperAction")]
                [Validation(Required=false)]
                public string OperAction { get; set; }

                /// <summary>
                /// <para>The public IP address of the operator terminal. If the IP address of the operator terminal is a private IP address, the value of this parameter is the public IP address to which the private IP address is mapped after network address translation (NAT).</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.0.XX.XX</para>
                /// </summary>
                [NameInMap("OperIp")]
                [Validation(Required=false)]
                public string OperIp { get; set; }

                /// <summary>
                /// <para>The type of the object on which the operation was performed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PV_ZONE</b>: the built-in authoritative zone</description></item>
                /// <item><description><b>PV_RECORD</b>: the DNS record</description></item>
                /// <item><description><b>RESOLVER_RULE</b>: the forwarding rule</description></item>
                /// <item><description><b>CUSTOM_LINE</b>: the user-defined line</description></item>
                /// <item><description><b>RESOLVER_ENDPOINT</b>: the outbound endpoint</description></item>
                /// <item><description><b>INBOUND_ENDPOINT</b>: the inbound endpoint</description></item>
                /// <item><description><b>CACHE_RESERVE_DOMAIN</b>: the cache retention domain name</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PV_ZONE</para>
                /// </summary>
                [NameInMap("OperObject")]
                [Validation(Required=false)]
                public string OperObject { get; set; }

                /// <summary>
                /// <para>The time when the operation is performed. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-01-24T07:35Z</para>
                /// </summary>
                [NameInMap("OperTime")]
                [Validation(Required=false)]
                public string OperTime { get; set; }

                /// <summary>
                /// <para>The time when the operation was performed. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1516779348000</para>
                /// </summary>
                [NameInMap("OperTimestamp")]
                [Validation(Required=false)]
                public long? OperTimestamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F0FCB52A-D512-41A0-8595-40234EDCFD8B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
