// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAbolishApiTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the unpublishing operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fc54<em><em><b>dd4c4</b></em>ad7edd7</em>***39401</para>
        /// </summary>
        [NameInMap("OperationUid")]
        [Validation(Required=false)]
        public string OperationUid { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
