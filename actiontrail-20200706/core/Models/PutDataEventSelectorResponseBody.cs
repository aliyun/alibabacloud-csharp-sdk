// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class PutDataEventSelectorResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration of the data event selector. This parameter is a JSON array that can contain a maximum of 20 elements.</para>
        /// <para>Each element in the JSON array includes the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ServiceName</c>: The name of the Alibaba Cloud service that supports data events.</para>
        /// </description></item>
        /// <item><description><para><c>ReadWriteType</c>: The type of data event. Valid values: Read, Write, and All.</para>
        /// </description></item>
        /// <item><description><para><c>EventName</c>: This field contains the <c>Equals</c> and <c>NotEquals</c> subfields.</para>
        /// <para>For example, the following configuration specifies that only <c>GetObject</c>, <c>CopyObject</c>, and <c>AppendObject</c> events are delivered:</para>
        /// <para><c>{&quot;EventName&quot;:{&quot;Equals&quot;:[&quot;GetObject&quot;,&quot;CopyObject&quot;,&quot;AppendObject&quot;]}}</c></para>
        /// <para>If you specify <c>NotEquals</c>, events other than <c>GetObject</c>, <c>CopyObject</c>, and <c>AppendObject</c> are delivered.</para>
        /// </description></item>
        /// <item><description><para><c>ResourceArn</c>: This field also contains the <c>Equals</c> and <c>NotEquals</c> subfields, similar to <c>EventName</c>. For example:</para>
        /// <para><c>{&quot;ResourceArn&quot;:{&quot;Equals&quot;:[arn1,...,arnx]}}</c></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;EventName&quot;:{&quot;Equals&quot;:[&quot;GetObject&quot;,&quot;CopyObject&quot;,&quot;AppendObject&quot;]},&quot;ReadWriteType&quot;:&quot;All&quot;,&quot;ServiceName&quot;:&quot;Oss&quot;}]</para>
        /// </summary>
        [NameInMap("DataEventSelectors")]
        [Validation(Required=false)]
        public string DataEventSelectors { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>243E1250-32DA-493B-9347-3C7EEE07****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the trail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:actiontrail:cn-shanghai:159498693826****:trail/trail-name</para>
        /// </summary>
        [NameInMap("TrailArn")]
        [Validation(Required=false)]
        public string TrailArn { get; set; }

    }

}
