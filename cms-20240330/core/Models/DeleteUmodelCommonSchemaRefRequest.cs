// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DeleteUmodelCommonSchemaRefRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apm-common</para>
        /// </summary>
        [NameInMap("group")]
        [Validation(Required=false)]
        public string Group { get; set; }

    }

}
