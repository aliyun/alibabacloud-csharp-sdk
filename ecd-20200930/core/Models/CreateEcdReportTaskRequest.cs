// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateEcdReportTaskRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions for filtering query results. The logical relationship between each filter condition is &quot;and&quot; (&amp;). Each filter condition contains FilterKey and FilterValues, which indicate the key and value for the filter condition.</para>
        /// </summary>
        [NameInMap("FilterList")]
        [Validation(Required=false)]
        public List<CreateEcdReportTaskRequestFilterList> FilterList { get; set; }
        public class CreateEcdReportTaskRequestFilterList : TeaModel {
            /// <summary>
            /// <para>The key of the filter condition for filtering query results. When SubType is set to:</para>
            /// <ol>
            /// <item><description>DESKTOP (indicating a cloud computer report), the following filter conditions are available:</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>KeyWord: cloud computer keyword (supports automatic recognition)</description></item>
            /// <item><description>RegionId: region ID</description></item>
            /// <item><description>DesktopId: cloud computer ID</description></item>
            /// <item><description>DesktopName: cloud computer name (supports fuzzy matching)</description></item>
            /// <item><description>OfficeSiteId: office network ID</description></item>
            /// <item><description>OfficeSiteName: office network name (supports fuzzy matching)</description></item>
            /// <item><description>Status: cloud computer status</description></item>
            /// <item><description>DesktopType: desktop type</description></item>
            /// <item><description>DesktopIP: cloud computer IP address</description></item>
            /// <item><description>SubPayType: billing method</description></item>
            /// <item><description>EndUserId: user name (supports fuzzy matching)</description></item>
            /// <item><description>ExpireTime: expiration date and time, in the yyyy-MM-dd\&quot;T\&quot;HH:mm:ss\&quot;Z\&quot; format</description></item>
            /// <item><description>IncludeAssignedUser: indicates whether the cloud computer is assigned to users or not</description></item>
            /// <item><description>ResourceGroupId: resource group ID</description></item>
            /// <item><description>PolicyId: policy ID</description></item>
            /// <item><description>Tag:{Tag Key value}: cloud computer tag (To filter data using multiple tags, specify multiple filter condition objects.)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Tag:TestKey</para>
            /// </summary>
            [NameInMap("FilterKey")]
            [Validation(Required=false)]
            public string FilterKey { get; set; }

            /// <summary>
            /// <para>The value of the filter condition. Only the first value of the FilterValues parameter is used, if FilterKey is set to one of the following values:</para>
            /// <list type="bullet">
            /// <item><description>KeyWord</description></item>
            /// <item><description>DesktopName</description></item>
            /// <item><description>OfficeSiteName</description></item>
            /// <item><description>DesktopIP</description></item>
            /// <item><description>EndUserId</description></item>
            /// <item><description>ExpireTime</description></item>
            /// <item><description>IncludeAssignedUser</description></item>
            /// </list>
            /// </summary>
            [NameInMap("FilterValues")]
            [Validation(Required=false)]
            public List<string> FilterValues { get; set; }

        }

        /// <summary>
        /// <para>The language of the report. An enumerated type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN (default): Chinese</description></item>
        /// <item><description>en-GB: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("LangType")]
        [Validation(Required=false)]
        public string LangType { get; set; }

        /// <summary>
        /// <para>The name of the report file.</para>
        /// </summary>
        [NameInMap("ReportFileName")]
        [Validation(Required=false)]
        public string ReportFileName { get; set; }

        /// <summary>
        /// <para>The sub-type of the report export task.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>DESKTOP: cloud computer</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DESKTOP</para>
        /// </summary>
        [NameInMap("SubType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

        /// <summary>
        /// <para>The type of the report task.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>RESOURCE_REPORT</description></item>
        /// </list>
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
