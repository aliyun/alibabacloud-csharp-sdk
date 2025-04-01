// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyInstanceConfigRequest : TeaModel {
        /// <summary>
        /// <para>The instance parameter settings that you want to modify. Specify this parameter in the JSON format. The new value of a parameter overwrites the original value.</para>
        /// <para>**</para>
        /// <para><b>Description</b> For more information, see <a href="https://help.aliyun.com/document_detail/259681.html">Supported parameters</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;maxmemory-policy&quot;:&quot;volatile-lru&quot;,&quot;zset-max-ziplist-entries&quot;:128,&quot;zset-max-ziplist-value&quot;:64,&quot;hash-max-ziplist-entries&quot;:512,&quot;set-max-intset-entries&quot;:512}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
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
        /// <para>The Sentinel-compatible mode, which is applicable to non-cluster instances. For more information about the parameter, see the relevant documentation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yes</para>
        /// </summary>
        [NameInMap("ParamNoLooseSentinelEnabled")]
        [Validation(Required=false)]
        public string ParamNoLooseSentinelEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow Sentinel commands to be run without requiring a password when the Sentinel mode is enabled. Valid values: Valid values: yes and no. Default value: no. After you set this parameter to yes, you can run Sentinel commands in a virtual private cloud (VPC) without the need to enable the password-free access feature.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ParamNoLooseSentinelPasswordFreeAccess")]
        [Validation(Required=false)]
        public string ParamNoLooseSentinelPasswordFreeAccess { get; set; }

        /// <summary>
        /// <para>After you enable the Sentinel mode and set the ParamNoLooseSentinelPasswordFreeAccess parameter to yes, you can use this parameter to specify an additional list of commands that can be run without requiring a password. By default, this parameter is empty. After you configure this parameter, you can run the specified commands without a password on any connection. Proceed with caution. The commands must be written in lowercase letters. Separate multiple commands with commas (,).</para>
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
        [NameInMap("ParamSemisyncReplTimeout")]
        [Validation(Required=false)]
        public string ParamSemisyncReplTimeout { get; set; }

        /// <summary>
        /// <para>The Sentinel-compatible mode, which is applicable to cluster instances in proxy mode or read/write splitting instances. For more information about the parameter, see the relevant documentation.</para>
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
