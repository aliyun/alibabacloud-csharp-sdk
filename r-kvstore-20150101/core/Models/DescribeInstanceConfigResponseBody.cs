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

        /// <summary>
        /// <para>The Sentinel-compatible mode, which is applicable to non-cluster instances. For more information about the parameter, see the relevant documentation.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ParamNoLooseSentinelEnabled")]
        [Validation(Required=false)]
        public string ParamNoLooseSentinelEnabled { get; set; }

        /// <summary>
        /// <para>Indicates whether Sentinel commands can be run without requiring a password when the Sentinel mode is enabled. Valid values: Valid values: yes and no. Default value: no. After you set this parameter to yes, you can run Sentinel commands in a virtual private cloud (VPC) without the need to enable the password-free access feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>no</para>
        /// </summary>
        [NameInMap("ParamNoLooseSentinelPasswordFreeAccess")]
        [Validation(Required=false)]
        public string ParamNoLooseSentinelPasswordFreeAccess { get; set; }

        /// <summary>
        /// <para>After you enable the Sentinel mode and set the ParamNoLooseSentinelPasswordFreeAccess parameter to yes, you can use this parameter to specify an additional list of commands that can be run without requiring a password. By default, this parameter is empty. After you configure this parameter, you can run the specified commands without a password on any connection. Proceed with caution. The commands must be written in lowercase letters. Multiple commands are separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ParamNoLooseSentinelPasswordFreeCommands")]
        [Validation(Required=false)]
        public string ParamNoLooseSentinelPasswordFreeCommands { get; set; }

        /// <summary>
        /// <para>The synchronization mode.</para>
        /// <list type="bullet">
        /// <item><description><b>semisync</b></description></item>
        /// <item><description><b>async</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>async</para>
        /// </summary>
        [NameInMap("ParamReplMode")]
        [Validation(Required=false)]
        public string ParamReplMode { get; set; }

        /// <summary>
        /// <para>The degradation threshold time of the semi-synchronous replication mode. This parameter is required only when semi-synchronous replication is enabled. Unit: milliseconds. Valid values: 10 to 60000.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ParamReplTimeout")]
        [Validation(Required=false)]
        public string ParamReplTimeout { get; set; }

        /// <summary>
        /// <para>The Sentinel-compatible mode, which is applicable to cluster instances in proxy mode or read/write splitting instances. For more information about the parameter, see the relevant documentation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
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
