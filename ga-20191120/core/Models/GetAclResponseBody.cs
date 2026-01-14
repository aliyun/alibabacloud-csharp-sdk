// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class GetAclResponseBody : TeaModel {
        /// <summary>
        /// <para>The entries of the ACL.</para>
        /// </summary>
        [NameInMap("AclEntries")]
        [Validation(Required=false)]
        public List<GetAclResponseBodyAclEntries> AclEntries { get; set; }
        public class GetAclResponseBodyAclEntries : TeaModel {
            /// <summary>
            /// <para>An IP address entry (192.168.XX.XX) or a CIDR block entry (10.0.XX.XX/24).</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX/24</para>
            /// </summary>
            [NameInMap("Entry")]
            [Validation(Required=false)]
            public string Entry { get; set; }

            /// <summary>
            /// <para>The description of the ACL entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-entry</para>
            /// </summary>
            [NameInMap("EntryDescription")]
            [Validation(Required=false)]
            public string EntryDescription { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nacl-hp34s2h0xx1ht4nwo****</para>
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// <para>The ID of the GA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-acl</para>
        /// </summary>
        [NameInMap("AclName")]
        [Validation(Required=false)]
        public string AclName { get; set; }

        /// <summary>
        /// <para>The IP version of the network ACL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPv4</b></description></item>
        /// <item><description><b>IPv6</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("AclStatus")]
        [Validation(Required=false)]
        public string AclStatus { get; set; }

        /// <summary>
        /// <para>The ID of the network ACL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("AddressIPVersion")]
        [Validation(Required=false)]
        public string AddressIPVersion { get; set; }

        /// <summary>
        /// <para>The listeners that are associated with the ACL.</para>
        /// </summary>
        [NameInMap("RelatedListeners")]
        [Validation(Required=false)]
        public List<GetAclResponseBodyRelatedListeners> RelatedListeners { get; set; }
        public class GetAclResponseBodyRelatedListeners : TeaModel {
            /// <summary>
            /// <para>The ID of the GA instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ga-bp1odcab8tmno0hdq****</para>
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// <para>The type of the ACL. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>white</b>: Only requests from the IP addresses or CIDR blocks in the ACL are forwarded. Whitelists are suitable for scenarios in which you want to allow access from specific IP addresses to an application. If a whitelist is improperly configured, risks may arise. After a whitelist is configured for a listener, only requests from the IP addresses that are added to the whitelist are distributed by the listener. If a whitelist is enabled but no IP address is added to the whitelist, the listener forwards all requests.</description></item>
            /// <item><description><b>black</b>: All requests from the IP addresses or CIDR blocks in the ACL are rejected. Blacklists are suitable for scenarios in which you want to deny access from specific IP addresses to an application. If a blacklist is enabled but no IP address is added to the blacklist, the listener forwards all requests.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>White</para>
            /// </summary>
            [NameInMap("AclType")]
            [Validation(Required=false)]
            public string AclType { get; set; }

            /// <summary>
            /// <para>The ID of the listener.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lsr-bp1bpn0kn908w4nbw****</para>
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the network ACL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BA984</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The name of the network ACL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmx7itmygzsza</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tag of the ACL.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetAclResponseBodyTags> Tags { get; set; }
        public class GetAclResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The key of tag N that is add to the ACL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N that is add to the ACL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
