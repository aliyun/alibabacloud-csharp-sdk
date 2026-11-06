// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetIncidentInvestigationRequest : TeaModel {
        /// <summary>
        /// <para>The display ID of the AI investigation report. You can obtain it from the IncidentInvestigationDisplayId parameter returned by ListIncidentInvestigations. This parameter takes effect only when IncidentInvestigationId is not specified. If neither identifier is specified, the most recent successfully completed investigation result for the specified event is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>755616bb5d63046c1e4f62ea872a****</para>
        /// </summary>
        [NameInMap("IncidentInvestigationDisplayId")]
        [Validation(Required=false)]
        public string IncidentInvestigationDisplayId { get; set; }

        /// <summary>
        /// <para>The ID of the AI investigation report. You can obtain it from the IncidentInvestigationId parameter returned by ListIncidentInvestigations. If both this parameter and IncidentInvestigationDisplayId are specified, this parameter takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>951a6a0b-14c7-4332-ace6-bff21c******</para>
        /// </summary>
        [NameInMap("IncidentInvestigationId")]
        [Validation(Required=false)]
        public string IncidentInvestigationId { get; set; }

        /// <summary>
        /// <para>The globally unique identity of the event. If neither the report ID nor the display ID is specified, an event query is performed to retrieve the most recent successfully completed investigation result.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
        /// </summary>
        [NameInMap("IncidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The region where the data management center of Threat Analysis is located. You must select the region of the management center based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Assets are located in the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: Assets are located outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the user whose perspective the administrator switches to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
