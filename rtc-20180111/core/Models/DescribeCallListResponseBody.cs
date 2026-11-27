// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeCallListResponseBody : TeaModel {
        /// <summary>
        /// <para>List of communications.</para>
        /// </summary>
        [NameInMap("CallList")]
        [Validation(Required=false)]
        public List<DescribeCallListResponseBodyCallList> CallList { get; set; }
        public class DescribeCallListResponseBodyCallList : TeaModel {
            /// <summary>
            /// <para>App ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>9qb1****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>Number of users with poor communication experience.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BadExpUserCnt")]
            [Validation(Required=false)]
            public int? BadExpUserCnt { get; set; }

            /// <summary>
            /// <para>Communication status. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>IN</b>: In progress.  </description></item>
            /// <item><description><b>OUT</b>: Ended.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OUT</para>
            /// </summary>
            [NameInMap("CallStatus")]
            [Validation(Required=false)]
            public string CallStatus { get; set; }

            /// <summary>
            /// <para>Channel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>904</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp indicating when the communication was created, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1614936817</para>
            /// </summary>
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp indicating when the communication was released, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1614936817</para>
            /// </summary>
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            /// <summary>
            /// <para>Duration of the communication, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>User Count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("UserCnt")]
            [Validation(Required=false)]
            public int? UserCnt { get; set; }

        }

        /// <summary>
        /// <para>Page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>Quantity per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>Total Quantity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCnt")]
        [Validation(Required=false)]
        public int? TotalCnt { get; set; }

    }

}
