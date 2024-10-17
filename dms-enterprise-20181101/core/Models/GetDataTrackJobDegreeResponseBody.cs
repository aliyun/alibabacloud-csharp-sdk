// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataTrackJobDegreeResponseBody : TeaModel {
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
        /// <para>The progress details of the data tracking task.</para>
        /// </summary>
        [NameInMap("JobDegree")]
        [Validation(Required=false)]
        public GetDataTrackJobDegreeResponseBodyJobDegree JobDegree { get; set; }
        public class GetDataTrackJobDegreeResponseBodyJobDegree : TeaModel {
            /// <summary>
            /// <para>The progress of binary log download. Valid values: 0 to 1. A value of 1 indicates that binary log download is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DownloadCompletionDegree")]
            [Validation(Required=false)]
            public double? DownloadCompletionDegree { get; set; }

            /// <summary>
            /// <para>The progress of binary log parsing. Valid values: 0 to 1. A value of 1 indicates that binary log parsing is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FilterCompletionDegree")]
            [Validation(Required=false)]
            public double? FilterCompletionDegree { get; set; }

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
            /// <para>The progress of binary log obtaining. Valid values: 0 to 1. A value of 1 indicates that binary log obtaining is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ListCompletionDegree")]
            [Validation(Required=false)]
            public double? ListCompletionDegree { get; set; }

            /// <summary>
            /// <para>The description of the task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>searching success</para>
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C51420E3-144A-4A94-B473-8662FCF4AD10</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
