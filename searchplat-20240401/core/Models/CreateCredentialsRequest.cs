// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class CreateCredentialsRequest : TeaModel {
        /// <summary>
        /// <para>The credential type. Valid types:</para>
        /// <list type="bullet">
        /// <item><description>api-token</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>api-token</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Specifies whether to only validate the request parameters. Default value: false.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Only validates the request parameters.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Validates the request parameters and creates the attribution configuration.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
