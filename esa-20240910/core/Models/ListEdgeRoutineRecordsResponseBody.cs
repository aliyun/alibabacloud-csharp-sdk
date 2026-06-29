// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListEdgeRoutineRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number, which is the same as the PageNumber request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records displayed per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of records.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<ListEdgeRoutineRecordsResponseBodyRecords> Records { get; set; }
        public class ListEdgeRoutineRecordsResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>The creation time of the record. The time is in ISO 8601 format and displayed in UTC. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-24T02:01:11Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The CNAME of the record. When the site uses CNAME access, this is the CNAME value that needs to be configured for the record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a.example.com.cnamezone.com</para>
            /// </summary>
            [NameInMap("RecordCname")]
            [Validation(Required=false)]
            public string RecordCname { get; set; }

            /// <summary>
            /// <para>The record name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a.example.com</para>
            /// </summary>
            [NameInMap("RecordName")]
            [Validation(Required=false)]
            public string RecordName { get; set; }

            /// <summary>
            /// <para>The site ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5407498413****</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

            /// <summary>
            /// <para>The name of the site to which the record belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("SiteName")]
            [Validation(Required=false)]
            public string SiteName { get; set; }

            /// <summary>
            /// <para>The update time of the record. The time is in ISO 8601 format and displayed in UTC. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-22T08:32:02Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EEEBE525-F576-1196-8DAF-2D70CA3F4D2F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>121</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
