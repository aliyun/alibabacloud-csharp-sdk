// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eais20190624.Models
{
    public class DescribeEaisResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeEaisResponseBodyInstances Instances { get; set; }
        public class DescribeEaisResponseBodyInstances : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<DescribeEaisResponseBodyInstancesInstance> Instance { get; set; }
            public class DescribeEaisResponseBodyInstancesInstance : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>jupyter</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>i-wz93g6pyat2g****</para>
                /// </summary>
                [NameInMap("ClientInstanceId")]
                [Validation(Required=false)]
                public string ClientInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test1</para>
                /// </summary>
                [NameInMap("ClientInstanceName")]
                [Validation(Required=false)]
                public string ClientInstanceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ecs.g5ne.large</para>
                /// </summary>
                [NameInMap("ClientInstanceType")]
                [Validation(Required=false)]
                public string ClientInstanceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-11-11T03:11Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>testDescription</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>eais-sz8t15a7gt7****</para>
                /// </summary>
                [NameInMap("ElasticAcceleratedInstanceId")]
                [Validation(Required=false)]
                public string ElasticAcceleratedInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>testName</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>eais.ei-a6.2xlarge</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://121.41.**.24:8888">http://121.41.**.24:8888</a></para>
                /// </summary>
                [NameInMap("JupyterUrl")]
                [Validation(Required=false)]
                public string JupyterUrl { get; set; }

                [NameInMap("PaymentType")]
                [Validation(Required=false)]
                public string PaymentType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-shenzhen</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sg-bp1gppir818lx4******</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>InUse</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeEaisResponseBodyInstancesInstanceTags Tags { get; set; }
                public class DescribeEaisResponseBodyInstancesInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeEaisResponseBodyInstancesInstanceTagsTag> Tag { get; set; }
                    public class DescribeEaisResponseBodyInstancesInstanceTagsTag : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>TestValue</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vsw-bp1sd131hfmd76r******</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-shenzhen-e</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1E23D585-BBD8-436F-9615-54CACD6*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
