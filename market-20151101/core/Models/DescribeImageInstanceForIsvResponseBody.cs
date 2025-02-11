// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeImageInstanceForIsvResponseBody : TeaModel {
        [NameInMap("ActiveAddress")]
        [Validation(Required=false)]
        public string ActiveAddress { get; set; }

        [NameInMap("AppJson")]
        [Validation(Required=false)]
        public string AppJson { get; set; }

        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public string AutoRenewal { get; set; }

        [NameInMap("BeganOn")]
        [Validation(Required=false)]
        public long? BeganOn { get; set; }

        [NameInMap("ComponentJson")]
        [Validation(Required=false)]
        public string ComponentJson { get; set; }

        [NameInMap("Constraints")]
        [Validation(Required=false)]
        public string Constraints { get; set; }

        [NameInMap("CreatedOn")]
        [Validation(Required=false)]
        public long? CreatedOn { get; set; }

        [NameInMap("EndOn")]
        [Validation(Required=false)]
        public long? EndOn { get; set; }

        [NameInMap("ExtendJson")]
        [Validation(Required=false)]
        public string ExtendJson { get; set; }

        [NameInMap("HostJson")]
        [Validation(Required=false)]
        public string HostJson { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        [NameInMap("IsTrial")]
        [Validation(Required=false)]
        public bool? IsTrial { get; set; }

        [NameInMap("LicenseCode")]
        [Validation(Required=false)]
        public string LicenseCode { get; set; }

        [NameInMap("Modules")]
        [Validation(Required=false)]
        public List<DescribeImageInstanceForIsvResponseBodyModules> Modules { get; set; }
        public class DescribeImageInstanceForIsvResponseBodyModules : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Properties")]
            [Validation(Required=false)]
            public List<DescribeImageInstanceForIsvResponseBodyModulesProperties> Properties { get; set; }
            public class DescribeImageInstanceForIsvResponseBodyModulesProperties : TeaModel {
                [NameInMap("DisplayUnit")]
                [Validation(Required=false)]
                public string DisplayUnit { get; set; }

                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PropertyValues")]
                [Validation(Required=false)]
                public List<DescribeImageInstanceForIsvResponseBodyModulesPropertiesPropertyValues> PropertyValues { get; set; }
                public class DescribeImageInstanceForIsvResponseBodyModulesPropertiesPropertyValues : TeaModel {
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public string Max { get; set; }

                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public string Min { get; set; }

                    [NameInMap("Remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    [NameInMap("Step")]
                    [Validation(Required=false)]
                    public string Step { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("ShowType")]
                [Validation(Required=false)]
                public string ShowType { get; set; }

            }

        }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        [NameInMap("ProductSkuCode")]
        [Validation(Required=false)]
        public string ProductSkuCode { get; set; }

        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("RelationalData")]
        [Validation(Required=false)]
        public DescribeImageInstanceForIsvResponseBodyRelationalData RelationalData { get; set; }
        public class DescribeImageInstanceForIsvResponseBodyRelationalData : TeaModel {
            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public string ServiceStatus { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SupplierName")]
        [Validation(Required=false)]
        public string SupplierName { get; set; }

    }

}
