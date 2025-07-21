// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class ReportUserFbIssueRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("ClientAppVersion")]
        [Validation(Required=false)]
        public string ClientAppVersion { get; set; }

        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("ClientModel")]
        [Validation(Required=false)]
        public string ClientModel { get; set; }

        [NameInMap("ClientOsName")]
        [Validation(Required=false)]
        public string ClientOsName { get; set; }

        [NameInMap("ClientSn")]
        [Validation(Required=false)]
        public string ClientSn { get; set; }

        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        [NameInMap("CustomerId")]
        [Validation(Required=false)]
        public string CustomerId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        [NameInMap("DesktopType")]
        [Validation(Required=false)]
        public int? DesktopType { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("FbType")]
        [Validation(Required=false)]
        public int? FbType { get; set; }

        [NameInMap("FileList")]
        [Validation(Required=false)]
        public List<ReportUserFbIssueRequestFileList> FileList { get; set; }
        public class ReportUserFbIssueRequestFileList : TeaModel {
            [NameInMap("FileMd5")]
            [Validation(Required=false)]
            public string FileMd5 { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public int? FileSize { get; set; }

            [NameInMap("FileType")]
            [Validation(Required=false)]
            public int? FileType { get; set; }

            [NameInMap("OssUrl")]
            [Validation(Required=false)]
            public string OssUrl { get; set; }

            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        [NameInMap("IsSubstituteReport")]
        [Validation(Required=false)]
        public bool? IsSubstituteReport { get; set; }

        [NameInMap("IssueLabel")]
        [Validation(Required=false)]
        public string IssueLabel { get; set; }

        [NameInMap("LoginRegionId")]
        [Validation(Required=false)]
        public string LoginRegionId { get; set; }

        [NameInMap("LoginToken")]
        [Validation(Required=false)]
        public string LoginToken { get; set; }

        [NameInMap("OccurTime")]
        [Validation(Required=false)]
        public long? OccurTime { get; set; }

        [NameInMap("ReservedA")]
        [Validation(Required=false)]
        public string ReservedA { get; set; }

        [NameInMap("ReservedB")]
        [Validation(Required=false)]
        public string ReservedB { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("TelNo")]
        [Validation(Required=false)]
        public string TelNo { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("UserEmail")]
        [Validation(Required=false)]
        public string UserEmail { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        [NameInMap("WyId")]
        [Validation(Required=false)]
        public string WyId { get; set; }

    }

}
