// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QueryUserAppUsageTimeRankResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of <c>200</c> indicates that the request is processed successfully. Other values indicate that the processing failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The ranking list of user application usage duration, sorted in descending order of cumulative usage duration.</para>
        /// </summary>
        [NameInMap("IndexData")]
        [Validation(Required=false)]
        public List<QueryUserAppUsageTimeRankResponseBodyIndexData> IndexData { get; set; }
        public class QueryUserAppUsageTimeRankResponseBodyIndexData : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-9ciijz60n4xsv****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Visual Studio Code</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The cumulative usage duration of the application within the statistical range. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("AppTimeCnt")]
            [Validation(Required=false)]
            public string AppTimeCnt { get; set; }

            /// <summary>
            /// <para>The application version. The current version may not return this value, and callers should not rely on this field. A non-empty value indicates the application version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.96.0</para>
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

        }

        /// <summary>
        /// <para>The description of the request processing result. If the request is successful, <c>success</c> is usually returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which can be used to troubleshoot request issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
