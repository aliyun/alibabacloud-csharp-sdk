// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class RemoveLiveMessageGroupBandRequest : TeaModel {
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
        /// <para>The data center. It must be the same as the data center that was specified when you called the <a href="https://help.aliyun.com/document_detail/2848162.html">CreateLiveMessageApp</a> operation to create the interactive messaging application.</para>
        /// <remarks>
        /// <para> Valid values: cn-shanghai and ap-southeast-1 (Singapore).</para>
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
        /// <para>The users whom you want to unmute.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UnbannedUsers")]
        [Validation(Required=false)]
        public List<string> UnbannedUsers { get; set; }

    }

}
