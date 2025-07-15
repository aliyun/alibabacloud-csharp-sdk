// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyLiveMessageGroupBandShrinkRequest : TeaModel {
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
        /// <para>Specifies whether to mute all users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BannedAll")]
        [Validation(Required=false)]
        public bool? BannedAll { get; set; }

        /// <summary>
        /// <para>The ID of the user whom you want to mute. Separate multiple user IDs with commas (,). You can specify up to 30 users IDs.</para>
        /// </summary>
        [NameInMap("BannnedUsers")]
        [Validation(Required=false)]
        public string BannnedUsersShrink { get; set; }

        /// <summary>
        /// <para>The data center. It must be the same as the data center that was specified when you called the <a href="https://help.aliyun.com/document_detail/2848162.html">CreateLiveMessageApp</a> operation to create the interactive messaging application. Valid values: cn-shanghai and ap-southeast-1 (Singapore).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

        /// <summary>
        /// <para>The ID of the user whom you do not want to mute when you set the BannedAll parameter to true. Separate multiple user IDs with commas (,). You can specify up to 30 users IDs.</para>
        /// </summary>
        [NameInMap("ExceptUsers")]
        [Validation(Required=false)]
        public string ExceptUsersShrink { get; set; }

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

    }

}
