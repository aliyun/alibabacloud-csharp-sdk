// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListAvatarTrainingJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAvatarTrainingJobsResponseBodyData Data { get; set; }
        public class ListAvatarTrainingJobsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of digital human training jobs.</para>
            /// </summary>
            [NameInMap("AvatarTrainingJobList")]
            [Validation(Required=false)]
            public List<ListAvatarTrainingJobsResponseBodyDataAvatarTrainingJobList> AvatarTrainingJobList { get; set; }
            public class ListAvatarTrainingJobsResponseBodyDataAvatarTrainingJobList : TeaModel {
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
                /// <para>Avatar-XXX</para>
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
                /// <item><description>The time when the job was created.</description></item>
                /// <item><description>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-23T13:33:40Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

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
                /// <para><em><b><b>aded114489ea02e0addf93</b></b></em></para>
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
                /// <para><em><b><b>aded114489ea02e0addf93</b></b></em></para>
                /// </summary>
                [NameInMap("Portrait")]
                [Validation(Required=false)]
                public string Portrait { get; set; }

                /// <summary>
                /// <para>The state of the digital human training job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
