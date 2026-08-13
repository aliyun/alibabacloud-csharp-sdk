// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeControlPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the current page displayed in a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page displayed in a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The information about the access control policies.</para>
        /// </summary>
        [NameInMap("Policys")]
        [Validation(Required=false)]
        public List<DescribeControlPolicyResponseBodyPolicys> Policys { get; set; }
        public class DescribeControlPolicyResponseBodyPolicys : TeaModel {
            /// <summary>
            /// <para>The action that Cloud Firewall performs on the traffic in the access control policy. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("AclAction")]
            [Validation(Required=false)]
            public string AclAction { get; set; }

            /// <summary>
            /// <para>The unique ID of the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00281255-d220-4db1-8f4f-c4df221a****</para>
            /// </summary>
            [NameInMap("AclUuid")]
            [Validation(Required=false)]
            public string AclUuid { get; set; }

            /// <summary>
            /// <para>The application ID of the traffic in the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10***</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The application type supported by the access control policy. We recommend that you use ApplicationNameList. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>The list of application names.</para>
            /// </summary>
            [NameInMap("ApplicationNameList")]
            [Validation(Required=false)]
            public List<string> ApplicationNameList { get; set; }

            /// <summary>
            /// <para>The time when the policy was created. The value is a UNIX timestamp in seconds, which is the number of seconds that have elapsed since January 1, 1970 (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1761062400</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Allow access to office network segment</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination port of the traffic in the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("DestPort")]
            [Validation(Required=false)]
            public string DestPort { get; set; }

            /// <summary>
            /// <para>The name of the destination port address book in the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_port_group</para>
            /// </summary>
            [NameInMap("DestPortGroup")]
            [Validation(Required=false)]
            public string DestPortGroup { get; set; }

            /// <summary>
            /// <para>The list of ports in the destination port address book.</para>
            /// </summary>
            [NameInMap("DestPortGroupPorts")]
            [Validation(Required=false)]
            public List<string> DestPortGroupPorts { get; set; }

            /// <summary>
            /// <para>The type of the destination port in the access control policy. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>port</para>
            /// </summary>
            [NameInMap("DestPortType")]
            [Validation(Required=false)]
            public string DestPortType { get; set; }

            /// <summary>
            /// <para>The destination address in the access control policy. The value varies depending on the DestinationType (destination type). Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX/24</para>
            /// </summary>
            [NameInMap("Destination")]
            [Validation(Required=false)]
            public string Destination { get; set; }

            /// <summary>
            /// <para>The list of CIDR blocks in the destination address book of the access control policy.</para>
            /// </summary>
            [NameInMap("DestinationGroupCidrs")]
            [Validation(Required=false)]
            public List<string> DestinationGroupCidrs { get; set; }

            /// <summary>
            /// <para>The type of the destination address book in the access control policy. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("DestinationGroupType")]
            [Validation(Required=false)]
            public string DestinationGroupType { get; set; }

            /// <summary>
            /// <para>The type of the destination address in the access control policy. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>net</para>
            /// </summary>
            [NameInMap("DestinationType")]
            [Validation(Required=false)]
            public string DestinationType { get; set; }

            /// <summary>
            /// <para>The traffic direction of the access control policy. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The DNS resolution result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX,192.0.XX.XX</para>
            /// </summary>
            [NameInMap("DnsResult")]
            [Validation(Required=false)]
            [Obsolete]
            public string DnsResult { get; set; }

            /// <summary>
            /// <para>The timestamp of the DNS resolution. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1579261141</para>
            /// </summary>
            [NameInMap("DnsResultTime")]
            [Validation(Required=false)]
            public long? DnsResultTime { get; set; }

            /// <summary>
            /// <para>The domain name resolution method of the access control policy. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>FQDN</para>
            /// </summary>
            [NameInMap("DomainResolveType")]
            [Validation(Required=false)]
            public string DomainResolveType { get; set; }

            /// <summary>
            /// <para>The end time of the policy validity period for the access control policy. The value is a UNIX timestamp in seconds. The value must be on the hour or half hour and must be at least 30 minutes later than the start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1694764800</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The most recent time of hits. The value is in the format of a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1579261141</para>
            /// </summary>
            [NameInMap("HitLastTime")]
            [Validation(Required=false)]
            public long? HitLastTime { get; set; }

            /// <summary>
            /// <para>The number of hits for the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("HitTimes")]
            [Validation(Required=false)]
            public long? HitTimes { get; set; }

            /// <summary>
            /// <para>The supported IP address version. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public int? IpVersion { get; set; }

            /// <summary>
            /// <para>The time when the policy was last modified. The value is a UNIX timestamp in seconds, which is the number of seconds that have elapsed since January 1, 1970 (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1761062400</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The priority of the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            /// <summary>
            /// <para>The security protocol type of the traffic in the access control policy. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Proto")]
            [Validation(Required=false)]
            public string Proto { get; set; }

            /// <summary>
            /// <para>The enabled status of the access control policy. The policy is enabled by default after creation. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Release")]
            [Validation(Required=false)]
            public string Release { get; set; }

            /// <summary>
            /// <para>The collection of recurrence days for the policy validity period of the access control policy.</para>
            /// </summary>
            [NameInMap("RepeatDays")]
            [Validation(Required=false)]
            public List<long?> RepeatDays { get; set; }

            /// <summary>
            /// <para>The recurrence end time of the policy validity period for the access control policy. Example: 23:30. The value must be on the hour or half hour and must be at least 30 minutes later than the recurrence start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23:30</para>
            /// </summary>
            [NameInMap("RepeatEndTime")]
            [Validation(Required=false)]
            public string RepeatEndTime { get; set; }

            /// <summary>
            /// <para>The recurrence start time of the policy validity period for the access control policy. Example: 08:00. The value must be on the hour or half hour and must be at least 30 minutes earlier than the recurrence end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08:00</para>
            /// </summary>
            [NameInMap("RepeatStartTime")]
            [Validation(Required=false)]
            public string RepeatStartTime { get; set; }

            /// <summary>
            /// <para>The recurrence type of the policy validity period for the access control policy. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>Permanent</para>
            /// </summary>
            [NameInMap("RepeatType")]
            [Validation(Required=false)]
            public string RepeatType { get; set; }

            /// <summary>
            /// <para>The source address in the access control policy. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX/24</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The list of CIDR blocks in the source address book of the access control policy.</para>
            /// </summary>
            [NameInMap("SourceGroupCidrs")]
            [Validation(Required=false)]
            public List<string> SourceGroupCidrs { get; set; }

            /// <summary>
            /// <para>The type of the source address book in the access control policy. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("SourceGroupType")]
            [Validation(Required=false)]
            public string SourceGroupType { get; set; }

            /// <summary>
            /// <para>The type of the source address in the access control policy. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>net</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The number of quota units consumed by the access control policy, which is the cumulative number of quota units consumed by each policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("SpreadCnt")]
            [Validation(Required=false)]
            public int? SpreadCnt { get; set; }

            /// <summary>
            /// <para>The start time of the policy validity period for the access control policy. The value is a UNIX timestamp in seconds. The value must be on the hour or half hour and must be at least 30 minutes earlier than the end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1694761200</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of the access control policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
