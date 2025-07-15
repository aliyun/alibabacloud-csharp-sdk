// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateMessageGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the interactive messaging application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a494caec-***-695ef345db77</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the creator. The ID can be up to 36 characters in length and can contain only letters and digits.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>as****hs</para>
        /// </summary>
        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <para>The extended field.</para>
        /// </summary>
        [NameInMap("Extension")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extension { get; set; }

    }

}
