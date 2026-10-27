// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeOrgsRequest : TeaModel {
        /// <summary>
        /// <para>The business channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("BusinessChannel")]
        [Validation(Required=false)]
        public string BusinessChannel { get; set; }

        /// <summary>
        /// <para>The list of organization IDs to query.</para>
        /// </summary>
        [NameInMap("IncludeOrgIds")]
        [Validation(Required=false)]
        public List<string> IncludeOrgIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to query all subordinate organizations when a parent organization is specified.</para>
        /// </summary>
        [NameInMap("IsQueryAllSubOrgs")]
        [Validation(Required=false)]
        public bool? IsQueryAllSubOrgs { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return. Valid values: 1 to 100. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Set the value to the NextToken parameter returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The name of the organization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Product Department</para>
        /// </summary>
        [NameInMap("OrgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        /// <summary>
        /// <para>The ID of the parent organization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>org-11fs****</para>
        /// </summary>
        [NameInMap("ParentOrgId")]
        [Validation(Required=false)]
        public string ParentOrgId { get; set; }

        /// <summary>
        /// <para>The switch mapping for additional response information. This parameter controls whether to return organization paths and resource policy information.</para>
        /// </summary>
        [NameInMap("ShowExtras")]
        [Validation(Required=false)]
        public Dictionary<string, object> ShowExtras { get; set; }

    }

}
