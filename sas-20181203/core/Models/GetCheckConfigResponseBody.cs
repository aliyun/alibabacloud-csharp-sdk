// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The periodic check schedule.</para>
        /// </summary>
        [NameInMap("CycleDays")]
        [Validation(Required=false)]
        public List<int?> CycleDays { get; set; }

        /// <summary>
        /// <para>Indicates whether new check items added to the selected standards are checked by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true:</b> Enabled.</description></item>
        /// <item><description><b>false:</b> Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableAddCheck")]
        [Validation(Required=false)]
        public bool? EnableAddCheck { get; set; }

        /// <summary>
        /// <para>Indicates whether automatic periodic checks are enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true:</b> Enabled.</description></item>
        /// <item><description><b>false:</b> Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAutoCheck")]
        [Validation(Required=false)]
        public bool? EnableAutoCheck { get; set; }

        /// <summary>
        /// <para>The end time of the check period, indicating the hour of the day. The start time and end time must fall within one of the following time ranges:</para>
        /// <list type="bullet">
        /// <item><description><b>0~6</b>: If the start time is 0, the end time must be set to 6.</description></item>
        /// <item><description><b>6~12</b>: If the start time is 6, the end time must be set to 12.</description></item>
        /// <item><description><b>12~18</b>: If the start time is 12, the end time must be set to 18.</description></item>
        /// <item><description><b>18~24</b>: If the start time is 18, the end time must be set to 24.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each request. You can use the request ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A3D5C8F-2A42-5477-BDD8-27E64B5F1739</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The check items selected in the policy.</para>
        /// </summary>
        [NameInMap("SelectedChecks")]
        [Validation(Required=false)]
        public List<GetCheckConfigResponseBodySelectedChecks> SelectedChecks { get; set; }
        public class GetCheckConfigResponseBodySelectedChecks : TeaModel {
            /// <summary>
            /// <para>The ID of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// <para>The section ID of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69</para>
            /// </summary>
            [NameInMap("SectionId")]
            [Validation(Required=false)]
            public long? SectionId { get; set; }

        }

        /// <summary>
        /// <para>The list of check item information.</para>
        /// </summary>
        [NameInMap("Standards")]
        [Validation(Required=false)]
        public List<GetCheckConfigResponseBodyStandards> Standards { get; set; }
        public class GetCheckConfigResponseBodyStandards : TeaModel {
            /// <summary>
            /// <para>The ID of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>云产品配置管理</para>
            /// </summary>
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            /// <summary>
            /// <para>The enabling status of the check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ON:</b> Enabled.</description></item>
            /// <item><description><b>OFF:</b> Shutdown.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RISK:</b> cloud service configuration management</description></item>
            /// <item><description><b>IDENTITY_PERMISSION:</b> permission management</description></item>
            /// <item><description><b>COMPLIANCE:</b> compliance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RISK</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The start time of the check period, indicating the hour of the day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

    }

}
