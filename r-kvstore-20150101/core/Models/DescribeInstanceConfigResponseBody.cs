// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInstanceConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The default configuration parameters of the instance. For more comprehensive parameter configurations, call the <a href="https://help.aliyun.com/document_detail/473847.html">Describeparamters</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;EvictionPolicy\&quot;:\&quot;volatile-lru\&quot;,\&quot;hash-max-ziplist-entries\&quot;:512,\&quot;zset-max-ziplist-entries\&quot;:128,\&quot;list-max-ziplist-entries\&quot;:512,\&quot;list-max-ziplist-value\&quot;:64,\&quot;zset-max-ziplist-value\&quot;:64,\&quot;set-max-intset-entries\&quot;:512,\&quot;hash-max-ziplist-value\&quot;:64}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The Sentinel compatibility mode, which applies to non-cluster instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>no</b>: disabled. This is the default value.</description></item>
        /// <item><description><b>yes</b>: enabled.<remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/178911.html">Sentinel compatibility mode</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>no</para>
        /// </summary>
        [NameInMap("ParamNoLooseSentinelEnabled")]
        [Validation(Required=false)]
        public string ParamNoLooseSentinelEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow password-free execution of Sentinel-related commands when the Sentinel mode is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>no</b>: disabled. This is the default value.</description></item>
        /// <item><description><b>yes</b>: enabled. After this feature is enabled, you can execute Sentinel commands without a password on any connection and use the SENTINEL command to monitor the +switch-master channel.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>no</para>
        /// </summary>
        [NameInMap("ParamNoLooseSentinelPasswordFreeAccess")]
        [Validation(Required=false)]
        public string ParamNoLooseSentinelPasswordFreeAccess { get; set; }

        /// <summary>
        /// <para>The list of additional password-free commands. After the Sentinel mode and the ParamNoLooseSentinelPasswordFreeAccess parameter are enabled, you can use this parameter to add extra password-free commands. Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ParamNoLooseSentinelPasswordFreeCommands")]
        [Validation(Required=false)]
        public string ParamNoLooseSentinelPasswordFreeCommands { get; set; }

        /// <summary>
        /// <para>The synchronization mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>async</b>: asynchronous mode. This is the default value.</description></item>
        /// <item><description><b>semisync</b>: semi-synchronous mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>async</para>
        /// </summary>
        [NameInMap("ParamReplMode")]
        [Validation(Required=false)]
        public string ParamReplMode { get; set; }

        /// <summary>
        /// <para>The degradation threshold for the semi-synchronous mode. This parameter can be configured only when the semi-synchronous mode is used. Unit: milliseconds. Valid values: 10 to 60000. Default value: 500.</para>
        /// <remarks>
        /// <para>When the synchronization latency exceeds this threshold, the synchronization mode automatically degrades to the asynchronous mode. After the synchronization latency is eliminated, the synchronization mode automatically switches back to the semi-synchronous mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("ParamReplTimeout")]
        [Validation(Required=false)]
        public string ParamReplTimeout { get; set; }

        /// <summary>
        /// <para>The Sentinel compatibility mode, which applies to instances in the cluster architecture proxy mode or read/write splitting architecture. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disabled. This is the default value.</description></item>
        /// <item><description><b>1</b>: enabled.<remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/178911.html">Sentinel compatibility mode</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ParamSentinelCompatEnable")]
        [Validation(Required=false)]
        public string ParamSentinelCompatEnable { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E2C08F6-2D11-4ECD-9A4C-27EF2D3D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
