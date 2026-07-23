// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetManagedDataKeyRequest : TeaModel {
        /// <summary>
        /// <para>The name of the managed data key (DK). This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-data-key</para>
        /// </summary>
        [NameInMap("DataKeyName")]
        [Validation(Required=false)]
        public string DataKeyName { get; set; }

        /// <summary>
        /// <para>The version number of the managed data key (DK). This parameter is optional. If you set this parameter to a specific version number, the plaintext of the specified version of the managed data key (DK) is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xH6OPUmz</para>
        /// </summary>
        [NameInMap("DataKeyVersionId")]
        [Validation(Required=false)]
        public string DataKeyVersionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the latest version of the managed data key (DK) when no version number is provided. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Returns the latest version of the managed data key (DK).</description></item>
        /// <item><description>false: Returns the first version of the managed data key (DK).</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseLatest")]
        [Validation(Required=false)]
        public bool? UseLatest { get; set; }

    }

}
