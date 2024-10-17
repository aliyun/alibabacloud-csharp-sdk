// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataTrackOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the ticket.</para>
        /// </summary>
        [NameInMap("DataTrackOrderDetail")]
        [Validation(Required=false)]
        public GetDataTrackOrderDetailResponseBodyDataTrackOrderDetail DataTrackOrderDetail { get; set; }
        public class GetDataTrackOrderDetailResponseBodyDataTrackOrderDetail : TeaModel {
            /// <summary>
            /// <para>The name that is used to search for the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx@yyy:3306</para>
            /// </summary>
            [NameInMap("DatabaseSearchName")]
            [Validation(Required=false)]
            public string DatabaseSearchName { get; set; }

            /// <summary>
            /// <para>The ID of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3431****</para>
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            /// <summary>
            /// <para>The end time of the time range in which data operations are tracked. The time is in the yyyy-MM-dd HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-23 10:00:00</para>
            /// </summary>
            [NameInMap("JobEndTime")]
            [Validation(Required=false)]
            public string JobEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the time range in which data operations are tracked. The time is in the yyyy-MM-dd HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-23 00:00:00</para>
            /// </summary>
            [NameInMap("JobStartTime")]
            [Validation(Required=false)]
            public string JobStartTime { get; set; }

            /// <summary>
            /// <para>The status of the data tracking task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INIT</b>: The task is being initialized.</description></item>
            /// <item><description><b>LISTING</b>: The binary logs are being obtained.</description></item>
            /// <item><description><b>LIST_SUCCESS</b>: The binary logs are successfully obtained.</description></item>
            /// <item><description><b>DOWNLOADING</b>: The binary logs are being downloaded.</description></item>
            /// <item><description><b>DOWNLOAD_FAIL</b>: The binary logs failed to be downloaded.</description></item>
            /// <item><description><b>DOWNLOAD_SUCCESS</b>: The binary logs are successfully downloaded.</description></item>
            /// <item><description><b>FILTERING</b>: The binary logs are being parsed.</description></item>
            /// <item><description><b>FILTER_FAIL</b>: The binary logs failed to be parsed.</description></item>
            /// <item><description><b>FILTER_SUCCESS</b>: The binary logs are successfully parsed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FILTER_SUCCESS</para>
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the database is a logical database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Logic")]
            [Validation(Required=false)]
            public bool? Logic { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>as_task</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The description of the task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>searching success</para>
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// <para>The names of the tables for which data operations are tracked.</para>
            /// </summary>
            [NameInMap("TableNames")]
            [Validation(Required=false)]
            public List<string> TableNames { get; set; }

            /// <summary>
            /// <para>The types of data operations that are tracked.</para>
            /// </summary>
            [NameInMap("TrackTypes")]
            [Validation(Required=false)]
            public List<string> TrackTypes { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>283C461F-11D8-48AA-B695-DF092DA32AF3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
