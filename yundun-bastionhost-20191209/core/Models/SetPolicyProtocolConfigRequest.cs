// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class SetPolicyProtocolConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Bastionhost instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain the instance ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-st220aw****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the control policy that you want to modify.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2758876.html">ListPolicies</a> operation to obtain the policy ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The protocol control configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ProtocolConfig")]
        [Validation(Required=false)]
        public SetPolicyProtocolConfigRequestProtocolConfig ProtocolConfig { get; set; }
        public class SetPolicyProtocolConfigRequestProtocolConfig : TeaModel {
            /// <summary>
            /// <para>The RDP options.</para>
            /// </summary>
            [NameInMap("RDP")]
            [Validation(Required=false)]
            public SetPolicyProtocolConfigRequestProtocolConfigRDP RDP { get; set; }
            public class SetPolicyProtocolConfigRequestProtocolConfigRDP : TeaModel {
                /// <summary>
                /// <para>Specifies whether to allow clipboard content to be downloaded. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Enable</para>
                /// </description></item>
                /// <item><description><para>Disable</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>The default value is Disable.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("ClipboardDownload")]
                [Validation(Required=false)]
                public string ClipboardDownload { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow clipboard content to be uploaded. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Enable</para>
                /// </description></item>
                /// <item><description><para>Disable</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>The default value is Disable.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("ClipboardUpload")]
                [Validation(Required=false)]
                public string ClipboardUpload { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable drive and printer mapping. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Enable</para>
                /// </description></item>
                /// <item><description><para>Disable</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>The default value is Disable.</para>
                /// </remarks>
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
                /// <para>Specifies whether to record keyboard input. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Enable</para>
                /// </description></item>
                /// <item><description><para>Disable</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>The default value is Disable.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("RecordKeyboard")]
                [Validation(Required=false)]
                public string RecordKeyboard { get; set; }

            }

            /// <summary>
            /// <para>The SSH and SFTP options.</para>
            /// </summary>
            [NameInMap("SSH")]
            [Validation(Required=false)]
            public SetPolicyProtocolConfigRequestProtocolConfigSSH SSH { get; set; }
            public class SetPolicyProtocolConfigRequestProtocolConfigSSH : TeaModel {
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
                /// <para>Specifies whether to allow remote command execution. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Enable</para>
                /// </description></item>
                /// <item><description><para>Disable</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>The default value is Disable.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("ExecCommand")]
                [Validation(Required=false)]
                public string ExecCommand { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the SFTP channel. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Enable</para>
                /// </description></item>
                /// <item><description><para>Disable</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>The default value is Disable.</para>
                /// </description></item>
                /// <item><description><para>At least one of the SSH channel and the SFTP channel must be enabled.</para>
                /// </description></item>
                /// <item><description><para>If you grant only SFTP permissions to a host account, do not disable the SSH and SFTP channels for that account in the control policy. Otherwise, you cannot use the host account to access the target server through Bastionhost.</para>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("SFTPChannel")]
                [Validation(Required=false)]
                public string SFTPChannel { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow file downloads over SFTP. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Enable</para>
                /// </description></item>
                /// <item><description><para>Disable</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>The default value is Disable.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("SFTPDownloadFile")]
                [Validation(Required=false)]
                public string SFTPDownloadFile { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow folder creation over SFTP. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Enable</para>
                /// </description></item>
                /// <item><description><para>Disable</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>The default value is Disable.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("SFTPMkdir")]
                [Validation(Required=false)]
                public string SFTPMkdir { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow file deletions over SFTP. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Enable</para>
                /// </description></item>
                /// <item><description><para>Disable</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>The default value is Disable.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("SFTPRemoveFile")]
                [Validation(Required=false)]
                public string SFTPRemoveFile { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow file renames over SFTP. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Enable</para>
                /// </description></item>
                /// <item><description><para>Disable</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>The default value is Disable.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("SFTPRenameFile")]
                [Validation(Required=false)]
                public string SFTPRenameFile { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow folder deletion over SFTP. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Enable</para>
                /// </description></item>
                /// <item><description><para>Disable</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>The default value is Disable.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("SFTPRmdir")]
                [Validation(Required=false)]
                public string SFTPRmdir { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow file uploads over SFTP. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Enable</para>
                /// </description></item>
                /// <item><description><para>Disable</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>The default value is Disable.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("SFTPUploadFile")]
                [Validation(Required=false)]
                public string SFTPUploadFile { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the SSH channel. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Enable</para>
                /// </description></item>
                /// <item><description><para>Disable</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>The default value is Disable.</para>
                /// </description></item>
                /// <item><description><para>At least one of the SSH channel and the SFTP channel must be enabled. If you disable the SSH channel, you cannot use SSH permissions to log on to the asset account. Configure this parameter with caution.</para>
                /// </description></item>
                /// <item><description><para>If you grant only SFTP permissions to a host account, do not disable the SSH and SFTP channels for that account in the control policy. Otherwise, you cannot use the host account to access the target server through Bastionhost.</para>
                /// </description></item>
                /// </list>
                /// </remarks>
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
                /// <para>Specifies whether to enable X11 forwarding. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Enable</para>
                /// </description></item>
                /// <item><description><para>Disable</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>The default value is Disable.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("X11Forwarding")]
                [Validation(Required=false)]
                public string X11Forwarding { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the region where the Bastionhost instance resides.</para>
        /// <remarks>
        /// <para>For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
