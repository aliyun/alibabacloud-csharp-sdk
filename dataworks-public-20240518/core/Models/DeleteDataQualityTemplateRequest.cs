// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DeleteDataQualityTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the custom rule template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER_DEFINED:2001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
