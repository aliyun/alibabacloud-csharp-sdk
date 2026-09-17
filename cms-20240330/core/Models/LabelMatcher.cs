// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class LabelMatcher : TeaModel {
        /// <summary>
        /// <para>The key name of the label matcher. This parameter specifies the label dimension identity to match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>_cms_workspace</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The match value of the label matcher. This parameter is used together with key to specify the value that the label key must match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-123</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
