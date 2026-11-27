// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeFaultDiagnosisUserListResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCnt")]
        [Validation(Required=false)]
        public int? TotalCnt { get; set; }

        /// <summary>
        /// <para>The detailed list of users with faults.</para>
        /// </summary>
        [NameInMap("UserList")]
        [Validation(Required=false)]
        public List<DescribeFaultDiagnosisUserListResponseBodyUserList> UserList { get; set; }
        public class DescribeFaultDiagnosisUserListResponseBodyUserList : TeaModel {
            /// <summary>
            /// <para>The creation timestamp of the channel. The time is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1614936817</para>
            /// </summary>
            [NameInMap("ChannelCreatedTs")]
            [Validation(Required=false)]
            public long? ChannelCreatedTs { get; set; }

            /// <summary>
            /// <para>The ID of the channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>904</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <para>The time when the user first joined the channel. The time is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1614936817</para>
            /// </summary>
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            /// <summary>
            /// <para>The time when the user last left the channel. The time is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1614936817</para>
            /// </summary>
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            /// <summary>
            /// <para>The list of faults.</para>
            /// </summary>
            [NameInMap("FaultList")]
            [Validation(Required=false)]
            public List<DescribeFaultDiagnosisUserListResponseBodyUserListFaultList> FaultList { get; set; }
            public class DescribeFaultDiagnosisUserListResponseBodyUserListFaultList : TeaModel {
                /// <summary>
                /// <para>The fault type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>JOIN_SLOW</para>
                /// </summary>
                [NameInMap("FaultType")]
                [Validation(Required=false)]
                public string FaultType { get; set; }

            }

            /// <summary>
            /// <para>The ID of the user.</para>
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
