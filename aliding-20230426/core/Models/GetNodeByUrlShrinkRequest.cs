// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetNodeByUrlShrinkRequest : TeaModel {
        [NameInMap("Option")]
        [Validation(Required=false)]
        public string OptionShrink { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://alidocs.dingtalk.com/i/nodes/EpGBa2L*********gN7R35y">https://alidocs.dingtalk.com/i/nodes/EpGBa2L*********gN7R35y</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
