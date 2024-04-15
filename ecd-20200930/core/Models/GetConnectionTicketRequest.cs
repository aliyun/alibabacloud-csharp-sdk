// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class GetConnectionTicketRequest : TeaModel {
        /// <summary>
        /// The command that you want to run to configure a custom application in user mode. After you obtain the credential, the application is automatically started. Parameter description in the command:
        /// 
        /// *   appPath: the path of the application startup file. Example: `"C:\\Program Files (x86)\\000\\000.exe"`. Use double slashes (\\\) as the delimiter. Type of the parameter value: string.
        /// *   appParameter: the startup arguments of the application. Example: `"meetingid 000 meetingname aaa"`. Separate multiple arguments with spaces. Type of the parameter value: string.
        /// </summary>
        [NameInMap("CommandContent")]
        [Validation(Required=false)]
        public string CommandContent { get; set; }

        /// <summary>
        /// The ID of the cloud computer for which you want to generate a connection credential. This parameter is required.
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// The ID of the end user of the cloud computer. The end user must be the current end user of the cloud computer.
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The password of the current end user of the cloud computer.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
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
        /// The ID of the cloud computer connection task.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The unique identifier of the client. If you use an Alibaba Cloud Workspace client, click **About** on the client logon page to view the identifier of the client.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
