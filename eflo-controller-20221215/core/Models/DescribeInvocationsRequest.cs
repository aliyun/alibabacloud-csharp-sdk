// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeInvocationsRequest : TeaModel {
        /// <summary>
        /// <para>The encoding mode of the <c>CommandContent</c> and <c>Output</c> response parameters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PlainText: returns the original command content and command outputs.</description></item>
        /// <item><description>Base64 (default): returns the Base64-encoded command content and command output.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PlainText</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the command outputs in the response.</para>
        /// <list type="bullet">
        /// <item><description>true: returns the command outputs. When this parameter is set to true, you must specify <c>InvokeId</c>, <c>InstanceId</c>, or both.</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeOutput")]
        [Validation(Required=false)]
        public bool? IncludeOutput { get; set; }

        /// <summary>
        /// <para>The execution ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-cd03crwys0lrls0</para>
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e01-cn-zvp2tgykr08</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

    }

}
