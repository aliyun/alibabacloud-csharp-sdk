// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateUserTagMetaRequest : TeaModel {
        /// <summary>
        /// <para>The description of the tag. The maximum length is 255 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Job positions within the department</para>
        /// </summary>
        [NameInMap("TagDescription")]
        [Validation(Required=false)]
        public string TagDescription { get; set; }

        /// <summary>
        /// <para>The specified tag ID. The maximum length is 64 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e82f6c6c0333431bad0225b2f85e****</para>
        /// </summary>
        [NameInMap("TagId")]
        [Validation(Required=false)]
        public string TagId { get; set; }

        /// <summary>
        /// <para>The name of the tag. The maximum length is 50 characters. Only letters, digits, and the /, \, |, [, ], (, and ) symbols are allowed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Position</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

    }

}
