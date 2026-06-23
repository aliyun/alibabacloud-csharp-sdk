// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the control policy.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public GetPolicyResponseBodyPolicy Policy { get; set; }
        public class GetPolicyResponseBodyPolicy : TeaModel {
            /// <summary>
            /// <para>The time-based access control settings.</para>
            /// </summary>
            [NameInMap("AccessTimeRangeConfig")]
            [Validation(Required=false)]
            public GetPolicyResponseBodyPolicyAccessTimeRangeConfig AccessTimeRangeConfig { get; set; }
            public class GetPolicyResponseBodyPolicyAccessTimeRangeConfig : TeaModel {
                /// <summary>
                /// <para>The allowed access time slots.</para>
                /// </summary>
                [NameInMap("EffectiveTime")]
                [Validation(Required=false)]
                public List<GetPolicyResponseBodyPolicyAccessTimeRangeConfigEffectiveTime> EffectiveTime { get; set; }
                public class GetPolicyResponseBodyPolicyAccessTimeRangeConfigEffectiveTime : TeaModel {
                    /// <summary>
                    /// <para>The days of the week when access is allowed.</para>
                    /// </summary>
                    [NameInMap("Days")]
                    [Validation(Required=false)]
                    public List<string> Days { get; set; }

                    /// <summary>
                    /// <para>The hours of the day when access is allowed.</para>
                    /// </summary>
                    [NameInMap("Hours")]
                    [Validation(Required=false)]
                    public List<string> Hours { get; set; }

                }

            }

            /// <summary>
            /// <para>The O\&amp;M approval settings.</para>
            /// </summary>
            [NameInMap("ApprovalConfig")]
            [Validation(Required=false)]
            public GetPolicyResponseBodyPolicyApprovalConfig ApprovalConfig { get; set; }
            public class GetPolicyResponseBodyPolicyApprovalConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether O\&amp;M approval is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>On</b>: O\&amp;M approval is enabled.</para>
                /// </description></item>
                /// <item><description><para><b>Off</b>: O\&amp;M approval is disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Off</para>
                /// </summary>
                [NameInMap("SwitchStatus")]
                [Validation(Required=false)]
                public string SwitchStatus { get; set; }

            }

            /// <summary>
            /// <para>The command control policy.</para>
            /// </summary>
            [NameInMap("CommandConfig")]
            [Validation(Required=false)]
            public GetPolicyResponseBodyPolicyCommandConfig CommandConfig { get; set; }
            public class GetPolicyResponseBodyPolicyCommandConfig : TeaModel {
                /// <summary>
                /// <para>The command approval settings.</para>
                /// </summary>
                [NameInMap("Approval")]
                [Validation(Required=false)]
                public GetPolicyResponseBodyPolicyCommandConfigApproval Approval { get; set; }
                public class GetPolicyResponseBodyPolicyCommandConfigApproval : TeaModel {
                    /// <summary>
                    /// <para>The commands that require approval.</para>
                    /// </summary>
                    [NameInMap("Commands")]
                    [Validation(Required=false)]
                    public List<string> Commands { get; set; }

                }

                /// <summary>
                /// <para>The command control settings.</para>
                /// </summary>
                [NameInMap("Deny")]
                [Validation(Required=false)]
                public GetPolicyResponseBodyPolicyCommandConfigDeny Deny { get; set; }
                public class GetPolicyResponseBodyPolicyCommandConfigDeny : TeaModel {
                    /// <summary>
                    /// <para>The command control mode. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>white</c>: allowlist.</para>
                    /// </description></item>
                    /// <item><description><para><c>black</c>: denylist.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>black</para>
                    /// </summary>
                    [NameInMap("AclType")]
                    [Validation(Required=false)]
                    public string AclType { get; set; }

                    /// <summary>
                    /// <para>The commands in the list.</para>
                    /// </summary>
                    [NameInMap("Commands")]
                    [Validation(Required=false)]
                    public List<string> Commands { get; set; }

                }

            }

            /// <summary>
            /// <para>The remarks on the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The source IP address-based access control settings.</para>
            /// </summary>
            [NameInMap("IPAclConfig")]
            [Validation(Required=false)]
            public GetPolicyResponseBodyPolicyIPAclConfig IPAclConfig { get; set; }
            public class GetPolicyResponseBodyPolicyIPAclConfig : TeaModel {
                /// <summary>
                /// <para>The source IP address-based access control mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>white</c>: allowlist.</para>
                /// </description></item>
                /// <item><description><para><c>black</c>: denylist.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>black</para>
                /// </summary>
                [NameInMap("AclType")]
                [Validation(Required=false)]
                public string AclType { get; set; }

                /// <summary>
                /// <para>The IP addresses in the ACL.</para>
                /// </summary>
                [NameInMap("IPs")]
                [Validation(Required=false)]
                public List<string> IPs { get; set; }

            }

            /// <summary>
            /// <para>The ID of the control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The name of the control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The priority of the control policy. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            /// <summary>
            /// <para>The protocol control settings.</para>
            /// </summary>
            [NameInMap("ProtocolConfig")]
            [Validation(Required=false)]
            public GetPolicyResponseBodyPolicyProtocolConfig ProtocolConfig { get; set; }
            public class GetPolicyResponseBodyPolicyProtocolConfig : TeaModel {
                /// <summary>
                /// <para>The RDP security settings.</para>
                /// </summary>
                [NameInMap("RDP")]
                [Validation(Required=false)]
                public GetPolicyResponseBodyPolicyProtocolConfigRDP RDP { get; set; }
                public class GetPolicyResponseBodyPolicyProtocolConfigRDP : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether clipboard download is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Enable</c></para>
                    /// </description></item>
                    /// <item><description><para><c>Disable</c></para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("ClipboardDownload")]
                    [Validation(Required=false)]
                    public string ClipboardDownload { get; set; }

                    /// <summary>
                    /// <para>Indicates whether clipboard upload is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Enable</c></para>
                    /// </description></item>
                    /// <item><description><para><c>Disable</c></para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("ClipboardUpload")]
                    [Validation(Required=false)]
                    public string ClipboardUpload { get; set; }

                    /// <summary>
                    /// <para>Indicates whether drive redirection and printer mapping are enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Enable</c></para>
                    /// </description></item>
                    /// <item><description><para><c>Disable</c></para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("DiskRedirection")]
                    [Validation(Required=false)]
                    public string DiskRedirection { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("DiskRedirectionDownload")]
                    [Validation(Required=false)]
                    public string DiskRedirectionDownload { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("DiskRedirectionUpload")]
                    [Validation(Required=false)]
                    public string DiskRedirectionUpload { get; set; }

                    /// <summary>
                    /// <para>Indicates whether keyboard recording is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Enable</c></para>
                    /// </description></item>
                    /// <item><description><para><c>Disable</c></para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("RecordKeyboard")]
                    [Validation(Required=false)]
                    public string RecordKeyboard { get; set; }

                }

                /// <summary>
                /// <para>The SSH and SFTP security settings.</para>
                /// </summary>
                [NameInMap("SSH")]
                [Validation(Required=false)]
                public GetPolicyResponseBodyPolicyProtocolConfigSSH SSH { get; set; }
                public class GetPolicyResponseBodyPolicyProtocolConfigSSH : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("AllowDirectTcp")]
                    [Validation(Required=false)]
                    public string AllowDirectTcp { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("AllowTcpForwarding")]
                    [Validation(Required=false)]
                    public string AllowTcpForwarding { get; set; }

                    /// <summary>
                    /// <para>Indicates whether remote command execution is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Enable</c></para>
                    /// </description></item>
                    /// <item><description><para><c>Disable</c></para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("ExecCommand")]
                    [Validation(Required=false)]
                    public string ExecCommand { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the SFTP channel is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Enable</c></para>
                    /// </description></item>
                    /// <item><description><para><c>Disable</c></para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("SFTPChannel")]
                    [Validation(Required=false)]
                    public string SFTPChannel { get; set; }

                    /// <summary>
                    /// <para>Indicates whether file downloads over SFTP are enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Enable</c></para>
                    /// </description></item>
                    /// <item><description><para><c>Disable</c></para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("SFTPDownloadFile")]
                    [Validation(Required=false)]
                    public string SFTPDownloadFile { get; set; }

                    /// <summary>
                    /// <para>Indicates whether directory creation over SFTP is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Enable</c></para>
                    /// </description></item>
                    /// <item><description><para><c>Disable</c></para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("SFTPMkdir")]
                    [Validation(Required=false)]
                    public string SFTPMkdir { get; set; }

                    /// <summary>
                    /// <para>Indicates whether file deletion over SFTP is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Enable</c></para>
                    /// </description></item>
                    /// <item><description><para><c>Disable</c></para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("SFTPRemoveFile")]
                    [Validation(Required=false)]
                    public string SFTPRemoveFile { get; set; }

                    /// <summary>
                    /// <para>Indicates whether file renaming over SFTP is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Enable</c></para>
                    /// </description></item>
                    /// <item><description><para><c>Disable</c></para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("SFTPRenameFile")]
                    [Validation(Required=false)]
                    public string SFTPRenameFile { get; set; }

                    /// <summary>
                    /// <para>Indicates whether directory deletion over SFTP is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Enable</c></para>
                    /// </description></item>
                    /// <item><description><para><c>Disable</c></para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("SFTPRmdir")]
                    [Validation(Required=false)]
                    public string SFTPRmdir { get; set; }

                    /// <summary>
                    /// <para>Indicates whether file uploads over SFTP are enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Enable</c></para>
                    /// </description></item>
                    /// <item><description><para><c>Disable</c></para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("SFTPUploadFile")]
                    [Validation(Required=false)]
                    public string SFTPUploadFile { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the SSH channel is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Enable</c></para>
                    /// </description></item>
                    /// <item><description><para><c>Disable</c></para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("SSHChannel")]
                    [Validation(Required=false)]
                    public string SSHChannel { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("TcpForwarding")]
                    [Validation(Required=false)]
                    public string TcpForwarding { get; set; }

                    /// <summary>
                    /// <para>Indicates whether X11 forwarding is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Enable</c></para>
                    /// </description></item>
                    /// <item><description><para><c>Disable</c></para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("X11Forwarding")]
                    [Validation(Required=false)]
                    public string X11Forwarding { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0D29F2C0-8B4B-5861-9474-F3F23D25594B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
