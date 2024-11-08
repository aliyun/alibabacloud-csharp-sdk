// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetSecretParametersRequest : TeaModel {
        /// <summary>
        /// <para>The name of the encryption parameter. Multiple encryption parameters can form a JSON array in the format of [&quot;xxxxxxxxx&quot;, &quot;yyyyyyyyy&quot;, … &quot;zzzzzzzzz&quot;]. Each JSON array can contain a maximum of 10 encryption parameters. Multiple encryption parameters in the array are separated by commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;secretParameter&quot;,&quot;secretParameter1&quot;]</para>
        /// </summary>
        [NameInMap("Names")]
        [Validation(Required=false)]
        public string Names { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to decrypt the parameter value. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("WithDecryption")]
        [Validation(Required=false)]
        public bool? WithDecryption { get; set; }

    }

}
