// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The action that Cloud Firewall performs on the traffic that matches the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>accept</b>: Allow</para>
        /// </description></item>
        /// <item><description><para><b>drop</b>: Deny</para>
        /// </description></item>
        /// <item><description><para><b>log</b>: Monitor</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, all action types are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>accept</para>
        /// </summary>
        [NameInMap("AclAction")]
        [Validation(Required=false)]
        public string AclAction { get; set; }

        /// <summary>
        /// <para>The unique ID of the access control policy. You must specify at least one of AclUuid and Direction. If you specify AclUuid, you can query the policy by its ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00281255-d220-4db1-8f4f-c4df221a****</para>
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// <para>The page number of the current page returned for a paged query during paging.</para>
        /// <para>Default value: 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The description of the access control policy. Fuzzy match is supported.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the descriptions of all policies are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Allow access to the office CIDR block</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination address in the access control policy. Fuzzy match is supported. The value of Destination varies based on the destination type (DestinationType).</para>
        /// <list type="bullet">
        /// <item><description><para>If DestinationType is set to <c>net</c>, the destination address is a CIDR block. Example: 10.0.3.0/24.</para>
        /// </description></item>
        /// <item><description><para>If DestinationType is set to <c>domain</c>, the destination address is a domain name. Example: aliyun.</para>
        /// </description></item>
        /// <item><description><para>If DestinationType is set to <c>group</c>, the destination address is the name of an address book. Example: db_group.</para>
        /// </description></item>
        /// <item><description><para>If DestinationType is set to <c>location</c>, the destination address is an area name. For more information about the area positional encoding, see AddControlPolicy. Example: [&quot;BJ11&quot;, &quot;ZB&quot;].</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter in the Settings, all types of destination addresses are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        /// <summary>
        /// <para>The traffic direction controlled by the access control policy. Valid values: in (inbound) and out (outbound). You must specify at least one of Direction and AclUuid. If AclUuid is not specified, you must specify a non-empty Direction. Otherwise, ErrorParametersDirection is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>in</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The IP address version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>4</b> (default): IPv4</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: IPv6</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page for a paged query during paging.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The protocol type of the traffic in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TCP</b></description></item>
        /// <item><description><b>UDP</b></description></item>
        /// <item><description><b>ICMP</b></description></item>
        /// <item><description><b>ANY</b> (all protocol types)<remarks>
        /// <para>If you do not specify this parameter, all protocol types are queried.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("Proto")]
        [Validation(Required=false)]
        public string Proto { get; set; }

        /// <summary>
        /// <para>Specifies whether the access control policy is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The access control policy is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The access control policy is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Release")]
        [Validation(Required=false)]
        public string Release { get; set; }

        /// <summary>
        /// <para>The recurrence type of the Policy Validity Period for the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Permanent</b> (default): Always</description></item>
        /// <item><description><b>None</b>: One-time</description></item>
        /// <item><description><b>Daily</b>: Daily</description></item>
        /// <item><description><b>Weekly</b>: Weekly</description></item>
        /// <item><description><b>Monthly</b>: Monthly</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Permanent</para>
        /// </summary>
        [NameInMap("RepeatType")]
        [Validation(Required=false)]
        public string RepeatType { get; set; }

        /// <summary>
        /// <para>The source address in the access control policy. Fuzzy match is supported. The value of Source varies based on the value of SourceType.</para>
        /// <list type="bullet">
        /// <item><description><para>If SourceType is set to <c>net</c>, the source address is a CIDR block. Example: 192.0.XX.XX/24.</para>
        /// </description></item>
        /// <item><description><para>If SourceType is set to <c>group</c>, the source address is the name of a source address book. Example: db_group. If this parameter is left empty, all access sources are queried.</para>
        /// </description></item>
        /// <item><description><para>If SourceType is set to <c>location</c>, the source address is a source region. Example: Beijing or beijing. Both Chinese and English region names are supported.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, all types of access sources are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
