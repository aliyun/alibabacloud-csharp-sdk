// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInstanceConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The parameter settings of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/43885.html">Parameter overview and configuration guide</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;EvictionPolicy\&quot;:\&quot;volatile-lru\&quot;,\&quot;hash-max-ziplist-entries\&quot;:512,\&quot;zset-max-ziplist-entries\&quot;:128,\&quot;list-max-ziplist-entries\&quot;:512,\&quot;list-max-ziplist-value\&quot;:64,\&quot;zset-max-ziplist-value\&quot;:64,\&quot;set-max-intset-entries\&quot;:512,\&quot;hash-max-ziplist-value\&quot;:64}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        [NameInMap("ParamNoLooseSentinelEnabled")]
        [Validation(Required=false)]
        public string ParamNoLooseSentinelEnabled { get; set; }

        [NameInMap("ParamNoLooseSentinelPasswordFreeAccess")]
        [Validation(Required=false)]
        public string ParamNoLooseSentinelPasswordFreeAccess { get; set; }

        [NameInMap("ParamNoLooseSentinelPasswordFreeCommands")]
        [Validation(Required=false)]
        public string ParamNoLooseSentinelPasswordFreeCommands { get; set; }

        [NameInMap("ParamReplMode")]
        [Validation(Required=false)]
        public string ParamReplMode { get; set; }

        [NameInMap("ParamReplTimeout")]
        [Validation(Required=false)]
        public string ParamReplTimeout { get; set; }

        [NameInMap("ParamSentinelCompatEnable")]
        [Validation(Required=false)]
        public string ParamSentinelCompatEnable { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E2C08F6-2D11-4ECD-9A4C-27EF2D3D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
