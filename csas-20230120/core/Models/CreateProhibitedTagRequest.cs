// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateProhibitedTagRequest : TeaModel {
        /// <summary>
        /// <para>The description of the prohibited software tag. The description can be up to 128 characters in length and can contain Chinese characters, uppercase and lowercase English letters, digits, spaces, periods (.), underscores (_), and hyphens (-). This parameter can be left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the prohibited software tag. Fuzzy match is supported. The name can be up to 128 characters in length and can contain Chinese characters, uppercase and lowercase English letters, digits, periods (.), underscores (_), and hyphens (-). Spaces are not allowed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>autotest_616bcc13</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
