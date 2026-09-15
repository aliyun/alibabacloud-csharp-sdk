// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DescribeDataAgentThemeResponseBody : TeaModel {
        /// <summary>
        /// <para>The response struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDataAgentThemeResponseBodyData Data { get; set; }
        public class DescribeDataAgentThemeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The common scenarios. Valid values: report, infographic, and others.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The creation time in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-15T08:30:00Z</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The description of the theme.</para>
            /// 
            /// <b>Example:</b>
            /// <para>weekly report</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The modification time in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-20T10:15:30Z</para>
            /// </summary>
            [NameInMap("ModifiedAt")]
            [Validation(Required=false)]
            public string ModifiedAt { get; set; }

            /// <summary>
            /// <para>The tracing information of the theme. This field is currently not enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6d1e3f9a-<b><b>-</b></b>-****-2b8c4e6f0a1d</para>
            /// </summary>
            [NameInMap("ReferTo")]
            [Validation(Required=false)]
            public string ReferTo { get; set; }

            /// <summary>
            /// <para>The source of the theme. Valid values: system, custom.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("ThemeFrom")]
            [Validation(Required=false)]
            public string ThemeFrom { get; set; }

            /// <summary>
            /// <para>The business ID of the theme.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0f8b2c1d***********9a3e5f7b1c2d</para>
            /// </summary>
            [NameInMap("ThemeId")]
            [Validation(Required=false)]
            public string ThemeId { get; set; }

            /// <summary>
            /// <para>The display name of the theme.</para>
            /// 
            /// <b>Example:</b>
            /// <para>weekly report</para>
            /// </summary>
            [NameInMap("ThemeName")]
            [Validation(Required=false)]
            public string ThemeName { get; set; }

            /// <summary>
            /// <para>The stage of the theme. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>design: The theme contains only design.md.</description></item>
            /// <item><description>template: The theme is complete and renderable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>template</para>
            /// </summary>
            [NameInMap("ThemeType")]
            [Validation(Required=false)]
            public string ThemeType { get; set; }

        }

        /// <summary>
        /// <para>The error code returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
