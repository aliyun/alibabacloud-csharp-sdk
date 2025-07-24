// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetVpcPrefixListAssociationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value is used to retrieve a new page of results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The information about the network instances that are associated with the prefix list.</para>
        /// </summary>
        [NameInMap("PrefixListAssociation")]
        [Validation(Required=false)]
        public List<GetVpcPrefixListAssociationsResponseBodyPrefixListAssociation> PrefixListAssociation { get; set; }
        public class GetVpcPrefixListAssociationsResponseBodyPrefixListAssociation : TeaModel {
            /// <summary>
            /// <para>List of CIDR addresses where the prefix list is effective in the currently associated resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.0/16</para>
            /// </summary>
            [NameInMap("CidrList")]
            [Validation(Required=false)]
            public string CidrList { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the prefix list belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>153460731706****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>The prefix list ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pl-0b7hwu67****</para>
            /// </summary>
            [NameInMap("PrefixListId")]
            [Validation(Required=false)]
            public string PrefixListId { get; set; }

            /// <summary>
            /// <para>The reason why the association failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>failed</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The region ID of the prefix list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the associated resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-bp1drpcfz9srr393h****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The type of the associated resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>vpcRouteTable</b>: virtual private cloud (VPC) route table.</description></item>
            /// <item><description><b>trRouteTable</b>: route table of a transit router.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vpcRouteTable</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the resource associated with the prefix list belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>132193271328****</para>
            /// </summary>
            [NameInMap("ResourceUid")]
            [Validation(Required=false)]
            public string ResourceUid { get; set; }

            /// <summary>
            /// <para>The status of the prefix list. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Created</b></description></item>
            /// <item><description><b>ModifyFailed</b></description></item>
            /// <item><description><b>Creating</b></description></item>
            /// <item><description><b>Modifying</b></description></item>
            /// <item><description><b>Deleting</b></description></item>
            /// <item><description><b>Deleted</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EC47282-1B74-4534-BD0E-403F3EE64CAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
