// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class SetPolicyProtocolConfigRequest : TeaModel {
        /// <summary>
        /// <para>The bastion host ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the bastion host ID.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2758876.html">ListPolicies</a> operation to query the control policy ID.</para>
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
        /// <para>The protocol control settings.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ProtocolConfig")]
        [Validation(Required=false)]
        public SetPolicyProtocolConfigRequestProtocolConfig ProtocolConfig { get; set; }
        public class SetPolicyProtocolConfigRequestProtocolConfig : TeaModel {
            /// <summary>
            /// <para>The settings of the Remote Desktop Protocol (RDP) options.</para>
            /// </summary>
            [NameInMap("RDP")]
            [Validation(Required=false)]
            public SetPolicyProtocolConfigRequestProtocolConfigRDP RDP { get; set; }
            public class SetPolicyProtocolConfigRequestProtocolConfigRDP : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable downloading from the clipboard. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable</description></item>
                /// <item><description>Disable</description></item>
                /// </list>
                /// <remarks>
                /// <para>If you do not specify this parameter, the default value Disable is used.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("ClipboardDownload")]
                [Validation(Required=false)]
                public string ClipboardDownload { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable uploading from the clipboard. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable</description></item>
                /// <item><description>Disable</description></item>
                /// </list>
                /// <remarks>
                /// <para>If you do not specify this parameter, the default value Disable is used.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("ClipboardUpload")]
                [Validation(Required=false)]
                public string ClipboardUpload { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable driver mapping. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable</description></item>
                /// <item><description>Disable</description></item>
                /// </list>
                /// <remarks>
                /// <para>If you do not specify this parameter, the default value Disable is used.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("DiskRedirection")]
                [Validation(Required=false)]
                public string DiskRedirection { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable keyboard operation recording. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable</description></item>
                /// <item><description>Disable</description></item>
                /// </list>
                /// <remarks>
                /// <para>If you do not specify this parameter, the default value Disable is used.</para>
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
            /// <para>The settings of the SSH and SSH Fine Transfer Protocol (SFTP) options.</para>
            /// </summary>
            [NameInMap("SSH")]
            [Validation(Required=false)]
            public SetPolicyProtocolConfigRequestProtocolConfigSSH SSH { get; set; }
            public class SetPolicyProtocolConfigRequestProtocolConfigSSH : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable remote command execution. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable</description></item>
                /// <item><description>Disable</description></item>
                /// </list>
                /// <remarks>
                /// <para>If you do not specify this parameter, the default value Disable is used.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("ExecCommand")]
                [Validation(Required=false)]
                public string ExecCommand { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable SFTP channels. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable</description></item>
                /// <item><description>Disable</description></item>
                /// </list>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>If you do not specify this parameter, the default value Disable is used.</para>
                /// </description></item>
                /// <item><description><para>You must set at least one of the following parameters to Enable: SSHChannel and SFTPChannel.</para>
                /// </description></item>
                /// <item><description><para>If you select Enable Only SFTP Permission for a host account, do not set SSHChannel and SFTPChannel to Disable for the account. Otherwise, users of the bastion host cannot use the account to access the host.</para>
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
                /// <para>Specifies whether to enable file downloading during SFTP-based O\&amp;M. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable</description></item>
                /// <item><description>Disable</description></item>
                /// </list>
                /// <remarks>
                /// <para>If you do not specify this parameter, the default value Disable is used.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("SFTPDownloadFile")]
                [Validation(Required=false)]
                public string SFTPDownloadFile { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable folder creation during SFTP-based O\&amp;M. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable</description></item>
                /// <item><description>Disable</description></item>
                /// </list>
                /// <remarks>
                /// <para>If you do not specify this parameter, the default value Disable is used.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("SFTPMkdir")]
                [Validation(Required=false)]
                public string SFTPMkdir { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable file deletion during SFTP-based O\&amp;M. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable</description></item>
                /// <item><description>Disable</description></item>
                /// </list>
                /// <remarks>
                /// <para>If you do not specify this parameter, the default value Disable is used.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("SFTPRemoveFile")]
                [Validation(Required=false)]
                public string SFTPRemoveFile { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable file renaming during SFTP-based O\&amp;M. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable</description></item>
                /// <item><description>Disable</description></item>
                /// </list>
                /// <remarks>
                /// <para>If you do not specify this parameter, the default value Disable is used.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("SFTPRenameFile")]
                [Validation(Required=false)]
                public string SFTPRenameFile { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable folder deletion during SFTP-based O\&amp;M. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable</description></item>
                /// <item><description>Disable</description></item>
                /// </list>
                /// <remarks>
                /// <para>If you do not specify this parameter, the default value Disable is used.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("SFTPRmdir")]
                [Validation(Required=false)]
                public string SFTPRmdir { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable file uploading during SFTP-based O\&amp;M. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable</description></item>
                /// <item><description>Disable</description></item>
                /// </list>
                /// <remarks>
                /// <para>If you do not specify this parameter, the default value Disable is used.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("SFTPUploadFile")]
                [Validation(Required=false)]
                public string SFTPUploadFile { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable SSH channels. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable</description></item>
                /// <item><description>Disable</description></item>
                /// </list>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>If you do not specify this parameter, the default value Disable is used.</para>
                /// </description></item>
                /// <item><description><para>You must set at least one of the following parameters to Enable: SSHChannel and SFTPChannel. If you set SSHChannel to Disable, SSH-based logon is disabled for the asset account. Proceed with caution.</para>
                /// </description></item>
                /// <item><description><para>If you select Enable Only SFTP Permission for a host account, do not set SSHChannel and SFTPChannel to Disable for the account. Otherwise, users of the bastion host cannot use the account to access the host.</para>
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
                /// <para>Specifies whether to enable X11 forwarding. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable</description></item>
                /// <item><description>Disable</description></item>
                /// </list>
                /// <remarks>
                /// <para>If you do not specify this parameter, the default value Disable is used.</para>
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
        /// <para>The region ID of the bastion host.</para>
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
