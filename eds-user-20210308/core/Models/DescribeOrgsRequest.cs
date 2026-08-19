// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeOrgsRequest : TeaModel {
        /// <summary>
        /// <para>The channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("BusinessChannel")]
        [Validation(Required=false)]
        public string BusinessChannel { get; set; }

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
        /// <para>The maximum number of results to return. Valid values: 1 to 100.<br>Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Set this parameter to the value of NextToken that was returned in the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The organization name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ProductDepartment</para>
        /// </summary>
        [NameInMap("OrgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        /// <summary>
        /// <para>The parent organization ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>org-11fs****</para>
        /// </summary>
        [NameInMap("ParentOrgId")]
        [Validation(Required=false)]
        public string ParentOrgId { get; set; }

        [NameInMap("ShowExtras")]
        [Validation(Required=false)]
        public Dictionary<string, object> ShowExtras { get; set; }

    }

}
