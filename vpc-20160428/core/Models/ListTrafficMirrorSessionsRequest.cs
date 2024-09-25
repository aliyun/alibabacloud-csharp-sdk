// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListTrafficMirrorSessionsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the traffic mirror session. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: does not enable the traffic mirror session.</description></item>
        /// <item><description><b>true</b>: enables the traffic mirror session.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return. Valid values: <b>1</b> to <b>100</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is your first query and no next queries are to be sent, ignore this parameter.</description></item>
        /// <item><description>If a next query is to be sent, set the value to the value of NextToken that is returned from the last call.</description></item>
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
        /// <para>The priority of the traffic mirror session. Valid values: <b>1</b> to <b>32766</b>.</para>
        /// <para>A smaller value indicates a higher priority. You cannot specify identical priorities for traffic mirror sessions that are created in the same region by using the same account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the traffic mirror session belongs. You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list. For more information about regions that support traffic mirroring, see <a href="https://help.aliyun.com/document_detail/207513.html">Overview of traffic mirroring</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hongkong</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the mirrored traffic belongs.</para>
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
        /// <para>The tags of the resource.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListTrafficMirrorSessionsRequestTags> Tags { get; set; }
        public class ListTrafficMirrorSessionsRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key. You can specify at most 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The key cannot exceed 64 characters in length, and can contain digits, periods (.), underscores (_), and hyphens (-). The key must start with a letter but cannot start with <c>aliyun</c> or <c>acs:</c>. The key cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. You can specify at most 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value cannot exceed 128 characters in length, and can contain digits, periods (.), underscores (_), and hyphens (-). It must start with a letter but cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the traffic mirror filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tmf-j6cmls82xnc86vtpe****</para>
        /// </summary>
        [NameInMap("TrafficMirrorFilterId")]
        [Validation(Required=false)]
        public string TrafficMirrorFilterId { get; set; }

        /// <summary>
        /// <para>The IDs of the traffic mirror session. The maximum value of N is 100, which indicates that you can query up to 100 traffic mirror sessions at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tms-j6cla50buc44ap8tu****</para>
        /// </summary>
        [NameInMap("TrafficMirrorSessionIds")]
        [Validation(Required=false)]
        public List<string> TrafficMirrorSessionIds { get; set; }

        /// <summary>
        /// <para>The name of the traffic mirror session.</para>
        /// <para>The name must be 1 to 128 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("TrafficMirrorSessionName")]
        [Validation(Required=false)]
        public string TrafficMirrorSessionName { get; set; }

        /// <summary>
        /// <para>The ID of the traffic mirror source. You can specify only an elastic network interface (ENI) as the mirror source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-j6c8znm5l1yt4sox*****</para>
        /// </summary>
        [NameInMap("TrafficMirrorSourceId")]
        [Validation(Required=false)]
        public string TrafficMirrorSourceId { get; set; }

        /// <summary>
        /// <para>The ID of the traffic mirror destination. You can specify only an ENI or a Server Load Balancer (SLB) instance as a traffic mirror destination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-j6c2fp57q8rr47rp****</para>
        /// </summary>
        [NameInMap("TrafficMirrorTargetId")]
        [Validation(Required=false)]
        public string TrafficMirrorTargetId { get; set; }

        /// <summary>
        /// <para>The VXLAN network identifier (VNI) that is used to distinguish different mirrored traffic. Valid values: <b>0</b> to <b>16777215</b>. You can use VNIs to identify mirrored traffic from different sessions at the traffic mirror destination. You can specify a custom VNI or use a random VNI that is allocated by the system. If you want the system to randomly allocate a VNI, ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("VirtualNetworkId")]
        [Validation(Required=false)]
        public int? VirtualNetworkId { get; set; }

    }

}
