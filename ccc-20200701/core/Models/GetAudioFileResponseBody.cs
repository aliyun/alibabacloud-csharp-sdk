// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetAudioFileResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Audio file data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAudioFileResponseBodyData Data { get; set; }
        public class GetAudioFileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Audio file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-file.wav</para>
            /// </summary>
            [NameInMap("AudioFileName")]
            [Validation(Required=false)]
            public string AudioFileName { get; set; }

            /// <summary>
            /// <para>Audio resource ID, the UUID of the audio file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c1a06b46-302a-4c6e-928b-a43c0df485cf</para>
            /// </summary>
            [NameInMap("AudioResourceId")]
            [Validation(Required=false)]
            public string AudioResourceId { get; set; }

            /// <summary>
            /// <para>Creation Time of the audio resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-14 10:48:43.0</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccc-test</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Display name of the audio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>欢迎语</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Key of the audio resource file in OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccc-test/test-file.wav</para>
            /// </summary>
            [NameInMap("OssFileKey")]
            [Validation(Required=false)]
            public string OssFileKey { get; set; }

            /// <summary>
            /// <para>Last Updated At of the audio resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-14 10:48:43.0</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public string UpdatedTime { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EEE26562-D921-5CB2-AE49-E4C45A42D432</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
