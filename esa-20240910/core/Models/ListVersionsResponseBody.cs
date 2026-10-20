// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7EBEC214-805D-5FE9-AEED-258FE0F8850F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of versions for the site.</para>
        /// </summary>
        [NameInMap("SiteVersionList")]
        [Validation(Required=false)]
        public List<ListVersionsResponseBodySiteVersionList> SiteVersionList { get; set; }
        public class ListVersionsResponseBodySiteVersionList : TeaModel {
            /// <summary>
            /// <para>The creation time. The time follows the ISO 8601 standard and includes a time zone offset. Example: 2024-06-15T17:41:27+08:00.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-15T17:41:27+08:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Site A uses multiple environments</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of environments for the site version. No environment is configured, or one or more environments are configured, such as the default environment and Environment 2.</para>
            /// </summary>
            [NameInMap("EnvironmentNameList")]
            [Validation(Required=false)]
            public List<string> EnvironmentNameList { get; set; }

            /// <summary>
            /// <para>The parent version of the site version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ParentSiteVersion")]
            [Validation(Required=false)]
            public int? ParentSiteVersion { get; set; }

            /// <summary>
            /// <para>Specifies whether the version is read-only. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ReadOnly")]
            [Validation(Required=false)]
            public bool? ReadOnly { get; set; }

            /// <summary>
            /// <para>The site version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("SiteVersion")]
            [Validation(Required=false)]
            public int? SiteVersion { get; set; }

            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>online</b>: Available.</para>
            /// </description></item>
            /// <item><description><para><b>configuring</b>: Configuring.</para>
            /// </description></item>
            /// <item><description><para><b>configure_faild</b>: Configuration failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The update time. The time follows the ISO 8601 standard and includes a time zone offset. Example: 2024-06-15T17:41:27+08:00.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-15T17:41:27+08:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
