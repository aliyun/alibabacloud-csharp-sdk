// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class SetPolicyProtocolConfigRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the bastion host.</para>
        /// <remarks>
        /// <para>You can invoke <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> to obtain this parameter.</para>
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
        /// <para>The ID of the control policy to modify.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/2758876.html">ListPolicies</a> to obtain this parameter.</para>
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
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The protocol control configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ProtocolConfig")]
        [Validation(Required=false)]
        public SetPolicyProtocolConfigRequestProtocolConfig ProtocolConfig { get; set; }
        public class SetPolicyProtocolConfigRequestProtocolConfig : TeaModel {
            /// <summary>
            /// <para>The RDP option configuration details.</para>
            /// </summary>
            [NameInMap("RDP")]
            [Validation(Required=false)]
            public SetPolicyProtocolConfigRequestProtocolConfigRDP RDP { get; set; }
            public class SetPolicyProtocolConfigRequestProtocolConfigRDP : TeaModel {
                /// <summary>
                /// <para>The clipboard download configuration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable: Enabled.</description></item>
                /// <item><description>Disable: Disabled.</description></item>
                /// </list>
                /// <remarks>
                /// <para>If this parameter is not specified, the default value is Disable.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("ClipboardDownload")]
                [Validation(Required=false)]
                public string ClipboardDownload { get; set; }

                /// <summary>
                /// <para>The clipboard upload configuration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable: Enabled.</description></item>
                /// <item><description>Disable: Disabled.<remarks>
                /// <para>If this parameter is not specified, the default value is Disable.</para>
                /// </remarks>
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
                /// <para>The drive/printer mapping configuration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable: Enabled.</description></item>
                /// <item><description>Disable: Disabled.<remarks>
                /// <para>If this parameter is not specified, the default value is Disable.</para>
                /// </remarks>
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
                /// <para>Specifies whether to allow disk download.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("DiskRedirectionDownload")]
                [Validation(Required=false)]
                public string DiskRedirectionDownload { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow disk upload.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("DiskRedirectionUpload")]
                [Validation(Required=false)]
                public string DiskRedirectionUpload { get; set; }

                /// <summary>
                /// <para>The keyboard recording configuration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable: Enabled.</description></item>
                /// <item><description>Disable: Disabled.<remarks>
                /// <para>If this parameter is not specified, the default value is Disable.</para>
                /// </remarks>
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
            /// <para>The SSH and SFTP option configuration details.</para>
            /// </summary>
            [NameInMap("SSH")]
            [Validation(Required=false)]
            public SetPolicyProtocolConfigRequestProtocolConfigSSH SSH { get; set; }
            public class SetPolicyProtocolConfigRequestProtocolConfigSSH : TeaModel {
                /// <summary>
                /// <para>Specifies whether to allow direct TCP connection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("AllowDirectTcp")]
                [Validation(Required=false)]
                public string AllowDirectTcp { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow TCP forwarding.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("AllowTcpForwarding")]
                [Validation(Required=false)]
                public string AllowTcpForwarding { get; set; }

                /// <summary>
                /// <para>The remote command execution configuration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable: Enabled.</description></item>
                /// <item><description>Disable: Disabled.<remarks>
                /// <para>If this parameter is not specified, the default value is Disable.</para>
                /// </remarks>
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
                /// <para>The SFTP channel configuration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable: Enabled.</description></item>
                /// <item><description>Disable: Disabled.</description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>If this parameter is not specified, the default value is Disable.</description></item>
                /// <item><description>At least one of the SSH channel and SFTP channel must be set to Enable.</description></item>
                /// <item><description>If you enable the SFTP-only permission for a host account, do not disable both the SSH channel and SFTP channel for that account in the control policy. Otherwise, you cannot use the host account to access the target server through the bastion host.</description></item>
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
                /// <para>The SFTP file download configuration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable: Enabled.</description></item>
                /// <item><description>Disable: Disabled.<remarks>
                /// <para>If this parameter is not specified, the default value is Disable.</para>
                /// </remarks>
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
                /// <para>The SFTP folder creation configuration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable: Enabled.</description></item>
                /// <item><description>Disable: Disabled.<remarks>
                /// <para>If this parameter is not specified, the default value is Disable.</para>
                /// </remarks>
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
                /// <para>The SFTP file deletion configuration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable: Enabled.</description></item>
                /// <item><description>Disable: Disabled.<remarks>
                /// <para>If this parameter is not specified, the default value is Disable.</para>
                /// </remarks>
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
                /// <para>The SFTP file rename configuration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable: Enabled.</description></item>
                /// <item><description>Disable: Disabled.<remarks>
                /// <para>If this parameter is not specified, the default value is Disable.</para>
                /// </remarks>
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
                /// <para>The SFTP folder deletion configuration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable: Enabled.</description></item>
                /// <item><description>Disable: Disabled.<remarks>
                /// <para>If this parameter is not specified, the default value is Disable.</para>
                /// </remarks>
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
                /// <para>The SFTP file upload configuration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable: Enabled.</description></item>
                /// <item><description>Disable: Disabled.<remarks>
                /// <para>If this parameter is not specified, the default value is Disable.</para>
                /// </remarks>
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
                /// <para>The SSH channel configuration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable: Enabled.</description></item>
                /// <item><description>Disable: Disabled.</description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>If this parameter is not specified, the default value is Disable.</description></item>
                /// <item><description>At least one of the SSH channel and SFTP channel must be set to Enable. If the SSH channel is set to Disable, you cannot log on to asset accounts by using SSH permissions. Proceed with caution.</description></item>
                /// <item><description>If you enable the SFTP-only permission for a host account, do not disable both the SSH channel and SFTP channel for that account in the control policy. Otherwise, you cannot use the host account to access the target server through the bastion host.</description></item>
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
                /// <para>Specifies whether to allow TCP forwarding.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("TcpForwarding")]
                [Validation(Required=false)]
                public string TcpForwarding { get; set; }

                /// <summary>
                /// <para>The X11 forwarding configuration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable: Enabled.</description></item>
                /// <item><description>Disable: Disabled.<remarks>
                /// <para>If this parameter is not specified, the default value is Disable.</para>
                /// </remarks>
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

        /// <summary>
        /// <para>The region ID of the bastion host.</para>
        /// <remarks>
        /// <para>For the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
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
