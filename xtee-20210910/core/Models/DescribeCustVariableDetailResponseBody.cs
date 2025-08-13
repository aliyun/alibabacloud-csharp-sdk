// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeCustVariableDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeCustVariableDetailResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeCustVariableDetailResponseBodyResultObject : TeaModel {
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
            /// <para>Description information.</para>
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
            /// <para>de_ahespg8137</para>
            /// </summary>
            [NameInMap("eventCodes")]
            [Validation(Required=false)]
            public string EventCodes { get; set; }

            /// <summary>
            /// <para>Value type</para>
            /// 
            /// <b>Example:</b>
            /// <para>EARLIEST</para>
            /// </summary>
            [NameInMap("historyValueType")]
            [Validation(Required=false)]
            public string HistoryValueType { get; set; }

            /// <summary>
            /// <para>Primary key ID of the cumulative variable</para>
            /// 
            /// <b>Example:</b>
            /// <para>2793</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Cumulative object</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEpage</para>
            /// </summary>
            [NameInMap("object")]
            [Validation(Required=false)]
            public string Object { get; set; }

            /// <summary>
            /// <para>Variable return type</para>
            /// 
            /// <b>Example:</b>
            /// <para>DOUBLE</para>
            /// </summary>
            [NameInMap("outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            /// <summary>
            /// <para>Main object</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEpname</para>
            /// </summary>
            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// <para>Time slice type</para>
            /// 
            /// <b>Example:</b>
            /// <para>NEAR</para>
            /// </summary>
            [NameInMap("timeType")]
            [Validation(Required=false)]
            public string TimeType { get; set; }

            /// <summary>
            /// <para>Title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>累计变量求平均值</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>Time count</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("twCount")]
            [Validation(Required=false)]
            public string TwCount { get; set; }

            /// <summary>
            /// <para>Variable type</para>
            /// 
            /// <b>Example:</b>
            /// <para>DISTINCT</para>
            /// </summary>
            [NameInMap("velocityFC")]
            [Validation(Required=false)]
            public string VelocityFC { get; set; }

            /// <summary>
            /// <para>Time slice unit</para>
            /// 
            /// <b>Example:</b>
            /// <para>HOUR_1</para>
            /// </summary>
            [NameInMap("velocityTW")]
            [Validation(Required=false)]
            public string VelocityTW { get; set; }

        }

    }

}
