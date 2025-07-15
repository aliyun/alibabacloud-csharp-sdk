// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateLiveMessageGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of administrators.</para>
        /// </summary>
        [NameInMap("Administrators")]
        [Validation(Required=false)]
        public string AdministratorsShrink { get; set; }

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
        /// <para>The ID of the group creator. The ID can be up to 64 bytes in length and can contain letters and digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uid1</para>
        /// </summary>
        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <para>The data center. It must be the same as the data center that was specified when you called the <a href="https://help.aliyun.com/document_detail/2593195.html">CreateLiveMessageApp</a> operation to create the interactive messaging application. Valid values: cn-shanghai and ap-southeast-1 (Singapore).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

        /// <summary>
        /// <para>The ID of the group that you want to create. The group ID must be unique within your business. The ID can be up to 64 bytes in length and can contain letters and digits.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>grouptest</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The additional information about the group. The value can be up to 32 KB in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testgroupinfo</para>
        /// </summary>
        [NameInMap("GroupInfo")]
        [Validation(Required=false)]
        public string GroupInfo { get; set; }

        /// <summary>
        /// <para>The name of the group. The name can be up to 128 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mytestgroup</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

    }

}
