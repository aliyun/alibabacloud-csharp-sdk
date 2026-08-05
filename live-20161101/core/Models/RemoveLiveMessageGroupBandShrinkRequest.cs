// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class RemoveLiveMessageGroupBandShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The data center. This must be the same data center that you specified when you called <a href="https://help.aliyun.com/document_detail/2848162.html">CreateLiveMessageApp</a>.</para>
        /// <remarks>
        /// <para>Valid values: \<c>cn-shanghai\\</c> (Shanghai) and \<c>ap-southeast-1\\</c> (Singapore).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

        /// <summary>
        /// <para>The group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>grouptest</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The list of users to unmute. You can specify up to 30 users. Separate multiple user IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UnbannedUsers")]
        [Validation(Required=false)]
        public string UnbannedUsersShrink { get; set; }

    }

}
