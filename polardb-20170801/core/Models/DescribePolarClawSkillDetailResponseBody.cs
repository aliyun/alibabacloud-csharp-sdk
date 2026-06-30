// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarClawSkillDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-xxx</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The latest version information.</para>
        /// </summary>
        [NameInMap("LatestVersion")]
        [Validation(Required=false)]
        public DescribePolarClawSkillDetailResponseBodyLatestVersion LatestVersion { get; set; }
        public class DescribePolarClawSkillDetailResponseBodyLatestVersion : TeaModel {
            /// <summary>
            /// <para>The version changelog.</para>
            /// 
            /// <b>Example:</b>
            /// <para>empty</para>
            /// </summary>
            [NameInMap("Changelog")]
            [Validation(Required=false)]
            public string Changelog { get; set; }

            /// <summary>
            /// <para>The version publish timestamp in Unix milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1767545394459</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The Skill author information.</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public DescribePolarClawSkillDetailResponseBodyOwner Owner { get; set; }
        public class DescribePolarClawSkillDetailResponseBodyOwner : TeaModel {
            /// <summary>
            /// <para>The display name of the author.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Peter Steinberger</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The account identifier of the author.</para>
            /// 
            /// <b>Example:</b>
            /// <para>steipete</para>
            /// </summary>
            [NameInMap("Handle")]
            [Validation(Required=false)]
            public string Handle { get; set; }

            /// <summary>
            /// <para>The profile picture URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://avatars.githubusercontent.com/u/58493?v=4">https://avatars.githubusercontent.com/u/58493?v=4</a></para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// <para>The user ID of the author.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s179zksw999xz8ms4cy7pb2fr183m5jq</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F45FFACC-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The core information of the Skill.</para>
        /// </summary>
        [NameInMap("Skill")]
        [Validation(Required=false)]
        public DescribePolarClawSkillDetailResponseBodySkill Skill { get; set; }
        public class DescribePolarClawSkillDetailResponseBodySkill : TeaModel {
            /// <summary>
            /// <para>The first publish timestamp in Unix milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1767545394459</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            /// <summary>
            /// <para>The display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Weather</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The Skill identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>weather</para>
            /// </summary>
            [NameInMap("Slug")]
            [Validation(Required=false)]
            public string Slug { get; set; }

            /// <summary>
            /// <para>The statistics information.</para>
            /// </summary>
            [NameInMap("Stats")]
            [Validation(Required=false)]
            public DescribePolarClawSkillDetailResponseBodySkillStats Stats { get; set; }
            public class DescribePolarClawSkillDetailResponseBodySkillStats : TeaModel {
                /// <summary>
                /// <para>The number of comments.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("Comments")]
                [Validation(Required=false)]
                public long? Comments { get; set; }

                /// <summary>
                /// <para>The number of downloads.</para>
                /// 
                /// <b>Example:</b>
                /// <para>155765</para>
                /// </summary>
                [NameInMap("Downloads")]
                [Validation(Required=false)]
                public long? Downloads { get; set; }

                /// <summary>
                /// <para>The total number of installations of all time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3787</para>
                /// </summary>
                [NameInMap("InstallsAllTime")]
                [Validation(Required=false)]
                public long? InstallsAllTime { get; set; }

                /// <summary>
                /// <para>The current number of installations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3664</para>
                /// </summary>
                [NameInMap("InstallsCurrent")]
                [Validation(Required=false)]
                public long? InstallsCurrent { get; set; }

                /// <summary>
                /// <para>The number of stars.</para>
                /// 
                /// <b>Example:</b>
                /// <para>404</para>
                /// </summary>
                [NameInMap("Stars")]
                [Validation(Required=false)]
                public long? Stars { get; set; }

                /// <summary>
                /// <para>The number of versions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Versions")]
                [Validation(Required=false)]
                public long? Versions { get; set; }

            }

            /// <summary>
            /// <para>The brief description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Get current weather and forecasts (no API key required).</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>The tag key-value pairs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;latest&quot;: &quot;1.0.0&quot;
            /// }</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// <para>The last update timestamp in Unix milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1778485729679</para>
            /// </summary>
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public long? UpdatedAt { get; set; }

        }

    }

}
