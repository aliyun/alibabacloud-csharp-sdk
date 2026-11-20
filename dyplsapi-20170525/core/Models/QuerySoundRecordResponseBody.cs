// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QuerySoundRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0000: Success.</description></item>
        /// </list>
        /// <para>Other values indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The call recording query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;FileUrl&quot;:&quot;<a href="http://www.oss.com/temepl/a.mp3%22%7D">http://www.oss.com/temepl/a.mp3&quot;}</a></para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySoundRecordResponseBodyData Data { get; set; }
        public class QuerySoundRecordResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The URL of the call recording. The maximum length is 1,000 characters. The URL is valid for 1 hour.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.oss.com/temepl/a.mp3">http://www.oss.com/temepl/a.mp3</a></para>
            /// </summary>
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The request is successful. </para>
        /// </description></item>
        /// <item><description><para>false: The request failed.</para>
        /// </description></item>
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
