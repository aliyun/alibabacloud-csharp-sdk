// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateResourceRelationsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the account group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-856a626622af0033****</para>
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return for a single request. Valid values: 1 to 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AcBjqMYSy0is7zSMGu16****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the resource resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The type of the relationship between the resource and the object.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IsContained: The object is included as part of the resource.</description></item>
        /// <item><description>IsAttachedTo: The object is added to the resource.</description></item>
        /// <item><description>IsAssociatedIn: The object is associated with the resource.</description></item>
        /// <item><description>Contains: The object contains the resource.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IsAttachedTo</para>
        /// </summary>
        [NameInMap("RelationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the resources in the account group belong.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100931896542****</para>
        /// </summary>
        [NameInMap("ResourceAccountId")]
        [Validation(Required=false)]
        public long? ResourceAccountId { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-j6cajg9yrfoh4sas****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the resource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::ECS::Instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The ID of the resource that is associated with the object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-j6c8k731qbrc7fxi****</para>
        /// </summary>
        [NameInMap("TargetResourceId")]
        [Validation(Required=false)]
        public string TargetResourceId { get; set; }

        /// <summary>
        /// <para>The type of the resource that is associated with the object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::ECS::Disk</para>
        /// </summary>
        [NameInMap("TargetResourceType")]
        [Validation(Required=false)]
        public string TargetResourceType { get; set; }

    }

}
