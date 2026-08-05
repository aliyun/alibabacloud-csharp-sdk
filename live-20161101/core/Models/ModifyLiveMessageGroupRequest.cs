// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyLiveMessageGroupRequest : TeaModel {
        /// <summary>
        /// <para>The updated list of administrators. Separate multiple administrators with commas (,). You can specify up to three administrators.</para>
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
        /// <para>The data center. It must be the same as the data center specified in the <a href="https://help.aliyun.com/document_detail/2848162.html">CreateLiveMessageApp</a> call. Valid values: cn-shanghai (Shanghai) and ap-southeast-1 (Singapore).</para>
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
        /// <para>The updated extended information of the group. The information can be up to 32 KB in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>newmeta</para>
        /// </summary>
        [NameInMap("GroupInfo")]
        [Validation(Required=false)]
        public string GroupInfo { get; set; }

        /// <summary>
        /// <para>Specifies whether to modify the group administrators.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ModifyAdmin")]
        [Validation(Required=false)]
        public bool? ModifyAdmin { get; set; }

        /// <summary>
        /// <para>Specifies whether to modify the extended information of the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ModifyInfo")]
        [Validation(Required=false)]
        public bool? ModifyInfo { get; set; }

    }

}
