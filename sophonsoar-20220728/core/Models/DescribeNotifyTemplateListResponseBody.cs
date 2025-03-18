// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeNotifyTemplateListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeNotifyTemplateListResponseBodyData> Data { get; set; }
        public class DescribeNotifyTemplateListResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Dear $aliyunUID : Cloud Security Center Threat Analysis and Response has detected a newly discovered security incident $incidentName(Incident id :$incidentID) in $startTime, Please go to Cloud Security Center Console View.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yundun_soar_incident_generate</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[\&quot;aliyunUID\&quot;,\&quot;incidentName\&quot;,\&quot;incidentID\&quot;,\&quot;startTime\&quot;]</para>
            /// </summary>
            [NameInMap("Params")]
            [Validation(Required=false)]
            public string Params { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[Alibaba Cloud Threat Analysis and Response] has detected a newly discovered security incident $incidentName($incidentID)</para>
            /// </summary>
            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>incident generate</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public DescribeNotifyTemplateListResponseBodyPage Page { get; set; }
        public class DescribeNotifyTemplateListResponseBodyPage : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B3FED5B9-190A-5952-93A4-24FBF0F0C573</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
