// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class SetPolicyProtocolConfigRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        [NameInMap("ProtocolConfig")]
        [Validation(Required=false)]
        public SetPolicyProtocolConfigRequestProtocolConfig ProtocolConfig { get; set; }
        public class SetPolicyProtocolConfigRequestProtocolConfig : TeaModel {
            [NameInMap("RDP")]
            [Validation(Required=false)]
            public SetPolicyProtocolConfigRequestProtocolConfigRDP RDP { get; set; }
            public class SetPolicyProtocolConfigRequestProtocolConfigRDP : TeaModel {
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
            public SetPolicyProtocolConfigRequestProtocolConfigSSH SSH { get; set; }
            public class SetPolicyProtocolConfigRequestProtocolConfigSSH : TeaModel {
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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
