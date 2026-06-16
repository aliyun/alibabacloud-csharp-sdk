// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeAdvanceSearchPageListRequest : TeaModel {
        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The condition value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;relationship&quot;: &quot;and&quot;,
        ///     &quot;list&quot;: [
        ///         {
        ///             &quot;deepCount&quot;: 1,
        ///             &quot;left&quot;: {
        ///                 &quot;hasRightVariable&quot;: true,
        ///                 &quot;fieldType&quot;: &quot;STRING&quot;,
        ///                 &quot;functionName&quot;: &quot;&quot;,
        ///                 &quot;leftVariableType&quot;: &quot;NATIVE&quot;,
        ///                 &quot;name&quot;: &quot;accountId&quot;,
        ///                 &quot;operatorCode&quot;: &quot;equals&quot;
        ///             },
        ///             &quot;right&quot;: {
        ///                 &quot;rightVariableType&quot;: &quot;constant&quot;,
        ///                 &quot;name&quot;: &quot;10000&quot;,
        ///                 &quot;functionName&quot;: &quot;&quot;
        ///             },
        ///             &quot;operatorCode&quot;: &quot;equals&quot;
        ///         }
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The start time of the query, in milliseconds (ms).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1753372800000</para>
        /// </summary>
        [NameInMap("eventBeginTime")]
        [Validation(Required=false)]
        public long? EventBeginTime { get; set; }

        /// <summary>
        /// <para>The event code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;de_ahqhsw7665&quot;]</para>
        /// </summary>
        [NameInMap("eventCodes")]
        [Validation(Required=false)]
        public string EventCodes { get; set; }

        /// <summary>
        /// <para>The end time of the query, in milliseconds (ms).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1753459199059</para>
        /// </summary>
        [NameInMap("eventEndTime")]
        [Validation(Required=false)]
        public long? EventEndTime { get; set; }

        /// <summary>
        /// <para>The field name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>age</para>
        /// </summary>
        [NameInMap("fieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// <para>The field value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("fieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

    }

}
