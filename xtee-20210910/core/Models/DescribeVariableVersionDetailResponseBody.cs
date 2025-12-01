// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeVariableVersionDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeVariableVersionDetailResponseBodyResultObject ResultObject { get; set; }
        public class DescribeVariableVersionDetailResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Condition value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;currentId&quot;:1,&quot;deepCount&quot;:0,&quot;list&quot;:[{&quot;currentId&quot;:2,&quot;deepCount&quot;:1,&quot;left&quot;:{&quot;code&quot;:&quot;accountId&quot;,&quot;fieldType&quot;:&quot;STRING&quot;,&quot;functionName&quot;:&quot;&quot;,&quot;hasRightVariable&quot;:false,&quot;name&quot;:&quot;accountId&quot;},&quot;operatorCode&quot;:&quot;isNotEmptyWrapper&quot;,&quot;parentId&quot;:1,&quot;right&quot;:{&quot;code&quot;:&quot;\&quot;A\nB\nC\&quot;&quot;,&quot;functionName&quot;:&quot;&quot;,&quot;name&quot;:&quot;&quot;,&quot;rightVariableType&quot;:&quot;constant&quot;}}],&quot;parentId&quot;:0,&quot;relationship&quot;:&quot;and&quot;}</para>
            /// </summary>
            [NameInMap("condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// <para>Data version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("dataVersion")]
            [Validation(Required=false)]
            public long? DataVersion { get; set; }

            /// <summary>
            /// <para>Variable description information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>变量描述</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Event code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>de_awkhwh0314</para>
            /// </summary>
            [NameInMap("eventCodes")]
            [Validation(Required=false)]
            public string EventCodes { get; set; }

            /// <summary>
            /// <para>Global cumulative. Not currently available externally.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("global")]
            [Validation(Required=false)]
            public bool? Global { get; set; }

            /// <summary>
            /// <para>Historical value parameter type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COUNT</para>
            /// </summary>
            [NameInMap("historyValueType")]
            [Validation(Required=false)]
            public string HistoryValueType { get; set; }

            /// <summary>
            /// <para>Primary key ID of the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3434</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Subordinate attribute (single selection, sourced from the event attribute list code).</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("object")]
            [Validation(Required=false)]
            public string Object { get; set; }

            /// <summary>
            /// <para>Status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ENABLE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Main attribute (multiple separated by commas, up to 5, sourced from the event attribute list code).</para>
            /// 
            /// <b>Example:</b>
            /// <para>age</para>
            /// </summary>
            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// <para>Time slice type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CURRENT</para>
            /// </summary>
            [NameInMap("timeType")]
            [Validation(Required=false)]
            public string TimeType { get; set; }

            /// <summary>
            /// <para>Title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>累计个数</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>Top N.</para>
            /// 
            /// <b>Example:</b>
            /// <para>topN累计</para>
            /// </summary>
            [NameInMap("topN")]
            [Validation(Required=false)]
            public long? TopN { get; set; }

            /// <summary>
            /// <para>Number of time slices.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("twCount")]
            [Validation(Required=false)]
            public long? TwCount { get; set; }

            /// <summary>
            /// <para>Cumulative indicator processing function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COUNT</para>
            /// </summary>
            [NameInMap("velocityFC")]
            [Validation(Required=false)]
            public string VelocityFC { get; set; }

            /// <summary>
            /// <para>Cumulative indicator time window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MONTH_1</para>
            /// </summary>
            [NameInMap("velocityTW")]
            [Validation(Required=false)]
            public string VelocityTW { get; set; }

        }

    }

}
