// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListTrafficMirrorSessionsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the traffic mirror session is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): The traffic mirror session is not enabled.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: The traffic mirror session is enabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return in this query. Valid values: <b>1</b> to <b>100</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter for the first request or if no next query exists.</description></item>
        /// <item><description>If a next query exists, set the value to the NextToken value returned in the previous API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The priority of traffic mirror session. Valid values: <b>1</b> to <b>32766</b>.</para>
        /// <para>A smaller value indicates a higher priority. The priority of traffic mirror session created by the same account in the same region must be unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The region ID of the traffic mirror session. You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID. For information about the regions that support traffic mirroring, see <a href="https://help.aliyun.com/document_detail/207513.html">Traffic mirroring overview</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hongkong</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the traffic mirroring session belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListTrafficMirrorSessionsRequestTags> Tags { get; set; }
        public class ListTrafficMirrorSessionsRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The instance ID of the traffic mirror filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tmf-j6cmls82xnc86vtpe****</para>
        /// </summary>
        [NameInMap("TrafficMirrorFilterId")]
        [Validation(Required=false)]
        public string TrafficMirrorFilterId { get; set; }

        /// <summary>
        /// <para>The instance IDs of traffic mirror sessions. The maximum value of <b>N</b> is <b>100</b>, which means you can query up to 100 traffic mirror sessions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tms-j6cla50buc44ap8tu****</para>
        /// </summary>
        [NameInMap("TrafficMirrorSessionIds")]
        [Validation(Required=false)]
        public List<string> TrafficMirrorSessionIds { get; set; }

        /// <summary>
        /// <para>The name of the traffic mirror session.</para>
        /// <para>The name must be 1 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("TrafficMirrorSessionName")]
        [Validation(Required=false)]
        public string TrafficMirrorSessionName { get; set; }

        /// <summary>
        /// <para>The instance ID of the traffic mirror source. Currently, elastic network interfaces (ENIs) are supported as traffic mirror sources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-j6c8znm5l1yt4sox*****</para>
        /// </summary>
        [NameInMap("TrafficMirrorSourceId")]
        [Validation(Required=false)]
        public string TrafficMirrorSourceId { get; set; }

        /// <summary>
        /// <para>The instance ID of the traffic mirror destination. Currently, elastic network interfaces (ENIs) and internal-facing SLB instances are supported as traffic mirror destinations. Elastic network interfaces are also referred to as network interface controllers (NICs).</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-j6c2fp57q8rr47rp****</para>
        /// </summary>
        [NameInMap("TrafficMirrorTargetId")]
        [Validation(Required=false)]
        public string TrafficMirrorTargetId { get; set; }

        /// <summary>
        /// <para>The Virtual Network Identifier (VNI) used to distinguish different mirrored data. Valid values: <b>0</b> to <b>16777215</b>. You can use the VNI to identify mirrored data from different sessions at the traffic mirror destination. You can specify a custom VNI value or let the system randomly assign one. To let the system randomly assign a value, do not specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("VirtualNetworkId")]
        [Validation(Required=false)]
        public int? VirtualNetworkId { get; set; }

    }

}
