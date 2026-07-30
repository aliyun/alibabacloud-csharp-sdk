// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class GetConnectionTicketRequest : TeaModel {
        /// <summary>
        /// <para>Specifies a custom user-mode application that is automatically launched after the credential is obtained.</para>
        /// <list type="bullet">
        /// <item><description>appPath: String. The path of the application startup file. Example: <c>&quot;C:\\Program Files (x86)\\000\\000.exe&quot;</c>. Use double backslashes (\\) as path separators.</description></item>
        /// <item><description>appParameter: String. The application startup parameters. Example: <c>&quot;meetingid 000 meetingname aaa&quot;</c>. Separate parameters with spaces.</description></item>
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
        /// <para>The ID of the cloud computer for which you want to generate a connection credential. This parameter is required to generate the credential.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-gx2x1dhsmucyy****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// <para>The username of the authorized user of the cloud computer. You must specify an existing authorized user of the cloud computer to generate the credential.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The password of the authorized user of the cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ab123456</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
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
        /// <para>2afbad19-778a-4fc5-9674-1f19c638****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the client. If you use the Apsara Uni-manager client, you can view this parameter in the <b>About</b> dialog box on the client logon page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28c80e90-f71e-4c23-93d6-1225329cf949</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
