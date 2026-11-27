// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribePubUserListBySubUserResponseBody : TeaModel {
        /// <summary>
        /// <para>Communication status. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>IN</b>: In progress.  </description></item>
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
        /// <para>Details of publishing users.</para>
        /// </summary>
        [NameInMap("PubUserDetailList")]
        [Validation(Required=false)]
        public List<DescribePubUserListBySubUserResponseBodyPubUserDetailList> PubUserDetailList { get; set; }
        public class DescribePubUserListBySubUserResponseBodyPubUserDetailList : TeaModel {
            /// <summary>
            /// <para>Call IDs of the user&quot;s communication streams.</para>
            /// </summary>
            [NameInMap("CallIdList")]
            [Validation(Required=false)]
            public List<string> CallIdList { get; set; }

            /// <summary>
            /// <para>Client type. Valid values: WEB: Web client. NATIVE: Native client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NATIVE</para>
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

            /// <summary>
            /// <para>The time when the user first joined the channel, represented as a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1614936817</para>
            /// </summary>
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            /// <summary>
            /// <para>The time when the user last left the channel, represented as a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1614936817</para>
            /// </summary>
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            /// <summary>
            /// <para>Communication duration, measured from the first entry to the final exit, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>Geographical location information, such as Zhejiang Province-Hangzhou City.</para>
            /// 
            /// <b>Example:</b>
            /// <para>浙江省-杭州市</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>Network type, such as WiFi, 4G, etc.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4G</para>
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            /// <summary>
            /// <para>Network types, such as WiFi, 4G, etc.</para>
            /// </summary>
            [NameInMap("NetworkList")]
            [Validation(Required=false)]
            public List<string> NetworkList { get; set; }

            /// <summary>
            /// <para>Online duration, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OnlineDuration")]
            [Validation(Required=false)]
            public long? OnlineDuration { get; set; }

            /// <summary>
            /// <para>Online period information.</para>
            /// </summary>
            [NameInMap("OnlinePeriods")]
            [Validation(Required=false)]
            public List<DescribePubUserListBySubUserResponseBodyPubUserDetailListOnlinePeriods> OnlinePeriods { get; set; }
            public class DescribePubUserListBySubUserResponseBodyPubUserDetailListOnlinePeriods : TeaModel {
                /// <summary>
                /// <para>The time when the user joined the channel, represented as a UNIX timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1614936817</para>
                /// </summary>
                [NameInMap("JoinTs")]
                [Validation(Required=false)]
                public long? JoinTs { get; set; }

                /// <summary>
                /// <para>The time when the user left the channel, represented as a UNIX timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1614936817</para>
                /// </summary>
                [NameInMap("LeaveTs")]
                [Validation(Required=false)]
                public long? LeaveTs { get; set; }

            }

            /// <summary>
            /// <para>Platform Type: If the client type is WEB, this field indicates the type of the browser. If the client type is NATIVE, this field indicates the operating system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iOS</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <para>Platform Type: If the client type is WEB, this field indicates the type of the browser. If the client type is NATIVE, this field indicates the operating system.</para>
            /// </summary>
            [NameInMap("OsList")]
            [Validation(Required=false)]
            public List<string> OsList { get; set; }

            /// <summary>
            /// <para>User roles. Valid values: SENDER: sender. RECEIVER: receiver.</para>
            /// </summary>
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<string> Roles { get; set; }

            /// <summary>
            /// <para>SDK Version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("SdkVersion")]
            [Validation(Required=false)]
            public string SdkVersion { get; set; }

            /// <summary>
            /// <para>List of software development kit (SDK) versions, such as 1.0.0, 1.1.1, etc.</para>
            /// </summary>
            [NameInMap("SdkVersionList")]
            [Validation(Required=false)]
            public List<string> SdkVersionList { get; set; }

            /// <summary>
            /// <para>User ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testuserid</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>User ID alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yi****</para>
            /// </summary>
            [NameInMap("UserIdAlias")]
            [Validation(Required=false)]
            public string UserIdAlias { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Subscriber user details.</para>
        /// </summary>
        [NameInMap("SubUserDetail")]
        [Validation(Required=false)]
        public DescribePubUserListBySubUserResponseBodySubUserDetail SubUserDetail { get; set; }
        public class DescribePubUserListBySubUserResponseBodySubUserDetail : TeaModel {
            /// <summary>
            /// <para>Client type. Valid values: WEB: Web client. NATIVE: Native client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NATIVE</para>
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

            /// <summary>
            /// <para>The time when the user first joined the channel, represented as a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1614936817</para>
            /// </summary>
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            /// <summary>
            /// <para>The time when the user last left the channel, represented as a UNIX timestamp, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1614936817</para>
            /// </summary>
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            /// <summary>
            /// <para>Communication duration, from the first entry to the final exit, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>Geographic location information, such as Zhejiang Province-Hangzhou City.</para>
            /// 
            /// <b>Example:</b>
            /// <para>浙江省-杭州市</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>Network type, such as WiFi, 4G, etc.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4G</para>
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            /// <summary>
            /// <para>Network type, such as WiFi, 4G, etc.</para>
            /// </summary>
            [NameInMap("NetworkList")]
            [Validation(Required=false)]
            public List<string> NetworkList { get; set; }

            /// <summary>
            /// <para>Online duration, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OnlineDuration")]
            [Validation(Required=false)]
            public long? OnlineDuration { get; set; }

            /// <summary>
            /// <para>Online period information.</para>
            /// </summary>
            [NameInMap("OnlinePeriods")]
            [Validation(Required=false)]
            public List<DescribePubUserListBySubUserResponseBodySubUserDetailOnlinePeriods> OnlinePeriods { get; set; }
            public class DescribePubUserListBySubUserResponseBodySubUserDetailOnlinePeriods : TeaModel {
                /// <summary>
                /// <para>The time when the user joined the channel, represented as a UNIX timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1614936817</para>
                /// </summary>
                [NameInMap("JoinTs")]
                [Validation(Required=false)]
                public long? JoinTs { get; set; }

                /// <summary>
                /// <para>The time when the user left the channel, represented as a UNIX timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1614936817</para>
                /// </summary>
                [NameInMap("LeaveTs")]
                [Validation(Required=false)]
                public long? LeaveTs { get; set; }

            }

            /// <summary>
            /// <para>Platform Type: If the client type is WEB, this field indicates the type of the browser. If the client type is NATIVE, this field indicates the operating system type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iOS</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <para>Platform Type: If the client type is WEB, this field indicates the type of the browser. If the client type is NATIVE, this field indicates the operating system type.</para>
            /// </summary>
            [NameInMap("OsList")]
            [Validation(Required=false)]
            public List<string> OsList { get; set; }

            /// <summary>
            /// <para>User role.</para>
            /// </summary>
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<string> Roles { get; set; }

            /// <summary>
            /// <para>SDK Version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("SdkVersion")]
            [Validation(Required=false)]
            public string SdkVersion { get; set; }

            /// <summary>
            /// <para>List of SDK versions, such as 1.0.0, 1.1.1, etc.</para>
            /// </summary>
            [NameInMap("SdkVersionList")]
            [Validation(Required=false)]
            public List<string> SdkVersionList { get; set; }

            /// <summary>
            /// <para>User ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testuserid</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>User ID alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yi****</para>
            /// </summary>
            [NameInMap("UserIdAlias")]
            [Validation(Required=false)]
            public string UserIdAlias { get; set; }

        }

    }

}
