// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeAnalysisConditionFavoriteListResponseBody : TeaModel {
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
        /// <para>Returned object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeAnalysisConditionFavoriteListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeAnalysisConditionFavoriteListResponseBodyResultObject : TeaModel {
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
            /// <para>Event start timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1752076800000</para>
            /// </summary>
            [NameInMap("eventBeginTime")]
            [Validation(Required=false)]
            public long? EventBeginTime { get; set; }

            /// <summary>
            /// <para>Event codes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>de_ahespg8137</para>
            /// </summary>
            [NameInMap("eventCodes")]
            [Validation(Required=false)]
            public string EventCodes { get; set; }

            /// <summary>
            /// <para>Event end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1753891199000</para>
            /// </summary>
            [NameInMap("eventEndTime")]
            [Validation(Required=false)]
            public long? EventEndTime { get; set; }

            /// <summary>
            /// <para>Field name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>age</para>
            /// </summary>
            [NameInMap("fieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>Field value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("fieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

            /// <summary>
            /// <para>Primary key ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>497</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Condition name</para>
            /// 
            /// <b>Example:</b>
            /// <para>查询条件1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Type, BASIC: Basic query, ADVANCE: Advanced query, BATCH: Batch query</para>
            /// 
            /// <b>Example:</b>
            /// <para>BASIC</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
