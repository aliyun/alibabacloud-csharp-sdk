// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateAnalysisExportTaskRequest : TeaModel {
        /// <summary>
        /// <para>The language type for the request and response messages. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>The custom columns.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///                 {
        ///                     &quot;fieldName&quot;: &quot;requestId&quot;,
        ///                     &quot;fieldTitle&quot;: &quot;RequestId&quot;
        ///                 },
        ///                 {
        ///                     &quot;fieldName&quot;: &quot;eventTime&quot;,
        ///                     &quot;fieldTitle&quot;: &quot;事件时间&quot;
        ///                 },
        ///                 {
        ///                     &quot;fieldName&quot;: &quot;accountId&quot;,
        ///                     &quot;fieldTitle&quot;: &quot;账号&quot;
        ///                 },
        ///                 {
        ///                     &quot;fieldName&quot;: &quot;deviceId&quot;,
        ///                     &quot;fieldTitle&quot;: &quot;设备ID&quot;
        ///                 },
        ///                 {
        ///                     &quot;fieldName&quot;: &quot;eventCode&quot;,
        ///                     &quot;fieldTitle&quot;: &quot;事件编码&quot;
        ///                 },
        ///                 {
        ///                     &quot;fieldName&quot;: &quot;ip&quot;,
        ///                     &quot;fieldTitle&quot;: &quot;IP&quot;
        ///                 },
        ///                 {
        ///                     &quot;fieldName&quot;: &quot;score&quot;,
        ///                     &quot;fieldTitle&quot;: &quot;分值&quot;
        ///                 },
        ///                 {
        ///                     &quot;fieldName&quot;: &quot;tags&quot;,
        ///                     &quot;fieldTitle&quot;: &quot;标签&quot;
        ///                 },
        ///                 {
        ///                     &quot;fieldName&quot;: &quot;DEtest222&quot;,
        ///                     &quot;fieldTitle&quot;: &quot;测试222&quot;
        ///                 }
        ///             ]</para>
        /// </summary>
        [NameInMap("columns")]
        [Validation(Required=false)]
        public string Columns { get; set; }

        /// <summary>
        /// <para>The query expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///      &quot;fieldName&quot;: null, 
        ///       &quot;fieldValue&quot;: null 
        ///       }</para>
        /// </summary>
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        /// <summary>
        /// <para>The start time, in milliseconds (ms).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1752076800000</para>
        /// </summary>
        [NameInMap("eventBeginTime")]
        [Validation(Required=false)]
        public long? EventBeginTime { get; set; }

        /// <summary>
        /// <para>The event code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>de_afghcf6411</para>
        /// </summary>
        [NameInMap("eventCodes")]
        [Validation(Required=false)]
        public string EventCodes { get; set; }

        /// <summary>
        /// <para>The end time, in milliseconds (ms).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1753891199000</para>
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
        /// <para>The file format. Valid values: Excel and CSV.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CSV</para>
        /// </summary>
        [NameInMap("fileFormat")]
        [Validation(Required=false)]
        public string FileFormat { get; set; }

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

        /// <summary>
        /// <para>The export scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL: all data</description></item>
        /// <item><description>SELECT: selected rows.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The query type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BASIC: basic query</description></item>
        /// <item><description>ADVANCE: advanced query</description></item>
        /// <item><description>BATCH: batch query.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BASIC</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
