// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeCallResponseBody : TeaModel {
        [NameInMap("CallInfo")]
        [Validation(Required=false)]
        public DescribeCallResponseBodyCallInfo CallInfo { get; set; }
        public class DescribeCallResponseBodyCallInfo : TeaModel {
            /// <summary>
            /// <para>App ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxxxx</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>IN</para>
            /// </summary>
            [NameInMap("CallStatus")]
            [Validation(Required=false)]
            public string CallStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1615860711</para>
            /// </summary>
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1615860811</para>
            /// </summary>
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserDetailList")]
        [Validation(Required=false)]
        public List<DescribeCallResponseBodyUserDetailList> UserDetailList { get; set; }
        public class DescribeCallResponseBodyUserDetailList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>GOOD</para>
            /// </summary>
            [NameInMap("CallExp")]
            [Validation(Required=false)]
            public string CallExp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1614936817</para>
            /// </summary>
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1614936817</para>
            /// </summary>
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            [NameInMap("DurMetricStatData")]
            [Validation(Required=false)]
            public DescribeCallResponseBodyUserDetailListDurMetricStatData DurMetricStatData { get; set; }
            public class DescribeCallResponseBodyUserDetailListDurMetricStatData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PubAudio")]
                [Validation(Required=false)]
                public long? PubAudio { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PubVideo1080")]
                [Validation(Required=false)]
                public long? PubVideo1080 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PubVideo360")]
                [Validation(Required=false)]
                public long? PubVideo360 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PubVideo720")]
                [Validation(Required=false)]
                public long? PubVideo720 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PubVideoScreenShare")]
                [Validation(Required=false)]
                public long? PubVideoScreenShare { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SubAudio")]
                [Validation(Required=false)]
                public long? SubAudio { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SubVideo1080")]
                [Validation(Required=false)]
                public long? SubVideo1080 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SubVideo360")]
                [Validation(Required=false)]
                public long? SubVideo360 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SubVideo720")]
                [Validation(Required=false)]
                public long? SubVideo720 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SubVideoScreenShare")]
                [Validation(Required=false)]
                public long? SubVideoScreenShare { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>浙江省-杭州市</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4G</para>
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            [NameInMap("NetworkList")]
            [Validation(Required=false)]
            public List<string> NetworkList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OnlineDuration")]
            [Validation(Required=false)]
            public long? OnlineDuration { get; set; }

            [NameInMap("OnlinePeriods")]
            [Validation(Required=false)]
            public List<DescribeCallResponseBodyUserDetailListOnlinePeriods> OnlinePeriods { get; set; }
            public class DescribeCallResponseBodyUserDetailListOnlinePeriods : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1614936817</para>
                /// </summary>
                [NameInMap("JoinTs")]
                [Validation(Required=false)]
                public long? JoinTs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1614936817</para>
                /// </summary>
                [NameInMap("LeaveTs")]
                [Validation(Required=false)]
                public long? LeaveTs { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>iOS</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            [NameInMap("OsList")]
            [Validation(Required=false)]
            public List<string> OsList { get; set; }

            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<string> Roles { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("SdkVersion")]
            [Validation(Required=false)]
            public string SdkVersion { get; set; }

            [NameInMap("SdkVersionList")]
            [Validation(Required=false)]
            public List<string> SdkVersionList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testuserid</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
