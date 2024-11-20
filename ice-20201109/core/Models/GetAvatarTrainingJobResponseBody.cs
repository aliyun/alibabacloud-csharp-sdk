// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetAvatarTrainingJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned if the request was successful.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAvatarTrainingJobResponseBodyData Data { get; set; }
        public class GetAvatarTrainingJobResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about the digital human training job.</para>
            /// </summary>
            [NameInMap("AvatarTrainingJob")]
            [Validation(Required=false)]
            public GetAvatarTrainingJobResponseBodyDataAvatarTrainingJob AvatarTrainingJob { get; set; }
            public class GetAvatarTrainingJobResponseBodyDataAvatarTrainingJob : TeaModel {
                /// <summary>
                /// <para>The description of the digital human.</para>
                /// </summary>
                [NameInMap("AvatarDescription")]
                [Validation(Required=false)]
                public string AvatarDescription { get; set; }

                /// <summary>
                /// <para>The ID of the digital human.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Avatar-XXXX</para>
                /// </summary>
                [NameInMap("AvatarId")]
                [Validation(Required=false)]
                public string AvatarId { get; set; }

                /// <summary>
                /// <para>The name of the digital human.</para>
                /// </summary>
                [NameInMap("AvatarName")]
                [Validation(Required=false)]
                public string AvatarName { get; set; }

                /// <summary>
                /// <para>The type of the digital human.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2DAvatar</para>
                /// </summary>
                [NameInMap("AvatarType")]
                [Validation(Required=false)]
                public string AvatarType { get; set; }

                /// <summary>
                /// <list type="bullet">
                /// <item><description>The time when the first training was initiated.</description></item>
                /// <item><description>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-23T13:33:40Z</para>
                /// </summary>
                [NameInMap("FirstTrainingTime")]
                [Validation(Required=false)]
                public string FirstTrainingTime { get; set; }

                /// <summary>
                /// <para>The ID of the digital human training job.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b><b>55d86f7f4587943ce7734d6b</b></b></para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <list type="bullet">
                /// <item><description>The time when the last training was initiated.</description></item>
                /// <item><description>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-23T13:33:40Z</para>
                /// </summary>
                [NameInMap("LastTrainingTime")]
                [Validation(Required=false)]
                public string LastTrainingTime { get; set; }

                /// <summary>
                /// <para>The status description.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The media asset ID of the portrait image.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b><b>571c704445f9a0ee011406c2</b></b></para>
                /// </summary>
                [NameInMap("Portrait")]
                [Validation(Required=false)]
                public string Portrait { get; set; }

                /// <summary>
                /// <list type="bullet">
                /// <item><description>The state of the digital human training job.</description></item>
                /// <item><description>Valid values: Init, Queuing, Training, Success, and Fail.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The thumbnail URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://your-bucket.oss-cn-hangzhou.aliyuncs.com/thumbnail.png">https://your-bucket.oss-cn-hangzhou.aliyuncs.com/thumbnail.png</a></para>
                /// </summary>
                [NameInMap("Thumbnail")]
                [Validation(Required=false)]
                public string Thumbnail { get; set; }

                /// <summary>
                /// <para>Indicates whether the input video supports alpha channels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Transparent")]
                [Validation(Required=false)]
                public bool? Transparent { get; set; }

                /// <summary>
                /// <para>The ID of the video used for training.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b><b>571c704445f9a0ee011406c2</b></b></para>
                /// </summary>
                [NameInMap("Video")]
                [Validation(Required=false)]
                public string Video { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
