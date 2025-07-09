// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyInstanceConfigRequest : TeaModel {
        /// <summary>
        /// <para>需修改的实例参数，格式为JSON，修改后的值会覆盖原来的值。例如您只希望修改<b>maxmemory-policy</b>参数为<b>noeviction</b>，您可以传入<c>{&quot;maxmemory-policy&quot;:&quot;noeviction&quot;}</c>。</para>
        /// <remarks>
        /// <para>关于各参数的详细说明，请参见<a href="https://help.aliyun.com/document_detail/259681.html">参数说明</a>。</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;maxmemory-policy&quot;:&quot;volatile-lru&quot;,&quot;zset-max-ziplist-entries&quot;:128,&quot;zset-max-ziplist-value&quot;:64,&quot;hash-max-ziplist-entries&quot;:512,&quot;set-max-intset-entries&quot;:512}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>实例ID。</para>
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
        /// <para>哨兵兼容模式，适用于非集群实例。取值说明：</para>
        /// <list type="bullet">
        /// <item><description><b>no</b>（默认）：未开启</description></item>
        /// <item><description><b>yes</b>：开启<remarks>
        /// <para>更多信息请参见<a href="https://help.aliyun.com/document_detail/178911.html">Sentinel兼容模式</a>。</para>
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
        /// <para>开启哨兵模式时，是否允许免密执行Sentinel相关命令，取值说明：</para>
        /// <list type="bullet">
        /// <item><description><b>no</b>（默认）：关闭。</description></item>
        /// <item><description><b>yes</b>：开启。开启后，可以在任意连接上免密执行Sentinel命令以及使用SENTINEL命令监听+switch-master通道。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ParamNoLooseSentinelPasswordFreeAccess")]
        [Validation(Required=false)]
        public string ParamNoLooseSentinelPasswordFreeAccess { get; set; }

        /// <summary>
        /// <para>启用哨兵模式及ParamNoLooseSentinelPasswordFreeAccess参数后，可通过本参数添加额外的免密命令列表（默认为空）。</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>设置后可在任意连接上无需密码执行对应命令，请谨慎操作。</description></item>
        /// <item><description>命令需使用小写字母，多个命令以英文逗号(,)分隔。</description></item>
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
        /// <para>同步模式：</para>
        /// <list type="bullet">
        /// <item><description><b>async</b>（默认）：异步</description></item>
        /// <item><description><b>semisync</b>：半同步</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>async</para>
        /// </summary>
        [NameInMap("ParamReplMode")]
        [Validation(Required=false)]
        public string ParamReplMode { get; set; }

        /// <summary>
        /// <para>半同步模式的降级阈值。仅半同步支持配置该参数，单位为ms，取值范围为10~60000，默认为500。</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>当同步延迟超出该阈值时，同步模式会自动转为异步，当同步延迟消除后，同步模式会自动转换为半同步。</description></item>
        /// <item><description>仅Tair企业版实例支持，该功能公测中。</description></item>
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
        /// <para>哨兵兼容模式，适用于集群架构代理连接模式或读写分离架构的实例，取值说明：</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>（默认）：未开启</description></item>
        /// <item><description><b>1</b>：开启<remarks>
        /// <para>更多信息请参见<a href="https://help.aliyun.com/document_detail/178911.html">Sentinel兼容模式</a>。</para>
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
