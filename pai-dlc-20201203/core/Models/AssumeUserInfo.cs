// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class AssumeUserInfo : TeaModel {
        /// <summary>
        /// <para>The AccessKey ID used for role assumption.</para>
        /// </summary>
        [NameInMap("AccessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>203610320085271232</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The security token used for role assumption.</para>
        /// </summary>
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The user identity type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sub</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
