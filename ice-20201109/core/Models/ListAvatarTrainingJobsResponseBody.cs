// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListAvatarTrainingJobsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAvatarTrainingJobsResponseBodyData Data { get; set; }
        public class ListAvatarTrainingJobsResponseBodyData : TeaModel {
            [NameInMap("AvatarTrainingJobList")]
            [Validation(Required=false)]
            public List<ListAvatarTrainingJobsResponseBodyDataAvatarTrainingJobList> AvatarTrainingJobList { get; set; }
            public class ListAvatarTrainingJobsResponseBodyDataAvatarTrainingJobList : TeaModel {
                [NameInMap("AvatarDescription")]
                [Validation(Required=false)]
                public string AvatarDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Avatar-XXX</para>
                /// </summary>
                [NameInMap("AvatarId")]
                [Validation(Required=false)]
                public string AvatarId { get; set; }

                [NameInMap("AvatarName")]
                [Validation(Required=false)]
                public string AvatarName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2DAvatar</para>
                /// </summary>
                [NameInMap("AvatarType")]
                [Validation(Required=false)]
                public string AvatarType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-12-23T13:33:40Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-12-23T13:33:40Z</para>
                /// </summary>
                [NameInMap("FirstTrainingTime")]
                [Validation(Required=false)]
                public string FirstTrainingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><em><b><b>aded114489ea02e0addf93</b></b></em></para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-12-23T13:33:40Z</para>
                /// </summary>
                [NameInMap("LastTrainingTime")]
                [Validation(Required=false)]
                public string LastTrainingTime { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><em><b><b>aded114489ea02e0addf93</b></b></em></para>
                /// </summary>
                [NameInMap("Portrait")]
                [Validation(Required=false)]
                public string Portrait { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
