// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeCallListRequest : TeaModel {
        /// <summary>
        /// <para>APP ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testappid</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Call status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IN</b>: In progress.</description></item>
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
        /// <para>311</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The end time of the query, expressed as a UNIX timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1615892596</para>
        /// </summary>
        [NameInMap("EndTs")]
        [Validation(Required=false)]
        public long? EndTs { get; set; }

        /// <summary>
        /// <para>Sorting field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BAD_EXP_USER_COUNT_DESC</b>: Sort by the number of users with poor experience in descending order.</description></item>
        /// <item><description><b>BAD_EXP_USER_COUNT_ASC</b>: Sort by the number of users with poor experience in ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BAD_EXP_USER_COUNT_DESC</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>Page number. Minimum value: 1. Maximum value: 200.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>Quantity per page, minimum value is 1, maximum value is 200.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Query mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALL</b>: All calls.</description></item>
        /// <item><description><b>FOLLOW</b>: Followed calls.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("QueryMode")]
        [Validation(Required=false)]
        public string QueryMode { get; set; }

        /// <summary>
        /// <para>Start Time of the query, represented as a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1615806196</para>
        /// </summary>
        [NameInMap("StartTs")]
        [Validation(Required=false)]
        public long? StartTs { get; set; }

        /// <summary>
        /// <para>User ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c906531af5f9****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
