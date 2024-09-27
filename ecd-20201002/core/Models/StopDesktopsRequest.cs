// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class StopDesktopsRequest : TeaModel {
        /// <summary>
        /// <para>The client ID. The system generates a unique ID for each client.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f4a0dc8e-1702-4728-9a60-95b27a35****</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The operating system (OS) of the device that runs the Alibaba Cloud Workspace client (hereinafter referred to as WUYING client).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Windows_NT 10.0.18363 x64</para>
        /// </summary>
        [NameInMap("ClientOS")]
        [Validation(Required=false)]
        public string ClientOS { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How do I ensure the idempotence of a request?</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>6ce412a8-399f-49f9-9518-66ee028a****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The client version. If you use a WUYING client, you can view the client version in the <b>About</b> dialog box on the client logon page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.1.0-R-20210731.151756</para>
        /// </summary>
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// <para>The IDs of the cloud computers. You can specify the IDs of 1 to 20 cloud computers.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-7w78ozhjcwa3u****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>The logon token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v18101ac6a9e69c66b04a163031680463660b4b216cd758f34b60b9ad6a7c7f7334b83dd8f75eef4209c68f9f1080b****</para>
        /// </summary>
        [NameInMap("LoginToken")]
        [Validation(Required=false)]
        public string LoginToken { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the regions supported by WUYING Workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cd45e873-650d-4d70-acb9-f996187a****</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The logon token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04b7b80a0b020715c5c1b4175fc4771698****9e2a759557a4624665fd53ae40</para>
        /// </summary>
        [NameInMap("SessionToken")]
        [Validation(Required=false)]
        public string SessionToken { get; set; }

    }

}
