// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeInvocationsRequest : TeaModel {
        /// <summary>
        /// <para>The encoding mode of the <c>CommandContent</c> and <c>Output</c> fields in the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PlainText: Returns the original command content and output.</para>
        /// </description></item>
        /// <item><description><para>Base64 (default): Returns the Base64-encoded command content and output.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PlainText</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the command output in the response.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Returns the output. You must specify the <c>InvokeId</c> or <c>NodeId</c> parameter.</para>
        /// </description></item>
        /// <item><description><para>false (default): Does not return the output.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeOutput")]
        [Validation(Required=false)]
        public bool? IncludeOutput { get; set; }

        /// <summary>
        /// <para>The ID of the command execution.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-cd03crwys0lrls0</para>
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e01-cn-zvp2tgykr08</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

    }

}
