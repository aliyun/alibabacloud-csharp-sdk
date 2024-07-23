// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeElasticityAssuranceInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the instances that match and use the elasticity assurance.</para>
        /// </summary>
        [NameInMap("ElasticityAssuranceItem")]
        [Validation(Required=false)]
        public DescribeElasticityAssuranceInstancesResponseBodyElasticityAssuranceItem ElasticityAssuranceItem { get; set; }
        public class DescribeElasticityAssuranceInstancesResponseBodyElasticityAssuranceItem : TeaModel {
            [NameInMap("InstanceIdSet")]
            [Validation(Required=false)]
            public List<DescribeElasticityAssuranceInstancesResponseBodyElasticityAssuranceItemInstanceIdSet> InstanceIdSet { get; set; }
            public class DescribeElasticityAssuranceInstancesResponseBodyElasticityAssuranceItemInstanceIdSet : TeaModel {
                /// <summary>
                /// <para>The instance ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp67acfmxazb4****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to start the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
