// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class PutDataEventSelectorRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the data event selector. This parameter is a JSON array that can contain a maximum of 20 elements.</para>
        /// <para>Each element in the JSON array includes the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ServiceName</c>: The name of the Alibaba Cloud service that supports data events.</para>
        /// </description></item>
        /// <item><description><para><c>ReadWriteType</c>: The type of data event. Valid values: Read, Write, and All.</para>
        /// </description></item>
        /// <item><description><para><c>EventName</c>: This field contains the <c>Equals</c> and <c>NotEquals</c> subfields.</para>
        /// <para>For example, the following configuration specifies that only <c>GetObject</c>, <c>CopyObject</c>, and <c>AppendObject</c>events are delivered:</para>
        /// <para><c>{&quot;EventName&quot;:{&quot;Equals&quot;:[&quot;GetObject&quot;,&quot;CopyObject&quot;,&quot;AppendObject&quot;]}}</c></para>
        /// <para>If you specify <c>NotEquals</c>, events other than <c>GetObject</c>, <c>CopyObject</c>, and <c>AppendObject</c> are delivered.</para>
        /// </description></item>
        /// <item><description><para><c>ResourceArn</c>: This field also contains the <c>Equals</c> and <c>NotEquals</c> subfields, similar to <c>EventName</c>. For example:</para>
        /// <para><c>{&quot;ResourceArn&quot;:{&quot;Equals&quot;:[arn1,...,arnx]}}</c></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;EventName&quot;:{&quot;Equals&quot;:[&quot;GetObject&quot;,&quot;CopyObject&quot;,&quot;AppendObject&quot;]},&quot;ReadWriteType&quot;:&quot;All&quot;,&quot;ServiceName&quot;:&quot;Oss&quot;}]</para>
        /// </summary>
        [NameInMap("EventSelectors")]
        [Validation(Required=false)]
        public string EventSelectors { get; set; }

        /// <summary>
        /// <para>Specifies whether the trail tracks data events in all regions.</para>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTrailAllRegion")]
        [Validation(Required=false)]
        public bool? IsTrailAllRegion { get; set; }

        /// <summary>
        /// <para>The name of the trail.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trail-name</para>
        /// </summary>
        [NameInMap("TrailName")]
        [Validation(Required=false)]
        public string TrailName { get; set; }

        /// <summary>
        /// <para>The regions where the trail tracks data events. Separate multiple region IDs with a comma (<c>,</c>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai,cn-hangzhou</para>
        /// </summary>
        [NameInMap("TrailRegionIds")]
        [Validation(Required=false)]
        public string TrailRegionIds { get; set; }

    }

}
