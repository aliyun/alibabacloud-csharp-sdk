// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListAclsRequest : TeaModel {
        /// <summary>
        /// <para>Filter access control lists (ACLs) by ACL ID. You can specify at most 20 ACL IDs in each call.</para>
        /// </summary>
        [NameInMap("AclIds")]
        [Validation(Required=false)]
        public List<string> AclIds { get; set; }

        /// <summary>
        /// <para>The ACL names. You can specify up to 10 ACL names in each call.</para>
        /// </summary>
        [NameInMap("AclNames")]
        [Validation(Required=false)]
        public List<string> AclNames { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return. This parameter is optional. Valid values: <b>1</b> to <b>100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is your first query or no next query is to be sent, ignore this parameter.</description></item>
        /// <item><description>If a next query is to be sent, set the value to the value of NextToken that is returned from the last call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. You can filter the query results based on the specified ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-atstuj3rtopty****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListAclsRequestTag> Tag { get; set; }
        public class ListAclsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The tag key can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
