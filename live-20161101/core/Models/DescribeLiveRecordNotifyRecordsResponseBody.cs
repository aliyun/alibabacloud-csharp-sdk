// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveRecordNotifyRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The callback records.</para>
        /// </summary>
        [NameInMap("CallbackList")]
        [Validation(Required=false)]
        public List<DescribeLiveRecordNotifyRecordsResponseBodyCallbackList> CallbackList { get; set; }
        public class DescribeLiveRecordNotifyRecordsResponseBodyCallbackList : TeaModel {
            /// <summary>
            /// <para>The name of the application to which the live stream belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liveApp****</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The description of the result. A value of success indicates that the request is successful. If the request fails, an error message is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The main streaming domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The callback content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>July 26,  16:14{&quot;domain&quot;:&quot;al.xxxx.com&quot;,&quot;stream&quot;:&quot;livestream01&quot;,&quot;pull _stream_result&quot;:true,&quot;cdn&quot;:&quot;al&quot;}</para>
            /// </summary>
            [NameInMap("NotifyContent")]
            [Validation(Required=false)]
            public string NotifyContent { get; set; }

            [NameInMap("NotifyHeader")]
            [Validation(Required=false)]
            public string NotifyHeader { get; set; }

            [NameInMap("NotifyResponse")]
            [Validation(Required=false)]
            public string NotifyResponse { get; set; }

            /// <summary>
            /// <para>The callback result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>success</description></item>
            /// <item><description>failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("NotifyResult")]
            [Validation(Required=false)]
            public string NotifyResult { get; set; }

            /// <summary>
            /// <para>The time when the callback was returned. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-19T19:09:28Z</para>
            /// </summary>
            [NameInMap("NotifyTime")]
            [Validation(Required=false)]
            public string NotifyTime { get; set; }

            /// <summary>
            /// <para>The callback type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>file_created: The recording file is created.</description></item>
            /// <item><description>record_error: A recording error occurs.</description></item>
            /// <item><description>record_started: Recording is started.</description></item>
            /// <item><description>record_paused: Recording is paused.</description></item>
            /// <item><description>record_resumed: Recording is resumed.</description></item>
            /// <item><description>record_force_transcode_fail: The recording task fails to trigger transcoding.</description></item>
            /// <item><description>transformat_error: An error occurs when the live stream is parsed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>record_started</para>
            /// </summary>
            [NameInMap("NotifyType")]
            [Validation(Required=false)]
            public string NotifyType { get; set; }

            /// <summary>
            /// <para>The recording callback URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://learn.aliyundoc.com/examplecallback.action">http://learn.aliyundoc.com/examplecallback.action</a></para>
            /// </summary>
            [NameInMap("NotifyUrl")]
            [Validation(Required=false)]
            public string NotifyUrl { get; set; }

            /// <summary>
            /// <para>The name of the live stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liveStream****</para>
            /// </summary>
            [NameInMap("StreamName")]
            [Validation(Required=false)]
            public string StreamName { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180FA0D2-1A02-5158-A36B-115DBF7B218D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that meet the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
