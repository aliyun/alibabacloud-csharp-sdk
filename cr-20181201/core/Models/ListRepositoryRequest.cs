// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepositoryRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call the ListInstance operation to query existing Enterprise instances.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-kmsiwlxxdcva****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The maximum number of returned results.</para>
        /// <para>Use this parameter together with the NextToken parameter. This parameter takes precedence over PageNo and PageSize.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page. If a next page exists, the service returns a NextToken value, which you can pass in the next request.</para>
        /// <para>Use this parameter together with the MaxResults parameter. This parameter takes precedence over PageNo and PageSize.</para>
        /// 
        /// <b>Example:</b>
        /// <para>*****V3MpHK1AP0pfERHZN5pu6lESTRpd5hnHNnmKOP/+w9F</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        [Obsolete]
        public int? PageNo { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100. If the specified value exceeds 100, the system returns a parameter error or uses 100 as the maximum number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        [Obsolete]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The repository name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>repo-test</para>
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <para>The name of the repository namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>repo-namespace-test</para>
        /// </summary>
        [NameInMap("RepoNamespaceName")]
        [Validation(Required=false)]
        public string RepoNamespaceName { get; set; }

        /// <summary>
        /// <para>The repository status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>NORMAL</c>: Normal.</para>
        /// </description></item>
        /// <item><description><para><c>DELETING</c>: Deleting.</para>
        /// </description></item>
        /// <item><description><para><c>DELETED</c>: Deleted.</para>
        /// </description></item>
        /// <item><description><para><c>ALL</c>: All repository statuses.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("RepoStatus")]
        [Validation(Required=false)]
        public string RepoStatus { get; set; }

    }

}
