// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class SearchTracesRequest : TeaModel {
        /// <summary>
        /// <para>The type of the application. You can set the value to <b>XTRACE</b> or leave this parameter unspecified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XTRACE</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value is a timestamp that is accurate to milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1575622455686</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The minimum value of an execution duration. Unit: seconds. For example, a value of 2 indicates that the traces whose execution duration is more than 2 seconds are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MinDuration")]
        [Validation(Required=false)]
        public long? MinDuration { get; set; }

        /// <summary>
        /// <para>The name of the span.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/api</para>
        /// </summary>
        [NameInMap("OperationName")]
        [Validation(Required=false)]
        public string OperationName { get; set; }

        /// <summary>
        /// <para>The number of the page to return. For example, a value of 5 indicates page 5.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to sort the query results in chronological order or reverse chronological order. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: reverse chronological order </description></item>
        /// <item><description>false: chronological order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        /// <summary>
        /// <para>The IP address of the server on which the span is running.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0</para>
        /// </summary>
        [NameInMap("ServiceIp")]
        [Validation(Required=false)]
        public string ServiceIp { get; set; }

        /// <summary>
        /// <para>The name of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service 1</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a timestamp that is accurate to milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1575561600000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public string StatusCode { get; set; }

        /// <summary>
        /// <para>The list of the tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<SearchTracesRequestTag> Tag { get; set; }
        public class SearchTracesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http.status_cod</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
