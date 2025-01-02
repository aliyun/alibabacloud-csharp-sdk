// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeInvocationsRequest : TeaModel {
        /// <summary>
        /// <para>Sets the encoding method for the <c>CommandContent</c> and <c>Output</c> fields in the returned data. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>PlainText: Returns the original command content and output information.</description></item>
        /// <item><description>Base64: Returns the Base64-encoded command content and output information.</description></item>
        /// </list>
        /// <para>Default value: Base64.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PlainText</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <para>Indicates whether to return the output information of the command execution in the result.</para>
        /// <list type="bullet">
        /// <item><description>true: Return. In this case, you must specify at least the <c>InvokeId</c> or <c>InstanceId</c> parameter.</description></item>
        /// <item><description>false: Do not return.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeOutput")]
        [Validation(Required=false)]
        public bool? IncludeOutput { get; set; }

        /// <summary>
        /// <para>Command execution ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-cd03crwys0lrls0</para>
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>e01-cn-zvp2tgykr08</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

    }

}
