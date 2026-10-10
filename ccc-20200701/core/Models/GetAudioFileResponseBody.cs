// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetAudioFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The audio file data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAudioFileResponseBodyData Data { get; set; }
        public class GetAudioFileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the audio file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-file.wav</para>
            /// </summary>
            [NameInMap("AudioFileName")]
            [Validation(Required=false)]
            public string AudioFileName { get; set; }

            /// <summary>
            /// <para>The audio resource ID, which is the unique identifier of the audio file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c1a06b46-302a-4c6e-928b-a43c0df485cf</para>
            /// </summary>
            [NameInMap("AudioResourceId")]
            [Validation(Required=false)]
            public string AudioResourceId { get; set; }

            /// <summary>
            /// <para>The time when the audio resource was created. The format is YYYY-MM-DD HH:mm:ss.S.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-14 10:48:43.0</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccc-test</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The display name of the audio file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Welcome message</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The key of the audio resource file in OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccc-test/test-file.wav</para>
            /// </summary>
            [NameInMap("OssFileKey")]
            [Validation(Required=false)]
            public string OssFileKey { get; set; }

            /// <summary>
            /// <para>The time when the audio resource was last modified. The format is YYYY-MM-DD HH:mm:ss.S.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-14 10:48:43.0</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public string UpdatedTime { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EEE26562-D921-5CB2-AE49-E4C45A42D432</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
