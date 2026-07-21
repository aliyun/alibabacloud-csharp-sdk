// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateEcdReportTaskRequest : TeaModel {
        [NameInMap("BusinessChannel")]
        [Validation(Required=false)]
        public string BusinessChannel { get; set; }

        /// <summary>
        /// <para>The list of filter conditions for query results. The filter condition objects have a logical AND (&amp;) relationship.
        /// Each filter condition contains FilterKey and FilterValues, which represent the filter condition name and specific values.</para>
        /// </summary>
        [NameInMap("FilterList")]
        [Validation(Required=false)]
        public List<CreateEcdReportTaskRequestFilterList> FilterList { get; set; }
        public class CreateEcdReportTaskRequestFilterList : TeaModel {
            /// <summary>
            /// <para>The report query filter condition. The valid values vary based on the SubType value:</para>
            /// <ol>
            /// <item><description>Cloud computer report</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>KeyWord: automatic keyword recognition for cloud computers.</description></item>
            /// <item><description>RegionId: the region ID.</description></item>
            /// <item><description>DesktopId: the cloud computer ID.</description></item>
            /// <item><description>DesktopName: the cloud computer name (fuzzy match).</description></item>
            /// <item><description>OfficeSiteId: the office network ID.</description></item>
            /// <item><description>OfficeSiteName: the office network name (fuzzy match).</description></item>
            /// <item><description>Status: the cloud computer status.</description></item>
            /// <item><description>DesktopType: the desktop specifications.</description></item>
            /// <item><description>DesktopIP: the cloud computer IP address.</description></item>
            /// <item><description>SubPayType: the billing method.</description></item>
            /// <item><description>EndUserId: the username (fuzzy match).</description></item>
            /// <item><description>ExpireTime: the expiration time in the yyyy-MM-dd\&quot;T\&quot;HH:mm:ss\&quot;Z\&quot; format.</description></item>
            /// <item><description>IncludeAssignedUser: specifies whether users are assigned.</description></item>
            /// <item><description>ResourceGroupId: the resource group ID.</description></item>
            /// <item><description>PolicyId: the policy ID.</description></item>
            /// <item><description>Tag:{Tag Key}: the cloud computer tag. To query by multiple tags, pass in multiple Filter objects.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Tag:TestKey</para>
            /// </summary>
            [NameInMap("FilterKey")]
            [Validation(Required=false)]
            public string FilterKey { get; set; }

            /// <summary>
            /// <para>The values of the filter condition.
            /// When FilterKey is set to one of the following values, only the first value in FilterValues is used:</para>
            /// <list type="bullet">
            /// <item><description>KeyWord</description></item>
            /// <item><description>DesktopName</description></item>
            /// <item><description>OfficeSiteName</description></item>
            /// <item><description>DesktopIP</description></item>
            /// <item><description>EndUserId</description></item>
            /// <item><description>ExpireTime</description></item>
            /// <item><description>IncludeAssignedUser</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Test cloud desktop name</para>
            /// </summary>
            [NameInMap("FilterValues")]
            [Validation(Required=false)]
            public List<string> FilterValues { get; set; }

        }

        /// <summary>
        /// <para>The report language type. This is an enumerated value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("LangType")]
        [Validation(Required=false)]
        public string LangType { get; set; }

        /// <summary>
        /// <para>The report file name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test report name</para>
        /// </summary>
        [NameInMap("ReportFileName")]
        [Validation(Required=false)]
        public string ReportFileName { get; set; }

        /// <summary>
        /// <para>The report task subtype.
        /// [_single.params.SubType.enum.  DESKTOP]Cloud computer</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DESKTOP</para>
        /// </summary>
        [NameInMap("SubType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

        /// <summary>
        /// <para>The report task type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RESOURCE_REPORT</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
