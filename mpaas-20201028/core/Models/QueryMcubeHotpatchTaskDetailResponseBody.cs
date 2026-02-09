// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class QueryMcubeHotpatchTaskDetailResponseBody : TeaModel {
        [NameInMap("QueryHotpatchTaskDetailResult")]
        [Validation(Required=false)]
        public QueryMcubeHotpatchTaskDetailResponseBodyQueryHotpatchTaskDetailResult QueryHotpatchTaskDetailResult { get; set; }
        public class QueryMcubeHotpatchTaskDetailResponseBodyQueryHotpatchTaskDetailResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("HotpatchTaskDetail")]
            [Validation(Required=false)]
            public QueryMcubeHotpatchTaskDetailResponseBodyQueryHotpatchTaskDetailResultHotpatchTaskDetail HotpatchTaskDetail { get; set; }
            public class QueryMcubeHotpatchTaskDetailResponseBodyQueryHotpatchTaskDetailResultHotpatchTaskDetail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ONEXPRE22BA951112038-default</para>
                /// </summary>
                [NameInMap("AppCode")]
                [Validation(Required=false)]
                public string AppCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ALIPUB9A63274111812</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BaseInfoId")]
                [Validation(Required=false)]
                public long? BaseInfoId { get; set; }

                [NameInMap("Bundles")]
                [Validation(Required=false)]
                public List<string> Bundles { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://xxxxx">https://xxxxx</a></para>
                /// </summary>
                [NameInMap("DownloadUrl")]
                [Validation(Required=false)]
                public string DownloadUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>117</para>
                /// </summary>
                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public string FileSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1766111313000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-01-09 10:14:46</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-01-09 10:14:46</para>
                /// </summary>
                [NameInMap("GmtModifiedStr")]
                [Validation(Required=false)]
                public string GmtModifiedStr { get; set; }

                [NameInMap("GreyConfigInfo")]
                [Validation(Required=false)]
                public string GreyConfigInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-01-01 12:00:00</para>
                /// </summary>
                [NameInMap("GreyEndtimeData")]
                [Validation(Required=false)]
                public string GreyEndtimeData { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("GreyNum")]
                [Validation(Required=false)]
                public long? GreyNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>14332</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>15cf3772223630be907c7aaefe8d51c6</para>
                /// </summary>
                [NameInMap("Md5")]
                [Validation(Required=false)]
                public string Md5 { get; set; }

                [NameInMap("Memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1664552</para>
                /// </summary>
                [NameInMap("PackageId")]
                [Validation(Required=false)]
                public long? PackageId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>iOS</para>
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ONEXPRE22BA951112038_ANDROID-default</para>
                /// </summary>
                [NameInMap("ProductId")]
                [Validation(Required=false)]
                public string ProductId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("ProductVersion")]
                [Validation(Required=false)]
                public string ProductVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PublishMode")]
                [Validation(Required=false)]
                public long? PublishMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("PublishPeriod")]
                [Validation(Required=false)]
                public long? PublishPeriod { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("PublishType")]
                [Validation(Required=false)]
                public long? PublishType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("QuickRollback")]
                [Validation(Required=false)]
                public long? QuickRollback { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>81c90a2cafdc6dfc54201e70845b5708</para>
                /// </summary>
                [NameInMap("ReleaseVersion")]
                [Validation(Required=false)]
                public string ReleaseVersion { get; set; }

                [NameInMap("RuleJsonList")]
                [Validation(Required=false)]
                public List<QueryMcubeHotpatchTaskDetailResponseBodyQueryHotpatchTaskDetailResultHotpatchTaskDetailRuleJsonList> RuleJsonList { get; set; }
                public class QueryMcubeHotpatchTaskDetailResponseBodyQueryHotpatchTaskDetailResultHotpatchTaskDetailRuleJsonList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>and</para>
                    /// </summary>
                    [NameInMap("Operation")]
                    [Validation(Required=false)]
                    public string Operation { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>city</para>
                    /// </summary>
                    [NameInMap("RuleElement")]
                    [Validation(Required=false)]
                    public string RuleElement { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("RuleType")]
                    [Validation(Required=false)]
                    public string RuleType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>smtp.qiye.aliyun.com</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mpaas.jar</para>
                /// </summary>
                [NameInMap("SourceName")]
                [Validation(Required=false)]
                public string SourceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public long? TaskStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1770442895017</para>
                /// </summary>
                [NameInMap("TaskVersion")]
                [Validation(Required=false)]
                public long? TaskVersion { get; set; }

                [NameInMap("Whitelist")]
                [Validation(Required=false)]
                public List<QueryMcubeHotpatchTaskDetailResponseBodyQueryHotpatchTaskDetailResultHotpatchTaskDetailWhitelist> Whitelist { get; set; }
                public class QueryMcubeHotpatchTaskDetailResponseBodyQueryHotpatchTaskDetailResultHotpatchTaskDetailWhitelist : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ONEXPRE40DB571151920-default</para>
                    /// </summary>
                    [NameInMap("AppCode")]
                    [Validation(Required=false)]
                    public string AppCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>business</para>
                    /// </summary>
                    [NameInMap("Business")]
                    [Validation(Required=false)]
                    public string Business { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1760754049000</para>
                    /// </summary>
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>9952804</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>userId</para>
                    /// </summary>
                    [NameInMap("IdType")]
                    [Validation(Required=false)]
                    public string IdType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>iOS</para>
                    /// </summary>
                    [NameInMap("Platform")]
                    [Validation(Required=false)]
                    public string Platform { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public long? Status { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("WhiteListCount")]
                    [Validation(Required=false)]
                    public long? WhiteListCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>whitelistName</para>
                    /// </summary>
                    [NameInMap("WhiteListName")]
                    [Validation(Required=false)]
                    public string WhiteListName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>825827</para>
                /// </summary>
                [NameInMap("WhitelistIds")]
                [Validation(Required=false)]
                public string WhitelistIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

            }

            /// <summary>
            /// <para>Id of the request</para>
            /// 
            /// <b>Example:</b>
            /// <para>61B9F63C-4E6F-5D8E-A694-899450987B48</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("ResultMsg")]
            [Validation(Required=false)]
            public string ResultMsg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11E66B29-9E5E-5C10-B64E-B5A0E0F26355</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
