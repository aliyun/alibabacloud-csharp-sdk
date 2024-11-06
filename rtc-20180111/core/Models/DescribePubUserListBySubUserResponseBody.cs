// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribePubUserListBySubUserResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>IN</para>
        /// </summary>
        [NameInMap("CallStatus")]
        [Validation(Required=false)]
        public string CallStatus { get; set; }

        [NameInMap("PubUserDetailList")]
        [Validation(Required=false)]
        public List<DescribePubUserListBySubUserResponseBodyPubUserDetailList> PubUserDetailList { get; set; }
        public class DescribePubUserListBySubUserResponseBodyPubUserDetailList : TeaModel {
            [NameInMap("CallIdList")]
            [Validation(Required=false)]
            public List<string> CallIdList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NATIVE</para>
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

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
            public List<DescribePubUserListBySubUserResponseBodyPubUserDetailListOnlinePeriods> OnlinePeriods { get; set; }
            public class DescribePubUserListBySubUserResponseBodyPubUserDetailListOnlinePeriods : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>旁路转推</para>
            /// </summary>
            [NameInMap("UserIdAlias")]
            [Validation(Required=false)]
            public string UserIdAlias { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubUserDetail")]
        [Validation(Required=false)]
        public DescribePubUserListBySubUserResponseBodySubUserDetail SubUserDetail { get; set; }
        public class DescribePubUserListBySubUserResponseBodySubUserDetail : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>NATIVE</para>
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

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
            public List<DescribePubUserListBySubUserResponseBodySubUserDetailOnlinePeriods> OnlinePeriods { get; set; }
            public class DescribePubUserListBySubUserResponseBodySubUserDetailOnlinePeriods : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>旁路转推</para>
            /// </summary>
            [NameInMap("UserIdAlias")]
            [Validation(Required=false)]
            public string UserIdAlias { get; set; }

        }

    }

}
