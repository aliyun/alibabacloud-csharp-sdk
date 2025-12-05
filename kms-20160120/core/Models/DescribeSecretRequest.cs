// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DescribeSecretRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return the resource tags of the secret. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The resource tags are returned.</description></item>
        /// <item><description>false: The resource tags are not returned. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FetchTags")]
        [Validation(Required=false)]
        public string FetchTags { get; set; }

        /// <summary>
        /// <para>The name of the secret.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>secret001</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

    }

}
