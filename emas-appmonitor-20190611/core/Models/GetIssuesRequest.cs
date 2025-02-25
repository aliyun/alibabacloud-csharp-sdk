// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emas_appmonitor20190611.Models
{
    public class GetIssuesRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>233588686</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>h5Resource</para>
        /// </summary>
        [NameInMap("BizModule")]
        [Validation(Required=false)]
        public string BizModule { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=false)]
        public GetIssuesRequestFilter Filter { get; set; }
        public class GetIssuesRequestFilter : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>erConfig</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BeginWith</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("SubFilters")]
            [Validation(Required=false)]
            public List<string> SubFilters { get; set; }

            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<object> Values { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GUI-TEST1711072832000</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>instances</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>h5</para>
        /// </summary>
        [NameInMap("Os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FE_RUNNING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TimeRange")]
        [Validation(Required=false)]
        public GetIssuesRequestTimeRange TimeRange { get; set; }
        public class GetIssuesRequestTimeRange : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-09-04T02:15:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Host</para>
            /// </summary>
            [NameInMap("Granularity")]
            [Validation(Required=false)]
            public int? Granularity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>day</para>
            /// </summary>
            [NameInMap("GranularityUnit")]
            [Validation(Required=false)]
            public string GranularityUnit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-11-05T16:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

    }

}
