// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class UpdateWarningConfigRequest : TeaModel {
        /// <summary>
        /// <para>baseMeAgentId</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ridList&quot;:[18130],&quot;configName&quot;:&quot;0310&quot;,&quot;channels&quot;:[{&quot;type&quot;:1,&quot;url&quot;:&quot;<a href="https://sca.console.aliyun.com/#/warningConfig%22%7D%5D,%22configId%22:29%7D">https://sca.console.aliyun.com/#/warningConfig&quot;}],&quot;configId&quot;:29}</a></para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
