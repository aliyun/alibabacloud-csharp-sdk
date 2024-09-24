// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The days in a week on which an automatic check is performed.</para>
        /// </summary>
        [NameInMap("CycleDays")]
        [Validation(Required=false)]
        public List<int?> CycleDays { get; set; }

        /// <summary>
        /// <para>Indicates whether the check for new check items in the selected requirement item is enabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableAddCheck")]
        [Validation(Required=false)]
        public bool? EnableAddCheck { get; set; }

        /// <summary>
        /// <para>Indicates whether the automatic check is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAutoCheck")]
        [Validation(Required=false)]
        public bool? EnableAutoCheck { get; set; }

        /// <summary>
        /// <para>The end time of the check. The value indicates a point in time. The time period that is specified by the start time and end time must be one of the following time periods:</para>
        /// <list type="bullet">
        /// <item><description><b>00:00 to 06:00</b>: If StartTime is set to 00:00, EndTime must be set to 06:00.</description></item>
        /// <item><description><b>06:00 to 12:00</b>: If StartTime is set to 06:00, EndTime must be set to 12:00.</description></item>
        /// <item><description><b>12:00 to 18:00</b>: If StartTime is set to 12:00, EndTime must be set to 18:00.</description></item>
        /// <item><description><b>18:00 to 24:00</b>: If StartTime is set to 18:00, EndTime must be set to 24:00.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
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
        /// <para>The information about the check items.</para>
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
            /// <para>Cloud service configuration management</para>
            /// </summary>
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            /// <summary>
            /// <para>The status of the check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ON</b>: The check item is enabled.</description></item>
            /// <item><description><b>OFF</b>: The check item is disabled.</description></item>
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
            /// <item><description><b>RISK</b>: cloud service configuration management</description></item>
            /// <item><description><b>IDENTITY_PERMISSION</b>: identity and permission management</description></item>
            /// <item><description><b>COMPLIANCE</b>: compliance</description></item>
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
        /// <para>The start time of the check. The value indicates a point in time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

    }

}
