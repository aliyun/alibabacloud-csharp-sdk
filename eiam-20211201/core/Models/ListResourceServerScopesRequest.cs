// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListResourceServerScopesRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The authorization type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>authorize_required</para>
        /// </summary>
        [NameInMap("AuthorizationType")]
        [Validation(Required=false)]
        public string AuthorizationType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token (NextToken) used to retrieve the next page of results. Set this parameter to the NextToken value returned in the previous API call. Leave this parameter empty for the first query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The pagination token for the previous page. Set this parameter to the PreviousToken value returned in the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PTxxxxxexample</para>
        /// </summary>
        [NameInMap("PreviousToken")]
        [Validation(Required=false)]
        public string PreviousToken { get; set; }

        /// <summary>
        /// <para>The list of scope permission IDs.</para>
        /// </summary>
        [NameInMap("ResourceServerScopeIds")]
        [Validation(Required=false)]
        public List<string> ResourceServerScopeIds { get; set; }

        /// <summary>
        /// <para>The scope permission name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>读取全部用户</para>
        /// </summary>
        [NameInMap("ResourceServerScopeName")]
        [Validation(Required=false)]
        public string ResourceServerScopeName { get; set; }

        /// <summary>
        /// <para>The scope permission type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>urn:alibaba:idaas:resourceserver:scope:delegated</para>
        /// </summary>
        [NameInMap("ResourceServerScopeType")]
        [Validation(Required=false)]
        public string ResourceServerScopeType { get; set; }

        /// <summary>
        /// <para>The scope permission value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>User:Write:ALL</para>
        /// </summary>
        [NameInMap("ResourceServerScopeValue")]
        [Validation(Required=false)]
        public string ResourceServerScopeValue { get; set; }

    }

}
