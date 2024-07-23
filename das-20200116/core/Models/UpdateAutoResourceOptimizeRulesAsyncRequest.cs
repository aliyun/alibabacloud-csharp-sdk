// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class UpdateAutoResourceOptimizeRulesAsyncRequest : TeaModel {
        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("ConsoleContext")]
        [Validation(Required=false)]
        public string ConsoleContext { get; set; }

        /// <summary>
        /// <para>The database instance IDs.</para>
        /// <remarks>
        /// <para> Set this parameter to a JSON array that consists of multiple instance IDs. Separate instance IDs with commas (,). Example: <c>[\\&quot;Instance ID1\\&quot;, \\&quot;Instance ID2\\&quot;]</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;rm-2ze8g2am97624****\&quot;,\&quot;rm-2ze9xrhze0709****\&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The ID of the asynchronous request.</para>
        /// <remarks>
        /// <para> Asynchronous calls do not immediately return the complete results. To obtain the complete results, you must use the value of <b>ResultId</b> returned in the response to re-initiate the call until the value of <b>isFinish</b> is <b>true</b>.**** In this case, you must call this operation at least twice.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>async__507044db6c4eadfa2dab9b084e80****</para>
        /// </summary>
        [NameInMap("ResultId")]
        [Validation(Required=false)]
        public string ResultId { get; set; }

        /// <summary>
        /// <para>The fragmentation rate that triggers automatic fragment recycling of a single physical table. Valid values: <b>0.10</b> to <b>0.99</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.2</para>
        /// </summary>
        [NameInMap("TableFragmentationRatio")]
        [Validation(Required=false)]
        public double? TableFragmentationRatio { get; set; }

        /// <summary>
        /// <para>The minimum storage usage that triggers automatic fragment recycling of a single physical table. Valid values: <b>5</b> to <b>100</b>. Unit: GB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TableSpaceSize")]
        [Validation(Required=false)]
        public double? TableSpaceSize { get; set; }

    }

}
