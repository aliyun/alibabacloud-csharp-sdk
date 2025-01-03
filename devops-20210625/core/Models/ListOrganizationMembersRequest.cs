// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListOrganizationMembersRequest : TeaModel {
        /// <summary>
        /// <para>返回信息中是否包含第三方信息，默认不包含。</para>
        /// </summary>
        [NameInMap("containsExternInfo")]
        [Validation(Required=false)]
        public bool? ContainsExternInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1236666</para>
        /// </summary>
        [NameInMap("externUid")]
        [Validation(Required=false)]
        public string ExternUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1631845101798</para>
        /// </summary>
        [NameInMap("joinTimeFrom")]
        [Validation(Required=false)]
        public long? JoinTimeFrom { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1631845101798</para>
        /// </summary>
        [NameInMap("joinTimeTo")]
        [Validation(Required=false)]
        public long? JoinTimeTo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("organizationMemberName")]
        [Validation(Required=false)]
        public string OrganizationMemberName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Dingtalk</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
