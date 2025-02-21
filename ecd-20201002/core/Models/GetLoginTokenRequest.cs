// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class GetLoginTokenRequest : TeaModel {
        /// <summary>
        /// <para>The verification code that is generated by the virtual MFA device. This parameter is required if you set <c>CurrentStage</c> to <c>MFAVerify</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47****</para>
        /// </summary>
        [NameInMap("AuthenticationCode")]
        [Validation(Required=false)]
        public string AuthenticationCode { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud Workspace client. The system generates a unique ID for each client.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f4a0dc8e-1702-4728-9a60-95b27a35****</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The operating system (OS) of the device that runs an Alibaba Cloud Workspace client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Windows_NT 10.0.1**** x64</para>
        /// </summary>
        [NameInMap("ClientOS")]
        [Validation(Required=false)]
        public string ClientOS { get; set; }

        /// <summary>
        /// <para>The type of Alibaba Cloud Workspace clients.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>HTML5: web client.</para>
        /// </description></item>
        /// <item><description><para>WINDOWS: Windows client.</para>
        /// </description></item>
        /// <item><description><para>MACOS: macOS client.</para>
        /// </description></item>
        /// <item><description><para>IOS: iOS client.</para>
        /// </description></item>
        /// <item><description><para>ANDROID: Android client.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public string ClientType { get; set; }

        /// <summary>
        /// <para>The version of the client. When you use an Alibaba Cloud Workspace client, you can view the client version in the <b>About</b> dialog box on the client logon page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.1.0-R-20210731.1****</para>
        /// </summary>
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// <para>The logon authentication stage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ADPassword</c>: the stage to verify the identity of the Active Directory (AD) user. You must specify the value when the system verifies the identity of a convenience account or an AD account.</description></item>
        /// <item><description><c>MFABind: the stage to bind a virtual multi-factor authentication (MFA) device.</c></description></item>
        /// <item><description><c>MFAVerify: the stage to verify the verification code that is generated by the virtual MFA device.</c></description></item>
        /// <item><description><c>TokenVerify</c>: the stage to perform two-factor authentication on an Alibaba Cloud Workspace client (hereinafter referred to as the client).</description></item>
        /// <item><description><c>ChangePassword</c>: the stage to change the password of the user.</description></item>
        /// <item><description><c>KeepAliveVerify</c>: the stage to obtain LoginToken if KeepAliveToken is valid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ADPassword</para>
        /// </summary>
        [NameInMap("CurrentStage")]
        [Validation(Required=false)]
        public string CurrentStage { get; set; }

        /// <summary>
        /// <para>The office network ID. This parameter has the same meaning as <c>OfficeSiteId</c>. We recommend that you replace <c>DirectoryId</c> with <c>OfficeSiteId</c>. You can specify a value for <c>DirectoryId</c> or <c>OfficeSiteId</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-885351****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The name of the convenience user or the AD user. This parameter is required if you set <c>CurrentStage</c> to <c>ADPassword</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>Specifies whether to keep the user logged on to the client. 
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description>null: Default value. Do not keep the user logged on to the client.</description></item>
        /// <item><description>true: Keep the user logged on to the client.</description></item>
        /// <item><description>false:  Do not keep the user logged on to the client.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("KeepAlive")]
        [Validation(Required=false)]
        public bool? KeepAlive { get; set; }

        /// <summary>
        /// <para>The token to keep logging on to an Alibaba Cloud Workspace client. When an end user logs on to the Alibaba Cloud Workspace client and select Auto Sign-in, <c>KeepAliveToken</c> is returned after you call this operation. Within the valid period of the returned token``, you can call the <c>GetLoginToken</c> operation and set <c>CurrentStage</c> to <c>KeepAliveVerify</c>. Then, you can obtain LoginToken. If you set <c>CurrentStage</c> to <c>KeepAliveVerify</c>, <c>KeepAliveToken</c> is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hide</para>
        /// </summary>
        [NameInMap("KeepAliveToken")]
        [Validation(Required=false)]
        public string KeepAliveToken { get; set; }

        /// <summary>
        /// <para>The new password. This parameter is required if you set <c>CurrentStage</c> to <c>ChangePassword</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NewPassword</para>
        /// </summary>
        [NameInMap("NewPassword")]
        [Validation(Required=false)]
        public string NewPassword { get; set; }

        /// <summary>
        /// <para>The office network ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-885351****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The current password. This parameter is required if you set <c>CurrentStage</c> to <c>ChangePassword</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OldPassword</para>
        /// </summary>
        [NameInMap("OldPassword")]
        [Validation(Required=false)]
        public string OldPassword { get; set; }

        /// <summary>
        /// <para>The password of the convenience user or the AD user. This parameter is required if you set <c>CurrentStage</c> to <c>ADPassword</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Password1234</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the regions supported by EDS.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the session.</para>
        /// <list type="bullet">
        /// <item><description>If the virtual multi-factor authentication (MFA) device is not bound or two-factor authentication is not enabled for the client, you do not need to specify a value for <c>SessionId</c>.</description></item>
        /// <item><description>If the virtual MFA device is not bound or two-factor authentication is enabled for the client, you must specify a value for <c>SessionId</c> to verify the user identity after you specify a value for <c>ADPassword</c>. The value of the <c>SessionId</c> parameter is returned only if the CurrentStage parameter is set to <c>ADPassword</c> when you call the <c>GetLoginToken</c> operation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cd45e873-650d-4d70-acb9-f996187a****</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>If two-factor authentication is enabled for Alibaba Cloud Workspace terminals in the EDS console and the system detects that the current logon user is exposed to risks, the system sends a verification code to the email address of the user. This parameter is required if you set <c>CurrentStage</c> to <c>TokenVerify</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63****</para>
        /// </summary>
        [NameInMap("TokenCode")]
        [Validation(Required=false)]
        public string TokenCode { get; set; }

        /// <summary>
        /// <para>The unique identifier of the client. When you use an Alibaba Cloud Workspace client, you can view the client version in the <b>About</b> dialog box on the client logon page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C78CA9E99315687575DD2844C1F3****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
