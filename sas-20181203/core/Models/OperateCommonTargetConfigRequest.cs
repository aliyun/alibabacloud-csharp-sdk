// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateCommonTargetConfigRequest : TeaModel {
        /// <summary>
        /// <para>The type of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>repoName</b>: the name of the image repository</description></item>
        /// <item><description><b>repoNamespace</b>: the namespace of the image repository</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>repoName</para>
        /// </summary>
        [NameInMap("FieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// <para>The name of the image repository or the namespace of the image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cafcmc-dev</para>
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>182.92.XXX.XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The configuration of proactive defense for your server. The value includes the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>targetType</b>: specifies the dimension from which you manage proactive defense. UUIDs are supported. Set the value to <b>uuid</b>.</description></item>
        /// <item><description><b>target</b>: specifies the UUID of the server for which you want to configure proactive defense.</description></item>
        /// <item><description><b>flag</b>: specifies whether to enable or disable proactive defense for your server. Valid values are <b>add</b> and <b>del</b>. The value add indicates that proactive defense will be enabled for your server. The value del indicates that proactive defense will be disabled for your server.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///       {
        ///             &quot;targetType&quot;: &quot;uuid&quot;,
        ///             &quot;target&quot;: &quot;f329a044-6a2f-49a0-9d33-352f6c1d****&quot;,
        ///             &quot;flag&quot;: &quot;del&quot;
        ///       }
        /// ]</para>
        /// </summary>
        [NameInMap("TargetOperations")]
        [Validation(Required=false)]
        public string TargetOperations { get; set; }

        /// <summary>
        /// <para>The dimension based on which the asset is selected. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>uuid</b>: the UUID of the server</description></item>
        /// <item><description><b>Cluster</b>: the ID of the cluster</description></item>
        /// <item><description><b>image_repo</b>: the name of the image repository</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>uuid</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The type of the feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>alidetect-scan-enable</b>: local file detection</description></item>
        /// <item><description><b>ACTION-TRIAL-PERMISSION</b>: data delivery to ActionTrail</description></item>
        /// <item><description><b>alidetect</b>: local file detection engine</description></item>
        /// <item><description><b>container_prevent_escape</b>: container escape prevention</description></item>
        /// <item><description><b>image_repo</b>: repository image scan</description></item>
        /// <item><description><b>proc_filter_switch</b>: log filtering</description></item>
        /// <item><description><b>agentless</b>: agentless detection</description></item>
        /// <item><description><b>rasp</b>: application protection</description></item>
        /// <item><description><b>sensitiveFile</b>: sensitive file detection</description></item>
        /// <item><description><b>aliscriptengine</b>: in-depth detection engine</description></item>
        /// <item><description><b>containerNetwork</b>: container network visualization</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alidetect</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
