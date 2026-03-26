// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSubscriptionInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of entries that can be displayed on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC3BAAF2-74E3-4471-8EB5-96202D6A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubscriptionInstances")]
        [Validation(Required=false)]
        public DescribeSubscriptionInstancesResponseBodySubscriptionInstances SubscriptionInstances { get; set; }
        public class DescribeSubscriptionInstancesResponseBodySubscriptionInstances : TeaModel {
            [NameInMap("SubscriptionInstance")]
            [Validation(Required=false)]
            public List<DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstance> SubscriptionInstance { get; set; }
            public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstance : TeaModel {
                [NameInMap("BeginTimestamp")]
                [Validation(Required=false)]
                public string BeginTimestamp { get; set; }

                [NameInMap("ConsumptionCheckpoint")]
                [Validation(Required=false)]
                public string ConsumptionCheckpoint { get; set; }

                [NameInMap("ConsumptionClient")]
                [Validation(Required=false)]
                public string ConsumptionClient { get; set; }

                [NameInMap("EndTimestamp")]
                [Validation(Required=false)]
                public string EndTimestamp { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("InstanceCreateTime")]
                [Validation(Required=false)]
                public string InstanceCreateTime { get; set; }

                [NameInMap("JobCreateTime")]
                [Validation(Required=false)]
                public string JobCreateTime { get; set; }

                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                [NameInMap("SourceEndpoint")]
                [Validation(Required=false)]
                public DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSourceEndpoint SourceEndpoint { get; set; }
                public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSourceEndpoint : TeaModel {
                    [NameInMap("InstanceID")]
                    [Validation(Required=false)]
                    public string InstanceID { get; set; }

                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("SubscribeTopic")]
                [Validation(Required=false)]
                public string SubscribeTopic { get; set; }

                [NameInMap("SubscriptionDataType")]
                [Validation(Required=false)]
                public DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionDataType SubscriptionDataType { get; set; }
                public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionDataType : TeaModel {
                    [NameInMap("DDL")]
                    [Validation(Required=false)]
                    public bool? DDL { get; set; }

                    [NameInMap("DML")]
                    [Validation(Required=false)]
                    public bool? DML { get; set; }

                }

                [NameInMap("SubscriptionHost")]
                [Validation(Required=false)]
                public DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionHost SubscriptionHost { get; set; }
                public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionHost : TeaModel {
                    [NameInMap("PrivateHost")]
                    [Validation(Required=false)]
                    public string PrivateHost { get; set; }

                    [NameInMap("PublicHost")]
                    [Validation(Required=false)]
                    public string PublicHost { get; set; }

                    [NameInMap("VPCHost")]
                    [Validation(Required=false)]
                    public string VPCHost { get; set; }

                }

                [NameInMap("SubscriptionInstanceID")]
                [Validation(Required=false)]
                public string SubscriptionInstanceID { get; set; }

                [NameInMap("SubscriptionInstanceName")]
                [Validation(Required=false)]
                public string SubscriptionInstanceName { get; set; }

                [NameInMap("SubscriptionObject")]
                [Validation(Required=false)]
                public DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionObject SubscriptionObject { get; set; }
                public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionObject : TeaModel {
                    [NameInMap("SynchronousObject")]
                    [Validation(Required=false)]
                    public List<DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionObjectSynchronousObject> SynchronousObject { get; set; }
                    public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionObjectSynchronousObject : TeaModel {
                        [NameInMap("DatabaseName")]
                        [Validation(Required=false)]
                        public string DatabaseName { get; set; }

                        [NameInMap("TableList")]
                        [Validation(Required=false)]
                        public DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionObjectSynchronousObjectTableList TableList { get; set; }
                        public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionObjectSynchronousObjectTableList : TeaModel {
                            [NameInMap("Table")]
                            [Validation(Required=false)]
                            public List<string> Table { get; set; }

                        }

                        [NameInMap("WholeDatabase")]
                        [Validation(Required=false)]
                        public string WholeDatabase { get; set; }

                    }

                }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceTags Tags { get; set; }
                public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceTagsTag> Tag { get; set; }
                    public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The total number of change tracking instances that belong to your Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
