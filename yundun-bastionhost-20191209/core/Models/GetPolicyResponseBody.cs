// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetPolicyResponseBody : TeaModel {
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public GetPolicyResponseBodyPolicy Policy { get; set; }
        public class GetPolicyResponseBodyPolicy : TeaModel {
            [NameInMap("AccessTimeRangeConfig")]
            [Validation(Required=false)]
            public GetPolicyResponseBodyPolicyAccessTimeRangeConfig AccessTimeRangeConfig { get; set; }
            public class GetPolicyResponseBodyPolicyAccessTimeRangeConfig : TeaModel {
                [NameInMap("EffectiveTime")]
                [Validation(Required=false)]
                public List<GetPolicyResponseBodyPolicyAccessTimeRangeConfigEffectiveTime> EffectiveTime { get; set; }
                public class GetPolicyResponseBodyPolicyAccessTimeRangeConfigEffectiveTime : TeaModel {
                    [NameInMap("Days")]
                    [Validation(Required=false)]
                    public List<string> Days { get; set; }

                    [NameInMap("Hours")]
                    [Validation(Required=false)]
                    public List<string> Hours { get; set; }

                }

            }

            [NameInMap("ApprovalConfig")]
            [Validation(Required=false)]
            public GetPolicyResponseBodyPolicyApprovalConfig ApprovalConfig { get; set; }
            public class GetPolicyResponseBodyPolicyApprovalConfig : TeaModel {
                [NameInMap("SwitchStatus")]
                [Validation(Required=false)]
                public string SwitchStatus { get; set; }

            }

            [NameInMap("CommandConfig")]
            [Validation(Required=false)]
            public GetPolicyResponseBodyPolicyCommandConfig CommandConfig { get; set; }
            public class GetPolicyResponseBodyPolicyCommandConfig : TeaModel {
                [NameInMap("Approval")]
                [Validation(Required=false)]
                public GetPolicyResponseBodyPolicyCommandConfigApproval Approval { get; set; }
                public class GetPolicyResponseBodyPolicyCommandConfigApproval : TeaModel {
                    [NameInMap("Commands")]
                    [Validation(Required=false)]
                    public List<string> Commands { get; set; }

                }

                [NameInMap("Deny")]
                [Validation(Required=false)]
                public GetPolicyResponseBodyPolicyCommandConfigDeny Deny { get; set; }
                public class GetPolicyResponseBodyPolicyCommandConfigDeny : TeaModel {
                    [NameInMap("AclType")]
                    [Validation(Required=false)]
                    public string AclType { get; set; }

                    [NameInMap("Commands")]
                    [Validation(Required=false)]
                    public List<string> Commands { get; set; }

                }

            }

            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("IPAclConfig")]
            [Validation(Required=false)]
            public GetPolicyResponseBodyPolicyIPAclConfig IPAclConfig { get; set; }
            public class GetPolicyResponseBodyPolicyIPAclConfig : TeaModel {
                [NameInMap("AclType")]
                [Validation(Required=false)]
                public string AclType { get; set; }

                [NameInMap("IPs")]
                [Validation(Required=false)]
                public List<string> IPs { get; set; }

            }

            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            [NameInMap("ProtocolConfig")]
            [Validation(Required=false)]
            public GetPolicyResponseBodyPolicyProtocolConfig ProtocolConfig { get; set; }
            public class GetPolicyResponseBodyPolicyProtocolConfig : TeaModel {
                [NameInMap("RDP")]
                [Validation(Required=false)]
                public GetPolicyResponseBodyPolicyProtocolConfigRDP RDP { get; set; }
                public class GetPolicyResponseBodyPolicyProtocolConfigRDP : TeaModel {
                    [NameInMap("ClipboardDownload")]
                    [Validation(Required=false)]
                    public string ClipboardDownload { get; set; }

                    [NameInMap("ClipboardUpload")]
                    [Validation(Required=false)]
                    public string ClipboardUpload { get; set; }

                    [NameInMap("DiskRedirection")]
                    [Validation(Required=false)]
                    public string DiskRedirection { get; set; }

                    [NameInMap("RecordKeyboard")]
                    [Validation(Required=false)]
                    public string RecordKeyboard { get; set; }

                }

                [NameInMap("SSH")]
                [Validation(Required=false)]
                public GetPolicyResponseBodyPolicyProtocolConfigSSH SSH { get; set; }
                public class GetPolicyResponseBodyPolicyProtocolConfigSSH : TeaModel {
                    [NameInMap("ExecCommand")]
                    [Validation(Required=false)]
                    public string ExecCommand { get; set; }

                    [NameInMap("SFTPChannel")]
                    [Validation(Required=false)]
                    public string SFTPChannel { get; set; }

                    [NameInMap("SFTPDownloadFile")]
                    [Validation(Required=false)]
                    public string SFTPDownloadFile { get; set; }

                    [NameInMap("SFTPMkdir")]
                    [Validation(Required=false)]
                    public string SFTPMkdir { get; set; }

                    [NameInMap("SFTPRemoveFile")]
                    [Validation(Required=false)]
                    public string SFTPRemoveFile { get; set; }

                    [NameInMap("SFTPRenameFile")]
                    [Validation(Required=false)]
                    public string SFTPRenameFile { get; set; }

                    [NameInMap("SFTPRmdir")]
                    [Validation(Required=false)]
                    public string SFTPRmdir { get; set; }

                    [NameInMap("SFTPUploadFile")]
                    [Validation(Required=false)]
                    public string SFTPUploadFile { get; set; }

                    [NameInMap("SSHChannel")]
                    [Validation(Required=false)]
                    public string SSHChannel { get; set; }

                    [NameInMap("X11Forwarding")]
                    [Validation(Required=false)]
                    public string X11Forwarding { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
