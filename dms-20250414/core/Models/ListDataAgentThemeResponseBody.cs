// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDataAgentThemeResponseBody : TeaModel {
        /// <summary>
        /// <para>The response struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDataAgentThemeResponseBodyData> Data { get; set; }
        public class ListDataAgentThemeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The common scenarios. Valid values: report, infographic, and others.</para>
            /// 
            /// <b>Example:</b>
            /// <para>report</para>
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
            /// <para>The description.</para>
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
            /// <para>The tracing reference that points to the UUID of the source theme.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6d1e3f9a-<b><b>-</b></b>-****-2b8c4e6f0a1d</para>
            /// </summary>
            [NameInMap("ReferTo")]
            [Validation(Required=false)]
            public string ReferTo { get; set; }

            /// <summary>
            /// <para>The source of the theme. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>system</description></item>
            /// <item><description>custom</description></item>
            /// <item><description>derived</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("ThemeFrom")]
            [Validation(Required=false)]
            public string ThemeFrom { get; set; }

            /// <summary>
            /// <para>The business identifier of the theme.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0f8b2c1d-<b><b>-</b></b>-****-9a3e5f7b1c2d</para>
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
            /// <para>The theme stage. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>design: contains only design.md.</description></item>
            /// <item><description>template: complete and renderable.</description></item>
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
        /// <para>The error code returned when the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NesLoKLEdIZrKhDT7I2gS****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The current page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
