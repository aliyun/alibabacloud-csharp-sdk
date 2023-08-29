// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class GetMcubeUpgradePackageInfoResponseBody : TeaModel {
        [NameInMap("GetPackageResult")]
        [Validation(Required=false)]
        public GetMcubeUpgradePackageInfoResponseBodyGetPackageResult GetPackageResult { get; set; }
        public class GetMcubeUpgradePackageInfoResponseBodyGetPackageResult : TeaModel {
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("PackageInfo")]
            [Validation(Required=false)]
            public GetMcubeUpgradePackageInfoResponseBodyGetPackageResultPackageInfo PackageInfo { get; set; }
            public class GetMcubeUpgradePackageInfoResponseBodyGetPackageResultPackageInfo : TeaModel {
                [NameInMap("MobileTestFlightConfigDO")]
                [Validation(Required=false)]
                public GetMcubeUpgradePackageInfoResponseBodyGetPackageResultPackageInfoMobileTestFlightConfigDO MobileTestFlightConfigDO { get; set; }
                public class GetMcubeUpgradePackageInfoResponseBodyGetPackageResultPackageInfoMobileTestFlightConfigDO : TeaModel {
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("InstallAmount")]
                    [Validation(Required=false)]
                    public int? InstallAmount { get; set; }

                    [NameInMap("InvalidTime")]
                    [Validation(Required=false)]
                    public string InvalidTime { get; set; }

                    [NameInMap("UpgradeId")]
                    [Validation(Required=false)]
                    public long? UpgradeId { get; set; }

                }

                [NameInMap("UpgradeBaseInfoDO")]
                [Validation(Required=false)]
                public GetMcubeUpgradePackageInfoResponseBodyGetPackageResultPackageInfoUpgradeBaseInfoDO UpgradeBaseInfoDO { get; set; }
                public class GetMcubeUpgradePackageInfoResponseBodyGetPackageResultPackageInfoUpgradeBaseInfoDO : TeaModel {
                    [NameInMap("AllowCreateTask")]
                    [Validation(Required=false)]
                    public bool? AllowCreateTask { get; set; }

                    [NameInMap("AppCode")]
                    [Validation(Required=false)]
                    public string AppCode { get; set; }

                    [NameInMap("AppstoreUrl")]
                    [Validation(Required=false)]
                    public string AppstoreUrl { get; set; }

                    [NameInMap("BackLog")]
                    [Validation(Required=false)]
                    public string BackLog { get; set; }

                    [NameInMap("ChangeLog")]
                    [Validation(Required=false)]
                    public string ChangeLog { get; set; }

                    [NameInMap("ClientFileSize")]
                    [Validation(Required=false)]
                    public int? ClientFileSize { get; set; }

                    [NameInMap("ClientName")]
                    [Validation(Required=false)]
                    public string ClientName { get; set; }

                    [NameInMap("CpId")]
                    [Validation(Required=false)]
                    public string CpId { get; set; }

                    [NameInMap("Creator")]
                    [Validation(Required=false)]
                    public string Creator { get; set; }

                    [NameInMap("DownloadUrl")]
                    [Validation(Required=false)]
                    public string DownloadUrl { get; set; }

                    [NameInMap("GlobalVariables")]
                    [Validation(Required=false)]
                    public string GlobalVariables { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtCreateStr")]
                    [Validation(Required=false)]
                    public string GmtCreateStr { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("GmtModifiedStr")]
                    [Validation(Required=false)]
                    public string GmtModifiedStr { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("InnerVersion")]
                    [Validation(Required=false)]
                    public string InnerVersion { get; set; }

                    [NameInMap("IosSymbol")]
                    [Validation(Required=false)]
                    public string IosSymbol { get; set; }

                    [NameInMap("IsEnterprise")]
                    [Validation(Required=false)]
                    public int? IsEnterprise { get; set; }

                    [NameInMap("IsRc")]
                    [Validation(Required=false)]
                    public int? IsRc { get; set; }

                    [NameInMap("IsRelease")]
                    [Validation(Required=false)]
                    public int? IsRelease { get; set; }

                    [NameInMap("MaxVersion")]
                    [Validation(Required=false)]
                    public string MaxVersion { get; set; }

                    [NameInMap("Md5")]
                    [Validation(Required=false)]
                    public string Md5 { get; set; }

                    [NameInMap("Modifier")]
                    [Validation(Required=false)]
                    public string Modifier { get; set; }

                    [NameInMap("NeedCheck")]
                    [Validation(Required=false)]
                    public int? NeedCheck { get; set; }

                    [NameInMap("OssPath")]
                    [Validation(Required=false)]
                    public string OssPath { get; set; }

                    [NameInMap("PackageType")]
                    [Validation(Required=false)]
                    public string PackageType { get; set; }

                    [NameInMap("Platform")]
                    [Validation(Required=false)]
                    public string Platform { get; set; }

                    [NameInMap("ProductId")]
                    [Validation(Required=false)]
                    public string ProductId { get; set; }

                    [NameInMap("ProductName")]
                    [Validation(Required=false)]
                    public string ProductName { get; set; }

                    [NameInMap("ProductVersion")]
                    [Validation(Required=false)]
                    public string ProductVersion { get; set; }

                    [NameInMap("PublishPeriod")]
                    [Validation(Required=false)]
                    public int? PublishPeriod { get; set; }

                    [NameInMap("QrcodeUrl")]
                    [Validation(Required=false)]
                    public string QrcodeUrl { get; set; }

                    [NameInMap("ReleaseType")]
                    [Validation(Required=false)]
                    public string ReleaseType { get; set; }

                    [NameInMap("ReleaseWindow")]
                    [Validation(Required=false)]
                    public string ReleaseWindow { get; set; }

                    [NameInMap("ScmDownloadUrl")]
                    [Validation(Required=false)]
                    public string ScmDownloadUrl { get; set; }

                    [NameInMap("ServerVersion")]
                    [Validation(Required=false)]
                    public int? ServerVersion { get; set; }

                    [NameInMap("VerificationCode")]
                    [Validation(Required=false)]
                    public string VerificationCode { get; set; }

                    [NameInMap("VerifyResult")]
                    [Validation(Required=false)]
                    public int? VerifyResult { get; set; }

                    [NameInMap("VersionCode")]
                    [Validation(Required=false)]
                    public string VersionCode { get; set; }

                }

            }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("ResultMsg")]
            [Validation(Required=false)]
            public string ResultMsg { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
