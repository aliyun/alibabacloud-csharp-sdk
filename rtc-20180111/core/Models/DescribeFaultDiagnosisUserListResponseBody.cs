// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeFaultDiagnosisUserListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCnt")]
        [Validation(Required=false)]
        public int? TotalCnt { get; set; }

        [NameInMap("UserList")]
        [Validation(Required=false)]
        public List<DescribeFaultDiagnosisUserListResponseBodyUserList> UserList { get; set; }
        public class DescribeFaultDiagnosisUserListResponseBodyUserList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1614936817</para>
            /// </summary>
            [NameInMap("ChannelCreatedTs")]
            [Validation(Required=false)]
            public long? ChannelCreatedTs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>904</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

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

            [NameInMap("FaultList")]
            [Validation(Required=false)]
            public List<DescribeFaultDiagnosisUserListResponseBodyUserListFaultList> FaultList { get; set; }
            public class DescribeFaultDiagnosisUserListResponseBodyUserListFaultList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>JOIN_SLOW</para>
                /// </summary>
                [NameInMap("FaultType")]
                [Validation(Required=false)]
                public string FaultType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
