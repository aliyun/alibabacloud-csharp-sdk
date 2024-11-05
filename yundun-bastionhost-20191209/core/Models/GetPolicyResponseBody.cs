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
            /// <para>The details of the logon period restrictions.</para>
            /// </summary>
            [NameInMap("AccessTimeRangeConfig")]
            [Validation(Required=false)]
            public GetPolicyResponseBodyPolicyAccessTimeRangeConfig AccessTimeRangeConfig { get; set; }
            public class GetPolicyResponseBodyPolicyAccessTimeRangeConfig : TeaModel {
                /// <summary>
                /// <para>The details of the periods during which logons are allowed.</para>
                /// </summary>
                [NameInMap("EffectiveTime")]
                [Validation(Required=false)]
                public List<GetPolicyResponseBodyPolicyAccessTimeRangeConfigEffectiveTime> EffectiveTime { get; set; }
                public class GetPolicyResponseBodyPolicyAccessTimeRangeConfigEffectiveTime : TeaModel {
                    /// <summary>
                    /// <para>The days of a week on which logons are allowed.</para>
                    /// </summary>
                    [NameInMap("Days")]
                    [Validation(Required=false)]
                    public List<string> Days { get; set; }

                    /// <summary>
                    /// <para>The time periods during which logons are allowed.</para>
                    /// </summary>
                    [NameInMap("Hours")]
                    [Validation(Required=false)]
                    public List<string> Hours { get; set; }

                }

            }

            /// <summary>
            /// <para>The O\&amp;M approval setting.</para>
            /// </summary>
            [NameInMap("ApprovalConfig")]
            [Validation(Required=false)]
            public GetPolicyResponseBodyPolicyApprovalConfig ApprovalConfig { get; set; }
            public class GetPolicyResponseBodyPolicyApprovalConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether O\&amp;M approval is enabled in the control policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>On</b>: O\&amp;M approval is enabled.</description></item>
                /// <item><description><b>Off</b>: O\&amp;M approval is disabled.</description></item>
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
            /// <para>The details of the command policy.</para>
            /// </summary>
            [NameInMap("CommandConfig")]
            [Validation(Required=false)]
            public GetPolicyResponseBodyPolicyCommandConfig CommandConfig { get; set; }
            public class GetPolicyResponseBodyPolicyCommandConfig : TeaModel {
                /// <summary>
                /// <para>The details of the command approval settings.</para>
                /// </summary>
                [NameInMap("Approval")]
                [Validation(Required=false)]
                public GetPolicyResponseBodyPolicyCommandConfigApproval Approval { get; set; }
                public class GetPolicyResponseBodyPolicyCommandConfigApproval : TeaModel {
                    /// <summary>
                    /// <para>An array of commands that can be run only after approval.</para>
                    /// </summary>
                    [NameInMap("Commands")]
                    [Validation(Required=false)]
                    public List<string> Commands { get; set; }

                }

                /// <summary>
                /// <para>The details of the command control setting.</para>
                /// </summary>
                [NameInMap("Deny")]
                [Validation(Required=false)]
                public GetPolicyResponseBodyPolicyCommandConfigDeny Deny { get; set; }
                public class GetPolicyResponseBodyPolicyCommandConfigDeny : TeaModel {
                    /// <summary>
                    /// <para>The type of command control. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>white: whitelist mode.</description></item>
                    /// <item><description>black: blacklist mode.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>black</para>
                    /// </summary>
                    [NameInMap("AclType")]
                    [Validation(Required=false)]
                    public string AclType { get; set; }

                    /// <summary>
                    /// <para>An array of controlled commands.</para>
                    /// </summary>
                    [NameInMap("Commands")]
                    [Validation(Required=false)]
                    public List<string> Commands { get; set; }

                }

            }

            /// <summary>
            /// <para>The description of the control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The access control settings on source IP addresses.</para>
            /// </summary>
            [NameInMap("IPAclConfig")]
            [Validation(Required=false)]
            public GetPolicyResponseBodyPolicyIPAclConfig IPAclConfig { get; set; }
            public class GetPolicyResponseBodyPolicyIPAclConfig : TeaModel {
                /// <summary>
                /// <para>The mode of access control on source IP addresses. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>white: whitelist mode.</description></item>
                /// <item><description>black: blacklist mode.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>black</para>
                /// </summary>
                [NameInMap("AclType")]
                [Validation(Required=false)]
                public string AclType { get; set; }

                /// <summary>
                /// <para>The IP addresses from which logons are not allowed.</para>
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
            /// <para>The details of protocol control.</para>
            /// </summary>
            [NameInMap("ProtocolConfig")]
            [Validation(Required=false)]
            public GetPolicyResponseBodyPolicyProtocolConfig ProtocolConfig { get; set; }
            public class GetPolicyResponseBodyPolicyProtocolConfig : TeaModel {
                /// <summary>
                /// <para>The configuration details of Remote Desktop Protocol (RDP) options.</para>
                /// </summary>
                [NameInMap("RDP")]
                [Validation(Required=false)]
                public GetPolicyResponseBodyPolicyProtocolConfigRDP RDP { get; set; }
                public class GetPolicyResponseBodyPolicyProtocolConfigRDP : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether downloading from the clipboard is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Enable</description></item>
                    /// <item><description>Disable</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("ClipboardDownload")]
                    [Validation(Required=false)]
                    public string ClipboardDownload { get; set; }

                    /// <summary>
                    /// <para>Indicates whether file uploading from the clipboard is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Enable</description></item>
                    /// <item><description>Disable</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("ClipboardUpload")]
                    [Validation(Required=false)]
                    public string ClipboardUpload { get; set; }

                    /// <summary>
                    /// <para>Indicates whether driver mapping is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Enable</description></item>
                    /// <item><description>Disable</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("DiskRedirection")]
                    [Validation(Required=false)]
                    public string DiskRedirection { get; set; }

                    /// <summary>
                    /// <para>Indicates whether keyboard recording is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Enable</description></item>
                    /// <item><description>Disable</description></item>
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
                /// <para>The configuration details of SSH and SSH File Transfer Protocol (SFTP) options.</para>
                /// </summary>
                [NameInMap("SSH")]
                [Validation(Required=false)]
                public GetPolicyResponseBodyPolicyProtocolConfigSSH SSH { get; set; }
                public class GetPolicyResponseBodyPolicyProtocolConfigSSH : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether remote command execution is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Enable</description></item>
                    /// <item><description>Disable</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("ExecCommand")]
                    [Validation(Required=false)]
                    public string ExecCommand { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the SFTP channel option is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Enable</description></item>
                    /// <item><description>Disable</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("SFTPChannel")]
                    [Validation(Required=false)]
                    public string SFTPChannel { get; set; }

                    /// <summary>
                    /// <para>Indicates whether file downloading is enabled in SFTP-based O\&amp;M. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Enable</description></item>
                    /// <item><description>Disable</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("SFTPDownloadFile")]
                    [Validation(Required=false)]
                    public string SFTPDownloadFile { get; set; }

                    /// <summary>
                    /// <para>Indicates whether folder creation is enabled in SFTP-based O\&amp;M. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Enable</description></item>
                    /// <item><description>Disable</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("SFTPMkdir")]
                    [Validation(Required=false)]
                    public string SFTPMkdir { get; set; }

                    /// <summary>
                    /// <para>Indicates whether file deletion is enabled in SFTP-based O\&amp;M. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Enable</description></item>
                    /// <item><description>Disable</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("SFTPRemoveFile")]
                    [Validation(Required=false)]
                    public string SFTPRemoveFile { get; set; }

                    /// <summary>
                    /// <para>Indicates whether file renaming is enabled in SFTP-based O\&amp;M. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Enable</description></item>
                    /// <item><description>Disable</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("SFTPRenameFile")]
                    [Validation(Required=false)]
                    public string SFTPRenameFile { get; set; }

                    /// <summary>
                    /// <para>Indicates whether folder deletion is enabled in SFTP-based O\&amp;M. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Enable</description></item>
                    /// <item><description>Disable</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("SFTPRmdir")]
                    [Validation(Required=false)]
                    public string SFTPRmdir { get; set; }

                    /// <summary>
                    /// <para>Indicates whether file uploading is enabled in SFTP-based O\&amp;M. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Enable</description></item>
                    /// <item><description>Disable</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("SFTPUploadFile")]
                    [Validation(Required=false)]
                    public string SFTPUploadFile { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the SSH channel option is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Enable</description></item>
                    /// <item><description>Disable</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enable</para>
                    /// </summary>
                    [NameInMap("SSHChannel")]
                    [Validation(Required=false)]
                    public string SSHChannel { get; set; }

                    /// <summary>
                    /// <para>Indicates whether X11 forwarding is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Enable</description></item>
                    /// <item><description>Disable</description></item>
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
