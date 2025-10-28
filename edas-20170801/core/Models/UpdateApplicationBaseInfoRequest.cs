// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateApplicationBaseInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c627c157-560d-43ff-<b><b>-</b></b>********</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The name of the application. The name must start with a letter, and can contain letters, digits, underscores (_), and hyphens (-). The name can be up to 36 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello-edas</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The description of the application. The description can be up to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test application</para>
        /// </summary>
        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// <para>The owner of the application. The value can be up to 127 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@aliyun_xxx.com">test@aliyun_xxx.com</a></para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

    }

}
