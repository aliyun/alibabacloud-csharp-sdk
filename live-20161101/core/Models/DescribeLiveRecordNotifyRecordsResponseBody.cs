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
            /// <para>The name of the application to which the stream belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liveApp****</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The result description. The value is success if the callback was successful. Otherwise, an error message is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The streamer\&quot;s streaming domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The specific content of the callback.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7月26日 16:14{&quot;domain&quot;:&quot;al.xxxx.com&quot;,&quot;stream&quot;:&quot;livestream01&quot;,&quot;pull _stream_result&quot;:true,&quot;cdn&quot;:&quot;al&quot;}</para>
            /// </summary>
            [NameInMap("NotifyContent")]
            [Validation(Required=false)]
            public string NotifyContent { get; set; }

            /// <summary>
            /// <para>The callback request header.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;Content-Type&quot;: [
            ///     &quot;application/json; charset=utf-8&quot;
            ///   ]
            /// }</para>
            /// </summary>
            [NameInMap("NotifyHeader")]
            [Validation(Required=false)]
            public string NotifyHeader { get; set; }

            /// <summary>
            /// <para>The response returned by the user after receiving the callback.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Code&quot;:0,&quot;Msg&quot;:&quot;Success&quot;}</para>
            /// </summary>
            [NameInMap("NotifyResponse")]
            [Validation(Required=false)]
            public string NotifyResponse { get; set; }

            /// <summary>
            /// <para>The callback result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>success: The callback was successful.</description></item>
            /// <item><description>failed: The callback failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("NotifyResult")]
            [Validation(Required=false)]
            public string NotifyResult { get; set; }

            /// <summary>
            /// <para>The callback time. Format: yyyy-MM-ddTHH:mm:ssZ (UTC).</para>
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
            /// <item><description>file_created: The recording was created.</description></item>
            /// <item><description>record_error: A recording error occurred.</description></item>
            /// <item><description>record_started: The recording started.</description></item>
            /// <item><description>record_paused: The recording was paused.</description></item>
            /// <item><description>record_resumed: The recording was resumed.</description></item>
            /// <item><description>record_force_transcode_fail: The recording task failed to trigger transcoding.</description></item>
            /// <item><description>transformat_error: An error occurred while parsing the live stream content.</description></item>
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
            /// <para>The recording storage type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>oss: recorded to OSS</description></item>
            /// <item><description>vod: recorded to ApsaraVideo VOD</description></item>
            /// <item><description>all: all storage types</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The stream name.</para>
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
        /// <para>The prompt message.</para>
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
        /// <para>The total number of entries that meet the conditions.</para>
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
