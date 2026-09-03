// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RunCommandRequest : TeaModel {
        /// <summary>
        /// <para>The plaintext or Base64-encoded content of the script. The Base64-encoded script content cannot exceed 16 KB.</para>
        /// <remarks>
        /// <para>If the script content is Base64-encoded, set the ContentEncoding parameter to Base64.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipconfig</para>
        /// </summary>
        [NameInMap("CommandContent")]
        [Validation(Required=false)]
        public string CommandContent { get; set; }

        /// <summary>
        /// <para>The role used when the command is executed on the cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("CommandRole")]
        [Validation(Required=false)]
        public string CommandRole { get; set; }

        /// <summary>
        /// <para>The encoding method of the script content.</para>
        /// <remarks>
        /// <para>If the specified value is not within the valid values, the value is treated as PlainText.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Base64</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <para>The IDs of cloud computers. Valid values of N: 1 to 50. If you specify multiple cloud computers, the API call succeeds as long as the script is successfully executed on at least one cloud computer. If the script fails to be executed on all specified cloud computers, reset this parameter.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>The ID of the end user. If this parameter is specified, the command is executed with the permissions of the end user.</para>
        /// <remarks>
        /// <para>The user must have a session record on the cloud computer (the user has logged on and connected to the cloud computer after it is started, and the connection was not preempted by another user). This parameter is not supported for Linux cloud computers.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The timeout period for executing the script. Unit: seconds. Default value: 300. A timeout may occur when the script cannot run due to process issues, missing modules, or missing Cloud Assistant Agent. After a timeout, the script process is forcefully terminated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

        /// <summary>
        /// <para>The language type of the O&amp;M script.</para>
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
