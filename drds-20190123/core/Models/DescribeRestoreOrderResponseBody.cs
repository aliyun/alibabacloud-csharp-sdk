// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeRestoreOrderResponseBody : TeaModel {
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RestoreOrderDO")]
        [Validation(Required=false)]
        public DescribeRestoreOrderResponseBodyRestoreOrderDO RestoreOrderDO { get; set; }
        public class DescribeRestoreOrderResponseBodyRestoreOrderDO : TeaModel {
            [NameInMap("DrdsOrderDOList")]
            [Validation(Required=false)]
            public DescribeRestoreOrderResponseBodyRestoreOrderDODrdsOrderDOList DrdsOrderDOList { get; set; }
            public class DescribeRestoreOrderResponseBodyRestoreOrderDODrdsOrderDOList : TeaModel {
                [NameInMap("DrdsOrderDOList")]
                [Validation(Required=false)]
                public List<DescribeRestoreOrderResponseBodyRestoreOrderDODrdsOrderDOListDrdsOrderDOList> DrdsOrderDOList { get; set; }
                public class DescribeRestoreOrderResponseBodyRestoreOrderDODrdsOrderDOListDrdsOrderDOList : TeaModel {
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                    [NameInMap("Network")]
                    [Validation(Required=false)]
                    public string Network { get; set; }

                    [NameInMap("VSwtichId")]
                    [Validation(Required=false)]
                    public string VSwtichId { get; set; }

                    [NameInMap("InstSpec")]
                    [Validation(Required=false)]
                    public string InstSpec { get; set; }

                    [NameInMap("AzoneId")]
                    [Validation(Required=false)]
                    public string AzoneId { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                }

            }
            [NameInMap("RdsOrderDOList")]
            [Validation(Required=false)]
            public DescribeRestoreOrderResponseBodyRestoreOrderDORdsOrderDOList RdsOrderDOList { get; set; }
            public class DescribeRestoreOrderResponseBodyRestoreOrderDORdsOrderDOList : TeaModel {
                [NameInMap("RdsOrderDOList")]
                [Validation(Required=false)]
                public List<DescribeRestoreOrderResponseBodyRestoreOrderDORdsOrderDOListRdsOrderDOList> RdsOrderDOList { get; set; }
                public class DescribeRestoreOrderResponseBodyRestoreOrderDORdsOrderDOListRdsOrderDOList : TeaModel {
                    [NameInMap("Network")]
                    [Validation(Required=false)]
                    public string Network { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                    [NameInMap("InstanceClass")]
                    [Validation(Required=false)]
                    public string InstanceClass { get; set; }

                    [NameInMap("DbInstanceStorage")]
                    [Validation(Required=false)]
                    public string DbInstanceStorage { get; set; }

                    [NameInMap("Num")]
                    [Validation(Required=false)]
                    public long? Num { get; set; }

                    [NameInMap("Engine")]
                    [Validation(Required=false)]
                    public string Engine { get; set; }

                    [NameInMap("AzoneId")]
                    [Validation(Required=false)]
                    public string AzoneId { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                }

            }
            [NameInMap("PolarOrderDOList")]
            [Validation(Required=false)]
            public DescribeRestoreOrderResponseBodyRestoreOrderDOPolarOrderDOList PolarOrderDOList { get; set; }
            public class DescribeRestoreOrderResponseBodyRestoreOrderDOPolarOrderDOList : TeaModel {
                [NameInMap("PolarOrderDOList")]
                [Validation(Required=false)]
                public List<DescribeRestoreOrderResponseBodyRestoreOrderDOPolarOrderDOListPolarOrderDOList> PolarOrderDOList { get; set; }
                public class DescribeRestoreOrderResponseBodyRestoreOrderDOPolarOrderDOListPolarOrderDOList : TeaModel {
                    [NameInMap("Network")]
                    [Validation(Required=false)]
                    public string Network { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                    [NameInMap("InstanceClass")]
                    [Validation(Required=false)]
                    public string InstanceClass { get; set; }

                    [NameInMap("DbInstanceStorage")]
                    [Validation(Required=false)]
                    public string DbInstanceStorage { get; set; }

                    [NameInMap("Num")]
                    [Validation(Required=false)]
                    public long? Num { get; set; }

                    [NameInMap("Engine")]
                    [Validation(Required=false)]
                    public string Engine { get; set; }

                    [NameInMap("AzoneId")]
                    [Validation(Required=false)]
                    public string AzoneId { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                }

            }
        };

    }

}
