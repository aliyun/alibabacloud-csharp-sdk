// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateApplicationDescriptionRequest : TeaModel {
        /// <summary>
        /// <para>The new description of the application. The description can be up to 1,024 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>newdesc</para>
        /// </summary>
        [NameInMap("AppDescription")]
        [Validation(Required=false)]
        public string AppDescription { get; set; }

        /// <summary>
        /// <para>The ID of the application that you want to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

    }

}
