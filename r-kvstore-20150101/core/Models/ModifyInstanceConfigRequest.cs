// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyInstanceConfigRequest : TeaModel {
        /// <summary>
        /// <para>The instance parameters to modify, in JSON format. The new values overwrite the existing values. For example, if you want to set only the <b>maxmemory-policy</b> parameter to <b>noeviction</b>, pass in <c>{&quot;maxmemory-policy&quot;:&quot;noeviction&quot;}</c>.</para>
        /// <remarks>
        /// <para>For more information about each parameter, see <a href="https://help.aliyun.com/document_detail/259681.html">Metric description</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;maxmemory-policy&quot;:&quot;volatile-lru&quot;,&quot;zset-max-ziplist-entries&quot;:128,&quot;zset-max-ziplist-value&quot;:64,&quot;hash-max-ziplist-entries&quot;:512,&quot;set-max-intset-entries&quot;:512}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The Sentinel compatibility mode. This parameter applies to non-cluster instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>no</b> (default): disabled.</description></item>
        /// <item><description><b>yes</b>: enabled.<remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/178911.html">Sentinel compatibility mode</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>yes</para>
        /// </summary>
        [NameInMap("ParamNoLooseSentinelEnabled")]
        [Validation(Required=false)]
        public string ParamNoLooseSentinelEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow password-free execution of Sentinel-related commands when Sentinel mode is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>no</b> (default): disabled.</description></item>
        /// <item><description><b>yes</b>: enabled. After this parameter is enabled, you can run Sentinel commands without a password on any connection and use the SENTINEL command to listen on the +switch-master channel.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ParamNoLooseSentinelPasswordFreeAccess")]
        [Validation(Required=false)]
        public string ParamNoLooseSentinelPasswordFreeAccess { get; set; }

        /// <summary>
        /// <para>After Sentinel mode and the ParamNoLooseSentinelPasswordFreeAccess parameter are enabled, use this parameter to add additional password-free commands (empty by default).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>After this parameter is set, the specified commands can be run without a password on any connection. Proceed with caution.</description></item>
        /// <item><description>Commands must be in lowercase letters. Separate multiple commands with commas (,).</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ParamNoLooseSentinelPasswordFreeCommands")]
        [Validation(Required=false)]
        public string ParamNoLooseSentinelPasswordFreeCommands { get; set; }

        /// <summary>
        /// <para>The synchronization pattern. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>async</b> (default): asynchronous</description></item>
        /// <item><description><b>semisync</b>: semi-synchronous.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>async</para>
        /// </summary>
        [NameInMap("ParamReplMode")]
        [Validation(Required=false)]
        public string ParamReplMode { get; set; }

        /// <summary>
        /// <para>The degradation threshold for semi-synchronous mode. This parameter is supported only in semi-synchronous mode. Unit: ms. Valid values: 10 to 60000. Default value: 500.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When the synchronization latency exceeds this threshold, the synchronous mode automatically transforms to asynchronous. When the latency is eliminated, the synchronous mode automatically transforms back to semi-synchronous.</description></item>
        /// <item><description>This parameter is supported only by Tair Enterprise instances. This feature is in public preview.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("ParamSemisyncReplTimeout")]
        [Validation(Required=false)]
        public string ParamSemisyncReplTimeout { get; set; }

        /// <summary>
        /// <para>The Sentinel compatibility mode. This parameter applies to instances that use the proxy connection mode in cluster architecture or instances that use the read/write splitting architecture. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b> (default): disabled.</description></item>
        /// <item><description><b>1</b>: enabled.<remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/178911.html">Sentinel compatibility mode</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ParamSentinelCompatEnable")]
        [Validation(Required=false)]
        public string ParamSentinelCompatEnable { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
