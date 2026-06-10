// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RunCommandRequest : TeaModel {
        /// <summary>
        /// <para>The script content in plaintext or Base64-encoded format.<br>
        /// The Base64-encoded script content cannot exceed 16 KB.<br></para>
        /// <remarks>
        /// <para>If the script content is Base64-encoded, you must set the <c>ContentEncoding</c> parameter to <c>Base64</c>.</para>
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
        /// <para>The encoding mode of the script content.</para>
        /// <remarks>
        /// <para>If you specify a value that is not a valid enumeration member, the system defaults to <c>PlainText</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Base64</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <para>The IDs of the cloud computers on which to run the script. You can specify up to 50 IDs.<br>
        /// The API call is considered successful if the script runs on at least one of the specified cloud computers. The call fails only if the script fails on all of them.<br></para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>If you specify this parameter, the command runs with the permissions of the specified end user.</para>
        /// <remarks>
        /// <para>This user must have a session history on the cloud computer. This means the user must have logged in after the cloud computer started and their session was not taken over by another user. This parameter is not supported for Linux cloud computers.</para>
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
        /// <para>The script execution timeout, in seconds. Default value: 300.<br>
        /// A command times out if the script cannot be run due to issues such as process conflicts, missing modules, or an unavailable Cloud Assistant client. When a command times out, the system forcibly terminates the script process.<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

        /// <summary>
        /// <para>The type of the script.</para>
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
