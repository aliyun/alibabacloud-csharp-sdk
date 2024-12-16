// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeInvocationsRequest : TeaModel {
        /// <summary>
        /// <para>The type of the command. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RunBatScript</description></item>
        /// <item><description>RunPowerShellScript</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RunPowerShellScript</para>
        /// </summary>
        [NameInMap("CommandType")]
        [Validation(Required=false)]
        public string CommandType { get; set; }

        /// <summary>
        /// <para>The encoding method of the command content and output. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PlainText</description></item>
        /// <item><description>Base64</description></item>
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
        /// <para>The ID of the cloud desktop. If you specify a cloud desktop, all the execution records of Cloud Assistant commands on the cloud desktop are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-7w78ozhjcwa3u****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// <para>The IDs of the cloud desktops.</para>
        /// </summary>
        [NameInMap("DesktopIds")]
        [Validation(Required=false)]
        public List<string> DesktopIds { get; set; }

        /// <summary>
        /// <para>The ID of the end user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        [NameInMap("IncludeInvokeDesktops")]
        [Validation(Required=false)]
        public bool? IncludeInvokeDesktops { get; set; }

        /// <summary>
        /// <para>Specifies whether to return command outputs in the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: returns command outputs.</description></item>
        /// <item><description>false: does not return command outputs.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeOutput")]
        [Validation(Required=false)]
        public bool? IncludeOutput { get; set; }

        /// <summary>
        /// <para>The ID of the execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-hz0jdfwd9f****</para>
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        /// <summary>
        /// <para>The overall execution status of a command. The overall execution status is determined by the execution status of the command on one or more cloud desktops. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Running: The execution is in progress on one or more cloud desktops.</description></item>
        /// <item><description>Finished: The execution is finished on all cloud desktops, or the execution is manually stopped on some cloud desktops and the execution is finished on others.</description></item>
        /// <item><description>Failed: The execution failed on all cloud desktops.</description></item>
        /// <item><description>PartialFailed: The execution failed on some cloud desktops.</description></item>
        /// <item><description>Stopped: The execution is stopped.</description></item>
        /// </list>
        /// <para>Default value: Running.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("InvokeStatus")]
        [Validation(Required=false)]
        public string InvokeStatus { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: 1 to 50.</description></item>
        /// <item><description>Default value: 10.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token. Set the value to the NextToken value that is returned from the last call to the previous DescribeInvocations operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nmB7qrRFJ8vmttjxPL****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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

    }

}
