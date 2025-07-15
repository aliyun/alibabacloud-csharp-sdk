// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyLiveMessageGroupRequest : TeaModel {
        /// <summary>
        /// <para>The list of administrators after your change.</para>
        /// </summary>
        [NameInMap("AdminList")]
        [Validation(Required=false)]
        public List<string> AdminList { get; set; }

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
        /// <para>The data center. It must be the same as the data center that was specified when you called the <a href="https://help.aliyun.com/document_detail/2848162.html">CreateLiveMessageApp</a> operation to create the interactive messaging application. Valid values: cn-shanghai and ap-southeast-1 (Singapore).</para>
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
        /// <para>The additional information about the group after the modification. The value can be up to 32 KB in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>newmeta</para>
        /// </summary>
        [NameInMap("GroupInfo")]
        [Validation(Required=false)]
        public string GroupInfo { get; set; }

        /// <summary>
        /// <para>Specifies whether to change the group administrators.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ModifyAdmin")]
        [Validation(Required=false)]
        public bool? ModifyAdmin { get; set; }

        /// <summary>
        /// <para>Specifies whether to modify the additional information about the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ModifyInfo")]
        [Validation(Required=false)]
        public bool? ModifyInfo { get; set; }

    }

}
