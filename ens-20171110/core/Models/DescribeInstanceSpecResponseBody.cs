// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstanceSpecResponseBody : TeaModel {
        /// <summary>
        /// <para>The bandwidth limit for a single instance. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BandwidthLimit")]
        [Validation(Required=false)]
        public int? BandwidthLimit { get; set; }

        /// <summary>
        /// <para>The returned service code. A value of 0 indicates that the operation was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The maximum capacity of a data disk. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20015</para>
        /// </summary>
        [NameInMap("DataDiskMaxSize")]
        [Validation(Required=false)]
        public int? DataDiskMaxSize { get; set; }

        /// <summary>
        /// <para>The minimum capacity of a data disk. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DataDiskMinSize")]
        [Validation(Required=false)]
        public int? DataDiskMinSize { get; set; }

        [NameInMap("InstanceSpecs")]
        [Validation(Required=false)]
        public DescribeInstanceSpecResponseBodyInstanceSpecs InstanceSpecs { get; set; }
        public class DescribeInstanceSpecResponseBodyInstanceSpecs : TeaModel {
            [NameInMap("InstanceSpec")]
            [Validation(Required=false)]
            public List<DescribeInstanceSpecResponseBodyInstanceSpecsInstanceSpec> InstanceSpec { get; set; }
            public class DescribeInstanceSpecResponseBodyInstanceSpecsInstanceSpec : TeaModel {
                [NameInMap("Core")]
                [Validation(Required=false)]
                public string Core { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ECC937A-AE0E-4626-BE51-DED1D6D1C888</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The maximum capacity of the system disk. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("SystemDiskMaxSize")]
        [Validation(Required=false)]
        public int? SystemDiskMaxSize { get; set; }

    }

}
