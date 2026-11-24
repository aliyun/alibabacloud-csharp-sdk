// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoTagRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-kmsiwlxxdcva****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return. Use this parameter together with the NextToken parameter. This parameter takes precedence over PageNo and PageSize.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. If a next page exists, the service returns a NextToken value, which you can include in the subsequent request. Use this parameter together with the MaxResults parameter. This parameter takes precedence over PageNo and PageSize.</para>
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
        /// <para>The page size. The maximum number of entries per page is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        [Obsolete]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The repository ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crr-tquyps22md8p****</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

    }

}
