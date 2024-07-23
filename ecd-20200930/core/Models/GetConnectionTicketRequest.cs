// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class GetConnectionTicketRequest : TeaModel {
        /// <summary>
        /// <para>The command that you want to run to configure a custom application in user mode. After you obtain the credential, the application is automatically started. Parameter description in the command:</para>
        /// <list type="bullet">
        /// <item><description>appPath: the path of the application startup file. Example: <c>&quot;C:\\\\Program Files (x86)\\\\000\\\\000.exe&quot;</c>. Use double slashes (\\\) as the delimiter. Type of the parameter value: string.</description></item>
        /// <item><description>appParameter: the startup arguments of the application. Example: <c>&quot;meetingid 000 meetingname aaa&quot;</c>. Separate multiple arguments with spaces. Type of the parameter value: string.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;startApplication&quot;: {
        ///             &quot;startApplicationList&quot;: [
        ///                   {
        ///                         &quot;sessionName&quot;: &quot;&quot;,
        ///                         &quot;appList&quot;: [
        ///                               {
        ///                                     &quot;appPath&quot;: &quot;C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe&quot;,
        ///                                     &quot;appParameter&quot;: &quot;<a href="http://www.example.com">www.example.com</a> <a href="http://www.example1.com">www.example1.com</a>&quot;
        ///                               }
        ///                         ]
        ///                   }
        ///             ]
        ///       }
        /// }</para>
        /// </summary>
        [NameInMap("CommandContent")]
        [Validation(Required=false)]
        public string CommandContent { get; set; }

        /// <summary>
        /// <para>The ID of the cloud computer for which you want to generate a connection credential. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-gx2x1dhsmucyy****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// <para>The ID of the end user of the cloud computer. The end user must be the current end user of the cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The password of the current end user of the cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ab123456</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the cloud computer connection task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2afbad19-778a-4fc5-9674-1f19c63862da</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the client. If you use an Alibaba Cloud Workspace client, click <b>About</b> on the client logon page to view the identifier of the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28c80e90-f71e-4c23-93d6-1225329cf949</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
