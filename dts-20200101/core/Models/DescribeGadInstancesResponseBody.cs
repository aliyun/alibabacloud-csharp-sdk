// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeGadInstancesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>present environment is not support,so skip.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeGadInstancesResponseBodyInstances Instances { get; set; }
        public class DescribeGadInstancesResponseBodyInstances : TeaModel {
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<DescribeGadInstancesResponseBodyInstancesInstances> Instances { get; set; }
            public class DescribeGadInstancesResponseBodyInstancesInstances : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("DbEngineType")]
                [Validation(Required=false)]
                public string DbEngineType { get; set; }

                [NameInMap("DbInstanceCount")]
                [Validation(Required=false)]
                public int? DbInstanceCount { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("InstanceRegion")]
                [Validation(Required=false)]
                public string InstanceRegion { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("MasterDbInstanceId")]
                [Validation(Required=false)]
                public string MasterDbInstanceId { get; set; }

                [NameInMap("MasterDbInstanceName")]
                [Validation(Required=false)]
                public string MasterDbInstanceName { get; set; }

                [NameInMap("MasterDbInstanceRegion")]
                [Validation(Required=false)]
                public string MasterDbInstanceRegion { get; set; }

                [NameInMap("MasterDbInstanceZoneId")]
                [Validation(Required=false)]
                public string MasterDbInstanceZoneId { get; set; }

                [NameInMap("MasterEngineArchType")]
                [Validation(Required=false)]
                public int? MasterEngineArchType { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C166D79D-436B-45F0-B5A5-25E1959F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
