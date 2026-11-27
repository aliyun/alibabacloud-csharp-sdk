// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeCallResponseBody : TeaModel {
        /// <summary>
        /// <para>The basic communication information.</para>
        /// </summary>
        [NameInMap("CallInfo")]
        [Validation(Required=false)]
        public DescribeCallResponseBodyCallInfo CallInfo { get; set; }
        public class DescribeCallResponseBodyCallInfo : TeaModel {
            /// <summary>
            /// <para>The app ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testappid</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The communication status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>IN</b>: In progress.</description></item>
            /// <item><description><b>OUT</b>: Ended.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IN</para>
            /// </summary>
            [NameInMap("CallStatus")]
            [Validation(Required=false)]
            public string CallStatus { get; set; }

            /// <summary>
            /// <para>The channel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <para>The time when the channel was created. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1615860711</para>
            /// </summary>
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            /// <summary>
            /// <para>The time when the channel was released. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1615860811</para>
            /// </summary>
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            /// <summary>
            /// <para>The duration of the channel. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of user details.</para>
        /// </summary>
        [NameInMap("UserDetailList")]
        [Validation(Required=false)]
        public List<DescribeCallResponseBodyUserDetailList> UserDetailList { get; set; }
        public class DescribeCallResponseBodyUserDetailList : TeaModel {
            /// <summary>
            /// <para>The call experience. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>GOOD</b>: Good.</description></item>
            /// <item><description><b>BAD</b>: Poor.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GOOD</para>
            /// </summary>
            [NameInMap("CallExp")]
            [Validation(Required=false)]
            public string CallExp { get; set; }

            /// <summary>
            /// <para>The time when the user first joined the channel. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1614936817</para>
            /// </summary>
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            /// <summary>
            /// <para>The time when the user last left the channel. The value is a UNIX timestamp in seconds. If the communication has not ended, the value is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1614936817</para>
            /// </summary>
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            /// <summary>
            /// <para>The duration statistics.</para>
            /// </summary>
            [NameInMap("DurMetricStatData")]
            [Validation(Required=false)]
            public DescribeCallResponseBodyUserDetailListDurMetricStatData DurMetricStatData { get; set; }
            public class DescribeCallResponseBodyUserDetailListDurMetricStatData : TeaModel {
                /// <summary>
                /// <para>The duration of published audio. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PubAudio")]
                [Validation(Required=false)]
                public long? PubAudio { get; set; }

                /// <summary>
                /// <para>The duration of published 1080P video. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PubVideo1080")]
                [Validation(Required=false)]
                public long? PubVideo1080 { get; set; }

                /// <summary>
                /// <para>The duration of published 360P video. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PubVideo360")]
                [Validation(Required=false)]
                public long? PubVideo360 { get; set; }

                /// <summary>
                /// <para>The duration of published 720P video. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PubVideo720")]
                [Validation(Required=false)]
                public long? PubVideo720 { get; set; }

                /// <summary>
                /// <para>The duration of published screen sharing. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PubVideoScreenShare")]
                [Validation(Required=false)]
                public long? PubVideoScreenShare { get; set; }

                /// <summary>
                /// <para>The duration of subscribed audio. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SubAudio")]
                [Validation(Required=false)]
                public long? SubAudio { get; set; }

                /// <summary>
                /// <para>The duration of subscribed 1080P video. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SubVideo1080")]
                [Validation(Required=false)]
                public long? SubVideo1080 { get; set; }

                /// <summary>
                /// <para>The duration of subscribed 360P video. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SubVideo360")]
                [Validation(Required=false)]
                public long? SubVideo360 { get; set; }

                /// <summary>
                /// <para>The duration of subscribed 720P video. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SubVideo720")]
                [Validation(Required=false)]
                public long? SubVideo720 { get; set; }

                /// <summary>
                /// <para>The duration of subscribed screen sharing. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SubVideoScreenShare")]
                [Validation(Required=false)]
                public long? SubVideoScreenShare { get; set; }

            }

            /// <summary>
            /// <para>The communication duration from the first join to the last leave. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The geographic location, such as Beijing-Beijing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhejiang-Hangzhou</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>The network type, such as Wi-Fi or 4G.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4G</para>
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            /// <summary>
            /// <para>The network type, such as Wi-Fi or 4G.</para>
            /// </summary>
            [NameInMap("NetworkList")]
            [Validation(Required=false)]
            public List<string> NetworkList { get; set; }

            /// <summary>
            /// <para>The online duration. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OnlineDuration")]
            [Validation(Required=false)]
            public long? OnlineDuration { get; set; }

            /// <summary>
            /// <para>The online periods.</para>
            /// </summary>
            [NameInMap("OnlinePeriods")]
            [Validation(Required=false)]
            public List<DescribeCallResponseBodyUserDetailListOnlinePeriods> OnlinePeriods { get; set; }
            public class DescribeCallResponseBodyUserDetailListOnlinePeriods : TeaModel {
                /// <summary>
                /// <para>The time when the user joined the channel. The value is a UNIX timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1614936817</para>
                /// </summary>
                [NameInMap("JoinTs")]
                [Validation(Required=false)]
                public long? JoinTs { get; set; }

                /// <summary>
                /// <para>The time when the user left the channel. The value is a UNIX timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1614936817</para>
                /// </summary>
                [NameInMap("LeaveTs")]
                [Validation(Required=false)]
                public long? LeaveTs { get; set; }

            }

            /// <summary>
            /// <para>The platform type. If the user client is WEB, this indicates the type of the browser. If the client is NATIVE, this indicates the operating system type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iOS</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <para>The platform type. If the user client is WEB, this indicates the type of the browser. If the client is NATIVE, this indicates the operating system type.</para>
            /// </summary>
            [NameInMap("OsList")]
            [Validation(Required=false)]
            public List<string> OsList { get; set; }

            /// <summary>
            /// <para>The user roles.</para>
            /// </summary>
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<string> Roles { get; set; }

            /// <summary>
            /// <para>The SDK version, such as 1.0.0 or 1.1.1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("SdkVersion")]
            [Validation(Required=false)]
            public string SdkVersion { get; set; }

            /// <summary>
            /// <para>The list of SDK versions, such as 1.0.0 or 1.1.1.</para>
            /// </summary>
            [NameInMap("SdkVersionList")]
            [Validation(Required=false)]
            public List<string> SdkVersionList { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testuserid</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
