// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class ListMcubeHotpatchTasksResponseBody : TeaModel {
        [NameInMap("ListHotpatchTasksResult")]
        [Validation(Required=false)]
        public ListMcubeHotpatchTasksResponseBodyListHotpatchTasksResult ListHotpatchTasksResult { get; set; }
        public class ListMcubeHotpatchTasksResponseBodyListHotpatchTasksResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("HotpatchTaskInfo")]
            [Validation(Required=false)]
            public List<ListMcubeHotpatchTasksResponseBodyListHotpatchTasksResultHotpatchTaskInfo> HotpatchTaskInfo { get; set; }
            public class ListMcubeHotpatchTasksResponseBodyListHotpatchTasksResultHotpatchTaskInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ALIPUB40DB571101207-default</para>
                /// </summary>
                [NameInMap("AppCode")]
                [Validation(Required=false)]
                public string AppCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1751594649000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-10-29 18:01:32</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-10-29 18:01:32</para>
                /// </summary>
                [NameInMap("GmtModifiedStr")]
                [Validation(Required=false)]
                public string GmtModifiedStr { get; set; }

                [NameInMap("GreyConfigInfo")]
                [Validation(Required=false)]
                public string GreyConfigInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-03-18 20:12:26</para>
                /// </summary>
                [NameInMap("GreyEndtime")]
                [Validation(Required=false)]
                public string GreyEndtime { get; set; }

                [NameInMap("GreyEndtimeData")]
                [Validation(Required=false)]
                public string GreyEndtimeData { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("GreyNum")]
                [Validation(Required=false)]
                public long? GreyNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1486</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxx</para>
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
                /// <para>ALIPUB40DB571101207_ANDROID-default</para>
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
                /// <para>3</para>
                /// </summary>
                [NameInMap("PublishType")]
                [Validation(Required=false)]
                public long? PublishType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>81c90a2cafdc6dfc54201e70845b5708</para>
                /// </summary>
                [NameInMap("ReleaseVersion")]
                [Validation(Required=false)]
                public string ReleaseVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1786</para>
                /// </summary>
                [NameInMap("ResIds")]
                [Validation(Required=false)]
                public string ResIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public long? TaskStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>825827</para>
                /// </summary>
                [NameInMap("WhitelistIds")]
                [Validation(Required=false)]
                public string WhitelistIds { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6BD4C876-47B4-56CF-84C5-57389EE1EDFE</para>
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
        /// <para>100</para>
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
