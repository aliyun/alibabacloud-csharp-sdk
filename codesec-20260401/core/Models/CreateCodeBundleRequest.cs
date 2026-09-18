// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class CreateCodeBundleRequest : TeaModel {
        /// <summary>
        /// <para>An optional CI/CD metadata JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;region&quot;:&quot;cn-beijing&quot;}</para>
        /// </summary>
        [NameInMap("ciMetadata")]
        [Validation(Required=false)]
        public string CiMetadata { get; set; }

        /// <summary>
        /// <para>The file name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-cases.zip</para>
        /// </summary>
        [NameInMap("filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

    }

}
