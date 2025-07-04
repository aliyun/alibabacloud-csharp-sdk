// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RunCommandRequest : TeaModel {
        /// <summary>
        /// <para>The content of the command. The command content can be plaintext or Base64-encoded.\
        /// The Base64-encoded command content cannot exceed 16 KB in size.</para>
        /// <remarks>
        /// <para>If the command content is Base64-encoded, you must set the ContentEncoding parameter to Base64.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipconfig</para>
        /// </summary>
        [NameInMap("CommandContent")]
        [Validation(Required=false)]
        public string CommandContent { get; set; }

        [NameInMap("CommandRole")]
        [Validation(Required=false)]
        public string CommandRole { get; set; }

        /// <summary>
        /// <para>The encoding mode of the command content. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PlainText: The command content is not encoded.</description></item>
        /// <item><description>Base64: The command content is Base64-encoded.</description></item>
        /// </list>
        /// <para>Default value: PlainText. If the specified value of this parameter is invalid, PlainText is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Base64</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <para>The ID of cloud desktop N. Valid values of N: 1 to 50.\
        /// If multiple cloud desktops are specified and the command execution succeeds on at least one of the cloud desktops, the operation is considered successful. If multiple cloud desktops are specified and the command execution fails on all the cloud desktops, verify the value of the parameter and try again.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>The ID of the end user. If you specify a value, you run the command as the end user that is granted specific permissions. Note: The end user has sessions on a cloud computer. That is, when the cloud computer is started, the end user logs on to an Alibaba Cloud Workspace client and connects to the cloud computer, and the cloud computer is not preempted by another end user during the connection. This parameter is not available for Linux cloud computers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>User1</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The timeout period for the command to run. Unit: seconds. Default value: 60.\
        /// A timeout error occurs if the command cannot be run because the process slows down or because a specific module or the Cloud Assistant client does not exist. When a timeout error occurs, the command process is forcibly terminated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

        /// <summary>
        /// <para>The language of the O\&amp;M command. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RunBatScript</description></item>
        /// <item><description>RunPowerShellScript</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RunPowerShellScript</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
