// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribePubUserListBySubUserRequest : TeaModel {
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
        /// <para>Channel ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testid</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The channel creation time. You can query data from the last 30 days. The value is represented as a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1614936817</para>
        /// </summary>
        [NameInMap("CreatedTs")]
        [Validation(Required=false)]
        public long? CreatedTs { get; set; }

        /// <summary>
        /// <para>The channel release time, represented as a UNIX timestamp in seconds. If this parameter is empty, the current time is used.  </para>
        /// <remarks>
        /// <para>If the provided channel release time exceeds the actual release time, data from the creation time to the actual release time will be returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1614936817</para>
        /// </summary>
        [NameInMap("DestroyedTs")]
        [Validation(Required=false)]
        public long? DestroyedTs { get; set; }

        /// <summary>
        /// <para>Subscriber User ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testuserid</para>
        /// </summary>
        [NameInMap("SubUserId")]
        [Validation(Required=false)]
        public string SubUserId { get; set; }

    }

}
