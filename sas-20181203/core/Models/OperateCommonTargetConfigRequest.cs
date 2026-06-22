// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateCommonTargetConfigRequest : TeaModel {
        /// <summary>
        /// <para>The target type of the image switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>repoName</b>: repository name.</description></item>
        /// <item><description><b>repoNamespace</b>: repository namespace name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>repoName</para>
        /// </summary>
        [NameInMap("FieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// <para>The repository name or repository namespace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cafcmc-dev</para>
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>182.92.XXX.XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The parameters for configuring proactive defense on servers. The following parameters are included:</para>
        /// <list type="bullet">
        /// <item><description><b>targetType</b>: the dimension of the defense configuration. Currently, only the UUID dimension is supported. Fixed value: <b>uuid</b>.</description></item>
        /// <item><description><b>target</b>: the UUID of the server for which you want to configure proactive defense.</description></item>
        /// <item><description><b>flag</b>: specifies whether to enable or disable proactive defense for the server. Valid values: <b>add</b> (enable) and <b>del</b> (disable).</description></item>
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
        /// <para>The Asset Type of the target. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>uuid</b>: server UUID.</description></item>
        /// <item><description><b>Cluster</b>: cluster ID.</description></item>
        /// <item><description><b>image_repo</b>: image repository name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>uuid</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The switch type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>alidetect-scan-enable</b>: local file detection that performs detection only locally.</description></item>
        /// <item><description><b>ACTION-TRIAL-PERMISSION</b>: ActionTrail data delivery.</description></item>
        /// <item><description><b>alidetect</b>: local file detection engine.</description></item>
        /// <item><description><b>container_prevent_escape</b>: container escape prevention.</description></item>
        /// <item><description><b>image_repo</b>: repository image scanning.</description></item>
        /// <item><description><b>proc_filter_switch</b>: log filtering.</description></item>
        /// <item><description><b>agentless</b>: agentless detection.</description></item>
        /// <item><description><b>rasp</b>: application protection.</description></item>
        /// <item><description><b>sensitiveFile</b>: sensitive information scanning.</description></item>
        /// <item><description><b>aliscriptengine</b>: deep detection engine.</description></item>
        /// <item><description><b>containerNetwork</b>: container visualization.</description></item>
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
