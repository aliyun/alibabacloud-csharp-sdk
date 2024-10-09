// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class InvokeCommandRequest : TeaModel {
        /// <summary>
        /// <para>The command ID. You can call the DescribeCommands operation to query all available command IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-sh02yh0932w****</para>
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// <para>The IDs of the simple application servers. The value can be a JSON array that consists of up to 50 IDs of simple application servers. Separate multiple IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;2ad1ae67295445f598017499dc****&quot;, &quot;2ad1ae67295445f598017123dc****&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The key-value pairs of custom parameters to specify when the custom parameter feature is enabled.</para>
        /// <list type="bullet">
        /// <item><description>You can specify up to 10 custom parameters. Each key in a Map collection cannot be an empty string and can be up to 64 characters in length.</description></item>
        /// <item><description>Values in a Map collection can be empty strings. The total length of the custom parameters and the original command cannot exceed 18 KB after they are encoded in Base64.</description></item>
        /// <item><description>The custom parameter names that you specify for the Parameters parameter must be included in the custom parameter names that you specified when you created the command.</description></item>
        /// <item><description>You can use empty strings to represent the custom parameters that are not specified. If you want to disable the custom parameter feature, you can leave this parameter empty.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;delayed_insert_timeout&quot;:&quot;600&quot;,&quot;max_length_for_sort_data&quot;:&quot;2048&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/189315.html">ListRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the user who runs the command in a simple application server. The username cannot exceed 255 characters in length.</para>
        /// <list type="bullet">
        /// <item><description>For Linux servers, the default value is the root username.</description></item>
        /// <item><description>For Windows servers, the default value is the system username.</description></item>
        /// </list>
        /// <para>You can change the user to run the command only for Linux simple application servers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
