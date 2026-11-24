// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListChartRepositoryRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-xkx6vujuhay0****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The repository name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ns1</para>
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <para>The namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>repo1</para>
        /// </summary>
        [NameInMap("RepoNamespaceName")]
        [Validation(Required=false)]
        public string RepoNamespaceName { get; set; }

        /// <summary>
        /// <para>The status of the chart repository. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>NORMAL</c>: The chart repository is in the Normal state.</para>
        /// </description></item>
        /// <item><description><para><c>DELETING</c>: The chart repository is being deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("RepoStatus")]
        [Validation(Required=false)]
        public string RepoStatus { get; set; }

    }

}
