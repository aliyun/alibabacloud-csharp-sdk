// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeAvailableSpecResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAvailableSpecResponseBodyData Data { get; set; }
        public class DescribeAvailableSpecResponseBodyData : TeaModel {
            [NameInMap("AvailableSpecifications")]
            [Validation(Required=false)]
            public List<DescribeAvailableSpecResponseBodyDataAvailableSpecifications> AvailableSpecifications { get; set; }
            public class DescribeAvailableSpecResponseBodyDataAvailableSpecifications : TeaModel {
                [NameInMap("DiskSizeRange")]
                [Validation(Required=false)]
                public DescribeAvailableSpecResponseBodyDataAvailableSpecificationsDiskSizeRange DiskSizeRange { get; set; }
                public class DescribeAvailableSpecResponseBodyDataAvailableSpecificationsDiskSizeRange : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>40000</para>
                    /// </summary>
                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public long? Max { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public long? Min { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Step")]
                    [Validation(Required=false)]
                    public long? Step { get; set; }

                }

                [NameInMap("DiskTypes")]
                [Validation(Required=false)]
                public List<string> DiskTypes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4C16GB</para>
                /// </summary>
                [NameInMap("InstanceClass")]
                [Validation(Required=false)]
                public string InstanceClass { get; set; }

                [NameInMap("LogDiskSizeRange")]
                [Validation(Required=false)]
                public DescribeAvailableSpecResponseBodyDataAvailableSpecificationsLogDiskSizeRange LogDiskSizeRange { get; set; }
                public class DescribeAvailableSpecResponseBodyDataAvailableSpecificationsLogDiskSizeRange : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>4000</para>
                    /// </summary>
                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public long? Max { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public long? Min { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Step")]
                    [Validation(Required=false)]
                    public long? Step { get; set; }

                }

                [NameInMap("NodeNum")]
                [Validation(Required=false)]
                public List<int?> NodeNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oceanbase.cluster.cd8.xlarge</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
