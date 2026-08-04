// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetDeviceStatusDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Returned error code. 200 indicates that the invocation succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Return Result of invoking this API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>0EC7*726E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned detailed information.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetDeviceStatusDetailResponseBodyResult Result { get; set; }
        public class GetDeviceStatusDetailResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Player information</para>
            /// </summary>
            [NameInMap("Player")]
            [Validation(Required=false)]
            public GetDeviceStatusDetailResponseBodyResultPlayer Player { get; set; }
            public class GetDeviceStatusDetailResponseBodyResultPlayer : TeaModel {
                /// <summary>
                /// <para>Song Album</para>
                /// </summary>
                [NameInMap("AudioAlbum")]
                [Validation(Required=false)]
                public string AudioAlbum { get; set; }

                /// <summary>
                /// <para>Artist</para>
                /// 
                /// <b>Example:</b>
                /// <para>刘德华</para>
                /// </summary>
                [NameInMap("AudioAnchor")]
                [Validation(Required=false)]
                public string AudioAnchor { get; set; }

                /// <summary>
                /// <para>Extension Information</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("AudioExt")]
                [Validation(Required=false)]
                public string AudioExt { get; set; }

                /// <summary>
                /// <para>Audio ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("AudioId")]
                [Validation(Required=false)]
                public string AudioId { get; set; }

                /// <summary>
                /// <para>Song length, in seconds</para>
                /// 
                /// <b>Example:</b>
                /// <para>253</para>
                /// </summary>
                [NameInMap("AudioLength")]
                [Validation(Required=false)]
                public string AudioLength { get; set; }

                /// <summary>
                /// <para>Song Name</para>
                /// </summary>
                [NameInMap("AudioName")]
                [Validation(Required=false)]
                public string AudioName { get; set; }

                /// <summary>
                /// <para>Song Source (xiami)</para>
                /// 
                /// <b>Example:</b>
                /// <para>xiami</para>
                /// </summary>
                [NameInMap("AudioSource")]
                [Validation(Required=false)]
                public string AudioSource { get; set; }

                /// <summary>
                /// <para>Song URL</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xxx">https://xxx</a></para>
                /// </summary>
                [NameInMap("AudioUrl")]
                [Validation(Required=false)]
                public string AudioUrl { get; set; }

                /// <summary>
                /// <para>Song Type (mp3)</para>
                /// 
                /// <b>Example:</b>
                /// <para>mp3</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>Playback progress</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <para>Playback Source (cloud)</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>Playback status, pause</para>
                /// 
                /// <b>Example:</b>
                /// <para>pause</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Reporting Time</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            /// <summary>
            /// <para>Battery information</para>
            /// </summary>
            [NameInMap("Power")]
            [Validation(Required=false)]
            public GetDeviceStatusDetailResponseBodyResultPower Power { get; set; }
            public class GetDeviceStatusDetailResponseBodyResultPower : TeaModel {
                /// <summary>
                /// <para>Battery value</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Quantity")]
                [Validation(Required=false)]
                public int? Quantity { get; set; }

                /// <summary>
                /// <para>Power status</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>Volume information</para>
            /// </summary>
            [NameInMap("Speaker")]
            [Validation(Required=false)]
            public GetDeviceStatusDetailResponseBodyResultSpeaker Speaker { get; set; }
            public class GetDeviceStatusDetailResponseBodyResultSpeaker : TeaModel {
                /// <summary>
                /// <para>Is muted</para>
                /// </summary>
                [NameInMap("Muted")]
                [Validation(Required=false)]
                public bool? Muted { get; set; }

                /// <summary>
                /// <para>Current volume value</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Volume")]
                [Validation(Required=false)]
                public int? Volume { get; set; }

            }

        }

    }

}
