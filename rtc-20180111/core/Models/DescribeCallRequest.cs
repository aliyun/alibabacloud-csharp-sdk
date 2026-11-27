// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeCallRequest : TeaModel {
        /// <summary>
        /// <para>The app ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testappid</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The channel ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testid</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The time when the channel was created. You can query data of the last 30 days. The time is a UNIX timestamp in seconds.</para>
        /// <remarks>
        /// <para>The channel creation time must be exactly the same as the actual creation time (accurate to the second). You can call the <a href="https://help.aliyun.com/document_detail/2655884.html">DescribeCallList</a> operation to view the channel creation time (the CreatedTS parameter in the response).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1614936817</para>
        /// </summary>
        [NameInMap("CreatedTs")]
        [Validation(Required=false)]
        public long? CreatedTs { get; set; }

        /// <summary>
        /// <para>The time when the channel was released. The time is a UNIX timestamp in seconds. If this parameter is left empty, the current time is used.</para>
        /// <remarks>
        /// <para>If the specified channel release time is later than the actual release time, the data from the creation time to the actual release time is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1614936817</para>
        /// </summary>
        [NameInMap("DestroyedTs")]
        [Validation(Required=false)]
        public long? DestroyedTs { get; set; }

        /// <summary>
        /// <para>The extended data type to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>USER_DURATION_STAT: user duration statistics.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USER_DURATION_STAT</para>
        /// </summary>
        [NameInMap("ExtDataType")]
        [Validation(Required=false)]
        public string ExtDataType { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the communication experience information. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("QueryExpInfo")]
        [Validation(Required=false)]
        public bool? QueryExpInfo { get; set; }

    }

}
