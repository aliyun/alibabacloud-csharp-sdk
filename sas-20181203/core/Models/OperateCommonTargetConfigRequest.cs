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
        /// <item><description><b>repoName</b>: The name of the repository.</description></item>
        /// <item><description><b>repoNamespace</b>: The namespace of the repository.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>repoName</para>
        /// </summary>
        [NameInMap("FieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// <para>The name of the repository or the namespace of the repository.</para>
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
        /// <para>The parameters for configuring proactive defense for servers, including the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><b>targetType</b>: The dimension of the defense configuration. Currently, only the UUID dimension is supported. Set the value to <b>uuid</b>.</description></item>
        /// <item><description><b>target</b>: The UUID of the server for which you want to configure the defense settings.</description></item>
        /// <item><description><b>flag</b>: Specifies whether to enable or disable proactive defense for the server. Valid values: <b>add</b> (enable) and <b>del</b> (disable).</description></item>
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
        /// <para>The target Asset Type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>uuid</b>: The UUID of the server.</description></item>
        /// <item><description><b>Cluster</b>: The ID of the cluster.</description></item>
        /// <item><description><b>image_repo</b>: The name of the image repository.</description></item>
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
        /// <item><description><b>alidetect-scan-enable</b>: Local file detection is performed only locally.</description></item>
        /// <item><description><b>ACTION-TRIAL-PERMISSION</b>: ActionTrail data delivery.</description></item>
        /// <item><description><b>alidetect</b>: Local file detection engine.</description></item>
        /// <item><description><b>container_prevent_escape</b>: Container escape prevention.</description></item>
        /// <item><description><b>image_repo</b>: Repository image scanning.</description></item>
        /// <item><description><b>proc_filter_switch</b>: Log filtering.</description></item>
        /// <item><description><b>agentless</b>: Agentless detection.</description></item>
        /// <item><description><b>rasp</b>: Application defense.</description></item>
        /// <item><description><b>sensitiveFile</b>: Sensitive information scanning.</description></item>
        /// <item><description><b>aliscriptengine</b>: Deep detection engine.</description></item>
        /// <item><description><b>containerNetwork</b>: Container visualization.</description></item>
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
