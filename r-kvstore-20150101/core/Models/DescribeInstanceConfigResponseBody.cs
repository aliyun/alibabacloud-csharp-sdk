// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInstanceConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The default configuration parameters of the instance. To view the full list of parameters, call the <a href="https://help.aliyun.com/document_detail/473847.html">DescribeParameters</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;EvictionPolicy\&quot;:\&quot;volatile-lru\&quot;,\&quot;hash-max-ziplist-entries\&quot;:512,\&quot;zset-max-ziplist-entries\&quot;:128,\&quot;list-max-ziplist-entries\&quot;:512,\&quot;list-max-ziplist-value\&quot;:64,\&quot;zset-max-ziplist-value\&quot;:64,\&quot;set-max-intset-entries\&quot;:512,\&quot;hash-max-ziplist-value\&quot;:64}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Sentinel compatibility mode. This parameter applies only to non-cluster instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>no</b> (default): Disabled</para>
        /// </description></item>
        /// <item><description><para><b>yes</b>: Enabled</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/178911.html">Sentinel compatibility mode</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>no</para>
        /// </summary>
        [NameInMap("ParamNoLooseSentinelEnabled")]
        [Validation(Required=false)]
        public string ParamNoLooseSentinelEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow password-free execution of Sentinel commands when Sentinel compatibility mode is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>no</b> (default): Disabled.</para>
        /// </description></item>
        /// <item><description><para><b>yes</b>: Enabled. Allows you to run Sentinel commands on any connection without a password and use the <c>SENTINEL</c> command to subscribe to the <c>+switch-master</c> channel.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>no</para>
        /// </summary>
        [NameInMap("ParamNoLooseSentinelPasswordFreeAccess")]
        [Validation(Required=false)]
        public string ParamNoLooseSentinelPasswordFreeAccess { get; set; }

        /// <summary>
        /// <para>Additional commands that can be run without a password. This parameter is valid only when Sentinel compatibility mode is enabled and <c>ParamNoLooseSentinelPasswordFreeAccess</c> is set to <c>yes</c>. By default, this parameter is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ParamNoLooseSentinelPasswordFreeCommands")]
        [Validation(Required=false)]
        public string ParamNoLooseSentinelPasswordFreeCommands { get; set; }

        /// <summary>
        /// <para>The replication mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>async</b> (default): asynchronous mode</para>
        /// </description></item>
        /// <item><description><para><b>semisync</b>: semi-synchronous mode</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>async</para>
        /// </summary>
        [NameInMap("ParamReplMode")]
        [Validation(Required=false)]
        public string ParamReplMode { get; set; }

        /// <summary>
        /// <para>The degradation threshold for the semi-synchronous mode. This parameter is valid only in semi-synchronous mode. Unit: milliseconds. Valid values: 10 to 60000. Default value: 500.</para>
        /// <remarks>
        /// <para>If replication latency exceeds this threshold, the replication mode degrades to asynchronous mode. When the replication latency returns to normal, the mode reverts to semi-synchronous mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("ParamReplTimeout")]
        [Validation(Required=false)]
        public string ParamReplTimeout { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Sentinel compatibility mode. This parameter applies to instances that use the cluster architecture with proxy connection mode or the read/write splitting architecture. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b> (default): Disabled</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Enabled</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/178911.html">Sentinel compatibility mode</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
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
