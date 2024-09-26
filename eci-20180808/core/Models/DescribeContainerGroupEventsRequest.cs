// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeContainerGroupEventsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the elastic container instances. You can specify up to 20 IDs. Each ID must be a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;eci-bp17gw49eu09yiwm****&quot;, &quot;eci-bp19aq49du01abcm****&quot;, &quot;eci-2zegym1qhbmdfr1s****&quot;]</para>
        /// </summary>
        [NameInMap("ContainerGroupIds")]
        [Validation(Required=false)]
        public string ContainerGroupIds { get; set; }

        /// <summary>
        /// <para>The event source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EciService</description></item>
        /// <item><description>K8sAgent</description></item>
        /// </list>
        /// <para>This parameter is empty by default. This indicates that all events are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>K8sAgent</para>
        /// </summary>
        [NameInMap("EventSource")]
        [Validation(Required=false)]
        public string EventSource { get; set; }

        /// <summary>
        /// <para>The maximum number of elastic container instances to be returned for this request. Default value: 200.</para>
        /// <remarks>
        /// <para> The number of elastic container instances to be returned is no greater than this parameter value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// <para>You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d78f2dd8-5979-42fe-xaee-b16db43be5bc</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-uf66jeqopgqa9hdn****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>A relative time in seconds before the current time from which to show event information. This parameter is used to poll incremental events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("SinceSecond")]
        [Validation(Required=false)]
        public int? SinceSecond { get; set; }

        /// <summary>
        /// <para>The tag that is added to the elastic container instances.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeContainerGroupEventsRequestTag> Tag { get; set; }
        public class DescribeContainerGroupEventsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6h3rbwbm90urjwa****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-k</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
